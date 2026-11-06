Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001CE RID: 462
	Friend Class O_0__O_o_O
		' Token: 0x06001596 RID: 5526 RVA: 0x0008E940 File Offset: 0x0008CB40
		Friend Sub New(A_0 As Object, A_1 As UdpClient, A_2 As IPEndPoint, A_3 As String, A_4 As IMBuddy, A_5 As String, A_6 As SendTypeEnum)
			Me.O00o___0OoO.0. = 8
			Me.Oo.Oo0. = 8
			Me.oO_0_Ooo.o. = 1024
			Me.OOOo._0. = New AutoResetEvent(False)
			Me.O0.0O0o_O. = New ReaderWriterLock()
			Me.O00o___0OoO.0. = New List(Of Integer)()
			Me.Oo.Oo0. = New List(Of Integer)()
			Me.OOOo._0. = New Dictionary(Of Integer, DateTime)()
			Me.O.0O__o. = -1
			Me.O0.0O0o_O. = RuntimeHelpers.GetObjectValue(A_0)
			Me.O00o___0OoO.0. = A_1
			Me.OOOo._0. = A_2
			Me.OOOo._0. = A_3
			Me.oO_Ooo_.0. = A_6
			Me.OOOo._0. = New FileStream(A_3, FileMode.Open, FileAccess.Read, FileShare.Read)
			Me.Oo.Oo0. = Me.OOOo._0..Length
			Me.oO_Ooo_.0. = A_4
			Me.oo.00ooO0_o. = A_5
			If A_2.Address.ToString().StartsWith("192.168.") Then
				Me.oO_0_Ooo.o. = 10240
			End If
		End Sub

		' Token: 0x06001597 RID: 5527 RVA: 0x0008EA28 File Offset: 0x0008CC28
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.o0OO0ooo0_O.O.
		End Function

		' Token: 0x06001598 RID: 5528 RVA: 0x0008EA30 File Offset: 0x0008CC30
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o0OO0ooo0_O.O. = A_0
		End Sub

		' Token: 0x06001599 RID: 5529 RVA: 0x0008EA39 File Offset: 0x0008CC39
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.oo.00ooO0_o.
		End Function

		' Token: 0x0600159A RID: 5530 RVA: 0x0008EA41 File Offset: 0x0008CC41
		Friend Function <<EMPTY_NAME>>() As IMBuddy
			Return Me.oO_Ooo_.0.
		End Function

		' Token: 0x0600159B RID: 5531 RVA: 0x0008EA49 File Offset: 0x0008CC49
		Friend Function <<EMPTY_NAME>>() As SendTypeEnum
			Return Me.oO_Ooo_.0.
		End Function

		' Token: 0x0600159C RID: 5532 RVA: 0x0008EA51 File Offset: 0x0008CC51
		Friend Sub <<EMPTY_NAME>>(A_0 As SendTypeEnum)
			Me.oO_Ooo_.0. = A_0
		End Sub

		' Token: 0x0600159D RID: 5533 RVA: 0x0008EA5A File Offset: 0x0008CC5A
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.oo.00ooO0_o.
		End Function

		' Token: 0x0600159E RID: 5534 RVA: 0x0008EA62 File Offset: 0x0008CC62
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.oo.00ooO0_o. = A_0
		End Sub

		' Token: 0x0600159F RID: 5535 RVA: 0x0008EA6B File Offset: 0x0008CC6B
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.o0OO0ooo0_O.O.
		End Function

		' Token: 0x060015A0 RID: 5536 RVA: 0x0008EA73 File Offset: 0x0008CC73
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.o0OO0ooo0_O.O. = A_0
		End Sub

		' Token: 0x060015A1 RID: 5537 RVA: 0x0008EA7C File Offset: 0x0008CC7C
		Friend Sub <<EMPTY_NAME>>()
			Try
				Dim s As String = String.Concat(New String() { Conversions.ToString(Me.Oo.Oo0.), ":", Conversions.ToString(Me.oO_0_Ooo.o.), ":", Conversions.ToString(Me.OOOo._0..Length) })
				Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
				Me.O00o___0OoO.0..Send(bytes, bytes.Length, Me.OOOo._0.)
				Dim now As DateTime = DateTime.Now
				Dim udpClient As UdpClient = Nothing
				Dim imbuddy As IMBuddy = Nothing
				If TypeOf Me.O0.0O0o_O. Is IMClient AndAlso Me.o_0.Oo_0O0_.() IsNot Nothing AndAlso Not(TypeOf Me.o_0.Oo_0O0_.()Is O_0OOOoO) AndAlso Not(TypeOf Me.o_0.Oo_0O0_.()Is ooo0) Then
					imbuddy = Me.o_0.Oo_0O0_.()
				End If
				Dim flag As Boolean
				While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
					If Me.O00o___0OoO.0..Available > 0 Then
						Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim bytes2 As Byte() = Me.O00o___0OoO.0..Receive(ipendPoint)
						Dim text As String = Encoding.Unicode.GetString(bytes2)
						If Operators.CompareString(ipendPoint.ToString(), Me.OOOo._0..ToString(), True) <> 0 Then
							Continue While
						End If
						If text.StartsWith("@") AndAlso text.EndsWith("@") Then
							text = text.Substring(1, text.Length - 2)
						End If
						Dim array As String() = text.Split(New Char() { ":"c })
						If array.Length = 2 AndAlso Integer.TryParse(array(0), Me.Oo.Oo0.) AndAlso Integer.TryParse(array(1), Me.oO_0_Ooo.o.) Then
							Me.Oo.Oo0. = Math.Abs(Me.Oo.Oo0.)
							Me.oO_0_Ooo.o. = Math.Abs(Me.oO_0_Ooo.o.)
							Me.O0.0O0o_O. = New Object(CInt(Math.Ceiling(CDbl(Me.OOOo._0..Length) / CDbl(Me.oO_0_Ooo.o.))) - 1 + 1 - 1) {}
							Me.OOOo._0. = New Integer(CInt(Math.Ceiling(CDbl(Me.O0.0O0o_O..Length) / CDbl(Me.Oo.Oo0.))) - 1 + 1 - 1) {}
							Me.Oo.Oo0. = New Integer(CInt(Math.Ceiling(CDbl(Me.O0.0O0o_O..Length) / CDbl(Me.Oo.Oo0.))) - 1 + 1 - 1) {}
							flag = True
							Exit While
						End If
					End If
					If udpClient IsNot Nothing AndAlso udpClient.Available > 0 Then
						Dim ipendPoint2 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim bytes3 As Byte() = udpClient.Receive(ipendPoint2)
						Dim text2 As String = Encoding.Unicode.GetString(bytes3)
						If Operators.CompareString(ipendPoint2.ToString(), Me.OOOo._0..ToString(), True) <> 0 Then
							Continue While
						End If
						If Operators.CompareString(text2, "Ping", True) = 0 Then
							s = String.Concat(New String() { Conversions.ToString(Me.Oo.Oo0.), ":", Conversions.ToString(Me.oO_0_Ooo.o.), ":", Conversions.ToString(Me.OOOo._0..Length) })
							bytes = Encoding.Unicode.GetBytes(s)
							udpClient.Send(bytes, bytes.Length, Me.OOOo._0.)
							Continue While
						End If
						If text2.StartsWith("@") AndAlso text2.EndsWith("@") Then
							text2 = text2.Substring(1, text2.Length - 2)
						End If
						Dim array2 As String() = text2.Split(New Char() { ":"c })
						If array2.Length = 2 AndAlso Integer.TryParse(array2(0), Me.Oo.Oo0.) AndAlso Integer.TryParse(array2(1), Me.oO_0_Ooo.o.) Then
							Me.Oo.Oo0. = Math.Abs(Me.Oo.Oo0.)
							Me.oO_0_Ooo.o. = Math.Abs(Me.oO_0_Ooo.o.)
							Me.O0.0O0o_O. = New Object(CInt(Math.Ceiling(CDbl(Me.OOOo._0..Length) / CDbl(Me.oO_0_Ooo.o.))) - 1 + 1 - 1) {}
							Me.OOOo._0. = New Integer(CInt(Math.Ceiling(CDbl(Me.O0.0O0o_O..Length) / CDbl(Me.Oo.Oo0.))) - 1 + 1 - 1) {}
							Me.Oo.Oo0. = New Integer(CInt(Math.Ceiling(CDbl(Me.O0.0O0o_O..Length) / CDbl(Me.Oo.Oo0.))) - 1 + 1 - 1) {}
							flag = True
							Me.O00o___0OoO.0. = udpClient
							Exit While
						End If
					End If
					If(DateTime.Now - now).TotalSeconds > 1.0 AndAlso imbuddy IsNot Nothing Then
						Dim imclient As IMClient = CType(Me.O0.0O0o_O., IMClient)
						If udpClient Is Nothing Then
							Dim text3 As String = vbVerticalTab
							If TypeOf Me.O0.0O0o_O. Is IMServer Then
								udpClient = o0___oO.o0__.0.(CType(Me.O0.0O0o_O., IMServer))
							Else
								udpClient = New UdpClient(0)
							End If
							o0___oO.O.oOo0O0O.(udpClient)
							udpClient.Client.SendBufferSize = 81920
							udpClient.Client.ReceiveBufferSize = 81920
							Dim bytes4 As Byte() = Encoding.Unicode.GetBytes(String.Concat(New String() { "%02", text3, imclient.UserName, text3, imclient.o_oo0Oooo.OOO_., text3, Me.OOOo._0..ToString(), text3, Me.O_OO.o0o_o0.() }))
							udpClient.Send(bytes4, bytes4.Length, imclient.ooOo.oO0.)
							bytes4 = Encoding.Unicode.GetBytes("Ping")
							udpClient.Send(bytes4, bytes4.Length, Me.OOOo._0.)
						End If
					End If
				End While
				If Not flag Then
					Me.O00o___0OoO.0..Close()
					Me.OOOo._0..Close()
					Me.o_OoO._.(True)
					Me.O._O___O. = True
				Else
					Me.O00o___0OoO.0. = DateTime.Now
					Me.OO.Oooo. = DateTime.Now
					Me.O00o___0OoO.0..BeginReceive(AddressOf Me.o_OoO._., Nothing)
					Dim num As Integer = Math.Min(Me.O00o___0OoO.0. - 1, Me.OOOo._0..Length - 1)
					For i As Integer = 0 To num
						Me.oo0_.O00.(i)
						Me.O00o___0OoO.0..Add(i)
						Me.Oo.Oo0..Add(i)
					Next
					Dim num2 As Integer = Me.O00o___0OoO.0.(Me.O00o___0OoO.0..Count - 1)
					Dim millisecondsTimeout As Integer = 2000
					now = DateTime.Now
					Try
						For Each a_ As Integer In Me.O00o___0OoO.0.
							Me.o0o_0OO00.Oo0_.(a_)
							Thread.Sleep(10)
						Next
					Finally
						Dim enumerator As List(Of Integer).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.O00o___0OoO.0..Clear()
					Dim num3 As Integer
					If Me.o_0.Oo_0O0_.() = SendTypeEnum.Capture Then
						num3 = 5
					Else
						num3 = 20
					End If
					Dim a_3 As Boolean
					While (Not(TypeOf Me.O0.0O0o_O. Is IMClient) OrElse Not CType(Me.O0.0O0o_O., IMClient).O0_OOo.O.) AndAlso (Not(TypeOf Me.O0.0O0o_O. Is IMServer) OrElse Not CType(Me.O0.0O0o_O., IMServer).o0oo__0Oo_.o00.) AndAlso Not Me.O0.0O0o_O. AndAlso Not Me.oo0_.O00.()
						Dim flag2 As Boolean
						Try
							For Each a_2 As Integer In Me.O00o___0OoO.0.
								If flag2 Then
									Thread.Sleep(10)
								End If
								Me.o0o_0OO00.Oo0_.(a_2)
							Next
						Finally
							Dim enumerator2 As List(Of Integer).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
						flag2 = False
						Dim flag3 As Boolean = False
						Me.O00o___0OoO.0..Clear()
						If Me.OOOo._0..WaitOne(millisecondsTimeout) Then
							flag3 = True
							millisecondsTimeout = 1000
						End If
						Dim oo.Oo0. As Object = Me.Oo.Oo0.
						Dim num4 As Integer
						SyncLock oo.Oo0.
							For j As Integer = Me.Oo.Oo0..Count - 1 To 0 Step -1
								If Me.Oo.Oo0.(Me.Oo.Oo0.(j)) > 0 Then
									Me.Oo.Oo0..RemoveAt(j)
									flag3 = True
								End If
							Next
							If flag3 Then
								num4 = 0
								While Me.Oo.Oo0..Count < Me.O00o___0OoO.0. AndAlso num2 < Me.OOOo._0..Length - 1
									num2 += 1
									Me.oo0_.O00.(num2)
									Me.O00o___0OoO.0..Add(num2)
									Me.Oo.Oo0..Add(num2)
								End While
								If Me.Oo.Oo0..Count = 0 Then
									a_3 = True
									Exit While
								End If
								For k As Integer = Me.Oo.Oo0..Count - 1 To 0 Step -1
									Dim num5 As Integer = Me.Oo.Oo0.(k)
									If Not Me.O00o___0OoO.0..Contains(num5) Then
										If Me.O.0O__o. - num5 >= 1 Then
											bytes = BitConverter.GetBytes(num5)
											Me.O00o___0OoO.0..Send(bytes, bytes.Length, Me.OOOo._0.)
										End If
										If Me.O.0O__o. - num5 >= 3 AndAlso (DateTime.Now - Me.OOOo._0.(num5)).TotalMilliseconds > Me.oo.00ooO0_o. * CDbl((1 + Me.OOOo._0.(num5))) AndAlso Not Me.O00o___0OoO.0..Contains(num5) Then
											Me.O00o___0OoO.0..Insert(0, num5)
											Dim num6 As Integer
											num6 += 1
										End If
									End If
								Next
							Else
								num4 += 1
								If Me.Oo.Oo0..Count = 0 Then
									a_3 = True
									Exit While
								End If
								If num4 = 1 Then
									Me.O00o___0OoO.0..AddRange(Me.Oo.Oo0.)
								Else
									Dim index As Integer = OoOo0O.Oo_oOO_._Oo_o.(0, Me.Oo.Oo0..Count)
									Me.O00o___0OoO.0..Add(Me.Oo.Oo0.(index))
								End If
								flag2 = True
								millisecondsTimeout = 1500
								Try
									For Each value As Integer In Me.Oo.Oo0.
										bytes = BitConverter.GetBytes(value)
										Me.O00o___0OoO.0..Send(bytes, bytes.Length, Me.OOOo._0.)
									Next
								Finally
									Dim enumerator3 As List(Of Integer).Enumerator
									CType(enumerator3, IDisposable).Dispose()
								End Try
								Dim num6 As Integer
								num6 += Me.O00o___0OoO.0..Count
							End If
						End SyncLock
						Try
							For Each num7 As Integer In Me.O00o___0OoO.0.
								If Me.OOOo._0.(num7) >= num3 Then
									Me.O._O___O. = True
									GoTo IL_A96
								End If
							Next
						Finally
							Dim enumerator4 As List(Of Integer).Enumerator
							CType(enumerator4, IDisposable).Dispose()
						End Try
						If num4 > 20 Then
							Me.O._O___O. = True
							Exit While
						End If
						If Me.O00o___0OoO.0. IsNot Nothing AndAlso Me.O00o___0OoO.0..FindForm() IsNot Nothing AndAlso (DateTime.Now - Me.OO.Oooo.).TotalSeconds >= 0.5 AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
							OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oO_Ooo_.0.)
						End If
					End While
					IL_A96:
					Me.O0.0O0o_O..AcquireWriterLock(-1)
					Dim totalSeconds As Double = (DateTime.Now - now).TotalSeconds
					Me.O0.0O0o_O. = True
					Me.O00o___0OoO.0..Close()
					Me.O0.0O0o_O..ReleaseWriterLock()
					If Not Me.oo0_.O00.() Then
						Me.oo.00ooO0_o.(a_3)
					End If
					Me.OOOo._0..Close()
				End If
			Catch a_4 As Exception
				ooO.oOo0Oo.o.(a_4, "")
			Finally
				Me.O0.0O0o_O. = True
				Me.o_OoO._.(True)
				If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
					OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oo0_.O00.)
				End If
			End Try
		End Sub

		' Token: 0x060015A2 RID: 5538 RVA: 0x0008F67C File Offset: 0x0008D87C
		Private Sub <<EMPTY_NAME>>()
			If Me.o_0.Oo_0O0_.() = SendTypeEnum.Capture AndAlso Not Me.oo0_.O00.() AndAlso TypeOf Me.O0.0O0o_O. Is IMClient AndAlso Not(TypeOf Me.o_0.Oo_0O0_.()Is ooo0) AndAlso Not(TypeOf Me.o_0.Oo_0O0_.()Is O_0OOOoO) Then
				Dim a_ As String = ChrW(2) & "/" & ChrW(2) & "=(" + Me.OOOo._0..Substring((OO_00oOO.ProjectPath + "QQClient\CaptureFiles\").Length) + ")=\" & ChrW(2)
				Dim imclient As IMClient = CType(Me.O0.0O0o_O., IMClient)
				CType(Me.O0.0O0o_O., IMClient).O.00O0_O_o_oO.(Me.o_0.Oo_0O0_.().Name, a_, 1, 1, Nothing)
			End If
		End Sub

		' Token: 0x060015A3 RID: 5539 RVA: 0x0008F724 File Offset: 0x0008D924
		Private Sub <<EMPTY_NAME>>()
			Dim timeSpan As TimeSpan = DateTime.Now - Me.O00o___0OoO.0.
			Dim num As Double = CDbl(Me.oO_Ooo_.0.) / 1024.0 / timeSpan.TotalSeconds
			If num < 1000.0 Then
				Me.O00o___0OoO.0..o_.0o0O__.().Text = Strings.Format(num, "0.0") + "K/S"
			Else
				Me.O00o___0OoO.0..o_.0o0O__.().Text = Strings.Format(num / 1024.0, "0.00") + "M/S"
			End If
			Dim num2 As Long = Me.oO_Ooo_.0. / 1024L
			Dim str As String
			If num2 < 1000L Then
				str = num2.ToString() + "K"
			Else
				str = Strings.Format(CDbl(Me.oO_Ooo_.0.) / 1024.0 / 1024.0, "0.00") + "M"
			End If
			num2 = Me.Oo.Oo0. / 1014L
			Dim str2 As String
			If num2 < 1000L Then
				str2 = num2.ToString() + "K"
			Else
				str2 = Strings.Format(CDbl(Me.Oo.Oo0.) / 1024.0 / 1024.0, "0.00") + "M"
			End If
			Me.O00o___0OoO.0..o_0O.00.().Text = str + "/" + str2
			Me.O00o___0OoO.0..o_.0o0O__.().Value = Math.Min(100, CInt(Math.Round(CDbl(Me.oO_Ooo_.0.) / CDbl(Me.Oo.Oo0.) * 100.0)))
			Me.OO.Oooo. = DateTime.Now
		End Sub

		' Token: 0x060015A4 RID: 5540 RVA: 0x0008F8EC File Offset: 0x0008DAEC
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.OOOo._0.(A_0) = Me.OOOo._0.(A_0) + 1
			Me.OOOo._0.(A_0) = DateTime.Now
			Dim num As Integer = A_0 * Me.Oo.Oo0.
			Dim num2 As Integer = Math.Min(num + Me.Oo.Oo0. - 1, Me.O0.0O0o_O..Length - 1)
			Dim num3 As Integer = num2
			For i As Integer = num To num3
				Dim array As Byte() = CType(Me.O0.0O0o_O.(i), Byte())
				If array IsNot Nothing Then
					If Me.OOOo._0.(A_0) > 1 Then
						Array.Copy(BitConverter.GetBytes(-BitConverter.ToInt32(array, 0)), 0, array, 0, 4)
					End If
					If Me.Oo.Oo0.(A_0) > 0 Then
						Exit For
					End If
					Me.O00o___0OoO.0..Send(array, array.Length, Me.OOOo._0.)
				End If
			Next
		End Sub

		' Token: 0x060015A5 RID: 5541 RVA: 0x0008F9A0 File Offset: 0x0008DBA0
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim num As Integer = A_0 * Me.Oo.Oo0.
			Dim num2 As Integer = Math.Min(num + Me.Oo.Oo0. - 1, Me.O0.0O0o_O..Length - 1)
			Dim array As Byte() = New Byte(Me.oO_0_Ooo.o. - 1 + 1 - 1) {}
			Dim num3 As Integer = num2
			For i As Integer = num To num3
				Dim num4 As Integer = Me.OOOo._0..Read(array, 0, Me.oO_0_Ooo.o.)
				Dim array2 As Byte() = New Byte(num4 + 3 + 1 - 1) {}
				Array.Copy(BitConverter.GetBytes(i), 0, array2, 0, 4)
				Array.Copy(array, 0, array2, 4, num4)
				Me.O0.0O0o_O.(i) = array2
			Next
		End Sub

		' Token: 0x060015A6 RID: 5542 RVA: 0x0008FA34 File Offset: 0x0008DC34
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim num As Integer = A_0 * Me.Oo.Oo0.
			Dim num2 As Integer = Math.Min(num + Me.Oo.Oo0. - 1, Me.O0.0O0o_O..Length - 1)
			Dim num3 As Integer = num2
			For i As Integer = num To num3
				Me.O0.0O0o_O.(i) = Nothing
			Next
		End Sub

		' Token: 0x060015A7 RID: 5543 RVA: 0x0008FA7C File Offset: 0x0008DC7C
		Private Sub <<EMPTY_NAME>>(A_0 As IAsyncResult)
			Me.O0.0O0o_O..AcquireReaderLock(-1)
			Try
				If Not Me.O0.0O0o_O. Then
					Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim bytes As Byte() = Me.O00o___0OoO.0..EndReceive(A_0, ipendPoint)
					Dim [string] As String = Encoding.Unicode.GetString(bytes)
					If Operators.CompareString(Me.OOOo._0..ToString(), ipendPoint.ToString(), True) = 0 Then
						Dim oo.Oo0. As Object = Me.Oo.Oo0.
						Dim flag2 As Boolean
						SyncLock oo.Oo0.
							Dim num As Integer
							If Integer.TryParse([string], num) Then
								If num = 2147483647 OrElse num = -2147483648 Then
									Me.oo.00ooO0_o.(True)
									Me.OOOo._0..[Set]()
									Return
								End If
								num = Math.Abs(num)
								If Me.Oo.Oo0..Contains(num) Then
									Me.Oo.Oo0..Remove(num)
									Me.o_0.Oo_0O0_.(num)
								End If
								If num >= 0 AndAlso num <= Me.Oo.Oo0..Length - 1 Then
									If Me.Oo.Oo0.(num) = 0 Then
										Me.oO_Ooo_.0. += CLng((Me.Oo.Oo0. * Me.oO_0_Ooo.o.))
										Me.O.0O__o. = Math.Max(Me.O.0O__o., num)
										flag2 = True
										If Me.OOOo._0.(num) = 1 Then
											Me.O00o___0OoO.0. += (DateTime.Now - Me.OOOo._0.(num)).TotalMilliseconds
											Me.O._O___O. += 1
											Me.oo.00ooO0_o. = Me.O00o___0OoO.0. / CDbl(Me.O._O___O.)
										End If
									End If
									Me.Oo.Oo0.(num) = Me.Oo.Oo0.(num) + 1
								End If
							End If
							While Me.O00o___0OoO.0..Available > 0
								ipendPoint = New IPEndPoint(IPAddress.Any, 0)
								bytes = Me.O00o___0OoO.0..Receive(ipendPoint)
								[string] = Encoding.Unicode.GetString(bytes)
								If Operators.CompareString(Me.OOOo._0..ToString(), ipendPoint.ToString(), True) = 0 AndAlso Integer.TryParse([string], num) Then
									If num = 2147483647 OrElse num = -2147483648 Then
										Me.oo.00ooO0_o.(True)
										Me.OOOo._0..[Set]()
										Return
									End If
									num = Math.Abs(num)
									If Me.Oo.Oo0..Contains(num) Then
										Me.Oo.Oo0..Remove(num)
										Me.o_0.Oo_0O0_.(num)
									End If
									If num >= 0 AndAlso num <= Me.Oo.Oo0..Length - 1 Then
										If Me.Oo.Oo0.(num) = 0 Then
											Me.oO_Ooo_.0. += CLng((Me.Oo.Oo0. * Me.oO_0_Ooo.o.))
											Me.O.0O__o. = Math.Max(Me.O.0O__o., num)
											flag2 = True
											If Me.OOOo._0.(num) = 1 Then
												Me.O00o___0OoO.0. += (DateTime.Now - Me.OOOo._0.(num)).TotalMilliseconds
												Me.O._O___O. += 1
												Me.oo.00ooO0_o. = Me.O00o___0OoO.0. / CDbl(Me.O._O___O.)
											End If
										End If
										Me.Oo.Oo0.(num) = Me.Oo.Oo0.(num) + 1
									End If
								End If
							End While
						End SyncLock
						If flag2 Then
							Me.OOOo._0..[Set]()
						End If
						If Not Me.O0.0O0o_O. Then
							Me.O00o___0OoO.0..BeginReceive(AddressOf Me.o_OoO._., Nothing)
						End If
					End If
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.O0.0O0o_O..ReleaseReaderLock()
			End Try
		End Sub

		' Token: 0x040008D0 RID: 2256
		Private <<EMPTY_NAME>> As Object

		' Token: 0x040008D1 RID: 2257
		Private <<EMPTY_NAME>> As UdpClient

		' Token: 0x040008D2 RID: 2258
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x040008D3 RID: 2259
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040008D4 RID: 2260
		Private <<EMPTY_NAME>> As FileStream

		' Token: 0x040008D5 RID: 2261
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008D6 RID: 2262
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008D7 RID: 2263
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008D8 RID: 2264
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x040008D9 RID: 2265
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x040008DA RID: 2266
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x040008DB RID: 2267
		Private <<EMPTY_NAME>> As AutoResetEvent

		' Token: 0x040008DC RID: 2268
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040008DD RID: 2269
		Private <<EMPTY_NAME>> As ReaderWriterLock

		' Token: 0x040008DE RID: 2270
		Private <<EMPTY_NAME>> As List(Of Integer)

		' Token: 0x040008DF RID: 2271
		Private <<EMPTY_NAME>> As List(Of Integer)

		' Token: 0x040008E0 RID: 2272
		Private <<EMPTY_NAME>> As Dictionary(Of Integer, DateTime)

		' Token: 0x040008E1 RID: 2273
		Private <<EMPTY_NAME>> As Double

		' Token: 0x040008E2 RID: 2274
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008E3 RID: 2275
		Private <<EMPTY_NAME>> As Double

		' Token: 0x040008E4 RID: 2276
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008E5 RID: 2277
		Private <<EMPTY_NAME>> As IMBuddy

		' Token: 0x040008E6 RID: 2278
		Private <<EMPTY_NAME>> As String

		' Token: 0x040008E7 RID: 2279
		Private <<EMPTY_NAME>> As SendTypeEnum

		' Token: 0x040008E8 RID: 2280
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040008E9 RID: 2281
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040008EA RID: 2282
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040008EB RID: 2283
		Private <<EMPTY_NAME>> As String

		' Token: 0x040008EC RID: 2284
		Friend <<EMPTY_NAME>> As oO0

		' Token: 0x040008ED RID: 2285
		Private <<EMPTY_NAME>> As Long

		' Token: 0x040008EE RID: 2286
		Friend <<EMPTY_NAME>> As Long

		' Token: 0x040008EF RID: 2287
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040008F0 RID: 2288
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040008F1 RID: 2289
		Friend <<EMPTY_NAME>> As String

		' Token: 0x020001CF RID: 463
		' (Invoke) Token: 0x060015AB RID: 5547
		Public Delegate Sub O_0OO0O()

		' Token: 0x020001D0 RID: 464
		' (Invoke) Token: 0x060015AF RID: 5551
		Public Delegate Sub ooO_()
	End Class
End Namespace
