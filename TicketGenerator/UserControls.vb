'''
''' <summary>
''' Special component - row with information about one movie.
''' </summary>
''' <author>Matej Paulech</author>
'''
Public Class UserControls
    Private lblFillColor As Color = Color.FromArgb(5, 56, 121)
    Private lblClearColor As Color = Color.FromArgb(92, 124, 166)
    Private lblFillHoverColor As Color = Color.FromArgb(199, 7, 9)
    Private lblClearHoverColor As Color = Color.FromArgb(217, 106, 107)

    Private Sub lblHourHoverColor(ByRef inLabel As Label)
        If (inLabel.Text.Length < 1) Then
            inLabel.BackColor = lblClearHoverColor
        Else
            inLabel.BackColor = lblFillHoverColor
        End If
    End Sub

    Private Sub lblHourColor(ByRef inLabel As Label)
        If (inLabel.Text.Length < 1) Then
            inLabel.BackColor = lblClearColor
        Else
            inLabel.BackColor = lblFillColor
        End If
    End Sub

    Private Sub lblPnlMovie_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVersion.MouseHover, lblParental.MouseHover, lblMovie.MouseHover, lblLength.MouseHover, lblHall.MouseHover, lblH22.MouseHover, lblH21.MouseHover, lblH20.MouseHover, lblH19.MouseHover, lblH18.MouseHover, lblH17.MouseHover, lblH16.MouseHover, lblH15.MouseHover, lblH14.MouseHover, lblH13.MouseHover, lblH12.MouseHover, lblH11.MouseHover, lblH10.MouseHover, pnlMovie.MouseHover
        lblHall.BackColor = lblFillHoverColor
        lblMovie.BackColor = lblFillHoverColor
        lblVersion.BackColor = lblFillHoverColor
        lblLength.BackColor = lblFillHoverColor
        lblParental.BackColor = lblFillHoverColor

        lblHourHoverColor(lblH10)
        lblHourHoverColor(lblH11)
        lblHourHoverColor(lblH12)
        lblHourHoverColor(lblH13)
        lblHourHoverColor(lblH14)
        lblHourHoverColor(lblH15)
        lblHourHoverColor(lblH16)
        lblHourHoverColor(lblH17)
        lblHourHoverColor(lblH18)
        lblHourHoverColor(lblH19)
        lblHourHoverColor(lblH20)
        lblHourHoverColor(lblH21)
        lblHourHoverColor(lblH22)
    End Sub

    Private Sub lblPnlMovie_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVersion.MouseLeave, lblParental.MouseLeave, lblMovie.MouseLeave, lblLength.MouseLeave, lblHall.MouseLeave, lblH22.MouseLeave, lblH21.MouseLeave, lblH20.MouseLeave, lblH19.MouseLeave, lblH18.MouseLeave, lblH17.MouseLeave, lblH16.MouseLeave, lblH15.MouseLeave, lblH14.MouseLeave, lblH13.MouseLeave, lblH12.MouseLeave, lblH11.MouseLeave, lblH10.MouseLeave, pnlMovie.MouseLeave
        lblHall.BackColor = lblFillColor
        lblMovie.BackColor = lblFillColor
        lblVersion.BackColor = lblFillColor
        lblLength.BackColor = lblFillColor
        lblParental.BackColor = lblFillColor

        lblHourColor(lblH10)
        lblHourColor(lblH11)
        lblHourColor(lblH12)
        lblHourColor(lblH13)
        lblHourColor(lblH14)
        lblHourColor(lblH15)
        lblHourColor(lblH16)
        lblHourColor(lblH17)
        lblHourColor(lblH18)
        lblHourColor(lblH19)
        lblHourColor(lblH20)
        lblHourColor(lblH21)
        lblHourColor(lblH22)
    End Sub
End Class
