Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
'''
''' <summary>
''' Admin form - create Order.
''' </summary>
''' <author>Sebastian Nemček</author>
'''
Public Class frmAdminOrder

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub frmAdminOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTG.AUSER' table. You can move, or remove it, as needed.
        Me.AUSERTableAdapter.Fill(Me.DataSetTG.AUSER)

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        If txtTotal.Text = "" Then
            MessageBox.Show("Please input value for total")
        Else

            Dim con As New OracleConnection
            'Dim strCheckingUsername As String
            Dim sql As String = "INSERT INTO AORDER VALUES (null, null, '" & cbUser.Text & "', '" & txtTotal.Text & "')"
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

            MessageBox.Show("New Order added to the Database.", "Operation Successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Close()

            con.Close()
            
        End If


    End Sub
End Class