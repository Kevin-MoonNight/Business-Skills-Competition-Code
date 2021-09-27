Module Module1
    Dim arr As New ArrayList
    Dim AA As Integer = 0
    '存放6個投注號碼
    Dim Text(6) As String
    '存放投注號碼
    Dim d(6) As String
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '輸入中獎號碼
        Dim T(5) As String
        For J = 1 To 5
            Input(1, T(J))
        Next
        For i = 1 To P
            '輸入投注號碼
            For J = 1 To 6
                Input(1, d(J))
            Next
            '找出所有組合
            DFS("")
            '存放中獎個數
            Dim M(5) As Integer
            Dim N As Integer = 0
            '判斷中獎個數
            For j = 1 To 6
                Dim ans() As String = Split(Text(j), ",")
                For k = 1 To 5
                    For l = 1 To 5
                        If ans(k) = T(l) Then
                            N += 1
                        End If
                    Next
                Next
                M(N) += 1
                N = 0
            Next
            '輸出
            Console.WriteLine(M(2) & "," & M(3) & "," & M(4) & "," & M(5))
            arr.Clear() : AA = 0
        Next
        FileClose()
        Call Main()
    End Sub
    Function DFS(ByVal num As String)
        '如果集滿5個號碼
        If Len(num) = 14 + 1 Then
            Dim number(6) As Boolean
            Dim ans() As String = Split(num, ",")
            '判斷該個數字組合有無出現過
            For i = 1 To 6
                For j = 1 To UBound(ans)
                    If d(i) = ans(j) Then
                        number(i) = True
                    End If
                Next
            Next
            For i = 1 To 6
                If number(i) = True Then
                    ans(0) &= i
                End If
            Next
            '判斷
            If arr.Contains(ans(0)) = False Then
                arr.Add(ans(0))
                AA += 1
                Text(AA) = num
            End If
        End If
        '組合
        For i = 1 To 6
            If InStr(num, d(i)) = 0 Then
                DFS(num & "," & d(i))
            End If
        Next
    End Function
End Module
