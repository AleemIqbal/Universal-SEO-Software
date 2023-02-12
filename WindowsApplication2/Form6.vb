Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Public Class Form6
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

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
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub FlatButton25_Click(sender As Object, e As EventArgs) Handles FlatButton25.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/kjup0x16bx1szwv/SEO_Template_7.0.xlsx/file")
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/31qxe1ovlmdafil/WEBRIS__Technical_SEO_Audit_.xlsx/file")
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/072www40azoxg6z/SEO-Audit_Checklist-2015R2.xls/file")
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/8ycmxl7r00kg7wl/WEBRIS__SEO_Content_Audit.xlsx/file")
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/null/%5BTemplate%5D-_SEO_Campaign.xlsx/file")
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/tsgun5l3lceexv6/Temp.zip/file")
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/0g6phl9hllaeqeg/5.7.1_Guest_Posting.xlsx/file")
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/hp7rbl3388s5grb/5.6_Blog_Commenting.xlsx/file")
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub


End Class