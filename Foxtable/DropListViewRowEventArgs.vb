Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200019C RID: 412
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DropListViewRowEventArgs
		Inherits ControlEventArgs

		' Token: 0x0600138C RID: 5004 RVA: 0x0007EFB2 File Offset: 0x0007D1B2
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As Integer, A_3 As Integer, A_4 As Foxtable.WinForm.ListView)
			MyBase.New(A_0, A_1)
			Me.oO.0. = True
			Me.OO0__.O0oO0o_o. = True
			Me.oO.0. = A_3
			Me.OO0__.O0oO0o_o. = A_2
			Me.oO.0. = A_4
		End Sub

		' Token: 0x170003F2 RID: 1010
		' (get) Token: 0x0600138D RID: 5005 RVA: 0x0007EFE1 File Offset: 0x0007D1E1
		Public ReadOnly Property NewIndex As Integer
			Get
				Return Me.oO.0.
			End Get
		End Property

		' Token: 0x170003F3 RID: 1011
		' (get) Token: 0x0600138E RID: 5006 RVA: 0x0007EFE9 File Offset: 0x0007D1E9
		Public ReadOnly Property OldIndex As Integer
			Get
				Return Me.OO0__.O0oO0o_o.
			End Get
		End Property

		' Token: 0x170003F4 RID: 1012
		' (get) Token: 0x0600138F RID: 5007 RVA: 0x0007EFF1 File Offset: 0x0007D1F1
		Public ReadOnly Property Source As Foxtable.WinForm.ListView
			Get
				Return Me.oO.0.
			End Get
		End Property

		' Token: 0x170003F5 RID: 1013
		' (get) Token: 0x06001390 RID: 5008 RVA: 0x0007EFF9 File Offset: 0x0007D1F9
		' (set) Token: 0x06001391 RID: 5009 RVA: 0x0007F001 File Offset: 0x0007D201
		Public Property Delete As Boolean
			Get
				Return Me.oO.0.
			End Get
			Set(value As Boolean)
				Me.oO.0. = value
			End Set
		End Property

		' Token: 0x170003F6 RID: 1014
		' (get) Token: 0x06001392 RID: 5010 RVA: 0x0007F00A File Offset: 0x0007D20A
		' (set) Token: 0x06001393 RID: 5011 RVA: 0x0007F012 File Offset: 0x0007D212
		Public Property Add As Boolean
			Get
				Return Me.OO0__.O0oO0o_o.
			End Get
			Set(value As Boolean)
				Me.OO0__.O0oO0o_o. = value
			End Set
		End Property

		' Token: 0x040007B4 RID: 1972
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040007B5 RID: 1973
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040007B6 RID: 1974
		Private <<EMPTY_NAME>> As Foxtable.WinForm.ListView

		' Token: 0x040007B7 RID: 1975
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040007B8 RID: 1976
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
