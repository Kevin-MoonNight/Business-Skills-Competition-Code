Module Module1

    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            Dim n As Integer = 0
            For i = 1 To Val(Str(0))
                If Val(Str(0)) Mod i = 0 And i Mod Val(Str(1)) = 0 Then
                    n += 1

                End If
            Next
            Console.WriteLine(n)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
