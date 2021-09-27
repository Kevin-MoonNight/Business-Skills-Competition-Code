Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), " ")
        Do Until Str(0) = "0" And Str(1) = "0" And Str(2) = "0" And Str(3) = "0"
            Dim Z, I, M, L As Integer
            Z = Val(Str(0)) : I = Val(Str(1)) : M = Val(Str(2)) : L = Val(Str(3))
            Dim Num(9999) As Boolean
            Dim n As Integer = 0
            L = (Z * L + I) Mod M
            Do Until Num(L) = True
                n += 1
                Num(L) = True
                L = (Z * L + I) Mod M
            Loop
            Console.WriteLine(n)
            Str = Split(LineInput(1), " ")
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
