Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020001AE RID: 430
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Client_LogoutEventArgs
		' Token: 0x06001456 RID: 5206 RVA: 0x00080E37 File Offset: 0x0007F037
		Public Sub New(A_0 As IMClient, A_1 As Integer)
			Me.O_o.O0. = A_1
			Me.O_o.O0. = A_0
		End Sub

		' Token: 0x1700043B RID: 1083
		' (get) Token: 0x06001457 RID: 5207 RVA: 0x00080E4D File Offset: 0x0007F04D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Client As IMClient
			Get
				Return Me.O_o.O0.
			End Get
		End Property

		' Token: 0x1700043C RID: 1084
		' (get) Token: 0x06001458 RID: 5208 RVA: 0x00080E55 File Offset: 0x0007F055
		Public ReadOnly Property Mode As Integer
			Get
				Return Me.O_o.O0.
			End Get
		End Property

		' Token: 0x040007E3 RID: 2019
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x040007E4 RID: 2020
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
