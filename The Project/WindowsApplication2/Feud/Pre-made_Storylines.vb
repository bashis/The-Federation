Module Pre_made_Storylines
    Public MyStoryLines As List(Of Storyline) = New List(Of Storyline)
    Public Sub Build()
        MyStoryLines.Clear()
        AddStoryline("Betrayer", "A person betrayes another", Storyline.Models(0), 0)
        AddStoryline("Fuck you", "A person fucks another 2", Storyline.Models(1), 0)
        AddStoryline("5-men brawl", "FUCKEN BRAAWL", Storyline.Models(6), 0)
        AddStoryline("My Fault!", "Wrestler accidentely hits another one, that brings them to the feud", Storyline.Models(0), 0)
    End Sub


    Public Sub AddStoryline(ByVal name As String, ByVal descr As String, ByVal model As String, ByVal overall As String, ByVal level As String)
        Dim S As Storyline = New Storyline
        With S
            .Description = descr
            .Name = name
            .Model = model
            .Overall = overall
            .level = level
        End With
        MyStoryLines.Add(S)
    End Sub

    Public Sub AddStoryline(ByVal name As String, ByVal descr As String, ByVal model As String, ByVal level As String)
        Dim S As Storyline = New Storyline
        With S
            .Description = descr
            .Name = name
            .Model = model
            .Overall = 0
            .level = level
        End With
        MyStoryLines.Add(S)
    End Sub
End Module
