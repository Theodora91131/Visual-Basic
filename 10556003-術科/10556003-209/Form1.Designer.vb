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
        Me.影片種類ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.N熱門新片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.S經典動畫ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重新選擇ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.功能選單ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(322, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '功能選單ToolStripMenuItem
        '
        Me.功能選單ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.影片種類ToolStripMenuItem, Me.重新選擇ToolStripMenuItem})
        Me.功能選單ToolStripMenuItem.Name = "功能選單ToolStripMenuItem"
        Me.功能選單ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.功能選單ToolStripMenuItem.Text = "功能選單"
        '
        '影片種類ToolStripMenuItem
        '
        Me.影片種類ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.N熱門新片ToolStripMenuItem, Me.S經典動畫ToolStripMenuItem})
        Me.影片種類ToolStripMenuItem.Name = "影片種類ToolStripMenuItem"
        Me.影片種類ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.影片種類ToolStripMenuItem.Text = "影片種類"
        '
        'N熱門新片ToolStripMenuItem
        '
        Me.N熱門新片ToolStripMenuItem.Name = "N熱門新片ToolStripMenuItem"
        Me.N熱門新片ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.N熱門新片ToolStripMenuItem.Text = "N熱門新片"
        '
        'S經典動畫ToolStripMenuItem
        '
        Me.S經典動畫ToolStripMenuItem.Name = "S經典動畫ToolStripMenuItem"
        Me.S經典動畫ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.S經典動畫ToolStripMenuItem.Text = "S經典動畫"
        '
        '重新選擇ToolStripMenuItem
        '
        Me.重新選擇ToolStripMenuItem.Name = "重新選擇ToolStripMenuItem"
        Me.重新選擇ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.重新選擇ToolStripMenuItem.Text = "重新選擇"
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
        Me.ListBox1.Location = New System.Drawing.Point(12, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(97, 160)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(213, 49)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(97, 160)
        Me.ListBox2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(132, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "歸還日"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(51, 225)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 22)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "數量"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(211, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 32)
        Me.Label3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "小計"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(285, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 32)
        Me.Label5.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 27)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "天數"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(59, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 32)
        Me.Label7.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(166, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 27)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "合計"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(215, 261)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 32)
        Me.TextBox1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "已租片名"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 12)
        Me.Label10.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(86, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "單價"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(121, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 27)
        Me.Label12.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 302)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
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
    Friend WithEvents 影片種類ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重新選擇ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents N熱門新片ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents S經典動畫ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
