
Imports System.IO
Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient


Module funzioni
    Public conn As MySqlConnection
    Public flag = False


    'exe'
    Public Function leggiDaFile(Optional path As String = ".\paswd.txt")
        Dim fileReader As String
        Try
            fileReader = My.Computer.FileSystem.ReadAllText(path)
            Return fileReader
        Catch ex As Exception
            MsgBox("file non trovato")
        End Try
        fileReader = My.Computer.FileSystem.ReadAllText(path)
        Return fileReader
    End Function


    Public Function Connetti()
        If flag = True Then
            Return conn
        End If

        Dim strConn = leggiDaFile()
        conn = New MySqlConnection(strConn)
        flag = True
        Return conn

    End Function

    Public Function StampaTabellaIntera(conn As MySqlConnection)

        Dim str As String = "SELECT * 
                            FROM lotto
                            JOIN vendita ON lotto.idlotto = vendita.idLotto
                            JOIN tipologia_lotto ON lotto.idlotto = tipologia_lotto.id_lotto
                            JOIN tipologia ON tipologia.idtipologia = tipologia_lotto.id_tipologia;"


        Dim da As New MySqlDataAdapter(str, conn)
        conn.Close()
        Dim ds As New DataSet()

        da.Fill(ds)
        Dim table As DataTable = ds.Tables(0)

        Return table



    End Function


    Public Function DoQuery(conn As MySqlConnection, query As String)

        If (query.Equals("")) Then
            Throw New Exception
        End If


        Dim da As New MySqlDataAdapter(query, conn) 'preleva i dati dal DB'
        Dim ds As New DataSet() 'crea la tabella'
        da.Fill(ds) 'inserisce i dati nella tabella'


        Return ds.Tables(0)


    End Function

    Public Function Esegui(query As String)

        If (query.Equals("")) Then
            Return 0
        End If

        Dim conn As MySqlConnection = Connetti()
        conn.Open()

        Dim cmd As New MySqlCommand(query, conn)
        Dim Reader = cmd.ExecuteScalar

        conn.Close()
        Return Reader


    End Function

    'ricerca'

    Public Function isCollegato(idLotto, idTipologia)
        Dim str As String = "select count(*) 
                            from tipologia_lotto
                            where id_tipologia =" + idTipologia + "
                            and id_lotto =" + idLotto + ";"
        If Esegui(str) > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function ricercaPerCodLotto(codLotto)
        Dim query =
        " SELECT lotto.idlotto, data_produzione, numBott As numeroBottDisponibiliPerTipologia, nome As tipologia
        From lotto
        Join tipologia_lotto On lotto.idlotto = tipologia_lotto.id_lotto
        Join tipologia On tipologia.idtipologia = tipologia_lotto.id_tipologia
        Where lotto.idLotto =" + codLotto + ";"

        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds

    End Function

    Public Function ricercaPerCodTipo(codTipo)
        Dim query =
        "SELECT lotto.idlotto, data_produzione, numBott As numeroBottPerTipologia , nome As tipologia
        From lotto
        Join tipologia_lotto On lotto.idlotto = tipologia_lotto.id_lotto
        Join tipologia On tipologia.idtipologia = tipologia_lotto.id_tipologia
        where tipologia.idTipologia =" + codTipo + ";"

        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds

    End Function

    Public Function controllaScadenze()
        Dim scadenza As DateTime = Today.AddDays(7)
        Dim query As String = "select * from vendita where data_vendita <=  '" + scadenza.ToString("yyyy-MM-dd") + " ' and effettuata_programmata = 'programmata'"
        Dim ds As DataTable = DoQuery(Connetti(), query)

        Return ds

    End Function

    Public Function lottiDaRifornire()
        Dim query As String = "select * from lotto where num_bottiglie < 1000 "

        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds

    End Function

    Public Function controllaDate()
        Dim query As String = "select * from  vendita where data_vendita <= ' " + Today.ToString("yyyy-MM-dd") + "' and effettuata_programmata = 'programmata'"
        Dim ds As DataTable = DoQuery(Connetti(), query)
        'spunta le vendite da programmate ad effettuate'
        Return ds
    End Function

    Public Function get_numBot_usate_perLotto(idLotto)

        Dim query = "SELECT
                    SUM(numBott) AS sum_quantity
                    FROM tipologia_lotto 
                    where id_lotto = " + idLotto.ToString()

        Dim num = Esegui(query)
        If num IsNot DBNull.Value Then
            Return num
        End If

        Return 0
    End Function

    Public Function get_numBott_lotto(idLotto)
        Dim query = "select num_bottiglie from lotto where idLotto = " + idLotto.ToString()
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds.Rows(0)(0).ToString()
    End Function

    Public Function get_num_bott_per_combo(idCombinazione As String)

        Dim query = "select numBott from tipologia_lotto where id= " + idCombinazione.ToString()
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Return ds.Rows(0)(0).ToString()
    End Function


    Public Function trovaNomeTipologiaFromid(Id As String)
        Dim query As String = "select nome from tipologia where idTipologia = " + Id + ""
        Dim ds As DataTable = DoQuery(Connetti(), query)
        Dim nomeTipologia As String = ds.Rows(0)(0).ToString()

        Return nomeTipologia
    End Function

    Public Function trovaIdTipologiaFromNome(nome As String)
        Dim query As String = "select idTipologia from tipologia where nome = '" + nome + "'"
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

    Public Function getVendite()
        Dim str = "SELECT idvendita,numBottiglie,effettuata_programmata as stato, data_vendita, l.idLotto, nome as tipologia, cliente, note
                   FROM vendita
                   JOIN tipologia_lotto AS t1 ON vendita.id_combo = t1.id
                   JOIN lotto AS l ON l.idlotto = t1.id_lotto
                   JOIN tipologia AS t3 ON t3.idtipologia = t1.id_tipologia;"


        Return DoQuery(Connetti, str)

    End Function

    Public Function getLotti()
        Dim str As String = "
            SELECT  l.data_produzione, l.idlotto,l.num_bottiglie
            FROM lotto l"

        Return DoQuery(Connetti, str)
    End Function

    Public Function getTipologie()
        Dim str = "select nome from tipologia"
        Return DoQuery(Connetti, str)
    End Function

    Public Function getLottiPerTipologie()
        Dim str As String = "SELECT  l.data_produzione, l.idlotto,tl.numBott,t.nome as tipologia
                            FROM lotto l
                            JOIN tipologia_lotto tl ON l.idlotto = tl.id_lotto
                            JOIN tipologia t ON tl.id_tipologia = t.idtipologia;"


        Return DoQuery(Connetti, str)
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

    Public Function abs(num)
        If (num < 0) Then
            Return num * -1
        Else
            If (num >= 0) Then
                Return num
            End If
        End If
    End Function



End Module
