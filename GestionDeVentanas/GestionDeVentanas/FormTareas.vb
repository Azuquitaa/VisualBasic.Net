Public Class FormTareas

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevaTarea As String = InputBox("Ingrese la nueva tarea:", "Agregar Tarea")

        If Not String.IsNullOrEmpty(nuevaTarea) Then
            lstTareas.Items.Add(nuevaTarea)
            dgvTareas.Rows.Add(nuevaTarea)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvTareas.SelectedRows.Count > 0 Then
            dgvTareas.Rows.Remove(dgvTareas.SelectedRows(0))

        Else
            MessageBox.Show("Seleccione una tarea para eliminar.", "Eliminar Tarea")
        End If

        'If lstTareas.SelectedIndex <> -1 Then
        '    lstTareas.Items.Remove(lstTareas.SelectedIndex)
        'Else
        '    MessageBox.Show("Seleccione una tarea para eliminar.", "Eliminar Tarea")
        'End If
    End Sub


    Private Sub LbTituloCalculadora_Click(sender As Object, e As EventArgs) Handles LbTituloCalculadora.Click

    End Sub
End Class