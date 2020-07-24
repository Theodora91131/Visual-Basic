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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.第一張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上一張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下一張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.最後一張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.photo_9_
        Me.PictureBox1.Location = New System.Drawing.Point(7, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.第一張ToolStripMenuItem, Me.上一張ToolStripMenuItem, Me.下一張ToolStripMenuItem, Me.最後一張ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 92)
        '
        '第一張ToolStripMenuItem
        '
        Me.第一張ToolStripMenuItem.Name = "第一張ToolStripMenuItem"
        Me.第一張ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.第一張ToolStripMenuItem.Text = "第一張"
        '
        '上一張ToolStripMenuItem
        '
        Me.上一張ToolStripMenuItem.Name = "上一張ToolStripMenuItem"
        Me.上一張ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.上一張ToolStripMenuItem.Text = "上一張"
        '
        '下一張ToolStripMenuItem
        '
        Me.下一張ToolStripMenuItem.Name = "下一張ToolStripMenuItem"
        Me.下一張ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.下一張ToolStripMenuItem.Text = "下一張"
        '
        '最後一張ToolStripMenuItem
        '
        Me.最後一張ToolStripMenuItem.Name = "最後一張ToolStripMenuItem"
        Me.最後一張ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.最後一張ToolStripMenuItem.Text = "最後一張"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "50c1e85051efb3a080f59d8fac8c58a0.jpg")
        Me.ImageList1.Images.SetKeyName(1, "eton-college-luptons-tower-and-college-buildings-viewed-from-the-chapel-bmm92m.jp" &
        "g")
        Me.ImageList1.Images.SetKeyName(2, "milton-abbey-school-milton-abbas-dorset-uk-f1gwy6.jpg")
        Me.ImageList1.Images.SetKeyName(3, "photo(9).JPG")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 第一張ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 上一張ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 下一張ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 最後一張ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
End Class
