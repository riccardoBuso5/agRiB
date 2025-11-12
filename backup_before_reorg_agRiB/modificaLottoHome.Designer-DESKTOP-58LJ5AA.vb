<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificaLottoHome
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
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        comboBox2 = New ComboBox()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 18
        Label4.Text = "numero lotto"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(241, 106)
        NumericUpDown1.Margin = New Padding(3, 2, 3, 2)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1000000, 0, 0, Integer.MinValue})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(204, 23)
        NumericUpDown1.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 15)
        Label2.TabIndex = 14
        Label2.Text = "numero bottiglie prodotte"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 15)
        Label1.TabIndex = 13
        Label1.Text = "data di produzione"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(148, 178)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 43)
        Button1.TabIndex = 11
        Button1.Text = "conferma"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.ImeMode = ImeMode.NoControl
        DateTimePicker1.Location = New Point(241, 56)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(204, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' comboBox2
        ' 
        comboBox2.FormattingEnabled = True
        comboBox2.Location = New Point(241, 16)
        comboBox2.Margin = New Padding(3, 2, 3, 2)
        comboBox2.Name = "comboBox2"
        comboBox2.Size = New Size(204, 23)
        comboBox2.TabIndex = 19
        ' 
        ' modificaLottoHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(535, 313)
        Controls.Add(comboBox2)
        Controls.Add(Label4)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "modificaLottoHome"
        Text = "modificaLottoHome"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents comboBox2 As ComboBox
End Class
