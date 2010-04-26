'TODO: Ak je predstavenie FULL -> cervenou farbou a neklikatelne
Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
'''
''' <summary>
''' UserControl for choose movie by user.
''' </summary>
''' <author>Matej Paulech</author>
'''
Public Class ucOrderChoiceMovie
    Private weekDates(7) As Date 'Pole v ktorom su ulozene datumi (dnesok+6 dalsich dni)
    Private selectedDay As Integer 'Poradie aktualneho dna (v poli ^^^)
    Dim actLbl As Label 'Aktualny vybany label s dnom

    Dim movies As New ArrayList 'Pole s eventami (kazdy prvok = 1 riadok)

    'Konstantne nastavenia
    Private lblDayColor As Color = Color.FromArgb(0, 227, 255)
    Private lblDayFontColor As Color = Color.DimGray
    Private lblDayActiveColor As Color = Color.DeepSkyBlue
    Private lblDayFontActiveColor As Color = Color.Black

    Private Sub ucOrderChoiceMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectCmbChoiceCinemaWithDB()

        initializeDays()
        initializeDayLabels()
        selectedDay = 0
        actLbl = lblDay1
        lblDate.Text = weekDates(0)
    End Sub

    'Spoji ComboBox na vyber kina s DB
    Private Sub connectCmbChoiceCinemaWithDB()
        Dim con As OracleConnection = New OracleConnection
        con.ConnectionString = Config.dbCONstr
        Dim sql As String = "SELECT * FROM CINEMA"
        Dim cmd As OracleCommand = New OracleCommand(sql, con)

        Try
            con.Open()
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

        Dim da As OracleDataAdapter = New OracleDataAdapter(cmd)
        Dim cb As OracleCommandBuilder = New OracleCommandBuilder(da)
        Dim ds As DataSet = New DataSet

        da.Fill(ds)

        With Me.cmbChooseCinema
            .DataSource = ds.Tables(0)
            .DisplayMember = "NAME"
            .ValueMember = "CINEMA_ID"
            .Text = "Choice Cinema"
        End With
        AddHandler Me.cmbChooseCinema.SelectedIndexChanged, AddressOf GenerateProgram
    End Sub

    'Nahadze do pola datumy od dneska do dnesok+6
    Private Sub initializeDays()
        For i As Integer = 0 To 6
            weekDates(i) = Today.AddDays(i)
        Next
    End Sub

#Region "lblDays"
    ''Nahodi do labelov nazvy dni od dnesneho (az po +6)
    Private Sub initializeDayLabels()
        lblDay1.Text = weekDates(0).DayOfWeek.ToString
        lblDay2.Text = weekDates(1).DayOfWeek.ToString
        lblDay3.Text = weekDates(2).DayOfWeek.ToString
        lblDay4.Text = weekDates(3).DayOfWeek.ToString
        lblDay5.Text = weekDates(4).DayOfWeek.ToString
        lblDay6.Text = weekDates(5).DayOfWeek.ToString
        lblDay7.Text = weekDates(6).DayOfWeek.ToString
    End Sub

    ''Pri prejdeni na label s dnom sa stmavy
    Private Sub lblDay_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDay7.MouseHover, lblDay6.MouseHover, lblDay5.MouseHover, lblDay4.MouseHover, lblDay3.MouseHover, lblDay2.MouseHover, lblDay1.MouseHover
        Dim lbl As Label = sender
        lbl.ForeColor = Color.Black
        lbl.BackColor = Color.DeepSkyBlue
    End Sub

    ''Pri odideni z labelu s dnom sa zbledne
    Private Sub lblDay_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDay7.MouseLeave, lblDay6.MouseLeave, lblDay5.MouseLeave, lblDay4.MouseLeave, lblDay3.MouseLeave, lblDay2.MouseLeave, lblDay1.MouseLeave
        Dim lbl As Label = sender
        If lbl.Text <> weekDates(selectedDay).DayOfWeek.ToString Then
            lbl.ForeColor = Color.DimGray
            lbl.BackColor = Color.FromArgb(0, 227, 255)
        End If
    End Sub

    ''Pri kliknuti na den musi zmenit farby atd...
    Private Sub lblDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDay7.Click, lblDay6.Click, lblDay5.Click, lblDay4.Click, lblDay3.Click, lblDay2.Click, lblDay1.Click
        Dim newLbl As Label = sender

        If newLbl.Text.Equals(actLbl.Text) Then
            Exit Sub
        End If

        actLbl.ForeColor = lblDayFontColor
        actLbl.BackColor = lblDayColor
        newLbl.ForeColor = lblDayFontActiveColor
        newLbl.BackColor = lblDayActiveColor

        actLbl = newLbl
        selectedDay = CInt(newLbl.Tag)
        lblDate.Text = weekDates(selectedDay)
        Me.panBlue.Left = newLbl.Left


        GenerateProgram()
    End Sub
#End Region

#Region "GenerateProgram"
    Private Sub lblMovieTimeAdd(ByRef inLabel As Label, ByVal inTime As String)
        inLabel.Text = inTime
        inLabel.BackColor = Color.FromArgb(5, 56, 121)
        inLabel.Cursor = Cursors.Hand
    End Sub

    Private Sub GenerateProgram()
        Debug.Print("gen " & CInt(Rnd(100) * 100)) 'TODO: zmazat
        ''Delete old events
        For Each rmMovie As UserControls In movies
            Me.panEvent.Controls.Remove(rmMovie.pnlMovie)
        Next
        movies.Clear()

        ''Generate new events
        'Connection
        Dim con As New OracleConnection
        con.ConnectionString = Config.dbCONstr
        'Command
        Dim sql As String = "SELECT DISTINCT event.movie_id, event.hall_id, movie.movie_name, movie.version, movie.length, movie.parents_guide, event.time FROM event, movie WHERE (event.movie_id = movie.movie_id) AND (cinema_id= :cinema_id) AND (adate= :adate) ORDER BY movie_name, hall_id"
        Dim cmd As New OracleCommand(sql, con)
        cmd.CommandType = CommandType.Text
        'Parameter
        Dim p_cinema_id As OracleParameter = New OracleParameter
        p_cinema_id.OracleDbType = OracleDbType.Int16
        p_cinema_id.Value = Me.cmbChooseCinema.SelectedValue
        cmd.Parameters.Add(p_cinema_id)
        Dim p_adate As OracleParameter = New OracleParameter
        p_adate.OracleDbType = OracleDbType.Date
        p_adate.Value = weekDates(selectedDay)
        cmd.Parameters.Add(p_adate)

        Dim movie As UserControls = New UserControls
        Dim movieID As Integer = -1
        Dim hallID As Integer = -1
        Dim i As Integer = 0
        Dim hour As String

        Try
            con.Open()
            Dim dr As OracleDataReader = cmd.ExecuteReader
            While (dr.Read())
                If (hallID <> dr.Item("HALL_ID")) Or (movieID <> dr.Item("MOVIE_ID")) Then
                    movieID = dr.Item("MOVIE_ID")
                    hallID = dr.Item("HALL_ID")

                    i = movies.Add(New UserControls)
                    movie = movies.Item(i)

                    movie.lblHall.Text = Trim(dr.Item("HALL_ID"))
                    movie.lblMovie.Text = Trim(dr.Item("MOVIE_NAME"))
                    movie.lblLength.Text = Trim(dr.Item("LENGTH"))
                    movie.lblVersion.Text = Trim(dr.Item("VERSION"))
                    movie.lblParental.Text = Trim(dr.Item("PARENTS_GUIDE"))

                    movie.pnlMovie.Top = (36 * i)
                    movie.pnlMovie.Left = 0
                    Me.panEvent.Controls.Add(movie.pnlMovie)
                End If

                hour = Strings.Left(dr.Item("TIME"), 2)
                Select Case hour
                    Case "10"
                        lblMovieTimeAdd(movie.lblH10, dr.Item("TIME"))
                    Case "11"
                        lblMovieTimeAdd(movie.lblH11, dr.Item("TIME"))
                    Case "12"
                        lblMovieTimeAdd(movie.lblH12, dr.Item("TIME"))
                    Case "13"
                        lblMovieTimeAdd(movie.lblH13, dr.Item("TIME"))
                    Case "14"
                        lblMovieTimeAdd(movie.lblH14, dr.Item("TIME"))
                    Case "15"
                        lblMovieTimeAdd(movie.lblH15, dr.Item("TIME"))
                    Case "16"
                        lblMovieTimeAdd(movie.lblH16, dr.Item("TIME"))
                    Case "17"
                        lblMovieTimeAdd(movie.lblH17, dr.Item("TIME"))
                    Case "18"
                        lblMovieTimeAdd(movie.lblH18, dr.Item("TIME"))
                    Case "19"
                        lblMovieTimeAdd(movie.lblH19, dr.Item("TIME"))
                    Case "20"
                        lblMovieTimeAdd(movie.lblH20, dr.Item("TIME"))
                    Case "21"
                        lblMovieTimeAdd(movie.lblH21, dr.Item("TIME"))
                    Case "22"
                        lblMovieTimeAdd(movie.lblH22, dr.Item("TIME"))
                End Select
            End While
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

        ''Nastavenie velkost panelov podla toho, ci sa vytvorili komponenty
        If movies.Count < 1 Then
            lblNotEvent.Visible = True
            Me.panEvents.Height = 80
        Else
            lblNotEvent.Visible = False
            Me.panEvents.Height = 50 + ((i + 1) * 36)
            Me.panEvent.Height = (i + 1) * 36
        End If
        Me.Height = Me.Height + Me.panEvent.Height
    End Sub
#End Region
End Class
