Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020001A7 RID: 423
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OO0_o_oOo0
		Implements IEnumerator(Of Foxtable.WinForm.ListViewGroup)

		' Token: 0x060013F2 RID: 5106 RVA: 0x00080310 File Offset: 0x0007E510
		Public Sub New(A_0 As ListViewGroupCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.Groups = A_0
		End Sub

		' Token: 0x060013F3 RID: 5107 RVA: 0x0008032D File Offset: 0x0007E52D
		Public Function get_Current() As Foxtable.WinForm.ListViewGroup Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.ListViewGroup).get_Current
			Return New Foxtable.WinForm.ListViewGroup(Me.Groups(Me.Index))
		End Function

		' Token: 0x060013F4 RID: 5108 RVA: 0x00080345 File Offset: 0x0007E545
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New Foxtable.WinForm.ListViewGroup(Me.Groups(Me.Index))
		End Function

		' Token: 0x060013F5 RID: 5109 RVA: 0x00080360 File Offset: 0x0007E560
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index <= Me.Groups.Count - 1
		End Function

		' Token: 0x060013F6 RID: 5110 RVA: 0x00080397 File Offset: 0x0007E597
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x060013F7 RID: 5111 RVA: 0x000803A0 File Offset: 0x0007E5A0
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x060013F8 RID: 5112 RVA: 0x000803B3 File Offset: 0x0007E5B3
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040007CB RID: 1995
		Private Groups As ListViewGroupCollection

		' Token: 0x040007CC RID: 1996
		Private Index As Integer

		' Token: 0x040007CD RID: 1997
		Private disposedValue As Boolean
	End Class
End Namespace
