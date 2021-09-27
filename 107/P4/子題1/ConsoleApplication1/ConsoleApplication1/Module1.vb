Module Module1
    Dim Max As Integer = 0
    Sub Main()
        '輸出
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For I = 1 To P
            '輸入資料
            Dim d As String
            d = LineInput(1)
            '去除頭尾括號
            d = Replace(d, "[", "").ToString.Replace("]", "")
            Dim num() As String = Split(d, ",")
            Dim n As Integer = 0
            Dim Tree(99, 99) As Integer
            Dim m As Integer = 0
            '判斷有幾層
            Do Until conver(m) >= UBound(num)
                m += 1
            Loop
            '輸入路徑
            For j = 1 To UBound(num) + 1
                If num(j - 1) <> "null" Then
                    '判斷第幾層 m-1 是因為樹葉不需要組合
                    For k = 0 To m - 1
                        '找到要組合的子節點位於哪一層後
                        If j > conver(k - 1) And j <= conver(k) Or k = 0 And j <= conver(k) Then
                            Dim T As Integer = (j - conver(k - 1))
                            '去下一層尋找他的子節點
                            '如果有左子樹
                            If conver(k) + (T * 2) - 2 <= UBound(num) Then
                                '要果要組合的子節點是null則不組合
                                If num(conver(k) + (T * 2) - 2) <> "null" Then
                                    Tree(Val(num(j - 1)), Val(num((conver(k) + (T * 2) - 2)))) = 1 : Tree(Val(num((conver(k) + (T * 2) - 2))), Val(num(j - 1))) = 1
                                End If
                            End If
                            '如果有右子樹
                            If conver(k) + (T * 2) - 1 <= UBound(num) Then
                                If num(conver(k) + (T * 2) - 1) <> "null" Then
                                    Tree(Val(num(j - 1)), Val(num((conver(k) + (T * 2) - 1)))) = 1 : Tree(Val(num((conver(k) + T * 2) - 1)), Val(num(j - 1))) = 1
                                End If
                            End If
                            Exit For
                        End If
                    Next
                End If
            Next
            '尋找一個根節點當作起點
            Dim Start As Integer = 0
            Max = 0
            For j = 1 To 99
                n = 0
                For k = 1 To 99
                    If Tree(j, k) = 1 Then
                        n += 1
                    End If
                Next
                If n = 1 Then
                    Start = j
                    DFS(Start, Start, 1, Tree)
                End If
            Next
            Console.WriteLine(Max)
        Next
        FileClose()
        Call Main()
    End Sub
    Function DFS(ByVal i As Integer, ByVal Last As Integer, ByVal n As Integer, ByVal Tree(,) As Integer)
        For j = 1 To 99
            If Tree(i, j) = 1 And Last <> j Then
                DFS(j, i, n + 1, Tree)
                If n > Max Then
                    Max = n
                End If
                n -= 1
            End If
        Next
    End Function
    Function conver(ByVal num As Integer)
        Dim ans As Integer = 0
        For i = 0 To num
            ans += 2 ^ i
        Next
        Return ans
    End Function
End Module
