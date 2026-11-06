Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace Foxtable.RibbonMenu
	' Token: 0x02000030 RID: 48
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonGroupEnumerator
		Implements IEnumerator

		' Token: 0x06000180 RID: 384 RVA: 0x000046D9 File Offset: 0x000028D9
		Public Sub New(A_0 As RibbonGroupCollection)
			Me.oOo_.0o_O_O_0. = -1
			Me.oOo_.0o_O_O_0. = A_0
		End Sub

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x06000181 RID: 385 RVA: 0x000046EF File Offset: 0x000028EF
		Public ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.oOo_.0o_O_O_0.(Me.oOo_.0o_O_O_0.)
			End Get
		End Property

		' Token: 0x06000182 RID: 386 RVA: 0x00004704 File Offset: 0x00002904
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.oOo_.0o_O_O_0. += 1
			Return Me.oOo_.0o_O_O_0. < Me.oOo_.0o_O_O_0..Count
		End Function

		' Token: 0x06000183 RID: 387 RVA: 0x00004739 File Offset: 0x00002939
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.oOo_.0o_O_O_0. = -1
		End Sub

		' Token: 0x0400004F RID: 79
		Private <<EMPTY_NAME>> As RibbonGroupCollection

		' Token: 0x04000050 RID: 80
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
