'''
''' <summary>
''' Admin form - create Cinema.
''' </summary>
''' <author>Sebastian Nemček</author>
'''
Public Class frmNewCinema

    Private Sub CINEMABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CINEMABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CINEMABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTG)

    End Sub

    Private Sub frmNewCinema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTG.CINEMA' table. You can move, or remove it, as needed.
        Me.CINEMATableAdapter.Fill(Me.DataSetTG.CINEMA)

    End Sub


End Class