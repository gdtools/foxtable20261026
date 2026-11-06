Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003C0 RID: 960
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O_oO__o0
		Implements IEnumerator(Of Foxtable.WinForm.TreeNode)

		' Token: 0x06003D61 RID: 15713 RVA: 0x001AB8D4 File Offset: 0x001A9AD4
		Public Sub New(A_0 As TreeNodeCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.Nodes = A_0
		End Sub

		' Token: 0x06003D62 RID: 15714 RVA: 0x001AB8F1 File Offset: 0x001A9AF1
		Public Function get_Current() As Foxtable.WinForm.TreeNode Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.TreeNode).get_Current
			Return New Foxtable.WinForm.TreeNode(CType(Me.Nodes(Me.Index), O_o__00Ooo))
		End Function

		' Token: 0x06003D63 RID: 15715 RVA: 0x001AB90E File Offset: 0x001A9B0E
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New Foxtable.WinForm.TreeNode(CType(Me.Nodes(Me.Index), O_o__00Ooo))
		End Function

		' Token: 0x06003D64 RID: 15716 RVA: 0x001AB92C File Offset: 0x001A9B2C
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.Nodes.Count
		End Function

		' Token: 0x06003D65 RID: 15717 RVA: 0x001AB961 File Offset: 0x001A9B61
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x06003D66 RID: 15718 RVA: 0x001AB96A File Offset: 0x001A9B6A
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06003D67 RID: 15719 RVA: 0x001AB97D File Offset: 0x001A9B7D
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04001913 RID: 6419
		Private Nodes As TreeNodeCollection

		' Token: 0x04001914 RID: 6420
		Private Index As Integer

		' Token: 0x04001915 RID: 6421
		Private disposedValue As Boolean
	End Class
End Namespace
