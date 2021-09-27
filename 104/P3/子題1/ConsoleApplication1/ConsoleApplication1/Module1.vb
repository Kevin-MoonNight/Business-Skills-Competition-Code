Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For i = 1 To P
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To P
            '轉成2進位
            Dim num As String = conver(d(i))
            Dim n As Integer = 0
            '判斷1有幾個
            For j = 1 To Len(num)
                If Mid(num, j, 1) = 1 Then
                    n += 1
                End If
            Next
            '輸出
            Console.WriteLine(n)
        Next
        Call Main()
    End Sub
    Function conver(ByVal num As String) As String
        '10轉2進制
        Dim ans As String
        Do While num <> 0
            ans = num Mod 2 & ans
            num \= 2
        Loop
        Return ans
    End Function
End Module
