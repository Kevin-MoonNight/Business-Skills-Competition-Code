Module Module1

    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str As String = LineInput(1)
        Dim Num As Integer = Val(Str)
        Dim Ans As String = Str & "="
        Do Until Num = 1
            Dim n As Integer = 0
            For i = 2 To Num
                If Num Mod i = 0 Then
                    Dim T As Boolean = False
                    For j = 2 To n - 1
                        If i Mod j <> 0 Then
                            T = True
                        End If
                    Next
                    If T = False Then
                        n = i : Exit For
                    End If
                End If
            Next
            If n = 0 Then
                n = Num
            End If
            Ans &= n & "*"
            Num = Num / n
        Loop
        Console.WriteLine(Mid(Ans, 1, Len(Ans) - 1))
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
