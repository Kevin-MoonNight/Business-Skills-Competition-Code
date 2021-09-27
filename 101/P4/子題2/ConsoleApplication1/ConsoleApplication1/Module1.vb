Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        Dim d(n) As String
        For i = 1 To n
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To n
            Dim T As Integer = 0
            Dim ans As Integer = 0
            '分割
            Dim num() As String = Split(d(i), " ")
            '計算數字
            For j = 0 To UBound(num)
                '求出數字
                Do Until num(j) <= 13
                    num(j) -= 13
                Loop
                'J、Q、K則是10點
                If num(j) > 10 Then
                    num(j) = 10
                End If
                '判斷是否是1
                If num(j) = 1 Then
                    T += 1
                End If
                '加總
                ans += num(j)
            Next
            '如果超過21點則顯示F
            If ans > 21 Then
                Console.WriteLine("F")
            Else
                '如果裡面有無1判斷+上11是否會超出21
                For j = 1 To T
                    If ans + 10 <= 21 Then
                        ans += 10
                    End If
                Next
                Console.WriteLine(ans)
            End If
        Next
        Call Main()
    End Sub
End Module
