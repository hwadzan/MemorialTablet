Imports System.Drawing.Printing

Public Class Form1

    Private printPreviewDiag As New PrintPreviewDialog()
    Private printDiag As New PrintDialog

    Private WithEvents printDoc As New PrintDocument()

    ' default page settings from default printer
    Private currentPrinterSettings As New PrinterSettings

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If True Then
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

    ' 地基主
    Private Sub drawMemo1(g As Graphics, tX As Single, tY As Single, tWidth As Single, tHeight As Single,
                          addr As String, name1 As String, name2 As String) ' addr 住址, name1 先人, name2 陽上
        Dim sWidth, sHeight As Single
        Dim scale
        Dim scaleD = 0.188147
        Dim scaleAdj As Single
        Dim fontR As Font
        Dim fontC1 As Font, fontC2 As Font
        Dim fontL1 As Font, fontL2 As Font

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

        fontC1 = New Font("新細明體", Int(20 * scaleAdj))
        fontC2 = New Font("標楷體", Int(20 * scaleAdj))
        fontL1 = New Font("標楷體", Int(15 * scaleAdj))
        fontL2 = New Font("新細明體", Int(15 * scaleAdj))

        fontR = New Font("標楷體", Int(13 * scaleAdj))

        ' of stringToPrint that will fit within the bounds of the page.
        ' g.MeasureString(c1, Me.Font, e.MarginBounds.Size,
        ' StringFormat.GenericTypographic, charactersOnPage, linesPerPage)

        Dim drawFormat As New System.Drawing.StringFormat
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical

        ' Draws the string within the bounds of the page.
        ' g.DrawString(c1, Me.Font, Brushes.Black, New RectangleF(tX, tY, tWidth, tHeight), StringFormat.GenericTypographic)
        ' g.DrawString(c1, font1, Brushes.Black, New RectangleF(tX, tY, tWidth, tHeight), StringFormat.GenericTypographic)
        g.DrawString(addr, fontR, Brushes.Black, New RectangleF(tX + 165 * scaleAdj, tY + 200 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)
        g.DrawString(c1, fontC1, Brushes.Black, New RectangleF(tX + 110 * scaleAdj, tY + 165 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)
        g.DrawString(name1, fontC2, Brushes.Black, New RectangleF(tX + 110 * scaleAdj, tY + 300 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)
        g.DrawString(c2, fontC1, Brushes.Black, New RectangleF(tX + 110 * scaleAdj, tY + 525 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)
        g.DrawString(l1, fontL1, Brushes.Black, New RectangleF(tX + 20 * scaleAdj, tY + 430 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)
        g.DrawString(name2, fontL2, Brushes.Black, New RectangleF(tX + 20 * scaleAdj, tY + 490 * scaleAdj, 30 * scaleAdj, tHeight), drawFormat)

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
                drawMemo1(e.Graphics, tPageX + (ix - 1) * tWidth, tPageY + (iy - 1) * tHeight, tWidth, tHeight,
                          "台北市大安區忠孝東路二段216巷24弄5號五樓", "    地基主", "三寶弟子三")
            Next
        Next
        e.HasMorePages = False
    End Sub
End Class
