Module Module1

    Sub Main()
        Dim num() As Integer
        Dim n, n1, i As Integer
        Console.Write("Enter no. of elements")
        n = Console.ReadLine()
        ReDim num(n)
        For i = 0 To n
            Console.Write("Enter no.")
            num(i) = Console.ReadLine()
        Next
        For i = 0 To n
            Console.WriteLine(num(i))
        Next

        Console.Write("Enter no. of more elements")
        n1 = Console.ReadLine()
        ReDim Preserve num(n + n1)
        For i = n + 1 To n + n1
            Console.Write("Enter no.")
            num(i) = Console.ReadLine()
        Next
        For i = 0 To n + n1
            Console.WriteLine(num(i))
        Next
        Console.ReadKey()
    End Sub

End Module
