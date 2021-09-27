Module Module1
    Dim Tree() As Tree1
    Dim P As Integer
    Dim Head, TheEnd As String
    Structure Tree1
        Dim n As String
        Dim Root As String
    End Structure
    Sub Main()
        Console.Write("請輸入路徑名稱：")
        FileOpen(1, Console.ReadLine, OpenMode.Input)
        Input(1, P)
        ReDim Tree(P)
        Dim Str() As String
        Input(1, TheEnd)
        '輸入
        For i = 1 To P
            Str = Split(Strings.Replace(LineInput(1), " ", ""), ",")
            If Str(1) = "---" Then
                Head = Str(0)
            Else
                Tree(i).Root = Str(1)
            End If
            Tree(i).n = Str(0)
        Next
        '尋找
        Console.WriteLine(FS(TheEnd, ""))
        FileClose()
        Console.ReadKey()
        Call Main()
    End Sub
    Function FS(ByVal n As String, ByVal Str As String)
        If n = Head Then
            Return n & Str
        End If
        For i = 1 To P
            If Tree(i).n = n Then
                Return FS(Tree(i).Root, " " & n & Str)
            End If
        Next
    End Function
End Module
