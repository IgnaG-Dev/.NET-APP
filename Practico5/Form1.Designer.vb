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
        OpenFileDialog1 = New OpenFileDialog()
        BFoto = New Button()
        PictureBox1 = New PictureBox()
        LFoto = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LFechaNacimiento = New Label()
        LSexo = New Label()
        LSaldo = New Label()
        Panel1 = New Panel()
        DTPFechaNacimiento = New DateTimePicker()
        BGuardar = New Button()
        TBSaldo = New TextBox()
        RBMujer = New RadioButton()
        RBHombre = New RadioButton()
        TBApellido = New TextBox()
        TBNombre = New TextBox()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' BFoto
        ' 
        BFoto.Location = New Point(58, 240)
        BFoto.Name = "BFoto"
        BFoto.Size = New Size(75, 23)
        BFoto.TabIndex = 0
        BFoto.Text = "Foto"
        BFoto.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(523, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(265, 272)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LFoto
        ' 
        LFoto.AutoSize = True
        LFoto.BackColor = SystemColors.ButtonShadow
        LFoto.BorderStyle = BorderStyle.Fixed3D
        LFoto.Location = New Point(147, 244)
        LFoto.Name = "LFoto"
        LFoto.Size = New Size(2, 17)
        LFoto.TabIndex = 2
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.Location = New Point(58, 22)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(89, 30)
        LNombre.TabIndex = 3
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.Location = New Point(56, 65)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(89, 30)
        LApellido.TabIndex = 4
        LApellido.Text = "Apellido"
        ' 
        ' LFechaNacimiento
        ' 
        LFechaNacimiento.AutoSize = True
        LFechaNacimiento.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LFechaNacimiento.Location = New Point(56, 106)
        LFechaNacimiento.Name = "LFechaNacimiento"
        LFechaNacimiento.Size = New Size(180, 30)
        LFechaNacimiento.TabIndex = 5
        LFechaNacimiento.Text = "Fecha Nacimiento"
        ' 
        ' LSexo
        ' 
        LSexo.AutoSize = True
        LSexo.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LSexo.Location = New Point(56, 146)
        LSexo.Name = "LSexo"
        LSexo.Size = New Size(57, 30)
        LSexo.TabIndex = 6
        LSexo.Text = "Sexo"
        ' 
        ' LSaldo
        ' 
        LSaldo.AutoSize = True
        LSaldo.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LSaldo.Location = New Point(58, 190)
        LSaldo.Name = "LSaldo"
        LSaldo.Size = New Size(64, 30)
        LSaldo.TabIndex = 7
        LSaldo.Text = "Saldo"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(DTPFechaNacimiento)
        Panel1.Controls.Add(BGuardar)
        Panel1.Controls.Add(LFoto)
        Panel1.Controls.Add(TBSaldo)
        Panel1.Controls.Add(RBMujer)
        Panel1.Controls.Add(RBHombre)
        Panel1.Controls.Add(TBApellido)
        Panel1.Controls.Add(TBNombre)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(LSaldo)
        Panel1.Controls.Add(BFoto)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(LSexo)
        Panel1.Controls.Add(LFechaNacimiento)
        Panel1.Location = New Point(12, 18)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(468, 345)
        Panel1.TabIndex = 8
        ' 
        ' DTPFechaNacimiento
        ' 
        DTPFechaNacimiento.Format = DateTimePickerFormat.Short
        DTPFechaNacimiento.Location = New Point(242, 112)
        DTPFechaNacimiento.Name = "DTPFechaNacimiento"
        DTPFechaNacimiento.Size = New Size(147, 23)
        DTPFechaNacimiento.TabIndex = 16
        ' 
        ' BGuardar
        ' 
        BGuardar.BackgroundImageLayout = ImageLayout.None
        BGuardar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), Image)
        BGuardar.ImageAlign = ContentAlignment.MiddleRight
        BGuardar.Location = New Point(242, 276)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(147, 56)
        BGuardar.TabIndex = 9
        BGuardar.Text = "Guardar"
        BGuardar.TextAlign = ContentAlignment.MiddleLeft
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' TBSaldo
        ' 
        TBSaldo.Location = New Point(242, 197)
        TBSaldo.Name = "TBSaldo"
        TBSaldo.Size = New Size(147, 23)
        TBSaldo.TabIndex = 15
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(333, 156)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 13
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' RBHombre
        ' 
        RBHombre.AutoSize = True
        RBHombre.Location = New Point(242, 156)
        RBHombre.Name = "RBHombre"
        RBHombre.Size = New Size(69, 19)
        RBHombre.TabIndex = 12
        RBHombre.Text = "Hombre"
        RBHombre.UseVisualStyleBackColor = True
        ' 
        ' TBApellido
        ' 
        TBApellido.Location = New Point(242, 72)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(147, 23)
        TBApellido.TabIndex = 11
        ' 
        ' TBNombre
        ' 
        TBNombre.Location = New Point(242, 29)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(147, 23)
        TBNombre.TabIndex = 10
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(53, 395)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ShowCellErrors = False
        DataGridView1.ShowCellToolTips = False
        DataGridView1.ShowEditingIcon = False
        DataGridView1.ShowRowErrors = False
        DataGridView1.Size = New Size(843, 306)
        DataGridView1.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(950, 742)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BFoto As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LFoto As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LFechaNacimiento As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents LSaldo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBSaldo As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DTPFechaNacimiento As DateTimePicker

End Class
