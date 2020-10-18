'Question 1: Write a program to accept two integers and check weather they are equal or not.
Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.WriteLine("Enter an integer: ")
        a = Console.ReadLine()
        Console.WriteLine("Enter another integer: ")
        b = Console.ReadLine()
        If (a = b) Then
            Console.WriteLine("This two integer is equal")
            Console.ReadLine()
        ElseIf (a > b) Then
            Console.WriteLine("this two integer is not equal, 1st integer is bigger thand 2nd integer")
            Console.ReadLine()
        Else
            Console.WriteLine("this two integer is not equal, 2nd integer is bigger than 1st integer")
            Console.ReadLine()
        End If
    End Sub

End Module
