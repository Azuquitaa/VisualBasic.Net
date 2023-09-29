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
        Me.components = New System.ComponentModel.Container()
        Me.TimerHoraActual = New System.Windows.Forms.Timer(Me.components)
        Me.lbActual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TimerHoraActual
        '
        Me.TimerHoraActual.Enabled = True
        Me.TimerHoraActual.Interval = 1000
        '
        'lbActual
        '
        Me.lbActual.AutoSize = True
        Me.lbActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbActual.Location = New System.Drawing.Point(87, 167)
        Me.lbActual.Name = "lbActual"
        Me.lbActual.Size = New System.Drawing.Size(64, 69)
        Me.lbActual.TabIndex = 0
        Me.lbActual.Text = "0"
        Me.lbActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hora actual"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbActual)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerHoraActual As Timer
    Friend WithEvents lbActual As Label
    Friend WithEvents Label1 As Label
End Class
