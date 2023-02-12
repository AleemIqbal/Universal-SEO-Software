Imports System
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Public Class Form22
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
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

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        ListBox1.Items.Clear()
        Me.totalcom.Text = "0"
        Me.totalorg.Text = "0"
        Me.totalus.Text = "0"
        Me.totalco.Text = "0"
        Me.totalnet.Text = "0"
        Me.totalother.Text = "0"
        Me.TD.Text = "0"
        Me.totalgov.Text = "0"
        Me.totaledu.Text = "0"
        Me.totalinfo.Text = "0"
        Me.totalme.Text = "0"
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fl As String
            fl = ofd.FileName
            Dim s As String
            Dim sr As New StreamReader(fl)
            While sr.Peek <> -1
                s = sr.ReadLine.ToString
                Me.ListBox1.Items.Add(s)
            End While
            sr.Close()
            Me.TD.Text = Conversions.ToString(Me.ListBox1.Items.Count)
        End If
    End Sub

    Private Sub Work() Handles FlatButton2.Click
        Dim t_com = 0
        Dim t_net = 0
        Dim t_me = 0
        Dim t_info = 0
        Dim t_co = 0
        Dim t_us = 0
        Dim t_edu = 0
        Dim t_gov = 0
        Dim t_org = 0
        Dim t_all = 0
        Dim t_other = 0
        Dim path As String = String.Format("{0}\Sorted\", Environment.CurrentDirectory)
        Dim file_com As String = path & "\.com Domains.txt"
        Dim file_us As String = path & "\.us Domains.txt"
        Dim file_net As String = path & "\.net Domains.txt"
        Dim file_me As String = path & "\.me Domains.txt"
        Dim file_info As String = path & "\.info Domains.txt"
        Dim file_co As String = path & "\.co Domains.txt"
        Dim file_edu As String = path & "\.edu Domains.txt"
        Dim file_gov As String = path & "\.gov Domains.txt"
        Dim file_org As String = path & "\.org Domains.txt"
        Dim file_all As String = path & "\All Domains.txt"
        Dim file_other As String = path & "\Other Domains.txt"
        Dim _com As New StringBuilder()
        Dim _net As New StringBuilder()
        Dim _me As New StringBuilder()
        Dim _info As New StringBuilder()
        Dim _co As New StringBuilder()
        Dim _us As New StringBuilder()
        Dim _edu As New StringBuilder()
        Dim _gov As New StringBuilder()
        Dim _org As New StringBuilder()
        Dim _all As New StringBuilder()
        Dim _other As New StringBuilder()
        For Each item In ListBox1.Items
            If item.ToString.Contains(".com") Then
                t_com += 1
                t_all += 1
                _com.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".net") Then
                t_net += 1
                t_all += 1
                _net.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".me") Then
                t_me += 1
                t_all += 1
                _me.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".info") Then
                t_info += 1
                t_all += 1
                _info.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".co") Then
                t_co += 1
                t_all += 1
                _co.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".edu") Then
                t_edu += 1
                t_all += 1
                _edu.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".gov") Then
                t_gov += 1
                t_all += 1
                _gov.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".us") Then
                t_us += 1
                t_all += 1
                _us.AppendLine(item)
                _all.AppendLine(item)
            ElseIf item.ToString.Contains(".org") Then
                t_org += 1
                t_all += 1
                _org.AppendLine(item)
                _all.AppendLine(item)
            Else
                t_other += 1
                _other.AppendLine(item)
            End If
        Next
        System.IO.File.WriteAllText(file_com, _com.ToString())
        System.IO.File.WriteAllText(file_net, _net.ToString())
        System.IO.File.WriteAllText(file_me, _me.ToString())
        System.IO.File.WriteAllText(file_info, _info.ToString())
        System.IO.File.WriteAllText(file_co, _co.ToString())
        System.IO.File.WriteAllText(file_us, _us.ToString())
        System.IO.File.WriteAllText(file_edu, _edu.ToString())
        System.IO.File.WriteAllText(file_gov, _gov.ToString())
        System.IO.File.WriteAllText(file_org, _org.ToString())
        System.IO.File.WriteAllText(file_all, _all.ToString())
        System.IO.File.WriteAllText(file_other, _other.ToString())
        Me.totalcom.Text = t_com
        Me.totalorg.Text = t_org
        Me.totaledu.Text = t_edu
        Me.totalus.Text = t_us
        Me.totalco.Text = t_co
        Me.totalnet.Text = t_net
        Me.totalgov.Text = t_gov
        Me.totalother.Text = t_other
        Me.totalme.Text = t_me
        Me.totalinfo.Text = t_info
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Dim path As String = String.Format("{0}\Sorted\", Environment.CurrentDirectory)
        Dim FILE_NAME As String = path
        System.Diagnostics.Process.Start(FILE_NAME)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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