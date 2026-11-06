Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000181 RID: 385
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class AfterReceiveFileEventArgs
		' Token: 0x06001204 RID: 4612 RVA: 0x0006E83B File Offset: 0x0006CA3B
		Public Sub New(A_0 As String, A_1 As String, A_2 As Boolean)
			Me.O0o00_0__.___0. = A_0
			Me.O___o.O_0__OoO. = A_1
			Me.O0o00_0__.___0. = A_2
		End Sub

		' Token: 0x170003D2 RID: 978
		' (get) Token: 0x06001205 RID: 4613 RVA: 0x0006E858 File Offset: 0x0006CA58
		Public ReadOnly Property Success As Boolean
			Get
				Return Me.O0o00_0__.___0.
			End Get
		End Property

		' Token: 0x170003D3 RID: 979
		' (get) Token: 0x06001206 RID: 4614 RVA: 0x0006E860 File Offset: 0x0006CA60
		Public ReadOnly Property UserName As String
			Get
				Return Me.O0o00_0__.___0.
			End Get
		End Property

		' Token: 0x170003D4 RID: 980
		' (get) Token: 0x06001207 RID: 4615 RVA: 0x0006E868 File Offset: 0x0006CA68
		Public ReadOnly Property FileName As String
			Get
				Return Me.O___o.O_0__OoO.
			End Get
		End Property

		' Token: 0x040006EA RID: 1770
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006EB RID: 1771
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006EC RID: 1772
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
