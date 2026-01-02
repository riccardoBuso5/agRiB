Imports System.IO
Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient


Module funzioni
    Public conn As MySqlConnection
    Public flag = False
    Dim strConn As String = "server=localhost;database=cantina;user id=root;password=password;port=3306;CharSet=utf8;"
    'exe'
    Public Function leggiDaFile(Optional path As String = "paswd.txt") As String
        Try
            ' Costruisci il percorso completo basato sulla directory dell'exe
            Dim fullPath As String = IO.Path.Combine(Application.StartupPath, path)

            ' Leggi il file usando il percorso completo
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(fullPath)
            Return fileReader.Trim()

        Catch ex As FileNotFoundException
            MsgBox("File " & path & " non trovato!" & vbCrLf &
                   "Percorso cercato: " & IO.Path.Combine(Application.StartupPath, path) & vbCrLf &
                   "Creare il file con la stringa di connessione.",
                   MsgBoxStyle.Exclamation, "File Mancante")
            Return Nothing
        Catch ex As Exception
            MsgBox("Errore lettura file: " & ex.Message, MsgBoxStyle.Critical, "Errore")
            Return Nothing
        End Try
    End Function


    Public Function Connetti() As MySqlConnection
        ' Controlla se la connessione è già aperta e valida
        If flag = True AndAlso conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            Return conn
        End If
        'decommentare prima di pubblicare'
        strConn = leggiDaFile()

        Try
            conn = New MySqlConnection(strConn)
            conn.Open() ' APRI SUBITO la connessione
            flag = True
            Return conn
        Catch ex As MySqlException
            flag = False
            MsgBox("Errore connessione MySQL (" & ex.Number & "): " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function StampaTabellaIntera(conn As MySqlConnection) As DataTable
        Dim str As String = "SELECT * 
                            FROM lotto
                            JOIN vendita ON lotto.idlotto = vendita.idLotto
                            JOIN tipologia_lotto ON lotto.idlotto = tipologia_lotto.id_lotto
                            JOIN tipologia ON tipologia.idtipologia = tipologia_lotto.id_tipologia;"


        ' NON chiudere la connessione prima del Fill!
        Dim da As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet()
        da.Fill(ds)

        Return ds.Tables(0)
    End Function


    Public Function DoQuery(conn As MySqlConnection, query As String) As DataTable
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        da.Fill(ds)

        Return ds.Tables(0)
    End Function

    Public Function Esegui(query As String) As Object
        If String.IsNullOrEmpty(query) Then
            Return 0
        End If

        Dim conn As MySqlConnection = Connetti()

        If conn Is Nothing OrElse conn.State <> ConnectionState.Open Then
            Return 0
        End If

        Try
            Dim cmd As New MySqlCommand(query, conn)
            Dim Reader = cmd.ExecuteScalar()
            Return Reader
        Finally
            conn.Close()
        End Try
    End Function

    'ricerca'

    Public Function ricercaPerCodLotto(codLotto As String) As DataTable
        Dim query As String = "SELECT lotto.idlotto, data_produzione, numBott AS numeroBottDisponibiliPerTipologia, nome AS tipologia
                           FROM lotto
                           JOIN tipologia_lotto ON lotto.idlotto = tipologia_lotto.id_lotto
                           JOIN tipologia ON tipologia.idtipologia = tipologia_lotto.id_tipologia
                           WHERE lotto.idLotto = @codLotto;"

        Dim conn As MySqlConnection = Connetti()

        ' Connetti() apre già la connessione
        If conn Is Nothing Then
            Return New DataTable()
        End If

        Try
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@codLotto", codLotto)

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            Return ds.Tables(0)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Public Function ricercaPerCodTipo(codTipo As String) As DataTable
        Dim query As String = "SELECT lotto.idlotto, data_produzione, numBott AS numeroBottPerTipologia, nome AS tipologia
                           FROM lotto
                           JOIN tipologia_lotto ON lotto.idlotto = tipologia_lotto.id_loto
                           JOIN tipologia ON tipologia.idtipologia = tipologia_lotto.id_tipologia
                           WHERE tipologia.idTipologia = @codTipo;"

        Dim conn As MySqlConnection = Connetti()
        If conn Is Nothing Then Return New DataTable()

        Try
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@codTipo", codTipo)

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            Return ds.Tables(0)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Public Function controllaScadenze() As DataTable
        Dim scadenza As DateTime = Today.AddDays(7)
        Dim query As String = "SELECT * FROM vendita 
                          WHERE data_vendita <= @scadenza 
                          AND effettuata_programmata = 'programmata'"

        Dim conn As MySqlConnection = Connetti()
        If conn Is Nothing Then Return New DataTable()

        Try
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@scadenza", scadenza.ToString("yyyy-MM-dd"))

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            Return ds.Tables(0)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Public Function lottiDaRifornire() As DataTable
        Dim query As String = "select * from lotto where num_bottiglie < 1000"
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds
    End Function

    Public Function controllaDate() As DataTable
        Dim query As String = "SELECT * FROM vendita 
                          WHERE data_vendita <= @oggi 
                          AND effettuata_programmata = 'programmata'"

        Dim conn As MySqlConnection = Connetti()
        If conn Is Nothing Then Return New DataTable()

        Try
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@oggi", Today.ToString("yyyy-MM-dd"))

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            Return ds.Tables(0)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Public Function get_numBot_usate_perLotto(idLotto As String) As Object
        Dim query = "SELECT SUM(numBott) AS sum_quantity
                    FROM tipologia_lotto 
                    WHERE id_lotto = " & idLotto.ToString()

        Dim num = Esegui(query)
        If num IsNot DBNull.Value Then
            Return num
        End If

        Return 0
    End Function

    Public Function get_numBott_lotto(idLotto As String) As String
        Dim query = "select num_bottiglie from lotto where idLotto = " & idLotto.ToString()
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds.Rows(0)(0).ToString()
    End Function

    Public Function get_num_bott_per_combo(idCombinazione As String) As String
        Dim query = "select numBott from tipologia_lotto where id = " & idCombinazione.ToString()
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds.Rows(0)(0).ToString()
    End Function


    Public Function trovaNomeTipologiaFromid(Id As String) As String
        Dim query As String = "select nome from tipologia where idTipologia = " & Id
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Dim nomeTipologia As String = ds.Rows(0)(0).ToString()
        Return nomeTipologia
    End Function

    Public Function trovaIdTipologiaFromNome(nome As String) As String
        Dim query As String = "select idTipologia from tipologia where nome = '" & nome & "'"
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Dim id As String = ds.Rows(0)(0).ToString()
        Return id
    End Function

    'inserisci'

    Public Sub nuovoTipologia_lotto(idLotto, idTipologia, numBott)
        Dim query As String = "insert into tipologia_lotto (id_lotto,id_tipologia,numBott) values(" + idLotto + "," + idTipologia + "," + numBott + ");"
        Esegui(query)
    End Sub



    Public Sub inserisciLotto(idLotto, data, num, idTipologia)

        If (idLotto IsNot "") Then
            'controllo che il codice sia univoco'
            Dim ricerca As String = "select count(*) from  lotto where idlotto = " + idLotto + ";"

            Dim isPresente = Esegui(ricerca)


            If (isPresente = 0) Then
                'se il codice non è gia presente lo inserisco'
                Try
                    Dim query = "insert into lotto (idlotto,data_produzione,num_bottiglie) values(" + idLotto + ",'" + data + "'," + num + ");"
                    Esegui(query)
                Catch ex As Exception
                    MsgBox("inserimento non riuscito")
                    Return
                End Try

                MsgBox("inserimento riuscito")
                Throw New Exception
            Else
                MsgBox("codice lotto correntemente in uso")
                Return
            End If

        Else
            MsgBox("inserire un codice lotto valido")
            Return

        End If

    End Sub

    'modifica'
    Public Sub modificaLotto(Data, numBot, idlotto)
        'controllare che la data sia nel formato corretto .ToString("yyyy-MM-dd")'
        Dim flag = True

        Dim query As String = "update lotto set data_produzione ='" + Data + "' , num_bottiglie = " + numBot.ToString + " where idlotto = " + idlotto.ToString + ""
        Try
            Esegui(query)
        Catch
            MsgBox("errore modifica non riuscita")
            flag = False
        End Try

        If (flag) Then
            MsgBox("modifica avvenuta correttamente")
        End If
    End Sub

    Public Sub modificaVendita(idVendita)
        Dim flag = True

        Dim query As String = "update vendita set effettuata_programmata = 'effettuata' where idVendita =" + idVendita
        Try
            Esegui(query)
        Catch
            MsgBox("errore modifica non riuscita")
            flag = False
        End Try

        If (flag) Then
            MsgBox("modifica avvenuta correttamente")
        End If
    End Sub

    Public Sub sottraiBottiglieNellaCombo(idCombo As Integer, numBottDaSottrarre As Integer)

        'se vengono vendute più bottiglie di quelle disponibili crea un exc'

        'controllo quante bottiglie sono disponibili'
        Dim bottDisponibili = get_num_bott_per_combo(idCombo)

        If bottDisponibili < numBottDaSottrarre Then
            Throw New ArgumentOutOfRangeException
            Return
        End If

        Dim query As String = "update tipologia_lotto set numBott  = " + numBottDaSottrarre.ToString() + " where id = " + idCombo.ToString()
        Esegui(query)
    End Sub

    Public Sub aggiungiBottiglieNellaCombo(idCombo As Integer, numBott As Integer)
        Dim combo = DoQuery(Connetti, "select * from tipologia_lotto where id = " + idCombo.ToString())
        Dim tipo = combo.rows(0)(0)
        Dim lotto = combo.rows(0)(1)
        Dim bott = combo.rows(0)(2)
        Dim id = combo.rows(0)(3)

        modificaCombo(tipo, lotto, bott + numBott, id)

    End Sub

    Public Sub modificaCombo(id_tipologia, id_lotto, numBott, id)

        Dim query = "update tipologia_lotto set id_tipologia = " + id_tipologia.ToString() + ", id_lotto = " + id_lotto.ToString() + ", numBott = " + numBott.ToString() + " where id = " + id.ToString()
        Esegui(query)
    End Sub

    'get'

    Public Function getVendite() As DataTable
        ' Forza l'uso dell'indice composto
        Dim str As String = "SELECT v.idvendita, v.numBottiglie, v.effettuata_programmata AS stato, 
                         v.data_vendita, l.idLotto, t.nome AS tipologia, v.cliente, v.note
                         FROM vendita v USE INDEX (idx_vendita_data_combo)
                         STRAIGHT_JOIN tipologia_lotto tl ON v.id_combo = tl.id
                         STRAIGHT_JOIN lotto l ON l.idlotto = tl.id_lotto
                         STRAIGHT_JOIN tipologia t ON t.idtipologia = tl.id_tipologia
                         ORDER BY v.data_vendita DESC;"

        Using localConn As New MySqlConnection(strConn)
            Try
                localConn.Open()

                Dim da As New MySqlDataAdapter(str, localConn)
                da.SelectCommand.CommandTimeout = 30

                Dim ds As New DataSet()
                da.Fill(ds)

                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return New DataTable()
                End If

            Catch ex As MySqlException
                MsgBox("Errore database: " & ex.Message)
                Return New DataTable()
            Catch ex As Exception
                MsgBox("Errore caricamento vendite: " & ex.Message)
                Return New DataTable()
            End Try
        End Using
    End Function

    Public Function getLotti() As DataTable
        Dim str As String = "SELECT l.data_produzione, l.idlotto, l.num_bottiglie FROM lotto l"
        Return DoQuery(Connetti(), str)
    End Function

    Public Function getTipologie() As DataTable
        Dim str = "select nome from tipologia"
        Return DoQuery(Connetti(), str)
    End Function

    Public Function getLottiPerTipologie() As DataTable
        Dim str As String = "SELECT l.data_produzione, l.idlotto, tl.numBott, t.nome as tipologia
                        FROM lotto l
                        JOIN tipologia_lotto tl ON l.idlotto = tl.id_lotto
                        JOIN tipologia t ON tl.id_tipologia = t.idtipologia;"
        Return DoQuery(Connetti(), str)
    End Function


    Sub BubbleSort(arr() As String)
        Dim n As Integer = arr.Length - 1
        Dim temp

        For i As Integer = 0 To n
            For j As Integer = 0 To (n - i) - 1
                If (arr(j).CompareTo(arr(j + 1)) > 0) Then
                    ' Scambia gli elementi  
                    temp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                End If
            Next
        Next
    End Sub

    Sub stampa(nome As String, path As String)

        Dim tabella As DataTable = Form1.DataGridView1.DataSource
        Try
            'creo file excel vuoto
            Dim fs = File.Create(path)
            fs.Close()

            'salvo il file 
            Dim wb As XLWorkbook = New XLWorkbook()
            wb.Worksheets.Add(tabella, nome)
            wb.SaveAs(path)

            'cancellare file  xml


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Trim(str As String, Optional path As String = " ")
        Dim lunghezzaInput As Integer = str.Length
        Dim lunghezzaPath As Integer = path.Length + 1 'tolgo il \ dalla stringa'
        Dim i As Integer = lunghezzaPath 'punto iniziale del nome'


        Dim a As Char() = str.ToArray()


        Dim spazi As Integer = 0 'numero di spazi trovati'

        'cerca gli spazi'
        For k As Integer = 0 To (lunghezzaInput - 1)
            If (a(k) Like " ") Then
                spazi = spazi + 1
            End If
        Next

        Dim lunghezzaNome = (lunghezzaInput - lunghezzaPath) - spazi
        Dim str_no_space(lunghezzaNome - 1) As Char 'nome '
        Dim j As Integer = 0


        While Not (j = str_no_space.Length)
            If ((a(i) Like " ") = False) Then
                str_no_space(j) = a(i).ToString()
                j = j + 1
            Else
                'non inserisco nel vettore'
            End If
            i = i + 1
        End While

        Dim newstr As New String(path + "\" + str_no_space)

        Return newstr

    End Function

    Public Function abs(num As Decimal) As Decimal
        If num < 0 Then
            Return num * -1
        Else
            Return num
        End If
    End Function

    Public Function isCollegato(idLotto As String, idTipologia As String) As Boolean
        Dim query As String = "SELECT COUNT(*) 
                          FROM tipologia_lotto
                          WHERE id_tipologia = @idTipologia
                          AND id_lotto = @idLotto;"

        Dim conn As MySqlConnection = Connetti()
        If conn Is Nothing Then Return False

        Try
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idTipologia", idTipologia)
            cmd.Parameters.AddWithValue("@idLotto", idLotto)

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Errore verifica collegamento: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

End Module
