Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000183 RID: 387
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OpenQQMenuEventArgs
		' Token: 0x0600120E RID: 4622 RVA: 0x0006E8B6 File Offset: 0x0006CAB6
		Public Sub New(A_0 As String, A_1 As String, A_2 As Integer, A_3 As String, A_4 As DateTime)
			Me.OOoo.00O_0. = A_0
			Me.O._000. = A_1
			Me.o.O0o_Ooo_o. = A_2
			Me.oo_._O_. = A_3
			Me.o.O0o_Ooo_o. = A_4
		End Sub

		' Token: 0x170003D9 RID: 985
		' (get) Token: 0x0600120F RID: 4623 RVA: 0x0006E8E3 File Offset: 0x0006CAE3
		Public ReadOnly Property BuddyName As String
			Get
				Return Me.OOoo.00O_0.
			End Get
		End Property

		' Token: 0x170003DA RID: 986
		' (get) Token: 0x06001210 RID: 4624 RVA: 0x0006E8EB File Offset: 0x0006CAEB
		Public ReadOnly Property Content As String
			Get
				Return Me.O._000.
			End Get
		End Property

		' Token: 0x170003DB RID: 987
		' (get) Token: 0x06001211 RID: 4625 RVA: 0x0006E8F3 File Offset: 0x0006CAF3
		Public ReadOnly Property ContentType As Integer
			Get
				Return Me.o.O0o_Ooo_o.
			End Get
		End Property

		' Token: 0x170003DC RID: 988
		' (get) Token: 0x06001212 RID: 4626 RVA: 0x0006E8FB File Offset: 0x0006CAFB
		Public ReadOnly Property Sender As String
			Get
				Return Me.oo_._O_.
			End Get
		End Property

		' Token: 0x170003DD RID: 989
		' (get) Token: 0x06001213 RID: 4627 RVA: 0x0006E903 File Offset: 0x0006CB03
		Public ReadOnly Property Sendtime As DateTime
			Get
				Return Me.o.O0o_Ooo_o.
			End Get
		End Property

		' Token: 0x040006F1 RID: 1777
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006F2 RID: 1778
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006F3 RID: 1779
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040006F4 RID: 1780
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006F5 RID: 1781
		Private <<EMPTY_NAME>> As DateTime
	End Class
End Namespace
