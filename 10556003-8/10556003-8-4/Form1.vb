Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data1, g, h, l, ans As Integer
        data1 = InputBox("請問要輸入幾個參數(需要小於等於3)")
        If data1 > 3 Then
            MsgBox("輸入錯誤")
        ElseIf data1 = 1 Then
            g = InputBox("請輸入參數1")
            ans = sum(g)
            MsgBox("1到" & g & "的總和等於" & ans)
        ElseIf data1 = 2 Then
            g = InputBox("請輸入參數1")
            h = InputBox("請輸入參數2")
            ans = sum(g, h)
            MsgBox(g & "到" & h & "的總和等於" & ans)
        ElseIf data1 = 3 Then
            g = InputBox("請輸入參數1")
            h = InputBox("請輸入參數2")
            l = InputBox("請輸入參數3")
            ans = sum(g, h, l)
            If ans = -1 Then
                MsgBox("第3個引數不能為0!")
            Else
                MsgBox(g & "到" & h & ",間隔為" & l & "的總和等於" & ans)
            End If
        End If
    End Sub
    Sub swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer
        temp = a
        a = b
        b = temp
    End Sub
    Overloads Function sum(ByVal m As Integer) As Integer
        Dim i, temp As Integer
        temp = 0
        For i = 1 To m
            temp = temp + i
        Next
        Return temp
    End Function

    Overloads Function sum(ByRef m As Integer, ByRef n As Integer) As Integer
        Dim i, temp As Integer
        temp = 0
        If m > n Then
            swap(m, n)
        End If
        For i = m To n
            temp = temp + i
        Next
        Return temp
    End Function
    Overloads Function sum(ByRef m As Integer, ByRef n As Integer, ByVal p As Integer) As Integer
        Dim i, temp As Integer
        temp = 0
        If p = 0 Then
            Return -1
        ElseIf p > 0 Then
            If m > n Then
                swap(m, n)
            End If
            For i = m To n Step p
                temp = temp + i
            Next
        ElseIf p < 0 Then
            If m < n Then
                swap(m, n)
            End If
            For i = m To n Step p
                temp = temp + i
            Next
        End If
        Return temp
    End Function
End Class
