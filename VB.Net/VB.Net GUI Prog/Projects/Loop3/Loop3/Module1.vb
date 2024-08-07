Module Module1

    Sub Main()
        Dim n, i, j, s As Integer
        Console.Write("Enter no. of lines")
        n = Console.ReadLine() 3
        For i = 1 To n
            For s = n - i To 1 Step -1
                Console.Write(" ")
            Next
            For j = 1 To i * 2 - 1
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
