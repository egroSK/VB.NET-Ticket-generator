'''
''' <summary>
''' Form for create new order (by user).
''' </summary>
''' <author>Matej Paulech</author>
'''
Public Class frmOrder
    Dim ucChoiceMovie As ucOrderChoiceMovie = New ucOrderChoiceMovie
    Dim ucChoiceSeats As ucOrderChoiceSeats = New ucOrderChoiceSeats
    Dim ucChoiceTickets As ucOrderChoiceTicket = New ucOrderChoiceTicket(ucChoiceSeats.getArrSeats, ucChoiceSeats.geCountSeats)
    'Dim ucChoiceTickets As ucOrderChoiceTicket = New ucOrderChoiceTicket(ucChoiceSeats.getPanSeats)


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panTop.Paint

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panMain.Paint

    End Sub

    Private Sub frmOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Panel2.Controls.Add(ucChoiceMovie)
        'Me.Width = ucChoiceMovie.Width

        Me.panMain.Controls.Add(ucChoiceSeats)
        Me.Width = ucChoiceSeats.Width
        Me.Height = Me.panTop.Height + ucChoiceSeats.Height
        'Me.panMain.Controls.Remove(ucChoiceSeats)





        ' Me.panMain.Controls.Add(ucChoiceTickets)
        'Me.Width = ucChoiceTickets.Width
        'Me.Height = Me.panTop.Height + ucChoiceTickets.Height
    End Sub
End Class