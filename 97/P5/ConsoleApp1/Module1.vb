Module Module1
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            Dim P(4) As Point
            Dim m(2) As Double
            P(1).X = Str(0) : P(1).Y = Str(1)
            P(2).X = Str(2) : P(2).Y = Str(3)
            P(3).X = Str(4) : P(3).Y = Str(5)
            P(4).X = Str(6) : P(4).Y = Str(7)
            Dim a, b, c, d, e, f As Double
            a = (P(2).Y - P(1).Y) / (P(2).X - P(1).X) * -1
            b = 1
            c = P(1).Y + ((P(2).Y - P(1).Y) / (P(2).X - P(1).X)) * (-1 * P(1).X)

            d = (P(4).Y - P(3).Y) / (P(4).X - P(3).X) * -1
            e = 1
            f = P(3).Y + ((P(4).Y - P(3).Y) / (P(4).X - P(3).X)) * (-1 * P(3).X)
            If b = e * (a / d) And c = f * (a / d) Then '如果重疊
                Console.WriteLine("L")
            ElseIf a / b = d / e Then '平行
                Console.WriteLine("N")
            Else
                Console.WriteLine("I")
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
