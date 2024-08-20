Public Class Formulario1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LNombre.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim nombre, apellido As String

        nombre = TextBox1.Text
        apellido = TextBox2.Text

        TextBox3.Text = nombre + " " + apellido
    End Sub

    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TextBox3.Clear()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub

End Class
