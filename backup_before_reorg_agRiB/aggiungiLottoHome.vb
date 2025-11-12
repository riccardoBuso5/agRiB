Imports System.Runtime.InteropServices.Marshalling
Imports Mysqlx.Crud

Public Class aggiungiLottoHome

    Dim idLotto As String
    Dim data As String
    Dim tipologia As String
    Dim num As String
    Dim idTipologia As String
    Dim query As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idLotto = TextBox1.Text
        data = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        num = NumericUpDown1.Value.ToString()

        Try
            inserisciLotto(idLotto, data, num, idTipologia)
        Catch ex As Exception
            Close()
        End Try
    End Sub

    Private Sub aggiungiLottoHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class