Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace Foxtable.RibbonMenu
	' Token: 0x02000025 RID: 37
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ContextMenuEnumerator
		Implements IEnumerator

		' Token: 0x06000127 RID: 295 RVA: 0x00003952 File Offset: 0x00001B52
		Public Sub New(A_0 As ContextMenuCollection)
			Me.o_.o0_o. = -1
			Me.o_.o0_o. = A_0
		End Sub

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x06000128 RID: 296 RVA: 0x00003968 File Offset: 0x00001B68
		Public ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.o_.o0_o.(Me.o_.o0_o.)
			End Get
		End Property

		' Token: 0x06000129 RID: 297 RVA: 0x0000397C File Offset: 0x00001B7C
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.o_.o0_o. += 1
			Return Me.o_.o0_o. < Me.o_.o0_o..Count
		End Function

		' Token: 0x0600012A RID: 298 RVA: 0x000039B1 File Offset: 0x00001BB1
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.o_.o0_o. = -1
		End Sub

		' Token: 0x0400003C RID: 60
		Private <<EMPTY_NAME>> As ContextMenuCollection

		' Token: 0x0400003D RID: 61
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
