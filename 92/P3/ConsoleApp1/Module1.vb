Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Txt As String = LineInput(1)
        Dim Ans As String = "**"
        Dim n As Integer = 0
        For i = 1 To Len(Txt)
            If Mid(Txt, i, 1) <> " " Then
                n += 1
            End If
        Next
        For i = 1 To Len(Txt)
            If Mid(Txt, i, 1) <> " " Then
                Dim Str As String = Asc(Mid(Txt, i, 1)) + (n Mod 10)
                For j = 1 To Len(Str)
                    Ans &= Chr(Asc("a") + Val(Mid(Str, j, 1)))
                Next
            Else
                Ans &= "*"
            End If
        Next
        Ans &= "#"
        For i = 1 To Len(n.ToString)
            Ans &= Chr(Asc("a") + Val(Mid(n.ToString, i, 1)))
        Next
        Console.WriteLine(Ans & "***")
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
