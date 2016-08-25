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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnChoosePrinter = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(363, 27)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(141, 41)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "直接印列"
        Me.btnPrint.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(540, 97)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.btnChoosePrinter)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents btnChoosePrinter As Button
    Friend WithEvents btnPrintPreview As Button
End Class
