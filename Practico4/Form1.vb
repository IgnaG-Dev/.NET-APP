Public Class Form1
    Private Sub BGenerarFuncion_Click(sender As Object, e As EventArgs) Handles BGenerarFuncion.Click
        ' Limpiar la lista antes de agregar nuevos elementos
        ListBox1.Items.Clear()

        ' Validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Por favor, ingrese valores en ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validar que los valores ingresados sean numéricos
        Dim desde As Integer
        Dim hasta As Integer

        If Not Integer.TryParse(TextBox1.Text, desde) Or Not Integer.TryParse(TextBox2.Text, hasta) Then
            MessageBox.Show("Por favor, ingrese solo valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validar que "desde" no sea mayor que "hasta"
        If desde > hasta Then
            MessageBox.Show("El valor 'Desde' no puede ser mayor que 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Generar los números en la lista
        For i As Integer = desde To hasta
            ListBox1.Items.Add(i.ToString())
        Next
    End Sub
End Class
