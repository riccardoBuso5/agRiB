Public Class modificaVenditaHome
    Dim ds As DataTable
    Private Sub modificaVenditaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = controllaDate()
        DataGridView1.DataSource = ds

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = ("idVendita")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (CheckBox1.Checked) Then
            modificaVendita(ComboBox1.Text)
            DataGridView1.DataSource = controllaDate()


        End If
    End Sub
End Class