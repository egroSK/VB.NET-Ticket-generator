<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.tabSet = New System.Windows.Forms.TabControl
        Me.tbCinema = New System.Windows.Forms.TabPage
        Me.CINEMADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CINEMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTG = New TicketGenerator.DataSetTG
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbMovie = New System.Windows.Forms.TabPage
        Me.btnSaveMovie = New System.Windows.Forms.Button
        Me.btnUpdateMovies = New System.Windows.Forms.Button
        Me.btnNewMovie = New System.Windows.Forms.Button
        Me.MOVIEDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOVIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbEvent = New System.Windows.Forms.TabPage
        Me.EVENTDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbTicket = New System.Windows.Forms.TabPage
        Me.btnUpdateTickets = New System.Windows.Forms.Button
        Me.btnCreateNewTicket = New System.Windows.Forms.Button
        Me.SOTICKETDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOTICKETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbOrder = New System.Windows.Forms.TabPage
        Me.btnUpdateOrders = New System.Windows.Forms.Button
        Me.btnCreateNewOrder = New System.Windows.Forms.Button
        Me.AORDERDataGridView = New System.Windows.Forms.DataGridView
        Me.ORDERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.USERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CREATEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AORDERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbUser = New System.Windows.Forms.TabPage
        Me.btnSaveUser = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnNewUser = New System.Windows.Forms.Button
        Me.AUSERDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AUSERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FIlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AUSERTableAdapter = New TicketGenerator.DataSetTGTableAdapters.AUSERTableAdapter
        Me.TableAdapterManager = New TicketGenerator.DataSetTGTableAdapters.TableAdapterManager
        Me.AORDERTableAdapter = New TicketGenerator.DataSetTGTableAdapters.AORDERTableAdapter
        Me.CINEMATableAdapter = New TicketGenerator.DataSetTGTableAdapters.CINEMATableAdapter
        Me.EVENTTableAdapter = New TicketGenerator.DataSetTGTableAdapters.EVENTTableAdapter
        Me.MOVIETableAdapter = New TicketGenerator.DataSetTGTableAdapters.MOVIETableAdapter
        Me.SOTICKETTableAdapter = New TicketGenerator.DataSetTGTableAdapters.SOTICKETTableAdapter
        Me.tabSet.SuspendLayout()
        Me.tbCinema.SuspendLayout()
        CType(Me.CINEMADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CINEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMovie.SuspendLayout()
        CType(Me.MOVIEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbEvent.SuspendLayout()
        CType(Me.EVENTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTicket.SuspendLayout()
        CType(Me.SOTICKETDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOTICKETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOrder.SuspendLayout()
        CType(Me.AORDERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AORDERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbUser.SuspendLayout()
        CType(Me.AUSERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUSERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSet
        '
        Me.tabSet.Controls.Add(Me.tbCinema)
        Me.tabSet.Controls.Add(Me.tbMovie)
        Me.tabSet.Controls.Add(Me.tbEvent)
        Me.tabSet.Controls.Add(Me.tbTicket)
        Me.tabSet.Controls.Add(Me.tbOrder)
        Me.tabSet.Controls.Add(Me.tbUser)
        Me.tabSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSet.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tabSet.Location = New System.Drawing.Point(0, 24)
        Me.tabSet.Name = "tabSet"
        Me.tabSet.Padding = New System.Drawing.Point(6, 7)
        Me.tabSet.SelectedIndex = 0
        Me.tabSet.Size = New System.Drawing.Size(1192, 754)
        Me.tabSet.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabSet.TabIndex = 0
        '
        'tbCinema
        '
        Me.tbCinema.BackColor = System.Drawing.Color.Transparent
        Me.tbCinema.Controls.Add(Me.CINEMADataGridView)
        Me.tbCinema.Controls.Add(Me.Label3)
        Me.tbCinema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbCinema.Location = New System.Drawing.Point(4, 45)
        Me.tbCinema.Name = "tbCinema"
        Me.tbCinema.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCinema.Size = New System.Drawing.Size(1184, 705)
        Me.tbCinema.TabIndex = 0
        Me.tbCinema.Text = "Cinemas"
        Me.tbCinema.UseVisualStyleBackColor = True
        '
        'CINEMADataGridView
        '
        Me.CINEMADataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CINEMADataGridView.AutoGenerateColumns = False
        Me.CINEMADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CINEMADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.CINEMADataGridView.DataSource = Me.CINEMABindingSource
        Me.CINEMADataGridView.Location = New System.Drawing.Point(15, 225)
        Me.CINEMADataGridView.Name = "CINEMADataGridView"
        Me.CINEMADataGridView.Size = New System.Drawing.Size(1150, 472)
        Me.CINEMADataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "CINEMA_ID"
        Me.DataGridViewTextBoxColumn25.HeaderText = "CINEMA_ID"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 120
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn26.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CITY"
        Me.DataGridViewTextBoxColumn27.HeaderText = "CITY"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 150
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "STREET"
        Me.DataGridViewTextBoxColumn28.HeaderText = "STREET"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 160
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "PRICE_ADULT"
        Me.DataGridViewTextBoxColumn29.HeaderText = "PRICE ADULT"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "PRICE_STUDENT"
        Me.DataGridViewTextBoxColumn30.HeaderText = "PRICE STUDENT"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 110
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "PRICE_CHILD"
        Me.DataGridViewTextBoxColumn31.HeaderText = "PRICE CHILD"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 38)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cinemas"
        '
        'tbMovie
        '
        Me.tbMovie.BackColor = System.Drawing.Color.Transparent
        Me.tbMovie.Controls.Add(Me.btnSaveMovie)
        Me.tbMovie.Controls.Add(Me.btnUpdateMovies)
        Me.tbMovie.Controls.Add(Me.btnNewMovie)
        Me.tbMovie.Controls.Add(Me.MOVIEDataGridView)
        Me.tbMovie.Controls.Add(Me.Label1)
        Me.tbMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbMovie.Location = New System.Drawing.Point(4, 45)
        Me.tbMovie.Name = "tbMovie"
        Me.tbMovie.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMovie.Size = New System.Drawing.Size(1184, 769)
        Me.tbMovie.TabIndex = 1
        Me.tbMovie.Text = "Movies"
        Me.tbMovie.UseVisualStyleBackColor = True
        '
        'btnSaveMovie
        '
        Me.btnSaveMovie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSaveMovie.Location = New System.Drawing.Point(569, 109)
        Me.btnSaveMovie.Name = "btnSaveMovie"
        Me.btnSaveMovie.Size = New System.Drawing.Size(152, 54)
        Me.btnSaveMovie.TabIndex = 14
        Me.btnSaveMovie.Text = "Save"
        Me.btnSaveMovie.UseVisualStyleBackColor = True
        '
        'btnUpdateMovies
        '
        Me.btnUpdateMovies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateMovies.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUpdateMovies.Location = New System.Drawing.Point(727, 109)
        Me.btnUpdateMovies.Name = "btnUpdateMovies"
        Me.btnUpdateMovies.Size = New System.Drawing.Size(152, 54)
        Me.btnUpdateMovies.TabIndex = 13
        Me.btnUpdateMovies.Text = "Update"
        Me.btnUpdateMovies.UseVisualStyleBackColor = True
        '
        'btnNewMovie
        '
        Me.btnNewMovie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnNewMovie.Location = New System.Drawing.Point(885, 109)
        Me.btnNewMovie.Name = "btnNewMovie"
        Me.btnNewMovie.Size = New System.Drawing.Size(281, 54)
        Me.btnNewMovie.TabIndex = 12
        Me.btnNewMovie.Text = "Create New Movie"
        Me.btnNewMovie.UseVisualStyleBackColor = True
        '
        'MOVIEDataGridView
        '
        Me.MOVIEDataGridView.AllowUserToAddRows = False
        Me.MOVIEDataGridView.AllowUserToDeleteRows = False
        Me.MOVIEDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MOVIEDataGridView.AutoGenerateColumns = False
        Me.MOVIEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MOVIEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn24})
        Me.MOVIEDataGridView.DataSource = Me.MOVIEBindingSource
        Me.MOVIEDataGridView.Location = New System.Drawing.Point(13, 169)
        Me.MOVIEDataGridView.Name = "MOVIEDataGridView"
        Me.MOVIEDataGridView.Size = New System.Drawing.Size(1153, 580)
        Me.MOVIEDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "MOVIE_ID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "MOVIE_ID"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 110
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "MOVIE_NAME"
        Me.DataGridViewTextBoxColumn22.HeaderText = "MOVIE NAME"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 330
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "YEAR"
        Me.DataGridViewTextBoxColumn21.HeaderText = "YEAR"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "LENGTH"
        Me.DataGridViewTextBoxColumn19.HeaderText = "LENGTH"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "VERSION"
        Me.DataGridViewTextBoxColumn20.HeaderText = "VERSION"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "PARENTS_GUIDE"
        Me.DataGridViewTextBoxColumn24.HeaderText = "PG"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 167
        '
        'MOVIEBindingSource
        '
        Me.MOVIEBindingSource.DataMember = "MOVIE"
        Me.MOVIEBindingSource.DataSource = Me.DataSetTG
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Movies"
        '
        'tbEvent
        '
        Me.tbEvent.BackColor = System.Drawing.Color.Transparent
        Me.tbEvent.Controls.Add(Me.EVENTDataGridView)
        Me.tbEvent.Controls.Add(Me.Label2)
        Me.tbEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbEvent.Location = New System.Drawing.Point(4, 45)
        Me.tbEvent.Name = "tbEvent"
        Me.tbEvent.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEvent.Size = New System.Drawing.Size(1184, 769)
        Me.tbEvent.TabIndex = 2
        Me.tbEvent.Text = "Events"
        Me.tbEvent.UseVisualStyleBackColor = True
        '
        'EVENTDataGridView
        '
        Me.EVENTDataGridView.AllowUserToDeleteRows = False
        Me.EVENTDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EVENTDataGridView.AutoGenerateColumns = False
        Me.EVENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EVENTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.EVENTDataGridView.DataSource = Me.EVENTBindingSource
        Me.EVENTDataGridView.Location = New System.Drawing.Point(15, 294)
        Me.EVENTDataGridView.Name = "EVENTDataGridView"
        Me.EVENTDataGridView.Size = New System.Drawing.Size(1151, 457)
        Me.EVENTDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "EVENT_ID"
        Me.DataGridViewTextBoxColumn34.HeaderText = "EVENT_ID"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "MOVIE_ID"
        Me.DataGridViewTextBoxColumn36.HeaderText = "MOVIE_ID"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "HALL_ID"
        Me.DataGridViewTextBoxColumn35.HeaderText = "HALL_ID"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "ADATE"
        Me.DataGridViewTextBoxColumn32.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "TIME"
        Me.DataGridViewTextBoxColumn33.HeaderText = "TIME"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'EVENTBindingSource
        '
        Me.EVENTBindingSource.DataMember = "EVENT"
        Me.EVENTBindingSource.DataSource = Me.DataSetTG
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Events"
        '
        'tbTicket
        '
        Me.tbTicket.BackColor = System.Drawing.Color.Transparent
        Me.tbTicket.Controls.Add(Me.btnUpdateTickets)
        Me.tbTicket.Controls.Add(Me.btnCreateNewTicket)
        Me.tbTicket.Controls.Add(Me.SOTICKETDataGridView)
        Me.tbTicket.Controls.Add(Me.Label4)
        Me.tbTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbTicket.Location = New System.Drawing.Point(4, 45)
        Me.tbTicket.Name = "tbTicket"
        Me.tbTicket.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTicket.Size = New System.Drawing.Size(1184, 769)
        Me.tbTicket.TabIndex = 3
        Me.tbTicket.Text = "Tickets"
        Me.tbTicket.UseVisualStyleBackColor = True
        '
        'btnUpdateTickets
        '
        Me.btnUpdateTickets.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUpdateTickets.Location = New System.Drawing.Point(732, 95)
        Me.btnUpdateTickets.Name = "btnUpdateTickets"
        Me.btnUpdateTickets.Size = New System.Drawing.Size(152, 54)
        Me.btnUpdateTickets.TabIndex = 15
        Me.btnUpdateTickets.Text = "Update"
        Me.btnUpdateTickets.UseVisualStyleBackColor = True
        '
        'btnCreateNewTicket
        '
        Me.btnCreateNewTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateNewTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCreateNewTicket.Location = New System.Drawing.Point(890, 95)
        Me.btnCreateNewTicket.Name = "btnCreateNewTicket"
        Me.btnCreateNewTicket.Size = New System.Drawing.Size(274, 54)
        Me.btnCreateNewTicket.TabIndex = 14
        Me.btnCreateNewTicket.Text = "Create New Ticket"
        Me.btnCreateNewTicket.UseVisualStyleBackColor = True
        '
        'SOTICKETDataGridView
        '
        Me.SOTICKETDataGridView.AllowUserToAddRows = False
        Me.SOTICKETDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SOTICKETDataGridView.AutoGenerateColumns = False
        Me.SOTICKETDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SOTICKETDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn12})
        Me.SOTICKETDataGridView.DataSource = Me.SOTICKETBindingSource
        Me.SOTICKETDataGridView.Location = New System.Drawing.Point(15, 155)
        Me.SOTICKETDataGridView.Name = "SOTICKETDataGridView"
        Me.SOTICKETDataGridView.ReadOnly = True
        Me.SOTICKETDataGridView.Size = New System.Drawing.Size(1149, 590)
        Me.SOTICKETDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SOTICKET_ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TICKET_ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 140
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ORDER_ID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ORDER_ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 120
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "EVENT_ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "EVENT_ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 120
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "HALL_ID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "HALL_ID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 120
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "AROW"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ROW"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 120
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ANUMBER"
        Me.DataGridViewTextBoxColumn17.HeaderText = "NUMBER"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 140
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ATYPE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TYPE"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'SOTICKETBindingSource
        '
        Me.SOTICKETBindingSource.DataMember = "SOTICKET"
        Me.SOTICKETBindingSource.DataSource = Me.DataSetTG
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tickets"
        '
        'tbOrder
        '
        Me.tbOrder.AutoScroll = True
        Me.tbOrder.BackColor = System.Drawing.Color.Transparent
        Me.tbOrder.Controls.Add(Me.btnUpdateOrders)
        Me.tbOrder.Controls.Add(Me.btnCreateNewOrder)
        Me.tbOrder.Controls.Add(Me.AORDERDataGridView)
        Me.tbOrder.Controls.Add(Me.Label5)
        Me.tbOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbOrder.Location = New System.Drawing.Point(4, 45)
        Me.tbOrder.Name = "tbOrder"
        Me.tbOrder.Size = New System.Drawing.Size(1184, 769)
        Me.tbOrder.TabIndex = 4
        Me.tbOrder.Text = "Orders"
        Me.tbOrder.UseVisualStyleBackColor = True
        '
        'btnUpdateOrders
        '
        Me.btnUpdateOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUpdateOrders.Location = New System.Drawing.Point(729, 35)
        Me.btnUpdateOrders.Name = "btnUpdateOrders"
        Me.btnUpdateOrders.Size = New System.Drawing.Size(152, 54)
        Me.btnUpdateOrders.TabIndex = 13
        Me.btnUpdateOrders.Text = "Update"
        Me.btnUpdateOrders.UseVisualStyleBackColor = True
        '
        'btnCreateNewOrder
        '
        Me.btnCreateNewOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateNewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCreateNewOrder.Location = New System.Drawing.Point(887, 35)
        Me.btnCreateNewOrder.Name = "btnCreateNewOrder"
        Me.btnCreateNewOrder.Size = New System.Drawing.Size(274, 54)
        Me.btnCreateNewOrder.TabIndex = 12
        Me.btnCreateNewOrder.Text = "Create New Order"
        Me.btnCreateNewOrder.UseVisualStyleBackColor = True
        '
        'AORDERDataGridView
        '
        Me.AORDERDataGridView.AllowUserToAddRows = False
        Me.AORDERDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AORDERDataGridView.AutoGenerateColumns = False
        Me.AORDERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AORDERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDERIDDataGridViewTextBoxColumn, Me.USERIDDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn, Me.CREATEDDataGridViewTextBoxColumn})
        Me.AORDERDataGridView.DataSource = Me.AORDERBindingSource
        Me.AORDERDataGridView.Location = New System.Drawing.Point(15, 95)
        Me.AORDERDataGridView.Name = "AORDERDataGridView"
        Me.AORDERDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AORDERDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AORDERDataGridView.Size = New System.Drawing.Size(1146, 651)
        Me.AORDERDataGridView.TabIndex = 9
        '
        'ORDERIDDataGridViewTextBoxColumn
        '
        Me.ORDERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ORDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn.HeaderText = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn.Name = "ORDERIDDataGridViewTextBoxColumn"
        Me.ORDERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USERIDDataGridViewTextBoxColumn
        '
        Me.USERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.USERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.Name = "USERIDDataGridViewTextBoxColumn"
        Me.USERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        Me.TOTALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CREATEDDataGridViewTextBoxColumn
        '
        Me.CREATEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CREATEDDataGridViewTextBoxColumn.DataPropertyName = "CREATED"
        Me.CREATEDDataGridViewTextBoxColumn.HeaderText = "CREATED"
        Me.CREATEDDataGridViewTextBoxColumn.Name = "CREATEDDataGridViewTextBoxColumn"
        Me.CREATEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AORDERBindingSource
        '
        Me.AORDERBindingSource.DataMember = "AORDER"
        Me.AORDERBindingSource.DataSource = Me.DataSetTG
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 38)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Orders"
        '
        'tbUser
        '
        Me.tbUser.AutoScroll = True
        Me.tbUser.BackColor = System.Drawing.Color.Transparent
        Me.tbUser.Controls.Add(Me.btnSaveUser)
        Me.tbUser.Controls.Add(Me.btnUpdate)
        Me.tbUser.Controls.Add(Me.btnNewUser)
        Me.tbUser.Controls.Add(Me.AUSERDataGridView)
        Me.tbUser.Controls.Add(Me.Label6)
        Me.tbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbUser.Location = New System.Drawing.Point(4, 45)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(1184, 769)
        Me.tbUser.TabIndex = 5
        Me.tbUser.Text = "Users"
        Me.tbUser.UseVisualStyleBackColor = True
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSaveUser.Location = New System.Drawing.Point(568, 161)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(152, 54)
        Me.btnSaveUser.TabIndex = 15
        Me.btnSaveUser.Text = "Save"
        Me.btnSaveUser.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(726, 161)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(152, 54)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnNewUser.Location = New System.Drawing.Point(884, 161)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(281, 54)
        Me.btnNewUser.TabIndex = 10
        Me.btnNewUser.Text = "Create New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'AUSERDataGridView
        '
        Me.AUSERDataGridView.AllowUserToAddRows = False
        Me.AUSERDataGridView.AllowUserToResizeRows = False
        Me.AUSERDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AUSERDataGridView.AutoGenerateColumns = False
        Me.AUSERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AUSERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AUSERDataGridView.DataSource = Me.AUSERBindingSource
        Me.AUSERDataGridView.Location = New System.Drawing.Point(15, 221)
        Me.AUSERDataGridView.Name = "AUSERDataGridView"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AUSERDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.AUSERDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.AUSERDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AUSERDataGridView.Size = New System.Drawing.Size(1150, 540)
        Me.AUSERDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "USER_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "USER_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TEL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TEL"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ADMIN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ADMIN"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PASSWORD"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PASSWORD"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'AUSERBindingSource
        '
        Me.AUSERBindingSource.DataMember = "AUSER"
        Me.AUSERBindingSource.DataSource = Me.DataSetTG
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 38)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Users"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIlToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1192, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIlToolStripMenuItem
        '
        Me.FIlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FIlToolStripMenuItem.Name = "FIlToolStripMenuItem"
        Me.FIlToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FIlToolStripMenuItem.Text = "FIle"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AUSERTableAdapter
        '
        Me.AUSERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AORDERTableAdapter = Me.AORDERTableAdapter
        Me.TableAdapterManager.AUSERTableAdapter = Me.AUSERTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CINEMATableAdapter = Me.CINEMATableAdapter
        Me.TableAdapterManager.EVENTTableAdapter = Me.EVENTTableAdapter
        Me.TableAdapterManager.HALLTableAdapter = Nothing
        Me.TableAdapterManager.MOVIETableAdapter = Me.MOVIETableAdapter
        Me.TableAdapterManager.SEATTableAdapter = Nothing
        Me.TableAdapterManager.SOTICKETTableAdapter = Me.SOTICKETTableAdapter
        Me.TableAdapterManager.UpdateOrder = TicketGenerator.DataSetTGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AORDERTableAdapter
        '
        Me.AORDERTableAdapter.ClearBeforeFill = True
        '
        'CINEMATableAdapter
        '
        Me.CINEMATableAdapter.ClearBeforeFill = True
        '
        'EVENTTableAdapter
        '
        Me.EVENTTableAdapter.ClearBeforeFill = True
        '
        'MOVIETableAdapter
        '
        Me.MOVIETableAdapter.ClearBeforeFill = True
        '
        'SOTICKETTableAdapter
        '
        Me.SOTICKETTableAdapter.ClearBeforeFill = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 778)
        Me.Controls.Add(Me.tabSet)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1000, 768)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET Ticket Generator - Administrator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabSet.ResumeLayout(False)
        Me.tbCinema.ResumeLayout(False)
        Me.tbCinema.PerformLayout()
        CType(Me.CINEMADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CINEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMovie.ResumeLayout(False)
        Me.tbMovie.PerformLayout()
        CType(Me.MOVIEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbEvent.ResumeLayout(False)
        Me.tbEvent.PerformLayout()
        CType(Me.EVENTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTicket.ResumeLayout(False)
        Me.tbTicket.PerformLayout()
        CType(Me.SOTICKETDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOTICKETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOrder.ResumeLayout(False)
        Me.tbOrder.PerformLayout()
        CType(Me.AORDERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AORDERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbUser.ResumeLayout(False)
        Me.tbUser.PerformLayout()
        CType(Me.AUSERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUSERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabSet As System.Windows.Forms.TabControl
    Friend WithEvents tbCinema As System.Windows.Forms.TabPage
    Friend WithEvents tbMovie As System.Windows.Forms.TabPage
    Friend WithEvents tbEvent As System.Windows.Forms.TabPage
    Friend WithEvents tbTicket As System.Windows.Forms.TabPage
    Friend WithEvents tbOrder As System.Windows.Forms.TabPage
    Friend WithEvents tbUser As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FIlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSetTG As TicketGenerator.DataSetTG
    Friend WithEvents AUSERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AUSERTableAdapter As TicketGenerator.DataSetTGTableAdapters.AUSERTableAdapter
    Friend WithEvents TableAdapterManager As TicketGenerator.DataSetTGTableAdapters.TableAdapterManager
    Friend WithEvents AUSERDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents AORDERTableAdapter As TicketGenerator.DataSetTGTableAdapters.AORDERTableAdapter
    Friend WithEvents AORDERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AORDERDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SOTICKETTableAdapter As TicketGenerator.DataSetTGTableAdapters.SOTICKETTableAdapter
    Friend WithEvents SOTICKETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SOTICKETDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MOVIETableAdapter As TicketGenerator.DataSetTGTableAdapters.MOVIETableAdapter
    Friend WithEvents MOVIEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MOVIEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CINEMATableAdapter As TicketGenerator.DataSetTGTableAdapters.CINEMATableAdapter
    Friend WithEvents CINEMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CINEMADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EVENTTableAdapter As TicketGenerator.DataSetTGTableAdapters.EVENTTableAdapter
    Friend WithEvents EVENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents AORDERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateOrders As System.Windows.Forms.Button
    Friend WithEvents btnCreateNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnUpdateMovies As System.Windows.Forms.Button
    Friend WithEvents btnNewMovie As System.Windows.Forms.Button
    Friend WithEvents ORDERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CREATEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSaveMovie As System.Windows.Forms.Button
    Friend WithEvents btnSaveUser As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateTickets As System.Windows.Forms.Button
    Friend WithEvents btnCreateNewTicket As System.Windows.Forms.Button
End Class
