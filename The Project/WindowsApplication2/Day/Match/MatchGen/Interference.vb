
Public Class Interference
    Public Enum Style
        DQ = 0

    End Enum

    Public Interferers As List(Of WModel)
    Public Victim_Id As Integer
    Public Description As String
    Public Result As Style
    Public aftermath As String
    ' Public Sub New()
    '
    '    End Sub

    ' Dim InterferrerName As String
    Public Shared Function ReturnInterfere(ByVal i As Interference, ByVal Attacker As WModel, ByVal Seller As WModel)
        Dim myStr As String
        myStr = i.Description.Replace("[A]", Attacker.Name).Replace("[S]", Seller.Name)
        For ind = 0 To i.Interferers.Count - 1
            '   myStr = myStr.Replace("[F_" & ind.ToString & "]", i.Interferers(ind).MyFinisher.Description.Replace("[A]", i.Interferers(ind).Name).Replace("[S]", Seller.Name))
            '    myStr = myStr.Replace("[I_" & ind.ToString & "]", i.Interferers(ind).Name)
        Next

        Return myStr

    End Function
    Public Shared Function OneInterference() As Interference 'TODO: Delete this
        Dim i1 As Interference = New Interference
        Dim intwr As WModel = New WModel
        With intwr
            .Name = "The Miz"
            .RingState = NewMatchGenerator.appearState.Inside
            .IsBleeding = False
            .MyPosition = WModel.Position.Standing
            .style = 0
        End With
        i1.Interferers = New List(Of WModel)
        '  NewMatchGenerator.InitializeFinisher(intwr, "Skull Crushing Finale", "[A] gets behind [S] and crushes him down with a massive Skull Crushing Finale!", MyWrestler.Position.Standing, False, False)
        i1.Interferers.Add(intwr)
        i1.Victim_Id = 1
        i1.Result = Style.DQ
        i1.Description = "Suddenly [I_0] runs to the ring, attempting to interfere the match. [S] tries to stop him, but [I_0] makes several punches straight to [S]'s face. [F_0] [I_0] then escapes the ring with a smile on his face. The referee has nothing else to do than to disqualify [A] for interference."
        Return i1
    End Function
End Class
