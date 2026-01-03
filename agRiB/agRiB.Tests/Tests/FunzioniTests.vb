Imports System.Data

Public Class FunzioniTests

    Public Shared Sub EseguiTuttiITest()
        Dim testPassati As Integer = 0
        Dim testFalliti As Integer = 0
        Dim messaggi As New System.Text.StringBuilder()

        messaggi.AppendLine("=== INIZIO TEST ===")
        messaggi.AppendLine()

        ' Test 1: RicercaPerCodTipo - query corretta
        Try
            TestRicercaPerCodTipo_QueryCorretta()
            testPassati += 1
            messaggi.AppendLine("✓ TestRicercaPerCodTipo_QueryCorretta PASSATO")
        Catch ex As Exception
            testFalliti += 1
            messaggi.AppendLine("✗ TestRicercaPerCodTipo_QueryCorretta FALLITO: " & ex.Message)
        End Try

        ' Test 2: InserisciLotto con codice vuoto DEVE fallire
        Try
            funzioni.inserisciLotto("", "2025-01-01", 1000, "1")
            testFalliti += 1
            messaggi.AppendLine("✗ TestInserisciLotto_ConCodiceVuoto FALLITO: Non ha generato errore")
        Catch ex As Exception
            If ex.Message.Contains("valido") OrElse ex.Message.Contains("vuoto") Then
                testPassati += 1
                messaggi.AppendLine("✓ TestInserisciLotto_ConCodiceVuoto PASSATO")
            Else
                testFalliti += 1
                messaggi.AppendLine("✗ TestInserisciLotto_ConCodiceVuoto FALLITO: Mostra MsgBox invece di lanciare eccezione")
            End If
        End Try

        ' Test 3: SottraiBottiglie con numero eccessivo DEVE fallire
        Try
            funzioni.sottraiBottiglieNellaCombo(1, 999999)
            testFalliti += 1
            messaggi.AppendLine("✗ TestSottraiBottiglie_Eccessivo FALLITO: Non ha generato errore")
        Catch ex As ArgumentOutOfRangeException
            testPassati += 1
            messaggi.AppendLine("✓ TestSottraiBottiglie_Eccessivo PASSATO")
        Catch ex As Exception
            testFalliti += 1
            messaggi.AppendLine("✗ TestSottraiBottiglie_Eccessivo FALLITO: " & ex.Message)
        End Try

        ' Test 4: ModificaLotto con dati invalidi DEVE fallire
        Try
            funzioni.modificaLotto("data-invalida", -100, "999999")
            testFalliti += 1
            messaggi.AppendLine("✗ TestModificaLotto_Invalido FALLITO: Non ha generato errore")
        Catch ex As Exception
            If ex.Message.Contains("MsgBox") Then
                testFalliti += 1
                messaggi.AppendLine("✗ TestModificaLotto_Invalido FALLITO: Mostra MsgBox invece di lanciare eccezione")
            Else
                testPassati += 1
                messaggi.AppendLine("✓ TestModificaLotto_Invalido PASSATO")
            End If
        End Try

        ' Test 5: ModificaVendita con ID invalido DEVE fallire
        Try
            funzioni.modificaVendita("999999")
            testFalliti += 1
            messaggi.AppendLine("✗ TestModificaVendita_Invalido FALLITO: Non ha generato errore")
        Catch ex As Exception
            If ex.Message.Contains("MsgBox") Then
                testFalliti += 1
                messaggi.AppendLine("✗ TestModificaVendita_Invalido FALLITO: Mostra MsgBox invece di lanciare eccezione")
            Else
                testPassati += 1
                messaggi.AppendLine("✓ TestModificaVendita_Invalido PASSATO")
            End If
        End Try

        ' Test 6: IsCollegato con connessione fallita DEVE gestire errore
        Try
            ' Forza disconnessione
            If funzioni.conn IsNot Nothing Then
                Try
                    funzioni.conn.Close()
                Catch
                End Try
                funzioni.conn = Nothing
                funzioni.flag = False
            End If

            Dim result = funzioni.isCollegato("1", "1")

            ' Se restituisce False è accettabile
            If result = False Then
                testPassati += 1
                messaggi.AppendLine("✓ TestIsCollegato_ConnessioneFallita PASSATO (restituisce False)")
            Else
                testFalliti += 1
                messaggi.AppendLine("✗ TestIsCollegato_ConnessioneFallita FALLITO: Dovrebbe gestire connessione fallita")
            End If
        Catch ex As Exception
            testPassati += 1
            messaggi.AppendLine("✓ TestIsCollegato_ConnessioneFallita PASSATO (genera eccezione)")
        End Try

        messaggi.AppendLine()
        messaggi.AppendLine("=== RISULTATI ===")
        messaggi.AppendLine($"Test Passati: {testPassati}")
        messaggi.AppendLine($"Test Falliti: {testFalliti}")
        messaggi.AppendLine($"Totale: {testPassati + testFalliti}")

        MsgBox(messaggi.ToString(), If(testFalliti > 0, MsgBoxStyle.Critical, MsgBoxStyle.Information), "Risultati Test")
    End Sub

    Private Shared Sub TestRicercaPerCodTipo_QueryCorretta()
        ' Test che la query non generi errore SQL con parametro corretto
        Dim result As DataTable = funzioni.ricercaPerCodTipo("999")

        If result Is Nothing Then
            Throw New Exception("Risultato null")
        End If

        ' Dovrebbe restituire tabella vuota senza errore SQL
    End Sub

End Class