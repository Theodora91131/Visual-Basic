<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.munWindowNewWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.munFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.munWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.munWindowTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.munWindowTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.ToolStripMenuItem1, Me.mnuWindows})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.mnuWindows
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.munWindowNewWindow, Me.munFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(59, 20)
        Me.mnuFile.Text = "檔案(F)"
        '
        'munWindowNewWindow
        '
        Me.munWindowNewWindow.Name = "munWindowNewWindow"
        Me.munWindowNewWindow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.munWindowNewWindow.Size = New System.Drawing.Size(190, 22)
        Me.munWindowNewWindow.Text = "新增視窗(W)"
        '
        'munFileExit
        '
        Me.munFileExit.Name = "munFileExit"
        Me.munFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.munFileExit.Size = New System.Drawing.Size(190, 22)
        Me.munFileExit.Text = "結束(X)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "字型(T)"
        '
        'mnuWindows
        '
        Me.mnuWindows.Checked = True
        Me.mnuWindows.CheckOnClick = True
        Me.mnuWindows.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.munWindowCascade, Me.munWindowTileVertical, Me.munWindowTileHorizontal})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(64, 20)
        Me.mnuWindows.Text = "視窗(&W)"
        '
        'munWindowCascade
        '
        Me.munWindowCascade.CheckOnClick = True
        Me.munWindowCascade.Name = "munWindowCascade"
        Me.munWindowCascade.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.munWindowCascade.ShowShortcutKeys = False
        Me.munWindowCascade.Size = New System.Drawing.Size(186, 22)
        Me.munWindowCascade.Text = "重疊視窗(C)"
        '
        'munWindowTileVertical
        '
        Me.munWindowTileVertical.CheckOnClick = True
        Me.munWindowTileVertical.Name = "munWindowTileVertical"
        Me.munWindowTileVertical.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.munWindowTileVertical.Size = New System.Drawing.Size(186, 22)
        Me.munWindowTileVertical.Text = "水平視窗(H)"
        '
        'munWindowTileHorizontal
        '
        Me.munWindowTileHorizontal.CheckOnClick = True
        Me.munWindowTileHorizontal.Name = "munWindowTileHorizontal"
        Me.munWindowTileHorizontal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.munWindowTileHorizontal.Size = New System.Drawing.Size(186, 22)
        Me.munWindowTileHorizontal.Text = "垂直視窗(Y)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripMenuItem2.Text = "E"
        '
        'FontDialog1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 418)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.Text = "MDI表單介面"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents munWindowCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents munWindowTileVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents munWindowTileHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents munWindowNewWindow As ToolStripMenuItem
    Friend WithEvents munFileExit As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
End Class
