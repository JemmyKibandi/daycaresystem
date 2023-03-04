Public Class FrmLogIn
    Dim username As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Enabled = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        If UserBox.Text = "Admin" And PassBox.Text = "ATHManage" Then
            ToolStripStatusLabel1.Text = "Welcome Administrator"
            FrmHome.Show()
            Me.Hide()
        ElseIf UserBox.Text = "Student" And PassBox.Text = "Student" Then
            ToolStripStatusLabel1.Text = "Welcome"
            FrmAttendance.Show()
            Me.Hide()
        ElseIf UserBox.Text = "Mentor" And PassBox.Text = "Mentor" Then
            ToolStripStatusLabel1.Text = "Welcome"
            FrmAttendance.Show()
            Me.Hide()
        Else
            ToolStripStatusLabel1.Text = "Invalid Username/Password"
            Try
                UserBox.Text = ""
                PassBox.Text = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
