Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer
        Input(1, N)
        Dim d(N) As String
        For i = 1 To N
            Input(1, d(i))
        Next
        FileClose()
        '執行
        Dim p As Integer = 1
        Do Until p = N + 1
            Dim i As Integer = p
            Dim text() As String = Split(d(i), " ")
            Dim num(13) As Integer
            '判斷是哪張牌
            For j = 0 To UBound(text)
                Do While text(j) > 13
                    text(j) = Val(text(j)) - 13
                Loop
                num(text(j)) += 1
            Next
            '判斷組合
            '判斷是否是四條
            For j = 1 To 13
                If num(j) = 4 Then
                    Console.WriteLine("四條")
                    p += 1
                    Continue Do
                End If
            Next
            '判斷是否是葫蘆
            For j = 1 To 13
                If num(j) = 3 Then
                    For k = 1 To 13
                        If num(k) = 2 Then
                            Console.WriteLine("葫蘆")
                            p += 1
                            Continue Do
                        End If
                    Next
                End If
            Next
            '判斷是否是順子
            For j = 1 To 10
                If num(j) = 1 And num(j + 1) = 1 And num(j + 2) = 1 And num(j + 3) = 1 Then
                    '防止出現10-J-Q-K-A
                    If j = 10 Or num(j + 4) = 1 Then
                        Console.WriteLine("順子")
                        p += 1
                        Continue Do
                    End If
                End If
            Next
            '判斷是否是三條
            For j = 1 To 13
                If num(j) = 3 Then
                    Console.WriteLine("三條")
                    p += 1
                    Continue Do
                End If
            Next
            '判斷是否是兩對
            For j = 1 To 13
                If num(j) = 2 Then
                    For k = j To 13
                        If num(k) = 2 Then
                            Console.WriteLine("兩對")
                            p += 1
                            Continue Do
                        End If
                    Next
                End If
            Next
            '判斷是否是一對
            For j = 1 To 13
                If num(j) = 2 Then
                    Console.WriteLine("一對")
                    p += 1
                    Continue Do
                End If
            Next
            '判斷是否是雜牌
            Console.WriteLine("雜牌")
            p += 1
        Loop
        Call Main()
    End Sub
End Module
