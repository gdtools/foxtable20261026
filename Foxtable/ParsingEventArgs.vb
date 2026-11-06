Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000152 RID: 338
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ParsingEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000FA8 RID: 4008 RVA: 0x00068F89 File Offset: 0x00067189
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ParseEventArgs)
			MyBase.New(A_0, A_1)
			Me.O_0o0.OoO_o. = A_2
		End Sub

		' Token: 0x170002E3 RID: 739
		' (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00068F9A File Offset: 0x0006719A
		Public ReadOnly Property Text As String
			Get
				Return Me.O_0o0.OoO_o..Text
			End Get
		End Property

		' Token: 0x170002E4 RID: 740
		' (get) Token: 0x06000FAA RID: 4010 RVA: 0x00068FA7 File Offset: 0x000671A7
		' (set) Token: 0x06000FAB RID: 4011 RVA: 0x00068FB4 File Offset: 0x000671B4
		Public Property Value As Object
			Get
				Return Me.O_0o0.OoO_o..Text
			End Get
			Set(value As Object)
				Me.O_0o0.OoO_o..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x04000601 RID: 1537
		Private <<EMPTY_NAME>> As ParseEventArgs
	End Class
End Namespace
