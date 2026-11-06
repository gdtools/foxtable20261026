Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace Foxtable.RibbonMenu
	' Token: 0x02000036 RID: 54
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTabGroupEnumerator
		Implements IEnumerator

		' Token: 0x060001CA RID: 458 RVA: 0x00004E9C File Offset: 0x0000309C
		Public Sub New(A_0 As RibbonTabGroupCollection)
			Me.OO0.0OOo__. = -1
			Me.OO0.0OOo__. = A_0
		End Sub

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x060001CB RID: 459 RVA: 0x00004EB2 File Offset: 0x000030B2
		Public ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.OO0.0OOo__.(Me.OO0.0OOo__.)
			End Get
		End Property

		' Token: 0x060001CC RID: 460 RVA: 0x00004EC8 File Offset: 0x000030C8
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.OO0.0OOo__. += 1
			Return Me.OO0.0OOo__. < Me.OO0.0OOo__..Count
		End Function

		' Token: 0x060001CD RID: 461 RVA: 0x00004EFD File Offset: 0x000030FD
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.OO0.0OOo__. = -1
		End Sub

		' Token: 0x04000058 RID: 88
		Private <<EMPTY_NAME>> As RibbonTabGroupCollection

		' Token: 0x04000059 RID: 89
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
