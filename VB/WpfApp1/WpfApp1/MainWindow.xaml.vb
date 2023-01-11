Imports System.IO

Class MainWindow
    Private Sub Bold_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontWeight = FontWeights.Bold
    End Sub

    Private Sub Bold_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontWeight = FontWeights.Normal
    End Sub

    Private Sub Italic_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontStyle = FontStyles.Italic
    End Sub

    Private Sub Italic_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontStyle = FontStyles.Normal
    End Sub

    Private Sub IncreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textBox1.FontSize < 18 Then
            textBox1.FontSize += 2
        End If
    End Sub
    Private Sub save_Click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.OpenFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            textBox1.Text = filename
        End If


    End Sub
    Private Sub Open_Click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.OpenFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            Showfile(filename)
        End If


    End Sub
    Sub showfile(FName As String)
        Dim filereader As System.IO.StreamReader
        filereader = New StreamReader(FName)

        Dim stringreader As String
        stringreader = filereader.ReadToEnd()
        textBox1.Text = stringreader
        filereader.Close()
    End Sub
    Sub savefile(FName As String)
    End Sub
    End Sub
    Private Sub DecreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textbox1.FontSize > 10 Then
            textbox1.FontSize -= 2
        End If
    End Sub
    Private Sub EXit_Click()
        Me.Close()
    End Sub


End Class
