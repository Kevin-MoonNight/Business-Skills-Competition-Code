Module Module1
    Sub Main()
        Dim n As Integer = -1
        For i = 1 To 9
            For j = 1 To 9
                If j >= 5 - n And j <= n + 5 And i <> 1 Then
                    Console.Write("  " & vbTab)
                Else
                    Console.Write(i * j & vbTab)
                End If
            Next
            If i >= 5 Then
                n -= 1
            Else
                n += 1
            End If
            Console.WriteLine()
        Next
        Console.ReadKey()
        Call Main()
    End Sub
End Module
