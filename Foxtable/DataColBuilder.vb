Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000280 RID: 640
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DataColBuilder
		' Token: 0x06001EDF RID: 7903 RVA: 0x000C8C62 File Offset: 0x000C6E62
		Public Sub New(A_0 As String, A_1 As Type)
			Me.O_0__o.o_0o. = 32
			Me.oo.O_0OOO_o. = ""
			Me.OOo._oO00ooo. = ""
			Me.O_0__o.o_0o. = A_0
			Me.O_0__o.o_0o. = A_1
		End Sub

		' Token: 0x06001EE0 RID: 7904 RVA: 0x000C8C96 File Offset: 0x000C6E96
		Public Sub New(A_0 As String, A_1 As Type, A_2 As String)
			Me.O_0__o.o_0o. = 32
			Me.oo.O_0OOO_o. = ""
			Me.OOo._oO00ooo. = ""
			Me.O_0__o.o_0o. = A_0
			Me.O_0__o.o_0o. = A_1
			Me.OOo._oO00ooo. = A_2
		End Sub

		' Token: 0x06001EE1 RID: 7905 RVA: 0x000C8CD4 File Offset: 0x000C6ED4
		Public Sub New(A_0 As String, A_1 As Type, A_2 As String, A_3 As String)
			Me.O_0__o.o_0o. = 32
			Me.oo.O_0OOO_o. = ""
			Me.OOo._oO00ooo. = ""
			Me.O_0__o.o_0o. = A_0
			Me.O_0__o.o_0o. = A_1
			Me.OOo._oO00ooo. = A_2
			Me.oo.O_0OOO_o. = A_3
		End Sub

		' Token: 0x06001EE2 RID: 7906 RVA: 0x000C8D22 File Offset: 0x000C6F22
		Public Sub New(A_0 As String, A_1 As Type, A_2 As Integer)
			Me.O_0__o.o_0o. = 32
			Me.oo.O_0OOO_o. = ""
			Me.OOo._oO00ooo. = ""
			Me.O_0__o.o_0o. = A_0
			Me.O_0__o.o_0o. = A_1
			Me.O_0__o.o_0o. = A_2
		End Sub

		' Token: 0x06001EE3 RID: 7907 RVA: 0x000C8D60 File Offset: 0x000C6F60
		Public Sub New(A_0 As String, A_1 As Type, A_2 As Integer, A_3 As String)
			Me.O_0__o.o_0o. = 32
			Me.oo.O_0OOO_o. = ""
			Me.OOo._oO00ooo. = ""
			Me.O_0__o.o_0o. = A_0
			Me.O_0__o.o_0o. = A_1
			Me.O_0__o.o_0o. = A_2
			Me.OOo._oO00ooo. = A_3
		End Sub

		' Token: 0x06001EE4 RID: 7908 RVA: 0x000C8DB0 File Offset: 0x000C6FB0
		Public Sub New(A_0 As String, A_1 As Type, A_2 As Integer, A_3 As String, A_4 As String)
			Me.O_0__o.o_0o. = 32
			Me.oo.O_0OOO_o. = ""
			Me.OOo._oO00ooo. = ""
			Me.O_0__o.o_0o. = A_0
			Me.O_0__o.o_0o. = A_1
			Me.O_0__o.o_0o. = A_2
			Me.OOo._oO00ooo. = A_3
			Me.oo.O_0OOO_o. = A_4
		End Sub

		' Token: 0x170006EC RID: 1772
		' (get) Token: 0x06001EE5 RID: 7909 RVA: 0x000C8E06 File Offset: 0x000C7006
		' (set) Token: 0x06001EE6 RID: 7910 RVA: 0x000C8E0E File Offset: 0x000C700E
		Public Property Name As String
			Get
				Return Me.O_0__o.o_0o.
			End Get
			Set(value As String)
				Me.O_0__o.o_0o. = value
			End Set
		End Property

		' Token: 0x170006ED RID: 1773
		' (get) Token: 0x06001EE7 RID: 7911 RVA: 0x000C8E17 File Offset: 0x000C7017
		' (set) Token: 0x06001EE8 RID: 7912 RVA: 0x000C8E1F File Offset: 0x000C701F
		Public Property Type As Type
			Get
				Return Me.O_0__o.o_0o.
			End Get
			Set(value As Type)
				Me.O_0__o.o_0o. = value
			End Set
		End Property

		' Token: 0x170006EE RID: 1774
		' (get) Token: 0x06001EE9 RID: 7913 RVA: 0x000C8E28 File Offset: 0x000C7028
		' (set) Token: 0x06001EEA RID: 7914 RVA: 0x000C8E30 File Offset: 0x000C7030
		Public Property Caption As String
			Get
				Return Me.oo.O_0OOO_o.
			End Get
			Set(value As String)
				Me.oo.O_0OOO_o. = value
			End Set
		End Property

		' Token: 0x170006EF RID: 1775
		' (get) Token: 0x06001EEB RID: 7915 RVA: 0x000C8E39 File Offset: 0x000C7039
		' (set) Token: 0x06001EEC RID: 7916 RVA: 0x000C8E41 File Offset: 0x000C7041
		Public Property Maxlength As Integer
			Get
				Return Me.O_0__o.o_0o.
			End Get
			Set(value As Integer)
				Me.O_0__o.o_0o. = value
			End Set
		End Property

		' Token: 0x170006F0 RID: 1776
		' (get) Token: 0x06001EED RID: 7917 RVA: 0x000C8E4A File Offset: 0x000C704A
		' (set) Token: 0x06001EEE RID: 7918 RVA: 0x000C8E52 File Offset: 0x000C7052
		Public Property Expression As String
			Get
				Return Me.OOo._oO00ooo.
			End Get
			Set(value As String)
				Me.OOo._oO00ooo. = value
			End Set
		End Property

		' Token: 0x04000CE6 RID: 3302
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CE7 RID: 3303
		Private <<EMPTY_NAME>> As Type

		' Token: 0x04000CE8 RID: 3304
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000CE9 RID: 3305
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CEA RID: 3306
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
