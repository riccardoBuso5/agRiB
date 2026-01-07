<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificaTipologiaHome
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
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        ricercaXlotto = New Button()
        Label1 = New Label()
        SuspendLayout()
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
        ComboBox2.Location = New Point(81, 78)
        ComboBox2.Margin = New Padding(2)
        ComboBox2.MaxDropDownItems = 15
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(134, 29)
        ComboBox2.TabIndex = 35
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(81, 158)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(134, 27)
        TextBox1.TabIndex = 34
        ' 
        ' ricercaXlotto
        ' 
        ricercaXlotto.Font = New Font("Segoe UI", 12F)
        ricercaXlotto.Location = New Point(82, 201)
        ricercaXlotto.Margin = New Padding(2)
        ricercaXlotto.Name = "ricercaXlotto"
        ricercaXlotto.Size = New Size(132, 33)
        ricercaXlotto.TabIndex = 33
        ricercaXlotto.Text = "invia"
        ricercaXlotto.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 36
        Label1.Text = "nuovo nome"
        ' 
        ' modificaTipologiaHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(295, 338)
        Controls.Add(Label1)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox1)
        Controls.Add(ricercaXlotto)
        Margin = New Padding(3, 2, 3, 2)
        Name = "modificaTipologiaHome"
        Text = "modificaTipologiaHome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ricercaXlotto As Button
    Friend WithEvents Label1 As Label
End Class
