'write a program to check the age of a candidate and determine weather it is eligible for vote or not

Module Module1

    Sub Main()
        Dim age As Integer
        Console.WriteLine("Enter person's age: ")
        age = Console.ReadLine()
        If (age >= 18) Then
            Console.WriteLine("He/She is eligable for vote")
            Console.ReadLine()
        Else
            Console.WriteLine("He/She is not eligable for vote")
            Console.ReadLine()
        End If
    End Sub

End Module
