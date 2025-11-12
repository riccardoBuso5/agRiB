Imports ClosedXML
Imports ClosedXML.Excel

Public Class salvaFile
    Dim path As String = ""
    Private Sub salvaFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            'salva tabella su file csv nel percorso precedentemente immesso'
            path = FolderBrowserDialog1.SelectedPath.Trim()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If path IsNot "" And TextBox1.Text.ToString() IsNot "" Then

            Dim nome = path + "\" + TextBox1.Text.ToString.Trim()
            path = Trim(nome, path) + ".xlsx"

            Try
                'scrivere un nome'
                stampa("tabella", path)

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

            MsgBox("file salvato in : " + path)
            Close()
        Else
            MsgBox("percorso o nome non valido")
            Close()
        End If

    End Sub
End Class