Module Module1

    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim Str() As String = Split(LineInput(1), " ")
            Dim Num(UBound(Str) + 1) As Double
            For j = 0 To UBound(Str) '輸入數字
                Num(j + 1) = Str(j)
            Next
            '判斷
            P1(Num) '等差
            P2(Num) '等比
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Sub P1(ByVal Num() As Double)
        Dim T As Double = Format(Num(2) - Num(1), "0.0000") '如果是等差
        For j = 1 To UBound(Num) - 1
            If Format(Num(j + 1) - Num(j), "0.0000") <> T Then
                Exit Sub
            End If
        Next
        Console.WriteLine("A " & T)
    End Sub
    Sub P2(ByVal Num() As Double)
        Dim T As Double = Num(2) / Num(1) '如果是等比
        For j = 1 To UBound(Num) - 1
            If Num(j + 1) / Num(j) <> T Then
                Exit Sub
            End If
        Next
        Console.WriteLine("G " & T)
    End Sub
End Module
