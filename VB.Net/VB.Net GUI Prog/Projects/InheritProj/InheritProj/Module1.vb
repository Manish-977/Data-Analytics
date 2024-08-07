Module Module1
    Class student
        Private roll As Integer
        Private sname As String
        Private fee As Double
        Public Sub getdata(ByVal r As Integer, ByVal nm As String, ByVal f As Double)
            roll = r
            sname = nm
            fee = f
        End Sub
        Public Sub dispdata()
            Console.WriteLine("Roll : {0}  Name : {1}  Fee : {2}", roll, sname, fee)
        End Sub
    End Class
    Class marks : Inherits student
        Private m1 As Integer
        Private m2 As Integer
        Public Sub getmarks(ByVal n1 As Integer, ByVal n2 As Integer)
            m1 = n1
            m2 = n2
        End Sub
        Public Sub dispmarks()
            Console.WriteLine("Marks1 : {0} Marks2 : {1}", m1, m2)
        End Sub
    End Class

    Sub Main()
        Dim m As marks = New marks()
        Dim roll1 As Integer
        Dim name1 As String
        Dim fee1 As Double
        Dim mk1, mk2 As Integer
        Console.Write("Enter roll")
        roll1 = Console.ReadLine()
        Console.Write("Enter name")
        name1 = Console.ReadLine()
        Console.Write("Enter Fee")
        fee1 = Console.ReadLine()
        Console.Write("Enter m1")
        mk1 = Console.ReadLine()
        Console.Write("Enter m2")
        mk2 = Console.ReadLine()
        m.getdata(roll1, name1, fee1)
        m.getmarks(mk1, mk2)
        m.dispdata()
        m.dispmarks()
        Console.ReadKey()
    End Sub

End Module
