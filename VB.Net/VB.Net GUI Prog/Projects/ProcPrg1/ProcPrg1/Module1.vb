Module Module1
    Sub sum(ByVal a As Integer, ByVal b As Integer, Optional ByVal c As Integer = 5)
        Dim s As Integer
        s = a + b + c
        Console.WriteLine("Sum is :{0}", s)
    End Sub
    Sub Main()
        sum(8, 6)
        sum(14, 2)
        sum(5, 6)
        sum(5, 6, 7)
        Console.ReadKey()
    End Sub

End Module
