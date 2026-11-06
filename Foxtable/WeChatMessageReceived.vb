Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000188 RID: 392
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class WeChatMessageReceived
		' Token: 0x06001225 RID: 4645 RVA: 0x0006EA38 File Offset: 0x0006CC38
		Public Sub New(A_0 As IMServer, A_1 As String, A_2 As String, A_3 As String, A_4 As Integer, A_5 As Boolean)
			Me.Oo0_0.o. = A_0
			Me.Oo0_0.o. = A_1
			Me.o0_O0_o_o0O._o. = A_2.Trim(New Char() { """"c })
			Me.oO0O_O0.0O. = A_3
			Me.o_0o0.0OOOo. = A_4
			Me.o_0o0.0OOOo. = A_5
		End Sub

		' Token: 0x170003E8 RID: 1000
		' (get) Token: 0x06001226 RID: 4646 RVA: 0x0006EA88 File Offset: 0x0006CC88
		Public ReadOnly Property Sender As String
			Get
				Return Me.Oo0_0.o.
			End Get
		End Property

		' Token: 0x170003E9 RID: 1001
		' (get) Token: 0x06001227 RID: 4647 RVA: 0x0006EA90 File Offset: 0x0006CC90
		Public ReadOnly Property WeChatID As String
			Get
				Return Me.o0_O0_o_o0O._o.
			End Get
		End Property

		' Token: 0x170003EA RID: 1002
		' (get) Token: 0x06001228 RID: 4648 RVA: 0x0006EA98 File Offset: 0x0006CC98
		Public ReadOnly Property Content As String
			Get
				Return Me.oO0O_O0.0O.
			End Get
		End Property

		' Token: 0x170003EB RID: 1003
		' (get) Token: 0x06001229 RID: 4649 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		Public ReadOnly Property ContentType As Integer
			Get
				Return Me.o_0o0.0OOOo.
			End Get
		End Property

		' Token: 0x170003EC RID: 1004
		' (get) Token: 0x0600122A RID: 4650 RVA: 0x0006EAA8 File Offset: 0x0006CCA8
		Public ReadOnly Property Server As IMServer
			Get
				Return Me.Oo0_0.o.
			End Get
		End Property

		' Token: 0x170003ED RID: 1005
		' (get) Token: 0x0600122B RID: 4651 RVA: 0x0006EAB0 File Offset: 0x0006CCB0
		Public ReadOnly Property Buildin As Boolean
			Get
				Return Me.o_0o0.0OOOo.
			End Get
		End Property

		' Token: 0x04000700 RID: 1792
		Private <<EMPTY_NAME>> As IMServer

		' Token: 0x04000701 RID: 1793
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000702 RID: 1794
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000703 RID: 1795
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000704 RID: 1796
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000705 RID: 1797
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
