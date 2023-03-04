Imports System.Data.OleDb

Public Class FrmStudent
    Private message As String = String.Empty
    Private connectstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\OneDrive\Documents\DB\ATHDatabase.accdb"

    Private Sub StudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        TableAdapterManager1.UpdateAll(ATHDatabaseDataSet)
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ATHDatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.ATHDatabaseDataSet.Student)

        Timer2.Enabled = True
        
    End Sub

    Private Sub timer2_tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim count As Integer
        count = StudentBindingSource.Count()
        Label2.Text = "Out of " + count.ToString + " students"
    End Sub

    Private Sub SaveChanges(action As String)
        If String.IsNullOrWhiteSpace(First_NameTextBox.Text) Or String.IsNullOrWhiteSpace(Last_NameTextBox.Text) Or String.IsNullOrWhiteSpace(Phone_NumberTextBox.Text) Or String.IsNullOrWhiteSpace(Email_AddressTextBox.Text) Or String.IsNullOrWhiteSpace(Workshop_IDTextBox.Text) Or String.IsNullOrWhiteSpace(CourseTextBox.Text) Then
            message = "Incomplete records"
            SetToolStrip(message, False)
            Return
        End If
        Try
            'method instead of opening connection for each button'
            Using connection As New OleDbConnection(connectstring)
                Dim command As New OleDbCommand(connectstring, connection)
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    If action = "Add" Then
                        .CommandText = "INSERT INTO Student (First_Name, Last_Name, Phone_Number, Email_Address, Workshop_ID, Institution_Name, Course) VALUES(@First_Name, @Last_Name, @Phone_Number, @Email_Address, @Workshop_ID, @Institution_Name, @Course)"
                        message = "Record Added Successfully"
                    ElseIf action = "Edit" Then
                        .CommandText = "UPDATE Student SET First_Name = @First_Name, Last_Name = @Last_Name, Phone_Number = @Phone_Number, Email_Address = @Email_Address, Workshop_ID = @Workshop_ID, Institution_Name = @Institution_Name, Course = @Course WHERE Student_ID = @Student_ID"
                        message = "Record Update successfully"
                    ElseIf action = "Delete" Then
                        MessageBox.Show("Are you sure you want to delete", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If DialogResult.Yes Then
                            .CommandText = "DELETE FROM Student WHERE Student_ID = @Student_ID"
                            .Parameters.AddWithValue("@Student_ID", Student_IDTextBox.Text)
                            message = "Record Deleted Successfully"
                        Else
                            Return
                        End If
                    End If

                    .Parameters.AddWithValue("@First_Name", First_NameTextBox.Text)
                    .Parameters.AddWithValue("@Last_Name", Last_NameTextBox.Text)
                    .Parameters.AddWithValue("@Phone_Number", Phone_NumberTextBox.Text)
                    .Parameters.AddWithValue("@Email_Address", Email_AddressTextBox.Text)
                    .Parameters.AddWithValue("@WorkShop_ID", Workshop_IDTextBox.Text)
                    .Parameters.AddWithValue("@Institution_Name", Institution_NameTextBox.Text)
                    .Parameters.AddWithValue("@Course", CourseTextBox.Text)

                    If action = "Edit" Then
                        .Parameters.AddWithValue("@Student_ID", Student_IDTextBox.Text)
                    End If

                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End With
            End Using
        Catch ex As OleDbException
            message = ex.Message
            SetToolStrip(message, False)
        Catch ex As Exception
            message = ex.Message
            SetToolStrip(message, False)
        End Try
        SetToolStrip(message, True)
    End Sub

    Private Sub BtnNewRecord_Click(sender As Object, e As EventArgs) Handles BtnNewRecord.Click
        Me.StudentBindingSource.AddNew()
    End Sub


    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.StudentBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.StudentBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmHome.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            FrmLogIn.Show()
            Me.Hide()
        ElseIf MessageBox.Show("Not logged out", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        SaveChanges("Edit")
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        SaveChanges("Add")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveChanges("Delete")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Student_IDTextBox.Text = ""
            First_NameTextBox.Text = ""
            Last_NameTextBox.Text = ""
            Phone_NumberTextBox.Text = ""
            Email_AddressTextBox.Text = ""
            Workshop_IDTextBox.Text = ""
            Institution_NameTextBox.Text = ""
            CourseTextBox.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SetToolStrip(action As String, image As Boolean)
        ToolStrip.Text = action
        If image = True Then
            ToolStrip.Image = My.Resources.Success
        Else
            ToolStrip.Image = My.Resources._error
        End If

    End Sub

    Private Sub StudentSearch_TextChanged(sender As Object, e As EventArgs) Handles StudentSearch.TextChanged
        Dim connection As New OleDbConnection(connectstring)
        Dim datatable As New DataTable
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("SELECT * FROM Student WHERE First_Name LIKE '%" & StudentSearch.Text & "%' or Last_Name LIKE '%" & StudentSearch.Text & "%' or Phone_Number LIKE '%" & StudentSearch.Text & "%'", connection)
        dataAdapter.Fill(datatable)

        StudentDataGridView.DataSource = datatable.DefaultView
        StudentDataGridView.Refresh()
    End Sub
End Class