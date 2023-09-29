<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTareas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvTareas = New System.Windows.Forms.DataGridView()
        Me.Tareas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lstTareas = New System.Windows.Forms.ListBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LbTituloCalculadora = New System.Windows.Forms.Label()
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTareas
        '
        Me.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tareas})
        Me.dgvTareas.Location = New System.Drawing.Point(283, 120)
        Me.dgvTareas.Name = "dgvTareas"
        Me.dgvTareas.RowHeadersWidth = 51
        Me.dgvTareas.RowTemplate.Height = 24
        Me.dgvTareas.Size = New System.Drawing.Size(204, 115)
        Me.dgvTareas.TabIndex = 12
        '
        'Tareas
        '
        Me.Tareas.HeaderText = "Tareas"
        Me.Tareas.MinimumWidth = 6
        Me.Tareas.Name = "Tareas"
        Me.Tareas.Width = 125
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DimGray
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Red
        Me.btnEliminar.Location = New System.Drawing.Point(303, 337)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 84)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar una tarea"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lstTareas
        '
        Me.lstTareas.FormattingEnabled = True
        Me.lstTareas.ItemHeight = 16
        Me.lstTareas.Location = New System.Drawing.Point(27, 119)
        Me.lstTareas.Name = "lstTareas"
        Me.lstTareas.Size = New System.Drawing.Size(205, 116)
        Me.lstTareas.TabIndex = 10
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DimGray
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Location = New System.Drawing.Point(83, 337)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(131, 84)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar una tarea"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'LbTituloCalculadora
        '
        Me.LbTituloCalculadora.AutoSize = True
        Me.LbTituloCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloCalculadora.Location = New System.Drawing.Point(38, 34)
        Me.LbTituloCalculadora.Name = "LbTituloCalculadora"
        Me.LbTituloCalculadora.Size = New System.Drawing.Size(194, 29)
        Me.LbTituloCalculadora.TabIndex = 8
        Me.LbTituloCalculadora.Text = "Lista de Tareas"
        '
        'FormTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 450)
        Me.Controls.Add(Me.dgvTareas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lstTareas)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.LbTituloCalculadora)
        Me.Name = "FormTareas"
        Me.Text = "FormTareas"
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTareas As DataGridView
    Friend WithEvents Tareas As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lstTareas As ListBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents LbTituloCalculadora As Label
End Class
