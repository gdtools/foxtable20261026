Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020000AF RID: 175
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FTPRenameEventArgs
		' Token: 0x06000702 RID: 1794 RVA: 0x000270B0 File Offset: 0x000252B0
		Public Sub New(A_0 As String, A_1 As String, A_2 As Boolean, A_3 As DateTime, A_4 As String)
			Me.O_.0O_o. = A_0
			Me.o_OO.00. = A_1
			Me.O_.0O_o. = A_2
			Me.O_.0O_o. = A_3
			Me.O0_00O0O_.0. = A_4
		End Sub

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x06000703 RID: 1795 RVA: 0x000270DD File Offset: 0x000252DD
		Public ReadOnly Property IsFolder As Boolean
			Get
				Return Me.O_.0O_o.
			End Get
		End Property

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x06000704 RID: 1796 RVA: 0x000270E5 File Offset: 0x000252E5
		Public ReadOnly Property NewName As String
			Get
				Return Me.o_OO.00.
			End Get
		End Property

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x06000705 RID: 1797 RVA: 0x000270ED File Offset: 0x000252ED
		Public ReadOnly Property OldName As String
			Get
				Return Me.O_.0O_o.
			End Get
		End Property

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x06000706 RID: 1798 RVA: 0x000270F5 File Offset: 0x000252F5
		Public ReadOnly Property FTPName As String
			Get
				Return Me.O0_00O0O_.0.
			End Get
		End Property

		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x06000707 RID: 1799 RVA: 0x000270FD File Offset: 0x000252FD
		Public ReadOnly Property ModifyTime As DateTime
			Get
				Return Me.O_.0O_o.
			End Get
		End Property

		' Token: 0x170001F3 RID: 499
		' (get) Token: 0x06000708 RID: 1800 RVA: 0x00027105 File Offset: 0x00025305
		' (set) Token: 0x06000709 RID: 1801 RVA: 0x0002710D File Offset: 0x0002530D
		Public Property Cancel As Boolean
			Get
				Return Me.o_OO.00.
			End Get
			Set(value As Boolean)
				Me.o_OO.00. = value
			End Set
		End Property

		' Token: 0x040001F8 RID: 504
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001F9 RID: 505
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001FA RID: 506
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001FB RID: 507
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001FC RID: 508
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001FD RID: 509
		Private <<EMPTY_NAME>> As DateTime
	End Class
End Namespace
