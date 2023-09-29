<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LbTituloCalculadora = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstTareas = New System.Windows.Forms.ListBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvTareas = New System.Windows.Forms.DataGridView()
        Me.Tareas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTituloCalculadora
        '
        Me.LbTituloCalculadora.AutoSize = True
        Me.LbTituloCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloCalculadora.Location = New System.Drawing.Point(23, 31)
        Me.LbTituloCalculadora.Name = "LbTituloCalculadora"
        Me.LbTituloCalculadora.Size = New System.Drawing.Size(194, 29)
        Me.LbTituloCalculadora.TabIndex = 0
        Me.LbTituloCalculadora.Text = "Lista de Tareas"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Gray
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(68, 334)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(131, 84)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar una tarea"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lstTareas
        '
        Me.lstTareas.FormattingEnabled = True
        Me.lstTareas.ItemHeight = 16
        Me.lstTareas.Location = New System.Drawing.Point(12, 116)
        Me.lstTareas.Name = "lstTareas"
        Me.lstTareas.Size = New System.Drawing.Size(205, 116)
        Me.lstTareas.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DimGray
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Red
        Me.btnEliminar.Location = New System.Drawing.Point(288, 334)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 84)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar una tarea"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgvTareas
        '
        Me.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tareas})
        Me.dgvTareas.Location = New System.Drawing.Point(268, 117)
        Me.dgvTareas.Name = "dgvTareas"
        Me.dgvTareas.RowHeadersWidth = 51
        Me.dgvTareas.RowTemplate.Height = 24
        Me.dgvTareas.Size = New System.Drawing.Size(204, 115)
        Me.dgvTareas.TabIndex = 7
        '
        'Tareas
        '
        Me.Tareas.HeaderText = "Tareas"
        Me.Tareas.MinimumWidth = 6
        Me.Tareas.Name = "Tareas"
        Me.Tareas.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.dgvTareas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lstTareas)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.LbTituloCalculadora)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTituloCalculadora As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstTareas As ListBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvTareas As DataGridView
    Friend WithEvents Tareas As DataGridViewTextBoxColumn
End Class
