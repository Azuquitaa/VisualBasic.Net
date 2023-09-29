Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim nombre = txtNombre.Text
        MessageBox.Show(nombre + " Hola Mundo!")

    End Sub
End Class
