Public Class GimmickSuggestion
    Public AutorId_String As String
    Public Property MyAutor() As WModel
        Get
            Return MData.FindWrestler(AutorId_String)
        End Get
        Set(ByVal value As WModel)
            AutorId_String = value.id_string
        End Set
    End Property

    Public Sub SetGimmick(ByVal G As Gimmick)
        ' MData.wrestlers(MyAutor.id).Gimmick = G
        MyAutor.Gimmick = G
        MData.Show()
    End Sub

    Public MyGimmick As Gimmick

#Region "Constructors"
    Public Sub New()

    End Sub
    Public Sub New(ByVal Autor As WModel, ByVal Gimmick As Gimmick)
        MyAutor = Autor
        MyGimmick = Gimmick
    End Sub
    Public Sub New(ByVal Author As WModel, ByVal modifier As Double)
        MyAutor = Author
        MyGimmick = Gimmick.Generate(modifier)
    End Sub
#End Region
End Class
