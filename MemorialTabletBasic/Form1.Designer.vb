﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnChoosePrinter = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.openFileDiag = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbMinimalBoundry = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txBoundLeft = New System.Windows.Forms.TextBox()
        Me.txBoundRight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txBoundButtom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txBoundTop = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txVerticalCount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txHorizontalCount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnProposeHorizontal = New System.Windows.Forms.Button()
        Me.btnProposeVertical = New System.Windows.Forms.Button()
        Me.directoryStr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chooseFolderDiag = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbRawNum = New System.Windows.Forms.Label()
        Me.ckTypeC = New System.Windows.Forms.CheckBox()
        Me.ckTypeD = New System.Windows.Forms.CheckBox()
        Me.ckTypeL = New System.Windows.Forms.CheckBox()
        Me.ckTypeY = New System.Windows.Forms.CheckBox()
        Me.ckTypeW = New System.Windows.Forms.CheckBox()
        Me.dgvWarning = New System.Windows.Forms.TabControl()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.dgvAll = New System.Windows.Forms.DataGridView()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Val1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Val2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabletAllSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabWarning = New System.Windows.Forms.TabPage()
        Me.dgvWarn = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainSplitter = New System.Windows.Forms.SplitContainer()
        Me.tabletWarnSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvWarning.SuspendLayout()
        Me.tabAll.SuspendLayout()
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabletAllSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWarning.SuspendLayout()
        CType(Me.dgvWarn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainSplitter.Panel1.SuspendLayout()
        Me.mainSplitter.Panel2.SuspendLayout()
        Me.mainSplitter.SuspendLayout()
        CType(Me.tabletWarnSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.Location = New System.Drawing.Point(135, 13)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.Size = New System.Drawing.Size(121, 32)
        Me.btnChoosePrinter.TabIndex = 1
        Me.btnChoosePrinter.Text = "選擇印表機"
        Me.btnChoosePrinter.UseVisualStyleBackColor = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Location = New System.Drawing.Point(262, 13)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(107, 32)
        Me.btnPrintPreview.TabIndex = 2
        Me.btnPrintPreview.Text = "印列預覽"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 3
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(7, 13)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(122, 32)
        Me.btnOpenFile.TabIndex = 8
        Me.btnOpenFile.Text = "讀取檔案"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'openFileDiag
        '
        Me.openFileDiag.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "最小邊界:"
        '
        'lbMinimalBoundry
        '
        Me.lbMinimalBoundry.AutoSize = True
        Me.lbMinimalBoundry.Location = New System.Drawing.Point(461, 13)
        Me.lbMinimalBoundry.Name = "lbMinimalBoundry"
        Me.lbMinimalBoundry.Size = New System.Drawing.Size(342, 15)
        Me.lbMinimalBoundry.TabIndex = 10
        Me.lbMinimalBoundry.Text = "lbMinimalBoundry,lbMinimalBoundry,lbMinimalBoundry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "設定邊界:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "左:"
        '
        'txBoundLeft
        '
        Me.txBoundLeft.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundLeft.Location = New System.Drawing.Point(493, 35)
        Me.txBoundLeft.Name = "txBoundLeft"
        Me.txBoundLeft.Size = New System.Drawing.Size(41, 25)
        Me.txBoundLeft.TabIndex = 13
        '
        'txBoundRight
        '
        Me.txBoundRight.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundRight.Location = New System.Drawing.Point(573, 35)
        Me.txBoundRight.Name = "txBoundRight"
        Me.txBoundRight.Size = New System.Drawing.Size(41, 25)
        Me.txBoundRight.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(541, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "右:"
        '
        'txBoundButtom
        '
        Me.txBoundButtom.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundButtom.Location = New System.Drawing.Point(733, 35)
        Me.txBoundButtom.Name = "txBoundButtom"
        Me.txBoundButtom.Size = New System.Drawing.Size(41, 25)
        Me.txBoundButtom.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(701, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "下:"
        '
        'txBoundTop
        '
        Me.txBoundTop.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundTop.Location = New System.Drawing.Point(653, 35)
        Me.txBoundTop.Name = "txBoundTop"
        Me.txBoundTop.Size = New System.Drawing.Size(41, 25)
        Me.txBoundTop.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(621, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "上:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "幅數:"
        '
        'txVerticalCount
        '
        Me.txVerticalCount.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txVerticalCount.Location = New System.Drawing.Point(653, 62)
        Me.txVerticalCount.Name = "txVerticalCount"
        Me.txVerticalCount.Size = New System.Drawing.Size(41, 25)
        Me.txVerticalCount.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(621, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "縱:"
        '
        'txHorizontalCount
        '
        Me.txHorizontalCount.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txHorizontalCount.Location = New System.Drawing.Point(493, 62)
        Me.txHorizontalCount.Name = "txHorizontalCount"
        Me.txHorizontalCount.Size = New System.Drawing.Size(41, 25)
        Me.txHorizontalCount.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(461, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "橫:"
        '
        'btnProposeHorizontal
        '
        Me.btnProposeHorizontal.Location = New System.Drawing.Point(540, 62)
        Me.btnProposeHorizontal.Name = "btnProposeHorizontal"
        Me.btnProposeHorizontal.Size = New System.Drawing.Size(51, 25)
        Me.btnProposeHorizontal.TabIndex = 25
        Me.btnProposeHorizontal.Text = "自動"
        Me.btnProposeHorizontal.UseVisualStyleBackColor = True
        '
        'btnProposeVertical
        '
        Me.btnProposeVertical.Location = New System.Drawing.Point(704, 60)
        Me.btnProposeVertical.Name = "btnProposeVertical"
        Me.btnProposeVertical.Size = New System.Drawing.Size(51, 25)
        Me.btnProposeVertical.TabIndex = 26
        Me.btnProposeVertical.Text = "自動"
        Me.btnProposeVertical.UseVisualStyleBackColor = True
        '
        'directoryStr
        '
        Me.directoryStr.Location = New System.Drawing.Point(50, 51)
        Me.directoryStr.Name = "directoryStr"
        Me.directoryStr.ReadOnly = True
        Me.directoryStr.Size = New System.Drawing.Size(319, 25)
        Me.directoryStr.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "目錄:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(216, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "資料數:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(284, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 15)
        Me.Label13.TabIndex = 35
        '
        'lbRawNum
        '
        Me.lbRawNum.AutoSize = True
        Me.lbRawNum.Location = New System.Drawing.Point(278, 111)
        Me.lbRawNum.Name = "lbRawNum"
        Me.lbRawNum.Size = New System.Drawing.Size(71, 15)
        Me.lbRawNum.TabIndex = 36
        Me.lbRawNum.Text = "lbRawNum"
        '
        'ckTypeC
        '
        Me.ckTypeC.AutoSize = True
        Me.ckTypeC.Location = New System.Drawing.Point(6, 82)
        Me.ckTypeC.Name = "ckTypeC"
        Me.ckTypeC.Size = New System.Drawing.Size(98, 19)
        Me.ckTypeC.TabIndex = 37
        Me.ckTypeC.Text = "C長生祿位"
        Me.ckTypeC.UseVisualStyleBackColor = True
        '
        'ckTypeD
        '
        Me.ckTypeD.AutoSize = True
        Me.ckTypeD.Location = New System.Drawing.Point(108, 82)
        Me.ckTypeD.Name = "ckTypeD"
        Me.ckTypeD.Size = New System.Drawing.Size(84, 19)
        Me.ckTypeD.TabIndex = 38
        Me.ckTypeD.Text = "D地基主"
        Me.ckTypeD.UseVisualStyleBackColor = True
        '
        'ckTypeL
        '
        Me.ckTypeL.AutoSize = True
        Me.ckTypeL.Location = New System.Drawing.Point(209, 82)
        Me.ckTypeL.Name = "ckTypeL"
        Me.ckTypeL.Size = New System.Drawing.Size(98, 19)
        Me.ckTypeL.TabIndex = 39
        Me.ckTypeL.Text = "L歷代祖先"
        Me.ckTypeL.UseVisualStyleBackColor = True
        '
        'ckTypeY
        '
        Me.ckTypeY.AutoSize = True
        Me.ckTypeY.Location = New System.Drawing.Point(108, 107)
        Me.ckTypeY.Name = "ckTypeY"
        Me.ckTypeY.Size = New System.Drawing.Size(99, 19)
        Me.ckTypeY.TabIndex = 41
        Me.ckTypeY.Text = "Y冤親債主"
        Me.ckTypeY.UseVisualStyleBackColor = True
        '
        'ckTypeW
        '
        Me.ckTypeW.AutoSize = True
        Me.ckTypeW.Location = New System.Drawing.Point(6, 107)
        Me.ckTypeW.Name = "ckTypeW"
        Me.ckTypeW.Size = New System.Drawing.Size(102, 19)
        Me.ckTypeW.TabIndex = 40
        Me.ckTypeW.Text = "W往生蓮位"
        Me.ckTypeW.UseVisualStyleBackColor = True
        '
        'dgvWarning
        '
        Me.dgvWarning.Controls.Add(Me.tabAll)
        Me.dgvWarning.Controls.Add(Me.tabWarning)
        Me.dgvWarning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWarning.Location = New System.Drawing.Point(0, 0)
        Me.dgvWarning.Name = "dgvWarning"
        Me.dgvWarning.SelectedIndex = 0
        Me.dgvWarning.Size = New System.Drawing.Size(840, 388)
        Me.dgvWarning.TabIndex = 42
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.dgvAll)
        Me.tabAll.Location = New System.Drawing.Point(4, 25)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAll.Size = New System.Drawing.Size(832, 359)
        Me.tabAll.TabIndex = 0
        Me.tabAll.Text = "全部資料"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'dgvAll
        '
        Me.dgvAll.AllowUserToAddRows = False
        Me.dgvAll.AutoGenerateColumns = False
        Me.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeDataGridViewTextBoxColumn, Me.FilenameDataGridViewTextBoxColumn, Me.Val1DataGridViewTextBoxColumn, Me.Val2DataGridViewTextBoxColumn})
        Me.dgvAll.DataSource = Me.tabletAllSource
        Me.dgvAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAll.Location = New System.Drawing.Point(3, 3)
        Me.dgvAll.Name = "dgvAll"
        Me.dgvAll.RowTemplate.Height = 27
        Me.dgvAll.Size = New System.Drawing.Size(826, 353)
        Me.dgvAll.TabIndex = 0
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "類型"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'FilenameDataGridViewTextBoxColumn
        '
        Me.FilenameDataGridViewTextBoxColumn.DataPropertyName = "Filename"
        Me.FilenameDataGridViewTextBoxColumn.HeaderText = "檔案"
        Me.FilenameDataGridViewTextBoxColumn.Name = "FilenameDataGridViewTextBoxColumn"
        '
        'Val1DataGridViewTextBoxColumn
        '
        Me.Val1DataGridViewTextBoxColumn.DataPropertyName = "Val1"
        Me.Val1DataGridViewTextBoxColumn.HeaderText = "欄位一"
        Me.Val1DataGridViewTextBoxColumn.Name = "Val1DataGridViewTextBoxColumn"
        Me.Val1DataGridViewTextBoxColumn.Width = 150
        '
        'Val2DataGridViewTextBoxColumn
        '
        Me.Val2DataGridViewTextBoxColumn.DataPropertyName = "Val2"
        Me.Val2DataGridViewTextBoxColumn.HeaderText = "欄位二"
        Me.Val2DataGridViewTextBoxColumn.Name = "Val2DataGridViewTextBoxColumn"
        Me.Val2DataGridViewTextBoxColumn.Width = 200
        '
        'tabletAllSource
        '
        Me.tabletAllSource.DataSource = GetType(MemorialTabletBasic.TabletInfo.TabletRawItem)
        '
        'tabWarning
        '
        Me.tabWarning.Controls.Add(Me.dgvWarn)
        Me.tabWarning.Location = New System.Drawing.Point(4, 25)
        Me.tabWarning.Name = "tabWarning"
        Me.tabWarning.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWarning.Size = New System.Drawing.Size(832, 359)
        Me.tabWarning.TabIndex = 1
        Me.tabWarning.Text = "疑似有問題資料"
        Me.tabWarning.UseVisualStyleBackColor = True
        '
        'dgvWarn
        '
        Me.dgvWarn.AllowUserToAddRows = False
        Me.dgvWarn.AutoGenerateColumns = False
        Me.dgvWarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvWarn.DataSource = Me.tabletWarnSource
        Me.dgvWarn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWarn.Location = New System.Drawing.Point(3, 3)
        Me.dgvWarn.Name = "dgvWarn"
        Me.dgvWarn.RowTemplate.Height = 27
        Me.dgvWarn.Size = New System.Drawing.Size(826, 353)
        Me.dgvWarn.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn1.HeaderText = "類型"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Filename"
        Me.DataGridViewTextBoxColumn2.HeaderText = "檔案"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Val1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "欄位一"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Val2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "欄位二"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'mainSplitter
        '
        Me.mainSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.mainSplitter.IsSplitterFixed = True
        Me.mainSplitter.Location = New System.Drawing.Point(0, 0)
        Me.mainSplitter.Name = "mainSplitter"
        Me.mainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'mainSplitter.Panel1
        '
        Me.mainSplitter.Panel1.Controls.Add(Me.btnChoosePrinter)
        Me.mainSplitter.Panel1.Controls.Add(Me.ckTypeY)
        Me.mainSplitter.Panel1.Controls.Add(Me.btnPrintPreview)
        Me.mainSplitter.Panel1.Controls.Add(Me.ckTypeW)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label1)
        Me.mainSplitter.Panel1.Controls.Add(Me.ckTypeL)
        Me.mainSplitter.Panel1.Controls.Add(Me.btnOpenFile)
        Me.mainSplitter.Panel1.Controls.Add(Me.ckTypeD)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label2)
        Me.mainSplitter.Panel1.Controls.Add(Me.ckTypeC)
        Me.mainSplitter.Panel1.Controls.Add(Me.lbMinimalBoundry)
        Me.mainSplitter.Panel1.Controls.Add(Me.lbRawNum)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label3)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label4)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label12)
        Me.mainSplitter.Panel1.Controls.Add(Me.txBoundLeft)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label11)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label5)
        Me.mainSplitter.Panel1.Controls.Add(Me.directoryStr)
        Me.mainSplitter.Panel1.Controls.Add(Me.txBoundRight)
        Me.mainSplitter.Panel1.Controls.Add(Me.btnProposeVertical)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label7)
        Me.mainSplitter.Panel1.Controls.Add(Me.btnProposeHorizontal)
        Me.mainSplitter.Panel1.Controls.Add(Me.txBoundTop)
        Me.mainSplitter.Panel1.Controls.Add(Me.txVerticalCount)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label6)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label9)
        Me.mainSplitter.Panel1.Controls.Add(Me.txBoundButtom)
        Me.mainSplitter.Panel1.Controls.Add(Me.txHorizontalCount)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label8)
        Me.mainSplitter.Panel1.Controls.Add(Me.Label10)
        '
        'mainSplitter.Panel2
        '
        Me.mainSplitter.Panel2.Controls.Add(Me.dgvWarning)
        Me.mainSplitter.Size = New System.Drawing.Size(842, 530)
        Me.mainSplitter.SplitterDistance = 136
        Me.mainSplitter.TabIndex = 43
        '
        'tabletWarnSource
        '
        Me.tabletWarnSource.DataSource = GetType(MemorialTabletBasic.TabletInfo.TabletRawItem)
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(842, 530)
        Me.Controls.Add(Me.mainSplitter)
        Me.Controls.Add(Me.Label13)
        Me.Name = "Form1"
        Me.Text = "牌位印列"
        Me.dgvWarning.ResumeLayout(False)
        Me.tabAll.ResumeLayout(False)
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabletAllSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWarning.ResumeLayout(False)
        CType(Me.dgvWarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitter.Panel1.ResumeLayout(False)
        Me.mainSplitter.Panel1.PerformLayout()
        Me.mainSplitter.Panel2.ResumeLayout(False)
        CType(Me.mainSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitter.ResumeLayout(False)
        CType(Me.tabletWarnSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChoosePrinter As Button
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents openFileDiag As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents lbMinimalBoundry As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txBoundLeft As TextBox
    Friend WithEvents txBoundRight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txBoundButtom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txBoundTop As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txVerticalCount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txHorizontalCount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnProposeHorizontal As Button
    Friend WithEvents btnProposeVertical As Button
    Friend WithEvents directoryStr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chooseFolderDiag As FolderBrowserDialog
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbRawNum As Label
    Friend WithEvents ckTypeC As CheckBox
    Friend WithEvents ckTypeD As CheckBox
    Friend WithEvents ckTypeL As CheckBox
    Friend WithEvents ckTypeY As CheckBox
    Friend WithEvents ckTypeW As CheckBox
    Friend WithEvents dgvWarning As TabControl
    Friend WithEvents tabAll As TabPage
    Friend WithEvents tabWarning As TabPage
    Friend WithEvents mainSplitter As SplitContainer
    Friend WithEvents dgvAll As DataGridView
    Friend WithEvents tabletAllSource As BindingSource
    Friend WithEvents tabletWarnSource As BindingSource
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Val1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Val2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvWarn As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
