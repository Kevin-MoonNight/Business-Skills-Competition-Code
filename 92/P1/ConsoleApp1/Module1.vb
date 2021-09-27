Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            Dim n As Integer = 0
            n += Val(Str(3)) '4剛好1個可以裝1箱
            Do While Val(Str(2)) <> 0 And Val(Str(0)) + (27) >= 64 '1跟3的組合 1個3跟27個1剛好可以裝成1箱
                n += 1 : Str(0) = Val(Str(0)) - 37 : Str(2) = Val(Str(2)) - 1
            Loop
            Do Until Val(Str(2)) = 0 '3的組合因為1不夠了 所以只能1個1箱
                n += 1 : Str(2) = Val(Str(2)) - 1
            Loop
            Do Until Val(Str(1)) < 8 '2的組合 8個2剛好可以裝成1箱
                n += 1 : Str(1) = Val(Str(1)) - 8
            Loop
            If (Val(Str(1)) * 2 * 2 * 2) + Val(Str(0)) >= 64 Then '2跟1的組合 將剩下的2跟1組合看能不能裝滿1箱
                n += 1 : Str(0) = Val(Str(0)) - (64 - (Val(Str(1)) * 2 * 2 * 2))
            End If
            Do Until Val(Str(1)) < 64 '1的組合 64個1剛好可以裝成1箱
                n += 1 : Str(0) = Val(Str(0)) - 64
            Loop
            If Val(Str(0)) <> 0 Then '如果1還有剩 就裝成1箱
                n += 1
            End If
            Console.WriteLine(n)
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
End Module
