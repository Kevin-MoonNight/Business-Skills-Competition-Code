Module Module1
    Dim Num(9999) As Integer
    Dim Theend As Boolean
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        For i = 1 To n
            Dim Str() As String = Split(LineInput(1), " ")
            Dim AA As Integer
            Dim T As Integer = 0
            Dim Max As Integer = Integer.MinValue
            AA = 0
            For j = 1 To UBound(Str)
                If Str(j) <> 0 Then
                    AA += 1
                    Num(AA) = Val(Str(j))
                    T += Num(AA)
                    If Num(AA) > Max Then
                        Max = Num(AA)
                    End If
                End If
            Next
            Theend = False
            If T / 4 = Int(T / 4) And Max <= T / 4 Then
                Dim T_Num(Val(Str(0))) As Boolean
                DFS(T / 4, 0, T_Num, 0)
            Else
                Console.WriteLine("0")
            End If
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function DFS(ByVal Goal As Integer, ByVal n As Integer, ByVal T_Num() As Boolean, ByVal All As Integer)
        If Theend = True Then
            Exit Function
        End If
        If All = 4 Then '判斷是否已經集滿4個邊
            For I = 1 To UBound(T_Num) '判斷是否全部棍子都有用到
                If T_Num(I) = False Then
                    Console.WriteLine("0")
                End If
            Next
            Console.WriteLine("1")
            Theend = True
        Else
            For I = 1 To UBound(T_Num)
                If T_Num(I) = False And Num(I) + n <= Goal Then '確定這根棍子沒用過 and 不超過目標長度
                    T_Num(I) = True
                    If Num(I) + n = Goal Then
                        DFS(Goal, 0, T_Num, All + 1) '如果長度夠
                    Else
                        DFS(Goal, Num(I) + n, T_Num, All)
                    End If
                    T_Num(I) = False
                End If
            Next
        End If
    End Function
End Module
