Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Data
Imports System.Net.Http
Imports System.Threading.Tasks

Public Class Form8

    Private Async Sub LoadFirestoreData()
        ' Create HttpClient instance
        Using client As New HttpClient()
            Dim url As String = "https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/users?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

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
                dataTable.Columns.Add("DocumentId") ' Add Document ID column
                dataTable.Columns.Add("Name")
                dataTable.Columns.Add("Address")
                dataTable.Columns.Add("Contact")
                dataTable.Columns.Add("Email")
                dataTable.Columns.Add("Status") ' Add Status column

                ' Parse the JSON data and add rows to the DataTable
                For Each doc As Object In jsonData("documents")
                    Dim fields As Object = doc("fields")
                    Dim name As String = fields("name")("stringValue")
                    Dim address As String = fields("address")("stringValue")
                    Dim contact As String = fields("contact")("stringValue")
                    Dim email As String = fields("email")("stringValue")
                    Dim status As String = If(fields.ContainsKey("status"), fields("status")("stringValue"), "Unknown") ' Default to "Unknown" if Status is not present
                    Dim docId As String = doc("name").ToString().Split("/"c).Last() ' Extract Document ID

                    dataTable.Rows.Add(docId, name, address, contact, email, status)
                Next

                ' Set DataGridView DataSource
                DataGridView1.DataSource = dataTable

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Async Sub AddUser(text1 As String, text2 As String, text3 As String, text4 As String)
        Using client As New HttpClient()
            Dim url As String = "https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/users?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

            Dim userData As New With {
                .fields = New With {
                    .name = New With {.stringValue = text1},
                    .address = New With {.stringValue = text2},
                    .contact = New With {.stringValue = text3},
                    .email = New With {.stringValue = text4}
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

    Private Async Sub UpdateUserInfo(docId As String, text1 As String, text2 As String, text3 As String, text4 As String)
        Using client As New HttpClient()
            Dim url As String = $"https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/users/{docId}?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

            Dim userData As New With {
                .fields = New With {
                    .name = New With {.stringValue = text1},
                    .address = New With {.stringValue = text2},
                    .contact = New With {.stringValue = text3},
                    .email = New With {.stringValue = text4}
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
            Dim url As String = $"https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/users/{docId}?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

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
        AddUser(username.Text, useraddress.Text, usercontact.Text, useremail.Text)
    End Sub

    Private Sub UpdateUser_Click(sender As Object, e As EventArgs)
        ' Ensure a row is selected in DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim docId As String = selectedRow.Cells("DocumentId").Value.ToString()

            ' Call UpdateUserInfo with the selected document ID and the new values
            UpdateUserInfo(docId, username.Text, useraddress.Text, usercontact.Text, useremail.Text)
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
            username.Text = selectedRow.Cells("Name").Value.ToString()
            useraddress.Text = selectedRow.Cells("Address").Value.ToString()
            usercontact.Text = selectedRow.Cells("Contact").Value.ToString()
            useremail.Text = selectedRow.Cells("Email").Value.ToString()
        Else
            MessageBox.Show("Please select a user.")
        End If
    End Sub

    ' Event handler to load Firestore data when form loads
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
