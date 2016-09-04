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
        Me.SuspendLayout()
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.Location = New System.Drawing.Point(181, 27)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.Size = New System.Drawing.Size(141, 41)
        Me.btnChoosePrinter.TabIndex = 1
        Me.btnChoosePrinter.Text = "選擇印表機"
        Me.btnChoosePrinter.UseVisualStyleBackColor = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Location = New System.Drawing.Point(343, 27)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(141, 41)
        Me.btnPrintPreview.TabIndex = 2
        Me.btnPrintPreview.Text = "印列預覽"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 3
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(23, 27)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(141, 41)
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
        Me.Label2.Location = New System.Drawing.Point(31, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "最小邊界:"
        '
        'lbMinimalBoundry
        '
        Me.lbMinimalBoundry.AutoSize = True
        Me.lbMinimalBoundry.Location = New System.Drawing.Point(108, 95)
        Me.lbMinimalBoundry.Name = "lbMinimalBoundry"
        Me.lbMinimalBoundry.Size = New System.Drawing.Size(342, 15)
        Me.lbMinimalBoundry.TabIndex = 10
        Me.lbMinimalBoundry.Text = "lbMinimalBoundry,lbMinimalBoundry,lbMinimalBoundry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "設定邊界:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "左:"
        '
        'txBoundLeft
        '
        Me.txBoundLeft.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundLeft.Location = New System.Drawing.Point(140, 117)
        Me.txBoundLeft.Name = "txBoundLeft"
        Me.txBoundLeft.Size = New System.Drawing.Size(41, 25)
        Me.txBoundLeft.TabIndex = 13
        '
        'txBoundRight
        '
        Me.txBoundRight.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundRight.Location = New System.Drawing.Point(220, 117)
        Me.txBoundRight.Name = "txBoundRight"
        Me.txBoundRight.Size = New System.Drawing.Size(41, 25)
        Me.txBoundRight.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "右:"
        '
        'txBoundButtom
        '
        Me.txBoundButtom.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundButtom.Location = New System.Drawing.Point(380, 117)
        Me.txBoundButtom.Name = "txBoundButtom"
        Me.txBoundButtom.Size = New System.Drawing.Size(41, 25)
        Me.txBoundButtom.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "下:"
        '
        'txBoundTop
        '
        Me.txBoundTop.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txBoundTop.Location = New System.Drawing.Point(300, 117)
        Me.txBoundTop.Name = "txBoundTop"
        Me.txBoundTop.Size = New System.Drawing.Size(41, 25)
        Me.txBoundTop.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "上:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "幅數:"
        '
        'txVerticalCount
        '
        Me.txVerticalCount.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txVerticalCount.Location = New System.Drawing.Point(300, 144)
        Me.txVerticalCount.Name = "txVerticalCount"
        Me.txVerticalCount.Size = New System.Drawing.Size(41, 25)
        Me.txVerticalCount.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(268, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "縱:"
        '
        'txHorizontalCount
        '
        Me.txHorizontalCount.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txHorizontalCount.Location = New System.Drawing.Point(140, 144)
        Me.txHorizontalCount.Name = "txHorizontalCount"
        Me.txHorizontalCount.Size = New System.Drawing.Size(41, 25)
        Me.txHorizontalCount.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(108, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "橫:"
        '
        'btnProposeHorizontal
        '
        Me.btnProposeHorizontal.Location = New System.Drawing.Point(187, 144)
        Me.btnProposeHorizontal.Name = "btnProposeHorizontal"
        Me.btnProposeHorizontal.Size = New System.Drawing.Size(51, 25)
        Me.btnProposeHorizontal.TabIndex = 25
        Me.btnProposeHorizontal.Text = "自動"
        Me.btnProposeHorizontal.UseVisualStyleBackColor = True
        '
        'btnProposeVertical
        '
        Me.btnProposeVertical.Location = New System.Drawing.Point(351, 142)
        Me.btnProposeVertical.Name = "btnProposeVertical"
        Me.btnProposeVertical.Size = New System.Drawing.Size(51, 25)
        Me.btnProposeVertical.TabIndex = 26
        Me.btnProposeVertical.Text = "自動"
        Me.btnProposeVertical.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(676, 325)
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
End Class
