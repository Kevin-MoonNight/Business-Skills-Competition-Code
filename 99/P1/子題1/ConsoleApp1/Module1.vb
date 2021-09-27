Module Module1

    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P(26) As Integer
        '輸入
        Dim Txt, Str As String
        Dim n As Integer
        Input(1, n)
        Txt = ""
        For i = 1 To n
            Str = LineInput(1)
            Txt &= Str
        Next
        FileClose()
        '判斷
        For i = 1 To Len(Txt)
            If Asc(UCase(Mid(Txt, i, 1))) >= Asc("A") And Asc(UCase(Mid(Txt, i, 1))) <= Asc("Z") Then
                P(Asc(UCase(Mid(Txt, i, 1))) - Asc("A") + 1) += 1
            End If
        Next
        '輸出
        For I = 1 To 26
            Console.Write("(" & Chr(Asc("A") + I - 1) & "," & P(I) & ") ")
        Next
        Console.WriteLine()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
