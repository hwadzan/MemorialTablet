Public Class TabletInfo
    Public Structure TabletRawItem
        Public type As Char
        Public filename As String
        Public val1 As String
        Public val2 As String
    End Structure

    Public Structure TabletItem
        Public rightStr As String
        Public center1 As String
        Public center2 As String
        Public center3 As String
        Public left1 As String
        Public left2 As String
        Public left3 As String
    End Structure

    Public Structure TabletRawInfo
        Public numOfRaw As Integer
        Public maxLength() As Integer
    End Structure

    Public Shared Function getExpectRawInfo(type As String) As TabletRawInfo
        Select Case type
            Case "C"
                getExpectRawInfo = New TabletRawInfo
                getExpectRawInfo.numOfRaw = 1
                getExpectRawInfo.maxLength = {40}
            Case "D"
                getExpectRawInfo = New TabletRawInfo
                getExpectRawInfo.numOfRaw = 2
                getExpectRawInfo.maxLength = {20, 20}
            Case "L"
                getExpectRawInfo = New TabletRawInfo
                getExpectRawInfo.numOfRaw = 2
                getExpectRawInfo.maxLength = {10, 20}
            Case "W"
                getExpectRawInfo = New TabletRawInfo
                getExpectRawInfo.numOfRaw = 2
                getExpectRawInfo.maxLength = {10, 20}
            Case "Y"
                getExpectRawInfo = New TabletRawInfo
                getExpectRawInfo.numOfRaw = 1
                getExpectRawInfo.maxLength = {25}
            Case Else
                getExpectRawInfo = New TabletRawInfo
                getExpectRawInfo.numOfRaw = 0
                getExpectRawInfo.maxLength = {0}
        End Select
    End Function

    Public Shared Sub raw2Tablet(r As TabletRawItem, ByRef t As TabletItem)
        Select Case r.type
            Case "C" ' C長生祿位
                t.rightStr = ""
                t.center1 = "佛力注照"
                t.center2 = r.val1
                t.center3 = "長生祿位"
                t.left1 = ""
                t.left2 = ""
                t.left3 = r.filename
            Case "D" ' D地基主
                t.rightStr = r.val1
                t.center1 = "佛力超薦"
                t.center2 = "地基主"
                t.center3 = "往生蓮位"
                t.left1 = "陽上"
                t.left2 = r.val2
                t.left3 = r.filename
            Case "L" ' L歷代祖先
                t.rightStr = ""
                t.center1 = "佛力超薦"
                t.center2 = r.val1 + "氏歷代祖先"
                t.center3 = "往生蓮位"
                t.left1 = "陽上"
                t.left2 = r.val2
                t.left3 = r.filename
            Case "W" ' 往生蓮位
                t.rightStr = ""
                t.center1 = "佛力超薦"
                t.center2 = r.val1
                t.center3 = "往生蓮位"
                t.left1 = "陽上"
                t.left2 = r.val2
                t.left3 = r.filename
            Case "Y" ' 冤親債主
                t.rightStr = ""
                t.center1 = "佛力超薦"
                t.center2 = "累劫冤親債主"
                t.center3 = "往生蓮位"
                t.left1 = "陽上"
                t.left2 = r.val1
                t.left3 = r.filename
            Case Else
                MsgBox("程式內部錯誤")
        End Select
    End Sub
End Class
