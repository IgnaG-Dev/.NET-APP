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
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(478, 109)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(275, 254)
        ListBox1.TabIndex = 0
        ' 
        ' LNumeros
        ' 
        LNumeros.AutoSize = True
        LNumeros.Location = New Point(548, 81)
        LNumeros.Name = "LNumeros"
        LNumeros.Size = New Size(147, 25)
        LNumeros.TabIndex = 1
        LNumeros.Text = "Lista de números"
        ' 
        ' LDesde
        ' 
        LDesde.AutoSize = True
        LDesde.Location = New Point(47, 114)
        LDesde.Name = "LDesde"
        LDesde.Size = New Size(62, 25)
        LDesde.TabIndex = 2
        LDesde.Text = "Desde"
        ' 
        ' LHasta
        ' 
        LHasta.AutoSize = True
        LHasta.Location = New Point(47, 164)
        LHasta.Name = "LHasta"
        LHasta.Size = New Size(57, 25)
        LHasta.TabIndex = 3
        LHasta.Text = "Hasta"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(110, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(110, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 5
        ' 
        ' BGenerarFuncion
        ' 
        BGenerarFuncion.Location = New Point(274, 109)
        BGenerarFuncion.Name = "BGenerarFuncion"
        BGenerarFuncion.Size = New Size(168, 34)
        BGenerarFuncion.TabIndex = 6
        BGenerarFuncion.Text = "Generar función"
        BGenerarFuncion.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BGenerarFuncion)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LHasta)
        Controls.Add(LDesde)
        Controls.Add(LNumeros)
        Controls.Add(ListBox1)
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

End Class
