Module Module1

    Sub Main()
        Dim i, j As Integer
        For i = 1 To 5
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine("")
        Next
        Console.ReadKey()
    End Sub

End Module
