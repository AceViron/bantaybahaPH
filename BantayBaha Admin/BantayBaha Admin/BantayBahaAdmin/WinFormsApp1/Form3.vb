Imports System.IO
Imports System.Net.Http
Imports System.Drawing

Public Class Form3

    ' Create a Timer control
    Private WithEvents refreshTimer As New Timer()

    Private Async Sub LoadImageFromFirebase()
        ' Firebase Storage URL for your image
        Dim imageUrl As String = "https://firebasestorage.googleapis.com/v0/b/bantaybaha-c0ea0.appspot.com/o/data%2Fphoto.jpg?alt=media"

        Using client As New HttpClient()
            Try
                ' Download image data as a byte array
                Dim imageData As Byte() = Await client.GetByteArrayAsync(imageUrl)

                ' Convert byte array to memory stream
                Using ms As New MemoryStream(imageData)
                    ' Convert memory stream to Image
                    Dim image As Image = Image.FromStream(ms)

                    ' Resize the image to fit the PictureBox dimensions
                    Dim resizedImage As Image = ResizeImage(image, PictureBox1.Width, PictureBox1.Height)

                    ' Display the resized image in PictureBox
                    PictureBox1.Image = resizedImage

                    ' Optionally, set the PictureBox SizeMode for better scaling
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End Using
            Catch ex As Exception
                MessageBox.Show("Error downloading image: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to resize the image to fit the specified width and height
    Private Function ResizeImage(ByVal img As Image, ByVal width As Integer, ByVal height As Integer) As Image
        ' Create a new bitmap with the desired dimensions
        Dim resizedBitmap As New Bitmap(width, height)

        ' Create a graphics object from the new bitmap
        Using g As Graphics = Graphics.FromImage(resizedBitmap)
            ' Set the interpolation mode for better quality
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(img, 0, 0, width, height) ' Draw the resized image
        End Using

        Return resizedBitmap
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the Timer
        refreshTimer.Interval = 3000 ' Set the interval to 3 seconds (3000 ms)
        refreshTimer.Start() ' Start the timer
    End Sub

    ' Event handler for the Timer tick
    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        LoadImageFromFirebase() ' Refresh the image
    End Sub

End Class
