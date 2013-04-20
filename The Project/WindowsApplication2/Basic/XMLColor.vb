Imports System.Xml.Serialization
Public Class XmlColor
    Private color_ As Color = Color.Black

    Public Sub New()
    End Sub
    Public Sub New(c As Color)
        color_ = c
    End Sub


    Public Function ToColor() As Color
        Return color_
    End Function

    Public Sub FromColor(c As Color)
        color_ = c
    End Sub

    Public Shared Widening Operator CType(x As XmlColor) As Color
        Return x.ToColor()
    End Operator

    Public Shared Widening Operator CType(c As Color) As XmlColor
        Return New XmlColor(c)
    End Operator

    <XmlAttribute> _
    Public Property Web() As String
        Get
            Return ColorTranslator.ToHtml(color_)
        End Get
        Set(value As String)
            Try
                If Alpha = &HFF Then
                    ' preserve named color value if possible
                    color_ = ColorTranslator.FromHtml(value)
                Else
                    color_ = Color.FromArgb(Alpha, ColorTranslator.FromHtml(value))
                End If
            Catch generatedExceptionName As Exception
                color_ = Color.Black
            End Try
        End Set
    End Property

    <XmlAttribute> _
    Public Property Alpha() As Byte
        Get
            Return color_.A
        End Get
        Set(value As Byte)
            If value <> color_.A Then
                ' avoid hammering named color if no alpha change
                color_ = Color.FromArgb(value, color_)
            End If
        End Set
    End Property

    Public Function ShouldSerializeAlpha() As Boolean
        Return Alpha < &HFF
    End Function
End Class
