Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)


        For P = 1 To 4
            Dim Str As String = LineInput(1)
            Dim a() As String = Split(Str, ",")
            Dim b(UBound(a) + 1) As Integer
            For i = 0 To UBound(a)
                b(i + 1) = a(i)
            Next
            '排大小
            For i = 1 To UBound(b)
                For j = 1 To UBound(b)
                    If b(i) > b(j) Then
                        Dim ST As Integer
                        ST = b(i)
                        b(i) = b(j)
                        b(j) = ST
                        Exit For
                    End If
                Next
            Next
            Conver(b)
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Sub Conver(ByVal b() As Integer)
        Dim k As Integer = b(1)
        Dim c(k) As Integer
        Dim T As Integer = 0
        For i = 1 To k
            c(i) = b(i + 1) - 1
        Next
        For i = 1 To k
            If c(i) < 0 Then
                Console.WriteLine("不正確")
                Exit Sub
            ElseIf c(i) = 0 Then
                T += 1
            End If
        Next
        If T = k Then
            Console.WriteLine("正確")
        Else
            Conver(c)
        End If
    End Sub
End Module
