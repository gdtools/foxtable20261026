Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000301 RID: 769
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o0o_Oo_o
		Implements IEnumerator(Of Relation)

		' Token: 0x06002842 RID: 10306 RVA: 0x0010DC1F File Offset: 0x0010BE1F
		Public Sub New()
			Me.index = -1
			Me.disposedValue = False
		End Sub

		' Token: 0x06002843 RID: 10307 RVA: 0x0010DC35 File Offset: 0x0010BE35
		Public Function get_Current() As Relation Implements System.Collections.Generic.IEnumerator(Of Foxtable.Relation).get_Current
			Return New Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations(Me.index))
		End Function

		' Token: 0x06002844 RID: 10308 RVA: 0x0010DC51 File Offset: 0x0010BE51
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations(Me.index))
		End Function

		' Token: 0x06002845 RID: 10309 RVA: 0x0010DC6D File Offset: 0x0010BE6D
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.index += 1
			Return O_O0OO.OOOo.oo_OOOO_0.().Relations.Count > Me.index
		End Function

		' Token: 0x06002846 RID: 10310 RVA: 0x0010DC94 File Offset: 0x0010BE94
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.index = -1
		End Sub

		' Token: 0x06002847 RID: 10311 RVA: 0x0010DC9D File Offset: 0x0010BE9D
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06002848 RID: 10312 RVA: 0x0010DCB0 File Offset: 0x0010BEB0
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040010AB RID: 4267
		Private index As Integer

		' Token: 0x040010AC RID: 4268
		Private disposedValue As Boolean
	End Class
End Namespace
