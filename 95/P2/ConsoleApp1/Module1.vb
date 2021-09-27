Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer = LineInput(1)
        For I = 1 To N
            Dim Stack As New Stack
            Stack.Clear()
            Dim Str As String = LineInput(1)
            Dim T As Boolean = False
            For j = 1 To Len(Str)
                If Mid(Str, j, 1) = "(" Then
                    Stack.Push("(")
                ElseIf Mid(Str, j, 1) = "[" Then
                    Stack.Push("[")
                ElseIf Mid(Str, j, 1) = ")" Then
                    If Stack.Count = 0 Then
                        T = True : Exit For
                    End If
                    Do Until Stack.Peek = "("
                        Stack.Pop()
                        If Stack.Count = 0 Then
                            T = True : Exit For
                        End If
                    Loop
                    Stack.Pop()
                ElseIf Mid(Str, j, 1) = "]" Then
                    If Stack.Count = 0 Then
                        T = True : Exit For
                    End If
                    Do Until Stack.Peek = "["
                        Stack.Pop()
                        If Stack.Count = 0 Then
                            T = True : Exit For
                        End If
                    Loop
                    Stack.Pop()
                End If
            Next
            If Stack.Count = 0 And T = False Then
                Console.WriteLine("Yes")
            Else
                Console.WriteLine("No")
            End If
        Next
            FileClose()
        Console.ReadLine()
        Call Main()
    End Sub
End Module
