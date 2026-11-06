Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020001B1 RID: 433
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Client_BuddyLogoutEventArgs
		' Token: 0x06001462 RID: 5218 RVA: 0x00080ED4 File Offset: 0x0007F0D4
		Friend Sub New(A_0 As String, A_1 As IMClient, A_2 As Integer)
			Me.O_o.O0. = A_0
			Me.O_o.O0. = A_2
			Me.O_o.O0. = A_1
		End Sub

		' Token: 0x17000443 RID: 1091
		' (get) Token: 0x06001463 RID: 5219 RVA: 0x00080EF1 File Offset: 0x0007F0F1
		Public ReadOnly Property BuddyName As String
			Get
				Return Me.O_o.O0.
			End Get
		End Property

		' Token: 0x17000444 RID: 1092
		' (get) Token: 0x06001464 RID: 5220 RVA: 0x00080EF9 File Offset: 0x0007F0F9
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Client As IMClient
			Get
				Return Me.O_o.O0.
			End Get
		End Property

		' Token: 0x17000445 RID: 1093
		' (get) Token: 0x06001465 RID: 5221 RVA: 0x00080F01 File Offset: 0x0007F101
		Public ReadOnly Property Mode As Integer
			Get
				Return Me.O_o.O0.
			End Get
		End Property

		' Token: 0x040007EB RID: 2027
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007EC RID: 2028
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x040007ED RID: 2029
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
