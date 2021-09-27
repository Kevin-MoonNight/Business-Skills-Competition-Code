Module Module1
    Sub Main()
        Console.Write("請輸入檔名：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim AA As Integer = 1
            Dim Str() As String = Split(LineInput(1), " ")
            Dim num(3) As Integer
            num(1) = Val(Str(0)) : num(2) = Val(Str(1)) : num(3) = Val(Str(2))
            Do Until AA Mod num(1) = 0 And AA Mod num(2) = 0 And AA Mod num(3) = 0
                AA += 1
            Loop
            Console.WriteLine(AA)
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
