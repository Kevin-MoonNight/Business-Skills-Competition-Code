Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim a(3), b(3) As Integer
        '輸入
        For i = 1 To 3
            Dim Str() As String = Split(LineInput(1), " ")
            a(i) = Val(Str(0)) : b(i) = Val(Str(1))
        Next
        '計算
        For i = 2 To 1 Step -1
            a(i) = a(i) * b(i + 1)
            b(i) = b(i) * b(i + 1) + a(i + 1)
        Next
        Console.WriteLine(a(1) & " " & b(1))
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
