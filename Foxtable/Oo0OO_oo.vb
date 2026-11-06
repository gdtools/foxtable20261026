Imports System
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002B3 RID: 691
	Friend NotInheritable Module Oo0OO_oo
		' Token: 0x060024B0 RID: 9392
		Friend Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (A_0 As Byte(), ByRef A_1 As Integer, A_2 As Integer)

		' Token: 0x060024B1 RID: 9393
		Friend Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (ByRef A_0 As Integer, A_1 As Byte(), A_2 As Integer)

		' Token: 0x060024B2 RID: 9394
		Private Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (A_0 As Byte(), A_1 As Byte(), A_2 As Integer)

		' Token: 0x060024B3 RID: 9395
		Private Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (A_0 As Byte(), A_1 As String, A_2 As Integer)

		' Token: 0x060024B4 RID: 9396
		Private Declare Ansi Sub <<EMPTY_NAME>> Lib "kernel32.dll" Alias "RtlMoveMemory" (A_0 As StringBuilder, A_1 As Byte(), A_2 As Integer)

		' Token: 0x060024B5 RID: 9397
		Private Declare Ansi Function HidD_GetAttributes Lib "HID.dll" (A_0 As Integer, ByRef A_1 As Oo0OO_oo.OOo) As Boolean

		' Token: 0x060024B6 RID: 9398
		Private Declare Ansi Function HidD_GetHidGuid Lib "HID.dll" (ByRef A_0 As Oo0OO_oo.o00oO_o) As Integer

		' Token: 0x060024B7 RID: 9399
		Private Declare Ansi Function HidD_GetPreparsedData Lib "HID.dll" (A_0 As Integer, ByRef A_1 As Integer) As Boolean

		' Token: 0x060024B8 RID: 9400
		Private Declare Ansi Function HidP_GetCaps Lib "HID.dll" (A_0 As Integer, ByRef A_1 As Oo0OO_oo.OoOo) As Integer

		' Token: 0x060024B9 RID: 9401
		Private Declare Ansi Function HidD_FreePreparsedData Lib "HID.dll" (A_0 As Integer) As Boolean

		' Token: 0x060024BA RID: 9402
		Private Declare Ansi Function HidD_SetFeature Lib "HID.dll" (A_0 As Integer, A_1 As Byte(), A_2 As Integer) As Boolean

		' Token: 0x060024BB RID: 9403
		Private Declare Ansi Function HidD_GetFeature Lib "HID.dll" (A_0 As Integer, A_1 As Byte(), A_2 As Integer) As Boolean

		' Token: 0x060024BC RID: 9404
		Private Declare Ansi Function SetupDiGetClassDevsA Lib "SetupApi.dll" (ByRef A_0 As Oo0OO_oo.o00oO_o, A_1 As Integer, A_2 As Integer, A_3 As Integer) As Integer

		' Token: 0x060024BD RID: 9405
		Private Declare Ansi Function SetupDiDestroyDeviceInfoList Lib "SetupApi.dll" (A_0 As Integer) As Boolean

		' Token: 0x060024BE RID: 9406
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "SetupApi.dll" Alias "SetupDiGetDeviceInterfaceDetailA" (A_0 As Integer, ByRef A_1 As Oo0OO_oo.O_OO0__0___Oo, ByRef A_2 As Oo0OO_oo.O_0O, A_3 As Integer, ByRef A_4 As Integer, A_5 As Integer) As Boolean

		' Token: 0x060024BF RID: 9407
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "SetupApi.dll" Alias "SetupDiEnumDeviceInterfaces" (A_0 As Integer, A_1 As Integer, ByRef A_2 As Oo0OO_oo.o00oO_o, A_3 As Integer, ByRef A_4 As Oo0OO_oo.O_OO0__0___Oo) As Boolean

		' Token: 0x060024C0 RID: 9408
		Private Declare Ansi Function SetupDiGetDeviceInterfaceDetailA Lib "SetupApi.dll" (A_0 As Integer, ByRef A_1 As Oo0OO_oo.O000_O0o__o, ByRef A_2 As Oo0OO_oo.O_0O, A_3 As Integer, ByRef A_4 As Integer, A_5 As Integer) As Boolean

		' Token: 0x060024C1 RID: 9409
		Private Declare Ansi Function SetupDiEnumDeviceInterfaces Lib "SetupApi.dll" (A_0 As Integer, A_1 As Integer, ByRef A_2 As Oo0OO_oo.o00oO_o, A_3 As Integer, ByRef A_4 As Oo0OO_oo.O000_O0o__o) As Boolean

		' Token: 0x060024C2 RID: 9410
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "CreateFileA" (A_0 As String, A_1 As Integer, A_2 As Integer, A_3 As Integer, A_4 As Integer, A_5 As Integer, A_6 As Integer) As Integer

		' Token: 0x060024C3 RID: 9411
		Private Declare Ansi Function CloseHandle Lib "kernel32.dll" (A_0 As Integer) As Integer

		' Token: 0x060024C4 RID: 9412
		Private Declare Ansi Function GetLastError Lib "kernel32.dll" () As Integer

		' Token: 0x060024C5 RID: 9413
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "lstrcpyA" (A_0 As String, ByRef A_1 As Byte) As Integer

		' Token: 0x060024C6 RID: 9414
		Private Declare Ansi Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "CreateSemaphoreA" (A_0 As Integer, A_1 As Integer, A_2 As Integer, A_3 As String) As Integer

		' Token: 0x060024C7 RID: 9415
		Private Declare Ansi Function WaitForSingleObject Lib "kernel32.dll" (A_0 As Integer, A_1 As Integer) As Integer

		' Token: 0x060024C8 RID: 9416
		Private Declare Ansi Function ReleaseSemaphore Lib "kernel32.dll" (A_0 As Integer, A_1 As Integer, ByRef A_2 As Integer) As Integer

		' Token: 0x060024C9 RID: 9417
		Friend Declare Ansi Function lstrlenA Lib "kernel32.dll" (A_0 As String) As Integer

		' Token: 0x060024CA RID: 9418 RVA: 0x000FAE30 File Offset: 0x000F9030
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

		' Token: 0x060024CB RID: 9419 RVA: 0x000FAEAC File Offset: 0x000F90AC
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

		' Token: 0x060024CC RID: 9420 RVA: 0x000FAF58 File Offset: 0x000F9158
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

		' Token: 0x060024CD RID: 9421 RVA: 0x000FB034 File Offset: 0x000F9234
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

		' Token: 0x060024CE RID: 9422 RVA: 0x000FB08C File Offset: 0x000F928C
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

		' Token: 0x060024CF RID: 9423 RVA: 0x000FB0DC File Offset: 0x000F92DC
		Private Function <<EMPTY_NAME>>(A_0 As Byte) As Byte
			Dim b As Byte = CByte((Oo0OO_oo.O_O_0_.oo_0O. And 1L))
			Dim b2 As Byte = (A_0 And 128) / 128
			Dim result As Byte = (A_0 And 127) * 2 Or b
			Oo0OO_oo.O_O_0_.oo_0O. = CLng(CULng(b2))
			Return result
		End Function

		' Token: 0x060024D0 RID: 9424 RVA: 0x000FB118 File Offset: 0x000F9318
		Private Function <<EMPTY_NAME>>(A_0 As Byte) As Byte
			Dim b As Byte = CByte((Oo0OO_oo.O_O_0_.oo_0O. And 128L))
			Dim b2 As Byte = (A_0 And 1) * 128
			Dim result As Byte = A_0 / 2 Or b
			Oo0OO_oo.O_O_0_.oo_0O. = CLng(CULng(b2))
			Return result
		End Function

		' Token: 0x060024D1 RID: 9425 RVA: 0x000FB150 File Offset: 0x000F9350
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Integer
			Dim result As Integer = A_0
			Dim array As Byte() = New Byte(3) {}
			Oo0OO_oo.O.OOO0_0.(array, result, 4)
			For i As Integer = 1 To A_1
				Oo0OO_oo.O_O_0_.oo_0O. = 0L
				Oo0OO_oo.OO_o_0.0__0.(array(3))
				Dim num As Integer = 0
				Do
					array(num) = Oo0OO_oo.OO_o_0.0__0.(array(num))
					num += 1
				Loop While num <= 3
			Next
			Oo0OO_oo.O.OOO0_0.(result, array, 4)
			Return result
		End Function

		' Token: 0x060024D2 RID: 9426 RVA: 0x000FB1B8 File Offset: 0x000F93B8
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Integer
			Dim result As Integer = A_0
			Dim array As Byte() = New Byte(3) {}
			Oo0OO_oo.O.OOO0_0.(array, result, 4)
			For i As Integer = 1 To A_1
				Oo0OO_oo.O_O_0_.oo_0O. = 0L
				Oo0OO_oo.Oo__._0Oo.(array(0))
				Dim num As Integer = 3
				Do
					array(num) = Oo0OO_oo.Oo__._0Oo.(array(num))
					num += -1
				Loop While num >= 0
			Next
			Oo0OO_oo.O.OOO0_0.(result, array, 4)
			Return result
		End Function

		' Token: 0x060024D3 RID: 9427 RVA: 0x000FB220 File Offset: 0x000F9420
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
				Dim num4 As Long = Oo0OO_oo.O0o_OO._0__OOo.(num4, -1640531527L)
				Dim num5 As Long = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num2, 4), a_)
				Dim num6 As Long = Oo0OO_oo.O0o_OO._0__OOo.(num2, num4)
				Dim num7 As Long = Oo0OO_oo.Oo__._0Oo.(num2, 5)
				num7 = Oo0OO_oo.O0o_OO._0__OOo.(num7, a_2)
				Dim num8 As Long = num5 Xor num6
				num8 = num8 Xor num7
				num = Oo0OO_oo.O0o_OO._0__OOo.(num, num8)
				Dim num9 As Long = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num, 4), a_3)
				num6 = Oo0OO_oo.O0o_OO._0__OOo.(num, num4)
				num7 = Oo0OO_oo.Oo__._0Oo.(num, 5)
				num7 = Oo0OO_oo.O0o_OO._0__OOo.(num7, a_4)
				num8 = (num9 Xor num6 Xor num7)
				num2 = Oo0OO_oo.O0o_OO._0__OOo.(num2, num8)
			Next
			A_0(0) = num
			A_0(1) = num2
		End Sub

		' Token: 0x060024D4 RID: 9428 RVA: 0x000FB2FC File Offset: 0x000F94FC
		Private Sub <<EMPTY_NAME>>(A_0 As Long(), A_1 As Long())
			New Long(1) {}
			Dim num As Long = A_0(0)
			Dim num2 As Long = A_0(1)
			Dim a_ As Long = A_1(0)
			Dim a_2 As Long = A_1(1)
			Dim a_3 As Long = A_1(2)
			Dim a_4 As Long = A_1(3)
			Dim num3 As Integer = 32
			Dim num4 As Long = Oo0OO_oo.o00.00_0_OOOOo.(-1640531527L, 5)
			Dim num5 As Integer = num3
			For i As Integer = 1 To num5
				Dim num6 As Long = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num, 4), a_3)
				Dim num7 As Long = Oo0OO_oo.O0o_OO._0__OOo.(num, num4)
				Dim num8 As Long = Oo0OO_oo.Oo__._0Oo.(num, 5)
				num8 = Oo0OO_oo.O0o_OO._0__OOo.(num8, a_4)
				Dim a_5 As Long = num6 Xor num7 Xor num8
				num2 = Oo0OO_oo.O0Oo0o.O.(num2, a_5)
				Dim num9 As Long = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num2, 4), a_)
				num7 = Oo0OO_oo.O0o_OO._0__OOo.(num2, num4)
				num8 = Oo0OO_oo.Oo__._0Oo.(num2, 5)
				num8 = Oo0OO_oo.O0o_OO._0__OOo.(num8, a_2)
				a_5 = (num9 Xor num7 Xor num8)
				num = Oo0OO_oo.O0Oo0o.O.(num, a_5)
				num4 = Oo0OO_oo.O0Oo0o.O.(num4, -1640531527L)
			Next
			A_0(0) = num
			A_0(1) = num2
		End Sub

		' Token: 0x060024D5 RID: 9429 RVA: 0x000FB3E4 File Offset: 0x000F95E4
		Private Sub <<EMPTY_NAME>>(A_0 As Long(), A_1 As Byte())
			A_0(0) = 0L
			A_0(1) = 0L
			Dim num As Integer = 0
			Do
				A_0(0) = (CLng(Oo0OO_oo.O0_Oo0._oO.(CInt(A_1(num)), num * 8)) Or A_0(0))
				A_0(1) = (CLng(Oo0OO_oo.O0_Oo0._oO.(CInt(A_1(num + 4)), num * 8)) Or A_0(1))
				num += 1
			Loop While num <= 3
		End Sub

		' Token: 0x060024D6 RID: 9430 RVA: 0x000FB430 File Offset: 0x000F9630
		Private Sub <<EMPTY_NAME>>(A_0 As Long(), A_1 As Byte())
			Dim num As Integer = 0
			Do
				A_1(num) = CByte((Oo0OO_oo.o.O_O00o0o_.(CInt(A_0(0)), num * 8) And 255))
				A_1(num + 4) = CByte((Oo0OO_oo.o.O_O00o0o_.(CInt(A_0(1)), num * 8) And 255))
				num += 1
			Loop While num <= 3
		End Sub

		' Token: 0x060024D7 RID: 9431 RVA: 0x000FB478 File Offset: 0x000F9678
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Long())
			Dim array As Long() = New Long(16) {}
			Dim num As Integer = Strings.Len(A_0)
			Dim num2 As Integer = 0
			Dim num3 As Integer = num
			Dim i As Integer
			i = 1
			While i <= num3
				Dim a_ As String = Strings.Mid(A_0, i, 2)
				array(num2) = CLng(Oo0OO_oo.Ooo_o_o._0o0.(a_))
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
				A_1(0) = (CLng(Oo0OO_oo.O0_Oo0._oO.(CInt(array(i)), i * 8)) Or A_1(0))
				A_1(1) = (CLng(Oo0OO_oo.O0_Oo0._oO.(CInt(array(i + 4)), i * 8)) Or A_1(1))
				A_1(2) = (CLng(Oo0OO_oo.O0_Oo0._oO.(CInt(array(i + 4 + 4)), i * 8)) Or A_1(2))
				A_1(3) = (CLng(Oo0OO_oo.O0_Oo0._oO.(CInt(array(i + 4 + 4 + 4)), i * 8)) Or A_1(3))
				i += 1
			Loop While i <= 3
		End Sub

		' Token: 0x060024D8 RID: 9432 RVA: 0x000FB530 File Offset: 0x000F9730
		Friend Sub <<EMPTY_NAME>>(A_0 As Byte(), A_1 As Byte(), A_2 As String)
			New Byte(16) {}
			Dim a_ As Long() = New Long(2) {}
			Dim a_2 As Long() = New Long(4) {}
			Oo0OO_oo.o0___0O._0.(A_2, a_2)
			Oo0OO_oo.O0o_OO._0__OOo.(a_, A_0)
			Oo0OO_oo.O00.00o0.(a_, a_2)
			Oo0OO_oo.O0ooo__oOO.o_0.(a_, A_1)
		End Sub

		' Token: 0x060024D9 RID: 9433 RVA: 0x000FB570 File Offset: 0x000F9770
		Friend Sub <<EMPTY_NAME>>(A_0 As Byte(), A_1 As Byte(), A_2 As String)
			New Byte(16) {}
			Dim a_ As Long() = New Long(2) {}
			Dim a_2 As Long() = New Long(4) {}
			Oo0OO_oo.o0___0O._0.(A_2, a_2)
			Oo0OO_oo.O0o_OO._0__OOo.(a_, A_0)
			Oo0OO_oo.O0Oo0o.O.(a_, a_2)
			Oo0OO_oo.O0ooo__oOO.o_0.(a_, A_1)
		End Sub

		' Token: 0x060024DA RID: 9434 RVA: 0x000FB5B0 File Offset: 0x000F97B0
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			Dim num As Integer = Oo0OO_oo.lstrlenA(A_0) + 1
			Dim num2 As Integer
			If num < 8 Then
				num2 = 8
			Else
				num2 = num
			End If
			Dim array3 As Byte() = New Byte(num2 + 1 - 1) {}
			Dim array4 As Byte() = New Byte(num2 + 1 - 1) {}
			Oo0OO_oo.O.OOO0_0.(array3, A_0, num)
			array3.CopyTo(array4, 0)
			Dim num3 As Integer = num2 - 8
			For i As Integer = 0 To num3 Step 8
				Dim num4 As Integer = 0
				Do
					array(num4) = array3(num4 + i)
					num4 += 1
				Loop While num4 <= 7
				Oo0OO_oo.OO.OO0oO0__.(array, array2, A_1)
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

		' Token: 0x060024DB RID: 9435 RVA: 0x000FB69C File Offset: 0x000F989C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
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
				array3(num2) = CByte(Oo0OO_oo.Ooo_o_o._0o0.(a_))
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
				Oo0OO_oo.o_o0oO000.0_.(array, array2, A_1)
				num2 = 0
				Do
					array4(num2 + i) = array2(num2)
					num2 += 1
				Loop While num2 <= 7
			Next
			Dim stringBuilder As StringBuilder = New StringBuilder("", num)
			Oo0OO_oo.O.OOO0_0.(stringBuilder, array4, num)
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060024DC RID: 9436 RVA: 0x000FB798 File Offset: 0x000F9998
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
				A_1(num3) = CByte(Oo0OO_oo.Ooo_o_o._0o0.(a_))
				num3 += 1
			Next
			Return num2
		End Function

		' Token: 0x060024DD RID: 9437 RVA: 0x000FB7FC File Offset: 0x000F99FC
		Private Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Byte(), A_2 As Short) As Boolean
			Dim array As Byte() = New Byte(512) {}
			Dim a_ As Integer
			Dim result As Boolean
			If Oo0OO_oo.HidD_GetPreparsedData(A_0, a_) Then
				Dim ooOo As Oo0OO_oo.OoOo
				If Oo0OO_oo.HidP_GetCaps(a_, ooOo) = 0 Then
					Oo0OO_oo.HidD_FreePreparsedData(a_)
				Else
					Dim flag As Boolean = True
					array(0) = 1
					Dim flag2 As Boolean = Oo0OO_oo.HidD_GetFeature(A_0, array, CInt(ooOo.OO__.0.))
					If flag2 Then
						Dim num As Short = A_2 - 1S
						For num2 As Short = 0S To num
							A_1(CInt(num2)) = array(CInt(num2))
						Next
					End If
					flag = (flag AndAlso flag2)
					Oo0OO_oo.HidD_FreePreparsedData(a_)
					result = flag
				End If
			End If
			Return result
		End Function

		' Token: 0x060024DE RID: 9438 RVA: 0x000FB87C File Offset: 0x000F9A7C
		Private Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Byte(), A_2 As Short) As Boolean
			Dim array As Byte() = New Byte(512) {}
			Dim a_ As Integer
			Dim result As Boolean
			If Oo0OO_oo.HidD_GetPreparsedData(A_0, a_) Then
				Dim ooOo As Oo0OO_oo.OoOo
				If Oo0OO_oo.HidP_GetCaps(a_, ooOo) = 0 Then
					Oo0OO_oo.HidD_FreePreparsedData(a_)
				Else
					Dim flag As Boolean = True
					array(0) = 2
					Dim num As Short = A_2 - 1S
					For num2 As Short = 0S To num
						array(CInt((num2 + 1S))) = A_1(CInt((num2 + 1S)))
					Next
					Dim flag2 As Boolean = Oo0OO_oo.HidD_SetFeature(A_0, array, CInt(ooOo.OO__.0.))
					flag = (flag AndAlso flag2)
					Oo0OO_oo.HidD_FreePreparsedData(a_)
					result = flag
				End If
			End If
			Return result
		End Function

		' Token: 0x060024DF RID: 9439 RVA: 0x000FB8FC File Offset: 0x000F9AFC
		Private Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As Short, ByRef A_2 As StringBuilder) As Boolean
			Dim result As Boolean
			If IntPtr.Size = 4 Then
				result = Oo0OO_oo.o00.00_0_OOOOo.(A_0, A_1, A_2)
			Else
				result = Oo0OO_oo.o0___0O._0.(A_0, A_1, A_2)
			End If
			Return result
		End Function

		' Token: 0x060024E0 RID: 9440 RVA: 0x000FB928 File Offset: 0x000F9B28
		Private Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As Short, ByRef A_2 As StringBuilder) As Boolean
			Dim o00oO_o As Oo0OO_oo.o00oO_o
			Oo0OO_oo.HidD_GetHidGuid(o00oO_o)
			Dim num As Integer = Oo0OO_oo.SetupDiGetClassDevsA(o00oO_o, 0, 0, 18)
			Dim result As Boolean
			If num <> -1 Then
				Dim o000_O0o__o As Oo0OO_oo.O000_O0o__o
				o000_O0o__o.o00o.0. = Strings.Len(o000_O0o__o)
				Dim num2 As Integer
				While Oo0OO_oo.SetupDiEnumDeviceInterfaces(num, 0, o00oO_o, num2, o000_O0o__o) AndAlso Oo0OO_oo.GetLastError() <> 259
					Dim o_0O As Oo0OO_oo.O_0O
					o_0O.o00o.0. = 5
					Dim num3 As Integer
					If Not Oo0OO_oo.SetupDiGetDeviceInterfaceDetailA(num, o000_O0o__o, o_0O, 300, num3, 0) Then
						Oo0OO_oo.SetupDiDestroyDeviceInfoList(num)
						Return result
					End If
					A_2 = New StringBuilder(New String(o_0O.o00o.0.), 260)
					Dim num4 As Integer = Oo0OO_oo.o_o0oO000.0_.(A_2.ToString(), 0, 3, 0, 3, 0, 0)
					If -1 <> num4 Then
						Dim ooo As Oo0OO_oo.OOo
						If Oo0OO_oo.HidD_GetAttributes(num4, ooo) AndAlso (ooo.ooO_O._Ooo. = 13961S And ooo.o_o__.0. = 13961S) Then
							If A_0 = A_1 Then
								Oo0OO_oo.SetupDiDestroyDeviceInfoList(num)
								Oo0OO_oo.CloseHandle(num4)
								Return True
							End If
							A_1 += 1S
						End If
						Oo0OO_oo.CloseHandle(num4)
					End If
					num2 += 1
				End While
				Oo0OO_oo.SetupDiDestroyDeviceInfoList(num)
			End If
			Return result
		End Function

		' Token: 0x060024E1 RID: 9441 RVA: 0x000FBA40 File Offset: 0x000F9C40
		Private Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As Short, ByRef A_2 As StringBuilder) As Boolean
			Dim o00oO_o As Oo0OO_oo.o00oO_o
			Oo0OO_oo.HidD_GetHidGuid(o00oO_o)
			Dim num As Integer = Oo0OO_oo.SetupDiGetClassDevsA(o00oO_o, 0, 0, 18)
			Dim result As Boolean
			If num <> -1 Then
				Dim o_OO0__0___Oo As Oo0OO_oo.O_OO0__0___Oo
				o_OO0__0___Oo.O_0o00_._o. = CLng(Strings.Len(o_OO0__0___Oo))
				Dim num2 As Integer
				While Oo0OO_oo.O0Oo0o.O.(num, 0, o00oO_o, num2, o_OO0__0___Oo) AndAlso Oo0OO_oo.GetLastError() <> 259
					Dim o_0O As Oo0OO_oo.O_0O
					o_0O.o00o.0. = 8
					Dim num3 As Integer
					If Not Oo0OO_oo.O0Oo0o.O.(num, o_OO0__0___Oo, o_0O, 300, num3, 0) Then
						Oo0OO_oo.SetupDiDestroyDeviceInfoList(num)
						Return result
					End If
					A_2 = New StringBuilder(New String(o_0O.o00o.0.), 260)
					Dim num4 As Integer = Oo0OO_oo.o_o0oO000.0_.(A_2.ToString(), 0, 3, 0, 3, 0, 0)
					If -1 <> num4 Then
						Dim ooo As Oo0OO_oo.OOo
						If Oo0OO_oo.HidD_GetAttributes(num4, ooo) AndAlso (ooo.ooO_O._Ooo. = 13961S And ooo.o_o__.0. = 13961S) Then
							If A_0 = A_1 Then
								Oo0OO_oo.SetupDiDestroyDeviceInfoList(num)
								Oo0OO_oo.CloseHandle(num4)
								Return True
							End If
							A_1 += 1S
						End If
						Oo0OO_oo.CloseHandle(num4)
					End If
					num2 += 1
				End While
				Oo0OO_oo.SetupDiDestroyDeviceInfoList(num)
			End If
			Return result
		End Function

		' Token: 0x060024E2 RID: 9442 RVA: 0x000FBB58 File Offset: 0x000F9D58
		Private Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As String) As Integer
			Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
			Dim num As Short
			Dim result As Integer
			If Not Oo0OO_oo.Ooo_o_o._0o0.(A_0, num, stringBuilder) Then
				result = -92
			Else
				A_1 = stringBuilder.ToString()
				result = 0
			End If
			Return result
		End Function

		' Token: 0x060024E3 RID: 9443 RVA: 0x000FBB94 File Offset: 0x000F9D94
		Private Function <<EMPTY_NAME>>(A_0 As Short, A_1 As Integer, A_2 As Integer, ByRef A_3 As String) As Integer
			Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
			Dim num As Short = A_0
			While num <= 256S
				Dim num2 As Short
				Dim result As Integer
				If Not Oo0OO_oo.Ooo_o_o._0o0.(num, num2, stringBuilder) Then
					result = -92
				Else
					Dim num3 As Short = CShort(Oo0OO_oo.O_O_O0oO.o_Oo.(A_1, A_3))
					If num3 <> 0S Then
						result = CInt(num3)
					Else
						Dim num4 As Integer
						num3 = CShort(Oo0OO_oo.OO_o_0.0__0.(num4, A_3))
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

		' Token: 0x060024E4 RID: 9444 RVA: 0x000FBC14 File Offset: 0x000F9E14
		Private Function <<EMPTY_NAME>>(A_0 As Short, A_1 As Integer, A_2 As Integer, ByRef A_3 As String) As Integer
			Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
			Dim num As Short = A_0
			While num <= 256S
				Dim num2 As Short
				Dim result As Integer
				If Not Oo0OO_oo.Ooo_o_o._0o0.(num, num2, stringBuilder) Then
					result = -92
				Else
					Dim num3 As Short = CShort(Oo0OO_oo.o_OOoo.O_0o_O.(A_1, A_3))
					If num3 <> 0S Then
						result = CInt(num3)
					Else
						Dim num4 As Integer
						num3 = CShort(Oo0OO_oo.OO_o_0.0__0.(num4, A_3))
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

		' Token: 0x060024E5 RID: 9445 RVA: 0x000FBC94 File Offset: 0x000F9E94
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Integer, A_1 As String) As Integer
			If Strings.Len(A_1) < 1 Then
				Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
				Dim num As Short
				If Not Oo0OO_oo.Ooo_o_o._0o0.(0S, num, stringBuilder) Then
					Return -92
				End If
				A_0 = Oo0OO_oo.o_o0oO000.0_.(stringBuilder.ToString(), -1073741824, 3, 0, 3, 128, 0)
				If A_0 = -1 Then
					Return -92
				End If
			Else
				A_0 = Oo0OO_oo.o_o0oO000.0_.(A_1, -1073741824, 3, 0, 3, 128, 0)
				If A_0 = -1 Then
					Return -92
				End If
			End If
			Return 0
		End Function

		' Token: 0x060024E6 RID: 9446 RVA: 0x000FBD14 File Offset: 0x000F9F14
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte, ByRef A_1 As Byte, ByRef A_2 As Byte, ByRef A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_4) <> 0 Then
				result = -92
			ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array, 5S) Then
				Oo0OO_oo.CloseHandle(a_)
				result = -93
			Else
				Oo0OO_oo.CloseHandle(a_)
				A_0 = array(0)
				A_1 = array(1)
				A_2 = array(2)
				A_3 = array(3)
				result = 0
			End If
			Return result
		End Function

		' Token: 0x060024E7 RID: 9447 RVA: 0x000FBD70 File Offset: 0x000F9F70
		Private Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Byte, A_2 As Byte, A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_4) <> 0 Then
				result = -92
			Else
				array(1) = 3
				array(2) = A_0
				array(3) = A_1
				array(4) = A_2
				array(5) = A_3
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 5S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x060024E8 RID: 9448 RVA: 0x000FBDCC File Offset: 0x000F9FCC
		Private Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Byte, A_2 As Byte, A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_4) <> 0 Then
				result = -92
			Else
				array(1) = 4
				array(2) = A_0
				array(3) = A_1
				array(4) = A_2
				array(5) = A_3
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 5S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x060024E9 RID: 9449 RVA: 0x000FBE28 File Offset: 0x000FA028
		Private Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Byte, A_2 As Byte, A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_4) <> 0 Then
				result = -92
			Else
				array(1) = 10
				array(2) = A_0
				array(3) = A_1
				array(4) = A_2
				array(5) = A_3
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 5S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x060024EA RID: 9450 RVA: 0x000FBE84 File Offset: 0x000FA084
		Private Function <<EMPTY_NAME>>(A_0 As Byte, A_1 As Byte, A_2 As Byte, A_3 As Byte, A_4 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_4) <> 0 Then
				result = -92
			Else
				array(1) = 11
				array(2) = A_0
				array(3) = A_1
				array(4) = A_2
				array(5) = A_3
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 5S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x060024EB RID: 9451 RVA: 0x000FBEE0 File Offset: 0x000FA0E0
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_1) <> 0 Then
				result = -92
			Else
				array(1) = 1
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 1S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 1S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
					A_0 = CShort(array2(0))
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x060024EC RID: 9452 RVA: 0x000FBF50 File Offset: 0x000FA150
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_1) <> 0 Then
				result = -92
			Else
				array(1) = 5
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 1S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 1S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
					A_0 = CShort(array2(0))
					result = 0
				End If
			End If
			Return result
		End Function

		' Token: 0x060024ED RID: 9453 RVA: 0x000FBFC0 File Offset: 0x000FA1C0
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim array As Integer() = New Integer(8) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim array3 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_2) <> 0 Then
				result = -92
			Else
				array2(1) = 2
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array2, 1S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array3, 8S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
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

		' Token: 0x060024EE RID: 9454 RVA: 0x000FC0A0 File Offset: 0x000FA2A0
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, ByRef A_3 As Byte(), A_4 As String, A_5 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim result As Integer
			If A_1 > 2031S Or A_1 < 0S Then
				result = -81
			ElseIf A_2 > 16S Then
				result = -87
			ElseIf A_2 + A_1 > 2031S Then
				result = -88
			Else
				Dim num As Short = CShort((A_1 >> 8)) * 2S
				Dim num2 As Short = A_1 And 255S
				Dim a_ As Integer
				If Oo0OO_oo.oo000oOOooo.oO.(a_, A_4) <> 0 Then
					result = -92
				Else
					array(1) = 16
					array(2) = CByte(num)
					array(3) = CByte(num2)
					array(4) = CByte(A_2)
					Dim num3 As Short = 0S
					Do
						array(CInt((5S + num3))) = A_3(CInt(num3))
						num3 += 1S
					Loop While num3 <= 7S
					If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 13S) Then
						Oo0OO_oo.CloseHandle(a_)
						result = -93
					ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, A_2 + 1S) Then
						Oo0OO_oo.CloseHandle(a_)
						result = -94
					Else
						Oo0OO_oo.CloseHandle(a_)
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

		' Token: 0x060024EF RID: 9455 RVA: 0x000FC1B8 File Offset: 0x000FA3B8
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, ByRef A_3 As Byte(), A_4 As String, A_5 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim result As Integer
			If A_2 > 8S Then
				result = -87
			ElseIf A_1 + A_2 - 1S > 2048S Or A_1 < 0S Then
				result = -81
			Else
				Dim num As Short = CShort((A_1 >> 8)) * 2S
				Dim num2 As Short = A_1 And 255S
				Dim a_ As Integer
				If Oo0OO_oo.oo000oOOooo.oO.(a_, A_4) <> 0 Then
					result = -92
				Else
					array(1) = 17
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
					If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 13S + A_2) Then
						Oo0OO_oo.CloseHandle(a_)
						result = -93
					ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 2S) Then
						Oo0OO_oo.CloseHandle(a_)
						result = -94
					Else
						Oo0OO_oo.CloseHandle(a_)
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

		' Token: 0x060024F0 RID: 9456 RVA: 0x000FC2C0 File Offset: 0x000FA4C0
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 8
				Dim num As Short = 2S
				Do
					array(CInt(num)) = A_0(CInt((num - 2S + A_3)))
					num += 1S
				Loop While num <= 9S
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 9S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 9S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
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

		' Token: 0x060024F1 RID: 9457 RVA: 0x000FC368 File Offset: 0x000FA568
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Byte, A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(30) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 9
				array(2) = A_1
				Dim num As Short = 0S
				Do
					array(CInt((3S + num))) = A_0(CInt((num + A_3)))
					num += 1S
				Loop While num <= 7S
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 11S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 2S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -94
				Else
					Oo0OO_oo.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060024F2 RID: 9458 RVA: 0x000FC3FC File Offset: 0x000FA5FC
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 12
				Dim num As Short = 2S
				Do
					array(CInt(num)) = A_0(CInt((num - 2S + A_3)))
					num += 1S
				Loop While num <= 9S
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 9S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 9S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
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

		' Token: 0x060024F3 RID: 9459 RVA: 0x000FC4A4 File Offset: 0x000FA6A4
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Byte, A_2 As String, A_3 As Short) As Integer
			Dim array As Byte() = New Byte(30) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_2) <> 0 Then
				result = -92
			Else
				array(1) = 13
				array(2) = A_1
				Dim num As Short = 0S
				Do
					array(CInt((3S + num))) = A_0(CInt((num + A_3)))
					num += 1S
				Loop While num <= 7S
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 11S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 2S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -94
				Else
					Oo0OO_oo.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060024F4 RID: 9460 RVA: 0x000FC538 File Offset: 0x000FA738
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Integer, A_1 As String) As Integer
			Dim b As Byte
			Dim b2 As Byte
			Dim b3 As Byte
			Dim b4 As Byte
			Dim result As Integer = Oo0OO_oo.o0_0__O00._O_o.(b, b2, b3, b4, A_1)
			Dim num As Integer = CInt(b)
			Dim num2 As Integer = CInt(b2)
			Dim num3 As Integer = CInt(b3)
			Dim num4 As Integer = CInt(b4)
			A_0 = (num Or num2 << 8 Or num3 << 16 Or num4 << 24)
			Return result
		End Function

		' Token: 0x060024F5 RID: 9461 RVA: 0x000FC574 File Offset: 0x000FA774
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Byte = CByte((A_0 And 255))
			Dim a_2 As Byte = CByte((A_0 >> 8 And 255))
			Dim a_3 As Byte = CByte((A_0 >> 16 And 255))
			Dim a_4 As Byte = CByte((A_0 >> 24 And 255))
			Return Oo0OO_oo.oO0_OO0.O0.(a_, a_2, a_3, a_4, A_1)
		End Function

		' Token: 0x060024F6 RID: 9462 RVA: 0x000FC5B8 File Offset: 0x000FA7B8
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Byte = CByte((A_0 And 255))
			Dim a_2 As Byte = CByte((A_0 >> 8 And 255))
			Dim a_3 As Byte = CByte((A_0 >> 16 And 255))
			Dim a_4 As Byte = CByte((A_0 >> 24 And 255))
			Return Oo0OO_oo.o0____o.0oO.(a_, a_2, a_3, a_4, A_1)
		End Function

		' Token: 0x060024F7 RID: 9463 RVA: 0x000FC5FC File Offset: 0x000FA7FC
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Byte = CByte((A_0 And 255))
			Dim a_2 As Byte = CByte((A_0 >> 8 And 255))
			Dim a_3 As Byte = CByte((A_0 >> 16 And 255))
			Dim a_4 As Byte = CByte((A_0 >> 24 And 255))
			Return Oo0OO_oo.O.__00O0.(a_, a_2, a_3, a_4, A_1)
		End Function

		' Token: 0x060024F8 RID: 9464 RVA: 0x000FC640 File Offset: 0x000FA840
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Byte = CByte((A_0 And 255))
			Dim a_2 As Byte = CByte((A_0 >> 8 And 255))
			Dim a_3 As Byte = CByte((A_0 >> 16 And 255))
			Dim a_4 As Byte = CByte((A_0 >> 24 And 255))
			Return Oo0OO_oo.o0_0__O00._O_o.(a_, a_2, a_3, a_4, A_1)
		End Function

		' Token: 0x060024F9 RID: 9465 RVA: 0x000FC684 File Offset: 0x000FA884
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.ooooooOo.O.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060024FA RID: 9466 RVA: 0x000FC6C4 File Offset: 0x000FA8C4
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Short, A_1 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o_O.0OOO_ooO.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060024FB RID: 9467 RVA: 0x000FC704 File Offset: 0x000FA904
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o____OOO.ooo.(A_0, A_1, A_2)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060024FC RID: 9468 RVA: 0x000FC744 File Offset: 0x000FA944
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.OO_o_0.0__0.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060024FD RID: 9469 RVA: 0x000FC784 File Offset: 0x000FA984
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.O_O_O0oO.o_Oo.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x060024FE RID: 9470 RVA: 0x000FC7C4 File Offset: 0x000FA9C4
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, A_3 As String, A_4 As String, A_5 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 + A_2 - 1S > 2031S Or A_1 < 0S Then
				result = -81
			Else
				Oo0OO_oo.O0ooo__oOO.o_0.(A_3, A_4, array)
				Dim num As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
				Oo0OO_oo.WaitForSingleObject(num, -1)
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
						num6 = Oo0OO_oo.o.O_O00o0o_.(A_0, A_1 + num5 * 8S, 8S, array, A_5, 8S * num5)
						If num6 <> 0 Then
							Dim a_ As Integer = num
							Dim a_2 As Integer = 1
							num7 = 0
							Oo0OO_oo.ReleaseSemaphore(a_, a_2, num7)
							Oo0OO_oo.CloseHandle(num)
							Return num6
						End If
						num5 += 1S
					End While
					If num3 - 8S * num5 > 0S Then
						num6 = Oo0OO_oo.o.O_O00o0o_.(A_0, A_1 + num5 * 8S, num3 - num5 * 8S, array, A_5, 8S * num5)
						If num6 <> 0 Then
							Dim a_3 As Integer = num
							Dim a_4 As Integer = 1
							num7 = 0
							Oo0OO_oo.ReleaseSemaphore(a_3, a_4, num7)
							Oo0OO_oo.CloseHandle(num)
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
						num6 = Oo0OO_oo.o.O_O00o0o_.(A_0, A_1 + num5 * 8S, 8S, array, A_5, num3 + 8S * num5)
						If num6 <> 0 Then
							Dim a_5 As Integer = num
							Dim a_6 As Integer = 1
							num7 = 0
							Oo0OO_oo.ReleaseSemaphore(a_5, a_6, num7)
							Oo0OO_oo.CloseHandle(num)
							Return num6
						End If
						num5 += 1S
					End While
					If A_2 - 8S * num5 > 0S Then
						num6 = Oo0OO_oo.o.O_O00o0o_.(A_0, A_1 + num5 * 8S, A_2 - num5 * 8S, array, A_5, num3 + 8S * num5)
						If num6 <> 0 Then
							Dim a_7 As Integer = num
							Dim a_8 As Integer = 1
							num7 = 0
							Oo0OO_oo.ReleaseSemaphore(a_7, a_8, num7)
							Oo0OO_oo.CloseHandle(num)
							Return num6
						End If
					End If
				End If
				Dim a_9 As Integer = num
				Dim a_10 As Integer = 1
				num7 = 0
				Oo0OO_oo.ReleaseSemaphore(a_9, a_10, num7)
				Oo0OO_oo.CloseHandle(num)
				result = num6
			End If
			Return result
		End Function

		' Token: 0x060024FF RID: 9471 RVA: 0x000FC990 File Offset: 0x000FAB90
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), A_1 As Short, A_2 As Short, A_3 As String, A_4 As String, A_5 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 + A_2 - 1S > 2031S Or A_1 < 0S Then
				result = -81
			Else
				Oo0OO_oo.O0ooo__oOO.o_0.(A_3, A_4, array)
				Dim num As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
				Oo0OO_oo.WaitForSingleObject(num, -1)
				Dim num2 As Short = A_2 / 16S - 1S
				Dim num3 As Short
				Dim num4 As Integer
				Dim num5 As Integer
				num3 = 0S
				While num3 <= num2
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(A_0, A_1 + num3 * 16S, 16S, array, A_5, num3 * 16S)
					If num4 <> 0 Then
						Dim a_ As Integer = num
						Dim a_2 As Integer = 1
						num5 = 0
						Oo0OO_oo.ReleaseSemaphore(a_, a_2, num5)
						Oo0OO_oo.CloseHandle(num)
						Return num4
					End If
					num3 += 1S
				End While
				If A_2 - 16S * num3 > 0S Then
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(A_0, A_1 + num3 * 16S, A_2 - 16S * num3, array, A_5, 16S * num3)
					If num4 <> 0 Then
						Dim a_3 As Integer = num
						Dim a_4 As Integer = 1
						num5 = 0
						Oo0OO_oo.ReleaseSemaphore(a_3, a_4, num5)
						Oo0OO_oo.CloseHandle(num)
						Return num4
					End If
				End If
				Dim a_5 As Integer = num
				Dim a_6 As Integer = 1
				num5 = 0
				Oo0OO_oo.ReleaseSemaphore(a_5, a_6, num5)
				Oo0OO_oo.CloseHandle(num)
				result = num4
			End If
			Return result
		End Function

		' Token: 0x06002500 RID: 9472 RVA: 0x000FCA90 File Offset: 0x000FAC90
		Friend Function <<EMPTY_NAME>>(A_0 As Short, A_1 As Integer, A_2 As Integer, ByRef A_3 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o.0_0OOoO.(A_0, A_1, A_2, A_3)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x06002501 RID: 9473 RVA: 0x000FCAD0 File Offset: 0x000FACD0
		Friend Function <<EMPTY_NAME>>(A_0 As Short, A_1 As Integer, A_2 As Integer, ByRef A_3 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o0_.____Oo00.(A_0, A_1, A_2, A_3)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x06002502 RID: 9474 RVA: 0x000FCB10 File Offset: 0x000FAD10
		Friend Function <<EMPTY_NAME>>(A_0 As Short, ByRef A_1 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o____OOO.ooo.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x06002503 RID: 9475 RVA: 0x000FCB50 File Offset: 0x000FAD50
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o_oO0._0O0O_oO.(A_0, A_1)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x06002504 RID: 9476 RVA: 0x000FCB90 File Offset: 0x000FAD90
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			For num As Short = CShort(Strings.Len(A_0))To 7S
				A_0 = "0" + A_0
			Next
			Return A_0
		End Function

		' Token: 0x06002505 RID: 9477 RVA: 0x000FCBC0 File Offset: 0x000FADC0
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, ByRef A_2 As Byte())
			A_0 = Oo0OO_oo.O.OOO0_0.(A_0)
			A_1 = Oo0OO_oo.O.OOO0_0.(A_1)
			Dim num As Short = 0S
			Do
				A_2(CInt(num)) = CByte(Oo0OO_oo.Ooo_o_o._0o0.(Strings.Mid(A_0, CInt((1S + num * 2S)), 2)))
				num += 1S
			Loop While num <= 3S
			num = 0S
			Do
				A_2(CInt((num + 4S))) = CByte(Oo0OO_oo.Ooo_o_o._0o0.(Strings.Mid(A_1, CInt((1S + num * 2S)), 2)))
				num += 1S
			Loop While num <= 3S
		End Sub

		' Token: 0x06002506 RID: 9478 RVA: 0x000FCC24 File Offset: 0x000FAE24
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			Oo0OO_oo.O0ooo__oOO.o_0.(A_0, A_1, array)
			Oo0OO_oo.O0ooo__oOO.o_0.(A_2, A_3, array2)
			Dim a_ As Short = 2032S
			Dim a_2 As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_2, -1)
			Dim result As Integer = Oo0OO_oo.o.O_O00o0o_.(array2, a_, 8S, array, A_4, 0S)
			Dim a_3 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, num)
			Oo0OO_oo.CloseHandle(a_2)
			Return result
		End Function

		' Token: 0x06002507 RID: 9479 RVA: 0x000FCC94 File Offset: 0x000FAE94
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim array2 As Byte() = New Byte(8) {}
			Oo0OO_oo.O0ooo__oOO.o_0.(A_0, A_1, array)
			Oo0OO_oo.O0ooo__oOO.o_0.(A_2, A_3, array2)
			Dim a_ As Short = 2040S
			Dim a_2 As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_2, -1)
			Dim result As Integer = Oo0OO_oo.o.O_O00o0o_.(array2, a_, 8S, array, A_4, 0S)
			Dim a_3 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, num)
			Oo0OO_oo.CloseHandle(a_2)
			Return result
		End Function

		' Token: 0x06002508 RID: 9480 RVA: 0x000FCD04 File Offset: 0x000FAF04
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Short, A_2 As String, A_3 As String, A_4 As String) As Integer
			Dim array As Byte() = New Byte(8) {}
			Dim result As Integer
			If A_1 < 0S Then
				result = -81
			Else
				Oo0OO_oo.O0ooo__oOO.o_0.(A_2, A_3, array)
				Dim num As Short = CShort(Oo0OO_oo.lstrlenA(A_0))
				Dim a_ As Byte() = New Byte(CInt((num + 1S)) - 1) {}
				Oo0OO_oo.O.OOO0_0.(a_, A_0, CInt(num))
				If A_1 + num > 2031S Then
					result = -47
				Else
					Dim num2 As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
					Oo0OO_oo.WaitForSingleObject(num2, -1)
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
							num7 = Oo0OO_oo.o.O_O00o0o_.(a_, A_1 + num6 * 8S, 8S, array, A_4, num6 * 8S)
							If num7 <> 0 Then
								Dim a_2 As Integer = num2
								Dim a_3 As Integer = 1
								num8 = 0
								Oo0OO_oo.ReleaseSemaphore(a_2, a_3, num8)
								Oo0OO_oo.CloseHandle(num2)
								Return num7
							End If
							num6 += 1S
						End While
						If num4 - 8S * num6 > 0S Then
							num7 = Oo0OO_oo.o.O_O00o0o_.(a_, A_1 + num6 * 8S, num4 - num6 * 8S, array, A_4, 8S * num6)
							If num7 <> 0 Then
								Dim a_4 As Integer = num2
								Dim a_5 As Integer = 1
								num8 = 0
								Oo0OO_oo.ReleaseSemaphore(a_4, a_5, num8)
								Oo0OO_oo.CloseHandle(num2)
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
							num7 = Oo0OO_oo.o.O_O00o0o_.(a_, A_1 + num6 * 8S, 8S, array, A_4, num4 + num6 * 8S)
							If num7 <> 0 Then
								Dim a_6 As Integer = num2
								Dim a_7 As Integer = 1
								num8 = 0
								Oo0OO_oo.ReleaseSemaphore(a_6, a_7, num8)
								Oo0OO_oo.CloseHandle(num2)
								Return num7
							End If
							num6 += 1S
						End While
						If num - 8S * num6 > 0S Then
							num7 = Oo0OO_oo.o.O_O00o0o_.(a_, A_1 + num6 * 8S, num - num6 * 8S, array, A_4, num4 + 8S * num6)
							If num7 <> 0 Then
								Dim a_8 As Integer = num2
								Dim a_9 As Integer = 1
								num8 = 0
								Oo0OO_oo.ReleaseSemaphore(a_8, a_9, num8)
								Oo0OO_oo.CloseHandle(num2)
								Return num7
							End If
						End If
					End If
					Dim a_10 As Integer = num2
					Dim a_11 As Integer = 1
					num8 = 0
					Oo0OO_oo.ReleaseSemaphore(a_10, a_11, num8)
					Oo0OO_oo.CloseHandle(num2)
					result = num7
				End If
			End If
			Return result
		End Function

		' Token: 0x06002509 RID: 9481 RVA: 0x000FCEFC File Offset: 0x000FB0FC
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As String, A_1 As Short, A_2 As Integer, A_3 As String, A_4 As String, A_5 As String) As Short
			Dim array As Byte() = New Byte(8) {}
			Dim a_ As Byte() = New Byte(A_2 + 1 - 1) {}
			Oo0OO_oo.O0ooo__oOO.o_0.(A_3, A_4, array)
			Dim result As Short
			If A_1 < 0S Then
				result = -81S
			ElseIf CShort((CInt(A_1) + A_2)) > 2031S Then
				result = -47S
			Else
				Dim num As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
				Oo0OO_oo.WaitForSingleObject(num, -1)
				Dim num2 As Short = CShort((A_2 / 16 - 1))
				Dim num3 As Short
				Dim num4 As Integer
				Dim num5 As Integer
				num3 = 0S
				While num3 <= num2
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(a_, A_1 + num3 * 16S, 16S, array, A_5, num3 * 16S)
					If num4 <> 0 Then
						Dim a_2 As Integer = num
						Dim a_3 As Integer = 1
						num5 = 0
						Oo0OO_oo.ReleaseSemaphore(a_2, a_3, num5)
						Oo0OO_oo.CloseHandle(num)
						Return CShort(num4)
					End If
					num3 += 1S
				End While
				If A_2 - CInt((16S * num3)) > 0 Then
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(a_, A_1 + num3 * 16S, CShort((A_2 - CInt((16S * num3)))), array, A_5, 16S * num3)
					If num4 <> 0 Then
						Dim a_4 As Integer = num
						Dim a_5 As Integer = 1
						num5 = 0
						Oo0OO_oo.ReleaseSemaphore(a_4, a_5, num5)
						Oo0OO_oo.CloseHandle(num)
						Return CShort(num4)
					End If
				End If
				Dim a_6 As Integer = num
				Dim a_7 As Integer = 1
				num5 = 0
				Oo0OO_oo.ReleaseSemaphore(a_6, a_7, num5)
				Oo0OO_oo.CloseHandle(num)
				Dim stringBuilder As StringBuilder = New StringBuilder("", A_2)
				Dim num6 As Short = CShort(A_2)
				num3 = 1S
				While num3 <= num6
					stringBuilder.Append(0)
					num3 += 1S
				End While
				Oo0OO_oo.O.OOO0_0.(stringBuilder, a_, A_2)
				A_0 = stringBuilder.ToString()
				result = CShort(num4)
			End If
			Return result
		End Function

		' Token: 0x0600250A RID: 9482 RVA: 0x000FD050 File Offset: 0x000FB250
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Integer
			New Byte(8) {}
			Dim array As Byte()
			Oo0OO_oo.o0___0O._0.(A_0, array)
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim num As Integer = Oo0OO_oo.O.__00O0.(array, 0, A_1, 8S)
			If num = 0 Then
				num = Oo0OO_oo.O.__00O0.(array, 1, A_1, 0S)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num2)
			Oo0OO_oo.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x0600250B RID: 9483 RVA: 0x000FD0B0 File Offset: 0x000FB2B0
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o____OOO.ooo.(A_0, A_1, A_2, 0S)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x0600250C RID: 9484 RVA: 0x000FD0F0 File Offset: 0x000FB2F0
		Friend Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As String, A_2 As String) As Integer
			Dim num As Integer = Oo0OO_oo.lstrlenA(A_0) + 1
			Dim a_ As Integer = num
			If num < 8 Then
				num = 8
			Else
				num = num
			End If
			Dim array As Byte() = New Byte(num + 1 - 1) {}
			Dim array2 As Byte() = New Byte(num + 1 - 1) {}
			Oo0OO_oo.O.OOO0_0.(array, A_0, a_)
			array.CopyTo(array2, 0)
			Dim num2 As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(num2, -1)
			Dim num3 As Integer = num - 8
			Dim num4 As Integer
			For i As Integer = 0 To num3 Step 8
				num4 = Oo0OO_oo.o____OOO.ooo.(array, array2, A_2, CShort(i))
				If num4 <> 0 Then
					Exit For
				End If
			Next
			Dim a_2 As Integer = num2
			Dim a_3 As Integer = 1
			Dim num5 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, num5)
			Oo0OO_oo.CloseHandle(num2)
			A_1 = ""
			num5 = num - 1
			For i As Integer = 0 To num5
				A_1 += array2(i).ToString("X2")
			Next
			Return num4
		End Function

		' Token: 0x0600250D RID: 9485 RVA: 0x000FD1C4 File Offset: 0x000FB3C4
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim num As Integer = Oo0OO_oo.O_O_O0oO.o_Oo.(A_0, A_2)
			If num = 0 Then
				num = Oo0OO_oo.OO_o_0.0__0.(A_1, A_2)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num2)
			Oo0OO_oo.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x0600250E RID: 9486 RVA: 0x000FD20C File Offset: 0x000FB40C
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim num As Integer = Oo0OO_oo.o_oO0._0O0O_oO.(A_0, A_2)
			If num = 0 Then
				num = Oo0OO_oo.OO_o_0.0__0.(A_1, A_2)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num2)
			Oo0OO_oo.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x0600250F RID: 9487 RVA: 0x000FD254 File Offset: 0x000FB454
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Integer
			New Byte(8) {}
			Dim array As Byte()
			Oo0OO_oo.o0___0O._0.(A_0, array)
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim num As Integer = Oo0OO_oo.o0_0__O00._O_o.(array, 0, A_1, 8S)
			If num = 0 Then
				num = Oo0OO_oo.o0_0__O00._O_o.(array, 1, A_1, 0S)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num2)
			Oo0OO_oo.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x06002510 RID: 9488 RVA: 0x000FD2B4 File Offset: 0x000FB4B4
		Friend Function <<EMPTY_NAME>>(ByRef A_0 As Byte(), ByRef A_1 As Byte(), A_2 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.O0ooo__oOO.o_0.(A_0, A_1, A_2, 0S)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x06002511 RID: 9489 RVA: 0x000FD2F4 File Offset: 0x000FB4F4
		Friend Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As String, A_2 As String) As Integer
			Dim num As Integer = Oo0OO_oo.lstrlenA(A_0) + 1
			Dim a_ As Integer = num
			If num < 8 Then
				num = 8
			Else
				num = num
			End If
			Dim array As Byte() = New Byte(num + 1 - 1) {}
			Dim array2 As Byte() = New Byte(num + 1 - 1) {}
			Oo0OO_oo.O.OOO0_0.(array, A_0, a_)
			array.CopyTo(array2, 0)
			Dim num2 As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(num2, -1)
			Dim num3 As Integer = num - 8
			Dim num4 As Integer
			For i As Integer = 0 To num3 Step 8
				num4 = Oo0OO_oo.O0ooo__oOO.o_0.(array, array2, A_2, CShort(i))
				If num4 <> 0 Then
					Exit For
				End If
			Next
			Dim a_2 As Integer = num2
			Dim a_3 As Integer = 1
			Dim num5 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, num5)
			Oo0OO_oo.CloseHandle(num2)
			A_1 = ""
			num5 = num - 1
			For i As Integer = 0 To num5
				A_1 += array2(i).ToString("X2")
			Next
			Return num4
		End Function

		' Token: 0x06002512 RID: 9490 RVA: 0x000FD3C8 File Offset: 0x000FB5C8
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim num As Integer = Oo0OO_oo.o_OOoo.O_0o_O.(A_0, A_2)
			If num = 0 Then
				num = Oo0OO_oo.OO_o_0.0__0.(A_1, A_2)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num2)
			Oo0OO_oo.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x06002513 RID: 9491 RVA: 0x000FD410 File Offset: 0x000FB610
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim num As Integer = Oo0OO_oo.Ooo0OOo.oO0oO.(A_0, A_2)
			If num = 0 Then
				num = Oo0OO_oo.OO_o_0.0__0.(A_1, A_2)
			End If
			Dim a_2 As Integer = 1
			Dim num2 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num2)
			Oo0OO_oo.CloseHandle(a_)
			Return num
		End Function

		' Token: 0x06002514 RID: 9492 RVA: 0x000FD458 File Offset: 0x000FB658
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Integer
			Dim num As Long = CLng(Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.()))
			Oo0OO_oo.WaitForSingleObject(CInt(num), -1)
			Dim num3 As Integer
			Dim num2 As Short = CShort(num3)
			Dim num4 As Integer = Oo0OO_oo.ooooooOo.O.(num2, A_0)
			num3 = CInt(num2)
			Dim num5 As Integer = num4
			If num5 = 0 Then
				num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0)
				If num5 = 0 Then
					num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0)
					If num5 = 0 Then
						num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0)
						If num5 = 0 Then
							num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0)
						End If
					End If
				End If
			End If
			Dim a_ As Integer = CInt(num)
			Dim a_2 As Integer = 1
			Dim num6 As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num6)
			Oo0OO_oo.CloseHandle(CInt(num))
			Return num5
		End Function

		' Token: 0x06002515 RID: 9493 RVA: 0x000FD4CC File Offset: 0x000FB6CC
		Private Function <<EMPTY_NAME>>(A_0 As String) As Integer
			Dim array As Byte() = New Byte(25) {}
			Dim array2 As Byte() = New Byte(25) {}
			Dim a_ As Integer
			Dim result As Integer
			If Oo0OO_oo.oo000oOOooo.oO.(a_, A_0) <> 0 Then
				result = -92
			Else
				array(1) = 32
				If Not Oo0OO_oo.Oo__._0Oo.(a_, array, 2S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				ElseIf Not Oo0OO_oo.o00.00_0_OOOOo.(a_, array2, 2S) Then
					Oo0OO_oo.CloseHandle(a_)
					result = -93
				Else
					Oo0OO_oo.CloseHandle(a_)
					If array2(0) <> 0 Then
						result = -82
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x06002516 RID: 9494 RVA: 0x000FD540 File Offset: 0x000FB740
		Friend Function a8(start As Short, in_data As Integer, verf_data As Integer, ByRef OutPath As String) As Integer
			Dim a_ As Integer = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.())
			Oo0OO_oo.WaitForSingleObject(a_, -1)
			Dim result As Integer = Oo0OO_oo.o.0_0OOoO.(start, in_data, verf_data, OutPath)
			Dim a_2 As Integer = 1
			Dim num As Integer = 0
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, num)
			Oo0OO_oo.CloseHandle(a_)
			Return result
		End Function

		' Token: 0x06002517 RID: 9495 RVA: 0x000FD580 File Offset: 0x000FB780
		Private Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(10) {}
			array(0) = 121
			array(1) = 116
			array(2) = 100
			array(3) = 103
			array(4) = 121
			array(5) = 122
			array(6) = 116
			array(7) = 95
			array(8) = 54
			array(9) = 100
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x04000F09 RID: 3849
		Private Const <<EMPTY_NAME>> As Short = 13961S

		' Token: 0x04000F0A RID: 3850
		Private Const <<EMPTY_NAME>> As Short = 13961S

		' Token: 0x04000F0B RID: 3851
		Private Const <<EMPTY_NAME>> As Short = 2S

		' Token: 0x04000F0C RID: 3852
		Private Const <<EMPTY_NAME>> As Short = 16S

		' Token: 0x04000F0D RID: 3853
		Private Const <<EMPTY_NAME>> As Short = -1S

		' Token: 0x04000F0E RID: 3854
		Private Const <<EMPTY_NAME>> As Short = 259S

		' Token: 0x04000F0F RID: 3855
		Private Const <<EMPTY_NAME>> As Integer = -2147483648

		' Token: 0x04000F10 RID: 3856
		Private Const <<EMPTY_NAME>> As Integer = 1073741824

		' Token: 0x04000F11 RID: 3857
		Private Const <<EMPTY_NAME>> As Short = 1S

		' Token: 0x04000F12 RID: 3858
		Private Const <<EMPTY_NAME>> As Short = 2S

		' Token: 0x04000F13 RID: 3859
		Private Const <<EMPTY_NAME>> As Short = 3S

		' Token: 0x04000F14 RID: 3860
		Private Const <<EMPTY_NAME>> As Short = 128S

		' Token: 0x04000F15 RID: 3861
		Private Const <<EMPTY_NAME>> As Short = -1S

		' Token: 0x04000F16 RID: 3862
		Private Const <<EMPTY_NAME>> As Short = 2031S

		' Token: 0x04000F17 RID: 3863
		Private Const <<EMPTY_NAME>> As Long = 4294967296L

		' Token: 0x04000F18 RID: 3864
		Private Const <<EMPTY_NAME>> As Long = 2147483647L

		' Token: 0x04000F19 RID: 3865
		Private Const <<EMPTY_NAME>> As Long = 2147483648L

		' Token: 0x04000F1A RID: 3866
		Private Const <<EMPTY_NAME>> As Long = -1640531527L

		' Token: 0x04000F1B RID: 3867
		Private <<EMPTY_NAME>> As Long

		' Token: 0x020002B4 RID: 692
		Private Structure o00oO_o
			' Token: 0x04000F1C RID: 3868
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 4)>
			Public <<EMPTY_NAME>> As Byte()

			' Token: 0x04000F1D RID: 3869
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 2)>
			Public <<EMPTY_NAME>> As Byte()

			' Token: 0x04000F1E RID: 3870
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 2)>
			Public <<EMPTY_NAME>> As Byte()

			' Token: 0x04000F1F RID: 3871
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 8)>
			Public <<EMPTY_NAME>> As Byte()
		End Structure

		' Token: 0x020002B5 RID: 693
		Private Structure O000_O0o__o
			' Token: 0x04000F20 RID: 3872
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04000F21 RID: 3873
			Public <<EMPTY_NAME>> As Oo0OO_oo.o00oO_o

			' Token: 0x04000F22 RID: 3874
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04000F23 RID: 3875
			Public <<EMPTY_NAME>> As Integer
		End Structure

		' Token: 0x020002B6 RID: 694
		Private Structure O_OO0__0___Oo
			' Token: 0x04000F24 RID: 3876
			Public <<EMPTY_NAME>> As Long

			' Token: 0x04000F25 RID: 3877
			Public <<EMPTY_NAME>> As Oo0OO_oo.o00oO_o

			' Token: 0x04000F26 RID: 3878
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04000F27 RID: 3879
			Public <<EMPTY_NAME>> As Integer
		End Structure

		' Token: 0x020002B7 RID: 695
		Private Structure oO0OOoo0O
			' Token: 0x04000F28 RID: 3880
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04000F29 RID: 3881
			Public <<EMPTY_NAME>> As Oo0OO_oo.o00oO_o

			' Token: 0x04000F2A RID: 3882
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04000F2B RID: 3883
			Public <<EMPTY_NAME>> As Integer
		End Structure

		' Token: 0x020002B8 RID: 696
		Private Structure O_0O
			' Token: 0x04000F2C RID: 3884
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04000F2D RID: 3885
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 255)>
			Public <<EMPTY_NAME>> As Char()
		End Structure

		' Token: 0x020002B9 RID: 697
		Private Structure OOo
			' Token: 0x04000F2E RID: 3886
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04000F2F RID: 3887
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F30 RID: 3888
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F31 RID: 3889
			Public <<EMPTY_NAME>> As Short
		End Structure

		' Token: 0x020002BA RID: 698
		Private Structure OoOo
			' Token: 0x04000F32 RID: 3890
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F33 RID: 3891
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F34 RID: 3892
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F35 RID: 3893
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F36 RID: 3894
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F37 RID: 3895
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 16)>
			Public <<EMPTY_NAME>> As Short()

			' Token: 0x04000F38 RID: 3896
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F39 RID: 3897
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F3A RID: 3898
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F3B RID: 3899
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F3C RID: 3900
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F3D RID: 3901
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F3E RID: 3902
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F3F RID: 3903
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F40 RID: 3904
			Public <<EMPTY_NAME>> As Short

			' Token: 0x04000F41 RID: 3905
			Public <<EMPTY_NAME>> As Short
		End Structure
	End Module
End Namespace
