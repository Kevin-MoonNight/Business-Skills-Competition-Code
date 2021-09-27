Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim n2 As Integer
            Input(1, n2)
            '輸入資料
            Dim d(n2) As String
            For j = 1 To n2
                Input(1, d(j))
            Next
            '計算
            Dim Money As Integer = 0
            For j = 1 To UBound(d) - 1
                Dim M1, M2 As Integer
                M1 = d(j) : M2 = d(j + 1)
                '判斷上下層
                If Math.Sign(M1 - M2) = -1 Then
                    Money += (M2 - M1) * 20
                ElseIf Math.Sign(M1 - M2) = 1
                    Money += (M1 - M2) * 10
                End If
            Next
            '輸出
            Console.WriteLine(Money)
        Next
        FileClose()
        Call Main()
    End Sub
End Module
