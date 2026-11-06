Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020001B4 RID: 436
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Server_UserEventArgs
		' Token: 0x06001474 RID: 5236 RVA: 0x00081003 File Offset: 0x0007F203
		Public Sub New(A_0 As String, A_1 As IMServer)
			Me.oo_O._. = A_0
			Me.o__.O0_0. = A_1
		End Sub

		' Token: 0x1700044C RID: 1100
		' (get) Token: 0x06001475 RID: 5237 RVA: 0x00081019 File Offset: 0x0007F219
		Public ReadOnly Property UserName As String
			Get
				Return Me.oo_O._.
			End Get
		End Property

		' Token: 0x1700044D RID: 1101
		' (get) Token: 0x06001476 RID: 5238 RVA: 0x00081021 File Offset: 0x0007F221
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Server As IMServer
			Get
				Return Me.o__.O0_0.
			End Get
		End Property

		' Token: 0x040007F5 RID: 2037
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007F6 RID: 2038
		Private <<EMPTY_NAME>> As IMServer
	End Class
End Namespace
