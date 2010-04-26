<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOrderChoiceSeats
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucOrderChoiceSeats))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.picUnchecked = New System.Windows.Forms.PictureBox
        Me.picChecked = New System.Windows.Forms.PictureBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.panBottom = New System.Windows.Forms.Panel
        Me.panSeats = New System.Windows.Forms.Panel
        Me.lblTProjScreen = New System.Windows.Forms.Label
        Me.lblTSelSeats = New System.Windows.Forms.Label
        Me.lblSetSeats = New System.Windows.Forms.Label
        Me.picFull = New System.Windows.Forms.PictureBox
        Me.lblPicUnchecked = New System.Windows.Forms.Label
        Me.lblPicChecked = New System.Windows.Forms.Label
        Me.lblPicFull = New System.Windows.Forms.Label
        Me.panInfo = New System.Windows.Forms.Panel
        Me.llbTMovie = New System.Windows.Forms.Label
        Me.lblTDate = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblMovie = New System.Windows.Forms.Label
        Me.lblTTime = New System.Windows.Forms.Label
        Me.ToolTipSeats = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picUnchecked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChecked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBottom.SuspendLayout()
        CType(Me.picFull, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'picUnchecked
        '
        Me.picUnchecked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picUnchecked.Image = Global.TicketGenerator.My.Resources.Resources.unchecked
        Me.picUnchecked.Location = New System.Drawing.Point(1, 23)
        Me.picUnchecked.Name = "picUnchecked"
        Me.picUnchecked.Size = New System.Drawing.Size(20, 20)
        Me.picUnchecked.TabIndex = 28
        Me.picUnchecked.TabStop = False
        Me.ToolTip.SetToolTip(Me.picUnchecked, "UnCheck All")
        '
        'picChecked
        '
        Me.picChecked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picChecked.Image = Global.TicketGenerator.My.Resources.Resources.checked
        Me.picChecked.Location = New System.Drawing.Point(1, 47)
        Me.picChecked.Name = "picChecked"
        Me.picChecked.Size = New System.Drawing.Size(20, 20)
        Me.picChecked.TabIndex = 29
        Me.picChecked.TabStop = False
        Me.ToolTip.SetToolTip(Me.picChecked, "Check all")
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(3, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(174, 72)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnNext.Image = Global.TicketGenerator.My.Resources.Resources.cont
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.Location = New System.Drawing.Point(611, 0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(174, 72)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "Continue"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'panBottom
        '
        Me.panBottom.Controls.Add(Me.btnBack)
        Me.panBottom.Controls.Add(Me.btnNext)
        Me.panBottom.Location = New System.Drawing.Point(0, 492)
        Me.panBottom.Name = "panBottom"
        Me.panBottom.Size = New System.Drawing.Size(872, 76)
        Me.panBottom.TabIndex = 28
        '
        'panSeats
        '
        Me.panSeats.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panSeats.Location = New System.Drawing.Point(37, 156)
        Me.panSeats.Name = "panSeats"
        Me.panSeats.Size = New System.Drawing.Size(600, 330)
        Me.panSeats.TabIndex = 4
        '
        'lblTProjScreen
        '
        Me.lblTProjScreen.AutoSize = True
        Me.lblTProjScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTProjScreen.Location = New System.Drawing.Point(244, 124)
        Me.lblTProjScreen.Name = "lblTProjScreen"
        Me.lblTProjScreen.Size = New System.Drawing.Size(222, 29)
        Me.lblTProjScreen.TabIndex = 6
        Me.lblTProjScreen.Text = "Projection Screen"
        '
        'lblTSelSeats
        '
        Me.lblTSelSeats.AutoSize = True
        Me.lblTSelSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTSelSeats.Location = New System.Drawing.Point(1, 1)
        Me.lblTSelSeats.Name = "lblTSelSeats"
        Me.lblTSelSeats.Size = New System.Drawing.Size(85, 20)
        Me.lblTSelSeats.TabIndex = 26
        Me.lblTSelSeats.Text = "Selected:"
        '
        'lblSetSeats
        '
        Me.lblSetSeats.AutoSize = True
        Me.lblSetSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSetSeats.Location = New System.Drawing.Point(88, 1)
        Me.lblSetSeats.Name = "lblSetSeats"
        Me.lblSetSeats.Size = New System.Drawing.Size(32, 18)
        Me.lblSetSeats.TabIndex = 27
        Me.lblSetSeats.Text = "220"
        '
        'picFull
        '
        Me.picFull.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picFull.Image = Global.TicketGenerator.My.Resources.Resources.full
        Me.picFull.Location = New System.Drawing.Point(1, 73)
        Me.picFull.Name = "picFull"
        Me.picFull.Size = New System.Drawing.Size(20, 20)
        Me.picFull.TabIndex = 30
        Me.picFull.TabStop = False
        '
        'lblPicUnchecked
        '
        Me.lblPicUnchecked.AutoSize = True
        Me.lblPicUnchecked.Location = New System.Drawing.Point(27, 27)
        Me.lblPicUnchecked.Name = "lblPicUnchecked"
        Me.lblPicUnchecked.Size = New System.Drawing.Size(73, 13)
        Me.lblPicUnchecked.TabIndex = 31
        Me.lblPicUnchecked.Text = "Available seat"
        '
        'lblPicChecked
        '
        Me.lblPicChecked.AutoSize = True
        Me.lblPicChecked.Location = New System.Drawing.Point(27, 51)
        Me.lblPicChecked.Name = "lblPicChecked"
        Me.lblPicChecked.Size = New System.Drawing.Size(66, 13)
        Me.lblPicChecked.TabIndex = 32
        Me.lblPicChecked.Text = "Chosen seat"
        '
        'lblPicFull
        '
        Me.lblPicFull.AutoSize = True
        Me.lblPicFull.Location = New System.Drawing.Point(27, 77)
        Me.lblPicFull.Name = "lblPicFull"
        Me.lblPicFull.Size = New System.Drawing.Size(53, 13)
        Me.lblPicFull.TabIndex = 33
        Me.lblPicFull.Text = "Sold Seat"
        '
        'panInfo
        '
        Me.panInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panInfo.Controls.Add(Me.lblPicFull)
        Me.panInfo.Controls.Add(Me.lblPicChecked)
        Me.panInfo.Controls.Add(Me.lblPicUnchecked)
        Me.panInfo.Controls.Add(Me.picFull)
        Me.panInfo.Controls.Add(Me.picChecked)
        Me.panInfo.Controls.Add(Me.picUnchecked)
        Me.panInfo.Controls.Add(Me.lblSetSeats)
        Me.panInfo.Controls.Add(Me.lblTSelSeats)
        Me.panInfo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.panInfo.Location = New System.Drawing.Point(665, 156)
        Me.panInfo.Name = "panInfo"
        Me.panInfo.Size = New System.Drawing.Size(127, 100)
        Me.panInfo.TabIndex = 26
        '
        'llbTMovie
        '
        Me.llbTMovie.AutoSize = True
        Me.llbTMovie.Font = New System.Drawing.Font("Helvetica", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llbTMovie.Location = New System.Drawing.Point(3, 0)
        Me.llbTMovie.Name = "llbTMovie"
        Me.llbTMovie.Size = New System.Drawing.Size(107, 35)
        Me.llbTMovie.TabIndex = 29
        Me.llbTMovie.Text = "Movie:"
        '
        'lblTDate
        '
        Me.lblTDate.AutoSize = True
        Me.lblTDate.Font = New System.Drawing.Font("Helvetica", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTDate.Location = New System.Drawing.Point(28, 36)
        Me.lblTDate.Name = "lblTDate"
        Me.lblTDate.Size = New System.Drawing.Size(82, 32)
        Me.lblTDate.TabIndex = 30
        Me.lblTDate.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Helvetica", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblDate.Location = New System.Drawing.Point(116, 40)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(250, 28)
        Me.lblDate.TabIndex = 31
        Me.lblDate.Text = "25.03.2010 (Monday)"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Helvetica", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblTime.Location = New System.Drawing.Point(116, 71)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(70, 26)
        Me.lblTime.TabIndex = 32
        Me.lblTime.Text = "13:30"
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.Font = New System.Drawing.Font("Helvetica", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblMovie.Location = New System.Drawing.Point(116, 3)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(225, 32)
        Me.lblMovie.TabIndex = 33
        Me.lblMovie.Text = "Sherlock Holmes"
        '
        'lblTTime
        '
        Me.lblTTime.AutoSize = True
        Me.lblTTime.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblTTime.Location = New System.Drawing.Point(34, 68)
        Me.lblTTime.Name = "lblTTime"
        Me.lblTTime.Size = New System.Drawing.Size(76, 29)
        Me.lblTTime.TabIndex = 34
        Me.lblTTime.Text = "Time:"
        '
        'ToolTipSeats
        '
        Me.ToolTipSeats.AutoPopDelay = 2500
        Me.ToolTipSeats.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolTipSeats.InitialDelay = 1000
        Me.ToolTipSeats.IsBalloon = True
        Me.ToolTipSeats.ReshowDelay = 750
        '
        'ucOrderChoiceSeats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.lblTTime)
        Me.Controls.Add(Me.lblMovie)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTDate)
        Me.Controls.Add(Me.llbTMovie)
        Me.Controls.Add(Me.panBottom)
        Me.Controls.Add(Me.panInfo)
        Me.Controls.Add(Me.lblTProjScreen)
        Me.Controls.Add(Me.panSeats)
        Me.Name = "ucOrderChoiceSeats"
        Me.Size = New System.Drawing.Size(798, 568)
        CType(Me.picUnchecked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChecked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBottom.ResumeLayout(False)
        CType(Me.picFull, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panInfo.ResumeLayout(False)
        Me.panInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents panBottom As System.Windows.Forms.Panel
    Friend WithEvents panSeats As System.Windows.Forms.Panel
    Friend WithEvents lblTProjScreen As System.Windows.Forms.Label
    Friend WithEvents lblTSelSeats As System.Windows.Forms.Label
    Friend WithEvents lblSetSeats As System.Windows.Forms.Label
    Friend WithEvents picUnchecked As System.Windows.Forms.PictureBox
    Friend WithEvents picChecked As System.Windows.Forms.PictureBox
    Friend WithEvents picFull As System.Windows.Forms.PictureBox
    Friend WithEvents lblPicUnchecked As System.Windows.Forms.Label
    Friend WithEvents lblPicChecked As System.Windows.Forms.Label
    Friend WithEvents lblPicFull As System.Windows.Forms.Label
    Friend WithEvents panInfo As System.Windows.Forms.Panel
    Friend WithEvents llbTMovie As System.Windows.Forms.Label
    Friend WithEvents lblTDate As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblMovie As System.Windows.Forms.Label
    Friend WithEvents lblTTime As System.Windows.Forms.Label
    Friend WithEvents ToolTipSeats As System.Windows.Forms.ToolTip

End Class
