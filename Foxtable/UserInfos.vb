Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000253 RID: 595
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("0609")>
	Public Class UserInfos
		Implements IEnumerable(Of UserInfo)

		' Token: 0x06001B80 RID: 7040 RVA: 0x000ADAAD File Offset: 0x000ABCAD
		Public Sub New()
			Me.ooo___o_0.__. = New Dictionary(Of DataRow, UserInfo)()
		End Sub

		' Token: 0x06001B81 RID: 7041 RVA: 0x000ADAC0 File Offset: 0x000ABCC0
		Public Function Count() As Integer
			Return Me.UserView.Count
		End Function

		' Token: 0x06001B82 RID: 7042 RVA: 0x000ADACD File Offset: 0x000ABCCD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of UserInfo) Implements System.Collections.Generic.IEnumerable(Of Foxtable.UserInfo).GetEnumerator
			Return New o__o_O0_(Me.UserView)
		End Function

		' Token: 0x06001B83 RID: 7043 RVA: 0x000ADADA File Offset: 0x000ABCDA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New o__o_O0_(Me.UserView)
		End Function

		' Token: 0x1700063F RID: 1599
		' (get) Token: 0x06001B84 RID: 7044 RVA: 0x000ADAE7 File Offset: 0x000ABCE7
		Friend ReadOnly Property UserView As DataView
			Get
				If Operators.CompareString(Me.a, OO_00oOO.ProjectFile, True) <> 0 Then
					Me.a = OO_00oOO.ProjectFile
					Me.ooo___o_0.__.()
				End If
				Return Me.ooo___o_0.__.
			End Get
		End Property

		' Token: 0x06001B85 RID: 7045 RVA: 0x000ADB14 File Offset: 0x000ABD14
		Friend Sub <<EMPTY_NAME>>()
			Dim table As DataTable = O_O0OO.OoO_o.oO0o0O.()
			Me.ooo___o_0.__..Clear()
			Me.ooo___o_0.__. = New DataView(table, "[Type] <= " + Conversions.ToString(4) + " And [Name] Is Not Null And [Type] Is Not Null", "[Type]", DataViewRowState.CurrentRows)
		End Sub

		' Token: 0x06001B86 RID: 7046 RVA: 0x000ADB5A File Offset: 0x000ABD5A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Load()
			Me.ooo___o_0.__.()
		End Sub

		' Token: 0x06001B87 RID: 7047 RVA: 0x000ADB62 File Offset: 0x000ABD62
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Load(UserName As String)
			O_O0OO.OoO_o.oO0o0O.(UserName, Me.UserView.Table)
		End Sub

		' Token: 0x06001B88 RID: 7048 RVA: 0x000ADB78 File Offset: 0x000ABD78
		Public Function Contains(UserName As String) As Boolean
			Dim num As Integer = Me.UserView.Count - 1
			For i As Integer = 0 To num
				If Operators.CompareString(Me.UserView(i)("Name").ToString(), UserName, True) = 0 Then
					Return True
				End If
			Next
			Return False
		End Function

		' Token: 0x17000640 RID: 1600
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Index As Integer) As UserInfo
			Get
				Return Me.ooo___o_0.__.(Me.UserView(Index).Row)
			End Get
		End Property

		' Token: 0x17000641 RID: 1601
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(name As String) As UserInfo
			Get
				Dim num As Integer = Me.UserView.Count - 1
				For i As Integer = 0 To num
					If Operators.CompareString(Me.UserView(i)("Name").ToString(), name, True) = 0 Then
						Return Me.ooo___o_0.__.(Me.UserView(i).Row)
					End If
				Next
				MessageBox.Show("不存在名为""" + name + """的用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return Nothing
			End Get
		End Property

		' Token: 0x06001B8B RID: 7051 RVA: 0x000ADC6C File Offset: 0x000ABE6C
		Private Function <<EMPTY_NAME>>(A_0 As DataRow) As UserInfo
			Dim result As UserInfo
			If Me.ooo___o_0.__..ContainsKey(A_0) Then
				result = Me.ooo___o_0.__.(A_0)
			Else
				Dim userProperty As UserProperty = New UserProperty()
				o_O_o_oOoo__.OOOO_OO._oo.(userProperty, Conversions.ToString(A_0("Config")), vbVerticalTab)
				Dim userInfo As UserInfo = New UserInfo()
				userInfo.Name = Conversions.ToString(A_0("Name"))
				userInfo.Group = userProperty.Group
				userInfo.Roles = userProperty.Role
				userInfo.Password = userProperty.PassWord
				userInfo.Tag = userProperty.Tag
				If userProperty.Type <> 3 Then
					userInfo.Type = userProperty.Type
				Else
					userInfo.Type = Conversions.ToInteger(A_0("Type"))
				End If
				Me.ooo___o_0.__..Add(A_0, userInfo)
				result = userInfo
			End If
			Return result
		End Function

		' Token: 0x04000BB1 RID: 2993
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x04000BB2 RID: 2994
		Friend <<EMPTY_NAME>> As Dictionary(Of DataRow, UserInfo)

		' Token: 0x04000BB3 RID: 2995
		Private a As String
	End Class
End Namespace
