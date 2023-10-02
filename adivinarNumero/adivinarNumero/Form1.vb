Public Class Form1
    Dim numeroAleatorio As New Random()

    ' Genera un número entero aleatorio entre 1 y 100
    Dim numAleatorio As Integer = numeroAleatorio.Next(1, 30)


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        Dim numeroUsuario As Integer = Integer.Parse(txtNumero.Text)
        Dim resultado As Integer = numeroUsuario - numAleatorio

        If (numeroUsuario = numAleatorio) Then
            lbTitulo.Text = "CORRECTO!!"

        ElseIf (numeroUsuario > numAleatorio) Then
            lbMayor.Text = ""
            lbMenor.Text = "-"

        ElseIf (numeroUsuario < numAleatorio) Then
            lbMenor.Text = ""
            lbMayor.Text = "+"

        End If

        lbRandom.Text = numAleatorio.ToString()
    End Sub
End Class
