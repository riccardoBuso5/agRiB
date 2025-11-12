Imports Org.BouncyCastle.Asn1.Crmf

Public Class eliminaCollegamentoHome

    Sub popola()
        Dim query =
            "select id,id_lotto, numBott, nome 
            from tipologia_lotto 
            join tipologia on tipologia_lotto.id_tipologia = tipologia.idtipologia "

        Dim ds = DoQuery(Connetti(), query)

        DataGridView1.DataSource = ds

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "id"

    End Sub
    Private Sub eliminaCollegamentoHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        popola()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query = " delete from tipologia_lotto where id = " + ComboBox1.Text.ToString() + ";"

        Try
            Esegui(query)
        Catch ex As Exception
            MsgBox("errore cancellazione")
            MsgBox("controlla che non ci siano vendite associate a questo collegamenteo (lotto - tipologia)")
            Return
        End Try

        MsgBox("cancellazione riuscita")
        popola()

        'aggiorno la tabella '
        Form1.modificaDataGrid(getLottiPerTipologie())


    End Sub
End Class