Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim JPY As Decimal
        Decimal.TryParse(JypBox.Text, JPY)
        Dim Yen As Decimal
        Yen = JPY * 136.69
        YenBox.Text = Yen.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Ero As Decimal
        Decimal.TryParse(JypBox.Text, Ero)
        Dim Euro As Decimal
        Euro = Ero * 1.0
        EuroBox.Text = Euro.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CD As Decimal
        Decimal.TryParse(JypBox.Text, CD)
        Dim CanD As Decimal
        CanD = CD * 1.29
        CanDBox.Text = CanD.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim TI As Decimal
        Decimal.TryParse(JypBox.Text, TI)
        Dim lira As Decimal
        lira = TI * 18.17
        liraBox.Text = lira.ToString("C2")
    End Sub
End Class
