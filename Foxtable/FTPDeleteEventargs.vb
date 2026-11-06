Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020000AC RID: 172
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FTPDeleteEventargs
		' Token: 0x060006EC RID: 1772 RVA: 0x00026F7F File Offset: 0x0002517F
		Public Sub New(A_0 As String, A_1 As Boolean, A_2 As DateTime, A_3 As String)
			Me.O00_.ooO. = A_0
			Me.O00_.ooO. = A_1
			Me.O00_.ooO. = A_2
			Me.OO0O_000.oO0. = A_3
		End Sub

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x060006ED RID: 1773 RVA: 0x00026FA4 File Offset: 0x000251A4
		Public ReadOnly Property IsFolder As Boolean
			Get
				Return Me.O00_.ooO.
			End Get
		End Property

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x060006EE RID: 1774 RVA: 0x00026FAC File Offset: 0x000251AC
		Public ReadOnly Property FileName As String
			Get
				Return Me.O00_.ooO.
			End Get
		End Property

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x060006EF RID: 1775 RVA: 0x00026FB4 File Offset: 0x000251B4
		Public ReadOnly Property ModifyTime As DateTime
			Get
				Return Me.O00_.ooO.
			End Get
		End Property

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x060006F0 RID: 1776 RVA: 0x00026FBC File Offset: 0x000251BC
		Public ReadOnly Property FTPName As String
			Get
				Return Me.OO0O_000.oO0.
			End Get
		End Property

		' Token: 0x170001E4 RID: 484
		' (get) Token: 0x060006F1 RID: 1777 RVA: 0x00026FC4 File Offset: 0x000251C4
		' (set) Token: 0x060006F2 RID: 1778 RVA: 0x00026FCC File Offset: 0x000251CC
		Public Property Cancel As Boolean
			Get
				Return Me.oO.o___.
			End Get
			Set(value As Boolean)
				Me.oO.o___. = value
			End Set
		End Property

		' Token: 0x170001E5 RID: 485
		' (get) Token: 0x060006F3 RID: 1779 RVA: 0x00026FD5 File Offset: 0x000251D5
		' (set) Token: 0x060006F4 RID: 1780 RVA: 0x00026FDD File Offset: 0x000251DD
		Public Property CancelAll As Boolean
			Get
				Return Me.o.o00_O0O0__0O.
			End Get
			Set(value As Boolean)
				Me.o.o00_O0O0__0O. = value
			End Set
		End Property

		' Token: 0x040001EA RID: 490
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001EB RID: 491
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001EC RID: 492
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001ED RID: 493
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001EE RID: 494
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001EF RID: 495
		Private <<EMPTY_NAME>> As DateTime
	End Class
End Namespace
