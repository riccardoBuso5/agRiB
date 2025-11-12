Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class eliminaTipologiaHome

    Private Sub popolaCombo()
        Dim str As String = "select * from tipologia ORDER BY nome ASC"
        ComboBox1.DataSource = DoQuery(Connetti(), str)
        ComboBox1.DisplayMember = ("nome")
    End Sub
    Private Sub eliminaVenditaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        popolaCombo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "delete from Tipologia where idTipologia = " + ComboBox1.SelectedItem("idTipologia").ToString()
        Dim flag = True
        Try
            Esegui(query)
        Catch ex As MySqlException
            MsgBox("non puoi cancellare una tipologia  se è collegata  ad un lotto, cancella prima il lotto")
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
    End Sub


End Class