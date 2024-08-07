Module Module1

    Sub Main()
        Dim num(5), i, max, min As Integer
        For i = 0 To 5
            Console.Write("Enter val")
            num(i) = Console.ReadLine()
        Next
        max = num(0)
        min = num(0)
        For i = 0 To 5
            If num(i) > max Then
                max = num(i)
            ElseIf num(i) < min Then
                min = num(i)
            End If

        Next
        Console.WriteLine("MAx is {0}", max)
        Console.WriteLine("Min is {0}", min)
        Console.ReadKey()
    End Sub

End Module
