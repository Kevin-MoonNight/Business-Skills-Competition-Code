Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            Dim n As Integer = Val(Str(1))
            Dim r As Integer = Val(Str(0))
            Dim Ans As Integer = (n * 1 / 2 * r ^ 2 * Math.Sin(360 / n))
            Console.WriteLine(Ans)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
