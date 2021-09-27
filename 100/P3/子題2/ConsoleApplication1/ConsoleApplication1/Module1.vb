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
        '第P筆資料
        For SP = 1 To n
            Dim m, r As Integer
            m = 0 : r = 0
            Dim text As String = ""
            '16轉2進制
            d(SP) = conver16(d(SP))
            '補0
            Do Until Len(d(SP)) = 16
                d(SP) = "0" & d(SP)
            Loop
            m = Len(d(SP))
            '計算r
            Do Until m + r <= 2 ^ r
                r += 1
            Loop
            '檢查碼
            Dim P(r) As Integer
            '歸零
            For i = 1 To r
                P(i) = 0
            Next
            Dim AA As Integer = 1
            '插入檢查碼
            For i = 0 To r
                For j = 1 To m + r
                    If j = 2 ^ i Then
                        text &= "P"
                        i += 1
                    Else
                        text &= Mid(d(SP), AA, 1)
                        AA += 1
                    End If
                Next
            Next
            '計算檢查碼那列有幾個1
            AA = 1
            For I = 1 To m + r
                If Mid(text, I, 1) = "1" Then
                    '轉2進制
                    Dim Ptext As String = conver(I)
                    Do Until Len(Ptext) = 5
                        Ptext = "0" & Ptext
                    Loop
                    For j = 1 To r
                        If Mid(Ptext, r - j + 1, 1) = "1" Then
                            P(j) += 1
                        End If
                    Next
                End If
            Next
            '判斷檢查碼偶同位數
            For i = 1 To r
                If P(i) Mod 2 = 0 Then
                    P(i) = 0
                Else
                    P(i) = 1
                End If
            Next
            '輸出
            Console.WriteLine(P(1) & " " & P(2) & " " & P(3) & " " & P(4) & " " & P(5))
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function conver16(ByVal num As String) As String
        '16轉2
        Dim ans As String
        For i = 1 To Len(num)
            Dim n As String = Mid(num, i, 1)
            If n = "A" Then
                n = 10
            ElseIf n = "B"
                n = 11
            ElseIf n = "C"
                n = 12
            ElseIf n = "D"
                n = 13
            ElseIf n = "E"
                n = 14
            ElseIf n = "F"
                n = 15
            End If
            ans &= conver(n)
        Next
        Return ans
    End Function
    Function conver(ByVal num As String) As String
        '10轉2
        Dim ans As String
        Dim n As Integer = num
        '10轉2
        Do Until n \ 2 = 0
            ans = n Mod 2 & ans
            n = n \ 2
        Loop
        ans = n Mod 2 & ans
        n = n \ 2
        Do Until Len(ans) >= 4
            ans = "0" & ans
        Loop
        Return ans
    End Function
End Module
