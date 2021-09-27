Module Module1
    Dim Ans As Boolean
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Do Until n = 0
            Dim Str() As String = Split(LineInput(1), " ")
            Dim Num(n) As Integer
            For i = 0 To UBound(Str)
                Num(i + 1) = Val(Str(i))
            Next
            Dim T As Integer = -1
            Ans = False
            Do Until Ans = True
                Dim T_Num(n) As Boolean
                Ans = False : T += 1
                DFS(T, Num, T_Num)
            Loop
            Console.WriteLine(T)
            n = LineInput(1)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function DFS(ByVal n As Integer, ByVal Num() As Integer, ByVal T_Num() As Boolean)
        If n < 0 Then
            Exit Function
        End If
        If P(Num, T_Num) = True And n = 0 Then '如果遞增成立
            Ans = True
        Else
            For i = 1 To UBound(Num)
                If T_Num(i) = False Then
                    T_Num(i) = True
                    DFS(n - 1, Num, T_Num)
                    T_Num(i) = False
                End If
            Next
        End If
    End Function
    Function P(ByVal Num() As Integer, ByVal T_Num() As Boolean) As Boolean
        Dim ST As Integer = Num(0)
        For i = 1 To UBound(Num)
            If T_Num(i) = False Then
                If ST < Num(i) Then
                    ST = Num(i)
                Else
                    Return False
                End If
            End If
        Next
        Return True
    End Function
End Module
