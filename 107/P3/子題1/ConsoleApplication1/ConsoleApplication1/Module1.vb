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
            Dim num() As String = Split(d(i), ",")
            Dim ans As String = num(0)
            For j = 2 To Val(num(1))
                ans = conver(ans, num(0))
            Next
            '輸出
            Console.WriteLine(Len(ans))
        Next
        Call Main()
    End Sub
    Function conver(ByVal str1 As String, ByVal str2 As String)
        '暫時存放數字
        Dim num1(99999), num2(99999) As Integer
        For i = Len(str1) To 1 Step -1
            num1(Len(str1) - i + 1) = Val(Mid(str1, i, 1))
        Next
        For i = Len(str2) To 1 Step -1
            num2(Len(str2) - i + 1) = Val(Mid(str2, i, 1))
        Next
        Dim num(99999) As Integer
        Dim ans As String = ""
        Dim n As Integer
        '乘數
        For i = 1 To Len(str2)
            '被乘數
            For j = 1 To Len(str1)
                num(i + j) += num1(j) * num2(i)
                '找終點
                n = i + j
                '加總 進位
                Do Until num(i + j) < 10
                    num(i + j) -= 10
                    num(i + j + 1) += 1
                    '找終點
                    n = i + j + 1
                Loop
            Next
        Next
        '組合
        For i = 2 To n
            ans = num(i) & ans
        Next
        '輸出
        Return ans
    End Function
End Module
