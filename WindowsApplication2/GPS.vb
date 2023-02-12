Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing

Public Class GPS

    Public Shared Function Geotag(ByVal original As Image, ByVal lat As Double, ByVal lng As Double) As Image

        Dim ExifTypeByte As Short = 1
        Dim ExifTypeAscii As Short = 2
        Dim ExifTypeRational As Short = 5
        Dim ExifTagGPSVersionID As Integer = 1
        Dim ExifTagGPSLatitudeRef As Integer = 2
        Dim ExifTagGPSLatitude As Integer = 3
        Dim ExifTagGPSLongitudeRef As Integer = 4
        Dim ExifTagGPSLongitude As Integer = 5
        Dim latHemisphere As String = "N"

        If lat < 0 Then
            latHemisphere = "S"
            lat = -lat
        End If

        Dim lngHemisphere As String = "E"

        If lng < 0 Then
            lngHemisphere = "W"c
            lng = -lng
        End If

        Dim ms As MemoryStream = New MemoryStream()
        original.Save(ms, ImageFormat.Jpeg)
        ms.Seek(0, SeekOrigin.Begin)
        Dim img As Image = Image.FromStream(ms)
        AddProperty(img, ExifTagGPSVersionID, ExifTypeByte, New Byte() {2, 3, 0, 0})
        AddProperty(img, ExifTagGPSLatitudeRef, ExifTypeAscii, New Byte() {CByte(latHemisphere), 0})
        AddProperty(img, ExifTagGPSLatitude, ExifTypeRational, ConvertToRationalTriplet(lat))
        AddProperty(img, ExifTagGPSLongitudeRef, ExifTypeAscii, New Byte() {CByte(lngHemisphere), 0})
        AddProperty(img, ExifTagGPSLongitude, ExifTypeRational, ConvertToRationalTriplet(lng))
        Return img
    End Function

    Private Shared Function ConvertToRationalTriplet(ByVal value As Double) As Byte()
        Dim degrees As Integer = CInt(Math.Floor(value))
        value = (value - degrees) * 60
        Dim minutes As Integer = CInt(Math.Floor(value))
        value = (value - minutes) * 60 * 100
        Dim seconds As Integer = CInt(Math.Round(value))
        Dim bytes As Byte() = New Byte(23) {}
        Dim i As Integer = 0
        Array.Copy(BitConverter.GetBytes(degrees), 0, bytes, i, 4)
        i += 4
        Array.Copy(BitConverter.GetBytes(1), 0, bytes, i, 4)
        i += 4
        Array.Copy(BitConverter.GetBytes(minutes), 0, bytes, i, 4)
        i += 4
        Array.Copy(BitConverter.GetBytes(1), 0, bytes, i, 4)
        i += 4
        Array.Copy(BitConverter.GetBytes(seconds), 0, bytes, i, 4)
        i += 4
        Array.Copy(BitConverter.GetBytes(100), 0, bytes, i, 4)
        Return bytes
    End Function

    Private Shared Sub AddProperty(ByVal img As Image, ByVal id As Integer, ByVal type As Short, ByVal value As Byte())
        Dim pi As PropertyItem = img.PropertyItems(0)
        pi.Id = id
        pi.Type = type
        pi.Len = value.Length
        pi.Value = value
        img.SetPropertyItem(pi)
    End Sub

End Class
