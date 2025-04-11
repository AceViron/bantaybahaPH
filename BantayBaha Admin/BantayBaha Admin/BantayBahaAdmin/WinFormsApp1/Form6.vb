Imports System.Net.Http
Imports Newtonsoft.Json ' You can install Newtonsoft.Json via NuGet Package Manager
Imports System.Data
Imports System.Windows.Forms

Public Class Form6
    Private WithEvents refreshTimer As Timer

    Private Async Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTimer = New Timer()
        refreshTimer.Interval = 2000
        refreshTimer.Start()

        Await FetchDataFromFirebaseAsync()
    End Sub

    ' Async function to fetch data from Firebase
    Private Async Function FetchDataFromFirebaseAsync() As Task
        Dim firebaseUrl As String = "https://bantaybaha-c0ea0-default-rtdb.firebaseio.com/sensor.json"

        ' Initialize HttpClient
        Using httpClient As New HttpClient()
            Try
                ' Send an asynchronous GET request to Firebase
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(firebaseUrl)
                response.EnsureSuccessStatusCode() ' Throw if not a success code

                ' Read the response content as a string
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()

                ' Parse JSON response
                Dim firebaseData As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(jsonResponse)

                ' Create a DataTable to hold the data
                Dim dataTable As New DataTable()
                dataTable.Columns.Add("Key")
                dataTable.Columns.Add("Value")
                dataTable.Columns.Add("Date and Time") ' New column for date and time

                ' Check if the Firebase data is not null and populate the DataTable
                If firebaseData IsNot Nothing Then
                    For Each entry In firebaseData
                        Dim row As DataRow = dataTable.NewRow()
                        row("Key") = entry.Key
                        row("Value") = entry.Value.ToString()
                        row("Date and Time") = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Set the current date and time
                        dataTable.Rows.Add(row)
                    Next
                Else
                    MessageBox.Show("No data found in Firebase.")
                End If

                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = dataTable

            Catch ex As Exception
                MessageBox.Show("Error fetching data from Firebase: " & ex.Message)
            End Try
        End Using
    End Function

    ' Timer tick event to refresh data
    Private Async Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        Await FetchDataFromFirebaseAsync() ' Fetch new data from Firebase
    End Sub
End Class
