Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001C4 RID: 452
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	<oO0oooo("3000")>
	Public Class UDPClient
		' Token: 0x060014F4 RID: 5364 RVA: 0x0008295E File Offset: 0x00080B5E
		Public Sub New(A_0 As String)
			Me.O00ooo._. = True
			Me.O00ooo._. = New Queue(Of UDPClient.OO00_)()
			Me.O00ooo._. = New ReaderWriterLock()
			Me.O00ooo._. = Encoding.Unicode
			Me.O_o.0__OOO0. = A_0
		End Sub

		' Token: 0x1700047A RID: 1146
		' (get) Token: 0x060014F5 RID: 5365 RVA: 0x00082995 File Offset: 0x00080B95
		Public ReadOnly Property Name As String
			Get
				Return Me.O_o.0__OOO0.
			End Get
		End Property

		' Token: 0x1700047B RID: 1147
		' (get) Token: 0x060014F6 RID: 5366 RVA: 0x0008299D File Offset: 0x00080B9D
		' (set) Token: 0x060014F7 RID: 5367 RVA: 0x000829A5 File Offset: 0x00080BA5
		Public Property IP As String
			Get
				Return Me.ooOoO_0Oo.O.
			End Get
			Set(value As String)
				Me.ooOoO_0Oo.O. = value
			End Set
		End Property

		' Token: 0x1700047C RID: 1148
		' (get) Token: 0x060014F8 RID: 5368 RVA: 0x000829AE File Offset: 0x00080BAE
		' (set) Token: 0x060014F9 RID: 5369 RVA: 0x000829B6 File Offset: 0x00080BB6
		Public Property Port As Integer
			Get
				Return Me.ooOoO_0Oo.O.
			End Get
			Set(value As Integer)
				Me.ooOoO_0Oo.O. = value
			End Set
		End Property

		' Token: 0x1700047D RID: 1149
		' (get) Token: 0x060014FA RID: 5370 RVA: 0x000829BF File Offset: 0x00080BBF
		' (set) Token: 0x060014FB RID: 5371 RVA: 0x000829C7 File Offset: 0x00080BC7
		Public Property EncodingName As String
			Get
				Return Me.o0O.OO0__.
			End Get
			Set(value As String)
				Me.o0O.OO0__. = value
			End Set
		End Property

		' Token: 0x1700047E RID: 1150
		' (get) Token: 0x060014FC RID: 5372 RVA: 0x000829D0 File Offset: 0x00080BD0
		Public ReadOnly Property Ready As Boolean
			Get
				Return Not Me.O00ooo._.
			End Get
		End Property

		' Token: 0x060014FD RID: 5373 RVA: 0x000829DC File Offset: 0x00080BDC
		<oO0oooo("3001")>
		Public Function Start() As Boolean
			Dim result As Boolean
			If Me.O00ooo._. IsNot Nothing Then
				MessageBox.Show("此UDPClient已经启动，请先停止，才能重新启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf Me.ooOoO_0Oo.O. = 0 OrElse Operators.CompareString(Me.ooOoO_0Oo.O., "", True) = 0 Then
				MessageBox.Show("必须同时指定端口,才能启动UDPClient!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				Me.O00ooo._..Clear()
				Me.O00ooo._. = True
				If Operators.CompareString(Me.EncodingName, "", True) = 0 Then
					Me.O00ooo._. = Encoding.Unicode
				Else
					Me.O00ooo._. = Encoding.GetEncoding(Me.EncodingName)
				End If
				Try
					Dim localEP As IPEndPoint
					If Operators.CompareString(Me.ooOoO_0Oo.O., "", True) = 0 Then
						localEP = New IPEndPoint(IPAddress.Any, Me.ooOoO_0Oo.O.)
					Else
						localEP = New IPEndPoint(IPAddress.Parse(Me.ooOoO_0Oo.O.), Me.ooOoO_0Oo.O.)
					End If
					Me.O00ooo._. = New UdpClient(localEP)
					Me.o.__o0_0o0oO_O. = New UdpClient(0)
					o0___oO.O.oOo0O0O.(Me.O00ooo._.)
					o0___oO.O.oOo0O0O.(Me.o.__o0_0o0oO_O.)
					Me.O00ooo._..Client.SendBufferSize = 81920
					Me.O00ooo._..Client.ReceiveBufferSize = 81920
					Me.o.__o0_0o0oO_O..Client.SendBufferSize = 81920
					Me.o.__o0_0o0oO_O..Client.ReceiveBufferSize = 81920
					Me.O00ooo._. = False
					Me.ooOoO_0Oo.O.()
					result = True
				Catch a_ As Exception
					Me.O00ooo._. = True
					If Me.O00ooo._. IsNot Nothing Then
						Me.O00ooo._..Close()
						Me.O00ooo._. = Nothing
					End If
					If Me.o.__o0_0o0oO_O. IsNot Nothing Then
						Me.o.__o0_0o0oO_O..Close()
						Me.o.__o0_0o0oO_O. = Nothing
					End If
					ooO.oOo0Oo.o.(a_, "启动UDPClient")
					result = False
				End Try
			End If
			Return result
		End Function

		' Token: 0x060014FE RID: 5374 RVA: 0x00082BBC File Offset: 0x00080DBC
		Public Sub [Stop]()
			Me.O00ooo._. = True
			Me.O00ooo._..AcquireWriterLock(-1)
			Dim ex As Exception = Nothing
			Try
				Dim o00ooo._. As Object = Me.O00ooo._.
				SyncLock o00ooo._.
					Me.O00ooo._..Clear()
				End SyncLock
				If Me.O00ooo._. IsNot Nothing Then
					Me.O00ooo._..Close()
					Me.O00ooo._. = Nothing
				End If
				If Me.o.__o0_0o0oO_O. IsNot Nothing Then
					Me.o.__o0_0o0oO_O..Close()
					Me.o.__o0_0o0oO_O. = Nothing
				End If
			Catch ex2 As Exception
				ex = ex2
			Finally
				Me.O00ooo._..ReleaseWriterLock()
			End Try
			If ex IsNot Nothing Then
				ooO.oOo0Oo.o.(ex, "关闭UDPClient")
			End If
		End Sub

		' Token: 0x060014FF RID: 5375 RVA: 0x00082C90 File Offset: 0x00080E90
		Private Sub <<EMPTY_NAME>>()
			Me.O00ooo._..AcquireReaderLock(-1)
			Dim ex As Exception = Nothing
			Try
				Me.O00ooo._..BeginReceive(AddressOf Me.ooOoO_0Oo.O., Nothing)
			Catch ex2 As Exception
				ex = ex2
			Finally
				Me.O00ooo._..ReleaseReaderLock()
			End Try
			If ex IsNot Nothing Then
				Me.[Stop]()
				ooO.oOo0Oo.o.(ex, "UDPClient异步接收")
			End If
		End Sub

		' Token: 0x06001500 RID: 5376 RVA: 0x00082D14 File Offset: 0x00080F14
		Private Sub <<EMPTY_NAME>>(A_0 As IAsyncResult)
			If Not Me.O00ooo._. Then
				Me.O00ooo._..AcquireReaderLock(-1)
				Dim ex As Exception = Nothing
				Try
					Dim a_ As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim a_2 As Byte() = Me.O00ooo._..EndReceive(A_0, a_)
					Dim o00ooo._. As Object = Me.O00ooo._.
					SyncLock o00ooo._.
						Me.O00ooo._..Enqueue(New UDPClient.OO00_(a_, a_2))
					End SyncLock
				Catch ex2 As Exception
					ex = ex2
				Finally
					Me.O00ooo._..ReleaseReaderLock()
				End Try
				If ex Is Nothing Then
					If Not Me.O00ooo._. Then
						Me.ooOoO_0Oo.O.()
						Return
					End If
				Else
					Me.[Stop]()
					ooO.oOo0Oo.o.(ex, "UDPClient异步接收回调过程")
				End If
			End If
		End Sub

		' Token: 0x06001501 RID: 5377 RVA: 0x00082DF4 File Offset: 0x00080FF4
		Public Sub Send(ip As String, port As Integer, bytes As Byte())
			If Not Me.O00ooo._. Then
				Dim endPoint As IPEndPoint
				If Operators.CompareString(ip, "", True) = 0 Then
					endPoint = New IPEndPoint(IPAddress.Any, port)
				Else
					endPoint = New IPEndPoint(IPAddress.Parse(ip), port)
				End If
				Me.O00ooo._..Send(bytes, bytes.Length, endPoint)
			End If
		End Sub

		' Token: 0x06001502 RID: 5378 RVA: 0x00082E44 File Offset: 0x00081044
		Public Sub Send(ip As String, port As Integer, msg As String)
			Dim bytes As Byte() = Me.O00ooo._..GetBytes(msg)
			Me.Send(ip, port, bytes)
		End Sub

		' Token: 0x04000862 RID: 2146
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000863 RID: 2147
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000864 RID: 2148
		Friend <<EMPTY_NAME>> As UdpClient

		' Token: 0x04000865 RID: 2149
		Friend <<EMPTY_NAME>> As UdpClient

		' Token: 0x04000866 RID: 2150
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000867 RID: 2151
		Friend <<EMPTY_NAME>> As Queue(Of UDPClient.OO00_)

		' Token: 0x04000868 RID: 2152
		Private <<EMPTY_NAME>> As ReaderWriterLock

		' Token: 0x04000869 RID: 2153
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400086A RID: 2154
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400086B RID: 2155
		Friend <<EMPTY_NAME>> As Encoding

		' Token: 0x020001CB RID: 459
		Friend Class OO00_
			' Token: 0x06001581 RID: 5505 RVA: 0x0008DA9C File Offset: 0x0008BC9C
			Friend Sub New(A_0 As IPEndPoint, A_1 As Byte())
				Me.O00ooo._. = A_0
				Me.O00ooo._. = A_1
			End Sub

			' Token: 0x06001582 RID: 5506 RVA: 0x0008DAB2 File Offset: 0x0008BCB2
			Friend Function <<EMPTY_NAME>>() As IPEndPoint
				Return Me.O00ooo._.
			End Function

			' Token: 0x06001583 RID: 5507 RVA: 0x0008DABA File Offset: 0x0008BCBA
			Friend Function <<EMPTY_NAME>>() As Byte()
				Return Me.O00ooo._.
			End Function

			' Token: 0x040008B6 RID: 2230
			Private <<EMPTY_NAME>> As IPEndPoint

			' Token: 0x040008B7 RID: 2231
			Private <<EMPTY_NAME>> As Byte()
		End Class
	End Class
End Namespace
