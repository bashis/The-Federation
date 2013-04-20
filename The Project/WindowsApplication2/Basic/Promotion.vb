Imports System.IO
Imports System.Xml.Serialization
<Serializable()>
Public Class Promotion

    Public Financial As Finance
    Public Name As String
    Public ShowNames(6) As String
    <XmlElement(Type:=GetType(XmlColor))> _
    Public Color1 As Color
    <XmlElement(Type:=GetType(XmlColor))> _
    Public Color2 As Color
    <XmlIgnore> Public MainImage As Image
    <XmlIgnore> Public BGImage As Image
    <XmlIgnore> Public ShowPics(6) As Image
    <XmlIgnore> Public ShowBGPics(6) As Image
    <XmlIgnore> Public Titles As List(Of Title)

    Public ShowPicsPaths(6) As String
    Public ShowBGPicsPaths(6) As String
    Public MainImagePath As String
    Public BGImagePath As String
    Public PPVs As List(Of PayPerView)
    Public Money As Double
    Public Popularity As Double
    Public Structure PayPerView
        Dim PDate As Date
        Dim PName As String
        <XmlIgnore> Dim PImage As Image
        Dim PImagePath As String
        Dim Show As Show
        Dim Interest As Integer
    End Structure
    Public Sub New(ByVal name As String, ByVal shownames() As String, ByVal color1 As Color, ByVal color2 As Color,
                   ByVal mainimage As String, ByVal bgimage As String, ByVal showpics() As String, ByVal showBGpics() As String,
                   ByVal money As Double, ByVal popularity As Double)
        With Me
            .Name = name
            .ShowNames = shownames
            .Color1 = color1
            .Color2 = color2
            .MainImagePath = mainimage
            .BGImagePath = bgimage
            For i = 0 To showpics.Length - 1
                .ShowPicsPaths(i) = showpics(i)
            Next
            For i = 0 To showBGpics.Length - 1
                .ShowBGPicsPaths(i) = showBGpics(i)
            Next
            .Money = money
            .Popularity = popularity
        End With
        GetImagesFromPaths()

    End Sub
    Public Sub GetImagesFromPaths()
        For i = 0 To ShowPics.Length - 1
            If Not ShowBGPicsPaths(i) = "" Then
                ShowPics(i) = Image.FromFile(Path.Combine({DefaultConstants.pth, "Promotions", "Images", ShowPicsPaths(i)}))
            End If
        Next
        For i = 0 To ShowBGPics.Length - 1
            If Not ShowBGPicsPaths(i) = "" Then
                ShowBGPics(i) = Image.FromFile(Path.Combine({DefaultConstants.pth, "Promotions", "Images", ShowBGPicsPaths(i)}))
            End If
        Next
        MainImage = Image.FromFile(Path.Combine({DefaultConstants.pth, "Promotions", "Images", MainImagePath}))
        BGImage = Image.FromFile(Path.Combine({DefaultConstants.pth, "Promotions", "Images", BGImagePath}))

        For i = 0 To PPVs.Count - 1
            Dim ppvSetter = PPVs(i)
            ppvSetter.PImage = Image.FromFile(Path.Combine({DefaultConstants.pth, "Promotions", "Images", "Pay-Per-Vews", PPVs(i).PImagePath}))
            PPVs(i) = ppvSetter
        Next
    End Sub
    Public Sub New()

    End Sub

    Public Sub AddPPV(ByVal _Name As String, ByVal _Date As Date, ByVal _Image As Image)
        Dim p As PayPerView = New PayPerView
        With p
            .PName = _Name
            .PDate = _Date
            .PImage = _Image
        End With
        PPVs.Add(p)
        ' Dim met As Boolean = False
        'For i = 0 To PPVs.GetLength(1) - 1
        '    If PPVs(PromotionIndex, i).PName = "" Then
        '        met = True
        '        With PPVs(PromotionIndex, i)
        '            .PName = _Name
        '            .PDate = _Date
        '            .PImage = _Image
        '        End With
        '    End If
        '    If met Then Exit For
        'Next

        'If Not met Then
        '    For i = 0 To PPVs.GetLength(1) - 2
        '        PPVs(PromotionIndex, i) = PPVs(PromotionIndex, i + 1)
        '    Next
        '    With PPVs(PromotionIndex, PPVs.GetLength(1) - 1)
        '        .PName = _Name
        '        .PDate = _Date
        '        .PImage = _Image
        '    End With
        'End If

        'Dim temp As PayPerView
        'For i = 0 To PPVs.GetLength(1) - 1
        '    '   If Not PPVs(PromotionIndex, i).PName = "" Then
        '    For j = i To PPVs.GetLength(1) - 1
        '        If PPVs(PromotionIndex, i).PDate < PPVs(PromotionIndex, j).PDate Then
        '            temp = PPVs(PromotionIndex, i)
        '            PPVs(PromotionIndex, i) = PPVs(PromotionIndex, j)
        '            PPVs(PromotionIndex, j) = temp
        '        End If
        '    Next
        '    ' End If
        'Next
    End Sub

End Class
