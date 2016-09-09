Public Class TabletInfo
    Public Structure TabletRawItem
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

    Public Shared Sub typeCRaw2Tablet(r As TabletRawItem, ByRef t As TabletItem)

    End Sub


End Class
