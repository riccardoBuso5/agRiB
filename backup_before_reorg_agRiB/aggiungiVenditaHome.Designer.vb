<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aggiungiVenditaHome
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        NumericUpDown1 = New NumericUpDown()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        CheckBox1 = New CheckBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        NumericUpDown2 = New NumericUpDown()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(90, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 15)
        Label2.TabIndex = 1
        Label2.Text = "effettuata/programmata"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(90, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 2
        Label3.Text = "data vendita"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(90, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 3
        Label4.Text = "lotto"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(102, 132)
        RadioButton1.Margin = New Padding(3, 2, 3, 2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(76, 19)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "effettuata"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(102, 154)
        RadioButton2.Margin = New Padding(3, 2, 3, 2)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(98, 19)
        RadioButton2.TabIndex = 6
        RadioButton2.Text = "programmata"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(102, 216)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 23)
        DateTimePicker1.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 11F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(90, 66)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(133, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(205, 456)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 55)
        Button1.TabIndex = 9
        Button1.Text = "conferma"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Segoe UI", 11F)
        NumericUpDown1.Location = New Point(102, 287)
        NumericUpDown1.Margin = New Padding(3, 2, 3, 2)
        NumericUpDown1.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(131, 27)
        NumericUpDown1.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 260)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 10
        Label1.Text = "numero bottiglie"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownWidth = 340
        ComboBox2.Font = New Font("Segoe UI", 11F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(267, 66)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(175, 28)
        ComboBox2.TabIndex = 12
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(102, 405)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(70, 19)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "PRIVATO"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(184, 350)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 27)
        TextBox1.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(90, 358)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 15
        Label5.Text = "NOTE :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(267, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 17
        Label6.Text = "tipologia"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(469, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 15)
        Label7.TabIndex = 18
        Label7.Text = "bottiglie disp"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Enabled = False
        NumericUpDown2.Font = New Font("Segoe UI", 11F)
        NumericUpDown2.Location = New Point(469, 67)
        NumericUpDown2.Margin = New Padding(3, 2, 3, 2)
        NumericUpDown2.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.ReadOnly = True
        NumericUpDown2.Size = New Size(131, 27)
        NumericUpDown2.TabIndex = 19
        ' 
        ' aggiungiVenditaHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 558)
        Controls.Add(NumericUpDown2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(CheckBox1)
        Controls.Add(ComboBox2)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "aggiungiVenditaHome"
        Text = "aggiungiVenditaHome"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
End Class
