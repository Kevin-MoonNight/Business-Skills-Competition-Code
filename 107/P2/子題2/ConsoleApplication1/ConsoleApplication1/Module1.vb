Module Module1
    Dim n As Integer
    Dim ans As Integer
    Dim num() As String
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        Dim d(P) As String
        For i = 1 To P
            d(i) = LineInput(1)
        Next
        FileClose()
        For i = 1 To P
            num = Split(d(i), ",")
            '幾筆x
            n = num(0)
            '第num(UBound(num))個組和
            ans = num(UBound(num))
            conver("")
        Next
        Call Main()
    End Sub
    Function conver(ByVal text As String)
        If Len(text) = n Then
            ans -= 1
            '輸出第ans個組合
            If ans = 0 Then
                Console.WriteLine(text)
            End If
        End If
        '組合
        For i = 1 To UBound(num) - 1
            If InStr(text, num(i)) = 0 Then
                conver(text & num(i))
            End If
        Next
    End Function
End Module
