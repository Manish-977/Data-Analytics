Module Module1

    Sub Main()
        Dim num(5), i, j, temp As Integer
        For i = 0 To 5
            Console.Write("Enter val")
            num(i) = Console.ReadLine()
        Next

        For i = 0 To 5
            For j = i + 1 To 5
                If num(i) < num(j) Then
                    temp = num(i)
                    num(i) = num(j)
                    num(j) = temp
                End If
            Next

        Next
        For i = 0 To 5
            Console.WriteLine(num(i))

        Next
        Console.ReadKey()
    End Sub

End Module
