Public Class CollegaLotto_tipologia




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idLotto As String = ComboBox1.SelectedItem("idLotto")
        Dim tipologia As String = ComboBox2.SelectedItem("idTipologia")
        Dim numeroBott As String = NumericUpDown1.Value

        'controllo che lo stesso lotto non abbia già un collegamento con la stessa tipologia'
        If isCollegato(idLotto, tipologia) Then
            MsgBox("collegamento già presente")
            Return
        End If

        'controllo che il numero di bottiglie sia sufficiente'
        Dim numBotTot As Integer = get_numBott_lotto(idLotto)

        Dim numBotUsate As Integer = get_numBot_usate_perLotto(idLotto)

        Dim numBottDisponibili = (numBotTot - numBotUsate)

        If numBottDisponibili < numeroBott Then
            MsgBox("numero bottiglie lotto disponibili insufficiente")

        Else
            nuovoTipologia_lotto(idLotto, tipologia, numeroBott)
            MsgBox("inserimento riuscito")
            Close()
        End If



    End Sub


    Private Sub CollegaLotto_tipologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strLotti As String = "select idLotto from lotto order by idlotto ASC"
        Dim strTipo As String = "select * from tipologia order by nome ASC"

        Dim lotti = DoQuery(Connetti(), strLotti)
        Dim tipo = DoQuery(Connetti(), strTipo)
        ComboBox1.DataSource = lotti
        ComboBox2.DataSource = tipo

        ComboBox1.DisplayMember = ("idlotto")
        ComboBox2.DisplayMember = "nome"
    End Sub
End Class