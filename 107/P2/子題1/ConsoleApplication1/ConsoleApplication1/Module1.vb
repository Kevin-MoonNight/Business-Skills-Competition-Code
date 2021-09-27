Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For I = 1 To P
            Input(1, d(I))
        Next
        FileClose()
        '執行
        For I = 1 To P
            '輸入資料
            Dim num As String = d(I)
            '判斷
            For K = 1 To 100
                Dim n As Integer = 0
                For j = 1 To Len(num)
                    n += Mid(num, j, 1) ^ 2
                Next
                num = n
                If num = d(I) Or num = 1 Then
                    Exit For
                End If
            Next
            '輸出
            If num = 1 Then
                Console.WriteLine("T")
            Else
                Console.WriteLine("F")
            End If
        Next
        Call Main()
    End Sub
End Module
