Module Module1
    Sub Main()
        '輸出
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For i = 1 To P
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To P
            Dim text() As String = Split(d(i), "=")
            Dim num1, num2 As String
            '化減
            num1 = conver(text(0))
            num2 = conver(text(1))
            Dim ans1, ans2 As Integer
            Dim T() As String = Split(num1, "x")
            '移項
            '左邊
            ans1 = Val(T(0))
            ans2 = Val(T(1)) * -1
            '右邊
            T = Split(num2, "x")
            ans1 += Val(T(0)) * -1
            ans2 += Val(T(1))
            '輸出
            If ans1 = 1 Then
                Console.WriteLine(ans2)
            ElseIf num1 = num2 Then
                Console.WriteLine("IS")
            ElseIf ans1 = 0
                Console.WriteLine("NS")
            Else
                Console.WriteLine(ans2 / ans1)
            End If
        Next
        Call Main()
    End Sub
    Function conver(ByVal text As String) As String
        '化簡
        Dim num1, num2 As Double '儲存x跟數字
        Dim ans As String '儲存輸出
        '將數字先分割出來
        Dim num() As String = Strings.Replace(text, "-", "+").ToString.Split("+")
        '儲存運算元
        Dim T(999) As String
        Dim n As Integer = 0
        '將運算元分割出來
        For J = 1 To Len(text)
            If IsNumeric(Mid(text, J, 1)) = False And Mid(text, J, 1) <> "x" Then
                n += 1
                T(n) = Mid(text, J, 1)
            End If
        Next
        '化簡
        For j = 0 To UBound(num)
            '如果是x
            If IsNumeric(num(j)) = False Then
                '如果是1x補上1
                If Mid(num(j), 1, Len(num(j)) - 1) = "" Then
                    num(j) = "1x"
                End If
                '把x去掉放到左邊
                If j = 0 Then
                    num1 += Val(Mid(num(j), 1, Len(num(j)) - 1))
                ElseIf T(j) = "+"
                    num1 += Val(Mid(num(j), 1, Len(num(j)) - 1))
                ElseIf T(j) = "-"
                    num1 -= Val(Mid(num(j), 1, Len(num(j)) - 1))
                End If
            Else
                If j = 0 Then
                    num2 += Val(num(j))
                ElseIf T(j) = "+"
                    num2 += Val(num(j))
                ElseIf T(j) = "-"
                    num2 -= Val(num(j))
                End If
            End If
        Next
        '如果數字是0
        If num2 = 0 Then
            ans = num1 & "x"
        ElseIf num2 > 0
            ans = num1 & "x+" & num2
        ElseIf num2 < 0
            ans = num1 & "x" & num2
        End If
        Return ans
    End Function
End Module
