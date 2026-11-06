Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004E9 RID: 1257
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class b
		Implements IEnumerator(Of Sheet)

		' Token: 0x06005098 RID: 20632 RVA: 0x00218B95 File Offset: 0x00216D95
		Public Sub New(A_0 As XLSheetCollection)
			Me.Ooo_O__.0. = -1
			Me.Ooo_O__.0. = False
			Me.Ooo_O__.0. = A_0
		End Sub

		' Token: 0x06005099 RID: 20633 RVA: 0x00218BB2 File Offset: 0x00216DB2
		Public Function get_Current() As Sheet Implements System.Collections.Generic.IEnumerator(Of Foxtable.XLS.Sheet).get_Current
			Return New Sheet(Me.Ooo_O__.0.(Me.Ooo_O__.0.))
		End Function

		' Token: 0x0600509A RID: 20634 RVA: 0x00218BCA File Offset: 0x00216DCA
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New Sheet(Me.Ooo_O__.0.(Me.Ooo_O__.0.))
		End Function

		' Token: 0x0600509B RID: 20635 RVA: 0x00218BE4 File Offset: 0x00216DE4
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Ooo_O__.0. += 1
			Return Me.Ooo_O__.0. < Me.Ooo_O__.0..Count
		End Function

		' Token: 0x0600509C RID: 20636 RVA: 0x00218C19 File Offset: 0x00216E19
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Ooo_O__.0. = -1
		End Sub

		' Token: 0x0600509D RID: 20637 RVA: 0x00218C22 File Offset: 0x00216E22
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.Ooo_O__.0. Then
			End If
			Me.Ooo_O__.0. = True
		End Sub

		' Token: 0x0600509E RID: 20638 RVA: 0x00218C35 File Offset: 0x00216E35
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040021A4 RID: 8612
		Private <<EMPTY_NAME>> As XLSheetCollection

		' Token: 0x040021A5 RID: 8613
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040021A6 RID: 8614
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
