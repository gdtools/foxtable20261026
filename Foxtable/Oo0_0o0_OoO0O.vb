Imports System
Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001C1 RID: 449
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Oo0_0o0_OoO0O
		' Token: 0x060014E8 RID: 5352 RVA: 0x00081B74 File Offset: 0x0007FD74
		Public Sub New(A_0 As UdpClient, A_1 As IPEndPoint)
			Me.ooo_OoooOOO.0. = 8
			Me.ooo.0_OO. = 500
			Me.oOo0O_o_.oO_o. = A_0
			Me.ooo_OoooOOO.0. = A_1
		End Sub

		' Token: 0x060014E9 RID: 5353 RVA: 0x00081B9C File Offset: 0x0007FD9C
		Public Function <<EMPTY_NAME>>() As Boolean
			Dim now As DateTime = DateTime.Now
			Dim flag As Boolean
			While DateTime.Compare(DateTime.Now, now.AddSeconds(4.0)) < 0
				If Me.oOo0O_o_.oO_o..Available > 0 Then
					now = DateTime.Now
					Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim bytes As Byte() = Me.oOo0O_o_.oO_o..Receive(ipendPoint)
					If Operators.CompareString(Me.ooo_OoooOOO.0..ToString(), ipendPoint.ToString(), True) = 0 Then
						Dim [string] As String = Encoding.Unicode.GetString(bytes)
						If Operators.CompareString([string], "None", True) = 0 Then
							Me.oOo0O_o_.oO_o..Close()
							Return True
						End If
						Dim array As String() = [string].Split(New Char() { vbTab })
						If array.Length = 2 AndAlso Versioned.IsNumeric(array(0)) AndAlso Versioned.IsNumeric(array(1)) Then
							Me.ooo_OoooOOO.0. = New IPEndPoint(Me.ooo_OoooOOO.0..Address, Conversions.ToInteger(array(0)))
							Me.ooo_OoooOOO.0. = New String(Conversions.ToInteger(array(1)) - 1 + 1 - 1) {}
							Me.ooo_OoooOOO.0. = New Integer(CInt(Math.Ceiling(CDbl(Me.ooo_OoooOOO.0..Length) / CDbl(Me.ooo_OoooOOO.0.))) - 1 + 1 - 1) {}
							flag = True
							Exit While
						End If
					End If
				End If
			End While
			If Not flag Then
				Me.oOo0O_o_.oO_o..Close()
				Return False
			End If
			If Me.ooo_OoooOOO.0..Length = 0 Then
				Me.oOo0O_o_.oO_o..Close()
				Return True
			End If
			Dim bytes2 As Byte() = Encoding.Unicode.GetBytes("{Ready}")
			Me.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, Me.ooo_OoooOOO.0.)
			now = DateAndTime.Now
			Dim result As Boolean
			While DateTime.Compare(DateTime.Now, now.AddSeconds(4.0)) < 0
				If Me.oOo0O_o_.oO_o..Available > 0 Then
					now = DateTime.Now
					Dim ipendPoint2 As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
					Dim bytes3 As Byte() = Me.oOo0O_o_.oO_o..Receive(ipendPoint2)
					If Operators.CompareString(ipendPoint2.ToString(), Me.ooo_OoooOOO.0..ToString(), True) = 0 Then
						Dim text As String = Encoding.Unicode.GetString(bytes3)
						If text.StartsWith("*" & vbVerticalTab) Then
							text = text.Substring(2)
							Dim num As Integer
							If Integer.TryParse(text, num) AndAlso Me.ooo_OoooOOO.0.(num) = -1 Then
								bytes2 = Encoding.Unicode.GetBytes(num.ToString())
								Me.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, Me.ooo_OoooOOO.0.)
								bytes2 = Encoding.Unicode.GetBytes((-num).ToString())
								Me.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, Me.ooo_OoooOOO.0.)
							End If
						ElseIf text.IndexOf(vbTab) >= 1 Then
							Dim s As String = text.Substring(0, text.IndexOf(vbTab))
							Dim text2 As String = text.Substring(text.IndexOf(vbTab) + 1)
							Dim num2 As Integer
							If Integer.TryParse(s, num2) AndAlso num2 >= 0 AndAlso num2 <= Me.ooo_OoooOOO.0..Length - 1 Then
								Dim num3 As Integer = num2 / Me.ooo_OoooOOO.0.
								If Operators.CompareString(Me.ooo_OoooOOO.0.(num2), "", True) = 0 Then
									Me.ooo_OoooOOO.0.(num2) = text2
									Me.ooo_OoooOOO.0.(num3) = Me.ooo_OoooOOO.0.(num3) + 1
									If Me.ooo_OoooOOO.0.(num3) = Me.ooo_OoooOOO.0. OrElse (num3 = Me.ooo_OoooOOO.0..Length - 1 AndAlso Me.ooo_OoooOOO.0.(num3) = Me.ooo_OoooOOO.0..Length Mod Me.ooo_OoooOOO.0.) Then
										Me.ooo_OoooOOO.0.(num3) = -1
										Me.OO___o.0Oo00. += 1
										bytes2 = Encoding.Unicode.GetBytes(num3.ToString())
										Me.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, Me.ooo_OoooOOO.0.)
										bytes2 = Encoding.Unicode.GetBytes((-num3).ToString())
										Me.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, Me.ooo_OoooOOO.0.)
									End If
								End If
								If Me.OO___o.0Oo00. = Me.ooo_OoooOOO.0..Length Then
									result = True
									Exit While
								End If
							End If
						End If
					End If
				End If
			End While
			Me.oOo0O_o_.oO_o..Close()
			Return result
		End Function

		' Token: 0x060014EA RID: 5354 RVA: 0x00081FCC File Offset: 0x000801CC
		Friend Function <<EMPTY_NAME>>() As String
			Dim result As String
			If Me.ooo_OoooOOO.0. Is Nothing Then
				result = ""
			Else
				Dim stringBuilder As StringBuilder = New StringBuilder()
				For Each value As String In Me.ooo_OoooOOO.0.
					stringBuilder.Append(value)
				Next
				result = stringBuilder.ToString()
			End If
			Return result
		End Function

		' Token: 0x0400084B RID: 2123
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400084C RID: 2124
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400084D RID: 2125
		Private <<EMPTY_NAME>> As String()

		' Token: 0x0400084E RID: 2126
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x0400084F RID: 2127
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000850 RID: 2128
		Private <<EMPTY_NAME>> As UdpClient

		' Token: 0x04000851 RID: 2129
		Private <<EMPTY_NAME>> As IPEndPoint
	End Class
End Namespace
