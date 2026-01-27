<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        eliminaVendita = New Button()
        eliminaTipologia = New Button()
        NuovoLotto = New Button()
        NuovaVendita = New Button()
        NuovaTipologia = New Button()
        DataGridView1 = New DataGridView()
        visualizzaLotti = New Button()
        visualizzaTipologia = New Button()
        visualizzaVendita = New Button()
        eliminaLotto = New Button()
        scadenze = New Button()
        lottiDaRifornire = New Button()
        modificaVendita = New Button()
        visualizza_lotti_per_tipologia = New Button()
        collegaLottoTipologia = New Button()
        modificaLotto = New Button()
        ricercaXlotto = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        eliminaCollegamento = New Button()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        ricPerData = New Button()
        Button2 = New Button()
        modificaCollegamento = New Button()
        modifica_tipologia = New Button()
        Button3 = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Button4 = New Button()
        Dim tableLayout As TableLayoutPanel = New TableLayoutPanel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' eliminaVendita
        ' 
        eliminaVendita.Font = New Font("Segoe UI", 12F)
        eliminaVendita.Location = New Point(1306, 933)
        eliminaVendita.Margin = New Padding(2)
        eliminaVendita.Name = "eliminaVendita"
        eliminaVendita.Size = New Size(152, 55)
        eliminaVendita.TabIndex = 18
        eliminaVendita.Text = "elimina vendita"
        eliminaVendita.UseVisualStyleBackColor = True
        ' 
        ' eliminaTipologia
        ' 
        eliminaTipologia.Font = New Font("Segoe UI", 12F)
        eliminaTipologia.Location = New Point(1306, 705)
        eliminaTipologia.Margin = New Padding(2)
        eliminaTipologia.Name = "eliminaTipologia"
        eliminaTipologia.Size = New Size(152, 54)
        eliminaTipologia.TabIndex = 17
        eliminaTipologia.Text = "elimina tipologia"
        eliminaTipologia.UseVisualStyleBackColor = True
        ' 
        ' NuovoLotto
        ' 
        NuovoLotto.Font = New Font("Segoe UI", 12F)
        NuovoLotto.Location = New Point(982, 587)
        NuovoLotto.Margin = New Padding(2)
        NuovoLotto.Name = "NuovoLotto"
        NuovoLotto.Size = New Size(152, 54)
        NuovoLotto.TabIndex = 16
        NuovoLotto.Text = "nuovo lotto"
        NuovoLotto.UseVisualStyleBackColor = True
        ' 
        ' NuovaVendita
        ' 
        NuovaVendita.Font = New Font("Segoe UI", 12F)
        NuovaVendita.Location = New Point(982, 828)
        NuovaVendita.Margin = New Padding(2)
        NuovaVendita.Name = "NuovaVendita"
        NuovaVendita.Size = New Size(152, 54)
        NuovaVendita.TabIndex = 15
        NuovaVendita.Text = "nuova vendita"
        NuovaVendita.UseVisualStyleBackColor = True
        ' 
        ' NuovaTipologia
        ' 
        NuovaTipologia.AllowDrop = True
        NuovaTipologia.Font = New Font("Segoe UI", 12F)
        NuovaTipologia.Location = New Point(982, 705)
        NuovaTipologia.Margin = New Padding(2)
        NuovaTipologia.Name = "NuovaTipologia"
        NuovaTipologia.Size = New Size(152, 54)
        NuovaTipologia.TabIndex = 14
        NuovaTipologia.Text = "nuova tipologia"
        NuovaTipologia.UseCompatibleTextRendering = True
        NuovaTipologia.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.Padding = New Padding(0, 0, 0, 3)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 80
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 15F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.Padding = New Padding(1)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.GridColor = SystemColors.GradientActiveCaption
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 45
        DataGridView1.RowTemplate.Resizable = DataGridViewTriState.True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.ShowCellErrors = False
        DataGridView1.ShowCellToolTips = False
        DataGridView1.ShowEditingIcon = False
        DataGridView1.ShowRowErrors = False
        DataGridView1.Size = New Size(1877, 434)
        DataGridView1.TabIndex = 13
        DataGridView1.VirtualMode = True
        ' 
        ' visualizzaLotti
        ' 
        visualizzaLotti.Font = New Font("Segoe UI", 12F)
        visualizzaLotti.Location = New Point(442, 825)
        visualizzaLotti.Margin = New Padding(2)
        visualizzaLotti.Name = "visualizzaLotti"
        visualizzaLotti.Size = New Size(152, 55)
        visualizzaLotti.TabIndex = 12
        visualizzaLotti.Text = "visualizza lotti"
        visualizzaLotti.UseVisualStyleBackColor = True
        ' 
        ' visualizzaTipologia
        ' 
        visualizzaTipologia.Font = New Font("Segoe UI", 12F)
        visualizzaTipologia.Location = New Point(442, 587)
        visualizzaTipologia.Margin = New Padding(2)
        visualizzaTipologia.Name = "visualizzaTipologia"
        visualizzaTipologia.Size = New Size(152, 55)
        visualizzaTipologia.TabIndex = 11
        visualizzaTipologia.Text = "visualizza tipologia"
        visualizzaTipologia.UseVisualStyleBackColor = True
        ' 
        ' visualizzaVendita
        ' 
        visualizzaVendita.Font = New Font("Segoe UI", 12F)
        visualizzaVendita.Location = New Point(442, 704)
        visualizzaVendita.Margin = New Padding(2)
        visualizzaVendita.Name = "visualizzaVendita"
        visualizzaVendita.Size = New Size(152, 55)
        visualizzaVendita.TabIndex = 10
        visualizzaVendita.Text = "visualizza vendite"
        visualizzaVendita.UseVisualStyleBackColor = True
        ' 
        ' eliminaLotto
        ' 
        eliminaLotto.Font = New Font("Segoe UI", 12F)
        eliminaLotto.Location = New Point(1306, 822)
        eliminaLotto.Margin = New Padding(2)
        eliminaLotto.Name = "eliminaLotto"
        eliminaLotto.Size = New Size(152, 55)
        eliminaLotto.TabIndex = 9
        eliminaLotto.Text = "elimina lotto"
        eliminaLotto.UseVisualStyleBackColor = True
        ' 
        ' scadenze
        ' 
        scadenze.Font = New Font("Segoe UI", 12F)
        scadenze.Location = New Point(653, 703)
        scadenze.Margin = New Padding(2)
        scadenze.Name = "scadenze"
        scadenze.Size = New Size(152, 55)
        scadenze.TabIndex = 8
        scadenze.Text = "visualizza vendite in scadenza"
        scadenze.UseVisualStyleBackColor = True
        ' 
        ' lottiDaRifornire
        ' 
        lottiDaRifornire.Font = New Font("Segoe UI", 12F)
        lottiDaRifornire.Location = New Point(442, 933)
        lottiDaRifornire.Margin = New Padding(2)
        lottiDaRifornire.Name = "lottiDaRifornire"
        lottiDaRifornire.Size = New Size(152, 55)
        lottiDaRifornire.TabIndex = 7
        lottiDaRifornire.Text = "visualizza lotti da rifornire"
        lottiDaRifornire.UseVisualStyleBackColor = True
        ' 
        ' modificaVendita
        ' 
        modificaVendita.Font = New Font("Segoe UI", 12F)
        modificaVendita.Location = New Point(1622, 578)
        modificaVendita.Margin = New Padding(2)
        modificaVendita.Name = "modificaVendita"
        modificaVendita.Size = New Size(152, 54)
        modificaVendita.TabIndex = 2
        modificaVendita.Text = "modifica vendita"
        modificaVendita.UseVisualStyleBackColor = True
        ' 
        ' visualizza_lotti_per_tipologia
        ' 
        visualizza_lotti_per_tipologia.Font = New Font("Segoe UI", 12F)
        visualizza_lotti_per_tipologia.Location = New Point(653, 586)
        visualizza_lotti_per_tipologia.Margin = New Padding(2)
        visualizza_lotti_per_tipologia.Name = "visualizza_lotti_per_tipologia"
        visualizza_lotti_per_tipologia.Size = New Size(152, 55)
        visualizza_lotti_per_tipologia.TabIndex = 1
        visualizza_lotti_per_tipologia.Text = "visualizza lotti per tipologia"
        visualizza_lotti_per_tipologia.UseVisualStyleBackColor = True
        ' 
        ' collegaLottoTipologia
        ' 
        collegaLottoTipologia.AllowDrop = True
        collegaLottoTipologia.Font = New Font("Segoe UI", 12F)
        collegaLottoTipologia.Location = New Point(1622, 933)
        collegaLottoTipologia.Margin = New Padding(2)
        collegaLottoTipologia.Name = "collegaLottoTipologia"
        collegaLottoTipologia.Size = New Size(152, 54)
        collegaLottoTipologia.TabIndex = 0
        collegaLottoTipologia.Text = "collega lotto con tipologia"
        collegaLottoTipologia.UseCompatibleTextRendering = True
        collegaLottoTipologia.UseVisualStyleBackColor = True
        ' 
        ' modificaLotto
        ' 
        modificaLotto.Font = New Font("Segoe UI", 12F)
        modificaLotto.Location = New Point(1622, 745)
        modificaLotto.Margin = New Padding(2)
        modificaLotto.Name = "modificaLotto"
        modificaLotto.Size = New Size(152, 54)
        modificaLotto.TabIndex = 19
        modificaLotto.Text = "modifica lotto"
        modificaLotto.UseVisualStyleBackColor = True
        ' 
        ' ricercaXlotto
        ' 
        ricercaXlotto.Font = New Font("Segoe UI", 12F)
        ricercaXlotto.Location = New Point(116, 597)
        ricercaXlotto.Margin = New Padding(2)
        ricercaXlotto.Name = "ricercaXlotto"
        ricercaXlotto.Size = New Size(147, 35)
        ricercaXlotto.TabIndex = 21
        ricercaXlotto.Text = "cerca per lotto"
        ricercaXlotto.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(115, 726)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 53)
        Button1.TabIndex = 23
        Button1.Text = "cerca per tipologia"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft YaHei", 18F)
        Label1.Location = New Point(136, 477)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 31)
        Label1.TabIndex = 25
        Label1.Text = "ricerca"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft YaHei", 18F)
        Label2.Location = New Point(556, 477)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 31)
        Label2.TabIndex = 26
        Label2.Text = "visualizza"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft YaHei", 18F)
        Label3.Location = New Point(1000, 487)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 31)
        Label3.TabIndex = 27
        Label3.Text = "aggiungi"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft YaHei", 18F)
        Label4.Location = New Point(1335, 487)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 31)
        Label4.TabIndex = 28
        Label4.Text = "elimina"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft YaHei", 18F)
        Label5.Location = New Point(1643, 487)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 31)
        Label5.TabIndex = 29
        Label5.Text = "modifica"
        ' 
        ' eliminaCollegamento
        ' 
        eliminaCollegamento.Font = New Font("Segoe UI", 12F)
        eliminaCollegamento.Location = New Point(1306, 586)
        eliminaCollegamento.Margin = New Padding(2)
        eliminaCollegamento.Name = "eliminaCollegamento"
        eliminaCollegamento.Size = New Size(152, 55)
        eliminaCollegamento.TabIndex = 30
        eliminaCollegamento.Text = "elimina collegamento"
        eliminaCollegamento.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(115, 560)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(148, 27)
        TextBox1.TabIndex = 31
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownHeight = 400
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownWidth = 340
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.IntegralHeight = False
        ComboBox2.ItemHeight = 21
        ComboBox2.Location = New Point(117, 680)
        ComboBox2.Margin = New Padding(2)
        ComboBox2.MaxDropDownItems = 15
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(146, 29)
        ComboBox2.TabIndex = 32
        ' 
        ' ricPerData
        ' 
        ricPerData.Font = New Font("Segoe UI", 12F)
        ricPerData.Location = New Point(117, 914)
        ricPerData.Margin = New Padding(2)
        ricPerData.Name = "ricPerData"
        ricPerData.Size = New Size(146, 54)
        ricPerData.TabIndex = 33
        ricPerData.Text = "lotti venduti "
        ricPerData.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(653, 827)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 55)
        Button2.TabIndex = 34
        Button2.Text = "visualizza vendite scadute"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' modificaCollegamento
        ' 
        modificaCollegamento.Font = New Font("Segoe UI", 12F)
        modificaCollegamento.Location = New Point(1622, 827)
        modificaCollegamento.Margin = New Padding(2)
        modificaCollegamento.Name = "modificaCollegamento"
        modificaCollegamento.Size = New Size(152, 54)
        modificaCollegamento.TabIndex = 35
        modificaCollegamento.Text = "modifica collegamento"
        modificaCollegamento.UseVisualStyleBackColor = True
        ' 
        ' modifica_tipologia
        ' 
        modifica_tipologia.Font = New Font("Segoe UI", 12F)
        modifica_tipologia.Location = New Point(1622, 655)
        modifica_tipologia.Margin = New Padding(2)
        modifica_tipologia.Name = "modifica_tipologia"
        modifica_tipologia.Size = New Size(152, 54)
        modifica_tipologia.TabIndex = 36
        modifica_tipologia.Text = "modifica tipologia"
        modifica_tipologia.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F)
        Button3.Location = New Point(115, 822)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(148, 54)
        Button3.TabIndex = 37
        Button3.Text = "salva"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F)
        Button4.Location = New Point(115, 1013)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 54)
        Button4.TabIndex = 38
        Button4.Text = "aiuto"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AccessibleRole = AccessibleRole.None
        AllowDrop = True
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoSize = True
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1877, 1078)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(modifica_tipologia)
        Controls.Add(modificaCollegamento)
        Controls.Add(Button2)
        Controls.Add(ricPerData)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox1)
        Controls.Add(eliminaCollegamento)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(ricercaXlotto)
        Controls.Add(modificaLotto)
        Controls.Add(collegaLottoTipologia)
        Controls.Add(visualizza_lotti_per_tipologia)
        Controls.Add(modificaVendita)
        Controls.Add(lottiDaRifornire)
        Controls.Add(scadenze)
        Controls.Add(eliminaLotto)
        Controls.Add(visualizzaVendita)
        Controls.Add(visualizzaTipologia)
        Controls.Add(visualizzaLotti)
        Controls.Add(DataGridView1)
        Controls.Add(NuovaTipologia)
        Controls.Add(NuovaVendita)
        Controls.Add(NuovoLotto)
        Controls.Add(eliminaTipologia)
        Controls.Add(eliminaVendita)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "Form1"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents eliminaVendita As Button
    Friend WithEvents eliminaTipologia As Button
    Friend WithEvents NuovoLotto As Button
    Friend WithEvents NuovaVendita As Button
    Friend WithEvents NuovaTipologia As Button
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents visualizzaLotti As Button
    Friend WithEvents visualizzaTipologia As Button
    Friend WithEvents visualizzaVendita As Button
    Friend WithEvents eliminaLotto As Button
    Friend WithEvents scadenze As Button
    Friend WithEvents lottiDaRifornire As Button
    Friend WithEvents modificaVendita As Button
    Friend WithEvents visualizza_lotti_per_tipologia As Button
    Friend WithEvents collegaLottoTipologia As Button
    Friend WithEvents modificaLotto As Button
    Friend WithEvents ricercaXlotto As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents eliminaCollegamento As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ricPerData As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents modificaCollegamento As Button
    Friend WithEvents modifica_tipologia As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button4 As Button

End Class
