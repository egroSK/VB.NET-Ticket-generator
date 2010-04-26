<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbCinema = New System.Windows.Forms.ComboBox
        Me.CINEMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTG = New TicketGenerator.DataSetTG
        Me.lblUsername = New System.Windows.Forms.Label
        Me.CINEMATableAdapter = New TicketGenerator.DataSetTGTableAdapters.CINEMATableAdapter
        Me.TableAdapterManager = New TicketGenerator.DataSetTGTableAdapters.TableAdapterManager
        Me.EVENTTableAdapter = New TicketGenerator.DataSetTGTableAdapters.EVENTTableAdapter
        Me.MOVIETableAdapter = New TicketGenerator.DataSetTGTableAdapters.MOVIETableAdapter
        Me.DataGridViewEvents = New System.Windows.Forms.DataGridView
        Me.MOVIENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VERSIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LENGTHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PARENTSGUIDEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOVIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CINEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 43)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Events"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1083, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(813, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Logged User:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cinema:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Please choose a Cinema and a Date."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date:"
        '
        'cbCinema
        '
        Me.cbCinema.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CINEMABindingSource, "NAME", True))
        Me.cbCinema.DataSource = Me.CINEMABindingSource
        Me.cbCinema.DisplayMember = "NAME"
        Me.cbCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCinema.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbCinema.FormattingEnabled = True
        Me.cbCinema.Location = New System.Drawing.Point(96, 150)
        Me.cbCinema.Name = "cbCinema"
        Me.cbCinema.Size = New System.Drawing.Size(392, 28)
        Me.cbCinema.TabIndex = 1
        '
        'CINEMABindingSource
        '
        Me.CINEMABindingSource.DataMember = "CINEMA"
        Me.CINEMABindingSource.DataSource = Me.DataSetTG
        '
        'DataSetTG
        '
        Me.DataSetTG.DataSetName = "DataSetTG"
        Me.DataSetTG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(900, 33)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(85, 16)
        Me.lblUsername.TabIndex = 15
        Me.lblUsername.Text = "lblUsername"
        '
        'CINEMATableAdapter
        '
        Me.CINEMATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AORDERTableAdapter = Nothing
        Me.TableAdapterManager.AUSERTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CINEMATableAdapter = Me.CINEMATableAdapter
        Me.TableAdapterManager.EVENTTableAdapter = Me.EVENTTableAdapter
        Me.TableAdapterManager.HALLTableAdapter = Nothing
        Me.TableAdapterManager.MOVIETableAdapter = Me.MOVIETableAdapter
        Me.TableAdapterManager.SEATTableAdapter = Nothing
        Me.TableAdapterManager.SOTICKETTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TicketGenerator.DataSetTGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EVENTTableAdapter
        '
        Me.EVENTTableAdapter.ClearBeforeFill = True
        '
        'MOVIETableAdapter
        '
        Me.MOVIETableAdapter.ClearBeforeFill = True
        '
        'DataGridViewEvents
        '
        Me.DataGridViewEvents.AllowDrop = True
        Me.DataGridViewEvents.AllowUserToAddRows = False
        Me.DataGridViewEvents.AllowUserToDeleteRows = False
        Me.DataGridViewEvents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewEvents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewEvents.AutoGenerateColumns = False
        Me.DataGridViewEvents.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridViewEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewEvents.ColumnHeadersHeight = 30
        Me.DataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MOVIENAMEDataGridViewTextBoxColumn, Me.VERSIONDataGridViewTextBoxColumn, Me.LENGTHDataGridViewTextBoxColumn, Me.PARENTSGUIDEDataGridViewTextBoxColumn})
        Me.DataGridViewEvents.DataSource = Me.MOVIEBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEvents.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewEvents.Location = New System.Drawing.Point(20, 379)
        Me.DataGridViewEvents.Name = "DataGridViewEvents"
        Me.DataGridViewEvents.ReadOnly = True
        Me.DataGridViewEvents.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DataGridViewEvents.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewEvents.Size = New System.Drawing.Size(1038, 275)
        Me.DataGridViewEvents.TabIndex = 16
        '
        'MOVIENAMEDataGridViewTextBoxColumn
        '
        Me.MOVIENAMEDataGridViewTextBoxColumn.DataPropertyName = "MOVIE_NAME"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.MOVIENAMEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MOVIENAMEDataGridViewTextBoxColumn.HeaderText = "MOVIE"
        Me.MOVIENAMEDataGridViewTextBoxColumn.Name = "MOVIENAMEDataGridViewTextBoxColumn"
        Me.MOVIENAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.MOVIENAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MOVIENAMEDataGridViewTextBoxColumn.Width = 300
        '
        'VERSIONDataGridViewTextBoxColumn
        '
        Me.VERSIONDataGridViewTextBoxColumn.DataPropertyName = "VERSION"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.VERSIONDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.VERSIONDataGridViewTextBoxColumn.HeaderText = "VER."
        Me.VERSIONDataGridViewTextBoxColumn.Name = "VERSIONDataGridViewTextBoxColumn"
        Me.VERSIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.VERSIONDataGridViewTextBoxColumn.Width = 50
        '
        'LENGTHDataGridViewTextBoxColumn
        '
        Me.LENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LENGTHDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.LENGTHDataGridViewTextBoxColumn.HeaderText = "L"
        Me.LENGTHDataGridViewTextBoxColumn.Name = "LENGTHDataGridViewTextBoxColumn"
        Me.LENGTHDataGridViewTextBoxColumn.ReadOnly = True
        Me.LENGTHDataGridViewTextBoxColumn.Width = 60
        '
        'PARENTSGUIDEDataGridViewTextBoxColumn
        '
        Me.PARENTSGUIDEDataGridViewTextBoxColumn.DataPropertyName = "PARENTS_GUIDE"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PARENTSGUIDEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PARENTSGUIDEDataGridViewTextBoxColumn.HeaderText = "PG"
        Me.PARENTSGUIDEDataGridViewTextBoxColumn.Name = "PARENTSGUIDEDataGridViewTextBoxColumn"
        Me.PARENTSGUIDEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PARENTSGUIDEDataGridViewTextBoxColumn.Width = 50
        '
        'MOVIEBindingSource
        '
        Me.MOVIEBindingSource.DataMember = "MOVIE"
        Me.MOVIEBindingSource.DataSource = Me.DataSetTG
        '
        'EVENTBindingSource
        '
        Me.EVENTBindingSource.DataMember = "EVENT"
        Me.EVENTBindingSource.DataSource = Me.DataSetTG
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DateTimePicker1.CausesValidation = False
        Me.DateTimePicker1.CustomFormat = "dd.MM.yy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 189)
        Me.DateTimePicker1.MinDate = New Date(2010, 4, 15, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker1.Size = New System.Drawing.Size(273, 26)
        Me.DateTimePicker1.TabIndex = 17
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 725)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridViewEvents)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.cbCinema)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET Ticket Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CINEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCinema As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents DataSetTG As TicketGenerator.DataSetTG
    Friend WithEvents CINEMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CINEMATableAdapter As TicketGenerator.DataSetTGTableAdapters.CINEMATableAdapter
    Friend WithEvents TableAdapterManager As TicketGenerator.DataSetTGTableAdapters.TableAdapterManager
    Friend WithEvents MOVIETableAdapter As TicketGenerator.DataSetTGTableAdapters.MOVIETableAdapter
    Friend WithEvents DataGridViewEvents As System.Windows.Forms.DataGridView
    Friend WithEvents MOVIEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTTableAdapter As TicketGenerator.DataSetTGTableAdapters.EVENTTableAdapter
    Friend WithEvents EVENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MOVIENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VERSIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LENGTHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARENTSGUIDEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
