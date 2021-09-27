Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), " ")
        Do Until Str(0) = "0" And Str(1) = "0"
            Dim St As Integer = 0
            Dim Num1(10), Num2(10) As Integer
            For i = 1 To Len(Str(0))
                Num1(Len(Str(0)) - i + 1) = Val(Mid(Str(0), i, 1))
            Next
            For i = 1 To Len(Str(1))
                Num2(Len(Str(1)) - i + 1) = Val(Mid(Str(1), i, 1))
            Next
            For i = 1 To 10
                Dim N As Integer = Num1(i) + Num2(i)
                Do While N >= 10
                    N -= 10
                    Num1(i + 1) += 1
                    St += 1
                Loop
            Next
            Console.WriteLine(St)
            Str = Split(LineInput(1), " ")
        Loop
        FileClose()
            Console.ReadKey()
        Call Main()
    End Sub
End Module
