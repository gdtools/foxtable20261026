Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002F4 RID: 756
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class KeyEventArgs
		Inherits KeyEventArgs

		' Token: 0x060027B8 RID: 10168 RVA: 0x0010B7F9 File Offset: 0x001099F9
		Public Sub New(A_0 As Table, A_1 As Keys)
			MyBase.New(A_1)
			Me.Oo0O0OO_0_.00. = A_0
		End Sub

		' Token: 0x1700091C RID: 2332
		' (get) Token: 0x060027B9 RID: 10169 RVA: 0x0010B809 File Offset: 0x00109A09
		Public ReadOnly Property Table As Table
			Get
				Return Me.Oo0O0OO_0_.00.
			End Get
		End Property

		' Token: 0x1700091D RID: 2333
		' (get) Token: 0x060027BA RID: 10170 RVA: 0x0010B811 File Offset: 0x00109A11
		' (set) Token: 0x060027BB RID: 10171 RVA: 0x0010B819 File Offset: 0x00109A19
		Public Property Cancel As Boolean
			Get
				Return MyBase.Handled
			End Get
			Set(value As Boolean)
				MyBase.Handled = value
				MyBase.SuppressKeyPress = value
			End Set
		End Property

		' Token: 0x1700091E RID: 2334
		' (get) Token: 0x060027BC RID: 10172 RVA: 0x0010B829 File Offset: 0x00109A29
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001078 RID: 4216
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
