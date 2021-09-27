Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Dim Str() As String = Split(LineInput(1), " ") '輸入
        Dim Num(n) As Integer
        For i = 0 To UBound(Str)
            Num(i + 1) = Str(i)
        Next
        n = LineInput(1)
        Do Until n = 0
            Dim T_Num(UBound(Num)) As Boolean
            Dim Ans As Boolean = False
            For i = 1 To UBound(Num)
                For j = 1 To UBound(Num)
                    If i <> j And Num(i) + Num(j) = n Then
                        Console.WriteLine("1") : Ans = True
                    End If
                Next
            Next
            If Ans = False Then
                Console.WriteLine("-1")
            End If
            n = LineInput(1)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
