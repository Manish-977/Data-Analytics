Module Module1

    Sub Main()
        Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}
        Dim temp As Integer() = list
        Dim i As Integer
        Console.Write("Original Array: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        ' reverse the array
        Array.Reverse(temp)
        Console.Write("Reversed Array: ")
        For Each i In temp
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        'sort the array
        Array.Sort(list)
        Console.Write("Sorted Array: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()
    End Sub




End Module
