Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000245 RID: 581
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class SentMsgStatusEventArgs
		' Token: 0x06001AFF RID: 6911 RVA: 0x000ABDE8 File Offset: 0x000A9FE8
		Public Sub New(A_0 As UInteger, A_1 As String, A_2 As String, A_3 As Short, A_4 As Boolean)
			Me.ooO.o_Oo. = A_0
			Me.ooO.o_Oo. = A_1
			Me.O_oo.0_o_. = A_2
			Me.ooO.o_Oo. = A_3
			Me.ooO.o_Oo. = A_4
		End Sub

		' Token: 0x17000626 RID: 1574
		' (get) Token: 0x06001B00 RID: 6912 RVA: 0x000ABE15 File Offset: 0x000AA015
		Public ReadOnly Property MsgID As UInteger
			Get
				Return Me.ooO.o_Oo.
			End Get
		End Property

		' Token: 0x17000627 RID: 1575
		' (get) Token: 0x06001B01 RID: 6913 RVA: 0x000ABE1D File Offset: 0x000AA01D
		Public ReadOnly Property DestNumber As String
			Get
				Return Me.ooO.o_Oo.
			End Get
		End Property

		' Token: 0x17000628 RID: 1576
		' (get) Token: 0x06001B02 RID: 6914 RVA: 0x000ABE25 File Offset: 0x000AA025
		Public ReadOnly Property Content As String
			Get
				Return Me.O_oo.0_o_.
			End Get
		End Property

		' Token: 0x17000629 RID: 1577
		' (get) Token: 0x06001B03 RID: 6915 RVA: 0x000ABE2D File Offset: 0x000AA02D
		Public ReadOnly Property SplitIndex As Short
			Get
				Return Me.ooO.o_Oo.
			End Get
		End Property

		' Token: 0x1700062A RID: 1578
		' (get) Token: 0x06001B04 RID: 6916 RVA: 0x000ABE35 File Offset: 0x000AA035
		Public ReadOnly Property Succeed As Boolean
			Get
				Return Me.ooO.o_Oo.
			End Get
		End Property

		' Token: 0x04000B6B RID: 2923
		Private <<EMPTY_NAME>> As UInteger

		' Token: 0x04000B6C RID: 2924
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B6D RID: 2925
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B6E RID: 2926
		Private <<EMPTY_NAME>> As Short

		' Token: 0x04000B6F RID: 2927
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
