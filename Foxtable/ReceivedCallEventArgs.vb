Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000244 RID: 580
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ReceivedCallEventArgs
		' Token: 0x06001AFD RID: 6909 RVA: 0x000ABDD1 File Offset: 0x000A9FD1
		Public Sub New(A_0 As String)
			Me.O_._0o00_. = A_0
		End Sub

		' Token: 0x17000625 RID: 1573
		' (get) Token: 0x06001AFE RID: 6910 RVA: 0x000ABDE0 File Offset: 0x000A9FE0
		Public ReadOnly Property FromNumber As String
			Get
				Return Me.O_._0o00_.
			End Get
		End Property

		' Token: 0x04000B6A RID: 2922
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
