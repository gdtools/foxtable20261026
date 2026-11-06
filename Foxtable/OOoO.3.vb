Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004BF RID: 1215
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OOoO
		Implements Oo0__O__O_0__

		' Token: 0x06004E7C RID: 20092 RVA: 0x0020878B File Offset: 0x0020698B
		Public Sub New()
			Me.O__O_._. = New List(Of DataCol)()
			Me.O__O_._. = New List(Of Boolean)()
		End Sub

		' Token: 0x06004E7D RID: 20093 RVA: 0x002087A9 File Offset: 0x002069A9
		Friend Sub <<EMPTY_NAME>>(A_0 As DataCol)
			Me.O__O_._..Add(A_0)
			Me.O__O_._..Add(A_0.AllowEdit)
		End Sub

		' Token: 0x06004E7E RID: 20094 RVA: 0x002087C8 File Offset: 0x002069C8
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.O__O_._.()
		End Sub

		' Token: 0x06004E7F RID: 20095 RVA: 0x002087D0 File Offset: 0x002069D0
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim num As Integer = Me.O__O_._..Count - 1
			For i As Integer = 0 To num
				Dim allowEdit As Boolean = Me.O__O_._.(i).AllowEdit
				Me.O__O_._.(i).AllowEdit = Me.O__O_._.(i)
				Me.O__O_._.(i) = allowEdit
			Next
		End Sub

		' Token: 0x06004E80 RID: 20096 RVA: 0x00208833 File Offset: 0x00206A33
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O__O_._..Count
		End Function

		' Token: 0x04002075 RID: 8309
		Private <<EMPTY_NAME>> As List(Of DataCol)

		' Token: 0x04002076 RID: 8310
		Private <<EMPTY_NAME>> As List(Of Boolean)
	End Class
End Namespace
