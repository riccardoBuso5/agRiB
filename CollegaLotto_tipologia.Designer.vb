<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollegaLotto_tipologia
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
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        codLotto = New Label()
        nometipologia = New Label()
        NumericUpDown1 = New NumericUpDown()
        numBottiglie = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(143, 279)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 38)
        Button1.TabIndex = 0
        Button1.Text = "invia"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 11F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(222, 86)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownWidth = 350
        ComboBox2.Font = New Font("Segoe UI", 12F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(222, 212)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 29)
        ComboBox2.TabIndex = 2
        ' 
        ' codLotto
        ' 
        codLotto.AutoSize = True
        codLotto.Location = New Point(61, 94)
        codLotto.Name = "codLotto"
        codLotto.Size = New Size(45, 15)
        codLotto.TabIndex = 3
        codLotto.Text = "idLotto"
        ' 
        ' nometipologia
        ' 
        nometipologia.AutoSize = True
        nometipologia.Location = New Point(61, 215)
        nometipologia.Name = "nometipologia"
        nometipologia.Size = New Size(54, 15)
        nometipologia.TabIndex = 4
        nometipologia.Text = "tipologia"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(222, 154)
        NumericUpDown1.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 5
        ' 
        ' numBottiglie
        ' 
        numBottiglie.AutoSize = True
        numBottiglie.Location = New Point(61, 154)
        numBottiglie.Name = "numBottiglie"
        numBottiglie.Size = New Size(96, 15)
        numBottiglie.TabIndex = 6
        numBottiglie.Text = "numero bottiglie"
        ' 
        ' CollegaLotto_tipologia
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(421, 372)
        Controls.Add(numBottiglie)
        Controls.Add(NumericUpDown1)
        Controls.Add(nometipologia)
        Controls.Add(codLotto)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        MinimizeBox = False
        Name = "CollegaLotto_tipologia"
        Text = "CollegaLotto_tipologia"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents codLotto As Label
    Friend WithEvents nometipologia As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents numBottiglie As Label
End Class
