Public Class Form1

    Private Sub TimerHoraActual_Tick(sender As Object, e As EventArgs) Handles TimerHoraActual.Tick

        lbActual.Text = DateTime.Now.ToString("HH:mm:ss")


    End Sub
End Class
