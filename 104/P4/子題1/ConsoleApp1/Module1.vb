Module Module1
    Dim Tree() As NewTree
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n, n2, n3 As Integer
        Input(1, n)
        For i = 1 To n
            Input(1, n2)
            ReDim Tree(n2)
            Input(1, n3)
            Tree(1).N = n3 '設定起始點
            For j = 2 To n2
                Input(1, n3)
                Tree(j).N = n3 '設定數值
                P(j, 1) '分配
            Next
            Dim Str() As String = Split(F(1), ",") '後序
            Dim Ans As String = ""
            For j = 0 To UBound(Str)
                If Str(j) <> "" Then
                    Ans &= Str(j) & ","
                End If
            Next
            Console.WriteLine(Mid(Ans, 1, Len(Ans) - 1)) '輸出
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Sub P(ByVal I As Integer, ByVal Root As Integer)
        If Tree(I).N < Tree(Root).N Then '如果比父節點大 分配到右子樹
            If Tree(Root).Left = 0 Then '如果右子樹沒有被分配過
                Tree(Root).Left = I
            Else '右子樹被分配過的話
                P(I, Tree(Root).Left) '判斷右子樹的節點
            End If
        ElseIf Tree(I).N > Tree(Root).N Then '如果比父節點小 分配到左子樹
            If Tree(Root).Right = 0 Then
                Tree(Root).Right = I
            Else '左子樹被分配過的話
                P(I, Tree(Root).Right) '判斷左子樹的節點
            End If
        End If
    End Sub
    Function F(ByVal Root As Integer)
        If Root <> 0 Then
            Return F(Tree(Root).Left) & "," & F(Tree(Root).Right) & "," & Tree(Root).N '搜尋
        End If
    End Function
    Structure NewTree
        Dim Left As Integer
        Dim Right As Integer
        Dim Root As Integer
        Dim N As Integer
    End Structure
End Module
