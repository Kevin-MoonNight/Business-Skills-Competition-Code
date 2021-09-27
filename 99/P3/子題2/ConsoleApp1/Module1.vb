Module Module1
    Sub Main()
        Console.Write("請輸入座標：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Txt(99) As String
        Dim AA As Integer = 1
        Do Until EOF(1)
            Txt(AA) = LineInput(1)
            AA += 1
        Loop

        For I = 1 To AA - 1
            Dim Str() As String = Split(Txt(I), " ")
            Dim T As Boolean = False
            For j = 0 To UBound(Str)
                If Mid(Str(j), 1, 1) = "A" Or Mid(Str(j), 1, 1) = "B" Or Mid(Str(j), 1, 1) = "E" Then
                    Dim num(11) As Integer
                    Dim m As Integer = Conver(Mid(Str(j), 1, 1)) + 10
                    num(1) = Val(Mid(m, 1, 1)) : num(2) = Val(Mid(m, 2, 1))
                    For K = 1 To 9
                        num(K + 2) = Val(Mid(Str(j), K + 1, 1))
                    Next
                    For k = 2 To 10
                        num(k) = num(k) * (11 - k)
                    Next
                    Dim Ans As Integer = 0
                    For k = 1 To 11
                        Ans += num(k)
                    Next
                    If Ans Mod 10 = 0 Then
                        T = True : Exit For
                    End If
                End If
            Next
            If T = True Then
                Console.WriteLine("有")
            Else
                Console.WriteLine("沒有")
            End If
        Next
        Console.ReadKey()
        Call Main()
    End Sub
    Function Conver(ByVal num As String)
        Dim Ans As Integer = Asc(num) - Asc("A")
        Return Ans
    End Function
End Module
