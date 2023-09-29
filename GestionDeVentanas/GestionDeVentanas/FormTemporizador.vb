Public Class FormTemporizador

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        'Dim numero = numContador.

        ' Establecer el tiempo inicial en segundos (por ejemplo, 60 segundos)
        If txtNumero.Text = "" Or txtNumero.Text = " " Then
            MessageBox.Show("Ingrese un numero!", "Error")
        Else
            Dim tiempoInicial As Integer = Integer.Parse(txtNumero.Text)
            ' Mostrar el tiempo inicial en el cuadro de texto
            txtContador.Text = tiempoInicial.ToString()

            ' iniciar el temporizador
            timerContador.Enabled = True
            timerContador.Start()
        End If


    End Sub

    Private Sub timerContador_Tick(sender As Object, e As EventArgs) Handles timerContador.Tick
        'obtener el tiempo restante del cuadro de texto y restar 1 segundo
        Dim tiempoRestante As Integer = Integer.Parse(txtContador.Text) - 1

        'mostrar el tiempo que se acaba de restar
        txtContador.Text = tiempoRestante.ToString()

        'si a llegado a cero muestra un mensaje
        If tiempoRestante = 0 Then
            timerContador.Stop()

            MessageBox.Show("Se terminó el tiempo!", "Fin del Contador")
        End If
    End Sub



    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub
End Class