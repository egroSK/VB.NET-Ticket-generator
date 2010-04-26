'''
''' <summary>
''' UserControl for choose ticket type by user.
''' </summary>
''' <author>Matej Paulech</author>
'''
Public Class ucOrderChoiceTicket
    Dim arrSeats(,) As CheckBox
    Dim arrCountSeats As Hashtable
    Private labelsLeft() As Label
    Private labelsRight() As Label
    Private labelsFont As Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))

    Dim m_MouseIsDown As Boolean = False
    Dim tmpArr As New Hashtable
    Private dragLst As ListView



    Public Sub New(ByRef inArrSeats(,) As CheckBox, ByRef inArrCountSeats As Hashtable)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        arrSeats = inArrSeats
        arrCountSeats = inArrCountSeats
    End Sub

    Private Sub ucOrderChoiceTicket_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'tmp set as checked
        arrSeats(3, 5).Checked = True
        arrSeats(3, 6).Checked = True
        arrSeats(3, 7).Checked = True


        createSeats()

        ReDim labelsLeft(arrCountSeats("maxRow"))
        ReDim labelsRight(arrCountSeats("maxRow"))
        createlabels()

    End Sub


    Private Sub createSeats()
        For i As Integer = arrCountSeats("minRow") To arrCountSeats("maxRow")
            For j As Integer = arrCountSeats("minColumn") To arrCountSeats("maxColumn")
                If arrSeats(i, j).Checked = False Then
                    arrSeats(i, j).Enabled = False
                Else
                    arrSeats(i, j).Enabled = True
                    AddHandler arrSeats(i, j).MouseDown, AddressOf seat_MouseDown
                    AddHandler arrSeats(i, j).MouseMove, AddressOf seat_MouseMove
                End If
                panSeats.Controls.Add(arrSeats(i, j))
            Next j
        Next i
        panSeats.Width = 30 * (arrCountSeats("maxColumn") - arrCountSeats("minColumn") + 1)
        panSeats.Height = 30 * (arrCountSeats("maxRow") - arrCountSeats("minRow") + 1)
    End Sub

#Region "Create seatsPanel"
    Private Function createLabel(ByRef inRow As Integer, ByRef inRowTag As Integer, ByRef inLeft As Integer) As Label
        Dim lbl As Label
        lbl = New Label()
        lbl.Text = Chr(65 + inRowTag)
        lbl.Left = inLeft
        lbl.Top = panSeats.Top + 4 + (inRow * 30)
        lbl.AutoSize = True
        lbl.Font = labelsFont
        lbl.Cursor = Cursors.Hand
        lbl.Tag = inRow
        Return lbl
    End Function

    Private Sub createlabels()
        Dim cRow As Integer = 0
        Dim cColumn As Integer = 0

        For i As Integer = arrCountSeats("minRow") To arrCountSeats("maxRow")
            For j As Integer = arrCountSeats("minColumn") To arrCountSeats("maxColumn")
                If arrSeats(i, j).Visible Then
                    cColumn += 1
                End If
            Next j

            If cColumn > 1 Then
                'Create labels
                labelsLeft(i) = createLabel(i, cRow, panSeats.Left - 20)
                Me.Controls.Add(labelsLeft(i))
                labelsRight(i) = createLabel(i, cRow, panSeats.Left + panSeats.Width)
                Me.Controls.Add(labelsRight(i))
                'Set counters
                cColumn = 0
                cRow += 1
            End If
        Next i
    End Sub
#End Region

    Private Sub seat_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        m_MouseIsDown = True
    End Sub

    Private Sub seat_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim chb As CheckBox = sender
        If m_MouseIsDown Then
            chb.DoDragDrop(New DataObject("System.Windows.Forms.CheckBox()", chb), DragDropEffects.Move)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub lstTicketType_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstAdult.DragEnter, lstStudent.DragEnter, lstChild.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.CheckBox()") Or e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lstTicketType_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstAdult.DragDrop, lstStudent.DragDrop, lstChild.DragDrop
        If e.Data.GetDataPresent("System.Windows.Forms.CheckBox()") Then
            Debug.Print("from Panel")
            Dim lst As ListView = sender
            Dim chb As CheckBox = e.Data.GetData("System.Windows.Forms.CheckBox()")

            Dim lstItm As ListViewItem = lst.Items.Add(chb.Tag)
            tmpArr.Add(chb.Tag, chb)
            lstItm.Tag = chb.Tag
            chb.Enabled = False
        ElseIf e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            Debug.Print("from listView")
            Dim dropLst As ListView = sender
            Dim myItem As ListViewItem
            Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")
            Dim i As Integer = 0

            'If Not (dropLst Is dragLst) Then
            For Each myItem In myItems
                ' Add the item to the target list.
                Dim tmpItm As ListViewItem = dropLst.Items.Add(myItems(i).Text)
                tmpItm.Tag = myItems(i).Tag
                ' Remove the item from the source list.
                dragLst.Items.Remove(myItems(i))
                'If dropLst Is dragLst Then
                ' dragLst.Items.Remove(dragLst.SelectedItems.Item(0))
                ' Else
                ' dragLst.Items.Remove(dragLst.SelectedItems.Item(0))
                ' End If
                i = i + 1
            Next
            'End If
        End If

    End Sub


    Private Sub lstTicketType_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAdult.DoubleClick, lstStudent.DoubleClick, lstChild.DoubleClick
        Dim lst As ListView = sender
        If lst.SelectedItems.Count > 0 Then
            Dim lstItem As ListViewItem = lst.SelectedItems(0)
            Dim chb As CheckBox = tmpArr.Item(lstItem.Tag)

            tmpArr.Remove(lstItem.Tag)
            lst.Items.Remove(lstItem)
            chb.Enabled = True
        End If
    End Sub

    Private Sub lstTicketType_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lstAdult.ItemDrag, lstStudent.ItemDrag, lstChild.ItemDrag
        Dim lst As ListView = sender

        dragLst = lst


        Dim myItem As ListViewItem
        Dim myItems(lst.SelectedItems.Count - 1) As ListViewItem
        Dim i As Integer = 0

        ' Loop though the SelectedItems collection for the source.
        For Each myItem In lst.SelectedItems
            ' Add the ListViewItem to the array of ListViewItems.
            myItems(i) = myItem
            i = i + 1
        Next
        ' Create a DataObject containg the array of ListViewItems.
        lst.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem()", myItems), DragDropEffects.Move)
    End Sub
End Class
