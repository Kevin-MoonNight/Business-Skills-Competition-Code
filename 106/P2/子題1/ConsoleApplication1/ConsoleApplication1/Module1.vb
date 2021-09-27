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
        '執行
        For i = 1 To P
            '判斷性別是否正確
            If Mid(d(i), 2, 1) <> 1 And Mid(d(i), 2, 1) <> 2 Then
                Console.WriteLine("F")
                Continue For
            End If
            '轉換第一碼
            Dim n As Integer
            Dim S As String = "ABCDEFGHJKLMNPQRSTUVXY"
            For J = 1 To Len(S)
                If Mid(d(i), 1, 1) = Mid(S, J, 1) Then
                    n = 10 + J - 1
                End If
            Next
            '例外
            If Mid(d(i), 1, 1) = "I" Then
                n = 34
            ElseIf Mid(d(i), 1, 1) = "O" Then
                n = 35
            ElseIf Mid(d(i), 1, 1) = "Z" Then
                n = 33
            End If
            '帶進陣列裡
            Dim num(11) As Integer
            num(1) = Mid(n, 1, 1) : num(2) = Mid(n, 2, 1)
            For j = 2 To Len(d(i))
                num(j + 1) = Mid(d(i), j, 1)
            Next
            '計算
            n = 1 * num(1)
            For j = 9 To 1 Step -1
                n += j * num(10 - j + 1)
            Next
            n += 1 * num(11)
            '判斷
            If n Mod 10 = 0 Then
                Console.WriteLine("T")
            Else
                Console.WriteLine("F")
            End If
        Next
        Call Main()
    End Sub
End Module
