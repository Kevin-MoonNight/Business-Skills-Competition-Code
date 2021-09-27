Module Module1

    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Dim Str() As String = Split(LineInput(1), " ")
        Dim Num(n) As Integer
        For i = 1 To n
            Num(i) = Val(Str(i - 1))
        Next
        '排序
        For i = 1 To n
            For j = 1 To n
                If Num(i) > Num(j) Then
                    Dim ST As Integer = Num(i)
                    Num(i) = Num(j)
                    Num(j) = ST
                End If
            Next
        Next
        n = LineInput(1)
        Do Until n = 0
            If n <= UBound(Num) Then
                For I = 0 To UBound(Str)
                    If Str(I) = Num(n) Then
                        Console.WriteLine(I + 1)
                        Exit For
                    End If
                Next
            Else
                Console.WriteLine(-1)
            End If
            n = LineInput(1)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
