Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200019D RID: 413
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ListViewDrawCellEventArgs
		Inherits ControlEventArgs

		' Token: 0x06001394 RID: 5012 RVA: 0x0007F01B File Offset: 0x0007D21B
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ListViewRow, A_3 As ListViewColumn, A_4 As DrawListViewSubItemEventArgs)
			MyBase.New(A_0, A_1)
			Me.oo.oO_. = A_2
			Me.oo.oO_. = A_3
			Me.oo.oO_. = A_4
		End Sub

		' Token: 0x170003F7 RID: 1015
		' (get) Token: 0x06001395 RID: 5013 RVA: 0x0007F03C File Offset: 0x0007D23C
		Public ReadOnly Property Row As ListViewRow
			Get
				Return Me.oo.oO_.
			End Get
		End Property

		' Token: 0x170003F8 RID: 1016
		' (get) Token: 0x06001396 RID: 5014 RVA: 0x0007F044 File Offset: 0x0007D244
		Public ReadOnly Property Col As ListViewColumn
			Get
				Return Me.oo.oO_.
			End Get
		End Property

		' Token: 0x170003F9 RID: 1017
		' (get) Token: 0x06001397 RID: 5015 RVA: 0x0007F04C File Offset: 0x0007D24C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property RowIndex As Integer
			Get
				Return Me.oo.oO_..Index
			End Get
		End Property

		' Token: 0x170003FA RID: 1018
		' (get) Token: 0x06001398 RID: 5016 RVA: 0x0007F059 File Offset: 0x0007D259
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property ColIndex As Integer
			Get
				Return Me.oo.oO_..Index
			End Get
		End Property

		' Token: 0x06001399 RID: 5017 RVA: 0x0007F066 File Offset: 0x0007D266
		Public Sub DrawText()
			Me.oo.oO_..DrawText()
		End Sub

		' Token: 0x0600139A RID: 5018 RVA: 0x0007F073 File Offset: 0x0007D273
		Public Sub DrawBackground()
			Me.oo.oO_..DrawBackground()
		End Sub

		' Token: 0x170003FB RID: 1019
		' (get) Token: 0x0600139B RID: 5019 RVA: 0x0007F080 File Offset: 0x0007D280
		' (set) Token: 0x0600139C RID: 5020 RVA: 0x0007F08D File Offset: 0x0007D28D
		Public Property DrawDefault As Boolean
			Get
				Return Me.oo.oO_..DrawDefault
			End Get
			Set(value As Boolean)
				Me.oo.oO_..DrawDefault = value
			End Set
		End Property

		' Token: 0x170003FC RID: 1020
		' (get) Token: 0x0600139D RID: 5021 RVA: 0x0007F09B File Offset: 0x0007D29B
		Public ReadOnly Property Graphics As Graphics
			Get
				Return Me.oo.oO_..Graphics
			End Get
		End Property

		' Token: 0x170003FD RID: 1021
		' (get) Token: 0x0600139E RID: 5022 RVA: 0x0007F0A8 File Offset: 0x0007D2A8
		Public ReadOnly Property x As Integer
			Get
				Return Me.oo.oO_..Bounds.X
			End Get
		End Property

		' Token: 0x170003FE RID: 1022
		' (get) Token: 0x0600139F RID: 5023 RVA: 0x0007F0C8 File Offset: 0x0007D2C8
		Public ReadOnly Property y As Integer
			Get
				Return Me.oo.oO_..Bounds.Y
			End Get
		End Property

		' Token: 0x170003FF RID: 1023
		' (get) Token: 0x060013A0 RID: 5024 RVA: 0x0007F0E8 File Offset: 0x0007D2E8
		Public ReadOnly Property Width As Integer
			Get
				Return Me.oo.oO_..Bounds.Width
			End Get
		End Property

		' Token: 0x17000400 RID: 1024
		' (get) Token: 0x060013A1 RID: 5025 RVA: 0x0007F108 File Offset: 0x0007D308
		Public ReadOnly Property Height As Integer
			Get
				Return Me.oo.oO_..Bounds.Height
			End Get
		End Property

		' Token: 0x040007B9 RID: 1977
		Private <<EMPTY_NAME>> As ListViewRow

		' Token: 0x040007BA RID: 1978
		Private <<EMPTY_NAME>> As ListViewColumn

		' Token: 0x040007BB RID: 1979
		Private <<EMPTY_NAME>> As DrawListViewSubItemEventArgs
	End Class
End Namespace
