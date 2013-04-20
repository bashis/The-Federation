Public Class TreeElement
    Public Value As String
    Public Shared Counter As Integer
    Public SubElements() As TreeElement
    Public LatestIndex As Integer

    Dim depth As Integer
    Public Sub Initialize()
        ReDim SubElements(0)
        SubElements(0) = Nothing
    End Sub

    Public Function NumberOfSubElements() As Integer 'Including empty element
        Return SubElements.Length

    End Function

    Public Sub AddElement()
        ReDim Preserve SubElements(SubElements.Length)
        SubElements(SubElements.Length - 1) = New TreeElement
        Counter += 1

    End Sub

    Public Sub RemoveElement(ByVal index As Integer)
        For i = index To UBound(SubElements) - 1
            SubElements(i) = SubElements(i + 1)
        Next i
        ReDim Preserve SubElements(UBound(SubElements) - 1)
    End Sub
    Dim max As Integer
    Public Function GetDepth(ByVal tree As TreeElement) As Integer
        If tree.SubElements Is Nothing Then
            Return 0
        End If

        max = 0
        Dim depth As Integer

        For i = 0 To tree.SubElements.Length - 1
            GetDepth(tree.SubElements(i))
            depth += 1
        Next

        Return depth

    End Function


End Class
