Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003DF RID: 991
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ListItemFormatEventArgs
		Inherits ControlEventArgs

		' Token: 0x06003EF7 RID: 16119 RVA: 0x001B2A6B File Offset: 0x001B0C6B
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As DataRowView)
			MyBase.New(A_0, A_1)
			Me.oo.oO_. = A_2
		End Sub

		' Token: 0x17000DB3 RID: 3507
		' (get) Token: 0x06003EF8 RID: 16120 RVA: 0x001B2A7C File Offset: 0x001B0C7C
		' (set) Token: 0x06003EF9 RID: 16121 RVA: 0x001B2A84 File Offset: 0x001B0C84
		Public Property Value As String
			Get
				Return Me.O0.ooOo0.
			End Get
			Set(value As String)
				Me.O0.ooOo0. = value
			End Set
		End Property

		' Token: 0x17000DB4 RID: 3508
		' (get) Token: 0x06003EFA RID: 16122 RVA: 0x001B2A8D File Offset: 0x001B0C8D
		' (set) Token: 0x06003EFB RID: 16123 RVA: 0x001B2A95 File Offset: 0x001B0C95
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Text As String
			Get
				Return Me.O0.ooOo0.
			End Get
			Set(value As String)
				Me.O0.ooOo0. = value
			End Set
		End Property

		' Token: 0x17000DB5 RID: 3509
		' (get) Token: 0x06003EFC RID: 16124 RVA: 0x001B2A9E File Offset: 0x001B0C9E
		Public ReadOnly Property ListItem As DataRow
			Get
				Return New DataRow(Me.oo.oO_..Row)
			End Get
		End Property

		' Token: 0x04001989 RID: 6537
		Private <<EMPTY_NAME>> As DataRowView

		' Token: 0x0400198A RID: 6538
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
