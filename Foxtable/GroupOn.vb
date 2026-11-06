Imports System
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000286 RID: 646
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GroupOn
		' Token: 0x06001F41 RID: 8001 RVA: 0x000C9F84 File Offset: 0x000C8184
		Friend Sub New()
			Me.ooOo_0oo._0_. = 3
			Me.oo_00o.00_0_. = True
		End Sub

		' Token: 0x06001F42 RID: 8002 RVA: 0x000C9F9A File Offset: 0x000C819A
		Public Sub New(A_0 As String)
			Me.ooOo_0oo._0_. = 3
			Me.oo_00o.00_0_. = True
			Me.OO0__0_.o00. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
		End Sub

		' Token: 0x06001F43 RID: 8003 RVA: 0x000C9FD8 File Offset: 0x000C81D8
		Public Sub New(A_0 As String, A_1 As String)
			Me.ooOo_0oo._0_. = 3
			Me.oo_00o.00_0_. = True
			Me.OO0__0_.o00. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.oO0O.__o_OO_oo. = A_1
		End Sub

		' Token: 0x06001F44 RID: 8004 RVA: 0x000CA028 File Offset: 0x000C8228
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.ooOo_0oo._0_. = 3
			Me.oo_00o.00_0_. = True
			Me.OO0__0_.o00. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.oO0O.__o_OO_oo. = A_1
			Me.OoO._0OO0O__. = A_2
		End Sub

		' Token: 0x06001F45 RID: 8005 RVA: 0x000CA080 File Offset: 0x000C8280
		Public Sub New(A_0 As String, A_1 As DateGroupEnum)
			Me.ooOo_0oo._0_. = 3
			Me.oo_00o.00_0_. = True
			Me.OO0__0_.o00. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.ooOo_0oo._0_. = A_1
		End Sub

		' Token: 0x06001F46 RID: 8006 RVA: 0x000CA0D0 File Offset: 0x000C82D0
		Public Sub New(A_0 As String, A_1 As DateGroupEnum, A_2 As String)
			Me.ooOo_0oo._0_. = 3
			Me.oo_00o.00_0_. = True
			Me.OO0__0_.o00. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.ooOo_0oo._0_. = A_1
			Me.oO0O.__o_OO_oo. = A_2
		End Sub

		' Token: 0x06001F47 RID: 8007 RVA: 0x000CA128 File Offset: 0x000C8328
		Public Sub New(A_0 As String, A_1 As DateGroupEnum, A_2 As String, A_3 As String)
			Me.ooOo_0oo._0_. = 3
			Me.oo_00o.00_0_. = True
			Me.OO0__0_.o00. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.ooOo_0oo._0_. = A_1
			Me.oO0O.__o_OO_oo. = A_2
			Me.OoO._0OO0O__. = A_3
		End Sub

		' Token: 0x1700070A RID: 1802
		' (get) Token: 0x06001F48 RID: 8008 RVA: 0x000CA186 File Offset: 0x000C8386
		' (set) Token: 0x06001F49 RID: 8009 RVA: 0x000CA18E File Offset: 0x000C838E
		Public Property Name As String
			Get
				Return Me.OO0__0_.o00.
			End Get
			Set(value As String)
				Me.OO0__0_.o00. = value.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			End Set
		End Property

		' Token: 0x1700070B RID: 1803
		' (get) Token: 0x06001F4A RID: 8010 RVA: 0x000CA1B8 File Offset: 0x000C83B8
		' (set) Token: 0x06001F4B RID: 8011 RVA: 0x000CA22D File Offset: 0x000C842D
		Public Property NewName As String
			Get
				Dim result As String
				If Operators.CompareString(Me.oO0O.__o_OO_oo., "", True) > 0 Then
					result = Me.oO0O.__o_OO_oo.
				ElseIf Me.OO0__0_.o00..IndexOf(".") > 0 Then
					result = Me.OO0__0_.o00..Split(New Char() { "."c })(1).Trim(New Char() { "["c, "]"c })
				Else
					result = Me.OO0__0_.o00.
				End If
				Return result
			End Get
			Set(value As String)
				Me.oO0O.__o_OO_oo. = value
			End Set
		End Property

		' Token: 0x1700070C RID: 1804
		' (get) Token: 0x06001F4C RID: 8012 RVA: 0x000CA238 File Offset: 0x000C8438
		Friend ReadOnly Property SourceName As String
			Get
				Dim result As String
				If Me.OO0__0_.o00..IndexOf(".") > 0 Then
					result = Me.OO0__0_.o00..Split(New Char() { "."c })(1).Trim(New Char() { "["c, "]"c })
				Else
					result = Me.OO0__0_.o00.
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700070D RID: 1805
		' (get) Token: 0x06001F4D RID: 8013 RVA: 0x000CA290 File Offset: 0x000C8490
		' (set) Token: 0x06001F4E RID: 8014 RVA: 0x000CA298 File Offset: 0x000C8498
		Public Property NewCaption As String
			Get
				Return Me.OoO._0OO0O__.
			End Get
			Set(value As String)
				Me.OoO._0OO0O__. = value
			End Set
		End Property

		' Token: 0x1700070E RID: 1806
		' (get) Token: 0x06001F4F RID: 8015 RVA: 0x000CA2A1 File Offset: 0x000C84A1
		' (set) Token: 0x06001F50 RID: 8016 RVA: 0x000CA2A9 File Offset: 0x000C84A9
		Public Property DateGroup As DateGroupEnum
			Get
				Return Me.ooOo_0oo._0_.
			End Get
			Set(value As DateGroupEnum)
				Me.ooOo_0oo._0_. = value
			End Set
		End Property

		' Token: 0x1700070F RID: 1807
		' (get) Token: 0x06001F51 RID: 8017 RVA: 0x000CA2B2 File Offset: 0x000C84B2
		' (set) Token: 0x06001F52 RID: 8018 RVA: 0x000CA2BA File Offset: 0x000C84BA
		Friend Property IsValid As Boolean
			Get
				Return Me.oo_00o.00_0_.
			End Get
			Set(value As Boolean)
				Me.oo_00o.00_0_. = value
			End Set
		End Property

		' Token: 0x17000710 RID: 1808
		' (get) Token: 0x06001F53 RID: 8019 RVA: 0x000CA2C3 File Offset: 0x000C84C3
		' (set) Token: 0x06001F54 RID: 8020 RVA: 0x000CA2CB File Offset: 0x000C84CB
		Friend Property IsDate As Boolean
			Get
				Return Me.o0.0_.
			End Get
			Set(value As Boolean)
				Me.o0.0_. = value
			End Set
		End Property

		' Token: 0x17000711 RID: 1809
		' (get) Token: 0x06001F55 RID: 8021 RVA: 0x000CA2D4 File Offset: 0x000C84D4
		' (set) Token: 0x06001F56 RID: 8022 RVA: 0x000CA2DC File Offset: 0x000C84DC
		Friend Property Pattern As String
			Get
				Return Me.OO._0__O.
			End Get
			Set(value As String)
				Me.OO._0__O. = value
			End Set
		End Property

		' Token: 0x17000712 RID: 1810
		' (get) Token: 0x06001F57 RID: 8023 RVA: 0x000CA2E5 File Offset: 0x000C84E5
		' (set) Token: 0x06001F58 RID: 8024 RVA: 0x000CA2ED File Offset: 0x000C84ED
		Friend Property Vertical As Boolean
			Get
				Return Me.OO0__0_.o00.
			End Get
			Set(value As Boolean)
				Me.OO0__0_.o00. = value
			End Set
		End Property

		' Token: 0x04000D04 RID: 3332
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D05 RID: 3333
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D06 RID: 3334
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D07 RID: 3335
		Private <<EMPTY_NAME>> As DateGroupEnum

		' Token: 0x04000D08 RID: 3336
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D09 RID: 3337
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D0A RID: 3338
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D0B RID: 3339
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D0C RID: 3340
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
