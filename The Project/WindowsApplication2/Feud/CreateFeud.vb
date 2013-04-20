Public Class CreateFeud
    Dim _MyStoryline As Storyline
    Public Property MyStoryline As Storyline
        Get
            Return _MyStoryline
        End Get
        Set(ByVal value As Storyline)
            _MyStoryline = value
            If Not value Is Nothing Then

            End If
        End Set
    End Property
    Public MyFeud As Feud
    Private Sub Save()
        Try
            MyFeud.Storyline = New Storyline
            MyFeud.Storyline = MyStoryline
            For i = 0 To MyFeud.Teams.Length - 1
                MyFeud.Teams(i) = New List(Of WModel)
                For j = 0 To CInt(modarr(i)) - 1
                    MyFeud.Teams(i).Add(Selectors(i).Item(j).MyWmodel)
                Next
            Next
            Basic.Feuds.Add(MyFeud)
            MsgBox("Storyline created successfully!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CreateFeud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim teamsarr() As Integer
    Dim Selectors() As List(Of StorylinePic)
    Dim modarr() As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MyStoryline = SelectNewStoryline()
        If Not MyStoryline Is Nothing Then


            If Not Selectors Is Nothing Then
                For i = 0 To Selectors.Length - 1
                    For j = 0 To Selectors(i).Count - 1
                        Me.Controls.Remove(Selectors(i).Item(j))
                    Next
                Next
            End If

            modarr = MyStoryline.Model.Split("x")



            MyFeud = New Feud(modarr.Length)
            ReDim Selectors(modarr.Length - 1)



            Dim curtop As Integer = StorylinePic1.Top
            Dim curleft As Integer = StorylinePic1.Left

            For i = 0 To MyFeud.Teams.Length - 1
                Selectors(i) = New List(Of StorylinePic)
                For j = 0 To CInt(modarr(i)) - 1
                    Dim Sel As StorylinePic = New StorylinePic
                    Sel.Top = curtop
                    Sel.Left = curleft

                    Me.Controls.Add(Sel)

                    Selectors(i).Add(Sel)

                    curtop += Sel.Height + 10

                Next
                curtop = StorylinePic1.Top
                curleft += 200
            Next

        End If

    End Sub

    Public Function SelectNewStoryline() As Storyline
        Dim r As DialogResult
        Dim Res As Storyline = Nothing
        Dim Sel As SelectStoryline = New SelectStoryline
        r = Sel.ShowDialog()
        If r = Windows.Forms.DialogResult.Cancel Then
            Return Nothing
        Else
            Return Sel.selectedStoryline
        End If
    End Function

    Private Sub StorylinePic1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StorylinePic1.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Save()
    End Sub
End Class