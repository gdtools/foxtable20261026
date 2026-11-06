Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000C3 RID: 195
	<oO0oooo("3279")>
	Public Class PY
		' Token: 0x0600086D RID: 2157 RVA: 0x00039740 File Offset: 0x00037940
		Shared Sub New()
			If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "pydb.mdb") Then
				PY.O0OOo0_._. = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + O_O0OO.o.00O_O.() + "pydb.mdb;Persist Security Info=False")
				PY.Oo_O.0o0_. = New OleDbCommand("select py+yd from 汉字 where hz = ?", PY.O0OOo0_._.)
				PY.Oo_O.0o0_..Parameters.AddWithValue("#hz", " "c)
				PY.OO.o_Oo. = New OleDbCommand("select py+yd from 姓氏 where hz = ?", PY.O0OOo0_._.)
				PY.OO.o_Oo..Parameters.AddWithValue("#hz", " "c)
				PY.O0OOo0_._..Open()
			End If
		End Sub

		' Token: 0x0600086E RID: 2158 RVA: 0x00039807 File Offset: 0x00037A07
		Public Shared Function IsHanzi(char As Char) As Boolean
			Return Regex.IsMatch(char.ToString(), "[\u4e00-\u9fbb]")
		End Function

		' Token: 0x0600086F RID: 2159 RVA: 0x0003981C File Offset: 0x00037A1C
		Public Shared Function GetNamePY(Input As String) As String
			Dim text As String = PY.O0OOo0_._.(Conversions.ToString(Input(0)), False, 0, PY.OO.o_Oo.)
			If String.IsNullOrEmpty(text) Then
				text = PY.O0OOo0_._.(Conversions.ToString(Input(0)), False, 0, PY.Oo_O.0o0_.)
			End If
			If Input.Length > 1 Then
				text = text + " " + PY.O0OOo0_._.(Input.Substring(1), False, 0, PY.Oo_O.0o0_.)
			End If
			Return text
		End Function

		' Token: 0x06000870 RID: 2160 RVA: 0x0003988C File Offset: 0x00037A8C
		Public Shared Function GetNamePY(Input As String, TitleCase As Boolean) As String
			Dim text As String = PY.O0OOo0_._.(Conversions.ToString(Input(0)), TitleCase, 0, PY.OO.o_Oo.)
			If String.IsNullOrEmpty(text) Then
				text = PY.O0OOo0_._.(Conversions.ToString(Input(0)), TitleCase, 0, PY.Oo_O.0o0_.)
			End If
			If Input.Length > 1 Then
				text = text + " " + PY.O0OOo0_._.(Input.Substring(1), TitleCase, 0, PY.Oo_O.0o0_.)
			End If
			Return text
		End Function

		' Token: 0x06000871 RID: 2161 RVA: 0x000398FC File Offset: 0x00037AFC
		Public Shared Function GetNamePY(Input As String, TitleCase As Boolean, mode As Integer) As String
			Dim text As String = PY.O0OOo0_._.(Conversions.ToString(Input(0)), TitleCase, mode, PY.OO.o_Oo.)
			If String.IsNullOrEmpty(text) Then
				text = PY.O0OOo0_._.(Conversions.ToString(Input(0)), TitleCase, mode, PY.Oo_O.0o0_.)
			End If
			If Input.Length > 1 Then
				text = text + Interaction.IIf(mode = 3, "", " ").ToString() + PY.O0OOo0_._.(Input.Substring(1), TitleCase, mode, PY.Oo_O.0o0_.)
			End If
			Return text
		End Function

		' Token: 0x06000872 RID: 2162 RVA: 0x0003997F File Offset: 0x00037B7F
		Public Shared Function GetPY(Input As String) As String
			Return PY.O0OOo0_._.(Input, False, 0, PY.Oo_O.0o0_.)
		End Function

		' Token: 0x06000873 RID: 2163 RVA: 0x0003998E File Offset: 0x00037B8E
		Public Shared Function GetPY(Input As String, TitleCase As Boolean) As String
			Return PY.O0OOo0_._.(Input, TitleCase, 0, PY.Oo_O.0o0_.)
		End Function

		' Token: 0x06000874 RID: 2164 RVA: 0x0003999D File Offset: 0x00037B9D
		Public Shared Function GetPY(Input As String, TitleCase As Boolean, Mode As Integer) As String
			Return PY.O0OOo0_._.(Input, TitleCase, Mode, PY.Oo_O.0o0_.)
		End Function

		' Token: 0x06000875 RID: 2165 RVA: 0x000399AC File Offset: 0x00037BAC
		Private Shared Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean, A_2 As Integer, A_3 As OleDbCommand) As String
			Dim num As Integer
			Dim result As String
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_10:
				num2 = 3
				For Each c As Char In A_0
					IL_28:
					num2 = 4
					If Not PY.IsHanzi(c) Then
						IL_33:
						num2 = 5
						stringBuilder.Append(c)
					Else
						IL_44:
						num2 = 7
						Dim text As String = ""
						IL_4D:
						num2 = 8
						If A_3 IsNot PY.Oo_O.0o0_. OrElse Not PY.Oo_O.0o0_..TryGetValue(c, text) Then
							IL_6A:
							num2 = 10
							If A_3 IsNot PY.OO.o_Oo. OrElse Not PY.OO.o_Oo..TryGetValue(c, text) Then
								IL_85:
								num2 = 12
								A_3.Parameters(0).Value = c
								IL_A0:
								num2 = 13
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(A_3.ExecuteScalar())
								IL_B0:
								num2 = 14
								If objectValue IsNot Nothing Then
									IL_B7:
									num2 = 15
									text = objectValue.ToString()
									IL_C3:
									num2 = 16
									If A_3 Is PY.Oo_O.0o0_. Then
										IL_CE:
										num2 = 17
										PY.Oo_O.0o0_..Add(c, text)
									Else
										IL_E1:
										num2 = 19
										PY.OO.o_Oo..Add(c, text)
									End If
								End If
							End If
						End If
						IL_F2:
						num2 = 20
						If Operators.CompareString(text, "", True) > 0 Then
							IL_108:
							num2 = 21
							If A_2 = 2 Then
								IL_10F:
								num2 = 22
								text = PY.O0OOo0_._.(text)
							End If
							IL_11B:
							num2 = 23
							If A_1 Then
								IL_121:
								num2 = 24
								text = text.Substring(0, 1).ToUpper() + text.Substring(1)
							End If
							IL_141:
							num2 = 25
							If A_2 = 0 Then
								IL_147:
								num2 = 26
								stringBuilder.Append(text.Substring(0, text.Length - 1) + " ")
							Else
								IL_16F:
								num2 = 28
								If A_2 = 1 OrElse A_2 = 2 Then
									IL_17A:
									num2 = 29
									stringBuilder.Append(text + " ")
								Else
									IL_193:
									num2 = 31
									If A_2 = 3 Then
										IL_19A:
										num2 = 32
										stringBuilder.Append(text.Substring(0, 1))
									End If
								End If
							End If
						End If
					End If
					IL_1AE:
					num2 = 33
				Next
				IL_1C5:
				num2 = 34
				result = stringBuilder.ToString().Trim(New Char() { " "c })
				IL_1E0:
				GoTo IL_2BE
				IL_1E5:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_27F:
				GoTo IL_2B3
				IL_281:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_291:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_281
			End Try
			IL_2B3:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2BE:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000876 RID: 2166 RVA: 0x00039C9C File Offset: 0x00037E9C
		Private Shared Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim num As Integer
			Dim result As String
			Dim num10 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim array As String() = New String() { "ua", "ue", "ui", "uo", "ia", "ie", "iu", "iong" }
				IL_51:
				num2 = 3
				Dim text As String = A_0.ToLower()
				IL_5B:
				num2 = 4
				Dim num3 As Integer = CInt(Math.Round(Char.GetNumericValue(text(text.Length - 1))))
				IL_7A:
				num2 = 5
				If num3 > 0 Then
					GoTo IL_8B
				End If
				IL_81:
				num2 = 6
				result = text
				GoTo IL_27F
				IL_8B:
				num2 = 7
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_94:
				num2 = 8
				text = text.Substring(0, text.Length - 1)
				IL_A9:
				num2 = 9
				Dim num4 As Integer = array.Length - 1
				For i As Integer = 0 To num4
					IL_BC:
					num2 = 10
					Dim num5 As Integer = text.IndexOf(array(i))
					IL_CD:
					num2 = 11
					If num5 >= 0 Then
						IL_D8:
						num2 = 12
						stringBuilder.Append(text.Substring(0, num5))
						IL_ED:
						num2 = 13
						Dim value As Char = array(i)(1)
						IL_FD:
						num2 = 14
						Dim num6 As Integer = "aeiou".IndexOf(value)
						IL_10E:
						num2 = 15
						value = "āáăàaēéĕèeīíĭìiōóŏòoūúŭùu"(num6 * 5 + num3 - 1)
						IL_126:
						num2 = 16
						stringBuilder.Append(Conversions.ToString(array(i)(0)) + Conversions.ToString(value))
						IL_14D:
						num2 = 17
						If array(i).Length > 2 Then
							IL_15D:
							num2 = 18
							stringBuilder.Append(array(i).Substring(2))
						End If
						IL_173:
						num2 = 19
						If num5 + array(i).Length < text.Length Then
							IL_18C:
							num2 = 20
							stringBuilder.Append(text.Substring(num5 + array(i).Length))
						End If
						IL_1AB:
						num2 = 21
						result = stringBuilder.ToString()
						GoTo IL_27F
					End If
					IL_1BB:
					num2 = 22
				Next
				IL_1CD:
				num2 = 23
				Dim num7 As Integer = text.Length - 1
				Dim j As Integer = 0
				While j <= num7
					IL_1E3:
					num2 = 24
					Dim value2 As String = Conversions.ToString(text(j))
					IL_1F6:
					num2 = 25
					Dim num8 As Integer = "aeiou".IndexOf(value2)
					IL_207:
					num2 = 26
					If num8 >= 0 Then
						IL_20F:
						num2 = 27
						stringBuilder.Append("āáăàaēéĕèeīíĭìiōóŏòoūúŭùu"(num8 * 5 + num3 - 1))
						IL_22D:
						num2 = 28
						If j < text.Length - 1 Then
							IL_23D:
							num2 = 29
							stringBuilder.Append(text.Substring(j + 1))
							Exit While
						End If
						Exit While
					Else
						IL_255:
						num2 = 32
						stringBuilder.Append(value2)
						IL_262:
						num2 = 33
						j += 1
					End If
				End While
				IL_274:
				num2 = 34
				result = stringBuilder.ToString()
				IL_27F:
				GoTo IL_35D
				IL_284:
				Dim num9 As Integer = num10 + 1
				num10 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9)
				IL_31E:
				GoTo IL_352
				IL_320:
				num10 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_330:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_320
			End Try
			IL_352:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_35D:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x040002E9 RID: 745
		Private Shared <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x040002EA RID: 746
		Private Shared <<EMPTY_NAME>> As OleDbCommand

		' Token: 0x040002EB RID: 747
		Private Shared <<EMPTY_NAME>> As OleDbCommand

		' Token: 0x040002EC RID: 748
		Private Shared <<EMPTY_NAME>> As Dictionary(Of Char, String) = New Dictionary(Of Char, String)()

		' Token: 0x040002ED RID: 749
		Private Shared <<EMPTY_NAME>> As Dictionary(Of Char, String) = New Dictionary(Of Char, String)()
	End Class
End Namespace
