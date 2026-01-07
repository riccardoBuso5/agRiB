Public Class eliminaVenditaHome

    Private Sub popolaCombo()
        Dim str As String = "select idVendita from vendita order by idVendita ASC"
        ComboBox1.DataSource = DoQuery(Connetti(), str)
        ComboBox1.DisplayMember = ("idVendita")
    End Sub

    Private Sub eliminaVenditaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        popolaCombo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'salvo i dati da ripristinare'

        Dim query As String = "select * from vendita where idVendita = " + ComboBox1.Text.ToString()
        Dim vendita = DoQuery(Connetti(), query)

        Dim bottDaRipristinare = vendita.Rows(0)(1)
        Dim codlotto As Integer = vendita.Rows(0)(5)
        Dim combo = vendita.Rows(0)(4)
        Dim tipologia = DoQuery(Connetti(), "select id_tipologia from tipologia_lotto where id = " + combo.ToString()).rows(0)(0)



        query = "delete from vendita where idVendita = " + ComboBox1.Text.ToString()
        Dim flag = True
        Try
            Esegui(query)
        Catch ex As Exception
            MsgBox("errore nell'eliminazione")
            flag = False
        End Try

        If flag Then
            MsgBox("cancellazione avvenuta con successo")

            'ripristino le bottiglie nella combinazione 
            aggiungiBottiglieNellaCombo(combo, bottDaRipristinare)

            'ripristino bottiglie nel lotto'
            Dim lotto = DoQuery(Connetti, "select * from lotto where idlotto = " + codlotto.ToString())
            Dim data As DateTime = lotto.rows(0)(1)

            modificaLotto(data.ToString("yyyy-MM-dd"), lotto.rows(0)(2) + bottDaRipristinare, codlotto)

            popolaCombo()

            'aggiorno la tabella'
            Form1.modificaDataGrid(getVendite())


        End If

    End Sub


End Class