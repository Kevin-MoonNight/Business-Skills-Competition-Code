Module Module1
    Dim T() As Boolean
    Dim n As Integer
    Dim ans_str As String = ""
    Sub Main()
        '輸入
        Console.WriteLine("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For i = 1 To P
            '輸入資料
            Dim d As String
            d = LineInput(1)
            '分割成數字陣列
            '將[ ] 去除再把每個數字取出來
            Dim text() As String = Replace(d, "[", "").ToString.Replace("]", "").ToString.Split(",")
            '放進數字陣列裡
            Dim num(UBound(text) + 1) As Integer
            For j = 0 To UBound(text)
                num(j + 1) = Val(text(j))
            Next
            '創一個樹存放路徑
            Dim Tree(UBound(num), UBound(num)) As Integer
            ReDim T(UBound(num))
            n = UBound(num)
            '輸入路徑
            For j = 1 To UBound(num)
                Tree(j, num(j)) = 1
            Next
            Dim ans As String = ""
            '從最小的樹開始走訪循環
            For j = 1 To UBound(num)
                '如果走過的值則不執行
                If T(j) <> True Then
                    ans_str = ""
                    T(j) = True
                    DFS(j, "", Tree)
                    ans &= "[" & ans_str & "]" & ","
                End If
            Next
            '輸出
            Console.WriteLine("[" & Mid(ans, 1, Len(ans) - 1) & "]")
        Next
        FileClose()
        Call Main()
    End Sub
    Function DFS(ByVal i As Integer, ByVal str As String, ByVal Tree(,) As Integer)
        For J = 1 To n
            '尋找可以走的路
            If Tree(i, J) = 1 Then
                '走到走過的路就回傳路徑
                If T(J) <> True Then
                    '走過的值設為True
                    T(i) = True : T(J) = True
                    '如果走到循環則輸出
                    For k = 1 To UBound(Split(str, ","))
                        If Val(Split(str, ",")(k)) = J Then
                            ans_str = str
                            Exit Function
                        End If
                    Next
                    DFS(J, str & i & ",", Tree)
                Else
                    ans_str = str & i
                    Exit Function
                End If
            End If
        Next
    End Function
End Module
