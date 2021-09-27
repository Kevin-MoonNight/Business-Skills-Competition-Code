Module Module1
    Dim arr(99, 99) As Integer
    Dim ans As String = ""
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
            Dim text() As String = Split(d(i), " ")
            Dim Tree(99, 99) As Integer
            '初始化
            For j = 0 To 99
                For k = 0 To 99
                    Tree(j, k) = -1
                    arr(j, k) = -1
                Next
            Next
            Dim Min As Integer = 999999
            '輸入路徑
            For j = 0 To UBound(text)
                If text(j) <> "" Then
                    Dim num() As String = Split(text(j), ",")
                    Tree(Val(num(0)), Val(num(1))) = 1 : Tree(Val(num(1)), Val(num(0))) = 1
                    If Math.Min(Val(num(0)), Val(num(1))) < Min Then
                        Min = Math.Min(Val(num(0)), Val(num(1)))
                    End If
                End If
            Next
            Dim T As Boolean = False
            '判斷是否有無限迴圈
            ans = ""
            DFS(Tree, Min, -1, "")
            If ans <> "" Then
                Console.WriteLine(ans)
                Continue For
            Else
                '判斷是否是樹
                For j = 0 To 99
                    For k = 0 To 99
                        If Tree(j, k) <> arr(j, k) Then
                            T = True
                        End If
                    Next
                Next
            End If
            If T = True Then
                Console.WriteLine("F")
            Else
                Console.WriteLine("T")
            End If
        Next
        Call Main()
    End Sub
    Function DFS(ByVal Tree(,) As Integer, ByVal i As Integer, ByVal Last As Integer, ByVal str As String) As String
        '判斷是否會無限迴圈
        For j = 0 To 99
            If Tree(i, j) = 1 And j <> Last Then
                Dim n As Integer = 0
                '判斷是否走過同樣的路
                For k = 0 To UBound(Split(str, ","))
                    If Val(Split(str, ",")(k)) = j Or Val(Split(str, ",")(k)) = i Then
                        n += 1
                    End If
                    If n = 2 Then
                        ans = i & "," & j
                        Exit Function
                    End If
                Next
                arr(i, j) = 1 : arr(j, i) = 1
                DFS(Tree, j, i, str & i & ",")
            End If
        Next
    End Function
End Module
