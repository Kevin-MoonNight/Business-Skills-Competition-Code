Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Arr As New ArrayList : Arr.Clear()
        Dim n As String = Val(LineInput(1))
        Do Until Arr.Contains(n) = True '如果出現重複
            Arr.Add(n)
            Console.WriteLine(Val(n) & vbTab & Val(n) ^ 2) '輸出
            n = Val(n) ^ 2
            If Val(n) > 10 Then
                Dim Max, Min As Integer : Max = Integer.MinValue : Min = Integer.MaxValue
                For i = 1 To Len(n) '找最大跟最小
                    If Val(Mid(n, i, 1)) > Max Then
                        Max = Val(Mid(n, i, 1))
                    End If
                    If Val(Mid(n, i, 1)) < Min Then
                        Min = Val(Mid(n, i, 1))
                    End If
                Next
                n = Val(Min.ToString & Max.ToString) '合併
            End If
        Loop
        Console.WriteLine("*" & Val(n) & vbTab & Val(n) ^ 2) '輸出
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
