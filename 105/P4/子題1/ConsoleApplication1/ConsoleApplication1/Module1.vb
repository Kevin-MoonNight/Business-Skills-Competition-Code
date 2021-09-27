Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For I = 1 To P
            '輸入資料
            Dim d(2) As String
            For j = 1 To 2
                Input(1, d(j))
            Next
            '帶入資料
            Dim x(Len(d(1))), y(Len(d(2))) As String
            For j = 1 To UBound(x)
                x(j) = Mid(d(1), j, 1)
            Next
            For j = 1 To UBound(y)
                y(j) = Mid(d(2), j, 1)
            Next
            '設定陣列
            Dim arr(UBound(x), UBound(y)) As Integer
            '帶公式
            Dim n As Integer = 0
            For j = 1 To UBound(x)
                For k = 1 To UBound(y)
                    If j = 0 Or k = 0 Then
                        arr(j, k) = 0
                    ElseIf x(j) = y(k) Then
                        arr(j, k) = arr(j - 1, k - 1) + 1
                    ElseIf x(j) <> y(k)
                        arr(j, k) = Math.Max(arr(j, k - 1), arr(j - 1, k))
                    End If
                Next
            Next
            '輸出
            Console.WriteLine(arr(UBound(x), UBound(y)))
        Next
        FileClose()
        Call Main()
    End Sub
End Module
