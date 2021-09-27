Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        '輸入
        Dim Txt(99) As String
        Dim AA As Integer = 1
        Do Until EOF(1)
            Txt(AA) = LineInput(1)
            AA += 1
        Loop
        '判斷
        For i = 1 To AA
            If Txt(i) <> "" Then
                Dim T As Boolean = False
                For j = 0 To UBound(Split(Txt(i), " "))
                    If Output(Split(Txt(i), " ")(j)) = True Then
                        T = True : Exit For
                    End If
                Next
                If T = True Then
                    Console.WriteLine("有")
                Else
                    Console.WriteLine("沒有")
                End If
            End If
        Next
        Console.ReadKey()
        Call Main()
    End Sub
    Function Output(ByVal Txt As String) As Boolean
        '如果開頭是數字
        For i = 1 To Len(Txt)
            If IsNumeric(Mid(Txt, i, 1)) = True Then
                For j = i + 1 To Len(Txt)
                    '如果有大寫英文
                    If Asc(Mid(Txt, j, 1)) >= Asc("A") And Asc(Mid(Txt, j, 1)) <= Asc("Z") Then
                        For K = j + 1 To Len(Txt)
                            '如果是數字結尾
                            If IsNumeric(Mid(Txt, K, 1)) = True Then
                                Return True
                            End If
                        Next
                    End If
                Next
            End If
        Next
        Return False
    End Function
End Module
