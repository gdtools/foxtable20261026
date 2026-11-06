Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002BC RID: 700
	<oO0oooo("2675")>
	Public NotInheritable Module UKey
		' Token: 0x0600254C RID: 9548 RVA: 0x000FE960 File Offset: 0x000FCB60
		<oO0oooo("2659")>
		Public Function Start() As Boolean
			If OoO0o.o.0_0O.(0S, UKey.o_o0_0.o_o_0.) = 0 Then
				Dim uid As String = UKey.UID
				Dim a_ As String = ""
				OoO0o.O_O0O_0.OO0_.(a_, 401S, 56, "ABCDEF09", "9876EFCD", UKey.o_o0_0.o_o_0.)
				If Operators.CompareString(O00.oO_.0o_oo_0O_.(a_, "ukey", "fox"), UKey.Encrypt1(uid).Substring(0, 16), True) = 0 Then
					Return True
				End If
			End If
			UKey.o_o0_0.o_o_0. = ""
			Return False
		End Function

		' Token: 0x0600254D RID: 9549 RVA: 0x000FE9DC File Offset: 0x000FCBDC
		Public Function EncInt(val As Integer) As Integer
			Dim num As Integer
			Dim result As Integer
			If OoO0o.OO00__O.O0.(val, num, UKey.o_o0_0.o_o_0.) <> 0 Then
				result = 0
			Else
				result = num
			End If
			Return result
		End Function

		' Token: 0x0600254E RID: 9550 RVA: 0x000FEA00 File Offset: 0x000FCC00
		Public Function DecInt(val As Integer) As Integer
			Dim num As Integer
			Dim result As Integer
			If OoO0o.oo_o_oo._0O.(val, num, UKey.o_o0_0.o_o_0.) <> 0 Then
				result = 0
			Else
				result = num
			End If
			Return result
		End Function

		' Token: 0x0600254F RID: 9551 RVA: 0x000FEA24 File Offset: 0x000FCC24
		<oO0oooo("2660")>
		Public Function Encrypt1(InString As String) As String
			Dim text As String = ""
			Dim result As String
			If OoO0o.o.0_0O.(InString, text, UKey.o_o0_0.o_o_0.) = 0 Then
				result = text
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06002550 RID: 9552 RVA: 0x000FEA54 File Offset: 0x000FCC54
		<oO0oooo("2661")>
		Public Function Encrypt2(InString As String) As String
			Dim text As String = ""
			Dim result As String
			If OoO0o.oOO.0O_0oO00_o.(InString, text, UKey.o_o0_0.o_o_0.) <> 0 Then
				result = ""
			Else
				result = text
			End If
			Return result
		End Function

		' Token: 0x06002551 RID: 9553 RVA: 0x000FEA84 File Offset: 0x000FCC84
		<oO0oooo("2666")>
		Public Function ReadStr(index As Short, length As Integer) As String
			Dim text As String = ""
			Dim result As String
			If CInt(index) + length > 400 Then
				result = ""
			ElseIf OoO0o.O_O0O_0.OO0_.(text, index, length, "ABCDEF09", "9876EFCD", UKey.o_o0_0.o_o_0.) <> 0S Then
				result = ""
			Else
				result = text
			End If
			Return result
		End Function

		' Token: 0x06002552 RID: 9554 RVA: 0x000FEAD0 File Offset: 0x000FCCD0
		<oO0oooo("2666")>
		Public Function WriteStr(index As Short, InString As String, password1 As String, password2 As String) As Boolean
			Dim num As Integer = OoO0o.lstrlenA(InString)
			Return CInt(index) + num <= 400 AndAlso OoO0o.ooO_.00O_oOO0.(InString, index, password1, password2, UKey.o_o0_0.o_o_0.) = 0
		End Function

		' Token: 0x17000893 RID: 2195
		' (get) Token: 0x06002553 RID: 9555 RVA: 0x000FEB08 File Offset: 0x000FCD08
		Public ReadOnly Property UID As String
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim result As String
				If OoO0o.o.0_0O.(num, num2, UKey.o_o0_0.o_o_0.) = 0 Then
					result = num.ToString("X") + num2.ToString("X")
				Else
					result = ""
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002554 RID: 9556 RVA: 0x000FEB4C File Offset: 0x000FCD4C
		<oO0oooo("2666")>
		Public Function LenStrA(val As String) As Integer
			Return OoO0o.lstrlenA(val)
		End Function

		' Token: 0x06002555 RID: 9557 RVA: 0x000FEB54 File Offset: 0x000FCD54
		Friend Function <<EMPTY_NAME>>(A_0 As Integer) As String
			Dim text As String = ""
			Dim array As String() = New String() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }
			Dim num As Integer = A_0 - 1
			For i As Integer = 0 To num
				text += array(OoOo0O.Oo_oOO_._Oo_o.(0, 16))
			Next
			Return text
		End Function

		' Token: 0x06002556 RID: 9558 RVA: 0x000FEC18 File Offset: 0x000FCE18
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return OoO0o.o00_.0_O.(UKey.o_o0_0.o_o_0.) = 0 AndAlso OoO0o.O__O_o0_O0o._.("00000000", "00000000", "FFFFFFFF", "FFFFFFFF", UKey.o_o0_0.o_o_0.) = 0 AndAlso OoO0o.O.o_ooO_O.("FFFFFFFF", "FFFFFFFF", "FFFFFFFF", "FFFFFFFF", UKey.o_o0_0.o_o_0.) = 0
		End Function

		' Token: 0x06002557 RID: 9559 RVA: 0x000FEC80 File Offset: 0x000FCE80
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String) As Boolean
			Return OoO0o.O__O_o0_O0o._.(A_0, A_1, A_2, A_3, UKey.o_o0_0.o_o_0.) = 0
		End Function

		' Token: 0x06002558 RID: 9560 RVA: 0x000FEC93 File Offset: 0x000FCE93
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String) As Boolean
			Return OoO0o.O.o_ooO_O.(A_0, A_1, A_2, A_3, UKey.o_o0_0.o_o_0.) = 0
		End Function

		' Token: 0x06002559 RID: 9561 RVA: 0x000FECA6 File Offset: 0x000FCEA6
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String) As Boolean
			Return OoO0o.o0O.Oooo_.(A_0, A_1, A_2, A_3, UKey.o_o0_0.o_o_0.) = 0
		End Function

		' Token: 0x0600255A RID: 9562 RVA: 0x000FECB9 File Offset: 0x000FCEB9
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Return OoO0o.O.o_ooO_O.(A_0, UKey.o_o0_0.o_o_0.) = 0
		End Function

		' Token: 0x04000F58 RID: 3928
		Private <<EMPTY_NAME>> As String = ""
	End Module
End Namespace
