Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001C2 RID: 450
	Friend Class o0O0OOoOO
		' Token: 0x060014EB RID: 5355 RVA: 0x0008201C File Offset: 0x0008021C
		Public Sub New(A_0 As IMServer, A_1 As IPEndPoint, A_2 As String)
			Me.ooOoO_0Oo.O. = 8
			Me.o0Ooo_oO_Oo.0. = 8
			Me.OO._000_oO_O. = 500
			Me.oO_o_O.o_. = New AutoResetEvent(False)
			Me.ooOoO_0Oo.O. = New ReaderWriterLock()
			Me.ooOoO_0Oo.O. = New List(Of Integer)()
			Me.o0Ooo_oO_Oo.0. = New List(Of Integer)()
			Me.O_.OOoo_Oo. = -1
			Me.oO_o_O.o_. = A_0
			Me.ooo_OoooOOO.0. = A_1
			Dim length As Integer = A_2.Length
			Me.oO_o_O.o_. = New Object(CInt(Math.Ceiling(CDbl(length) / CDbl(Me.OO._000_oO_O.))) - 1 + 1 - 1) {}
			Me.oO_o_O.o_. = New Integer(CInt(Math.Ceiling(CDbl(Me.oO_o_O.o_..Length) / CDbl(Me.o0Ooo_oO_Oo.0.))) - 1 + 1 - 1) {}
			Me.o0Ooo_oO_Oo.0. = New Integer(CInt(Math.Ceiling(CDbl(Me.oO_o_O.o_..Length) / CDbl(Me.o0Ooo_oO_Oo.0.))) - 1 + 1 - 1) {}
			Dim num As Integer = Me.oO_o_O.o_..Length - 1
			For i As Integer = 0 To num
				Me.oO_o_O.o_.(i) = Encoding.Unicode.GetBytes(Conversions.ToString(i) + vbTab + A_2.Substring(i * Me.OO._000_oO_O., Math.Min(Me.OO._000_oO_O., length - i * Me.OO._000_oO_O.)))
			Next
		End Sub

		' Token: 0x060014EC RID: 5356 RVA: 0x00082158 File Offset: 0x00080358
		Friend Function <<EMPTY_NAME>>() As Boolean
			Try
				Me.ooOoO_0Oo.O. = o0___oO.o0__.0.(Me.oO_o_O.o_.)
				o0___oO.O.oOo0O0O.(Me.ooOoO_0Oo.O.)
				Me.ooOoO_0Oo.O..Client.SendBufferSize = 81920
				Me.ooOoO_0Oo.O..Client.ReceiveBufferSize = 81920
				Dim text As String = Me.ooOoO_0Oo.O..Client.LocalEndPoint.ToString()
				Me.oO_o_O.o_..O0o_.Oo0oo.(Me.ooo_OoooOOO.0., text.Substring(text.IndexOf(":") + 1) + vbTab + Conversions.ToString(Me.oO_o_O.o_..Length))
				Dim now As DateTime = DateTime.Now
				Dim flag As Boolean
				While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
					If Me.ooOoO_0Oo.O..Available > 0 Then
						Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim bytes As Byte() = Me.ooOoO_0Oo.O..Receive(ipendPoint)
						If Operators.CompareString(Encoding.Unicode.GetString(bytes), "{Ready}", True) = 0 Then
							flag = True
							Exit While
						End If
					End If
				End While
				If Not flag Then
					Me.ooOoO_0Oo.O..Close()
					Return False
				End If
				Me.ooOoO_0Oo.O..BeginReceive(AddressOf Me.ooo_OoooOOO.0., Nothing)
				Dim num As Integer = Math.Min(Me.ooOoO_0Oo.O. - 1, Me.oO_o_O.o_..Length - 1)
				For i As Integer = 0 To num
					Me.ooOoO_0Oo.O..Add(i)
					Me.o0Ooo_oO_Oo.0..Add(i)
				Next
				Dim num2 As Integer = Me.ooOoO_0Oo.O.(Me.ooOoO_0Oo.O..Count - 1)
				now = DateTime.Now
				Dim result As Boolean
				While True
					Try
						For Each a_ As Integer In Me.ooOoO_0Oo.O.
							Me.ooo_OoooOOO.0.(a_)
						Next
					Finally
						Dim enumerator As List(Of Integer).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.ooOoO_0Oo.O..Clear()
					If Me.oO_o_O.o_..WaitOne(1000) Then
						Dim obj As Object = Me.o0Ooo_oO_Oo.0.
						SyncLock obj
							While Me.o0Ooo_oO_Oo.0..Count < Me.ooOoO_0Oo.O. AndAlso num2 < Me.oO_o_O.o_..Length - 1
								num2 += 1
								Me.ooOoO_0Oo.O..Add(num2)
								Me.o0Ooo_oO_Oo.0..Add(num2)
							End While
							If Me.o0Ooo_oO_Oo.0..Count = 0 Then
								result = True
								Exit For
							End If
							For j As Integer = Me.o0Ooo_oO_Oo.0..Count - 1 To 0 Step -1
								If Me.O_.OOoo_Oo. - Me.o0Ooo_oO_Oo.0.(j) >= 1 Then
									Me.oO_o_O.o_..O0o_.Oo0oo.(Me.ooo_OoooOOO.0., "*" & vbVerticalTab + Conversions.ToString(Me.o0Ooo_oO_Oo.0.(j)))
								End If
								If Me.O_.OOoo_Oo. - Me.o0Ooo_oO_Oo.0.(j) >= 3 AndAlso Not Me.ooOoO_0Oo.O..Contains(Me.o0Ooo_oO_Oo.0.(j)) Then
									Me.ooOoO_0Oo.O..Insert(0, Me.o0Ooo_oO_Oo.0.(j))
								End If
							Next
							GoTo IL_32A
						End SyncLock
						GoTo IL_319
					End If
					GoTo IL_319
					IL_32A:
					For k As Integer = Me.ooOoO_0Oo.O..Count - 1 To 0 Step -1
						Dim num3 As Integer = Me.ooOoO_0Oo.O.(k)
						If Me.o0Ooo_oO_Oo.0.(num3) > 0 Then
							Me.ooOoO_0Oo.O..Remove(num3)
							If Me.o0Ooo_oO_Oo.0..Contains(num3) Then
								Me.o0Ooo_oO_Oo.0..Remove(num3)
							End If
						End If
					Next
					Try
						For Each num4 As Integer In Me.ooOoO_0Oo.O.
							If Me.oO_o_O.o_.(num4) >= 8 Then
								GoTo IL_3FD
							End If
							If Me.oO_o_O.o_.(num4) >= 1 Then
								Me.oO_o_O.o_..O0o_.Oo0oo.(Me.ooo_OoooOOO.0., "*" & vbVerticalTab + Conversions.ToString(num4))
							End If
						Next
						Continue For
					Finally
						Dim enumerator2 As List(Of Integer).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					Exit For
					IL_319:
					Me.ooOoO_0Oo.O..AddRange(Me.o0Ooo_oO_Oo.0.)
					GoTo IL_32A
				End While
				IL_3FD:
				Me.ooOoO_0Oo.O..AcquireWriterLock(-1)
				Dim totalSeconds As Double = (DateTime.Now - now).TotalSeconds
				Me.oO_o_O.o_. = True
				Me.ooOoO_0Oo.O..Close()
				Me.ooOoO_0Oo.O..ReleaseWriterLock()
				Return result
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			End Try
			Me.oO_o_O.o_. = True
			Dim result2 As Boolean
			Return result2
		End Function

		' Token: 0x060014ED RID: 5357 RVA: 0x0008262C File Offset: 0x0008082C
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.oO_o_O.o_.(A_0) = Me.oO_o_O.o_.(A_0) + 1
			Dim num As Integer = A_0 * Me.o0Ooo_oO_Oo.0.
			Dim num2 As Integer = Math.Min(num + Me.o0Ooo_oO_Oo.0. - 1, Me.oO_o_O.o_..Length - 1)
			Dim num3 As Integer = num2
			Dim num4 As Integer = num
			While num4 <= num3 AndAlso Me.o0Ooo_oO_Oo.0.(A_0) <= 0
				Dim array As Byte() = CType(Me.oO_o_O.o_.(num4), Byte())
				Me.ooOoO_0Oo.O..Send(array, array.Length, Me.ooo_OoooOOO.0.)
				num4 += 1
			End While
		End Sub

		' Token: 0x060014EE RID: 5358 RVA: 0x000826AC File Offset: 0x000808AC
		Private Sub <<EMPTY_NAME>>(A_0 As IAsyncResult)
			Me.ooOoO_0Oo.O..AcquireReaderLock(-1)
			Try
				If Not Me.oO_o_O.o_. Then
					Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim bytes As Byte() = Me.ooOoO_0Oo.O..EndReceive(A_0, ipendPoint)
					Dim [string] As String = Encoding.Unicode.GetString(bytes)
					If Operators.CompareString(Me.ooo_OoooOOO.0..ToString(), ipendPoint.ToString(), True) = 0 Then
						Dim obj As Object = Me.o0Ooo_oO_Oo.0.
						SyncLock obj
							Dim num As Integer
							If Integer.TryParse([string], num) Then
								num = Math.Abs(num)
								If Me.o0Ooo_oO_Oo.0..Contains(num) Then
									Me.o0Ooo_oO_Oo.0..Remove(num)
									Me.o0Ooo_oO_Oo.0.(num) = Me.o0Ooo_oO_Oo.0.(num) + 1
									Me.O_.OOoo_Oo. = Math.Max(Me.O_.OOoo_Oo., num)
								End If
							End If
							While Me.ooOoO_0Oo.O..Available > 0
								ipendPoint = New IPEndPoint(IPAddress.Any, 0)
								bytes = Me.ooOoO_0Oo.O..Receive(ipendPoint)
								[string] = Encoding.Unicode.GetString(bytes)
								If Operators.CompareString(Me.ooo_OoooOOO.0..ToString(), ipendPoint.ToString(), True) = 0 AndAlso Integer.TryParse([string], num) Then
									num = Math.Abs(num)
									If Me.o0Ooo_oO_Oo.0..Contains(num) Then
										Me.o0Ooo_oO_Oo.0..Remove(num)
										Me.o0Ooo_oO_Oo.0.(num) = Me.o0Ooo_oO_Oo.0.(num) + 1
										Me.O_.OOoo_Oo. = Math.Max(Me.O_.OOoo_Oo., num)
									End If
								End If
							End While
						End SyncLock
						Me.oO_o_O.o_..[Set]()
						Me.ooOoO_0Oo.O..BeginReceive(AddressOf Me.ooo_OoooOOO.0., Nothing)
					End If
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.ooOoO_0Oo.O..ReleaseReaderLock()
			End Try
		End Sub

		' Token: 0x04000852 RID: 2130
		Private <<EMPTY_NAME>> As IMServer

		' Token: 0x04000853 RID: 2131
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x04000854 RID: 2132
		Private <<EMPTY_NAME>> As UdpClient

		' Token: 0x04000855 RID: 2133
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000856 RID: 2134
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000857 RID: 2135
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000858 RID: 2136
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x04000859 RID: 2137
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x0400085A RID: 2138
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x0400085B RID: 2139
		Private <<EMPTY_NAME>> As AutoResetEvent

		' Token: 0x0400085C RID: 2140
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400085D RID: 2141
		Private <<EMPTY_NAME>> As ReaderWriterLock

		' Token: 0x0400085E RID: 2142
		Private <<EMPTY_NAME>> As List(Of Integer)

		' Token: 0x0400085F RID: 2143
		Private <<EMPTY_NAME>> As List(Of Integer)

		' Token: 0x04000860 RID: 2144
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
