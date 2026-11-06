Imports System
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002BD RID: 701
	Friend NotInheritable Module OoO0o
		' Token: 0x0600255B RID: 9563
		Private Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (ByRef A_0 As Byte, ByRef A_1 As Byte, A_2 As Integer)

		' Token: 0x0600255C RID: 9564
		Private Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (ByRef A_0 As Byte, A_1 As String, A_2 As Integer)

		' Token: 0x0600255D RID: 9565
		Private Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (A_0 As StringBuilder, ByRef A_1 As Byte, A_2 As Integer)

		' Token: 0x0600255E RID: 9566
		Private Declare Ansi Function HidD_GetAttributes Lib "HID.dll" (A_0 As Integer, ByRef A_1 As OoO0o.o_O000_Oo0oo) As Boolean

		' Token: 0x0600255F RID: 9567
		Private Declare Ansi Function HidD_GetHidGuid Lib "HID.dll" (ByRef A_0 As OoO0o.O0o_0o_00_Oo) As Integer

		' Token: 0x06002560 RID: 9568
		Private Declare Ansi Function HidD_GetPreparsedData Lib "HID.dll" (A_0 As Integer, ByRef A_1 As Integer) As Boolean

		' Token: 0x06002561 RID: 9569
		Private Declare Ansi Function HidP_GetCaps Lib "HID.dll" (A_0 As Integer, ByRef A_1 As OoO0o.o_OO000_0) As Integer

		' Token: 0x06002562 RID: 9570
		Private Declare Ansi Function HidD_FreePreparsedData Lib "HID.dll" (A_0 As Integer) As Boolean

		' Token: 0x06002563 RID: 9571
		Private Declare Ansi Function HidD_SetFeature Lib "HID.dll" (A_0 As Integer, ByRef A_1 As Byte, A_2 As Integer) As Boolean

		' Token: 0x06002564 RID: 9572
		Private Declare Ansi Function HidD_GetFeature Lib "HID.dll" (A_0 As Integer, ByRef A_1 As Byte, A_2 As Integer) As Boolean

		' Token: 0x06002565 RID: 9573
		Private Declare Ansi Function SetupDiGetClassDevsA Lib "SetupApi.dll" (ByRef A_0 As OoO0o.O0o_0o_00_Oo, A_1 As Integer, A_2 As Integer, A_3 As Integer) As Integer

		' Token: 0x06002566 RID: 9574
		Private Declare Ansi Function SetupDiDestroyDeviceInfoList Lib "SetupApi.dll" (A_0 As Integer) As Boolean

		' Token: 0x06002567 RID: 9575
		Private Declare Ansi Function SetupDiGetDeviceInterfaceDetailA Lib "SetupApi.dll" (A_0 As Integer, ByRef A_1 As OoO0o.O_0O00__o0O, ByRef A_2 As OoO0o.O0__0o, A_3 As Integer, ByRef A_4 As Integer, A_5 As Integer) As Boolean

		' Token: 0x06002568 RID: 9576
		Private Declare Ansi Function SetupDiEnumDeviceInterfaces Lib "SetupApi.dll" (A_0 As Integer, A_1 As Integer, ByRef A_2 As OoO0o.O0o_0o_00_Oo, A_3 As Integer, ByRef A_4 As OoO0o.O_0O00__o0O) As Boolean

		' Token: 0x06002569 RID: 9577
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "CreateFileA" (A_0 As String, A_1 As Integer, A_2 As Integer, A_3 As Integer, A_4 As Integer, A_5 As Integer, A_6 As Integer) As Integer

		' Token: 0x0600256A RID: 9578
		Private Declare Ansi Function GetLastError Lib "kernel32.dll" () As Integer

		' Token: 0x0600256B RID: 9579
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "lstrcpyA" (A_0 As String, ByRef A_1 As Byte) As Integer

		' Token: 0x0600256C RID: 9580
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "CreateSemaphoreA" (A_0 As Integer, A_1 As Integer, A_2 As Integer, A_3 As String) As Integer

		' Token: 0x0600256D RID: 9581
		Private Declare Ansi Function WaitForSingleObject Lib "kernel32.dll" (A_0 As Integer, A_1 As Integer) As Integer

		' Token: 0x0600256E RID: 9582
		Private Declare Ansi Function ReleaseSemaphore Lib "kernel32.dll" (A_0 As Integer, A_1 As Integer, ByRef A_2 As Integer) As Integer

		' Token: 0x0600256F RID: 9583
		Public Declare Ansi Function lstrlenA Lib "kernel32.dll" (A_0 As String) As Integer

		' Token: 0x06002570 RID: 9584
		Public Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (ByRef A_0 As Byte, ByRef A_1 As Integer, A_2 As Integer)

		' Token: 0x06002571 RID: 9585
		Public Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (ByRef A_0 As Integer, ByRef A_1 As Byte, A_2 As Integer)

		' Token: 0x06002572 RID: 9586
		Friend Declare Function CreateFile Lib "kernel32.dll" (A_0 As String, A_1 As UInteger, A_2 As Integer, A_3 As Integer, A_4 As Integer, A_5 As Integer, A_6 As Integer) As Integer

		' Token: 0x06002573 RID: 9587
		Friend Declare Function CloseHandle Lib "kernel32.dll" (A_0 As Integer) As Integer

		' Token: 0x06002574 RID: 9588
		Friend Declare Function ReadFile Lib "kernel32.dll" (A_0 As Integer, A_1 As Byte(), A_2 As UInteger, ByRef A_3 As Integer, A_4 As UInteger) As Boolean

		' Token: 0x06002575 RID: 9589
		Friend Declare Function WriteFile Lib "kernel32.dll" (A_0 As Integer, A_1 As Byte(), A_2 As UInteger, ByRef A_3 As Integer, A_4 As UInteger) As Boolean

		' Token: 0x06002576 RID: 9590
		Friend Declare Function WaitNamedPipe Lib "kernel32.dll" (A_0 As String, A_1 As Integer) As Integer

		' Token: 0x06002577 RID: 9591
		Friend Declare Function FindWindow Lib "user32.dll" (A_0 As String, A_1 As String) As IntPtr

		' Token: 0x06002578 RID: 9592
		Friend Declare Function GetWindowText Lib "user32.dll" (A_0 As IntPtr, A_1 As StringBuilder, A_2 As Integer) As Integer

		' Token: 0x06002579 RID: 9593
		Friend Declare Ansi Function ShowWindow Lib "user32" (A_0 As IntPtr, A_1 As Integer) As Integer

		' Token: 0x0600257A RID: 9594
		Friend Declare Ansi Function CloseWindow Lib "user32" (A_0 As IntPtr) As Integer

		' Token: 0x0600257B RID: 9595
		Friend Declare Ansi Function DestroyWindow Lib "user32" (A_0 As IntPtr) As Integer

		' Token: 0x0600257C RID: 9596
		Friend Declare Ansi Function LoadRuntime Lib "Foxtable.core.dll" () As Boolean

		' Token: 0x0600257D RID: 9597 RVA: 0x000FECCC File Offset: 0x000FCECC
		Private Function <<EMPTY_NAME>>(A_0 As String) As Integer
			A_0 = Strings.UCase(A_0)
			Dim str As String = "0123456789ABCDEF"
			Dim num As Integer = 1
			Dim num2 As Integer = 0
			For i As Integer = A_0.Length To 1 Step -1
				Dim left As String = Strings.Mid(A_0, i, 1)
				Dim num3 As Integer = 0
				Dim num4 As Integer = 1
				Do
					If Operators.CompareString(left, Strings.Mid(str, num4, 1), True) = 0 Then
						num3 = num4 - 1
					End If
					num4 += 1
				Loop While num4 <= 16
				num2 += num3 * num
				num *= 16
			Next
			Return num2
		End Function

		' Token: 0x0600257E RID: 9598 RVA: 0x000FED48 File Offset: 0x000FCF48
		Private Function <<EMPTY_NAME>>(A_0 As Long, A_1 As Long) As Long
			Dim num As Long = A_0 And -2147483648L
			Dim num2 As Long = A_1 And -2147483648L
			Dim num3 As Long = A_0 And 1073741824L
			Dim num4 As Long = A_1 And 1073741824L
			Dim num5 As Long = (A_0 And 1073741823L) + (A_1 And 1073741823L)
			If(num3 And num4) <> 0L Then
				num5 = (num5 Xor -2147483648L Xor num Xor num2)
			ElseIf(num3 Or num4) <> 0L Then
				If(num5 And 1073741824L) <> 0L Then
					num5 = (num5 Xor -1073741824L Xor num Xor num2)
				Else
					num5 = (num5 Xor 1073741824L Xor num Xor num2)
				End If
			Else
				num5 = (num5 Xor num Xor num2)
			End If
			Return num5
		End Function

		' Token: 0x0600257F RID: 9599 RVA: 0x000FEDF4 File Offset: 0x000FCFF4
		Private Function <<EMPTY_NAME>>(A_0 As Long, A_1 As Long) As Long
			Dim num As Long = A_0 And -2147483648L
			Dim num2 As Long = A_1 And -2147483648L
			Dim num3 As Double = CDbl((A_0 And 2147483647L))
			Dim num4 As Double = CDbl((A_1 And 2147483647L))
			Dim num5 As Double
			If num <> 0L Then
				If num2 <> 0L Then
					num5 = num3 - num4
				Else
					num3 += 2147483648.0
					num5 = num3 - num4
				End If
			ElseIf num2 <> 0L Then
				num4 = CDbl(A_1)
				num5 = num3 - num4
			Else
				num5 = num3 - num4
			End If
			Dim result As Long
			If num5 < 0.0 Then
				result = ((CLng(Math.Round(2147483648.0 + num5)) Or -2147483648L) And -1L)
			ElseIf num5 > 2147483647.0 Then
				result = ((CLng(Math.Round(num5 - 2147483648.0)) Or -2147483648L) And -1L)
			Else
				result = (CLng(Math.Round(num5)) And -1L)
			End If
			Return result
		End Function

		' Token: 0x06002580 RID: 9600 RVA: 0x000FEED0 File Offset: 0x000FD0D0
		Private Function <<EMPTY_NAME>>(A_0 As Long, A_1 As Integer) As Long
			A_1 = A_1 Mod 32
			Dim num As Long = A_0
			Dim result As Long
			If A_1 = 0 Then
				result = num
			Else
				Dim num2 As Integer = A_1
				For i As Integer = 1 To num2
					Dim num3 As Long = num And 1073741824L
					num = (num And 1073741823L) * 2L
					If(num3 And 1073741824L) <> 0L Then
						num = num Or -2147483648L
					End If
				Next
				result = num
			End If
			Return result
		End Function

		' Token: 0x06002581 RID: 9601 RVA: 0x000FEF28 File Offset: 0x000FD128
		Private Function <<EMPTY_NAME>>(A_0 As Long, A_1 As Integer) As Long
			Dim num As Long = A_0
			A_1 = A_1 Mod 32
			Dim result As Long
			If A_1 = 0 Then
				result = num
			Else
				Dim num2 As Integer = A_1
				For i As Integer = 1 To num2
					Dim num3 As Long = num And -2147483648L
					num = (num And 2147483647L) / 2L
					If num3 <> 0L Then
						num = num Or 1073741824L
					End If
				Next
				result = num
			End If
			Return result
		End Function

		' Token: 0x06002582 RID: 9602 RVA: 0x000FEF78 File Offset: 0x000FD178
		Private Function <<EMPTY_NAME>>(A_0 As Byte) As Byte
			Dim b As Byte = CByte((OoO0o.O0o0Ooo0.oO. And 1L))
			Dim b2 As Byte = (A_0 And 128) / 128
			Dim result As Byte = (A_0 And 127) * 2 Or b
			OoO0o.O0o0Ooo0.oO. = CLng(CULng(b2))
			Return result
		End Function

		' Token: 0x06002583 RID: 9603 RVA: 0x000FEFB4 File Offset: 0x000FD1B4
		Private Function <<EMPTY_NAME>>(A_0 As Byte) As Byte
			Dim b As Byte = CByte((OoO0o.O0o0Ooo0.oO. And 128L))
			Dim b2 As Byte = (A_0 And 1) * 128
			Dim result As Byte = A_0 / 2 Or b
			OoO0o.O0o0Ooo0.oO. = CLng(CULng(b2))
			Return result
		End Function

		' Token: 0x06002584 RID: 9604 RVA: 0x000FEFEC File Offset: 0x000FD1EC
		Public Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Integer
			Dim result As Integer = A_0
			Dim array As Byte() = New Byte(3) {}
			OoO0o.Oo___0.O_o.(array(0), result, 4)
			For i As Integer = 1 To A_1
				OoO0o.O0o0Ooo0.oO. = 0L
				OoO0o.o00_.0_O.(array(3))
				Dim num As Integer = 0
				Do
					array(num) = OoO0o.o00_.0_O.(array(num))
					num += 1
				Loop While num <= 3
			Next
			OoO0o.Oo___0.O_o.(result, array(0), 4)
			Return result
		End Function

		' Token: 0x06002585 RID: 9605 RVA: 0x000FF060 File Offset: 0x000FD260
		Public Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Integer
			Dim result As Integer = A_0
			Dim array As Byte() = New Byte(3) {}
			OoO0o.Oo___0.O_o.(array(0), result, 4)
			For i As Integer = 1 To A_1
				OoO0o.O0o0Ooo0.oO. = 0L
				OoO0o.o0O.Oooo_.(array(0))
				Dim num As Integer = 3
				Do
					array(num) = OoO0o.o0O.Oooo_.(array(num))
					num += -1
				Loop While num >= 0
			Next
			OoO0o.Oo___0.O_o.(result, array(0), 4)
			Return result
		End Function

		' Token: 0x06002586 RID: 9606 RVA: 0x000FF0D4 File Offset: 0x000FD2D4
		Private Sub <<EMPTY_NAME>>(A_0 As Long(), A_1 As Long())
			New Long(1) {}
			Dim num As Long = A_0(0)
			Dim num2 As Long = A_0(1)
			Dim a_ As Long = A_1(0)
			Dim a_2 As Long = A_1(1)
			Dim a_3 As Long = A_1(2)
			Dim a_4 As Long = A_1(3)
			Dim num3 As Integer = 32
			For i As Integer = 1 To num3
				Dim num4 As Long = OoO0o.o0O.Oo.(num4, -1640531527L)
				Dim num5 As Long = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num2, 4), a_)
				Dim num6 As Long = OoO0o.o0O.Oo.(num2, num4)
				Dim num7 As Long = OoO0o.o0O.Oooo_.(num2, 5)
				num7 = OoO0o.o0O.Oo.(num7, a_2)
				Dim num8 As Long = num5 Xor num6
				num8 = num8 Xor num7
				num = OoO0o.o0O.Oo.(num, num8)
				Dim num9 As Long = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num, 4), a_3)
				num6 = OoO0o.o0O.Oo.(num, num4)
				num7 = OoO0o.o0O.Oooo_.(num, 5)
				num7 = OoO0o.o0O.Oo.(num7, a_4)
				num8 = (num9 Xor num6 Xor num7)
				num2 = OoO0o.o0O.Oo.(num2, num8)
			Next
			A_0(0) = num
			A_0(1) = num2
		End Sub

		' Token: 0x06002587 RID: 9607 RVA: 0x000FF1B0 File Offset: 0x000FD3B0
		Private Sub <<EMPTY_NAME>>(A_0 As Long(), A_1 As Long())
			New Long(1) {}
			Dim num As Long = A_0(0)
			Dim num2 As Long = A_0(1)
			Dim a_ As Long = A_1(0)
			Dim a_2 As Long = A_1(1)
			Dim a_3 As Long = A_1(2)
			Dim a_4 As Long = A_1(3)
			Dim num3 As Integer = 32
			Dim num4 As Long = OoO0o.OoO0.O0_0.(-1640531527L, 5)
			Dim num5 As Integer = num3
			For i As Integer = 1 To num5
				Dim num6 As Long = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num, 4), a_3)
				Dim num7 As Long = OoO0o.o0O.Oo.(num, num4)
				Dim num8 As Long = OoO0o.o0O.Oooo_.(num, 5)
				num8 = OoO0o.o0O.Oo.(num8, a_4)
				Dim a_5 As Long = num6 Xor num7 Xor num8
				num2 = OoO0o.oo_o_oo._0O.(num2, a_5)
				Dim num9 As Long = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num2, 4), a_)
				num7 = OoO0o.o0O.Oo.(num2, num4)
				num8 = OoO0o.o0O.Oooo_.(num2, 5)
				num8 = OoO0o.o0O.Oo.(num8, a_2)
				a_5 = (num9 Xor num7 Xor num8)
				num = OoO0o.oo_o_oo._0O.(num, a_5)
				num4 = OoO0o.oo_o_oo._0O.(num4, -1640531527L)
			Next
			A_0(0) = num
			A_0(1) = num2
		End Sub

		' Token: 0x06002588 RID: 9608 RVA: 0x000FF298 File Offset: 0x000FD498
		Private Sub <<EMPTY_NAME>>(A_0 As Long(), A_1 As Byte())
			A_0(0) = 0L
			A_0(1) = 0L
			Dim num As Integer = 0
			Do
				A_0(0) = (CLng(OoO0o.OOo0o.00000o.(CInt(A_1(num)), num * 8)) Or A_0(0))
				A_0(1) = (CLng(OoO0o.OOo0o.00000o.(CInt(A_1(num + 4)), num * 8)) Or A_0(1))
				num += 1
			Loop While num <= 3
		End Sub

		' Token: 0x06002589 RID: 9609 RVA: 0x000FF2E4 File Offset: 0x000FD4E4
		Private Sub <<EMPTY_NAME>>(A_0 As Long(), A_1 As Byte())
			Dim num As Integer = 0
			Do
				A_1(num) = CByte((OoO0o.O_O0O_0.OO0_.(CInt(A_0(0)), num * 8) And 255))
				A_1(num + 4) = CByte((OoO0o.O_O0O_0.OO0_.(CInt(A_0(1)), num * 8) And 255))
				num += 1
			Loop While num <= 3
		End Sub

		' Token: 0x0600258A RID: 9610 RVA: 0x000FF32C File Offset: 0x000FD52C
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			Dim num As Integer = OoO0o.lstrlenA(A_0) + 1
			Dim num2 As Integer
			If num < 8 Then
				num2 = 8
			Else
				num2 = num
			End If
			Dim array3 As Byte() = New Byte(num2 + 1 - 1) {}
			Dim array4 As Byte() = New Byte(num2 + 1 - 1) {}
			OoO0o.Oo___0.O_o.(array3(0), A_0, num)
			array3.CopyTo(array4, 0)
			Dim num3 As Integer = num2 - 8
			For i As Integer = 0 To num3 Step 8
				Dim num4 As Integer = 0
				Do
					array(num4) = array3(num4 + i)
					num4 += 1
				Loop While num4 <= 7
				OoO0o.oOO.0O_0oO00_o.(array, array2, A_1)
				num4 = 0
				Do
					array4(num4 + i) = array2(num4)
					num4 += 1
				Loop While num4 <= 7
			Next
			Dim text As String = ""
			Dim num5 As Integer = num2 - 1
			For i As Integer = 0 To num5
				text += array4(i).ToString("X2")
			Next
			Return text
		End Function

		' Token: 0x0600258B RID: 9611 RVA: 0x000FF420 File Offset: 0x000FD620
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Long())
			Dim array As Long() = New Long(16) {}
			Dim num As Integer = Strings.Len(A_0)
			Dim num2 As Integer = 0
			Dim num3 As Integer = num
			Dim i As Integer
			i = 1
			While i <= num3
				Dim a_ As String = Strings.Mid(A_0, i, 2)
				array(num2) = CLng(OoO0o.O_O.oOO0_.(a_))
				num2 += 1
				i += 2
			End While
			i = 0
			Do
				A_1(i) = 0L
				i += 1
			Loop While i <= 3
			i = 0
			Do
				A_1(0) = (CLng(OoO0o.OOo0o.00000o.(CInt(array(i)), i * 8)) Or A_1(0))
				A_1(1) = (CLng(OoO0o.OOo0o.00000o.(CInt(array(i + 4)), i * 8)) Or A_1(1))
				A_1(2) = (CLng(OoO0o.OOo0o.00000o.(CInt(array(i + 4 + 4)), i * 8)) Or A_1(2))
				A_1(3) = (CLng(OoO0o.OOo0o.00000o.(CInt(array(i + 4 + 4 + 4)), i * 8)) Or A_1(3))
				i += 1
			Loop While i <= 3
		End Sub

		' Token: 0x0600258C RID: 9612 RVA: 0x000FF4D8 File Offset: 0x000FD6D8
		Public Sub <<EMPTY_NAME>>(A_0 As Byte(), A_1 As Byte(), A_2 As String)
			New Byte(16) {}
			Dim a_ As Long() = New Long(2) {}
			Dim a_2 As Long() = New Long(4) {}
			OoO0o.o__._00.(A_2, a_2)
			OoO0o.o00._OOo.(a_, A_0)
			OoO0o.OO00__O.O0.(a_, a_2)
			OoO0o.o__._00.(a_, A_1)
		End Sub

		' Token: 0x0600258D RID: 9613 RVA: 0x000FF518 File Offset: 0x000FD718
		Public Sub <<EMPTY_NAME>>(A_0 As Byte(), A_1 As Byte(), A_2 As String)
			New Byte(16) {}
			Dim a_ As Long() = New Long(2) {}
			Dim a_2 As Long() = New Long(4) {}
			OoO0o.o__._00.(A_2, a_2)
			OoO0o.o00._OOo.(a_, A_0)
			OoO0o.OO.00_0.(a_, a_2)
			OoO0o.o__._00.(a_, A_1)
		End Sub

		' Token: 0x0600258E RID: 9614 RVA: 0x000FF558 File Offset: 0x000FD758
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			Dim length As Integer = A_0.Length
			If length < 16 Then
			End If
			Dim num As Integer = CInt(Math.Round(CDbl(length) / 2.0))
			Dim array3 As Byte() = New Byte(num + 1 - 1) {}
			Dim array4 As Byte() = New Byte(num + 1 - 1) {}
			Dim num2 As Integer = 0
			Dim num3 As Integer = length
			For i As Integer = 1 To num3 Step 2
				Dim a_ As String = A_0.Substring(i - 1, 2)
				array3(num2) = CByte(OoO0o.O_O.oOO0_.(a_))
				num2 += 1
			Next
			array3.CopyTo(array4, 0)
			Dim num4 As Integer = num - 8
			For i As Integer = 0 To num4 Step 8
				num2 = 0
				Do
					array(num2) = array3(num2 + i)
					num2 += 1
				Loop While num2 <= 7
				OoO0o.o.0_0O.(array, array2, A_1)
				num2 = 0
				Do
					array4(num2 + i) = array2(num2)
					num2 += 1
				Loop While num2 <= 7
			Next
			Dim stringBuilder As StringBuilder = New StringBuilder("", num)
			OoO0o.Oo___0.O_o.(stringBuilder, array4(0), num)
			Return stringBuilder.ToString()
		End Function

		' Token: 0x0600258F RID: 9615 RVA: 0x000FF65C File Offset: 0x000FD85C
		Private Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As Byte()) As Long
			Dim num As Integer = Strings.Len(A_0)
			If num < 16 Then
			End If
			Dim num2 As Long = CLng(Math.Round(CDbl(num) / 2.0))
			A_1 = New Byte(CInt(num2) + 1 - 1) {}
			Dim num3 As Integer = 0
			Dim num4 As Integer = num
			For i As Integer = 1 To num4 Step 2
				Dim a_ As String = Strings.Mid(A_0, i, 2)
				A_1(num3) = CByte(OoO0o.O_O.oOO0_.(a_))
				num3 += 1
			Next
			Return num2
		End Function

		' Token: 0x06002590 RID: 9616 RVA: 0x000FF6C0 File Offset: 0x000FD8C0
		Private Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Byte(), A_2 As Short) As Boolean
			Dim array As Byte() = New Byte(512) {}
			Dim a_ As Integer
			Dim result As Boolean
			If OoO0o.HidD_GetPreparsedData(A_0, a_) Then
				Dim o_OO000_ As OoO0o.o_OO000_0
				If OoO0o.HidP_GetCaps(a_, o_OO000_) = 0 Then
					OoO0o.HidD_FreePreparsedData(a_)
				Else
					Dim flag As Boolean = True
					array(0) = 1
					Dim flag2 As Boolean = OoO0o.HidD_GetFeature(A_0, array(0), CInt(o_OO000_.FeatureReportByteLength))
					If flag2 Then
						Dim num As Short = A_2 - 1S
						For num2 As Short = 0S To num
							A_1(CInt(num2)) = array(CInt(num2))
						Next
					End If
					flag = (flag AndAlso flag2)
					OoO0o.HidD_FreePreparsedData(a_)
					result = flag
				End If
			End If
			Return result
		End Function

		' Token: 0x06002591 RID: 9617 RVA: 0x000FF744 File Offset: 0x000FD944
		Private Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Byte(), A_2 As Short) As Boolean
			Dim array As Byte() = New Byte(512) {}
			Dim a_ As Integer
			Dim result As Boolean
			If OoO0o.HidD_GetPreparsedData(A_0, a_) Then
				Dim o_OO000_ As OoO0o.o_OO000_0
				If OoO0o.HidP_GetCaps(a_, o_OO000_) = 0 Then
					OoO0o.HidD_FreePreparsedData(a_)
				Else
					Dim flag As Boolean = True
					array(0) = 2
					Dim num As Short = A_2 - 1S
					For num2 As Short = 0S To num
						array(CInt((num2 + 1S))) = A_1(CInt((num2 + 1S)))
					Next
					Dim flag2 As Boolean = OoO0o.HidD_SetFeature(A_0, array(0), CInt(o_OO000_.FeatureReportByteLength))
					flag = (flag AndAlso flag2)
					OoO0o.HidD_FreePreparsedData(a_)
					result = flag
				End If
			End If
			Return result
		End Function

		' Token: 0x06002592 RID: 9618 RVA: 0x000FF7C8 File Offset: 0x000FD9C8
		Private Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As Short, ByRef A_2 As StringBuilder) As Boolean
			Dim o0o_0o_00_Oo As OoO0o.O0o_0o_00_Oo
			OoO0o.HidD_GetHidGuid(o0o_0o_00_Oo)
			Dim num As Integer = OoO0o.SetupDiGetClassDevsA(o0o_0o_00_Oo, 0, 0, 18)
			Dim result As Boolean
			If num <> -1 Then
				Dim o_0O00__o0O As OoO0o.O_0O00__o0O
				o_0O00__o0O.cbSize = Strings.Len(o_0O00__o0O)
				Dim num2 As Integer
				While OoO0o.SetupDiEnumDeviceInterfaces(num, 0, o0o_0o_00_Oo, num2, o_0O00__o0O) AndAlso OoO0o.GetLastError() <> 259
					Dim o0__0o As OoO0o.O0__0o
					o0__0o.cbSize = 5
					Dim num3 As Integer
					If Not OoO0o.SetupDiGetDeviceInterfaceDetailA(num, o_0O00__o0O, o0__0o, 300, num3, 0) Then
						OoO0o.SetupDiDestroyDeviceInfoList(num)
						Return result
					End If
					A_2 = New StringBuilder(New String(o0__0o.DevicePath), 260)
					Dim num4 As Integer = OoO0o.Oo___0.O_o.(A_2.ToString(), 0, 3, 0, 3, 0, 0)
					If -1 <> num4 Then
						Dim o_O000_Oo0oo As OoO0o.o_O000_Oo0oo
						If OoO0o.HidD_GetAttributes(num4, o_O000_Oo0oo) AndAlso (o_O000_Oo0oo.ProductID = -30878S And o_O000_Oo0oo.VendorID = 13961S) Then
							If A_0 = A_1 Then
								OoO0o.SetupDiDestroyDeviceInfoList(num)
								OoO0o.CloseHandle(num4)
								Return True
							End If
							A_1 += 1S
						End If
						OoO0o.CloseHandle(num4)
					End If
					num2 += 1
				End While
				OoO0o.SetupDiDestroyDeviceInfoList(num)
			End If
			Return result
		End Function

		' Token: 0x06002593 RID: 9619 RVA: 0x000FF8E0 File Offset: 0x000FDAE0
		Private Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As String) As Integer
			Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
			Dim num As Short
			Dim result As Integer
			If Not OoO0o.o__._00.(A_0, num, stringBuilder) Then
				result = -92
			Else
				A_1 = stringBuilder.ToString()
				result = 0
			End If
			Return result
		End Function

		' Token: 0x06002594 RID: 9620 RVA: 0x000FF91C File Offset: 0x000FDB1C
		Private Function <<EMPTY_NAME>>(A_0 As Short, A_1 As Integer, A_2 As Integer, ByRef A_3 As String) As Integer
			Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
			Dim num As Short = A_0
			While num <= 256S
				Dim num2 As Short
				Dim result As Integer
				If Not OoO0o.o__._00.(num, num2, stringBuilder) Then
					result = -92
				Else
					Dim num3 As Short = CShort(OoO0o.oOo0_O.O0_.(A_1, A_3))
					If num3 <> 0S Then
						result = CInt(num3)
					Else
						Dim num4 As Integer
						num3 = CShort(OoO0o.o00_.0_O.(num4, A_3))
						If num3 <> 0S Then
							result = CInt(num3)
						Else
							If num4 <> A_2 Then
								num += 1S
								Continue While
							End If
							A_3 = stringBuilder.ToString()
							result = 0
						End If
					End If
				End If
				Return result
			End While
			Return -92
		End Function

		' Token: 0x06002595 RID: 9621 RVA: 0x000FF99C File Offset: 0x000FDB9C
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Integer, A_1 As String) As Integer
			If Strings.Len(A_1) < 1 Then
				Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
				Dim num As Short
				If Not OoO0o.o__._00.(0S, num, stringBuilder) Then
					Return -92
				End If
				A_0 = OoO0o.Oo___0.O_o.(stringBuilder.ToString(), -1073741824, 3, 0, 3, 128, 0)
				If A_0 = -1 Then
					Return -92
				End If
			Else
				A_0 = OoO0o.Oo___0.O_o.(A_1, -1073741824, 3, 0, 3, 128, 0)
				If A_0 = -1 Then
					Return -92
				End If
			End If
			Return 0
		End Function

		' Token: 0x06002596 RID: 9622 RVA: 0x000FFA1C File Offset: 0x000FDC1C
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte, ByRef A_1 As Byte, ByRef A_2 As Byte, ByRef A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_4) <> 0 Then
				result = -92
			ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array, 5S) Then
				OoO0o.CloseHandle(a_)
				result = -93
			Else
				OoO0o.CloseHandle(a_)
				A_0 = array(0)
				A_1 = array(1)
				A_2 = array(2)
				A_3 = array(3)
				result = 0
			End If
			Return result
		End Function

		' Token: 0x06002597 RID: 9623 RVA: 0x000FFA78 File Offset: 0x000FDC78
		Private Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Byte, A_2 As Byte, A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_4) <> 0 Then
				result = -92
			Else
				array(1) = 3
				array(2) = A_0
				array(3) = A_1
				array(4) = A_2
				array(5) = A_3
				If Not OoO0o.OO.00_0.(a_, array, 5S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x06002598 RID: 9624 RVA: 0x000FFAD4 File Offset: 0x000FDCD4
		Private Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Byte, A_2 As Byte, A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_4) <> 0 Then
				result = -92
			Else
				array(1) = 4
				array(2) = A_0
				array(3) = A_1
				array(4) = A_2
				array(5) = A_3
				If Not OoO0o.OO.00_0.(a_, array, 5S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x06002599 RID: 9625 RVA: 0x000FFB30 File Offset: 0x000FDD30
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_1) <> 0 Then
				result = -92
			Else
				array(1) = 1
				If Not OoO0o.OO.00_0.(a_, array, 1S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 1S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					A_0 = CShort(array2(0))
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x0600259A RID: 9626 RVA: 0x000FFBA0 File Offset: 0x000FDDA0
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim array As Integer() = New Integer(8) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim array3 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_2) <> 0 Then
				result = -92
			Else
				array2(1) = 2
				If Not OoO0o.OO.00_0.(a_, array2, 1S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array3, 8S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					array(0) = CInt(array3(0))
					array(1) = CInt(array3(1))
					array(2) = CInt(array3(2))
					array(3) = CInt(array3(3))
					array(4) = CInt(array3(4))
					array(5) = CInt(array3(5))
					array(6) = CInt(array3(6))
					array(7) = CInt(array3(7))
					A_0 = (array(3) Or array(2) << 8 Or array(1) << 16 Or array(0) << 24)
					A_1 = (array(7) Or array(6) << 8 Or array(5) << 16 Or array(4) << 24)
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x0600259B RID: 9627 RVA: 0x000FFC80 File Offset: 0x000FDE80
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, ByRef A_3 As Byte(), A_4 As String, A_5 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim result As Integer
			If A_1 > 495S Or A_1 < 0S Then
				result = -81
			ElseIf A_2 > 16S Then
				result = -87
			ElseIf A_2 + A_1 > 495S Then
				result = -88
			Else
				Dim num As Short = CShort((A_1 >> 8)) * 2S
				Dim num2 As Short = A_1 And 255S
				Dim a_ As Integer
				If OoO0o.o0_Ooo_.o_00_.(a_, A_4) <> 0 Then
					result = -92
				Else
					array(1) = 18
					array(2) = CByte(num)
					array(3) = CByte(num2)
					array(4) = CByte(A_2)
					Dim num3 As Short = 0S
					Do
						array(CInt((5S + num3))) = A_3(CInt(num3))
						num3 += 1S
					Loop While num3 <= 7S
					If Not OoO0o.OO.00_0.(a_, array, 13S) Then
						OoO0o.CloseHandle(a_)
						result = -93
					ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, A_2 + 1S) Then
						OoO0o.CloseHandle(a_)
						result = -94
					Else
						OoO0o.CloseHandle(a_)
						If array2(0) <> 0 Then
							result = -83
						Else
							Dim num4 As Short = A_2 - 1S
							num3 = 0S
							While num3 <= num4
								A_0(CInt((num3 + A_5))) = array2(CInt((num3 + 1S)))
								num3 += 1S
							End While
							result = 0
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600259C RID: 9628 RVA: 0x000FFD98 File Offset: 0x000FDF98
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, ByRef A_3 As Byte(), A_4 As String, A_5 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim result As Integer
			If A_2 > 8S Then
				result = -87
			ElseIf A_1 + A_2 - 1S > 512S Or A_1 < 0S Then
				result = -81
			Else
				Dim num As Short = CShort((A_1 >> 8)) * 2S
				Dim num2 As Short = A_1 And 255S
				Dim a_ As Integer
				If OoO0o.o0_Ooo_.o_00_.(a_, A_4) <> 0 Then
					result = -92
				Else
					array(1) = 19
					array(2) = CByte(num)
					array(3) = CByte(num2)
					array(4) = CByte(A_2)
					Dim num3 As Short = 0S
					Do
						array(CInt((5S + num3))) = A_3(CInt(num3))
						num3 += 1S
					Loop While num3 <= 7S
					Dim num4 As Short = A_2 - 1S
					num3 = 0S
					While num3 <= num4
						array(CInt((13S + num3))) = A_0(CInt((num3 + A_5)))
						num3 += 1S
					End While
					If Not OoO0o.OO.00_0.(a_, array, 13S + A_2) Then
						OoO0o.CloseHandle(a_)
						result = -93
					ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 2S) Then
						OoO0o.CloseHandle(a_)
						result = -94
					Else
						OoO0o.CloseHandle(a_)
						If array2(0) <> 0 Then
							result = -82
						Else
							result = 0
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600259D RID: 9629 RVA: 0x000FFEA0 File Offset: 0x000FE0A0
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 8
				Dim num As Short = 2S
				Do
					array(CInt(num)) = A_0(CInt((num - 2S + A_3)))
					num += 1S
				Loop While num <= 9S
				If Not OoO0o.OO.00_0.(a_, array, 9S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 9S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					num = 0S
					Do
						A_1(CInt((num + A_3))) = array2(CInt(num))
						num += 1S
					Loop While num <= 7S
					If array2(8) <> 85 Then
						result = -20
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600259E RID: 9630 RVA: 0x000FFF48 File Offset: 0x000FE148
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Byte, A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(30) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 9
				array(2) = A_1
				Dim num As Short = 0S
				Do
					array(CInt((3S + num))) = A_0(CInt((num + A_3)))
					num += 1S
				Loop While num <= 7S
				If Not OoO0o.OO.00_0.(a_, array, 11S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 2S) Then
					OoO0o.CloseHandle(a_)
					result = -94
				Else
					OoO0o.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600259F RID: 9631 RVA: 0x000FFFDC File Offset: 0x000FE1DC
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Integer, A_1 As String) As Integer
			Dim b As Byte
			Dim b2 As Byte
			Dim b3 As Byte
			Dim b4 As Byte
			Dim result As Integer = OoO0o.o0_o.OOO__0.(b, b2, b3, b4, A_1)
			Dim num As Integer = CInt(b)
			Dim num2 As Integer = CInt(b2)
			Dim num3 As Integer = CInt(b3)
			Dim num4 As Integer = CInt(b4)
			A_0 = (num Or num2 << 8 Or num3 << 16 Or num4 << 24)
			Return result
		End Function

		' Token: 0x060025A0 RID: 9632 RVA: 0x00100018 File Offset: 0x000FE218
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Byte = CByte((A_0 And 255))
			Dim a_2 As Byte = CByte((A_0 >> 8 And 255))
			Dim a_3 As Byte = CByte((A_0 >> 16 And 255))
			Dim a_4 As Byte = CByte((A_0 >> 24 And 255))
			Return OoO0o.o00_.0_O.(a_, a_2, a_3, a_4, A_1)
		End Function

		' Token: 0x060025A1 RID: 9633 RVA: 0x0010005C File Offset: 0x000FE25C
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Byte = CByte((A_0 And 255))
			Dim a_2 As Byte = CByte((A_0 >> 8 And 255))
			Dim a_3 As Byte = CByte((A_0 >> 16 And 255))
			Dim a_4 As Byte = CByte((A_0 >> 24 And 255))
			Return OoO0o.o0O.Oooo_.(a_, a_2, a_3, a_4, A_1)
		End Function

		' Token: 0x060025A2 RID: 9634 RVA: 0x001000A0 File Offset: 0x000FE2A0
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.O0ooo0.OO_0.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025A3 RID: 9635 RVA: 0x001000E0 File Offset: 0x000FE2E0
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.ooO0O.O_oO.(A_0, A_1, A_2)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025A4 RID: 9636 RVA: 0x00100120 File Offset: 0x000FE320
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.o00_.0_O.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025A5 RID: 9637 RVA: 0x00100160 File Offset: 0x000FE360
		Public Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.oOo0_O.O0_.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025A6 RID: 9638 RVA: 0x001001A0 File Offset: 0x000FE3A0
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, A_3 As String, A_4 As String, A_5 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 + A_2 - 1S > 495S Or A_1 < 0S Then
				result = -81
			Else
				OoO0o.o__._00.(A_3, A_4, array)
				Dim num As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
				OoO0o.WaitForSingleObject(num, -1)
				Dim num2 As Short = A_1 Mod 16S
				Dim num3 As Short = 16S - num2
				If num3 > A_2 Then
					num3 = A_2
				End If
				Dim num6 As Integer
				Dim num7 As Integer
				If num3 > 0S Then
					Dim num4 As Short = num3 / 8S - 1S
					Dim num5 As Short
					num5 = 0S
					While num5 <= num4
						num6 = OoO0o.O_O0O_0.OO0_.(A_0, A_1 + num5 * 8S, 8S, array, A_5, 8S * num5)
						If num6 <> 0 Then
							Dim a_ As Integer = num
							Dim a_2 As Integer = 1
							num7 = 0
							OoO0o.ReleaseSemaphore(a_, a_2, num7)
							OoO0o.CloseHandle(num)
							Return num6
						End If
						num5 += 1S
					End While
					If num3 - 8S * num5 > 0S Then
						num6 = OoO0o.O_O0O_0.OO0_.(A_0, A_1 + num5 * 8S, num3 - num5 * 8S, array, A_5, 8S * num5)
						If num6 <> 0 Then
							Dim a_3 As Integer = num
							Dim a_4 As Integer = 1
							num7 = 0
							OoO0o.ReleaseSemaphore(a_3, a_4, num7)
							OoO0o.CloseHandle(num)
							Return num6
						End If
					End If
				End If
				A_2 -= num3
				A_1 += num3
				If A_2 > 0S Then
					Dim num8 As Short = A_2 / 8S - 1S
					Dim num5 As Short
					num5 = 0S
					While num5 <= num8
						num6 = OoO0o.O_O0O_0.OO0_.(A_0, A_1 + num5 * 8S, 8S, array, A_5, num3 + 8S * num5)
						If num6 <> 0 Then
							Dim a_5 As Integer = num
							Dim a_6 As Integer = 1
							num7 = 0
							OoO0o.ReleaseSemaphore(a_5, a_6, num7)
							OoO0o.CloseHandle(num)
							Return num6
						End If
						num5 += 1S
					End While
					If A_2 - 8S * num5 > 0S Then
						num6 = OoO0o.O_O0O_0.OO0_.(A_0, A_1 + num5 * 8S, A_2 - num5 * 8S, array, A_5, num3 + 8S * num5)
						If num6 <> 0 Then
							Dim a_7 As Integer = num
							Dim a_8 As Integer = 1
							num7 = 0
							OoO0o.ReleaseSemaphore(a_7, a_8, num7)
							OoO0o.CloseHandle(num)
							Return num6
						End If
					End If
				End If
				Dim a_9 As Integer = num
				Dim a_10 As Integer = 1
				num7 = 0
				OoO0o.ReleaseSemaphore(a_9, a_10, num7)
				OoO0o.CloseHandle(num)
				result = num6
			End If
			Return result
		End Function

		' Token: 0x060025A7 RID: 9639 RVA: 0x0010036C File Offset: 0x000FE56C
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, A_3 As String, A_4 As String, A_5 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 + A_2 - 1S > 495S Or A_1 < 0S Then
				result = -81
			Else
				OoO0o.o__._00.(A_3, A_4, array)
				Dim num As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
				OoO0o.WaitForSingleObject(num, -1)
				Dim num2 As Short = A_2 / 16S - 1S
				Dim num3 As Short
				Dim num4 As Integer
				Dim num5 As Integer
				num3 = 0S
				While num3 <= num2
					num4 = OoO0o.OOo0o.00000o.(A_0, A_1 + num3 * 16S, 16S, array, A_5, num3 * 16S)
					If num4 <> 0 Then
						Dim a_ As Integer = num
						Dim a_2 As Integer = 1
						num5 = 0
						OoO0o.ReleaseSemaphore(a_, a_2, num5)
						OoO0o.CloseHandle(num)
						Return num4
					End If
					num3 += 1S
				End While
				If A_2 - 16S * num3 > 0S Then
					num4 = OoO0o.OOo0o.00000o.(A_0, A_1 + num3 * 16S, A_2 - 16S * num3, array, A_5, 16S * num3)
					If num4 <> 0 Then
						Dim a_3 As Integer = num
						Dim a_4 As Integer = 1
						num5 = 0
						OoO0o.ReleaseSemaphore(a_3, a_4, num5)
						OoO0o.CloseHandle(num)
						Return num4
					End If
				End If
				Dim a_5 As Integer = num
				Dim a_6 As Integer = 1
				num5 = 0
				OoO0o.ReleaseSemaphore(a_5, a_6, num5)
				OoO0o.CloseHandle(num)
				result = num4
			End If
			Return result
		End Function

		' Token: 0x060025A8 RID: 9640 RVA: 0x0010046C File Offset: 0x000FE66C
		Public Function <<EMPTY_NAME>>(A_0 As Short, A_1 As Integer, A_2 As Integer, ByRef A_3 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.ooO0O.O_oO.(A_0, A_1, A_2, A_3)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025A9 RID: 9641 RVA: 0x001004AC File Offset: 0x000FE6AC
		Public Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.ooO0O.O_oO.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025AA RID: 9642 RVA: 0x001004EC File Offset: 0x000FE6EC
		Public Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.OOo.O___oo_.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025AB RID: 9643 RVA: 0x0010052C File Offset: 0x000FE72C
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			For num As Short = CShort(Strings.Len(A_0))To 7S
				A_0 = "0" + A_0
			Next
			Return A_0
		End Function

		' Token: 0x060025AC RID: 9644 RVA: 0x0010055C File Offset: 0x000FE75C
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, ByRef A_2 As Byte())
			A_0 = OoO0o.Oo___0.O_o.(A_0)
			A_1 = OoO0o.Oo___0.O_o.(A_1)
			Dim num As Short = 0S
			Do
				A_2(CInt(num)) = CByte(OoO0o.O_O.oOO0_.(Strings.Mid(A_0, CInt((1S + num * 2S)), 2)))
				num += 1S
			Loop While num <= 3S
			num = 0S
			Do
				A_2(CInt((num + 4S))) = CByte(OoO0o.O_O.oOO0_.(Strings.Mid(A_1, CInt((1S + num * 2S)), 2)))
				num += 1S
			Loop While num <= 3S
		End Sub

		' Token: 0x060025AD RID: 9645 RVA: 0x001005C0 File Offset: 0x000FE7C0
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Byte, A_1 As Integer, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 > 495 Or A_1 < 0 Then
				result = -81
			Else
				OoO0o.o__._00.(A_2, A_3, array)
				Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
				OoO0o.WaitForSingleObject(a_, -1)
				Dim num As Integer = OoO0o.oo_o_oo._0O.(A_0, CShort(A_1), array, A_4)
				Dim a_2 As Integer = 1
				Dim num2 As Integer = 0
				OoO0o.ReleaseSemaphore(a_, a_2, num2)
				OoO0o.CloseHandle(a_)
				result = num
			End If
			Return result
		End Function

		' Token: 0x060025AE RID: 9646 RVA: 0x0010062C File Offset: 0x000FE82C
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte, A_1 As Short, ByRef A_2 As Byte(), A_3 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim result As Integer
			If A_1 > 495S Or A_1 < 0S Then
				result = -81
			Else
				Dim b As Byte = 128
				If A_1 > 255S Then
					b = 160
					A_1 -= 256S
				End If
				Dim a_ As Integer
				If OoO0o.o0_Ooo_.o_00_.(a_, A_3) <> 0 Then
					result = -92
				Else
					array(1) = 16
					array(2) = b
					array(3) = CByte(A_1)
					array(4) = CByte(A_1)
					Dim num As Short = 0S
					Do
						array(CInt((5S + num))) = A_2(CInt(num))
						num += 1S
					Loop While num <= 7S
					If Not OoO0o.OO.00_0.(a_, array, 13S) Then
						OoO0o.CloseHandle(a_)
						result = -93
					ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 2S) Then
						OoO0o.CloseHandle(a_)
						result = -94
					Else
						OoO0o.CloseHandle(a_)
						If array2(0) <> 83 Then
							result = -83
						Else
							A_0 = array2(1)
							result = 0
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060025AF RID: 9647 RVA: 0x00100708 File Offset: 0x000FE908
		Public Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Integer, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 > 495 Or A_1 < 0 Then
				result = -81
			Else
				OoO0o.o__._00.(A_2, A_3, array)
				Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
				OoO0o.WaitForSingleObject(a_, -1)
				Dim num As Integer = OoO0o.oo_o_oo._0O.(A_0, CShort(A_1), array, A_4)
				Dim a_2 As Integer = 1
				Dim num2 As Integer = 0
				OoO0o.ReleaseSemaphore(a_, a_2, num2)
				OoO0o.CloseHandle(a_)
				result = num
			End If
			Return result
		End Function

		' Token: 0x060025B0 RID: 9648 RVA: 0x00100774 File Offset: 0x000FE974
		Private Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Short, ByRef A_2 As Byte(), A_3 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim result As Integer
			If A_1 > 511S Or A_1 < 0S Then
				result = -81
			Else
				Dim b As Byte = 64
				If A_1 > 255S Then
					b = 96
					A_1 -= 256S
				End If
				Dim a_ As Integer
				If OoO0o.o0_Ooo_.o_00_.(a_, A_3) <> 0 Then
					result = -92
				Else
					array(1) = 17
					array(2) = b
					array(3) = CByte(A_1)
					array(4) = A_0
					Dim num As Short = 0S
					Do
						array(CInt((5S + num))) = A_2(CInt(num))
						num += 1S
					Loop While num <= 7S
					If Not OoO0o.OO.00_0.(a_, array, 13S) Then
						OoO0o.CloseHandle(a_)
						result = -93
					ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 2S) Then
						OoO0o.CloseHandle(a_)
						result = -94
					Else
						OoO0o.CloseHandle(a_)
						If array2(1) <> 1 Then
							result = -82
						Else
							result = 0
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060025B1 RID: 9649 RVA: 0x00100844 File Offset: 0x000FEA44
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			OoO0o.o__._00.(A_0, A_1, array)
			OoO0o.o__._00.(A_2, A_3, array2)
			Dim a_ As Short = 496S
			Dim a_2 As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_2, -1)
			Dim result As Integer = OoO0o.O_O0O_0.OO0_.(array2, a_, 8S, array, A_4, 0S)
			Dim a_3 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_2, a_3, num)
			OoO0o.CloseHandle(a_2)
			Return result
		End Function

		' Token: 0x060025B2 RID: 9650 RVA: 0x001008B4 File Offset: 0x000FEAB4
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			OoO0o.o__._00.(A_0, A_1, array)
			OoO0o.o__._00.(A_2, A_3, array2)
			Dim a_ As Short = 504S
			Dim a_2 As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_2, -1)
			Dim result As Integer = OoO0o.O_O0O_0.OO0_.(array2, a_, 8S, array, A_4, 0S)
			Dim a_3 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_2, a_3, num)
			OoO0o.CloseHandle(a_2)
			Return result
		End Function

		' Token: 0x060025B3 RID: 9651 RVA: 0x00100924 File Offset: 0x000FEB24
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As Short, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 < 0S Then
				result = -81
			Else
				OoO0o.o__._00.(A_2, A_3, array)
				Dim num As Short = CShort(OoO0o.lstrlenA(A_0))
				Dim array2 As Byte() = New Byte(CInt((num + 1S)) - 1) {}
				OoO0o.Oo___0.O_o.(array2(0), A_0, CInt(num))
				If A_1 + num > 495S Then
					result = -47
				Else
					Dim num2 As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
					OoO0o.WaitForSingleObject(num2, -1)
					Dim num3 As Short = A_1 Mod 16S
					Dim num4 As Short = 16S - num3
					If num4 > num Then
						num4 = num
					End If
					Dim num7 As Integer
					Dim num8 As Integer
					If num4 > 0S Then
						Dim num5 As Short = num4 / 8S - 1S
						Dim num6 As Short
						num6 = 0S
						While num6 <= num5
							num7 = OoO0o.O_O0O_0.OO0_.(array2, A_1 + num6 * 8S, 8S, array, A_4, num6 * 8S)
							If num7 <> 0 Then
								Dim a_ As Integer = num2
								Dim a_2 As Integer = 1
								num8 = 0
								OoO0o.ReleaseSemaphore(a_, a_2, num8)
								OoO0o.CloseHandle(num2)
								Return num7
							End If
							num6 += 1S
						End While
						If num4 - 8S * num6 > 0S Then
							num7 = OoO0o.O_O0O_0.OO0_.(array2, A_1 + num6 * 8S, num4 - num6 * 8S, array, A_4, 8S * num6)
							If num7 <> 0 Then
								Dim a_3 As Integer = num2
								Dim a_4 As Integer = 1
								num8 = 0
								OoO0o.ReleaseSemaphore(a_3, a_4, num8)
								OoO0o.CloseHandle(num2)
								Return num7
							End If
						End If
					End If
					num -= num4
					A_1 += num4
					If num > 0S Then
						Dim num9 As Short = num / 8S - 1S
						Dim num6 As Short
						num6 = 0S
						While num6 <= num9
							num7 = OoO0o.O_O0O_0.OO0_.(array2, A_1 + num6 * 8S, 8S, array, A_4, num4 + num6 * 8S)
							If num7 <> 0 Then
								Dim a_5 As Integer = num2
								Dim a_6 As Integer = 1
								num8 = 0
								OoO0o.ReleaseSemaphore(a_5, a_6, num8)
								OoO0o.CloseHandle(num2)
								Return num7
							End If
							num6 += 1S
						End While
						If num - 8S * num6 > 0S Then
							num7 = OoO0o.O_O0O_0.OO0_.(array2, A_1 + num6 * 8S, num - num6 * 8S, array, A_4, num4 + 8S * num6)
							If num7 <> 0 Then
								Dim a_7 As Integer = num2
								Dim a_8 As Integer = 1
								num8 = 0
								OoO0o.ReleaseSemaphore(a_7, a_8, num8)
								OoO0o.CloseHandle(num2)
								Return num7
							End If
						End If
					End If
					Dim a_9 As Integer = num2
					Dim a_10 As Integer = 1
					num8 = 0
					OoO0o.ReleaseSemaphore(a_9, a_10, num8)
					OoO0o.CloseHandle(num2)
					result = num7
				End If
			End If
			Return result
		End Function

		' Token: 0x060025B4 RID: 9652 RVA: 0x00100B20 File Offset: 0x000FED20
		Public Function <<EMPTY_NAME>>(ByRef A_0 As String, A_1 As Short, A_2 As Integer, A_3 As String, A_4 As String, A_5 As String) As Short
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(A_2 + 1 - 1) {}
			OoO0o.o__._00.(A_3, A_4, array)
			Dim result As Short
			If A_1 < 0S Then
				result = -81S
			ElseIf CShort((CInt(A_1) + A_2)) > 495S Then
				result = -47S
			Else
				Dim num As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
				OoO0o.WaitForSingleObject(num, -1)
				Dim num2 As Short = CShort((A_2 / 16 - 1))
				Dim num3 As Short
				Dim num4 As Integer
				Dim num5 As Integer
				num3 = 0S
				While num3 <= num2
					num4 = OoO0o.OOo0o.00000o.(array2, A_1 + num3 * 16S, 16S, array, A_5, num3 * 16S)
					If num4 <> 0 Then
						Dim a_ As Integer = num
						Dim a_2 As Integer = 1
						num5 = 0
						OoO0o.ReleaseSemaphore(a_, a_2, num5)
						OoO0o.CloseHandle(num)
						Return CShort(num4)
					End If
					num3 += 1S
				End While
				If A_2 - CInt((16S * num3)) > 0 Then
					num4 = OoO0o.OOo0o.00000o.(array2, A_1 + num3 * 16S, CShort((A_2 - CInt((16S * num3)))), array, A_5, 16S * num3)
					If num4 <> 0 Then
						Dim a_3 As Integer = num
						Dim a_4 As Integer = 1
						num5 = 0
						OoO0o.ReleaseSemaphore(a_3, a_4, num5)
						OoO0o.CloseHandle(num)
						Return CShort(num4)
					End If
				End If
				Dim a_5 As Integer = num
				Dim a_6 As Integer = 1
				num5 = 0
				OoO0o.ReleaseSemaphore(a_5, a_6, num5)
				OoO0o.CloseHandle(num)
				Dim stringBuilder As StringBuilder = New StringBuilder("", A_2)
				Dim num6 As Short = CShort(A_2)
				num3 = 1S
				While num3 <= num6
					stringBuilder.Append(0)
					num3 += 1S
				End While
				OoO0o.Oo___0.O_o.(stringBuilder, array2(0), A_2)
				A_0 = stringBuilder.ToString()
				result = CShort(num4)
			End If
			Return result
		End Function

		' Token: 0x060025B5 RID: 9653 RVA: 0x00100C7C File Offset: 0x000FEE7C
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Integer
			New Byte(8) {}
			Dim array As Byte()
			OoO0o.o__._00.(A_0, array)
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim num As Integer = OoO0o.ooO0O.O_oO.(array, 0, A_1, 8S)
			If num = 0 Then
				num = OoO0o.ooO0O.O_oO.(array, 1, A_1, 0S)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num2)
			OoO0o.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x060025B6 RID: 9654 RVA: 0x00100CDC File Offset: 0x000FEEDC
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.OoO0.O0_0.(A_0, A_1, A_2, 0S)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025B7 RID: 9655 RVA: 0x00100D1C File Offset: 0x000FEF1C
		Public Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As String, A_2 As String) As Integer
			Dim num As Integer = OoO0o.lstrlenA(A_0) + 1
			Dim a_ As Integer = num
			If num < 8 Then
				num = 8
			Else
				num = num
			End If
			Dim array As Byte() = New Byte(num + 1 - 1) {}
			Dim array2 As Byte() = New Byte(num + 1 - 1) {}
			OoO0o.Oo___0.O_o.(array(0), A_0, a_)
			array.CopyTo(array2, 0)
			Dim num2 As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(num2, -1)
			Dim num3 As Integer = num - 8
			Dim num4 As Integer
			For i As Integer = 0 To num3 Step 8
				num4 = OoO0o.OoO0.O0_0.(array, array2, A_2, CShort(i))
				If num4 <> 0 Then
					Exit For
				End If
			Next
			Dim a_2 As Integer = num2
			Dim a_3 As Integer = 1
			Dim num5 As Integer = 0
			OoO0o.ReleaseSemaphore(a_2, a_3, num5)
			OoO0o.CloseHandle(num2)
			A_1 = ""
			num5 = num - 1
			For i As Integer = 0 To num5
				A_1 += array2(i).ToString("X2")
			Next
			Return num4
		End Function

		' Token: 0x060025B8 RID: 9656 RVA: 0x00100DF8 File Offset: 0x000FEFF8
		Public Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim num As Integer = OoO0o.oOo0_O.O0_.(A_0, A_2)
			If num = 0 Then
				num = OoO0o.o00_.0_O.(A_1, A_2)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num2)
			OoO0o.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x060025B9 RID: 9657 RVA: 0x00100E40 File Offset: 0x000FF040
		Public Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim num As Integer = OoO0o.OOo.O___oo_.(A_0, A_2)
			If num = 0 Then
				num = OoO0o.o00_.0_O.(A_1, A_2)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num2)
			OoO0o.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x060025BA RID: 9658 RVA: 0x00100E88 File Offset: 0x000FF088
		Public Function <<EMPTY_NAME>>(A_0 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.o0_o.OOO__0.(A_0)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025BB RID: 9659 RVA: 0x00100EC4 File Offset: 0x000FF0C4
		Private Function <<EMPTY_NAME>>(A_0 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_0) <> 0 Then
				result = -92
			Else
				array(1) = 32
				If Not OoO0o.OO.00_0.(a_, array, 2S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 2S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060025BC RID: 9660 RVA: 0x00100F38 File Offset: 0x000FF138
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Integer
			New Byte(8) {}
			Dim array As Byte()
			OoO0o.o__._00.(A_0, array)
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim num As Integer = OoO0o.o0_o.OOO__0.(array, 0, A_1, 8S)
			If num = 0 Then
				num = OoO0o.o0_o.OOO__0.(array, 1, A_1, 0S)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num2)
			OoO0o.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x060025BD RID: 9661 RVA: 0x00100F98 File Offset: 0x000FF198
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.o0_o.OOO__0.(A_0, A_1, A_2, 0S)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025BE RID: 9662 RVA: 0x00100FD8 File Offset: 0x000FF1D8
		Public Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As String, A_2 As String) As Integer
			Dim num As Integer = OoO0o.lstrlenA(A_0) + 1
			Dim a_ As Integer = num
			If num < 8 Then
				num = 8
			Else
				num = num
			End If
			Dim array As Byte() = New Byte(num + 1 - 1) {}
			Dim array2 As Byte() = New Byte(num + 1 - 1) {}
			OoO0o.Oo___0.O_o.(array(0), A_0, a_)
			array.CopyTo(array2, 0)
			Dim num2 As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(num2, -1)
			Dim num3 As Integer = num - 8
			Dim num4 As Integer
			For i As Integer = 0 To num3 Step 8
				num4 = OoO0o.o0_o.OOO__0.(array, array2, A_2, CShort(i))
				If num4 <> 0 Then
					Exit For
				End If
			Next
			Dim a_2 As Integer = num2
			Dim a_3 As Integer = 1
			Dim num5 As Integer = 0
			OoO0o.ReleaseSemaphore(a_2, a_3, num5)
			OoO0o.CloseHandle(num2)
			A_1 = ""
			num5 = num - 1
			For i As Integer = 0 To num5
				A_1 += array2(i).ToString("X2")
			Next
			Return num4
		End Function

		' Token: 0x060025BF RID: 9663 RVA: 0x001010B4 File Offset: 0x000FF2B4
		Public Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.o.0_0O.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060025C0 RID: 9664 RVA: 0x001010F4 File Offset: 0x000FF2F4
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 12
				Dim num As Short = 2S
				Do
					array(CInt(num)) = A_0(CInt((num - 2S + A_3)))
					num += 1S
				Loop While num <= 9S
				If Not OoO0o.OO.00_0.(a_, array, 9S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 9S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					num = 0S
					Do
						A_1(CInt((num + A_3))) = array2(CInt(num))
						num += 1S
					Loop While num <= 7S
					If array2(8) <> 85 Then
						result = -20
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060025C1 RID: 9665 RVA: 0x0010119C File Offset: 0x000FF39C
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Byte, A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(30) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 13
				array(2) = A_1
				Dim num As Short = 0S
				Do
					array(CInt((3S + num))) = A_0(CInt((num + A_3)))
					num += 1S
				Loop While num <= 7S
				If Not OoO0o.OO.00_0.(a_, array, 11S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 2S) Then
					OoO0o.CloseHandle(a_)
					result = -94
				Else
					OoO0o.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060025C2 RID: 9666 RVA: 0x00101230 File Offset: 0x000FF430
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_1) <> 0 Then
				result = -92
			Else
				array(1) = 5
				If Not OoO0o.OO.00_0.(a_, array, 1S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 1S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					A_0 = CShort(array2(0))
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x060025C3 RID: 9667 RVA: 0x001012A0 File Offset: 0x000FF4A0
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, ByRef A_3 As Byte(), A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim result As Integer
			Dim a_ As Integer
			If A_2 > 8S Then
				result = -87
			ElseIf OoO0o.o0_Ooo_.o_00_.(a_, A_4) <> 0 Then
				result = -92
			Else
				array(1) = 6
				array(2) = 0
				array(3) = 0
				array(4) = CByte(A_2)
				Dim num As Short = 0S
				Do
					array(CInt((5S + num))) = A_3(CInt(num))
					num += 1S
				Loop While num <= 7S
				Dim num2 As Short = A_2 - 1S
				num = 0S
				While num <= num2
					array(CInt((13S + num))) = A_0(CInt(num))
					num += 1S
				End While
				If Not OoO0o.OO.00_0.(a_, array, 13S + A_2) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 2S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060025C4 RID: 9668 RVA: 0x0010136C File Offset: 0x000FF56C
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			OoO0o.o__._00.(A_0, A_1, array)
			OoO0o.o__._00.(A_2, A_3, array2)
			Dim a_ As Short = 0S
			Dim a_2 As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_2, -1)
			Dim result As Integer = OoO0o.O_O0O_0.OO0_.(array2, a_, 8S, array, A_4)
			Dim a_3 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_2, a_3, num)
			OoO0o.CloseHandle(a_2)
			Return result
		End Function

		' Token: 0x060025C5 RID: 9669 RVA: 0x001013D4 File Offset: 0x000FF5D4
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If OoO0o.o0_Ooo_.o_00_.(a_, A_1) <> 0 Then
				result = -92
			Else
				array(1) = 7
				Dim num As Short = 2S
				Do
					array(CInt(num)) = A_0(CInt((num - 2S)))
					num += 1S
				Loop While num <= 9S
				If Not OoO0o.OO.00_0.(a_, array, 9S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				ElseIf Not OoO0o.oOO.0O_0oO00_o.(a_, array2, 9S) Then
					OoO0o.CloseHandle(a_)
					result = -93
				Else
					OoO0o.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060025C6 RID: 9670 RVA: 0x00101464 File Offset: 0x000FF664
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Integer
			Dim array As Byte()
			OoO0o.o__._00.(A_0, array)
			Dim a_ As Integer = OoO0o.o.0_0O.(0, 1, 1, "ex_sim")
			OoO0o.WaitForSingleObject(a_, -1)
			Dim result As Integer = OoO0o.o0O.Oooo_.(array, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			OoO0o.ReleaseSemaphore(a_, a_2, num)
			OoO0o.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x04000F59 RID: 3929
		Private Const <<EMPTY_NAME>> As Short = 13961S

		' Token: 0x04000F5A RID: 3930
		Private Const <<EMPTY_NAME>> As Short = -30878S

		' Token: 0x04000F5B RID: 3931
		Private Const <<EMPTY_NAME>> As Short = 2S

		' Token: 0x04000F5C RID: 3932
		Private Const <<EMPTY_NAME>> As Short = 16S

		' Token: 0x04000F5D RID: 3933
		Private Const <<EMPTY_NAME>> As Short = -1S

		' Token: 0x04000F5E RID: 3934
		Private Const <<EMPTY_NAME>> As Short = 259S

		' Token: 0x04000F5F RID: 3935
		Private Const <<EMPTY_NAME>> As Integer = -2147483648

		' Token: 0x04000F60 RID: 3936
		Private Const <<EMPTY_NAME>> As Integer = 1073741824

		' Token: 0x04000F61 RID: 3937
		Private Const <<EMPTY_NAME>> As Short = 1S

		' Token: 0x04000F62 RID: 3938
		Private Const <<EMPTY_NAME>> As Short = 2S

		' Token: 0x04000F63 RID: 3939
		Private Const <<EMPTY_NAME>> As Short = 3S

		' Token: 0x04000F64 RID: 3940
		Private Const <<EMPTY_NAME>> As Short = 128S

		' Token: 0x04000F65 RID: 3941
		Private Const <<EMPTY_NAME>> As Short = -1S

		' Token: 0x04000F66 RID: 3942
		Private Const <<EMPTY_NAME>> As Short = 495S

		' Token: 0x04000F67 RID: 3943
		Private Const <<EMPTY_NAME>> As Long = 4294967296L

		' Token: 0x04000F68 RID: 3944
		Private Const <<EMPTY_NAME>> As Long = 2147483647L

		' Token: 0x04000F69 RID: 3945
		Private Const <<EMPTY_NAME>> As Long = 2147483648L

		' Token: 0x04000F6A RID: 3946
		Private Const <<EMPTY_NAME>> As Long = -1640531527L

		' Token: 0x04000F6B RID: 3947
		Private <<EMPTY_NAME>> As Long

		' Token: 0x020002BE RID: 702
		Private Structure O0o_0o_00_Oo
			' Token: 0x04000F6C RID: 3948
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 4)>
			Public Data1 As Byte()

			' Token: 0x04000F6D RID: 3949
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 2)>
			Public Data2 As Byte()

			' Token: 0x04000F6E RID: 3950
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 2)>
			Public Data3 As Byte()

			' Token: 0x04000F6F RID: 3951
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 8)>
			Public Data4 As Byte()
		End Structure

		' Token: 0x020002BF RID: 703
		Private Structure O_0O00__o0O
			' Token: 0x04000F70 RID: 3952
			Public cbSize As Integer

			' Token: 0x04000F71 RID: 3953
			Public InterfaceClassGuid As OoO0o.O0o_0o_00_Oo

			' Token: 0x04000F72 RID: 3954
			Public Flags As Integer

			' Token: 0x04000F73 RID: 3955
			Public Reserved As Integer
		End Structure

		' Token: 0x020002C0 RID: 704
		Private Structure oOO0oOo__ooo
			' Token: 0x04000F74 RID: 3956
			Public cbSize As Integer

			' Token: 0x04000F75 RID: 3957
			Public ClassGuid As OoO0o.O0o_0o_00_Oo

			' Token: 0x04000F76 RID: 3958
			Public DevInst As Integer

			' Token: 0x04000F77 RID: 3959
			Public Reserved As Integer
		End Structure

		' Token: 0x020002C1 RID: 705
		Private Structure O0__0o
			' Token: 0x04000F78 RID: 3960
			Public cbSize As Integer

			' Token: 0x04000F79 RID: 3961
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 255)>
			Public DevicePath As Char()
		End Structure

		' Token: 0x020002C2 RID: 706
		Private Structure o_O000_Oo0oo
			' Token: 0x04000F7A RID: 3962
			Public Size As Integer

			' Token: 0x04000F7B RID: 3963
			Public VendorID As Short

			' Token: 0x04000F7C RID: 3964
			Public ProductID As Short

			' Token: 0x04000F7D RID: 3965
			Public VersionNumber As Short
		End Structure

		' Token: 0x020002C3 RID: 707
		Private Structure o_OO000_0
			' Token: 0x04000F7E RID: 3966
			Public Usage As Short

			' Token: 0x04000F7F RID: 3967
			Public UsagePage As Short

			' Token: 0x04000F80 RID: 3968
			Public InputReportByteLength As Short

			' Token: 0x04000F81 RID: 3969
			Public OutputReportByteLength As Short

			' Token: 0x04000F82 RID: 3970
			Public FeatureReportByteLength As Short

			' Token: 0x04000F83 RID: 3971
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 16)>
			Public Reserved As Short()

			' Token: 0x04000F84 RID: 3972
			Public NumberLinkCollectionNodes As Short

			' Token: 0x04000F85 RID: 3973
			Public NumberInputButtonCaps As Short

			' Token: 0x04000F86 RID: 3974
			Public NumberInputValueCaps As Short

			' Token: 0x04000F87 RID: 3975
			Public NumberInputDataIndices As Short

			' Token: 0x04000F88 RID: 3976
			Public NumberOutputButtonCaps As Short

			' Token: 0x04000F89 RID: 3977
			Public NumberOutputValueCaps As Short

			' Token: 0x04000F8A RID: 3978
			Public NumberOutputDataIndices As Short

			' Token: 0x04000F8B RID: 3979
			Public NumberFeatureButtonCaps As Short

			' Token: 0x04000F8C RID: 3980
			Public NumberFeatureValueCaps As Short

			' Token: 0x04000F8D RID: 3981
			Public NumberFeatureDataIndices As Short
		End Structure
	End Module
End Namespace
