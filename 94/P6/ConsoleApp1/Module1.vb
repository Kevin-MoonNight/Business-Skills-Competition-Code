Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Dim X(5), Y(5) As Integer
        '輸入
        For i = 1 To n
            Dim Str() As String = Split(LineInput(1), " ")
            X(i) = Val(Str(0)) : Y(i) = Val(Str(1))
        Next
        Dim r, All_X, All_Y, _X, _Y As Double
        For I = 1 To n
            All_X += X(I)
            All_Y += Y(I)
        Next
        _X = (1 / n) * All_X : _Y = (1 / n) * All_Y
        Dim Num(3) As Double
        For i = 1 To n
            Num(1) += (X(i) - _X) * (Y(i) - _Y)
            Num(2) += (X(i) - _X) ^ 2
            Num(3) += (Y(i) - _Y) ^ 2
        Next
        r = Num(1) / (Math.Sqrt(Num(2)) * Math.Sqrt(Num(3)))
        Console.WriteLine(Format(r, "0.000"))
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
