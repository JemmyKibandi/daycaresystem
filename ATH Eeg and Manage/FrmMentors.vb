Imports System.Data.OleDb

Public Class FrmMentors
    Private message As String = String.Empty
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\OneDrive\Documents\DB\ATHDatabase.accdb"

    Private Sub Mentors2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Mentors2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ATHDatabaseDataSet)

    End Sub

    Private Sub FrmMentors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ATHDatabaseDataSet.Mentors2' table. You can move, or remove it, as needed.
        Me.Mentors2TableAdapter.Fill(Me.ATHDatabaseDataSet.Mentors2)
        'TODO: This line of code loads data into the 'ATHDatabaseDataSet.Mentors' table. You can move, or remove it, as needed.
        Me.MentorsTableAdapter.Fill(Me.ATHDatabaseDataSet.Mentors)

        Timer1.Enabled = True
        
    End Sub

    Private Sub SaveChanges(action As String)
        If String.IsNullOrWhiteSpace(First_NameTextBox.Text) Or String.IsNullOrWhiteSpace(Last_NameTextBox.Text) Or String.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) Or String.IsNullOrWhiteSpace(EmailAddressTextBox.Text) Or String.IsNullOrWhiteSpace(CompanyTextBox.Text) Or String.IsNullOrWhiteSpace(JobTitleTextBox.Text) Or String.IsNullOrWhiteSpace(Workshop_IDTextBox.Text) Then
            message = "Incomplete records"
            SetToolStrip(message, False)
            Return
        End If
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim command As New OleDbCommand(connectionString, connection)

                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    If action = "Add" Then
                        .CommandText = "INSERT INTO Mentors (First_Name, Last_Name, PhoneNumber, EmailAddress, Company, JobTitle, Workshop_ID) VALUES(@First_Name, @Last_Name, @PhoneNumber, @EmailAddress, @Company, @JobTitle, @Workshop_ID)"
                        message = "Record Added successfully"
                    ElseIf action = "Edit" Then
                        .CommandText = "UPDATE Mentors SET First_Name = @First_Name, Last_Name = @Last_Name, PhoneNumber = @PhoneNumber,  EmailAddress = @EmailAddress, Company = @Company, JobTitle = @JobTitle, Workshop_ID = @Workshop_ID WHERE Mentor_ID = @Mentor_ID"
                        message = "Record Update successfully"
                    ElseIf action = "Delete" Then
                        MessageBox.Show("Are you sure you want to delete", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If DialogResult.Yes Then
                            .CommandText = "DELETE FROM Mentors WHERE Mentor_ID = @Mentor_ID"
                            .Parameters.AddWithValue("@Mentor_ID", Mentor_IDTextBox.Text)
                            message = "Record Deleted successfully"
                        Else
                            Return
                        End If
                    End If


                    .Parameters.AddWithValue("@First_Name", First_NameTextBox.Text)
                    .Parameters.AddWithValue("@Last_Name", Last_NameTextBox.Text)
                    .Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                    .Parameters.AddWithValue("@EmailAddress", EmailAddressTextBox.Text)
                    .Parameters.AddWithValue("@Company", CompanyTextBox.Text)
                    .Parameters.AddWithValue("@JobTitle", JobTitleTextBox.Text)
                    .Parameters.AddWithValue("@WorkShop_ID", Workshop_IDTextBox.Text)

                    If action = "Edit" Then
                        .Parameters.AddWithValue("@Mentor_ID", Mentor_IDTextBox.Text)
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

    Private Sub BtnOut_Click(sender As Object, e As EventArgs) Handles BtnOut.Click
        If MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            FrmLogIn.Show()
            Me.Hide()
        ElseIf MessageBox.Show("Not logged out", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Me.Show()
        End If

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        FrmHome.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.Mentors2BindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.Mentors2BindingSource.MoveNext()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.Mentors2BindingSource.AddNew()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        SaveChanges("Edit")
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        SaveChanges("Add")
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        SaveChanges("Delete")
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Try
            Mentor_IDTextBox.Text = ""
            First_NameTextBox.Text = ""
            Last_NameTextBox.Text = ""
            PhoneNumberTextBox.Text = ""
            EmailAddressTextBox.Text = ""
            CompanyTextBox.Text = ""
            JobTitleTextBox.Text = ""
            Workshop_IDTextBox.Text = ""
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

    Private Sub timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer
        count = Mentors2BindingSource.Count()
        Label1.Text = "Out of " + count.ToString + " mentors"
    End Sub
   
    Private Sub MentorSearch_TextChanged(sender As Object, e As EventArgs) Handles MentorSearch.TextChanged
        Dim connection As New OleDbConnection(connectionString)
        Dim datatable As New DataTable
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("SELECT * FROM Mentors WHERE First_Name LIKE '%" & MentorSearch.Text & "%' or Last_Name LIKE '%" & MentorSearch.Text & "%' or PhoneNumber LIKE '%" & MentorSearch.Text & "%'", connection)
        dataAdapter.Fill(datatable)

        Mentors2DataGridView.DataSource = datatable.DefaultView
        Mentors2DataGridView.Refresh()
    End Sub
End Class