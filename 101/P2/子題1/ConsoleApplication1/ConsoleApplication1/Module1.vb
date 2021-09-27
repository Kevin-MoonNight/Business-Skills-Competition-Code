Module Module1
    Dim MAX_L As Integer = 0
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For i = 1 To P
            '輸入資料
            Dim Input_n As String = ""
            Do Until Input_n <> ""
                Input(1, Input_n)
            Loop
            Dim d(Input_n - 1) As String
            For j = 1 To Input_n - 1
                d(j) = LineInput(1)
            Next
            Dim tree_arr(Input_n - 1, Input_n - 1) As Integer
            '清空陣列
            For J = 0 To Input_n - 1
                For K = 0 To Input_n - 1
                    tree_arr(J, K) = 0
                Next
            Next
            '輸入路徑
            For J = 1 To UBound(d)
                Dim L() As String = Split(d(J), ",")
                tree_arr(Val(L(0)), Val(L(1))) = 1
                tree_arr(Val(L(1)), Val(L(0))) = 1
            Next
            '尋找最長路徑
            MAX_L = 0
            'DFS(起點座標,路徑數,可走路陣列,起點算第一步,前一步的座標)
            DFS(0, Input_n - 1, tree_arr, 1, -1)
            Console.WriteLine(MAX_L)
        Next
        FileClose()
        Call Main()
    End Sub
    Function DFS(ByVal i As Integer, ByVal input_n As Integer, ByVal tree_arr(,) As Integer, ByVal n As Integer, ByVal last As Integer)
        'DFS
        For j = 0 To input_n
            '如果找到可以走的路 And 不走上一步
            If tree_arr(i, j) = 1 And j <> last Then
                n += 1
                DFS(j, input_n, tree_arr, n, i)
                '遞迴時步數回朔減一
                n -= 1
            End If
        Next
        '走完路的話輸出走了幾步
        If n > MAX_L Then
            MAX_L = n
        End If
    End Function
End Module
