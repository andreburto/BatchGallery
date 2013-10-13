Imports System
Imports System.IO
Imports System.Text

Public Class GalleryList

    Private _list As Collection

    Public Sub New()
        _list = New Collection
    End Sub

    Public Sub ClearList()
        _list.Clear()
    End Sub

    Public Sub AddToList(ByVal img As BatchPic)
        _list.Add(New GalleryPic(img.Full, img.Thumbnail, img.Small, img.Filename, img.Filename))
    End Sub

    Public Function MakeXml() As String
        Dim xml As StringBuilder = New StringBuilder

        xml.Append("<?xml version=""1.0"" encoding=""UTF-8""?>").Append(vbCrLf)
        xml.Append("<gallery>").Append(vbCrLf)
        xml.Append("  <directories>").Append(vbCrLf)
        xml.Append("    <dir type=""full"" path=""").Append(Settings.full).Append(""" />").Append(vbCrLf)
        xml.Append("    <dir type=""thumb"" path=""").Append(Settings.thumb).Append(""" />").Append(vbCrLf)
        xml.Append("    <dir type=""small"" path=""").Append(Settings.small).Append(""" />").Append(vbCrLf)
        xml.Append("  </directories>").Append(vbCrLf)
        xml.Append("  <images>").Append(vbCrLf)

        For Each i As GalleryPic In _list
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

    Public Function MakeHtml() As String
        Dim html As StringBuilder = New StringBuilder

        html.Append("<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.01 Transitional//EN"">").Append(vbCrLf)
        html.Append("<html lang=""en"">").Append(vbCrLf)
        html.Append("<head><title>BatchSize2 Gallery</title></head>").Append(vbCrLf)
        html.Append("<body style=""text-align: center;"">").Append(vbCrLf)
        html.Append("<div style=""width: 800px; margin: auto; padding: 0px;"">").Append(vbCrLf)
        For Each i As GalleryPic In _list
            html.Append("<div style=""margin: 2px; border: 0px none; float: left;"">")
            html.Append("<a href=""").Append(Settings.full).Append("/").Append(i.FullImage).Append(""">")
            html.Append("<img src=""").Append(Settings.thumb).Append("/").Append(i.Thumbnail).Append(""" ")
            html.Append("style=""border: 0px none; margin: 2px;"" alt=""").Append(i.Title).Append("""></a></div>").Append(vbCrLf)
        Next
        html.Append("</div>").Append(vbCrLf)
        html.Append("</body>").Append(vbCrLf).Append("</html>").Append(vbCrLf)

        Return html.ToString
    End Function

End Class