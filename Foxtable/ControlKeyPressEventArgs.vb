Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003DC RID: 988
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ControlKeyPressEventArgs
		Inherits ControlEventArgs

		' Token: 0x06003EEB RID: 16107 RVA: 0x001B29C3 File Offset: 0x001B0BC3
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.OO00_O0_._OO0. = A_2
		End Sub

		' Token: 0x17000DAD RID: 3501
		' (get) Token: 0x06003EEC RID: 16108 RVA: 0x001B29D4 File Offset: 0x001B0BD4
		' (set) Token: 0x06003EED RID: 16109 RVA: 0x001B29DC File Offset: 0x001B0BDC
		Public Property KeyChar As String
			Get
				Return Me.OO00_O0_._OO0.
			End Get
			Set(value As String)
				Me.OO00_O0_._OO0. = value
			End Set
		End Property

		' Token: 0x04001985 RID: 6533
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
