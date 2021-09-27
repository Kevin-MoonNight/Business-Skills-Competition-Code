Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim S(P) As String
        For i = 1 To P
            Input(1, S(i))
        Next
        FileClose()
        '執行
        For J = 1 To P
            Dim I, V, X, L, C, D, M As Integer
            I = 1 : V = 5 : X = 1 : L = 5 : C = 1 : D = 5 : M = 1
            Dim str As String = ""
            '從千位百位十位個位一個一個取
            For K = 1 To Len(S(J))
                Dim num As String = Val(Mid(S(J), K, 1)) * (10 ^ (Len(S(J)) - K))
                '判斷
                If Len(num) = 4 Then
                    str &= conver(Mid(num, 1, 1), "M", "", "")
                ElseIf Len(num) = 3
                    str &= conver(Mid(num, 1, 1), "C", "D", "M")
                ElseIf Len(num) = 2
                    str &= conver(Mid(num, 1, 1), "X", "L", "C")
                ElseIf Len(num) = 1
                    str &= conver(Mid(num, 1, 1), "I", "V", "X")
                End If
            Next
            '輸出
            Console.WriteLine(str)
        Next
        Call Main()
    End Sub
    Function conver(ByVal num As Integer, ByVal num1 As String, ByVal num2 As String, ByVal num3 As String) As String
        Dim str As String = ""
        If num <= 3 Then
            For L = 1 To num
                str &= num1
            Next
        ElseIf num = 4
            str &= num1 & num2
        ElseIf num = 9
            For L = 1 To 1
                str &= num1
            Next
            str &= num3
        ElseIf num >= 5
            str &= num2
            For L = 1 To num - 5
                str &= num1
            Next
        End If
        Return str
    End Function
End Module
