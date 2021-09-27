Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Dim Num(n) As Integer
        Dim Max As Integer = Integer.MinValue
        '輸入
        For i = 1 To n
            Num(i) = LineInput(1)
            If Num(i) > Max Then
                Max = Num(i)
            End If
        Next
        Dim Ans As Integer = 0
        For i = 1 To Max
            Dim T As Boolean = False
            For j = 1 To n
                If Num(j) Mod i <> 0 Then
                    T = True : Exit For
                End If
            Next
            If T = False Then
                Ans = i
            End If
        Next
        Console.WriteLine(Ans)
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
