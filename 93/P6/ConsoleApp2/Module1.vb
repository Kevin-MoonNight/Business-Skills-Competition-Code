Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim n As Integer = Int(LineInput(1))
            Dim X(999), Max As Double
            X(0) = 1 : X(1) = 1 : Max = Integer.MinValue
            For i = 1 To n - 1
                Dim ST() As Double = X.Clone
                For J = 99 To 0 Step -1 '乘上X
                    If ST(J) <> 0 Then
                        X(J + 1) = ST(J)
                        X(J) = 0
                        If J + 1 > Max Then
                            Max = J + 1
                        End If
                    End If
                Next
                For J = 99 To 0 Step -1 '乘上1
                    If ST(J) <> 0 Then
                        X(J) += ST(J)
                    End If
                Next
            Next
            Dim Ans As String = ""
            For i = Max To 0 Step -1
                Ans &= X(i) & ","
            Next
            Console.WriteLine(Mid(Ans, 1, Len(Ans) - 1))
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
