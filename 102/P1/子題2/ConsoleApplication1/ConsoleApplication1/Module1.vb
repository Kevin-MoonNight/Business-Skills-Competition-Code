Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For P = 1 To P
            Dim n As Integer
            Input(1, n)
            Dim d(n) As String
            Dim num(5) As String
            Dim T(39) As Integer
            '執行
            For I = 1 To n
                '輸入
                For j = 1 To 5
                    Input(1, num(j))
                Next
                '數字加總
                For j = 1 To UBound(num)
                    For k = 1 To 39
                        If num(j) = k Then
                            T(k) += 1
                        End If
                    Next
                Next
            Next
            Dim ans As String = ""
            Dim Max As Integer = 0
            '求最大出現次數
            For i = 1 To 39
                If Max < T(i) Then
                    Max = T(i)
                End If
            Next
            '判斷出現次數
            For i = 1 To 39
                If T(i) >= Max Then
                    If i < 10 Then
                        ans &= "0" & i & ","
                    Else
                        ans &= i & ","
                    End If
                End If
            Next
            '輸出
            Console.WriteLine(Mid(ans, 1, Len(ans) - 1))
        Next
        FileClose()
        Call Main()
    End Sub
End Module
