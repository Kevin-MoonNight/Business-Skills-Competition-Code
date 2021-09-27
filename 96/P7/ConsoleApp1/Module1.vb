Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim k As Integer = LineInput(1)
        Dim n As Integer = LineInput(1)
        For i = 1 To n
            Dim Str As String = LineInput(1)
            Dim Ans As String = ""
            For j = 1 To Len(Str)
                Ans &= Chr(Asc(Mid(Str, j, 1)) - k)
            Next
            Console.WriteLine(Ans)
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
