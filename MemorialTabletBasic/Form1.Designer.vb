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
        Me.rioC = New System.Windows.Forms.RadioButton()
        Me.rioD = New System.Windows.Forms.RadioButton()
        Me.rioL = New System.Windows.Forms.RadioButton()
        Me.rioW = New System.Windows.Forms.RadioButton()
        Me.rioY = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbRawNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.Location = New System.Drawing.Point(140, 12)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.Size = New System.Drawing.Size(121, 32)
        Me.btnChoosePrinter.TabIndex = 1
        Me.btnChoosePrinter.Text = "選擇印表機"
        Me.btnChoosePrinter.UseVisualStyleBackColor = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Location = New System.Drawing.Point(267, 12)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(107, 32)
        Me.btnPrintPreview.TabIndex = 2
        Me.btnPrintPreview.Text = "印列預覽"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 3
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 12)
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
        Me.Label2.Location = New System.Drawing.Point(14, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "最小邊界:"
        '
        'lbMinimalBoundry
        '
        Me.lbMinimalBoundry.AutoSize = True
        Me.lbMinimalBoundry.Location = New System.Drawing.Point(91, 140)
        Me.lbMinimalBoundry.Name = "lbMinimalBoundry"
        Me.lbMinimalBoundry.Size = New System.Drawing.Size(342, 15)
        Me.lbMinimalBoundry.TabIndex = 10
        Me.lbMinimalBoundry.Text = "lbMinimalBoundry,lbMinimalBoundry,lbMinimalBoundry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "設定邊界:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "左:"
        '
        'txBoundLeft
        '
        Me.txBoundLeft.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundLeft.Location = New System.Drawing.Point(123, 162)
        Me.txBoundLeft.Name = "txBoundLeft"
        Me.txBoundLeft.Size = New System.Drawing.Size(41, 25)
        Me.txBoundLeft.TabIndex = 13
        '
        'txBoundRight
        '
        Me.txBoundRight.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundRight.Location = New System.Drawing.Point(203, 162)
        Me.txBoundRight.Name = "txBoundRight"
        Me.txBoundRight.Size = New System.Drawing.Size(41, 25)
        Me.txBoundRight.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "右:"
        '
        'txBoundButtom
        '
        Me.txBoundButtom.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundButtom.Location = New System.Drawing.Point(363, 162)
        Me.txBoundButtom.Name = "txBoundButtom"
        Me.txBoundButtom.Size = New System.Drawing.Size(41, 25)
        Me.txBoundButtom.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "下:"
        '
        'txBoundTop
        '
        Me.txBoundTop.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundTop.Location = New System.Drawing.Point(283, 162)
        Me.txBoundTop.Name = "txBoundTop"
        Me.txBoundTop.Size = New System.Drawing.Size(41, 25)
        Me.txBoundTop.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "上:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "幅數:"
        '
        'txVerticalCount
        '
        Me.txVerticalCount.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txVerticalCount.Location = New System.Drawing.Point(283, 189)
        Me.txVerticalCount.Name = "txVerticalCount"
        Me.txVerticalCount.Size = New System.Drawing.Size(41, 25)
        Me.txVerticalCount.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(251, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "縱:"
        '
        'txHorizontalCount
        '
        Me.txHorizontalCount.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txHorizontalCount.Location = New System.Drawing.Point(123, 189)
        Me.txHorizontalCount.Name = "txHorizontalCount"
        Me.txHorizontalCount.Size = New System.Drawing.Size(41, 25)
        Me.txHorizontalCount.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "橫:"
        '
        'btnProposeHorizontal
        '
        Me.btnProposeHorizontal.Location = New System.Drawing.Point(170, 189)
        Me.btnProposeHorizontal.Name = "btnProposeHorizontal"
        Me.btnProposeHorizontal.Size = New System.Drawing.Size(51, 25)
        Me.btnProposeHorizontal.TabIndex = 25
        Me.btnProposeHorizontal.Text = "自動"
        Me.btnProposeHorizontal.UseVisualStyleBackColor = True
        '
        'btnProposeVertical
        '
        Me.btnProposeVertical.Location = New System.Drawing.Point(334, 187)
        Me.btnProposeVertical.Name = "btnProposeVertical"
        Me.btnProposeVertical.Size = New System.Drawing.Size(51, 25)
        Me.btnProposeVertical.TabIndex = 26
        Me.btnProposeVertical.Text = "自動"
        Me.btnProposeVertical.UseVisualStyleBackColor = True
        '
        'directoryStr
        '
        Me.directoryStr.Location = New System.Drawing.Point(55, 50)
        Me.directoryStr.Name = "directoryStr"
        Me.directoryStr.ReadOnly = True
        Me.directoryStr.Size = New System.Drawing.Size(319, 25)
        Me.directoryStr.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "目錄:"
        '
        'rioC
        '
        Me.rioC.AutoSize = True
        Me.rioC.Checked = True
        Me.rioC.Location = New System.Drawing.Point(12, 81)
        Me.rioC.Name = "rioC"
        Me.rioC.Size = New System.Drawing.Size(119, 19)
        Me.rioC.TabIndex = 29
        Me.rioC.TabStop = True
        Me.rioC.Text = "C RadioButton1"
        Me.rioC.UseVisualStyleBackColor = True
        '
        'rioD
        '
        Me.rioD.AutoSize = True
        Me.rioD.Location = New System.Drawing.Point(132, 81)
        Me.rioD.Name = "rioD"
        Me.rioD.Size = New System.Drawing.Size(120, 19)
        Me.rioD.TabIndex = 30
        Me.rioD.TabStop = True
        Me.rioD.Text = "D RadioButton2"
        Me.rioD.UseVisualStyleBackColor = True
        '
        'rioL
        '
        Me.rioL.AutoSize = True
        Me.rioL.Location = New System.Drawing.Point(258, 81)
        Me.rioL.Name = "rioL"
        Me.rioL.Size = New System.Drawing.Size(119, 19)
        Me.rioL.TabIndex = 31
        Me.rioL.TabStop = True
        Me.rioL.Text = "L RadioButton2"
        Me.rioL.UseVisualStyleBackColor = True
        '
        'rioW
        '
        Me.rioW.AutoSize = True
        Me.rioW.Location = New System.Drawing.Point(12, 106)
        Me.rioW.Name = "rioW"
        Me.rioW.Size = New System.Drawing.Size(123, 19)
        Me.rioW.TabIndex = 32
        Me.rioW.TabStop = True
        Me.rioW.Text = "W RadioButton2"
        Me.rioW.UseVisualStyleBackColor = True
        '
        'rioY
        '
        Me.rioY.AutoSize = True
        Me.rioY.Location = New System.Drawing.Point(132, 106)
        Me.rioY.Name = "rioY"
        Me.rioY.Size = New System.Drawing.Size(120, 19)
        Me.rioY.TabIndex = 33
        Me.rioY.TabStop = True
        Me.rioY.Text = "Y RadioButton2"
        Me.rioY.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(403, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "資料數:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(466, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 15)
        Me.Label13.TabIndex = 35
        '
        'lbRawNum
        '
        Me.lbRawNum.AutoSize = True
        Me.lbRawNum.Location = New System.Drawing.Point(465, 21)
        Me.lbRawNum.Name = "lbRawNum"
        Me.lbRawNum.Size = New System.Drawing.Size(71, 15)
        Me.lbRawNum.TabIndex = 36
        Me.lbRawNum.Text = "lbRawNum"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(599, 278)
        Me.Controls.Add(Me.lbRawNum)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.rioY)
        Me.Controls.Add(Me.rioW)
        Me.Controls.Add(Me.rioL)
        Me.Controls.Add(Me.rioD)
        Me.Controls.Add(Me.rioC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.directoryStr)
        Me.Controls.Add(Me.btnProposeVertical)
        Me.Controls.Add(Me.btnProposeHorizontal)
        Me.Controls.Add(Me.txVerticalCount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txHorizontalCount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txBoundButtom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txBoundTop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txBoundRight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txBoundLeft)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbMinimalBoundry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.btnChoosePrinter)
        Me.Name = "Form1"
        Me.Text = "牌位印列"
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
    Friend WithEvents rioC As RadioButton
    Friend WithEvents rioD As RadioButton
    Friend WithEvents rioL As RadioButton
    Friend WithEvents rioW As RadioButton
    Friend WithEvents rioY As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbRawNum As Label
End Class
