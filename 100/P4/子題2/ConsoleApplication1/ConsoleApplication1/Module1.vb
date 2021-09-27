Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入檔案路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        Dim d(n) As String
        For i = 1 To n
            Input(1, d(i))
        Next
        FileClose()
        Dim T1(n), T2(n), T3(n), T4(n), T5(n), T6(n), T7(n), T8(n) As Boolean
        '第A筆資料
        For A = 1 To n
            'P為第A筆資料
            Dim P(n) As String
            P(A) = d(A)
            '將資料分割成5組數字
            Dim text() As String = Strings.Replace(P(A), "S", "").ToString.Replace("H", "").ToString.Replace("D", "").ToString.Replace("C", "").ToString.Split(" ")
            '判斷 同花順 > 四條 > 葫蘆 > 順子 > 三條 > 兩對 > 一對 > 雜牌
            Dim num(12) As Integer
            'S=黑桃 H=紅心 D=方塊 C=梅花
            'FC用來存放花色數量
            Dim FC(4) As Integer
            '判斷花色
            For i = 1 To Len(P(A))
                If IsNumeric(Mid(P(A), i, 1)) = False Then
                    If Mid(P(A), i, 1) = "S" Then
                        FC(1) += 1
                    ElseIf Mid(P(A), i, 1) = "H" Then
                        FC(2) += 1
                    ElseIf Mid(P(A), i, 1) = "D" Then
                        FC(3) += 1
                    ElseIf Mid(P(A), i, 1) = "C" Then
                        FC(4) += 1
                    End If
                End If
            Next
            '判斷第i組數字
            For i = 1 To 5
                '判斷是幾號
                For j = 1 To 12
                    If text(i - 1) = j Then
                        num(j) += 1
                    End If
                Next
            Next
            '判斷組合
            For i = 1 To 12
                '判斷是否是順子
                If i + 4 < 12 Then
                    If num(i) = 1 And num(i + 1) = 1 And num(i + 2) = 1 And num(i + 3) = 1 And num(i + 4) = 1 Then
                        '判斷是否是同花順
                        If FC(1) = 4 Or FC(2) = 4 Or FC(3) = 4 Or FC(4) = 4 Then
                            T1(A) = True
                            Continue For
                        Else
                            T4(A) = True
                            Continue For
                        End If
                    End If
                End If
                '判斷是否是四條
                If num(i) = 4 Then
                    T2(A) = True
                    Continue For
                End If
                '判斷是否是三條
                If num(i) = 3 Then
                    '判斷否是葫蘆
                    For J = 1 To 12
                        If num(J) = 2 Then
                            T3(A) = True
                            Continue For
                        End If
                    Next
                    '不是葫蘆就是三條
                    If T3(A) <> True Then
                        T5(A) = True
                        Continue For
                    End If
                End If
                '判斷是否是一對
                If num(i) = 2 Then
                    '判斷是否是兩對
                    For j = i To 12
                        If num(j) = 2 Then
                            T6(A) = True
                            Continue For
                        End If
                    Next
                    '不是兩懟就是一對
                    If T6(A) <> True Then
                        T7(A) = True
                    End If
                End If
                '都不是就是雜牌
                T8(A) = True
            Next
        Next
        Dim T(n) As Integer
        For i = 1 To n
            If T1(i) = True Then
                T(i) += 1
            ElseIf T2(i) = True Then
                T(i) += 2
            ElseIf T3(i) = True Then
                T(i) += 3
            ElseIf T4(i) = True Then
                T(i) += 4
            ElseIf T5(i) = True Then
                T(i) += 5
            ElseIf T6(i) = True Then
                T(i) += 6
            ElseIf T7(i) = True Then
                T(i) += 7
            ElseIf T8(i) = True Then
                T(i) += 8
            End If
        Next
        '找最大、最小
        Dim Max, Min As Integer
        Max = 1 : Min = 1
        For i = 1 To n
            If T(Max) > T(i) Then
                Max = i
            End If
            If T(Min) < T(i) Then
                Min = i
            End If
        Next
        '輸出
        Console.WriteLine(d(Max))
        Console.WriteLine(d(Min))
        Console.ReadKey()
        Call Main()
    End Sub
End Module
