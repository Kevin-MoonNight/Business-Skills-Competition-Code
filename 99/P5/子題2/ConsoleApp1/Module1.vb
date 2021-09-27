Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer
        Input(1, n)
        FileClose()
        For i = 1 To n
            If Conver(i) = True Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadKey()
        Call Main()
    End Sub
    Function Conver(ByVal n As Integer)
        Dim Ans As Integer = 0
        For i = 1 To n - 1
            If n Mod i = 0 Then
                Ans += i
            End If
        Next
        If Ans = n Then
            Return True
        End If
    End Function
End Module
