Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer
        Input(1, N)
        Dim d(N * 4) As String
        For i = 1 To N * 4
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To N
            Dim num(4) As Integer
            '數字帶進num裡
            num(1) = d(((i - 1) * 4) + 1) : num(2) = d(((i - 1) * 4) + 2) : num(3) = d(((i - 1) * 4) + 3) : num(4) = d(((i - 1) * 4) + 4)
            '暴力解 每個組合一直試到成功
            For j = 0 To num(1)
                If (j * num(2)) + ((num(1) - j) * num(3)) = num(4) Then
                    Console.WriteLine(j & "," & (num(1) - j))
                    Exit For
                End If
            Next
        Next
        Call Main()
    End Sub
End Module
