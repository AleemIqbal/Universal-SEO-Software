Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class Form14
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


    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs) Handles FlatButton12.Click
        System.Diagnostics.Process.Start("http://www.mediafire.com/file/eygk911ponezybd/Everything_about_SEO_and_Marketing_-_Ebooks_Collection.rar")
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub FlatButton13_Click(sender As Object, e As EventArgs) Handles FlatButton13.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/ejkh9scn5ncnbmw/1.Basic.rar")
    End Sub

    Private Sub FlatButton25_Click(sender As Object, e As EventArgs) Handles FlatButton25.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/b6yl38t6p9fft7y/2.On%20Page.rar")
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/6iuds8te2apxcf2/3.Off%20Page.rar")
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/1s1lmdh1a6b6q9h/4.Social%20SEO.rar")
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/obmdj2uuq35g173/5.Ecommerece%20SEO.rar")
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/hr4pob2qw3ikal3/6.Keyword%20Research.rar")
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/78c3l4w2rt9kecy/7.Local%20SEO.rar")
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/01zdtlo7ai67px6/8.Amazon%20Affiliate.rar")
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/cgw3ynz9f98f8e1/9.Social%20Media%20Marketing.rar")
    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/dhxkwdtcoz3n64d/10.Speed%20Optimization.rar")
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/9dy56ii55woi8wp/11.Youtube%20SEO.rar")
    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/kl9s61l24bs85lu/13.Email%20Marketing.rar")
    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/6it3agtvgm0e0t2/14.CPA.rar")
    End Sub

    Private Sub FlatButton15_Click(sender As Object, e As EventArgs) Handles FlatButton15.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/yycrt90b8py0fng/15.Adsense.rar")
    End Sub

    Private Sub FlatButton14_Click(sender As Object, e As EventArgs) Handles FlatButton14.Click
        System.Diagnostics.Process.Start("https://www.mediafire.com/file/xt6813qlkd9673b/12.Bonus%20Guides.rar")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub









End Class