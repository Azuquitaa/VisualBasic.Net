Public Class FormMenu
    Private Sub TareasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TareasToolStripMenuItem.Click
        FormTareas.Show()
    End Sub

    Private Sub TemporizadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemporizadorToolStripMenuItem.Click
        FormTemporizador.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        FormCalculadora.Show()
    End Sub
End Class
