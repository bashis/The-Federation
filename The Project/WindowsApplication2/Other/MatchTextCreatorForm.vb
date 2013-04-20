Public Class MatchTextCreatorForm
    Shared Tree As TreeElement
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TextTree As TreeElement = New TreeElement
        TextTree.Initialize()

        TextTree.AddElement()
        TextTree.SubElements(1).Value = "Empty Element"

        TextTree.AddElement()
        TextTree.SubElements(2).Value = "Empty Element"

        TextTree.SubElements(1).Initialize()
        TextTree.SubElements(1).AddElement()
        TextTree.SubElements(1).SubElements(1).Value = "FUCK"



        FillButtons(TextTree.SubElements)


    End Sub
    Dim Buttons() As Button
    Dim Temp() As TreeElement
    Public Sub FillButtons(ByVal Elements As TreeElement())
        If Not Buttons Is Nothing Then
            For i = 0 To Buttons.Length - 1

                Me.Controls.Remove(Buttons(i))
                Buttons(i) = Nothing
            Next
        End If
        If Not Elements Is Nothing Then
            ReDim Temp(Elements.Length - 1)
            For i = 0 To Elements.Length - 1
                Temp(i) = Elements(i)
            Next

            If Elements.Length > 1 Then
                ReDim Buttons(Elements.Length - 2)
                For i = 1 To Elements.Length - 1
                    Buttons(i - 1) = New Button
                    With Buttons(i - 1)
                        .Height = newElement.Height
                        .Width = newElement.Width
                        .Text = "Variant " & i.ToString
                        .Left = newElement.Left
                        .Top = newElement.Top + (newElement.Height + 2) * i
                        Me.Controls.Add(Buttons(i - 1))
                        AddHandler .Click, AddressOf Clicking 'FillButtons(Elements(i).SubElements)
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Clicking(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer = 0
       
        index = Array.IndexOf(Buttons, sender)
        Label1.Text = Temp(index + 1).Value
        FillButtons(Temp(index + 1).SubElements)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newElement.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Dim cnt As Integer
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class