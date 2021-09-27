Module Module1
    '前序、中序
    Dim preorder(), inorder(), postorder() As String
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        For I = 1 To P
            '輸入資料
            Dim d(2) As String
            For J = 1 To 2
                d(J) = LineInput(1)
            Next
            '分割成陣列
            preorder = Split(d(2), ",") : inorder = Split(d(1), ",")
            postorder = Split(conver(0, UBound(preorder), 0, UBound(inorder)), " ")
            '輸出
            Dim ans As String = ""
            '將陣列裡的數字串上ans
            For j = 0 To UBound(postorder)
                If postorder(j) <> "" Then
                    ans &= postorder(j) & ","
                End If
            Next
            '去除逗號
            ans = Mid(ans, 1, Len(ans) - 1)
            Console.WriteLine(ans)
        Next
        FileClose()
        Call Main()
    End Sub
    Function conver(ByVal pre_star As Integer, ByVal pre_end As Integer, ByVal in_star As Integer, ByVal in_end As Integer) As String
        If pre_star > pre_end Or in_star > in_end Then
            Return ""
        End If
        '目前執行到的前序
        Dim Root As Integer = preorder(pre_star)
        Dim n, mid As Integer
        '找根節點在中序裡的位置
        For i = in_star To in_end
            If inorder(i) = Root Then
                mid = i '根節點在中序裡的位置
                n = mid - in_star '左子樹有幾個
            End If
        Next
        '回傳 左子樹 & 右子樹 & 根節點
        'conver(目前前序陣列左子樹執行到的的地方+1,左子樹有幾個,中序左子樹執行到的地方,左子樹在中序有幾個) & " " & conver(目前前序陣列右子樹執行到的地方,右子樹到第幾個,右子樹開始的地方,右子樹在中序的第幾個) & " " & 樹根
        Return conver(pre_star + 1, n + pre_star, in_star, mid - 1) & " " & conver(pre_star + n + 1, pre_end, mid + 1, in_end) & " " & Root
    End Function
End Module
