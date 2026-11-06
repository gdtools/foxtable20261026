Imports System
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200027F RID: 639
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CrossTotalOn
		' Token: 0x06001ED2 RID: 7890 RVA: 0x000C8A45 File Offset: 0x000C6C45
		Friend Sub New(Optional A_0 As Boolean = False)
			Me.O_oO_O_0.0_o. = 2
			Me.O_oO_O_0.0_o. = A_0
		End Sub

		' Token: 0x06001ED3 RID: 7891 RVA: 0x000C8A5B File Offset: 0x000C6C5B
		Public Sub New(A_0 As String, Optional A_1 As Boolean = False)
			Me.O_oO_O_0.0_o. = 2
			Me.O_oO_O_0.0_o. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.O_oO_O_0.0_o. = A_1
		End Sub

		' Token: 0x06001ED4 RID: 7892 RVA: 0x000C8A98 File Offset: 0x000C6C98
		Public Sub New(A_0 As String, A_1 As String, Optional A_2 As Boolean = False)
			Me.O_oO_O_0.0_o. = 2
			Me.O_oO_O_0.0_o. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.oO00._. = A_1
			Me.O_oO_O_0.0_o. = A_2
		End Sub

		' Token: 0x06001ED5 RID: 7893 RVA: 0x000C8AE8 File Offset: 0x000C6CE8
		Public Sub New(A_0 As String, A_1 As AggregateEnum, Optional A_2 As Boolean = False)
			Me.O_oO_O_0.0_o. = 2
			Me.O_oO_O_0.0_o. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.O_oO_O_0.0_o. = A_1
			Me.O_oO_O_0.0_o. = A_2
		End Sub

		' Token: 0x06001ED6 RID: 7894 RVA: 0x000C8B38 File Offset: 0x000C6D38
		Public Sub New(A_0 As String, A_1 As AggregateEnum, A_2 As String, Optional A_3 As Boolean = False)
			Me.O_oO_O_0.0_o. = 2
			Me.O_oO_O_0.0_o. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.O_oO_O_0.0_o. = A_1
			Me.oO00._. = A_2
			Me.O_oO_O_0.0_o. = A_3
		End Sub

		' Token: 0x170006E8 RID: 1768
		' (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000C8B8F File Offset: 0x000C6D8F
		' (set) Token: 0x06001ED8 RID: 7896 RVA: 0x000C8B97 File Offset: 0x000C6D97
		Public Property Name As String
			Get
				Return Me.O_oO_O_0.0_o.
			End Get
			Set(value As String)
				Me.O_oO_O_0.0_o. = value.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			End Set
		End Property

		' Token: 0x170006E9 RID: 1769
		' (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000C8BC0 File Offset: 0x000C6DC0
		' (set) Token: 0x06001EDA RID: 7898 RVA: 0x000C8C37 File Offset: 0x000C6E37
		Public Property Caption As String
			Get
				Dim result As String
				If Operators.CompareString(Me.oO00._., "", True) > 0 Then
					result = Me.oO00._.
				ElseIf Me.O_oO_O_0.0_o..StartsWith("{") AndAlso Me.O_oO_O_0.0_o..IndexOf("}.") > 0 Then
					result = Me.O_oO_O_0.0_o..Substring(Me.O_oO_O_0.0_o..IndexOf("}.") + 2)
				Else
					result = Me.O_oO_O_0.0_o.
				End If
				Return result
			End Get
			Set(value As String)
				Me.oO00._. = value
			End Set
		End Property

		' Token: 0x170006EA RID: 1770
		' (get) Token: 0x06001EDB RID: 7899 RVA: 0x000C8C40 File Offset: 0x000C6E40
		' (set) Token: 0x06001EDC RID: 7900 RVA: 0x000C8C48 File Offset: 0x000C6E48
		Public Property Aggregate As AggregateEnum
			Get
				Return Me.O_oO_O_0.0_o.
			End Get
			Set(value As AggregateEnum)
				Me.O_oO_O_0.0_o. = value
			End Set
		End Property

		' Token: 0x170006EB RID: 1771
		' (get) Token: 0x06001EDD RID: 7901 RVA: 0x000C8C51 File Offset: 0x000C6E51
		' (set) Token: 0x06001EDE RID: 7902 RVA: 0x000C8C59 File Offset: 0x000C6E59
		Public Property upto As Boolean
			Get
				Return Me.O_oO_O_0.0_o.
			End Get
			Set(value As Boolean)
				Me.O_oO_O_0.0_o. = value
			End Set
		End Property

		' Token: 0x04000CE2 RID: 3298
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CE3 RID: 3299
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CE4 RID: 3300
		Private <<EMPTY_NAME>> As AggregateEnum

		' Token: 0x04000CE5 RID: 3301
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
