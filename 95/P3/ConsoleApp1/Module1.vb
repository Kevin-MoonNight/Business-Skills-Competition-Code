Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), ":")
        Do Until Str(0) = "0" And Str(1) = "00"
            Dim H, M As Double
            H = Val(Str(0)) : M = Val(Str(1))
            Dim Min As Double
            If M = 0 Then
                M = 12
            Else
                M = M / 5
                H += 5 * (M / 60)
            End If
            Min = Math.Min((Math.Abs(H - M)) * (360 / 12), (Math.Abs(12 - H + M)) * (360 / 12))
            Console.WriteLine(Format(Min, "0.000"))
            Str = Split(LineInput(1), ":")
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
