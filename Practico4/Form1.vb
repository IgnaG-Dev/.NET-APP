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

    Private Sub BPares_Click(sender As Object, e As EventArgs) Handles BPares.Click
        ListBox1.Items.Clear()
        For i As Integer = Val(TextBox1.Text) To Val(TextBox2.Text)
            If i Mod 2 = 0 Then
                ListBox1.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub BImpares_Click(sender As Object, e As EventArgs) Handles BImpares.Click
        ListBox1.Items.Clear()
        For i As Integer = Val(TextBox1.Text) To Val(TextBox2.Text)
            If i Mod 2 <> 0 Then
                ListBox1.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub BPrimos_Click(sender As Object, e As EventArgs) Handles BPrimos.Click
        ListBox1.Items.Clear()
        For i As Integer = Val(TextBox1.Text) To Val(TextBox2.Text)
            If EsPrimo(i) Then
                ListBox1.Items.Add(i)
            End If
        Next
    End Sub

    Private Function EsPrimo(numero As Integer) As Boolean
        If numero <= 1 Then Return False
        For i As Integer = 2 To Math.Sqrt(numero)
            If numero Mod i = 0 Then Return False
        Next
        Return True
    End Function
End Class
