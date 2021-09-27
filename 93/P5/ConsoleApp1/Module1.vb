Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            Dim Txt(2), Ans As String
            Txt(1) = Str(0) : Txt(2) = Str(1)
            Txt(1) = Mid(Txt(1), 1, 3)
            Ans = Txt(1)
            For i = 1 To Len(Txt(2))
                If InStr(Txt(1), Mid(Txt(2), i, 1)) = 0 Then
                    Ans &= Mid(Txt(2), i, 1)
                End If
                If Len(Ans) = 8 Then
                    Exit For
                End If
            Next
            Console.WriteLine(Ans)
        Loop
            FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
