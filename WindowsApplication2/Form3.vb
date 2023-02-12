Imports System
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Public Class Form3
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim MyName As String
    Dim Topic As String
    Dim RPage As String
    Dim WebsiteL As String
    Dim RName As String
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
    Private Sub Panel2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub


    Private ProxyList As Queue(Of Form3.Proxy)
    Public Property ip As String
    Public Property port As String
    Private Structure Proxy
        Public email As String

        Public pass As String
    End Structure
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs)
        Dim path As String = String.Format("{0}\Sorted\", Environment.CurrentDirectory)
        Dim FILE_NAME As String = path
        System.Diagnostics.Process.Start(FILE_NAME)
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) 
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlatButton2_Click_1(sender As Object, e As EventArgs) Handles FlatButton2.Click
        TextBox1.Text = "Hey" + RName + ",
I was doing some research on " + Topic + " and noticed that you have this killer resource page on your site. Awesome job!
" + RPage + "
Since you’re clearly an authority on the subject, I thought you’d be interested in checking out my article on " + Topic + ". It’s super in-depth and I think it would make an awesome addition to your resource page.
Here’s the link if you’d like to check it out:
" + WebsiteL + "
Cheers,
" + MyName + ""
    End Sub

    Private Sub FlatTextBox1_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox1.TextChanged
        MyName = FlatTextBox1.Text
    End Sub

    Private Sub FlatTextBox2_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox2.TextChanged
        RName = FlatTextBox2.Text
    End Sub

    Private Sub FlatTextBox3_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox3.TextChanged
        Topic = FlatTextBox3.Text
    End Sub

    Private Sub FlatTextBox4_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox4.TextChanged
        WebsiteL = FlatTextBox4.Text
    End Sub

    Private Sub FlatTextBox5_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox5.TextChanged
        RPage = FlatTextBox5.Text
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs)

    End Sub
End Class