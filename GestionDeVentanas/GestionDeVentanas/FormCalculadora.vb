Public Class FormCalculadora



    '"Dim"  es la palabra reservada para crear una variable,
    ' la palabra reservada "As" sirve para decirle al lenguaje de qué valor será la variable que crees.

    ' String = tipo texto
    ' Int16, Int32, Int64, Integer = varian las posibilidaddes pero en todos los tipos se pueden colocar enteros
    ' Double = tipo de punto flotante  de presicion Doble
    ' Decimal = represetna un numero decimal
    ' Boolean = representa a los valores booleanos, True o False

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        ' el valor de la variable expresion va a ser lo que tenga el textboxResultado
        Dim numeroentexto As String = TextBoxResultado.Text

        Dim resultado As Object = New DataTable().Compute(numeroentexto, Nothing)

        TextBoxResultado.Text = resultado.ToString()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim button As Button = CType(sender, Button) ' Dar a la variable button el valor que tenga escrito el boton donde se hace click
        TextBoxResultado.Text += button.Text
        ' en la caja blanca se escribe la variable de tipo boton que tiene un numero y se pasa a texto

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += button.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim button As Button = CType(sender, Button)

        TextBoxResultado.Text += " " & button.Text & " "

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += " " & button.Text & " "
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += " " & button.Text & " "
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim button As Button = CType(sender, Button)
        TextBoxResultado.Text += " " & button.Text & " "
    End Sub


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBoxResultado.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class