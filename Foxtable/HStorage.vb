Imports System
Imports Newtonsoft.Json

Namespace Foxtable
	' Token: 0x020000F3 RID: 243
	Public Class HStorage
		' Token: 0x06000D38 RID: 3384 RVA: 0x0005EEC2 File Offset: 0x0005D0C2
		Friend Sub New(A_0 As WebViewer, A_1 As String)
			Me.O0oO.o_OOoO_. = A_0
			Me.O0oO.o_OOoO_. = A_1
		End Sub

		' Token: 0x17000236 RID: 566
		' (get) Token: 0x06000D39 RID: 3385 RVA: 0x0005EED8 File Offset: 0x0005D0D8
		Public ReadOnly Property length As Object
			Get
				Dim text As String = String.Format("{0}.length", Me.O0oO.o_OOoO_.)
				Return Me.O0oO.o_OOoO_..ExecuteScriptAsync(text)
			End Get
		End Property

		' Token: 0x06000D3A RID: 3386 RVA: 0x0005EF04 File Offset: 0x0005D104
		Public Function key(n As Integer) As Object
			Dim text As String = String.Format("{0}.key({1})", Me.O0oO.o_OOoO_., n)
			Return Me.O0oO.o_OOoO_..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D3B RID: 3387 RVA: 0x0005EF34 File Offset: 0x0005D134
		Public Function getItem(key As String) As Object
			Dim text As String = String.Format("{0}.getItem({1})", Me.O0oO.o_OOoO_., JsonConvert.ToString(key))
			Return Me.O0oO.o_OOoO_..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D3C RID: 3388 RVA: 0x0005EF64 File Offset: 0x0005D164
		Public Function setItem(key As String, value As String) As Object
			Dim text As String = String.Format("{0}.setItem({1},{2})", Me.O0oO.o_OOoO_., JsonConvert.ToString(key), JsonConvert.ToString(value))
			Return Me.O0oO.o_OOoO_..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D3D RID: 3389 RVA: 0x0005EF9C File Offset: 0x0005D19C
		Public Function removeItem(key As String) As Object
			Dim text As String = String.Format("{0}.removeItem({1})", Me.O0oO.o_OOoO_., JsonConvert.ToString(key))
			Return Me.O0oO.o_OOoO_..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D3E RID: 3390 RVA: 0x0005EFCC File Offset: 0x0005D1CC
		Public Function clear() As Object
			Dim text As String = String.Format("{0}.clear()", Me.O0oO.o_OOoO_.)
			Return Me.O0oO.o_OOoO_..ExecuteScriptAsync(text)
		End Function

		' Token: 0x04000517 RID: 1303
		Friend <<EMPTY_NAME>> As WebViewer

		' Token: 0x04000518 RID: 1304
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
