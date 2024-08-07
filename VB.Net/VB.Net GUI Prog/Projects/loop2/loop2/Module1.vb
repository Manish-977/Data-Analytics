Module Module1

    Sub Main()
        Dim m, n, i As Integer
        Console.Write("Enter start value")
        m = Console.ReadLine()
        Console.Write("Enter end value")
        n = Console.ReadLine()
        For m = m To n
            For i = 1 To 10
                Console.WriteLine("{0} x {1} = {2}", m, i, m * i)
            Next
            Console.Write("Press Any key to continue.......")
            Console.ReadKey()
        Next

    End Sub

End Module
