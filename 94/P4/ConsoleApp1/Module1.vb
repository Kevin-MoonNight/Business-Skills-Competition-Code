Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Dim Num(n) As Integer
        For i = 1 To n
            Num(i) = Val(LineInput(1))
        Next
        For i = 1 To n
            For j = 1 To n
                If Num(i) < Num(j) Then
                    Dim ST As Integer
                    ST = Num(i)
                    Num(i) = Num(j)
                    Num(j) = ST
                End If
            Next
        Next
        For i = 1 To n / 2
            Console.WriteLine(Num(i) + Num(n - i + 1) & "=" & Num(i) & "+" & Num(n - i + 1))
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
