Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑名稱：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim d(999) As String
        Dim AA As Integer = 1
        Do Until EOF(1) = True
            Input(1, d(AA))
            AA += 1
        Loop
        FileClose()
        '整合文字
        Dim text As String
        For i = 1 To UBound(d)
            If d(i) <> "EOF" Then
                text &= d(i) & " "
            End If
        Next
        '分割
        Dim P() As String = Strings.Split(text, " ")
        Dim T(3) As Integer
        Dim N As Integer
        Dim arr As New ArrayList
        text = ""
        For I = 0 To UBound(P)
            If P(I) <> "" Then
                '判斷是否執行過
                If arr.Contains(P(I)) = False Then
                    N = 0
                    arr.Add(P(I))
                    '計算出現次數
                    For J = 0 To UBound(P)
                        '判斷是否同樣
                        If P(I) = P(J) Then
                            N += 1
                        End If
                    Next
                    text &= N & " "
                End If

            End If
        Next
        '比大小
        Dim ans() As String = Split(text, " ")
        Dim Max As String
        arr.Clear()
        For I = 0 To UBound(ans)
            For j = 0 To UBound(ans)
                If Val(ans(I)) > Val(ans(j)) Then
                    Max = ans(I)
                    ans(I) = ans(j)
                    ans(j) = Max
                End If
            Next
        Next
        '輸出
        Console.WriteLine(ans(0) & "," & ans(1) & "," & ans(2))
        Call Main()
    End Sub
End Module
