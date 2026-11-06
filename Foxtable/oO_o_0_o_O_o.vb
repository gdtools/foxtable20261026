Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200018E RID: 398
	Friend Class oO_o_0_o_O_o
		' Token: 0x0600125C RID: 4700 RVA: 0x0006FC48 File Offset: 0x0006DE48
		Public Sub <<EMPTY_NAME>>()
			Me.O00.oo0_0oo. = o0___oO.o0__.0.(Me.O00.oo0_0oo.)
			o0___oO.O.oOo0O0O.(Me.O00.oo0_0oo.)
			Me.O00.oo0_0oo..Client.SendBufferSize = 81920
			Me.O00.oo0_0oo..Client.ReceiveBufferSize = 91920
			Dim text As String = vbVerticalTab
			Dim text2 As String = Me.O00.oo0_0oo..Client.LocalEndPoint.ToString()
			Dim a_ As String = String.Concat(New String() { "%10", text, Me.O00.oo0_0oo..Name, text, Me.O00.oo0_0oo., text, text2.Substring(text2.IndexOf(":") + 1), text, Me.oO.o0_O_. })
			Me.O00.oo0_0oo..oOOOo._.(Me.oO.o0_O_..Name, a_)
			Dim now As DateTime = DateTime.Now
			Do
				If Me.O00.oo0_0oo..Available > 0 Then
					now = DateTime.Now
					Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim bytes As Byte() = Me.O00.oo0_0oo..Receive(ipendPoint)
					If Operators.CompareString(Encoding.Unicode.GetString(bytes), "Ping", True) = 0 Then
						Me.oO.o0_O_. = ipendPoint
					End If
				End If
			Loop While(DateTime.Now - now).TotalSeconds < 3.0
			If Me.oO.o0_O_. IsNot Nothing Then
				Dim bytes2 As Byte() = Encoding.Unicode.GetBytes(text2.Substring(text2.IndexOf(":") + 1) + vbTab + Me.oO.o0_O_.)
				Me.O00.oo0_0oo..ooO_.O0_..Send(bytes2, bytes2.Length, Me.O00.oo0_0oo.)
				now = DateTime.Now
				While (DateTime.Now - now).TotalSeconds < 5.0
					If Me.O00.oo0_0oo..Available > 0 Then
						now = DateTime.Now
						Dim ipendPoint2 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim array As Byte() = Me.O00.oo0_0oo..Receive(ipendPoint2)
						If Operators.CompareString(ipendPoint2.ToString(), Me.O00.oo0_0oo..ToString(), True) = 0 Then
							Me.O00.oo0_0oo..Send(array, array.Length, Me.oO.o0_O_.)
						ElseIf Operators.CompareString(ipendPoint2.ToString(), Me.oO.o0_O_..ToString(), True) = 0 Then
							Me.O00.oo0_0oo..Send(array, array.Length, Me.O00.oo0_0oo.)
						End If
					End If
				End While
			End If
		End Sub

		' Token: 0x04000736 RID: 1846
		Friend <<EMPTY_NAME>> As IMServer

		' Token: 0x04000737 RID: 1847
		Friend <<EMPTY_NAME>> As IMUser

		' Token: 0x04000738 RID: 1848
		Friend <<EMPTY_NAME>> As IMUser

		' Token: 0x04000739 RID: 1849
		Friend <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x0400073A RID: 1850
		Friend <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x0400073B RID: 1851
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400073C RID: 1852
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400073D RID: 1853
		Private <<EMPTY_NAME>> As UdpClient
	End Class
End Namespace
