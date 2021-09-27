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
            Dim Fib(18) As Integer
            '判斷是否有超過2個1
            Dim T As Boolean = False
            Fib(0) = 0 : Fib(1) = 1
            '計算費氏數列
            For j = 2 To 18
                Fib(j) = Fib(j - 1) + Fib(j - 2)
            Next
            '判斷
            For j = 18 To 2 Step -1
                If Fib(j) <= d(i) Then
                    '第一個一定是1
                    Console.Write(d(i) & "=" & "1")
                    d(i) = Val(d(i)) - Fib(j)
                    '尋找能減的數
                    For k = j - 1 To 2 Step -1
                        '能減輸出1 不能減輸出0
                        If Fib(k) <= d(i) Then
                            d(i) = Val(d(i)) - Fib(k)
                            Console.Write("1")
                        Else
                            Console.Write("0")
                        End If
                    Next
                    Console.WriteLine()
                    Exit For
                End If
            Next
        Next
        Call Main()
    End Sub
End Module
