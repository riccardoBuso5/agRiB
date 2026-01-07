Public Class modificaTipologiaHome
    Private Sub modificaTipologiaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        popola()
    End Sub

    Private Sub popola()
        Dim ds = DoQuery(Connetti(), "select * from tipologia order by nome")

        ComboBox2.DataSource = ds
        ComboBox2.DisplayMember = "nome"
    End Sub

    Private Sub ricercaXlotto_Click(sender As Object, e As EventArgs) Handles ricercaXlotto.Click
        Dim nuovonome = TextBox1.Text

        Dim query = "update tipologia set nome = '" + nuovonome.ToString + "' where  idtipologia = " + ComboBox2.SelectedItem("idtipologia").ToString()
        Dim isPresente As DataTable = DoQuery(Connetti, "select count(nome) from tipologia where nome = '" + nuovonome + "'")
        Dim numRipetizioni = isPresente.Rows(0)(0)

        If nuovonome IsNot "" And numRipetizioni = 0 Then
            Try
                Esegui(query)
            Catch ex As Exception
                MsgBox("modifica non riuscita")
                Return
            End Try

            MsgBox("modifica avvenuta correttamente")
            Close()
        Else
            MsgBox("nome non disponibile")
            Close()
        End If
    End Sub
End Class