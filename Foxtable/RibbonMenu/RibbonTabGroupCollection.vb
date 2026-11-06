Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000035 RID: 53
	<ComVisible(True)>
	<oO0oooo("3088")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTabGroupCollection
		Implements IEnumerable

		' Token: 0x060001BC RID: 444 RVA: 0x00004D0B File Offset: 0x00002F0B
		Public Sub New(A_0 As RibbonTabGroupCollection)
			Me.OO0.0OOo__. = A_0
		End Sub

		' Token: 0x060001BD RID: 445 RVA: 0x00004D1A File Offset: 0x00002F1A
		Public Sub Add(tabGroup As TabGroup)
			Me.OO0.0OOo__..Add(tabGroup.RibbonTabGroup)
		End Sub

		' Token: 0x060001BE RID: 446 RVA: 0x00004D2E File Offset: 0x00002F2E
		Public Sub Insert(Index As Integer, tabGroup As TabGroup)
			Me.OO0.0OOo__..Insert(Index, tabGroup.RibbonTabGroup)
		End Sub

		' Token: 0x060001BF RID: 447 RVA: 0x00004D42 File Offset: 0x00002F42
		Public Sub Remove(tabGroup As TabGroup)
			If Me.OO0.0OOo__..Contains(tabGroup.RibbonTabGroup) Then
				Me.OO0.0OOo__..Remove(tabGroup.RibbonTabGroup)
			End If
		End Sub

		' Token: 0x060001C0 RID: 448 RVA: 0x00004D68 File Offset: 0x00002F68
		Public Sub Remove(tgpName As String)
			If Me.OO0.0OOo__..Contains(tgpName) Then
				Me.OO0.0OOo__..Remove(Me.OO0.0OOo__.(tgpName))
			End If
		End Sub

		' Token: 0x060001C1 RID: 449 RVA: 0x00004D8F File Offset: 0x00002F8F
		Public Sub RemoveAt(Index As Integer)
			Me.OO0.0OOo__..RemoveAt(Index)
		End Sub

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x060001C2 RID: 450 RVA: 0x00004D9D File Offset: 0x00002F9D
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OO0.0OOo__..Count
			End Get
		End Property

		' Token: 0x060001C3 RID: 451 RVA: 0x00004DAA File Offset: 0x00002FAA
		Public Sub Clear()
			Me.OO0.0OOo__..Clear()
		End Sub

		' Token: 0x060001C4 RID: 452 RVA: 0x00004DB7 File Offset: 0x00002FB7
		Public Function Contains(Name As String) As Boolean
			Return Me.OO0.0OOo__..Contains(Name)
		End Function

		' Token: 0x060001C5 RID: 453 RVA: 0x00004DC5 File Offset: 0x00002FC5
		Public Function Contains(g As TabGroup) As Boolean
			Return Me.OO0.0OOo__..Contains(g.RibbonTabGroup)
		End Function

		' Token: 0x170000C5 RID: 197
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As TabGroup
			Get
				Dim result As TabGroup
				If TypeOf A_0 Is String Then
					result = Me(Conversions.ToString(A_0))
				Else
					result = Me(Conversions.ToInteger(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000C6 RID: 198
		Public ReadOnly Default Property Item(A_0 As Integer) As TabGroup
			Get
				Dim result As TabGroup
				If A_0 >= 0 AndAlso A_0 <= Me.OO0.0OOo__..Count - 1 Then
					result = New TabGroup(Me.OO0.0OOo__.(A_0))
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000C7 RID: 199
		Public ReadOnly Default Property Item(A_0 As String) As TabGroup
			Get
				Dim result As TabGroup
				If Me.OO0.0OOo__..Contains(A_0) Then
					result = New TabGroup(Me.OO0.0OOo__.(A_0))
				Else
					MessageBox.Show("菜单中不存在名为""" + A_0 + """的TabGroup！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x060001C9 RID: 457 RVA: 0x00004E94 File Offset: 0x00003094
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New RibbonTabGroupEnumerator(Me)
		End Function

		' Token: 0x04000057 RID: 87
		Private <<EMPTY_NAME>> As RibbonTabGroupCollection
	End Class
End Namespace
