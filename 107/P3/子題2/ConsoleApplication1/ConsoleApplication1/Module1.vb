Module Module1
    Sub Main()
        '輸入
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
            Dim num() As String = Split(d(i), " ")
            Dim amin, amax, bmin, bmax, mmin, mmax As Integer
            '帶入比較值
            amin = num(0) : amax = num(1) : bmin = num(2) : bmax = num(3) : mmin = num(4) : mmax = num(5)
            Dim n As Integer = 0
            For a = amin To amax
                For b = bmin To bmax
                    For m = mmin To mmax
                        Dim n1, n2 As Integer
                        n1 = 0 : n2 = 0
                        '計算
                        n1 = (a + b) Mod m
                        n2 = conver(a - b, m)
                        '判斷
                        If n1 = n2 Then
                            n += 1
                        End If
                    Next
                Next
            Next
            '輸出次數
            Console.WriteLine(n)
        Next
        Call Main()
    End Sub
    Function conver(ByVal num As Integer, ByVal m As Integer)
        Dim n2 As Integer
        '如果是負數就一直加
        If num < 0 Then
            n2 = num
            '加到餘數大於m本身就中斷迴圈
            Do Until n2 >= m
                n2 += m
            Loop
            '最後再把多加的一次去掉
            n2 -= m
        Else
            n2 = (num) Mod m
        End If
        Return n2
    End Function
End Module
