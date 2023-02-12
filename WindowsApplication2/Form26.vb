Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form26

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser2.Navigate("https://www.google.com/maps?q")
        WebBrowser2.ScriptErrorsSuppressed = True

    End Sub
    Private _reg As Regex = New Regex("@(-?[\d]*\.[\d]*),(-?[\d]*\.[\d]*)", RegexOptions.IgnoreCase)
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim url As String = WebBrowser2.Url.AbsoluteUri.ToString()

        ' The input string.
        Dim value As String = WebBrowser2.Url.ToString
        Dim myString As String = WebBrowser2.Url.ToString

        Dim regex1 = New Regex("@(-?\d+\.\d+)")
        Dim regex2 = New Regex(",(-?\d+\.\d+)")
        Dim match = regex1.Match(myString)
        Dim match2 = regex2.Match(myString)

        If match.Success Then
            Dim match3 As String = match.Value.Replace("@", "")
            Dim match4 As String = match2.Value.Replace(",", "")
            Label1.Text = match3
            Label2.Text = match4
            Form25.TextBox12.Text = Label1.Text
            Form25.TextBox22.Text = Label2.Text
            Close()

        End If
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted

    End Sub
End Class