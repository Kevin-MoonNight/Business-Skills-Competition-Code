Module Module1

    Sub Main()
        '輸出
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim p As Integer
        Input(1, p)
        Dim d(p) As String
        For i = 1 To p
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To p
            Dim num As String = d(i)
            Dim T As String = ""
            '判斷是幾號
            Do Until num = ""
                If Mid(num, 1, 2) = "00" Then
                    num = Mid(num, 3, Len(num) - 2)
                    T &= 0
                ElseIf Mid(num, 1, 2) = "01" Then
                    num = Mid(num, 3, Len(num) - 2)
                    T &= 1
                ElseIf Mid(num, 1, 3) = "100" Then
                    num = Mid(num, 4, Len(num) - 3)
                    T &= 2
                ElseIf Mid(num, 1, 3) = "101" Then
                    num = Mid(num, 4, Len(num) - 3)
                    T &= 3
                ElseIf Mid(num, 1, 4) = "1100" Then
                    num = Mid(num, 5, Len(num) - 4)
                    T &= 4
                ElseIf Mid(num, 1, 4) = "1101" Then
                    num = Mid(num, 5, Len(num) - 4)
                    T &= 5
                ElseIf Mid(num, 1, 5) = "11100" Then
                    num = Mid(num, 6, Len(num) - 5)
                    T &= 6
                ElseIf Mid(num, 1, 5) = "11101" Then
                    num = Mid(num, 6, Len(num) - 5)
                    T &= 7
                ElseIf Mid(num, 1, 6) = "111100" Then
                    num = Mid(num, 7, Len(num) - 6)
                    T &= 8
                ElseIf Mid(num, 1, 6) = "111101" Then
                    num = Mid(num, 7, Len(num) - 6)
                    T &= 9
                End If
            Loop
            '將號碼對應到字母
            If T = "01" Then
                T = "D"
            ElseIf T = "02" Then
                T = "E"
            ElseIf T = "03" Then
                T = "F"
            ElseIf T = "04" Then
                T = "G"
            ElseIf T = "05" Then
                T = "H"
            ElseIf T = "06" Then
                T = "I"
            ElseIf T = "07" Then
                T = "J"
            ElseIf T = "08" Then
                T = "K"
            ElseIf T = "09" Then
                T = "L"
            ElseIf T = "10" Then
                T = "M"
            ElseIf T = "11" Then
                T = "N"
            ElseIf T = "12" Then
                T = "O"
            ElseIf T = "13" Then
                T = "P"
            ElseIf T = "14" Then
                T = "Q"
            ElseIf T = "15" Then
                T = "R"
            ElseIf T = "16" Then
                T = "S"
            ElseIf T = "17" Then
                T = "T"
            ElseIf T = "18" Then
                T = "U"
            ElseIf T = "19" Then
                T = "V"
            ElseIf T = "20" Then
                T = "W"
            ElseIf T = "21" Then
                T = "X"
            ElseIf T = "22" Then
                T = "Y"
            ElseIf T = "23" Then
                T = "Z"
            ElseIf T = "24" Then
                T = "A"
            ElseIf T = "25" Then
                T = "B"
            ElseIf T = "26"
                T = "C"
            End If
            '輸出
            Console.WriteLine(T)
        Next
        Call Main()
    End Sub
End Module
