Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001D5 RID: 469
	Public NotInheritable Module ChinesFunctions
		' Token: 0x060016AF RID: 5807 RVA: 0x00092336 File Offset: 0x00090536
		<oO0oooo("3240")>
		Public Function GetPY(hzString As String, Optional Initial As Boolean = False) As String
			Return ChinesFunctions.O_OO_0O.Oo0.(hzString, Initial)
		End Function

		' Token: 0x060016B0 RID: 5808 RVA: 0x00092340 File Offset: 0x00090540
		Private Function <<EMPTY_NAME>>(A_0 As String, Optional A_1 As Boolean = False) As String
			Dim text As String = ""
			Dim result As String
			If A_1 Then
				result = ChinesFunctions.GetPY2(A_0)
			Else
				For Each c As Char In A_0
					If Char.IsLetter(c) AndAlso Strings.Asc(c) < 0 Then
						If Operators.CompareString(text, "", True) > 0 Then
							text += " "
						End If
						Dim text2 As String = chs2py.convert(Conversions.ToString(c))
						If Operators.CompareString(text2, "", True) > 0 Then
							text += text2
						Else
							text += Conversions.ToString(c)
						End If
					Else
						text += Conversions.ToString(c)
					End If
				Next
				result = text
			End If
			Return result
		End Function

		' Token: 0x060016B1 RID: 5809 RVA: 0x000923FE File Offset: 0x000905FE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetPY2(strWords As String) As String
			Return ChinesFunctions.o._0.(strWords)
		End Function

		' Token: 0x060016B2 RID: 5810 RVA: 0x00092408 File Offset: 0x00090608
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = ""
			Dim num As Integer = A_0.Length - 1
			For i As Integer = 0 To num
				Dim a_ As String = A_0.Substring(i, 1)
				text += ChinesFunctions.o.O_0_.(a_)
			Next
			Return text
		End Function

		' Token: 0x060016B3 RID: 5811 RVA: 0x00092450 File Offset: 0x00090650
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0.CompareTo("吖") < 0 Then
				result = A_0
			ElseIf A_0.CompareTo("八") < 0 Then
				result = "A"
			ElseIf A_0.CompareTo("嚓") < 0 Then
				result = "B"
			ElseIf A_0.CompareTo("咑") < 0 Then
				result = "C"
			ElseIf A_0.CompareTo("妸") < 0 Then
				result = "D"
			ElseIf A_0.CompareTo("发") < 0 Then
				result = "E"
			ElseIf A_0.CompareTo("旮") < 0 Then
				result = "F"
			ElseIf A_0.CompareTo("铪") < 0 Then
				result = "G"
			ElseIf A_0.CompareTo("讥") < 0 Then
				result = "H"
			ElseIf A_0.CompareTo("咔") < 0 Then
				result = "J"
			ElseIf A_0.CompareTo("垃") < 0 Then
				result = "K"
			ElseIf A_0.CompareTo("嘸") < 0 Then
				result = "L"
			ElseIf A_0.CompareTo("拏") < 0 Then
				result = "M"
			ElseIf A_0.CompareTo("噢") < 0 Then
				result = "N"
			ElseIf A_0.CompareTo("妑") < 0 Then
				result = "O"
			ElseIf A_0.CompareTo("七") < 0 Then
				result = "P"
			ElseIf A_0.CompareTo("亽") < 0 Then
				result = "Q"
			ElseIf A_0.CompareTo("仨") < 0 Then
				result = "R"
			ElseIf A_0.CompareTo("他") < 0 Then
				result = "S"
			ElseIf A_0.CompareTo("哇") < 0 Then
				result = "T"
			ElseIf A_0.CompareTo("夕") < 0 Then
				result = "W"
			ElseIf A_0.CompareTo("丫") < 0 Then
				result = "X"
			ElseIf A_0.CompareTo("帀") < 0 Then
				result = "Y"
			ElseIf A_0.CompareTo("咗") < 0 Then
				result = "Z"
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x060016B4 RID: 5812 RVA: 0x000926A2 File Offset: 0x000908A2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Fract(V As Double, Optional Precision As Double = 0.001) As String
			Return ChinesFunctions.O_OO_0O.Oo0.(V, Precision)
		End Function

		' Token: 0x060016B5 RID: 5813 RVA: 0x000926AC File Offset: 0x000908AC
		Private Function <<EMPTY_NAME>>(A_0 As Double, Optional A_1 As Double = 0.001) As String
			Dim num As Long = 30L
			Dim num2 As Double = 1E-06
			Dim num3 As Double = A_0
			Dim num4 As Long = 1L
			Dim num5 As Long = 0L
			Dim num6 As Long = 0L
			Dim num7 As Long = 1L
			Dim num8 As Long = num
			Dim num11 As Long
			Dim num12 As Long
			For num9 As Long = 0L To num8
				Dim num10 As Long = CLng(Math.Floor(num3))
				num3 -= CDbl(num10)
				num11 = num4 * num10 + num6
				num12 = num5 * num10 + num7
				num6 = num4
				num7 = num5
				num4 = num11
				num5 = num12
				If num3 < num2 OrElse Math.Abs(A_0 - CDbl(num11) / CDbl(num12)) < A_1 Then
					Exit For
				End If
				num3 = 1.0 / num3
			Next
			Return Conversions.ToString(num11) + "/" + Conversions.ToString(num12)
		End Function

		' Token: 0x060016B6 RID: 5814 RVA: 0x00092751 File Offset: 0x00090951
		<oO0oooo("0320")>
		Public Function ReadBirthDay(PIN As String) As DateTime
			Return ChinesFunctions.O_OO_0O.Oo0.(PIN)
		End Function

		' Token: 0x060016B7 RID: 5815 RVA: 0x0009275C File Offset: 0x0009095C
		Private Function <<EMPTY_NAME>>(A_0 As String) As DateTime
			Dim dateTime As DateTime
			If Strings.Len(A_0) = 15 Then
				If Information.IsDate(String.Concat(New String() { Strings.Mid(A_0, 7, 2), "-", Strings.Mid(A_0, 9, 2), "-", Strings.Mid(A_0, 11, 2) })) Then
					dateTime = DateTime.Parse(String.Concat(New String() { Strings.Mid(A_0, 7, 2), "-", Strings.Mid(A_0, 9, 2), "-", Strings.Mid(A_0, 11, 2) }))
				End If
			ElseIf Strings.Len(A_0) = 18 AndAlso Information.IsDate(String.Concat(New String() { Strings.Mid(A_0, 7, 4), "-", Strings.Mid(A_0, 11, 2), "-", Strings.Mid(A_0, 13, 2) })) Then
				dateTime = DateTime.Parse(String.Concat(New String() { Strings.Mid(A_0, 7, 4), "-", Strings.Mid(A_0, 11, 2), "-", Strings.Mid(A_0, 13, 2) }))
			End If
			If DateTime.Compare(dateTime, DateTime.Today) > 0 Then
				dateTime = dateTime.AddYears(-100)
			End If
			Return dateTime
		End Function

		' Token: 0x060016B8 RID: 5816 RVA: 0x000928B6 File Offset: 0x00090AB6
		<oO0oooo("2624")>
		Public Function ValidPIN(PIN As String) As Boolean
			Return ChinesFunctions.oOo___._0___0_.(PIN)
		End Function

		' Token: 0x060016B9 RID: 5817 RVA: 0x000928C0 File Offset: 0x00090AC0
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If A_0.Length <> 18 Then
				result = False
			Else
				Dim array As Integer() = New Integer() { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 }
				Dim text As String = "10X98765432"
				Dim num As Integer = 0
				Dim num2 As Integer
				Do
					Dim value As String = Conversions.ToString(A_0(num))
					num2 += Conversions.ToInteger(value) * array(num)
					num += 1
				Loop While num <= 16
				num2 = num2 Mod 11
				result = (text(num2) = A_0(17))
			End If
			Return result
		End Function

		' Token: 0x060016BA RID: 5818 RVA: 0x00092939 File Offset: 0x00090B39
		<oO0oooo("0321")>
		Public Function ReadSex(PIN As String) As String
			Return ChinesFunctions.OO__O__O_oo.0.(PIN)
		End Function

		' Token: 0x060016BB RID: 5819 RVA: 0x00092944 File Offset: 0x00090B44
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			If Strings.Len(A_0) = 15 Then
				If Information.IsDate(String.Concat(New String() { Strings.Mid(A_0, 7, 2), "-", Strings.Mid(A_0, 9, 2), "-", Strings.Mid(A_0, 11, 2) })) Then
					Return Interaction.IIf(Integer.Parse(Strings.Right(A_0, 1)) Mod 2 = 0, "女", "男").ToString()
				End If
			ElseIf Strings.Len(A_0) = 18 AndAlso Information.IsDate(String.Concat(New String() { Strings.Mid(A_0, 7, 4), "-", Strings.Mid(A_0, 11, 2), "-", Strings.Mid(A_0, 13, 2) })) Then
				Return Interaction.IIf(Integer.Parse(Strings.Mid(A_0, 17, 1)) Mod 2 = 0, "女", "男").ToString()
			End If
			Return ""
		End Function

		' Token: 0x060016BC RID: 5820 RVA: 0x00092A4B File Offset: 0x00090C4B
		<oO0oooo("0317")>
		Public Function CUDate(Value As DateTime) As String
			Return ChinesFunctions.oOo___._0___0_.(Value, "零壹贰叁肆伍陆柒捌玖拾")
		End Function

		' Token: 0x060016BD RID: 5821 RVA: 0x00092A58 File Offset: 0x00090C58
		<oO0oooo("1578")>
		Public Function CLDate(value As DateTime) As String
			Return ChinesFunctions.oOo___._0___0_.(value, "○一二三四五六七八九十")
		End Function

		' Token: 0x060016BE RID: 5822 RVA: 0x00092A65 File Offset: 0x00090C65
		<oO0oooo("1581")>
		Public Function CCDate(value As DateTime) As String
			Return ChinesFunctions.O_.o_O0O_o__.(value)
		End Function

		' Token: 0x060016BF RID: 5823 RVA: 0x00092A70 File Offset: 0x00090C70
		Private Function <<EMPTY_NAME>>(A_0 As DateTime) As String
			Dim text As String = "零壹贰叁肆伍陆柒捌玖拾"
			Dim year As Integer = A_0.Year
			Dim month As Integer = A_0.Month
			Dim day As Integer = A_0.Day
			Dim text2 As String = year.ToString()
			Dim text3 As String = ""
			Dim num As Integer = text2.Length - 1
			For i As Integer = 0 To num
				text3 += Conversions.ToString(text(Integer.Parse(Conversions.ToString(text2(i)))))
			Next
			Dim text4 As String
			If month < 10 Then
				text4 = "零" + Conversions.ToString(text(month))
			ElseIf month = 10 Then
				text4 = "壹拾"
			Else
				text4 = "壹拾" + Conversions.ToString(text(month Mod 10))
			End If
			Dim text5 As String
			If day < 10 Then
				text5 = "零" + Conversions.ToString(text(day))
			ElseIf day < 10 Then
				text5 = "零" + Conversions.ToString(text(10))
			Else
				text5 = Strings.Mid(text, day / 10 + 1, 1) + "拾"
				If day Mod 10 > 0 Then
					text5 += Strings.Mid(text, day Mod 10 + 1, 1)
				End If
			End If
			Return String.Concat(New String() { text3, "年", text4, "月", text5, "日" })
		End Function

		' Token: 0x060016C0 RID: 5824 RVA: 0x00092BEC File Offset: 0x00090DEC
		Private Function <<EMPTY_NAME>>(A_0 As DateTime, A_1 As String) As String
			Dim year As Integer = A_0.Year
			Dim month As Integer = A_0.Month
			Dim day As Integer = A_0.Day
			Dim text As String = year.ToString()
			Dim text2 As String = ""
			Dim num As Integer = text.Length - 1
			For i As Integer = 0 To num
				text2 += Conversions.ToString(A_1(Integer.Parse(Conversions.ToString(text(i)))))
			Next
			Dim text3 As String
			If month < 10 Then
				text3 = Conversions.ToString(A_1(month))
			ElseIf month = 10 Then
				text3 = Conversions.ToString(A_1(10))
			Else
				text3 = Conversions.ToString(A_1(10)) + Conversions.ToString(A_1(month Mod 10))
			End If
			Dim text4 As String
			If day < 10 Then
				text4 = Conversions.ToString(A_1(day))
			Else
				If day / 10 = 1 Then
					text4 = Conversions.ToString(A_1(10))
				Else
					text4 = Conversions.ToString(A_1(day / 10)) + Conversions.ToString(A_1(10))
				End If
				If day Mod 10 > 0 Then
					text4 += Conversions.ToString(A_1(day Mod 10))
				End If
			End If
			Return String.Concat(New String() { text2, "年", text3, "月", text4, "日" })
		End Function

		' Token: 0x060016C1 RID: 5825 RVA: 0x00092D5E File Offset: 0x00090F5E
		<oO0oooo("0319")>
		Public Function GetDigit(Value As String, Position As Integer, Optional Symbol As Char = "￥"c) As Char
			Return ChinesFunctions.O_OO_0O.Oo0.(Value, Position, Symbol)
		End Function

		' Token: 0x060016C2 RID: 5826 RVA: 0x00092D68 File Offset: 0x00090F68
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As Integer, Optional A_2 As Char = "￥"c) As Char
			Dim result As Char
			If Operators.CompareString(A_0, "", True) = 0 Then
				result = vbNullChar
			Else
				Dim array As String() = A_0.Split(New Char() { (New Char() { "."c })(0) })
				If array(0).Length > 0 And A_1 >= 0 Then
					array(0) = o_O_o_oOoo__.OOOO_OO._oo.(array(0))
					If array(0).Length > A_1 Then
						result = array(0)(A_1)
					ElseIf array(0).Length = A_1 Then
						result = A_2
					Else
						result = vbNullChar
					End If
				ElseIf array.Length > 1 And A_1 < 0 Then
					If array(1).Length >= Math.Abs(A_1) Then
						result = array(1)(Math.Abs(A_1) - 1)
					Else
						result = "0"c
					End If
				ElseIf A_1 < 0 Then
					result = "0"c
				Else
					result = vbNullChar
				End If
			End If
			Return result
		End Function

		' Token: 0x060016C3 RID: 5827 RVA: 0x00092E36 File Offset: 0x00091036
		<oO0oooo("1582")>
		Public Function CCNumber(Value As String) As String
			Return ChinesFunctions.o_00o.OO00O.(Value)
		End Function

		' Token: 0x060016C4 RID: 5828 RVA: 0x00092E40 File Offset: 0x00091040
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String
			If Versioned.IsNumeric(A_0) Then
				Dim num As Long = Conversions.ToLong(A_0)
				text = ChinesFunctions.CUNumber(A_0)
				If num > 0L And num < 10L Then
					text = "零" + text
				End If
			Else
				text = A_0
			End If
			Return text
		End Function

		' Token: 0x060016C5 RID: 5829 RVA: 0x00092E82 File Offset: 0x00091082
		<oO0oooo("0316")>
		Public Function CUMoney(Value As String) As String
			Return ChinesFunctions.OO._.(Value)
		End Function

		' Token: 0x060016C6 RID: 5830 RVA: 0x00092E8C File Offset: 0x0009108C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0 Is Nothing Then
				result = Nothing
			Else
				Dim array As String() = A_0.Split(New Char() { (New Char() { "."c })(0) })
				If array.Length = 1 OrElse Conversion.Val(array(1)) = 0.0 Then
					result = ChinesFunctions.CUNumber(array(0)) + "元整"
				Else
					result = ChinesFunctions.CUNumber(array(0)) + "元" + ChinesFunctions.O.O0O0O.(array(1))
				End If
			End If
			Return result
		End Function

		' Token: 0x060016C7 RID: 5831 RVA: 0x00092F10 File Offset: 0x00091110
		<oO0oooo("0318")>
		Public Function CUNumber(value As String) As String
			Return ChinesFunctions.O_0_._0__.(value)
		End Function

		' Token: 0x060016C8 RID: 5832 RVA: 0x00092F18 File Offset: 0x00091118
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = ""
			Dim text2 As String = ""
			Dim text3 As String = ""
			Dim text4 As String = ""
			Dim text5 As String = "万亿兆"
			A_0 = A_0.TrimEnd(New Char() { "."c })
			Dim result As String
			If Not Versioned.IsNumeric(A_0) Then
				result = ""
			ElseIf Conversion.Val(A_0) = 0.0 Then
				result = "零"
			Else
				Dim num As Long = CLng(Math.Floor(Conversion.Val(A_0)))
				If A_0.IndexOf(".") >= 0 Then
					text = A_0.Substring(A_0.IndexOf("."c) + 1)
				End If
				If num > 0L Then
					If num = 0L Then
						Return "零"
					End If
					A_0 = num.ToString()
					Dim num2 As Integer = 1
					Do
						Dim text6 As String = Strings.Right(A_0, 4)
						num = Long.Parse(text6)
						text6 = num.ToString()
						If num2 = 1 Then
							text4 = ChinesFunctions.o0O.o00O0_oOo.(text6)
						Else
							If num > 0L Then
								text3 = ChinesFunctions.o0O.o00O0_oOo.(text6) + Conversions.ToString(text5(num2 - 2))
							End If
							If Operators.CompareString(text4, "", True) > 0 Then
								If num = 0L OrElse text2.Length < 4 OrElse text6.EndsWith("0") Then
									text4 = text3 + "零" + text4
								Else
									text4 = text3 + text4
								End If
							Else
								text4 = text3
							End If
						End If
						text2 = text6
						If A_0.Length <= 4 Then
							Exit Do
						End If
						A_0 = A_0.Substring(0, A_0.Length - 4)
						num2 += 1
					Loop While num2 <= 4
					text4 = text4.Replace("零零", "零")
					text4 = text4.Replace("零零", "零")
				End If
				If Operators.CompareString(text, "", True) > 0 Then
					If Operators.CompareString(text4, "", True) = 0 Then
						text4 = "零点"
					Else
						text4 += "点"
					End If
					Dim num3 As Integer = text.Length - text.TrimStart(New Char() { "0"c }).Length
					If num3 > 0 Then
						text4 += "零".PadLeft(num3, "零"c)
					End If
					text4 += ChinesFunctions.CUNUM(Conversions.ToInteger(text))
				End If
				result = text4
			End If
			Return result
		End Function

		' Token: 0x060016C9 RID: 5833 RVA: 0x0009314E File Offset: 0x0009134E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function CUDigit(x As Char) As String
			Return ChinesFunctions.O_.o_O0O_o__.(x)
		End Function

		' Token: 0x060016CA RID: 5834 RVA: 0x00093158 File Offset: 0x00091358
		Private Function <<EMPTY_NAME>>(A_0 As Char) As String
			Dim result As String
			If Not Versioned.IsNumeric(A_0) Then
				result = Nothing
			Else
				Dim text As String = ""
				Select Case A_0
					Case "0"c
						text = "零"
					Case "1"c
						text = "壹"
					Case "2"c
						text = "贰"
					Case "3"c
						text = "叁"
					Case "4"c
						text = "肆"
					Case "5"c
						text = "伍"
					Case "6"c
						text = "陆"
					Case "7"c
						text = "柒"
					Case "8"c
						text = "捌"
					Case "9"c
						text = "玖"
				End Select
				result = text
			End If
			Return result
		End Function

		' Token: 0x060016CB RID: 5835 RVA: 0x00093208 File Offset: 0x00091408
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			A_0 = o_O_o_oOoo__.OOOO_OO._oo.(A_0)
			Dim length As Integer = A_0.Length
			Dim text As String = ""
			Dim num As Integer = length - 1
			For i As Integer = 0 To num
				Dim expression As Char = A_0(i)
				Select Case i
					Case 0
						If Conversion.Val(expression) > 0 Then
							text = ChinesFunctions.CUDigit(A_0(i))
						End If
					Case 1
						If Conversion.Val(expression) > 0 Then
							text = ChinesFunctions.CUDigit(A_0(i)) + "拾" + text
						ElseIf Operators.CompareString(text, "", True) > 0 Then
							text = "零" + text
						End If
					Case 2
						If Conversion.Val(expression) > 0 Then
							text = ChinesFunctions.CUDigit(A_0(i)) + "佰" + text
						ElseIf Operators.CompareString(text, "", True) > 0 Then
							text = "零" + text
						End If
					Case 3
						text = ChinesFunctions.CUDigit(A_0(i)) + "仟" + text
				End Select
				text = text.Replace("零零", "零")
			Next
			Return text
		End Function

		' Token: 0x060016CC RID: 5836 RVA: 0x0009332C File Offset: 0x0009152C
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0.Length = 1 Then
				result = ChinesFunctions.CUDigit(A_0(0)) + "角整"
			Else
				result = (ChinesFunctions.CUDigit(A_0(0)) + "角" + ChinesFunctions.CUDigit(A_0(1)) + "分").Replace("零分", "").Replace("零角", "零")
			End If
			Return result
		End Function

		' Token: 0x060016CD RID: 5837 RVA: 0x000933A7 File Offset: 0x000915A7
		<oO0oooo("0322")>
		Public Function EUNumber(Value As String) As String
			Return ChinesFunctions.o._o.(Value)
		End Function

		' Token: 0x060016CE RID: 5838 RVA: 0x000933B0 File Offset: 0x000915B0
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = ""
			Dim array As String() = New String(9) {}
			array(2) = " Thousand "
			array(3) = " Million "
			array(4) = " Billion "
			array(5) = " Trillion "
			Dim result As String
			If A_0.Length > 16 Then
				MessageBox.Show("EUNumber不能转换超过16个有效数字的整数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = ""
			Else
				Dim s As String = A_0.Trim()
				Dim num As Long = 0L
				If Long.TryParse(s, num) Then
					num = Long.Parse(A_0.Trim())
					A_0 = num.ToString()
					Dim num2 As Integer = 1
					While Operators.CompareString(A_0, "", True) <> 0
						Dim text2 As String = ChinesFunctions.Oo0oO0_0O.o.(Strings.Right(A_0, 3))
						If Operators.CompareString(text2, "", True) <> 0 Then
							text = text2 + array(num2) + text
						End If
						If Strings.Len(A_0) > 3 Then
							A_0 = Strings.Left(A_0, Strings.Len(A_0) - 3)
						Else
							A_0 = ""
						End If
						num2 += 1
					End While
					result = text
				Else
					result = ""
				End If
			End If
			Return result
		End Function

		' Token: 0x060016CF RID: 5839 RVA: 0x000934AD File Offset: 0x000916AD
		<oO0oooo("0323")>
		Public Function EUMoney(Value As String) As String
			Return ChinesFunctions.o0__._.(Value)
		End Function

		' Token: 0x060016D0 RID: 5840 RVA: 0x000934B8 File Offset: 0x000916B8
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = ""
			A_0 = Strings.Trim(A_0)
			Dim num As Integer = Strings.InStr(A_0, ".", CompareMethod.Text)
			If num > 0 Then
				text = ChinesFunctions.o.O_.(Strings.Left(Strings.Mid(A_0, num + 1) + "00", 2))
				A_0 = Strings.Trim(Strings.Left(A_0, num - 1))
			End If
			Dim text2 As String = ChinesFunctions.EUNumber(A_0)
			Dim left As String = text2
			If Operators.CompareString(left, "", True) = 0 Then
				text2 = ""
			ElseIf Operators.CompareString(left, "One", True) = 0 Then
				text2 = "One Dollar"
			Else
				text2 += " Dollars"
			End If
			Dim left2 As String = text
			If Operators.CompareString(left2, "", True) = 0 Then
				text = ""
			ElseIf Operators.CompareString(left2, "One", True) = 0 Then
				text = "One Cent"
			Else
				text += " Cents"
			End If
			Dim result As String
			If Operators.CompareString(text2, "", True) > 0 And Operators.CompareString(text, "", True) > 0 Then
				result = text2 + " And " + text
			Else
				result = text2 + text
			End If
			Return result
		End Function

		' Token: 0x060016D1 RID: 5841 RVA: 0x000935D0 File Offset: 0x000917D0
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = ""
			Dim result As String
			If Conversion.Val(A_0) = 0.0 Then
				result = ""
			Else
				A_0 = Strings.Right("000" + A_0, 3)
				If Operators.CompareString(Strings.Left(A_0, 1), "0", True) <> 0 Then
					text = ChinesFunctions.oOo___._0___0_.(Strings.Left(A_0, 1)) + " Hundred "
					If Operators.CompareString(Strings.Mid(A_0, 2), "00", True) <> 0 Then
						text += "And "
					End If
				End If
				If Operators.CompareString(Strings.Mid(A_0, 2, 1), "0", True) <> 0 Then
					text += ChinesFunctions.o.O_.(Strings.Mid(A_0, 2))
				Else
					text += ChinesFunctions.oOo___._0___0_.(Strings.Mid(A_0, 3))
				End If
				result = Strings.Trim(text)
			End If
			Return result
		End Function

		' Token: 0x060016D2 RID: 5842 RVA: 0x000936A4 File Offset: 0x000918A4
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = ""
			If Conversion.Val(Strings.Left(A_0, 1)) = 1.0 Then
				Dim num As Double = Conversion.Val(A_0)
				If num = 10.0 Then
					text = "Ten"
				ElseIf num = 11.0 Then
					text = "Eleven"
				ElseIf num = 12.0 Then
					text = "Twelve"
				ElseIf num = 13.0 Then
					text = "Thirteen"
				ElseIf num = 14.0 Then
					text = "Fourteen"
				ElseIf num = 15.0 Then
					text = "Fifteen"
				ElseIf num = 16.0 Then
					text = "Sixteen"
				ElseIf num = 17.0 Then
					text = "Seventeen"
				ElseIf num = 18.0 Then
					text = "Eighteen"
				ElseIf num = 19.0 Then
					text = "Nineteen"
				End If
			Else
				Dim num2 As Double = Conversion.Val(Strings.Left(A_0, 1))
				If num2 = 2.0 Then
					text = "Twenty "
				ElseIf num2 = 3.0 Then
					text = "Thirty "
				ElseIf num2 = 4.0 Then
					text = "Forty "
				ElseIf num2 = 5.0 Then
					text = "Fifty "
				ElseIf num2 = 6.0 Then
					text = "Sixty "
				ElseIf num2 = 7.0 Then
					text = "Seventy "
				ElseIf num2 = 8.0 Then
					text = "Eighty "
				ElseIf num2 = 9.0 Then
					text = "Ninety "
				End If
				text += ChinesFunctions.oOo___._0___0_.(Strings.Right(A_0, 1))
			End If
			Return text
		End Function

		' Token: 0x060016D3 RID: 5843 RVA: 0x00093884 File Offset: 0x00091A84
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim num As Double = Conversion.Val(A_0)
			Dim result As String
			If num = 1.0 Then
				result = "One"
			ElseIf num = 2.0 Then
				result = "Two"
			ElseIf num = 3.0 Then
				result = "Three"
			ElseIf num = 4.0 Then
				result = "Four"
			ElseIf num = 5.0 Then
				result = "Five"
			ElseIf num = 6.0 Then
				result = "Six"
			ElseIf num = 7.0 Then
				result = "Seven"
			ElseIf num = 8.0 Then
				result = "Eight"
			ElseIf num = 9.0 Then
				result = "Nine"
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x060016D4 RID: 5844 RVA: 0x00093959 File Offset: 0x00091B59
		<oO0oooo("1620")>
		Public Function StrToWide(str As String) As String
			Return Strings.StrConv(str, VbStrConv.Wide, 0)
		End Function

		' Token: 0x060016D5 RID: 5845 RVA: 0x00093963 File Offset: 0x00091B63
		<oO0oooo("1621")>
		Public Function StrToNarrow(str As String) As String
			Return Strings.StrConv(str, VbStrConv.Narrow, 0)
		End Function

		' Token: 0x060016D6 RID: 5846 RVA: 0x0009396D File Offset: 0x00091B6D
		<oO0oooo("1832")>
		Public Function StrToSimplified(str As String) As String
			Return Strings.StrConv(str, VbStrConv.SimplifiedChinese, 0)
		End Function

		' Token: 0x060016D7 RID: 5847 RVA: 0x0009397B File Offset: 0x00091B7B
		<oO0oooo("1831")>
		Public Function StrToTraditional(str As String) As String
			Return Strings.StrConv(str, VbStrConv.TraditionalChinese, 0)
		End Function

		' Token: 0x060016D8 RID: 5848 RVA: 0x00093989 File Offset: 0x00091B89
		<oO0oooo("2364")>
		Public Function StrToTitleCase(str As String) As String
			Return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str)
		End Function

		' Token: 0x060016D9 RID: 5849 RVA: 0x000939A0 File Offset: 0x00091BA0
		<oO0oooo("1622")>
		Public Function DecToBin(Dec As Long) As String
			Dim text As String = ""
			While Dec > 0L
				text = Conversions.ToString(Dec Mod 2L) + text
				Dec /= 2L
			End While
			Return text
		End Function

		' Token: 0x060016DA RID: 5850 RVA: 0x000939D1 File Offset: 0x00091BD1
		<oO0oooo("1622")>
		Public Function DecToHex(Dec As Long) As String
			Return Conversion.Hex(Dec)
		End Function

		' Token: 0x060016DB RID: 5851 RVA: 0x000939D9 File Offset: 0x00091BD9
		<oO0oooo("1622")>
		Public Function DecToOct(Dec As Long) As String
			Return Conversion.Oct(Dec)
		End Function

		' Token: 0x060016DC RID: 5852 RVA: 0x000939E1 File Offset: 0x00091BE1
		<oO0oooo("1622")>
		Public Function HexToDec(value As String) As Long
			Return Convert.ToInt64(value, 16)
		End Function

		' Token: 0x060016DD RID: 5853 RVA: 0x000939EB File Offset: 0x00091BEB
		<oO0oooo("1622")>
		Public Function OctToDec(value As String) As Long
			Return Convert.ToInt64(value, 8)
		End Function

		' Token: 0x060016DE RID: 5854 RVA: 0x000939F4 File Offset: 0x00091BF4
		<oO0oooo("1622")>
		Public Function BinToDec(value As String) As Long
			Return Convert.ToInt64(value, 2)
		End Function

		' Token: 0x060016DF RID: 5855 RVA: 0x00093A00 File Offset: 0x00091C00
		<oO0oooo("2515")>
		Public Function CUNUM(value As Integer) As String
			Dim text As String = value.ToString()
			Dim text2 As String = ""
			Dim text3 As String = "零壹贰叁肆伍陆柒捌玖拾"
			Dim text4 As String = text
			For i As Integer = 0 To text4.Length - 1
				Dim index As Integer = Integer.Parse(Conversions.ToString(text4(i)))
				text2 += Conversions.ToString(text3(index))
			Next
			Return text2
		End Function

		' Token: 0x060016E0 RID: 5856 RVA: 0x00093A5C File Offset: 0x00091C5C
		<oO0oooo("2616")>
		Public Function CLNUM(value As Integer) As String
			Dim text As String = value.ToString()
			Dim text2 As String = ""
			Dim text3 As String = "零一二三四五六七八九十"
			Dim text4 As String = text
			For i As Integer = 0 To text4.Length - 1
				Dim index As Integer = Integer.Parse(Conversions.ToString(text4(i)))
				text2 += Conversions.ToString(text3(index))
			Next
			Return text2
		End Function

		' Token: 0x060016E1 RID: 5857 RVA: 0x00093AB8 File Offset: 0x00091CB8
		<oO0oooo("2648")>
		Public Sub DateYMD(dt1 As DateTime, dt2 As DateTime, ByRef y As Integer, ByRef m As Integer, ByRef d As Integer)
			Dim dateTime As DateTime
			If DateTime.Compare(dt1, dt2) > 0 Then
				dateTime = dt1
				dt1 = dt2
				dt2 = dateTime
			End If
			y = dt2.Year - dt1.Year
			m = dt2.Month - dt1.Month
			If DateTime.Compare(dt1.AddMonths(y * 12), dt2) > 0 Then
				y -= 1
				m += 12
			End If
			If DateTime.Compare(dt1.AddMonths(y * 12 + m), dt2) > 0 Then
				m -= 1
			End If
			dateTime = dt1.AddMonths(y * 12 + m)
			d = CInt(Math.Round((dt2 - dateTime).TotalDays))
		End Sub
	End Module
End Namespace
