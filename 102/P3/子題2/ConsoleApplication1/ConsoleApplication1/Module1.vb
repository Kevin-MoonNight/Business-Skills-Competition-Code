Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For I = 1 To P
            '輸入資料
            Dim input_n As String = ""
            Do Until input_n <> ""
                Input(1, input_n)
            Loop
            Dim d(Val(input_n)) As String
            For j = 1 To Val(input_n)
                d(j) = LineInput(1)
            Next
            '判斷
            Dim T As Boolean = False
            Dim L() As String = Split(d(1), " ")
            Dim n As Integer = UBound(L) + 2
            '用來判斷邊是否有重複
            Dim Tree(n, n) As Integer
            '用來判斷內部節點有哪些
            Dim T_arr(n) As Integer
            '初始化
            For j = 1 To n
                For k = 1 To n
                    Tree(j, k) = 0
                Next
                T_arr(j) = 0
            Next
            'm比測試資料
            For m = 1 To Val(input_n)
                '用來分割輸入資料
                L = Split(d(m), " ")
                n = UBound(L) + 2
                Dim Tree_arr(n, n) As Integer
                '輸入路徑
                For j = 0 To UBound(L)
                    Dim num() As String = Split(L(j), "-")
                    Tree_arr(Val(num(0)), Val(num(1))) = 1 : Tree_arr(Val(num(1)), Val(num(0))) = 1
                Next
                '判斷是不是樹
                If DFS(1, n, -1, "", Tree_arr) = True Then
                    T = True : m = Val(input_n)
                End If
                '判斷哪些是內部節點
                Dim ST_arr = DFS2(n, Tree_arr)
                '比對兩個數內部節點是否不一樣
                For j = 1 To UBound(Tree_arr)
                    '將當過內部節點+1當過兩次以上的就算重複
                    T_arr(j) += ST_arr(j)
                    If T_arr(j) > 1 Then
                        T = True : m = Val(input_n)
                    End If
                Next
                '判斷有沒有重複的邊
                For j = 1 To n
                    For k = 1 To n
                        '將走過的路+1走過兩次以上的就算重複
                        Tree(j, k) += Tree_arr(j, k)
                        If Tree(j, k) > 1 Then
                            T = True : m = Val(input_n)
                        End If
                    Next
                Next
            Next
            '輸出
            If T = True Then
                Console.WriteLine("F")
            Else
                Console.WriteLine("T")
            End If
        Next
        FileClose()
        Call Main()
    End Sub
    Function DFS(ByVal i As Integer, ByVal n As Integer, ByVal last As Integer, ByVal str As String, ByVal Tree_arr(,) As Integer) As Boolean
        '判斷是不是樹
        For j = 0 To n
            If Tree_arr(i, j) = 1 And last <> j Then
                '判斷是否會無限迴圈
                For k = 0 To UBound(Split(str, ","))
                    If Val(Split(str, ",")(k)) = j Then
                        Return True
                    End If
                Next
                DFS(j, n, i, str & i & ",", Tree_arr)
            End If
        Next
    End Function
    Function DFS2(ByVal n As Integer, ByVal Tree_arr(,) As Integer) As Integer()
        Dim Boolean_arr(n) As Integer
        '判斷哪些是內部節點
        For i = 0 To n
            Dim tmp As Integer = 0
            For j = 0 To n
                If Tree_arr(i, j) = 1 Then
                    tmp += 1
                End If
            Next
            If tmp >= 2 Then
                Boolean_arr(i) = 1
            End If
        Next
        Return Boolean_arr
    End Function
End Module
