Public Class TabletInfo
    Public Class TabletRawItem
        Public Sub New()
        End Sub

        Public Sub New(type As Char, filename As String, val1 As String, val2 As String)
            ' Public Sub New(idx As Integer, type As Char, filename As String, val1 As String, val2 As String)
            ' _idx = idx
            _type = type
            _filename = filename
            _val1 = val1
            _val2 = val2
        End Sub

        ' Private _idx As Integer
        Private _type As Char
        Private _filename As String
        Private _val1 As String
        Private _val2 As String


        Public Property Type As Char
            Get
                Return _type
            End Get
            Set(value As Char)
                _type = value
            End Set
        End Property

        Public Property Filename As String
            Get
                Return _filename
            End Get
            Set(value As String)
                _filename = value
            End Set
        End Property

        Public Property Val1 As String
            Get
                Return _val1
            End Get
            Set(value As String)
                _val1 = value
            End Set
        End Property

        Public Property Val2 As String
            Get
                Return _val2
            End Get
            Set(value As String)
                _val2 = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return _type
        End Function
    End Class

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
