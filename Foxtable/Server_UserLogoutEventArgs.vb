Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020001B7 RID: 439
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Server_UserLogoutEventArgs
		' Token: 0x0600148A RID: 5258 RVA: 0x000812FF File Offset: 0x0007F4FF
		Public Sub New(A_0 As String, A_1 As IMServer, A_2 As Integer)
			Me.OoO.Oo0O0o. = A_0
			Me.OoO.Oo0O0o. = A_1
			Me.o_o._O0O_. = A_2
		End Sub

		' Token: 0x17000458 RID: 1112
		' (get) Token: 0x0600148B RID: 5259 RVA: 0x0008131C File Offset: 0x0007F51C
		Public ReadOnly Property UserName As String
			Get
				Return Me.OoO.Oo0O0o.
			End Get
		End Property

		' Token: 0x17000459 RID: 1113
		' (get) Token: 0x0600148C RID: 5260 RVA: 0x00081324 File Offset: 0x0007F524
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Server As IMServer
			Get
				Return Me.OoO.Oo0O0o.
			End Get
		End Property

		' Token: 0x1700045A RID: 1114
		' (get) Token: 0x0600148D RID: 5261 RVA: 0x0008132C File Offset: 0x0007F52C
		Public ReadOnly Property Mode As Integer
			Get
				Return Me.o_o._O0O_.
			End Get
		End Property

		' Token: 0x04000804 RID: 2052
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000805 RID: 2053
		Private <<EMPTY_NAME>> As IMServer

		' Token: 0x04000806 RID: 2054
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
