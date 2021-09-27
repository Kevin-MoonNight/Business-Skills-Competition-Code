Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str As String = LineInput(1)
        Dim Ans As String = ""
        For k = 1 To Len(Str)
            Dim Txt As String = Convert.ToString(Asc(Mid(Str, k, 1)), 2)
            Dim Num(Len(Txt)) As Integer
            For i = Len(Txt) To 1 Step -1
                Num(i) = Val(Mid(Txt, i, 1))
            Next
            For i = Len(Txt) To Len(Txt) - 2 Step -1
                If Num(i) = 1 Then
                    Num(i) = 0
                Else
                    Num(i) = 1
                End If
            Next
            Txt = String.Join("", Num)
            Ans &= Chr(Convert.ToInt32(Txt, 2))
        Next
        Console.WriteLine(Ans)
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
