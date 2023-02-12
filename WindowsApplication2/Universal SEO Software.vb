
Imports MaterialSkin

Public Class Form1
    Dim proc As New System.Diagnostics.Process()


    Private Sub FlatButton4_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub


    Private Sub FlatButton7_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Form5.Show()
    End Sub


    Private Sub FlatButton8_Click(sender As Object, e As EventArgs)
        Form14.Show()
    End Sub


    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub FlatButton20_Click(sender As Object, e As EventArgs)
        Form12.Show()
    End Sub

    Private Sub FlatButton17_Click(sender As Object, e As EventArgs)
        Form17.Show()
    End Sub

    Private Sub FlatButton15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub FlatButton16_Click(sender As Object, e As EventArgs)
        Form22.Show()
    End Sub


    Private Sub FlatButton7_Click_1(sender As Object, e As EventArgs) Handles FlatButton7.Click
        Form9.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        System.Diagnostics.Process.Start("https://www.facebook.com/groups/seomastersacademy/")
    End Sub



    Private Sub FlatButton3_Click_1(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Form16.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("https://skillsacademy.pk/")
    End Sub

    Private Sub FlatButton8_Click_1(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Form14.Show()
    End Sub

    Private Sub FlatButton9_Click_1(sender As Object, e As EventArgs) Handles FlatButton9.Click
        Form13.Show()
    End Sub

    Private Sub FlatButton11_Click_1(sender As Object, e As EventArgs) Handles FlatButton11.Click
        Form12.Show()
    End Sub

    Private Sub FlatButton12_Click_1(sender As Object, e As EventArgs) Handles FlatButton12.Click
        Form17.Show()
    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton17_Click_1(sender As Object, e As EventArgs)
        proc = Process.Start(".\data\RC\RC.exe", "")
    End Sub

    Private Sub FlatButton16_Click_1(sender As Object, e As EventArgs)
        proc = Process.Start(".\data\HCC\HCC.exe", "")
    End Sub

    Private Sub FlatButton14_Click_1(sender As Object, e As EventArgs) Handles FlatButton14.Click
        Form22.Show()
    End Sub

    Private Sub FlatButton13_Click_1(sender As Object, e As EventArgs) Handles FlatButton13.Click
        Form2.Show()
    End Sub

    Private Sub FlatButton18_Click(sender As Object, e As EventArgs) Handles FlatButton18.Click
        Form24.Show()
    End Sub

    Private Sub FlatButton19_Click(sender As Object, e As EventArgs) Handles FlatButton19.Click
        Form25.Show()
    End Sub


    Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
        proc = Process.Start(".\SupaGrowth\Launcher.exe", "")
    End Sub

    Private Sub FlatLabel2_Click(sender As Object, e As EventArgs) Handles FlatLabel2.Click

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click_2(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Form10.Show()
    End Sub

    Private Sub FlatButton23_Click(sender As Object, e As EventArgs)
        Form29.Show()
    End Sub

    Private Sub FlatButton21_Click(sender As Object, e As EventArgs) Handles FlatButton21.Click
        System.Diagnostics.Process.Start("https://skillsacademy.pk/tools/")
    End Sub

    Private Sub FlatButton2_Click_1(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Form6.Show()
    End Sub

    Private Sub FlatButton4_Click_1(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Form11.Show()
    End Sub
End Class
