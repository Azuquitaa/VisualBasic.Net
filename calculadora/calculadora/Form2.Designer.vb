<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraEscolarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraCientificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Otro Formulario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.FuncionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraEscolarToolStripMenuItem, Me.CalculadoraCientificaToolStripMenuItem})
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.CalcularToolStripMenuItem.Text = "calcular"
        '
        'CalculadoraEscolarToolStripMenuItem
        '
        Me.CalculadoraEscolarToolStripMenuItem.Name = "CalculadoraEscolarToolStripMenuItem"
        Me.CalculadoraEscolarToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.CalculadoraEscolarToolStripMenuItem.Text = "calculadora escolar"
        '
        'CalculadoraCientificaToolStripMenuItem
        '
        Me.CalculadoraCientificaToolStripMenuItem.Name = "CalculadoraCientificaToolStripMenuItem"
        Me.CalculadoraCientificaToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.CalculadoraCientificaToolStripMenuItem.Text = "calculadora cientifica"
        '
        'FuncionesToolStripMenuItem
        '
        Me.FuncionesToolStripMenuItem.Name = "FuncionesToolStripMenuItem"
        Me.FuncionesToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.FuncionesToolStripMenuItem.Text = "funciones"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(87, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(662, 258)
        Me.DataGridView1.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraEscolarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraCientificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
End Class
