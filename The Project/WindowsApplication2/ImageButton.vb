Public Class ImageButton
    Inherits PictureBox
    Dim _PressImage As Image
    Public Property PressImage As Image
        Get
            Return _PressImage
        End Get
        Set(value As Image)
            _PressImage = value
        End Set
    End Property
    Dim _StaticImage As Image
    Public Property StaticImage As Image
        Get
            Return _StaticImage
        End Get
        Set(value As Image)
            _StaticImage = value
        End Set
    End Property
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        Me.Image = StaticImage
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Me.Image = PressImage
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        Me.Image = StaticImage
    End Sub
    Public Sub New()
        Me.Image = StaticImage
    End Sub
End Class
