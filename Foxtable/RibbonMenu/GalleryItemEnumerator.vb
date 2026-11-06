Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace Foxtable.RibbonMenu
	' Token: 0x0200002D RID: 45
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GalleryItemEnumerator
		Implements IEnumerator

		' Token: 0x06000160 RID: 352 RVA: 0x00003F76 File Offset: 0x00002176
		Public Sub New(A_0 As GalleryItemCollection)
			Me.OO0oOo.O_o0. = -1
			Me.OO0oOo.O_o0. = A_0
		End Sub

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x06000161 RID: 353 RVA: 0x00003F8C File Offset: 0x0000218C
		Public ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.OO0oOo.O_o0.(Me.OO0oOo.O_o0.)
			End Get
		End Property

		' Token: 0x06000162 RID: 354 RVA: 0x00003FA0 File Offset: 0x000021A0
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.OO0oOo.O_o0. += 1
			Return Me.OO0oOo.O_o0. < Me.OO0oOo.O_o0..Count
		End Function

		' Token: 0x06000163 RID: 355 RVA: 0x00003FD5 File Offset: 0x000021D5
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.OO0oOo.O_o0. = -1
		End Sub

		' Token: 0x0400004A RID: 74
		Private <<EMPTY_NAME>> As GalleryItemCollection

		' Token: 0x0400004B RID: 75
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
