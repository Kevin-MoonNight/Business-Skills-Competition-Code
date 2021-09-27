Module Module1
    Sub Main()
        '輸出
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For i = 1 To P
            Input(1, d(i))
        Next
        FileClose()
        '執行
        For i = 1 To P
            Dim ans As String = ""
            Dim text() As String = Split(d(i), " ")
            For j = 0 To UBound(text)
                '判斷
                If text(j) = "-----" Then
                    ans &= "0"
                ElseIf text(j) = ".----" Then
                    ans &= "1"
                ElseIf text(j) = "..---" Then
                    ans &= "2"
                ElseIf text(j) = "...--" Then
                    ans &= "3"
                ElseIf text(j) = "....-" Then
                    ans &= "4"
                ElseIf text(j) = "....." Then
                    ans &= "5"
                ElseIf text(j) = "-...." Then
                    ans &= "6"
                ElseIf text(j) = "--..." Then
                    ans &= "7"
                ElseIf text(j) = "---.." Then
                    ans &= "8"
                ElseIf text(j) = "----." Then
                    ans &= "9"
                End If
            Next
            '輸出
            Console.WriteLine(ans)
        Next
        Call Main()
    End Sub
End Module
