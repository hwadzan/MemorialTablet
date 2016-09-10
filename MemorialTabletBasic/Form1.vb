Imports System.Drawing.Printing
Imports MemorialTabletBasic.LayoutUtil
Imports MemorialTabletBasic.TabletInfo

Public Class Form1
    Private printPreviewDiag As New PrintPreviewDialog()
    Private printDiag As New PrintDialog

    Private WithEvents printDoc As New PrintDocument()

    Public Structure PageInfo ' in unit 0.01 inch
        Dim marginLeft As Integer
        Dim marginTop As Integer
        Dim marginButtom As Integer
        Dim marginRight As Integer
        Dim pageWidth As Integer
        Dim pageHeight As Integer
    End Structure

    Public Structure PageConfigInfo ' margin in unit 0.01 inch
        Dim marginLeft As Integer
        Dim marginTop As Integer
        Dim marginButtom As Integer
        Dim marginRight As Integer
        Dim horizontalCount As Integer
        Dim verticalCount As Integer
    End Structure

    Private currentPrinterSettings As New PrinterSettings
    Private miniMarginInfo As New PageInfo
    Private pageConfig As New PageConfigInfo

    Private currentPrintCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pageConfig.marginTop = 50
        pageConfig.marginRight = 50
        pageConfig.marginLeft = 50
        pageConfig.marginButtom = 50
        pageConfig.verticalCount = 1
        pageConfig.horizontalCount = 1

        updateUI()
        lbRawNum.Text = "0"

        If False Then
            Dim ti As TabletRawItem = New TabletRawItem
            ti.Type = "C"
            ti.Filename = "C001.txt"
            ti.Val1 = "台北市大安區忠孝東路二段263巷32弄9號二十二樓"
            ti.Val2 = "xxxx"
            tabletAllSource.Add(ti)
            printDoc.DefaultPageSettings.Landscape = True
            printPreviewDiag.Document = printDoc
            printPreviewDiag.ShowDialog()
        End If
    End Sub

    Public Function pageInfo2Str(pi As PageInfo) As String
        pageInfo2Str =
            "左:" + pi.marginLeft.ToString +
            ", 右:" + pi.marginRight.ToString +
            ", 上:" + pi.marginTop.ToString +
            ", 下:" + pi.marginButtom.ToString +
            ", 寬:" + pi.pageWidth.ToString +
            ", 高:" + pi.pageHeight.ToString
    End Function

    Private Sub updatePapeInfo()
        Dim pageSettings = currentPrinterSettings.DefaultPageSettings

        miniMarginInfo.marginLeft = pageSettings.PrintableArea.Left
        miniMarginInfo.marginRight = pageSettings.PaperSize.Width - pageSettings.PrintableArea.Right
        miniMarginInfo.marginTop = pageSettings.PrintableArea.Top
        miniMarginInfo.marginButtom = pageSettings.PaperSize.Height - pageSettings.PrintableArea.Bottom

        miniMarginInfo.pageWidth = pageSettings.PrintableArea.Right - pageSettings.PrintableArea.Left
        miniMarginInfo.pageHeight = pageSettings.PrintableArea.Bottom - pageSettings.PrintableArea.Top

        lbMinimalBoundry.Text = pageInfo2Str(miniMarginInfo)
    End Sub

    Private Sub updatePageConfig()
        txBoundLeft.Text = pageConfig.marginLeft.ToString
        txBoundRight.Text = pageConfig.marginRight.ToString
        txBoundTop.Text = pageConfig.marginTop.ToString
        txBoundButtom.Text = pageConfig.marginButtom.ToString

        txHorizontalCount.Text = pageConfig.horizontalCount.ToString
        txVerticalCount.Text = pageConfig.verticalCount.ToString
    End Sub

    Private Sub updateUI()
        updatePapeInfo()
        updatePageConfig()
    End Sub

    Private Sub btnChoosePrinter_Click(sender As Object, e As EventArgs) Handles btnChoosePrinter.Click
        Dim ret As DialogResult

        ret = printDiag.ShowDialog()
        If ret = DialogResult.OK Then
            currentPrinterSettings = printDiag.PrinterSettings
            updateUI()
        End If
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        printDoc.PrinterSettings = currentPrinterSettings
        printPreviewDiag.Document = printDoc
        printPreviewDiag.ShowDialog()
    End Sub

    ' old version of manually written wrapString1. works for english and chinese. other language might need more test !
    Private Function wrapString1(g As Graphics, inStr As String, f As Font, rect As Rectangle, strFmt As StringFormat) As List(Of String)
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

    ' use SetMeasurableCharacterRanges, which might apply better for more language
    Private Function wrapString(g As Graphics, inStr As String, f As Font, rect As Rectangle, strFmt As StringFormat) As List(Of String)
        inStr = inStr.Trim()
        Dim retStrAr As New List(Of String)()
        If (inStr.Length < 6) Then
            retStrAr.Add(inStr.Trim)
            Return retStrAr
        End If

        While inStr.Length > 0
            Dim rngCnt As Integer = Math.Min(32, inStr.Length)
            Dim measuresStrFmt As New StringFormat(strFmt)
            Dim cRanges(rngCnt - 1) As CharacterRange
            Dim i As Integer
            For i = 0 To rngCnt - 1
                cRanges(i) = New CharacterRange(i, 1)
            Next
            measuresStrFmt.SetMeasurableCharacterRanges(cRanges)
            Dim largerRect As New Rectangle(rect.Location, New Size(rect.Size.Width * 5, rect.Size.Height))
            Dim charRects As Region() = g.MeasureCharacterRanges(inStr, f, largerRect, measuresStrFmt)
            Dim sprlitPoint As Integer = 0
            Dim prevRect As Region = New Region(New Rectangle(0, 0, 0, 0))
            Dim curRect As Region = New Region(New Rectangle(0, 0, 0, 0))
            For i = 0 To rngCnt - 1
                curRect = charRects(i)
                If curRect.GetBounds(g).Location.X <> 0 Then
                    If prevRect.GetBounds(g).Location.X <> 0 Then
                        If prevRect.GetBounds(g).Location.X < curRect.GetBounds(g).Location.X Then
                            Dim strToAdd As String = inStr.Substring(0, i)
                            retStrAr.Add(strToAdd.Trim)
                            inStr = inStr.Substring(i).Trim
                            Exit For
                        End If
                    Else
                        prevRect = curRect
                    End If
                End If
            Next
            If (i = rngCnt) Then
                retStrAr.Add(inStr)
                inStr = ""
            End If
        End While

        Return retStrAr
    End Function

    Private Sub drawRectIfTrue(b As Boolean, g As Graphics, rect As Rectangle)
        If b Then g.DrawRectangle(Pens.Black, rect)
    End Sub

    ' 地基主
    Private Sub drawMemo(g As Graphics, tX As Single, tY As Single, tWidth As Single, tHeight As Single,
                         ti As TabletItem)
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
        g.DrawString(ti.rightStr, fontR, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)
        ' 中間上方
        rect = New Rectangle(tX + 110 * scaleAdj, tY + 165 * scaleAdj, 30 * scaleAdj, 120 * scaleAdj)
        g.DrawString(ti.center1, fontC1, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)

        ' 中間 中方
        Dim rectCenter = New Rectangle(tX + 110 * scaleAdj, tY + 290 * scaleAdj, 30 * scaleAdj, 230 * scaleAdj)
        Dim wR As List(Of String) = wrapString(g, ti.center2, fontC2, rectCenter, drawFormatCenter)
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
            wR = wrapString(g, ti.center2, fontC2r34, rectCenter, drawFormatCenter)
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
        g.DrawString(ti.center3, fontC1, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)
        ' 左邊 上方
        rect = New Rectangle(tX + 20 * scaleAdj, tY + 300 * scaleAdj, 23 * scaleAdj, 50 * scaleAdj)
        g.DrawString(ti.left1, fontL1, Brushes.Black, rect, drawFormat)
        drawRectIfTrue(drawRect, g, rect)
        ' 左邊 下方
        rect = New Rectangle(tX + 20 * scaleAdj, tY + 350 * scaleAdj, 23 * scaleAdj, 260 * scaleAdj)
        g.DrawString(ti.left2, fontL2, Brushes.Black, rect, drawFormatFar)
        drawRectIfTrue(drawRect, g, rect)
        ' 左邊 下方 小標 TODO
    End Sub

    Sub printDoc_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim pageSettings = currentPrinterSettings.DefaultPageSettings

        Dim pInfo As PlacementInfo = LayoutUtil.computePlacementInfo(
            New PointF(pageConfig.marginLeft, pageConfig.marginTop),
            New SizeF(
                CType(pageSettings.PaperSize.Width - pageConfig.marginLeft - pageConfig.marginRight, Single),
                CType(pageSettings.PaperSize.Height - pageConfig.marginTop - pageConfig.marginButtom, Single)),
                pageConfig.horizontalCount, pageConfig.verticalCount,
                My.Resources.background.Size
            )

        Dim ti As New TabletItem
        For ix = 1 To pageConfig.horizontalCount
            For iy = 1 To pageConfig.verticalCount
                If (currentPrintCount < tabletAllSource.Count) Then
                    Dim item As TabletRawItem = tabletAllSource.Item(currentPrintCount)
                    Dim pt As PointF = LayoutUtil.rectOfIdx(ix, iy, pInfo)
                    'drawMemo1(e.Graphics, tPageX + (ix - 1) * tWidth, tPageY + (iy - 1) * tHeight, tWidth, tHeight,
                    '          "台北市大安區忠孝東路二段216巷24弄5號五樓", "    地基主", "三寶弟子三")
                    TabletInfo.raw2Tablet(item, ti) ' ti call by reference
                    drawMemo(e.Graphics, pt.X, pt.Y, pInfo.tWidth, pInfo.tHeight, ti)
                    currentPrintCount += 1
                End If
            Next
        Next
        If (currentPrintCount >= tabletAllSource.Count) Then
            e.HasMorePages = False
            currentPrintCount = 0
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub inputFileInDirInType(dir As String, typeChar As Char)
        Dim rawInfo As TabletRawInfo = TabletInfo.getExpectRawInfo(typeChar)
        Dim di As New IO.DirectoryInfo(dir)
        Dim files = di.GetFiles(typeChar + "*.txt")

        For Each file In files
            Dim sr As New System.IO.StreamReader(file.FullName, System.Text.Encoding.Default)
            Do While sr.Peek() >= 0
                Dim line As String = sr.ReadLine().Trim
                If line.Length = 0 Then Continue Do
                Dim linear() As String = Split(line, vbTab)

                Dim item As TabletRawItem = New TabletRawItem
                item.Type = typeChar
                item.Filename = file.Name
                item.Val1 = linear(0)

                If linear.Count >= 2 Then item.Val2 = linear(1) Else item.Val2 = ""
                If (linear.Count <> rawInfo.numOfRaw) Then
                    tabletWarnSource.Add(item)
                End If
                ' tabletWarnSource.Add(item)
                tabletAllSource.Add(item)
            Loop
            sr.Close()
        Next
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If chooseFolderDiag.ShowDialog() <> DialogResult.OK Then Exit Sub

        tabletWarnSource.Clear()
        tabletAllSource.Clear()

        If ckTypeC.Checked Then inputFileInDirInType(chooseFolderDiag.SelectedPath, "C")
        If ckTypeD.Checked Then inputFileInDirInType(chooseFolderDiag.SelectedPath, "D")
        If ckTypeL.Checked Then inputFileInDirInType(chooseFolderDiag.SelectedPath, "L")
        If ckTypeW.Checked Then inputFileInDirInType(chooseFolderDiag.SelectedPath, "W")
        If ckTypeY.Checked Then inputFileInDirInType(chooseFolderDiag.SelectedPath, "Y")

        lbRawNum.Text = tabletAllSource.Count
    End Sub

    Private Function valAfterUpdate(o As Integer, t As String, min As Integer, max As Integer) As Integer
        Dim val As Integer
        Dim parseSucc As Boolean
        Try
            parseSucc = Integer.TryParse(t, val)
        Catch ex As Exception
        End Try

        If Not parseSucc Then
            Return o
        End If
        If val < min Then Return min
        If val > max Then Return max
        Return val
    End Function

    Private Sub txBoundAll_LostFocus(sender As Object, e As EventArgs) Handles _
            txBoundLeft.LostFocus,
            txBoundRight.LostFocus,
            txBoundTop.LostFocus,
            txBoundButtom.LostFocus
        If sender.Equals(txBoundLeft) Then
            pageConfig.marginLeft = valAfterUpdate(pageConfig.marginLeft, txBoundLeft.Text, miniMarginInfo.marginLeft, 200)
        ElseIf sender.Equals(txBoundRight) Then
            pageConfig.marginRight = valAfterUpdate(pageConfig.marginRight, txBoundRight.Text, miniMarginInfo.marginRight, 200)
        ElseIf sender.Equals(txBoundTop) Then
            pageConfig.marginTop = valAfterUpdate(pageConfig.marginTop, txBoundTop.Text, miniMarginInfo.marginTop, 200)
        ElseIf sender.Equals(txBoundButtom) Then
            pageConfig.marginButtom = valAfterUpdate(pageConfig.marginButtom, txBoundButtom.Text, miniMarginInfo.marginButtom, 200)
        End If
        updatePageConfig()
    End Sub

    Private Sub txCount_LostFocus(sender As Object, e As EventArgs) Handles _
            txHorizontalCount.LostFocus, txVerticalCount.LostFocus
        If sender.Equals(txHorizontalCount) Then
            pageConfig.horizontalCount = valAfterUpdate(
                pageConfig.horizontalCount,
                txHorizontalCount.Text,
                1, 50)
        ElseIf sender.Equals(txVerticalCount) Then
            pageConfig.verticalCount = valAfterUpdate(
                pageConfig.verticalCount,
                txVerticalCount.Text,
                1, 50)
        End If
    End Sub

    Private Sub btnProposeHorizontal_Click(sender As Object, e As EventArgs) Handles btnProposeHorizontal.Click
        Dim pageSettings = currentPrinterSettings.DefaultPageSettings
        pageConfig.horizontalCount = LayoutUtil.proposedHorizontalCount(
            pageConfig.verticalCount,
            New PointF(pageConfig.marginLeft, pageConfig.marginTop),
            New SizeF(
                CType(pageSettings.PaperSize.Width - pageConfig.marginLeft - pageConfig.marginRight, Single),
                CType(pageSettings.PaperSize.Height - pageConfig.marginTop - pageConfig.marginButtom, Single)),
            My.Resources.background.Size)
        txHorizontalCount.Text = pageConfig.horizontalCount.ToString
    End Sub

    Private Sub btnProposeVertical_Click(sender As Object, e As EventArgs) Handles btnProposeVertical.Click
        Dim pageSettings = currentPrinterSettings.DefaultPageSettings
        pageConfig.verticalCount = LayoutUtil.proposedVerticalCount(
            pageConfig.horizontalCount,
            New PointF(pageConfig.marginLeft, pageConfig.marginTop),
            New SizeF(
                CType(pageSettings.PaperSize.Width - pageConfig.marginLeft - pageConfig.marginRight, Single),
                CType(pageSettings.PaperSize.Height - pageConfig.marginTop - pageConfig.marginButtom, Single)),
            My.Resources.background.Size)
        txVerticalCount.Text = pageConfig.verticalCount.ToString
    End Sub

    Private Sub AllDelRow(ByVal sender As Object, ByVal e As DataGridViewRowCancelEventArgs) _
            Handles dgvAll.UserDeletingRow
        Dim raws = dgvAll.SelectedRows

        For Each row In raws
            Dim ti As TabletRawItem = TryCast(row.DataBoundItem, TabletRawItem)
            tabletWarnSource.Remove(ti)
        Next
        lbRawNum.Text = tabletAllSource.Count.ToString
    End Sub

    Private Sub WarnDelRow(ByVal sender As Object, ByVal e As DataGridViewRowCancelEventArgs) _
           Handles dgvWarn.UserDeletingRow
        Dim raws = dgvWarn.SelectedRows

        For Each row In raws
            Dim ti As TabletRawItem = TryCast(row.DataBoundItem, TabletRawItem)
            tabletAllSource.Remove(ti)
        Next

        lbRawNum.Text = tabletAllSource.Count.ToString
    End Sub
End Class
