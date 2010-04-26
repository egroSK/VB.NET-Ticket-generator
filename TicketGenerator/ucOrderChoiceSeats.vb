'TODO: Doplnit exceptions ku vsekym pristupom ku OracleDataReaderu!
Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
'''
''' <summary>
''' UserControl for choose seats by user.
''' </summary>
''' <author>Matej Paulech</author>
'''
Public Class ucOrderChoiceSeats
    'Constants
    Private imgChecked As Image = My.Resources.checked
    Private imgUnChecked As Image = My.Resources.unchecked
    Private imgFull As Image = My.Resources.full
    Private labelsFont As Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    'Seats - Array of checkboxes
    Private minRow As Integer = 0 'rad A
    Private maxRow As Integer = 10 'rad K
    Private minColumn As Integer = 0 'sedadlo 1
    Private maxColumn As Integer = 19 'sedadlo 20
    Private arrSeats(maxRow, maxColumn) As CheckBox
    Private labelsLeft(maxRow) As Label
    Private labelsRight(maxRow) As Label

    Dim inEvent_id As Integer = 2 'TODO << DELETE
    'Dim inEvent_id As Integer = 3

    Dim arrCountSeats As New Hashtable


    Private Sub ucOrderChoiceSeats_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblSetSeats.Text = 0

        fillEventInformation()

        seatsBounds()

        If inEvent_id = 3 Then  'TODO: delete
            maxRow += 1
        End If

        createSeats()
        enableAvailableSeats()
        disableFullSeats()
        createTags()
    End Sub

    Private Function runQuery(ByVal sql As String) As OracleDataReader
        'Connection
        Dim con As New OracleConnection
        con.ConnectionString = Config.dbCONstr
        'Command
        Dim cmd As New OracleCommand(Sql, con)
        cmd.CommandType = CommandType.Text
        'Parameter {vsade potrebujem event_id (preto napevno)}
        Dim p_event_id As OracleParameter = New OracleParameter
        p_event_id.OracleDbType = OracleDbType.Int16
        p_event_id.Value = inEvent_id
        cmd.Parameters.Add(p_event_id)
        'DataReader
        Dim dr As OracleDataReader = Nothing

        Try
            con.Open()
            dr = cmd.ExecuteReader
        Catch ex As OracleException ' catches only Oracle errors
            Select Case ex.Number
                Case 12560
                    MessageBox.Show("The database is unavailable.")
                Case 12514
                    MessageBox.Show("The database is unavailable.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("Database error: " + ex.Message.ToString(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Select
        End Try

        Return dr
    End Function


    Private Sub fillEventInformation()
        Dim sql As String = "SELECT movie.movie_name, event.adate, event.time FROM event, movie WHERE (movie.movie_id = event.movie_id) AND (event.event_id = :event_id)"
        Dim dr As OracleDataReader = runQuery(sql)
        If dr.HasRows Then
            dr.Read()
            lblMovie.Text = dr.Item("MOVIE_NAME")
            lblDate.Text = dr.Item("ADATE")
            lblTime.Text = dr.Item("TIME")
        End If
    End Sub

#Region "Generate seats"
    Private Sub seatsBounds()
        Dim sql As String = "SELECT MIN(AROW), MAX(AROW), MIN(ANUMBER), MAX(ANUMBER) FROM (SELECT arow, anumber FROM seat WHERE (cinema_id = (SELECT cinema_id FROM event WHERE (event_id = :event_id))) AND (hall_id = (SELECT hall_id FROM event WHERE (event_id = :event_id))))"
        Dim dr As OracleDataReader = runQuery(sql)
        If dr.HasRows Then
            dr.Read()
            minRow = dr.Item("MIN(AROW)")
            maxRow = dr.Item("MAX(AROW)") ' + 1 'Delete ak je problem s poctom riadkov
            minColumn = dr.Item("MIN(ANUMBER)")
            maxColumn = dr.Item("MAX(ANUMBER)")
        End If
        Debug.Print("minRow " & minRow)
        Debug.Print("maxRow " & maxRow)
        Debug.Print("minColumn " & minColumn)
        Debug.Print("maxColumn " & maxColumn)
        arrCountSeats.Add("minRow", minRow)       'TODO: Delete
        arrCountSeats.Add("maxRow", maxRow)
        arrCountSeats.Add("minColumn", minColumn)
        arrCountSeats.Add("maxColumn", maxColumn)
    End Sub

    Private Sub createSeats()
        For i As Integer = minRow To maxRow
            For j As Integer = minColumn To maxColumn
                arrSeats(i, j) = New CheckBox()
                arrSeats(i, j).Visible = False
                arrSeats(i, j).Enabled = False
                arrSeats(i, j).Checked = False
                arrSeats(i, j).Width = 26
                arrSeats(i, j).Height = 26
                arrSeats(i, j).Left = (j - minColumn) * 30 'leftCorrection
                arrSeats(i, j).Top = (i - minRow) * 30 'topCorrection
                arrSeats(i, j).Appearance = Appearance.Button
                arrSeats(i, j).Image = imgUnChecked
                AddHandler arrSeats(i, j).CheckedChanged, AddressOf arrSeats_CheckedChanged
                panSeats.Controls.Add(arrSeats(i, j))
            Next j
        Next i
        panSeats.Width = 30 * (maxColumn - minColumn + 1)
        panSeats.Height = 30 * (maxRow - (minRow) + 1)
        'CenterPanel On a Form
        panSeats.Left = (Me.Width - panInfo.Width - panSeats.Width) / 2
        lblTProjScreen.Left = (Me.Width - panInfo.Width - lblTProjScreen.Width) / 2
        panBottom.Top = panSeats.Top + panSeats.Height + 10
    End Sub

    Private Sub enableAvailableSeats()
        Dim sql As String = "SELECT arow, anumber FROM seat WHERE (cinema_id = (SELECT cinema_id FROM event WHERE (event_id = :event_id))) AND (hall_id = (SELECT hall_id FROM event WHERE (event_id = :event_id)))"
        Dim dr As OracleDataReader = runQuery(sql)

        While (dr.Read())
            arrSeats(dr.Item("AROW"), dr.Item("ANUMBER")).Visible = True
            arrSeats(dr.Item("AROW"), dr.Item("ANUMBER")).Enabled = True
        End While
    End Sub

    Private Sub disableFullSeats()
        Dim sql As String = "SELECT arow, anumber FROM soticket WHERE (event_id = :event_id)"
        Dim dr As OracleDataReader = runQuery(sql)

        While (dr.Read())
            arrSeats(dr.Item("AROW"), dr.Item("ANUMBER")).Image = imgFull
            arrSeats(dr.Item("AROW"), dr.Item("ANUMBER")).Enabled = False
        End While
    End Sub


    Private Function createLabel(ByRef inRow As Integer, ByRef inRowTag As Integer, ByRef inLeft As Integer) As Label
        Dim lbl As Label
        lbl = New Label()
        lbl.Text = Chr(65 + inRowTag)
        lbl.Left = inLeft
        lbl.Top = panSeats.Top + 4 + (inRow * 30)
        lbl.AutoSize = True
        lbl.Font = labelsFont
        lbl.Cursor = Cursors.Hand
        lbl.Tag = inRow
        Me.ToolTip.SetToolTip(lbl, "Check/UnCheck row")
        AddHandler lbl.Click, AddressOf lblRow_Click
        Return lbl
    End Function

    Private Sub createTags()
        Dim cRow As Integer = 0
        Dim cColumn As Integer = 0

        For i As Integer = minRow To maxRow
            For j As Integer = minColumn To maxColumn
                If arrSeats(i, j).Visible Then
                    cColumn += 1
                    arrSeats(i, j).Tag = Chr(65 + cRow) & cColumn
                    Me.ToolTipSeats.SetToolTip(arrSeats(i, j), arrSeats(i, j).Tag)
                End If
            Next j

            If cColumn > 1 Then
                'Create labels
                labelsLeft(i) = createLabel(i, cRow, panSeats.Left - 20)
                Me.Controls.Add(labelsLeft(i))
                labelsRight(i) = createLabel(i, cRow, panSeats.Left + panSeats.Width)
                Me.Controls.Add(labelsRight(i))
                'Set counters
                cColumn = 0
                cRow += 1
            End If
        Next i
    End Sub
#End Region

#Region "Events"
    Private Sub arrSeats_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim chk As CheckBox = sender
        If chk.Checked Then
            chk.Image = imgChecked
            lblSetSeats.Text = CStr(CInt(lblSetSeats.Text) + 1)
        Else
            chk.Image = imgUnChecked
            lblSetSeats.Text = CStr(CInt(lblSetSeats.Text) - 1)
        End If
    End Sub

    Private Sub changeCheckedRow(ByRef inRow As Integer, ByRef inChecked As Boolean)
        For i As Integer = minColumn To maxColumn
            If arrSeats(inRow, i).Enabled Then
                arrSeats(inRow, i).Checked = inChecked
            End If
        Next
    End Sub

    Private Sub lblRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim inLbl As Label = sender
        Dim inRow As Integer = inLbl.Tag
        Dim checkedCount As Integer = 0
        Dim couldCheckCount As Integer = 0

        'Zisti, ci su zaceknute vsetky co sa daju zaceknut...
        For i As Integer = minColumn To maxColumn
            If arrSeats(inRow, i).Checked Then
                checkedCount += 1
            End If
            If arrSeats(inRow, i).Enabled Then
                couldCheckCount += 1
            End If
        Next i

        '...ak ano, vsetko odcekne; ak nie, docekuje chybajuce
        If checkedCount = couldCheckCount Then
            changeCheckedRow(inRow, False)
        Else
            changeCheckedRow(inRow, True)
        End If
    End Sub

    Private Sub picUnchecked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUnchecked.Click
        For i As Integer = minRow To maxRow
            changeCheckedRow(i, False)
        Next
    End Sub

    Private Sub picChecked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picChecked.Click
        For i As Integer = minRow To maxRow
            changeCheckedRow(i, True)
        Next
    End Sub
#End Region

    Public Function getArrSeats() As Array
        Return arrSeats
    End Function

    Public Function geCountSeats() As Hashtable
        Return arrCountSeats
    End Function

End Class