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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.功能選單ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.冰品選擇ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.八堡冰ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.水果冰ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重選ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.功能選單ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '功能選單ToolStripMenuItem
        '
        Me.功能選單ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.冰品選擇ToolStripMenuItem, Me.重選ToolStripMenuItem})
        Me.功能選單ToolStripMenuItem.Name = "功能選單ToolStripMenuItem"
        Me.功能選單ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.功能選單ToolStripMenuItem.Text = "功能選單"
        '
        '冰品選擇ToolStripMenuItem
        '
        Me.冰品選擇ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.八堡冰ToolStripMenuItem, Me.水果冰ToolStripMenuItem})
        Me.冰品選擇ToolStripMenuItem.Name = "冰品選擇ToolStripMenuItem"
        Me.冰品選擇ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.冰品選擇ToolStripMenuItem.Text = "冰品選擇"
        '
        '八堡冰ToolStripMenuItem
        '
        Me.八堡冰ToolStripMenuItem.Name = "八堡冰ToolStripMenuItem"
        Me.八堡冰ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.八堡冰ToolStripMenuItem.Text = "八堡冰"
        '
        '水果冰ToolStripMenuItem
        '
        Me.水果冰ToolStripMenuItem.Name = "水果冰ToolStripMenuItem"
        Me.水果冰ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.水果冰ToolStripMenuItem.Text = "水果冰"
        '
        '重選ToolStripMenuItem
        '
        Me.重選ToolStripMenuItem.Name = "重選ToolStripMenuItem"
        Me.重選ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.重選ToolStripMenuItem.Text = "重選"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(2, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(90, 148)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(186, 68)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(90, 148)
        Me.ListBox2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "單價"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(41, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 36)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "數量"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 247)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(43, 26)
        Me.TextBox1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "合計"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(201, 246)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(75, 26)
        Me.TextBox2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "請選擇冰品"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 290)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 功能選單ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 冰品選擇ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 八堡冰ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 水果冰ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重選ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
End Class
