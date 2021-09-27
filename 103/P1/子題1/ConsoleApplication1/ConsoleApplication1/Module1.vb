Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer
        Input(1, N)
        Dim d(N * 2) As String
        For i = 1 To N * 2
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To N
            Dim num(1) As String
            '將數字帶進num
            num(0) = d(((i - 1) * 2) + 1) : num(1) = d(((i - 1) * 2) + 2)
            '判斷是否是孿生質數
            If Val(num(0)) + 2 <> num(1) Then
                Console.WriteLine("N")
            Else
                '判斷兩個數 是否是質數
                Dim T As Integer = 0
                For J = 0 To UBound(num)
                    For k = 1 To Val(num(J))
                        If Val(num(J)) Mod k = 0 Then
                            T += 1
                        End If
                    Next
                Next
                If T <> 4 Then
                    Console.WriteLine("N")
                Else
                    Console.WriteLine("Y")
                End If
            End If
        Next
        Call Main()
    End Sub
End Module
