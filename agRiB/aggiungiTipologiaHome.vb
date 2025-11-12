Public Class aggiungiTipologiaHome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("nome non valido")
            Close()
        Else

            Dim nome As String = TextBox1.Text()
            Dim dt As DataTable = getTipologie()
            Dim tipologie(dt.Rows.Count - 1) As String
            Dim oldName As String = ""

            For i As Integer = 0 To dt.Rows.Count - 1
                oldName = dt.Rows(i).Item(0).ToString
                tipologie(i) = oldName
            Next

            BubbleSort(tipologie)

            Dim flag As Boolean = False

            'cerco se il nome non è già presente'
            Dim cont As Integer = 0
            While (flag = False And cont < tipologie.Length)
                If (tipologie(cont) Is nome) Then
                    flag = True
                Else
                    cont = cont + 1
                End If
            End While

            If flag = True Then
                MsgBox("nome tipologia già in uso")
                Close()
            End If


            Dim query As String = "insert into tipologia(nome) values('" + nome + "');"
            flag = True

            Try
                Esegui(query)
            Catch ex As Exception
                MsgBox(query)
                MsgBox("inserimento non riuscito")
                flag = False
            End Try

            If flag Then
                MsgBox("Inserimento riuscito")
                Close()

            End If
        End If



    End Sub

    Private Sub aggiungiTipologiaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class