Module Module1

    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), ",")
            Dim a(2), b(2), c(2) As Integer
            a(1) = Str(0) : b(1) = Str(1) : c(1) = Str(2)
            a(2) = Str(3) : b(2) = Str(4) : c(2) = Str(5)
            For X = -100 To 100
                For Y = -100 To 100
                    If a(1) * X + b(1) * Y + c(1) = 0 And a(2) * X + b(2) * Y + c(2) = 0 Then
                        Console.WriteLine("X=" & X & ",Y=" & Y) : X = 101 : Exit For
                    End If
                Next
            Next
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
