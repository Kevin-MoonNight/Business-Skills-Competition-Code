Module Module1
    Sub Main()
        '輸出
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        Dim d(n * 2) As String
        For i = 1 To n * 2
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To n
            Dim num1() As String = Split(d((i - 1) * 2 + 1), " ")
            Dim num2() As String = Split(d((i - 1) * 2 + 2), " ")
            '相同的數字設為True
            Dim T(65535) As Boolean
            '判斷
            For J = 1 To UBound(num1)
                For K = 1 To UBound(num2)
                    If num1(J) = num2(K) Then
                        T(num2(K)) = True
                    End If
                Next
            Next
            Dim P As Integer = 0
            '輸出
            For J = 1 To UBound(T)
                If T(J) = True Then
                    P += 1
                End If
            Next
            Console.WriteLine(P)
        Next
        Call Main()
    End Sub
End Module
