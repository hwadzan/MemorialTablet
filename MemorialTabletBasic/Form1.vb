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

    Sub printDoc_PrintPage(ByVal sender As Object,
        ByVal e As PrintPageEventArgs) Handles printDoc.PrintPage

        Dim scale As Single
        Dim scaleX, scaleY As Single

        Dim sWidth, sHeight As Single

        Dim tPageX, tPageY As Single
        Dim tPageWidth, tPageHeight As Single
        Dim tWidth, tHeight As Single

        Dim ix, iy As Integer

        sWidth = My.Resources.background.Size.Width
        sHeight = My.Resources.background.Size.Height

        tPageX = e.MarginBounds.X
        tPageY = e.MarginBounds.Y
        tPageWidth = e.MarginBounds.Width
        tPageHeight = e.MarginBounds.Height
        If (tPageX > 50) Then
            tPageWidth = tPageWidth + 2 * (tPageX - 50)
            tPageX = 50
        End If
        If (tPageY > 50) Then
            tPageHeight = tPageHeight + 2 * (tPageY - 50)
            tPageY = 50
        End If
        scaleX = tPageWidth / sWidth
        scaleY = tPageHeight / sHeight

        If scaleX < scaleY Then
            scale = scaleX
        Else
            scale = scaleY
        End If
        scale = scale / 2

        tWidth = sWidth * scale
        tHeight = sHeight * scale

        For ix = 1 To Int(tPageWidth / tWidth)
            For iy = 1 To Int(tPageHeight / tHeight)
                e.Graphics.DrawImage(My.Resources.background,
                    New System.Drawing.RectangleF(tPageX + (ix - 1) * tWidth, tPageY + (iy - 1) * tHeight, tWidth, tHeight),
                    New System.Drawing.RectangleF(0, 0, sWidth, sHeight),
                    System.Drawing.GraphicsUnit.Pixel)
            Next
        Next
        e.HasMorePages = False
    End Sub
End Class
