<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogIn
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
        Me.RAMS = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.LogIn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RAMS
        '
        Me.RAMS.AutoSize = True
        Me.RAMS.BackColor = System.Drawing.Color.Transparent
        Me.RAMS.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMS.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RAMS.Location = New System.Drawing.Point(16, 391)
        Me.RAMS.Name = "RAMS"
        Me.RAMS.Size = New System.Drawing.Size(419, 25)
        Me.RAMS.TabIndex = 0
        Me.RAMS.Text = "Registration And Management System"
        Me.RAMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(327, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time"
        '
        'UserBox
        '
        Me.UserBox.BackColor = System.Drawing.Color.White
        Me.UserBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic)
        Me.UserBox.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.UserBox.Location = New System.Drawing.Point(306, 101)
        Me.UserBox.MaxLength = 20
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(143, 28)
        Me.UserBox.TabIndex = 2
        Me.UserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PassBox
        '
        Me.PassBox.BackColor = System.Drawing.Color.White
        Me.PassBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic)
        Me.PassBox.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.PassBox.Location = New System.Drawing.Point(306, 160)
        Me.PassBox.MaxLength = 20
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(143, 28)
        Me.PassBox.TabIndex = 3
        Me.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogIn
        '
        Me.LogIn.BackColor = System.Drawing.Color.White
        Me.LogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LogIn.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn.Location = New System.Drawing.Point(332, 194)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(86, 37)
        Me.LogIn.TabIndex = 4
        Me.LogIn.Text = "Log In"
        Me.LogIn.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(461, 23)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "Log In Page"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(84, 18)
        Me.ToolStripStatusLabel1.Text = "LogIn Page"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(310, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(310, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'FrmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ATH_Eeg_and_Manage.My.Resources.Resources.Logo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(461, 452)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LogIn)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RAMS)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogIn"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RAMS As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserBox As System.Windows.Forms.TextBox
    Friend WithEvents PassBox As System.Windows.Forms.TextBox
    Friend WithEvents LogIn As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
