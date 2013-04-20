
Imports System.Xml.Serialization
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Basic
#Region "Promotion Constants"

    Shared _Promotion As Integer
    Public Shared Property Promotion
        Get
            Return _Promotion
        End Get
        Set(value)
            _Promotion = value
            If Not MData.wrestlers Is Nothing Then
                MData.fillmywrestlers()
            End If
        End Set
    End Property

    Public Shared Promotions As List(Of Promotion) = New List(Of Promotion)


    '  Public Shared PromotionName As String
    '  Public Shared Color1 As Color
    '   Public Shared BackImage1 As Image

    'Public Shared ShowDays(,) As Boolean = {
    '    {False, False, False, False, False, False, False},
    '    {False, True, False, False, False, True, False},
    '    {False, False, False, False, False, False, False},
    '    {False, False, False, False, False, False, False},
    '    {False, False, False, False, False, False, False},
    '    {False, False, False, False, False, False, False}
    '}
    '  Public Shared P_Names() As String = {"Free Agent", "WWE", "ROH", "Impact Wrestling"}



    'Public Shared ShowNames(,) As String = {
    '        {"", "", "", "", "", "", ""},
    '        {"", "Monday Night RAW", "NXT", "Superstars", "", "Friday Night SmackDown", ""},
    '        {"", "", "", "", "", "", "Ring Of Honor"},
    '        {"", "", "", "Impact Wrestling", "", "", ""}
    '    }

#End Region
#Region "Other Constants"
    Public Shared Titles As List(Of Title)

    Public Shared Feuds As List(Of Feud)

    Public Shared Arenas(10) As Arena

    Public Structure Arena
        Dim Cost As Double
        Dim Places As Integer
        Dim Name As String
    End Structure
#End Region
#Region "PPVs"
   
    Public Shared Function PBN(ByVal Name As String) As Image
        Dim DefaultPath As String = Path.Combine(DefaultConstants.pth, "Promotions", "Images", Name)
        Dim result As Image
        Try
            result = Image.FromFile(DefaultPath)
        Catch ex As Exception
            result = Nothing
        End Try

        Return result
    End Function

    '   Public Shared PPVs(Promotions.Count - 1, DefaultConstants.PPVsPerYear) As PayPerView



    '  Public Shared ShowPics(P_Names.Length - 1, 6) As String
    '   Public Shared ShowBGPics(P_Names.Length - 1, 6) As String
    '  Public Shared Colors() As Color = {Color.DarkGray, Color.LightCoral, Color.Crimson, Color.DodgerBlue}
    'Public Shared Colors2() As Color = {Color.Black, Color.Black, Color.Black, Color.Black}
    '  Public Shared P_Images1() As String = {"bg-free.jpg", "bg-wwe.jpg", "bg-roh.jpg", "bg-tna.jpg"}
    ' Public Shared P_ImagesBG() As String = {"background2.jpg", "background2.jpg", "ROH_MAIN_Background.jpg", "TNA_MAIN_Background.jpg"}


  
#End Region

    Public Shared Sub recount()
        '  BackImage1 = PBN(P_Images1(Promotion))
        Innn()
    End Sub

    Public Shared Sub Innn()

        Pre_made_Storylines.Build()
        Feuds = New List(Of Feud)

        'ShowBGPics(1, 1) = "bg-raw.jpg"
        'ShowBGPics(1, 5) = "bg-sd.jpg"
        'ShowBGPics(1, 2) = "bg-nxt.jpg"
        'ShowBGPics(1, 3) = "bg-superstars.jpg"
        'ShowBGPics(3, 3) = "bg-tna.jpg"
        'ShowBGPics(2, 6) = "bg-roh.jpg"


        'ShowPics(1, 1) = "Schedule\WWE-RAW.jpg"
        'ShowPics(1, 5) = "Schedule\WWE-SmackDown.jpg"
        'ShowPics(1, 2) = "Schedule\WWE-NXT.jpg"
        'ShowPics(1, 3) = "Schedule\WWE-Superstars.jpg"
        'ShowPics(3, 3) = "Schedule\TNA-IMPACT.jpg"
        'ShowPics(2, 6) = "Schedule\ROH.jpg"

        'PPVs(1, 0) = New PayPerView
        'With PPVs(1, 0)
        '    .PDate = New Date(2012, 4, 1)
        '    .PImage = My.Resources.WWE_WrestleMania_28
        '    .PName = "Wrestlemania 28"
        'End With
        'AddPPV(1, "Extreme Rules", New Date(2012, 4, 29), My.Resources.extreme_rules1)
        ' PPVs(1, 0).Interest = 86

        With Arenas(0)
            .Name = "Maddison Square Garden"
            .Cost = 100000
            .Places = 20000
        End With

        '======Load Titles List

        '========/Load Titles List

    End Sub
#Region "Dates"
    Public Shared Sub NextDay()
        CurrentDate = CurrentDate.AddDays(1)
    End Sub
    Public Shared CurrentDate As Date = "14/01/2013 00:00"
#End Region
#Region "Gimmick"
    Public Shared StoredGimmicks As List(Of GimmickSuggestion) = New List(Of GimmickSuggestion)
#End Region
End Class
