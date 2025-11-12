Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class modificaLottoHome
    Dim lotto As String = ""
    Public Sub main()

        Dim Str = "select idlotto from lotto order by idlotto ASC"
        comboBox2.DataSource = DoQuery(Connetti(), str)
        comboBox2.DisplayMember = ("idlotto")

    End Sub

    Private Sub idLotto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox2.SelectedIndexChanged
        'trovo i dati di questo lotto'

        lotto = comboBox2.SelectedItem("idlotto").ToString()


        Dim query As String
        If (lotto IsNot "" And lotto IsNot " ") Then
            query = "select * from lotto where idlotto =" + lotto + ""


            Dim ds As DataTable = DoQuery(Connetti(), query)
            If (ds.Rows.Count > 0) Then
                Dim riga As DataRow = ds.Rows(0)
                '0 lotto,  1 data, 2 num bottiglie, 3 id tipologia'

                DateTimePicker1.Value = riga(1)
                NumericUpDown1.Value = riga(2)
            End If
        End If

    End Sub



    Private Sub modificaLottoHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'salvo i nuovi dati'
        Dim data = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim numBot = NumericUpDown1.Value

        modificaLotto(data, numBot, lotto)
    End Sub


End Class