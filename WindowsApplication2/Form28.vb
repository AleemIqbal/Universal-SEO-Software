Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Namespace AddGPSTagsToEXIF
    Public Class Form28

        Private Sub Form28_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub


        Private Const GPSLatitudeRefQuery As String = "/app1/ifd/gps/subifd:{ulong=1}"

        Private Const GPSLatitudeQuery As String = "/app1/ifd/gps/subifd:{ulong=2}"

        Private Const GPSLongitudeRefQuery As String = "/app1/ifd/gps/subifd:{ulong=3}"

        Private Const GPSLongitudeQuery As String = "/app1/ifd/gps/subifd:{ulong=4}"

        Private Const GPSAltitudeRefQuery As String = "/app1/ifd/gps/subifd:{ulong=5}"

        Private Const GPSAltitudeQuery As String = "/app1/ifd/gps/subifd:{ulong=6}"

        Private Shared Sub Main(ByVal args As String())
            Dim originalPath As String = "D:\Temp\test.jpg"
            Dim outputPath As String = "D:\Temp\testModified.jpg"
            Dim createOptions As BitmapCreateOptions = BitmapCreateOptions.PreservePixelFormat Or BitmapCreateOptions.IgnoreColorProfile
            Dim paddingAmount As UInteger = 2048
            Using originalFile As Stream = File.Open(originalPath, FileMode.Open, FileAccess.Read)
                Dim original As BitmapDecoder = BitmapDecoder.Create(originalFile, createOptions, BitmapCacheOption.None)
                Dim output As JpegBitmapEncoder = New JpegBitmapEncoder()
                If original.Frames(0) IsNot Nothing AndAlso original.Frames(0).Metadata IsNot Nothing Then
                    Dim metadata As BitmapMetadata = TryCast(original.Frames(0).Metadata.Clone(), BitmapMetadata)
                    metadata.SetQuery("/app1/ifd/PaddingSchema:Padding", paddingAmount)
                    metadata.SetQuery("/app1/ifd/exif/PaddingSchema:Padding", paddingAmount)
                    metadata.SetQuery("/xmp/PaddingSchema:Padding", paddingAmount)
                    Dim latitude As Double = 30 + 15 / 60 + 22 / 3600
                    Dim longitude As Double = -(86 + 16 / 60 + 23 / 3600)
                    Dim altitude As Double = 44
                    Dim latitudeRational As GPSRational = New GPSRational(latitude)
                    Dim longitudeRational As GPSRational = New GPSRational(longitude)
                    metadata.SetQuery(GPSLatitudeQuery, latitudeRational.bytes)
                    metadata.SetQuery(GPSLongitudeQuery, longitudeRational.bytes)
                    If latitude > 0 Then metadata.SetQuery(GPSLatitudeRefQuery, "N") Else metadata.SetQuery(GPSLatitudeRefQuery, "S")
                    If longitude > 0 Then metadata.SetQuery(GPSLongitudeRefQuery, "E") Else metadata.SetQuery(GPSLongitudeRefQuery, "W")
                    Dim altitudeRational As Rational = New Rational(CInt(altitude), 1)
                    metadata.SetQuery(GPSAltitudeQuery, altitudeRational.bytes)
                    output.Frames.Add(BitmapFrame.Create(original.Frames(0), original.Frames(0).Thumbnail, metadata, original.Frames(0).ColorContexts))
                End If

                Using outputFile As Stream = File.Open(outputPath, FileMode.Create, FileAccess.ReadWrite)
                    output.Save(outputFile)
                End Using
            End Using

            Using savedFile As Stream = File.Open(outputPath, FileMode.Open, FileAccess.Read)
                Dim output As BitmapDecoder = BitmapDecoder.Create(savedFile, BitmapCreateOptions.None, BitmapCacheOption.[Default])
                Dim metadata As BitmapMetadata = TryCast(output.Frames(0).Metadata.Clone(), BitmapMetadata)
                Dim lat4 As Byte() = CType(metadata.GetQuery(GPSLatitudeQuery), Byte())
                Dim lon4 As Byte() = CType(metadata.GetQuery(GPSLongitudeQuery), Byte())
                Dim latitudeRef As String = CStr(metadata.GetQuery(GPSLatitudeRefQuery))
                Dim longitudeRef As String = CStr(metadata.GetQuery(GPSLongitudeRefQuery))
                Dim altitude As Byte() = CType(metadata.GetQuery(GPSAltitudeQuery), Byte())
            End Using
        End Sub
    End Class

    Public Class Rational

        Public _num As Int32

        Public _denom As Int32

        Public bytes As Byte()

        Public Sub New(ByVal _Num As Int32, ByVal _Denom As Int32)
            _Num = _Num
            _Denom = _Denom
            bytes = New Byte(7) {}
            BitConverter.GetBytes(_Num).CopyTo(bytes, 0)
            BitConverter.GetBytes(_Denom).CopyTo(bytes, 4)
        End Sub

        Public Sub New(ByVal _bytes As Byte())
            Dim n As Byte() = New Byte(3) {}
            Dim d As Byte() = New Byte(3) {}
            Array.Copy(_bytes, 0, n, 0, 4)
            Array.Copy(_bytes, 4, d, 0, 4)
            _num = BitConverter.ToInt32(n, 0)
            _denom = BitConverter.ToInt32(d, 0)
        End Sub

        Public Function ToDouble() As Double
            Return Math.Round(Convert.ToDouble(_num) / Convert.ToDouble(_denom), 5)
        End Function
    End Class

    Public Class GPSRational

        Public _degrees As Rational

        Public _minutes As Rational

        Public _seconds As Rational

        Public bytes As Byte()

        Private angleInDegrees As Double

        Public Sub New(ByVal angleInDeg As Double)
            Dim absAngleInDeg As Double = Math.Abs(angleInDeg)
            Dim degreesInt As Integer = CInt((absAngleInDeg))
            absAngleInDeg -= degreesInt
            Dim minutesInt As Integer = CInt((absAngleInDeg * 60))
            absAngleInDeg -= minutesInt / 60
            Dim secondsInt As Integer = CInt((absAngleInDeg * 3600 + 0.5))
            Dim denominator As Integer = 1
            _degrees = New Rational(degreesInt, denominator)
            _minutes = New Rational(minutesInt, denominator)
            _seconds = New Rational(secondsInt, denominator)
            angleInDegrees = _degrees.ToDouble() + _minutes.ToDouble() / 60 + _seconds.ToDouble() / 3600
            bytes = New Byte(23) {}
            BitConverter.GetBytes(degreesInt).CopyTo(bytes, 0)
            BitConverter.GetBytes(denominator).CopyTo(bytes, 4)
            BitConverter.GetBytes(minutesInt).CopyTo(bytes, 8)
            BitConverter.GetBytes(denominator).CopyTo(bytes, 12)
            BitConverter.GetBytes(secondsInt).CopyTo(bytes, 16)
            BitConverter.GetBytes(denominator).CopyTo(bytes, 20)
        End Sub

        Public Sub New(ByVal _bytes As Byte())
            Dim degBytes As Byte() = New Byte(7) {}
            Dim minBytes As Byte() = New Byte(7) {}
            Dim secBytes As Byte() = New Byte(7) {}
            Array.Copy(_bytes, 0, degBytes, 0, 8)
            Array.Copy(_bytes, 8, minBytes, 0, 8)
            Array.Copy(_bytes, 16, secBytes, 0, 8)
            _degrees = New Rational(degBytes)
            _minutes = New Rational(minBytes)
            _seconds = New Rational(secBytes)
            angleInDegrees = _degrees.ToDouble() + _minutes.ToDouble() / 60 + _seconds.ToDouble() / 3600
            bytes = New Byte(23) {}
            _bytes.CopyTo(bytes, 0)
        End Sub


    End Class
End Namespace