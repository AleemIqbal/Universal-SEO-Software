Imports System.Text.RegularExpressions
Imports System.Text
Public Class Form4
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim MyName As String
    Dim RName As String
    Dim ArDescription As String
    Dim Article As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub FlatListBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub

    Private Sub FlatTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub FlatButton2_Click_1(sender As Object, e As EventArgs) Handles FlatButton2.Click
        TextBox1.Text = "Hey" + RName + ",
I’m sure you probably get these outreach emails daily, so I’ll keep it quick. My name is Ryan Stewart and I’m a digital marketing consultant.
I’d the chance to have a post featured in your weekly round up.
I write some pretty kick ass content that is a perfect fit for your audience.
If interested, please feel free to use them!
1. " + ArDescription + ": " + Article + "
Have a great day!
" + MyName + ""
    End Sub

    Private Sub FlatTextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles FlatTextBox1.TextChanged
        MyName = FlatTextBox1.Text
    End Sub

    Private Sub FlatTextBox2_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox2.TextChanged
        RName = FlatTextBox2.Text
    End Sub

    Private Sub FlatTextBox3_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox3.TextChanged
        ArDescription = FlatTextBox3.Text
    End Sub

    Private Sub FlatTextBox4_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox4.TextChanged
        Article = FlatTextBox4.Text
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub
End Class