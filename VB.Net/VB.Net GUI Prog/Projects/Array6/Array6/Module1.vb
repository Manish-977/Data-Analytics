Module Module1

    Sub Main()
        Dim num(5), rev(5), i, j As Integer
        j = 0
        For i = 0 To 5
            Console.Write("Enter val")
            num(i) = Console.ReadLine()
        Next

        For i = 5 To 0 Step -1
            Console.WriteLine(num(i))
        Next
        'For i = 5 To 0 Step -1
        '    rev(j) = num(i)
        '    j += 1
        'Next

        'For i = 0 To 5
        '    Console.WriteLine(rev(i))

        'Next
        Console.ReadKey()
    End Sub

End Module
