Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar OpenFileDialog
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.bmp;*.png"
        OpenFileDialog1.InitialDirectory = "C:\"
        ConfigureDataGridView()
    End Sub

    Private Sub ConfigureDataGridView()
        ' Configura las columnas del DataGridView
        Dim colApellido As New DataGridViewTextBoxColumn With {.Name = "Apellido", .HeaderText = "Apellido", .DefaultCellStyle = New DataGridViewCellStyle With {.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)}}
        Dim colNombre As New DataGridViewTextBoxColumn With {.Name = "Nombre", .HeaderText = "Nombre", .DefaultCellStyle = New DataGridViewCellStyle With {.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)}}
        Dim colFechaNacimiento As New DataGridViewTextBoxColumn With {.Name = "FechaNacimiento", .HeaderText = "Fecha de Nacimiento"}
        Dim colSexo As New DataGridViewTextBoxColumn With {.Name = "Sexo", .HeaderText = "Sexo"}
        Dim colEliminar As New DataGridViewButtonColumn With {.Name = "Eliminar", .Text = "Eliminar", .UseColumnTextForButtonValue = True, .HeaderText = "Eliminar"}
        Dim colSaldo As New DataGridViewTextBoxColumn With {.Name = "Saldo", .HeaderText = "Saldo"}
        Dim colFoto As New DataGridViewImageColumn With {.Name = "Foto", .HeaderText = "Foto", .ImageLayout = DataGridViewImageCellLayout.Stretch}
        Dim colRutaFoto As New DataGridViewTextBoxColumn With {.Name = "Ruta", .HeaderText = "Ruta"}

        ' Añadir las columnas al DataGridView
        DataGridView1.Columns.AddRange({colApellido, colNombre, colFechaNacimiento, colSexo, colEliminar, colSaldo, colFoto, colRutaFoto})
    End Sub

    Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
        ' Maneja la selección de foto
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            LFoto.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TBSaldo_TextChanged(sender As Object, e As EventArgs) Handles TBSaldo.TextChanged
        ' Validación para que solo se puedan ingresar números
        If Not IsNumeric(TBSaldo.Text) And TBSaldo.Text <> String.Empty Then
            MessageBox.Show("Por favor, ingrese un saldo válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBSaldo.Clear()
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(TBNombre.Text) OrElse String.IsNullOrWhiteSpace(TBApellido.Text) OrElse String.IsNullOrWhiteSpace(TBSaldo.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar que se haya seleccionado una imagen
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Debe seleccionar una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar que esté seleccionado Hombre o Mujer
        If Not RBHombre.Checked And Not RBMujer.Checked Then
            MessageBox.Show("Debe seleccionar el sexo: Hombre o Mujer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obtener valores de los inputs
        Dim nombre As String = TBNombre.Text
        Dim apellido As String = TBApellido.Text
        Dim fechaNacimiento As String = DTPFechaNacimiento.Value.ToShortDateString()
        Dim saldo As Decimal = Convert.ToDecimal(TBSaldo.Text)
        Dim sexo As String = If(RBHombre.Checked, "Hombre", "Mujer")
        Dim foto As Image = PictureBox1.Image
        Dim rutaFoto As String = LFoto.Text

        ' Agregar datos al DataGridView
        Dim index As Integer = DataGridView1.Rows.Add(apellido, nombre, fechaNacimiento, sexo, Nothing, saldo, foto, rutaFoto)

        ' Cambiar el fondo de la fila si el saldo es menor a $50
        If saldo < 50 Then
            DataGridView1.Rows(index).DefaultCellStyle.BackColor = Color.Red
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Manejo de la eliminación de registros al hacer clic en el botón "Eliminar"
        If e.ColumnIndex = DataGridView1.Columns("Eliminar").Index Then
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub DTPFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaNacimiento.ValueChanged
        ' Maneja cambios en la fecha de nacimiento si es necesario
    End Sub
End Class
