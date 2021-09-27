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
        Dim m As Integer = 1
        Do Until m = P + 1
            Dim i As Integer = m
            Dim num() As String = Split(d(i), " ")
            Dim T(13) As Integer
            m += 1
            '求出號碼
            For j = 0 To UBound(num)
                Dim n As Integer = num(j)
                Do Until n <= 13
                    n -= 13
                Loop
                T(n) += 1
            Next
            '判斷
            '順子
            m = m
            For j = 1 To 10
                If T(j) >= 1 And T(j + 1) >= 1 And T(j + 2) >= 1 And T(j + 3) >= 1 Then
                    '防止出現10-J-Q-K-A
                    If j = 10 Then
                        '判斷是否是同花順
                        For K = 0 To 3
                            Dim n As Integer = 0
                            For l = 0 To 5
                                If num(l) >= ((K * 13) + 1) And num(l) <= ((K * 13) + 13) Then
                                    n += 1
                                End If
                            Next
                            If n = 5 Then
                                Console.WriteLine("7")
                                Continue Do
                            End If
                        Next
                        Console.WriteLine("4")
                        Continue Do
                    ElseIf j + 4 <= 13 Then
                        If T(j + 4) >= 1 Or j = 10 Then
                            '判斷是否是同花順
                            For K = 0 To 3
                                Dim n As Integer = 0
                                For l = 0 To 5
                                    If num(l) >= ((K * 13) + 1) And num(l) <= ((K * 13) + 13) Then
                                        n += 1
                                    End If
                                Next
                                If n = 5 Then
                                    Console.WriteLine("7")
                                    Continue Do
                                End If
                            Next
                            Console.WriteLine("4")
                            Continue Do
                        End If
                    End If
                End If
            Next
            '判斷是否是四條
            For j = 1 To 13
                If T(j) >= 4 Then
                    Console.WriteLine("6")
                    Continue Do
                End If
            Next
            '判斷是否是葫蘆
            For j = 1 To 13
                If T(j) = 3 Then
                    For k = 1 To 13
                        If T(k) = 2 Then
                            Console.WriteLine("5")
                            Continue Do
                        End If
                    Next
                End If
            Next
            '判斷是否是三條
            For j = 1 To 13
                If T(j) = 3 Then
                    Console.WriteLine("3")
                    Continue Do
                End If
            Next
            '判斷是否是兩對
            For j = 1 To 13
                If T(j) = 2 Then
                    For k = j + 1 To 13
                        If T(k) = 2 Then
                            Console.WriteLine("2")
                            Continue Do
                        End If
                    Next
                    Console.WriteLine("1")
                    Continue Do
                End If
            Next
            '雜牌
            Console.WriteLine("0")
        Loop
        Call Main()
    End Sub
End Module
