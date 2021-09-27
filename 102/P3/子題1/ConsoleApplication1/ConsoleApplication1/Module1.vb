Module Module1
    Dim ans As Integer
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For i = 1 To P
            '輸入資料
            Dim input_n As String = ""
            Do Until input_n <> ""
                Input(1, input_n)
            Loop
            Dim n As String = ""
            Input(1, n)
            Dim d(Val(input_n)) As String
            For j = 1 To Val(input_n)
                d(j) = LineInput(1)
            Next
            '根結點
            Dim Root As Integer = 0
            Dim Tree_arr(Val(input_n) - 1, Val(input_n) - 1) As Integer
            '清空路徑陣列
            For j = 0 To Val(input_n) - 1
                For k = 0 To Val(input_n) - 1
                    Tree_arr(j, k) = 0
                Next
            Next
            For j = 1 To UBound(d)
                Dim L() As String = Split(d(j), ",")
                '判斷哪個根結點
                If Val(L(1)) = 99 Then
                    Root = Val(L(0))
                Else
                    '輸入可走路徑
                    Tree_arr(Val(L(0)), Val(L(1))) = 1
                    Tree_arr(Val(L(1)), Val(L(0))) = 1
                End If
            Next
            ans = 0
            '尋找
            DFS(n - 1, Root, input_n - 1, Tree_arr, -1)
            '輸出
            Console.WriteLine(ans)
        Next
        FileClose()
        Call Main()
    End Sub
    Function DFS(ByVal goal As Integer, ByVal i As Integer, ByVal n As Integer, ByVal Tree_arr(,) As Integer, ByVal last As Integer) As Integer
        For j = 0 To n
            '如果走目標長度
            If goal = 0 Then
                '判斷該節點可以走向幾條路
                For k = 0 To n
                    If Tree_arr(i, k) = 1 And k <> last Then
                        ans += 1
                    End If
                Next
                Exit For
            ElseIf Tree_arr(i, j) = 1 And j <> last Then
                '往前走長度-1
                goal -= 1
                DFS(goal, j, n, Tree_arr, i)
                '遞迴時長度回朔+1
                goal += 1
            End If
        Next
    End Function
End Module
