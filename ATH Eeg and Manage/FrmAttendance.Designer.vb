<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAttendance))
        Me.ATHDatabaseDataSet = New ATH_Eeg_and_Manage.ATHDatabaseDataSet()
        Me.Mentors2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mentors2TableAdapter = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.Mentors2TableAdapter()
        Me.TableAdapterManager = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StudentTableAdapter = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.StudentTableAdapter()
        Me.WorkshopTableAdapter = New ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.WorkshopTableAdapter()
        Me.WorkshopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Wbox = New System.Windows.Forms.TextBox()
        Me.Mentors2DataGridView = New System.Windows.Forms.DataGridView()
        Me.WorkshopDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog3 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mentors2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkshopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mentors2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkshopDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ATHDatabaseDataSet
        '
        Me.ATHDatabaseDataSet.DataSetName = "ATHDatabaseDataSet"
        Me.ATHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mentors2BindingSource
        '
        Me.Mentors2BindingSource.DataMember = "Mentors2"
        Me.Mentors2BindingSource.DataSource = Me.ATHDatabaseDataSet
        '
        'Mentors2TableAdapter
        '
        Me.Mentors2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Mentors1TableAdapter = Nothing
        Me.TableAdapterManager.Mentors2TableAdapter = Me.Mentors2TableAdapter
        Me.TableAdapterManager.Mentors3TableAdapter = Nothing
        Me.TableAdapterManager.MentorsTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkshopTableAdapter = Me.WorkshopTableAdapter
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'WorkshopTableAdapter
        '
        Me.WorkshopTableAdapter.ClearBeforeFill = True
        '
        'WorkshopBindingSource
        '
        Me.WorkshopBindingSource.DataMember = "Workshop"
        Me.WorkshopBindingSource.DataSource = Me.ATHDatabaseDataSet
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(756, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 44)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(548, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(202, 44)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Print child"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(114, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(428, 33)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = "Search Children"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(548, 420)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(202, 33)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Print Day"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(548, 218)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 33)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Print Caregiver"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.Location = New System.Drawing.Point(114, 218)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(428, 33)
        Me.TextBox2.TabIndex = 30
        Me.TextBox2.Text = "Search Caregiver"
        '
        'Wbox
        '
        Me.Wbox.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wbox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Wbox.Location = New System.Drawing.Point(114, 420)
        Me.Wbox.Name = "Wbox"
        Me.Wbox.Size = New System.Drawing.Size(428, 33)
        Me.Wbox.TabIndex = 31
        Me.Wbox.Text = "Search Day"
        '
        'Mentors2DataGridView
        '
        Me.Mentors2DataGridView.AutoGenerateColumns = False
        Me.Mentors2DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Mentors2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mentors2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Mentors2DataGridView.DataSource = Me.Mentors2BindingSource
        Me.Mentors2DataGridView.Location = New System.Drawing.Point(12, 257)
        Me.Mentors2DataGridView.Name = "Mentors2DataGridView"
        Me.Mentors2DataGridView.Size = New System.Drawing.Size(849, 157)
        Me.Mentors2DataGridView.TabIndex = 31
        '
        'WorkshopDataGridView
        '
        Me.WorkshopDataGridView.AutoGenerateColumns = False
        Me.WorkshopDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WorkshopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkshopDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.WorkshopDataGridView.DataSource = Me.WorkshopBindingSource
        Me.WorkshopDataGridView.Location = New System.Drawing.Point(114, 459)
        Me.WorkshopDataGridView.Name = "WorkshopDataGridView"
        Me.WorkshopDataGridView.Size = New System.Drawing.Size(428, 220)
        Me.WorkshopDataGridView.TabIndex = 31
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument2
        '
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "WorkshopStudent"
        Me.StudentBindingSource1.DataSource = Me.WorkshopBindingSource
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource1
        Me.StudentDataGridView.Location = New System.Drawing.Point(12, 53)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.Size = New System.Drawing.Size(841, 159)
        Me.StudentDataGridView.TabIndex = 31
        '
        'PrintDocument3
        '
        '
        'PrintPreviewDialog3
        '
        Me.PrintPreviewDialog3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog3.Document = Me.PrintDocument3
        Me.PrintPreviewDialog3.Enabled = True
        Me.PrintPreviewDialog3.Icon = CType(resources.GetObject("PrintPreviewDialog3.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        Me.PrintPreviewDialog3.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Child_ID"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email_Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email_Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Workshop_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Day_ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Institution_Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Parent_designation"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mentor_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mentor_ID"
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
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "EmailAddress"
        Me.DataGridViewTextBoxColumn13.HeaderText = "EmailAddress"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Company"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "JobTitle"
        Me.DataGridViewTextBoxColumn15.HeaderText = "JobTitle"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Workshop_ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Day_ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Workshop_ID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Day_ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "WorkshopName"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Day_Name"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'FrmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.ATH_Eeg_and_Manage.My.Resources.Resources.Logo2
        Me.ClientSize = New System.Drawing.Size(898, 699)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.WorkshopDataGridView)
        Me.Controls.Add(Me.Mentors2DataGridView)
        Me.Controls.Add(Me.Wbox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAttendance"
        CType(Me.ATHDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mentors2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkshopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mentors2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkshopDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ATHDatabaseDataSet As ATH_Eeg_and_Manage.ATHDatabaseDataSet
    Friend WithEvents Mentors2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mentors2TableAdapter As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.Mentors2TableAdapter
    Friend WithEvents TableAdapterManager As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentTableAdapter As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents WorkshopTableAdapter As ATH_Eeg_and_Manage.ATHDatabaseDataSetTableAdapters.WorkshopTableAdapter
    Friend WithEvents WorkshopBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Wbox As System.Windows.Forms.TextBox
    Friend WithEvents Mentors2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WorkshopDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PrintPreviewDialog2 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents StudentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog3 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
End Class
