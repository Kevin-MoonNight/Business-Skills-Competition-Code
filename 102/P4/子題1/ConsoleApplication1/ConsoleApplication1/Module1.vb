Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入檔案路徑：")
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
            '將"-"去掉
            Dim text As String = Replace(d(i), "-", "")
            'T為檢查碼 TEXT的最後一個字
            Dim T As String = Mid(text, Len(text), 1)
            Dim S, M As Integer
            Dim N As String
            '判斷是ISDN-10或ISBN-13
            If Len(text) - 1 = 9 Then
                S = 0
                '計算加權和S
                For j = 1 To 9
                    S += Val(Mid(text, j, 1)) * (11 - j)
                Next
                '計算餘數
                M = S Mod 11
                '計算差
                N = 11 - M
                '得出檢查碼
                If N = 10 Then
                    N = "X"
                ElseIf N = 11
                    N = "0"
                End If
                '判斷檢查碼並輸出
                If N = T Then
                    Console.WriteLine("T")
                Else
                    Console.WriteLine("F")
                End If
            Else
                S = 0
                For j = 1 To 12
                    If j Mod 2 <> 0 Then
                        S += Val(Mid(text, j, 1)) * 1
                    Else
                        S += Val(Mid(text, j, 1)) * 3
                    End If

                Next
                M = S Mod 10
                N = 10 - M
                If N = 10 Then
                    N = "0"
                End If
                If N = T Then
                    Console.WriteLine("T")
                Else
                    Console.WriteLine("F")
                End If
            End If
        Next
        Call Main()
    End Sub
End Module
