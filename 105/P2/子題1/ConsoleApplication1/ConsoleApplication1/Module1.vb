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
            '分割IP跟子網路遮罩
            Dim text() As String = Split(d(i), "/")
            Dim IP() As String = Split(text(0), ".")
            Dim IP2() As String = Split(text(1), ".")
            Dim ID(UBound(IP)) As String
            For J = 0 To UBound(IP)
                Dim ans As String = ""
                '轉2進制
                IP(J) = conver(IP(J))
                IP2(J) = conver(IP2(J))
                For K = 1 To Len(IP(J))
                    '如果該位元子網路遮罩為1 該位元IP則保留
                    If Mid(IP2(J), K, 1) = 1 Then
                        ans &= Mid(IP(J), K, 1)
                    Else
                        ans &= "0"
                    End If
                Next
                ID(J) = conver2(ans)
            Next
            '輸出
            Console.WriteLine(ID(0) & "." & ID(1) & "." & ID(2) & "." & ID(3))
        Next
        Call Main()
    End Sub
    Function conver(ByVal num As Integer) As String
        Dim ans As String
        '轉2進制
        If num = 0 Then
            Return "00000000"
        End If
        Do Until num = 0
            ans = num Mod 2 & ans
            num = num \ 2
        Loop
        '補滿8位元
        Do Until Len(ans) = 8
            ans = "0" & ans
        Loop
        Return ans
    End Function
    Function conver2(ByVal num As String) As Integer
        Dim ans As Integer = 0
        '轉10進制
        For i = 1 To Len(num)
            ans += Mid(num, i, 1) * (2 ^ (Len(num) - i))
        Next
        Return ans
    End Function
End Module
