Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002A5 RID: 677
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DropDownClosedEventArgs
		' Token: 0x060023DF RID: 9183 RVA: 0x000F9B92 File Offset: 0x000F7D92
		Public Sub New(A_0 As Form, A_1 As Boolean)
			Me.oO.0. = A_0
			Me.oO.0. = A_1
		End Sub

		' Token: 0x17000835 RID: 2101
		' (get) Token: 0x060023E0 RID: 9184 RVA: 0x000F9BA8 File Offset: 0x000F7DA8
		Public ReadOnly Property Form As Form
			Get
				Return Me.oO.0.
			End Get
		End Property

		' Token: 0x17000836 RID: 2102
		' (get) Token: 0x060023E1 RID: 9185 RVA: 0x000F9BB0 File Offset: 0x000F7DB0
		Public ReadOnly Property Selected As Boolean
			Get
				Return Me.oO.0.
			End Get
		End Property

		' Token: 0x04000ED7 RID: 3799
		Private <<EMPTY_NAME>> As Form

		' Token: 0x04000ED8 RID: 3800
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
