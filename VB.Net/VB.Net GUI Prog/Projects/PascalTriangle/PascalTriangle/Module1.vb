Module Module1

    Sub Main()
        Dim rows, coef, space, i, j As Integer
        coef = 1
        Console.Write("Enter the number of rows: ")
        rows = Console.ReadLine()
        For i = 0 To rows
            For space = 1 To rows - i
                Console.Write("  ")
            Next space
            For j = 0 To i
                If (j = 0 Or i = 0) Then
                    coef = 1
                Else
                    coef = coef * (i - j + 1) / j
                End If
                Console.Write("   {0}", coef)
            Next j

            Console.WriteLine()
        Next i
        Console.ReadKey()
    End Sub

End Module
