Module Module1
    Sub number(ByVal n As Integer)
        n = 10
    End Sub
    Sub number1(ByRef n As Integer)
        n = 10
    End Sub
    Sub Main()
        Dim num As Integer
        num = 1
        number(num)
        Console.WriteLine(num)
        number1(num)
        Console.WriteLine(num)
        Console.ReadKey()
    End Sub

End Module
