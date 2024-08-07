Module Module1
    Sub sum(ByVal a As Integer, ByVal b As Integer)
        Dim s As Integer
        s = a + b
        Console.WriteLine("Sum is : {0}", s)
    End Sub
    Function sum1(ByVal a As Integer, ByVal b As Integer) As Integer 
        Dim s As Integer
        s = a + b
        'sum1 = s
        Return s
    End Function
    Function fact(ByVal n As Integer) As Integer
        If (n = 1 Or n = 0) Then
            Return 1
        Else
            Return n * fact(n - 1)
        End If
    End Function
    Sub Main()
        Dim n1, n2, n3 As Integer
        Console.Write("Enter n1 :")
        n1 = Console.ReadLine()
        Console.Write("Enter n2 :")
        n2 = Console.ReadLine()
        sum(n1, n2)
        n3 = n1 + n2 + sum1(n1, n2)
        ' n3 = sum1(n1, n2)
        Console.WriteLine("Sum is : {0}", n3)
        Console.WriteLine("Fact is : {0}", fact(n1))  fact(5)

        Console.ReadKey()
    End Sub

End Module
