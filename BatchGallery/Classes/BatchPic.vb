Imports System
Imports System.Text

Public Class BatchPic

    Private _fileName As String = ""
    Private _origName As String = ""

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String)
        Me._fileName = Me.Str2B64(name) + ".png"
        Me._origName = name
    End Sub

    Public Property Filename() As String
        Get
            Return Me._origName
        End Get
        Set(ByVal value As String)
            Me._fileName = Str2B64(value) + ".png"
            Me._origName = value
        End Set
    End Property

    Public ReadOnly Property Full()
        Get
            Return Me._fileName
        End Get
    End Property

    Public ReadOnly Property Thumbnail()
        Get
            Return "t_" + Me._fileName
        End Get
    End Property

    Public ReadOnly Property Small()
        Get
            Return "s_" + Me._fileName
        End Get
    End Property

    Private Function Str2B64(ByVal fn As String) As String
        Dim b As Byte() = Encoding.UTF8.GetBytes(fn)
        Return Convert.ToBase64String(b)
    End Function
End Class
