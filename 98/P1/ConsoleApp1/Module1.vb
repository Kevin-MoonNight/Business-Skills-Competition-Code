Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim Str As String
            Str = LineInput(1)
            Dim Txt() As String = Strings.Replace(Str, ".", " ").ToString.Replace(",", " ").ToString.Replace(":", " ").ToString.Split(" ")
            Dim Arr As New ArrayList
            Arr.Clear()
            Dim T As Integer = 0
            For j = 0 To UBound(Txt)
                If Txt(j) <> "" Then
                    If Arr.Contains(UCase(Txt(j))) = False Then
                        T += 1
                        Arr.Add(UCase(Txt(j)))
                    End If
                End If
            Next
            Console.WriteLine(T)
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
