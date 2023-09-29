<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.timerContador = New System.Windows.Forms.Timer(Me.components)
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Temporizador"
        '
        'btnComenzar
        '
        Me.btnComenzar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnComenzar.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComenzar.Location = New System.Drawing.Point(98, 300)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(162, 65)
        Me.btnComenzar.TabIndex = 2
        Me.btnComenzar.Text = "COMENZAR"
        Me.btnComenzar.UseVisualStyleBackColor = False
        '
        'txtContador
        '
        Me.txtContador.BackColor = System.Drawing.SystemColors.Control
        Me.txtContador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContador.Location = New System.Drawing.Point(110, 157)
        Me.txtContador.Multiline = True
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(133, 57)
        Me.txtContador.TabIndex = 3
        Me.txtContador.Text = "0"
        Me.txtContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timerContador
        '
        Me.timerContador.Interval = 1000
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(237, 38)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 450)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtContador)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnComenzar As Button
    Friend WithEvents txtContador As TextBox
    Friend WithEvents timerContador As Timer
    Friend WithEvents txtNumero As TextBox
End Class
