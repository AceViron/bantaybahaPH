Public Class Form2


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub livebtn_Click(sender As Object, e As EventArgs) Handles livebtn.Click
        Form3.Show()
    End Sub

    Private Sub rescuebtn_Click(sender As Object, e As EventArgs) Handles rescuebtn.Click
        Form4.Show()
    End Sub

    Private Sub msgbtn_Click(sender As Object, e As EventArgs) Handles msgbtn.Click
        Form5.Show()
    End Sub


    Private Sub levelbtn_Click(sender As Object, e As EventArgs) Handles levelbtn.Click
        Form6.Show()
    End Sub

    Private Sub adminbtn_Click(sender As Object, e As EventArgs) Handles adminbtn.Click
        Form7.Show()
    End Sub

    Private Sub usersbtn_Click(sender As Object, e As EventArgs) Handles usersbtn.Click
        Form8.Show()
    End Sub

    Private Sub reportbtn_Click_1(sender As Object, e As EventArgs) Handles reportbtn.Click
        Form9.Show()
    End Sub
End Class