Module Module1
    Dim Max As Integer
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim d(9999) As String
        Dim AA As Integer
        AA = 0
        Do Until EOF(1)
            AA += 1
            d(AA) = LineInput(1)
        Loop
        For i = 1 To AA Step 2
            Max = Integer.MinValue
            Dim Str() As String = Split(d(i), " ")
            Dim n As Integer = Val(Str(0)) - Val(Str(1)) '要剩下幾個
            Dim T_Num(Val(Str(0))) As Boolean '用來判斷使用過的數字
            DFS("", n, T_Num, Val(d(i + 1)), 0) '將每種可能試過一次
            Console.WriteLine(Max) '輸出
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function DFS(ByVal Num As String, ByVal n As Integer, ByVal T_Num() As Boolean, ByVal Txt As String, ByVal i As Integer) As Integer
        If Val(Num) > Max And n = 0 Then '如果比之前的組合還大
            Max = Val(Num) '輸出
        Else
            For j = 1 To Len(Txt)
                If T_Num(j) = False And j > i Then '數字要沒使用過 且不能比上個位數要大
                    T_Num(j) = True
                    DFS(Num & Mid(Txt, j, 1), n - 1, T_Num, Txt, j)
                    T_Num(j) = False
                End If
            Next
        End If
    End Function
End Module
