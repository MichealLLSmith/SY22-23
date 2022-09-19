Public Class Form1
    Dim pounds As Decimal
    Dim dec As Decimal
    Dim Regular As Decimal
    Dim tot As Decimal
    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Decimal.TryParse(PoundsTextBox.Text, pounds)
        Decimal.TryParse(DecTextBox.Text, dec)
        Decimal.TryParse(RegularTextBox.Text, Regular)
        Decimal.TryParse(TotTextBox.Text, tot)
        pounds = dec + Regular
        PoundsTextBox.Text = pounds
        tot = pounds * 4.99
        TotTextBox.Text = tot.ToString("c2")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TotTextBox.Clear()
        PoundsTextBox.Clear()
        DecTextBox.Clear()
        ZipTextBox.Clear()
        StateTextBox.Clear()
        NameTextBox.Clear()
        AdressTextBox.Clear()
        CityTextBox.Clear()
        RegularTextBox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class