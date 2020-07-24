Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m, i, l As Short
        Dim key As Single
        m = InputBox("請輸入數列長度")
        Dim data1(m) As Single
        For i = 0 To m - 1
            data1(i) = InputBox("第" & i + 1 & "個")
        Next
        key = InputBox("請輸入要找的數字")
        sortsequence(data1)
        'Array.Sort(data1)
        'For i = 0 To m - 1
        'MsgBox("數字" & data1(i))
        'Next
        If key < data1(0) Or key > data1(m - 1) Then
            MsgBox("數字" & key & "不在數列中")
        Else
            l = binarysearch(key, data1)
            If l <> -1 Then
                MsgBox("數字" & key & "在數列中")
            Else
                MsgBox("數字" & key & "不在數列中")
            End If
        End If
    End Sub
    Sub sortsequence(ByRef data1() As Single)
        Dim j, i, n As Short
        Dim temp As Single
        n = data1.Length - 1
        'For i = 0 To n - 1
        'MsgBox("數字" & data1(i))
        'next
        'MsgBox("長度" & n)
        For i = 0 To n - 1
            For j = i + 1 To n - 1
                If data1(i) > data1(j) Then
                    temp = data1(i)
                    data1(i) = data1(j)
                    data1(j) = temp
                End If
            Next j
        Next i
    End Sub
    Function binarysearch(ByVal k As Single, ByRef data2() As Single) As Short
        Dim left, right, middle As Short
        left = 0
        right = data2.Length - 1
        Do While left < right
            middle = left + right \ 2
            If data2(middle) = k Then
                Return middle
            ElseIf data2(middle) > k Then
                right = middle - 1
            Else
                left = middle + 1
            End If
        Loop
        Return -1
    End Function
End Class
