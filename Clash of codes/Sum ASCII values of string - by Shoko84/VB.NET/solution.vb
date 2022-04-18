Module Solution
    Sub Main ()
        
        Dim S as String
        S = Console.ReadLine()

        Dim temp as Integer
        For Each c As Char in S        
            temp += Convert.ToByte(c)
        Next
        Console.WriteLine(temp)
        
    End Sub
End Module