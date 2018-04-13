Public Class QueueNode

    Private mItem As Object
    Private mNext As Object

    Public Sub New()
        mNext = Nothing
    End Sub

    Public Sub New(ByVal item As Object)
        mItem = item
        mNext = Nothing
    End Sub

    Public Property Item() As Object
        Get
            Return mItem
        End Get
        Set(value As Object)
            mItem = value
        End Set
    End Property

    Public Property NextItem As Object
        Get
            Return mNext
        End Get
        Set(value As Object)
            mNext = value
        End Set
    End Property

End Class
