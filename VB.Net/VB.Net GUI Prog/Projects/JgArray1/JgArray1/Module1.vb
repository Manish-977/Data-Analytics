Module Module1

    Sub Main()
        Dim i, j As Integer
        Dim num As Integer()() = New Integer(2)() {}
        num(0) = New Integer() {4, 5}
        num(1) = New Integer() {14, 15}
        num(2) = New Integer() {24, 25}
        For i = 0 To 2
            For j = 0 To 1
                Console.Write(" {0}", num(i)(j))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
