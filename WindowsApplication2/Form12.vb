Imports System.IO
Public Class Form12
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim proc As New System.Diagnostics.Process()
    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub FlatButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub FlatButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton8_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs) Handles FlatButton12.Click
        System.Diagnostics.Process.Start("http://www.mediafire.com/file/ff2ksboga7r2prv/Backlinks+Directory.rar")
    End Sub

    Private Sub FlatButton25_Click(sender As Object, e As EventArgs) Handles FlatButton25.Click
        System.Diagnostics.Process.Start("http://www.mediafire.com/file/g7ujbthud7agd90/200++US+University+List.xlsx")
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/g24iqzpbfd3kxmt/300%20High%20PR%20Social%20Bookmarking%20Websites.xlsx")
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/mbyh46bdbi67c8q/Blog%20Directories.xlsx")
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/dm23vrkj9ur618a/Do%20Follow%20Websites%20for%20Image%20Sharing.txt")
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/7owdug4691okgad/Guest%20Posting%20Websites.xlsx")
    End Sub

    Private Sub FlatButton5_Click_1(sender As Object, e As EventArgs) Handles FlatButton5.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/gwdgdgn0gj73rt0/Infographic%20Submission%20Sites%20List.xlsx")
    End Sub

    Private Sub FlatButton6_Click_1(sender As Object, e As EventArgs) Handles FlatButton6.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/obrl6rf86lbyqsr/Local%20Listing%20Sites.xlsx")
    End Sub

    Private Sub FlatButton7_Click_1(sender As Object, e As EventArgs) Handles FlatButton7.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/q4aeundttdue4o8/My%20Personal%20Backlinks%20Sites.xlsx")
    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/lx6433e602a419c/Regular%20Directories.xlsx")
    End Sub

    Private Sub FlatButton13_Click(sender As Object, e As EventArgs) Handles FlatButton13.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/d3y1xfuzai9xy5d/Backlink%20Dorks.rar")
    End Sub

    Private Sub FlatButton9_Click_1(sender As Object, e As EventArgs) Handles FlatButton9.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/5rj2db8dcs8813a/Template%20Submission%20Sites.xlsx")
    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/nygbs9g07c6ayjj/Top%2030%20High%20Authority%20Websites.xlsx")
    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/e360edonpwk2r6e/User%20Review%20Sites.xlsx")
    End Sub

    Private Sub FlatButton15_Click(sender As Object, e As EventArgs) Handles FlatButton15.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/hpdz4uls0yygto9/Profile%20Backlinks.rar")
    End Sub

    Private Sub FlatButton14_Click(sender As Object, e As EventArgs) Handles FlatButton14.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/bacq9yv1kr8b51q/High%20PR%20Blog%20Submission%20Sites%20List%20%5BDirectories%5D.txt")
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs)

    End Sub
End Class