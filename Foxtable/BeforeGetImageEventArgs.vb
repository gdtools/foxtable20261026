Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002A4 RID: 676
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BeforeGetImageEventArgs
		' Token: 0x060023DA RID: 9178 RVA: 0x000F9B0D File Offset: 0x000F7D0D
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As String)
			If TypeOf A_0 Is System.Windows.Forms.PictureBox AndAlso TypeOf A_0.Parent Is CustomPictureBox Then
				A_0 = A_0.Parent
			End If
			Me.o0OOo.000Oo0. = A_0
			Me.o0OOo.000Oo0. = A_2
			Me.o0OOo.000Oo0. = A_1
		End Sub

		' Token: 0x17000832 RID: 2098
		' (get) Token: 0x060023DB RID: 9179 RVA: 0x000F9B47 File Offset: 0x000F7D47
		Public ReadOnly Property Sender As Object
			Get
				If Me.o0.OO0OOOO000_. Is Nothing Then
					Me.o0.OO0OOOO000_. = ooO_0O.o_O0.O_.(Me.o0OOo.000Oo0.)
					Me.o0.OO0OOOO000_..o.__O0O. = Me.Form
				End If
				Return Me.o0.OO0OOOO000_.
			End Get
		End Property

		' Token: 0x17000833 RID: 2099
		' (get) Token: 0x060023DC RID: 9180 RVA: 0x000F9B79 File Offset: 0x000F7D79
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.o0OOo.000Oo0.
			End Get
		End Property

		' Token: 0x17000834 RID: 2100
		' (get) Token: 0x060023DD RID: 9181 RVA: 0x000F9B81 File Offset: 0x000F7D81
		' (set) Token: 0x060023DE RID: 9182 RVA: 0x000F9B89 File Offset: 0x000F7D89
		Public Property File As String
			Get
				Return Me.o0OOo.000Oo0.
			End Get
			Set(value As String)
				Me.o0OOo.000Oo0. = value
			End Set
		End Property

		' Token: 0x04000ED3 RID: 3795
		Private <<EMPTY_NAME>> As System.Windows.Forms.Control

		' Token: 0x04000ED4 RID: 3796
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000ED5 RID: 3797
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x04000ED6 RID: 3798
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Control
	End Class
End Namespace
