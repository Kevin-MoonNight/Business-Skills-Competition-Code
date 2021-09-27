Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入輸入檔案路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim d(4) As String
        For i = 1 To 4
            Input(1, d(i))
        Next
        FileClose()
        '輸出
        For i = 1 To 4
            'P為比較值 num、num1為計算值
            Dim p As Integer
            Dim num, num1 As String
            num = "" : num1 = "" : p = 0
            '1個字1個字取
            For j = 1 To Len(d(i))
                '如果是數字則加到計算值
                If IsNumeric(Mid(d(i), j, 1)) = True Then
                    num = num & Mid(d(i), j, 1)
                Else
                    '如果是==則，比較值=計算值
                    If Mid(d(i), j, 2) = "==" Then
                        p = num
                        num = ""
                        j += 1
                        '如果是運算元則將運算元後的數字一直取，取到不是數字
                    ElseIf Mid(d(i), j, 1) = "+"
                        j += 1
                        Do While IsNumeric(Mid(d(i), j, 1)) = True
                            '將運算元後的數字加到計算值1裡面
                            num1 &= Mid(d(i), j, 1)
                            j += 1
                        Loop
                        '計算
                        num = Val(num) + Val(num1)
                        num1 = ""
                        j -= 1
                    ElseIf Mid(d(i), j, 1) = "-"
                        j += 1
                        Do While IsNumeric(Mid(d(i), j, 1)) = True
                            num1 &= Mid(d(i), j, 1)
                            j += 1
                        Loop
                        num = Val(num) - Val(num1)
                        num1 = ""
                        j -= 1
                    End If
                End If
            Next
            '比較
            If p <> Val(num) Then
                Console.WriteLine("FALSE")
            Else
                Console.WriteLine("TRUE")
            End If
        Next
        Console.ReadKey()
    End Sub
End Module
