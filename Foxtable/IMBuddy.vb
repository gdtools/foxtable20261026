Imports System
Imports System.ComponentModel
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001BB RID: 443
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class IMBuddy
		' Token: 0x060014A6 RID: 5286 RVA: 0x0008154C File Offset: 0x0007F74C
		Friend Sub New(A_0 As String, A_1 As IPEndPoint, A_2 As String)
			Me.O.__0_0__0O0_o. = A_0
			Me.O.__0_0__0O0_o. = A_1
			Me.o.0__0o0OO_0oo. = A_2
			If Me.O.__0_0__0O0_o..IndexOf(".") > 0 Then
				Me.Oo_O___oO.__0. = Me.O.__0_0__0O0_o..Substring(0, Me.O.__0_0__0O0_o..IndexOf("."))
				Me.Oo__.0o. = Me.O.__0_0__0O0_o..Substring(Me.O.__0_0__0O0_o..IndexOf(".") + 1)
			End If
		End Sub

		' Token: 0x060014A7 RID: 5287 RVA: 0x000815CC File Offset: 0x0007F7CC
		Public Sub New(A_0 As String, A_1 As String)
			Me.Oo0__0O_00O.0o. = True
			Me.O.__0_0__0O0_o. = A_0
			If A_1.IndexOf(".") > 0 Then
				Me.Oo_O___oO.__0. = A_1.Substring(0, A_1.IndexOf("."))
				Me.Oo__.0o. = A_1.Substring(A_1.IndexOf(".") + 1)
				Return
			End If
			Me.Oo_O___oO.__0. = "微信用户"
			Me.Oo__.0o. = A_1
		End Sub

		' Token: 0x17000463 RID: 1123
		' (get) Token: 0x060014A8 RID: 5288 RVA: 0x0008163F File Offset: 0x0007F83F
		Public ReadOnly Property FromWeChat As Boolean
			Get
				Return Me.Oo0__0O_00O.0o.
			End Get
		End Property

		' Token: 0x17000464 RID: 1124
		' (get) Token: 0x060014A9 RID: 5289 RVA: 0x00081648 File Offset: 0x0007F848
		Public ReadOnly Property WeID As String
			Get
				Dim result As String
				If Me.FromWeChat Then
					result = Me.o.0__0o0OO_0oo.
				Else
					result = ""
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000465 RID: 1125
		' (get) Token: 0x060014AA RID: 5290 RVA: 0x0008166D File Offset: 0x0007F86D
		' (set) Token: 0x060014AB RID: 5291 RVA: 0x00081675 File Offset: 0x0007F875
		Friend Property WanIP As IPEndPoint
			Get
				Return Me.O.__0_0__0O0_o.
			End Get
			Set(value As IPEndPoint)
				Me.O.__0_0__0O0_o. = value
			End Set
		End Property

		' Token: 0x17000466 RID: 1126
		' (get) Token: 0x060014AC RID: 5292 RVA: 0x0008167E File Offset: 0x0007F87E
		' (set) Token: 0x060014AD RID: 5293 RVA: 0x00081686 File Offset: 0x0007F886
		Friend Property LanIP As IPEndPoint
			Get
				Return Me.o.0__0o0OO_0oo.
			End Get
			Set(value As IPEndPoint)
				Me.o.0__0o0OO_0oo. = value
			End Set
		End Property

		' Token: 0x17000467 RID: 1127
		' (get) Token: 0x060014AE RID: 5294 RVA: 0x0008168F File Offset: 0x0007F88F
		Public ReadOnly Property Name As String
			Get
				Return Me.O.__0_0__0O0_o.
			End Get
		End Property

		' Token: 0x17000468 RID: 1128
		' (get) Token: 0x060014AF RID: 5295 RVA: 0x00081698 File Offset: 0x0007F898
		' (set) Token: 0x060014B0 RID: 5296 RVA: 0x000816C9 File Offset: 0x0007F8C9
		Public Property SimpleName As String
			Get
				Dim result As String
				If Operators.CompareString(Me.Oo__.0o., "", True) = 0 Then
					result = Me.O.__0_0__0O0_o.
				Else
					result = Me.Oo__.0o.
				End If
				Return result
			End Get
			Friend Set(value As String)
				Me.Oo__.0o. = value
			End Set
		End Property

		' Token: 0x17000469 RID: 1129
		' (get) Token: 0x060014B1 RID: 5297 RVA: 0x000816D4 File Offset: 0x0007F8D4
		Public ReadOnly Property UserGroup As String
			Get
				Dim result As String
				If Operators.CompareString(Me.Oo_O___oO.__0., "", True) = 0 Then
					result = "未分组"
				Else
					result = Me.Oo_O___oO.__0.
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700046A RID: 1130
		' (get) Token: 0x060014B2 RID: 5298 RVA: 0x00081704 File Offset: 0x0007F904
		' (set) Token: 0x060014B3 RID: 5299 RVA: 0x00081716 File Offset: 0x0007F916
		Public Property OnLine As Boolean
			Get
				Return Me.O.__0_0__0O0_o. IsNot Nothing AndAlso Me.O.__0_0__0O0_o.
			End Get
			Friend Set(value As Boolean)
				If Not value Then
					Me.O.__0_0__0O0_o. = False
					Me.O.__0_0__0O0_o. = Nothing
					Me.o.0__0o0OO_0oo. = Nothing
					Me.oOo.o0__0Oo0oO. = 0
					Me.O00OO.o_. = 0
					Me.oO0.OooOOO00. = 0
					Me.O00OO.o_. = False
					Me.oO0.OooOOO00. = False
				End If
			End Set
		End Property

		' Token: 0x1700046B RID: 1131
		' (get) Token: 0x060014B4 RID: 5300 RVA: 0x00081753 File Offset: 0x0007F953
		' (set) Token: 0x060014B5 RID: 5301 RVA: 0x0008175B File Offset: 0x0007F95B
		Friend Property LastReceiveHeartbeatTime As DateTime
			Get
				Return Me.O.__0_0__0O0_o.
			End Get
			Set(value As DateTime)
				Me.O.__0_0__0O0_o. = value
			End Set
		End Property

		' Token: 0x1700046C RID: 1132
		' (get) Token: 0x060014B6 RID: 5302 RVA: 0x00081764 File Offset: 0x0007F964
		' (set) Token: 0x060014B7 RID: 5303 RVA: 0x0008176C File Offset: 0x0007F96C
		Friend Property RandKey As String
			Get
				Return Me.o.0__0o0OO_0oo.
			End Get
			Set(value As String)
				Me.o.0__0o0OO_0oo. = value
			End Set
		End Property

		' Token: 0x1700046D RID: 1133
		' (get) Token: 0x060014B8 RID: 5304 RVA: 0x00081775 File Offset: 0x0007F975
		' (set) Token: 0x060014B9 RID: 5305 RVA: 0x0008177D File Offset: 0x0007F97D
		Friend Property Ready As Boolean
			Get
				Return Me.O.__0_0__0O0_o.
			End Get
			Set(value As Boolean)
				Me.O.__0_0__0O0_o. = value
			End Set
		End Property

		' Token: 0x1700046E RID: 1134
		' (get) Token: 0x060014BA RID: 5306 RVA: 0x00081788 File Offset: 0x0007F988
		Public ReadOnly Property WanIPAddress As String
			Get
				Dim result As String
				If Me.WanIP IsNot Nothing Then
					result = Me.WanIP.ToString()
				Else
					result = "None"
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700046F RID: 1135
		' (get) Token: 0x060014BB RID: 5307 RVA: 0x000817B4 File Offset: 0x0007F9B4
		Public ReadOnly Property LanIPAddress As String
			Get
				Dim result As String
				If Me.LanIP IsNot Nothing Then
					result = Me.LanIP.ToString()
				Else
					result = "None"
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000470 RID: 1136
		' (get) Token: 0x060014BC RID: 5308 RVA: 0x000817DE File Offset: 0x0007F9DE
		' (set) Token: 0x060014BD RID: 5309 RVA: 0x000817E6 File Offset: 0x0007F9E6
		Public Property Tag As Object
			Get
				Return Me.O.__0_0__0O0_o.
			End Get
			Set(value As Object)
				Me.O.__0_0__0O0_o. = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17000471 RID: 1137
		' (get) Token: 0x060014BE RID: 5310 RVA: 0x000817F4 File Offset: 0x0007F9F4
		Public ReadOnly Property p2p As Boolean
			Get
				Return Me.oOo.o0__0Oo0oO. > 0 AndAlso Me.O00OO.o_. > 0
			End Get
		End Property

		' Token: 0x04000818 RID: 2072
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x04000819 RID: 2073
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x0400081A RID: 2074
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400081B RID: 2075
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x0400081C RID: 2076
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x0400081D RID: 2077
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x0400081E RID: 2078
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x0400081F RID: 2079
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000820 RID: 2080
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000821 RID: 2081
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000822 RID: 2082
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000823 RID: 2083
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000824 RID: 2084
		Friend <<EMPTY_NAME>> As DateTime

		' Token: 0x04000825 RID: 2085
		Private <<EMPTY_NAME>> As Object

		' Token: 0x04000826 RID: 2086
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000827 RID: 2087
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000828 RID: 2088
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04000829 RID: 2089
		Friend <<EMPTY_NAME>> As DateTime

		' Token: 0x0400082A RID: 2090
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
