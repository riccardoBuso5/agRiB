<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ricercaPerData
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
        DateTimePicker2 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 11F)
        DateTimePicker1.Location = New Point(29, 122)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 27)
        DateTimePicker1.TabIndex = 0
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 11F)
        DateTimePicker2.Location = New Point(29, 193)
        DateTimePicker2.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(219, 27)
        DateTimePicker2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 2
        Label1.Text = "DA:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 15)
        Label2.TabIndex = 3
        Label2.Text = "A: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(89, 235)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 36)
        Button1.TabIndex = 4
        Button1.Text = "cerca"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.DropDownWidth = 350
        ComboBox1.Font = New Font("Segoe UI", 11F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(29, 46)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(133, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 6
        Label3.Text = "TIPOLOGIA"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(251, 55)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(110, 27)
        TextBox1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(251, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 15)
        Label4.TabIndex = 8
        Label4.Text = "numero totale bottiglie : "
        ' 
        ' ricercaPerData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(426, 388)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Margin = New Padding(3, 2, 3, 2)
        MinimizeBox = False
        Name = "ricercaPerData"
        Text = "ricercaPerData"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
