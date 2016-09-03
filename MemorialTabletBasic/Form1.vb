Imports System.Drawing.Printing
' Imports System.Printing

Public Class Form1
    Private printPreviewDiag As New PrintPreviewDialog()
    Private printDiag As New PrintDialog

    Private WithEvents printDoc As New PrintDocument()

    Private currentPrinterSettings As New PrinterSettings

    Private Structure TabletItem
        Public filename As String
        Public val1 As String
        Public val2 As String
        Public val3 As String
    End Structure

    Private tabletData As New ArrayList
    Private currentPrintCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If True Then
            Dim ti As TabletItem = New TabletItem
            ti.val1 = "台北市大安區忠孝東路二段263巷32弄9號二十二樓"
            ti.val2 = "xxxx"
            tabletData.Add(ti)
            printDoc.DefaultPageSettings.Landscape = True
            printPreviewDiag.Document = printDoc
            printPreviewDiag.ShowDialog()
        End If

        'Dim server As LocalPrintServer = New LocalPrintServer();
        'PrintQueueCollection queueCollection = server.GetPrintQueues();
        'PrintQueue printQueue = null;

        'foreach(PrintQueue pq In queueCollection)
        '{
        '    If (pq.FullName == PrinterName) Then
        '        printQueue = pq;
        '}

        'Int numberOfJobs = 0;
        'If (printQueue!= null) Then
        '    numberOfJobs = printQueue.NumberOfJobs;
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

    Private Function wrapString(g As Graphics, inStr As String, f As Font, rect As Rectangle, strFmt As StringFormat) As List(Of String)
        inStr = inStr.Trim()
        Dim retStrAr As New List(Of String)()
        If (inStr.Length < 6) Then
            retStrAr.Add(inStr.Trim)
            Return retStrAr
        End If
        Dim stringSize As New SizeF

        Dim prevStr As String = ""
        Dim prevSize As SizeF = New SizeF(0, 0)
        Dim curSize As SizeF

        Dim strlen As Integer = inStr.Length
        Dim prevStrStart As Integer = 0
        Dim i As Integer
        Dim prevCutIdx As Integer = 0
        Dim prevIsPunctuation = False
        Dim strToAdd As String
        For i = 0 To strlen - 1
            Dim curChar = inStr.Substring(i, 1)
            If Char.IsPunctuation(curChar) Then
                prevIsPunctuation = True
            ElseIf prevIsPunctuation Then
                prevCutIdx = i
                prevIsPunctuation = False
            ElseIf Char.IsDigit(curChar) Or Char.IsUpper(curChar) Or Char.IsLower(curChar) Then ' prevIsPunctuation is false here
                prevIsPunctuation = False
                ' pass
            Else ' white space, chinese char
                prevIsPunctuation = False
                prevCutIdx = i
            End If
            curSize = g.MeasureString(inStr.Substring(prevStrStart, i - prevStrStart + 1), f, New SizeF(rect.Width, rect.Height), strFmt)
            If prevSize.Width = 0 Then
                prevSize = curSize
                Continue For
            ElseIf prevSize = curSize And Not Char.IsWhiteSpace(curChar) Then
                ' retStrAr.Add(inStr.Substring(prevStrStart, i - prevStrStart))
                If (prevCutIdx = prevStrStart) Then
                    prevCutIdx = i ' just cut a very long english string
                End If
                strToAdd = inStr.Substring(prevStrStart, prevCutIdx - prevStrStart).Trim
                If strToAdd.Length > 0 Then
                    retStrAr.Add(strToAdd)
                End If
                prevStrStart = prevCutIdx
                prevSize = g.MeasureString(inStr.Substring(prevStrStart, i - prevStrStart + 1), f, New SizeF(rect.Width, rect.Height), strFmt)
            Else
                prevSize = curSize
            End If
        Next
        strToAdd = inStr.Substring(prevStrStart, i - prevStrStart).Trim
        retStrAr.Add(strToAdd)

        Return retStrAr
    End Function

    Private Sub drawRectIfTrue(b As Boolean, g As Graphics, rect As Rectangle)
        If b Then g.DrawRectangle(Pens.Black, rect)
    End Sub



    ' 地基主
    Private Sub drawMemo1(g As Graphics, tX As Single, tY As Single, tWidth As Single, tHeight As Single,
                          addr As String, name1 As String, name2 As String) ' addr 住址, name1 先人, name2 陽上
        Dim drawRect As Boolean = True

        Dim sWidth, sHeight As Single
        Dim scale
        Dim scaleD = 0.188147
        Dim scaleAdj As Single

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

        Dim fontC1 = New Font("新細明體", Int(19 * scaleAdj))
        Dim fontC2 = New Font("標楷體", Int(20 * scaleAdj)) ' for one and two rows.
        Dim fontC2r34 = New Font("標楷體", Int(19 * scaleAdj * 2 / 3)) ' for 3 and 4 rows.
        Dim fontL1 = New Font("標楷體", Int(15 * scaleAdj))
        Dim fontL2 = New Font("新細明體", Int(15 * scaleAdj))
        Dim fontR = New Font("標楷體", Int(13 * scaleAdj))

        Dim drawFormat As New System.Drawing.StringFormat
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical

        Dim drawFormatFar As New System.Drawing.StringFormat
        drawFormatFar.FormatFlags = StringFormatFlags.DirectionVertical
        drawFormatFar.Alignment = StringAlignment.Far

        Dim drawFormatCenter As New System.Drawing.StringFormat
        drawFormatCenter.FormatFlags = StringFormatFlags.DirectionVertical
        drawFormatCenter.Alignment = StringAlignment.Center
        drawFormatCenter.LineAlignment = StringAlignment.Center

        Dim rect As Rectangle
        ' 住址
        rect = New Rectangle(tX + 165 * scaleAdj, tY + 200 * scaleAdj, 23 * scaleAdj, 400 * scaleAdj)
        g.DrawString(addr, fontR, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)
        ' 中間上方
        rect = New Rectangle(tX + 110 * scaleAdj, tY + 165 * scaleAdj, 30 * scaleAdj, 120 * scaleAdj)
        g.DrawString(c1, fontC1, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)
        ' 中間 中方

        Dim rectCenter = New Rectangle(tX + 110 * scaleAdj, tY + 290 * scaleAdj, 30 * scaleAdj, 230 * scaleAdj)
        Dim wR As List(Of String) = wrapString(g, name1, fontC2, rectCenter, drawFormatCenter)
        If (wR.Count = 1) Then
            drawRectIfTrue(drawRect, g, rectCenter)
            g.DrawString(wR.Item(0), fontC2, Brushes.Black, rectCenter, drawFormatCenter)
        ElseIf (wR.Count = 2) Then
            Dim rectLeft = New Rectangle(tX + 95 * scaleAdj, tY + 290 * scaleAdj, 30 * scaleAdj, 230 * scaleAdj)
            drawRectIfTrue(drawRect, g, rectLeft)
            g.DrawString(wR.Item(1), fontC2, Brushes.Black, rectLeft, drawFormatCenter)
            Dim rectRight = New Rectangle(tX + 125 * scaleAdj, tY + 290 * scaleAdj, 30 * scaleAdj, 230 * scaleAdj)
            drawRectIfTrue(drawRect, g, rectRight)
            g.DrawString(wR.Item(0), fontC2, Brushes.Black, rectRight, drawFormatCenter)
        Else

            rectCenter = New Rectangle(tX + 115 * scaleAdj, tY + 300 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)
            wR = wrapString(g, name1, fontC2r34, rectCenter, drawFormatCenter)
            If (wR.Count = 1) Then ' this won't happen in general ! just in case.
                drawRectIfTrue(drawRect, g, rectCenter)
                g.DrawString(wR.Item(0), fontC2r34, Brushes.Black, rectCenter, drawFormatCenter)
            ElseIf (wR.Count = 2) Then
                Dim rectLeft = New Rectangle(tX + 100 * scaleAdj, tY + 290 * scaleAdj, 19 * scaleAdj, 230 * scaleAdj)
                drawRectIfTrue(drawRect, g, rectLeft)
                g.DrawString(wR.Item(1), fontC2r34, Brushes.Black, rectLeft, drawFormatCenter)

                Dim rectRight = New Rectangle(tX + 120 * scaleAdj, tY + 290 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)
                drawRectIfTrue(drawRect, g, rectRight)
                g.DrawString(wR.Item(0), fontC2r34, Brushes.Black, rectRight, drawFormatCenter)
            ElseIf (wR.Count = 3) Then
                Dim rectLeft = New Rectangle(tX + 95 * scaleAdj, tY + 300 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)
                rectCenter = New Rectangle(tX + 115 * scaleAdj, tY + 300 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)
                Dim rectRight = New Rectangle(tX + 135 * scaleAdj, tY + 300 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)

                drawRectIfTrue(drawRect, g, rectLeft)
                g.DrawString(wR.Item(2), fontC2r34, Brushes.Black, rectLeft, drawFormatCenter)

                drawRectIfTrue(drawRect, g, rectCenter)
                g.DrawString(wR.Item(1), fontC2r34, Brushes.Black, rectCenter, drawFormatCenter)

                drawRectIfTrue(drawRect, g, rectRight)
                g.DrawString(wR.Item(0), fontC2r34, Brushes.Black, rectRight, drawFormatCenter)
            ElseIf wR.Count >= 4 Then
                Dim rectLeft1 = New Rectangle(tX + 75 * scaleAdj, tY + 290 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)
                Dim rectLeft2 = New Rectangle(tX + 95 * scaleAdj, tY + 290 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)
                rectCenter = New Rectangle(tX + 115 * scaleAdj, tY + 290 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)
                Dim rectRight = New Rectangle(tX + 135 * scaleAdj, tY + 290 * scaleAdj, 20 * scaleAdj, 230 * scaleAdj)

                drawRectIfTrue(drawRect, g, rectLeft1)
                g.DrawString(wR.Item(3), fontC2r34, Brushes.Black, rectLeft1, drawFormatCenter)

                drawRectIfTrue(drawRect, g, rectLeft2)
                g.DrawString(wR.Item(2), fontC2r34, Brushes.Black, rectLeft2, drawFormatCenter)

                drawRectIfTrue(drawRect, g, rectCenter)
                g.DrawString(wR.Item(1), fontC2r34, Brushes.Black, rectCenter, drawFormatCenter)

                drawRectIfTrue(drawRect, g, rectRight)
                g.DrawString(wR.Item(0), fontC2r34, Brushes.Black, rectRight, drawFormatCenter)
            End If
        End If

        ' 中間 下方
        rect = New Rectangle(tX + 110 * scaleAdj, tY + 525 * scaleAdj, 30 * scaleAdj, 120 * scaleAdj)
        g.DrawString(c2, fontC1, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)
        ' 左邊 上方
        rect = New Rectangle(tX + 20 * scaleAdj, tY + 300 * scaleAdj, 23 * scaleAdj, 50 * scaleAdj)
        g.DrawString(l1, fontL1, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)
        ' 左邊 下方
        rect = New Rectangle(tX + 20 * scaleAdj, tY + 350 * scaleAdj, 23 * scaleAdj, 260 * scaleAdj)
        g.DrawString(name2, fontL2, Brushes.Black, rect, drawFormatFar)
        drawRectIfTrue(drawRect, g, rect)
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

        If Not rioCnt1.Checked Then
            If rioCnt2.Checked Then
                scale = scale / 2
            ElseIf rioCnt3.Checked Then
                scale = scale / 3
            End If
        End If

        tWidth = sWidth * scale
        tHeight = sHeight * scale

        For ix = 1 To Int(tPageWidth / tWidth)
            For iy = 1 To Int(tPageHeight / tHeight)
                If (currentPrintCount < tabletData.Count) Then
                    Dim item As TabletItem = tabletData.Item(currentPrintCount)
                    'drawMemo1(e.Graphics, tPageX + (ix - 1) * tWidth, tPageY + (iy - 1) * tHeight, tWidth, tHeight,
                    '          "台北市大安區忠孝東路二段216巷24弄5號五樓", "    地基主", "三寶弟子三")

                    drawMemo1(e.Graphics, tPageX + (ix - 1) * tWidth, tPageY + (iy - 1) * tHeight, tWidth, tHeight,
                    item.val1, "地基主在此this is a test地基主在此地基主在此地基主在此地基主在此地基主在此地基主在此地基主在此", item.val2)
                    currentPrintCount += 1
                End If
            Next
        Next
        If (currentPrintCount >= tabletData.Count) Then
            e.HasMorePages = False
            currentPrintCount = 0
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If openFileDiag.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(openFileDiag.FileName, System.Text.Encoding.Default)

            tabletData.Clear()

            Do While sr.Peek() >= 0
                Dim line As String = sr.ReadLine()
                Dim linear() As String = Split(line, vbTab)
                If (linear.Count <> 2) Then
                    Continue Do
                End If
                Dim item As TabletItem = New TabletItem
                item.filename = openFileDiag.FileName ' todo: only need file name without dir and extension
                item.val1 = linear(0)
                If linear.Count >= 2 Then item.val2 = linear(1)
                If linear.Count >= 3 Then item.val2 = linear(2)
                tabletData.Add(item)
            Loop
            ' MessageBox.Show(sr.ReadToEnd)
            sr.Close()
        End If
    End Sub
End Class
