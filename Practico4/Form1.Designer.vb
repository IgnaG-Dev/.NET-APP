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
        ListBox1 = New ListBox()
        LNumeros = New Label()
        LDesde = New Label()
        LHasta = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        BGenerarFuncion = New Button()
        BPares = New Button()
        BImpares = New Button()
        BPrimos = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(335, 65)
        ListBox1.Margin = New Padding(2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(194, 154)
        ListBox1.TabIndex = 0
        ' 
        ' LNumeros
        ' 
        LNumeros.AutoSize = True
        LNumeros.Location = New Point(384, 49)
        LNumeros.Margin = New Padding(2, 0, 2, 0)
        LNumeros.Name = "LNumeros"
        LNumeros.Size = New Size(97, 15)
        LNumeros.TabIndex = 1
        LNumeros.Text = "Lista de números"
        ' 
        ' LDesde
        ' 
        LDesde.AutoSize = True
        LDesde.Location = New Point(33, 68)
        LDesde.Margin = New Padding(2, 0, 2, 0)
        LDesde.Name = "LDesde"
        LDesde.Size = New Size(39, 15)
        LDesde.TabIndex = 2
        LDesde.Text = "Desde"
        ' 
        ' LHasta
        ' 
        LHasta.AutoSize = True
        LHasta.Location = New Point(33, 98)
        LHasta.Margin = New Padding(2, 0, 2, 0)
        LHasta.Name = "LHasta"
        LHasta.Size = New Size(37, 15)
        LHasta.TabIndex = 3
        LHasta.Text = "Hasta"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(77, 67)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(106, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(77, 97)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(106, 23)
        TextBox2.TabIndex = 5
        ' 
        ' BGenerarFuncion
        ' 
        BGenerarFuncion.Location = New Point(202, 67)
        BGenerarFuncion.Margin = New Padding(2)
        BGenerarFuncion.Name = "BGenerarFuncion"
        BGenerarFuncion.Size = New Size(118, 20)
        BGenerarFuncion.TabIndex = 6
        BGenerarFuncion.Text = "Generar función"
        BGenerarFuncion.UseVisualStyleBackColor = True
        ' 
        ' BPares
        ' 
        BPares.Location = New Point(202, 135)
        BPares.Name = "BPares"
        BPares.Size = New Size(118, 23)
        BPares.TabIndex = 7
        BPares.Text = "Números pares"
        BPares.UseVisualStyleBackColor = True
        ' 
        ' BImpares
        ' 
        BImpares.Location = New Point(202, 164)
        BImpares.Name = "BImpares"
        BImpares.Size = New Size(118, 23)
        BImpares.TabIndex = 8
        BImpares.Text = "Números impares"
        BImpares.UseVisualStyleBackColor = True
        ' 
        ' BPrimos
        ' 
        BPrimos.Location = New Point(202, 193)
        BPrimos.Name = "BPrimos"
        BPrimos.Size = New Size(118, 23)
        BPrimos.TabIndex = 9
        BPrimos.Text = "Números primos"
        BPrimos.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(BPrimos)
        Controls.Add(BImpares)
        Controls.Add(BPares)
        Controls.Add(BGenerarFuncion)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LHasta)
        Controls.Add(LDesde)
        Controls.Add(LNumeros)
        Controls.Add(ListBox1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Formulario 4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LNumeros As Label
    Friend WithEvents LDesde As Label
    Friend WithEvents LHasta As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BGenerarFuncion As Button
    Friend WithEvents BPares As Button
    Friend WithEvents BImpares As Button
    Friend WithEvents BPrimos As Button

End Class
