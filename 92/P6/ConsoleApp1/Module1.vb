Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim A(3, 3), B(3, 3), C(2, 2) As Integer
        '輸入
        Dim Str As String = LineInput(1)
        Dim Txt() As String = Split(Str, " ")
        'A
        For i = 0 To 2
            A(1, i + 1) = Val(Txt(i))
        Next
        Str = LineInput(1)
        Txt = Split(Str, " ")
        For i = 0 To 2
            A(2, i + 1) = Val(Txt(i))
        Next
        'B
        Str = LineInput(1) : Str = LineInput(1)
        Txt = Split(Str, " ")
        For i = 0 To 1
            B(1, i + 1) = Val(Txt(i))
        Next
        Str = LineInput(1)
        Txt = Split(Str, " ")
        For i = 0 To 1
            B(2, i + 1) = Val(Txt(i))
        Next
        Str = LineInput(1)
        Txt = Split(Str, " ")
        For i = 0 To 1
            B(3, i + 1) = Val(Txt(i))
        Next
        '計算
        For m = 1 To 2
            For p = 1 To 2
                For n = 1 To 3
                    C(m, p) += A(m, n) * B(n, p)
                Next
            Next
        Next
        '輸出
        For m = 1 To 2
            For p = 1 To 2
                Console.Write(C(m, p) & " ")
            Next
            Console.WriteLine()
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
