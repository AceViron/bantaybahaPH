Imports Google.Cloud.Firestore
Imports Google.Apis.Auth.OAuth2
Imports System.IO
Imports Google.Cloud.Firestore.V1

Public Class Form1
    Inherits System.Windows.Forms.Form

    Private FirestoreDb As FirestoreDb

    Public Sub New()
        InitializeComponent()
        InitializeFirestore()
    End Sub

    Private Sub InitializeFirestore()
        ' Load the credentials from the JSON key file.
        Dim credential = GoogleCredential.FromFile("C:\Users\mylene\Desktop\BantayBaha Admin\bantaybaha-c0ea0-firebase-adminsdk-xwmv9-a216e24d2a.json")

        ' Create the Firestore client.
        Dim builder = New FirestoreClientBuilder() With {
            .Credential = credential ' Ensure this is correctly capitalized
        }
        Dim firestoreClient = builder.Build()

        ' Initialize FirestoreDb.
        FirestoreDb = FirestoreDb.Create("bantaybaha-c0ea0", firestoreClient) ' Make sure this project ID is correct
    End Sub

    Private Async Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim username As String = user_txtbox.Text.Trim()
        Dim password As String = pass_txtbox.Text.Trim()

        If Await AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful!")

            ' Navigate to Form2
            Dim form2 As New Form2 ' Pass username to Form2 if needed
            form2.Show()
            Me.Hide() ' Optionally hide Form1
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Async Function AuthenticateUser(username As String, password As String) As Task(Of Boolean)
        Dim userCollection As CollectionReference = FirestoreDb.Collection("admin")
        Dim query = userCollection.WhereEqualTo("useradmin", username) ' Ensure this field name matches your Firestore database
        Dim querySnapshot = Await query.GetSnapshotAsync()

        If querySnapshot.Count = 0 Then
            Return False
        End If

        For Each document As DocumentSnapshot In querySnapshot.Documents
            Dim storedPassword As String = document.GetValue(Of String)("adminpassword") ' Ensure this field name matches your Firestore database
            If storedPassword = password Then
                Return True
            End If
        Next

        Return False
    End Function

    '... (rest of your form design code)
End Class
