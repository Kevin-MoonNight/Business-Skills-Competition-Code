Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), " ")
        Do Until Str(0) = "0" And Str(1) = "0"
            Dim n As Integer = 0
            For i = Val(Str(0)) To Val(Str(1))
                If i Mod 2 = 0 Or i Mod 3 = 0 Or i Mod 5 = 0 Then
                    n += 1
                End If
            Next
            Console.WriteLine(n)
            Str = Split(LineInput(1), " ")
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
