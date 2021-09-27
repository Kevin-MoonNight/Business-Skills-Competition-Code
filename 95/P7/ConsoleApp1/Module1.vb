Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            Dim n As Integer = Val(Str(0))
            Dim Px(n), Dog, Miki As Point
            Miki.X = Val(Str(1)) : Miki.Y = Val(Str(2)) : Dog.X = Val(Str(3)) : Dog.Y = Val(Str(4))
            For i = 1 To n
                Dim Txt() As String = Split(LineInput(1), " ")
                Px(i).X = Val(Txt(0)) : Px(i).Y = Val(Txt(1))
            Next
            Dim Min As Integer = 0
            For i = 1 To n
                If Math.Sqrt((Miki.X - Px(i).X) ^ 2 + (Miki.Y - Px(i).Y) ^ 2) * 2 < Math.Sqrt((Dog.X - Px(i).X) ^ 2 + (Dog.Y - Px(i).Y) ^ 2) Then
                    If Min = 0 Then
                        Min = i
                    Else
                        If Math.Sqrt((Miki.X - Px(i).X) ^ 2 + (Miki.Y - Px(i).Y) ^ 2) < Math.Sqrt((Miki.X - Px(Min).X) ^ 2 + (Miki.Y - Px(Min).Y) ^ 2) Then
                            Min = i
                        End If
                    End If
                End If
            Next
            If Min = 0 Then
                Console.WriteLine("田鼠無法逃走")
            Else
                Console.WriteLine("田鼠可由" & "(" & Format(Px(Min).X, "0.000") & "," & Format(Px(Min).Y, "0.000") & ")的鼠洞逃走")
            End If
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Structure Point
        Dim X As Double
        Dim Y As Double
    End Structure
End Module
