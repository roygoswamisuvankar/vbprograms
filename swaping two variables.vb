'using 3rd variable

Module Module1

    Sub Main()
        Dim a, b, tmp As Integer
        Console.WriteLine("Enter A: ")
        a = Console.ReadLine()
        Console.WriteLine("Enter B: ")
        b = Console.ReadLine()
        Console.WriteLine("Before swaping,")
        Console.WriteLine("A : " & a)
        Console.WriteLine("B : " & b)
        tmp = a
        a = b
        b = tmp
        Console.WriteLine("After Swapping: ")
        Console.WriteLine("A : " & a)
        Console.WriteLine("B : " & b)
        Console.ReadLine()
    End Sub

End Module
