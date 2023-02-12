Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Public Class Form10

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim path As String = TextBox2.Text
        Dim lines As New HashSet(Of String)()
        'Read to file
        Using sr As StreamReader = New StreamReader(path)
            Do While sr.Peek() >= 0
                lines.Add(sr.ReadLine())
            Loop
        End Using

        'Write to file
        Using sw As StreamWriter = New StreamWriter(path)
            For Each line As String In lines
                sw.WriteLine(line)
            Next
        End Using
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "Text (*.txt)|*.txt"
        If (dialog.ShowDialog = DialogResult.OK) Then
            Dim fileName As String = dialog.FileName
            Me.TextBox2.Text = fileName
            Dim items As String() = File.ReadAllLines(fileName)
        End If
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "txt"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        OpenFileDialog1.Multiselect = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class