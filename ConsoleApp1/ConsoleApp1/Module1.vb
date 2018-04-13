Module Module1

    Sub Main()
        Dim lqueue As ListQueue = New ListQueue()

        lqueue.addNode("A")
        lqueue.printNode()

        lqueue.addNode("B")
        lqueue.printNode()

        lqueue.addNode("C")
        lqueue.printNode()

        Console.WriteLine(lqueue.deNode())

        lqueue.deleteNode()
        lqueue.printNode()

        Console.WriteLine(lqueue.deNode())
    End Sub

End Module
