Module Module1
    Sub Main()
        '輸出
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer
        Input(1, N)
        '執行
        For i = 1 To N
            '輸入資料
            Dim d(2) As String
            For J = 1 To 2
                Input(1, d(J))
            Next
            Dim P As String = d(1) '前
            Dim Q As String = d(2) '後
            '判斷
            Dim S As String = ""
            Dim L As Integer = Math.Min(Len(P), Len(Q))
            For J = 1 To L
                If Mid(P, 1, J) = Strings.Right(Q, J) Then
                    S = Mid(P, 1, J)
                End If

            Next
            Console.WriteLine(Len(S))
        Next
        FileClose()
        Call Main()
    End Sub
End Module
