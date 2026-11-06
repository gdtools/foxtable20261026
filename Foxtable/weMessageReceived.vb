Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000189 RID: 393
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class weMessageReceived
		' Token: 0x0600122C RID: 4652 RVA: 0x0006EAB8 File Offset: 0x0006CCB8
		Public Sub New(A_0 As IMClient, A_1 As String, A_2 As Integer, A_3 As String)
			Me.Oo0_0.o. = A_0
			Me.o.O___oOOOOoo. = A_1
			Me.o.O___oOOOOoo. = A_2
			Me.o0_O0_o_o0O._o. = A_3
		End Sub

		' Token: 0x170003EE RID: 1006
		' (get) Token: 0x0600122D RID: 4653 RVA: 0x0006EADD File Offset: 0x0006CCDD
		Public ReadOnly Property Client As IMClient
			Get
				Return Me.Oo0_0.o.
			End Get
		End Property

		' Token: 0x170003EF RID: 1007
		' (get) Token: 0x0600122E RID: 4654 RVA: 0x0006EAE5 File Offset: 0x0006CCE5
		Public ReadOnly Property WeChatID As String
			Get
				Return Me.o.O___oOOOOoo.
			End Get
		End Property

		' Token: 0x170003F0 RID: 1008
		' (get) Token: 0x0600122F RID: 4655 RVA: 0x0006EAED File Offset: 0x0006CCED
		Public ReadOnly Property ContentType As Integer
			Get
				Return Me.o.O___oOOOOoo.
			End Get
		End Property

		' Token: 0x170003F1 RID: 1009
		' (get) Token: 0x06001230 RID: 4656 RVA: 0x0006EAF5 File Offset: 0x0006CCF5
		Public ReadOnly Property Content As String
			Get
				Return Me.o0_O0_o_o0O._o.
			End Get
		End Property

		' Token: 0x04000706 RID: 1798
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x04000707 RID: 1799
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000708 RID: 1800
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000709 RID: 1801
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
