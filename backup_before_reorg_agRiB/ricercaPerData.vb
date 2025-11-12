Imports System.Security.Cryptography.X509Certificates
Imports MySql.Installer.Dialogs

Public Class ricercaPerData

    Public Function getData()
        Dim dataFrom = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim dataTo = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        Dim idTipologia As String = ComboBox1.SelectedItem("idTipologia")

        'sistemare '
        Dim query =
        "SELECT idLotto as codLotto, tipologia.nome As tipologia, t1.numBottiglie As Bottiglie, idvendita 
         From vendita As t1
        Join tipologia_lotto As t2 On id_combo = id 
        Join tipologia On idTipologia = t2.id_tipologia
         Where id_tipologia = " + idTipologia + "
         And data_vendita >= ' " + dataFrom + " ' 
         And data_vendita <= '" + dataTo + "' ;"



        Return DoQuery(Connetti(), query)

    End Function

    Public Function contaBotTot()
        Dim dataFrom = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim dataTo = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        Dim idTipologia As String = ComboBox1.SelectedItem("idTipologia")


        Dim query =
         " SELECT sum(t1.numBottiglie) as numBott 
         From vendita As t1
         Join tipologia_lotto On id_combo = id 
         Where id_tipologia = " + idTipologia + " 
         And data_vendita >= ' " + dataFrom + " ' 
         And data_vendita <= '" + dataTo + "' ;"


        Dim num = Esegui(query)
        If num IsNot DBNull.Value Then
            Return num
        Else Return 0

        End If

    End Function

    Private Sub ricercaPerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        popolaCombo()
    End Sub

    Private Sub popolaCombo()
        ComboBox1.DataSource = DoQuery(Connetti(), "select * from tipologia ORDER BY nome ASC")
        ComboBox1.DisplayMember = "nome"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.modificaDataGrid(getData())
        TextBox1.Text = contaBotTot()

    End Sub
End Class