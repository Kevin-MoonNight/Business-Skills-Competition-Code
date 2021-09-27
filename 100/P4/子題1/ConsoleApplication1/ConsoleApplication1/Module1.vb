Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入檔案路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        Dim d(n) As Integer
        For i = 1 To n
            Input(1, d(i))
        Next
        FileClose()
        Dim M50, M20, M10, M5, M1 As Integer
        '第P筆資料
        For P = 1 To n
            '找零計算
            d(P) = 100 - d(P)
            Do While d(P) / 50 >= 1
                d(P) -= 50
                M50 += 1
            Loop
            Do While d(P) / 20 >= 1
                d(P) -= 20
                M20 += 1
            Loop
            Do While d(P) / 10 >= 1
                d(P) -= 10
                M10 += 1
            Loop
            Do While d(P) / 5 >= 1
                d(P) -= 5
                M5 += 1
            Loop
            Do While d(P) / 1 >= 1
                d(P) -= 1
                M1 += 1
            Loop
        Next
        '輸出
        Console.WriteLine("50," & M50 & ",20," & M20 & ",10," & M10 & ",5," & M5 & ",1," & M1)
        Call Main()
    End Sub
End Module
