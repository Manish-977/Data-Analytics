Module Module1

    Sub Main()
        Dim num(5), i As Integer
        For i = 0 To 5
            Console.Write("Enter val")
            num(i) = Console.ReadLine()
        Next
        For i = 0 To 5
            Console.WriteLine(num(i))

        Next
        Console.ReadKey()
    End Sub

End Module
