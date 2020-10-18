'Question 2: write a program to check weather the given number is odd or even
Module Module1

    Sub Main()
        Dim a As Integer
        Console.WriteLine("Enter a number: ")
        a = Console.ReadLine()
        If (a Mod 2 = 0) Then
            Console.WriteLine("This number is even")
            Console.ReadLine()
        Else
            Console.WriteLine("this number is odd")
            Console.ReadLine()
        End If
    End Sub

End Module
