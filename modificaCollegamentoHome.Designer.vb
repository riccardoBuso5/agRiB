<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificaCollegamentoHome
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        numBottiglie = New Label()
        NumericUpDown1 = New NumericUpDown()
        nometipologia = New Label()
        codLotto = New Label()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Label1 = New Label()
        NumericUpDown2 = New NumericUpDown()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' numBottiglie
        ' 
        numBottiglie.AutoSize = True
        numBottiglie.Location = New Point(40, 160)
        numBottiglie.Name = "numBottiglie"
        numBottiglie.Size = New Size(131, 15)
        numBottiglie.TabIndex = 13
        numBottiglie.Text = "numero bottiglieAttuali"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(201, 160)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1000000, 0, 0, Integer.MinValue})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 12
        ' 
        ' nometipologia
        ' 
        nometipologia.AutoSize = True
        nometipologia.Location = New Point(40, 237)
        nometipologia.Name = "nometipologia"
        nometipologia.Size = New Size(54, 15)
        nometipologia.TabIndex = 11
        nometipologia.Text = "tipologia"
        ' 
        ' codLotto
        ' 
        codLotto.AutoSize = True
        codLotto.Location = New Point(40, 116)
        codLotto.Name = "codLotto"
        codLotto.Size = New Size(45, 15)
        codLotto.TabIndex = 10
        codLotto.Text = "idLotto"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownWidth = 350
        ComboBox2.Font = New Font("Segoe UI", 12F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(201, 234)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 29)
        ComboBox2.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 11F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(201, 108)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(122, 301)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 38)
        Button1.TabIndex = 7
        Button1.Text = "invia"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 207)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 14
        Label1.Text = "puoi aggiungerne : "
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Enabled = False
        NumericUpDown2.Location = New Point(201, 199)
        NumericUpDown2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        NumericUpDown2.Minimum = New Decimal(New Integer() {10000000, 0, 0, Integer.MinValue})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.ReadOnly = True
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 15
        ' 
        ' modificaCollegamentoHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(403, 400)
        Controls.Add(NumericUpDown2)
        Controls.Add(Label1)
        Controls.Add(numBottiglie)
        Controls.Add(NumericUpDown1)
        Controls.Add(nometipologia)
        Controls.Add(codLotto)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Name = "modificaCollegamentoHome"
        Text = "modificaCollegamentoHome"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents numBottiglie As Label
    Friend WithEvents nometipologia As Label
    Friend WithEvents codLotto As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Public WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Public WithEvents NumericUpDown2 As NumericUpDown
End Class
