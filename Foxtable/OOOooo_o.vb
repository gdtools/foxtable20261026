Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000306 RID: 774
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class OOOooo_o
		Implements IEnumerator(Of Col)

		' Token: 0x060028B9 RID: 10425 RVA: 0x001116EE File Offset: 0x0010F8EE
		Friend Sub New(A_0 As Table)
			Me.Index = -1
			Me.disposedValue = False
			Me.Table = A_0
		End Sub

		' Token: 0x060028BA RID: 10426 RVA: 0x0011170C File Offset: 0x0010F90C
		Public Function get_Current() As Col Implements System.Collections.Generic.IEnumerator(Of Foxtable.Col).get_Current
			Return Me.Table.Cols(Me.Table.foxGrid.Cols(Me.Index + Me.Table.foxGrid.Cols.Fixed).Name)
		End Function

		' Token: 0x060028BB RID: 10427 RVA: 0x00111760 File Offset: 0x0010F960
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return Me.Table.Cols(Me.Table.foxGrid.Cols(Me.Index + Me.Table.foxGrid.Cols.Fixed).Name)
		End Function

		' Token: 0x060028BC RID: 10428 RVA: 0x001117B4 File Offset: 0x0010F9B4
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Dim o_oOooO_O As O_oOooO_O = Me.Table.foxGrid
			Dim flag As Boolean
			If Me.Index + o_oOooO_O.Cols.Fixed > o_oOooO_O.Cols.Count - 1 Then
				flag = False
			Else
				Dim name As String = Me.Table.foxGrid.Cols(Me.Index + Me.Table.foxGrid.Cols.Fixed).Name
				flag = (Not o_O_o_oOoo__.oO.O_..Contains(name) OrElse flag)
			End If
			Return flag
		End Function

		' Token: 0x060028BD RID: 10429 RVA: 0x0011184B File Offset: 0x0010FA4B
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x060028BE RID: 10430 RVA: 0x00111854 File Offset: 0x0010FA54
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x060028BF RID: 10431 RVA: 0x00111867 File Offset: 0x0010FA67
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040010C7 RID: 4295
		Private Table As Table

		' Token: 0x040010C8 RID: 4296
		Private Index As Integer

		' Token: 0x040010C9 RID: 4297
		Private disposedValue As Boolean
	End Class
End Namespace
