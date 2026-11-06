Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002DC RID: 732
	<oO0oooo("2979")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class IMServer
		' Token: 0x060026D8 RID: 9944 RVA: 0x00107BB8 File Offset: 0x00105DB8
		Public Sub New(A_0 As String)
			Me.oo._0oo_00O. = -1
			Me.OOOOoo_0o.Oo. = -1
			Me.o_O0O00OO0.00. = True
			Me.O_O.Oo0000. = 30
			Me.OO_.OO. = 100
			Me.o0oo__0Oo_.o00. = True
			Me.ooO_.O0_. = New ReaderWriterLock()
			Me.o_O0O00OO0.00. = New IMUserCollections()
			Me.ooO_.O0_. = New Queue(Of oO__oO_0_O)()
			Me.oOOO_0o.oo. = 81920
			Me.O._OoOO0o. = 81920
			Me.o_O0O00OO0.00. = New Dictionary(Of String, o0o0_oo00Oo)()
			Me.ooO_.O0_. = New Dictionary(Of String, ooOoO)()
			Me.ooO_.O0_. = New Dictionary(Of String, O_0__O_o_O)()
			Me.oo._0oo_00O. = A_0
		End Sub

		' Token: 0x170008AC RID: 2220
		' (get) Token: 0x060026D9 RID: 9945 RVA: 0x00107C56 File Offset: 0x00105E56
		Public ReadOnly Property Users As IMUserCollections
			Get
				Return Me.o_O0O00OO0.00.
			End Get
		End Property

		' Token: 0x170008AD RID: 2221
		' (get) Token: 0x060026DA RID: 9946 RVA: 0x00107C5E File Offset: 0x00105E5E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Name As String
			Get
				Return Me.oo._0oo_00O.
			End Get
		End Property

		' Token: 0x170008AE RID: 2222
		' (get) Token: 0x060026DB RID: 9947 RVA: 0x00107C66 File Offset: 0x00105E66
		Public ReadOnly Property Ready As Boolean
			Get
				Return Not Me.o0oo__0Oo_.o00.
			End Get
		End Property

		' Token: 0x170008AF RID: 2223
		' (get) Token: 0x060026DC RID: 9948 RVA: 0x00107C71 File Offset: 0x00105E71
		' (set) Token: 0x060026DD RID: 9949 RVA: 0x00107C79 File Offset: 0x00105E79
		Public Property ServerIP As String
			Get
				Return Me.ooO_.O0_.
			End Get
			Set(value As String)
				Me.ooO_.O0_. = value
			End Set
		End Property

		' Token: 0x170008B0 RID: 2224
		' (get) Token: 0x060026DE RID: 9950 RVA: 0x00107C82 File Offset: 0x00105E82
		' (set) Token: 0x060026DF RID: 9951 RVA: 0x00107C8A File Offset: 0x00105E8A
		Public Property ServerPort As Integer
			Get
				Return Me.ooO_.O0_.
			End Get
			Set(value As Integer)
				Me.ooO_.O0_. = value
			End Set
		End Property

		' Token: 0x170008B1 RID: 2225
		' (get) Token: 0x060026E0 RID: 9952 RVA: 0x00107C93 File Offset: 0x00105E93
		' (set) Token: 0x060026E1 RID: 9953 RVA: 0x00107C9B File Offset: 0x00105E9B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property MonitorHeartbeat As Boolean
			Get
				Return Me.o_O0O00OO0.00.
			End Get
			Set(value As Boolean)
				Me.o_O0O00OO0.00. = value
			End Set
		End Property

		' Token: 0x170008B2 RID: 2226
		' (get) Token: 0x060026E2 RID: 9954 RVA: 0x00107CA4 File Offset: 0x00105EA4
		' (set) Token: 0x060026E3 RID: 9955 RVA: 0x00107CAC File Offset: 0x00105EAC
		Public Property HeartbeatInterval As Integer
			Get
				Return Me.O_O.Oo0000.
			End Get
			Set(value As Integer)
				If value < 5 Then
					value = 5
				End If
				Me.O_O.Oo0000. = value
			End Set
		End Property

		' Token: 0x170008B3 RID: 2227
		' (get) Token: 0x060026E4 RID: 9956 RVA: 0x00107CBC File Offset: 0x00105EBC
		' (set) Token: 0x060026E5 RID: 9957 RVA: 0x00107CC4 File Offset: 0x00105EC4
		Public Property HeartbeatTimeout As Integer
			Get
				Return Me.OO_.OO.
			End Get
			Set(value As Integer)
				If value < 10 Then
					value = 10
				End If
				Me.OO_.OO. = value
			End Set
		End Property

		' Token: 0x170008B4 RID: 2228
		' (get) Token: 0x060026E6 RID: 9958 RVA: 0x00107CD6 File Offset: 0x00105ED6
		' (set) Token: 0x060026E7 RID: 9959 RVA: 0x00107CDE File Offset: 0x00105EDE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ReceiveBufferSize As Integer
			Get
				Return Me.oOOO_0o.oo.
			End Get
			Set(value As Integer)
				Me.oOOO_0o.oo. = value
			End Set
		End Property

		' Token: 0x170008B5 RID: 2229
		' (get) Token: 0x060026E8 RID: 9960 RVA: 0x00107CE7 File Offset: 0x00105EE7
		' (set) Token: 0x060026E9 RID: 9961 RVA: 0x00107CEF File Offset: 0x00105EEF
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SendBufferSize As Integer
			Get
				Return Me.O._OoOO0o.
			End Get
			Set(value As Integer)
				Me.O._OoOO0o. = value
			End Set
		End Property

		' Token: 0x170008B6 RID: 2230
		' (get) Token: 0x060026EA RID: 9962 RVA: 0x00107CF8 File Offset: 0x00105EF8
		' (set) Token: 0x060026EB RID: 9963 RVA: 0x00107D00 File Offset: 0x00105F00
		Public Property Buildin As Boolean
			Get
				Return Me.o__00O.o_o0_o0.
			End Get
			Set(value As Boolean)
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.o.0_O_O. })
				If dataRow IsNot Nothing AndAlso Operators.CompareString(dataRow("Config").ToString(), "1", True) = 0 Then
					Me.o__00O.o_o0_o0. = value
				End If
			End Set
		End Property

		' Token: 0x170008B7 RID: 2231
		' (get) Token: 0x060026EC RID: 9964 RVA: 0x00107D6B File Offset: 0x00105F6B
		Friend ReadOnly Property MeetingInfos As Dictionary(Of String, o0o0_oo00Oo)
			Get
				Return Me.o_O0O00OO0.00.
			End Get
		End Property

		' Token: 0x170008B8 RID: 2232
		' (get) Token: 0x060026ED RID: 9965 RVA: 0x00107D73 File Offset: 0x00105F73
		' (set) Token: 0x060026EE RID: 9966 RVA: 0x00107D7C File Offset: 0x00105F7C
		<oO0oooo("3247")>
		Public Property PortRange As String
			Get
				Return Me.OOOOoo_0o.Oo.
			End Get
			Set(value As String)
				Me.OOOOoo_0o.Oo. = value
				Me.oo._0oo_00O. = -1
				Me.OOOOoo_0o.Oo. = -1
				If Operators.CompareString(value, "", True) > 0 Then
					Dim array As String() = value.Split(New Char() { "/"c, "\"c })
					If array.Length >= 1 AndAlso Integer.TryParse(array(0), Me.oo._0oo_00O.) Then
						Me.oo._0oo_00O. = Math.Max(0, Me.oo._0oo_00O.)
					End If
					If array.Length >= 2 AndAlso Integer.TryParse(array(1), Me.OOOOoo_0o.Oo.) Then
						Me.OOOOoo_0o.Oo. = Math.Min(65535, Me.OOOOoo_0o.Oo.)
					End If
				End If
			End Set
		End Property

		' Token: 0x060026EF RID: 9967 RVA: 0x00107E18 File Offset: 0x00106018
		<oO0oooo("3024")>
		Public Function Start() As Boolean
			Dim result As Boolean
			If Me.ooO_.O0_. IsNot Nothing Then
				MessageBox.Show("此IMServer已经启动，请先停止，才能重新启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf Me.ooO_.O0_. = 0 Then
				MessageBox.Show("必须同时指定端口,才能启动IMServer!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				Me.Users.o_.oOoo_0.()
				Try
					Dim localEP As IPEndPoint
					If Operators.CompareString(Me.ooO_.O0_., "", True) = 0 Then
						localEP = New IPEndPoint(IPAddress.Any, Me.ooO_.O0_.)
					Else
						localEP = New IPEndPoint(IPAddress.Parse(Me.ooO_.O0_.), Me.ooO_.O0_.)
					End If
					Me.ooO_.O0_. = New UdpClient(localEP)
					Me.ooO_.O0_..Client.ReceiveBufferSize = Me.ReceiveBufferSize
					Me.ooO_.O0_..Client.SendBufferSize = Me.SendBufferSize
					o0___oO.O.oOo0O0O.(Me.ooO_.O0_.)
					Me.o0oo__0Oo_.o00. = False
					Me.Oo__o._0_.()
					Me.O0o_.Oo0oo.()
					Me.o.Ooo_.()
					result = True
				Catch a_ As Exception
					Me.o0oo__0Oo_.o00. = True
					If Me.ooO_.O0_. IsNot Nothing Then
						Me.ooO_.O0_..Close()
						Me.ooO_.O0_. = Nothing
					End If
					ooO.oOo0Oo.o.(a_, "启动IMServer")
					result = False
				End Try
			End If
			Return result
		End Function

		' Token: 0x060026F0 RID: 9968 RVA: 0x00107F60 File Offset: 0x00106160
		Public Sub [Stop]()
			Me.o0oo__0Oo_.o00. = True
			Me.ooO_.O0_..AcquireWriterLock(-1)
			Dim ex As Exception = Nothing
			Try
				Try
					For Each imuser As IMUser In Me.Users
						Dim a_ As String = "&3" & vbVerticalTab + imuser.Name + vbVerticalTab + Me.Users(imuser.Name).OO__o_.O0_0O_0.
						Me.oOOOo._.(imuser.Name, a_)
					Next
				Finally
					Dim enumerator As IEnumerator(Of IMUser)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Me.Users.o_.oOoo_0.()
				Me.MeetingInfos.Clear()
				Dim obj As Object = Me.ooO_.O0_.
				SyncLock obj
					Me.ooO_.O0_..Clear()
				End SyncLock
				If Me.ooO_.O0_. IsNot Nothing Then
					Me.ooO_.O0_..Close()
					Me.ooO_.O0_. = Nothing
				End If
				If Me.O0O_.O. IsNot Nothing Then
					If Me.O0O_.O..State = ConnectionState.Open Then
						Me.O0O_.O..Close()
					End If
					Me.O0O_.O. = Nothing
				End If
			Catch ex2 As Exception
				ex = ex2
			Finally
				Me.ooO_.O0_..ReleaseWriterLock()
			End Try
			If ex IsNot Nothing Then
				ooO.oOo0Oo.o.(ex, "关闭IMServer")
			End If
		End Sub

		' Token: 0x060026F1 RID: 9969 RVA: 0x001080CC File Offset: 0x001062CC
		<oO0oooo("3026")>
		Public Sub KickOff(UserName As String)
			If Me.Users.Contains(UserName) Then
				Dim a_ As String = "&1" & vbVerticalTab + UserName + vbVerticalTab + Me.Users(UserName).OO__o_.O0_0O_0.
				Me.oOOOo._.(UserName, a_)
				a_ = "!2" & vbVerticalTab + UserName + vbVerticalTab + Me.Users(UserName).OO__o_.O0_0O_0.
				Try
					For Each imuser As IMUser In Me.Users
						If imuser.Buddies.Contains(UserName) Then
							Me.oOOOo._.(imuser.Name, a_)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of IMUser)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Me.Users.o_.oOoo_0.(UserName)
				Dim server_UserLogoutEventArgs As Server_UserLogoutEventArgs = New Server_UserLogoutEventArgs(UserName, Me, 2)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", New Object() { server_UserLogoutEventArgs }, True, "项目", False)
			End If
		End Sub

		' Token: 0x060026F2 RID: 9970 RVA: 0x001081C0 File Offset: 0x001063C0
		Private Sub <<EMPTY_NAME>>()
			Me.ooO_.O0_..AcquireReaderLock(-1)
			Dim ex As Exception = Nothing
			Try
				Me.ooO_.O0_..BeginReceive(AddressOf Me.O0o_.Oo0oo., Nothing)
			Catch ex2 As Exception
				ex = ex2
			Finally
				Me.ooO_.O0_..ReleaseReaderLock()
			End Try
			If ex IsNot Nothing Then
				Me.[Stop]()
				ooO.oOo0Oo.o.(ex, "IMServer异步接收")
			End If
		End Sub

		' Token: 0x060026F3 RID: 9971 RVA: 0x00108244 File Offset: 0x00106444
		Private Sub <<EMPTY_NAME>>(A_0 As IAsyncResult)
			If Not Me.o0oo__0Oo_.o00. Then
				Me.ooO_.O0_..AcquireReaderLock(-1)
				Dim ex As Exception = Nothing
				Try
					Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim array As Byte() = Me.ooO_.O0_..EndReceive(A_0, ipendPoint)
					Dim text As String = Encoding.Unicode.GetString(array)
					If Operators.CompareString(text, "", True) > 0 Then
						If Operators.CompareString(text, ChrW(5) & vbVerticalTab & ChrW(5), True) = 0 Then
							Me.ooO_.O0_..Send(array, array.Length, ipendPoint)
						ElseIf text.StartsWith("#" & vbVerticalTab) Then
							Dim array2 As String() = text.Split(New Char() { vbVerticalTab })
							If Me.Users.Contains(array2(1)) AndAlso Operators.CompareString(Me.Users(array2(1)).OO__o_.O0_0O_0., array2(2), True) = 0 Then
								Me.ooO_.O0_..Send(array, array.Length, ipendPoint)
								Me.Users(array2(1)).LastHeartbeatTime = DateTime.Now
							End If
						ElseIf text.StartsWith("=$" & vbVerticalTab) Then
							Dim array3 As String() = text.Split(New Char() { vbVerticalTab })
							If array3.Length = 5 Then
								If array3(1).StartsWith("""") AndAlso array3(1).EndsWith("""") Then
									Me.ooO_.O0_..Enqueue(New oO__oO_0_O(ipendPoint, text))
								ElseIf Me.Users.Contains(array3(1)) AndAlso Me.Users.Contains(array3(2)) AndAlso Operators.CompareString(Me.Users(array3(2)).OO__o_.O0_0O_0., array3(4), True) = 0 Then
									text = String.Concat(New String() { "$" & vbVerticalTab, array3(2), vbVerticalTab, array3(3), vbVerticalTab, array3(4) })
									Me.oOOOo._.(array3(1), text)
								Else
									text = "$" & vbVerticalTab + array3(2) + vbVerticalTab + array3(3)
									Me.O0O_.O..CommandText = "Insert Into [Messages] ([Receiver],[Time],[Content]) Values(?, #" + Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") + "#,?)"
									Me.O0O_.O..Parameters.Clear()
									Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", array3(1)))
									Me.O0O_.O..Parameters.Add(New OleDbParameter("@p2", text))
									Me.O0O_.O..ExecuteNonQuery()
								End If
							End If
						ElseIf text.StartsWith("*" & vbVerticalTab) Then
							Dim array4 As String() = text.Split(New Char() { vbVerticalTab })
							If array4.Length = 7 AndAlso Me.Users.Contains(array4(1)) AndAlso Operators.CompareString(Me.Users(array4(1)).OO__o_.O0_0O_0., array4(2), True) = 0 Then
								Dim s As String = "{OK}"
								Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
								Me.ooO_.O0_..Send(bytes, bytes.Length, ipendPoint)
								AddressOf Me.O0o_.Oo0oo..Start(array4)
							End If
						ElseIf text.StartsWith("*1" & vbVerticalTab) Then
							Dim array5 As String() = text.Split(New Char() { vbVerticalTab })
							If array5.Length = 6 Then
								Dim value As Char = vbVerticalTab
								If Me.Users.Contains(array5(1)) AndAlso Me.Users.Contains(array5(2)) AndAlso Operators.CompareString(Me.Users(array5(2)).OO__o_.O0_0O_0., array5(3), True) = 0 Then
									text = String.Concat(New String() { "*1", Conversions.ToString(value), array5(2), Conversions.ToString(value), array5(3), Conversions.ToString(value), array5(4), Conversions.ToString(value), array5(5) })
									Me.oOOOo._.(array5(1), text)
								Else
									text = String.Concat(New String() { "*1", Conversions.ToString(value), array5(2), Conversions.ToString(value), array5(4), Conversions.ToString(value), array5(5) })
									Me.O0O_.O..CommandText = "Insert Into [Messages] ([Receiver],[Time],[Content]) Values(?, #" + Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") + "#, ?)"
									Me.O0O_.O..Parameters.Clear()
									Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", array5(1)))
									Me.O0O_.O..Parameters.Add(New OleDbParameter("@p2", text))
									Me.O0O_.O..ExecuteNonQuery()
								End If
							End If
						ElseIf text.StartsWith("*2" & vbVerticalTab) Then
							Dim array6 As String() = text.Split(New Char() { vbVerticalTab })
							If array6.Length = 4 AndAlso Me.MeetingInfos.ContainsKey(array6(3)) AndAlso Me.Users.Contains(array6(1)) AndAlso Operators.CompareString(Me.MeetingInfos(array6(3)).O_oO._O.(), array6(1), True) = 0 AndAlso Operators.CompareString(Me.Users(array6(1)).OO__o_.O0_0O_0., array6(2), True) = 0 Then
								Me.O0O_.O..CommandText = "Delete From [Meetings] Where [MeetingKey]  = '" + array6(3) + "'"
								Me.O0O_.O..ExecuteNonQuery()
								Try
									For Each text2 As String In Me.MeetingInfos(array6(3)).o.oo_o0O.()
										If Me.Users.Contains(text2) Then
											Me.oOOOo._.(text2, text)
										End If
									Next
								Finally
									Dim enumerator As List(Of String).Enumerator
									CType(enumerator, IDisposable).Dispose()
								End Try
								Me.MeetingInfos.Remove(array6(3))
							End If
						ElseIf text.StartsWith("*3" & vbVerticalTab) Then
							Dim array7 As String() = text.Split(New Char() { vbVerticalTab })
							If array7.Length = 5 AndAlso Me.MeetingInfos.ContainsKey(array7(3)) AndAlso Me.Users.Contains(array7(1)) AndAlso Operators.CompareString(Me.MeetingInfos(array7(3)).O_oO._O.(), array7(1), True) = 0 AndAlso Operators.CompareString(Me.Users(array7(1)).OO__o_.O0_0O_0., array7(2), True) = 0 Then
								Me.MeetingInfos(array7(3)).o.oo_o0O.(array7(4))
								Me.O0O_.O..CommandText = String.Concat(New String() { "Update [Meetings] Set [Members] = '", array7(4), "' Where [MeetingKey]  = '", array7(3), "'" })
								Me.O0O_.O..ExecuteNonQuery()
							End If
						ElseIf text.StartsWith("%1" & vbVerticalTab) Then
							Dim array8 As String() = text.Split(New Char() { vbVerticalTab })
							Dim value2 As Char = vbVerticalTab
							If array8.Length = 9 Then
								If Me.Users.Contains(array8(1)) AndAlso Operators.CompareString(Me.Users(array8(1)).OO__o_.O0_0O_0., array8(2), True) = 0 AndAlso Me.Users.Contains(array8(3)) AndAlso Operators.CompareString(Me.Users(array8(3)).OO__o_.O0_0O_0., array8(4), True) = 0 Then
									text = String.Concat(New String() { "%1", Conversions.ToString(value2), array8(1), Conversions.ToString(value2), array8(5), Conversions.ToString(value2), array8(6), Conversions.ToString(value2), array8(7), Conversions.ToString(value2), ipendPoint.ToString(), Conversions.ToString(value2), array8(8) })
									Me.oOOOo._.(array8(3), text)
								End If
							ElseIf array8.Length = 4 AndAlso Me.Users.Contains(array8(1)) Then
								Dim ipString As String = array8(3).Substring(0, array8(3).IndexOf(":"))
								Dim value3 As String = array8(3).Substring(array8(3).IndexOf(":") + 1)
								Dim endPoint As IPEndPoint = New IPEndPoint(IPAddress.Parse(ipString), Conversions.ToInteger(value3))
								Dim bytes2 As Byte() = Encoding.Unicode.GetBytes(array8(2))
								Me.ooO_.O0_..Send(bytes2, bytes2.Length, endPoint)
							End If
						ElseIf text.StartsWith("%2" & vbVerticalTab) Then
							Dim array9 As String() = text.Split(New Char() { vbVerticalTab })
							Dim value4 As Char = vbVerticalTab
							If array9.Length = 8 Then
								If Me.Users.Contains(array9(1)) AndAlso Operators.CompareString(Me.Users(array9(1)).OO__o_.O0_0O_0., array9(2), True) = 0 AndAlso Me.Users.Contains(array9(5)) AndAlso Operators.CompareString(Me.Users(array9(5)).OO__o_.O0_0O_0., array9(6), True) = 0 Then
									text = String.Concat(New String() { "%2", Conversions.ToString(value4), array9(1), Conversions.ToString(value4), array9(3), Conversions.ToString(value4), array9(4), Conversions.ToString(value4), ipendPoint.ToString(), Conversions.ToString(value4), array9(7) })
									Me.oOOOo._.(array9(5), text)
								End If
							ElseIf array9.Length = 3 AndAlso Me.Users.Contains(array9(1)) Then
								Dim ipString2 As String = array9(2).Substring(0, array9(2).IndexOf(":"))
								Dim value5 As String = array9(2).Substring(array9(2).IndexOf(":") + 1)
								Dim endPoint2 As IPEndPoint = New IPEndPoint(IPAddress.Parse(ipString2), Conversions.ToInteger(value5))
								Dim bytes3 As Byte() = Encoding.Unicode.GetBytes(ipendPoint.ToString())
								Me.ooO_.O0_..Send(bytes3, bytes3.Length, endPoint2)
							End If
						ElseIf text.StartsWith("%02" & vbVerticalTab) Then
							Dim array10 As String() = text.Split(New Char() { vbVerticalTab })
							Dim value6 As Char = vbVerticalTab
							If array10.Length = 5 AndAlso Me.Users.Contains(array10(1)) AndAlso Operators.CompareString(Me.Users(array10(1)).OO__o_.O0_0O_0., array10(2), True) = 0 Then
								Dim ipString3 As String = array10(3).Substring(0, array10(3).IndexOf(":"))
								Dim value7 As String = array10(3).Substring(array10(3).IndexOf(":") + 1)
								Dim endPoint3 As IPEndPoint = New IPEndPoint(IPAddress.Parse(ipString3), Conversions.ToInteger(value7))
								Dim bytes4 As Byte() = Encoding.Unicode.GetBytes(String.Concat(New String() { "%02", Conversions.ToString(value6), array10(4), Conversions.ToString(value6), ipendPoint.ToString() }))
								Me.ooO_.O0_..Send(bytes4, bytes4.Length, endPoint3)
							End If
						ElseIf text.StartsWith("%10" & vbVerticalTab) Then
							Dim array11 As String() = text.Split(New Char() { vbVerticalTab })
							If array11.Length = 7 AndAlso Me.Users.Contains(array11(1)) AndAlso Operators.CompareString(Me.Users(array11(1)).OO__o_.O0_0O_0., array11(2), True) = 0 AndAlso Me.Users.Contains(array11(4)) AndAlso Operators.CompareString(Me.Users(array11(4)).OO__o_.O0_0O_0., array11(5), True) = 0 Then
								AddressOf New oO_o_0_o_O_o() With { .O00.oo0_0oo. = ipendPoint, .O00.oo0_0oo. = array11(3), .O00.oo0_0oo. = Me.Users(array11(1)), .oO.o0_O_. = Me.Users(array11(4)), .oO.o0_O_. = array11(6), .O00.oo0_0oo. = Me }.O___o.o..Start()
							End If
						ElseIf text.StartsWith("%3" & vbVerticalTab) Then
							Dim array12 As String() = text.Split(New Char() { vbVerticalTab })
							If array12.Length = 6 AndAlso Me.Users.Contains(array12(1)) AndAlso Operators.CompareString(Me.Users(array12(1)).OO__o_.O0_0O_0., array12(2), True) = 0 Then
								Dim text3 As String = Me.O0o_.Oo0oo.(array12(3))
								Dim udpClient As UdpClient = o0___oO.o0__.0.(Me)
								o0___oO.O.oOo0O0O.(udpClient)
								udpClient.Client.ReceiveBufferSize = 81920
								Dim text4 As String = udpClient.Client.LocalEndPoint.ToString()
								text4 = text3.Substring((OO_00oOO.ProjectPath + "QQServer\UploadFiles\").Length) + vbTab + text4.Substring(text4.IndexOf(":") + 1)
								Dim bytes5 As Byte() = Encoding.Unicode.GetBytes(text4)
								Me.ooO_.O0_..Send(bytes5, bytes5.Length, ipendPoint)
								Dim ooOoO As ooOoO = New ooOoO(Me, udpClient, ipendPoint, text3, array12(1), array12(5), CType(Conversions.ToInteger(array12(4)), SendTypeEnum))
								Dim flag As Boolean = False
								Dim obj As Object = Me.ooO_.O0_.
								SyncLock obj
									If Not Me.ooO_.O0_..ContainsKey(ooOoO.o0OO._0.()) Then
										Me.ooO_.O0_..Add(ooOoO.o0OO._0.(), ooOoO)
										flag = True
									End If
								End SyncLock
								If flag Then
									AddressOf ooOoO.O_OOOooo_0.O..Start()
								End If
							End If
						ElseIf text.StartsWith("%4" & vbVerticalTab) Then
							Dim array13 As String() = text.Split(New Char() { vbVerticalTab })
							If array13.Length = 4 AndAlso Me.Users.Contains(array13(1)) AndAlso Operators.CompareString(Me.Users(array13(1)).OO__o_.O0_0O_0., array13(2), True) = 0 Then
								Dim parameter As Object() = New Object() { array13(3), ipendPoint }
								AddressOf Me.o__00O.o_o0_o0..Start(parameter)
							End If
						ElseIf text.StartsWith("%9" & vbVerticalTab) Then
							Dim array14 As String() = text.Split(New Char() { vbVerticalTab })
							If array14.Length = 4 AndAlso Me.Users.Contains(array14(1)) AndAlso Operators.CompareString(Me.Users(array14(1)).OO__o_.O0_0O_0., array14(2), True) = 0 Then
								Dim text5 As String = Path.Combine(OO_00oOO.ProjectPath + "QQServer\UploadFiles\", array14(3))
								If Not text5.StartsWith(OO_00oOO.ProjectPath + "QQServer\UploadFiles\") OrElse Not OO_00oOO.FileSys.FileExists(text5) Then
									array = Encoding.Unicode.GetBytes("None")
									Me.ooO_.O0_..Send(array, array.Length, ipendPoint)
								Else
									array = Encoding.Unicode.GetBytes("OK")
									Me.ooO_.O0_..Send(array, array.Length, ipendPoint)
									Me.SendFile(array14(1), text5)
								End If
							End If
						Else
							Dim obj2 As Object = Me.ooO_.O0_.
							SyncLock obj2
								Me.ooO_.O0_..Enqueue(New oO__oO_0_O(ipendPoint, text))
							End SyncLock
						End If
					End If
				Catch ex2 As Exception
					ex = ex2
				Finally
					Me.ooO_.O0_..ReleaseReaderLock()
				End Try
				If ex Is Nothing Then
					If Not Me.o0oo__0Oo_.o00. Then
						Me.o.Ooo_.()
						Return
					End If
				Else
					Me.[Stop]()
					ooO.oOo0Oo.o.(ex, "IMServer异步接收回调过程")
				End If
			End If
		End Sub

		' Token: 0x060026F4 RID: 9972 RVA: 0x0010930C File Offset: 0x0010750C
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Try
				Dim array As Object() = CType(A_0, Object())
				Dim text As String = OO_00oOO.ProjectPath + "QQServer\UploadFiles\" + array(0).ToString()
				Dim ipendPoint As IPEndPoint = CType(array(1), IPEndPoint)
				If Not OO_00oOO.FileSys.FileExists(text) Then
					Me.O0o_.Oo0oo.(ipendPoint, "-1")
				Else
					Dim udpClient As UdpClient = o0___oO.o0__.0.(Me)
					o0___oO.O.oOo0O0O.(udpClient)
					udpClient.Client.SendBufferSize = 81920
					Dim text2 As String = udpClient.Client.LocalEndPoint.ToString()
					text2 = text2.Substring(text2.IndexOf(":") + 1)
					Dim bytes As Byte() = Encoding.Unicode.GetBytes(text2)
					Me.ooO_.O0_..Send(bytes, bytes.Length, ipendPoint)
					Dim now As DateTime = DateTime.Now
					While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
						If udpClient.Available > 0 Then
							Dim ipendPoint2 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
							Dim bytes2 As Byte() = udpClient.Receive(ipendPoint2)
							If Operators.CompareString(Encoding.Unicode.GetString(bytes2), "Ping", True) = 0 Then
								Dim o_0__O_o_O As O_0__O_o_O = New O_0__O_o_O(Me, udpClient, ipendPoint, text, Nothing, OoOo0O.OO_o.0o_O.(8), SendTypeEnum.ManualFile)
								Dim obj As Object = Me.ooO_.O0_.
								SyncLock obj
									Me.ooO_.O0_..Add(o_0__O_o_O.O_OO.o0o_o0.(), o_0__O_o_O)
								End SyncLock
								o_0__O_o_O.o0o_0OO00.Oo0_.()
								Exit While
							End If
						End If
					End While
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x060026F5 RID: 9973 RVA: 0x001094D4 File Offset: 0x001076D4
		<oO0oooo("3027")>
		Public Sub SendFile(UserName As String, FileName As String)
			Dim parameter As Object() = New Object() { UserName, FileName }
			AddressOf Me.o0Oo.OoO..Start(parameter)
		End Sub

		' Token: 0x060026F6 RID: 9974 RVA: 0x00109508 File Offset: 0x00107708
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim array As Object() = CType(A_0, Object())
			Dim text As String = array(0).ToString()
			Dim text2 As String = array(1).ToString()
			Dim text3 As String = vbVerticalTab
			Dim udpClient As UdpClient = o0___oO.o0__.0.(Me)
			o0___oO.O.oOo0O0O.(udpClient)
			udpClient.Client.SendBufferSize = 81920
			Dim text4 As String = udpClient.Client.LocalEndPoint.ToString()
			Dim text5 As String = String.Concat(New String() { "%8", text3, text4.Substring(text4.IndexOf(":") + 1), text3, OO_00oOO.FileSys.GetName(text2) })
			Me.oOOOo._.(text, text5)
			Dim now As DateTime = DateTime.Now
			Dim flag2 As Boolean
			While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
				If udpClient.Available > 0 Then
					Dim a_ As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim bytes As Byte() = udpClient.Receive(a_)
					text5 = Encoding.Unicode.GetString(bytes)
					If Operators.CompareString(text5, "Ping", True) = 0 Then
						Dim o_0__O_o_O As O_0__O_o_O = New O_0__O_o_O(Me, udpClient, a_, text2, Nothing, OoOo0O.OO_o.0o_O.(8), SendTypeEnum.AutoFile)
						o_0__O_o_O.O._O___O. = text
						Dim obj As Object = Me.ooO_.O0_.
						SyncLock obj
							Me.ooO_.O0_..Add(o_0__O_o_O.O_OO.o0o_o0.(), o_0__O_o_O)
						End SyncLock
						flag2 = True
						o_0__O_o_O.o0o_0OO00.Oo0_.()
						Exit While
					End If
				End If
			End While
			If Not flag2 Then
				Dim afterSendFileEventArgs As AfterSendFileEventArgs = New AfterSendFileEventArgs(text, text2, False)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_AfterSendFile", New Object() { afterSendFileEventArgs }, True, "项目", False)
			End If
		End Sub

		' Token: 0x060026F7 RID: 9975 RVA: 0x001096B8 File Offset: 0x001078B8
		Private Sub <<EMPTY_NAME>>()
			Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("Select * From [Meetings] Where Finish = False Or Finish Is Null ", Me.O0O_.O.)
			Dim dataTable As DataTable = New DataTable()
			dbDataAdapter.Fill(dataTable)
			Try
				For Each obj As Object In dataTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Dim o0o0_oo00Oo As o0o0_oo00Oo = New o0o0_oo00Oo(dataRow("MeetingName").ToString(), dataRow("MeetingKey").ToString(), dataRow("Hostess").ToString(), dataRow("Description").ToString(), dataRow("Members").ToString(), False)
					o0o0_oo00Oo.o.oo_o0O.(Conversions.ToDate(dataRow("DateTime")))
					Me.MeetingInfos.Add(o0o0_oo00Oo.OO.O_o__.(), o0o0_oo00Oo)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060026F8 RID: 9976 RVA: 0x001097B0 File Offset: 0x001079B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Try
				Dim array As String() = CType(A_0, String())
				Dim oleDbCommand As OleDbCommand = New OleDbCommand("", Me.O0O_.O.)
				oleDbCommand.CommandText = String.Concat(New String() { "Insert Into Meetings (MeetingName,MeetingKey,Hostess,Description,[DateTime],Members,[Finish]) Values(?, '", array(5), "','", array(1), "', ?, #", Strings.Format(DateTime.Now, "MM/dd/yyyy HH:ss"), "#,'", array(6), "',False)" })
				Me.O0O_.O..Parameters.Clear()
				oleDbCommand.Parameters.Add(New OleDbParameter("@p1", array(3)))
				oleDbCommand.Parameters.Add(New OleDbParameter("@p2", array(4)))
				oleDbCommand.ExecuteNonQuery()
				Dim o0o0_oo00Oo As o0o0_oo00Oo = New o0o0_oo00Oo(array(3), array(5), array(1), array(5), array(6), False)
				Me.MeetingInfos.Add(array(5), o0o0_oo00Oo)
				Dim text As String = vbVerticalTab
				Dim text2 As String = String.Concat(New String() { "*", text, array(1), text, array(3), text, array(4), text, array(5), text, array(6), text, Strings.Format(DateTime.Now, "MM/dd/yyyy HH:ss") })
				Try
					For Each text3 As String In o0o0_oo00Oo.o.oo_o0O.()
						If Me.Users.Contains(text3) Then
							Me.oOOOo._.(text3, text2)
						Else
							Me.O0O_.O..CommandText = String.Concat(New String() { "Insert Into [Messages] ([Receiver],[Time],[Content]) Values('", text3, "',#", Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"), "#, ?)" })
							Me.O0O_.O..Parameters.Clear()
							Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", text2))
							Me.O0O_.O..ExecuteNonQuery()
						End If
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x060026F9 RID: 9977 RVA: 0x00109A40 File Offset: 0x00107C40
		<oO0oooo("2980")>
		Public Sub Send(UserName As String, msg As String, Optional AnyWay As Boolean = False)
			If Me.Users.Contains(UserName) Then
				msg = "$" & vbVerticalTab & vbVerticalTab + msg.Replace(vbVerticalTab, "") + vbVerticalTab + Me.Users(UserName).OO__o_.O0_0O_0.
				Dim a_ As IPEndPoint = Me.Users(UserName).WanIP
				Me.O0o_.Oo0oo.(a_, msg)
				Return
			End If
			If AnyWay Then
				msg = "$" & vbVerticalTab & vbVerticalTab + msg
				Me.O0O_.O..CommandText = String.Concat(New String() { "Insert Into [Messages] ([Receiver],[Time],[Content]) Values('", UserName, "',#", Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"), "#, ?)" })
				Me.O0O_.O..Parameters.Clear()
				Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", msg))
				Me.O0O_.O..ExecuteNonQuery()
			End If
		End Sub

		' Token: 0x060026FA RID: 9978 RVA: 0x00109B3C File Offset: 0x00107D3C
		<oO0oooo("3062")>
		Public Sub SendNotice(UserName As String, msg As String)
			msg = "={" + msg.Replace(vbVerticalTab, "") + "}="
			If Not Me.Users.Contains(UserName) Then
				Try
					For Each o0o0_oo00Oo As o0o0_oo00Oo In Me.MeetingInfos.Values
						If Operators.CompareString(o0o0_oo00Oo.oOO_00_0.o.(), UserName, True) = 0 Then
							Try
								For Each a_ As String In o0o0_oo00Oo.o.oo_o0O.()
									Me.ooO.OO_o_000.(a_, msg)
								Next
								Return
							Finally
								Dim enumerator2 As List(Of String).Enumerator
								CType(enumerator2, IDisposable).Dispose()
							End Try
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, o0o0_oo00Oo).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			Me.ooO.OO_o_000.(UserName, msg)
		End Sub

		' Token: 0x060026FB RID: 9979 RVA: 0x00109C18 File Offset: 0x00107E18
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Me.Users.Contains(A_0) Then
				A_1 = "$" & vbVerticalTab & "[System]" & vbVerticalTab + A_1 + vbVerticalTab + Me.Users(A_0).OO__o_.O0_0O_0.
				Dim a_ As IPEndPoint = Me.Users(A_0).WanIP
				Me.O0o_.Oo0oo.(a_, A_1)
				Return
			End If
			A_1 = "$" & vbVerticalTab & "[System]" & vbVerticalTab + A_1
			Me.O0O_.O..CommandText = String.Concat(New String() { "Insert Into [Messages] ([Receiver],[Time],[Content]) Values('", A_0, "',#", Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"), "#, ?)" })
			Me.O0O_.O..Parameters.Clear()
			Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", A_1))
			Me.O0O_.O..ExecuteNonQuery()
		End Sub

		' Token: 0x060026FC RID: 9980 RVA: 0x00109D00 File Offset: 0x00107F00
		<oO0oooo("3063")>
		Public Sub SendNoticeFile(UserName As String, FileName As String)
			If OO_00oOO.FileSys.FileExists(FileName) Then
				Dim text As String = OO_00oOO.ProjectPath + "QQServer\UploadFiles\" + Strings.Format(DateTime.Today, "yyyyMM") + "\"
				If Not OO_00oOO.FileSys.DirectoryExists(text) Then
					OO_00oOO.FileSys.CreateDirectory(text)
				End If
				Dim text2 As String = OO_00oOO.FileSys.GetName(FileName)
				text2 = text + text2
				If Not OO_00oOO.FileSys.FileExists(text2) OrElse Operators.CompareString(O00.CRCCheckFile(FileName), O00.CRCCheckFile(text2), True) <> 0 Then
					If OO_00oOO.FileSys.FileExists(text2) Then
						Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(text2)
						Dim extension As String = Path.GetExtension(text2)
						Dim num As Integer = 1
						While OO_00oOO.FileSys.FileExists(String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num), ")", extension }))
							num += 1
						End While
						text2 = String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num), ")", extension })
					End If
					If Operators.CompareString(FileName.ToLower(), text2.ToLower(), True) <> 0 Then
						OO_00oOO.FileSys.CopyFile(FileName, text2, True)
					End If
				End If
				Dim fileInfo As FileInfo = New FileInfo(text2)
				Dim a_ As String = String.Concat(New String() { "={" & ChrW(2) & ChrW(2) & "<?", Strings.Format(DateTime.Today, "yyyyMM"), "\", OO_00oOO.FileSys.GetName(text2), vbTab, o0___oO.o0__.0.(fileInfo.Length), "?>}=" })
				If Not Me.Users.Contains(UserName) Then
					Try
						For Each o0o0_oo00Oo As o0o0_oo00Oo In Me.MeetingInfos.Values
							If Operators.CompareString(o0o0_oo00Oo.oOO_00_0.o.(), UserName, True) = 0 Then
								Try
									For Each a_2 As String In o0o0_oo00Oo.o.oo_o0O.()
										Me.o__00O.o_o0_o0.(a_2, a_)
									Next
									Return
								Finally
									Dim enumerator2 As List(Of String).Enumerator
									CType(enumerator2, IDisposable).Dispose()
								End Try
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, o0o0_oo00Oo).ValueCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				Me.o__00O.o_o0_o0.(UserName, a_)
			End If
		End Sub

		' Token: 0x060026FD RID: 9981 RVA: 0x00109F74 File Offset: 0x00108174
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Me.Users.Contains(A_0) Then
				A_1 = "$" & vbVerticalTab & "[System]" & vbVerticalTab + A_1 + vbVerticalTab + Me.Users(A_0).OO__o_.O0_0O_0.
				Dim a_ As IPEndPoint = Me.Users(A_0).WanIP
				Me.O0o_.Oo0oo.(a_, A_1)
				Return
			End If
			A_1 = A_1.Replace(ChrW(2) & ChrW(2), ChrW(2))
			A_1 = "$" & vbVerticalTab & "[System]" & vbVerticalTab + A_1
			Me.O0O_.O..CommandText = String.Concat(New String() { "Insert Into [Messages] ([Receiver],[Time],[Content]) Values('", A_0, "',#", Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"), "#, ?)" })
			Me.O0O_.O..Parameters.Clear()
			Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", A_1))
			Me.O0O_.O..ExecuteNonQuery()
		End Sub

		' Token: 0x060026FE RID: 9982 RVA: 0x0010A070 File Offset: 0x00108270
		<oO0oooo("3064")>
		Public Sub SendNoticeImage(UserName As String, FileName As String)
			If OO_00oOO.FileSys.FileExists(FileName) Then
				Dim text As String = OO_00oOO.ProjectPath + "QQServer\UploadFiles\" + Strings.Format(DateTime.Today, "yyyyMM") + "\"
				If Not OO_00oOO.FileSys.DirectoryExists(text) Then
					OO_00oOO.FileSys.CreateDirectory(text)
				End If
				Dim text2 As String = OO_00oOO.FileSys.GetName(FileName)
				text2 = text + text2
				If Not OO_00oOO.FileSys.FileExists(text2) OrElse Operators.CompareString(O00.CRCCheckFile(FileName), O00.CRCCheckFile(text2), True) <> 0 Then
					If OO_00oOO.FileSys.FileExists(text2) Then
						Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(text2)
						Dim extension As String = Path.GetExtension(text2)
						Dim num As Integer = 1
						While OO_00oOO.FileSys.FileExists(String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num), ")", extension }))
							num += 1
						End While
						text2 = String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num), ")", extension })
					End If
					If Operators.CompareString(FileName.ToLower(), text2.ToLower(), True) <> 0 Then
						OO_00oOO.FileSys.CopyFile(FileName, text2, True)
					End If
				End If
				New FileInfo(text2)
				Dim a_ As String = String.Concat(New String() { "={" & ChrW(2) & ChrW(2) & "=?", Strings.Format(DateTime.Today, "yyyyMM"), "\", OO_00oOO.FileSys.GetName(text2), "?=}=" })
				If Not Me.Users.Contains(UserName) Then
					Try
						For Each o0o0_oo00Oo As o0o0_oo00Oo In Me.MeetingInfos.Values
							If Operators.CompareString(o0o0_oo00Oo.oOO_00_0.o.(), UserName, True) = 0 Then
								Try
									For Each a_2 As String In o0o0_oo00Oo.o.oo_o0O.()
										Me.o0Oo.OoO.(a_2, a_)
									Next
									Return
								Finally
									Dim enumerator2 As List(Of String).Enumerator
									CType(enumerator2, IDisposable).Dispose()
								End Try
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, o0o0_oo00Oo).ValueCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				Me.o0Oo.OoO.(UserName, a_)
			End If
		End Sub

		' Token: 0x060026FF RID: 9983 RVA: 0x0010A2CC File Offset: 0x001084CC
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Me.Users.Contains(A_0) Then
				A_1 = "$" & vbVerticalTab & "[System]" & vbVerticalTab + A_1 + vbVerticalTab + Me.Users(A_0).OO__o_.O0_0O_0.
				Dim a_ As IPEndPoint = Me.Users(A_0).WanIP
				Me.O0o_.Oo0oo.(a_, A_1)
				Return
			End If
			A_1 = A_1.Replace(ChrW(2) & ChrW(2), ChrW(2))
			A_1 = "$" & vbVerticalTab & "[System]" & vbVerticalTab + A_1
			Me.O0O_.O..CommandText = String.Concat(New String() { "Insert Into [Messages] ([Receiver],[Time],[Content]) Values('", A_0, "',#", Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"), "#, ?)" })
			Me.O0O_.O..Parameters.Clear()
			Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", A_1))
			Me.O0O_.O..ExecuteNonQuery()
		End Sub

		' Token: 0x06002700 RID: 9984 RVA: 0x0010A3C8 File Offset: 0x001085C8
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Me.Users.Contains(A_0) Then
				Dim a_ As IPEndPoint = Me.Users(A_0).WanIP
				Me.O0o_.Oo0oo.(a_, A_1)
			End If
		End Sub

		' Token: 0x06002701 RID: 9985 RVA: 0x0010A400 File Offset: 0x00108600
		Friend Sub <<EMPTY_NAME>>(A_0 As IPEndPoint, A_1 As String)
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_1)
			Me.ooO_.O0_..Send(bytes, bytes.Length, A_0)
		End Sub

		' Token: 0x06002702 RID: 9986 RVA: 0x0010A42C File Offset: 0x0010862C
		Friend Sub <<EMPTY_NAME>>()
			Try
				If Not OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "QQServer") Then
					OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "QQServer")
				End If
				Dim text As String = OO_00oOO.ProjectPath + "QQServer\" + Me.Name + "_Cache.mdb"
				If Not OO_00oOO.FileSys.FileExists(text) Then
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "IMServer.mdb", text)
				End If
				Me.O0O_.O. = New OleDbConnection(Oo00.o_._0OOo.(text))
				Me.O0O_.O. = New OleDbDataAdapter("Select * From [Messages] Where [_Identify] Is Null", Me.O0O_.O.)
				Me.O0O_.O. = New OleDbCommand("", Me.O0O_.O.)
				Me.O0O_.O..Open()
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06002703 RID: 9987 RVA: 0x0010A524 File Offset: 0x00108724
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim o00.O0. As Object = OO_00oOO.IMClients.O00.O0.
			ObjectFlowControl.CheckForSyncLockOnValueType(o00.O0.)
			Dim result As String
			SyncLock o00.O0.
				If Operators.CompareString(OO_00oOO.FileSys.GetParentPath(A_0), "", True) = 0 Then
					Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(A_0)
					Dim extension As String = Path.GetExtension(A_0)
					Dim text As String = OO_00oOO.ProjectPath + "QQServer\UploadFiles\" + Strings.Format(DateTime.Today, "yyyyMM") + "\"
					If Not OO_00oOO.FileSys.DirectoryExists(text) Then
						OO_00oOO.FileSys.CreateDirectory(text)
					End If
					If Not OO_00oOO.FileSys.FileExists(text + fileNameWithoutExtension + extension) AndAlso Not IMServer.oO_0OO.0..Contains(text + fileNameWithoutExtension + extension) Then
						A_0 = text + fileNameWithoutExtension + extension
						IMServer.oO_0OO.0..Add(A_0)
					Else
						Dim num As Integer = 1
						While OO_00oOO.FileSys.FileExists(String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num), ")", extension })) OrElse IMServer.oO_0OO.0..Contains(String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num), ")", extension }))
							num += 1
						End While
						A_0 = String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num), ")", extension })
						IMServer.oO_0OO.0..Add(A_0)
					End If
				End If
				result = A_0
			End SyncLock
			Return result
		End Function

		' Token: 0x06002704 RID: 9988 RVA: 0x0010A700 File Offset: 0x00108900
		<oO0oooo("A4106")>
		Public Sub ForwardMessage(WeChatID As String, Receiver As String, Message As String)
			Dim text As String = vbVerticalTab
			Message = String.Concat(New String() { "=$", text, WeChatID, text, Message })
			Me.O0O_.O.(Receiver, Message)
		End Sub

		' Token: 0x06002705 RID: 9989 RVA: 0x0010A740 File Offset: 0x00108940
		<oO0oooo("A4107")>
		Public Sub ForwardFile(WeChatID As String, Receiver As String, FileName As String)
			Dim text As String = vbVerticalTab
			Dim a_ As String = String.Concat(New String() { "=$", text, WeChatID, text, ChrW(2) & "<?", FileName, "?>" })
			Me.O0O_.O.(Receiver, a_)
		End Sub

		' Token: 0x06002706 RID: 9990 RVA: 0x0010A790 File Offset: 0x00108990
		<oO0oooo("A4108")>
		Public Sub ForwardChatMessage(WeChatID As String, Receiver As String, Message As String)
			Dim text As String = vbVerticalTab
			Message = String.Concat(New String() { "=$", text, WeChatID, text, "={", Message, "}=" })
			Me.O0O_.O.(Receiver, Message)
		End Sub

		' Token: 0x06002707 RID: 9991 RVA: 0x0010A7E0 File Offset: 0x001089E0
		<oO0oooo("A4109")>
		Public Sub ForwardChatFile(WeChatID As String, Receiver As String, FileName As String)
			Dim text As String = vbVerticalTab
			Dim text2 As String = OO_00oOO.ProjectPath + "QQServer\UploadFiles\" + FileName
			If OO_00oOO.FileSys.FileExists(text2) Then
				Dim fileInfo As FileInfo = New FileInfo(text2)
				Dim a_ As String = String.Concat(New String() { "=$", text, WeChatID, text, "={" & ChrW(2) & "<?", FileName, vbTab, o0___oO.o0__.0.(fileInfo.Length), "?>}=" })
				Me.O0O_.O.(Receiver, a_)
			End If
		End Sub

		' Token: 0x06002708 RID: 9992 RVA: 0x0010A86C File Offset: 0x00108A6C
		<oO0oooo("A4105")>
		Public Sub ForwardChatImage(WeChatID As String, Receiver As String, FileName As String)
			Dim text As String = vbVerticalTab
			Dim a_ As String = String.Concat(New String() { "=$", text, WeChatID, text, "={" & ChrW(2) & "=?", FileName, "?=}=" })
			Me.O0O_.O.(Receiver, a_)
		End Sub

		' Token: 0x06002709 RID: 9993 RVA: 0x0010A8BC File Offset: 0x00108ABC
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Me.Users.Contains(A_0) Then
				Dim a_ As IPEndPoint = Me.Users(A_0).WanIP
				Me.O0o_.Oo0oo.(a_, A_1)
				Return
			End If
			Me.O0O_.O..CommandText = String.Concat(New String() { "Insert Into [Messages] ([Receiver],[Time],[Content]) Values('", A_0, "',#", Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"), "#, ?)" })
			Me.O0O_.O..Parameters.Clear()
			Me.O0O_.O..Parameters.Add(New OleDbParameter("@p1", A_1))
			Me.O0O_.O..ExecuteNonQuery()
		End Sub

		' Token: 0x04001014 RID: 4116
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001015 RID: 4117
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001016 RID: 4118
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001017 RID: 4119
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001018 RID: 4120
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04001019 RID: 4121
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x0400101A RID: 4122
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400101B RID: 4123
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400101C RID: 4124
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400101D RID: 4125
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400101E RID: 4126
		Friend <<EMPTY_NAME>> As ReaderWriterLock

		' Token: 0x0400101F RID: 4127
		Friend <<EMPTY_NAME>> As UdpClient

		' Token: 0x04001020 RID: 4128
		Private <<EMPTY_NAME>> As IMUserCollections

		' Token: 0x04001021 RID: 4129
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001022 RID: 4130
		Friend <<EMPTY_NAME>> As Queue(Of oO__oO_0_O)

		' Token: 0x04001023 RID: 4131
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001024 RID: 4132
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001025 RID: 4133
		Private <<EMPTY_NAME>> As Dictionary(Of String, o0o0_oo00Oo)

		' Token: 0x04001026 RID: 4134
		Friend <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04001027 RID: 4135
		Friend <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x04001028 RID: 4136
		Friend <<EMPTY_NAME>> As Dictionary(Of String, ooOoO)

		' Token: 0x04001029 RID: 4137
		Friend <<EMPTY_NAME>> As Dictionary(Of String, O_0__O_o_O)

		' Token: 0x0400102A RID: 4138
		Private <<EMPTY_NAME>> As OleDbCommand

		' Token: 0x0400102B RID: 4139
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400102C RID: 4140
		Private Shared <<EMPTY_NAME>> As List(Of String) = New List(Of String)()
	End Class
End Namespace
