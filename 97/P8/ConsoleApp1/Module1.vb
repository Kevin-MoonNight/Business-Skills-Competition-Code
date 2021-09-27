Module Module1

    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str As String = Console.ReadLine(1)


        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
