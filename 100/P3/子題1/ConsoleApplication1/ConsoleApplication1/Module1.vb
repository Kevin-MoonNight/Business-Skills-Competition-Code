Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入測試資料路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim p As Integer
        Input(1, p)
        Dim d(p) As String
        For i = 1 To p
            Input(1, d(i))
        Next
        '判斷
        For i = 1 To p
            Dim text As String
            If conver(10, d(i)) = "1" Then
                text &= "A"
            End If
            If conver(11, d(i)) = "1" Then
                text &= "B"
            End If
            If conver(12, d(i)) = "1" Then
                text &= "C"
            End If
            If conver(13, d(i)) = "1" Then
                text &= "D"
            End If
            If conver(14, d(i)) = "1" Then
                text &= "E"
            End If
            If conver(15, d(i)) = "1" Then
                text &= "F"
            End If
            If conver(16, d(i)) = "1" Then
                text &= "G"
            End If
            If conver(17, d(i)) = "1" Then
                text &= "H"
            End If
            If conver(34, d(i)) = "1" Then
                text &= "I"
            End If
            If conver(18, d(i)) = "1" Then
                text &= "J"
            End If
            If conver(19, d(i)) = "1" Then
                text &= "K"
            End If
            If conver(20, d(i)) = "1" Then
                text &= "L"
            End If
            If conver(21, d(i)) = "1" Then
                text &= "M"
            End If
            If conver(22, d(i)) = "1" Then
                text &= "N"
            End If
            If conver(35, d(i)) = "1" Then
                text &= "O"
            End If
            If conver(23, d(i)) = "1" Then
                text &= "P"
            End If
            If conver(24, d(i)) = "1" Then
                text &= "Q"
            End If
            If conver(25, d(i)) = "1" Then
                text &= "R"
            End If
            If conver(26, d(i)) = "1" Then
                text &= "S"
            End If
            If conver(27, d(i)) = "1" Then
                text &= "T"
            End If
            If conver(28, d(i)) = "1" Then
                text &= "U"
            End If
            If conver(29, d(i)) = "1" Then
                text &= "V"
            End If
            If conver(32, d(i)) = "1" Then
                text &= "W"
            End If
            If conver(30, d(i)) = "1" Then
                text &= "X"
            End If
            If conver(31, d(i)) = "1" Then
                text &= "Y"
            End If
            If conver(33, d(i)) = "1" Then
                text &= "Z"
            End If
            '輸出
            Console.WriteLine(text)
            text = ""
        Next
        Console.ReadKey()
        Call Main()
    End Sub
    Function conver(ByVal p As String, ByVal d As String) As String
        '將判斷p跟測試資料組合在一起進行運算
        Dim text = p & d
        Dim n As String = 19876543211
        Dim ans As Integer
        For j = 1 To 11
            ans += Val(Mid(text, j, 1)) * Val(Mid(n, j, 1))
        Next
        '如果運算結果不能被10整除 就回傳0
        If ans Mod 10 = 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Module
