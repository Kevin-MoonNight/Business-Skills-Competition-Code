Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim Str() As String = Split(LineInput(1), " ")
            Dim B, P, M, R As Double
            B = Str(0) : P = Str(1) : M = Str(2)
            R = B
            If P Mod 2 = 1 Then
                P -= 1
            End If
            Do Until P <= 1
                R = R ^ 2 Mod M
                P /= 2
            Loop
            If Val(Str(1)) Mod 2 <> 0 Then
                R = B * R Mod M
            End If
            Console.WriteLine(R)
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
