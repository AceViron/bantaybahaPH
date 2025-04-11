Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form4
    Private Async Sub sendbtn_Click(sender As Object, e As EventArgs) Handles sendbtn.Click
        ' Firestore REST API URL with the collection path
        Dim url As String = "https://firestore.googleapis.com/v1/projects/bantaybaha-c0ea0/databases/(default)/documents/Notification?key=AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots"

        ' Retrieve data from TextBoxes
        Dim title As String = titlebox.Text
        Dim message As String = messagebox1.Text
        Dim dateVal As String = datebox.Text

        ' Create the data payload
        Dim notifData As New With {
            .fields = New With {
                .Title = New With {.stringValue = title},
                .Message = New With {.stringValue = message},
                .Date = New With {.stringValue = dateVal}
            }
        }

        ' Serialize the payload to JSON
        Dim jsonContent As String = JsonConvert.SerializeObject(notifData)
        Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

        Try
            ' Create HttpClient and make a POST request to the Firestore REST API
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

                ' Check if the request was successful
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Data saved successfully to Firestore.")
                Else
                    Dim errorResponse As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Error saving data: " & errorResponse)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Exception occurred: " & ex.Message)
        End Try
    End Sub
End Class
