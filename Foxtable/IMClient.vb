Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001C9 RID: 457
	<oO0oooo("2987")>
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class IMClient
		' Token: 0x0600151D RID: 5405 RVA: 0x00088388 File Offset: 0x00086588
		Friend Sub New(A_0 As String)
			Me.o_00o.O. = True
			Me.ooOo.oO0. = New ReaderWriterLock()
			Me.O0_OOo.O. = True
			Me.ooOo.oO0. = New Queue(Of oO__oO_0_O)()
			Me.oOO0O.O0O0. = New IMBuddyCollections()
			Me.StopHeartbratServer = False
			Me.StopHeartbratBuddy = False
			Me.Oo0__0.ooO0__o. = -1
			Me.O0Oo0OO.O. = 5
			Me.O.o0OOOO_. = 81920
			Me.O.OOo0_Oooo. = 81920
			Me.OoOoo._. = True
			Me.oo.___oo__0_O. = New Dictionary(Of String, ooo0)()
			Me.oo.___oo__0_O. = New Dictionary(Of String, O_0OOOoO)()
			Me.ooOooo.oO. = New Dictionary(Of String, ooOoO)()
			Me.ooOooo.oO. = New Dictionary(Of String, O_0__O_o_O)()
			Me.O0_OOo.O. = New Dictionary(Of String, O_0__O_o_O)()
			Me.O00.O0. = New List(Of Object)()
			Me.ooOooo.oO. = New List(Of Integer)()
			Me.oo.___oo__0_O. = RuntimeHelpers.GetObjectValue(New Object())
			Me.oOO0_O.O__0_0. = New List(Of Integer)()
			Me.ooOo.oO0. = New Dictionary(Of Integer, O0o000)()
			Me.oo.___oo__0_O. = New Dictionary(Of String, DateTime)()
			Me.o00_.0o0. = True
			Me.O00._Oo. = New Dictionary(Of String, DateTime)()
			Me.O00.O0. = New Dictionary(Of String, String)()
			Me.OO.0o0OoooO. = A_0
		End Sub

		' Token: 0x1700047F RID: 1151
		' (get) Token: 0x0600151E RID: 5406 RVA: 0x000884A5 File Offset: 0x000866A5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Name As String
			Get
				Return Me.OO.0o0OoooO.
			End Get
		End Property

		' Token: 0x17000480 RID: 1152
		' (get) Token: 0x0600151F RID: 5407 RVA: 0x000884AD File Offset: 0x000866AD
		Public ReadOnly Property Buddies As IMBuddyCollections
			Get
				Return Me.oOO0O.O0O0.
			End Get
		End Property

		' Token: 0x17000481 RID: 1153
		' (get) Token: 0x06001520 RID: 5408 RVA: 0x000884B5 File Offset: 0x000866B5
		' (set) Token: 0x06001521 RID: 5409 RVA: 0x000884BD File Offset: 0x000866BD
		Public Property ServerIP As String
			Get
				Return Me.Oooo0O.0__OO__.
			End Get
			Set(value As String)
				Me.Oooo0O.0__OO__. = value
			End Set
		End Property

		' Token: 0x17000482 RID: 1154
		' (get) Token: 0x06001522 RID: 5410 RVA: 0x000884C6 File Offset: 0x000866C6
		' (set) Token: 0x06001523 RID: 5411 RVA: 0x000884CE File Offset: 0x000866CE
		Public Property ServerPort As Integer
			Get
				Return Me.o_00o.O.
			End Get
			Set(value As Integer)
				Me.o_00o.O. = value
			End Set
		End Property

		' Token: 0x17000483 RID: 1155
		' (get) Token: 0x06001524 RID: 5412 RVA: 0x000884D7 File Offset: 0x000866D7
		Public ReadOnly Property ServerMessage As String
			Get
				Return Me.oOOooo_._O.
			End Get
		End Property

		' Token: 0x17000484 RID: 1156
		' (get) Token: 0x06001525 RID: 5413 RVA: 0x000884DF File Offset: 0x000866DF
		' (set) Token: 0x06001526 RID: 5414 RVA: 0x000884E7 File Offset: 0x000866E7
		Friend Property Heartbeat As Boolean
			Get
				Return Me.o_00o.O.
			End Get
			Set(value As Boolean)
				Me.o_00o.O. = value
			End Set
		End Property

		' Token: 0x17000485 RID: 1157
		' (get) Token: 0x06001527 RID: 5415 RVA: 0x000884F0 File Offset: 0x000866F0
		' (set) Token: 0x06001528 RID: 5416 RVA: 0x000884F8 File Offset: 0x000866F8
		Friend Property HeartbeatInterval As Integer
			Get
				Return Me.oO_0.0O_o.
			End Get
			Set(value As Integer)
				If value < 5 Then
					value = 5
				End If
				Me.oO_0.0O_o. = value
			End Set
		End Property

		' Token: 0x17000486 RID: 1158
		' (get) Token: 0x06001529 RID: 5417 RVA: 0x00088508 File Offset: 0x00086708
		' (set) Token: 0x0600152A RID: 5418 RVA: 0x00088510 File Offset: 0x00086710
		Friend Property HeartbeatTimeout As Integer
			Get
				Return Me.O_00O_000.O0_.
			End Get
			Set(value As Integer)
				If value < 10 Then
					value = 10
				End If
				Me.O_00O_000.O0_. = value
			End Set
		End Property

		' Token: 0x17000487 RID: 1159
		' (get) Token: 0x0600152B RID: 5419 RVA: 0x00088522 File Offset: 0x00086722
		' (set) Token: 0x0600152C RID: 5420 RVA: 0x0008852A File Offset: 0x0008672A
		Friend Property LastReceiveHeartbeatTime As DateTime
			Get
				Return Me.oOOOo0.oo0OoO0.
			End Get
			Set(value As DateTime)
				Me.oOOOo0.oo0OoO0. = value
			End Set
		End Property

		' Token: 0x17000488 RID: 1160
		' (get) Token: 0x0600152D RID: 5421 RVA: 0x00088533 File Offset: 0x00086733
		' (set) Token: 0x0600152E RID: 5422 RVA: 0x0008853B File Offset: 0x0008673B
		Public Property UserName As String
			Get
				Return Me.o_00o.O.
			End Get
			Set(value As String)
				Me.o_00o.O. = value
			End Set
		End Property

		' Token: 0x17000489 RID: 1161
		' (get) Token: 0x0600152F RID: 5423 RVA: 0x00088544 File Offset: 0x00086744
		' (set) Token: 0x06001530 RID: 5424 RVA: 0x0008854C File Offset: 0x0008674C
		Public Property Password As String
			Get
				Return Me.oo00000_0o0.oO.
			End Get
			Set(value As String)
				Me.oo00000_0o0.oO. = value
			End Set
		End Property

		' Token: 0x1700048A RID: 1162
		' (get) Token: 0x06001531 RID: 5425 RVA: 0x00088555 File Offset: 0x00086755
		' (set) Token: 0x06001532 RID: 5426 RVA: 0x0008855D File Offset: 0x0008675D
		Friend Property WanIP As IPEndPoint
			Get
				Return Me.OO.OO_oO_0_0.
			End Get
			Set(value As IPEndPoint)
				Me.OO.OO_oO_0_0. = value
			End Set
		End Property

		' Token: 0x1700048B RID: 1163
		' (get) Token: 0x06001533 RID: 5427 RVA: 0x00088566 File Offset: 0x00086766
		' (set) Token: 0x06001534 RID: 5428 RVA: 0x0008856E File Offset: 0x0008676E
		Public Property Ready As Boolean
			Get
				Return Me.oo.o_.
			End Get
			Private Set(value As Boolean)
				Me.oo.o_. = value
			End Set
		End Property

		' Token: 0x1700048C RID: 1164
		' (get) Token: 0x06001535 RID: 5429 RVA: 0x00088577 File Offset: 0x00086777
		' (set) Token: 0x06001536 RID: 5430 RVA: 0x0008857F File Offset: 0x0008677F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ReceiveBufferSize As Integer
			Get
				Return Me.O.o0OOOO_.
			End Get
			Set(value As Integer)
				Me.O.o0OOOO_. = value
			End Set
		End Property

		' Token: 0x1700048D RID: 1165
		' (get) Token: 0x06001537 RID: 5431 RVA: 0x00088588 File Offset: 0x00086788
		' (set) Token: 0x06001538 RID: 5432 RVA: 0x00088590 File Offset: 0x00086790
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SendBufferSize As Integer
			Get
				Return Me.O.OOo0_Oooo.
			End Get
			Set(value As Integer)
				Me.O.OOo0_Oooo. = value
			End Set
		End Property

		' Token: 0x1700048E RID: 1166
		' (get) Token: 0x06001539 RID: 5433 RVA: 0x0008859C File Offset: 0x0008679C
		' (set) Token: 0x0600153A RID: 5434 RVA: 0x000885D7 File Offset: 0x000867D7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property DataFile As String
			Get
				Dim result As String
				If Operators.CompareString(Me.Oo00_0._0O_., "", True) = 0 Then
					result = Me.UserName + ".mdb"
				Else
					result = Me.Oo00_0._0O_.
				End If
				Return result
			End Get
			Set(value As String)
				Me.Oo00_0._0O_. = value
			End Set
		End Property

		' Token: 0x1700048F RID: 1167
		' (get) Token: 0x0600153B RID: 5435 RVA: 0x000885E0 File Offset: 0x000867E0
		' (set) Token: 0x0600153C RID: 5436 RVA: 0x000885E8 File Offset: 0x000867E8
		Public Property ThroughServer As Boolean
			Get
				Return Me.O.o0OOOO_.
			End Get
			Set(value As Boolean)
				Me.O.o0OOOO_. = value
			End Set
		End Property

		' Token: 0x17000490 RID: 1168
		' (get) Token: 0x0600153D RID: 5437 RVA: 0x000885F1 File Offset: 0x000867F1
		' (set) Token: 0x0600153E RID: 5438 RVA: 0x000885F9 File Offset: 0x000867F9
		Public Property AllowSendFile As Boolean
			Get
				Return Me.OoOoo._.
			End Get
			Set(value As Boolean)
				Me.OoOoo._. = value
			End Set
		End Property

		' Token: 0x17000491 RID: 1169
		' (get) Token: 0x0600153F RID: 5439 RVA: 0x00088602 File Offset: 0x00086802
		' (set) Token: 0x06001540 RID: 5440 RVA: 0x0008860A File Offset: 0x0008680A
		Public Property ReceiveNotice As Boolean
			Get
				Return Me.o00_.0o0.
			End Get
			Set(value As Boolean)
				Me.o00_.0o0. = value
			End Set
		End Property

		' Token: 0x06001541 RID: 5441 RVA: 0x00088613 File Offset: 0x00086813
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ClearWeChatUsers()
			Me.O00.O0..Clear()
		End Sub

		' Token: 0x06001542 RID: 5442 RVA: 0x00088620 File Offset: 0x00086820
		Public Function Start(Optional Timeout As Integer = 5) As Boolean
			Dim result As Boolean
			If Me.ooOo.oO0. IsNot Nothing Then
				MessageBox.Show("此IMClient已经启动，请先停止，才能重新启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf Me.o_00o.O. = 0 OrElse Operators.CompareString(Me.Oooo0O.0__OO__., "", True) = 0 Then
				MessageBox.Show("必须指定服务器的IP地址和端口号,才能启动IMClient!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				Dim flag As Boolean
				If Operators.CompareString(Me.UserName, "", True) = 0 AndAlso Operators.CompareString(Me.Password, "", True) = 0 Then
					If Operators.CompareString(OO_00oOO.User.Group, "", True) > 0 Then
						Me.UserName = OO_00oOO.User.Group + "." + OO_00oOO.User.Name
					Else
						Me.UserName = OO_00oOO.User.Name
					End If
					Me.Password = OO_00oOO.User.Password
					flag = True
				End If
				Me.Oo0__0.ooO0__o. = -1
				Me.Buddies.OOO__.0.()
				Me.o_oo0Oooo.OOO_. = OoOo0O.OO_o.0o_O.(4)
				If Timeout <> 5 Then
					Timeout = Math.Max(1, Timeout)
					Me.O0Oo0OO.O. = Timeout
				End If
				Try
					Dim array As String() = Me.Oooo0O.0__OO__..Split(New Char() { "."c })
					If array.Length = 4 AndAlso Versioned.IsNumeric(array(0)) AndAlso Versioned.IsNumeric(array(1)) AndAlso Versioned.IsNumeric(array(2)) AndAlso Versioned.IsNumeric(array(3)) Then
						Me.ooOo.oO0. = New IPEndPoint(IPAddress.Parse(Me.Oooo0O.0__OO__.), Me.o_00o.O.)
					Else
						For Each ipaddress As IPAddress In Dns.GetHostEntry(Me.Oooo0O.0__OO__.).AddressList
							If ipaddress.AddressFamily = AddressFamily.InterNetwork Then
								Me.ooOo.oO0. = New IPEndPoint(ipaddress, Me.o_00o.O.)
								Exit For
							End If
						Next
					End If
					If Me.ooOo.oO0. Is Nothing Then
						MessageBox.Show("IMserver服务器地址无效", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						result = False
					Else
						Me.ooOo.oO0. = New UdpClient(0)
						Me.O00._Oo. = New UdpClient(0)
						Me.ooOo.oO0..Client.ReceiveBufferSize = Me.ReceiveBufferSize
						Me.ooOo.oO0..Client.SendBufferSize = Me.SendBufferSize
						Me.O00._Oo..Client.ReceiveBufferSize = 81920
						o0___oO.O.oOo0O0O.(Me.ooOo.oO0.)
						o0___oO.O.oOo0O0O.(Me.O00._Oo.)
						Dim text As String
						If flag Then
							text = String.Concat(New String() { "@1" & vbVerticalTab, Me.o_00o.O., vbVerticalTab, Me.oo00000_0o0.oO., vbVerticalTab, Me.o_oo0Oooo.OOO_., vbVerticalTab })
						Else
							text = String.Concat(New String() { "@" & vbVerticalTab, Me.o_00o.O., vbVerticalTab, Me.oo00000_0o0.oO., vbVerticalTab, Me.o_oo0Oooo.OOO_., vbVerticalTab })
						End If
						Dim text2 As String = o0___oO.o0__.0.()
						If Operators.CompareString(text2, "", True) > 0 Then
							Dim text3 As String = Me.ooOo.oO0..Client.LocalEndPoint.ToString()
							text3 = text3.Substring(text3.IndexOf(":") + 1)
							text = text + text2 + ":" + text3
						Else
							text += "None"
						End If
						Me.O.00O0_O_o_oO.(Me.ooOo.oO0., text)
						Dim now As DateTime = DateTime.Now
						While DateTime.Compare(DateTime.Now, now.AddSeconds(CDbl(Timeout))) < 0
							If Me.ooOo.oO0..Available > 0 Then
								Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
								Dim bytes As Byte() = Me.ooOo.oO0..Receive(ipendPoint)
								Dim [string] As String = Encoding.Unicode.GetString(bytes)
								Dim array2 As String() = [string].Split(New Char() { vbVerticalTab })
								If array2.Length = 7 AndAlso Operators.CompareString(array2(0), Me.o_00o.O., True) = 0 Then
									Me.O0_OOo.O. = False
									Me.oOOooo_._O. = array2(1)
									If Operators.CompareString(array2(2), "1", True) = 0 Then
										Me.Heartbeat = True
									Else
										Me.Heartbeat = False
									End If
									Me.HeartbeatInterval = Conversions.ToInteger(array2(3))
									Me.HeartbeatTimeout = Conversions.ToInteger(array2(4))
									Me.LastReceiveHeartbeatTime = DateTime.Now
									Me.Oo0__0.ooO0__o. = False
									Me.O0O.Oo_. = False
									Me.WanIP = o0___oO.o0__.0.(array2(5))
									Me.Oo0__0.ooO0__o. = Conversions.ToInteger(array2(6))
									Me.o0oo.Oo_o.()
									Me.Oooo_OoO._OO.()
									Me.O.00O0_O_o_oO.(Timeout, Me.Oo0__0.ooO0__o.)
									If Me.Heartbeat Then
										Me.ooOo.oO0. = AddressOf Me.o00O0._0O.
									End If
									Me.oo.o_. = True
									text = "+@" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
									Me.O.00O0_O_o_oO.(Me.ooOo.oO0., text)
									Me.O00._Oo. = DateTime.Now
									Me.o_oo0.O0Oo__oO. = False
									Dim client_UserEventArgs As Client_UserEventArgs = New Client_UserEventArgs(Me)
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Connected", New Object() { client_UserEventArgs }, True, "项目", False)
									If Me.UnreadCount > 0 AndAlso OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg2.wav") Then
										OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg2.wav", AudioPlayMode.Background)
									End If
									Return True
								End If
								If Me.ooOo.oO0. IsNot Nothing AndAlso Me.ooOo.oO0. IsNot Nothing Then
									text = "-@" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
									Me.O.00O0_O_o_oO.(Me.ooOo.oO0., text)
								End If
								Me.oo.o_. = False
								Me.O0_OOo.O. = True
								Me.Buddies.OOO__.0.()
								If Me.ooOo.oO0. IsNot Nothing Then
									Me.ooOo.oO0..Close()
									Me.ooOo.oO0. = Nothing
								End If
								If Me.O00._Oo. IsNot Nothing Then
									Me.O00._Oo..Close()
									Me.O00._Oo. = Nothing
								End If
								If Me.ooOo.oO0. IsNot Nothing Then
									Me.ooOo.oO0..Dispose()
									Me.ooOo.oO0. = Nothing
								End If
								Me.ooOo.oO0. = Nothing
								Me.oOOooo_._O. = [string]
								Return False
							End If
						End While
						Me.oOOooo_._O. = "规定时间内未获服务器响应!"
						Me.O_0O0o.__O_.()
						result = False
					End If
				Catch a_ As Exception
					Me.O_0O0o.__O_.()
					ooO.oOo0Oo.o.(a_, "启动IMClient")
				End Try
			End If
			Return result
		End Function

		' Token: 0x06001543 RID: 5443 RVA: 0x00088CA4 File Offset: 0x00086EA4
		Private Sub <<EMPTY_NAME>>()
			If Me.ooOo.oO0. IsNot Nothing AndAlso Me.ooOo.oO0. IsNot Nothing Then
				Dim a_ As String = "-@" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
				Me.O.00O0_O_o_oO.(Me.ooOo.oO0., a_)
			End If
			Me.Buddies.OOO__.0.()
			Me.oo.o_. = False
			Me.O0_OOo.O. = True
			If Me.ooOo.oO0. IsNot Nothing Then
				Me.ooOo.oO0..Close()
				Me.ooOo.oO0. = Nothing
			End If
			If Me.O00._Oo. IsNot Nothing Then
				Me.O00._Oo..Close()
				Me.O00._Oo. = Nothing
			End If
			If Me.ooOo.oO0. IsNot Nothing Then
				Me.ooOo.oO0..Dispose()
				Me.ooOo.oO0. = Nothing
			End If
			Me.ooOo.oO0. = Nothing
		End Sub

		' Token: 0x06001544 RID: 5444 RVA: 0x00088D58 File Offset: 0x00086F58
		Public Sub [Stop]()
			If Not Me.O0_OOo.O. Then
				If Me.ooOooo.oO. IsNot Nothing Then
					Me.ooOooo.oO..Close()
					Me.ooOooo.oO. = Nothing
				End If
				Dim client_LogoutEventArgs As Client_LogoutEventArgs = New Client_LogoutEventArgs(Me, 1)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", New Object() { client_LogoutEventArgs }, True, "项目", False)
				Dim text As String = "!1" & vbVerticalTab + Me.o_00o.O. + vbVerticalTab + Me.o_oo0Oooo.OOO_.
				Dim bytes As Byte() = Encoding.Unicode.GetBytes(text)
				Me.ooOo.oO0..Send(bytes, bytes.Length, Me.ooOo.oO0.)
				Try
					For Each imbuddy As IMBuddy In Me.Buddies
						Me.O.00O0_O_o_oO.(imbuddy.Name, text)
					Next
				Finally
					Dim enumerator As IEnumerator(Of IMBuddy)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Me.dispose()
			End If
		End Sub

		' Token: 0x06001545 RID: 5445 RVA: 0x00088E40 File Offset: 0x00087040
		Public Sub dispose()
			If Me.ooOo.oO0. IsNot Nothing Then
				If Me.ooOooo.oO. IsNot Nothing Then
					Me.ooOooo.oO..Close()
					Me.ooOooo.oO. = Nothing
				End If
				Me.oo.o_. = False
				Me.O0_OOo.O. = True
				Me.ooOo.oO0..AcquireWriterLock(-1)
				Dim ex As Exception = Nothing
				Try
					If Me.ooOo.oO0. IsNot Nothing Then
						Me.ooOo.oO0..Dispose()
						Me.ooOo.oO0. = Nothing
					End If
					Dim obj As Object = Me.ooOo.oO0.
					SyncLock obj
						Me.ooOo.oO0..Clear()
					End SyncLock
					Me.Buddies.OOO__.0.()
					Me.oo.___oo__0_O..Clear()
					Me.oo.___oo__0_O..Clear()
					Me.ooOo.oO0. = Nothing
					Me.ooOo.oO0..Close()
					Me.ooOo.oO0. = Nothing
					Me.O00._Oo..Close()
					Me.O00._Oo. = Nothing
					Me.oOO0O.O0O0..Close()
					Me.oOOOo0.oo0OoO0. = Nothing
					Me.oOO0O.O0O0. = Nothing
					If Me.oOOOo0.oo0OoO0. IsNot Nothing Then
						Me.oOOOo0.oo0OoO0..Clear()
						Me.oOOOo0.oo0OoO0. = Nothing
					End If
				Catch ex2 As Exception
					ex = ex2
				Finally
					Me.ooOo.oO0..ReleaseWriterLock()
				End Try
				If ex IsNot Nothing Then
					ooO.oOo0Oo.o.(ex, "关闭IMClient")
				End If
			End If
		End Sub

		' Token: 0x06001546 RID: 5446 RVA: 0x00088FA4 File Offset: 0x000871A4
		Private Sub <<EMPTY_NAME>>()
			Dim ex As Exception = Nothing
			Me.ooOo.oO0..AcquireReaderLock(-1)
			Try
				Me.ooOo.oO0..BeginReceive(AddressOf Me.O.00O0_O_o_oO., Nothing)
			Catch ex2 As Exception
				ex = ex2
			Finally
				Me.ooOo.oO0..ReleaseReaderLock()
			End Try
			If ex IsNot Nothing Then
				Me.[Stop]()
				ooO.oOo0Oo.o.(ex, "IMClient异步接收")
			End If
		End Sub

		' Token: 0x06001547 RID: 5447 RVA: 0x00089028 File Offset: 0x00087228
		Private Sub <<EMPTY_NAME>>(A_0 As IAsyncResult)
			If Not Me.O0_OOo.O. Then
				Dim ex As Exception = Nothing
				Me.ooOo.oO0..AcquireReaderLock(-1)
				Try
					Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim array As Byte() = Me.ooOo.oO0..EndReceive(A_0, ipendPoint)
					Dim text As String = Encoding.Unicode.GetString(array)
					If Operators.CompareString(text, "", True) > 0 Then
						If text.StartsWith("#" & vbVerticalTab) Then
							Dim array2 As String() = text.Split(New Char() { vbVerticalTab })
							If Operators.CompareString(array2(1), Me.UserName, True) = 0 AndAlso Operators.CompareString(array2(2), Me.o_oo0Oooo.OOO_., True) = 0 Then
								Me.LastReceiveHeartbeatTime = DateTime.Now
								Me.Oo0__0.ooO0__o. = False
								Me.O0O.Oo_. = False
							ElseIf Me.Buddies.Contains(array2(1)) AndAlso Operators.CompareString(Me.Buddies(array2(1)).RandKey, array2(2), True) = 0 Then
								If Me.Buddies(array2(1)).oOo.o0__0Oo0oO. = 0 Then
									Me.Buddies(array2(1)).oOo.o0__0Oo0oO. = Me.Buddies(array2(1)).oOo.o0__0Oo0oO. + 1
									text = "#" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
									array = Encoding.Unicode.GetBytes(text)
									Me.ooOo.oO0..Send(array, array.Length, ipendPoint)
									Me.Buddies(array2(1)).WanIP = ipendPoint
									text = "##" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
									array = Encoding.Unicode.GetBytes(text)
									Me.ooOo.oO0..Send(array, array.Length, ipendPoint)
								End If
								Me.Buddies(array2(1)).LastReceiveHeartbeatTime = DateTime.Now
							End If
						ElseIf text.StartsWith("#1" & vbVerticalTab) Then
							Dim array3 As String() = text.Split(New Char() { vbVerticalTab })
							If Me.Buddies.Contains(array3(1)) AndAlso Operators.CompareString(Me.Buddies(array3(1)).RandKey, array3(2), True) = 0 Then
								Me.Buddies(array3(1)).oOo.o0__0Oo0oO. = Me.Buddies(array3(1)).oOo.o0__0Oo0oO. + 1
								Me.Buddies(array3(1)).WanIP = ipendPoint
								Me.Buddies(array3(1)).LastReceiveHeartbeatTime = DateTime.Now
								text = "##" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
								array = Encoding.Unicode.GetBytes(text)
								Me.ooOo.oO0..Send(array, array.Length, ipendPoint)
							End If
							text = "#" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
							array = Encoding.Unicode.GetBytes(text)
							Me.ooOo.oO0..Send(array, array.Length, ipendPoint)
						ElseIf text.StartsWith("##" & vbVerticalTab) Then
							Dim array4 As String() = text.Split(New Char() { vbVerticalTab })
							If Me.Buddies.Contains(array4(1)) AndAlso Operators.CompareString(Me.Buddies(array4(1)).RandKey, array4(2), True) = 0 Then
								Me.Buddies(array4(1)).O00OO.o_. = Me.Buddies(array4(1)).O00OO.o_. + 1
							End If
						ElseIf text.StartsWith("###" & vbVerticalTab) Then
							Dim array5 As String() = text.Split(New Char() { vbVerticalTab })
							If Me.Buddies.Contains(array5(1)) AndAlso Operators.CompareString(Me.Buddies(array5(1)).RandKey, array5(2), True) = 0 Then
								text = "##" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
								array = Encoding.Unicode.GetBytes(text)
								Me.ooOo.oO0..Send(array, array.Length, ipendPoint)
							End If
						ElseIf text.StartsWith("%1" & vbVerticalTab) Then
							Dim array6 As String() = text.Split(New Char() { vbVerticalTab })
							If Me.Buddies.Contains(array6(1)) AndAlso Me.Buddies(array6(1)).OnLine AndAlso array6.Length = 7 Then
								Dim text2 As String = vbVerticalTab
								Dim ipendPoint2 As IPEndPoint = New IPEndPoint(Me.Buddies(array6(1)).WanIP.Address, Conversions.ToInteger(array6(4)))
								Dim udpClient As UdpClient = New UdpClient(0)
								o0___oO.O.oOo0O0O.(udpClient)
								udpClient.Client.ReceiveBufferSize = 81920
								text = "Ping"
								array = Encoding.Unicode.GetBytes(text)
								udpClient.Send(array, array.Length, ipendPoint2)
								Dim text3 As String = udpClient.Client.LocalEndPoint.ToString()
								text3 = text3.Substring(text3.IndexOf(":") + 1)
								text = String.Concat(New String() { "%1", text2, array6(1), text2, text3, text2, array6(5) })
								array = Encoding.Unicode.GetBytes(text)
								Me.O.00O0_O_o_oO.(ipendPoint, text)
								Dim ooOoO As ooOoO = New ooOoO(Me, udpClient, ipendPoint2, array6(2), array6(1), array6(6), CType(Conversions.ToInteger(array6(3)), SendTypeEnum))
								Dim obj As Object = Me.ooOooo.oO.
								SyncLock obj
									Me.ooOooo.oO..Add(ooOoO.o0OO._0.(), ooOoO)
								End SyncLock
								AddressOf ooOoO.O_OOOooo_0.O..Start()
							End If
						ElseIf text.StartsWith("%2" & vbVerticalTab) Then
							Dim array7 As String() = text.Split(New Char() { vbVerticalTab })
							If array7.Length = 6 AndAlso Me.Buddies.Contains(array7(1)) Then
								Dim udpClient2 As UdpClient = New UdpClient(0)
								o0___oO.O.oOo0O0O.(udpClient2)
								udpClient2.Client.ReceiveBufferSize = 81920
								Dim ipString As String = array7(4).Substring(0, array7(4).IndexOf(":"))
								Dim value As String = array7(4).Substring(array7(4).IndexOf(":") + 1)
								Dim ipendPoint3 As IPEndPoint = New IPEndPoint(IPAddress.Parse(ipString), Conversions.ToInteger(value))
								array = Encoding.Unicode.GetBytes("Ping")
								udpClient2.Send(array, array.Length, ipendPoint3)
								text = "%2" & vbVerticalTab + array7(1) + vbVerticalTab + array7(4)
								array = Encoding.Unicode.GetBytes(text)
								udpClient2.Send(array, array.Length, Me.ooOo.oO0.)
								Dim ooOoO2 As ooOoO = New ooOoO(Me, udpClient2, ipendPoint3, array7(2), array7(1), array7(5), CType(Conversions.ToInteger(array7(3)), SendTypeEnum))
								Dim obj2 As Object = Me.ooOooo.oO.
								SyncLock obj2
									Me.ooOooo.oO..Add(ooOoO2.o0OO._0.(), ooOoO2)
								End SyncLock
								AddressOf ooOoO2.O_OOOooo_0.O..Start()
							End If
						ElseIf text.StartsWith("%8" & vbVerticalTab) Then
							Dim array8 As String() = text.Split(New Char() { vbVerticalTab })
							If array8.Length = 3 Then
								Dim udpClient3 As UdpClient = New UdpClient(0)
								o0___oO.O.oOo0O0O.(udpClient3)
								udpClient3.Client.ReceiveBufferSize = 81920
								Dim port As Integer = Conversions.ToInteger(array8(1))
								Dim ipendPoint4 As IPEndPoint = New IPEndPoint(Me.ooOo.oO0..Address, port)
								array = Encoding.Unicode.GetBytes("Ping")
								udpClient3.Send(array, array.Length, ipendPoint4)
								Dim ooOoO3 As ooOoO = New ooOoO(Me, udpClient3, ipendPoint4, array8(2), Nothing, OoOo0O.OO_o.0o_O.(8), SendTypeEnum.AutoFile)
								If Me.O00._Oo..ContainsKey(array8(2).ToLower()) AndAlso (DateTime.Now - Me.O00._Oo.(array8(2).ToLower())).TotalSeconds < 10.0 AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
									OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oOO0O.O0O0., New Object() { Nothing, array8(2), ooOoO3 })
								End If
								Dim obj3 As Object = Me.ooOooo.oO.
								SyncLock obj3
									Me.ooOooo.oO..Add(ooOoO3.o0OO._0.(), ooOoO3)
								End SyncLock
								AddressOf ooOoO3.O_OOOooo_0.O..Start()
							End If
						ElseIf text.StartsWith("%10" & vbVerticalTab) Then
							Dim array9 As String() = text.Split(New Char() { vbVerticalTab })
							If array9.Length = 5 AndAlso Me.Buddies.Contains(array9(1)) AndAlso Operators.CompareString(ipendPoint.ToString(), Me.ooOo.oO0..ToString(), True) = 0 Then
								Dim udpClient4 As UdpClient = New UdpClient(0)
								o0___oO.O.oOo0O0O.(udpClient4)
								udpClient4.Client.ReceiveBufferSize = 81920
								Dim port2 As Integer = Conversions.ToInteger(array9(3))
								Dim ipendPoint5 As IPEndPoint = New IPEndPoint(Me.ooOo.oO0..Address, port2)
								array = Encoding.Unicode.GetBytes("Ping")
								udpClient4.Send(array, array.Length, ipendPoint5)
								Dim ooOoO4 As ooOoO = New ooOoO(Me, udpClient4, ipendPoint5, array9(2), array9(1), array9(4), SendTypeEnum.AutoFile)
								Dim obj4 As Object = Me.ooOooo.oO.
								SyncLock obj4
									Me.ooOooo.oO..Add(ooOoO4.o0OO._0.(), ooOoO4)
								End SyncLock
								AddressOf ooOoO4.O_OOOooo_0.O..Start()
							End If
						Else
							Dim obj5 As Object = Me.ooOo.oO0.
							SyncLock obj5
								Me.ooOo.oO0..Enqueue(New oO__oO_0_O(ipendPoint, text))
							End SyncLock
						End If
					End If
				Catch ex2 As Exception
					ex = ex2
				Finally
					Me.ooOo.oO0..ReleaseReaderLock()
				End Try
				If ex Is Nothing Then
					If Not Me.O0_OOo.O. Then
						Me.o0oo.Oo_o.()
						Return
					End If
				Else
					ooO.oOo0Oo.o.(ex, "IMClient异步接收回调过程")
				End If
			End If
		End Sub

		' Token: 0x06001548 RID: 5448 RVA: 0x00089B2C File Offset: 0x00087D2C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Send(ParamArray args As Object())
			If args.Length = 1 Then
				Me.Send(Conversions.ToString(args(0)))
				Return
			End If
			If args.Length = 2 Then
				Me.Send(Conversions.ToString(args(0)), Conversions.ToString(args(1)), False, False)
				Return
			End If
			If args.Length = 3 Then
				Me.Send(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToBoolean(args(2)), False)
				Return
			End If
			If args.Length = 4 Then
				Me.Send(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToBoolean(args(2)), Conversions.ToBoolean(args(3)))
			End If
		End Sub

		' Token: 0x06001549 RID: 5449 RVA: 0x00089BC4 File Offset: 0x00087DC4
		Public Sub Send(Msg As String)
			Msg = String.Concat(New String() { "$" & vbVerticalTab, Me.UserName, vbVerticalTab, Msg.Replace(vbVerticalTab, ""), vbVerticalTab, Me.o_oo0Oooo.OOO_. })
			Me.O.00O0_O_o_oO.("", Msg)
		End Sub

		' Token: 0x0600154A RID: 5450 RVA: 0x00089C28 File Offset: 0x00087E28
		<oO0oooo("2990")>
		Public Function Send(UserName As String, Msg As String, Optional AnyWay As Boolean = False, Optional ThroughServer As Boolean = False) As Boolean
			Msg = o0___oO.o0__.0.(Msg)
			Dim result As Boolean
			If Operators.CompareString(UserName, "", True) = 0 Then
				Me.Send(Msg)
				result = True
			ElseIf Me.Buddies.Contains(UserName) Then
				Dim imbuddy As IMBuddy = Me.Buddies(UserName)
				If Not imbuddy.OnLine AndAlso Not AnyWay AndAlso Not imbuddy.FromWeChat Then
					result = False
				ElseIf imbuddy.oOo.o0__0Oo0oO. > 0 AndAlso Not imbuddy.FromWeChat AndAlso imbuddy.O00OO.o_. > 0 AndAlso Not Me.ThroughServer AndAlso Not ThroughServer Then
					Msg = String.Concat(New String() { "$" & vbVerticalTab, Me.UserName, vbVerticalTab, Msg.Replace(vbVerticalTab, ""), vbVerticalTab, Me.o_oo0Oooo.OOO_. })
					Me.O.00O0_O_o_oO.(UserName, Msg)
					result = True
				Else
					Dim text As String = UserName
					If imbuddy.FromWeChat Then
						text = """" + text + """"
					End If
					Msg = String.Concat(New String() { "=$" & vbVerticalTab, text, vbVerticalTab, Me.UserName, vbVerticalTab, Msg.Replace(vbVerticalTab, ""), vbVerticalTab, Me.o_oo0Oooo.OOO_. })
					Me.O.00O0_O_o_oO.("", Msg)
					result = True
				End If
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x0600154B RID: 5451 RVA: 0x00089D94 File Offset: 0x00087F94
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, Optional A_2 As Boolean = True)
			Dim value As Char = vbVerticalTab
			If A_2 Then
				Dim text As String = A_1.Replace(Conversions.ToString(value), "")
				If text.StartsWith("{!}") Then
					text = text.Substring(3)
				End If
				Me.O.00O0_O_o_oO.(A_0, text, 2, 1, Me.UserName)
			End If
			If Me.oo.___oo__0_O..ContainsKey(A_0) Then
				Dim a_ As String = String.Concat(New String() { "*1", Conversions.ToString(value), Me.UserName, Conversions.ToString(value), Me.o_oo0Oooo.OOO_., Conversions.ToString(value), A_0, Conversions.ToString(value), A_1.Replace(Conversions.ToString(value), "") })
				Try
					For Each imbuddy As IMBuddy In Me.oo.___oo__0_O.(A_0).O0_.OO.()
						If imbuddy.oOo.o0__0Oo0oO. > 0 AndAlso imbuddy.O00OO.o_. > 0 AndAlso Not Me.ThroughServer Then
							Me.O.00O0_O_o_oO.(imbuddy.Name, a_)
						Else
							Dim a_2 As String = String.Concat(New String() { "*1", Conversions.ToString(value), imbuddy.Name, Conversions.ToString(value), Me.UserName, Conversions.ToString(value), Me.o_oo0Oooo.OOO_., Conversions.ToString(value), A_0, Conversions.ToString(value), A_1.Replace(Conversions.ToString(value), "") })
							Me.O.00O0_O_o_oO.(a_2)
						End If
					Next
					Return
				Finally
					Dim enumerator As List(Of IMBuddy).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			If Me.oo.___oo__0_O..ContainsKey(A_0) Then
				Dim a_3 As String = String.Concat(New String() { "*1", Conversions.ToString(value), Me.UserName, Conversions.ToString(value), Me.o_oo0Oooo.OOO_., Conversions.ToString(value), A_0, Conversions.ToString(value), A_1.Replace(Conversions.ToString(value), "") })
				Try
					For Each text2 As String In Me.oo.___oo__0_O.(A_0).O0O0o_.00O.()
						If Operators.CompareString(text2, Me.UserName, True) <> 0 Then
							If Me.Buddies.Contains(text2) AndAlso Me.Buddies(text2).oOo.o0__0Oo0oO. > 0 AndAlso Me.Buddies(text2).O00OO.o_. > 0 AndAlso Not Me.ThroughServer Then
								Me.O.00O0_O_o_oO.(text2, a_3)
							Else
								Dim a_4 As String = String.Concat(New String() { "*1", Conversions.ToString(value), text2, Conversions.ToString(value), Me.UserName, Conversions.ToString(value), Me.o_oo0Oooo.OOO_., Conversions.ToString(value), A_0, Conversions.ToString(value), A_1.Replace(Conversions.ToString(value), "") })
								Me.O.00O0_O_o_oO.(a_4)
							End If
						End If
					Next
				Finally
					Dim enumerator2 As List(Of String).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
			End If
		End Sub

		' Token: 0x0600154C RID: 5452 RVA: 0x0008A110 File Offset: 0x00088310
		<oO0oooo("3021")>
		Public Sub SendChatMessage(BuddyName As String, msg As String)
			Dim imbuddy As IMBuddy = Nothing
			If Me.Buddies.Contains(BuddyName) Then
				imbuddy = Me.Buddies(BuddyName)
			End If
			If imbuddy Is Nothing Then
				Try
					For Each ooo As ooo0 In Me.oo.___oo__0_O..Values
						If Operators.CompareString(ooo.oo.o0.(), BuddyName, True) = 0 Then
							imbuddy = ooo
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, ooo0).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			If imbuddy Is Nothing Then
				Try
					For Each o_0OOOoO As O_0OOOoO In Me.oo.___oo__0_O..Values
						If Operators.CompareString(o_0OOOoO.Name, BuddyName, True) = 0 Then
							imbuddy = o_0OOOoO
						End If
					Next
				Finally
					Dim enumerator2 As Dictionary(Of String, O_0OOOoO).ValueCollection.Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
			End If
			If imbuddy IsNot Nothing Then
				If TypeOf imbuddy Is ooo0 Then
					Me.o00O0._0O.(CType(imbuddy, ooo0).Oo_0__o.o.(), msg, True)
					Return
				End If
				If TypeOf imbuddy Is O_0OOOoO Then
					Me.o00O0._0O.(CType(imbuddy, O_0OOOoO).O_O0_o._O0o0O.(), msg, True)
					Return
				End If
				If TypeOf imbuddy Is IMBuddy Then
					If imbuddy.OnLine Then
						Me.O_._00O0_. += 1
						Me.ooOo.oO0..Add(Me.O_._00O0_., New O0o000(imbuddy, msg))
						Me.Send(imbuddy.Name, String.Concat(New String() { "={", msg, ChrW(4), Me.O_._00O0_..ToString(), "}=" }), True, False)
					Else
						Me.Send(imbuddy.Name, "={" + msg + "}=", True, False)
					End If
					Dim text As String = msg.Replace(vbVerticalTab, "")
					If text.StartsWith("{!}") Then
						text = text.Substring(3)
					End If
					Me.O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, Nothing)
				End If
			End If
		End Sub

		' Token: 0x0600154D RID: 5453 RVA: 0x0008A304 File Offset: 0x00088504
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O.00O0_O_o_oO.("", A_0)
		End Sub

		' Token: 0x0600154E RID: 5454 RVA: 0x0008A314 File Offset: 0x00088514
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim ipendPoint As IPEndPoint = Nothing
			If Operators.CompareString(A_0, "", True) = 0 Then
				ipendPoint = Me.ooOo.oO0.
			ElseIf Me.Buddies.Contains(A_0) Then
				ipendPoint = Me.Buddies(A_0).WanIP
			End If
			If ipendPoint IsNot Nothing Then
				Me.O.00O0_O_o_oO.(ipendPoint, A_1)
			End If
		End Sub

		' Token: 0x0600154F RID: 5455 RVA: 0x0008A368 File Offset: 0x00088568
		Friend Sub <<EMPTY_NAME>>(A_0 As IPEndPoint, A_1 As String)
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_1)
			Me.ooOo.oO0..Send(bytes, bytes.Length, A_0)
		End Sub

		' Token: 0x06001550 RID: 5456 RVA: 0x0008A394 File Offset: 0x00088594
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Integer = 5, Optional A_1 As Integer = -1)
			If Not Me.O0_OOo.O. Then
				Dim buddies As Object = Me.Buddies
				SyncLock buddies
					Dim dataView As DataView
					If A_1 > 0 Then
						Dim s As String = "^" & vbVerticalTab + Me.o_00o.O. + vbVerticalTab + Me.o_oo0Oooo.OOO_.
						Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
						Me.O00._Oo..Send(bytes, bytes.Length, Me.ooOo.oO0.)
						Dim now As DateTime = DateTime.Now
						Me.Buddies.OOO__.0.()
						While DateTime.Compare(DateTime.Now, now.AddSeconds(CDbl(A_0))) < 0
							If Me.O00._Oo..Available > 0 Then
								now = DateTime.Now
								Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
								Dim bytes2 As Byte() = Me.O00._Oo..Receive(ipendPoint)
								Dim array As String() = Encoding.Unicode.GetString(bytes2).Split(New Char() { vbVerticalTab })
								For i As Integer = 0 To array.Length - 1
									Dim array2 As String() = array(i).Split(New Char() { vbTab })
									If array2.Length = 5 AndAlso Operators.CompareString(array2(0), "^", True) = 0 Then
										Dim a_ As IPEndPoint = o0___oO.o0__.0.(array2(2))
										Me.Buddies.Oo___o.oo.(New IMBuddy(array2(1), a_, array2(3)))
										If Operators.CompareString(array2(4), "None", True) <> 0 Then
											Me.Buddies(array2(1)).LanIP = o0___oO.o0__.0.(array2(4))
										End If
										Me.Buddies(array2(1)).Ready = True
									ElseIf array2.Length = 2 AndAlso Operators.CompareString(array2(0), "^", True) = 0 Then
										Me.Buddies.Oo___o.oo.(New IMBuddy(array2(1), Nothing, Nothing))
									End If
								Next
								If Me.Buddies.Count = Me.Oo0__0.ooO0__o. Then
									Exit While
								End If
							End If
						End While
					End If
					If Me.ReceiveNotice Then
						Dim imbuddy As IMBuddy = New IMBuddy("[System]", Nothing, Nothing)
						imbuddy.SimpleName = "系统通知"
						Me.Buddies.Oo___o.oo.(imbuddy)
					End If
					If Not o0OO__.OO0oO.o.() AndAlso Me.Buddies.Count > 20 Then
						Dim imbuddyCollections As IMBuddyCollections = New IMBuddyCollections()
						Try
							For Each a_2 As IMBuddy In Me.Buddies
								imbuddyCollections.Oo___o.oo.(a_2)
								If imbuddyCollections.Count >= 20 Then
									Exit For
								End If
							Next
						Finally
							Dim enumerator As IEnumerator(Of IMBuddy)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						Me.oOO0O.O0O0. = imbuddyCollections
					End If
					Try
						For Each imbuddy2 As IMBuddy In Me.Buddies
							If imbuddy2.OnLine Then
								If imbuddy2.oOo.o0__0Oo0oO. = 0 AndAlso imbuddy2.LanIP IsNot Nothing Then
									Dim text As String = imbuddy2.WanIP.ToString()
									Dim text2 As String = Me.WanIP.ToString()
									text = text.Substring(0, text.IndexOf(":"))
									text2 = text2.Substring(0, text2.IndexOf(":"))
									If Operators.CompareString(text, text2, True) = 0 Then
										Me.O.00O0_O_o_oO.(imbuddy2.LanIP, "#1" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.)
									End If
								End If
								Me.O.00O0_O_o_oO.(imbuddy2.Name, "#" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.)
								imbuddy2.LastReceiveHeartbeatTime = DateTime.Now
								imbuddy2.O00OO.o_. = DateTime.Now
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of IMBuddy)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
					Me.O0.O0OOo.()
					If Me.O00.O0..Count > 0 Then
						Dim list As List(Of String) = New List(Of String)()
						Dim list2 As List(Of String) = New List(Of String)()
						Try
							For Each text3 As String In Me.O00.O0..Keys
								list.Add(text3)
								list2.Add(Me.O00.O0.(text3))
							Next
						Finally
							Dim enumerator3 As Dictionary(Of String, String).KeyCollection.Enumerator
							CType(enumerator3, IDisposable).Dispose()
						End Try
						Me.OOO__.0.(list, list2)
					End If
					dataView = New DataView(Me.oOOOo0.oo0OoO0., "[Read] = 0", "Name", DataViewRowState.CurrentRows)
					If dataView.Count > 0 Then
						Dim text4 As String = dataView(0)("Name").ToString()
						Dim num As Integer = 1
						Dim num2 As Integer = dataView.Count - 1
						For j As Integer = 1 To num2
							If Operators.CompareString(dataView(j)("Name").ToString(), text4, True) = 0 Then
								num += 1
							Else
								Me.oOO0O.O0O0.(text4, num)
								num = 1
								text4 = dataView(j)("Name").ToString()
							End If
						Next
						Me.oOO0O.O0O0.(text4, num)
					End If
				End SyncLock
			End If
		End Sub

		' Token: 0x06001551 RID: 5457 RVA: 0x0008A8C8 File Offset: 0x00088AC8
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Integer)
			If Me.oo.___oo__0_O..ContainsKey(A_0) Then
				Me.oo.___oo__0_O.(A_0).oo.0o_0O0_0. = A_1
				Return
			End If
			If Me.oo.___oo__0_O..ContainsKey(A_0) Then
				Me.oo.___oo__0_O.(A_0).oo.0o_0O0_0. = A_1
				Return
			End If
			If Me.Buddies.Contains(A_0) Then
				Me.Buddies(A_0).oo.0o_0O0_0. = A_1
			End If
		End Sub

		' Token: 0x06001552 RID: 5458 RVA: 0x0008A938 File Offset: 0x00088B38
		Private Sub <<EMPTY_NAME>>()
			If Not Me.O0_OOo.O. Then
				Dim udpClient As UdpClient = New UdpClient(0)
				o0___oO.O.oOo0O0O.(udpClient)
				udpClient.Client.ReceiveBufferSize = 81920
				Dim s As String = "+$" & vbVerticalTab + Me.o_00o.O. + vbVerticalTab + Me.o_oo0Oooo.OOO_.
				Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
				udpClient.Send(bytes, bytes.Length, Me.ooOo.oO0.)
				Dim oo0_0o0_OoO0O As Oo0_0o0_OoO0O = New Oo0_0o0_OoO0O(udpClient, Me.ooOo.oO0.)
				If oo0_0o0_OoO0O.oOo0O_o_.oO_o.() Then
					Dim text As String = oo0_0o0_OoO0O.oOo0O_o_.oO_o.()
					If Operators.CompareString(text, "", True) = 0 Then
						Me.oOOOo0.oo0OoO0..Fill(Me.oOOOo0.oo0OoO0.)
						Return
					End If
					Dim array As String() = text.Split(New Char() { vbFormFeed })
					Dim list As List(Of Client_MessageEventargs) = New List(Of Client_MessageEventargs)()
					Dim list2 As List(Of weMessageReceived) = New List(Of weMessageReceived)()
					Dim array2 As String() = array
					For i As Integer = 0 To array2.Length - 1
						Dim array3 As String() = array2(i).Split(New Char() { vbVerticalTab })
						If Operators.CompareString(array3(0), "*", True) = 0 AndAlso array3.Length = 7 Then
							If Operators.CompareString(array3(1), Me.UserName, True) = 0 Then
								Dim ooo As ooo0 = New ooo0(array3(2), Me.WanIP, array3(4), array3(3))
								ooo.O0_.OO.(Conversions.ToDate(array3(6)))
								Dim list3 As List(Of IMBuddy) = New List(Of IMBuddy)()
								For Each text2 As String In array3(5).Split(New Char() { ","c })
									If Me.Buddies.Contains(text2) Then
										list3.Add(Me.Buddies(text2))
									End If
								Next
								ooo.O0_.OO.(list3)
								Me.oo.___oo__0_O..Add(ooo.Oo_0__o.o.(), ooo)
							ElseIf Me.Buddies.Contains(array3(1)) Then
								Dim o_0OOOoO As O_0OOOoO = New O_0OOOoO(array3(2), array3(4), Me.Buddies(array3(1)), array3(3), array3(5))
								o_0OOOoO.O0O0o_.00O.(Conversions.ToDate(array3(6)))
								Me.oo.___oo__0_O..Add(o_0OOOoO.O_O0_o._O0o0O.(), o_0OOOoO)
							End If
							Dim array5 As DataRow() = Me.oo00000_0o0.oO..[Select]("MeetingKey = '" + array3(4) + "'")
							Dim dataRow As DataRow
							If array5.Length > 0 Then
								dataRow = array5(0)
							Else
								dataRow = Me.oo00000_0o0.oO..NewRow()
								dataRow("MeetingKey") = array3(4)
								Me.oo00000_0o0.oO..Rows.Add(dataRow)
							End If
							dataRow("Hostess") = array3(1)
							dataRow("MeetingName") = array3(2)
							dataRow("DateTime") = array3(6)
							dataRow("Description") = array3(3)
							dataRow("Members") = array3(5)
							dataRow("Finish") = False
						ElseIf Operators.CompareString(array3(0), "*", True) = 0 AndAlso array3.Length = 8 Then
							If Not Me.oo.___oo__0_O..ContainsKey(array3(4)) AndAlso Not Me.oo.___oo__0_O..ContainsKey(array3(4)) Then
								Dim dataRow2 As DataRow = Me.oo00000_0o0.oO..NewRow()
								dataRow2("MeetingKey") = array3(4)
								dataRow2("Hostess") = array3(1)
								dataRow2("MeetingName") = array3(2)
								dataRow2("DateTime") = array3(6)
								dataRow2("Description") = array3(3)
								dataRow2("Members") = array3(5)
								dataRow2("Finish") = True
								Me.oo00000_0o0.oO..Rows.Add(dataRow2)
							End If
						ElseIf array3.Length = 4 AndAlso Operators.CompareString(array3(0), "$", True) = 0 Then
							If Me.Buddies.Contains(array3(1)) OrElse Operators.CompareString(array3(1), "", True) = 0 Then
								If array3(2).StartsWith("={") AndAlso array3(2).EndsWith("}=") Then
									Dim dataRow3 As DataRow = Me.oOOOo0.oo0OoO0..NewRow()
									dataRow3("Name") = array3(1)
									dataRow3("Type") = 1
									Dim text3 As String = array3(2).Substring(2, array3(2).Length - 4)
									If text3.StartsWith("{!}") Then
										text3 = text3.Substring(3)
										Dim text4 As String = array3(1)
										If Operators.CompareString(text4, "[System]", True) = 0 Then
											text4 = "系统通知"
										End If
										OO_00oOO.PopMessage(text3, text4, 0, -1)
									End If
									dataRow3("Content") = text3
									dataRow3("Time") = Conversions.ToDate(array3(3))
									dataRow3("Read") = 0
									Me.oOOOo0.oo0OoO0..Rows.Add(dataRow3)
								Else
									Dim client_MessageEventargs As Client_MessageEventargs = New Client_MessageEventargs(Me, array3(1), array3(2))
									Dim dateTime As DateTime
									If DateTime.TryParse(array3(3), dateTime) Then
										client_MessageEventargs.SendTime = client_MessageEventargs.SendTime
									End If
									list.Add(client_MessageEventargs)
								End If
							End If
						ElseIf array3.Length = 4 AndAlso Operators.CompareString(array3(0), "=$", True) = 0 Then
							If array3(2).StartsWith("={") AndAlso array3(2).EndsWith("}=") Then
								Dim dataRow4 As DataRow = Me.oOOOo0.oo0OoO0..NewRow()
								If array3(1).IndexOf(vbTab) < 0 Then
									dataRow4("Name") = array3(1)
								Else
									Dim array6 As String() = array3(1).Split(New Char() { vbTab })
									dataRow4("Name") = array6(0)
									If Not Me.O00.O0..ContainsKey(array6(0)) AndAlso array6.Length = 2 Then
										Me.O00.O0..Add(array6(0), array6(1))
									End If
								End If
								dataRow4("Type") = 1
								Dim text5 As String = array3(2).Substring(2, array3(2).Length - 4)
								If text5.StartsWith("{!}") Then
									text5 = text5.Substring(3)
								End If
								dataRow4("Content") = text5
								dataRow4("Time") = Conversions.ToDate(array3(3))
								dataRow4("Read") = 0
								Me.oOOOo0.oo0OoO0..Rows.Add(dataRow4)
							Else
								Dim text6 As String = array3(2)
								Dim a_ As Integer
								If text6.StartsWith(ChrW(2) & "=?") AndAlso text6.EndsWith("?=") Then
									a_ = 1
								ElseIf text6.StartsWith(ChrW(2) & "<?") AndAlso text6.EndsWith("?>") Then
									a_ = 2
								End If
								Dim item As weMessageReceived = New weMessageReceived(Me, array3(1), a_, text6)
								list2.Add(item)
							End If
						ElseIf array3.Length = 5 AndAlso Operators.CompareString(array3(0), "*1", True) = 0 Then
							Dim dataRow5 As DataRow = Me.oOOOo0.oo0OoO0..NewRow()
							dataRow5("Name") = array3(2)
							dataRow5("Type") = 1
							dataRow5("Content") = array3(3)
							dataRow5("Time") = Conversions.ToDate(array3(4))
							dataRow5("Read") = 0
							dataRow5("MeetingSender") = array3(1)
							Me.oOOOo0.oo0OoO0..Rows.Add(dataRow5)
						End If
					Next
					Me.oo00000_0o0.oO..Update(Me.oo00000_0o0.oO.)
					Me.oOOOo0.oo0OoO0..Update(Me.oOOOo0.oo0OoO0.)
					Me.oOOOo0.oo0OoO0..Rows.Clear()
					Me.oOOOo0.oo0OoO0..Fill(Me.oOOOo0.oo0OoO0.)
					Try
						For Each client_MessageEventargs2 As Client_MessageEventargs In list
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_ReceivedMessage", New Object() { client_MessageEventargs2 }, True, "项目", False)
						Next
					Finally
						Dim enumerator As List(Of Client_MessageEventargs).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Try
						For Each weMessageReceived As weMessageReceived In list2
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_WeMessageReceived", New Object() { weMessageReceived }, True, "项目", False)
						Next
					Finally
						Dim enumerator2 As List(Of weMessageReceived).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
				End If
			End If
		End Sub

		' Token: 0x06001553 RID: 5459 RVA: 0x0008B1E8 File Offset: 0x000893E8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SendWait(ParamArray args As Object()) As String
			Dim result As String
			If args.Length = 1 Then
				result = Me.SendWait(Conversions.ToString(args(0)), -1)
			ElseIf args.Length = 2 Then
				result = Me.SendWait(Conversions.ToString(args(0)), Conversions.ToInteger(args(1)))
			End If
			Return result
		End Function

		' Token: 0x06001554 RID: 5460 RVA: 0x0008B22C File Offset: 0x0008942C
		<oO0oooo("2991")>
		Public Function SendWait(msg As String, Optional TimeOut As Integer = -1) As String
			Dim result As String
			If Me.O0_OOo.O. Then
				result = ""
			Else
				Me.o0.0o_00.()
				If TimeOut = -1 Then
					TimeOut = Me.O0Oo0OO.O.
				End If
				TimeOut = Math.Max(1, TimeOut)
				msg = String.Concat(New String() { "$" & vbVerticalTab, Me.o_00o.O., vbVerticalTab, msg, vbVerticalTab, Me.o_oo0Oooo.OOO_. })
				Dim bytes As Byte() = Encoding.Unicode.GetBytes(msg)
				Me.O00._Oo..Send(bytes, bytes.Length, Me.ooOo.oO0.)
				Dim now As DateTime = DateTime.Now
				While DateTime.Compare(DateTime.Now, now.AddSeconds(CDbl(TimeOut))) < 0
					If Me.O00._Oo..Available > 0 Then
						Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim bytes2 As Byte() = Me.O00._Oo..Receive(ipendPoint)
						Dim array As String() = Encoding.Unicode.GetString(bytes2).Split(New Char() { vbVerticalTab })
						If array.Length = 4 AndAlso Operators.CompareString(array(3), Me.o_oo0Oooo.OOO_., True) = 0 Then
							Return array(2)
						End If
						Return ""
					End If
				End While
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06001555 RID: 5461 RVA: 0x0008B35C File Offset: 0x0008955C
		Friend Function <<EMPTY_NAME>>(A_0 As String, Optional A_1 As Integer = -1) As String
			Dim result As String
			If Me.O0_OOo.O. Then
				result = ""
			Else
				Me.o0.0o_00.()
				If A_1 = -1 Then
					A_1 = Me.O0Oo0OO.O.
				End If
				A_1 = Math.Max(1, A_1)
				Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_0)
				Me.O00._Oo..Send(bytes, bytes.Length, Me.ooOo.oO0.)
				Dim now As DateTime = DateTime.Now
				While DateTime.Compare(DateTime.Now, now.AddSeconds(CDbl(A_1))) < 0
					If Me.O00._Oo..Available > 0 Then
						Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim bytes2 As Byte() = Me.O00._Oo..Receive(ipendPoint)
						Return Encoding.Unicode.GetString(bytes2)
					End If
				End While
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06001556 RID: 5462 RVA: 0x0008B418 File Offset: 0x00089618
		Private Sub <<EMPTY_NAME>>()
			While Me.O00._Oo..Available > 0
				Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
				Me.O00._Oo..Receive(ipendPoint)
			End While
		End Sub

		' Token: 0x06001557 RID: 5463 RVA: 0x0008B450 File Offset: 0x00089650
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim buddies As Object = Me.Buddies
			SyncLock buddies
				If Not Me.O0_OOo.O. Then
					Dim s As String = "#" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.
					Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
					Dim bytes2 As Byte() = Encoding.Unicode.GetBytes("###" & vbVerticalTab + Me.UserName + vbVerticalTab + Me.o_oo0Oooo.OOO_.)
					If Not Me.StopHeartbratServer Then
						Me.ooOo.oO0..Send(bytes, bytes.Length, Me.ooOo.oO0.)
					End If
					If Not Me.StopHeartbratBuddy Then
						Try
							For Each imbuddy As IMBuddy In Me.Buddies
								If imbuddy.OnLine Then
									Me.ooOo.oO0..Send(bytes, bytes.Length, imbuddy.WanIP)
									If imbuddy.O00OO.o_. = 0 AndAlso imbuddy.oO0.OooOOO00. < 3 Then
										Me.ooOo.oO0..Send(bytes2, bytes2.Length, imbuddy.WanIP)
										imbuddy.oO0.OooOOO00. += 1
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator(Of IMBuddy)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
					End If
				End If
			End SyncLock
		End Sub

		' Token: 0x06001558 RID: 5464 RVA: 0x0008B5BC File Offset: 0x000897BC
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Integer, A_3 As Integer, A_4 As String) As DataRow
			Try
				If Me.oOO0O.O0O0. IsNot Nothing Then
					Dim dataRow As DataRow = Me.oOOOo0.oo0OoO0..NewRow()
					dataRow("Name") = A_0
					dataRow("Type") = A_2
					dataRow("Content") = A_1
					dataRow("Time") = DateTime.Now
					dataRow("Read") = A_3
					dataRow("MeetingSender") = A_4
					Me.oOOOo0.oo0OoO0..Rows.Add(dataRow)
					Me.oOOOo0.oo0OoO0..Update(New DataRow() { dataRow })
					dataRow("_Identify") = RuntimeHelpers.GetObjectValue(Me.ooOooo.oO..ExecuteScalar())
					dataRow.AcceptChanges()
					Dim imbuddy As IMBuddy = Nothing
					If A_4 Is Nothing Then
						If Not Me.Buddies.Contains(A_0) Then
							Return Nothing
						End If
						imbuddy = Me.Buddies(A_0)
					ElseIf Me.oo.___oo__0_O..ContainsKey(A_0) Then
						imbuddy = Me.oo.___oo__0_O.(A_0)
					ElseIf Me.oo.___oo__0_O..ContainsKey(A_0) Then
						imbuddy = Me.oo.___oo__0_O.(A_0)
					Else
						If Me.ooOooo.oO..o.0_0_Ooo. IsNot Nothing AndAlso TypeOf Me.ooOooo.oO..o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
							Dim o0o0_oo00Oo As o0o0_oo00Oo = CType(Me.ooOooo.oO..o.0_0_Ooo..Tag, o0o0_oo00Oo)
							If Me.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()) Then
								imbuddy = Me.oo.___oo__0_O.(o0o0_oo00Oo.OO.O_o__.())
							ElseIf Me.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()) Then
								imbuddy = Me.oo.___oo__0_O.(o0o0_oo00Oo.OO.O_o__.())
							End If
						End If
						If imbuddy Is Nothing Then
							Return Nothing
						End If
					End If
					If Me.ooOooo.oO. IsNot Nothing AndAlso Me.ooOooo.oO..Oo0_O0o.o_. Then
						If Me.ooOooo.oO..o.0_0_Ooo. IsNot Nothing AndAlso Me.ooOooo.oO..o.0_0_Ooo..Tag Is imbuddy AndAlso Me.ooOooo.oO..o.0_0_Ooo..TopicPage.Index <> 0 Then
							Me.ooOooo.oO..OooOO_o0O0_._.()
						End If
						Dim c1TopicLink As C1TopicLink = Me.ooOooo.oO..Oo.Oo00__oooo.().Pages(0).FindLinkByTag(imbuddy)
						Dim flag As Boolean = False
						If c1TopicLink <> Me.ooOooo.oO..o.0_0_Ooo. AndAlso c1TopicLink IsNot Nothing AndAlso Me.ooOooo.oO..o.0_0_Ooo. IsNot Nothing AndAlso TypeOf Me.ooOooo.oO..o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
							Dim o0o0_oo00Oo2 As o0o0_oo00Oo = CType(Me.ooOooo.oO..o.0_0_Ooo..Tag, o0o0_oo00Oo)
							If Me.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo2.OO.O_o__.()) AndAlso c1TopicLink.Tag Is Me.oo.___oo__0_O.(o0o0_oo00Oo2.OO.O_o__.()) Then
								flag = True
							ElseIf Me.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo2.OO.O_o__.()) AndAlso c1TopicLink.Tag Is Me.oo.___oo__0_O.(o0o0_oo00Oo2.OO.O_o__.()) Then
								flag = True
							End If
						End If
						If(c1TopicLink IsNot Nothing AndAlso Me.ooOooo.oO..o.0_0_Ooo. = c1TopicLink) OrElse flag Then
							Dim oo0O As Oo0O = Me.ooOooo.oO..O_0oOOO_.OO.()
							oo0O.BeginUpdate()
							Me.ooOooo.oO..O_0.00o.(oo0O, dataRow)
							oo0O.EndUpdate()
							oo0O.ShowCell(oo0O.Rows.Count - 1, 0)
							If oo0O.Row = 0 Then
								oo0O.[Select](1, 1, 2, 1)
							End If
						Else
							imbuddy.oo.0o_0O0_0. += 1
							If c1TopicLink Is Nothing Then
								c1TopicLink = New C1TopicLink()
								c1TopicLink.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")"
								c1TopicLink.Tag = imbuddy
								If TypeOf imbuddy Is ooo0 OrElse TypeOf imbuddy Is O_0OOOoO Then
									c1TopicLink.ImageIndex = 9
								ElseIf imbuddy.FromWeChat Then
									c1TopicLink.ImageIndex = 20
								ElseIf imbuddy.OnLine Then
									c1TopicLink.ImageIndex = 0
								Else
									c1TopicLink.ImageIndex = 1
								End If
								Me.ooOooo.oO..Oo.Oo00__oooo.().Pages(0).Links.Add(c1TopicLink)
								If Not Me.ooOooo.oO..Oo.Oo00__oooo.().Pages(0).PageVisible Then
									Me.ooOooo.oO..Oo.Oo00__oooo.().Pages(0).PageVisible = True
								End If
							Else
								c1TopicLink.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")"
							End If
						End If
					ElseIf A_3 = 0 Then
						imbuddy.oo.0o_0O0_0. += 1
					End If
					If A_2 = 1 AndAlso OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav") Then
						OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background)
					End If
					Return dataRow
				End If
				Return Nothing
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			Return Nothing
		End Function

		' Token: 0x06001559 RID: 5465 RVA: 0x0008BAD8 File Offset: 0x00089CD8
		Friend Sub <<EMPTY_NAME>>()
			Try
				If Not OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "QQClient") Then
					OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "QQClient")
				End If
				If Not OO_00oOO.FileSys.FileExists(OO_00oOO.ProjectPath + "QQClient\" + Me.DataFile) Then
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "IMclient.mdb", OO_00oOO.ProjectPath + "QQClient\" + Me.DataFile)
				End If
				Me.oOOOo0.oo0OoO0. = New DataTable()
				Me.oo00000_0o0.oO. = New DataTable()
				Me.oOO0O.O0O0. = New OleDbConnection(Oo00.o_._0OOo.(OO_00oOO.ProjectPath + "QQClient\" + Me.DataFile))
				Me.oOOOo0.oo0OoO0. = New OleDbDataAdapter("Select * From [Messages] Where [Read] = 0", Me.oOO0O.O0O0.)
				Me.oOOOo0.oo0OoO0..FillSchema(Me.oOOOo0.oo0OoO0., SchemaType.Source)
				Me.oo00000_0o0.oO. = New OleDbDataAdapter("Select * From [Meetings]", Me.oOO0O.O0O0.)
				Me.oo00000_0o0.oO..FillSchema(Me.oo00000_0o0.oO., SchemaType.Source)
				Me.oo00000_0o0.oO..Fill(Me.oo00000_0o0.oO.)
				o_O_o_oOoo__.OO_O0oO0.oooO_.(Me.oOOOo0.oo0OoO0.)
				o_O_o_oOoo__.OO_O0oO0.oooO_.(Me.oo00000_0o0.oO.)
				Me.ooOooo.oO. = New OleDbCommand("Select @@IDENTITY", Me.oOO0O.O0O0.)
				Me.oOO0O.O0O0..Open()
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x0600155A RID: 5466 RVA: 0x0008BC78 File Offset: 0x00089E78
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenChatWindow(ParamArray args As Object())
			If args.Length = 0 Then
				Me.OpenChatWindow()
				Return
			End If
			If args.Length = 1 Then
				Me.OpenChatWindow(Conversions.ToString(args(0)))
				Return
			End If
			If args.Length = 2 Then
				Me.OpenChatWindow(Conversions.ToString(args(0)), Conversions.ToString(args(1)))
			End If
		End Sub

		' Token: 0x0600155B RID: 5467 RVA: 0x0008BCB7 File Offset: 0x00089EB7
		<oO0oooo("2993")>
		Public Sub OpenChatWindow()
			Me.OpenChatWindow("", "")
		End Sub

		' Token: 0x0600155C RID: 5468 RVA: 0x0008BCC9 File Offset: 0x00089EC9
		<oO0oooo("2993")>
		Public Sub OpenChatWindow(Caption As String)
			Me.OpenChatWindow(Caption, "")
		End Sub

		' Token: 0x0600155D RID: 5469 RVA: 0x0008BCD8 File Offset: 0x00089ED8
		<oO0oooo("2993")>
		Public Sub OpenChatWindow(Caption As String, ImageFile As String)
			If Me.ooOooo.oO. Is Nothing Then
				Dim f As f4 = New f4(Me)
				Me.ooOooo.oO. = f
				f.Owner = OO_00oOO.BaseMainForm
				f.oOo00_.0Oo.().Enabled = Me.AllowSendFile
				If Operators.CompareString(Caption, "", True) > 0 Then
					f.Text = Caption + "(" + Me.UserName + ")"
				End If
				If Not String.IsNullOrEmpty(ImageFile) Then
					If String.IsNullOrEmpty(Path.GetPathRoot(ImageFile)) Then
						If OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + ImageFile) Then
							ImageFile = O_O0OO.OOo_o.0o. + ImageFile
						Else
							ImageFile = ooO.OoO0o_o___.O.(ImageFile)
						End If
						If Not File.Exists(ImageFile) Then
							ImageFile = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\images\" + c.OOOOO.o.().FileSystem.GetName(ImageFile)
						End If
					End If
					If OO_00oOO.FileSys.FileExists(ImageFile) Then
						f.Icon = New Icon(ImageFile)
					End If
				End If
				f.Show()
			End If
		End Sub

		' Token: 0x0600155E RID: 5470 RVA: 0x0008BDE4 File Offset: 0x00089FE4
		Friend Sub <<EMPTY_NAME>>(A_0 As IMBuddy)
			A_0.OnLine = False
			If Me.ooOooo.oO. IsNot Nothing AndAlso Me.ooOooo.oO..Oo0_O0o.o_. Then
				Try
					For Each obj As Object In Me.ooOooo.oO..Oo.Oo00__oooo.().Pages
						Dim c1TopicPage As C1TopicPage = CType(obj, C1TopicPage)
						Dim c1TopicLink As C1TopicLink = c1TopicPage.FindLinkByTag(A_0)
						If c1TopicLink IsNot Nothing Then
							If c1TopicLink.TopicPage.Index = 0 Then
								c1TopicLink.ImageIndex = 1
							Else
								c1TopicLink.ImageIndex = 12
							End If
							Dim num As Integer = 0
							Dim num2 As Integer = c1TopicPage.Links.Count - 1
							For i As Integer = 0 To num2
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(c1TopicPage.Links(i).Tag)
								If TypeOf objectValue Is ooo0 OrElse TypeOf objectValue Is O_0OOOoO OrElse CType(objectValue, IMBuddy).OnLine Then
									num += 1
								End If
							Next
							num = Math.Min(num, c1TopicPage.Links.Count - 1)
							If num <> c1TopicLink.Index Then
								c1TopicPage.Links.Remove(c1TopicLink)
								c1TopicPage.Links.Insert(num, c1TopicLink)
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Me.ooOooo.oO..o.0_0_Ooo. IsNot Nothing AndAlso Me.ooOooo.oO..o.0_0_Ooo..Tag Is A_0 Then
					Me.ooOooo.oO..oOoO.O_o__.("对方已经离线,您可以继续发送离线消息!")
				End If
			End If
		End Sub

		' Token: 0x0600155F RID: 5471 RVA: 0x0008BF60 File Offset: 0x0008A160
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim array As Object() = CType(A_0, Object())
			Dim a_ As IMBuddy = CType(array(0), IMBuddy)
			Dim a_2 As String = array(1).ToString()
			Dim a_3 As SendTypeEnum = CType(Conversions.ToInteger(array(2)), SendTypeEnum)
			Dim a_4 As oO0 = Nothing
			If array(3) IsNot Nothing Then
				a_4 = CType(array(3), oO0)
			End If
			Dim a_5 As Boolean
			If array.Length = 5 Then
				a_5 = Conversions.ToBoolean(array(4))
			End If
			Me.o00O0._0O.(a_, a_2, a_3, a_4, a_5)
		End Sub

		' Token: 0x06001560 RID: 5472 RVA: 0x0008BFC0 File Offset: 0x0008A1C0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SendFile(ParamArray args As Object())
			Select Case args.Length
				Case 1
					Me.SendFile(Conversions.ToString(args(0)), False)
					Return
				Case 2
					If TypeOf args(1)Is Boolean Then
						Me.SendFile(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)))
						Return
					End If
					Me.SendFile(Conversions.ToString(args(0)), Conversions.ToString(args(1)), False)
					Return
				Case 3
					Me.SendFile(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToBoolean(args(2)))
					Return
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06001561 RID: 5473 RVA: 0x0008C050 File Offset: 0x0008A250
		<oO0oooo("3020")>
		Public Sub SendFile(BuddyName As String, FileName As String, Optional ShowProcess As Boolean = False)
			If OO_00oOO.FileSys.FileExists(FileName) AndAlso Me.Buddies.Contains(BuddyName) AndAlso (Me.Buddies(BuddyName).OnLine OrElse Me.Buddies(BuddyName).FromWeChat) Then
				Dim array As Object() = New Object(4) {}
				array(0) = Me.Buddies(BuddyName)
				array(1) = FileName
				If Me.Buddies(BuddyName).FromWeChat Then
					array(2) = SendTypeEnum.ManualFile
				Else
					array(2) = SendTypeEnum.AutoFile
				End If
				If ShowProcess Then
					Dim oO As oO0 = New oO0(Me, Me.Buddies(BuddyName), FileName, SendTypeEnum.ManualFile)
					oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(FileName)
					oO.o.oo00_.().Visible = False
					oO.OO0.oo_o00o.().Enabled = False
					Dim fileInfo As FileInfo = New FileInfo(FileName)
					Dim text As String
					If fileInfo.Length / 1024L < 1000L Then
						text = (fileInfo.Length / 1024L).ToString() + "K"
					Else
						text = Strings.Format(CDbl(fileInfo.Length) / 1024.0 / 1024.0, "0.00") + "M"
					End If
					oO.o_0O.00.().Text = text
					If Me.ooOooo.oO. Is Nothing Then
						Me.ooOooo.oO. = New o\u3000\u3002\u3000\u3002\u3000(Me)
						Me.ooOooo.oO..Owner = OO_00oOO.BaseMainForm
					End If
					Me.ooOooo.oO..O_0O_o.0.(oO)
					Me.ooOooo.oO..Show()
					array(3) = oO
				Else
					array(3) = Nothing
				End If
				array(4) = False
				AddressOf Me.O00__O._O_00o..Start(array)
			End If
		End Sub

		' Token: 0x06001562 RID: 5474 RVA: 0x0008C218 File Offset: 0x0008A418
		<oO0oooo("3020")>
		Public Sub SendFile(FileName As String, Optional ShowProcess As Boolean = False)
			If OO_00oOO.FileSys.FileExists(FileName) Then
				Dim array As Object() = New Object(4) {}
				array(0) = Nothing
				array(1) = FileName
				array(2) = SendTypeEnum.AutoFile
				If ShowProcess Then
					Dim oO As oO0 = New oO0(Me, Nothing, FileName, SendTypeEnum.ManualFile)
					oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(FileName)
					oO.o.oo00_.().Visible = False
					oO.OO0.oo_o00o.().Enabled = False
					Dim fileInfo As FileInfo = New FileInfo(FileName)
					Dim text As String
					If fileInfo.Length / 1024L < 1000L Then
						text = (fileInfo.Length / 1024L).ToString() + "K"
					Else
						text = Strings.Format(CDbl(fileInfo.Length) / 1024.0 / 1024.0, "0.00") + "M"
					End If
					oO.o_0O.00.().Text = text
					If Me.ooOooo.oO. Is Nothing Then
						Me.ooOooo.oO. = New o\u3000\u3002\u3000\u3002\u3000(Me)
						Me.ooOooo.oO..Owner = OO_00oOO.BaseMainForm
					End If
					Me.ooOooo.oO..O_0O_o.0.(oO)
					Me.ooOooo.oO..Show()
					array(3) = oO
				Else
					array(3) = Nothing
				End If
				array(4) = False
				AddressOf Me.O00__O._O_00o..Start(array)
			End If
		End Sub

		' Token: 0x06001563 RID: 5475 RVA: 0x0008C370 File Offset: 0x0008A570
		<oO0oooo("3022")>
		Public Sub SendChatFile(BuddyName As String, FileName As String, Optional ShowProcess As Boolean = False)
			If OO_00oOO.FileSys.FileExists(FileName) Then
				Me.O.00O0_O_o_oO.(BuddyName, FileName, False, ShowProcess)
			End If
		End Sub

		' Token: 0x06001564 RID: 5476 RVA: 0x0008C389 File Offset: 0x0008A589
		<oO0oooo("3023")>
		Public Sub SendChatImage(BuddyName As String, FileName As String, Optional ShowProcess As Boolean = False)
			If OO_00oOO.FileSys.FileExists(FileName) Then
				Me.O.00O0_O_o_oO.(BuddyName, FileName, True, ShowProcess)
			End If
		End Sub

		' Token: 0x06001565 RID: 5477 RVA: 0x0008C3A4 File Offset: 0x0008A5A4
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean, A_3 As Boolean)
			Dim a_ As String = Nothing
			Dim a_2 As String = Nothing
			Dim imbuddy As IMBuddy = Nothing
			If OO_00oOO.FileSys.FileExists(A_1) Then
				If Me.Buddies.Contains(A_0) Then
					imbuddy = Me.Buddies(A_0)
					a_2 = A_0
				End If
				If imbuddy Is Nothing Then
					Try
						For Each ooo As ooo0 In Me.oo.___oo__0_O..Values
							If Operators.CompareString(ooo.oo.o0.(), A_0, True) = 0 Then
								imbuddy = ooo
								a_2 = ooo.Oo_0__o.o.()
								a_ = Me.UserName
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, ooo0).ValueCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				If imbuddy Is Nothing Then
					Try
						For Each o_0OOOoO As O_0OOOoO In Me.oo.___oo__0_O..Values
							If Operators.CompareString(o_0OOOoO.Name, A_0, True) = 0 Then
								imbuddy = o_0OOOoO
								a_2 = o_0OOOoO.O_O0_o._O0o0O.()
								a_ = Me.UserName
							End If
						Next
					Finally
						Dim enumerator2 As Dictionary(Of String, O_0OOOoO).ValueCollection.Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
				End If
				If imbuddy IsNot Nothing Then
					If A_2 Then
						Dim text As String
						If A_1.StartsWith(OO_00oOO.ProjectPath + "QQClient\CaptureFiles\", StringComparison.CurrentCultureIgnoreCase) Then
							text = A_1.Substring((OO_00oOO.ProjectPath + "QQClient\CaptureFiles\").Length)
						Else
							Dim text2 As String = String.Concat(New String() { OO_00oOO.ProjectPath, "QQClient\CaptureFiles\", Strings.Format(DateTime.Today, "yyyyMM"), "\", OoOo0O.OO_o.0o_O.(10), Path.GetExtension(A_1) })
							OO_00oOO.FileSys.CopyFile(A_1, text2, True)
							text = text2.Substring((OO_00oOO.ProjectPath + "QQClient\CaptureFiles\").Length)
							A_1 = text2
						End If
						text = ChrW(2) & "=(" + text + ")="
						Me.O.00O0_O_o_oO.(a_2, text, 2, 1, a_)
					End If
					Dim array As Object() = New Object(4) {}
					array(0) = imbuddy
					array(1) = A_1
					If A_2 Then
						array(2) = SendTypeEnum.Capture
					Else
						array(2) = SendTypeEnum.ManualFile
					End If
					If A_3 Then
						Dim oO As oO0 = New oO0(Me, imbuddy, A_1, SendTypeEnum.ManualFile)
						oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(A_1)
						oO.o.oo00_.().Visible = False
						oO.OO0.oo_o00o.().Enabled = False
						Dim fileInfo As FileInfo = New FileInfo(A_1)
						Dim text3 As String
						If fileInfo.Length / 1024L < 1000L Then
							text3 = (fileInfo.Length / 1024L).ToString() + "K"
						Else
							text3 = Strings.Format(CDbl(fileInfo.Length) / 1024.0 / 1024.0, "0.00") + "M"
						End If
						oO.o_0O.00.().Text = text3
						If Me.ooOooo.oO. Is Nothing Then
							Me.ooOooo.oO. = New o\u3000\u3002\u3000\u3002\u3000(Me)
							Me.ooOooo.oO..Owner = OO_00oOO.BaseMainForm
						End If
						Me.ooOooo.oO..O_0O_o.0.(oO)
						Me.ooOooo.oO..Show()
						array(3) = oO
					Else
						array(3) = Nothing
					End If
					array(4) = False
					AddressOf Me.O00__O._O_00o..Start(array)
				End If
			End If
		End Sub

		' Token: 0x06001566 RID: 5478 RVA: 0x0008C6F4 File Offset: 0x0008A8F4
		Friend Sub <<EMPTY_NAME>>(A_0 As IMBuddy, A_1 As String, A_2 As SendTypeEnum, A_3 As oO0, A_4 As Boolean)
			Dim text As String = OoOo0O.OO_o.0o_O.(6)
			If A_3 IsNot Nothing Then
				text = A_3.o0O.Oo.
			End If
			Dim udpClient As UdpClient = New UdpClient(0)
			o0___oO.O.oOo0O0O.(udpClient)
			udpClient.Client.SendBufferSize = 81920
			Dim text2 As String = vbVerticalTab
			Dim flag As Boolean
			Dim flag4 As Boolean
			If A_0 IsNot Nothing AndAlso Not A_0.FromWeChat AndAlso A_0.oOo.o0__0Oo0oO. > 0 AndAlso A_0.O00OO.o_. > 0 AndAlso Not A_4 Then
				Dim ipendPoint As IPEndPoint = A_0.WanIP
				If ipendPoint.ToString().StartsWith("192.168.") OrElse ipendPoint.ToString().StartsWith("127.0.0.1") Then
					Dim text3 As String = udpClient.Client.LocalEndPoint.ToString()
					text3 = text3.Substring(text3.IndexOf(":") + 1)
					Dim s As String = String.Concat(New String() { "%1", text2, Me.UserName, text2, Me.o_oo0Oooo.OOO_., text2, A_0.Name, text2, A_0.RandKey, text2, OO_00oOO.FileSys.GetName(A_1), text2, Conversions.ToString(CInt(A_2)), text2, text3, text2, text })
					Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
					udpClient.Send(bytes, bytes.Length, Me.ooOo.oO0.)
					Dim now As DateTime = DateTime.Now
					flag = True
					While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
						If udpClient.Available > 0 Then
							Dim ipendPoint2 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
							Dim bytes2 As Byte() = udpClient.Receive(ipendPoint2)
							Dim port As Integer
							If Integer.TryParse(Encoding.Unicode.GetString(bytes2), port) Then
								Dim a_ As IPEndPoint = New IPEndPoint(A_0.WanIP.Address, port)
								Dim o_0__O_o_O As O_0__O_o_O = New O_0__O_o_O(Me, udpClient, a_, A_1, A_0, text, A_2)
								o_0__O_o_O.O00o___0OoO.0. = A_3
								Dim flag2 As Boolean = False
								Dim obj As Object = Me.ooOooo.oO.
								SyncLock obj
									If Not Me.ooOooo.oO..ContainsKey(o_0__O_o_O.O_OO.o0o_o0.()) Then
										Me.ooOooo.oO..Add(o_0__O_o_O.O_OO.o0o_o0.(), o_0__O_o_O)
										flag2 = True
									End If
								End SyncLock
								If flag2 Then
									flag4 = True
									o_0__O_o_O.o0o_0OO00.Oo0_.()
									Exit While
								End If
								Exit While
							End If
						End If
					End While
				End If
			End If
			If flag Then
				If Not flag4 AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
					If A_2 = SendTypeEnum.Capture Then
						OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O0.O0OOo., New Object() { A_0, A_1 })
						Return
					End If
					If A_2 = SendTypeEnum.ManualFile Then
						OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O.00O0_O_o_oO., New Object() { A_0, A_1 })
						Return
					End If
				End If
			Else
				If A_0 IsNot Nothing AndAlso Not A_0.FromWeChat AndAlso A_0.oOo.o0__0Oo0oO. > 0 AndAlso A_0.O00OO.o_. > 0 AndAlso Not A_4 Then
					Dim s As String = String.Concat(New String() { "%2", text2, Me.UserName, text2, Me.o_oo0Oooo.OOO_., text2, OO_00oOO.FileSys.GetName(A_1), text2, Conversions.ToString(CInt(A_2)), text2, A_0.Name, text2, A_0.RandKey, text2, text })
					Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
					udpClient.Send(bytes, bytes.Length, Me.ooOo.oO0.)
					Dim now As DateTime = DateTime.Now
					flag = True
					While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
						If udpClient.Available > 0 Then
							Dim ipendPoint3 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
							Dim bytes3 As Byte() = udpClient.Receive(ipendPoint3)
							Dim array As String() = Encoding.Unicode.GetString(bytes3).Split(New Char() { ":"c })
							If array.Length = 2 Then
								Dim address As IPAddress = IPAddress.Parse(array(0))
								Dim port2 As Integer
								If Integer.TryParse(array(1), port2) Then
									Dim a_ As IPEndPoint = New IPEndPoint(address, port2)
									Dim o_0__O_o_O2 As O_0__O_o_O = New O_0__O_o_O(Me, udpClient, a_, A_1, A_0, text, A_2)
									o_0__O_o_O2.O00o___0OoO.0. = A_3
									Dim flag5 As Boolean = False
									Dim obj2 As Object = Me.ooOooo.oO.
									SyncLock obj2
										If Not Me.ooOooo.oO..ContainsKey(o_0__O_o_O2.O_OO.o0o_o0.()) Then
											Me.ooOooo.oO..Add(o_0__O_o_O2.O_OO.o0o_o0.(), o_0__O_o_O2)
											flag5 = True
										End If
									End SyncLock
									If flag5 Then
										flag4 = True
										o_0__O_o_O2.o0o_0OO00.Oo0_.()
										Exit While
									End If
									Exit While
								End If
							End If
						End If
					End While
				End If
				If flag Then
					If Not flag4 AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
						If A_2 = SendTypeEnum.Capture Then
							OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O0.O0OOo., New Object() { A_0, A_1 })
							Return
						End If
						If A_2 = SendTypeEnum.ManualFile Then
							OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O.00O0_O_o_oO., New Object() { A_0, A_1 })
							Return
						End If
					End If
				Else
					If A_2 = SendTypeEnum.AutoFile AndAlso A_0 IsNot Nothing AndAlso Not A_0.FromWeChat AndAlso Not(TypeOf A_0 Is ooo0) AndAlso Not(TypeOf A_0 Is O_0OOOoO) Then
						If A_0.OnLine Then
							Dim s As String = String.Concat(New String() { "%10", text2, Me.UserName, text2, Me.o_oo0Oooo.OOO_., text2, OO_00oOO.FileSys.GetName(A_1), text2, A_0.Name, text2, A_0.RandKey, text2, text })
							Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
							udpClient.Send(bytes, bytes.Length, Me.ooOo.oO0.)
							Dim now As DateTime = DateTime.Now
							While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
								If udpClient.Available > 0 Then
									Dim ipendPoint4 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
									Dim bytes4 As Byte() = udpClient.Receive(ipendPoint4)
									Dim array2 As String() = Encoding.Unicode.GetString(bytes4).Split(New Char() { vbTab })
									Dim port3 As Integer
									If array2.Length = 2 AndAlso Integer.TryParse(array2(0), port3) AndAlso Operators.CompareString(array2(1), text, True) = 0 Then
										Dim a_ As IPEndPoint = New IPEndPoint(Me.ooOo.oO0..Address, port3)
										Dim o_0__O_o_O3 As O_0__O_o_O = New O_0__O_o_O(Me, udpClient, a_, A_1, A_0, text, SendTypeEnum.AutoFile)
										Dim flag7 As Boolean = False
										Dim obj3 As Object = Me.ooOooo.oO.
										SyncLock obj3
											If Not Me.ooOooo.oO..ContainsKey(o_0__O_o_O3.O_OO.o0o_o0.()) Then
												Me.ooOooo.oO..Add(o_0__O_o_O3.O_OO.o0o_o0.(), o_0__O_o_O3)
												flag7 = True
											End If
										End SyncLock
										If flag7 Then
											flag4 = True
											o_0__O_o_O3.o0o_0OO00.Oo0_.()
											Exit While
										End If
										Exit While
									End If
								End If
							End While
						End If
					Else
						Dim s As String = String.Concat(New String() { "%3", text2, Me.UserName, text2, Me.o_oo0Oooo.OOO_., text2, OO_00oOO.FileSys.GetName(A_1), text2, Conversions.ToString(CInt(A_2)), text2, text })
						Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
						udpClient.Send(bytes, bytes.Length, Me.ooOo.oO0.)
						Dim now As DateTime = DateTime.Now
						While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
							If udpClient.Available > 0 Then
								Dim ipendPoint5 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
								Dim bytes5 As Byte() = udpClient.Receive(ipendPoint5)
								Dim array3 As String() = Encoding.Unicode.GetString(bytes5).Split(New Char() { vbTab })
								Dim port4 As Integer
								If array3.Length = 2 AndAlso Integer.TryParse(array3(1), port4) Then
									Dim a_ As IPEndPoint = New IPEndPoint(Me.ooOo.oO0..Address, port4)
									Dim o_0__O_o_O4 As O_0__O_o_O = New O_0__O_o_O(Me, udpClient, a_, A_1, A_0, text, A_2)
									o_0__O_o_O4.O00o___0OoO.0. = A_3
									o_0__O_o_O4.o_OoO._.(array3(0))
									Dim flag9 As Boolean = False
									Dim obj4 As Object = Me.ooOooo.oO.
									SyncLock obj4
										If Not Me.ooOooo.oO..ContainsKey(o_0__O_o_O4.O_OO.o0o_o0.()) Then
											Me.ooOooo.oO..Add(o_0__O_o_O4.O_OO.o0o_o0.(), o_0__O_o_O4)
											flag9 = True
										End If
									End SyncLock
									If flag9 Then
										flag4 = True
										o_0__O_o_O4.o0o_0OO00.Oo0_.()
										Exit While
									End If
									Exit While
								End If
							End If
						End While
					End If
					If Not flag4 AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
						If A_2 = SendTypeEnum.Capture Then
							OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O0.O0OOo., New Object() { A_0, A_1 })
							Return
						End If
						If A_2 = SendTypeEnum.ManualFile Then
							OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O.00O0_O_o_oO., New Object() { A_0, A_1 })
							Return
						End If
						If A_2 = SendTypeEnum.AutoFile Then
							Dim afterSendFileEventArgs As AfterSendFileEventArgs = New AfterSendFileEventArgs(Interaction.IIf(A_0 Is Nothing, "", A_0.Name).ToString(), A_1, False)
							OO_00oOO.BaseMainForm.Invoke(AddressOf Me.OOO__.0., New Object() { afterSendFileEventArgs })
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06001567 RID: 5479 RVA: 0x0008D0B0 File Offset: 0x0008B2B0
		Private Sub <<EMPTY_NAME>>(A_0 As IMBuddy, A_1 As String)
			Dim a_ As String = ChrW(2) & "/" & ChrW(2) & "=(" + A_1.Substring((OO_00oOO.ProjectPath + "QQClient\CaptureFiles\").Length) + ")=\" & ChrW(2)
			Me.O.00O0_O_o_oO.(A_0.Name, a_, 1, 1, Nothing)
		End Sub

		' Token: 0x06001568 RID: 5480 RVA: 0x0008D0F8 File Offset: 0x0008B2F8
		Private Sub <<EMPTY_NAME>>(A_0 As IMBuddy, A_1 As String)
			Dim fileInfo As FileInfo = New FileInfo(A_1)
			Dim a_ As String = String.Concat(New String() { ChrW(2) & "{因网络问题，文件发送失败""", OO_00oOO.FileSys.GetName(A_1), """(", o0___oO.o0__.0.(fileInfo.Length), ")}" & ChrW(2) })
			Me.O.00O0_O_o_oO.(A_0.Name, a_, 2, 1, Nothing)
		End Sub

		' Token: 0x06001569 RID: 5481 RVA: 0x0008D15D File Offset: 0x0008B35D
		Private Sub <<EMPTY_NAME>>(A_0 As AfterSendFileEventArgs)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_AfterSendFile", New Object() { A_0 }, True, "项目", False)
		End Sub

		' Token: 0x0600156A RID: 5482 RVA: 0x0008D180 File Offset: 0x0008B380
		<oO0oooo("2992")>
		Public Function ChangePassWord(OldPassword As String, NewPassword As String) As String
			Dim text As String = vbVerticalTab
			Dim a_ As String = String.Concat(New String() { ".", text, Me.UserName, text, Me.o_oo0Oooo.OOO_., text, OldPassword, text, NewPassword })
			Return Me.o00O0._0O.(a_, -1)
		End Function

		' Token: 0x0600156B RID: 5483 RVA: 0x0008D1DC File Offset: 0x0008B3DC
		<oO0oooo("3044")>
		Public Function RequestFile(FileName As String, Optional TimeOut As Integer = 5, Optional ShowProcess As Boolean = False) As Integer
			Me.o0.0o_00.()
			If(DateTime.Now - Me.O_00O_000.O0_.).TotalSeconds > 10.0 Then
				Me.O00._Oo..Clear()
			End If
			Me.O_00O_000.O0_. = DateTime.Now
			Dim key As String = OO_00oOO.FileSys.GetName(FileName).ToLower()
			If Me.O00._Oo..ContainsKey(key) Then
				Me.O00._Oo..Remove(key)
			End If
			If ShowProcess Then
				Me.O00._Oo..Add(key, DateTime.Now)
			End If
			Dim text As String = String.Concat(New String() { "%9" & vbVerticalTab, Me.UserName, vbVerticalTab, Me.o_oo0Oooo.OOO_., vbVerticalTab, FileName })
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(text)
			Me.O00._Oo..Send(bytes, bytes.Length, Me.ooOo.oO0.)
			Dim now As DateTime = DateTime.Now
			While (DateTime.Now - now).TotalSeconds < CDbl(TimeOut)
				If Me.O00._Oo..Available > 0 Then
					Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim bytes2 As Byte() = Me.O00._Oo..Receive(ipendPoint)
					text = Encoding.Unicode.GetString(bytes2)
					Exit While
				End If
			End While
			Dim result As Integer
			If Operators.CompareString(text, "None", True) = 0 Then
				result = 0
			ElseIf Operators.CompareString(text, "OK", True) = 0 Then
				result = 1
			Else
				result = 2
			End If
			Return result
		End Function

		' Token: 0x0600156C RID: 5484 RVA: 0x0008D348 File Offset: 0x0008B548
		<oO0oooo("A4103")>
		Public Sub AddWeChatUser(id As String, Name As String)
			Dim list As List(Of String) = New List(Of String)()
			Dim list2 As List(Of String) = New List(Of String)()
			list.Add(id)
			list2.Add(Name)
			Me.AddWeChatUsers(list, list2)
		End Sub

		' Token: 0x0600156D RID: 5485 RVA: 0x0008D378 File Offset: 0x0008B578
		<oO0oooo("A4104")>
		Public Sub AddWeChatUsers(IDS As List(Of String), Names As List(Of String))
			If IDS.Count = Names.Count Then
				Dim num As Integer = IDS.Count - 1
				For i As Integer = 0 To num
					If Not Me.O00.O0..ContainsKey(IDS(i)) Then
						Me.O00.O0..Add(IDS(i), Names(i))
					End If
				Next
				If Me.Ready Then
					Me.OOO__.0.(IDS, Names)
				End If
			End If
		End Sub

		' Token: 0x0600156E RID: 5486 RVA: 0x0008D3E8 File Offset: 0x0008B5E8
		Private Sub <<EMPTY_NAME>>(A_0 As List(Of String), A_1 As List(Of String))
			Dim num As Integer = A_0.Count - 1
			For i As Integer = 0 To num
				If Not Me.Buddies.Contains(A_0(i)) Then
					Dim imbuddy As IMBuddy = New IMBuddy(A_0(i), A_1(i))
					Me.Buddies.Oo___o.oo.(imbuddy)
					imbuddy.oo.0o_0O0_0. = Conversions.ToInteger(Me.oOOOo0.oo0OoO0..Compute("Count([_Identify])", "Name = '" + imbuddy.Name + "'"))
				End If
			Next
			If Me.ooOooo.oO. IsNot Nothing AndAlso Me.ooOooo.oO..Oo0_O0o.o_. Then
				Dim c1TopicPage As C1TopicPage = Me.ooOooo.oO..Oo.Oo00__oooo.().Pages(0)
				Dim num2 As Integer = A_0.Count - 1
				For j As Integer = 0 To num2
					If Me.Buddies.Contains(A_0(j)) Then
						Dim imbuddy2 As IMBuddy = Me.Buddies(A_0(j))
						Dim c1TopicPage2 As C1TopicPage = Me.ooOooo.oO..Oo.Oo00__oooo.().FindPage(imbuddy2.UserGroup)
						If c1TopicPage2 Is Nothing Then
							c1TopicPage2 = New C1TopicPage()
							c1TopicPage2.Text = imbuddy2.UserGroup
							c1TopicPage2.Collapsed = True
							c1TopicPage2.ImageList = Me.ooOooo.oO..O_0oOOO_.OO.()
							Me.ooOooo.oO..Oo.Oo00__oooo.().Pages.Add(c1TopicPage2)
						End If
						Dim c1TopicLink As C1TopicLink = New C1TopicLink()
						c1TopicLink.Text = imbuddy2.SimpleName
						c1TopicLink.Tag = imbuddy2
						c1TopicLink.ImageIndex = 20
						c1TopicPage2.Links.Add(c1TopicLink)
						If imbuddy2.oo.0o_0O0_0. > 0 Then
							c1TopicLink = New C1TopicLink()
							If imbuddy2.oo.0o_0O0_0. > 0 Then
								c1TopicLink.Text = imbuddy2.SimpleName + "(" + Conversions.ToString(imbuddy2.oo.0o_0O0_0.) + ")"
							Else
								c1TopicLink.Text = imbuddy2.SimpleName
							End If
							c1TopicLink.Tag = imbuddy2
							c1TopicLink.ImageIndex = 20
							c1TopicPage.Links.Add(c1TopicLink)
						End If
					End If
				Next
			End If
		End Sub

		' Token: 0x17000492 RID: 1170
		' (get) Token: 0x0600156F RID: 5487 RVA: 0x0008D5FC File Offset: 0x0008B7FC
		Public ReadOnly Property UnreadCount As Integer
			Get
				Return Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Me.oOOOo0.oo0OoO0..Compute("Count([_Identify])", "Read = 0")))
			End Get
		End Property

		' Token: 0x06001570 RID: 5488 RVA: 0x0008D620 File Offset: 0x0008B820
		Private Sub <<EMPTY_NAME>>(A_0 As IMBuddy, A_1 As String, A_2 As ooOoO)
			Dim oo0O__ As Oo0O__ = New Oo0O__(Me, A_0, A_1, A_2.o0OO._0.())
			oo0O__.o_0.Oo_0O0_. = True
			oo0O__.o.o_oo.().Text = OO_00oOO.FileSys.GetName(A_1)
			oo0O__.OOOO_.0O0o0.().Visible = False
			oo0O__.o0_0oO.0o0_.().Enabled = False
			If Me.ooOooo.oO. Is Nothing Then
				Me.ooOooo.oO. = New o\u3000\u3002\u3000\u3002\u3000(Me)
				Me.ooOooo.oO..Owner = OO_00oOO.BaseMainForm
			End If
			Me.ooOooo.oO..O_0O_o.0.(oo0O__)
			Me.ooOooo.oO..Show()
			A_2.O0__00OoOo_O.o. = oo0O__
		End Sub

		' Token: 0x17000493 RID: 1171
		' (get) Token: 0x06001571 RID: 5489 RVA: 0x0008D6B3 File Offset: 0x0008B8B3
		' (set) Token: 0x06001572 RID: 5490 RVA: 0x0008D6BB File Offset: 0x0008B8BB
		<oO0oooo("3076")>
		Public Property MenuItems As String
			Get
				Return Me.o_O.OOO.
			End Get
			Set(value As String)
				Me.o_O.OOO. = value
				If Me.ooOooo.oO. IsNot Nothing AndAlso Me.ooOooo.oO..Oo0_O0o.o_. Then
					Me.ooOooo.oO..o_0_o000O_0.O0.()
				End If
			End Set
		End Property

		' Token: 0x06001573 RID: 5491 RVA: 0x0008D6E4 File Offset: 0x0008B8E4
		Friend Sub <<EMPTY_NAME>>(A_0 As Form)
			If Me.ooOooo.oO. IsNot Nothing AndAlso Me.ooOooo.oO..Visible Then
				Dim location As Point = Me.ooOooo.oO..Location
				Dim value As Integer = Me.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Value
				Dim dictionary As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)()
				Dim obj As Object = Nothing
				If Me.ooOooo.oO..o.0_0_Ooo. IsNot Nothing Then
					obj = RuntimeHelpers.GetObjectValue(Me.ooOooo.oO..o.0_0_Ooo..Tag)
				End If
				Try
					For Each obj2 As Object In Me.ooOooo.oO..Oo.Oo00__oooo.().Pages
						Dim c1TopicPage As C1TopicPage = CType(obj2, C1TopicPage)
						dictionary.Add(c1TopicPage.Text, c1TopicPage.Collapsed)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.ooOooo.oO..Close()
				Me.ooOooo.oO. = Nothing
				Me.OpenChatWindow()
				Me.ooOooo.oO..Location = location
				Try
					For Each obj3 As Object In Me.ooOooo.oO..Oo.Oo00__oooo.().Pages
						Dim c1TopicPage2 As C1TopicPage = CType(obj3, C1TopicPage)
						If dictionary.ContainsKey(c1TopicPage2.Text) Then
							c1TopicPage2.Collapsed = dictionary(c1TopicPage2.Text)
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Me.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Value = Math.Max(Me.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Minimum, Math.Min(value, Me.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Maximum))
				If obj Is Nothing Then
					Return
				End If
				Try
					For Each obj4 As Object In Me.ooOooo.oO..Oo.Oo00__oooo.().Pages
						Dim c1TopicLink As C1TopicLink = CType(obj4, C1TopicPage).FindLinkByTag(RuntimeHelpers.GetObjectValue(obj))
						If c1TopicLink IsNot Nothing Then
							Me.ooOooo.oO..oOO_._0_0o_0.(c1TopicLink)
							Exit For
						End If
					Next
					Return
				Finally
					Dim enumerator3 As IEnumerator
					If TypeOf enumerator3 Is IDisposable Then
						TryCast(enumerator3, IDisposable).Dispose()
					End If
				End Try
			End If
			Me.OpenChatWindow()
		End Sub

		' Token: 0x04000878 RID: 2168
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000879 RID: 2169
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400087A RID: 2170
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400087B RID: 2171
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400087C RID: 2172
		Friend <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x0400087D RID: 2173
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x0400087E RID: 2174
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400087F RID: 2175
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000880 RID: 2176
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000881 RID: 2177
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04000882 RID: 2178
		Private <<EMPTY_NAME>> As System.Threading.Timer

		' Token: 0x04000883 RID: 2179
		Friend <<EMPTY_NAME>> As UdpClient

		' Token: 0x04000884 RID: 2180
		Friend <<EMPTY_NAME>> As UdpClient

		' Token: 0x04000885 RID: 2181
		Private <<EMPTY_NAME>> As ReaderWriterLock

		' Token: 0x04000886 RID: 2182
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000887 RID: 2183
		Friend <<EMPTY_NAME>> As Queue(Of oO__oO_0_O)

		' Token: 0x04000888 RID: 2184
		Private <<EMPTY_NAME>> As IMBuddyCollections

		' Token: 0x04000889 RID: 2185
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400088A RID: 2186
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400088B RID: 2187
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400088C RID: 2188
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400088D RID: 2189
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public StopHeartbratServer As Boolean

		' Token: 0x0400088E RID: 2190
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public StopHeartbratBuddy As Boolean

		' Token: 0x0400088F RID: 2191
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000890 RID: 2192
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000891 RID: 2193
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000892 RID: 2194
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000893 RID: 2195
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000894 RID: 2196
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000895 RID: 2197
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000896 RID: 2198
		Friend <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04000897 RID: 2199
		Friend <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x04000898 RID: 2200
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x04000899 RID: 2201
		Friend <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x0400089A RID: 2202
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x0400089B RID: 2203
		Private <<EMPTY_NAME>> As OleDbCommand

		' Token: 0x0400089C RID: 2204
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400089D RID: 2205
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400089E RID: 2206
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400089F RID: 2207
		Friend <<EMPTY_NAME>> As f4

		' Token: 0x040008A0 RID: 2208
		Friend <<EMPTY_NAME>> As o\u3000\u3002\u3000\u3002\u3000

		' Token: 0x040008A1 RID: 2209
		Friend <<EMPTY_NAME>> As Dictionary(Of String, ooo0)

		' Token: 0x040008A2 RID: 2210
		Friend <<EMPTY_NAME>> As Dictionary(Of String, O_0OOOoO)

		' Token: 0x040008A3 RID: 2211
		Friend <<EMPTY_NAME>> As Dictionary(Of String, ooOoO)

		' Token: 0x040008A4 RID: 2212
		Friend <<EMPTY_NAME>> As Dictionary(Of String, O_0__O_o_O)

		' Token: 0x040008A5 RID: 2213
		Friend <<EMPTY_NAME>> As Dictionary(Of String, O_0__O_o_O)

		' Token: 0x040008A6 RID: 2214
		Friend <<EMPTY_NAME>> As List(Of Object)

		' Token: 0x040008A7 RID: 2215
		Friend <<EMPTY_NAME>> As List(Of Integer)

		' Token: 0x040008A8 RID: 2216
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x040008A9 RID: 2217
		Friend <<EMPTY_NAME>> As Object

		' Token: 0x040008AA RID: 2218
		Friend <<EMPTY_NAME>> As List(Of Integer)

		' Token: 0x040008AB RID: 2219
		Friend <<EMPTY_NAME>> As Dictionary(Of Integer, O0o000)

		' Token: 0x040008AC RID: 2220
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x040008AD RID: 2221
		Friend <<EMPTY_NAME>> As DateTime

		' Token: 0x040008AE RID: 2222
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040008AF RID: 2223
		Friend <<EMPTY_NAME>> As Dictionary(Of String, DateTime)

		' Token: 0x040008B0 RID: 2224
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040008B1 RID: 2225
		Private <<EMPTY_NAME>> As Dictionary(Of String, DateTime)

		' Token: 0x040008B2 RID: 2226
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x040008B3 RID: 2227
		Private <<EMPTY_NAME>> As String

		' Token: 0x040008B4 RID: 2228
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x020002DE RID: 734
		' (Invoke) Token: 0x06002719 RID: 10009
		Private Delegate Sub OO_0_(A_0 As IMBuddy, A_1 As String)

		' Token: 0x020002DF RID: 735
		' (Invoke) Token: 0x0600271D RID: 10013
		Private Delegate Sub o_oOO_(A_0 As AfterSendFileEventArgs)

		' Token: 0x020002E0 RID: 736
		' (Invoke) Token: 0x06002721 RID: 10017
		Private Delegate Sub o00o_(A_0 As IMBuddy, A_1 As String, A_2 As ooOoO)
	End Class
End Namespace
