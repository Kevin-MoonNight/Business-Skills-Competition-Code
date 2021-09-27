Module Module1
    Sub Main()
        '輸出
        Console.Write("請輸入路徑名稱：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer
        Input(1, N)
        Dim d(N) As String
        For i = 1 To N
            Input(1, d(i))
        Next
        FileClose()
        '執行第N筆資料
        For i = 1 To N
            Dim num As String = d(i)
            Dim num2 As String = d(i)
            '補0
            Do Until Len(num) Mod 3 = 0
                num = 0 & num
            Loop
            Do Until Len(num2) Mod 4 = 0
                num2 = 0 & num2
            Loop
            '輸出
            Console.WriteLine(conver1(num2) & "," & conver2(num))
        Next
        Call Main()
    End Sub
    Function conver(ByVal num As String) As String
        '2轉10進制
        Dim ans As Integer
        For j = Len(num) To 1 Step -1
            ans += Val(Mid(num, Len(num) - j + 1, 1)) * (2 ^ (j - 1))
        Next
        Return ans
    End Function
    Function conver1(ByVal num As String) As String
        '10轉16
        Dim ans As String
        '取4個bit轉成10進制
        For i = 0 To (Len(num) \ 4) - 1
            '轉成10進制後再轉乘16進制
            ans &= Hex(conver(Mid(num, i * 4 + 1, 4)))
        Next
        Return ans
    End Function
    Function conver2(ByVal num As String) As String
        '2轉8
        Dim ans As String
        '取3個bit轉成10進制
        For i = 0 To (Len(num) \ 3) - 1
            ans &= conver(Mid(num, i * 3 + 1, 3))
        Next
        Return ans
    End Function
End Module
