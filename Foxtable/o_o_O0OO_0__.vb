Imports System
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000439 RID: 1081
	Friend NotInheritable Module o_o_O0OO_0__
		' Token: 0x06004771 RID: 18289
		Private Declare Function MD5Encrypt Lib "Foxtable.IO.dll" (A_0 As String, A_1 As StringBuilder, A_2 As Integer) As Integer

		' Token: 0x06004772 RID: 18290
		Private Declare Function GetDllVersion Lib "Foxtable.IO.dll" (A_0 As String) As Integer

		' Token: 0x06004773 RID: 18291 RVA: 0x001D8277 File Offset: 0x001D6477
		Friend Function <<EMPTY_NAME>>() As String
			Return o_o_O0OO_0__.o000oOoo.0.
		End Function

		' Token: 0x06004774 RID: 18292 RVA: 0x001D827E File Offset: 0x001D647E
		Friend Function <<EMPTY_NAME>>() As String
			Return o_o_O0OO_0__.O00_._o_O0_.
		End Function

		' Token: 0x06004775 RID: 18293 RVA: 0x001D8285 File Offset: 0x001D6485
		Friend Function <<EMPTY_NAME>>() As String
			Return o_o_O0OO_0__.oOO.___0_0OO.
		End Function

		' Token: 0x06004776 RID: 18294 RVA: 0x001D828C File Offset: 0x001D648C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim stringBuilder As StringBuilder = New StringBuilder(100)
			Dim length As Integer = A_0.Length
			Dim result As String
			If o_o_O0OO_0__.MD5Encrypt(A_0, stringBuilder, length) = 1 Then
				result = stringBuilder.ToString().Trim()
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06004777 RID: 18295 RVA: 0x001D82C4 File Offset: 0x001D64C4
		Friend Function <<EMPTY_NAME>>() As String
			Dim array As String() = New String(2) {}
			Dim result As String
			If Operators.CompareString(o_o_O0OO_0__.o_oOo_O_._., "", True) > 0 Then
				result = o_o_O0OO_0__.o_oOo_O_._.
			Else
				If Not OO_00oOO.HardWareInfo.Ready Then
					OO_00oOO.HardWareInfo.initialize()
				Else
					While Not OO_00oOO.HardWareInfo.ok
						Thread.Sleep(100)
					End While
				End If
				array(0) = OO_00oOO.HardWareInfo.CPU.Name + OO_00oOO.HardWareInfo.CPU.ProcessorId
				array(1) = OO_00oOO.HardWareInfo.BaseBoard.Product + OO_00oOO.HardWareInfo.BaseBoard.SerialNumber
				array(2) = OO_00oOO.HardWareInfo.Disk.Model + OO_00oOO.HardWareInfo.Disk.Signature
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					array(i) = O00.MD5Encrypt(array(i))
					o_o_O0OO_0__.o_oOo_O_._. += array(i).Substring(0, 4).ToUpper()
				Next
				o_o_O0OO_0__.o_oOo_O_._..Replace("O", "0")
				result = o_o_O0OO_0__.o_oOo_O_._.
			End If
			Return result
		End Function

		' Token: 0x06004778 RID: 18296 RVA: 0x001D83EC File Offset: 0x001D65EC
		Friend Function <<EMPTY_NAME>>() As String
			Dim result As String
			If Operators.CompareString(o_o_O0OO_0__.O_0.o_0oo__0o., "", True) > 0 Then
				result = o_o_O0OO_0__.O_0.o_0oo__0o.
			Else
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "(ProjectIdentify)", "(ProjectIdentify)" })
				If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") Then
					o_o_O0OO_0__.O_0.o_0oo__0o. = O00.oO_.0o_oo_0O_.(dataRow("Config").ToString(), o_o_O0OO_0__.o000oOoo.0.(O_O0OO.O_O._Oo.()), O00.MD5Encrypt(O_O0OO.O_O._Oo.()))
					o_o_O0OO_0__.O_0.o_0oo__0o. = o_o_O0OO_0__.O_0.o_0oo__0o..Substring(0, o_o_O0OO_0__.O_0.o_0oo__0o..IndexOf("|"))
					result = o_o_O0OO_0__.O_0.o_0oo__0o.
				Else
					result = "0".PadLeft(28, "0"c)
				End If
			End If
			Return result
		End Function

		' Token: 0x06004779 RID: 18297 RVA: 0x001D84C4 File Offset: 0x001D66C4
		Friend Function <<EMPTY_NAME>>() As String
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "(ProjectIdentify)", "(ProjectIdentify)" })
			Dim result As String
			If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") Then
				Dim text As String = O00.oO_.0o_oo_0O_.(dataRow("Config").ToString(), o_o_O0OO_0__.o000oOoo.0.(O_O0OO.O_O._Oo.()), O00.MD5Encrypt(O_O0OO.O_O._Oo.()))
				result = text.Substring(text.IndexOf("|") + 1)
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x0600477A RID: 18298 RVA: 0x001D855B File Offset: 0x001D675B
		Friend Function <<EMPTY_NAME>>() As Boolean
			o0OO__.O_0_O0_OO.0Ooo.()
			Return New O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000().ShowDialog() = DialogResult.OK
		End Function

		' Token: 0x04001D32 RID: 7474
		Private <<EMPTY_NAME>> As String = O00.oO_.0o_oo_0O_.(a.Oo_.__Ooo.(), "microsoft", "egridsoft") + Strings.Left(O00.ooo000o_0.00o0.(o_o_O0OO_0__.oo00_.0oO_.(), "foxtable", o_o_O0OO_0__.oo00_.0oO_.()).Replace("/", ""), 12)

		' Token: 0x04001D33 RID: 7475
		Private <<EMPTY_NAME>> As String = O00.ooo000o_0.00o0.(o_o_O0OO_0__.o000oOoo.0., "foxsoft", o_o_O0OO_0__.oo00_.0oO_.()).Substring(0, 12)

		' Token: 0x04001D34 RID: 7476
		Private <<EMPTY_NAME>> As String = O00.ooo000o_0.00o0.(o_o_O0OO_0__.o000oOoo.0., "egridsoft", o_o_O0OO_0__.oo00_.0oO_.()).Substring(0, 12)

		' Token: 0x04001D35 RID: 7477
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D36 RID: 7478
		Private <<EMPTY_NAME>> As String
	End Module
End Namespace
