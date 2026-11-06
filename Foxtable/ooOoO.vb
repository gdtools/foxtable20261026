Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001CC RID: 460
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ooOoO
		' Token: 0x06001584 RID: 5508 RVA: 0x0008DAC4 File Offset: 0x0008BCC4
		Friend Sub New(A_0 As Object, A_1 As UdpClient, A_2 As IPEndPoint, A_3 As String, A_4 As String, A_5 As String, A_6 As SendTypeEnum)
			Me.o_Oo_o._Oo_o_. = 8
			Me.O.0_oO_o_0O0o. = 1024
			Me.O_0Oo.OO_o. = RuntimeHelpers.GetObjectValue(A_0)
			Me.O0__00OoOo_O.o. = A_1
			Me.O_0Oo.OO_o. = A_2
			Me.o_Oo_o._Oo_o_. = A_3
			Me.o_Oo_o._Oo_o_. = A_6
			Me.ooo0_.o__. = Path.GetTempFileName()
			Me.o_Oo_o._Oo_o_. = New FileStream(Me.ooo0_.o__., FileMode.Create)
			Me.oOoo_oo0o_._0. = A_4
			Me.oo_o__O_.oOO0. = A_5
			If A_2.Address.ToString().StartsWith("192.168.") Then
				Me.O.0_oO_o_0O0o. = 10240
			End If
			If TypeOf A_0 Is IMClient Then
				Dim imclient As IMClient = CType(Me.O_0Oo.OO_o., IMClient)
				If imclient.ooOooo.oO. IsNot Nothing AndAlso Not imclient.ooOooo.oO..IsDisposed Then
					Try
						For Each obj As Object In imclient.ooOooo.oO..Controls
							Dim control As Control = CType(obj, Control)
							If TypeOf control Is Oo0O__ AndAlso Operators.CompareString(CType(control, Oo0O__).O_OO.o0o_o0., A_5, True) = 0 Then
								Me.O0__00OoOo_O.o. = CType(control, Oo0O__)
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			End If
		End Sub

		' Token: 0x06001585 RID: 5509 RVA: 0x0008DC08 File Offset: 0x0008BE08
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.oo_o__O_.oOO0.
		End Function

		' Token: 0x06001586 RID: 5510 RVA: 0x0008DC10 File Offset: 0x0008BE10
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.oOoo_oo0o_._0.
		End Function

		' Token: 0x06001587 RID: 5511 RVA: 0x0008DC18 File Offset: 0x0008BE18
		Friend Function <<EMPTY_NAME>>() As SendTypeEnum
			Return Me.o_Oo_o._Oo_o_.
		End Function

		' Token: 0x06001588 RID: 5512 RVA: 0x0008DC20 File Offset: 0x0008BE20
		Friend Sub <<EMPTY_NAME>>(A_0 As SendTypeEnum)
			Me.o_Oo_o._Oo_o_. = A_0
		End Sub

		' Token: 0x06001589 RID: 5513 RVA: 0x0008DC29 File Offset: 0x0008BE29
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.o_Oo_o._Oo_o_.
		End Function

		' Token: 0x0600158A RID: 5514 RVA: 0x0008DC31 File Offset: 0x0008BE31
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.o_Oo_o._Oo_o_. = A_0
		End Sub

		' Token: 0x0600158B RID: 5515 RVA: 0x0008DC3A File Offset: 0x0008BE3A
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.O_OOOooo_0.O.
		End Function

		' Token: 0x0600158C RID: 5516 RVA: 0x0008DC42 File Offset: 0x0008BE42
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O_OOOooo_0.O. = True
		End Sub

		' Token: 0x0600158D RID: 5517 RVA: 0x0008DC4B File Offset: 0x0008BE4B
		Friend Function <<EMPTY_NAME>>() As DataRow
			Return Me.o0_.OO0O_o.
		End Function

		' Token: 0x0600158E RID: 5518 RVA: 0x0008DC53 File Offset: 0x0008BE53
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			Me.o0_.OO0O_o. = A_0
		End Sub

		' Token: 0x0600158F RID: 5519 RVA: 0x0008DC5C File Offset: 0x0008BE5C
		Friend Sub <<EMPTY_NAME>>()
			Try
				Dim now As DateTime = DateTime.Now
				Dim ipendPoint As IPEndPoint = Nothing
				Dim imclient As IMClient = Nothing
				If TypeOf Me.O_0Oo.OO_o. Is IMClient Then
					imclient = CType(Me.O_0Oo.OO_o., IMClient)
				End If
				Dim flag As Boolean
				While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0 AndAlso Not Me.ooo0_.o__.
					If Me.O0__00OoOo_O.o..Available > 0 Then
						now = DateTime.Now
						Dim ipendPoint2 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim array As Byte() = Me.O0__00OoOo_O.o..Receive(ipendPoint2)
						Dim [string] As String = Encoding.Unicode.GetString(array)
						If imclient IsNot Nothing AndAlso Operators.CompareString(imclient.ooOo.oO0..ToString(), ipendPoint2.ToString(), True) = 0 AndAlso [string].StartsWith("%02" & vbVerticalTab) AndAlso ipendPoint Is Nothing Then
							Dim array2 As String() = [string].Split(New Char() { vbVerticalTab })
							If array2.Length = 3 AndAlso Operators.CompareString(array2(1), Me.o0OO._0.(), True) = 0 Then
								Dim ipString As String = array2(2).Substring(0, array2(2).IndexOf(":"))
								Dim value As String = array2(2).Substring(array2(2).IndexOf(":") + 1)
								ipendPoint = New IPEndPoint(IPAddress.Parse(ipString), Conversions.ToInteger(value))
								array = Encoding.Unicode.GetBytes("Ping")
								Me.O0__00OoOo_O.o..Send(array, array.Length, ipendPoint)
								Continue While
							End If
						End If
						If Operators.CompareString(Me.O_0Oo.OO_o..ToString(), ipendPoint2.ToString(), True) = 0 OrElse (ipendPoint IsNot Nothing AndAlso Operators.CompareString(ipendPoint.ToString(), ipendPoint2.ToString(), True) = 0) Then
							Dim array3 As String() = [string].Split(New Char() { ":"c })
							If array3.Length = 3 AndAlso Versioned.IsNumeric(array3(0)) AndAlso Versioned.IsNumeric(array3(1)) Then
								Dim val As Integer = Conversions.ToInteger(array3(0))
								Dim val2 As Integer = Conversions.ToInteger(array3(1))
								Dim num As Long = Conversions.ToLong(array3(2))
								Me.oOoo_oo0o_._0. = num
								Me.o_Oo_o._Oo_o_. = Math.Min(Me.o_Oo_o._Oo_o_., val)
								Me.O.0_oO_o_0O0o. = Math.Min(Me.O.0_oO_o_0O0o., val2)
								Me.O_0Oo.OO_o. = New Object(CInt(Math.Ceiling(CDbl(num) / CDbl(Me.O.0_oO_o_0O0o.))) - 1 + 1 - 1) {}
								Me.o_Oo_o._Oo_o_. = New Integer(CInt(Math.Ceiling(CDbl(Me.O_0Oo.OO_o..Length) / CDbl(Me.o_Oo_o._Oo_o_.))) - 1 + 1 - 1) {}
								Me.o_Oo_o._Oo_o_..SetLength(num)
								Me.O_0Oo.OO_o. = ipendPoint2
								flag = True
								Exit While
							End If
						End If
					End If
				End While
				If Not flag OrElse Me.o_Oo_o._Oo_o_..Length = 0 Then
					Me.o_Oo_o._Oo_o_..Close()
					Me.O0__00OoOo_O.o..Close()
					If OO_00oOO.FileSys.FileExists(Me.ooo0_.o__.) Then
						OO_00oOO.FileSys.DeleteFile(Me.ooo0_.o__.)
					End If
					If Not flag Then
						Me.Oo0___._oooo_O. = True
					End If
					Me.o0_.OO0O_o.(True)
				Else
					Dim bytes As Byte() = Encoding.Unicode.GetBytes(Conversions.ToString(Me.o_Oo_o._Oo_o_.) + ":" + Conversions.ToString(Me.O.0_oO_o_0O0o.))
					Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
					Encoding.Unicode.GetBytes(String.Concat(New String() { "@", Conversions.ToString(Me.o_Oo_o._Oo_o_.), ":", Conversions.ToString(Me.O.0_oO_o_0O0o.), "@" }))
					Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
					Me.O_0Oo.OO_o. = DateTime.Now
					Me.O.0_oO_o_0O0o. = DateTime.Now
					now = DateTime.Now
					Dim array4 As Integer() = New Integer(Me.o_Oo_o._Oo_o_..Length - 1 + 1 - 1) {}
					Dim num2 As Integer
					If Me.OO.000O.() = SendTypeEnum.Capture Then
						num2 = 5
					Else
						num2 = 20
					End If
					Dim flag2 As Boolean
					While DateTime.Compare(DateTime.Now, now.AddSeconds(CDbl(num2))) < 0 AndAlso (Not(TypeOf Me.O_0Oo.OO_o. Is IMClient) OrElse Not CType(Me.O_0Oo.OO_o., IMClient).O0_OOo.O.) AndAlso (Not(TypeOf Me.O_0Oo.OO_o. Is IMServer) OrElse Not CType(Me.O_0Oo.OO_o., IMServer).o0oo__0Oo_.o00.) AndAlso Not Me.ooo0_.o__.
						If Me.O0__00OoOo_O.o..Available > 0 Then
							now = DateTime.Now
							Dim ipendPoint3 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
							Dim array5 As Byte() = Me.O0__00OoOo_O.o..Receive(ipendPoint3)
							If Operators.CompareString(ipendPoint3.ToString(), Me.O_0Oo.OO_o..ToString(), True) = 0 Then
								If array5.Length = 4 Then
									Dim num3 As Integer = BitConverter.ToInt32(array5, 0)
									If Me.o_Oo_o._Oo_o_.(num3) = -1 Then
										array4(num3) += 1
										bytes = Encoding.Unicode.GetBytes(num3.ToString())
										Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
										bytes = Encoding.Unicode.GetBytes((-num3).ToString())
										Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
									End If
								ElseIf array5.Length > 4 Then
									Dim num4 As Integer = Math.Abs(BitConverter.ToInt32(array5, 0))
									If num4 >= 0 AndAlso num4 <= Me.O_0Oo.OO_o..Length - 1 Then
										Dim num5 As Integer = num4 / Me.o_Oo_o._Oo_o_.
										If Me.o_Oo_o._Oo_o_.(num5) = -1 Then
											If num4 = num5 * Me.o_Oo_o._Oo_o_. Then
												bytes = Encoding.Unicode.GetBytes(num5.ToString())
												Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
												bytes = Encoding.Unicode.GetBytes((-num5).ToString())
												Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
											End If
										ElseIf Me.o_Oo_o._Oo_o_.(num5) <> -1 AndAlso Me.O_0Oo.OO_o.(num4) Is Nothing Then
											Me.O_0Oo.OO_o.(num4) = array5
											Me.o_Oo_o._Oo_o_.(num5) = Me.o_Oo_o._Oo_o_.(num5) + 1
											If Me.o_Oo_o._Oo_o_.(num5) = Me.o_Oo_o._Oo_o_. OrElse (num5 = Me.o_Oo_o._Oo_o_..Length - 1 AndAlso Me.o_Oo_o._Oo_o_.(num5) = Me.O_0Oo.OO_o..Length Mod Me.o_Oo_o._Oo_o_.) Then
												Me.o_Oo_o._Oo_o_.(num5) = -1
												Me.o0_.OO0O_o.(num5)
												Me.ooo0_.o__. += 1
												bytes = Encoding.Unicode.GetBytes(num5.ToString())
												Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
												bytes = Encoding.Unicode.GetBytes((-num5).ToString())
												Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
											End If
										End If
										If Me.ooo0_.o__. = Me.o_Oo_o._Oo_o_..Length Then
											bytes = Encoding.Unicode.GetBytes(Integer.MaxValue.ToString())
											Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
											Thread.Sleep(10)
											bytes = Encoding.Unicode.GetBytes(Integer.MinValue.ToString())
											Me.O0__00OoOo_O.o..Send(bytes, bytes.Length, Me.O_0Oo.OO_o.)
											flag2 = True
											Exit While
										End If
									End If
								End If
							End If
						End If
					End While
					Me.O0__00OoOo_O.o..Close()
					Me.o_Oo_o._Oo_o_..Close()
					If TypeOf Me.O_0Oo.OO_o. Is IMClient AndAlso Not Me.ooo0_.o__. AndAlso Not flag2 Then
						Me.Oo0___._oooo_O. = True
					End If
					Dim o00.O0. As Object = OO_00oOO.IMClients.O00.O0.
					ObjectFlowControl.CheckForSyncLockOnValueType(o00.O0.)
					SyncLock o00.O0.
						If flag2 Then
							If Operators.CompareString(OO_00oOO.FileSys.GetParentPath(Me.o_Oo_o._Oo_o_.), "", True) = 0 Then
								Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(Me.o_Oo_o._Oo_o_.)
								Dim extension As String = Path.GetExtension(Me.o_Oo_o._Oo_o_.)
								Dim text As String = OO_00oOO.ProjectPath + "QQClient\ReceivedFiles\" + Strings.Format(DateTime.Today, "yyyyMM") + "\"
								If Not OO_00oOO.FileSys.DirectoryExists(text) Then
									OO_00oOO.FileSys.CreateDirectory(text)
								End If
								If Not OO_00oOO.FileSys.FileExists(text + fileNameWithoutExtension + extension) Then
									Me.o_Oo_o._Oo_o_. = text + fileNameWithoutExtension + extension
								Else
									Dim num6 As Integer = 1
									While OO_00oOO.FileSys.FileExists(String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num6), ")", extension }))
										num6 += 1
									End While
									Me.o_Oo_o._Oo_o_. = String.Concat(New String() { text, fileNameWithoutExtension, "(", Conversions.ToString(num6), ")", extension })
								End If
							End If
							File.Move(Me.ooo0_.o__., Me.o_Oo_o._Oo_o_.)
							Me.O_OOOooo_0.O.(True)
						ElseIf OO_00oOO.FileSys.FileExists(Me.ooo0_.o__.) Then
							OO_00oOO.FileSys.DeleteFile(Me.ooo0_.o__.)
						End If
					End SyncLock
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.o0_.OO0O_o.(True)
				If Me.OO.000O.() IsNot Nothing AndAlso Me.OO.000O.() = SendTypeEnum.Capture Then
					Dim imclient2 As IMClient = CType(Me.O_0Oo.OO_o., IMClient)
					Dim oo.___oo__0_O. As Object = imclient2.oo.___oo__0_O.
					ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.)
					SyncLock oo.___oo__0_O.
						imclient2.o_oo0.O0Oo__oO. -= 1
					End SyncLock
				End If
			End Try
		End Sub

		' Token: 0x06001590 RID: 5520 RVA: 0x0008E674 File Offset: 0x0008C874
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim offset As Long = CLng(A_0) * CLng(Me.o_Oo_o._Oo_o_.) * CLng(Me.O.0_oO_o_0O0o.)
			Dim num As Integer = A_0 * Me.o_Oo_o._Oo_o_.
			Dim num2 As Integer = Math.Min(num + Me.o_Oo_o._Oo_o_. - 1, Me.O_0Oo.OO_o..Length - 1)
			Me.o_Oo_o._Oo_o_..Seek(offset, SeekOrigin.Begin)
			Dim num3 As Integer = num2
			For i As Integer = num To num3
				Dim array As Byte() = CType(Me.O_0Oo.OO_o.(i), Byte())
				Me.o_Oo_o._Oo_o_..Write(array, 4, array.Length - 4)
				Me.o_Oo_o._Oo_o_. = Me.o_Oo_o._Oo_o_. + CLng(array.Length) - 4L
				Me.O_0Oo.OO_o.(i) = Nothing
			Next
			If Me.O0__00OoOo_O.o. IsNot Nothing AndAlso Me.O0__00OoOo_O.o..FindForm() IsNot Nothing AndAlso (DateTime.Now - Me.O.0_oO_o_0O0o.).TotalSeconds >= 0.5 AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.o0_.OO0O_o.)
			End If
		End Sub

		' Token: 0x06001591 RID: 5521 RVA: 0x0008E778 File Offset: 0x0008C978
		Private Sub <<EMPTY_NAME>>()
			Dim timeSpan As TimeSpan = DateTime.Now - Me.O_0Oo.OO_o.
			Dim num As Double = CDbl(Me.o_Oo_o._Oo_o_.) / 1024.0 / timeSpan.TotalSeconds
			If num < 1000.0 Then
				Me.O0__00OoOo_O.o..O0__00OoOo_O.o.().Text = Strings.Format(num, "0.0") + "K/S"
			Else
				num /= 1024.0
				Me.O0__00OoOo_O.o..O0__00OoOo_O.o.().Text = Strings.Format(num, "0.00") + "M/S"
			End If
			Dim num2 As Long = Me.o_Oo_o._Oo_o_. / 1024L
			Dim str As String
			If num2 < 1000L Then
				str = num2.ToString() + "K"
			Else
				str = Strings.Format(CDbl(Me.o_Oo_o._Oo_o_.) / 1024.0 / 1024.0, "0.00") + "M"
			End If
			num2 = Me.oOoo_oo0o_._0. / 1014L
			Dim str2 As String
			If num2 < 1000L Then
				str2 = num2.ToString() + "K"
			Else
				str2 = Strings.Format(CDbl(Me.oOoo_oo0o_._0.) / 1024.0 / 1024.0, "0.00") + "M"
			End If
			Me.O0__00OoOo_O.o..Oo0O_.o.().Text = str + "/" + str2
			Me.O0__00OoOo_O.o..O0__00OoOo_O.o.().Value = Math.Min(100, CInt(Math.Round(CDbl(Me.o_Oo_o._Oo_o_.) / CDbl(Me.oOoo_oo0o_._0.) * 100.0)))
			Me.O.0_oO_o_0O0o. = DateTime.Now
		End Sub

		' Token: 0x040008B8 RID: 2232
		Private <<EMPTY_NAME>> As Object

		' Token: 0x040008B9 RID: 2233
		Private <<EMPTY_NAME>> As UdpClient

		' Token: 0x040008BA RID: 2234
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x040008BB RID: 2235
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040008BC RID: 2236
		Private <<EMPTY_NAME>> As FileStream

		' Token: 0x040008BD RID: 2237
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008BE RID: 2238
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008BF RID: 2239
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x040008C0 RID: 2240
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x040008C1 RID: 2241
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040008C2 RID: 2242
		Private <<EMPTY_NAME>> As String

		' Token: 0x040008C3 RID: 2243
		Private <<EMPTY_NAME>> As String

		' Token: 0x040008C4 RID: 2244
		Private <<EMPTY_NAME>> As SendTypeEnum

		' Token: 0x040008C5 RID: 2245
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040008C6 RID: 2246
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040008C7 RID: 2247
		Private <<EMPTY_NAME>> As String

		' Token: 0x040008C8 RID: 2248
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x040008C9 RID: 2249
		Friend <<EMPTY_NAME>> As Oo0O__

		' Token: 0x040008CA RID: 2250
		Private <<EMPTY_NAME>> As Long

		' Token: 0x040008CB RID: 2251
		Friend <<EMPTY_NAME>> As Long

		' Token: 0x040008CC RID: 2252
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040008CD RID: 2253
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040008CE RID: 2254
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040008CF RID: 2255
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x020001CD RID: 461
		' (Invoke) Token: 0x06001595 RID: 5525
		Public Delegate Sub oOoo()
	End Class
End Namespace
