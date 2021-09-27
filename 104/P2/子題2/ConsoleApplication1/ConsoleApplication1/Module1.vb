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
            Dim num() As String = Split(d(i), ",")
            Dim Max As Integer = 0
            '找最大數
            For j = 0 To UBound(num)
                If Max < Val(num(j)) Then
                    Max = num(j)
                End If
            Next
            Dim ans As Integer
            '從1開始判斷公因數到最大數
            For j = 1 To Max
                Dim T(UBound(num)) As Boolean
                Dim n As Integer = 0
                '判斷該數字是否可以被J整除
                For k = 0 To UBound(num)
                    If num(k) Mod j = 0 Then
                        T(k) = True
                        n += 1
                    End If
                Next
                '所有數都可以被整除那j就式所有數的公因數
                If n = UBound(num) + 1 Then
                    ans = j
                End If
            Next
            '輸出
            Console.WriteLine(ans)
        Next
        Call Main()
    End Sub
End Module
