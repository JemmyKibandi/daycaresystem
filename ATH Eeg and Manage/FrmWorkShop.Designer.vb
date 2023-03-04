<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWorkShop
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
        Dim Workshop_IDLabel As System.Windows.Forms.Label
        Dim WorkshopNameLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Search3 = New System.Windows.Forms.Label()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.WorkshopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATHDatabaseDataSet = New ATH_Eeg_and_Manage.ATHDatabaseDataSet()
        Me.BtnWDelete = New System.Windows.Forms.Button()
        Me.BtnWUpdate = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.OutBtn = New System.Windows.Forms.Button()
        Me.WorkshopTableAdapter = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.WorkshopTableAdapter()
        Me.TableAdapterManager = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.WorkshopDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Workshop_IDLabel = New System.Windows.Forms.Label()
        WorkshopNameLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WorkshopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkshopDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Workshop_IDLabel
        '
        Workshop_IDLabel.AutoSize = True
        Workshop_IDLabel.Location = New System.Drawing.Point(6, 19)
        Workshop_IDLabel.Name = "Workshop_IDLabel"
        Workshop_IDLabel.Size = New System.Drawing.Size(80, 21)
        Workshop_IDLabel.TabIndex = 0
        Workshop_IDLabel.Text = "Day ID:"
        '
        'WorkshopNameLabel
        '
        WorkshopNameLabel.AutoSize = True
        WorkshopNameLabel.Location = New System.Drawing.Point(6, 53)
        WorkshopNameLabel.Name = "WorkshopNameLabel"
        WorkshopNameLabel.Size = New System.Drawing.Size(104, 21)
        WorkshopNameLabel.TabIndex = 2
        WorkshopNameLabel.Text = "Day Name:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(6, 83)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(56, 21)
        CityLabel.TabIndex = 4
        CityLabel.Text = "Date:"
        '
        'BtnAdd
        '
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Location = New System.Drawing.Point(424, 90)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(121, 30)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add Record"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.White
        Me.HomeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(443, 434)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(121, 32)
        Me.HomeBtn.TabIndex = 4
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Location = New System.Drawing.Point(325, 145)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(44, 38)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "<<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Location = New System.Drawing.Point(375, 145)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(43, 38)
        Me.BtnNext.TabIndex = 6
        Me.BtnNext.Text = ">>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 507)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(576, 34)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip
        '
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(81, 29)
        Me.ToolStrip.Text = "Ready"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ClearBtn)
        Me.GroupBox1.Controls.Add(Me.Search3)
        Me.GroupBox1.Controls.Add(Me.SearchText)
        Me.GroupBox1.Controls.Add(Workshop_IDLabel)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.BtnWDelete)
        Me.GroupBox1.Controls.Add(Me.BtnNext)
        Me.GroupBox1.Controls.Add(WorkshopNameLabel)
        Me.GroupBox1.Controls.Add(Me.BtnWUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 209)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(424, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 30)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(133, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        '
        'ClearBtn
        '
        Me.ClearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearBtn.Location = New System.Drawing.Point(424, 19)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(121, 29)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Search3
        '
        Me.Search3.AutoSize = True
        Me.Search3.ForeColor = System.Drawing.Color.Black
        Me.Search3.Location = New System.Drawing.Point(6, 119)
        Me.Search3.Name = "Search3"
        Me.Search3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Search3.Size = New System.Drawing.Size(74, 21)
        Me.Search3.TabIndex = 19
        Me.Search3.Text = "Search:"
        '
        'SearchText
        '
        Me.SearchText.Location = New System.Drawing.Point(10, 151)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(309, 28)
        Me.SearchText.TabIndex = 20
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkshopBindingSource, "Workshop_ID", True))
        Me.txtID.Location = New System.Drawing.Point(184, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(75, 28)
        Me.txtID.TabIndex = 1
        '
        'WorkshopBindingSource
        '
        Me.WorkshopBindingSource.DataMember = "Workshop"
        Me.WorkshopBindingSource.DataSource = Me.ATHDatabaseDataSet
        '
        'ATHDatabaseDataSet
        '
        Me.ATHDatabaseDataSet.DataSetName = "ATHDatabaseDataSet"
        Me.ATHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnWDelete
        '
        Me.BtnWDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnWDelete.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnWDelete.Location = New System.Drawing.Point(436, 164)
        Me.BtnWDelete.Name = "BtnWDelete"
        Me.BtnWDelete.Size = New System.Drawing.Size(109, 32)
        Me.BtnWDelete.TabIndex = 8
        Me.BtnWDelete.Text = "Delete"
        Me.BtnWDelete.UseVisualStyleBackColor = True
        '
        'BtnWUpdate
        '
        Me.BtnWUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnWUpdate.ForeColor = System.Drawing.Color.Black
        Me.BtnWUpdate.Location = New System.Drawing.Point(443, 126)
        Me.BtnWUpdate.Name = "BtnWUpdate"
        Me.BtnWUpdate.Size = New System.Drawing.Size(102, 32)
        Me.BtnWUpdate.TabIndex = 6
        Me.BtnWUpdate.Text = "Update"
        Me.BtnWUpdate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkshopBindingSource, "WorkshopName", True))
        Me.txtName.Location = New System.Drawing.Point(184, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(234, 28)
        Me.txtName.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkshopBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(184, 84)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(162, 28)
        Me.txtCity.TabIndex = 5
        '
        'OutBtn
        '
        Me.OutBtn.BackColor = System.Drawing.Color.White
        Me.OutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OutBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutBtn.Location = New System.Drawing.Point(443, 472)
        Me.OutBtn.Name = "OutBtn"
        Me.OutBtn.Size = New System.Drawing.Size(121, 32)
        Me.OutBtn.TabIndex = 8
        Me.OutBtn.Text = "Log Out"
        Me.OutBtn.UseVisualStyleBackColor = False
        '
        'WorkshopTableAdapter
        '
        Me.WorkshopTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Mentors1TableAdapter = Nothing
        Me.TableAdapterManager.Mentors2TableAdapter = Nothing
        Me.TableAdapterManager.Mentors3TableAdapter = Nothing
        Me.TableAdapterManager.MentorsTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkshopTableAdapter = Me.WorkshopTableAdapter
        '
        'WorkshopDataGridView
        '
        Me.WorkshopDataGridView.AutoGenerateColumns = False
        Me.WorkshopDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WorkshopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkshopDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.WorkshopDataGridView.DataSource = Me.WorkshopBindingSource
        Me.WorkshopDataGridView.Location = New System.Drawing.Point(12, 227)
        Me.WorkshopDataGridView.Name = "WorkshopDataGridView"
        Me.WorkshopDataGridView.Size = New System.Drawing.Size(419, 277)
        Me.WorkshopDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Workshop_ID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Workshop_ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "WorkshopName"
        Me.DataGridViewTextBoxColumn18.HeaderText = "WorkshopName"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn19.HeaderText = "City"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Timer3
        '
        '
        'FrmWorkShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATH_Eeg_and_Manage.My.Resources.Resources.Logo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.HomeBtn
        Me.ClientSize = New System.Drawing.Size(576, 541)
        Me.Controls.Add(Me.OutBtn)
        Me.Controls.Add(Me.WorkshopDataGridView)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWorkShop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WorkShop"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.WorkshopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkshopDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents HomeBtn As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ATHDatabaseDataSet As ATH_Eeg_and_Manage.ATHDatabaseDataSet
    Friend WithEvents WorkshopBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkshopTableAdapter As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.WorkshopTableAdapter
    Friend WithEvents TableAdapterManager As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents OutBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchText As System.Windows.Forms.TextBox
    Friend WithEvents Search3 As System.Windows.Forms.Label
    Friend WithEvents BtnWUpdate As System.Windows.Forms.Button
    Friend WithEvents WorkshopDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents BtnWDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
