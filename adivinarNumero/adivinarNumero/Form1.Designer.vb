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
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lbMayor = New System.Windows.Forms.Label()
        Me.lbMenor = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lbRandom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(103, 51)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(242, 29)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Coloque un número"
        Me.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(183, 156)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(66, 75)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbMayor
        '
        Me.lbMayor.AutoSize = True
        Me.lbMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMayor.Location = New System.Drawing.Point(210, 111)
        Me.lbMayor.Name = "lbMayor"
        Me.lbMayor.Size = New System.Drawing.Size(0, 32)
        Me.lbMayor.TabIndex = 2
        '
        'lbMenor
        '
        Me.lbMenor.AutoSize = True
        Me.lbMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMenor.Location = New System.Drawing.Point(210, 240)
        Me.lbMenor.Name = "lbMenor"
        Me.lbMenor.Size = New System.Drawing.Size(0, 32)
        Me.lbMenor.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(146, 346)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(145, 57)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lbRandom
        '
        Me.lbRandom.AutoSize = True
        Me.lbRandom.Location = New System.Drawing.Point(352, 363)
        Me.lbRandom.Name = "lbRandom"
        Me.lbRandom.Size = New System.Drawing.Size(23, 16)
        Me.lbRandom.TabIndex = 5
        Me.lbRandom.Text = "----"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 450)
        Me.Controls.Add(Me.lbRandom)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbMenor)
        Me.Controls.Add(Me.lbMayor)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lbTitulo)
        Me.Name = "Form1"
        Me.Text = "Adivina el numero secreto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitulo As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lbMayor As Label
    Friend WithEvents lbMenor As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lbRandom As Label
End Class
