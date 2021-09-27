Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), " ")
        Do Until Str(0) = "0" And Str(1) = "0"
            If Val(Str(0)) > Val(Str(1)) Then
                Console.WriteLine(">")
            ElseIf Val(Str(0)) < Val(Str(1)) Then
                Console.WriteLine("<")
            ElseIf Val(Str(0)) = Val(Str(1)) Then
                Console.WriteLine("=")
            End If
            Str = Split(LineInput(1), " ")
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
