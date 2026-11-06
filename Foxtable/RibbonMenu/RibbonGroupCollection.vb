Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000031 RID: 49
	<oO0oooo("2483")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class RibbonGroupCollection
		Implements IEnumerable

		' Token: 0x06000184 RID: 388 RVA: 0x00004742 File Offset: 0x00002942
		Public Sub New(A_0 As RibbonGroupCollection)
			Me.oOo_.0o_O_O_0. = A_0
		End Sub

		' Token: 0x06000185 RID: 389 RVA: 0x00004751 File Offset: 0x00002951
		Public Sub Add(Group As Group)
			Me.oOo_.0o_O_O_0..Add(Group.OO0oOo.O_o0.)
		End Sub

		' Token: 0x06000186 RID: 390 RVA: 0x00004765 File Offset: 0x00002965
		Public Sub Insert(Index As Integer, Group As Group)
			Me.oOo_.0o_O_O_0..Insert(Index, Group.OO0oOo.O_o0.)
		End Sub

		' Token: 0x06000187 RID: 391 RVA: 0x00004779 File Offset: 0x00002979
		Public Sub Remove(Group As Group)
			Me.oOo_.0o_O_O_0..Remove(Group.OO0oOo.O_o0.)
		End Sub

		' Token: 0x06000188 RID: 392 RVA: 0x0000478C File Offset: 0x0000298C
		Public Sub RemoveAt(Index As Integer)
			Me.oOo_.0o_O_O_0..RemoveAt(Index)
		End Sub

		' Token: 0x170000AE RID: 174
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Group
			Get
				Dim result As Group
				If TypeOf A_0 Is String Then
					result = Me(Conversions.ToString(A_0))
				Else
					result = Me(Conversions.ToInteger(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000AF RID: 175
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Integer) As Group
			Get
				Dim result As Group
				If A_0 < 0 Or A_0 > Me.oOo_.0o_O_O_0..Count - 1 Then
					result = Nothing
				Else
					result = New Group(Me.oOo_.0o_O_O_0.(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000B0 RID: 176
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As String) As Group
			Get
				Dim result As Group
				If Me.oOo_.0o_O_O_0..Contains(A_0) Then
					result = Me(Me.oOo_.0o_O_O_0..IndexOf(Me.oOo_.0o_O_O_0.(A_0)))
				Else
					MessageBox.Show("菜单中不存在名为""" + A_0 + """的功能组！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x0600018C RID: 396 RVA: 0x00004868 File Offset: 0x00002A68
		Public Sub Clear()
			Me.oOo_.0o_O_O_0..Clear()
		End Sub

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x0600018D RID: 397 RVA: 0x00004875 File Offset: 0x00002A75
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oOo_.0o_O_O_0..Count
			End Get
		End Property

		' Token: 0x0600018E RID: 398 RVA: 0x00004882 File Offset: 0x00002A82
		Public Function Contains(Name As String) As Boolean
			Return Me.oOo_.0o_O_O_0..Contains(Name)
		End Function

		' Token: 0x0600018F RID: 399 RVA: 0x00004890 File Offset: 0x00002A90
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Contains(g As Group) As Boolean
			Return Me.oOo_.0o_O_O_0..Contains(g.OO0oOo.O_o0.)
		End Function

		' Token: 0x06000190 RID: 400 RVA: 0x000048A3 File Offset: 0x00002AA3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New RibbonGroupEnumerator(Me)
		End Function

		' Token: 0x04000051 RID: 81
		Private <<EMPTY_NAME>> As RibbonGroupCollection
	End Class
End Namespace
