Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x020004BE RID: 1214
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oo___ooo
		Implements Oo0__O__O_0__

		' Token: 0x06004E77 RID: 20087 RVA: 0x00208673 File Offset: 0x00206873
		Public Sub New()
			Me.o00.oo0__00. = New List(Of DataRow)()
			Me.o00.oo0__00. = New List(Of Object)()
		End Sub

		' Token: 0x06004E78 RID: 20088 RVA: 0x00208691 File Offset: 0x00206891
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			Me.o00.oo0__00..Add(A_0)
			Me.o00.oo0__00..Add(RuntimeHelpers.GetObjectValue(A_0("_Locked")))
		End Sub

		' Token: 0x06004E79 RID: 20089 RVA: 0x002086BA File Offset: 0x002068BA
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.o00.oo0__00.()
		End Sub

		' Token: 0x06004E7A RID: 20090 RVA: 0x002086C4 File Offset: 0x002068C4
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim num As Integer = Me.o00.oo0__00..Count - 1
			For i As Integer = 0 To num
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o00.oo0__00.(i)("_Locked"))
				Me.o00.oo0__00.(i)("_Locked") = RuntimeHelpers.GetObjectValue(Me.o00.oo0__00.(i))
				Me.o00.oo0__00.(i) = RuntimeHelpers.GetObjectValue(objectValue)
				If OO_00oOO.DataTables(Me.o00.oo0__00.(i).Table.TableName).frd_IsInnerTable Then
					Oo00.o0_o._O_.(Me.o00.oo0__00.(i))
				End If
			Next
		End Sub

		' Token: 0x06004E7B RID: 20091 RVA: 0x0020877E File Offset: 0x0020697E
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.o00.oo0__00..Count
		End Function

		' Token: 0x04002073 RID: 8307
		Private <<EMPTY_NAME>> As List(Of DataRow)

		' Token: 0x04002074 RID: 8308
		Private <<EMPTY_NAME>> As List(Of Object)
	End Class
End Namespace
