'write a program to find the biigest number between three numbers
Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.WriteLine("Enter A: ")
        a = Console.ReadLine()
        Console.WriteLine("Enter B: ")
        b = Console.ReadLine()
        Console.WriteLine("Enter C: ")
        c = Console.ReadLine()
        If (a > b And a > c) Then
            Console.WriteLine("A is bigger " & a)
            Console.ReadLine()
        ElseIf (b > a And b > c) Then
            Console.WriteLine("B is biiger " & b)
            Console.ReadLine()
        Else
            Console.WriteLine("C is bigger " & c)
            Console.ReadLine()
        End If
    End Sub

End Module
