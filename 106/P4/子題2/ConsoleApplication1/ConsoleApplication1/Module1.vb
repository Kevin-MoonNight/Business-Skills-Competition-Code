Module Module1
    Dim ans As String = ""
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For i = 1 To P
            '輸入路徑
            Dim Tree(99, 99) As Integer
            Dim TheEnd As Integer = 0
            Dim d As String = ""
            Do Until d = "0"
                d = LineInput(1)
                Dim num() As String = Split(d, ",")
                If d <> "0" Then
                    '如果第二個是99那第一個是該樹的根結點
                    If num(1) = "99" Then
                        TheEnd = Val(num(0))
                    Else
                        Tree(Val(num(0)), Val(num(1))) = 1 : Tree(Val(num(1)), Val(num(0))) = 1
                    End If
                End If
            Loop
            '尋找樹葉節點
            For j = 0 To 99
                Dim n As Integer = 0
                For k = 0 To 99
                    If Tree(j, k) = 1 Then
                        n += 1
                    End If
                Next
                '如果是樹葉節點就執行
                If n = 1 And j <> TheEnd Then
                    ans = ""
                    DFS(j, -1, "", TheEnd, Tree)
                    '判斷路徑
                    If ans <> "" Then
                        ans = j & ":" & "{" & Mid(ans, 1, Len(ans) - 1) & "}"
                    Else
                        ans = j & ":" & "N"
                    End If
                    '輸出
                    Console.WriteLine(ans)
                End If
            Next
            Console.WriteLine()
        Next
        FileClose()
        Call Main()
    End Sub
    Function DFS(ByVal i As Integer, ByVal Last As Integer, ByVal str As String, ByVal TheEnd As Integer, ByVal Tree(,) As Integer) As String
        For j = 0 To 99
            If Tree(i, j) = 1 And j <> Last Then
                '如果走到根結點 就回傳路徑
                If j = TheEnd Then
                    ans = str
                End If
                '找到路就一直走下去直到走到根結點
                DFS(j, i, str & j & ",", TheEnd, Tree)
            End If
        Next
    End Function
End Module
