'TODO: zmenit aby bolo nezavisle od komponent
Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
'''
''' <summary>
''' Register new user to system.
''' </summary>
''' <author>Sebastian Nemček</author>
'''
Public Class frmNewUser
    Dim clrBackColor As Color = Color.Coral
    Dim TDES As New TripleDES()

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Are you sure?", "Close windows?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click
        Dim strName As String = Me.txtName.Text
        Dim strSurname As String = Me.txtSurname.Text
        Dim strUsername As String = Me.txtUsername.Text
        Dim strPassword As String = Me.txtPassword.Text
        Dim strCPassword As String = Me.txtCPassword.Text
        Dim strEmail As String = Me.txtEmail.Text
        Dim strPhone As String = Me.txtPhone.Text
        Dim strAdmin As String

        Me.txtPassword.BackColor = Color.White
        Me.txtCPassword.BackColor = Color.White
        Me.txtUsername.BackColor = Color.White
        Me.txtName.BackColor = Color.White
        Me.txtSurname.BackColor = Color.White
        Me.txtEmail.BackColor = Color.White

        If formCheck(strName, strSurname, strUsername, strPassword, strCPassword, strEmail) Then
            If passwordCheck() Then
                If Me.chkbAdmin.Checked Then
                    strAdmin = 1
                Else
                    strAdmin = 0
                End If
                'checks wheather user already exists, da sa to spravit aj pomocou jednej funkcie ale zatial to neprerabam...
                If SQLusername(strUsername) Then
                    MessageBox.Show("Username is already in use." & vbCrLf & "Please choose a different user name", "", MessageBoxButtons.OK, _
            MessageBoxIcon.Error)
                    Me.txtUsername.BackColor = clrBackColor
                    Me.txtUsername.Focus()
                Else
                    Call createRow(strName, strSurname, strUsername, strPassword, strEmail, strAdmin, strPhone)
                End If
            Else
                MessageBox.Show("Password mismatch" & vbCrLf & "Please set your password again", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtPassword.Text = ""
                Me.txtCPassword.Text = ""
                Me.txtPassword.BackColor = clrBackColor
                Me.txtCPassword.BackColor = clrBackColor
                Me.txtPassword.Focus()
            End If
        End If
    End Sub


    Private Function formCheck(ByVal strName As String, ByVal strSurname As String, ByVal strUsername As String, _
                               ByVal strPassword As String, ByVal strCPassword As String, ByVal strEmail As String) As Boolean
        Dim strMessage As String = ""
        Dim validEmail As String = ""


        If strName = "" Then
            Me.txtName.BackColor = clrBackColor
            strMessage = "Name, "
        End If
        If strSurname = "" Then
            Me.txtSurname.BackColor = clrBackColor
            strMessage = strMessage & "Surname, "
        End If
        If strUsername = "" Then
            Me.txtUsername.BackColor = clrBackColor
            strMessage = strMessage & "Username, "
        End If
        If strPassword = "" Then
            Me.txtPassword.BackColor = clrBackColor
            strMessage = strMessage & "Password, "
        End If
        If strCPassword = "" Then
            Me.txtCPassword.BackColor = clrBackColor
            strMessage = strMessage & "Confirm pasword, "
        End If
        If strEmail = "" Then
            Me.txtEmail.BackColor = clrBackColor
            strMessage = strMessage & "Email, "
        Else
            Dim Expression As New System.Text.RegularExpressions.Regex("\S+@\S+\.\S+")
            If Expression.IsMatch(txtEmail.Text) Then

            Else
                validEmail = "Email address is not valid."
                Me.txtEmail.Focus()
                Me.txtEmail.BackColor = clrBackColor
            End If

        End If


        If strMessage = "" And validEmail = "" Then
            If Me.chkbAdmin.Checked = True Then
                Dim strSystemPass As String
                strSystemPass = InputBox("Input system password.")
                If strSystemPass = "system" Then
                    formCheck = True
                Else
                    formCheck = False
                    MsgBox("Incorrect password")
                End If
            Else
                formCheck = True
            End If

        ElseIf Not strMessage = "" Then
            MsgBox(strMessage & "cannot be empty! " & validEmail)
            formCheck = False
        ElseIf Not validEmail = "" Then
            MsgBox(validEmail)
            formCheck = False

        End If


    End Function

    Private Function passwordCheck() As Boolean
        Dim strPassword As String = Me.txtPassword.Text
        Dim strCPassword As String = Me.txtCPassword.Text

        If strPassword = strCPassword Then
            passwordCheck = True
        Else
            passwordCheck = False
        End If
    End Function

    Private Sub createRow(ByVal strName As String, ByVal strSurname As String, ByVal strUsername As String, ByVal strPassword As String, _
                          ByVal strEmail As String, ByVal strAdmin As String, Optional ByVal strPhone As String = "")

        Dim dsNewRow As DataRow

        dsNewRow = DataSetTG.Tables("AUSER").NewRow()

        dsNewRow.Item("USER_ID") = strUsername.ToUpper
        dsNewRow.Item("NAME") = strName
        dsNewRow.Item("SURNAME") = strSurname
        dsNewRow.Item("EMAIL") = strEmail
        dsNewRow.Item("TEL") = strPhone
        dsNewRow.Item("ADMIN") = strAdmin
        'dsNewRow.Item("PASSWORD") = strPassword
        dsNewRow.Item("PASSWORD") = TDES.Encrypt(strPassword)

        Try
            DataSetTG.Tables("AUSER").Rows.Add(dsNewRow)
            AUSERTableAdapter.Update(DataSetTG)
            If frmAdmin.Created Then
                MessageBox.Show("New Record added to the Database.", "Operation Successful!", _
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("New Record added to the Database." & vbCrLf & "Use your credentials to log in.", "Operation Successful!", _
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            Me.Close()
            If frmAdmin.Created() Then
            Else
                frmLogin.txtUser.Focus()
            End If


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

    End Sub

    Private Function SQLusername(ByVal strUserID As String) As Boolean

        Dim con As New OracleConnection
        Dim strCheckingUsername As String
        Dim sql As String = "SELECT USER_ID FROM AUSER where user_id like" & "'" & strUserID.ToUpper & "'"
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

        While (dr.Read())
            strCheckingUsername = dr.GetString(0)
        End While

        con.Close()
        If Not strCheckingUsername = "" Then
            SQLusername = True
        Else
            SQLusername = False
        End If

    End Function


    Private Sub AUSERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AUSERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTG)

    End Sub

    Private Sub frmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTG.AUSER' table. You can move, or remove it, as needed.
        Me.AUSERTableAdapter.Fill(Me.DataSetTG.AUSER)

    End Sub

End Class