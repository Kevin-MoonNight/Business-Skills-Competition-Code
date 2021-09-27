Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For i = 1 To P
            d(i) = LineInput(1)
        Next
        FileClose()
        '執行
        For i = 1 To P
            '分割單字
            Dim text() As String = Split(d(i), " ")
            '輸出
            Console.WriteLine(UBound(text) + 1)
        Next
        Call Main()
    End Sub
End Module
