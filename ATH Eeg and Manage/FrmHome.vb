Imports System.Data.OleDb

Public Class FrmHome
    Private connectstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\USER\OneDrive\Documents\DB\ATHRAMS.mdb"

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub LogOutButt_Click(sender As Object, e As EventArgs) Handles LogOutButt.Click
        If MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            FrmLogIn.Show()
            Me.Hide()
        ElseIf MessageBox.Show("Not logged out", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Me.Show()
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmStudent.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmMentors.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmWorkShop.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmAttendance.Show()
        Me.Hide()
    End Sub
End Class