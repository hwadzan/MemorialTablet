Imports System.Drawing.Printing
Imports Microsoft.VisualBasic

Public Class LayoutUtil
    Public Structure PlacementInfo
        Dim xPos As Single
        Dim yPos As Single

        Dim xOffset As Single
        Dim yOffset As Single

        Dim tWidth As Single
        Dim tHeight As Single

        Dim scale As Single

        Dim horizontalCount As Integer
        Dim verticalCount As Integer
    End Structure

    Public Shared Function proposedVerticalCount(
                              horizontalCount As Integer,
                              p As PointF, drawArea As SizeF,
                              objSize As Size) As Integer
        Dim scaleX = drawArea.Width / (objSize.Width * horizontalCount)
        proposedVerticalCount = Math.Floor(drawArea.Height / (objSize.Height * scaleX))
        If (proposedVerticalCount = 0) Then proposedVerticalCount = 1
    End Function

    Public Shared Function proposedHorizontalCount(
                              verticalCount As Integer,
                              p As PointF, drawArea As SizeF,
                              objSize As Size
                              ) As Integer
        Dim scaleY = drawArea.Height / (objSize.Height * verticalCount)
        proposedHorizontalCount = Math.Floor(drawArea.Width / (objSize.Width * scaleY))
        If (proposedHorizontalCount = 0) Then proposedHorizontalCount = 1
    End Function

    Public Shared Function computePlacementInfo(p As PointF, drawArea As SizeF,
                                    horizontalCount As Integer, verticalCount As Integer,
                                    objSize As Size) As PlacementInfo
        Dim ci As New PlacementInfo

        ci.xPos = p.X
        ci.yPos = p.Y
        ci.horizontalCount = horizontalCount
        ci.verticalCount = verticalCount

        Dim scaleX, scaleY As Single

        ' sWidth = objSize.Width ; sHeight = objSize.Height
        ' tPageX = p.X ; tPageY = p.Y
        ' tPageWidth = drawArea.Width ; tPageHeight = drawArea.Height

        scaleX = drawArea.Width / (objSize.Width * horizontalCount)
        scaleY = drawArea.Height / (objSize.Height * verticalCount)

        If scaleX < scaleY Then
            ci.scale = scaleX

            ci.tWidth = objSize.Width * ci.scale
            ci.tHeight = objSize.Height * ci.scale

            ci.xOffset = objSize.Width * ci.scale

            If (ci.verticalCount = 1) Then
                ci.yOffset = 0
                ci.yPos = ci.yPos + (drawArea.Height - ci.tHeight) / 2
            Else
                ci.yOffset = ci.tHeight + (drawArea.Height - ci.verticalCount * ci.tHeight) / (ci.verticalCount - 1)
            End If
        Else
            ci.scale = scaleY

            ci.tWidth = objSize.Width * ci.scale
            ci.tHeight = objSize.Height * ci.scale

            If (ci.horizontalCount = 1) Then
                ci.xOffset = 0
                ci.xPos = ci.xPos + (drawArea.Width - ci.tWidth) / 2
            Else
                ci.xOffset = ci.tWidth + (drawArea.Width - ci.horizontalCount * ci.tWidth) / (ci.horizontalCount - 1)
            End If

            ci.yOffset = objSize.Height * ci.scale
        End If
        Return ci
    End Function

    Public Shared Function rectOfIdx(ix As Integer, iy As Integer, pi As PlacementInfo) As PointF
        If (ix > pi.horizontalCount) Then ix = pi.horizontalCount
        If (iy > pi.verticalCount) Then iy = pi.verticalCount
        rectOfIdx = New PointF(
            pi.xPos + (ix - 1) * pi.xOffset,
            pi.yPos + (iy - 1) * pi.yOffset)
    End Function

    ' not used.
    Public Shared Function getMaxPaperSize(ps As PrinterSettings) As SizeF
        Dim maxSize As New SizeF
        maxSize.Width = 0
        maxSize.Height = 0
        For i = 0 To ps.PaperSizes.Count - 1
            Dim pkSize = ps.PaperSizes.Item(i)
            If pkSize.Width > maxSize.Width Or pkSize.Height > maxSize.Height Then
                maxSize.Width = pkSize.Width
                maxSize.Height = pkSize.Height
            End If
        Next
        Return maxSize
    End Function
End Class
