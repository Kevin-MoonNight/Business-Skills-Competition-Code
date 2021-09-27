Module Module1
    Sub Main()
        '輸入
        Console.Write("輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        Dim text, Pt As String
        Do Until EOF(1) = True
            Input(1, Pt)
            text &= Pt & ","
        Loop
        Dim d() As String = Strings.Replace(text, "{", "").ToString.Split("}")
        FileClose()
        '執行
        For i = 0 To n - 1
            '用來判斷出現的數字
            Dim T(9) As Integer
            '分割數字
            text = d(i * 2) & d(i * 2 + 1)
            Dim num() As String = Split(text, ",")
            '聯集
            '判斷
            For j = 0 To UBound(num)
                If IsNumeric(num(j)) = True Then
                    T(num(j)) += 1
                End If
            Next
            text = ""
            For j = 0 To 9
                If T(j) <> 0 Then
                    text &= j & ","
                End If
            Next
            '輸出
            ans(text)
            '交集
            text = ""
            For J = 0 To 9
                If T(J) > 1 Then
                    text &= J & ","
                End If
            Next
            '輸出
            ans(text)
            '差集
            text = ""
            For j = 0 To UBound(num) \ 2
                If num(j) <> "" Then
                    If T(num(j)) = 1 Then
                        text &= num(j) & ","
                    End If
                End If
            Next
            '輸出
            ans(text)
            '對稱差集
            text = ""
            For j = 0 To 9
                If T(j) = 1 Then
                    text &= j & ","
                End If
            Next
            '輸出
            If text = "" Then
                Console.WriteLine("N")
            Else
                Console.WriteLine("{" & Mid(text, 1, Len(text) - 1) & "}")
            End If
        Next
        Call Main()
    End Sub
    Sub ans(ByVal text As String)
        If text = "" Then
            Console.Write("N,")
        Else
            Console.Write("{" & Mid(text, 1, Len(text) - 1) & "},")
        End If
    End Sub
End Module
