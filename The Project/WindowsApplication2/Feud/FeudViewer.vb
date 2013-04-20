Public Class FeudViewer
    Dim _MyFeud As Feud
    Dim WPics() As PictureBox
    Public Property MyFeud As Feud
        Get
            Return _MyFeud
        End Get
        Set(ByVal value As Feud)
            _MyFeud = value
            If Not MyFeud Is Nothing Then
                Label1.Text = MyFeud.Storyline.Name
                Label2.Text = "Overall: " & MyFeud.Overall
                Label1.Left = 0
                Label2.Left = 0
                Label1.AutoSize = True
                Label2.AutoSize = True
                '   For Each pb As PictureBox In WPics
               

                Dim cnt As Integer = 0
                Dim curLeft As Integer = PictureBox1.Left
                For i = 0 To MyFeud.Teams.Length - 1
                    For j = 0 To MyFeud.Teams(i).Count - 1
                        ReDim Preserve WPics(cnt)
                        WPics(cnt) = New PictureBox
                        With WPics(cnt)
                            .Height = PictureBox1.Height
                            .Width = PictureBox1.Width
                            .Top = PictureBox1.Top
                            .Left = curLeft
                            .SizeMode = PictureBox1.SizeMode
                            .BorderStyle = PictureBox1.BorderStyle
                            .Image = StorylinePic.getpicfromidstring(MyFeud.Teams(i).Item(j))
                        End With
                        Me.Controls.Add(WPics(cnt))
                        curLeft += PictureBox1.Width + 5
                        cnt += 1
                    Next

                    If Not i = MyFeud.Teams.Length - 1 Then
                        Dim Separator As PictureBox = New PictureBox
                        With Separator
                            .Size = Me.VsBar.Size
                            .Left = curLeft
                            .Top = CInt(PictureBox1.Top + (PictureBox1.Height - VsBar.Height) / 2)
                            .BackColor = VsBar.BackColor
                            .BorderStyle = Windows.Forms.BorderStyle.None
                            .SizeMode = VsBar.SizeMode
                            .Image = VsBar.Image
                        End With
                        Me.Controls.Add(Separator)
                    End If

                    curLeft += VsBar.Width + 5

                Next

                Me.Width2 = Me.Width

            End If
        End Set
    End Property
    Public Property Width2 As Integer
        Get
            Return Me.Width
        End Get
        Set(ByVal value As Integer)
            Me.Width = value
            Label1.AutoSize = False
            Label2.AutoSize = False
            Label1.Left = 0
            Label2.Left = 0
            Label1.Width = Me.Width
            Label2.Width = Me.Width
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As MsgBoxResult = MsgBox("Are you sure you want to cancel this feud?", MsgBoxStyle.YesNo)
        If r = MsgBoxResult.Yes Then
            Basic.Feuds.Remove(MyFeud)
            Me.Dispose()
        End If
    End Sub
End Class
