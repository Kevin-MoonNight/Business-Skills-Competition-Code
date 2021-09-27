Module Module1
    Dim AA As Integer
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim Str() As String = Split(LineInput(1), " ")
            Dim Num(9999) As Integer
            AA = 0
            For j = 0 To UBound(Str)
                If Str(j) <> "" Then
                    AA += 1
                    Num(AA) = Val(Str(j))
                End If
            Next
            Console.WriteLine(Conver(Num))
        Next
        Console.ReadKey()
        Call Main()
    End Sub
    Function Conver(ByVal num() As Integer)
        Dim Max As Integer = Integer.MinValue
        For i = 1 To AA
            For j = 1 To AA
                Dim n As Integer = 0
                For k = i To j
                    n += num(k)
                Next
                If n > Max Then
                    Max = n
                End If
            Next
        Next
        Return Max
    End Function
End Module
