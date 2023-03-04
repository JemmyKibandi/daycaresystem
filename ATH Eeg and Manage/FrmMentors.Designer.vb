<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMentors
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
        Dim Mentor_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim CompanyLabel As System.Windows.Forms.Label
        Dim JobTitleLabel As System.Windows.Forms.Label
        Dim Workshop_IDLabel As System.Windows.Forms.Label
        Me.ATHDatabaseDataSet = New ATH_Eeg_and_Manage.ATHDatabaseDataSet()
        Me.MentorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MentorsTableAdapter = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.MentorsTableAdapter()
        Me.TableAdapterManager = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Mentor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Mentors2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.JobTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Workshop_IDTextBox = New System.Windows.Forms.TextBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnOut = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Mentors2TableAdapter = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.Mentors2TableAdapter()
        Me.Mentors2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MentorBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MentorSearch = New System.Windows.Forms.TextBox()
        Me.Search1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Mentor_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        CompanyLabel = New System.Windows.Forms.Label()
        JobTitleLabel = New System.Windows.Forms.Label()
        Workshop_IDLabel = New System.Windows.Forms.Label()
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MentorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Mentors2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Mentors2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MentorBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mentor_IDLabel
        '
        Mentor_IDLabel.AutoSize = True
        Mentor_IDLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mentor_IDLabel.Location = New System.Drawing.Point(6, 32)
        Mentor_IDLabel.Name = "Mentor_IDLabel"
        Mentor_IDLabel.Size = New System.Drawing.Size(125, 21)
        Mentor_IDLabel.TabIndex = 18
        Mentor_IDLabel.Text = "Caregiver ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(6, 77)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(112, 21)
        First_NameLabel.TabIndex = 20
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(6, 119)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(108, 21)
        Last_NameLabel.TabIndex = 22
        Last_NameLabel.Text = "Last Name:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel.Location = New System.Drawing.Point(6, 161)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(143, 21)
        PhoneNumberLabel.TabIndex = 24
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailAddressLabel.Location = New System.Drawing.Point(6, 203)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(141, 21)
        EmailAddressLabel.TabIndex = 26
        EmailAddressLabel.Text = "Email Address:"
        '
        'CompanyLabel
        '
        CompanyLabel.AutoSize = True
        CompanyLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CompanyLabel.Location = New System.Drawing.Point(6, 245)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(47, 21)
        CompanyLabel.TabIndex = 28
        CompanyLabel.Text = "Age:"
        '
        'JobTitleLabel
        '
        JobTitleLabel.AutoSize = True
        JobTitleLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JobTitleLabel.Location = New System.Drawing.Point(6, 287)
        JobTitleLabel.Name = "JobTitleLabel"
        JobTitleLabel.Size = New System.Drawing.Size(94, 21)
        JobTitleLabel.TabIndex = 30
        JobTitleLabel.Text = "Job Title:"
        '
        'Workshop_IDLabel
        '
        Workshop_IDLabel.AutoSize = True
        Workshop_IDLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Workshop_IDLabel.Location = New System.Drawing.Point(6, 329)
        Workshop_IDLabel.Name = "Workshop_IDLabel"
        Workshop_IDLabel.Size = New System.Drawing.Size(80, 21)
        Workshop_IDLabel.TabIndex = 32
        Workshop_IDLabel.Text = "Day ID:"
        '
        'ATHDatabaseDataSet
        '
        Me.ATHDatabaseDataSet.DataSetName = "ATHDatabaseDataSet"
        Me.ATHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MentorsBindingSource
        '
        Me.MentorsBindingSource.DataMember = "Mentors"
        Me.MentorsBindingSource.DataSource = Me.ATHDatabaseDataSet
        '
        'MentorsTableAdapter
        '
        Me.MentorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Mentors1TableAdapter = Nothing
        Me.TableAdapterManager.Mentors2TableAdapter = Nothing
        Me.TableAdapterManager.Mentors3TableAdapter = Nothing
        Me.TableAdapterManager.MentorsTableAdapter = Me.MentorsTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkshopTableAdapter = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Mentor_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Mentor_IDTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(EmailAddressLabel)
        Me.GroupBox1.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox1.Controls.Add(CompanyLabel)
        Me.GroupBox1.Controls.Add(Me.CompanyTextBox)
        Me.GroupBox1.Controls.Add(JobTitleLabel)
        Me.GroupBox1.Controls.Add(Me.JobTitleTextBox)
        Me.GroupBox1.Controls.Add(Workshop_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Workshop_IDTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 361)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Mentor_IDTextBox
        '
        Me.Mentor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "Mentor_ID", True))
        Me.Mentor_IDTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mentor_IDTextBox.Location = New System.Drawing.Point(148, 29)
        Me.Mentor_IDTextBox.Name = "Mentor_IDTextBox"
        Me.Mentor_IDTextBox.Size = New System.Drawing.Size(100, 28)
        Me.Mentor_IDTextBox.TabIndex = 19
        '
        'Mentors2BindingSource
        '
        Me.Mentors2BindingSource.DataMember = "Mentors2"
        Me.Mentors2BindingSource.DataSource = Me.ATHDatabaseDataSet
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(148, 71)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(334, 28)
        Me.First_NameTextBox.TabIndex = 21
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(148, 113)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(334, 28)
        Me.Last_NameTextBox.TabIndex = 23
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(148, 155)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(225, 28)
        Me.PhoneNumberTextBox.TabIndex = 25
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(148, 197)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(334, 28)
        Me.EmailAddressTextBox.TabIndex = 27
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "Company", True))
        Me.CompanyTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyTextBox.Location = New System.Drawing.Point(148, 239)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(334, 28)
        Me.CompanyTextBox.TabIndex = 29
        '
        'JobTitleTextBox
        '
        Me.JobTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "JobTitle", True))
        Me.JobTitleTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobTitleTextBox.Location = New System.Drawing.Point(148, 281)
        Me.JobTitleTextBox.Name = "JobTitleTextBox"
        Me.JobTitleTextBox.Size = New System.Drawing.Size(334, 28)
        Me.JobTitleTextBox.TabIndex = 31
        '
        'Workshop_IDTextBox
        '
        Me.Workshop_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mentors2BindingSource, "Workshop_ID", True))
        Me.Workshop_IDTextBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Workshop_IDTextBox.Location = New System.Drawing.Point(148, 323)
        Me.Workshop_IDTextBox.Name = "Workshop_IDTextBox"
        Me.Workshop_IDTextBox.Size = New System.Drawing.Size(100, 28)
        Me.Workshop_IDTextBox.TabIndex = 33
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Black
        Me.BtnNext.Location = New System.Drawing.Point(729, 209)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(93, 69)
        Me.BtnNext.TabIndex = 18
        Me.BtnNext.Text = ">>>"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrevious.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Black
        Me.BtnPrevious.Location = New System.Drawing.Point(729, 114)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(93, 69)
        Me.BtnPrevious.TabIndex = 17
        Me.BtnPrevious.Text = "<<<"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddNew.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNew.Location = New System.Drawing.Point(500, 94)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(167, 39)
        Me.BtnAddNew.TabIndex = 18
        Me.BtnAddNew.Text = "Save Record"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAddNew.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Location = New System.Drawing.Point(500, 49)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(167, 39)
        Me.BtnAdd.TabIndex = 19
        Me.BtnAdd.Text = "Add Record"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Location = New System.Drawing.Point(500, 144)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(167, 39)
        Me.BtnEdit.TabIndex = 20
        Me.BtnEdit.Text = "Edit Record"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDelete.Location = New System.Drawing.Point(500, 242)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(190, 39)
        Me.BtnDelete.TabIndex = 21
        Me.BtnDelete.Text = "Delete Record"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.Transparent
        Me.BtnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHome.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.Location = New System.Drawing.Point(6, 2)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(121, 39)
        Me.BtnHome.TabIndex = 22
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 610)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(882, 30)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip
        '
        Me.ToolStrip.ForeColor = System.Drawing.Color.White
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(78, 25)
        Me.ToolStrip.Text = "Ready"
        '
        'BtnOut
        '
        Me.BtnOut.BackColor = System.Drawing.Color.Transparent
        Me.BtnOut.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOut.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOut.ForeColor = System.Drawing.Color.White
        Me.BtnOut.Location = New System.Drawing.Point(753, 2)
        Me.BtnOut.Name = "BtnOut"
        Me.BtnOut.Size = New System.Drawing.Size(121, 39)
        Me.BtnOut.TabIndex = 24
        Me.BtnOut.Text = "Log Out"
        Me.BtnOut.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.Transparent
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearBtn.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(572, 196)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(95, 39)
        Me.ClearBtn.TabIndex = 25
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Mentors2TableAdapter
        '
        Me.Mentors2TableAdapter.ClearBeforeFill = True
        '
        'Mentors2DataGridView
        '
        Me.Mentors2DataGridView.AutoGenerateColumns = False
        Me.Mentors2DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Mentors2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mentors2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Mentors2DataGridView.DataSource = Me.Mentors2BindingSource
        Me.Mentors2DataGridView.Location = New System.Drawing.Point(6, 402)
        Me.Mentors2DataGridView.Name = "Mentors2DataGridView"
        Me.Mentors2DataGridView.Size = New System.Drawing.Size(843, 205)
        Me.Mentors2DataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Mentor_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Caregiver_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EmailAddress"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EmailAddress"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Company"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "JobTitle"
        Me.DataGridViewTextBoxColumn7.HeaderText = "JobTitle"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Workshop_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Day_ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'MentorBox
        '
        Me.MentorBox.BackColor = System.Drawing.Color.Transparent
        Me.MentorBox.Controls.Add(Me.Label1)
        Me.MentorBox.Controls.Add(Me.MentorSearch)
        Me.MentorBox.Controls.Add(Me.Search1)
        Me.MentorBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MentorBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MentorBox.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MentorBox.ForeColor = System.Drawing.Color.White
        Me.MentorBox.Location = New System.Drawing.Point(505, 292)
        Me.MentorBox.Name = "MentorBox"
        Me.MentorBox.Size = New System.Drawing.Size(344, 104)
        Me.MentorBox.TabIndex = 27
        Me.MentorBox.TabStop = False
        Me.MentorBox.Text = "Grid Controls"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Label1"
        '
        'MentorSearch
        '
        Me.MentorSearch.Location = New System.Drawing.Point(6, 58)
        Me.MentorSearch.Name = "MentorSearch"
        Me.MentorSearch.Size = New System.Drawing.Size(329, 30)
        Me.MentorSearch.TabIndex = 21
        '
        'Search1
        '
        Me.Search1.AutoSize = True
        Me.Search1.Location = New System.Drawing.Point(6, 28)
        Me.Search1.Name = "Search1"
        Me.Search1.Size = New System.Drawing.Size(72, 24)
        Me.Search1.TabIndex = 17
        Me.Search1.Text = "Search:"
        '
        'Timer1
        '
        '
        'FrmMentors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.ATH_Eeg_and_Manage.My.Resources.Resources.erika_fletcher_YfNWGrQI3a4_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnHome
        Me.ClientSize = New System.Drawing.Size(882, 640)
        Me.Controls.Add(Me.MentorBox)
        Me.Controls.Add(Me.Mentors2DataGridView)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.BtnOut)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMentors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMentors"
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MentorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Mentors2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Mentors2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MentorBox.ResumeLayout(False)
        Me.MentorBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ATHDatabaseDataSet As ATH_Eeg_and_Manage.ATHDatabaseDataSet
    Friend WithEvents MentorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MentorsTableAdapter As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.MentorsTableAdapter
    Friend WithEvents TableAdapterManager As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtnOut As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Mentors2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mentors2TableAdapter As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.Mentors2TableAdapter
    Friend WithEvents Mentor_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Workshop_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mentors2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MentorBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MentorSearch As System.Windows.Forms.TextBox
    Friend WithEvents Search1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
