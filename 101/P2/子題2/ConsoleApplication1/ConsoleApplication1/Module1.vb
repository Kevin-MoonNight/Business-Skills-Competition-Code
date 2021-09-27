Module Module1
    '比對可通行路徑用陣列
    Dim T_arr(20, 20) As Integer
    '判斷是否是樹
    Dim IsTree As Boolean = False
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
            '輸入資料、路徑
            Dim tree_arr(20, 20) As Integer
            For J = 0 To 20
                For K = 0 To 20
                    tree_arr(J, K) = 0
                    T_arr(J, K) = 0
                Next
            Next
            '將資料給的可通行路徑放到陣列裡
            Dim input_L() As String = Split(d(i), " ")
            For J = 0 To UBound(input_L)
                Dim L() As String = Split(input_L(J), ",")
                If L(0) <> "" Then
                    tree_arr(Val(L(0)), Val(L(1))) = 1 : tree_arr(Val(L(1)), Val(L(0))) = 1
                End If
            Next
            '判斷是否是樹
            IsTree = False
            T_arr(0, 0) = 1
            '將樹走遍走過的路徑設為1 
            DFS(0, tree_arr, -1, "")
            '跟資料的陣列進行比對 判斷是否相同
            For j = 0 To 20
                For k = 0 To 20
                    '如果可通行路徑不一樣就離開迴圈
                    If tree_arr(j, k) <> T_arr(j, k) Then
                        j = 20
                        IsTree = True
                        Exit For
                    End If
                Next
            Next
            '如果是樹就尋找根節點有幾個
            If IsTree = True Then
                '輸出
                Console.WriteLine("F")
            Else
                '尋找
                Dim n As Integer = 0
                Dim T As Integer = 0
                For J = 1 To 20
                    For K = 0 To 20
                        If tree_arr(J, K) = 1 Then
                            T += 1
                        End If
                    Next
                    If T = 1 Then
                        n += 1
                    End If
                    T = 0
                Next
                '輸出
                Console.WriteLine(n)
            End If
        Next
        Call Main()
    End Sub
    Function DFS(ByVal i As Integer, ByVal tree_arr(,) As Integer, ByVal last As Integer, ByVal L As String)
        For j = 0 To 20
            If tree_arr(i, j) = 1 And j <> last Then
                '防止出現無限迴圈
                For K = 0 To UBound(Split(L, ","))
                    '判斷這步之前是否有走過
                    If Split(L, ",")(K) = j.ToString Then
                        IsTree = True
                        Exit Function
                    End If
                Next
                '沒走過就輸出走過的路為1
                T_arr(i, j) = 1 : T_arr(j, i) = 1
                DFS(j, tree_arr, i, L & j & ",")
            End If
        Next
    End Function
End Module
