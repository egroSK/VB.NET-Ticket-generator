Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
'''
''' <summary>
''' Old user form.
''' </summary>
''' <author>Sebastian Nemček</author>
'''
Public Class frmHome

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim answer As Integer = MessageBox.Show("Do you really want to quit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If answer = vbNo Then
        Else
            End
        End If

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Dispose()
        frmLogin.txtUser.Focus()

    End Sub

    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTG._EVENT' table. You can move, or remove it, as needed.
        Me.EVENTTableAdapter.Fill(Me.DataSetTG._EVENT)
        'TODO: This line of code loads data into the 'DataSetTG.MOVIE' table. You can move, or remove it, as needed.
        Me.MOVIETableAdapter.Fill(Me.DataSetTG.MOVIE)
        'TODO: This line of code loads data into the 'DataSetTG.CINEMA' table. You can move, or remove it, as needed.
        Me.CINEMATableAdapter.Fill(Me.DataSetTG.CINEMA)
        'Call loadCinemas()

    End Sub

    Private Sub loadCinemas()
        Dim con As New OracleConnection
        Dim dr As DataRow
        Dim sql As String = "SELECT NAME FROM CINEMA"
        Dim cmd As OracleCommand = New OracleCommand(sql, con)
        Dim itemDA As OracleDataAdapter = New OracleDataAdapter()
        itemDA.SelectCommand = cmd
        con.ConnectionString = Config.dbCONstr
        Dim orderDS As DataSet = New DataSet()

        Try
            con.Open()
            itemDA.Fill(orderDS, "CINEMA")

            MsgBox("DB openened")
            con.Close()
        Catch ex As OracleException ' catches only Oracle errors
            Select Case ex.Number
                Case 12560
                    MessageBox.Show("The database is unavailable.")
                Case Else
                    MessageBox.Show("Database error: " + ex.Message.ToString(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Select

        End Try

        For Each dr In orderDS.Tables("CINEMA").Rows
            cbCinema.Items.Add(dr.Item("NAME"))

        Next

    End Sub

    Private Sub CINEMABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CINEMABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTG)

    End Sub
End Class