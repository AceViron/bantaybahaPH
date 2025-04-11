Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Data
Imports System.Net.Http
Imports System.Threading.Tasks

Public Class Form7


    Private Async Sub LoadFirestoreData()
        ' Create HttpClient instance
        Using client As New HttpClient()
            Dim url As String = "https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/admin?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

            Try
                ' Send a GET request and await the response
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                response.EnsureSuccessStatusCode()

                ' Read the JSON response as a string
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON response
                Dim jsonData As Object = JsonConvert.DeserializeObject(jsonResponse)

                ' Create a DataTable and add columns
                Dim dataTable As New DataTable()
                dataTable.Columns.Add("useradmin")
                dataTable.Columns.Add("adminpassword")


                ' Parse the JSON data and add rows to the DataTable
                For Each doc As Object In jsonData("documents")
                    Dim fields As Object = doc("fields")
                    Dim uadmin As String = fields("useradmin")("stringValue")
                    Dim password As String = fields("adminpassword")("stringValue")


                    dataTable.Rows.Add(uadmin, password)
                Next

                ' Set DataGridView DataSource
                DataGridView1.DataSource = dataTable

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Async Sub AddUser(text1 As String, text2 As String)
        Using client As New HttpClient()
            Dim url As String = "https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/admin?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

            Dim userData As New With {
                .fields = New With {
                    .useradmin = New With {.stringValue = text1},
                    .adminpassword = New With {.stringValue = text2}
            }
          }
            Dim jsonContent As String = JsonConvert.SerializeObject(userData)
            Dim content As New StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json")

            Try
                ' Send a POST request to add the user
                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
                response.EnsureSuccessStatusCode()

                ' Reload Firestore data after adding
                LoadFirestoreData()
                MessageBox.Show("User added successfully.")
            Catch ex As Exception
                MessageBox.Show("Error adding user: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Async Sub UpdateUserInfo(docId As String, text1 As String, text2 As String)
        Using client As New HttpClient()
            Dim url As String = $"https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/admin/{docId}?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

            Dim userData As New With {
                .fields = New With {
                    .useradmin = New With {.stringValue = text1},
                    .adminpassword = New With {.stringValue = text2}
                }
            }

            Dim jsonContent As String = JsonConvert.SerializeObject(userData)
            Dim content As New StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json")

            Try
                ' Send a PATCH request to update the user
                Dim response As HttpResponseMessage = Await client.PatchAsync(url, content)
                response.EnsureSuccessStatusCode()

                ' Reload Firestore data after updating
                LoadFirestoreData()
                MessageBox.Show("User updated successfully.")
            Catch ex As Exception
                MessageBox.Show("Error updating user: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Async Sub DeleteUserById(docId As String)
        Using client As New HttpClient()
            Dim url As String = $"https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/admin/{docId}?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

            Try
                ' Send a DELETE request and await the response
                Dim response As HttpResponseMessage = Await client.DeleteAsync(url)
                response.EnsureSuccessStatusCode()

                ' Reload Firestore data after deletion
                LoadFirestoreData()
                MessageBox.Show("User deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs)
        ' Call AddUser method using values from textboxes
        AddUser(useradmin.Text, adminpassword.Text)
    End Sub

    Private Sub UpdateUser_Click(sender As Object, e As EventArgs)
        ' Ensure a row is selected in DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim docId As String = selectedRow.Cells("DocumentId").Value.ToString()

            ' Call UpdateUserInfo with the selected document ID and the new values
            UpdateUserInfo(docId, useradmin.Text, adminpassword.Text)
        Else
            MessageBox.Show("Please select a user to update.")
        End If
    End Sub

    Private Sub DeleteUser_Click(sender As Object, e As EventArgs)
        ' Ensure a row is selected in DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim docId As String = selectedRow.Cells("DocumentId").Value.ToString()

            ' Call the DeleteUser method to delete the user
            DeleteUserById(docId)
        Else
            MessageBox.Show("Please select a user to delete.")
        End If
    End Sub

    Private Sub SelectUser_Click(sender As Object, e As EventArgs)
        ' Ensure a row is selected in DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Populate the textboxes with the selected user's data
            useradmin.Text = selectedRow.Cells("useradmin").Value.ToString()
            adminpassword.Text = selectedRow.Cells("adminpassword").Value.ToString()
            MessageBox.Show("Please select a user.")
        End If
    End Sub

    ' Event handler to load Firestore data when form loads
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFirestoreData() ' Load data from Firestore into DataGridView

        ' Event handlers for buttons
        AddHandler addusers.Click, AddressOf AddUser_Click
        AddHandler bntupdateuser.Click, AddressOf UpdateUser_Click
        AddHandler bntdeleteuser.Click, AddressOf DeleteUser_Click
        AddHandler selectuser.Click, AddressOf SelectUser_Click

        ' Configure DataGridView selection mode
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
    End Sub

End Class
