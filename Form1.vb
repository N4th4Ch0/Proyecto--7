Public Class Form1


    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        Dim num1, num2 As Integer

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        If num1 > num2 Then

            lblResultado.Text = " EL NUMERO MAYOR ES:  " & num1
            lblResultado.ForeColor = Color.Green

        ElseIf num2 > num1 Then

            lblResultado.Text = " EL NUMERO MAYOR ES EL: " & num2
            lblResultado.ForeColor = Color.Red

        Else

            lblResultado.Text = " LOS NUMEROS SON IGUALES "
            lblResultado.ForeColor = Color.BlueViolet

        End If

    End Sub
End Class
