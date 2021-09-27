Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Do Until n = 0
            If n >= 489 Then
                Console.Write(10 & " ")
                n -= 489
            End If
            For i = 8 To 0 Step -1
                If 2 ^ i <= n Then
                    n -= 2 ^ i
                    Console.Write(i + 1 & " ")
                End If
            Next
            Console.WriteLine()
            n = LineInput(1)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
