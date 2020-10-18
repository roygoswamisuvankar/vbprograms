'Question: 4: write a program to check weather given year is leap-year or not.
Module Module1

    Sub Main()
        Dim year As Integer
        Console.WriteLine("Enter a year:")
        year = Console.ReadLine()
        If (year Mod 4 = 0 And Not year Mod 100 = 0 Or year Mod 400 = 0) Then
            Console.WriteLine("This year is leap-year")
            Console.ReadLine()
        Else
            Console.WriteLine("This year is not leap-year")
            Console.ReadLine()
        End If
    End Sub

End Module


 
 
 

