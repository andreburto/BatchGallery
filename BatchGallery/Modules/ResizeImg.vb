Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Stream

Module ResizeImg

    Public Function ResizeImg(ByVal imgFile As String) As MemoryStream
        Return ResizeImg(imgFile, 100, 100)
    End Function

    Public Function ResizeImg(ByVal imgFile As String, ByVal width As Integer, ByVal height As Integer) As MemoryStream
        If Not File.Exists(imgFile) Then
            MessageBox.Show("No file: " + imgFile)
            End
        End If
        Try
            Dim memStrm As MemoryStream
            Dim fs As FileStream = New FileStream(imgFile, FileMode.Open, FileAccess.Read)
            Dim bytes(1024) As Byte
            Dim count As Integer = 1024

            If fs.CanSeek = True Then
                memStrm = New MemoryStream(fs.Length)
            Else
                memStrm = New MemoryStream
            End If

            Do
                count = fs.Read(bytes, 0, count)
                If count = 0 Then Exit Do
                memStrm.Write(bytes, 0, count)
            Loop

            memStrm.Position = 0
            fs.Close()
            fs.Dispose()
            Dim imgSrc As Image = Image.FromStream(memStrm)
            Return ResizeImg(imgSrc, width, height)

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCrLf + vbCrLf + _
                            ex.StackTrace + vbCrLf + vbCrLf + ex.Source)
            End
        End Try
    End Function

    Public Function ResizeImg(ByVal imgSrc As Image) As MemoryStream
        Return ResizeImg(imgSrc, 100, 100)
    End Function

    Public Function ResizeImg(ByVal imgSrc As Image, ByVal width As Integer, ByVal height As Integer) As MemoryStream
        ' Source image data
        Dim simgW As Integer = imgSrc.Width
        Dim simgH As Integer = imgSrc.Height
        Dim simgX As Integer = 0
        Dim simgY As Integer = 0

        ' Destination image data
        Dim dimgW As Integer = 0
        Dim dimgH As Integer = 0
        Dim dimgX As Integer = 0
        Dim dimgY As Integer = 0

        If simgH < height And simgW < width Then
            dimgH = simgH
            dimgW = simgW
        Else
            If imgSrc.Width < imgSrc.Height Then
                dimgH = height + 1
                dimgW = Math.Floor(simgW * (dimgH / simgH))
            Else
                dimgW = width + 1
                dimgH = Math.Floor(simgH * (dimgW / simgW))
            End If
        End If

        Dim bmImg As Bitmap = New Bitmap(dimgW, dimgH, PixelFormat.Format32bppRgb)
        bmImg.SetResolution(imgSrc.HorizontalResolution, imgSrc.VerticalResolution)

        Dim gmImg As Graphics = Graphics.FromImage(bmImg)

        gmImg.InterpolationMode = InterpolationMode.HighQualityBicubic
        gmImg.CompositingMode = CompositingMode.SourceCopy
        gmImg.CompositingQuality = CompositingQuality.HighSpeed
        gmImg.SmoothingMode = SmoothingMode.HighSpeed

        gmImg.DrawImage(imgSrc, _
                        New Rectangle(dimgX, dimgY, dimgW, dimgH), _
                        New Rectangle(simgX, simgY, simgW, simgH), _
                        GraphicsUnit.Pixel)


        Dim ms As New MemoryStream
        Dim crop As Rectangle = New Rectangle(1, 1, dimgW - 1, dimgH - 1)
        Dim shavedBm As Bitmap = bmImg.Clone(crop, bmImg.PixelFormat)
        shavedBm.Save(ms, ImageFormat.Bmp)

        gmImg.Dispose()
        bmImg.Dispose()

        Return ms
    End Function
End Module