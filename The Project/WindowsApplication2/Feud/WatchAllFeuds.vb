Public Class WatchAllFeuds
    Dim FVControls As List(Of FeudViewer)
    Private Sub WatchAllFeuds_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Basic.Feuds.Count = 0 Then
            FVControls = New List(Of FeudViewer)
            Dim curTop As Integer = FeudViewer1.Top
            For i = 0 To Basic.Feuds.Count - 1
                '    For Each fd As Feud In Basic.Feuds
                Dim fv As FeudViewer = New FeudViewer
                fv.Left = FeudViewer1.Left
                fv.Parent = Panel1
                fv.Top = curTop

                'FVControls.Add(fv)
                Panel1.Controls.Add(fv)
                curTop += fv.Height + 5
                fv.MyFeud = Basic.Feuds(i)
            Next
            ' Next
        Else
            MsgBox("There are no feuds currently")
            Me.Close()
        End If
    End Sub
End Class