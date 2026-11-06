Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200019E RID: 414
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ListViewEditEventArgs
		Inherits ListViewRowEventArgs

		' Token: 0x060013A2 RID: 5026 RVA: 0x0007F128 File Offset: 0x0007D328
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ListViewRow, A_3 As String)
			MyBase.New(A_0, A_1, A_2, A_2.Index)
			Me.oo.oO_. = A_3
		End Sub

		' Token: 0x17000401 RID: 1025
		' (get) Token: 0x060013A3 RID: 5027 RVA: 0x0007F141 File Offset: 0x0007D341
		Public ReadOnly Property NewText As String
			Get
				Return Me.oo.oO_.
			End Get
		End Property

		' Token: 0x040007BC RID: 1980
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
