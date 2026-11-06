Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003B9 RID: 953
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o0_0oo00_o
		Implements IEnumerator(Of TabPage)

		' Token: 0x06003D11 RID: 15633 RVA: 0x001AAF80 File Offset: 0x001A9180
		Public Sub New(A_0 As C1DockingTabPages)
			Me.Index = -1
			Me.disposedValue = False
			Me.Pages = A_0
		End Sub

		' Token: 0x06003D12 RID: 15634 RVA: 0x001AAF9D File Offset: 0x001A919D
		Public Function get_Current() As TabPage Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.TabPage).get_Current
			Return CType(Me.Pages(Me.Index), TabPage)
		End Function

		' Token: 0x06003D13 RID: 15635 RVA: 0x001AAFB5 File Offset: 0x001A91B5
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return CType(Me.Pages(Me.Index), TabPage)
		End Function

		' Token: 0x06003D14 RID: 15636 RVA: 0x001AAFD0 File Offset: 0x001A91D0
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.Pages.Count
		End Function

		' Token: 0x06003D15 RID: 15637 RVA: 0x001AB005 File Offset: 0x001A9205
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x06003D16 RID: 15638 RVA: 0x001AB00E File Offset: 0x001A920E
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06003D17 RID: 15639 RVA: 0x001AB021 File Offset: 0x001A9221
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04001904 RID: 6404
		Private Pages As C1DockingTabPages

		' Token: 0x04001905 RID: 6405
		Private Index As Integer

		' Token: 0x04001906 RID: 6406
		Private disposedValue As Boolean
	End Class
End Namespace
