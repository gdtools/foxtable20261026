Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200019B RID: 411
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DrawListViewCellEventArgs
		Inherits ControlEventArgs

		' Token: 0x06001388 RID: 5000 RVA: 0x0007EF80 File Offset: 0x0007D180
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ListViewRow, A_3 As Integer, A_4 As Integer, A_5 As DrawListViewSubItemEventArgs)
			MyBase.New(A_0, A_1)
		End Sub

		' Token: 0x06001389 RID: 5001 RVA: 0x0007EF8A File Offset: 0x0007D18A
		Public Sub DrawDefault()
			Me.ooo_OOO.O0O..DrawDefault = True
		End Sub

		' Token: 0x0600138A RID: 5002 RVA: 0x0007EF98 File Offset: 0x0007D198
		Public Sub DrawText()
			Me.ooo_OOO.O0O..DrawText()
		End Sub

		' Token: 0x0600138B RID: 5003 RVA: 0x0007EFA5 File Offset: 0x0007D1A5
		Public Sub DrawBackGroud()
			Me.ooo_OOO.O0O..DrawBackground()
		End Sub

		' Token: 0x040007B1 RID: 1969
		Private <<EMPTY_NAME>> As ListViewRow

		' Token: 0x040007B2 RID: 1970
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040007B3 RID: 1971
		Private <<EMPTY_NAME>> As DrawListViewSubItemEventArgs
	End Class
End Namespace
