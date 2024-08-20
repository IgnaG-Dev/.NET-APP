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
        LNya = New Label()
        LDni = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LModificar = New Label()
        BGuardar = New Button()
        BEliminar = New Button()
        TDni = New TextBox()
        TNombre = New TextBox()
        TApellido = New TextBox()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(109, 74)
        LNya.Name = "LNya"
        LNya.Size = New Size(167, 25)
        LNya.TabIndex = 0
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(140, 127)
        LDni.Name = "LDni"
        LDni.Size = New Size(43, 25)
        LDni.TabIndex = 1
        LDni.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(109, 175)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(78, 25)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(108, 225)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(78, 25)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(282, 74)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(87, 25)
        LModificar.TabIndex = 4
        LModificar.Text = "Modificar"
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(107, 286)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(138, 34)
        BGuardar.TabIndex = 5
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(252, 286)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(142, 34)
        BEliminar.TabIndex = 6
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(189, 124)
        TDni.Name = "TDni"
        TDni.Size = New Size(205, 31)
        TDni.TabIndex = 7
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(189, 172)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(205, 31)
        TNombre.TabIndex = 8
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(189, 225)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(205, 31)
        TApellido.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 423)
        Controls.Add(TApellido)
        Controls.Add(TNombre)
        Controls.Add(TDni)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(LModificar)
        Controls.Add(LApellido)
        Controls.Add(LNombre)
        Controls.Add(LDni)
        Controls.Add(LNya)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pequeño Formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox

End Class
