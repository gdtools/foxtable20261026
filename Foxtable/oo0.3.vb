Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003A5 RID: 933
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oo0
		Implements IEnumerator(Of Foxtable.WinForm.Control)

		' Token: 0x06003B30 RID: 15152 RVA: 0x00198EC6 File Offset: 0x001970C6
		Public Sub New(A_0 As Foxtable.WinForm.Form, A_1 As System.Windows.Forms.Control.ControlCollection)
			Me.lst = New List(Of Foxtable.WinForm.Control)()
			Me._Index = -1
			Me.disposedValue = False
			Me._frm = A_0
			Me._controls = A_1
			Me.CreateList(Me._controls)
		End Sub

		' Token: 0x06003B31 RID: 15153 RVA: 0x00198F04 File Offset: 0x00197104
		Private Sub CreateList(Controls As System.Windows.Forms.Control.ControlCollection)
			Try
				For Each obj As Object In Controls
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					Dim control2 As Foxtable.WinForm.Control = ooO_0O.o_O0.O_.(control)
					If control2 IsNot Nothing Then
						control2.o.__O0O. = Me._frm
						Me.lst.Add(control2)
					End If
					If control.Controls.Count > 0 Then
						Me.CreateList(control.Controls)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003B32 RID: 15154 RVA: 0x00198F90 File Offset: 0x00197190
		Public Function get_Current() As Foxtable.WinForm.Control Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.Control).get_Current
			Return Me.lst(Me._Index)
		End Function

		' Token: 0x06003B33 RID: 15155 RVA: 0x00198FA3 File Offset: 0x001971A3
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return Me.lst(Me._Index)
		End Function

		' Token: 0x06003B34 RID: 15156 RVA: 0x00198FB8 File Offset: 0x001971B8
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me._Index += 1
			Return Me._Index < Me.lst.Count
		End Function

		' Token: 0x06003B35 RID: 15157 RVA: 0x00198FED File Offset: 0x001971ED
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me._Index = -1
		End Sub

		' Token: 0x06003B36 RID: 15158 RVA: 0x00198FF6 File Offset: 0x001971F6
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06003B37 RID: 15159 RVA: 0x00199009 File Offset: 0x00197209
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x0400185E RID: 6238
		Private _frm As Foxtable.WinForm.Form

		' Token: 0x0400185F RID: 6239
		Private _controls As System.Windows.Forms.Control.ControlCollection

		' Token: 0x04001860 RID: 6240
		Private lst As List(Of Foxtable.WinForm.Control)

		' Token: 0x04001861 RID: 6241
		Private _Index As Integer

		' Token: 0x04001862 RID: 6242
		Private disposedValue As Boolean
	End Class
End Namespace
