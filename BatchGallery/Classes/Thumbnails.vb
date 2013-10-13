Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Class Thumbnails

    Private idir As String = ""
    Private odir As String = ""
    Private ifile As String = ""
    Private ofile As String = ""
    Private w As String = ""

    Public Sub New(ByVal inputDir As String, ByVal inputFile As String, ByVal outputDir As String, _
                   ByVal outputFile As String, ByVal width As String)
        Me.idir = inputDir
        Me.ifile = inputFile
        Me.odir = outputDir
        Me.ofile = outputFile
        Me.w = width
    End Sub

    Public Sub MakeThumbnails()
        Dim infile As String = Me.idir
        Dim outfile As String = Me.odir

        If infile.EndsWith("\") = False Then
            infile += "\" + Me.ifile
        Else
            infile += Me.ifile
        End If

        If outfile.EndsWith("\") = False Then
            outfile += "\" + Me.ofile
        Else
            outfile += Me.ofile
        End If

        If Not File.Exists(infile) Then ErrorMsg.Show("File " + infile + " does not exist")

        Try
            Dim ms As MemoryStream = ResizeImg.ResizeImg(infile, Integer.Parse(Me.w), Integer.Parse(Me.w))
            Dim img As Image = Image.FromStream(ms)
            img.Save(outfile, ImageFormat.Png)
            img.Dispose()
        Catch ex As Exception
            ErrorMsg.Show(ex)
        End Try
    End Sub
End Class