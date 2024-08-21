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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Panel1 = New Panel()
        TTelefono = New TextBox()
        LTarjetaCredito = New Label()
        LTelefono = New Label()
        CBMasterCard = New CheckBox()
        CBVisa = New CheckBox()
        CBNaranja = New CheckBox()
        PictureBox1 = New PictureBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        BSalir = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        resources.ApplyResources(LNya, "LNya")
        LNya.BackColor = SystemColors.ControlLight
        LNya.Name = "LNya"
        ' 
        ' LDni
        ' 
        resources.ApplyResources(LDni, "LDni")
        LDni.BackColor = SystemColors.ControlLight
        LDni.Name = "LDni"
        ' 
        ' LNombre
        ' 
        resources.ApplyResources(LNombre, "LNombre")
        LNombre.BackColor = SystemColors.ControlLight
        LNombre.Name = "LNombre"
        ' 
        ' LApellido
        ' 
        resources.ApplyResources(LApellido, "LApellido")
        LApellido.BackColor = SystemColors.ControlLight
        LApellido.Name = "LApellido"
        ' 
        ' LModificar
        ' 
        resources.ApplyResources(LModificar, "LModificar")
        LModificar.BackColor = SystemColors.ControlLight
        LModificar.ForeColor = Color.Red
        LModificar.Name = "LModificar"
        ' 
        ' BGuardar
        ' 
        resources.ApplyResources(BGuardar, "BGuardar")
        BGuardar.Name = "BGuardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        resources.ApplyResources(BEliminar, "BEliminar")
        BEliminar.Name = "BEliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' TDni
        ' 
        resources.ApplyResources(TDni, "TDni")
        TDni.Name = "TDni"
        ' 
        ' TNombre
        ' 
        resources.ApplyResources(TNombre, "TNombre")
        TNombre.Name = "TNombre"
        ' 
        ' TApellido
        ' 
        resources.ApplyResources(TApellido, "TApellido")
        TApellido.Name = "TApellido"
        ' 
        ' Panel1
        ' 
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TTelefono)
        Panel1.Controls.Add(LTarjetaCredito)
        Panel1.Controls.Add(LTelefono)
        Panel1.Controls.Add(CBMasterCard)
        Panel1.Controls.Add(CBVisa)
        Panel1.Controls.Add(CBNaranja)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(LNya)
        Panel1.Controls.Add(LDni)
        Panel1.Name = "Panel1"
        ' 
        ' TTelefono
        ' 
        resources.ApplyResources(TTelefono, "TTelefono")
        TTelefono.Name = "TTelefono"
        ' 
        ' LTarjetaCredito
        ' 
        resources.ApplyResources(LTarjetaCredito, "LTarjetaCredito")
        LTarjetaCredito.Name = "LTarjetaCredito"
        ' 
        ' LTelefono
        ' 
        resources.ApplyResources(LTelefono, "LTelefono")
        LTelefono.Name = "LTelefono"
        ' 
        ' CBMasterCard
        ' 
        resources.ApplyResources(CBMasterCard, "CBMasterCard")
        CBMasterCard.Name = "CBMasterCard"
        CBMasterCard.UseVisualStyleBackColor = True
        ' 
        ' CBVisa
        ' 
        resources.ApplyResources(CBVisa, "CBVisa")
        CBVisa.Name = "CBVisa"
        CBVisa.UseVisualStyleBackColor = True
        ' 
        ' CBNaranja
        ' 
        resources.ApplyResources(CBNaranja, "CBNaranja")
        CBNaranja.Name = "CBNaranja"
        CBNaranja.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.BackgroundImage = My.Resources.Resources.varon
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' RBVaron
        ' 
        resources.ApplyResources(RBVaron, "RBVaron")
        RBVaron.Checked = True
        RBVaron.Name = "RBVaron"
        RBVaron.TabStop = True
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        resources.ApplyResources(RBMujer, "RBMujer")
        RBMujer.Name = "RBMujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        resources.ApplyResources(BSalir, "BSalir")
        BSalir.Name = "BSalir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = SystemColors.ActiveCaption
        Label1.Name = "Label1"
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(BSalir)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(TNombre)
        Controls.Add(PictureBox1)
        Controls.Add(TDni)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(LModificar)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents CBMasterCard As CheckBox
    Friend WithEvents CBVisa As CheckBox
    Friend WithEvents CBNaranja As CheckBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents LTarjetaCredito As Label
    Friend WithEvents BSalir As Button
    Friend WithEvents Label1 As Label

End Class
