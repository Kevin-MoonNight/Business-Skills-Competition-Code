Imports System.Numerics
Module Module1
    Dim MinNum As New BigInteger
    Sub Main()
        Console.Write("請輸入路徑：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Do Until EOF(1)
            Dim Str() As String = Split(LineInput(1), " ")
            Dim T_Str(UBound(Str)) As Boolean
            Dim Num(UBound(Str)) As Integer

            For i = 0 To UBound(Str)
                Num(i) = Val(Str(i))
                MinNum = Create(MinNum.ToString & Str(i))
            Next
            DFS("", -1, Num, T_Str) '找最小
            Console.WriteLine(MinNum) '輸出
        Loop
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function DFS(ByVal Min As String, ByVal n As Integer, ByVal Num() As Integer, ByVal T_Num() As Boolean)
        If n = UBound(Num) And Create(Min) < MinNum Then
            MinNum = Create(Min)
        Else
            For i = 0 To UBound(Num)
                If T_Num(i) = False Then
                    T_Num(i) = True
                    DFS(Min & Num(i), n + 1, Num, T_Num)
                    T_Num(i) = False
                End If
            Next
        End If
    End Function
    Function Create(ByVal Str As String) As BigInteger
        Dim Ans As BigInteger = 0
        For i = 1 To Len(Str)
            Ans = Ans * 10 + Val(Mid(Str, i, 1))
        Next
        Return Ans
    End Function
End Module
