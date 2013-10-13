Imports System
Imports System.IO
Imports System.Text
Imports System.Xml

Public Class frmGalleryThing

    Private fileName As String = ""
    Private filePath As String = ""
    Private fullName As String = ""
    Private imageList As Hashtable
    Private keyList() As String
    Private imageCounter As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtColumns.Text = Settings.cols
        txtPerPage.Text = Settings.perpage
        txtGalleryTitle.Text = Settings.title
        dlgOpenXml.FileName = Settings.xml
        If dlgOpenXml.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If dlgOpenXml.CheckPathExists = False Then
                ErrorMsg.Die("That file does not exist.  Goodbye.")
            End If

            Me.fullName = dlgOpenXml.FileName
            Me.filePath = Path.GetDirectoryName(Me.fullName)
            Me.fileName = Path.GetFileName(Me.fullName)

            LoadXml(Me.fullName)
            LoadImageData()
        Else
            ErrorMsg.Die("No XML file was selected.  Goodbye.")
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveXml()
    End Sub

#Region " First Panel Controls "

    Private Sub btnHtml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHtml.Click
        btnHtml.Enabled = False
        Dim perpage As Integer = Integer.Parse(txtPerPage.Text)
        Dim cols As Integer = Integer.Parse(txtColumns.Text)
        Dim pages As Integer = Math.Floor(keyList.Length / perpage)
        If (keyList.Length Mod perpage) > 0 Then pages += 1
        Dim menu As String = MakeMenu(pages)
        For cnt As Integer = 1 To pages
            Dim setKeys() As String = {}
            Dim tempKeystart As Integer = (perpage * cnt) - perpage
            Dim tempKeyCount As Integer = 0
            If (keyList.Length - tempKeystart) > perpage Then
                ReDim setKeys(perpage - 1)
                For tc As Integer = tempKeystart To (tempKeystart + perpage - 1)
                    setKeys(tempKeyCount) = keyList(tc)
                    tempKeyCount += 1
                Next
            Else
                If keyList.Length > perpage Then
                    ReDim setKeys((keyList.Length Mod perpage) - 1)
                Else
                    ReDim setKeys(keyList.Length - 1)
                End If
                For tc As Integer = tempKeystart To (keyList.Length - 1)
                    setKeys(tempKeyCount) = keyList(tc)
                    tempKeyCount += 1
                Next
            End If
            Dim name As String = ""
            If cnt > 1 Then name = cnt.ToString + ".html" Else name = "index.html"
            Dim html As String = MakeHtml(setKeys, cols, txtGalleryTitle.Text, txtGalleryAbout.Text, menu)
            Dim bh As Byte() = Encoding.UTF8.GetBytes(html)
            Dim fsh As FileStream = New FileStream(filePath + "\" + name, FileMode.Create, FileAccess.Write)
            fsh.Write(bh, 0, bh.Length)
            fsh.Close()
            fsh.Dispose()
            SaveXml()
        Next
        btnHtml.Enabled = True
    End Sub

    Private Sub btnAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddImage.Click
        If dlgOpenImg.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
        If dlgOpenImg.FileName.Length = 0 Then Exit Sub
        Dim fileImgPath As String = Path.GetDirectoryName(dlgOpenImg.FileName)
        Dim fileImgName As String = Path.GetFileName(dlgOpenImg.FileName)
        Dim bp As BatchPic = New BatchPic(dlgOpenImg.FileName)

        Dim twidth As Integer = GetImageWidthFromDir(Me.filePath + "\" + Settings.thumb)
        Dim thumb As Thumbnails = New Thumbnails(fileImgPath, fileImgName, Me.filePath + "\" + Settings.thumb, _
                                                 bp.Thumbnail, twidth.ToString)
        thumb.MakeThumbnails()

        Dim swidth As Integer = GetImageWidthFromDir(Me.filePath + "\" + Settings.small)
        Dim small As Thumbnails = New Thumbnails(fileImgPath, fileImgName, Me.filePath + "\" + Settings.small, _
                                                 bp.Small, swidth.ToString)
        small.MakeThumbnails()

        Dim imgFile As String = dlgOpenImg.FileName
        Dim outFile As String = Me.filePath + "\" + Settings.full + "\" + bp.Full
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
        imageList(fileImgName) = New GalleryPic(bp.Full, bp.Thumbnail, bp.Small, _
                                                fileImgName, fileImgName)
        UpdateKeyList()
        SaveXml()
        LoadXml(Me.fullName)
        LoadImageData()
        dlgOpenImg.Reset()
    End Sub

#End Region

#Region "HTML Stuff"

    Private Function MakeHtml(ByVal keys() As String, ByVal cols As Integer, _
                              ByVal title As String, ByVal about As String, _
                              ByVal menu As String) As String
        Dim html As StringBuilder = New StringBuilder
        Dim colCount As Integer = 0
        Dim startDiv As String = "<div style=""width: auto; margin: auto; padding: 0px; text-align: center;"">"
        html.Append("<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.01 Transitional//EN"">").Append(vbCrLf)
        html.Append("<html lang=""en"">").Append(vbCrLf)
        html.Append("<head><title>").Append(title).Append("</title></head>").Append(vbCrLf)
        html.Append("<body style=""text-align: center;"">").Append(vbCrLf)
        html.Append("<h1 style=""text-align: center;"">").Append(title).Append("</h1>").Append(vbCrLf)
        html.Append("<h3 style=""text-align: center;"">").Append(about).Append("</h3>").Append(vbCrLf)
        html.Append("<p style=""text-align: center;"">").Append(menu).Append("</p>")
        html.Append(startDiv).Append(vbCrLf)
        For k As Integer = 0 To keys.Length - 1
            Dim i As GalleryPic = imageList(keys(k))
            If colCount = cols Then
                html.Append("</div>").Append(vbCrLf).Append(startDiv).Append(vbCrLf)
                colCount = 0
            End If
            html.Append("<a href=""").Append(Settings.full).Append("/").Append(i.FullImage).Append(""">")
            html.Append("<img src=""").Append(Settings.thumb).Append("/").Append(i.Thumbnail).Append(""" ")
            html.Append("style=""border: 0px none; margin: auto;"" alt=""").Append(i.Title)
            html.Append(""" title=""").Append(i.About).Append("""></a>").Append(vbCrLf)
            colCount += 1
        Next
        html.Append("</div>").Append(vbCrLf)
        html.Append("<p style=""text-align: center;"">").Append(menu).Append("</p>").Append(vbCrLf)
        html.Append("</body>").Append(vbCrLf).Append("</html>").Append(vbCrLf)
        Return html.ToString
    End Function

    Private Function MakeMenu(ByVal total As Integer) As String
        Dim menu As StringBuilder = New StringBuilder
        For cnt As Integer = 1 To total
            If cnt > 1 Then
                menu.Append(" / <a href=""").Append(cnt.ToString).Append(".html"">")
                menu.Append(cnt.ToString).Append("</a>")
            Else
                menu.Append("<a href=""index.html"">1</a>")
            End If
        Next
        Return menu.ToString
    End Function

#End Region

#Region " Second Panel Controls "

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Me.imageCounter -= 1
        If Me.imageCounter < 0 Then Me.imageCounter = Me.keyList.Length - 1
        LoadImageData()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.imageCounter += 1
        If Me.imageCounter = Me.keyList.Length Then Me.imageCounter = 0
        LoadImageData()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim temp_key = keyList(imageCounter)
        imageList(temp_key).About = XmlEncode(txtImageAbout.Text)
        SaveXml()
        LoadXml(fullName)
    End Sub

    Private Sub LoadImageData()
        Dim temp_key = keyList(imageCounter)
        Dim img As GalleryPic = imageList(temp_key)
        lblImageTitle.Text = img.Title
        txtImageAbout.Text = XmlDecode(img.About)
        picImage.Load(filePath + "\" + Settings.small + "\" + img.Small)
    End Sub

#End Region

#Region "XML Stuff"

    Private Sub LoadXml(ByVal xml As String)
        Dim doc As XmlDocument = New XmlDocument()
        imageList = New Hashtable

        Try
            doc.Load(xml)
            Dim textTitle As String = ""
            Dim textAbout As String = ""

            If doc.SelectNodes("/gallery/title").Count > 0 Then
                txtGalleryTitle.Text = XmlDecode(doc.SelectSingleNode("/gallery/title").InnerText)
            End If

            If doc.SelectNodes("/gallery/about").Count > 0 Then
                txtGalleryAbout.Text = XmlDecode(doc.SelectSingleNode("/gallery/about").InnerText)
            End If

            For Each x As XmlNode In doc.SelectNodes("/gallery/images/image")
                imageList(x.Item("title").InnerText) = New GalleryPic(x.Item("full").InnerText, _
                                                                      x.Item("thumb").InnerText, _
                                                                      x.Item("small").InnerText, _
                                                                      x.Item("title").InnerText, _
                                                                      x.Item("about").InnerText)
            Next
            UpdateKeyList()
        Catch ex As Exception
            ErrorMsg.Die(ex)
        End Try
    End Sub

    Private Sub SaveXml()
        Dim xml As String = MakeXml()
        Dim bx As Byte() = Encoding.UTF8.GetBytes(xml)
        Dim fsx As FileStream = New FileStream(fullName, FileMode.Create, FileAccess.Write)
        fsx.Write(bx, 0, bx.Length)
        fsx.Close()
        fsx.Dispose()
    End Sub

    Public Function MakeXml() As String
        Dim xml As StringBuilder = New StringBuilder

        xml.Append("<?xml version=""1.0"" encoding=""UTF-8""?>").Append(vbCrLf)
        xml.Append("<gallery>").Append(vbCrLf)

        If txtGalleryTitle.Text.Length > 0 Then
            xml.Append("  <title>").Append(XmlEncode(txtGalleryTitle.Text)).Append("</title>").Append(vbCrLf)
        End If

        If txtGalleryAbout.Text.Length > 0 Then
            xml.Append("  <about>").Append(XmlEncode(txtGalleryAbout.Text)).Append("</about>").Append(vbCrLf)
        End If

        xml.Append("  <directories>").Append(vbCrLf)
        xml.Append("    <dir type=""full"" path=""").Append(Settings.full).Append(""" />").Append(vbCrLf)
        xml.Append("    <dir type=""thumb"" path=""").Append(Settings.thumb).Append(""" />").Append(vbCrLf)
        xml.Append("    <dir type=""small"" path=""").Append(Settings.small).Append(""" />").Append(vbCrLf)
        xml.Append("  </directories>").Append(vbCrLf)
        xml.Append("  <images>").Append(vbCrLf)

        For Each k As String In keyList
            Dim i As GalleryPic = imageList(k)
            xml.Append("    <image>").Append(vbCrLf)
            xml.Append("      <title>").Append(i.Title).Append("</title>").Append(vbCrLf)
            xml.Append("      <about>").Append(i.About).Append("</about>").Append(vbCrLf)
            xml.Append("      <full>").Append(i.FullImage).Append("</full>").Append(vbCrLf)
            xml.Append("      <thumb>").Append(i.Thumbnail).Append("</thumb>").Append(vbCrLf)
            xml.Append("      <small>").Append(i.Small).Append("</small>").Append(vbCrLf)
            xml.Append("    </image>").Append(vbCrLf)
        Next

        xml.Append("  </images>").Append(vbCrLf)
        xml.Append("</gallery>").Append(vbCrLf)

        Return xml.ToString
    End Function

    Private Function XmlEncode(ByVal text As String) As String
        text = text.Replace("&", "&amp;")
        text = text.Replace("<", "&lt;")
        text = text.Replace(">", "&gt;")
        text = text.Replace("'", "&apos;")
        text = text.Replace("""", "&quot;")
        Return text
    End Function

    Private Function XmlDecode(ByVal text As String) As String
        text = text.Replace("&lt;", "<")
        text = text.Replace("&gt;", ">")
        text = text.Replace("&apos;", "'")
        text = text.Replace("&quot;", """")
        text = text.Replace("&amp;", "&")
        Return text
    End Function

#End Region

    Private Sub UpdateKeyList()
        ReDim Me.keyList(Me.imageList.Keys.Count - 1)
        imageList.Keys.CopyTo(Me.keyList, 0)
        Array.Sort(Me.keyList)
    End Sub

    Private Function GetImageWidthFromDir(ByVal d As String) As Integer
        Dim fl() As IO.FileInfo = New DirectoryInfo(d).GetFiles("*.*")
        Dim tempImg As Image = Image.FromFile(fl(1).FullName)
        Dim w As Integer = tempImg.Width
        tempImg.Dispose()
        Return w
    End Function

End Class
