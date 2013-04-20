Module TwitsTemplates
    Public GoodMatchWinner() As String = {
        "Nice match tonight! So cool to see all these fans...", "Had a fantastic match tonight! #Mustsee",
        "You haven't seen the REAL wrestling if you haven't seen THE MATCH tonight!", "This. Means. Wrestling. Seriously.",
        "What a victory for [S] in a fantastic match!", "WRESTLING! WRESTLING! WRESTLING!"
    }
    Public GoodMatchLooser() As String = {
        "Nice match starring me tonight. Obviously #Mustsee", "I bet I beat him next time.", "This match was almost mine! #HOWCOME",
        "All Right guys. We all regret about my loss. Still nice match though!", "Who cares? I may win next time."
    }
    Public BadMatchWinner() As String = {
        "Still a victory is a victory. Who cares about the match?", "It could be better..."
    }
    Public BadMatchLooser() As String = {
        "It could be better :(", "How could this even happen? #Whatashame", "Sorry, guys. Everybody has a chance to fail.",
        "Really dissapointed with the results of the match..."}
    Public Function RandomTwitAbout(ByVal About As Object, ByVal From As String) As String
        Dim res As String
        res = About(RosterViewerForm.random(0, About.Length - 1))
        res = res.Replace("[S]", Twitter.NameToTwit(From))
        Return res
    End Function
    Public Function RandomArray() As Object
        Dim i As Integer = RosterViewerForm.random(1, 4)

        Select Case i
            Case 1
                Return GoodMatchLooser
            Case 2
                Return GoodMatchWinner
            Case 3
                Return BadMatchLooser
            Case 4
                Return BadMatchWinner


            Case Else
                Return Nothing
        End Select
    End Function
End Module
