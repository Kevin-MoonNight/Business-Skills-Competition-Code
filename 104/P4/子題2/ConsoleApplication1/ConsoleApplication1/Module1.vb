Module Module1
    Dim T As Boolean
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
            Dim Tree_arr(24, 24) As Integer
            Dim Star As Integer = 0
            Dim Last As Integer = 0
            Dim Min_ans As Integer = 0
            Dim ans_arr(24, 24) As Integer
            Dim arr As New ArrayList
            '初始化
            arr.Clear()
            For j = 0 To 24
                For k = 0 To 24
                    Tree_arr(j, k) = -1 : ans_arr(j, k) = -1
                Next
            Next
            '輸入路徑成本
            Dim L() As String = Split(d(i), " ")
            For J = 0 To UBound(L)
                Dim num() As String = Split(L(J), ",")
                Tree_arr(Asc(num(0)) - Asc("A") + 1, Asc(num(1)) - Asc("A") + 1) = num(2) : Tree_arr(Asc(num(1)) - Asc("A") + 1, Asc(num(0)) - Asc("A") + 1) = num(2)
            Next
            '算出有幾個點
            Dim n As Integer = 0
            For j = 1 To 24
                For k = 1 To 24
                    If Tree_arr(j, k) >= 0 Then
                        n += 1
                        Exit For
                    End If
                Next
            Next
            '組合樹
            '執行m次 = n-1
            For m = 1 To n - 1
                '從最小的路開始組合
                Dim Min As Integer = 9999999
                For j = 1 To 24
                    For k = 1 To 24
                        '尋找最小
                        If Tree_arr(j, k) < Min And arr.Contains(j & "," & k) = False And arr.Contains(k & "," & j) = False And Tree_arr(j, k) >= 0 Then
                            Min = Tree_arr(j, k)
                            Star = k : Last = j
                        End If
                    Next
                Next
                '判斷該條路是否可以輸出到樹
                ans_arr(Last, Star) = Tree_arr(Star, Last) : ans_arr(Star, Last) = Tree_arr(Last, Star)
                Min_ans += ans_arr(Star, Last)
                '判斷會不會無限迴圈 會的話就不要輸出
                T = False
                DFS(Star, Last, 24, Last & ",", ans_arr)
                If T = True Then
                    Min_ans -= ans_arr(Star, Last)
                    ans_arr(Star, Last) = -1 : ans_arr(Last, Star) = -1
                    m -= 1
                End If
                '試過的路加到判斷裡
                arr.Add(Star & "," & Last) : arr.Add(Last & "," & Star)
            Next
            '輸出
            Console.WriteLine(Min_ans)
        Next
        Call Main()
    End Sub
    Function DFS(ByVal i As Integer, ByVal Last As Integer, ByVal n As Integer, ByVal Str As String, ByVal Tree_arr(,) As Integer)
        For j = 1 To n
            If Tree_arr(i, j) >= 0 And j <> Last Then
                '判斷是否會出現無限迴圈
                For K = 0 To UBound(Split(Str, ", "))
                    If Val(Split(Str, ", ")(K)) = j Then
                        T = True
                        Exit Function
                    End If
                Next
                DFS(j, i, n, Str & i & ", ", Tree_arr)
            End If
        Next
    End Function
End Module
