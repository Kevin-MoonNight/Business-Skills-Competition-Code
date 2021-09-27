Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入檔案路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        '判斷字串
        Dim T As String
        Input(1, T)
        Dim d(999) As String
        Dim AA As Integer
        Do Until EOF(1) = True
            Input(1, d(AA))
            AA += 1
        Loop
        FileClose()
        '將字串集合起來
        Dim Text As String
        For I = 0 To UBound(d)
            If d(I) <> "EOF" Then
                Text &= d(I) & " "
            End If
        Next
        '分割去除標點符號
        Dim ans() As String = Strings.Replace(Text, ",", " ").ToString.Replace(";", " ").ToString.Replace(".", " ").ToString.Split(" ")
        '判斷單字出現次數
        Dim n1, n2 As Integer
        n1 = 0 : n2 = 0
        For i = 0 To UBound(ans)
            '清除多餘的空白
            For j = 1 To Len(ans(i))
                If Mid(ans(i), j, 1) = " " Then
                    ans(i) = Replace(ans(i), " ", "")
                End If
            Next
            '判斷
            If LCase(ans(i)) = LCase(T) Then
                n1 += 1
            End If
            '計算單字數
            If ans(i) <> "" Then
                n2 += 1
            End If
        Next
        Console.WriteLine(n1 & "," & n2)
        Console.ReadKey()
        Call Main()
    End Sub
End Module
