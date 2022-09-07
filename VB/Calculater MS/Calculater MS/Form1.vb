Public Class Form1
    Dim Num1 As Decimal
    Dim Num2 As Decimal
    Dim oper As String
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click, TwoButton.Click, ThreeButton.Click, SixButton.Click, SevenButton.Click, OneButton.Click, NineButton.Click, MyBase.Click, FourButton.Click, FiveButton.Click, EightButton.Click
        DisplayTextBox.Text = DisplayTextBox.Text + sender.text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "+"
        DisplayTextBox.Clear()
    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num2)
        If oper = "+" Then
            DisplayTextBox.Text = Num1 + Num2
        End If
        If oper = "-" Then
            DisplayTextBox.Text = Num1 - Num2
        End If
        If oper = "*" Then
            DisplayTextBox.Text = Num1 * Num2
        End If
        If oper = "/" Then
            DisplayTextBox.Text = Num1 / Num2
        End If
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "-"
        DisplayTextBox.Clear()
    End Sub

    Private Sub MultiButton_Click(sender As Object, e As EventArgs) Handles MultiButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "*"
        DisplayTextBox.Clear()
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        oper = "/"
        DisplayTextBox.Clear()
    End Sub
End Class
