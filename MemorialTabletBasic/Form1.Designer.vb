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
        Me.btnChoosePrinter = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rioCnt1 = New System.Windows.Forms.RadioButton()
        Me.rioCnt2 = New System.Windows.Forms.RadioButton()
        Me.rioCnt3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.Location = New System.Drawing.Point(24, 27)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.Size = New System.Drawing.Size(141, 41)
        Me.btnChoosePrinter.TabIndex = 1
        Me.btnChoosePrinter.Text = "選擇印表機"
        Me.btnChoosePrinter.UseVisualStyleBackColor = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Location = New System.Drawing.Point(195, 27)
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
        'rioCnt1
        '
        Me.rioCnt1.AutoSize = True
        Me.rioCnt1.Checked = True
        Me.rioCnt1.Location = New System.Drawing.Point(10, 24)
        Me.rioCnt1.Name = "rioCnt1"
        Me.rioCnt1.Size = New System.Drawing.Size(50, 19)
        Me.rioCnt1.TabIndex = 4
        Me.rioCnt1.TabStop = True
        Me.rioCnt1.Text = "1幅"
        Me.rioCnt1.UseVisualStyleBackColor = True
        '
        'rioCnt2
        '
        Me.rioCnt2.AutoSize = True
        Me.rioCnt2.Location = New System.Drawing.Point(87, 24)
        Me.rioCnt2.Name = "rioCnt2"
        Me.rioCnt2.Size = New System.Drawing.Size(50, 19)
        Me.rioCnt2.TabIndex = 5
        Me.rioCnt2.Text = "2幅"
        Me.rioCnt2.UseVisualStyleBackColor = True
        '
        'rioCnt3
        '
        Me.rioCnt3.AutoSize = True
        Me.rioCnt3.Location = New System.Drawing.Point(167, 24)
        Me.rioCnt3.Name = "rioCnt3"
        Me.rioCnt3.Size = New System.Drawing.Size(50, 19)
        Me.rioCnt3.TabIndex = 6
        Me.rioCnt3.Text = "3幅"
        Me.rioCnt3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rioCnt3)
        Me.GroupBox1.Controls.Add(Me.rioCnt1)
        Me.GroupBox1.Controls.Add(Me.rioCnt2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 61)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "短邊幅數"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(367, 180)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.btnChoosePrinter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChoosePrinter As Button
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rioCnt1 As RadioButton
    Friend WithEvents rioCnt2 As RadioButton
    Friend WithEvents rioCnt3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
