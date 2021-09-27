Module Module1
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
        For I = 1 To P
            Dim input_num() As String = Split(d(I), ",")
            Dim n As Integer = 0
            '算出根節點
            For j = 0 To UBound(input_num)
                n += Val(input_num(j))
            Next
            Dim Huffman_Tree(n, n) As Integer
            '初始化樹
            For j = 0 To n
                For k = 0 To n
                    Huffman_Tree(j, k) = -1
                Next
            Next
            '組合
            Huffman_Tree = Huffman(input_num, Huffman_Tree)
            '存放輸出
            Dim text As String = ""
            '尋找數字
            For j = 0 To UBound(input_num)
                text &= ans(input_num(j), Huffman_Tree, n, 0) & ","
            Next
            '去除結尾的，
            text = Mid(text, 1, Len(text) - 1)
            Console.WriteLine(text)
            Next
            Call Main()
    End Sub
    Function Huffman(ByVal input_num() As String, ByVal Huffman_Tree(,) As Integer)
        Dim Min1, Min2 As Integer : Min1 = 0 : Min2 = 0
        Dim n, Last As Integer : n = 99
        Dim num(UBound(input_num)) As Integer
        For i = 0 To UBound(input_num)
            num(i) = Val(input_num(i))
        Next
        Dim T(UBound(num)) As Boolean
        '重複執行到所有數字都組合過
        Do Until n = 1
            '找出兩個最小
            Min1 = min(num, T)
            T(Min1) = True
            Min2 = min(num, T)
            T(Min2) = True
            '將兩個樹的總和放到Last
            Last = num(Min1) + num(Min2)
            '將使用過的樹輸出路徑
            Huffman_Tree(num(Min1), Last) = 1 : Huffman_Tree(Last, num(Min1)) = 1 : Huffman_Tree(num(Min2), Last) = 1 : Huffman_Tree(Last, num(Min2)) = 1
            '找一個位置將Last儲存在可用的數字
            For i = 0 To UBound(num)
                If T(i) = True Then
                    num(i) = Last : T(i) = False
                    Exit For
                End If
            Next
            '判斷剩幾個數字沒組合
            n = 0
            For i = 0 To UBound(T)
                If T(i) = False Then
                    n += 1
                End If
            Next
        Loop
        '輸出樹
        Return Huffman_Tree
    End Function
    Function min(ByVal num() As Integer, ByVal T() As Boolean)
        '找最小
        Dim n As Integer
        For i = 0 To UBound(num)
            If T(i) = False Then
                n = i
            End If
        Next
        For i = 0 To UBound(num)
            If num(i) < num(n) And T(i) = False Then
                n = i
            End If
        Next
        Return n
    End Function
    Function ans(ByVal num As Integer, ByVal Tree(,) As Integer, ByVal TheEnd As Integer, ByVal n As Integer)
        Do Until num = TheEnd
            '往上尋找 算走了幾步
            For j = 0 To TheEnd
                If Tree(num, j) = 1 And j > num Then
                    num = j
                    n += 1
                End If
            Next
        Loop
        Return n
    End Function
End Module
