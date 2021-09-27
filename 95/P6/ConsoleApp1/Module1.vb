Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Do Until n = 0
            Dim Str() As String = Split(LineInput(1), " ")
            Dim P As Integer = 0
            For i = 0 To n - 1
                P += Val(Str(i))
            Next
            P = P / n
            Dim Ans As Integer = 0
            For i = 0 To n - 1
                If Val(Str(i)) < P Then
                    Ans += P - Val(Str(i))
                End If
            Next
            Console.WriteLine(Ans)
            n = LineInput(1)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
