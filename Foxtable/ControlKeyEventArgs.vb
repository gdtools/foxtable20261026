Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003DB RID: 987
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ControlKeyEventArgs
		Inherits KeyEventArgs

		' Token: 0x06003EE2 RID: 16098 RVA: 0x001B291D File Offset: 0x001B0B1D
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As Keys)
			MyBase.New(A_2)
			If TypeOf A_0 Is System.Windows.Forms.PictureBox AndAlso TypeOf A_0.Parent Is CustomPictureBox Then
				A_0 = A_0.Parent
			End If
			Me.O_.0oo_O. = A_0
			Me.O_.0oo_O. = A_1
		End Sub

		' Token: 0x17000DA6 RID: 3494
		' (get) Token: 0x06003EE3 RID: 16099 RVA: 0x001B2951 File Offset: 0x001B0B51
		Public ReadOnly Property Sender As Object
			Get
				If Me.O_.0oo_O. Is Nothing Then
					Me.O_.0oo_O. = ooO_0O.o_O0.O_.(Me.O_.0oo_O.)
					Me.O_.0oo_O..o.__O0O. = Me.Form
				End If
				Return Me.O_.0oo_O.
			End Get
		End Property

		' Token: 0x17000DA7 RID: 3495
		' (get) Token: 0x06003EE4 RID: 16100 RVA: 0x001B2983 File Offset: 0x001B0B83
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.O_.0oo_O.
			End Get
		End Property

		' Token: 0x17000DA8 RID: 3496
		' (get) Token: 0x06003EE5 RID: 16101 RVA: 0x001B298B File Offset: 0x001B0B8B
		Public ReadOnly Property KeyCode As Keys
			Get
				Return MyBase.KeyCode
			End Get
		End Property

		' Token: 0x17000DA9 RID: 3497
		' (get) Token: 0x06003EE6 RID: 16102 RVA: 0x001B2993 File Offset: 0x001B0B93
		Public ReadOnly Property Alt As Boolean
			Get
				Return MyBase.Alt
			End Get
		End Property

		' Token: 0x17000DAA RID: 3498
		' (get) Token: 0x06003EE7 RID: 16103 RVA: 0x001B299B File Offset: 0x001B0B9B
		Public ReadOnly Property Control As Boolean
			Get
				Return MyBase.Control
			End Get
		End Property

		' Token: 0x17000DAB RID: 3499
		' (get) Token: 0x06003EE8 RID: 16104 RVA: 0x001B29A3 File Offset: 0x001B0BA3
		Public ReadOnly Property Shift As Boolean
			Get
				Return MyBase.Shift
			End Get
		End Property

		' Token: 0x17000DAC RID: 3500
		' (get) Token: 0x06003EE9 RID: 16105 RVA: 0x001B29AB File Offset: 0x001B0BAB
		' (set) Token: 0x06003EEA RID: 16106 RVA: 0x001B29B3 File Offset: 0x001B0BB3
		Public Property Cancel As Boolean
			Get
				Return MyBase.Handled
			End Get
			Set(value As Boolean)
				MyBase.Handled = value
				MyBase.SuppressKeyPress = value
			End Set
		End Property

		' Token: 0x04001982 RID: 6530
		Private <<EMPTY_NAME>> As System.Windows.Forms.Control

		' Token: 0x04001983 RID: 6531
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x04001984 RID: 6532
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Control
	End Class
End Namespace
