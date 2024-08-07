Module Module1

    Sub Main()
        Dim num() As Integer
        Dim n, i As Integer
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
        Console.ReadKey()
    End Sub

End Module
