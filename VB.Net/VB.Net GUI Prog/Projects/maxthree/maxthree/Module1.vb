Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.Write("Enter First No.")
        a = Console.ReadLine()
        Console.Write("Enter Second No.")
        b = Console.ReadLine()
        Console.Write("Enter Third No.")
        c = Console.ReadLine()
        If a > b Then
            If a > c Then
                Console.WriteLine("First no. is max")
            Else
                Console.WriteLine("Third no. is max")
            End If
        Else
            If b > c Then
                Console.WriteLine("Second no. is max")
            Else
                Console.WriteLine("Third no. is max")
            End If
        End If
        Console.ReadKey()

    End Sub

End Module
