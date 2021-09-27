Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Dim Num(n) As Integer
        '輸入
        Dim Txt As String = ""
        For i = 1 To n
            Num(i) = Val(LineInput(1))
            Txt &= Num(i) & "、"
        Next
        Txt = Mid(Txt, 1, Len(Txt) - 1)
        Console.WriteLine(Txt)
        '排序
        For I = 3 To 1 Step -1
            Txt = ""
            For J = 1 To n
                For K = 1 To n
                    If Val(Mid(Num(J), I, 1)) < Val(Mid(Num(K), I, 1)) And J <> K Then
                        Dim ST As Integer = Num(J)
                        Num(J) = Num(K)
                        Num(K) = ST
                    End If
                Next
            Next
            For j = 1 To n
                Txt &= Num(j) & "、"
            Next
            Txt = Mid(Txt, 1, Len(Txt) - 1)
            Console.WriteLine(Txt)
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
