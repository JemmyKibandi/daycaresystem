Imports System.Data.OleDb
Public Class FrmAttendance
    Private message As String = String.Empty
    Private connectstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\OneDrive\Documents\DB\ATHDatabase.accdb"

    Private bitmap As Bitmap

    Private Sub Mentors2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Mentors2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ATHDatabaseDataSet)

    End Sub

    Private Sub StudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource1.EndEdit()
        TableAdapterManager.UpdateAll(ATHDatabaseDataSet)
    End Sub

    Private Sub WorkshopBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WorkshopBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ATHDatabaseDataSet)

    End Sub

    Private Sub FrmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ATHDatabaseDataSet.Workshop' table. You can move, or remove it, as needed.
        Me.WorkshopTableAdapter.Fill(Me.ATHDatabaseDataSet.Workshop)
        'TODO: This line of code loads data into the 'ATHDatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.ATHDatabaseDataSet.Student)
        'TODO: This line of code loads data into the 'ATHDatabaseDataSet.Mentors2' table. You can move, or remove it, as needed.
        Me.Mentors2TableAdapter.Fill(Me.ATHDatabaseDataSet.Mentors2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            FrmLogIn.Show()
            Me.Hide()
        ElseIf MessageBox.Show("Not logged out", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.StudentDataGridView.Width, Me.StudentDataGridView.Height)
        StudentDataGridView.DrawToBitmap(bm, New Rectangle(30, 30, Me.StudentDataGridView.Width, Me.StudentDataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim connection As New OleDbConnection(connectstring)
        Dim command As New OleDbCommand(connectstring, connection)
        Dim datatable As New DataTable
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("SELECT * FROM Student WHERE First_Name LIKE '%" & TextBox1.Text & "%' or Last_Name LIKE '%" & TextBox1.Text & "%' or Workshop_ID LIKE '%" & TextBox1.Text & "%'", connection)
        dataAdapter.Fill(datatable)

        StudentDataGridView.DataSource = datatable.DefaultView
        StudentDataGridView.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintPreviewDialog2.ShowDialog()
        PrintDocument2.Print()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim bm As New Bitmap(Me.Mentors2DataGridView.Width, Me.Mentors2DataGridView.Height)
        Mentors2DataGridView.DrawToBitmap(bm, New Rectangle(30, 30, Me.Mentors2DataGridView.Width, Me.Mentors2DataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim connection As New OleDbConnection(connectstring)
        Dim datatable As New DataTable
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("SELECT * FROM Mentors WHERE First_Name LIKE '%" & TextBox2.Text & "%' or Last_Name LIKE '%" & TextBox2.Text & "%' or Workshop_ID LIKE '%" & TextBox2.Text & "%'", connection)
        dataAdapter.Fill(datatable)

        Mentors2DataGridView.DataSource = datatable.DefaultView
        Mentors2DataGridView.Refresh()
    End Sub

    Private Sub wbox_click(sender As Object, e As EventArgs) Handles Wbox.Click
        Wbox.Text = ""
    End Sub

    Private Sub TextBox2_click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox1_click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog3.ShowDialog()
        PrintDocument3.Print()
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim bm As New Bitmap(Me.WorkshopDataGridView.Width, Me.WorkshopDataGridView.Height)
        WorkshopDataGridView.DrawToBitmap(bm, New Rectangle(30, 30, Me.WorkshopDataGridView.Width, Me.WorkshopDataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Wbox_TextChanged(sender As Object, e As EventArgs) Handles Wbox.TextChanged
        Dim connection As New OleDbConnection(connectstring)
        Dim datatable As New DataTable
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("SELECT * FROM WorkShop WHERE WorkShopName LIKE '%" & Wbox.Text & "%'or Workshop_ID LIKE '%" & Wbox.Text & "%'", connection)
        dataAdapter.Fill(datatable)

        WorkshopDataGridView.DataSource = datatable.DefaultView
        WorkshopDataGridView.Refresh()
    End Sub
End Class