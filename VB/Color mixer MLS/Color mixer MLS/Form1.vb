Public Class Form1
    Dim Red As Integer
    Dim blue As Integer
    Dim Green As Integer
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub VeiwButton_Click(sender As Object, e As EventArgs) Handles VeiwButton.Click
        Integer.TryParse(RedTextBox.Text, Red)
        Integer.TryParse(BlueTextBox.Text, blue)
        Integer.TryParse(GreenTextBox.Text, Green)

        ColorLabel.BackColor = Color.FromArgb(Red, blue, Green)
    End Sub
End Class
