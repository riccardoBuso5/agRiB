Imports System.Threading
Imports Mysqlx.Resultset
Imports prova1.funzioni

Public Class Form1

    Public Sub modificaDataGrid(dt As DataTable)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        popolaCombo()
        Dim table As DataTable = StampaTabellaIntera(Connetti)
        DataGridView1.DataSource = table

        'ogni avvio del programma controllo le vendite in scadenza'
        ' Dim ds = controllaDate()

        ' If (ds.Rows.Count() > 0) Then
        'modificaVenditaHome.Show()
        ' End If
    End Sub

    '------------------aggiungi------------------------- '

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NuovoLotto.Click
        'apre la pagina per aggiungere un nuovo lotto'
        aggiungiLottoHome.Show()


    End Sub

    Private Sub NuovaVendita_Click(sender As Object, e As EventArgs) Handles NuovaVendita.Click
        aggiungiVenditaHome.Show()

    End Sub

    Private Sub NuovaTipologia_Click(sender As Object, e As EventArgs) Handles NuovaTipologia.Click
        aggiungiTipologiaHome.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles collegaLottoTipologia.Click
        'collega lotto a tipologia '
        CollegaLotto_tipologia.Show()
    End Sub


    '-------------------------------------elimina------------------------------------------'
    Private Sub eliminaVendita_Click(sender As Object, e As EventArgs) Handles eliminaVendita.Click
        eliminaVenditaHome.Show()
    End Sub

    Private Sub eliminaTipologia_Click(sender As Object, e As EventArgs) Handles eliminaTipologia.Click
        eliminaTipologiaHome.Show()
    End Sub

    Private Sub eliminaLotto_Click(sender As Object, e As EventArgs) Handles eliminaLotto.Click
        eliminaLottoHome.Show()
    End Sub


    '-------------------------------------visualizza------------------------------------------ '


    Private Sub visualizzaLotti_Click(sender As Object, e As EventArgs) Handles visualizzaLotti.Click

        DataGridView1.DataSource = funzioni.getLotti()

    End Sub

    Public Sub visualizzaVendita_Click(sender As Object, e As EventArgs) Handles visualizzaVendita.Click

        DataGridView1.DataSource = funzioni.getVendite()

    End Sub


    Private Sub visualizzaTipologia_Click(sender As Object, e As EventArgs) Handles visualizzaTipologia.Click
        DataGridView1.DataSource = funzioni.getTipologie()


    End Sub


    Private Sub scadenze_Click(sender As Object, e As EventArgs) Handles scadenze.Click
        DataGridView1.DataSource = funzioni.controllaScadenze()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles lottiDaRifornire.Click
        DataGridView1.DataSource = funzioni.lottiDaRifornire()

    End Sub

    Private Sub visualizza_lotti_per_tipologia_Click(sender As Object, e As EventArgs) Handles visualizza_lotti_per_tipologia.Click

        DataGridView1.DataSource = getLottiPerTipologie()

    End Sub

    '------------------------------modifica--------------------------------------------

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles modificaVendita.Click

        'se è minimizzata non ottiene il focus, risolvere'
        modificaVenditaHome.Show
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles modificaLotto.Click
        modificaLottoHome.Show()
    End Sub

    Private Sub ricercaXlotto_Click(sender As Object, e As EventArgs) Handles ricercaXlotto.Click


        Try
            DataGridView1.DataSource = ricercaPerCodLotto(TextBox1.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DataGridView1.DataSource = ricercaPerCodTipo(ComboBox2.SelectedItem("idTipologia").ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox(ComboBox2.SelectedItem("idTipologia"))
        End Try
    End Sub

    Public Sub popolaCombo()

        ComboBox2.DataSource = DoQuery(Connetti(), "select * from tipologia order by nome ASC")
        ComboBox2.DisplayMember = "nome"

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        popolaCombo()
    End Sub

    Private Sub comboBox2_getFocus(sender As Object, e As EventArgs)
        popolaCombo()
    End Sub

    Private Sub eliminaCollegamento_Click(sender As Object, e As EventArgs) Handles eliminaCollegamento.Click
        eliminaCollegamentoHome.Show()
    End Sub

    Private Sub ricPerData_Click(sender As Object, e As EventArgs) Handles ricPerData.Click
        ricercaPerData.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        modificaVenditaHome.Show()

    End Sub

    Private Sub modificaCollegamento_Click(sender As Object, e As EventArgs) Handles modificaCollegamento.Click
        modificaCollegamentoHome.Show()
    End Sub

    Private Sub modifica_tipologia_Click(sender As Object, e As EventArgs) Handles modifica_tipologia.Click
        modificaTipologiaHome.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'apri file exp per scegliere dove salvare il file'
        salvaFile.ShowDialog()

    End Sub

End Class
