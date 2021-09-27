Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入檔案路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        Dim d(n) As String
        For i = 1 To n
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To n
            Dim T(9) As Boolean
            '判斷是否有數字
            For J = 1 To Len(d(i))
                If IsNumeric(Mid(d(i), J, 1)) = True Then
                    T(Mid(d(i), J, 1)) = True
                End If
            Next
            Dim M As Boolean = False
            '輸出有出現的數字
            For J = 0 To 9
                If T(J) = True Then
                    Console.Write(J)
                    M = True
                End If
            Next
            '如果沒出現數字則輸出N
            If M = False Then
                Console.Write("N")
            End If
            Console.WriteLine()
        Next
        Call Main()
    End Sub
End Module
