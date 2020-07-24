Imports System.Windows.Forms

Public Class Form1
    Dim frmTemp As Form2
    Public TextBox1
    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
    ' 建立子表單的新執行個體。
    'Dim ChildForm As New System.Windows.Forms.Form
    ' 將它變成這個 MDI 表單的子表單，然後才顯示。
    'ChildForm.MdiParent = Me

    'm_ChildFormNumber += 1
    'ChildForm.Text = "視窗 " & m_ChildFormNumber

    'ChildForm.Show()
    'End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    'Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    ' 使用 My.Computer.Clipboard 將選取的文字或影像插入剪貼簿
    'End Sub

    'Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    ' 使用 My.Computer.Clipboard 將選取的文字或影像插入剪貼簿
    'End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '使用 My.Computer.Clipboard.GetText() 或 My.Computer.Clipboard.GetData 從剪貼簿擷取資訊。
    'End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles munWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles munWindowTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles munWindowTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    'Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    'Me.LayoutMdi(MdiLayout.ArrangeIcons)
    'End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' 關閉父表單的所有子表單。
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    'Private m_ChildFormNumber As Integer

    'Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    'End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WindowsMenu_Click(sender As Object, e As EventArgs) Handles mnuWindows.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            frmTemp.Font = FontDialog1.Font
        Else

        End If
    End Sub

    'Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles mnuFile.Click

    'End Sub

    Private Sub munWindowNewWindow_Click(sender As Object, e As EventArgs) Handles munWindowNewWindow.Click
        Call AddNewWindow()
    End Sub

    Public Sub AddNewWindow()
        Static document As Integer

        document = document + 1
        frmTemp = New Form2
        frmTemp.MdiParent = Me
        frmTemp.Text = "子視窗" & document
        frmTemp.Show()
    End Sub

    Private Sub munFileExit_Click(sender As Object, e As EventArgs) Handles munFileExit.Click
        Application.Exit()
    End Sub

    ' Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    'End Sub
End Class
