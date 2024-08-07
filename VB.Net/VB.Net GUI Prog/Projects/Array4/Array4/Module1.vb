Module Module1

    Sub Main()
        Dim num(5), i, j, temp As Integer
        For i = 0 To 5
            Console.Write("Enter val")
            num(i) = Console.ReadLine()
        Next
       
        For i = 0 To 2
            For j = i + 1 To 2
                If num(i) > num(j) Then
                    temp = num(i)
                    num(i) = num(j)
                    num(j) = temp
                End If
            Next

        Next
        Console.WriteLine("MAx is {0}", num(2))
        Console.WriteLine("Min is {0}", num(0))
        Console.ReadKey()
    End Sub

End Module
