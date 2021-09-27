Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '輸入資料
        Dim d(P) As String
        For J = 1 To P
            d(J) = LineInput(1)
        Next
        '執行
        For I = 1 To P
            Dim num() As String = Split(d(I), ",")
            Dim n As Integer = 0
            '判斷有幾層
            Do Until (UBound(num) + 1) < 2 ^ n
                n += 1
            Loop
            '將數值帶進陣列
            Dim arr(n, 2 ^ n) As Integer
            Dim m1, m2 As Integer
            m1 = 0 : m2 = 0
            Do Until m1 > UBound(num)
                For j = 1 To 2 ^ m2
                    If m1 <= UBound(num) Then
                        arr(m2 + 1, j) = num(m1)
                    End If
                    m1 += 1
                Next
                m2 += 1
            Loop
            '用來判斷是哪種樹
            Dim T(3) As Boolean
            For j = 1 To 3
                T(j) = True
            Next
            '判斷是否是最小堆積數
            For j = 2 To n
                For k = 1 To 2 ^ (j - 1)
                    '如果是左子樹
                    If k Mod 2 <> 0 Then
                        '則判斷左子樹是否小於右子樹
                        If arr(j, k + 1) <> 0 Then
                            If arr(j, k) < arr(j - 1, (k \ 2) + 1) Or arr(j, k + 1) < arr(j - 1, (k + 1) \ 2) Then
                                '不是的話則不是最小堆積數
                                T(1) = False
                            End If
                        End If
                    End If
                Next
            Next
            '判斷是否是最大堆積數
            For j = 2 To n
                For k = 1 To 2 ^ (j - 1)
                    '如果是左子樹
                    If k Mod 2 <> 0 Then
                        '則判斷左子樹是否小於右子樹
                        If arr(j, k + 1) <> 0 Then
                            If arr(j, k) > arr(j - 1, (k \ 2) + 1) Or arr(j, k + 1) > arr(j - 1, (k + 1) \ 2) Then
                                '不是的話則不是最小堆積數
                                T(2) = False
                            End If
                        End If
                    End If
                Next
            Next
            '判斷是二元搜尋樹
            For j = 2 To n
                For k = 1 To 2 ^ (j - 1)
                    '如果是左子樹
                    If k Mod 2 <> 0 Then
                        '則判斷左子樹是否小於樹根 且右子樹是否大於樹根
                        If arr(j, k + 1) <> 0 Then
                            If arr(j, k) > arr(j - 1, (k \ 2) + 1) Or arr(j, k + 1) < arr(j - 1, (k + 1) \ 2) Then
                                '不是的話則不是二元搜尋樹
                                T(3) = False
                            End If
                        End If
                    End If
                Next
            Next
            '輸出
            If T(1) = True Or T(2) = True Then
                Console.WriteLine("H")
            ElseIf T(3) = True
                Console.WriteLine("B")
            Else
                Console.WriteLine("F")
            End If
        Next
        FileClose()
        Call Main()
    End Sub
End Module
