Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020001AF RID: 431
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Client_BuddyLoginEventArgs
		' Token: 0x06001459 RID: 5209 RVA: 0x00080E5D File Offset: 0x0007F05D
		Friend Sub New(A_0 As String, A_1 As IMClient)
			Me.oOo___._0___0_. = A_0
			Me.oOo___._0___0_. = A_1
		End Sub

		' Token: 0x1700043D RID: 1085
		' (get) Token: 0x0600145A RID: 5210 RVA: 0x00080E73 File Offset: 0x0007F073
		Public ReadOnly Property BuddyName As String
			Get
				Return Me.oOo___._0___0_.
			End Get
		End Property

		' Token: 0x1700043E RID: 1086
		' (get) Token: 0x0600145B RID: 5211 RVA: 0x00080E7B File Offset: 0x0007F07B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Client As IMClient
			Get
				Return Me.oOo___._0___0_.
			End Get
		End Property

		' Token: 0x040007E5 RID: 2021
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007E6 RID: 2022
		Private <<EMPTY_NAME>> As IMClient
	End Class
End Namespace
