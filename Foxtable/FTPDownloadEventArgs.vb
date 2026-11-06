Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020000AD RID: 173
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FTPDownloadEventArgs
		' Token: 0x060006F5 RID: 1781 RVA: 0x00026FE6 File Offset: 0x000251E6
		Public Sub New(A_0 As String, A_1 As DateTime, A_2 As String)
			Me.O00_.ooO. = A_0
			Me.O00_.ooO. = A_1
			Me.OO0O_000.oO0. = A_2
		End Sub

		' Token: 0x170001E6 RID: 486
		' (get) Token: 0x060006F6 RID: 1782 RVA: 0x00027003 File Offset: 0x00025203
		Public ReadOnly Property File As String
			Get
				Return Me.O00_.ooO.
			End Get
		End Property

		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x060006F7 RID: 1783 RVA: 0x0002700B File Offset: 0x0002520B
		Public ReadOnly Property ModifyTime As DateTime
			Get
				Return Me.O00_.ooO.
			End Get
		End Property

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x060006F8 RID: 1784 RVA: 0x00027013 File Offset: 0x00025213
		Public ReadOnly Property FTPName As String
			Get
				Return Me.OO0O_000.oO0.
			End Get
		End Property

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x060006F9 RID: 1785 RVA: 0x0002701B File Offset: 0x0002521B
		' (set) Token: 0x060006FA RID: 1786 RVA: 0x00027023 File Offset: 0x00025223
		Public Property Cancel As Boolean
			Get
				Return Me.O00_.ooO.
			End Get
			Set(value As Boolean)
				Me.O00_.ooO. = value
			End Set
		End Property

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x060006FB RID: 1787 RVA: 0x0002702C File Offset: 0x0002522C
		' (set) Token: 0x060006FC RID: 1788 RVA: 0x00027034 File Offset: 0x00025234
		Public Property CancelAll As Boolean
			Get
				Return Me.OO0O_000.oO0.
			End Get
			Set(value As Boolean)
				Me.OO0O_000.oO0. = value
			End Set
		End Property

		' Token: 0x040001F0 RID: 496
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001F1 RID: 497
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001F2 RID: 498
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001F3 RID: 499
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001F4 RID: 500
		Private <<EMPTY_NAME>> As DateTime
	End Class
End Namespace
