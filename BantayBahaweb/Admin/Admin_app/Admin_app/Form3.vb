Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide both DataGridViews initially
        DataGridView1.Hide()
        DataGridView2.Hide()

        ' Load data into DataGridView1 from tbl_login

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show DataGridView1 and hide DataGridView2
        DataGridView1.Show
        DataGridView2.Hide
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Load data into DataGridView2 from tbl_rescue
        Dim str As String = "server=localhost; database=admin_acct; username=root; password="
        Dim con As New MySqlConnection(str)
        Dim comm As String = "SELECT * FROM tbl_rescue"
        Dim adap As New MySqlDataAdapter(comm, con)
        Dim ds As New DataSet()

        adap.Fill(ds, "RESCUE")
        DataGridView2.DataSource = ds.Tables(0)

        ' Show DataGridView2 and hide DataGridView1
        DataGridView2.Show()
        DataGridView1.Hide()
    End Sub
End Class
