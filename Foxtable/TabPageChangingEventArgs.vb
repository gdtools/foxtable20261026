Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002A6 RID: 678
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TabPageChangingEventArgs
		Inherits ControlEventArgs

		' Token: 0x060023E2 RID: 9186 RVA: 0x000F9BB8 File Offset: 0x000F7DB8
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As SelectedIndexChangingEventArgs)
			MyBase.New(A_0, A_1)
			Me.Oo_._O0oOOOo. = A_2
		End Sub

		' Token: 0x17000837 RID: 2103
		' (get) Token: 0x060023E3 RID: 9187 RVA: 0x000F9BC9 File Offset: 0x000F7DC9
		Public ReadOnly Property NewIndex As Integer
			Get
				Return Me.Oo_._O0oOOOo..NewIndex
			End Get
		End Property

		' Token: 0x17000838 RID: 2104
		' (get) Token: 0x060023E4 RID: 9188 RVA: 0x000F9BD6 File Offset: 0x000F7DD6
		' (set) Token: 0x060023E5 RID: 9189 RVA: 0x000F9BE3 File Offset: 0x000F7DE3
		Public Property Cancel As Boolean
			Get
				Return Me.Oo_._O0oOOOo..Cancel
			End Get
			Set(value As Boolean)
				Me.Oo_._O0oOOOo..Cancel = value
			End Set
		End Property

		' Token: 0x04000ED9 RID: 3801
		Private <<EMPTY_NAME>> As SelectedIndexChangingEventArgs
	End Class
End Namespace
