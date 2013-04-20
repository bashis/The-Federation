Public Class PreviewScreen
    Public Sub Draw(ByVal Background As Image, ByVal WModelCollection As List(Of WModel), ByVal MatchName As String)
        Dim imageList As List(Of Bitmap) = New List(Of Bitmap)
        For i = 0 To WModelCollection.Count - 1
            imageList.Add(MData.imcontainer(MData.find_actual_id(WModelCollection(i), MData.SearchType.All)).bigimage)
            ' MsgBox(MData.find_actual_id(WModelCollection(i)))
        Next
        bg.BorderStyle = Windows.Forms.BorderStyle.None
        Me.BorderStyle = Windows.Forms.BorderStyle.None
        bg.Image = PreviewImage(Background, imageList, bg.Height, MatchName)
    End Sub

    Private Function PreviewImage(ByVal MyBackgroundImage As Bitmap, ByVal WrestlerImages As List(Of Bitmap), ByVal MaxWrestlerHeight As Integer, ByVal MatchName As String) As Image
        Const BorderDistantion As Integer = 10
        Const MaxWrestlerDistantion As Integer = 40

        Dim thumb As Bitmap = MyBackgroundImage.Clone
        Dim g As Graphics = Graphics.FromImage(thumb)

        Dim obj(WrestlerImages.Count - 1) As Graphics
        For i = 0 To WrestlerImages.Count - 1
            WrestlerImages(i) = Convert(WrestlerImages(i), MaxWrestlerHeight, 0)
            obj(i) = Graphics.FromImage(WrestlerImages(i))
        Next
        Dim Separator As Integer

        Select Case WrestlerImages.Count
            Case 0
                Separator = 0
            Case 1
                Separator = 0
            Case Else
                Separator = Math.Min(MaxWrestlerDistantion, CInt((thumb.Width - 2 * BorderDistantion - ImagesWidth(WrestlerImages)) / (WrestlerImages.Count - 1)))
        End Select

        For i = 0 To WrestlerImages.Count - 1
            Dim addw As Integer
            Dim firstLeft As Integer = Math.Max(BorderDistantion, CInt(thumb.Width - ImagesWidth(WrestlerImages) - (WrestlerImages.Count - 1) * Separator) / 2)
            If i = 0 Then
                g.DrawImage(WrestlerImages(i), New Rectangle(firstLeft, thumb.Height - WrestlerImages(i).Height, WrestlerImages(i).Width, WrestlerImages(i).Height))
            Else
                g.DrawImage(WrestlerImages(i), New Rectangle(firstLeft + Separator * i + addw, thumb.Height - WrestlerImages(i).Height, WrestlerImages(i).Width, WrestlerImages(i).Height))
            End If
            addw += WrestlerImages(i).Width
        Next
        Dim r As New Rectangle(10, thumb.Height - 50, thumb.Width - 20, 40)
        g.FillRectangle(Brushes.DarkRed, r)
        g.DrawRectangle(Pens.Black, r)



        Using myFont As New Font("Courier New", 20, FontStyle.Bold)
            TextRenderer.DrawText(g, MatchName, myFont, r, _
                                  Color.White, Color.Empty, _
                                  TextFormatFlags.HorizontalCenter)
        End Using

        '   g.DrawString(MatchName, New Font("Courier New", 25, FontStyle.Bold), Brushes.White, New RectangleF(10, thumb.Height - 50, thumb.Width - 20, 40), StringFormat.GenericDefault)
        ' g.DrawImage(images(0), New Rectangle(10, 10, 1000, 1000))
        ' g.DrawImage(images(1), New Rectangle(500, 10, 1000, 1000))
        ' g.DrawImage(images(2), New Rectangle(1000, 10, 1000, 1000))

        g.Dispose()
        Return thumb
    End Function
    Private Function ImagesWidth(ByVal img As List(Of Bitmap)) As Integer
        Dim result As Integer = 0
        For i = 0 To img.Count - 1
            result += img(i).Width
        Next
        Return result
    End Function
    Private Function Convert(ByVal OldImage As Image, ByVal newH As Integer, ByVal newW As Integer) As Image
        If Not (newH = 0 And newW = 0) Then


            If newH = 0 Then
                newH = CInt(OldImage.Height * newW / OldImage.Width)
            ElseIf newW = 0 Then
                newW = CInt(OldImage.Width * newH / OldImage.Height)
            End If

            Dim thumb As New Bitmap(newW, newH)



            thumb.MakeTransparent(thumb.GetPixel(0, 0))

            Dim g As Graphics = Graphics.FromImage(thumb)

            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(OldImage, New Rectangle(0, 0, newW, newH), New Rectangle(0, 0, OldImage.Width, OldImage.Height), GraphicsUnit.Pixel)
            g.Dispose()

            Return thumb
        Else : Return OldImage
        End If
    End Function

    Private Sub bg_Click(sender As Object, e As EventArgs) Handles bg.Click

    End Sub
End Class
