Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        For i = 1 To n
            Dim Str() As String = Split(LineInput(1), " ")


        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
