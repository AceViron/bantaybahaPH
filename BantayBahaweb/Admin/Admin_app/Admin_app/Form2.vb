Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Try
            cm = New MySqlCommand("insert into tbl_login values('" & username.Text & "','" & password.Text & "')", constring)
            cm.ExecuteNonQuery()
            MessageBox.Show("succesfully registered")

            Form1.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub bckbtn_Click(sender As Object, e As EventArgs) Handles bckbtn.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class