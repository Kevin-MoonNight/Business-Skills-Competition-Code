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
            Dim text() As String = Split(d(i), ",")
            Dim Max(2) As Integer
            '存放所有組合中最大的公因數
            Dim ans As Integer = 0
            '把每一種組合試過
            For P1 = 0 To UBound(text)
                For P2 = 0 To UBound(text)
                    '存放最大公因數
                    Dim M As Integer = 0
                    If P1 <> P2 Then
                        Max(1) = Math.Max(Val(text(P1)), Val(text(P2)))
                        Max(2) = Math.Min(Val(text(P1)), Val(text(P2)))
                        '取最大公因數
                        For j = 1 To Max(2)
                            If Max(1) Mod j = 0 And Max(2) Mod j = 0 Then
                                M = j
                            End If
                        Next
                    End If
                    '如果比之前的組和裡的最大公因數還大
                    If ans < M Then
                        ans = M
                    End If
                Next
            Next
            '輸出
            Console.WriteLine(ans)
        Next
            Call Main()
    End Sub
End Module
