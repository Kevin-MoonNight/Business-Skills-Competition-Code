Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Num As Integer = Int(LineInput(1))
            Dim Ans As String = Convert.ToString(Num, 2)
            Do Until Len(Ans) = 8
                Ans = "0" & Ans
            Loop
            Console.WriteLine(Ans)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
