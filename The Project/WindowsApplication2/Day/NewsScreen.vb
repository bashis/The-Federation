Public Class NewsScreen
    Public Structure News
        Dim BgPic As Bitmap
        Dim Head As String
        Dim Body As String
        Dim Wrestler As WModel
        Public Shared Function Create(ByVal Head As String, ByVal Body As String,
                                      ByVal BgPic As Bitmap, ByVal Wrestler As WModel) As News
            Dim n As News = New News
            n.Head = Head
            n.Body = Body
            n.BgPic = BgPic
            n.Wrestler = Wrestler
            Return n
        End Function
        Public Shared Function Create(ByVal Head As String, ByVal Body As String,
                                      ByVal BgPic As Bitmap) As News
            Dim n As News = New News
            n.Head = Head
            n.Body = Body
            n.BgPic = BgPic
            n.Wrestler = Nothing
            Return n
        End Function

    End Structure
    Public MyNews As List(Of News)
    Public SmallImages() As PictureBox
    Public SmallImagesFillers() As PictureBox
    Public EventLabels() As Label
    Dim CurrentTab As Integer = -1
    Private Sub NewsScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextPanel.Parent = PictureBox1
        TextPanel.BackColor = Color.Transparent

        If Not PictureBox1.Image Is Nothing Then
            PictureBox1.Image = TurnBlack(PictureBox1.Image)
        End If

        wrestler_image.Parent = PictureBox1
        '  For Each m As News In MyNews
        ' TurnBlack(m.BgPic)
        ' Next
    End Sub
    Public Sub LoadNews()
        If Not MyNews Is Nothing Then
            ReDim SmallImages(MyNews.Count - 1)
            ReDim SmallImagesFillers(MyNews.Count - 1)
            ReDim EventLabels(MyNews.Count - 1)
            For i = 0 To MyNews.Count - 1
                SmallImages(i) = New PictureBox
                SmallImagesFillers(i) = New PictureBox
                EventLabels(i) = New Label
                With SmallImages(i)
                    .SizeMode = PictureBoxSizeMode.Zoom
                    If i = 0 Then
                        .Left = ShortTemplate.Left
                    Else
                        .Left = SmallImages(i - 1).Right + 2
                    End If
                    .Size = ShortTemplate.Size
                    .Top = ShortTemplate.Top
                    .Parent = Panel1
                    .Image = MyNews(i).BgPic
                End With
                With SmallImagesFillers(i)
                    .Parent = SmallImages(i)
                    .Size = WTemplate.Size
                    .Top = WTemplate.Top
                    .SizeMode = PictureBoxSizeMode.Zoom
                    .Image = MData.imcontainer(MyNews(i).Wrestler.id).bigimage
                    .Left = CInt((SmallImages(i).Width - .Width) / 2)
                    .BackColor = Color.Transparent
                End With
                With EventLabels(i)
                    .BackColor = Color.Black 'TemplateLabel.BackColor
                    .ForeColor = Color.White 'TemplateLabel.ForeColor
                    .Top = TemplateLabel.Top
                    .AutoSize = False
                    .Parent = SmallImages(i)
                    .Left = 0
                    .Width = SmallImages(i).Width
                    .TextAlign = TemplateLabel.TextAlign
                    .Height = TemplateLabel.Height
                    .Text = MyNews(i).Head
                    SmallImages(i).Controls.Add(EventLabels(i))
                    .BringToFront()
                End With

                AddHandler SmallImages(i).Click, AddressOf SmallImage_Click
                AddHandler SmallImagesFillers(i).Click, AddressOf SmallImage_Click
                AddHandler EventLabels(i).Click, AddressOf SmallImage_Click
            Next
        End If
    End Sub
    Private Sub SmallImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim index As Integer = Array.IndexOf(SmallImages, sender)
        If index = -1 Then
            index = Array.IndexOf(SmallImagesFillers, sender)
        End If
        If index = -1 Then
            index = Array.IndexOf(EventLabels, sender)
        End If

        If Not index = CurrentTab Then
            CurrentTab = index
            ' PictureBox1.Image = MyNews(index).BgPic.Clone()

            PictureBox1.Image = TurnBlack(MyNews(index).BgPic)

            HeadLabel.Text = MyNews(index).Head
            BodyLabel.Text = MyNews(index).Body

            If Not MyNews(index).Wrestler Is Nothing Then
                '  MsgBox("!")
                wrestler_image.Image = MData.imcontainer(MyNews(index).Wrestler.id).bigimage
                wrestler_image.BringToFront()

            End If



            End If
    End Sub
    Private Function TurnBlack(ByVal bitm As Bitmap) As Bitmap
        Dim result As Bitmap = New Bitmap(bitm)
        Dim g As Graphics = Graphics.FromImage(result)
        Dim BlackLevel As Integer = -140 'idk wtf, but it works; Width: 203
        'Dim newColor As Color
        Dim BlackStep As Integer = 1
        Dim ImageStep As Integer = 1
        Dim Brush As SolidBrush = New SolidBrush(Color.FromArgb(255, 0, 0, 0))

        g.FillRectangle(Brush, 0, 0, BlackLevel, bitm.Height)
        Dim c As Integer = BlackLevel
        For i = 255 To 0 Step -1 * BlackStep
            Brush = New SolidBrush(Color.FromArgb(i, 0, 0, 0))
            g.FillRectangle(Brush, c, 0, c + ImageStep, bitm.Height)
            c += ImageStep
        Next

        g.Dispose()
        Return result
    End Function
    Private Sub HeadLabel_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadLabel.Resize
        BodyLabel.Top = HeadLabel.Bottom + 1
    End Sub


End Class
