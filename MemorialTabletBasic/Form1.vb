Imports System.Drawing.Printing

Public Class Form1

    Private printPreviewDiag As New PrintPreviewDialog()
    Private printDiag As New PrintDialog

    Private WithEvents printDoc As New PrintDocument()

    ' default page settings from default printer
    Private currentPrinterSettings As New PrinterSettings

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If False Then
            printDoc.DefaultPageSettings.Landscape = True
            printPreviewDiag.Document = printDoc
            printPreviewDiag.ShowDialog()
        End If
    End Sub

    Private Sub btnChoosePrinter_Click(sender As Object, e As EventArgs) Handles btnChoosePrinter.Click
        Dim ret As DialogResult

        ret = printDiag.ShowDialog()
        If ret = DialogResult.OK Then
            currentPrinterSettings = printDiag.PrinterSettings
        End If
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        printDoc.PrinterSettings = currentPrinterSettings
        printPreviewDiag.Document = printDoc
        printPreviewDiag.ShowDialog()
    End Sub

    ' 往生蓮位
    Private Sub drawMemo1(g As Graphics, tX As Single, tY As Single, tWidth As Single, tHeight As Single,
                          name1 As String, name2 As String) ' name1 先人, name2 陽上
        Dim sWidth, sHeight As Single
        Dim scale
        Dim scaleD = 0.188147
        Dim scaleAdj As Single
        Dim fontC As Font

        sWidth = My.Resources.background.Size.Width
        sHeight = My.Resources.background.Size.Height

        scale = tWidth / sWidth
        scaleAdj = scale / scaleD
        g.DrawImage(My.Resources.background,
                    New System.Drawing.RectangleF(tX, tY, tWidth, tHeight),
                    New System.Drawing.RectangleF(0, 0, sWidth, sHeight),
                    System.Drawing.GraphicsUnit.Pixel)

        Dim c1 As String = "佛力超薦"
        Dim c2 As String = "往生蓮位"

        Dim l1 As String = "陽上"

        fontC = New Font("新細明體", Int(20 * scaleAdj))

        ' of stringToPrint that will fit within the bounds of the page.
        ' g.MeasureString(c1, Me.Font, e.MarginBounds.Size,
        ' StringFormat.GenericTypographic, charactersOnPage, linesPerPage)

        Dim drawFormat As New System.Drawing.StringFormat
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical

        ' Draws the string within the bounds of the page.
        ' g.DrawString(c1, Me.Font, Brushes.Black, New RectangleF(tX, tY, tWidth, tHeight), StringFormat.GenericTypographic)
        ' g.DrawString(c1, font1, Brushes.Black, New RectangleF(tX, tY, tWidth, tHeight), StringFormat.GenericTypographic)
        g.DrawString(c1, fontC, Brushes.Black, New RectangleF(tX + 110 * scaleAdj, tY + 165 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)
        g.DrawString(c2, fontC, Brushes.Black, New RectangleF(tX + 110 * scaleAdj, tY + 525 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)
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
        ' scale = scale / 2

        tWidth = sWidth * scale
        tHeight = sHeight * scale

        For ix = 1 To Int(tPageWidth / tWidth)
            For iy = 1 To Int(tPageHeight / tHeight)
                drawMemo1(e.Graphics, tPageX + (ix - 1) * tWidth, tPageY + (iy - 1) * tHeight, tWidth, tHeight, "n1", "n2")
            Next
        Next
        e.HasMorePages = False
    End Sub
End Class
