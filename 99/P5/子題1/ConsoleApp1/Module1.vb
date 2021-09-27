Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), ",")
        Dim Num(UBound(Str) + 1) As Integer
        For i = 0 To UBound(Str)
            Num(i + 1) = Val(Str(i))
        Next
        Dim n, Star As Integer
        Input(1, Star)
        FileClose()
        n = UBound(Num)
        Dim T(n) As Boolean
        n -= 1
        T(Star) = True
        Do Until n = 0
            For i = 1 To 2
                Star += 1
                If Star > UBound(Num) Then
                    Star -= UBound(Num)
                End If
                If T(Star) = True Then
                    i -= 1
                End If
            Next
            T(Star) = True
            If n = 1 Then
                Console.WriteLine(Star)
                Exit Do
            End If
            n -= 1
        Loop
        Console.ReadKey()
        Call Main()
    End Sub
End Module
