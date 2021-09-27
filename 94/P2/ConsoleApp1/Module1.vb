Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim n As Integer = LineInput(1)
        Dim flower(4) As Integer
        Dim Ans As Integer = 0
        flower(1) = n \ 50 : n -= flower(1) * 50
        flower(2) = n \ 10 : n -= flower(2) * 10
        flower(3) = n \ 5 : n -= flower(3) * 5
        flower(4) = n \ 1 : n -= flower(1) * 1
        For i = 1 To 4
            Ans += flower(i)
        Next
        Console.WriteLine(Ans)
        For i = 1 To 4
            Console.WriteLine(flower(i))
        Next
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
