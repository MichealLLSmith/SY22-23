﻿Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Integer.TryParse(TextBox1.Text, Sea)
        Me.Close()
    End Sub
End Class