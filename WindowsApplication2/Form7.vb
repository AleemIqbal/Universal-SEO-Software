Imports System.IO
Public Class Form7
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim Uniname As String
    Dim RName As String
    Dim ScholarshipURL As String
    Dim MyName As String
    Dim CampName As String
    Dim Deadline As String
    Dim TScholarship As String
    Dim i = 0
    Dim nxt As Integer
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

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        TextBox4.Text = "Hi " + RName + "," + "
I’m contacting you because of a new scholarship opportunity for the " + Uniname + " students.

Our scholarship is called " + CampName + " Scholarship, and it’s designed to help the students who are currently studying in the areas of Marketing. We run this scholarship program every year.
Link to our Scholarship page:" + ScholarshipURL + "
Award: $1000
Deadline:" + Deadline + "

Here is the list of our requirements:
Name
Date of Birth
Phone Number, Mailing Address and any other mean of contact
College Name
Essay (Please include a 2000 word essay on the topic of ""How do you see the recent Tech startups changing global scenarios."".)

We would be honored if you’d be kind enough to add our award to your scholarship page " + TScholarship + ".
Of course, we’re here to answer any questions you may have.

Thank you, 
" + MyName + " "
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub sfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

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

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FlatTextBox1_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox1.TextChanged
        Uniname = FlatTextBox1.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub FlatTextBox2_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox2.TextChanged
        RName = FlatTextBox2.Text
    End Sub

    Private Sub FlatTextBox3_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox3.TextChanged
        ScholarshipURL = FlatTextBox3.Text
    End Sub

    Private Sub FlatTextBox4_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox4.TextChanged
        MyName = FlatTextBox4.Text
    End Sub

    Private Sub FlatTextBox5_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox5.TextChanged
        CampName = FlatTextBox5.Text
    End Sub

    Private Sub FlatTextBox6_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox6.TextChanged
        Deadline = FlatTextBox6.Text
    End Sub

    Private Sub FlatTextBox7_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox7.TextChanged
        TScholarship = FlatTextBox7.Text
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Clipboard.SetText(TextBox4.Text)
    End Sub

    Private Sub FlatButton3_Click_1(sender As Object, e As EventArgs) Handles FlatButton3.Click
        If (Me.ofd.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 <= num
                    Dim str As String = strArrays(0)
                    num1 = num1 + 1
                    Me.DataGridView1.Rows.Add(New Object() {str})
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub FlatButton4_Click_1(sender As Object, e As EventArgs) Handles FlatButton4.Click
        If (Me.ofd.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 <= num
                    Dim str As String = strArrays(0)
                    num1 = num1 + 1
                    Me.DataGridView2.Rows.Add(New Object() {str})
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub FlatButton5_Click_1(sender As Object, e As EventArgs) Handles FlatButton5.Click
        If (Me.ofd.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 <= num
                    Dim str As String = strArrays(0)
                    num1 = num1 + 1
                    Me.DataGridView3.Rows.Add(New Object() {str})
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub FlatButton6_Click_1(sender As Object, e As EventArgs) Handles FlatButton6.Click
        If (Me.ofd.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 <= num
                    Dim str As String = strArrays(0)
                    num1 = num1 + 1
                    Me.DataGridView4.Rows.Add(New Object() {str})
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton7_Click_1(sender As Object, e As EventArgs) Handles FlatButton7.Click
        If (DataGridView1.Rows(i).Cells(0).Value = "" Or DataGridView2.Rows(i).Cells(0).Value = "" Or DataGridView3.Rows(i).Cells(0).Value = "" Or DataGridView4.Rows(i).Cells(0).Value = "") Then
        Else
            Dim Uniname = DataGridView1.Rows(i).Cells(0).Value
            Dim ReciverName = DataGridView2.Rows(i).Cells(0).Value
            Dim Email = DataGridView3.Rows(i).Cells(0).Value
            Dim SchoLink = DataGridView4.Rows(i).Cells(0).Value

            i += 1

            FlatTextBox1.Text = Uniname
            FlatTextBox2.Text = ReciverName
            FlatTextBox8.Text = Email
            FlatTextBox7.Text = SchoLink
            TextBox4.Text = "Hi " + RName + "," + "
I’m contacting you because of a new scholarship opportunity for the " + Uniname + " students.

Our scholarship is called " + CampName + " Scholarship, and it’s designed to help the students who are currently studying your college. We run this scholarship program every year.
Link to our Scholarship page: " + ScholarshipURL + "
Award: $1000
Deadline:" + Deadline + "

Here is the list of our requirements:
Name
Date of Birth
Phone Number, Mailing Address and any other mean of contact
College Name
Essay (Please include a 2000 word essay on the topic of ""How do you see the recent Tech startups changing global scenarios."".)

We would be honored if you’d be kind enough to add our award to your scholarship page " + TScholarship + ".
Of course, we’re here to answer any questions you may have.

Thank you, 
" + MyName + " "
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            FlatTextBox2.Text = row.Cells(0).Value.ToString()

        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            FlatTextBox8.Text = row.Cells(0).Value.ToString()

        End If
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            FlatTextBox7.Text = row.Cells(0).Value.ToString()

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        With DataGridView1
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index

                FlatTextBox1.Text = .Rows(0).Cells(0).Value.ToString

            End If
        End With
    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Clipboard.SetText(FlatTextBox9.Text)
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        Clipboard.SetText(FlatTextBox8.Text)
    End Sub

    Private Sub DataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave

    End Sub
End Class