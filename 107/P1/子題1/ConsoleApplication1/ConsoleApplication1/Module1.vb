Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For i = 1 To P
            d(i) = LineInput(1)
        Next
        FileClose()
        '執行
        For i = 1 To P
            Dim N As Integer = 0
            '分割空白
            Dim text() As String = Split(d(i), " ")
            '判斷每個單字內是否含有S
            For j = 0 To UBound(text)
                For k = 1 To Len(text(j))
                    If UCase(Mid(text(j), k, 1)) = "S" Then
                        N += 1
                        Exit For
                    End If
                Next
            Next
            '輸出
            Console.WriteLine((UBound(text) + 1) & "," & N)
        Next
        Call Main()
    End Sub
End Module
