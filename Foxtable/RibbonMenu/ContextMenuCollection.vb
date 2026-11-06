Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000026 RID: 38
	<oO0oooo("1324")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ContextMenuCollection
		Implements IEnumerable

		' Token: 0x0600012B RID: 299 RVA: 0x000039BA File Offset: 0x00001BBA
		Public Sub New(A_0 As Dictionary(Of String, o__o_OO_o_))
			Me.o_.o0_o. = A_0
		End Sub

		' Token: 0x1700008B RID: 139
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As ContextMenu
			Get
				Dim result As ContextMenu
				If TypeOf A_0 Is String Then
					result = Me(Conversions.ToString(A_0))
				Else
					result = Me(Conversions.ToInteger(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700008C RID: 140
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Integer) As ContextMenu
			Get
				Dim list As List(Of String) = New List(Of String)()
				list.AddRange(Me.o_.o0_o..Keys)
				Return Me(list(A_0))
			End Get
		End Property

		' Token: 0x1700008D RID: 141
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As String) As ContextMenu
			Get
				Dim result As ContextMenu
				If Me.o_.o0_o..ContainsKey(A_0) Then
					result = New ContextMenu(Me.o_.o0_o.(A_0))
				Else
					MessageBox.Show("不存在名为""" + A_0 + """的快捷菜单！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x0600012F RID: 303 RVA: 0x00003A84 File Offset: 0x00001C84
		Public ReadOnly Property Count As Integer
			Get
				Return Me.o_.o0_o..Count
			End Get
		End Property

		' Token: 0x06000130 RID: 304 RVA: 0x00003A91 File Offset: 0x00001C91
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New ContextMenuEnumerator(Me)
		End Function

		' Token: 0x0400003E RID: 62
		Private <<EMPTY_NAME>> As Dictionary(Of String, o__o_OO_o_)
	End Class
End Namespace
