Public Class Basic
    Public Shared Promotion As Integer
    Public Shared PromotionName As String
    Public Shared Color1 As Color
    Public Shared BackImage1 As Image
    'Public Shared ShowDays(,) As Boolean = {
    '    {False, False, False, False, False, False, False},
    '    {False, True, False, False, False, True, False},
    '    {False, False, False, False, False, False, False},
    '    {False, False, False, False, False, False, False},
    '    {False, False, False, False, False, False, False},
    '    {False, False, False, False, False, False, False}
    '}
    Public Shared P_Names() As String = {"Free Agent", "WWE", "ROH", "Impact Wrestling"}


    Public Shared ShowNames(,) As String = {
            {"", "", "", "", "", "", ""},
            {"", "Monday Night RAW", "", "", "", "Friday Night SmackDown", ""},
            {"", "", "", "", "", "", "Ring Of Honor"},
            {"", "", "", "Impact Wrestling", "", "", ""}
        }

    Public Shared Arenas(10) As Arena


    Public Structure PayPerView
        Dim PDate As Date
        Dim PName As String
        Dim PImage As Image
        Dim PArena As Arena
        Dim ppvMode As Integer
        Dim IsCancelled As Boolean
    End Structure
    Public Shared PPVs(P_Names.Length - 1, DefaultConstants.PPVsPerYear) As PayPerView



    Public Shared ShowPics(P_Names.Length - 1, 6) As Image

    Public Shared Colors() As Color = {Color.DarkGray, Color.LightCoral, Color.RoyalBlue, Color.DodgerBlue}
    Public Shared Colors2() As Color = {Color.Black, Color.Black, Color.Black, Color.Black}
    Public Shared P_Images1() As Image = {My.Resources.bg_free, My.Resources.bg_wwe, My.Resources.bg_roh, My.Resources.bg_tna}
    Public Shared P_ImagesBG() As Image = {My.Resources.background2, My.Resources.background2, My.Resources.background2, My.Resources.SbgTNA}

    Public Shared Sub recount()
        PromotionName = P_Names(Promotion)
        Color1 = Colors(Promotion)
        BackImage1 = P_Images1(Promotion)
        Innn()
    End Sub
    Public Shared Sub Innn()
        With Arenas(0)
            .Name = "Maddison Square Garden"
            .Cost = 100000
            .Places = 20000
        End With
        With Arenas(1)
            .Name = "The Original Arena"
            .Cost = 20000
            .Places = 4500
        End With
        ShowPics(1, 1) = My.Resources.bg_raw
        ShowPics(1, 5) = My.Resources.bg_sd
        ShowPics(3, 3) = My.Resources.bg_tna
        ShowPics(2, 6) = My.Resources.bg_roh

        PPVs(1, 0) = New PayPerView

        With PPVs(1, 0)
            .PDate = New Date(2012, 4, 1)
            .PImage = My.Resources.wm28
            .PName = "Wrestlemania 28"
            .PArena = Arenas(1)
            .ppvMode = 1
        End With

        AddPPV(1, "Extreme Rules", New Date(2012, 4, 29), Arenas(0), My.Resources.extreme_rules1, 1)

        AddPPV(3, "Destination X", New Date(2012, 3, 21), Arenas(0), My.Resources.tna_destination_x_logo, 1)




    End Sub
    Public Structure Arena
        Dim Cost As Double
        Dim Places As Integer
        Dim Name As String
    End Structure

    Public Shared Sub AddPPV(ByVal PromotionIndex As Integer, ByVal _Name As String, ByVal _Date As Date, ByVal _Arena As Arena, ByVal _Image As Image, ByVal _ppvMode As Integer)
        Dim met As Boolean = False
        For i = 0 To PPVs.GetLength(1) - 1
            If PPVs(PromotionIndex, i).PName = "" Then
                met = True
                With PPVs(PromotionIndex, i)
                    .PName = _Name
                    .PDate = _Date
                    .PImage = _Image
                    .PArena = _Arena
                    .ppvMode = _ppvMode
                End With
            End If
            If met Then Exit For
        Next

        If Not met Then
            For i = 0 To PPVs.GetLength(1) - 2
                PPVs(PromotionIndex, i) = PPVs(PromotionIndex, i + 1)
            Next
            With PPVs(PromotionIndex, PPVs.GetLength(1) - 1)
                .PName = _Name
                .PDate = _Date
                .PImage = _Image
                .PArena = _Arena
                .ppvMode = _ppvMode
            End With
        End If

        Dim temp As PayPerView
        For i = 0 To PPVs.GetLength(1) - 1
            '   If Not PPVs(PromotionIndex, i).PName = "" Then
            For j = i To PPVs.GetLength(1) - 1
                If PPVs(PromotionIndex, i).PDate < PPVs(PromotionIndex, j).PDate Then
                    temp = PPVs(PromotionIndex, i)
                    PPVs(PromotionIndex, i) = PPVs(PromotionIndex, j)
                    PPVs(PromotionIndex, j) = temp
                End If
            Next
            ' End If
        Next
    End Sub
    Public Shared Sub NextDay()
        CurrentDate = CurrentDate.AddDays(1)
    End Sub
    Public Shared CurrentDate As Date = "11/03/2012 10:00"

End Class
