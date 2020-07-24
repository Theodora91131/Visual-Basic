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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "開獎"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._9
        Me.PictureBox1.Location = New System.Drawing.Point(21, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 65)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources._9
        Me.PictureBox2.Location = New System.Drawing.Point(86, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 65)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources._9
        Me.PictureBox3.Location = New System.Drawing.Point(151, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 65)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources._9
        Me.PictureBox4.Location = New System.Drawing.Point(216, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 65)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "0.gif")
        Me.ImageList1.Images.SetKeyName(1, "1.gif")
        Me.ImageList1.Images.SetKeyName(2, "2.gif")
        Me.ImageList1.Images.SetKeyName(3, "3.gif")
        Me.ImageList1.Images.SetKeyName(4, "4.gif")
        Me.ImageList1.Images.SetKeyName(5, "5.gif")
        Me.ImageList1.Images.SetKeyName(6, "6.gif")
        Me.ImageList1.Images.SetKeyName(7, "7.gif")
        Me.ImageList1.Images.SetKeyName(8, "8.gif")
        Me.ImageList1.Images.SetKeyName(9, "9.gif")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "0.gif")
        Me.ImageList2.Images.SetKeyName(1, "1.gif")
        Me.ImageList2.Images.SetKeyName(2, "2.gif")
        Me.ImageList2.Images.SetKeyName(3, "3.gif")
        Me.ImageList2.Images.SetKeyName(4, "4.gif")
        Me.ImageList2.Images.SetKeyName(5, "5.gif")
        Me.ImageList2.Images.SetKeyName(6, "7.gif")
        Me.ImageList2.Images.SetKeyName(7, "8.gif")
        Me.ImageList2.Images.SetKeyName(8, "9.gif")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "0.gif")
        Me.ImageList3.Images.SetKeyName(1, "1.gif")
        Me.ImageList3.Images.SetKeyName(2, "2.gif")
        Me.ImageList3.Images.SetKeyName(3, "3.gif")
        Me.ImageList3.Images.SetKeyName(4, "4.gif")
        Me.ImageList3.Images.SetKeyName(5, "5.gif")
        Me.ImageList3.Images.SetKeyName(6, "6.gif")
        Me.ImageList3.Images.SetKeyName(7, "7.gif")
        Me.ImageList3.Images.SetKeyName(8, "8.gif")
        Me.ImageList3.Images.SetKeyName(9, "9.gif")
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "0.gif")
        Me.ImageList4.Images.SetKeyName(1, "1.gif")
        Me.ImageList4.Images.SetKeyName(2, "2.gif")
        Me.ImageList4.Images.SetKeyName(3, "3.gif")
        Me.ImageList4.Images.SetKeyName(4, "4.gif")
        Me.ImageList4.Images.SetKeyName(5, "5.gif")
        Me.ImageList4.Images.SetKeyName(6, "6.gif")
        Me.ImageList4.Images.SetKeyName(7, "7.gif")
        Me.ImageList4.Images.SetKeyName(8, "8.gif")
        Me.ImageList4.Images.SetKeyName(9, "9.gif")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 207)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents ImageList4 As ImageList
End Class
