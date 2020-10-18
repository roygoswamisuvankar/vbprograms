'Question: 3: write a program to check weather given number is positive or not.
Module Module1

    Sub Main()
        Dim a As Integer
        Console.WriteLine("Enter a number: ")
        a = Console.ReadLine()
        If (a > 0) Then
            Console.WriteLine("This number is positive integer")
            Console.ReadLine()
        ElseIf (a = 0) Then
            Console.WriteLine("This number is not positive not negative, it's zero")
            Console.ReadLine()
        Else
            Console.WriteLine("This number is negative integer")
            Console.ReadLine()
        End If
    End Sub

End Module
