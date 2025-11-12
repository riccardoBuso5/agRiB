Imports MySql.Data.MySqlClient

Public Class eliminaLottoHome
    Private Sub popolaCombo()
        Dim str As String = "select idlotto from lotto order by idlotto ASC"
        ComboBox1.DataSource = DoQuery(Connetti(), str)
        ComboBox1.DisplayMember = ("idlotto")
    End Sub
    Private Sub eliminaVenditaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        popolaCombo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "delete from lotto where idlotto = " + ComboBox1.Text.ToString()
        Dim flag = True
        Try
            Esegui(query)
        Catch ex As MySqlException
            MsgBox("non puoi cancellare un lotto se è collegato ad una vendita o ad una tipologia, cancella prima i collegamenti")
            flag = False
            Close()
        Catch ex As Exception
            MsgBox("errore nell'eliminazione")
            flag = False
            Close()
        End Try

        If flag Then
            MsgBox("cancellazione avvenuta con successo")
            popolaCombo()
        End If

        popolaCombo()
    End Sub


End Class