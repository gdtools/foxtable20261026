Imports System
Imports System.ComponentModel
Imports System.Net

Namespace Foxtable
	' Token: 0x020001B8 RID: 440
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class UDPClient_MessageReceived
		' Token: 0x0600148E RID: 5262 RVA: 0x00081334 File Offset: 0x0007F534
		Friend Sub New(A_0 As UDPClient, A_1 As UDPClient.OO00_)
			Me.OO.000O. = A_0
			Me.OO.000O. = A_1
		End Sub

		' Token: 0x1700045B RID: 1115
		' (get) Token: 0x0600148F RID: 5263 RVA: 0x0008134A File Offset: 0x0007F54A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property UDPclient As UDPClient
			Get
				Return Me.OO.000O.
			End Get
		End Property

		' Token: 0x1700045C RID: 1116
		' (get) Token: 0x06001490 RID: 5264 RVA: 0x00081352 File Offset: 0x0007F552
		Public ReadOnly Property Bytes As Byte()
			Get
				Return Me.OO.000O..O00ooo._.()
			End Get
		End Property

		' Token: 0x1700045D RID: 1117
		' (get) Token: 0x06001491 RID: 5265 RVA: 0x0008135F File Offset: 0x0007F55F
		Public ReadOnly Property Message As String
			Get
				Return Me.UDPclient.O00ooo._..GetString(Me.Bytes)
			End Get
		End Property

		' Token: 0x1700045E RID: 1118
		' (get) Token: 0x06001492 RID: 5266 RVA: 0x00081377 File Offset: 0x0007F577
		' (set) Token: 0x06001493 RID: 5267 RVA: 0x0008137F File Offset: 0x0007F57F
		Public Property ReturnValue As String
			Get
				Return Me.OO.000O.
			End Get
			Set(value As String)
				Me.OO.000O. = value
			End Set
		End Property

		' Token: 0x1700045F RID: 1119
		' (get) Token: 0x06001494 RID: 5268 RVA: 0x00081388 File Offset: 0x0007F588
		' (set) Token: 0x06001495 RID: 5269 RVA: 0x00081390 File Offset: 0x0007F590
		Public Property ReturnBytes As Byte()
			Get
				Return Me.OO.000O.
			End Get
			Set(value As Byte())
				Me.OO.000O. = value
			End Set
		End Property

		' Token: 0x17000460 RID: 1120
		' (get) Token: 0x06001496 RID: 5270 RVA: 0x00081399 File Offset: 0x0007F599
		Public ReadOnly Property IPEndpoint As IPEndPoint
			Get
				Return Me.OO.000O..O00ooo._.()
			End Get
		End Property

		' Token: 0x17000461 RID: 1121
		' (get) Token: 0x06001497 RID: 5271 RVA: 0x000813A6 File Offset: 0x0007F5A6
		Public ReadOnly Property IP As String
			Get
				Return Me.OO.000O..O00ooo._.().Address.ToString()
			End Get
		End Property

		' Token: 0x17000462 RID: 1122
		' (get) Token: 0x06001498 RID: 5272 RVA: 0x000813BD File Offset: 0x0007F5BD
		Public ReadOnly Property Port As Integer
			Get
				Return Me.OO.000O..O00ooo._.().Port
			End Get
		End Property

		' Token: 0x04000807 RID: 2055
		Private <<EMPTY_NAME>> As UDPClient

		' Token: 0x04000808 RID: 2056
		Private <<EMPTY_NAME>> As UDPClient.OO00_

		' Token: 0x04000809 RID: 2057
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400080A RID: 2058
		Private <<EMPTY_NAME>> As Byte()
	End Class
End Namespace
