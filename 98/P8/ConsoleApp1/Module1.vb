Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim Str() As String = Split(LineInput(1), " ")
            Dim All As Integer = 0
            For J = 1 To UBound(Str)
                If Str(J) <> "" Then
                    All += Val(Str(J))
                End If
            Next
            Console.WriteLine(Format(All / Val(Str(0)), "0.00"))
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
