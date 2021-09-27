Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim arr(9, 9) As Integer
        Dim Str() As String
        For i = 1 To 9
            Str = Split(LineInput(1), " ")
            For j = 0 To UBound(Str)
                arr(i, j + 1) = Val(Str(j))
            Next
        Next
        Str = Split(LineInput(1), " ")
        Do Until Str(0) = "0" And Str(1) = "0"
            Dim Ans As String = ""
            For i = 1 To 9 '每個數字下去判斷            
                If arr(Val(Str(1)), Val(Str(0))) = 0 Then
                    If P(arr, i, Val(Str(1)), Val(Str(0))) = True Then
                        Ans &= i & " "
                    End If
                End If
            Next
            If ans = "" Then
                Console.Write("0")
            End If
            Console.WriteLine(Ans)
            Str = Split(LineInput(1), " ")
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function P(ByVal arr(,) As Integer, ByVal n As Integer, ByVal I As Integer, ByVal J As Integer) As Boolean
        For k = 1 To 9 '十字判斷
            If arr(I, k) = n Or arr(k, J) = n Then
                Return False
            End If
        Next
        Dim x, y As Integer
        For k = 0 To 2
            If I >= k * 3 + 1 And I <= (k + 1) * 3 Then
                x = k
            End If
            If J >= k * 3 + 1 And J <= (k + 1) * 3 Then
                y = k
            End If
        Next
        For k = (x * 3) + 1 To ((x + 1) * 3)  '九格判斷
            For l = (y * 3) + 1 To ((y + 1) * 3)
                If arr(k, l) = n Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
End Module
