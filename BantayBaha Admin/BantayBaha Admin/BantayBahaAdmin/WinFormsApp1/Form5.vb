Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Data

Public Class Form5
    Private ReadOnly httpClient As HttpClient = New HttpClient()
    Private rescueRequestsTable As DataTable ' Declare the table at the class level



    ' Load Firestore data for the 'rescue_requests' collection
    Private Async Sub LoadRescueRequestsData()
        Try
            Dim url As String = "https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/rusers?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()

            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim jsonData As Object = JsonConvert.DeserializeObject(jsonResponse)

            rescueRequestsTable = New DataTable() ' Initialize the DataTable
            rescueRequestsTable.Columns.Add("Name")
            rescueRequestsTable.Columns.Add("Address")
            rescueRequestsTable.Columns.Add("Contact")
            rescueRequestsTable.Columns.Add("Timestamp")

            For Each doc As Object In jsonData("documents")
                Dim fields As Object = doc("fields")
                If fields IsNot Nothing Then
                    Dim name As String = fields("name")?("stringValue")?.ToString()
                    Dim address As String = fields("address")?("stringValue")?.ToString()
                    Dim contact As String = fields("contact")?("stringValue")?.ToString()
                    Dim timestamp As String = fields("timestamp")?("timestampValue")?.ToString()
                    rescueRequestsTable.Rows.Add(name, address, contact, timestamp)
                End If
            Next

            DataGridView2.DataSource = rescueRequestsTable ' Set the data source
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Event handler to load data when the form loads
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRescueRequestsData() ' Load 'rescue_requests' data into DataGridView2
    End Sub

    ' Event handler for searchbox text change
    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        FilterDataGridView(searchbox.Text)
    End Sub

    ' Filter function to search by name
    Private Sub FilterDataGridView(searchTerm As String)
        If rescueRequestsTable IsNot Nothing Then
            Dim filteredData As DataView = New DataView(rescueRequestsTable)
            filteredData.RowFilter = String.Format("Name LIKE '%{0}%'", searchTerm)
            DataGridView2.DataSource = filteredData
        End If
    End Sub
End Class
