Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), ",")
        Dim X(UBound(Str)), n, Num() As Integer
        n = UBound(Str)
        For i = 0 To n - 1
            X(i + 1) = Str(i)
        Next
        '排序
        For i = 1 To n
            For j = 1 To n
                If X(i) > X(j) Then
                    Dim ST As Double = X(i)
                    X(i) = X(j)
                    X(j) = ST
                End If
            Next
        Next
        ReDim Num(X(1))
        Dim Ans(4) As Double
        For i = 1 To n '平均
            Ans(1) += X(i)
            Num(X(i)) += 1
        Next
        Ans(1) /= n
        For i = 1 To n '變異
            Ans(2) += (X(i) - Ans(1)) ^ 2
        Next
        Ans(2) *= 1 / (n - 1)
        Ans(3) = (1 / 2) * (X(n / 2) + X(n / 2 + 1)) '中位數
        '眾數
        Dim Max As Integer = 1
        For i = 1 To UBound(Num)
            If Num(i) > Num(Max) Then
                Max = i
            End If
        Next
        Ans(4) = Max
        Console.WriteLine("平均數：" & Format(Ans(1), "0.0"))
        Console.WriteLine("變異數：" & Format(Ans(2), "0.00"))
        Console.WriteLine("中位數：" & Format(Ans(3), "0"))
        Console.WriteLine("眾  數：" & Format(Ans(4), "0"))
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
