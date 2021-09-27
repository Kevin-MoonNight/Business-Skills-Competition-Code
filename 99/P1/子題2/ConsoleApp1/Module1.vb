Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Dim Txt, Str As String
        Input(1, n)
        For i = 1 To n
            Str = LineInput(1)
            Txt &= Str & " "
        Next
        Dim A_Str() As String = Strings.Replace(Txt, ".", " ").ToString.Replace(",", " ").ToString.Split(" ")
        Dim Arr As New ArrayList
        Arr.Clear()
        For i = 0 To UBound(A_Str)
            If UCase(Mid(A_Str(i), 1, 1)) = "A" And Arr.Contains(A_Str(i)) = False Then
                Arr.Add(A_Str(i))
                Console.WriteLine(A_Str(i))
            End If
        Next
        Console.ReadKey()
        Call Main()
    End Sub
End Module
