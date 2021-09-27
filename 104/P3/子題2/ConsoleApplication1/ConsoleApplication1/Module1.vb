Module Module1
    Sub Main()
        '輸入
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Dim P As Integer
        Input(1, P)
        '執行
        For i = 1 To P
            Dim m, r, n As Integer
            Input(1, m) : Input(1, r) : Input(1, r) : Input(1, n)
            Dim A(m, r), B(r, n), AB(m, n) As Integer
            '輸入資料A
            Dim text As String
            For J = 1 To m
                Input(1, text)
                Dim num() As String = Strings.Replace(text, "    ", " ").ToString.Replace("   ", " ").ToString.Replace("  ", " ").ToString.Replace(vbTab, " ").ToString.Split(" ")
                For k = 0 To UBound(num)
                    A(J, k + 1) = num(k)
                Next
            Next
            '輸入資料B
            For J = 1 To r
                Input(1, text)
                Dim num() As String = Strings.Replace(text, "    ", " ").ToString.Replace("   ", " ").ToString.Replace("  ", " ").ToString.Replace(vbTab, " ").ToString.Split(" ")
                For k = 0 To UBound(num)
                    B(J, k + 1) = num(k)
                Next
            Next
            '輸入資料AB
            For J = 1 To m
                Input(1, text)
                Dim num() As String = Strings.Replace(text, "    ", " ").ToString.Replace("   ", " ").ToString.Replace("  ", " ").ToString.Replace(vbTab, " ").ToString.Split(" ")
                For k = 0 To UBound(num)
                    AB(J, k + 1) = num(k)
                Next
            Next
            '尋找矩陣A
            '尋找需要修正的值
            Dim tmpi, tmpj As Integer
            '紀錄修正值的座標
            tmpi = 0 : tmpj = 0
            For j = 1 To m
                For k = 1 To r
                    If A(j, k) = 9999 Then
                        tmpi = j : tmpj = k
                    End If
                Next
            Next
            '計算正確值
            If tmpi <> 0 And tmpj <> 0 Then
                '存放除了修正值以外的矩陣相乘總和
                Dim ans As Integer = 0
                '防止出現0的情況
                '用來暫時存放
                Dim st As Integer = tmpi
                Do Until B(tmpj, st) <> 0
                    st += 1
                Loop
                '計算除了修正值以外的矩陣相乘總和
                For j = 1 To r
                    If j <> tmpj Then
                        ans += A(tmpi, j) * B(j, st)
                    End If
                Next
                '計算修正後的數值  
                A(tmpi, tmpj) = (AB(tmpi, st) - ans) / B(tmpj, st)
                Console.WriteLine(A(tmpi, tmpj))
                Continue For
            End If
            '尋找矩陣B
            '尋找需要修正的值
            tmpi = 0 : tmpj = 0   '紀錄修正值的座標
            For j = 1 To r
                For k = 1 To n
                    If B(j, k) = 9999 Then
                        tmpi = j : tmpj = k
                    End If
                Next
            Next
            '計算正確值
            If tmpi <> 0 And tmpj <> 0 Then
                Dim ans As Integer = 0 '存放除了修正值以外的矩陣相乘總和
                '防止出現0的情況
                Dim st As Integer = tmpj '用來暫時存放
                Do Until A(st, tmpi) <> 0
                    st += 1
                Loop
                For j = 1 To r
                    If j <> tmpi Then
                        ans += A(st, j) * B(j, tmpj) '計算除了修正值以外的矩陣相乘總和
                    End If
                Next
                B(tmpi, tmpj) = (AB(st, tmpj) - ans) / A(st, tmpi) '計算修正後的數值 
                Console.WriteLine(B(tmpi, tmpj))
                Continue For
            End If
            '尋找矩陣AB
            '尋找需要修正的值
            tmpi = 0 : tmpj = 0
            For j = 1 To m
                For k = 1 To n
                    If AB(j, k) = 9999 Then
                        tmpi = j : tmpj = k
                    End If
                Next
            Next
            '計算正確值
            If tmpi <> 0 And tmpj <> 0 Then
                Dim ans As Integer = 0 '存放除了修正值以外的矩陣相乘總和
                For j = 1 To r
                    ans += A(tmpi, j) * B(j, tmpj) '計算修正後的數值 
                Next
                AB(tmpi, tmpj) = ans
                Console.WriteLine(AB(tmpi, tmpj))
            End If
        Next
        FileClose()
        Call Main()
    End Sub
End Module
