Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200019F RID: 415
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ListViewRowEventArgs
		Inherits ControlEventArgs

		' Token: 0x060013A4 RID: 5028 RVA: 0x0007F149 File Offset: 0x0007D349
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ListViewRow, A_3 As Integer)
			MyBase.New(A_0, A_1)
			Me.O._OOOO0_. = A_2
			Me.O._OOOO0_. = A_3
		End Sub

		' Token: 0x17000402 RID: 1026
		' (get) Token: 0x060013A5 RID: 5029 RVA: 0x0007F162 File Offset: 0x0007D362
		Public ReadOnly Property Row As ListViewRow
			Get
				Return Me.O._OOOO0_.
			End Get
		End Property

		' Token: 0x17000403 RID: 1027
		' (get) Token: 0x060013A6 RID: 5030 RVA: 0x0007F16A File Offset: 0x0007D36A
		Public ReadOnly Property Index As Integer
			Get
				Return Me.O._OOOO0_.
			End Get
		End Property

		' Token: 0x040007BD RID: 1981
		Private <<EMPTY_NAME>> As ListViewRow

		' Token: 0x040007BE RID: 1982
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040007BF RID: 1983
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
