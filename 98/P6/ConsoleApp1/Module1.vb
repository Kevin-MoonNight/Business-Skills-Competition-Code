Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim d(9999) As String
        Dim AA As Integer = 0
        Do Until EOF(1)
            AA += 1
            d(AA) = LineInput(1)
        Loop
        Dim Max, Min As Integer
        Dim Num As Integer
        Min = 1 : Max = 100
        For I = 1 To AA
            If I Mod 2 = 1 Then
                Num = Val(d(I))
            Else
                If d(I) = "too high" Then
                    Max = Num - 1
                ElseIf d(I) = "too low" Then
                    Min = Num + 1
                ElseIf d(I) = "right on" Then
                    If Num >= Min And Num <= Max Then
                        Console.WriteLine("1")
                    Else
                        Console.WriteLine("0")
                    End If
                    Min = 1 : Max = 100
                End If
            End If
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
