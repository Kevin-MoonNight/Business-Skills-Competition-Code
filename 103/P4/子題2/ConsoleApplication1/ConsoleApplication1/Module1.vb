Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For i = 1 To P
            Dim m, k, v As Integer
            Input(1, m) : Input(1, k) : Input(1, v)
            '輸入
            Dim d(P) As String
            For j = 0 To m - 1
                Input(1, d(j))
            Next











        Next
        FileClose()

        Call Main()
    End Sub
End Module
