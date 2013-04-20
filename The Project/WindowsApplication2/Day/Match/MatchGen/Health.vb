Public Class Health
    Public ParentWrestler As WModel
    Public Enum Organ
        Head
        Legs
        Body
        Arms
    End Enum

    Private _head As Integer = BasicStats.MaxHealth
    Public Property Head As Integer
        Get
            Return _head
        End Get
        Set(value As Integer)
            _head = value
        End Set
    End Property
    Private _legs As Integer = BasicStats.MaxHealth
    Public Property Legs As Integer
        Get
            Return _legs
        End Get
        Set(value As Integer)
            _legs = value
        End Set
    End Property
    Private _body As Integer = BasicStats.MaxHealth
    Public Property Body As Integer
        Get
            Return _body
        End Get
        Set(value As Integer)
            _body = value
        End Set
    End Property
    Private _arms As Integer = BasicStats.MaxHealth
    Public Property Arms As Integer
        Get
            Return _arms
        End Get
        Set(value As Integer)
            _arms = value
        End Set
    End Property

    Public Sub New(ByVal ParentWrestler As WModel)
        Me.ParentWrestler = ParentWrestler
    End Sub
End Class
