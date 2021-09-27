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
            '判斷總長度
            Dim n As Integer = Len(d(i))
            '判斷有幾個空白
            Dim num() As String = Split(d(i), " ")
            '輸出不含空白的長度
            Console.WriteLine(n - UBound(num))
        Next
        Call Main()
    End Sub
End Module
