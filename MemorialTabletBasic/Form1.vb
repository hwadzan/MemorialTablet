Imports System.Drawing.Printing

Public Class Form1

    Private printPreviewDiag As New PrintPreviewDialog()
    Private printDiag As New PrintDialog

    Private WithEvents printDoc As New PrintDocument()

    ' default page settings from default printer
    Private currentPageSettings As New PageSettings

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChoosePrinter_Click(sender As Object, e As EventArgs) Handles btnChoosePrinter.Click
        Dim ret As DialogResult

        ret = printDiag.ShowDialog()
        If ret = DialogResult.OK Then
            currentPageSettings = New PageSettings
        End If
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        printPreviewDiag.Document = printDoc
        printPreviewDiag.ShowDialog()
    End Sub

    Sub printDocument1_PrintPage(ByVal sender As Object,
        ByVal e As PrintPageEventArgs) Handles printDoc.PrintPage

        Dim bx, by As Single
        Dim x, y As Single

        bx = e.MarginBounds.X
        by = e.MarginBounds.Y

        Dim scale As Single
        Dim ox, oy As Single

        ox = My.Resources.background.Size.Width
        oy = My.Resources.background.Size.Height
        scale = e.MarginBounds.Width / ox
        x = ox * scale
        y = oy * scale

        If 1 Then
            e.Graphics.DrawImage(My.Resources.background,
                New System.Drawing.RectangleF(bx, by, x, y),
                New System.Drawing.RectangleF(0, 0, ox, oy), System.Drawing.GraphicsUnit.Pixel)
            ' e.Graphics.DrawImage(My.Resources.background, New PointF(0, 0))
        End If
        e.HasMorePages = False
    End Sub
End Class
