Imports System.Data.OleDb

Public Class FrmWorkShop
    Private message As String = String.Empty
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\OneDrive\Documents\DB\ATHDatabase.accdb"

    Private Sub WorkshopBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WorkshopBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ATHDatabaseDataSet)

    End Sub

    Private Sub FrmWorkShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ATHDatabaseDataSet.Workshop' table. You can move, or remove it, as needed.
        Me.WorkshopTableAdapter.Fill(Me.ATHDatabaseDataSet.Workshop)

        Timer3.Enabled = True

    End Sub
    Private Sub SaveChanges(action As String)
        If String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(txtCity.Text) Then
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
                        .CommandText = "INSERT INTO WorkShop (WorkShopName, City) VALUES(@WorkShopName, @City)"
                        message = "Record Added Successfully"
                    ElseIf action = "Edit" Then
                        .CommandText = "UPDATE WorkShop SET WorkShopName = @WorkShopName, City = @City WHERE WorkShop_ID = @WorkShop_ID"
                        message = "Record Update successfully"
                    ElseIf action = "Delete" Then
                        MessageBox.Show("Are you sure you want to delete this record?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If DialogResult.Yes Then
                            .CommandText = "DELETE FROM WorkShop WHERE WorkShop_ID = @WorkShop_ID"
                            .Parameters.AddWithValue("@WorkShop_ID", txtID.Text)
                            message = "Record Deleted successfully"
                        Else
                            Return
                        End If
                    End If

                        .Parameters.AddWithValue("@WorkShopName", txtName.Text)
                        .Parameters.AddWithValue("@City", txtCity.Text)

                        If action = "Edit" Then
                            .Parameters.AddWithValue("@WorkShop_ID", txtID.Text)
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

    Private Sub BtnNew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.WorkshopBindingSource.AddNew()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.WorkshopBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.WorkshopBindingSource.MoveNext()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        FrmHome.Show()
        Me.Hide()
    End Sub
    Private Sub SetToolStrip(action As String, image As Boolean)
        ToolStrip.Text = action
        If image = True Then
            ToolStrip.Image = My.Resources.Success
        Else
            ToolStrip.Image = My.Resources._error
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        txtID.Text = ""
        txtName.Text = ""
        txtCity.Text = ""
    End Sub

    Private Sub OutBtn_Click(sender As Object, e As EventArgs) Handles OutBtn.Click
        If MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            FrmLogIn.Show()
            Me.Hide()
        ElseIf MessageBox.Show("Not logged out", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Me.Show()
        End If

    End Sub

    Private Sub timer3_tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim count As Integer
        count = WorkshopBindingSource.Count()
        Label3.Text = "Out of " + count.ToString + " workshops"
    End Sub

    Private Sub WkshpSearch_TextChanged(sender As Object, e As EventArgs) Handles SearchText.TextChanged
        Dim connection As New OleDbConnection(connectionString)
        Dim datatable As New DataTable
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("SELECT * FROM WorkShop WHERE WorkShopName LIKE '%" & SearchText.Text & "%'", connection)
        dataAdapter.Fill(datatable)

        WorkshopDataGridView.DataSource = datatable.DefaultView
        WorkshopDataGridView.Refresh()
    End Sub

    Private Sub WorkshopDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles WorkshopDataGridView.RowHeaderMouseClick
        txtID.Text = WorkshopDataGridView.SelectedCells(0).FormattedValue.ToString()
        txtName.Text = WorkshopDataGridView.SelectedCells(1).FormattedValue.ToString()
        txtCity.Text = WorkshopDataGridView.SelectedCells(0).FormattedValue.ToString()
        WorkshopDataGridView.Refresh()
    End Sub

    Private Sub BtnWUpdate_Click(sender As Object, e As EventArgs) Handles BtnWUpdate.Click
        SaveChanges("Edit")
    End Sub

    Private Sub BtnWDelete_Click(sender As Object, e As EventArgs) Handles BtnWDelete.Click
        SaveChanges("Delete")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveChanges("Add")
    End Sub
End Class