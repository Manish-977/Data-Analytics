Module Module1

    Sub Main()
        Dim i As Integer
        'For i = 1 To 5
        '    Console.WriteLine("Welcome")
        'Next
        i = 1
        'While i <= 5
        '    Console.WriteLine("Welcome")
        '    i += 1
        'End While

        'Do While i <= 5
        '    Console.WriteLine("Welcome")
        '    i += 1
        'Loop

        'Do
        '    Console.WriteLine("Welcome")
        '    i += 1
        'Loop While i <= 5

        'Do Until i > 5
        '    Console.WriteLine("Welcome")
        '    i += 1
        'Loop

        Do
            Console.WriteLine("Welcome")
            i += 1
        Loop Until i > 5

        Console.ReadKey()
    End Sub

End Module
