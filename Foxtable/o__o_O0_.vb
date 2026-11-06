Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000251 RID: 593
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o__o_O0_
		Implements IEnumerator(Of UserInfo)

		' Token: 0x06001B67 RID: 7015 RVA: 0x000AD844 File Offset: 0x000ABA44
		Public Sub New(A_0 As DataView)
			Me.Index = -1
			Me.disposedValue = False
			Me.UserDataView = A_0
		End Sub

		' Token: 0x06001B68 RID: 7016 RVA: 0x000AD861 File Offset: 0x000ABA61
		Public Function get_Current() As UserInfo Implements System.Collections.Generic.IEnumerator(Of Foxtable.UserInfo).get_Current
			Return Me.GetUserInfo()
		End Function

		' Token: 0x06001B69 RID: 7017 RVA: 0x000AD869 File Offset: 0x000ABA69
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return Me.GetUserInfo()
		End Function

		' Token: 0x06001B6A RID: 7018 RVA: 0x000AD874 File Offset: 0x000ABA74
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.UserDataView.Count
		End Function

		' Token: 0x06001B6B RID: 7019 RVA: 0x000AD8A9 File Offset: 0x000ABAA9
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x06001B6C RID: 7020 RVA: 0x000AD8B2 File Offset: 0x000ABAB2
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06001B6D RID: 7021 RVA: 0x000AD8C8 File Offset: 0x000ABAC8
		Private Function GetUserInfo() As UserInfo
			Dim row As DataRow = Me.UserDataView(Me.Index).Row
			Dim userProperty As UserProperty = New UserProperty()
			o_O_o_oOoo__.OOOO_OO._oo.(userProperty, Conversions.ToString(row("Config")), vbVerticalTab)
			Dim userInfo As UserInfo = New UserInfo()
			userInfo.Name = Conversions.ToString(row("Name"))
			userInfo.Group = userProperty.Group
			userInfo.Roles = userProperty.Role
			userInfo.Password = userProperty.PassWord
			userInfo.Tag = userProperty.Tag
			If userProperty.Type <> 3 Then
				userInfo.Type = userProperty.Type
			Else
				userInfo.Type = Conversions.ToInteger(row("Type"))
			End If
			Return userInfo
		End Function

		' Token: 0x06001B6E RID: 7022 RVA: 0x000AD984 File Offset: 0x000ABB84
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04000BA6 RID: 2982
		Private Index As Integer

		' Token: 0x04000BA7 RID: 2983
		Private UserDataView As DataView

		' Token: 0x04000BA8 RID: 2984
		Private disposedValue As Boolean
	End Class
End Namespace
