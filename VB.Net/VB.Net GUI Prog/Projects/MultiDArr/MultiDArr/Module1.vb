Module Module1

    Sub Main()
        Dim num(3, 4) As Integer
        Dim i, j As Integer
        For i = 0 To 3
            For j = 0 To 4
                Console.Write("Enter val")
                num(i, j) = Console.ReadLine()
            Next
        Next
        For i = 0 To 3
            For j = 0 To 4
                Console.Write("  {0}", num(i, j))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
