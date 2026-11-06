Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace Foxtable.RibbonMenu
	' Token: 0x0200002A RID: 42
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ContextCommandEnumerator
		Implements IEnumerator

		' Token: 0x0600014F RID: 335 RVA: 0x00003CB2 File Offset: 0x00001EB2
		Public Sub New(A_0 As ContextCommandCollection)
			Me.o_o_0oO_.o_o. = -1
			Me.o_o_0oO_.o_o. = A_0
		End Sub

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x06000150 RID: 336 RVA: 0x00003CC8 File Offset: 0x00001EC8
		Public ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.o_o_0oO_.o_o.(Me.o_o_0oO_.o_o.)
			End Get
		End Property

		' Token: 0x06000151 RID: 337 RVA: 0x00003CDC File Offset: 0x00001EDC
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.o_o_0oO_.o_o. += 1
			Return Me.o_o_0oO_.o_o. < Me.o_o_0oO_.o_o..Count
		End Function

		' Token: 0x06000152 RID: 338 RVA: 0x00003D11 File Offset: 0x00001F11
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.o_o_0oO_.o_o. = -1
		End Sub

		' Token: 0x04000045 RID: 69
		Private <<EMPTY_NAME>> As ContextCommandCollection

		' Token: 0x04000046 RID: 70
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
