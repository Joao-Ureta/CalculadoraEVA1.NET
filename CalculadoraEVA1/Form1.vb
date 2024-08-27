Public Class Form1

    Dim secuencia As Boolean = True
    Dim operacion As String
    Dim num1, num2, Resultado As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (secuencia = True) Then

            txtDisplay.Text = "1"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (secuencia = True) Then

            txtDisplay.Text = "2"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (secuencia = True) Then

            txtDisplay.Text = "3"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (secuencia = True) Then

            txtDisplay.Text = "4"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (secuencia = True) Then

            txtDisplay.Text = "5"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (secuencia = True) Then

            txtDisplay.Text = "6"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (secuencia = True) Then

            txtDisplay.Text = "7"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (secuencia = True) Then

            txtDisplay.Text = "8"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (secuencia = True) Then

            txtDisplay.Text = "9"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "9"
        End If
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        If (secuencia = True) Then

            txtDisplay.Text = "0"
            secuencia = False
        Else
            txtDisplay.Text = txtDisplay.Text + "0"
        End If
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click

        operacion = "+"
        num1 = txtDisplay.Text
        secuencia = True
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click

        operacion = "-"
        num1 = txtDisplay.Text
        secuencia = True
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click

        operacion = "*"
        num1 = txtDisplay.Text
        secuencia = True
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click

        operacion = "/"
        num1 = txtDisplay.Text
        secuencia = True
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click

        num2 = txtDisplay.Text

        Try
            Select Case operacion
                Case "+"
                    Resultado = CDbl(num1) + CDbl(num2)
                    txtDisplay.Text = Resultado.ToString
                    secuencia = True
                Case "-"
                    Resultado = CDbl(num1) - CDbl(num2)
                    txtDisplay.Text = Resultado.ToString
                    secuencia = True
                Case "*"
                    Resultado = CDbl(num1) * CDbl(num2)
                    txtDisplay.Text = Resultado.ToString
                    secuencia = True
                Case "/"
                    'Verificar que num2 no sea 0 para evitar división por cero
                    If num2 <> 0 Then
                        Resultado = CDbl(num1) / CDbl(num2)
                        txtDisplay.Text = Resultado.ToString
                        secuencia = True
                    Else
                        txtDisplay.Text = "ERROR - No divisible"
                        Exit Sub
                    End If
                Case Else
                    MessageBox.Show("Operación no válida.")
                    Exit Sub
            End Select

            'Mostrar el resultado en el TextBox
            txtDisplay.Text = num1 & operacion & num2 & " " & "=" & " " & Resultado.ToString()


        Catch ex As Exception
            MessageBox.Show("Error en la entrada. Por favor, ingrese una operación válida.")
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtDisplay.Clear()
        num1 = 0
        num2 = 0
        secuencia = True
        txtDisplay.Text = num1.ToString
    End Sub
End Class
