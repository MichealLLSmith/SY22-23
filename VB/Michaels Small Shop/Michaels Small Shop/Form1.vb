Public Class Form1
    Dim MFI As Decimal
    Dim VI As Decimal
    Dim SFI As Decimal
    Dim ToT As Decimal
    Dim Grand As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
        MFITextBox.Text = Meat
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.ShowDialog()
        VITextBox.Text = Food
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.ShowDialog()
        SFITextBox.Text = Sea
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim n As Integer
        Dim d As Decimal
        Dim s As Single
        Integer.TryParse(MFITextBox.Text, n)
        Decimal.TryParse(VITextBox.Text, d)
        Single.TryParse(SFITextBox.Text, s)
        MFITextBox.Text = n
        VITextBox.Text = d
        SFITextBox.Text = s
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Decimal.TryParse(SFITextBox.Text, SFI)
        Decimal.TryParse(MFITextBox.Text, MFI)
        Decimal.TryParse(VITextBox.Text, VI)
        Decimal.TryParse(ToTBox.Text, ToT)
        Decimal.TryParse(GrandBox.Text, Grand)
        ToT = MFI + VI + SFI
        ToTBox.Text = ToT
        Grand = ToT * 5
        GrandBox.Text = Grand.ToString("C2")
    End Sub
End Class
