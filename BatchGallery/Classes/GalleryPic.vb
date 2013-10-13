Public Class GalleryPic

    Private _fullImage As String = ""
    Private _thImage As String = ""
    Private _smImage As String = ""
    Private _titleImage As String = ""
    Private _aboutImage As String = ""

    Public Sub New()
    End Sub

    Public Sub New(ByVal f As String, ByVal t As String, ByVal s As String, _
                   ByVal title As String, ByVal about As String)
        Me._fullImage = f
        Me._thImage = t
        Me._smImage = s
        Me._titleImage = title
        Me._aboutImage = about
    End Sub

    Public ReadOnly Property FullImage() As String
        Get
            Return Me._fullImage
        End Get
    End Property

    Public ReadOnly Property Thumbnail() As String
        Get
            Return Me._thImage
        End Get
    End Property

    Public ReadOnly Property Small() As String
        Get
            Return Me._smImage
        End Get
    End Property

    Public ReadOnly Property Title() As String
        Get
            Return Me._titleImage
        End Get
    End Property

    Public Property About() As String
        Get
            Return Me._aboutImage
        End Get
        Set(ByVal value As String)
            Me._aboutImage = value
        End Set
    End Property

End Class
