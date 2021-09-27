Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim Box(999) As Integer
        Dim AA As Integer = 0
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            If Str(0) = "Insert" Then '插入
                AA += 1
                Box(AA) = Val(Str(1))
            ElseIf Str(0) = "Inquire" Then '輸出
                If Box(Val(Str(1))) <> 0 Then
                    Console.WriteLine(Box(Val(Str(1))))
                End If
            ElseIf Str(0) = "Clean" Then '清除所有
                AA = 0
                ReDim Box(999)
            ElseIf Str(0) = "End" Then
                Exit Do
            End If
            '排序
            For i = 1 To AA
                For j = 1 To AA
                    If Box(i) > Box(j) Then
                        Dim ST As Integer
                        ST = Box(i)
                        Box(i) = Box(j)
                        Box(j) = ST
                    End If
                Next
            Next
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
