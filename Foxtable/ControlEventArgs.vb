Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020000E4 RID: 228
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ControlEventArgs
		' Token: 0x06000CB8 RID: 3256 RVA: 0x0005C97C File Offset: 0x0005AB7C
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form)
			If TypeOf A_0 Is System.Windows.Forms.PictureBox AndAlso TypeOf A_0.Parent Is CustomPictureBox Then
				A_0 = A_0.Parent
			End If
			Me.oo_.o_O. = A_0
			Me.O.OOO0000_0. = A_1
		End Sub

		' Token: 0x17000214 RID: 532
		' (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0005C9AF File Offset: 0x0005ABAF
		Public ReadOnly Property Sender As Object
			Get
				If Me.O.OOO0000_0. Is Nothing Then
					Me.O.OOO0000_0. = ooO_0O.o_O0.O_.(Me.oo_.o_O.)
					If Me.O.OOO0000_0. IsNot Nothing Then
						Me.O.OOO0000_0..o.__O0O. = Me.Form
					End If
				End If
				Return Me.O.OOO0000_0.
			End Get
		End Property

		' Token: 0x17000215 RID: 533
		' (get) Token: 0x06000CBA RID: 3258 RVA: 0x0005C9E9 File Offset: 0x0005ABE9
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.O.OOO0000_0.
			End Get
		End Property

		' Token: 0x17000216 RID: 534
		' (get) Token: 0x06000CBB RID: 3259 RVA: 0x0005C9F1 File Offset: 0x0005ABF1
		' (set) Token: 0x06000CBC RID: 3260 RVA: 0x0005C9F9 File Offset: 0x0005ABF9
		Public Overridable Property Cancel As Boolean
			Get
				Return Me.O.OOO0000_0.
			End Get
			Set(value As Boolean)
				Me.O.OOO0000_0. = value
			End Set
		End Property

		' Token: 0x040004E1 RID: 1249
		Private <<EMPTY_NAME>> As System.Windows.Forms.Control

		' Token: 0x040004E2 RID: 1250
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040004E3 RID: 1251
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x040004E4 RID: 1252
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Control
	End Class
End Namespace
