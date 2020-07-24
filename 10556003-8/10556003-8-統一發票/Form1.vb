Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a(5, 5), temps As String
        Dim ksum, n, i, w As Integer
        ksum = 0
        While ksum < 9
            a(1, 1) = InputBox("輸入特別獎號碼")
            a(2, 1) = InputBox("輸入特獎號碼")
            For w = 1 To 3
                a(3, w) = InputBox("輸入頭獎號碼三組,第" & w & "組")
            Next
            For i = 1 To 4
                a(4, i) = InputBox("輸入六獎號碼四組,第" & i & "組")
            Next
            ksum = ksum + check_len(8, a(1, 1))
            ksum = ksum + check_len(8, a(2, 1))
            For i = 1 To 3
                ksum = ksum + check_len(8, a(3, i))
            Next i
            For i = 1 To 4
                ksum = ksum + check_len(3, a(4, i))
            Next i

            If ksum < 9 Then
                MsgBox("中獎號碼長度錯誤,請重新輸入!!")
                ksum = 0
            End If
        End While

        n = InputBox("輸入兌獎號碼共幾組")
        Dim b(n + 1, 1) As String
        ksum = 0
        Do While ksum < n
            For i = 1 To n
                b(i, 0) = InputBox("輸入兌獎號碼,第" & i & "組")
                ksum = ksum + check_len(8, b(i, 0))
            Next
            If ksum < n Then
                MsgBox("兌獎號碼長度錯誤,請重新輸入!!")
                ksum = 0
            End If
        Loop
        For i = 1 To n
            b(i, 1) = check_P1(a, b(i, 0))
            If b(i, 1) = "" Then
                b(i, 1) = check_P2(a, b(i, 0))
            End If
            If b(i, 1) = "" Then
                b(i, 1) = check_P3(a, b(i, 0), 2)
            End If
            If b(i, 1) = "" Then
                b(i, 1) = check_P3(a, b(i, 0), 3)
            End If
            If b(i, 1) = "" Then
                b(i, 1) = check_P3(a, b(i, 0), 4)
            End If
            If b(i, 1) = "" Then
                b(i, 1) = check_P3(a, b(i, 0), 5)
            End If
            If b(i, 1) = "" Then
                b(i, 1) = check_P3(a, b(i, 0), 6)
            End If
            If b(i, 1) = "" Then
                b(i, 1) = "未中獎!"
            End If
        Next
        temps = ""
        For i = 1 To n
            temps = temps & b(i, 0) & "==>" & b(i, 1) & vbNewLine
        Next
        MsgBox(temps)
    End Sub

    Function check_P1(ByRef c(,) As String, str1 As String) As String
        Dim temps As String
        temps = ""
        If str1 = c(1, 1) Then
            temps = "恭喜中特別獎，獎金1,000萬元!"
        ElseIf str1 = c(2, 1) Then
            temps = "恭喜中特獎，獎金200萬元!"
        End If
        Return temps
    End Function

    Function check_P2(ByRef c(,) As String, ByVal str1 As String) As String
        Dim temps As String
        Dim k As Integer
        temps = ""
        k = 1
        Do While k <= 3
            If str1 = c(3, k) Then
                temps = "恭喜中頭獎，獎金20萬元!"
                k = 4
            Else
                k = k + 1
            End If
        Loop
        Return temps
    End Function

    Function check_P3(ByRef c(,) As String, ByVal str1 As String, ByVal p As Integer) As String
        Dim temps As String
        Dim k As Integer
        Dim d(4) As String
        Dim n(7) As String
        n(2) = "恭喜中二獎，獎金4萬元!"
        n(3) = "恭喜中三獎，獎金1萬元!"
        n(4) = "恭喜中四獎，獎金4千元!"
        n(5) = "恭喜中五獎，獎金1千元!"
        n(6) = "恭喜中六獎，獎金2百元!"
        str1 = Mid(str1, p)
        'MsgBox(str1)
        For k = 1 To 3
            d(k) = Mid(c(3, k), p)
            'MsgBox(d(k))
        Next k
        temps = ""
        k = 1
        Do While k <= 3
            If str1 = d(k) Then
                temps = n(p)
                k = 4
            Else
                k = k + 1
            End If
        Loop
        If temps = "" And p = 6 Then
            k = 1
            While k <= 4
                If str1 = c(4, k) Then
                    temps = n(p)
                    k = 5
                Else
                    k = k + 1
                End If
            End While
        End If
        Return temps
    End Function

    Function check_len(ByVal z As Integer, ByRef str As String) As Integer
        If Len(str) = z Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class

