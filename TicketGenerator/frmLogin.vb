Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
'''
''' <summary>
''' Login form - log in user to system.
''' </summary>
''' <author>Sebastian Nemček, Matej Paulech</author>
'''
Public Class frmLogin
    Dim TDES As New TripleDES

    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click
        frmNewUser.Show()
    End Sub

    Private Function isEmpty(ByVal inStr As String) As Boolean
        isEmpty = (inStr.Length < 1)
    End Function

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim strUsername As String = Trim(Me.txtUser.Text)
        Dim strPassword As String = Trim(Me.txtPassword.Text)

        If isEmpty(strUsername) Then
            MessageBox.Show("Please fill an username.", "Username is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtUser.Focus()
            Exit Sub
        End If

        If isEmpty(strPassword) Then
            MessageBox.Show("Please fill an password.", "Password is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtPassword.Focus()
            Exit Sub
        End If

        ''Database
        'Connection
        Dim con As New OracleConnection
        con.ConnectionString = Config.dbCONstr
        'Command
        Dim sql As String = "SELECT * FROM AUSER where user_id = :user_id"
        Dim cmd As New OracleCommand(sql, con)
        cmd.CommandType = CommandType.Text
        'Parameter
        Dim p_user_id As OracleParameter = New OracleParameter
        p_user_id.OracleDbType = OracleDbType.Varchar2
        p_user_id.Value = strUsername.ToUpper
        cmd.Parameters.Add(p_user_id)

        'Retrieve informations from DB
        Dim dbUserExists As Boolean = False
        Dim dbUserPass As String = ""
        Dim dbIsAdmin As Boolean = False

        Try
            con.Open()
            Dim dr As OracleDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                dbUserExists = True
                dbUserPass = TDES.Decrypt(dr.Item("PASSWORD"))
                dbIsAdmin = dr.Item("ADMIN")
            End If
            con.Dispose()
        Catch ex As OracleException ' catches only Oracle errors
            Select Case ex.Number
                Case 12560
                    MessageBox.Show("The database is unavailable.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 12514
                    MessageBox.Show("The database is unavailable.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("Database error: " + ex.Message.ToString(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Select
        End Try

        'Check if user exists
        If Not dbUserExists Then
            MessageBox.Show("User doesn't exists.", "Wrong UserName", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtUser.Focus()
            Exit Sub
        End If

        'Check if is Password OK
        If Not dbUserPass.Equals(strPassword) Then
            MessageBox.Show("Incorrect Password.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtPassword.Focus()
            Exit Sub
        End If

        'Check if is Admin and open Form
        If dbIsAdmin Then
            frmAdmin.Show()
            Me.txtPassword.Text = ""
            Me.txtUser.Text = ""
            Me.Visible = False
        Else
            frmHome.Show()
            frmHome.lblUsername.Text = strUsername
            Me.txtPassword.Text = ""
            Me.txtUser.Text = ""
            Me.Visible = False
        End If
    End Sub
End Class
