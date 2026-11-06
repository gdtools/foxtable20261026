Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003A4 RID: 932
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	<oO0oooo("0706")>
	Public Class ControlCollection
		Implements IEnumerable(Of Foxtable.WinForm.Control)

		' Token: 0x06003B2B RID: 15147 RVA: 0x00198DD5 File Offset: 0x00196FD5
		Public Sub New(A_0 As Foxtable.WinForm.Form, A_1 As System.Windows.Forms.Control.ControlCollection)
			Me.O.OOO0000_0. = A_0
			Me.O.OOO0000_0. = A_1
		End Sub

		' Token: 0x17000CD4 RID: 3284
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Dim control As Foxtable.WinForm.Control = Nothing
				If Me.O.OOO0000_0..Pane IsNot Nothing AndAlso Not Me.O.OOO0000_0..Pane.IsDisposed Then
					control = Me.O.OOO0000_0..o_._o000O.(Me.O.OOO0000_0., Name)
					If control Is Nothing Then
						MessageBox.Show("找不到名称为""" + Name + """的控件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				Else
					MessageBox.Show(Me.O.OOO0000_0..Name + "已经关闭，不能调用其中的控件""" + Name + """ ！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
				If control IsNot Nothing Then
					control.o.__O0O. = Me.O.OOO0000_0.
				End If
				Return control
			End Get
		End Property

		' Token: 0x06003B2D RID: 15149 RVA: 0x00198E89 File Offset: 0x00197089
		Public Function Contains(Name As String) As Boolean
			Return Me.O.OOO0000_0..o_._o000O.(Me.O.OOO0000_0., Name) IsNot Nothing
		End Function

		' Token: 0x06003B2E RID: 15150 RVA: 0x00198EA0 File Offset: 0x001970A0
		Public Function GetEnumerator() As IEnumerator(Of Foxtable.WinForm.Control) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.Control).GetEnumerator
			Return New oo0(Me.O.OOO0000_0., Me.O.OOO0000_0.)
		End Function

		' Token: 0x06003B2F RID: 15151 RVA: 0x00198EB3 File Offset: 0x001970B3
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New oo0(Me.O.OOO0000_0., Me.O.OOO0000_0.)
		End Function

		' Token: 0x0400185C RID: 6236
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x0400185D RID: 6237
		Private <<EMPTY_NAME>> As System.Windows.Forms.Control.ControlCollection
	End Class
End Namespace
