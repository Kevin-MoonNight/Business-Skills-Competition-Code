Module Module1
    Dim Txt As String = "肉菜蛋果"
    Dim Num(), D() As Integer
    Dim Ansnum(999) As String
    Dim Money(999) As Integer
    Dim AA As Integer
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, "C:\Users\User\Desktop\商科歷屆題目\99 商業類技藝競賽模擬試題\99程式設計_模擬_術科_輸出入檔\in-4-1.txt", OpenMode.Input)
        Dim Str() As String = Split(LineInput(1), ",")
        ReDim Num(UBound(Str) + 1), D(UBound(Str) + 1)
        For i = 0 To UBound(Str)
            Num(i + 1) = Val(Str(i))
        Next
        Str = Split(LineInput(1), ",")
        For i = 0 To UBound(Str)
            D(i + 1) = Val(Str(i))
        Next
        FileClose()
        AA = 0
        FS("")
        '排大小
        For I = 1 To AA
            For J = 1 To AA
                If Money(J) < Money(I) Then
                    Dim ST As String = Money(J)
                    Money(J) = Money(I)
                    Money(I) = ST
                    ST = Ansnum(J)
                    Ansnum(J) = Ansnum(I)
                    Ansnum(I) = ST
                End If
            Next
        Next
        For I = 1 To AA
            Console.WriteLine(Ansnum(I))
        Next
        Console.ReadLine()
        Call Main()
    End Sub
    Function FS(ByVal Str As String)
        If Len(Str) = 4 Then
            AA += 1
            Ansnum(AA) = Str & " " & Conver(Str) : Money(AA) = Conver(Str)
        Else
            For I = 1 To Len(Txt)
                If InStr(Str, Mid(Txt, I, 1)) = 0 Then
                    FS(Str & Mid(Txt, I, 1))
                End If
            Next
        End If
    End Function
    Function Conver(ByVal Str As String) As Integer
        Dim Ans As Integer = 0
        For i = 1 To Len(Str)
            For j = 1 To Len(Txt)
                If Mid(Txt, j, 1) = Mid(Str, i, 1) Then
                    Ans += Num(j) * D(i)
                End If
            Next
        Next
        Return Ans
    End Function
End Module
