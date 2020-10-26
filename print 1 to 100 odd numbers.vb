Module Module1

    Sub Main()
        Dim num As Integer
        num = 1
        While (num <= 100)
            If (num Mod 2 <> 0) Then
                Console.WriteLine(num)
            End If
            num = num + 1
        End While
        Console.ReadLine()
    End Sub

End Module
