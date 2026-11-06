Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003B6 RID: 950
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OOO0O0
		Implements IEnumerator(Of NavPage)

		' Token: 0x06003CF4 RID: 15604 RVA: 0x001AAB48 File Offset: 0x001A8D48
		Public Sub New(A_0 As C1NavBarPanel.PanelCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.panels = A_0
		End Sub

		' Token: 0x06003CF5 RID: 15605 RVA: 0x001AAB65 File Offset: 0x001A8D65
		Public Function get_Current() As NavPage Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.NavPage).get_Current
			Return CType(Me.panels(Me.Index), NavPage)
		End Function

		' Token: 0x06003CF6 RID: 15606 RVA: 0x001AAB7D File Offset: 0x001A8D7D
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return CType(Me.panels(Me.Index), NavPage)
		End Function

		' Token: 0x06003CF7 RID: 15607 RVA: 0x001AAB98 File Offset: 0x001A8D98
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.panels.Count
		End Function

		' Token: 0x06003CF8 RID: 15608 RVA: 0x001AABCD File Offset: 0x001A8DCD
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x06003CF9 RID: 15609 RVA: 0x001AABD6 File Offset: 0x001A8DD6
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06003CFA RID: 15610 RVA: 0x001AABE9 File Offset: 0x001A8DE9
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040018FF RID: 6399
		Private panels As C1NavBarPanel.PanelCollection

		' Token: 0x04001900 RID: 6400
		Private Index As Integer

		' Token: 0x04001901 RID: 6401
		Private disposedValue As Boolean
	End Class
End Namespace
