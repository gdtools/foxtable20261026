Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x020000A8 RID: 168
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oooOo_0oo
		Inherits Dictionary(Of String, Object)

		' Token: 0x060006D1 RID: 1745 RVA: 0x00026CEE File Offset: 0x00024EEE
		Public Sub New()
			Me.oO_0o_.oOO0. = New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)
			Me.o0O___o_o_0o.o. = New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)
		End Sub

		' Token: 0x060006D2 RID: 1746 RVA: 0x00026D16 File Offset: 0x00024F16
		Public Sub Clear()
			MyBase.Clear()
			Me.oO_0o_.oOO0..Clear()
			Me.o0O___o_o_0o.o..Clear()
		End Sub

		' Token: 0x060006D3 RID: 1747 RVA: 0x00026D34 File Offset: 0x00024F34
		Public Sub Remove(key As String)
			MyBase.Remove(key)
			Me.oO_0o_.oOO0..Remove(key)
			Me.o0O___o_o_0o.o..Remove(key)
		End Sub

		' Token: 0x060006D4 RID: 1748 RVA: 0x00026D58 File Offset: 0x00024F58
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Return Me.oO_0o_.oOO0..ContainsKey(A_0)
		End Function

		' Token: 0x060006D5 RID: 1749 RVA: 0x00026D66 File Offset: 0x00024F66
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Return Me.o0O___o_o_0o.o..ContainsKey(A_0)
		End Function

		' Token: 0x060006D6 RID: 1750 RVA: 0x00026D74 File Offset: 0x00024F74
		Public Sub Add(Key As String, value As Object, Output As Boolean, Optional Size As Integer = 32)
			If value Is Nothing Then
				value = DBNull.Value
			End If
			MyBase.Add(Key, RuntimeHelpers.GetObjectValue(value))
			If Output Then
				Me.oO_0o_.oOO0..Add(Key, Size)
				Return
			End If
			Me.o0O___o_o_0o.o..Add(Key, Size)
		End Sub

		' Token: 0x060006D7 RID: 1751 RVA: 0x00026DAD File Offset: 0x00024FAD
		Public Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Object)
			MyBase.Add(A_0, RuntimeHelpers.GetObjectValue(A_1))
		End Sub

		' Token: 0x040001DC RID: 476
		Friend <<EMPTY_NAME>> As Dictionary(Of String, Integer)

		' Token: 0x040001DD RID: 477
		Friend <<EMPTY_NAME>> As Dictionary(Of String, Integer)
	End Class
End Namespace
