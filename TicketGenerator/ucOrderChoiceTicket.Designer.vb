<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOrderChoiceTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucOrderChoiceTicket))
        Me.seatsIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.panSeats = New System.Windows.Forms.Panel
        Me.lstAdult = New System.Windows.Forms.ListView
        Me.lstStudent = New System.Windows.Forms.ListView
        Me.lstChild = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'seatsIcons
        '
        Me.seatsIcons.ImageStream = CType(resources.GetObject("seatsIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.seatsIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.seatsIcons.Images.SetKeyName(0, "unchecked.gif")
        Me.seatsIcons.Images.SetKeyName(1, "checked.gif")
        Me.seatsIcons.Images.SetKeyName(2, "full.gif")
        '
        'panSeats
        '
        Me.panSeats.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panSeats.Location = New System.Drawing.Point(112, 13)
        Me.panSeats.Name = "panSeats"
        Me.panSeats.Size = New System.Drawing.Size(600, 330)
        Me.panSeats.TabIndex = 5
        '
        'lstAdult
        '
        Me.lstAdult.AllowDrop = True
        Me.lstAdult.Location = New System.Drawing.Point(112, 396)
        Me.lstAdult.Name = "lstAdult"
        Me.lstAdult.Size = New System.Drawing.Size(154, 164)
        Me.lstAdult.TabIndex = 6
        Me.lstAdult.UseCompatibleStateImageBehavior = False
        Me.lstAdult.View = System.Windows.Forms.View.List
        '
        'lstStudent
        '
        Me.lstStudent.AllowDrop = True
        Me.lstStudent.Location = New System.Drawing.Point(357, 395)
        Me.lstStudent.Name = "lstStudent"
        Me.lstStudent.Size = New System.Drawing.Size(154, 164)
        Me.lstStudent.TabIndex = 7
        Me.lstStudent.UseCompatibleStateImageBehavior = False
        Me.lstStudent.View = System.Windows.Forms.View.List
        '
        'lstChild
        '
        Me.lstChild.AllowDrop = True
        Me.lstChild.Location = New System.Drawing.Point(596, 395)
        Me.lstChild.Name = "lstChild"
        Me.lstChild.Size = New System.Drawing.Size(154, 164)
        Me.lstChild.TabIndex = 8
        Me.lstChild.UseCompatibleStateImageBehavior = False
        Me.lstChild.View = System.Windows.Forms.View.List
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Adult (150 Kc):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Student (100 Kc):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Child (50 Kc): "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(272, 396)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(38, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(517, 395)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(38, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(756, 395)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(38, 21)
        Me.ComboBox3.TabIndex = 14
        '
        'ucOrderChoiceTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstChild)
        Me.Controls.Add(Me.lstStudent)
        Me.Controls.Add(Me.lstAdult)
        Me.Controls.Add(Me.panSeats)
        Me.Name = "ucOrderChoiceTicket"
        Me.Size = New System.Drawing.Size(798, 660)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents seatsIcons As System.Windows.Forms.ImageList
    Friend WithEvents panSeats As System.Windows.Forms.Panel
    Friend WithEvents lstAdult As System.Windows.Forms.ListView
    Friend WithEvents lstStudent As System.Windows.Forms.ListView
    Friend WithEvents lstChild As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox

End Class
