Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlatButton13_Click(sender As Object, e As EventArgs) Handles FlatButton13.Click
        GetDomain("http://www.google.com/tset")

    End Sub
    Function GetDomain(url As String) As String
        Dim myUri As New Uri(url)
        Dim myHost As String = myUri.Host
        Return myHost.Substring(myHost.IndexOf(".") + 1)
    End Function
End Class