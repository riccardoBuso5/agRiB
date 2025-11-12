Imports Mysqlx.Crud

Public Class aggiungiVenditaHome

    Dim numBottiglie As Integer
    Dim effettuata_programmata As String
    Dim data As String
    Dim codLotto As String
    Dim idtipo As String
    Dim idCombo As String
    Dim cliente As String
    Dim note As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        numBottiglie = NumericUpDown1.Value
        Dim numBottDisp As Integer = get_num_bott_per_combo(ComboBox2.SelectedItem("id"))

        If numBottiglie > numBottDisp Then
            MsgBox("bottiglie insufficienti")
            Return
        End If


        If (RadioButton1.Checked) Then
            effettuata_programmata = "effettuata"
        ElseIf (RadioButton2.Checked) Then
            effettuata_programmata = "programmata"
        End If

        data = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        codLotto = ComboBox1.SelectedItem("idLotto").ToString()
        idtipo = ComboBox2.SelectedItem("id_tipologia").ToString()

        idCombo = ComboBox2.SelectedItem("id")
        note = TextBox1.Text

        If CheckBox1.Checked Then
            cliente = "privato"
        Else
            cliente = "pubblico"
        End If



        Dim query As String = "insert into vendita(numBottiglie,effettuata_programmata,data_vendita,id_combo,idLotto,cliente,note) values(" + numBottiglie.ToString + ", '" + effettuata_programmata.ToString + "' ,'" + data.ToString + "'," + idCombo.ToString + "," + codLotto.ToString + ",'" + cliente.ToString + "','" + note.ToString + "');"
        Dim flag As Boolean = True
        Try
            Esegui(query)
        Catch ex As Exception

            MsgBox("inserimento non riuscito")
            flag = False
        End Try

        If flag Then
            MsgBox("inserimento riuscito")
            'modifico la quantità di bottiglie nel db
            'ricavo i dati del lotto'

            query = "select * from lotto where idlotto = " + codLotto
            Dim ds As DataTable = DoQuery(Connetti(), query)
            Dim riga As DataRow
            If (ds.Rows.Count > 0) Then
                riga = ds.Rows(0)

                Dim data As DateTime = riga(1)
                Dim oldBottTotLotto = riga(2)
                'sottraggo le bottiglie disponibili nel lotto'
                modificaLotto(data.ToString("yyyy-MM-dd"), (oldBottTotLotto - numBottiglie), codLotto)


                Dim id = ComboBox1.SelectedItem("id")
                Dim numBottCombo = get_num_bott_per_combo(id)

                'sottraggo le bottiglie disponibili nella combo '
                sottraiBottiglieNellaCombo(id, numBottCombo - numBottiglie)


            End If
            Close()
        End If
        Form1.modificaDataGrid(funzioni.getVendite())



    End Sub

    Private Sub aggiungiVenditaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim str As String = "SELECT  distinct(l.idlotto) , t.nome, tl.id, tl.id_tipologia
                            FROM lotto l
                            JOIN tipologia_lotto tl ON l.idlotto = tl.id_lotto
                            JOIN tipologia t ON tl.id_tipologia = t.idtipologia
                            ORDER BY idlotto ASC;"

        Dim sr = DoQuery(Connetti(), str)
        ComboBox1.DataSource = sr
        ComboBox2.DataSource = sr

        ComboBox1.DisplayMember = "idlotto"
        ComboBox2.DisplayMember = "nome"


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            NumericUpDown2.Value = get_num_bott_per_combo(ComboBox2.SelectedItem("id"))
        Catch

        End Try

    End Sub
End Class