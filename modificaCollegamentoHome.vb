Public Class modificaCollegamentoHome
    Dim bottAttualiPerCombo As Integer
    Dim bottTot As Integer
    Private Sub modificaCollegamentoHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        popolaCombo()


    End Sub

    Private Sub popolaCombo()
        'prelevo i dati da tipologia_lotto'
        Dim query As String = "select * from tipologia_lotto join tipologia on idtipologia = id_tipologia order by id_lotto ASC"
        Dim combo = DoQuery(Connetti, query)

        ComboBox1.DataSource = combo
        ComboBox1.DisplayMember = "id_lotto"
        ComboBox2.DataSource = combo
        ComboBox2.DisplayMember = "nome"


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        bottAttualiPerCombo = ComboBox1.SelectedItem("numBott") 'bottiglie nella combinazione'

        'le bottiglie aggiungibili sono quelle presenti nel lotto, ma senza essere collegati ad una combinazione'

        Dim lotto = ComboBox1.SelectedItem("id_lotto")

        'trovo tutte le bottiglie del lotto, assegnate alle varie combinazioni'

        Dim str As String = " select sum(numBott) from tipologia_lotto where id_lotto = " + lotto.ToString() + " ;"
        Dim bottUsateTot As Integer = DoQuery(Connetti(), str).Rows(0)(0)
        bottTot = Convert.ToInt64(get_numBott_lotto(lotto))

        Dim bottLibere As Integer = BottTot - bottUsateTot
        NumericUpDown1.Maximum = bottAttualiPerCombo + bottLibere 'numero bottiglie aggiungibili massime'
        NumericUpDown2.Value = bottLibere
        NumericUpDown1.Value = bottAttualiPerCombo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tipologia As String = ComboBox1.SelectedItem("id_tipologia")
        Dim lotto As String = ComboBox1.SelectedItem("id_lotto")
        Dim cod_combo As String = ComboBox1.SelectedItem("id")

        Dim bottNuoveCombo As String = NumericUpDown1.Value
        Dim bottOldCombo As String = bottAttualiPerCombo

        Dim variazione = abs(bottNuoveCombo - bottOldCombo) 'bottiglie di differenza '


        'modifica combinazione'
        modificaCombo(tipologia, lotto, bottNuoveCombo, cod_combo)

        'aggiorno tabella'
        Form1.modificaDataGrid(getLottiPerTipologie)
    End Sub

End Class