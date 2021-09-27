Module Module1
    Dim Txt As String = "肉菜蛋果"
    Dim n As Integer
    Dim AnsTxt(999) As String
    Dim D() As Integer
    Dim Money(999) As Integer
    Dim AA As Integer
    Dim arr As New ArrayList
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Input(1, n)
        Dim Str() As String = Split(LineInput(1), ",")
        ReDim D(UBound(Str) + 1)
        For I = 0 To UBound(Str)
            D(I + 1) = Val(Str(I))
        Next
        FileClose()
        AA = 0
        arr.Clear()
        DFS("")
        '排大小
        For I = 1 To AA
            For J = 1 To AA
                If Money(J) < Money(I) Then
                    Dim ST As String = Money(I)
                    Money(I) = Money(J)
                    Money(J) = ST
                    ST = AnsTxt(I)
                    AnsTxt(I) = AnsTxt(J)
                    AnsTxt(J) = ST
                End If
            Next
        Next
        For I = 1 To AA
            Console.WriteLine(Conver3(AnsTxt(I)) & vbTab & Money(I))
        Next
        Console.ReadKey()
        Call Main()
    End Sub
    Function DFS(ByVal Str As String)
        If Len(Str) = 2 Then
            If Conver2(Str) = False Then
                AA += 1
                AnsTxt(AA) = Str
                Money(AA) = Conver(Str)
            End If
        Else
            For I = 1 To Len(Txt)
                If InStr(Str, Mid(Txt, I, 1)) = 0 Then
                    DFS(Str & Mid(Txt, I, 1))
                End If
            Next
        End If
    End Function
    Function Conver3(ByVal Str As String)
        Dim T(4) As Boolean
        For i = 1 To Len(Str)
            For j = 1 To 4
                If Mid(Txt, j, 1) = Mid(Str, i, 1) Then
                    T(j) = True
                End If
            Next
        Next
        Dim Ans As String = ""
        For i = 1 To 4
            If T(i) = True Then
                Ans &= "(" & Mid(Txt, i, 1) & ")"
            Else
                Ans &= Mid(Txt, i, 1)
            End If
        Next
        Return Ans
    End Function
    Function Conver2(ByVal Str As String)
        Dim T(4) As Boolean
        For i = 1 To Len(Str)
            For j = 1 To 4
                If Mid(Txt, j, 1) = Mid(Str, i, 1) Then
                    T(j) = True
                End If
            Next
        Next
        For i = 0 To arr.Count - 1
            Dim P As Boolean = False
            For j = 1 To 4
                If arr(i)(j) <> T(j) Then
                    arr.Add(T)
                    P = True
                End If
            Next
            If P = False Then
                Return True
            End If
        Next
        If arr.Count = 0 Then
            arr.Add(T)
        End If
        Return False
    End Function
    Function Conver(ByVal Str As String)
        Dim Ans As Integer = 0
        For i = 1 To Len(Str)
            For j = 1 To Len(Txt)
                If Mid(Str, i, 1) = Mid(Txt, j, 1) Then
                    Ans += D(j)
                End If
            Next
        Next
        Return Ans
    End Function
End Module
