<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.panTop = New System.Windows.Forms.Panel
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.panMain = New System.Windows.Forms.Panel
        Me.panTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panTop
        '
        Me.panTop.Controls.Add(Me.Label64)
        Me.panTop.Controls.Add(Me.Label63)
        Me.panTop.Controls.Add(Me.Label65)
        Me.panTop.Controls.Add(Me.Label1)
        Me.panTop.Controls.Add(Me.PictureBox1)
        Me.panTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTop.Location = New System.Drawing.Point(0, 0)
        Me.panTop.Name = "panTop"
        Me.panTop.Size = New System.Drawing.Size(766, 156)
        Me.panTop.TabIndex = 0
        '
        'Label64
        '
        Me.Label64.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label64.Location = New System.Drawing.Point(720, 12)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(40, 16)
        Me.Label64.TabIndex = 95
        Me.Label64.Text = "egro"
        '
        'Label63
        '
        Me.Label63.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label63.Location = New System.Drawing.Point(634, 12)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(87, 16)
        Me.Label63.TabIndex = 94
        Me.Label63.Text = "Logged user:"
        '
        'Label65
        '
        Me.Label65.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label65.Location = New System.Drawing.Point(703, 31)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(51, 16)
        Me.Label65.TabIndex = 96
        Me.Label65.Text = "LogOut"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Chiller", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(165, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(589, 74)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VBA TICKET GENERATOR"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Image = Global.TicketGenerator.My.Resources.Resources.vba_ticket_1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 99)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panMain
        '
        Me.panMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panMain.Location = New System.Drawing.Point(0, 156)
        Me.panMain.Name = "panMain"
        Me.panMain.Size = New System.Drawing.Size(766, 597)
        Me.panMain.TabIndex = 1
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(766, 753)
        Me.Controls.Add(Me.panMain)
        Me.Controls.Add(Me.panTop)
        Me.Name = "frmOrder"
        Me.Text = "frmOrder"
        Me.panTop.ResumeLayout(False)
        Me.panTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panTop As System.Windows.Forms.Panel
    Friend WithEvents panMain As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
End Class
