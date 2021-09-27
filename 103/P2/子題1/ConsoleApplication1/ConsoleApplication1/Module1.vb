Module Module1
    Sub Main()
        '輸入
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
            '把相同的字串轉成asc儲存設為True
            Dim T(Asc("z")) As Boolean
            Dim Text1, Text2 As String
            '帶進Text
            Text1 = d((i - 1) * 2 + 1) : Text2 = d((i - 1) * 2 + 2)
            '判斷
            For j = 1 To Len(Text1)
                For k = 1 To Len(Text2)
                    '相同的在T裡設為True
                    If Mid(Text1, j, 1) = Mid(Text2, k, 1) Then
                        T(Asc(Mid(Text1, j, 1))) = True
                    End If
                Next
            Next
            '輸出
            '存放輸出
            Text1 = ""
            For J = 1 To UBound(T)
                If T(J) = True Then
                    Text1 &= Chr(J)
                End If
            Next
            '如果Text裡有東西就輸出Text
            If Text1 <> "" Then
                Console.WriteLine(Text1)
                Continue For
            End If
            Console.WriteLine("N")
        Next
        Call Main()
    End Sub
End Module
