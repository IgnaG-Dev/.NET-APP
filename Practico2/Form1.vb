Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LNya.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked Then
            PictureBox1.BackgroundImage = My.Resources.varon  ' Cambia IconoVaron por el nombre de tu imagen de varón
        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked Then
            PictureBox1.BackgroundImage = My.Resources.mujer  ' Cambia IconoMujer por el nombre de tu imagen de mujer
        End If
    End Sub


    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TDni.Text = "" Or TNombre.Text = "" Or TApellido.Text = "" Then
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else

            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea insertar un nuevo Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Insercion")

            If ask = MsgBoxResult.Yes Then

                Dim nombre, apellido As String
                nombre = TNombre.Text
                apellido = TApellido.Text

                LModificar.Text = nombre + " " + apellido

                MsgBox("El Cliente: " & nombre & " " & apellido & " se insertó correctamente", MsgBoxStyle.Information, "Guardar")
            End If
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click

        Dim ask As MsgBoxResult
        ask = MsgBox("Está apunto de eliminar el Cliente: " & TNombre.Text & " " & TApellido.Text,
                     MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2, "Confirmar Eliminación")

        If ask = MsgBoxResult.Yes Then

            Dim nombre, apellido As String
            nombre = TNombre.Text
            apellido = TApellido.Text

            TDni.Clear()
            TNombre.Clear()
            TApellido.Clear()
            LModificar.Text = "Modificar"

            MsgBox("El Cliente: " & nombre & " " & apellido & " se eliminó correctamente",
                   MsgBoxStyle.Information, "Eliminar")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
