Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace Foxtable.RibbonMenu
	' Token: 0x02000032 RID: 50
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTabEnumerator
		Implements IEnumerator

		' Token: 0x06000191 RID: 401 RVA: 0x000048AB File Offset: 0x00002AAB
		Public Sub New(A_0 As RibbonTabCollection)
			Me.O_00Oo_.0. = -1
			Me.O_00Oo_.0. = A_0
		End Sub

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x06000192 RID: 402 RVA: 0x000048C1 File Offset: 0x00002AC1
		Public ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.O_00Oo_.0.(Me.O_00Oo_.0.)
			End Get
		End Property

		' Token: 0x06000193 RID: 403 RVA: 0x000048D4 File Offset: 0x00002AD4
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.O_00Oo_.0. += 1
			Return Me.O_00Oo_.0. < Me.O_00Oo_.0..Count
		End Function

		' Token: 0x06000194 RID: 404 RVA: 0x00004909 File Offset: 0x00002B09
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.O_00Oo_.0. = -1
		End Sub

		' Token: 0x04000052 RID: 82
		Private <<EMPTY_NAME>> As RibbonTabCollection

		' Token: 0x04000053 RID: 83
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
