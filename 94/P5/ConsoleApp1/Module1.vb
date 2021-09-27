Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str As String = LineInput(1)
        Dim n As Integer = 0
        For i = 1 To Len(Str)
            If IsNumeric(Mid(Str, i, 1)) = True Then
                n += 1
            End If
        Next
        Console.WriteLine(n)
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
