Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x0200023F RID: 575
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ConnectModemResultEventArgs
		' Token: 0x06001AE4 RID: 6884 RVA: 0x000ABC4C File Offset: 0x000A9E4C
		Public Sub New(A_0 As Boolean)
			Me.Oo___.ooooO00. = A_0
		End Sub

		' Token: 0x17000616 RID: 1558
		' (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000ABC5B File Offset: 0x000A9E5B
		Public ReadOnly Property Succeed As Boolean
			Get
				Return Me.Oo___.ooooO00.
			End Get
		End Property

		' Token: 0x04000B5D RID: 2909
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
