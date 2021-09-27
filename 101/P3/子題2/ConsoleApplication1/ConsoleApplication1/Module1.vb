Module Module1
    Sub Main()
        '輸入
        Console.Write("請入路徑名稱：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer
        Input(1, N)
        Dim d(N) As String
        For i = 1 To N
            Input(1, d(i))
        Next
        FileClose()
        '執行第N筆資料
        For i = 1 To N
            Dim text As String = d(i)
            Dim ans As String
            Dim T(11) As String
            T(0) = 100 : T(1) = 101 : T(2) = 1100 : T(3) = 1101 : T(4) = 11100 : T(5) = 11101 : T(6) = 111100 : T(7) = 111101 : T(8) = 111110 : T(9) = 111111
            '判斷是否相符
            For j = 1 To 4
                For K = 0 To 9
                    If Mid(text, 1, Len(T(K))) = T(K) Then
                        ans &= K
                        text = Mid(text, Len(T(K)) + 1)
                        Exit For
                    End If
                Next
            Next
            ans &= ","
            '加入A、B
            T(0) = "00" : T(1) = "01" : T(2) = 100 : T(3) = 101 : T(4) = 1100 : T(5) = 1101 : T(6) = 11100 : T(7) = 11101 : T(8) = 111100 : T(9) = 111101 : T(10) = 1111110 : T(11) = 1111111
            '判斷是否相符
            For j = 1 To 4
                For K = 0 To 11
                    If Mid(text, 1, Len(T(K))) = T(K) Then
                        If K = 0 Then
                            ans &= "A"
                        ElseIf K = 1
                            ans &= "B"
                        Else
                            ans &= K - 2
                        End If
                        text = Mid(text, Len(T(K)) + 1)
                        Exit For
                    End If
                Next
            Next
            '輸出
            Console.WriteLine(ans)
            ans = ""
        Next
        Call Main()
    End Sub
End Module
