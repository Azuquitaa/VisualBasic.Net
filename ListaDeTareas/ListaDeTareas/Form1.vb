Public Class Form1


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ' input box = lo que el usuario ingresa
        ' Null = no hay nada

        Dim nuevaTarea As String = InputBox("Ingrese la nueva tarea:", "Agregar Tarea")

        If Not String.IsNullOrEmpty(nuevaTarea) Then ' verifica si 

            lstTareas.Items.Add(nuevaTarea) ' agregamos la tarea a la lista de tareas

            dgvTareas.Rows.Add(nuevaTarea) ' agregamos la tarea al data grid view en la columna ya creada

        End If

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click


        ' si la fila seleccionada es menor a 0 quiere decir que esta fuera de indice el data 

        If dgvTareas.SelectedRows.Count > 0 Then
            dgvTareas.Rows.Remove(dgvTareas.SelectedRows(0))

        Else
            MessageBox.Show("Seleccione una tarea para eliminar.", "Eliminar Tarea")
        End If





        '<> distinto de..
        ' verifica si lo que selecciono el usuario en la lista de tareas es distinto de -1
        ' porque el primer elemento de la lista es siempre 0

        'If (lstTareas.SelectedIndex) <> -1 Then

        '    lstTareas.Items.Remove(lstTareas.SelectedIndex) ' se eleimina lo que se selecciona
        'Else
        '    MessageBox.Show("Seleccione una tarea para eliminar.", "Eliminar Tarea")
        'End If


    End Sub
End Class
