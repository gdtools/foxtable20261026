Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000243 RID: 579
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class NewMessageEventArgs
		' Token: 0x06001AF7 RID: 6903 RVA: 0x000ABD7C File Offset: 0x000A9F7C
		Public Sub New(A_0 As Short, A_1 As Short, A_2 As String, A_3 As String, A_4 As DateTime)
			Me.Oo_oOO_._Oo_o. = A_0
			Me.o0o_Oo_.o. = A_1
			Me.Oo_oOO_._Oo_o. = A_2
			Me.o0o_Oo_.o. = A_3
			Me.Oo_oOO_._Oo_o. = A_4
		End Sub

		' Token: 0x17000620 RID: 1568
		' (get) Token: 0x06001AF8 RID: 6904 RVA: 0x000ABDA9 File Offset: 0x000A9FA9
		Public ReadOnly Property Type As Short
			Get
				Return Me.Oo_oOO_._Oo_o.
			End Get
		End Property

		' Token: 0x17000621 RID: 1569
		' (get) Token: 0x06001AF9 RID: 6905 RVA: 0x000ABDB1 File Offset: 0x000A9FB1
		Public ReadOnly Property Content As String
			Get
				Return Me.o0o_Oo_.o.
			End Get
		End Property

		' Token: 0x17000622 RID: 1570
		' (get) Token: 0x06001AFA RID: 6906 RVA: 0x000ABDB9 File Offset: 0x000A9FB9
		Public ReadOnly Property Index As Short
			Get
				Return Me.o0o_Oo_.o.
			End Get
		End Property

		' Token: 0x17000623 RID: 1571
		' (get) Token: 0x06001AFB RID: 6907 RVA: 0x000ABDC1 File Offset: 0x000A9FC1
		Public ReadOnly Property FromNumber As String
			Get
				Return Me.Oo_oOO_._Oo_o.
			End Get
		End Property

		' Token: 0x17000624 RID: 1572
		' (get) Token: 0x06001AFC RID: 6908 RVA: 0x000ABDC9 File Offset: 0x000A9FC9
		Public ReadOnly Property SentTime As DateTime
			Get
				Return Me.Oo_oOO_._Oo_o.
			End Get
		End Property

		' Token: 0x04000B65 RID: 2917
		Private <<EMPTY_NAME>> As Short

		' Token: 0x04000B66 RID: 2918
		Private <<EMPTY_NAME>> As Short

		' Token: 0x04000B67 RID: 2919
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B68 RID: 2920
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B69 RID: 2921
		Private <<EMPTY_NAME>> As DateTime
	End Class
End Namespace
