Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim N As Integer
        Input(1, N)
        Dim d(N) As String
        For i = 1 To N
            Input(1, d(i))
        Next
        FileClose()

        Dim T, O, F As Integer
        Dim n1, n2 As Integer
        Dim arr As New ArrayList
        For i = 1 To N
            If Mid(d(i), 1, 1) = "A" Then
                n1 = 1 : n2 = 0
            ElseIf Mid(d(i), 1, 1) = "B" Then
                n1 = 1 : n2 = 1
            ElseIf Mid(d(i), 1, 1) = "C" Then
                n1 = 1 : n2 = 2
            ElseIf Mid(d(i), 1, 1) = "D" Then
                n1 = 1 : n2 = 3
            ElseIf Mid(d(i), 1, 1) = "E" Then
                n1 = 1 : n2 = 4
            ElseIf Mid(d(i), 1, 1) = "F" Then
                n1 = 1 : n2 = 5
            ElseIf Mid(d(i), 1, 1) = "G" Then
                n1 = 1 : n2 = 6
            ElseIf Mid(d(i), 1, 1) = "H" Then
                n1 = 1 : n2 = 7
            ElseIf Mid(d(i), 1, 1) = "I" Then
                n1 = 3 : n2 = 4
            ElseIf Mid(d(i), 1, 1) = "J" Then
                n1 = 1 : n2 = 8
            ElseIf Mid(d(i), 1, 1) = "K" Then
                n1 = 1 : n2 = 9
            ElseIf Mid(d(i), 1, 1) = "L" Then
                n1 = 2 : n2 = 0
            ElseIf Mid(d(i), 1, 1) = "M" Then
                n1 = 2 : n2 = 1
            ElseIf Mid(d(i), 1, 1) = "N" Then
                n1 = 2 : n2 = 2
            ElseIf Mid(d(i), 1, 1) = "O" Then
                n1 = 3 : n2 = 5
            ElseIf Mid(d(i), 1, 1) = "P" Then
                n1 = 2 : n2 = 3
            ElseIf Mid(d(i), 1, 1) = "Q" Then
                n1 = 2 : n2 = 4
            ElseIf Mid(d(i), 1, 1) = "R" Then
                n1 = 2 : n2 = 5
            ElseIf Mid(d(i), 1, 1) = "S" Then
                n1 = 2 : n2 = 6
            ElseIf Mid(d(i), 1, 1) = "T" Then
                n1 = 2 : n2 = 7
            ElseIf Mid(d(i), 1, 1) = "U" Then
                n1 = 2 : n2 = 8
            ElseIf Mid(d(i), 1, 1) = "V" Then
                n1 = 2 : n2 = 9
            ElseIf Mid(d(i), 1, 1) = "W" Then
                n1 = 3 : n2 = 2
            ElseIf Mid(d(i), 1, 1) = "X" Then
                n1 = 3 : n2 = 0
            ElseIf Mid(d(i), 1, 1) = "Y" Then
                n1 = 3 : n2 = 1
            ElseIf Mid(d(i), 1, 1) = "Z" Then
                n1 = 3 : n2 = 3
            End If
            '判斷性別
            If Mid(d(i), 2, 1) = 1 Or Mid(d(i), 2, 1) = 2 Then
                '判斷身分證字號
                If ((n1 * 1) + (n2 * 9) + (Mid(d(i), 2, 1) * 8) + (Mid(d(i), 3, 1) * 7) + (Mid(d(i), 4, 1) * 6) + (Mid(d(i), 5, 1) * 5) + (Mid(d(i), 6, 1) * 4) + (Mid(d(i), 7, 1) * 3) + (Mid(d(i), 8, 1) * 2) + (Mid(d(i), 9, 1) * 1) + (Mid(d(i), 10, 1) * 1)) Mod 10 = 0 Then
                    '判斷是否重複出現
                    If arr.Contains(d(i)) = False Then
                        arr.Add(d(i))
                        T += 1
                    Else
                        O += 1
                    End If
                Else
                    F += 1
                End If
            Else
                F += 1
            End If
        Next
        '輸出
        Console.WriteLine(T & "," & O & "," & F)
        Call Main()
    End Sub
    Function conver(ByVal n1 As Integer, ByVal n2 As Integer) As Boolean

    End Function
End Module
