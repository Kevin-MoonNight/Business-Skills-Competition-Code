Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As New ArrayList
        P.Clear()
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            P.Add(Str)
        Loop
        Dim Num(P.Count - 1) As Integer
        Console.WriteLine("學號" & vbTab & "程式設計" & vbTab & "名次")
        For i = 0 To P.Count - 1
            For j = 0 To P.Count - 1
                If Val(P(i)(1)) < Val(P(j)(1)) And i <> j Then
                    Num(i) += 1
                End If
            Next
            Console.WriteLine(P(i)(0) & vbTab & P(i)(1) & vbTab & Num(i) + 1)
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
