Module Module1
    Dim AA As Integer
    Dim ans(999) As String
    Dim P As Integer
    Dim d(3) As String
    Dim text As String
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        '輸入幾筆測試資料
        Input(1, P)
        For i = 1 To P
            '輸入資料
            For j = 1 To 3
                Input(1, d(j))
            Next
            '執行
            text = d(1)
            AA = 1
            DFS("")
            Console.WriteLine(Val(ans(d(2))) + Val(ans(d(3))))
        Next
        FileClose()
        Call Main()
    End Sub
    Sub DFS(ByVal num As String)
        '輸出
        If Len(num) = Len(text) Then
            ans(AA) = num
            AA += 1
        End If
        '組合
        For I = 0 To Len(text) - 1
            If InStr(num, text(I)) = 0 Then
                DFS(num & text(I))
            End If
        Next
    End Sub
End Module
