Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic

Public Class frmBatch

    Dim th As Thread
    Dim tCount As Integer = 0
    Dim statusLength As Integer = 0

    Private Sub frmBatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtThumb.Text = Settings.thumbSize.ToString
        txtSmall.Text = Settings.smallSize.ToString
    End Sub

    Private Sub btnSelectInputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectInputFolder.Click
        If Not txtInputFolder.Text = "" Then
            fbdInputFolder.SelectedPath = txtInputFolder.Text
        End If

        If fbdInputFolder.ShowDialog() = DialogResult.OK Then
            txtInputFolder.Text = fbdInputFolder.SelectedPath
        End If
    End Sub

    Private Sub btnSelectOutputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectOutputFolder.Click
        If Not txtOutputFolder.Text = "" Then
            fbdOutputFolder.SelectedPath = txtOutputFolder.Text
        ElseIf Not txtInputFolder.Text = "" Then
            fbdOutputFolder.SelectedPath = txtInputFolder.Text
        End If

        If fbdOutputFolder.ShowDialog = DialogResult.OK Then
            txtOutputFolder.Text = fbdOutputFolder.SelectedPath
        End If
    End Sub

    Private Sub btnThumbnailize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThumbnailize.Click
        If txtInputFolder.Text.Length = 0 Then Exit Sub
        If txtOutputFolder.Text.Length = 0 Then Exit Sub

        If Not txtInputFolder.Text.EndsWith("\") Then txtInputFolder.Text += "\"
        If Not txtOutputFolder.Text.EndsWith("\") Then txtOutputFolder.Text += "\"

        btnThumbnailize.Enabled = False
        statLabel.Text = ""

        Dim gl As GalleryList = New GalleryList
        Dim exts As String() = {"jpeg", "jpg", "gif", "png", "bmp"}
        Dim di As New IO.DirectoryInfo(txtInputFolder.Text)

        For Each ext As String In exts
            Dim pat As String = "*." + ext
            Dim dir As IO.FileInfo() = di.GetFiles(pat)

            If Not Directory.Exists(txtOutputFolder.Text + Settings.full) Then Directory.CreateDirectory(txtOutputFolder.Text + Settings.full)
            If Not Directory.Exists(txtOutputFolder.Text + Settings.thumb) Then Directory.CreateDirectory(txtOutputFolder.Text + Settings.thumb)
            If Not Directory.Exists(txtOutputFolder.Text + Settings.small) Then Directory.CreateDirectory(txtOutputFolder.Text + Settings.small)

            For Each file As IO.FileInfo In dir
                Dim bp As BatchPic = New BatchPic(file.Name)
                Dim thumb As Thumbnails = New Thumbnails(txtInputFolder.Text, file.Name, txtOutputFolder.Text + Settings.thumb, _
                                                         bp.Thumbnail, txtThumb.Text)
                thumb.MakeThumbnails()
                Dim small As Thumbnails = New Thumbnails(txtInputFolder.Text, file.Name, txtOutputFolder.Text + Settings.small, _
                                                         bp.Small, txtSmall.Text)
                small.MakeThumbnails()
                CopyImageToNewPlace(bp)
                gl.AddToList(bp)
                Me.statLabel.Text = "Finished: " + bp.Filename
                Me.StatusStrip1.Refresh()
                Me.Refresh()
            Next
        Next

        If chkXml.Checked = True Then
            Dim xml As String = gl.MakeXml()
            Dim bx As Byte() = Encoding.UTF8.GetBytes(xml)
            Dim fsx As FileStream = New FileStream(txtOutputFolder.Text + "\" + Settings.xml, FileMode.Create, FileAccess.Write)
            fsx.Write(bx, 0, bx.Length)
            fsx.Close()
            fsx.Dispose()
        End If

        If chkHtml.Checked = True Then
            Dim html As String = gl.MakeHtml()
            Dim bh As Byte() = Encoding.UTF8.GetBytes(html)
            Dim fsh As FileStream = New FileStream(txtOutputFolder.Text + "\" + Settings.html, FileMode.Create, FileAccess.Write)
            fsh.Write(bh, 0, bh.Length)
            fsh.Close()
            fsh.Dispose()
        End If

        Me.statLabel.Text = "Complete"
        Me.StatusStrip1.Refresh()
        Me.Refresh()
        btnThumbnailize.Enabled = True
    End Sub

    Private Sub CopyImageToNewPlace(ByVal bp As BatchPic)
        Dim imgFile As String = txtInputFolder.Text + "\" + bp.Filename
        Dim outFile As String = txtOutputFolder.Text + "\" + Settings.full + "\" + bp.Full
        Dim fs As FileStream = New FileStream(imgFile, FileMode.Open, FileAccess.Read)
        Dim os As FileStream = New FileStream(outFile, FileMode.Create, FileAccess.Write)
        Dim bytes(1024) As Byte
        Dim count As Integer = 1024
        Do
            count = fs.Read(bytes, 0, count)
            If count = 0 Then Exit Do
            os.Write(bytes, 0, count)
        Loop
        fs.Close()
        fs.Dispose()
        os.Close()
        os.Dispose()
    End Sub
End Class
