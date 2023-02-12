Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports System.Collections.Generic


Public Enum EXIFProperty
    Subject = 40095
    Title = 40091
    Comments = 40092
    Author = 40093
    Keywords = 40094
    Latitude = 2
    Longitude = 4
End Enum
Public Class Form25
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


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim selectimg As String
    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable

        Next
        PictureBox1.AllowDrop = True
    End Sub
    Public Function ReadEXIFMetadata(ByVal filepath As String) As ImageMetadata
        Dim fs As New FileStream(filepath, FileMode.Open, FileAccess.Read)
        Dim image__1 As Image = Image.FromStream(fs)
        Dim imagePropertyItems As PropertyItem() = image__1.PropertyItems
        Dim imageMetadata As New ImageMetadata()
        For Each pi As PropertyItem In imagePropertyItems
            Select Case CType(pi.Id, EXIFProperty)
                Case EXIFProperty.Title
                    imageMetadata.Title = Encoding.Unicode.GetString(pi.Value)
                    'imageMetadata.Title = Encoding.UTF32.GetString(pi.Value)
                    Exit Select
                Case EXIFProperty.Author
                    imageMetadata.Author = Encoding.Unicode.GetString(pi.Value)
                    'imageMetadata.Author = Encoding.UTF8.GetString(pi.Value)
                    Exit Select
                Case EXIFProperty.Keywords
                    imageMetadata.Keywords = Encoding.Unicode.GetString(pi.Value)
                    'imageMetadata.Keywords = Encoding.UTF8.GetString(pi.Value)
                    Exit Select
                Case EXIFProperty.Keywords
                    imageMetadata.Keywords = Encoding.Unicode.GetString(pi.Value)
                    'imageMetadata.Keywords = Encoding.UTF8.GetString(pi.Value)
                    Exit Select
                Case EXIFProperty.Keywords
                    imageMetadata.Keywords = Encoding.Unicode.GetString(pi.Value)
                    'imageMetadata.Keywords = Encoding.UTF8.GetString(pi.Value)
                    Exit Select
                Case EXIFProperty.Comments
                    imageMetadata.Comments = Encoding.Unicode.GetString(pi.Value)
                    'imageMetadata.Comments = Encoding.UTF8.GetString(pi.Value)
                    Exit Select
                Case Else
                    Exit Select
            End Select
        Next
        fs.Close()
        Return imageMetadata
    End Function
    Public Class ImageMetadata
        Private _title As String = String.Empty
        Private _author As String = String.Empty
        Private _keywords As String = String.Empty
        Private _comments As String = String.Empty
        Public Sub New()
            Me._title = String.Empty
            Me._author = String.Empty
            Me._keywords = String.Empty
            Me._comments = String.Empty
        End Sub
        Public Sub New(ByVal title As String, ByVal author As String, ByVal keywords As String, ByVal comments As String)
            Me._title = title
            Me._author = author
            Me._keywords = keywords
            Me._comments = comments
        End Sub
        Public Property Title() As String
            Get
                Return Me._title
            End Get
            Set(ByVal value As String)
                Me._title = value
            End Set
        End Property
        Public Property Author() As String
            Get
                Return Me._author
            End Get
            Set(ByVal value As String)
                Me._author = value
            End Set
        End Property
        Public Property Keywords() As String
            Get
                Return Me._keywords
            End Get
            Set(ByVal value As String)
                Me._keywords = value
            End Set
        End Property
        Public Property Comments() As String
            Get
                Return Me._comments
            End Get
            Set(ByVal value As String)
                Me._comments = value
            End Set
        End Property
    End Class

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        OpenFileDialog1.Filter = "Image Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|All Files (*.*)|*.*"
        OpenFileDialog1.Title = "Choose your photo"
        OpenFileDialog1.FileName = ""

        Try
            With OpenFileDialog1
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    selectimg = .FileName
                    Dim filename As String = GetFileName(.FileName)
                    Label13.Text = filename
                    Dim fi As New System.IO.FileInfo(selectimg)
                    If fi.Extension.ToLower = ".gif" Or fi.Extension.ToLower = ".bmp" Or fi.Extension.ToLower = ".jpg" Or fi.Extension.ToLower = ".jpeg" Or fi.Extension.ToLower = ".png" Then
                        Dim ImageFileStream As New FileStream(selectimg, IO.FileMode.Open)
                        Dim bm As New Bitmap(ImageFileStream)
                        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                        PictureBox1.Image = bm
                        ImageFileStream.Close()
                        EditEXIF()
                        ReadEXIFMetadata(.FileName)

                    Else
                        PictureBox1.Image = PictureBox1.ErrorImage
                        Try
                            EditEXIF()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click

        Dim imgFile As FileStream = New FileStream(selectimg, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim fileBytes(imgFile.Length) As Byte
        imgFile.Read(fileBytes, 0, fileBytes.Length)
        imgFile.Close()
        Dim MS As MemoryStream = New MemoryStream(fileBytes)
        Dim TheImage As Image = Image.FromStream(MS)
        Dim AllProperties() As PropertyItem = TheImage.PropertyItems
        Dim PropItem As PropertyItem = AllProperties(0)
        Dim strNewValue() As Byte
        If (Me.CheckBox20.Checked = True) Then
            strNewValue = System.Text.ASCIIEncoding.Unicode.GetBytes(TextBox20.Text)
            PropItem.Id = 40091
            PropItem.Len = strNewValue.Length
            PropItem.Value = strNewValue
            PropItem.Type = 1
            TheImage.SetPropertyItem(PropItem)
            lblTitle.Text = TextBox20.Text
        End If
        If (Me.CheckBox21.Checked = True) Then
            strNewValue = System.Text.ASCIIEncoding.Unicode.GetBytes(TextBox19.Text)
            PropItem.Id = 40095
            PropItem.Len = strNewValue.Length
            PropItem.Value = strNewValue
            PropItem.Type = 1
            TheImage.SetPropertyItem(PropItem)
            lblSubject.Text = TextBox19.Text
        End If
        If (Me.CheckBox22.Checked = True) Then
            If Not DataGridView1.Rows(0).Cells(1).Value = "" Then
                strNewValue = System.Text.ASCIIEncoding.Unicode.GetBytes(TextBox15.Text)
                PropItem.Id = 40094
                PropItem.Len = strNewValue.Length
                PropItem.Value = strNewValue
                PropItem.Type = 1
                TheImage.SetPropertyItem(PropItem)
                Label29.Text = TextBox15.Text
            End If
        End If
        If (Me.CheckBox23.Checked = True) Then
            strNewValue = System.Text.ASCIIEncoding.Unicode.GetBytes(TextBox14.Text)
            PropItem.Id = 40092
            PropItem.Len = strNewValue.Length
            PropItem.Value = strNewValue
            PropItem.Type = 1
            TheImage.SetPropertyItem(PropItem)
            Label17.Text = TextBox14.Text
        End If
        If (Me.CheckBox24.Checked = True) Then
            strNewValue = System.Text.ASCIIEncoding.Unicode.GetBytes(TextBox13.Text)
            PropItem.Id = 40093
            PropItem.Len = strNewValue.Length
            PropItem.Value = strNewValue
            PropItem.Type = 1
            TheImage.SetPropertyItem(PropItem)
            Label21.Text = TextBox13.Text
        End If
        If (Me.CheckBox25.Checked = True) Then
            Dim northorSouth As String = "N"
            If (TextBox12.Text < 0) Then
                northorSouth = "S"
            End If
            PropItem.Id = 1
            PropItem.Len = 2
            Dim vByte(24) As Byte
            vByte(0) = Asc(northorSouth)
            vByte(1) = 0
            PropItem.Value = vByte
            PropItem.Type = 2
            TheImage.SetPropertyItem(PropItem)

            Dim eastorWest As String = "E"
            If (TextBox22.Text < 0) Then
                eastorWest = "W"
            End If
            PropItem.Id = 3
            PropItem.Len = 2
            vByte(0) = Asc(eastorWest)
            vByte(1) = 0
            PropItem.Value = vByte
            PropItem.Type = 2
            TheImage.SetPropertyItem(PropItem)

            PropItem.Id = 0
            PropItem.Len = 4
            vByte(0) = 2
            vByte(1) = 2
            vByte(2) = 0
            vByte(3) = 0
            PropItem.Value = vByte
            PropItem.Type = 1
            TheImage.SetPropertyItem(PropItem)

            strNewValue = System.Text.ASCIIEncoding.Unicode.GetBytes(TextBox12.Text)
            PropItem.Id = 2
            PropItem.Len = 24
            PropItem.Value = doubleCoordinateToRationalByteArray(TextBox12.Text)
            PropItem.Type = 5
            TheImage.SetPropertyItem(PropItem)

            Label27.Text = TextBox12.Text
            strNewValue = System.Text.ASCIIEncoding.Unicode.GetBytes(TextBox22.Text)
            PropItem.Id = 4
            PropItem.Len = 24
            PropItem.Value = doubleCoordinateToRationalByteArray(TextBox22.Text)
            PropItem.Type = 5
            TheImage.SetPropertyItem(PropItem)
            Label28.Text = TextBox22.Text
        End If

            TheImage.Save(selectimg)
        MS.Close()
        TheImage.Dispose()
    End Sub

    Private Shared Function intToByteArray(ByVal int As Int32) As Byte()
        ' a necessary wrapper because of the cast to Int32
        Return BitConverter.GetBytes(int)
    End Function
    Private Shared Function strToByteArray(ByVal str As String) As Byte()
        ' a necessary wrapper because of the cast to Int32
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function
    Private Shared Function doubleCoordinateToRationalByteArray(ByVal doubleVal As Double) As Byte()
        Dim temp As Double

        temp = Math.Abs(doubleVal)
        Dim degrees = Math.Truncate(temp)

        temp = (temp - degrees) * 60
        Dim minutes = Math.Truncate(temp)

        temp = (temp - minutes) * 60
        Dim seconds = Math.Truncate(temp)

        Dim result(24) As Byte
        Array.Copy(intToByteArray(degrees), 0, result, 0, 4)
        Array.Copy(intToByteArray(1), 0, result, 4, 4)
        Array.Copy(intToByteArray(minutes), 0, result, 8, 4)
        Array.Copy(intToByteArray(1), 0, result, 12, 4)
        Array.Copy(intToByteArray(seconds), 0, result, 16, 4)
        Array.Copy(intToByteArray(1), 0, result, 20, 4)
        Return result
    End Function
    Private Sub EditEXIF()
        DataGridView1.Rows.Clear()
        Dim imgFile As FileStream = New FileStream(selectimg, FileMode.Open, FileAccess.Read)
        Dim TheImage As Image = Image.FromStream(imgFile)
        Dim AllProperties As PropertyItem() = TheImage.PropertyItems
        Dim Propertyitems As New List(Of Integer)
        For i As Integer = 0 To AllProperties.Length - 1
            Propertyitems.Add(AllProperties(i).Id)
        Next
        Dim PropItem As PropertyItem = AllProperties(0)


        For Each tstEnum As EXIFProperty In System.Enum.GetValues(GetType(EXIFProperty))

            DataGridView1.Rows.Add()
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = tstEnum.ToString
            If Propertyitems.Contains(CInt(tstEnum)) Then
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = System.Text.Encoding.Unicode.GetString(TheImage.GetPropertyItem(CInt(tstEnum)).Value).ToString
            End If
        Next

        lblSubject.Text = DataGridView1.Rows(6).Cells(1).Value
        Label29.Text = DataGridView1.Rows(5).Cells(1).Value
        Label21.Text = DataGridView1.Rows(4).Cells(1).Value
        Label27.Text = DataGridView1.Rows(0).Cells(1).Value
        Label17.Text = DataGridView1.Rows(3).Cells(1).Value
        lblTitle.Text = DataGridView1.Rows(2).Cells(1).Value
        Label28.Text = DataGridView1.Rows(1).Cells(1).Value
        imgFile.Close()
        TheImage.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Form26.Show()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Me.CheckBox25.Checked = True
    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        Dim droppedfiles As String() = e.Data.GetData(DataFormats.FileDrop)
        ReadEXIFMetadata(e.Data.GetDataPresent(DataFormats.FileDrop))
        For Each file In droppedfiles
            'LOAD AN IMGE I
            PictureBox1.Image = Image.FromFile(file)
            Dim filename As String = GetFileName(file)
            Label13.Text = filename
            EditEXIF()
            ReadEXIFMetadata(file)
        Next
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged

    End Sub

    Public Function GetFileName(path As String)
        Return System.IO.Path.GetFileNameWithoutExtension(path)
    End Function
End Class