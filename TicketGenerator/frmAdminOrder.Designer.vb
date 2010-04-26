<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminOrder
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
        Me.components = New System.ComponentModel.Container
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cbUser = New System.Windows.Forms.ComboBox
        Me.AUSERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTG = New TicketGenerator.DataSetTG
        Me.AUSERTableAdapter = New TicketGenerator.DataSetTGTableAdapters.AUSERTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        CType(Me.AUSERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 38)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "New Order"
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(194, 171)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(165, 52)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(19, 171)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(165, 52)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbUser
        '
        Me.cbUser.DataSource = Me.AUSERBindingSource
        Me.cbUser.DisplayMember = "USER_ID"
        Me.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(91, 100)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(268, 21)
        Me.cbUser.TabIndex = 1
        '
        'AUSERBindingSource
        '
        Me.AUSERBindingSource.DataMember = "AUSER"
        Me.AUSERBindingSource.DataSource = Me.DataSetTG
        '
        'DataSetTG
        '
        Me.DataSetTG.DataSetName = "DataSetTG"
        Me.DataSetTG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AUSERTableAdapter
        '
        Me.AUSERTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "User:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(91, 129)
        Me.txtTotal.MaxLength = 20
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(268, 20)
        Me.txtTotal.TabIndex = 3
        '
        'frmAdminOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 242)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbUser)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.MaximumSize = New System.Drawing.Size(400, 278)
        Me.MinimumSize = New System.Drawing.Size(400, 278)
        Me.Name = "frmAdminOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Order"
        CType(Me.AUSERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbUser As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetTG As TicketGenerator.DataSetTG
    Friend WithEvents AUSERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AUSERTableAdapter As TicketGenerator.DataSetTGTableAdapters.AUSERTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
End Class
