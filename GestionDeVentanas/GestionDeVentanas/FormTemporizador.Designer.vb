<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTemporizador
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
        Me.components = New System.ComponentModel.Container()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.timerContador = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(284, 57)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 30)
        Me.txtNumero.TabIndex = 8
        '
        'txtContador
        '
        Me.txtContador.BackColor = System.Drawing.SystemColors.Control
        Me.txtContador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContador.Location = New System.Drawing.Point(157, 176)
        Me.txtContador.Multiline = True
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(133, 57)
        Me.txtContador.TabIndex = 7
        Me.txtContador.Text = "0"
        Me.txtContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnComenzar
        '
        Me.btnComenzar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnComenzar.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComenzar.Location = New System.Drawing.Point(145, 319)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(162, 65)
        Me.btnComenzar.TabIndex = 6
        Me.btnComenzar.Text = "COMENZAR"
        Me.btnComenzar.UseVisualStyleBackColor = False
        '
        'LbTitulo
        '
        Me.LbTitulo.AutoSize = True
        Me.LbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.Location = New System.Drawing.Point(59, 50)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(177, 29)
        Me.LbTitulo.TabIndex = 5
        Me.LbTitulo.Text = "Temporizador"
        '
        'timerContador
        '
        Me.timerContador.Interval = 1000
        '
        'FormTemporizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 450)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtContador)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.LbTitulo)
        Me.Name = "FormTemporizador"
        Me.Text = "FormTemporizador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtContador As TextBox
    Friend WithEvents btnComenzar As Button
    Friend WithEvents LbTitulo As Label
    Friend WithEvents timerContador As Timer
End Class
