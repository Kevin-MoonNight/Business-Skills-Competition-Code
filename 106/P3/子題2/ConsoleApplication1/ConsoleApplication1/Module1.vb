Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For i = 1 To P
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To P
            Dim num As String = d(i)
            Dim T As Integer
            Do Until Len(num) = 1
                For j = 1 To Len(num)
                    T += Val(Mid(num, j, 1))
                Next
                num = T
                T = 0
            Loop
            '輸出
            Console.WriteLine(num)
        Next
        Call Main()
    End Sub
End Module
