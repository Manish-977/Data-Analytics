Module Module1

    Sub Main()
        Dim roll As Integer
        Dim sname, grade As String
        Dim m1, m2, m3, tot, avg As Single
        Console.Write("Enter Roll")
        roll = Console.ReadLine()
        Console.Write("Enter Name")
        sname = Console.ReadLine()
        Console.Write("Enter Marks of Sub1")
        m1 = Console.ReadLine()
        Console.Write("Enter Marks of Sub2")
        m2 = Console.ReadLine()
        Console.Write("Enter Marks of Sub3")
        m3 = Console.ReadLine()
        tot = m1 + m2 + m3
        avg = tot / 3
        If avg >= 85 Then
            grade = "A"
        ElseIf avg >= 70 Then
            grade = "B"
        ElseIf avg >= 50 Then
            grade = "C"
        ElseIf avg >= 40 Then
            grade = "D"
        Else
            grade = "F"
        End If
        Console.WriteLine("Roll is {0}", roll)
        Console.WriteLine("Name is {0}", sname)
        Console.WriteLine("Total is {0}", tot)
        Console.WriteLine("Avg is {0}", avg)
        Console.WriteLine("Grade is {0}", grade)
        Console.WriteLine()
        Console.WriteLine("Student details Roll - {0} Name - {1} Total - {2} Avg - {3} Grade - {4}", roll, sname, tot, avg, grade)
        Console.ReadKey()

    End Sub

End Module
