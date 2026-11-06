Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000435 RID: 1077
	Friend NotInheritable Module o0OO__
		' Token: 0x06004729 RID: 18217 RVA: 0x001D665C File Offset: 0x001D485C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim oo0oO.o. As String = Nothing
			Dim result As Boolean
			If Oo0OO_oo.OO.OO0oO0__.(0S, 123, 1011412005, oo0oO.o.) = 0 Then
				o0OO__.OO0oO.o. = oo0oO.o.
				result = True
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x0600472A RID: 18218 RVA: 0x001D668C File Offset: 0x001D488C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Integer, A_2 As Boolean) As Boolean
			Dim result As Boolean
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
				result = False
			Else
				Dim bytes As Byte()
				If A_2 Then
					bytes = Encoding.Unicode.GetBytes(A_0)
				Else
					bytes = Encoding.ASCII.GetBytes(A_0)
				End If
				result = (Oo0OO_oo.O0_Oo0._oO.(bytes, CShort(A_1), CShort(bytes.Length), "20020317", "91730521", o0OO__.OO0oO.o.) = 0)
			End If
			Return result
		End Function

		' Token: 0x0600472B RID: 18219 RVA: 0x001D66E4 File Offset: 0x001D48E4
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As Boolean) As String
			Dim result As String
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
				result = ""
			Else
				Dim bytes As Byte() = New Byte(A_1 - 1 + 1 - 1) {}
				If Oo0OO_oo.o.O_O00o0o_.(bytes, CShort(A_0), CShort(A_1), "5599ABCD", "FEDC6833", o0OO__.OO0oO.o.) = 0 Then
					If A_2 Then
						result = Encoding.Unicode.GetString(bytes)
					Else
						result = Encoding.ASCII.GetString(bytes)
					End If
				Else
					result = ""
				End If
			End If
			Return result
		End Function

		' Token: 0x0600472C RID: 18220 RVA: 0x001D6750 File Offset: 0x001D4950
		Friend Function <<EMPTY_NAME>>(A_0 As Integer) As Integer
			Dim result As Integer
			Dim num As Integer
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
				result = A_0
			ElseIf Oo0OO_oo.o_OOoo.O_0o_O.(A_0, num, o0OO__.OO0oO.o.) = 0 Then
				result = num
			Else
				result = OoOo0O.Oo_oOO_._Oo_o.(10000, 99999)
			End If
			Return result
		End Function

		' Token: 0x0600472D RID: 18221 RVA: 0x001D678C File Offset: 0x001D498C
		Friend Function <<EMPTY_NAME>>(A_0 As Integer) As Integer
			Dim result As Integer
			Dim num As Integer
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
				result = A_0
			ElseIf Oo0OO_oo.Ooo0OOo.oO0oO.(A_0, num, o0OO__.OO0oO.o.) = 0 Then
				result = num
			Else
				result = OoOo0O.Oo_oOO_._Oo_o.(10000, 99999)
			End If
			Return result
		End Function

		' Token: 0x0600472E RID: 18222 RVA: 0x001D67C8 File Offset: 0x001D49C8
		Friend Sub <<EMPTY_NAME>>(ByRef A_0 As String, ByRef A_1 As String)
			Dim num As Integer
			Dim num2 As Integer
			If o0OO__.O_0_O0_OO.0Ooo.() AndAlso Oo0OO_oo.o0___0O._0.(num, num2, o0OO__.OO0oO.o.) = 0 Then
				num = Math.Abs(num)
				num2 = Math.Abs(num2)
			Else
				num = Math.Abs(OoOo0O.Oo_oOO_._Oo_o.())
				num2 = Math.Abs(OoOo0O.Oo_oOO_._Oo_o.())
			End If
			num = num Mod 99999999 + 1
			num2 = num2 Mod 99999999 + 1
			A_0 = Strings.Format(num, "00000000")
			A_1 = Strings.Format(num2, "00000000")
		End Sub

		' Token: 0x0600472F RID: 18223 RVA: 0x001D684C File Offset: 0x001D4A4C
		Friend Function <<EMPTY_NAME>>() As DateTime
			If o0OO__.O_0_O0_OO.0Ooo.() Then
				Try
					Dim a_ As String = ""
					Dim a_2 As String = ""
					Dim text As String = o0OO__.OO0oO.o.(1800, 50, False).Trim()
					o0OO__.oOO.o_.(a_, a_2)
					text = O00.oO_.0o_oo_0O_.(text, a_, a_2)
					Return New DateTime(Conversions.ToInteger(text.Substring(0, 4)), Conversions.ToInteger(text.Substring(4, 2)), Conversions.ToInteger(text.Substring(6, 2)))
				Catch ex As Exception
					MessageBox.Show(O_O0OO.o0O0000_0.0.(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return DateTime.Today.AddDays(-100.0)
				End Try
			End If
			Return DateTime.Today.AddDays(-100.0)
		End Function

		' Token: 0x06004730 RID: 18224 RVA: 0x001D6928 File Offset: 0x001D4B28
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim text As String = ""
			Dim text2 As String = ""
			o0OO__.oOO.o_.(text, text2)
			Dim text3 As String = o0OO__.OO0oO.o.(1850, 75, False).Trim()
			If Operators.CompareString(text3, "", True) > 0 Then
				text3 = O00.oO_.0o_oo_0O_.(text3, text, text2)
			End If
			Dim text4 As String = text + text2
			text4 = O00.MD5Encrypt(text4).Substring(0, 16)
			Return Operators.CompareString(text3, text4, True) = 0
		End Function

		' Token: 0x06004731 RID: 18225 RVA: 0x001D6998 File Offset: 0x001D4B98
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim text As String = "integer"
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
			End If
			Dim text2 As String = Nothing
			Dim strToHash As String
			If Oo0OO_oo.OO.OO0oO0__.(text, text2, o0OO__.OO0oO.o.) = 0 Then
				strToHash = text2.ToString()
			Else
				strToHash = text
			End If
			Return Operators.CompareString(O00.MD5Encrypt(strToHash), "tyr4CJXAlbeZlLvWONeM0g==", True) = 0
		End Function

		' Token: 0x06004732 RID: 18226 RVA: 0x001D69E4 File Offset: 0x001D4BE4
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
			End If
			Dim text As String = Nothing
			Dim result As String
			If Oo0OO_oo.OO.OO0oO0__.(A_0, text, o0OO__.OO0oO.o.) = 0 Then
				result = text
			Else
				result = OoOo0O.OO_o.0o_O.(A_0.Length)
			End If
			Return result
		End Function

		' Token: 0x06004733 RID: 18227 RVA: 0x001D6A1C File Offset: 0x001D4C1C
		Friend Function <<EMPTY_NAME>>() As String
			Dim str As String = Nothing
			Dim str2 As String = Nothing
			o0OO__.oOO.o_.(str, str2)
			Dim text As String = str + str2
			Return Strings.Format(Conversions.ToLong((Conversions.ToLong(o_O_o_oOoo__.OOOO_OO._oo.(text)) Xor Conversions.ToLong(text)).ToString().PadRight(16, "0"c).Substring(0, 16)), "0000-0000-0000-0000")
		End Function

		' Token: 0x06004734 RID: 18228 RVA: 0x001D6A80 File Offset: 0x001D4C80
		Friend Function <<EMPTY_NAME>>(A_0 As Integer) As Boolean
			Dim result As Boolean
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
				Try
					Dim tempFileName As String = OO_00oOO.FileSys.GetTempFileName()
					OO_00oOO.FileSys.DeleteFile(tempFileName)
					ShareLibriay.Network.DownloadFile("http://www.foxtable.com/update/eval.txt", tempFileName, "", "", False, 5000, False)
					If OO_00oOO.FileSys.FileExists(tempFileName) Then
						Dim text As String = OO_00oOO.FileSys.ReadAllText(tempFileName, Encoding.[Default])
						OO_00oOO.FileSys.DeleteFile(tempFileName)
						Dim array As String() = text.Split(New Char() { "|"c })
						If array.Length = 3 Then
							Dim dateTime As DateTime
							DateTime.TryParse(array(0), dateTime)
							Dim t As DateTime = Conversions.ToDate(OO_00oOO.ApplicationVertion())
							If DateTime.Compare(dateTime, t) <= 0 Then
								If A_0 <> 4 Then
									MessageBox.Show("您正在使用的Foxtable已经是最新版本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								End If
								Return True
							End If
							If MessageBox.Show(array(1).Replace("{0}", Strings.Format(dateTime, "yyyy-MM-dd")), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
								Process.Start("iexplore.exe", array(2))
								Return True
							End If
						End If
					End If
				Catch a_ As Exception
					If A_0 = 1 Then
						ooO.oOo0Oo.o.(a_, "")
					End If
				End Try
				result = False
			Else
				Dim dateTime2 As DateTime = Conversions.ToDate(OO_00oOO.ApplicationVertion())
				New Process()
				Dim value As Integer = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(OO_00oOO.IssueName(), "开发版", True) = 0, 1, 0))
				Dim text2 As String = o_o_O0OO_0__.O.ooOo__o000OO.()
				Dim text3 As String = o_o_O0OO_0__.O0_O_o.o_.()
				Dim str As String = Nothing
				Dim str2 As String = Nothing
				o0OO__.oOO.o_.(str, str2)
				Dim text4 As String = str + str2
				Dim text5 As String
				If Operators.CompareString(o0OO__.O.0ooOoO_0_.("hubiao2012"), "F330056DB66FD827313200", True) = 0 Then
					text5 = (Conversions.ToLong(o_O_o_oOoo__.OOOO_OO._oo.(text4)) Xor Conversions.ToLong(text4)).ToString()
					text5 = text5.PadRight(16, "0"c).Substring(0, 16)
					text5 = Strings.Format(Conversions.ToLong(text5), "0000-0000-0000-0000")
				Else
					text5 = "{" + Strings.Format(Conversions.ToLong(text4), "0000-0000-0000-0000") + "}"
				End If
				If A_0 = 2 Then
					text3 = "$" + text3
				ElseIf A_0 = 3 Then
					text3 = "$$" + text3
				ElseIf A_0 = 4 Then
					text3 = "$$$" + text3
				End If
				Try
					Dim text6 As String = String.Concat(New String() { "http://www.foxtable.com/verify/Verify.aspx?lx=", Conversions.ToString(value), "&bh=", text5, "&jqm=", text2, "&zcm=", text3, "&bb=", Conversions.ToString(dateTime2), "&rt=4" })
					Dim dateTime3 As DateTime
					If DateTime.TryParse(New HttpClient(text6).GetData(True), dateTime3) Then
						If DateTime.Compare(dateTime2, dateTime3) >= 0 Then
							If A_0 = 1 Then
								MessageBox.Show("您正在使用的Foxtable已经是最新版本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							Return True
						End If
						If MessageBox.Show("Foxtable的最新版本" + Strings.Format(dateTime3, "yyyy-MM-dd") + "已经发布, 是否现在下载？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) = DialogResult.Yes Then
							text6 = String.Concat(New String() { "http://www.foxtable.com/verify/Verify.aspx?lx=", Conversions.ToString(value), "&bh=", text5, "&jqm=", text2, "&zcm=", text3, "&bb=", Conversions.ToString(dateTime2), "&rt=1" })
							Process.Start("iexplore.exe", text6)
							Return True
						End If
					End If
				Catch a_2 As Exception
					If A_0 = 1 Then
						ooO.oOo0Oo.o.(a_2, "")
					End If
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x06004735 RID: 18229 RVA: 0x001D6E94 File Offset: 0x001D5094
		Friend Function <<EMPTY_NAME>>() As Integer
			Dim num2 As Integer
			Dim num As Short = CShort(num2)
			Dim flag As Boolean = Oo0OO_oo.O.__00O0.(num, o0OO__.OO0oO.o.) <> 0
			num2 = CInt(num)
			Dim result As Integer
			If flag Then
				result = 0
			Else
				result = num2
			End If
			Return result
		End Function

		' Token: 0x06004736 RID: 18230 RVA: 0x001D6EBC File Offset: 0x001D50BC
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			If Not o0OO__.O_0_O0_OO.0Ooo.() Then
			End If
			Dim text As String = Nothing
			Dim result As String
			If Oo0OO_oo.o_o0oO000.0_.(A_0, text, o0OO__.OO0oO.o.) = 0 Then
				result = text
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x06004737 RID: 18231 RVA: 0x001D6EEC File Offset: 0x001D50EC
		Friend Function <<EMPTY_NAME>>() As Boolean
			If o0OO__.a Is Nothing Then
				If Operators.CompareString(O_O0OO.O0_00o.o0__o..AdvancedHid, "", True) = 0 OrElse Operators.CompareString(O_O0OO.O0_00o.o0__o..AdvancedREG, "", True) = 0 Then
					o0OO__.a = 2
				Else
					Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "AdvancedHID", o0_O.ooOo_._O. })
					If dataRow Is Nothing OrElse Operators.CompareString(dataRow("Config").ToString(), O_O0OO.O0_00o.o0__o..AdvancedHid, True) <> 0 Then
						o0OO__.a = 2
					Else
						dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "AdvanceREG", o0_O.o.o__0_. })
						If dataRow Is Nothing OrElse Operators.CompareString(dataRow("Config").ToString(), O_O0OO.O0_00o.o0__o..AdvancedREG, True) <> 0 Then
							o0OO__.a = 2
						ElseIf New Oo00.o0_o_o().O0.0_.() Then
							o0OO__.a = 1
						Else
							o0OO__.a = 2
						End If
					End If
				End If
			End If
			Return o0OO__.a = 1
		End Function

		' Token: 0x06004738 RID: 18232 RVA: 0x001D702F File Offset: 0x001D522F
		Friend Function <<EMPTY_NAME>>() As String
			Return O_O0OO.O0_00o.o0__o..AdvancedHid
		End Function

		' Token: 0x06004739 RID: 18233 RVA: 0x001D703B File Offset: 0x001D523B
		Friend Function <<EMPTY_NAME>>() As String
			Return O_O0OO.O0_00o.o0__o..AdvancedREG
		End Function

		' Token: 0x04001D1B RID: 7451
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D1C RID: 7452
		Private <<EMPTY_NAME>> As Integer = 1700

		' Token: 0x04001D1D RID: 7453
		Private <<EMPTY_NAME>> As Integer = 100

		' Token: 0x04001D1E RID: 7454
		Private <<EMPTY_NAME>> As Integer = 100

		' Token: 0x04001D1F RID: 7455
		Private <<EMPTY_NAME>> As Integer = 512

		' Token: 0x04001D20 RID: 7456
		Private a As BooleanEnum
	End Module
End Namespace
