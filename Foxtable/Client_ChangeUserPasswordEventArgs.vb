Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000184 RID: 388
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Client_ChangeUserPasswordEventArgs
		' Token: 0x06001214 RID: 4628 RVA: 0x0006E90B File Offset: 0x0006CB0B
		Public Sub New(A_0 As IMClient)
			Me.O_o.O0. = A_0
		End Sub

		' Token: 0x170003DE RID: 990
		' (get) Token: 0x06001215 RID: 4629 RVA: 0x0006E91A File Offset: 0x0006CB1A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Client As IMClient
			Get
				Return Me.O_o.O0.
			End Get
		End Property

		' Token: 0x040006F6 RID: 1782
		Private <<EMPTY_NAME>> As IMClient
	End Class
End Namespace
