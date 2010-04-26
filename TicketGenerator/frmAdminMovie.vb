Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
'''
''' <summary>
''' Admin form - create Movie.
''' </summary>
''' <author>Sebastian Nemček</author>
'''
Public Class frmAdminMovie

    Dim strMessage As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click

        Dim strName As String = Me.txtMovieName.Text
        Dim strYear As String = Me.txtYear.Text
        Dim strVersion As String = Me.cbVersion.Text
        Dim strPG As String = Me.cbPG.Text
        Dim strLength As String = Me.txtLength.Text



        If Not frmCheck(strName, strYear, strVersion, strPG, strLength) Then
            MessageBox.Show(strMessage)
        Else

            Dim con As New OracleConnection
            'Dim strCheckingUsername As String
            Dim sql As String = "INSERT INTO MOVIE VALUES ('" & strLength & "','" & strVersion & "','" & strYear & "','" & strName & "', null,'" _
                                                            & strPG & "')"
            Dim cmd As OracleCommand = New OracleCommand(sql, con)

            Try
                con.ConnectionString = Config.dbCONstr
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

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            cmd.CommandType = CommandType.Text

            MessageBox.Show("New Movie added to the Database.", "Operation Successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Close()

            con.Close()

            'frmAdmin.MOVIETableAdapter.Fill(DataSetTG.Tables("MOVIE"))
            'frmAdmin.MOVIEBindingSource.ResetBindings(False)

        End If
    End Sub

    Private Function frmCheck(ByVal strName As String, ByVal strYear As String, ByVal strVersion As String, ByVal strPG As String, ByVal _
                              strLength As String) As Boolean
        If strName = "" Then
            strMessage = "Name, "
        End If
        If strYear = "" Then
            strMessage = strMessage & "Year, "
        End If
        If strVersion = "" Then
            strMessage = strMessage & "Version, "
        End If
        If strLength = "" Then
            strMessage = strMessage & "Length, "
        End If
        If strPG = "" Then
            strMessage = strMessage & "PG, "
        End If
        
        If strMessage = "" Then
            frmCheck = True
        Else
            MsgBox(strMessage & "cannot be empty!")
            frmCheck = False
            strMessage = ""
        End If

    End Function
End Class