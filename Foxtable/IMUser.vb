Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x020002DD RID: 733
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class IMUser
		' Token: 0x0600270A RID: 9994 RVA: 0x0010A973 File Offset: 0x00108B73
		Friend Sub New(A_0 As String, A_1 As IPEndPoint)
			Me.oO_0OO.0. = New List(Of String)()
			Me.OO__o_.O0_0O_0. = OoOo0O.OO_o.0o_O.(4)
			Me.o_.oOoo_0. = A_0
			Me.oO_0OO.0. = A_1
			Me.o_.oOoo_0. = DateTime.Now
		End Sub

		' Token: 0x170008B9 RID: 2233
		' (get) Token: 0x0600270B RID: 9995 RVA: 0x0010A9AB File Offset: 0x00108BAB
		Friend ReadOnly Property WanIP As IPEndPoint
			Get
				Return Me.oO_0OO.0.
			End Get
		End Property

		' Token: 0x170008BA RID: 2234
		' (get) Token: 0x0600270C RID: 9996 RVA: 0x0010A9B3 File Offset: 0x00108BB3
		' (set) Token: 0x0600270D RID: 9997 RVA: 0x0010A9BB File Offset: 0x00108BBB
		Friend Property LanIP As IPEndPoint
			Get
				Return Me.OO__o_.O0_0O_0.
			End Get
			Set(value As IPEndPoint)
				Me.OO__o_.O0_0O_0. = value
			End Set
		End Property

		' Token: 0x170008BB RID: 2235
		' (get) Token: 0x0600270E RID: 9998 RVA: 0x0010A9C4 File Offset: 0x00108BC4
		' (set) Token: 0x0600270F RID: 9999 RVA: 0x0010A9CC File Offset: 0x00108BCC
		Friend Property LastHeartbeatTime As DateTime
			Get
				Return Me.o_.oOoo_0.
			End Get
			Set(value As DateTime)
				Me.o_.oOoo_0. = value
			End Set
		End Property

		' Token: 0x170008BC RID: 2236
		' (get) Token: 0x06002710 RID: 10000 RVA: 0x0010A9D5 File Offset: 0x00108BD5
		Public ReadOnly Property Name As String
			Get
				Return Me.o_.oOoo_0.
			End Get
		End Property

		' Token: 0x170008BD RID: 2237
		' (get) Token: 0x06002711 RID: 10001 RVA: 0x0010A9DD File Offset: 0x00108BDD
		Friend ReadOnly Property Buddies As List(Of String)
			Get
				Return Me.oO_0OO.0.
			End Get
		End Property

		' Token: 0x170008BE RID: 2238
		' (get) Token: 0x06002712 RID: 10002 RVA: 0x0010A9E5 File Offset: 0x00108BE5
		Public ReadOnly Property WanIPAddress As String
			Get
				Return Me.WanIP.ToString()
			End Get
		End Property

		' Token: 0x170008BF RID: 2239
		' (get) Token: 0x06002713 RID: 10003 RVA: 0x0010A9F4 File Offset: 0x00108BF4
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

		' Token: 0x170008C0 RID: 2240
		' (get) Token: 0x06002714 RID: 10004 RVA: 0x0010AA1E File Offset: 0x00108C1E
		' (set) Token: 0x06002715 RID: 10005 RVA: 0x0010AA26 File Offset: 0x00108C26
		Public Property Tag As Object
			Get
				Return Me.o_.oOoo_0.
			End Get
			Set(value As Object)
				Me.o_.oOoo_0. = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x0400102D RID: 4141
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x0400102E RID: 4142
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x0400102F RID: 4143
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001030 RID: 4144
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001031 RID: 4145
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x04001032 RID: 4146
		Private <<EMPTY_NAME>> As Object

		' Token: 0x04001033 RID: 4147
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
