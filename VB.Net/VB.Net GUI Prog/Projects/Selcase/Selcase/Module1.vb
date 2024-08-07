Module Module1

    Sub Main()
        Dim Days As String
        Console.WriteLine("Enter day is sort form")
        Days = Console.ReadLine()
        Select Case Days
            'Case 1, 5, 6 To 10, 12

            Case "Mon"
                Console.WriteLine(" Today is Monday")
            Case "Tue"
                Console.WriteLine(" Today is Tuesday")
            Case "Wed"
                Console.WriteLine("Today is Wednesday")
            Case "Thurs"
                Console.WriteLine("Today is Thursday")
            Case "Fri"
                Console.WriteLine("Today is Friday")
            Case "Sat"
                Console.WriteLine("Today is Saturday")
            Case "Sun"
                Console.WriteLine("Today is Sunday")
            Case Else
                Console.WriteLine(" You have typed Something wrong")
        End Select
        Console.ReadKey()
    End Sub

End Module
