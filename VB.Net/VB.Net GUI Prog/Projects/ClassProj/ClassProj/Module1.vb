Module Module1
    Class student
        Private roll As Integer
        Private sname As String
        Private fee As Double
        Public Sub New()
            Console.WriteLine("Constructor call")
            roll = 2
            sname = "Aman"
            fee = 4000
        End Sub
        Public Sub New(ByVal r1 As Integer, ByVal nm As String, ByVal f1 As Double)
            Console.WriteLine("Constructor call")
            roll = r1
            sname = nm
            fee = f1
        End Sub
        Public Sub getdata(ByVal r As Integer, ByVal nm As String, ByVal f As Double)
            roll = r
            sname = nm
            fee = f
        End Sub
        Public Sub dispdata()
            Console.WriteLine("Roll : {0}  Name : {1}  Fee : {2}", roll, sname, fee)
        End Sub
        Protected Overrides Sub Finalize()
            Console.WriteLine("Object deleted")
            Console.ReadKey()
        End Sub

        Shared Sub Main()
            Dim s As student = New student()
            s.dispdata()
            Dim s1 As student = New student(6, "Vikas", 7000)
            s1.dispdata()
            Dim roll1 As Integer
            Dim name1 As String
            Dim fee1 As Double
            Console.Write("Enter roll")
            roll1 = Console.ReadLine()
            Console.Write("Enter name")
            name1 = Console.ReadLine()
            Console.Write("Enter Fee")
            fee1 = Console.ReadLine()
            Dim s2 As student = New student(roll1, name1, fee1)
            s2.dispdata()
            ''s.getdata(10, "Rajesh", 6000)
            's.getdata(roll1, name1, fee1)
            's.dispdata()
            Console.ReadKey()
        End Sub
    End Class
End Module
