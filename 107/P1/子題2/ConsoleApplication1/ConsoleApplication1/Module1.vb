Module Module1
    Dim arr(3, 3) As Integer
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For I = 1 To P
            '輸入資料
            Dim d(3) As String
            For j = 1 To 3
                Input(1, d(j))
                For k = 1 To 3
                    arr(j, k) = Val(Mid(d(j), k, 1))
                Next
            Next
            '輸出
            Console.WriteLine(ans)
        Next
        FileClose()
        Call Main()
    End Sub
    Function ans() As String
        '判斷
        Dim n As Integer = 0
        For num = 1 To 2
            '左至右
            For i = 1 To 3
                For j = 1 To 3
                    If arr(i, j) = num Then
                        n += 1
                    End If
                    If n = 3 Then
                        Return num
                    End If
                Next
                n = 0
            Next
            '上至下
            For i = 1 To 3
                For j = 1 To 3
                    If arr(j, i) = num Then
                        n += 1
                    End If
                    If n = 3 Then
                        Return num
                    End If
                Next
                n = 0
            Next
            '斜邊
            If arr(1, 1) = num And arr(2, 2) = num And arr(3, 3) = num Then
                Return num
            End If
            If arr(1, 3) = num And arr(2, 2) = num And arr(3, 1) = num Then
                Return num
            End If
        Next
        '都沒有就輸出3
        Return 3
    End Function
End Module
