<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aggiungiLottoHome
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
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        NumericUpDown1 = New NumericUpDown()
        TextBox1 = New TextBox()
        Label4 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.ImeMode = ImeMode.NoControl
        DateTimePicker1.Location = New Point(245, 53)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(204, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(157, 195)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 43)
        Button1.TabIndex = 1
        Button1.Text = "conferma"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 15)
        Label1.TabIndex = 4
        Label1.Text = "data di produzione"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 15)
        Label2.TabIndex = 5
        Label2.Text = "numero bottiglie prodotte"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Segoe UI", 11F)
        NumericUpDown1.Location = New Point(245, 99)
        NumericUpDown1.Margin = New Padding(3, 2, 3, 2)
        NumericUpDown1.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(204, 27)
        NumericUpDown1.TabIndex = 7
        NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(245, 9)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(204, 27)
        TextBox1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 9
        Label4.Text = "numero lotto"
        ' 
        ' aggiungiLottoHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 278)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Margin = New Padding(3, 2, 3, 2)
        MinimizeBox = False
        Name = "aggiungiLottoHome"
        Text = "aggiungiLottoHome"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
