Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.Write("Enter First No.")
        a = Console.ReadLine()
        Console.Write("Enter Second No.")
        b = Console.ReadLine()
        If a > b Then
            Console.WriteLine("First no. is max")
        Else
            Console.WriteLine("Second no. is max")
        End If
        Console.ReadKey()

    End Sub

End Module
