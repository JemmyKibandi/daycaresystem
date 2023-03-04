<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudent
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
        Me.components = New System.ComponentModel.Container()
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Workshop_IDLabel As System.Windows.Forms.Label
        Dim Institution_NameLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Me.BtnNewRecord = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATHDatabaseDataSet = New ATH_Eeg_and_Manage.ATHDatabaseDataSet()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Workshop_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Institution_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StudentTableAdapter = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager1 = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentBox = New System.Windows.Forms.GroupBox()
        Me.StudentSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Search2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Student_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Workshop_IDLabel = New System.Windows.Forms.Label()
        Institution_NameLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Location = New System.Drawing.Point(6, 26)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(92, 24)
        Student_IDLabel.TabIndex = 0
        Student_IDLabel.Text = "Child ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(6, 62)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(111, 24)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(6, 98)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(107, 24)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(6, 134)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(143, 24)
        Phone_NumberLabel.TabIndex = 6
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(6, 170)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(140, 24)
        Email_AddressLabel.TabIndex = 8
        Email_AddressLabel.Text = "Email Address:"
        '
        'Workshop_IDLabel
        '
        Workshop_IDLabel.AutoSize = True
        Workshop_IDLabel.Location = New System.Drawing.Point(6, 206)
        Workshop_IDLabel.Name = "Workshop_IDLabel"
        Workshop_IDLabel.Size = New System.Drawing.Size(79, 24)
        Workshop_IDLabel.TabIndex = 10
        Workshop_IDLabel.Text = "Day ID:"
        '
        'Institution_NameLabel
        '
        Institution_NameLabel.AutoSize = True
        Institution_NameLabel.Location = New System.Drawing.Point(6, 242)
        Institution_NameLabel.Name = "Institution_NameLabel"
        Institution_NameLabel.Size = New System.Drawing.Size(79, 24)
        Institution_NameLabel.TabIndex = 12
        Institution_NameLabel.Text = "Address:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(-4, 282)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(178, 24)
        CourseLabel.TabIndex = 14
        CourseLabel.Text = "Parent Designation:"
        '
        'BtnNewRecord
        '
        Me.BtnNewRecord.BackColor = System.Drawing.Color.Transparent
        Me.BtnNewRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewRecord.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewRecord.ForeColor = System.Drawing.Color.White
        Me.BtnNewRecord.Location = New System.Drawing.Point(542, 74)
        Me.BtnNewRecord.Name = "BtnNewRecord"
        Me.BtnNewRecord.Size = New System.Drawing.Size(118, 33)
        Me.BtnNewRecord.TabIndex = 27
        Me.BtnNewRecord.Text = "Add Record"
        Me.BtnNewRecord.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(542, 113)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(118, 33)
        Me.BtnAdd.TabIndex = 28
        Me.BtnAdd.Text = "Save Record"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(709, 164)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(75, 34)
        Me.BtnPrevious.TabIndex = 29
        Me.BtnPrevious.Text = "<<"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(709, 217)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 34)
        Me.BtnNext.TabIndex = 30
        Me.BtnNext.Text = ">>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(542, 231)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 34)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Delete Records"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Student_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Student_IDTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(Phone_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Phone_NumberTextBox)
        Me.GroupBox1.Controls.Add(Email_AddressLabel)
        Me.GroupBox1.Controls.Add(Me.Email_AddressTextBox)
        Me.GroupBox1.Controls.Add(Workshop_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Workshop_IDTextBox)
        Me.GroupBox1.Controls.Add(Institution_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Institution_NameTextBox)
        Me.GroupBox1.Controls.Add(CourseLabel)
        Me.GroupBox1.Controls.Add(Me.CourseTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 321)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Student_ID", True))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(172, 23)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(100, 30)
        Me.Student_IDTextBox.TabIndex = 1
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.ATHDatabaseDataSet
        '
        'ATHDatabaseDataSet
        '
        Me.ATHDatabaseDataSet.DataSetName = "ATHDatabaseDataSet"
        Me.ATHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(172, 59)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(330, 30)
        Me.First_NameTextBox.TabIndex = 3
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(172, 95)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(330, 30)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(172, 131)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(242, 30)
        Me.Phone_NumberTextBox.TabIndex = 7
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Email_Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(172, 167)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(343, 30)
        Me.Email_AddressTextBox.TabIndex = 9
        '
        'Workshop_IDTextBox
        '
        Me.Workshop_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Workshop_ID", True))
        Me.Workshop_IDTextBox.Location = New System.Drawing.Point(172, 203)
        Me.Workshop_IDTextBox.Name = "Workshop_IDTextBox"
        Me.Workshop_IDTextBox.Size = New System.Drawing.Size(100, 30)
        Me.Workshop_IDTextBox.TabIndex = 11
        '
        'Institution_NameTextBox
        '
        Me.Institution_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Institution_Name", True))
        Me.Institution_NameTextBox.Location = New System.Drawing.Point(172, 239)
        Me.Institution_NameTextBox.Name = "Institution_NameTextBox"
        Me.Institution_NameTextBox.Size = New System.Drawing.Size(343, 30)
        Me.Institution_NameTextBox.TabIndex = 13
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Course", True))
        Me.CourseTextBox.Location = New System.Drawing.Point(172, 275)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(343, 30)
        Me.CourseTextBox.TabIndex = 15
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 627)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(871, 30)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip
        '
        Me.ToolStrip.ForeColor = System.Drawing.Color.White
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(78, 25)
        Me.ToolStrip.Text = "Ready"
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Mentors1TableAdapter = Nothing
        Me.TableAdapterManager1.Mentors2TableAdapter = Nothing
        Me.TableAdapterManager1.Mentors3TableAdapter = Nothing
        Me.TableAdapterManager1.MentorsTableAdapter = Nothing
        Me.TableAdapterManager1.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.WorkshopTableAdapter = Nothing
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditBtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(542, 151)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(118, 33)
        Me.EditBtn.TabIndex = 34
        Me.EditBtn.Text = "Edit Record"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(542, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 34)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 39)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(756, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 39)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Log Out"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(10, 399)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.Size = New System.Drawing.Size(843, 222)
        Me.StudentDataGridView.TabIndex = 38
        '
        'StudentBox
        '
        Me.StudentBox.BackColor = System.Drawing.Color.Transparent
        Me.StudentBox.Controls.Add(Me.StudentSearch)
        Me.StudentBox.Controls.Add(Me.Label2)
        Me.StudentBox.Controls.Add(Me.Search2)
        Me.StudentBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StudentBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StudentBox.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentBox.ForeColor = System.Drawing.Color.White
        Me.StudentBox.Location = New System.Drawing.Point(542, 272)
        Me.StudentBox.Name = "StudentBox"
        Me.StudentBox.Size = New System.Drawing.Size(265, 121)
        Me.StudentBox.TabIndex = 39
        Me.StudentBox.TabStop = False
        Me.StudentBox.Text = "Grid Controls"
        '
        'StudentSearch
        '
        Me.StudentSearch.Location = New System.Drawing.Point(4, 61)
        Me.StudentSearch.Name = "StudentSearch"
        Me.StudentSearch.Size = New System.Drawing.Size(238, 30)
        Me.StudentSearch.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label2"
        '
        'Search2
        '
        Me.Search2.AutoSize = True
        Me.Search2.Location = New System.Drawing.Point(6, 29)
        Me.Search2.Name = "Search2"
        Me.Search2.Size = New System.Drawing.Size(72, 24)
        Me.Search2.TabIndex = 18
        Me.Search2.Text = "Search:"
        '
        'Timer2
        '
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Student_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Child_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Email_Address"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Email_Address"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Workshop_ID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Day_ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Institution_Name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Parent_Designation"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'FrmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATH_Eeg_and_Manage.My.Resources.Resources.erika_fletcher_YfNWGrQI3a4_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 657)
        Me.Controls.Add(Me.StudentBox)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnNewRecord)
        Me.Name = "FrmStudent"
        Me.Text = "StudentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentBox.ResumeLayout(False)
        Me.StudentBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNewRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ATHDatabaseDataSet As ATH_Eeg_and_Manage.ATHDatabaseDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager1 As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StudentBox As System.Windows.Forms.GroupBox
    Friend WithEvents StudentSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Search2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Student_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Workshop_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Institution_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CourseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
End Class
