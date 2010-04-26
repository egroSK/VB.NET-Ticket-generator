''' <summary>
''' Admin form - operations with database.
''' </summary>
''' <author>Sebastian Nemček</author>
Public Class frmAdmin

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTG._EVENT' table. You can move, or remove it, as needed.
        Me.EVENTTableAdapter.Fill(Me.DataSetTG._EVENT)
        'TODO: This line of code loads data into the 'DataSetTG.CINEMA' table. You can move, or remove it, as needed.
        Me.CINEMATableAdapter.Fill(Me.DataSetTG.CINEMA)
        'TODO: This line of code loads data into the 'DataSetTG.MOVIE' table. You can move, or remove it, as needed.
        Me.MOVIETableAdapter.Fill(Me.DataSetTG.MOVIE)
        'TODO: This line of code loads data into the 'DataSetTG.SOTICKET' table. You can move, or remove it, as needed.
        Me.SOTICKETTableAdapter.Fill(Me.DataSetTG.SOTICKET)
        'TODO: This line of code loads data into the 'DataSetTG.ORDER' table. You can move, or remove it, as needed.
        Me.AORDERTableAdapter.Fill(Me.DataSetTG.AORDER)
        'TODO: This line of code loads data into the 'DataSetTG.AUSER' table. You can move, or remove it, as needed.
        Me.AUSERTableAdapter.Fill(Me.DataSetTG.AUSER)


    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Dim answer As Integer = MessageBox.Show("Do you really want to quit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If answer = vbNo Then
        Else
            End
            frmLogin.Dispose()
        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
        frmLogin.txtUser.Focus()
    End Sub

    '***************************************
    'USER TAB
    '***************************************

    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click
        frmNewUser.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Me.AUSERTableAdapter.Fill(DataSetTG.Tables("AUSER"))
        Me.AUSERBindingSource.ResetBindings(False)
    End Sub

    Private Sub btnSaveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUser.Click
        Me.Validate()
        Me.AUSERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTG)
        MessageBox.Show("Changes saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    '***************************************
    'ORDER TAB
    '***************************************

    Private Sub btnCreateNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNewOrder.Click
        frmAdminOrder.Show()
    End Sub

    Private Sub btnUpdateOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateOrders.Click
        Me.AORDERTableAdapter.Fill(DataSetTG.Tables("AORDER"))
        Me.AORDERBindingSource.ResetBindings(False)
    End Sub


    '***************************************
    'MOVIE TAB
    '***************************************

    Private Sub btnNewMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMovie.Click
        frmAdminMovie.Show()
    End Sub

    Private Sub btnUpdateMovies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateMovies.Click
        Me.MOVIETableAdapter.Fill(DataSetTG.Tables("MOVIE"))
        Me.MOVIEBindingSource.ResetBindings(False)
    End Sub

    Private Sub btnSaveMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMovie.Click
        Me.Validate()
        Me.MOVIEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTG)
        MessageBox.Show("Changes saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    '***************************************
    'TICKET TAB
    '***************************************
    Private Sub btnUpdateTickets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateTickets.Click
        Me.SOTICKETTableAdapter.Fill(DataSetTG.Tables("SOTICKET"))
        Me.SOTICKETBindingSource.ResetBindings(False)
    End Sub
End Class