Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace Foxtable.RibbonMenu
	' Token: 0x0200002C RID: 44
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonItemEnumerator
		Implements IEnumerator

		' Token: 0x0600015C RID: 348 RVA: 0x00003F0E File Offset: 0x0000210E
		Public Sub New(A_0 As RibbonItemCollection)
			Me.oOo_.0o_O_O_0. = -1
			Me.O_00Oo_.0. = A_0
		End Sub

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x0600015D RID: 349 RVA: 0x00003F24 File Offset: 0x00002124
		Public ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.O_00Oo_.0.(Me.oOo_.0o_O_O_0.)
			End Get
		End Property

		' Token: 0x0600015E RID: 350 RVA: 0x00003F38 File Offset: 0x00002138
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.oOo_.0o_O_O_0. += 1
			Return Me.oOo_.0o_O_O_0. < Me.O_00Oo_.0..Count
		End Function

		' Token: 0x0600015F RID: 351 RVA: 0x00003F6D File Offset: 0x0000216D
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.oOo_.0o_O_O_0. = -1
		End Sub

		' Token: 0x04000048 RID: 72
		Private <<EMPTY_NAME>> As RibbonItemCollection

		' Token: 0x04000049 RID: 73
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
