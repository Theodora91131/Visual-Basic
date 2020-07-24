<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NoLabel As System.Windows.Forms.Label
        Dim CompanyLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CellphoneLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim CellphoneLabel1 As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim MemoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Customers = New WindowsApplication1.customers()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New WindowsApplication1.customersTableAdapters.customersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.customersTableAdapters.TableAdapterManager()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CellphoneTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.CellphoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.MemoTextBox = New System.Windows.Forms.TextBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        NoLabel = New System.Windows.Forms.Label()
        CompanyLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CellphoneLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        CellphoneLabel1 = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        MemoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        CType(Me.Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoLabel
        '
        NoLabel.AutoSize = True
        NoLabel.Location = New System.Drawing.Point(13, 75)
        NoLabel.Name = "NoLabel"
        NoLabel.Size = New System.Drawing.Size(32, 12)
        NoLabel.TabIndex = 4
        NoLabel.Text = "編號:"
        '
        'CompanyLabel
        '
        CompanyLabel.AutoSize = True
        CompanyLabel.Location = New System.Drawing.Point(151, 76)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(56, 12)
        CompanyLabel.TabIndex = 6
        CompanyLabel.Text = "服務單位:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(320, 76)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(33, 12)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "email:"
        '
        'CellphoneLabel
        '
        CellphoneLabel.AutoSize = True
        CellphoneLabel.Location = New System.Drawing.Point(468, 76)
        CellphoneLabel.Name = "CellphoneLabel"
        CellphoneLabel.Size = New System.Drawing.Size(32, 12)
        CellphoneLabel.TabIndex = 10
        CellphoneLabel.Text = "電話:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(93, 76)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(32, 12)
        SexLabel.TabIndex = 12
        SexLabel.Text = "性名:"
        '
        'CellphoneLabel1
        '
        CellphoneLabel1.AutoSize = True
        CellphoneLabel1.Location = New System.Drawing.Point(13, 113)
        CellphoneLabel1.Name = "CellphoneLabel1"
        CellphoneLabel1.Size = New System.Drawing.Size(32, 12)
        CellphoneLabel1.TabIndex = 14
        CellphoneLabel1.Text = "手機:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(197, 110)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(32, 12)
        AddressLabel.TabIndex = 16
        AddressLabel.Text = "地址:"
        '
        'MemoLabel
        '
        MemoLabel.AutoSize = True
        MemoLabel.Location = New System.Drawing.Point(6, 147)
        MemoLabel.Name = "MemoLabel"
        MemoLabel.Size = New System.Drawing.Size(32, 12)
        MemoLabel.TabIndex = 18
        MemoLabel.Text = "備註:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(13, 40)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(116, 12)
        NameLabel.TabIndex = 19
        NameLabel.Text = "選取所要檢視的姓名:"
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(180, 41)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(33, 12)
        NameLabel1.TabIndex = 19
        NameLabel1.Text = "name:"
        '
        'Customers
        '
        Me.Customers.DataSetName = "customers"
        Me.Customers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.Customers
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.customersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(759, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "加入新的"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(27, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "刪除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "儲存資料"
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Location = New System.Drawing.Point(0, 233)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.RowTemplate.Height = 24
        Me.CustomersDataGridView.Size = New System.Drawing.Size(739, 321)
        Me.CustomersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "sex"
        Me.DataGridViewTextBoxColumn3.HeaderText = "sex"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "company"
        Me.DataGridViewTextBoxColumn4.HeaderText = "company"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telphone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "telphone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cellphone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cellphone"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "memo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "memo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'NoTextBox
        '
        Me.NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "no", True))
        Me.NoTextBox.Location = New System.Drawing.Point(54, 72)
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.Size = New System.Drawing.Size(33, 22)
        Me.NoTextBox.TabIndex = 5
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(208, 73)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CompanyTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(359, 73)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(103, 22)
        Me.EmailTextBox.TabIndex = 9
        '
        'CellphoneTextBox
        '
        Me.CellphoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "cellphone", True))
        Me.CellphoneTextBox.Location = New System.Drawing.Point(506, 72)
        Me.CellphoneTextBox.Name = "CellphoneTextBox"
        Me.CellphoneTextBox.Size = New System.Drawing.Size(141, 22)
        Me.CellphoneTextBox.TabIndex = 11
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(128, 72)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(23, 22)
        Me.SexTextBox.TabIndex = 13
        '
        'CellphoneTextBox1
        '
        Me.CellphoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "cellphone", True))
        Me.CellphoneTextBox1.Location = New System.Drawing.Point(51, 110)
        Me.CellphoneTextBox1.Name = "CellphoneTextBox1"
        Me.CellphoneTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.CellphoneTextBox1.TabIndex = 15
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(245, 107)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(333, 22)
        Me.AddressTextBox.TabIndex = 17
        '
        'MemoTextBox
        '
        Me.MemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "memo", True))
        Me.MemoTextBox.Location = New System.Drawing.Point(49, 144)
        Me.MemoTextBox.Multiline = True
        Me.MemoTextBox.Name = "MemoTextBox"
        Me.MemoTextBox.Size = New System.Drawing.Size(670, 83)
        Me.MemoTextBox.TabIndex = 19
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "name", True))
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "name", True))
        Me.NameComboBox.DataSource = Me.CustomersBindingSource
        Me.NameComboBox.DisplayMember = "name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(219, 38)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(121, 20)
        Me.NameComboBox.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 574)
        Me.Controls.Add(NameLabel1)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(MemoLabel)
        Me.Controls.Add(Me.MemoTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CellphoneLabel1)
        Me.Controls.Add(Me.CellphoneTextBox1)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(CellphoneLabel)
        Me.Controls.Add(Me.CellphoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(CompanyLabel)
        Me.Controls.Add(Me.CompanyTextBox)
        Me.Controls.Add(NoLabel)
        Me.Controls.Add(Me.NoTextBox)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Customers As customers
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As customersTableAdapters.customersTableAdapter
    Friend WithEvents TableAdapterManager As customersTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents NoTextBox As TextBox
    Friend WithEvents CompanyTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CellphoneTextBox As TextBox
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents CellphoneTextBox1 As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents MemoTextBox As TextBox
    Friend WithEvents CustomersDataGridView As DataGridView
    Friend WithEvents NameComboBox As ComboBox
End Class
