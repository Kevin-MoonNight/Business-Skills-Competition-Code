Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), "x")
        Dim n As Integer = Convert.ToString(Convert.ToInt32(Str(0), 2) * Convert.ToInt32(Str(1), 2), 2)
        Console.WriteLine(n)
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
