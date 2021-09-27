Module Module1
    Sub Main()
        Console.Write("請輸入檔名：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Console.WriteLine(Conver(Val(LineInput(1))))
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function Conver(ByVal Num As Integer)
        Dim Ans As String = ""
        Do Until Num / 2 = 0
            Ans = Num Mod 2 & Ans
            Num = Num \ 2
        Loop
        Dim T As Integer = 0
        For i = 1 To Len(Ans)
            If Val(Mid(Ans, i, 1)) = 1 Then
                T += 1
            End If
        Next
        Return T
    End Function
End Module
