Module Module1
    Dim arr(14, 14) As Integer
    Sub Main()
        '輸入
        Console.Write("請輸入檔案路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim d(31) As String
        For i = 0 To 31
            Input(1, d(i))
        Next
        '最多能通過的空白單位數目
        Dim N As Integer = d(0)
        '第P個圖
        For P = 0 To 1
            '將輸入帶進陣列
            For I = 0 To 14
                For J = 0 To 14
                    '設定障礙物
                    If Mid(d(I + 1 + (P * 16)), J + 1, 1) = "1" Then
                        arr(I, J) = -1
                    Else
                        arr(I, J) = 0
                    End If
                Next
            Next
            '設定起點
            arr(0, 0) = 1
            '洪水演算法
            For k = 1 To N
                For i = 0 To 14
                    For J = 0 To 14
                        If arr(i, J) = k Then
                            '上
                            BFS(k, i - 1, J)
                            '下
                            BFS(k, i + 1, J)
                            '左
                            BFS(k, i, J - 1)
                            '右
                            BFS(k, i, J + 1)
                        End If

                    Next
                Next
            Next
            '判斷終點的值是否有改變 
            If arr(14, 14) <> 0 Then
                Console.WriteLine("TRUE")
            Else
                Console.WriteLine("FALSE")
            End If
            '輸出路徑圖用
            'For i = 0 To 14
            '    For j = 0 To 14
            '        Console.Write(arr(i, j) & "    ")
            '    Next
            '    Console.WriteLine()
            'Next
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Sub BFS(ByVal k As Integer, ByVal tmpi As Integer, ByVal tmpj As Integer)
        If (tmpi >= 0 And tmpi <= 14) And tmpj >= 0 And tmpj <= 14 Then
            If (arr(tmpi, tmpj) = 0) Then
                arr(tmpi, tmpj) = k + 1
            End If
        End If
    End Sub
End Module
