Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Form13
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim MyName As String
    Dim Searchterm As String
    Dim UDate As String
    Dim Numbers As String
    Dim TLD As String
    Dim Dork As String
    Dim Input As String
    Dim ShowLabel As String
    Private Sub Form13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form13_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form13_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub
    Private Sub Panel13_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel13_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
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

    Private Sub FlatButton25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Blog Platforms")
        ComboBox1.Items.Add("Comment Backlinks")
        ComboBox1.Items.Add("Forum Backlinks")
        ComboBox1.Items.Add("Guest Posts")
        ComboBox1.Items.Add("Link Roundups")
        ComboBox1.Items.Add("Resource Pages")
        ComboBox1.Items.Add("Sponser/Donation Links")

        ComboBox2.Items.Add("Any Time")
        ComboBox2.Items.Add("Past Week")
        ComboBox2.Items.Add("Past Month")
        ComboBox2.Items.Add("Past Year")

        ComboBox3.Items.Add("10 Results")
        ComboBox3.Items.Add("20 Results")
        ComboBox3.Items.Add("30 Results")
        ComboBox3.Items.Add("50 Results")
        ComboBox3.Items.Add("100 Results")

        ComboBox4.Items.Add("Any TLD")
        ComboBox4.Items.Add(".com")
        ComboBox4.Items.Add(".org")
        ComboBox4.Items.Add(".net")
        ComboBox4.Items.Add(".edu")
        ComboBox4.Items.Add(".gov")

        ComboBox1.Text = "Blog Platforms"
    End Sub

    Private Sub WhileInside(sender As Object, e As EventArgs) Handles FlatTextBox1.TextChanged
        Input = FlatTextBox1.Text
    End Sub
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If ComboBox3.Text = "10 Results" Then
            Numbers = "10"
        End If
        If ComboBox3.Text = "20 Results" Then
            Numbers = "20"
        End If
        If ComboBox3.Text = "30 Results" Then
            Numbers = "30"
        End If
        If ComboBox3.Text = "50 Results" Then
            Numbers = "50"
        End If
        If ComboBox3.Text = "100 Results" Then
            Numbers = "100"
        End If
        If ComboBox4.Text = "Any TLD" Then
            TLD = ""
        End If
        If ComboBox4.Text = ".org" Then
            TLD = "site:.org"
        End If
        If ComboBox4.Text = ".com" Then
            TLD = "site:.com"
        End If
        If ComboBox4.Text = ".net" Then
            TLD = "site:.net"
        End If
        If ComboBox4.Text = ".edu" Then
            TLD = "site:.edu"
        End If
        If ComboBox4.Text = ".gov" Then
            TLD = "site:.gov"
        End If
        If ComboBox2.Text = "Any Time" Then
            UDate = ""
        End If
        If ComboBox2.Text = "Past Week" Then
            UDate = "w"
        End If
        If ComboBox2.Text = "Past Month" Then
            UDate = "m"
        End If
        If ComboBox2.Text = "Past Year" Then
            UDate = "y"
        End If
        Searchterm = FlatTextBox1.Text

        System.Diagnostics.Process.Start("http://www.google.com/search?q=" + Searchterm + " " + Dork + " " + " " + TLD + "&tbs=qdr:" + UDate + "&num=" + Numbers)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Blog Platforms" Then
            ComboBox5.Items.Clear()
            ComboBox5.Text = "BlogEngine.NET"
            ComboBox5.Items.Add("BlogEngine.NET")
            Searchterm = FlatTextBox1.Text
            Dork = " %22Powered by BlogEngine.NET%22 inurl:blog %22post a comment%22 -%22comments closed%22 -%22you must be logged in%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
            ComboBox5.Items.Add("Expression Engine 1")
            ComboBox5.Items.Add("Expression Engine 2")
            ComboBox5.Items.Add("Expression Engine 3")
            ComboBox5.Items.Add("Typepad")
            ComboBox5.Items.Add("Wordpress (no comments) 1")
            ComboBox5.Items.Add("Wordpress (no comments) 2")
        End If
        If ComboBox1.Text = "Comment Backlinks" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("CommentLuv Premium")
            ComboBox5.Text = "CommentLuv Premium"
            Dork = "CommentLuv Premium"
            Label4.Text = Input + " " + Dork
            ComboBox5.Items.Add("Do-Follow Comments")
            ComboBox5.Items.Add("Intense Debate")
            ComboBox5.Items.Add("Keyword Luv")
            ComboBox5.Items.Add("Livefyre")

        End If
        If ComboBox1.Text = "Forum Backlinks" Then
            ComboBox5.Items.Clear()
            ComboBox5.Text = "ip.board"
            Dork = "ip.board"
            Label4.Text = Input + " " + Dork
            ComboBox5.Items.Add("ip.board")
            ComboBox5.Items.Add("Fireboard")
            ComboBox5.Items.Add("phpbb")
            ComboBox5.Items.Add("phpbb3")
            ComboBox5.Items.Add("SMF")
            ComboBox5.Items.Add("Vbulletin")
        End If
        If ComboBox1.Text = "Guest Posts" Then
            ComboBox5.Items.Clear()
            ComboBox5.Text = "accepting guest posts"
            Dork = "accepting guest posts"
            Label4.Text = Input + " " + Dork
            ComboBox5.Items.Add("accepting guest posts")
            ComboBox5.Items.Add("become a contributor")
            ComboBox5.Items.Add("become a guest writer")
            ComboBox5.Items.Add("contribute to our site")
            ComboBox5.Items.Add("contributor guidelines")
            ComboBox5.Items.Add("guest bloggers wanted")
            ComboBox5.Items.Add("guest post courtesy of")
            ComboBox5.Items.Add("guest post guidelines")
            ComboBox5.Items.Add("guest post opportunities")
            ComboBox5.Items.Add("guest posts wanted")
            ComboBox5.Items.Add("I’ve been featured on")
            ComboBox5.Items.Add("my guest blogs")
            ComboBox5.Items.Add("my posts on other blogs")
            ComboBox5.Items.Add("sites I’ve written for")
            ComboBox5.Items.Add("submit article")
            ComboBox5.Items.Add("submit blog post")
            ComboBox5.Items.Add("submit guest post")
            ComboBox5.Items.Add("submit your content")
            ComboBox5.Items.Add("this is a guest post by")
            ComboBox5.Items.Add("This post was written by")
            ComboBox5.Items.Add("write for us")
            ComboBox5.Items.Add("writers wanted")
        End If
        If ComboBox1.Text = "Link Roundups" Then
            ComboBox5.Items.Clear()
            ComboBox5.Text = "best articles of the week"
            Dork = "best articles of the week"
            Label4.Text = Input + " " + Dork
            ComboBox5.Items.Add("best articles of the week")
            ComboBox5.Items.Add("best of")
            ComboBox5.Items.Add("best posts of the week")
            ComboBox5.Items.Add("daily link roundup")
            ComboBox5.Items.Add("friday link roundup")
            ComboBox5.Items.Add("link roundup")
            ComboBox5.Items.Add("monday link roundup")
            ComboBox5.Items.Add("roundup")
            ComboBox5.Items.Add("this week")
            ComboBox5.Items.Add("top posts this week")
            ComboBox5.Items.Add("weekly link roundup")
        End If
        If ComboBox1.Text = "Resource Pages" Then
            ComboBox5.Items.Clear()
            ComboBox5.Text = "intitle:resources"
            Dork = "intitle:resources"
            Label4.Text = Input + " " + Dork
            ComboBox5.Items.Add("intitle:resources")
            ComboBox5.Items.Add("inurl:resources")
            ComboBox5.Items.Add("links")
            ComboBox5.Items.Add("recommended sites")
            ComboBox5.Items.Add("resources")
            ComboBox5.Items.Add("resource page")
            ComboBox5.Items.Add("resource pages")
        End If
        If ComboBox1.Text = "Sponser/Donation Links" Then
            ComboBox5.Items.Clear()
            ComboBox5.Text = "contributors page"
            Dork = "contributors page"
            Label4.Text = Input + " " + Dork
            ComboBox5.Items.Add("contributors page")
            ComboBox5.Items.Add("donate to us")
            ComboBox5.Items.Add("sponsors page")
        End If
    End Sub


    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        'Comment'
        If ComboBox5.Text = "BlogEngine.NET" Then
            Dork = " %22Powered by BlogEngine.NET%22 inurl:blog %22post a comment%22 -%22comments closed%22 -%22you must be logged in%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Expression Engine 1" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by expressionengine%22 inurl:blog %22post a comment%22 -%22comments closed%22 -%22you must be logged in%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Expression Engine 2" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by expressionengine%22 %22post a comment%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Expression Engine 3" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by expressionengine%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Typepad" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by Typepad%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Wordpress (no comments) 1" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22no comments posted yet%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Wordpress (no comments) 2" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22why not be the first to have your say%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        'Dofollow Comment'
        If ComboBox5.Text = "CommentLuv Premium" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22This blog uses premium CommentLuv%22 -%22The version of CommentLuv on this site is no longer supported.%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Do-Follow Comments" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22Notify me of follow-up comments?%22+%22Submit the word you see below:%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Intense Debate" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22if you have a website, link to it here%22 %22post a new comment%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Keyword Luv" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22Enter YourName@YourKeywords%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Livefyre" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22get livefyre%22 %22comment help%22 -%22Comments have been disabled for this post%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        'Forum'
        If ComboBox5.Text = "ip.board" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by ip.board%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Fireboard" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by Fireboard%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "phpbb" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by phpbb%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "phpbb3" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by phpbb3%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "SMF" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by SMF%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Vbulletin" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22powered by vbulletin%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        'Guest Posts'
        If ComboBox5.Text = "accepting guest posts" Then
            Searchterm = FlatTextBox1.Text
            Dork = " %22accepting guest posts%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "become a contributor" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22become a contributor%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "become a guest writer" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22become a guest writer%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "contribute to our site" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22contribute to our site%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "contributor guidelines" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22contributor guidelines%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "guest bloggers wanted" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22guest bloggers wanted%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "guest post courtesy of" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22guest post courtesy of%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "guest post guidelines" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22guest post guidelines%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "guest post opportunities" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22guest post opportunities%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "guest posts wanted" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22guest posts wanted%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "I’ve been featured on" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22I’ve been featured on%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "my guest blogs" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22my guest blogs%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "my posts on other blogs" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22my posts on other blogs%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "sites I’ve written for" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22sites I’ve written for%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "submit article" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22submit article%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "submit blog post" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22submit blog post%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "submit guest post" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22submit guest post%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "submit your content" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22submit your content%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "this is a guest post by" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22this is a guest post by%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "This post was written by" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22This post was written by%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "write for us" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22write for us%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "writers wanted" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22writers wanted%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        'Roundups'
        If ComboBox5.Text = "best articles of the week" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22best articles of the week%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "BlogEngine.NET" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22best of%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "best posts of the week" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22best posts of the week%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "daily link roundup" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22daily link roundup%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "friday link roundup" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22friday link roundup%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "Blink roundup" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22Blink roundup%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "monday link roundup" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22monday link roundup%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "roundup" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22roundup%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "this week" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22this week%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "top posts this week" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22top posts this week%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "weekly link roundup" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22weekly link roundup%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        'Resource Pages'
        If ComboBox5.Text = "intitle:resources" Then
            Searchterm = FlatTextBox1.Text
            Dork = "intitle:resources"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "inurl:resources" Then
            Searchterm = FlatTextBox1.Text
            Dork = "inurl:resources"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "links" Then
            Searchterm = FlatTextBox1.Text
            Dork = "links"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If

        If ComboBox5.Text = "recommended sites" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22recommended sites%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "resources" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22resources%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "resource page" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22resource page%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "resource pages" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22resource pages%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        'Comment'
        If ComboBox5.Text = "contributors page" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22contributors page%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "donate to us" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22donate to us%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If
        If ComboBox5.Text = "sponsors page" Then
            Searchterm = FlatTextBox1.Text
            Dork = "%22sponsors page%22"
            ShowLabel = Input + " " + Dork
            ShowLabel = ShowLabel.Replace("%22", """")
            Label4.Text = ShowLabel
        End If

        'Gov'

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub FlatTextBox1_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox1.TextChanged
        ShowLabel = Input + " " + Dork
        ShowLabel = ShowLabel.Replace("%22", """")
        Label4.Text = ShowLabel
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class