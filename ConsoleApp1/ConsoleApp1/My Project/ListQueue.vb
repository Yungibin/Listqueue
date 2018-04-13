Public Class ListQueue

    Private front As QueueNode
    Private rear As QueueNode

    Public Sub New()
        front = Nothing
        rear = Nothing
    End Sub

    Public Function isEmpty() As Boolean
        Return front Is Nothing
    End Function

    Public Sub addNode(item As Object)
        Dim node As QueueNode = New QueueNode(item)

        If isEmpty() Then
            front = node
            rear = node
        Else
            rear.NextItem = node
            rear = node
        End If
    End Sub

    Public Function deNode() As Object
        Dim item As Object
        If isEmpty() Then
            Console.WriteLine("nothing")
        Else
            item = front.Item
            front = front.NextItem
            If front Is Nothing Then
                rear = Nothing
            End If
        End If
        Return item
    End Function

    Public Sub deleteNode()
        If isEmpty() Then
            Console.WriteLine("nothing")
        Else
            front = front.NextItem
            If front Is Nothing Then
                rear = Nothing
            End If
        End If
    End Sub

    Public Function peekNode() As Object
        If isEmpty() Then
            Console.WriteLine("nothing")
            Return 0
        Else
            Return front.Item
        End If
    End Function

    Public Sub printNode()
        If isEmpty() Then
            Console.WriteLine("nothing")
        Else
            Console.WriteLine("***** You have *****")
            Dim tempnode As QueueNode = front
            While tempnode IsNot Nothing
                Console.WriteLine(tempnode.Item)
                tempnode = tempnode.NextItem
            End While
        End If
    End Sub

End Class
