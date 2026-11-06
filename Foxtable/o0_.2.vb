Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000430 RID: 1072
	Friend NotInheritable Module o0_
		' Token: 0x060046B6 RID: 18102 RVA: 0x001C9E98 File Offset: 0x001C8098
		Private Sub <<EMPTY_NAME>>(A_0 As List(Of DataRow), A_1 As DataRow)
			A_0.Add(A_1)
			For Each a_ As DataRow In A_1.GetChildRows("Component")
				o0_.o_000Oo0O_.00o.(A_0, a_)
			Next
		End Sub

		' Token: 0x060046B7 RID: 18103 RVA: 0x001C9ED4 File Offset: 0x001C80D4
		Public Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String)
			Dim regex As Regex = New Regex("(\b)(?<!System.)(Windows\.Forms\.)", RegexOptions.IgnoreCase)
			For Each dataRow As DataRow In A_0.[Select]("[Type] = " + Conversions.ToString(19))
				If Not dataRow.IsNull("Config") Then
					Dim text As String = dataRow("Config").ToString()
					Dim a_ As String = A_1
					If text.StartsWith("[") AndAlso text.EndsWith("]") Then
						text = text.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })
						a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., A_1.Substring(0, 5)).Substring(0, 5)
					End If
					text = O00.oO_.0o_oo_0O_.(text, "API", a_)
					Dim text2 As String = regex.Replace(text, "$1System.$2")
					If text.Length <> text2.Length Then
						a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., A_1.Substring(0, 5)).Substring(0, 5)
						dataRow("Config") = "[" + O00.ooo000o_0.00o0.(text2, "API", a_) + "]"
					End If
				End If
			Next
			Oo00.o0_o._O_.(A_0, False)
		End Sub

		' Token: 0x060046B8 RID: 18104 RVA: 0x001CA018 File Offset: 0x001C8218
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable)
			Dim regex As Regex = New Regex("(\b)(?<!System.)(Windows\.Forms\.)", RegexOptions.IgnoreCase)
			For Each dataRow As DataRow In A_0.[Select]("[Column] = '' And [Code] Is Not Null")
				New DataTableProperty()
				Dim text As String = DataTable.o.o00O.(Conversions.ToString(dataRow("Code")))
				If Not String.IsNullOrEmpty(text) Then
					Dim text2 As String = regex.Replace(text, "$1System.$2")
					If text.Length <> text2.Length Then
						dataRow("Code") = O00.ooo000o_0.00o0.(text2, O_O0OO.O_O._Oo.(), ooO0__OO.o.0_0_ooO.())
					End If
				End If
			Next
			Oo00.o0_o._O_.(A_0, False)
		End Sub

		' Token: 0x060046B9 RID: 18105 RVA: 0x001CA0B8 File Offset: 0x001C82B8
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable)
			Dim regex As Regex = New Regex("(\b)(?<!System.)(Windows\.Forms\.)", RegexOptions.IgnoreCase)
			Dim text As String = ooO0__OO.O_Oo00oO.Ooo.()
			Try
				For Each obj As Object In A_0.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Not dataRow.IsNull("Code") Then
						Dim text2 As String = Conversions.ToString(dataRow("Code"))
						Dim a_ As String = text
						Dim flag As Boolean = False
						If text2.StartsWith("{") AndAlso text2.EndsWith("}") Then
							text2 = text2.TrimStart(New Char() { "{"c }).TrimEnd(New Char() { "}"c })
							a_ = Oo00.ooO.ooo.()
							flag = True
						End If
						text2 = O00.oO_.0o_oo_0O_.(text2, text, a_)
						If Not String.IsNullOrEmpty(text2) Then
							Dim text3 As String = regex.Replace(text2, "$1System.$2")
							If text2.Length <> text3.Length Then
								text2 = O00.ooo000o_0.00o0.(text3, text, a_)
								If flag Then
									text2 = "{" + text2 + "}"
								End If
								dataRow("Code") = text2
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(A_0, False)
		End Sub

		' Token: 0x060046BA RID: 18106 RVA: 0x001CA210 File Offset: 0x001C8410
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String, A_2 As String, A_3 As String(), A_4 As String, A_5 As String, A_6 As DataTable, Optional A_7 As DataRow = Nothing) As Assembly
			Dim num As Integer
			Dim result As Assembly
			Dim num6 As Integer
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
				If Operators.CompareString(A_2, "", True) <= 0 Then
					GoTo IL_36
				End If
				IL_21:
				num2 = 4
				stringBuilder.Append(A_2 + vbCrLf)
				IL_36:
				num2 = 5
				If A_7 IsNot Nothing Then
					GoTo IL_50
				End If
				IL_3C:
				num2 = 6
				Dim array As DataRow() = A_0.[Select](A_1, "", DataViewRowState.CurrentRows)
				GoTo IL_71
				IL_50:
				num2 = 8
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_59:
				num2 = 9
				o0_.o_000Oo0O_.00o.(list, A_7)
				IL_65:
				num2 = 10
				array = list.ToArray()
				IL_71:
				num2 = 11
				Dim array2 As DataRow() = array
				Dim i As Integer = 0
				While i < array2.Length
					Dim dataRow As DataRow = array2(i)
					IL_87:
					num2 = 12
					If Conversions.ToInteger(dataRow("Type")) <> 231 Then
						GoTo IL_196
					End If
					IL_A5:
					num2 = 13
					If Operators.CompareString(A_4, "WinForm", True) <> 0 Then
						GoTo IL_196
					End If
					IL_BA:
					num2 = 14
					Dim text As String = String.Concat(New String() { OO_00oOO.FileSys.GetParentPath(A_5), "\", o0OoOOoOOo0.oo00o.0OoO.(""), ".Table.", Conversions.ToString(dataRow("Key")), ".dll" })
					IL_112:
					num2 = 15
					If dataRow.IsNull("Code") Then
						IL_123:
						num2 = 16
						If OO_00oOO.FileSys.FileExists(text) Then
							IL_137:
							num2 = 17
							OO_00oOO.FileSys.DeleteFile(text)
						End If
					Else
						IL_14B:
						num2 = 19
						If OO_00oOO.FileSys.FileExists(text) Then
							IL_15C:
							num2 = 20
							OO_00oOO.FileSys.DeleteFile(text)
						End If
						IL_16B:
						num2 = 21
						Dim a_ As DataTableProperty = New DataTableProperty()
						IL_175:
						num2 = 22
						o_O_o_oOoo__.OOOO_OO._oo.(a_, dataRow, True)
						IL_182:
						num2 = 23
						o0_.Oo_0.OOo0oO0.(a_, text, A_6)
					End If
					IL_956:
					num2 = 134
					Dim text2 As String
					i += 1
					Continue While
					IL_196:
					num2 = 25
					text2 = ""
					IL_1A0:
					num2 = 26
					Dim a_2 As String = ooO0__OO.O_Oo00oO.Ooo.()
					IL_1AA:
					num2 = 27
					If Not dataRow.IsNull("Code") Then
						IL_1BE:
						num2 = 28
						text2 = Conversions.ToString(dataRow("Code"))
						IL_1D4:
						num2 = 29
						If text2.StartsWith("{") AndAlso text2.EndsWith("}") Then
							IL_1F3:
							num2 = 30
							text2 = text2.TrimStart(New Char() { "{"c }).TrimEnd(New Char() { "}"c })
							IL_21A:
							num2 = 31
							a_2 = Oo00.ooO.ooo.()
						Else
							IL_226:
							num2 = 33
							If text2.StartsWith(" ") AndAlso text2.EndsWith(" ") Then
								IL_245:
								num2 = 34
								text2 = text2.Trim()
								IL_251:
								num2 = 35
								a_2 = o_O_o_oOoo__.OOOO_OO._oo.(ooO0__OO.O_Oo00oO.Ooo.())
							End If
						End If
						IL_260:
						num2 = 36
						text2 = O00.oO_.0o_oo_0O_.(text2, ooO0__OO.O_Oo00oO.Ooo.(), a_2)
					End If
					IL_273:
					num2 = 37
					If Operators.CompareString(text2, "", True) <> 0 Then
						IL_288:
						num2 = 39
						Dim array3 As String() = text2.Split(New Char() { vbVerticalTab })
						IL_29F:
						num2 = 40
						Dim num3 As Integer = array3.Length - 2
						For j As Integer = 0 To num3 Step 2
							IL_2B2:
							num2 = 41
							Dim text3 As String = ""
							IL_2BC:
							num2 = 42
							Dim text4 As String = ""
							IL_2C6:
							num2 = 43
							Dim text5 As String = array3(j + 1)
							IL_2D2:
							num2 = 44
							If Operators.CompareString(text5, "", True) > 0 Then
								IL_2E5:
								num2 = 45
								text5 = text5.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
							End If
							IL_302:
							num2 = 46
							If Operators.CompareString(text5, "", True) <> 0 Then
								IL_317:
								num2 = 48
								Dim flag As Boolean = False
								IL_31D:
								num2 = 49
								If text5.StartsWith("'''async", StringComparison.OrdinalIgnoreCase) Then
									IL_32F:
									num2 = 50
									flag = True
								End If
								IL_335:
								num2 = 51
								If Operators.CompareString(A_4, "Ribbon", True) = 0 Then
									IL_34A:
									num2 = 52
									Dim ribbonItemTypeEnum As RibbonItemTypeEnum = CType(Conversions.ToInteger(dataRow("Type")), RibbonItemTypeEnum)
									Select Case ribbonItemTypeEnum
										Case RibbonItemTypeEnum.Ribbon
											IL_411:
											num2 = 54
											text4 = o0_.o_000Oo0O_.00o.("Ribbon", array3(j), False)
										Case RibbonItemTypeEnum.ApplicationMenu, RibbonItemTypeEnum.QAT, RibbonItemTypeEnum.ConfigBar, RibbonItemTypeEnum.PaperList, RibbonItemTypeEnum.WindowList, RibbonItemTypeEnum.TableViewList, RibbonItemTypeEnum.GroupTableList, RibbonItemTypeEnum.CrossTableList, RibbonItemTypeEnum.SubtotalModeList, RibbonItemTypeEnum.ExcelReportList, RibbonItemTypeEnum.CodeReportList, RibbonItemTypeEnum.WordReportList, RibbonItemTypeEnum.GalleryItem
										Case RibbonItemTypeEnum.Tab
											IL_5CB:
											num2 = 88
											text4 = o0_.o_000Oo0O_.00o.("RibbonTab", array3(j), False)
										Case RibbonItemTypeEnum.Group
											IL_549:
											num2 = 78
											text4 = o0_.o_000Oo0O_.00o.("RibbonGroup", array3(j), False)
										Case RibbonItemTypeEnum.ToggleGroup
											IL_5FF:
											num2 = 92
											text4 = o0_.o_000Oo0O_.00o.("RibbonToggleGroup", array3(j), False)
										Case RibbonItemTypeEnum.ToolBar
											IL_619:
											num2 = 94
											text4 = o0_.o_000Oo0O_.00o.("RibbonToolBar", array3(j), False)
										Case RibbonItemTypeEnum.Button
											IL_42B:
											num2 = 56
											text4 = o0_.o_000Oo0O_.00o.("RibbonButton", array3(j), False)
										Case RibbonItemTypeEnum.CheckBox
											IL_445:
											num2 = 58
											text4 = o0_.o_000Oo0O_.00o.("RibbonCheckBox", array3(j), False)
										Case RibbonItemTypeEnum.ColorPicker
											IL_45F:
											num2 = 60
											text4 = o0_.o_000Oo0O_.00o.("RibbonColorPicker", array3(j), False)
										Case RibbonItemTypeEnum.ComboBox
											IL_479:
											num2 = 62
											text4 = o0_.o_000Oo0O_.00o.("RibbonComboBox", array3(j), False)
										Case RibbonItemTypeEnum.TextBox
											IL_493:
											num2 = 64
											text4 = o0_.o_000Oo0O_.00o.("RibbonTextBox", array3(j), False)
										Case RibbonItemTypeEnum.FontComboBox
											IL_52F:
											num2 = 76
											text4 = o0_.o_000Oo0O_.00o.("RibbonFontComboBox", array3(j), False)
										Case RibbonItemTypeEnum.Label
											IL_563:
											num2 = 80
											text4 = o0_.o_000Oo0O_.00o.("RibbonLabel", array3(j), False)
										Case RibbonItemTypeEnum.MenuButton
											IL_57D:
											num2 = 82
											text4 = o0_.o_000Oo0O_.00o.("RibbonMenuButton", array3(j), False)
										Case RibbonItemTypeEnum.Separator
											IL_597:
											num2 = 84
											text4 = o0_.o_000Oo0O_.00o.("RibbonSeparator", array3(j), False)
										Case RibbonItemTypeEnum.SplitButton
											IL_5B1:
											num2 = 86
											text4 = o0_.o_000Oo0O_.00o.("RibbonSplitButton", array3(j), False)
										Case RibbonItemTypeEnum.ToggleButton
											IL_5E5:
											num2 = 90
											text4 = o0_.o_000Oo0O_.00o.("RibbonToggleButton", array3(j), False)
										Case RibbonItemTypeEnum.DatePicker
											IL_4E1:
											num2 = 70
											text4 = o0_.o_000Oo0O_.00o.("RibbonDatePicker", array3(j), False)
										Case RibbonItemTypeEnum.NumericBox
											IL_4FB:
											num2 = 72
											text4 = o0_.o_000Oo0O_.00o.("RibbonNumericBox", array3(j), False)
										Case RibbonItemTypeEnum.ProgressBar
											IL_515:
											num2 = 74
											text4 = o0_.o_000Oo0O_.00o.("RibbonProgressBar", array3(j), False)
										Case RibbonItemTypeEnum.Gallery
											IL_633:
											num2 = 96
											text4 = o0_.o_000Oo0O_.00o.("RibbonGallery", array3(j), False)
										Case RibbonItemTypeEnum.TimePicker
											IL_4AD:
											num2 = 66
											text4 = o0_.o_000Oo0O_.00o.("RibbonTimePicker", array3(j), False)
										Case RibbonItemTypeEnum.TrackBar
											IL_4C7:
											num2 = 68
											text4 = o0_.o_000Oo0O_.00o.("RibbonTrackBar", array3(j), False)
										Case Else
											Select Case ribbonItemTypeEnum
												Case RibbonItemTypeEnum.ContextMenu
													IL_64D:
													num2 = 98
													text4 = o0_.o_000Oo0O_.00o.("ContextMenu", array3(j), False)
												Case RibbonItemTypeEnum.ContextCommand
													IL_667:
													num2 = 100
													text4 = o0_.o_000Oo0O_.00o.("ContextCommand", array3(j), False)
												Case RibbonItemTypeEnum.ContextCommandMenu
													IL_681:
													num2 = 102
													text4 = o0_.o_000Oo0O_.00o.("ContextCommandMenu", array3(j), False)
											End Select
									End Select
								Else
									IL_69B:
									num2 = 105
									If Operators.CompareString(A_4, "WinForm", True) = 0 Then
										IL_6AD:
										num2 = 106
										If Conversions.ToInteger(dataRow("Type")) = 229 OrElse Conversions.ToInteger(dataRow("Type")) = 233 Then
											IL_6E0:
											num2 = 107
											text4 = o0_.o_000Oo0O_.00o.("Form", array3(j), False)
										Else
											IL_6F7:
											num2 = 109
											text4 = o0_.o_000Oo0O_.00o.("Control", array3(j), False)
										End If
									Else
										IL_70E:
										num2 = 111
										text4 = o0_.o_000Oo0O_.00o.(A_4, array3(j), False)
									End If
								End If
								IL_720:
								num2 = 112
								Dim num4 As Integer = A_3.Length - 1
								For k As Integer = 0 To num4
									IL_72F:
									num2 = 113
									If Not dataRow.IsNull(A_3(k)) Then
										IL_73F:
										num2 = 114
										If Operators.CompareString(text3, "", True) > 0 Then
											IL_752:
											num2 = 115
											text3 += "_"
										End If
										IL_763:
										num2 = 116
										text3 += Conversions.ToString(dataRow(A_3(k)))
									End If
									IL_77F:
									num2 = 117
								Next
								IL_78E:
								num2 = 118
								If Operators.CompareString(text3, "", True) > 0 Then
									IL_7A4:
									num2 = 119
									If O_O0OO.o_O0.oo_o0oo. Then
										IL_7AE:
										num2 = 120
										If O_O0OO.O0_00o.o0__o..CompileCode AndAlso OoOo0O.Oo_oOO_._Oo_o.(1, 6) = 3 Then
											IL_7C7:
											num2 = 121
											text3 += text3.Substring(1, 1)
										End If
									End If
									IL_7DC:
									num2 = 122
									If flag Then
										IL_7E3:
										num2 = 123
										stringBuilder.Append(String.Concat(New String() { "Public Async Sub ", o0OoOOoOOo0.OO0._Oo0o.(array3(j) + "_" + text3), "(", text4, ")" & vbCrLf }))
									Else
										IL_834:
										num2 = 125
										stringBuilder.Append(String.Concat(New String() { "Public Sub ", o0OoOOoOOo0.OO0._Oo0o.(array3(j) + "_" + text3), "(", text4, ")" & vbCrLf }))
									End If
								Else
									IL_885:
									num2 = 127
									If flag Then
										IL_88C:
										num2 = 128
										stringBuilder.Append(String.Concat(New String() { "Public Async Sub ", o0OoOOoOOo0.OO0._Oo0o.(array3(j)), "(", text4, ")" & vbCrLf }))
									Else
										IL_8D1:
										num2 = 130
										stringBuilder.Append(String.Concat(New String() { "Public Sub ", o0OoOOoOOo0.OO0._Oo0o.(array3(j)), "(", text4, ")" & vbCrLf }))
									End If
								End If
								IL_914:
								num2 = 131
								stringBuilder.Append(text5 + vbCrLf)
								IL_92E:
								num2 = 132
								stringBuilder.Append("End Sub" & vbCrLf)
							End If
							IL_941:
							num2 = 133
						Next
						GoTo IL_956
					End If
					GoTo IL_956
				End While
				IL_96D:
				num2 = 135
				If Operators.CompareString(A_4, "WinForm", True) <> 0 OrElse Not O_O0OO.OoO.0OO__0ooo.().HasChanges() Then
					GoTo IL_9AE
				End If
				IL_98E:
				num2 = 136
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False)
				IL_9AE:
				num2 = 137
				Dim left As String = stringBuilder.ToString()
				IL_9BD:
				num2 = 138
				If Not O_O0OO.o_O0.oo_o0oo. Then
					GoTo IL_9E9
				End If
				IL_9CA:
				num2 = 139
				If Operators.CompareString(left, "", True) <> 0 Then
					GoTo IL_9E9
				End If
				IL_9DF:
				num2 = 140
				result = Nothing
				GoTo IL_A07
				IL_9E9:
				num2 = 141
				result = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), A_5, A_6, False, "", True)
				IL_A07:
				GoTo IL_C91
				IL_A0C:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_C52:
				GoTo IL_C86
				IL_C54:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_C64:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_C54
			End Try
			IL_C86:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_C91:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060046BB RID: 18107 RVA: 0x001CAED4 File Offset: 0x001C90D4
		Friend Function <<EMPTY_NAME>>(A_0 As DataTableProperty, A_1 As String, A_2 As DataTable) As Assembly
			Dim num As Integer
			Dim result As Assembly
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
				Dim properties As PropertyInfo() = A_0.[GetType]().GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
				IL_21:
				num2 = 4
				For Each propertyInfo As PropertyInfo In properties
					IL_36:
					num2 = 5
					If propertyInfo.GetSetMethod() IsNot Nothing AndAlso Not O00OOOo_O0_O.O.0o_0_o.(propertyInfo) Then
						IL_50:
						num2 = 6
						If O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) Then
							IL_5E:
							num2 = 7
							Dim text As String = ""
							IL_67:
							num2 = 8
							Dim eventString As EventString = CType(propertyInfo.GetValue(A_0, Nothing), EventString)
							IL_79:
							num2 = 9
							If eventString IsNot Nothing AndAlso eventString.Count > 0 Then
								IL_8A:
								num2 = 10
								text = eventString(0).Trim()
							End If
							IL_9C:
							num2 = 11
							If Operators.CompareString(text, "", True) <> 0 Then
								IL_B1:
								num2 = 14
								Dim text2 As String = o0_.o_000Oo0O_.00o.("Table", propertyInfo.Name, False)
								IL_C8:
								num2 = 15
								If Operators.CompareString(text, "", True) > 0 Then
									IL_DB:
									num2 = 16
									text = text.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
								End If
								IL_F8:
								num2 = 17
								If text.StartsWith("'''async", StringComparison.OrdinalIgnoreCase) Then
									IL_10A:
									num2 = 18
									stringBuilder.Append(String.Concat(New String() { "Public Async Sub ", propertyInfo.Name, "(", text2, ")" & vbCrLf }))
								Else
									IL_149:
									num2 = 20
									stringBuilder.Append(String.Concat(New String() { "Public Sub ", propertyInfo.Name, "(", text2, ")" & vbCrLf }))
								End If
								IL_186:
								num2 = 21
								stringBuilder.Append(text + vbCrLf)
								IL_19D:
								num2 = 22
								stringBuilder.Append("End Sub" & vbCrLf)
							End If
						End If
					End If
					IL_1AD:
					num2 = 23
				Next
				IL_1C1:
				num2 = 24
				result = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), A_1, A_2, False, "", True)
				IL_1DA:
				GoTo IL_290
				IL_1DF:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_251:
				GoTo IL_285
				IL_253:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_263:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_253
			End Try
			IL_285:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_290:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060046BC RID: 18108 RVA: 0x001CB198 File Offset: 0x001C9398
		Friend Function <<EMPTY_NAME>>(A_0 As ProjectProperty, A_1 As DataTable, A_2 As String, A_3 As String, A_4 As DataTable) As Assembly
			Dim num As Integer
			Dim result As Assembly
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				o0_.O0.oO. = True
				IL_0F:
				num2 = 3
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_18:
				num2 = 4
				Dim properties As PropertyInfo() = A_0.[GetType]().GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
				IL_29:
				num2 = 5
				For Each propertyInfo As PropertyInfo In properties
					IL_3E:
					num2 = 6
					If propertyInfo.GetSetMethod() IsNot Nothing AndAlso Not O00OOOo_O0_O.O.0o_0_o.(propertyInfo) Then
						IL_58:
						num2 = 7
						If O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) Then
							IL_66:
							num2 = 8
							Dim text As String = ""
							IL_6F:
							num2 = 9
							Dim eventString As EventString = CType(propertyInfo.GetValue(A_0, Nothing), EventString)
							IL_82:
							num2 = 10
							If eventString IsNot Nothing AndAlso eventString.Count > 0 Then
								IL_93:
								num2 = 11
								text = eventString(0).Trim()
								IL_A5:
								num2 = 12
								Dim name As String = propertyInfo.Name
								IL_B1:
								num2 = 14
								If Operators.CompareString(name, "AfterOpenProject", True) <> 0 Then
									Operators.CompareString(name, "LoadUserSetting", True)
								End If
							End If
							IL_D1:
							num2 = 15
							If Operators.CompareString(O00.O0o.__O.(propertyInfo.Name), o0_.o_000Oo0O_.00o.(), True) = 0 Then
								IL_ED:
								num2 = 16
								text = o0OoOOoOOo0.OO0._Oo0o.() + vbCrLf + text
							End If
							IL_103:
							num2 = 17
							If Operators.CompareString(text, "", True) <> 0 Then
								IL_118:
								num2 = 20
								Dim text2 As String = o0_.o_000Oo0O_.00o.("Project", propertyInfo.Name, False)
								IL_12F:
								num2 = 21
								text = text.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
								IL_14C:
								num2 = 22
								Dim text3 As String = propertyInfo.Name
								IL_158:
								num2 = 23
								Dim left As String = text3
								IL_15F:
								num2 = 25
								If Operators.CompareString(left, "BeforeConnectOuterDataSource", True) = 0 OrElse Operators.CompareString(left, "BeforeLoadInnerTable", True) = 0 OrElse Operators.CompareString(left, "BeforeLoadOuterTable", True) = 0 OrElse Operators.CompareString(left, "Initialize", True) = 0 OrElse Operators.CompareString(left, "AfterOpenProject", True) = 0 OrElse Operators.CompareString(left, "BeforeOpenProject", True) = 0 OrElse Operators.CompareString(left, "LoadUserSetting", True) = 0 Then
									IL_1CB:
									num2 = 26
									text3 = o0OoOOoOOo0.OO0._Oo0o.(text3)
								Else
									IL_1D9:
									num2 = 28
									If Operators.CompareString(left, o0_.O0.oO., True) = 0 Then
										IL_1EB:
										num2 = 29
										If Not o0OO__.OO0oO.o.() Then
											GoTo IL_2A3
										End If
									End If
								End If
								IL_1F8:
								num2 = 31
								If text.StartsWith("'''async", StringComparison.OrdinalIgnoreCase) Then
									IL_20A:
									num2 = 32
									stringBuilder.Append(String.Concat(New String() { "Public Async Sub ", text3, "(", text2, ")" & vbCrLf }))
								Else
									IL_244:
									num2 = 34
									stringBuilder.Append(String.Concat(New String() { "Public Sub ", text3, "(", text2, ")" & vbCrLf }))
								End If
								IL_27C:
								num2 = 35
								stringBuilder.Append(text + vbCrLf)
								IL_293:
								num2 = 36
								stringBuilder.Append("End Sub" & vbCrLf)
							End If
						End If
					End If
					IL_2A3:
					num2 = 37
				Next
				IL_2B7:
				num2 = 38
				OO_00oOO.MyTimers.Clear()
				IL_2C4:
				num2 = 39
				If stringBuilder.Length <= 0 Then
					GoTo IL_2E1
				End If
				IL_2D1:
				num2 = 40
				stringBuilder.Append(vbCrLf)
				IL_2E1:
				num2 = 41
				Dim array2 As DataRow() = A_1.[Select]("[Type] = " + Conversions.ToString(3))
				IL_2FC:
				num2 = 42
				For Each dataRow As DataRow In array2
					IL_312:
					num2 = 43
					Dim timerProperty As TimerProperty = New TimerProperty()
					IL_31C:
					num2 = 44
					Dim timer As Timer = New Timer()
					IL_326:
					num2 = 45
					If Not dataRow.IsNull("Config") Then
						IL_337:
						num2 = 46
						o_O_o_oOoo__.OOOO_OO._oo.(timerProperty, O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow("Config")), "Timer", A_2), vbVerticalTab)
					End If
					IL_35F:
					num2 = 47
					timer.Name = Conversions.ToString(dataRow("Name"))
					IL_37A:
					num2 = 48
					Dim text4 As String = "Timer_" + timer.Name
					IL_390:
					num2 = 49
					timer.Tag = text4
					IL_39C:
					num2 = 50
					timer.Interval = timerProperty.Interval
					IL_3AD:
					num2 = 51
					timer.Enabled = timerProperty.Enabled
					IL_3BE:
					num2 = 52
					timer.CanPause = timerProperty.CanPause
					IL_3CF:
					num2 = 53
					If timerProperty.Tick IsNot Nothing AndAlso timerProperty.Tick.Count > 0 Then
						IL_3F0:
						num2 = 54
						Dim text5 As String = timerProperty.Tick(0)
						IL_402:
						num2 = 55
						If Operators.CompareString(text5, "", True) > 0 Then
							IL_415:
							num2 = 56
							text5 = text5.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
						End If
						IL_432:
						num2 = 57
						If text5.StartsWith("'''async", StringComparison.OrdinalIgnoreCase) Then
							IL_444:
							num2 = 58
							stringBuilder.Append("Public Async Sub " + text4 + "()" & vbCrLf)
						Else
							IL_462:
							num2 = 60
							stringBuilder.Append("Public Sub " + text4 + "()" & vbCrLf)
						End If
						IL_47E:
						num2 = 61
						stringBuilder.Append(text5 + vbCrLf)
						IL_495:
						num2 = 62
						stringBuilder.Append("End Sub" & vbCrLf)
					End If
					IL_4A5:
					num2 = 63
					OO_00oOO.MyTimers.Add(Conversions.ToString(dataRow("Name")), timer)
					IL_4C5:
					num2 = 64
				Next
				IL_4D9:
				num2 = 65
				Dim assembly As Assembly = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), A_3, A_4, False, A_2, True)
				IL_4F0:
				num2 = 66
				o0_.O0.oO. = False
				IL_4F9:
				num2 = 67
				result = assembly
				IL_4FF:
				GoTo IL_661
				IL_504:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_622:
				GoTo IL_656
				IL_624:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_634:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_624
			End Try
			IL_656:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_661:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060046BD RID: 18109 RVA: 0x001CB82C File Offset: 0x001C9A2C
		Private Function <<EMPTY_NAME>>(A_0 As String) As Assembly
			Dim result As Assembly
			Return result
		End Function

		' Token: 0x060046BE RID: 18110 RVA: 0x001CB83C File Offset: 0x001C9A3C
		Shared Sub New()
			Dim a_ As Integer = 18
			o0_.O0.oO. = O00.DecryptText(O00OOOo_O0_O.b("犯閣覥ﲧ튩쎫龯��醴캹蚽鞿藁ꋃꗅ鋇賉駋뻍鷏뗑ꗓ鿕臗뇛駝", a_), O00OOOo_O0_O.b("욟춡�", a_), O00OOOo_O0_O.b("풟쎡욣쪥춧", a_))
			o0_.oO.0_O. = O00OOOo_O0_O.b("풟톣쾥�좫膭花ﲳ蒵躹풻調胁돃귅ﳇ诉", a_)
			o0_.O0.oO. = RuntimeHelpers.GetObjectValue(New Object())
			o0_.OoOOoO.O_o. = O00OOOo_O0_O.b("잡킣캥잧캩鶭", a_)
			Dim num As Integer
			Dim num17 As Integer
			Dim obj As Object
			Try
				IL_72:
				ProjectData.ClearProjectError()
				num = 1
				IL_79:
				Dim num2 As Integer = 2
				Dim array As Byte() = New Byte() { 1, 2, 3, 4, 5 }
				IL_8D:
				num2 = 3
				Dim num3 As Integer = array.Length
				IL_94:
				num2 = 4
				Dim num4 As Integer = Environment.TickCount Xor num3
				IL_A0:
				num2 = 5
				Dim num5 As UInteger = CUInt(num4)
				IL_A6:
				num2 = 6
				Dim array2 As Byte() = New Byte(255) {}
				IL_B4:
				num2 = 7
				Dim num6 As Integer = 0
				Do
					IL_B9:
					num2 = 8
					Dim num7 As UInteger = CUInt(num6)
					IL_BF:
					num2 = 9
					num7 = num7 * 1103515245UI + 12345UI
					IL_D2:
					num2 = 10
					array2(num6) = CByte((num7 >> 16 And 255UI))
					IL_E6:
					num2 = 11
					num6 += 1
				Loop While num6 <= 255
				IL_F8:
				num2 = 12
				Dim num8 As Integer = num3 - 1
				For i As Integer = 0 To num8
					IL_106:
					num2 = 13
					Dim b As Byte = array(i)
					IL_10F:
					num2 = 14
					Dim b2 As Byte = CByte((CUInt(b) >> 4)) And 15
					IL_11D:
					num2 = 15
					Dim b3 As Byte = b And 15
					IL_128:
					num2 = 16
					Dim b4 As Byte = CByte((b3 << 4)) Or b2
					IL_135:
					num2 = 17
					Dim b5 As Byte = array2(CInt(b4))
					Dim b6 As Byte = array2(CInt(b))
					IL_144:
					num2 = 18
					array(i) = b
					IL_14D:
					num2 = 19
				Next
				IL_15C:
				num2 = 20
				Dim num9 As UInteger = UInteger.MaxValue
				IL_162:
				num2 = 21
				Dim num10 As Integer = num3 - 1
				For j As Integer = 0 To num10
					IL_170:
					num2 = 22
					num9 = num9 Xor CUInt(array(j))
					IL_17C:
					num2 = 23
					Dim num11 As Integer = 0
					Do
						IL_182:
						num2 = 24
						If(CULng(num9) And 1UL) <> 0UL Then
							IL_18D:
							num2 = 25
							num9 = (num9 >> 1 Xor 3988292384UI)
						Else
							IL_19E:
							num2 = 27
							num9 >>= 1
						End If
						IL_1A7:
						num2 = 28
						num11 += 1
					Loop While num11 <= 7
					IL_1B5:
					num2 = 29
				Next
				IL_1C4:
				num2 = 30
				GC.KeepAlive(num9)
				IL_1D3:
				num2 = 31
				Dim num12 As Integer = num3 / 2 - 1
				For k As Integer = 0 To num12
					IL_1E3:
					num2 = 32
					Dim num13 As Integer = num3 - 1 - k
					IL_1EF:
					num2 = 33
					Dim b7 As Byte = array(k)
					IL_1F8:
					num2 = 34
					array(k) = array(num13)
					IL_203:
					num2 = 35
					array(num13) = b7
					IL_20C:
					num2 = 36
					b7 = array(k)
					IL_215:
					num2 = 37
					array(k) = array(num13)
					IL_220:
					num2 = 38
					array(num13) = b7
					IL_229:
					num2 = 39
				Next
				IL_238:
				num2 = 40
				Dim num14 As Long = 0L
				IL_23F:
				num2 = 41
				Dim num15 As Integer = num3 - 1
				For l As Integer = 0 To num15
					IL_24D:
					num2 = 42
					num5 = num5 * 1664525UI + 1013904223UI
					IL_260:
					num2 = 43
					Dim b8 As Byte = CByte((CULng((num5 >> 24)) And 255UL))
					IL_273:
					num2 = 44
					num14 += CLng(CULng((array(l) Xor b8)))
					IL_283:
					num2 = 45
				Next
				IL_292:
				num2 = 46
				GC.KeepAlive(num14)
				IL_2A1:
				GoTo IL_3AF
				IL_2A6:
				Dim num16 As Integer = num17 + 1
				num17 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num16)
				IL_370:
				GoTo IL_3A4
				IL_372:
				num17 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_382:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num17 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_372
			End Try
			IL_3A4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3AF:
			If num17 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060046BF RID: 18111 RVA: 0x001CBC1C File Offset: 0x001C9E1C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As DataTable, Optional A_3 As Boolean = False, Optional A_4 As String = "", Optional A_5 As Boolean = True) As Assembly
			Dim num As Integer
			Dim result As Assembly
			Dim num6 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(A_0, "", True) <> 0 Then
					GoTo IL_AD
				End If
				IL_1A:
				num2 = 3
				Dim text As String = O_O0OO.o.00O_O.() + "Bin\Foxtable.Blank.dll"
				IL_2D:
				num2 = 4
				If Not OO_00oOO.FileSys.FileExists(A_1) Then
					GoTo IL_49
				End If
				IL_3C:
				num2 = 5
				OO_00oOO.FileSys.DeleteFile(A_1)
				IL_49:
				num2 = 6
				If OO_00oOO.FileSys.FileExists(text) Then
					GoTo IL_70
				End If
				IL_59:
				num2 = 7
				o0_.Oo_0.OOo0oO0.("    ", text, Nothing, False, "", True)
				IL_70:
				num2 = 8
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_91
				End If
				IL_81:
				num2 = 9
				OO_00oOO.FileSys.CopyFile(text, A_1)
				IL_91:
				num2 = 10
				Dim rawAssembly As Byte() = File.ReadAllBytes(text)
				IL_9D:
				num2 = 11
				result = Assembly.Load(rawAssembly)
				GoTo IL_AF8
				IL_AD:
				num2 = 13
				If Operators.CompareString(A_4, "", True) <> 0 OrElse Operators.CompareString(A_0.Trim(), "", True) <= 0 OrElse A_3 Then
					GoTo IL_E0
				End If
				IL_D6:
				num2 = 14
				A_4 = O_O0OO.O_O._Oo.()
				IL_E0:
				num2 = 15
				Dim vbcodeProvider As VBCodeProvider = New VBCodeProvider()
				IL_EA:
				num2 = 16
				Dim compilerParameters As CompilerParameters = New CompilerParameters()
				IL_F4:
				num2 = 17
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_FE:
				num2 = 18
				stringBuilder.Append("Option Strict Off" & vbCrLf)
				IL_10E:
				num2 = 19
				stringBuilder.Append("Option Compare Text" & vbCrLf)
				IL_11E:
				num2 = 20
				If OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "Bin\TempFiles") Then
					GoTo IL_158
				End If
				IL_13C:
				num2 = 21
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "Bin\TempFiles")
				IL_158:
				num2 = 22
				compilerParameters.TempFiles = New TempFileCollection(OO_00oOO.ProjectPath + "Bin\TempFiles", True)
				IL_177:
				num2 = 23
				For Each text2 As String In SysInfo.spaceNames.Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
					IL_1A6:
					num2 = 24
					Dim array2 As String() = text2.Split(New Char() { "("c, ")"c }, StringSplitOptions.RemoveEmptyEntries)
					IL_1C3:
					num2 = 25
					If Not array2(0).StartsWith("'") Then
						IL_1D6:
						num2 = 27
						If array2.Length = 1 Then
							IL_1E0:
							num2 = 28
							stringBuilder.Append("Imports " + array2(0) + vbCrLf)
						Else
							IL_200:
							num2 = 30
							stringBuilder.Append(String.Concat(New String() { "Imports ", array2(1), " = ", array2(0), vbCrLf }))
						End If
					End If
					IL_23C:
					num2 = 31
				Next
				IL_250:
				num2 = 32
				If A_2 Is Nothing Then
					GoTo IL_373
				End If
				IL_259:
				num2 = 33
				Dim dataRow As DataRow = A_2.Rows.Find(New Object() { "Space", o0_O.oo0o_OoO_.Oo. })
				IL_281:
				num2 = 34
				If dataRow Is Nothing OrElse dataRow.IsNull("Config") Then
					GoTo IL_373
				End If
				IL_29C:
				num2 = 35
				Dim array3 As String() = dataRow("Config").ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_2C8:
				num2 = 36
				Dim num3 As Integer = array3.Length - 1
				For j As Integer = 0 To num3
					IL_2DB:
					num2 = 37
					Dim array4 As String() = array3(j).Split(New Char() { "("c, ")"c }, StringSplitOptions.RemoveEmptyEntries)
					IL_2FB:
					num2 = 38
					If array4.Length = 1 Then
						IL_305:
						num2 = 39
						stringBuilder.Append("Imports " + array4(0) + vbCrLf)
					Else
						IL_325:
						num2 = 41
						stringBuilder.Append(String.Concat(New String() { "Imports ", array4(1), " = ", array4(0), vbCrLf }))
					End If
					IL_361:
					num2 = 42
				Next
				IL_373:
				num2 = 43
				stringBuilder.Append(SysInfo.ImportsStrings + vbCrLf)
				IL_38D:
				num2 = 44
				stringBuilder.Append("Public Module UserCode" & vbCrLf)
				IL_39D:
				num2 = 45
				stringBuilder.Append(A_0 + vbCrLf)
				IL_3B3:
				num2 = 46
				stringBuilder.Append("End Module")
				IL_3C3:
				num2 = 47
				Dim compilerParameters2 As CompilerParameters = compilerParameters
				IL_3CA:
				num2 = 48
				compilerParameters2.GenerateExecutable = False
				IL_3D5:
				num2 = 49
				compilerParameters2.IncludeDebugInformation = False
				IL_3E0:
				num2 = 50
				For Each text3 As String In SysInfo.referFiles.Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
					IL_40F:
					num2 = 51
					If text3.StartsWith("System.", StringComparison.CurrentCultureIgnoreCase) Then
						IL_421:
						num2 = 52
						compilerParameters2.ReferencedAssemblies.Add(text3)
					Else
						IL_438:
						num2 = 54
						If Operators.CompareString(text3, "Office.dll", True) = 0 OrElse Operators.CompareString(text3, "Neodynamic.WinControls.BarcodeProfessional.dll", True) = 0 OrElse Operators.CompareString(text3, "Microsoft.Office.Interop.Excel.dll", True) = 0 Then
							IL_468:
							num2 = 55
							If Not o_O_o_oOoo__.OOOO_OO._oo.() Then
								IL_475:
								num2 = 56
								compilerParameters2.ReferencedAssemblies.Add(O_O0OO.o.00O_O.() + text3)
							End If
						Else
							IL_493:
							num2 = 58
							If Operators.CompareString(text3, O00.DecryptText("gjA/WO8lyyoZND23CfLzDLMGOObohTz0LwbTD2GaXMs=", "table", "grid"), True) = 0 Then
								IL_4B4:
								num2 = 59
								If Operators.CompareString(O_O0OO.O0_00o.o0__o..oO00o00_0.O., "", True) > 0 Then
									IL_4CF:
									num2 = 60
									text3 = O_O0OO.O0_00o.o0__o..oO00o00_0.O. + ".exe"
								End If
							End If
							IL_4E8:
							num2 = 61
							compilerParameters2.ReferencedAssemblies.Add(O_O0OO.o.00O_O.() + text3)
						End If
					End If
					IL_504:
					num2 = 62
				Next
				IL_518:
				num2 = 63
				If A_3 OrElse Operators.CompareString(A_4, "", True) <= 0 Then
					GoTo IL_686
				End If
				IL_534:
				num2 = 64
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_562
				End If
				IL_546:
				num2 = 65
				Dim text4 As String = OO_00oOO.FileSys.GetParentPath(A_1) + "\"
				GoTo IL_576
				IL_562:
				num2 = 67
				text4 = OO_00oOO.ProjectPath + "Bin\"
				IL_576:
				num2 = 68
				If Operators.CompareString(text4, O_O0OO.o.00O_O.() + "Bin\", True) = 0 Then
					GoTo IL_686
				End If
				IL_595:
				num2 = 69
				If Operators.CompareString(A_1, "", True) <> 0 Then
					GoTo IL_5BC
				End If
				IL_5A6:
				num2 = 70
				Dim text5 As String = OO_00oOO.FileSys.GetName(OO_00oOO.ProjectFile)
				GoTo IL_5CC
				IL_5BC:
				num2 = 72
				text5 = OO_00oOO.FileSys.GetName(A_1)
				IL_5CC:
				num2 = 73
				text5 = text5.Substring(0, text5.IndexOf("."))
				IL_5E5:
				num2 = 74
				text5 = text4 + text5 + ".Public.dll"
				IL_5F8:
				num2 = 75
				If OO_00oOO.FileSys.FileExists(text5) Then
					GoTo IL_674
				End If
				IL_609:
				num2 = 76
				Dim a_ As String = o0_.o_000Oo0O_.00o.(A_2, "")
				IL_619:
				num2 = 77
				o0_.Oo_0.OOo0oO0.(a_, text5, Nothing, True, "", True)
				IL_62E:
				num2 = 78
				O_O0OO.O0_00o.o0__o..AsmAPICrcString = O00.CRCCheckFile(text5)
				IL_642:
				num2 = 79
				If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
					GoTo IL_674
				End If
				IL_657:
				num2 = 80
				O_O0OO.O0_00o.o0__o..o0Oo.Oo_0oO0o. = True
				IL_665:
				num2 = 81
				O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
				IL_674:
				num2 = 82
				compilerParameters2.ReferencedAssemblies.Add(text5)
				IL_686:
				num2 = 83
				If A_2 Is Nothing Then
					GoTo IL_786
				End If
				IL_68F:
				num2 = 84
				Dim dataRow2 As DataRow = A_2.Rows.Find(New Object() { "Refrence", o0_O.oOO0.oO0O0__. })
				IL_6B7:
				num2 = 85
				If dataRow2 Is Nothing OrElse dataRow2.IsNull("Config") Then
					GoTo IL_786
				End If
				IL_6D2:
				num2 = 86
				Dim array6 As String() = dataRow2("Config").ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_6FE:
				num2 = 87
				Dim num4 As Integer = array6.Length - 1
				For l As Integer = 0 To num4
					IL_70E:
					num2 = 88
					If array6(l).StartsWith("System.", StringComparison.CurrentCultureIgnoreCase) Then
						IL_723:
						num2 = 89
						compilerParameters2.ReferencedAssemblies.Add(array6(l))
					Else
						IL_73A:
						num2 = 91
						If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + array6(l)) Then
							IL_758:
							num2 = 92
							compilerParameters2.ReferencedAssemblies.Add(O_O0OO.o.00O_O.() + array6(l))
						End If
					End If
					IL_777:
					num2 = 93
				Next
				IL_786:
				num2 = 94
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_7E2
				End If
				IL_798:
				num2 = 95
				compilerParameters2.OutputAssembly = A_1
				IL_7A3:
				num2 = 96
				compilerParameters2.GenerateInMemory = False
				IL_7AE:
				num2 = 97
				If OO_00oOO.FileSys.DirectoryExists(OO_00oOO.FileSys.GetParentPath(A_1)) Then
					GoTo IL_7ED
				End If
				IL_7C8:
				num2 = 98
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.FileSys.GetParentPath(A_1))
				GoTo IL_7ED
				IL_7E2:
				num2 = 100
				compilerParameters2.GenerateInMemory = True
				IL_7ED:
				compilerParameters2 = Nothing
				IL_7F0:
				num2 = 102
				Dim o0.oO. As Object = o0_.O0.oO.
				ObjectFlowControl.CheckForSyncLockOnValueType(o0.oO.)
				Dim compilerResults As CompilerResults
				SyncLock o0.oO.
					Dim a_2 As Boolean = OO_00oOO.SystemReady
					OO_00oOO.SystemReady = False
					compilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, New String() { stringBuilder.ToString() })
					OO_00oOO.SystemReady = a_2
				End SyncLock
				IL_84A:
				num2 = 103
				If Not compilerResults.Errors.HasErrors Then
					GoTo IL_A32
				End If
				IL_85E:
				num2 = 104
				If A_5 Then
					GoTo IL_898
				End If
				IL_865:
				num2 = 105
				result = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
				GoTo IL_AF8
				IL_898:
				num2 = 106
				Dim text6 As String = ""
				IL_8A2:
				num2 = 107
				Dim enumerator As IEnumerator = compilerResults.Errors.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim compilerError As CompilerError = CType(obj, CompilerError)
					IL_8C6:
					num2 = 108
					If Not compilerError.IsWarning Then
						IL_8D2:
						num2 = 110
						text6 = text6 + "编译错误:" + compilerError.ErrorText + vbCrLf & vbCrLf
						IL_8EF:
						num2 = 111
						Dim textBox As TextBox = New TextBox()
						IL_8F9:
						num2 = 112
						textBox.Text = stringBuilder.ToString()
						IL_90A:
						num2 = 113
						text6 = vbCrLf + text6 + "错误代码：" + textBox.Lines(compilerError.Line - 1).Trim()
						Exit While
					End If
					IL_938:
					num2 = 115
				End While
				IL_947:
				num2 = 116
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_95F:
				num2 = 117
				text6 = text6.Replace("Foxtable.", "").Trim()
				IL_97A:
				num2 = 118
				If Operators.CompareString(text6, "", True) <= 0 Then
					GoTo IL_9A5
				End If
				IL_98D:
				num2 = 119
				MessageBox.Show(text6, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				GoTo IL_A25
				IL_9A5:
				num2 = 121
				If Not o_O_o_oOoo__.OOOO_OO._oo.() Then
					GoTo IL_A0C
				End If
				IL_9AF:
				num2 = 122
				MessageBox.Show("本机的.NET Framework 2.0版本过低，无法正常编译代码，建议升级到.NET Framework 2.0 SP2。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_9C5:
				num2 = 123
				Dim text7 As String = O_O0OO.o.00O_O.() + "downloadnetsp2.htm"
				IL_9D9:
				num2 = 124
				If Not OO_00oOO.FileSys.FileExists(text7) Then
					GoTo IL_A25
				End If
				IL_9EA:
				num2 = 125
				Dim process As Process = New Process()
				IL_9F4:
				num2 = 126
				process.File = text7
				IL_A00:
				num2 = 127
				process.Start()
				GoTo IL_A25
				IL_A0C:
				num2 = 129
				MessageBox.Show("未知编译错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				IL_A25:
				num2 = 130
				result = Nothing
				GoTo IL_AF8
				IL_A32:
				num2 = 131
				Dim enumerator2 As IEnumerator = compilerResults.TempFiles.GetEnumerator()
				While enumerator2.MoveNext()
					Dim value As Object = enumerator2.Current
					Dim text8 As String = Conversions.ToString(value)
					IL_A56:
					num2 = 132
					If Operators.CompareString(Path.GetExtension(text8), ".vb", True) = 0 Then
						IL_A70:
						num2 = 133
						OO_00oOO.FileSys.DeleteFile(text8)
					End If
					IL_A82:
					num2 = 134
				End While
				IL_A91:
				num2 = 135
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_AAC:
				num2 = 136
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_AE0
				End If
				IL_AC1:
				num2 = 137
				Dim rawAssembly2 As Byte() = File.ReadAllBytes(A_1)
				IL_ACF:
				num2 = 138
				Dim assembly As Assembly = Assembly.Load(rawAssembly2)
				GoTo IL_AEF
				IL_AE0:
				num2 = 140
				assembly = compilerResults.CompiledAssembly
				IL_AEF:
				num2 = 141
				result = assembly
				IL_AF8:
				GoTo IL_D82
				IL_AFD:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_D43:
				GoTo IL_D77
				IL_D45:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_D55:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_D45
			End Try
			IL_D77:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_D82:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060046C0 RID: 18112 RVA: 0x001CC9E8 File Offset: 0x001CABE8
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, Optional A_1 As String = "") As String
			Dim text As String = ""
			For Each dataRow As DataRow In A_0.[Select]("[Type] = " + Conversions.ToString(19))
				If Not dataRow.IsNull("Config") AndAlso Operators.CompareString(dataRow("Name").ToString(), A_1, True) <> 0 Then
					Dim text2 As String = O_O0OO.o0_OO.000.(A_0.DataSet)
					Dim text3 As String = dataRow("Config").ToString()
					If text3.StartsWith("[") AndAlso text3.EndsWith("]") Then
						text3 = text3.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })
						text2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., text2.Substring(0, 5)).Substring(0, 5)
					ElseIf text3.StartsWith("{") AndAlso text3.EndsWith("}") Then
						text3 = text3.TrimStart(New Char() { "{"c }).TrimEnd(New Char() { "}"c })
						text2 = text2.Substring(0, 5)
					End If
					text3 = O00.oO_.0o_oo_0O_.(text3, "API", text2)
					text = text + vbCrLf + text3
				End If
			Next
			Return text
		End Function

		' Token: 0x060046C1 RID: 18113 RVA: 0x001CCB40 File Offset: 0x001CAD40
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, Optional A_2 As Boolean = False) As String
			Dim text As String = o0_.o_000Oo0O_.00o.(A_0, A_1)
			Dim result As String
			If Operators.CompareString(text, "", True) > 0 Then
				If A_2 Then
					result = text
				Else
					result = "ByVal e As " + text
				End If
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x060046C2 RID: 18114 RVA: 0x001CCB80 File Offset: 0x001CAD80
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
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
				If Operators.CompareString(A_0, "Form", True) <> 0 OrElse (Operators.CompareString(A_1, "SizeChanged", True) <> 0 AndAlso Operators.CompareString(A_1, "AfterShow", True) <> 0) Then
					GoTo IL_3C
				End If
				IL_33:
				num2 = 3
				A_1 = "AfterLoad"
				IL_3C:
				num2 = 4
				If Operators.CompareString(A_0, "Control", True) <> 0 Then
					GoTo IL_738
				End If
				IL_4F:
				num2 = 5
				Dim left As String = A_1
				IL_54:
				num2 = 7
				If Operators.CompareString(left, "RetrieveVirtualRow", True) <> 0 AndAlso Operators.CompareString(left, "BeforeDragRow", True) <> 0 AndAlso Operators.CompareString(left, "RowSelectionChanged", True) <> 0 AndAlso Operators.CompareString(left, "RowChecking", True) <> 0 AndAlso Operators.CompareString(left, "RowChecked", True) <> 0 Then
					GoTo IL_AE
				End If
				IL_A1:
				num2 = 8
				result = "ListViewRowEventArgs"
				GoTo IL_E7C
				IL_AE:
				num2 = 10
				If Operators.CompareString(left, "BeforeDropRow", True) <> 0 Then
					GoTo IL_CE
				End If
				IL_C0:
				num2 = 11
				result = "DropListViewRowEventArgs"
				GoTo IL_E7C
				IL_CE:
				num2 = 13
				If Operators.CompareString(left, "RowActivate", True) <> 0 Then
					GoTo IL_EE
				End If
				IL_E0:
				num2 = 14
				result = "ControlEventArgs"
				GoTo IL_E7C
				IL_EE:
				num2 = 16
				If Operators.CompareString(left, "BeforeEdit", True) <> 0 AndAlso Operators.CompareString(left, "AfterEdit", True) <> 0 Then
					GoTo IL_11D
				End If
				IL_10F:
				num2 = 17
				result = "ListViewEditEventArgs"
				GoTo IL_E7C
				IL_11D:
				num2 = 19
				If Operators.CompareString(left, "DrawViewCell", True) <> 0 Then
					GoTo IL_13D
				End If
				IL_12F:
				num2 = 20
				result = "ListViewDrawCellEventArgs"
				GoTo IL_E7C
				IL_13D:
				num2 = 22
				If Operators.CompareString(left, "DataFormat", True) <> 0 Then
					GoTo IL_15D
				End If
				IL_14F:
				num2 = 23
				result = "FormattingEventArgs"
				GoTo IL_E7C
				IL_15D:
				num2 = 25
				If Operators.CompareString(left, "DataParse", True) <> 0 Then
					GoTo IL_17D
				End If
				IL_16F:
				num2 = 26
				result = "ParsingEventArgs"
				GoTo IL_E7C
				IL_17D:
				num2 = 28
				If Operators.CompareString(left, "AfterCollapseNode", True) <> 0 Then
					GoTo IL_19D
				End If
				IL_18F:
				num2 = 29
				result = "TreeViewEventArgs"
				GoTo IL_E7C
				IL_19D:
				num2 = 31
				If Operators.CompareString(left, "GaugeItemClick", True) <> 0 AndAlso Operators.CompareString(left, "GaugeItemDoubleClick", True) <> 0 AndAlso Operators.CompareString(left, "GaugeItemStateChanged", True) <> 0 AndAlso Operators.CompareString(left, "GaugeItemMouseEnter", True) <> 0 AndAlso Operators.CompareString(left, "GaugeItemMouseLeave", True) <> 0 Then
					GoTo IL_1F9
				End If
				IL_1EB:
				num2 = 32
				result = "GaugeItemEventArgs"
				GoTo IL_E7C
				IL_1F9:
				num2 = 34
				If Operators.CompareString(left, "GaugeItemMouseMove", True) <> 0 AndAlso Operators.CompareString(left, "GaugeItemMouseDown", True) <> 0 AndAlso Operators.CompareString(left, "GaugeItemMouseUp", True) <> 0 Then
					GoTo IL_237
				End If
				IL_229:
				num2 = 35
				result = "GaugeItemMouseEventArgs"
				GoTo IL_E7C
				IL_237:
				num2 = 37
				If Operators.CompareString(left, "PointerDragMove", True) <> 0 AndAlso Operators.CompareString(left, "PointerDragCancel", True) <> 0 AndAlso Operators.CompareString(left, "PointerDragBegin", True) <> 0 AndAlso Operators.CompareString(left, "PointerDragEnd", True) <> 0 Then
					GoTo IL_284
				End If
				IL_276:
				num2 = 38
				result = "GaugePointerDragEventArgs"
				GoTo IL_E7C
				IL_284:
				num2 = 40
				If Operators.CompareString(left, "GaugeFormatLabel", True) <> 0 Then
					GoTo IL_2A4
				End If
				IL_296:
				num2 = 41
				result = "GaugeFormatLabelEventArgs"
				GoTo IL_E7C
				IL_2A4:
				num2 = 43
				If Operators.CompareString(left, "GaugePointerValueChanged", True) <> 0 Then
					GoTo IL_2C4
				End If
				IL_2B6:
				num2 = 44
				result = "GaugePointerValueChangedEventArgs"
				GoTo IL_E7C
				IL_2C4:
				num2 = 46
				If Operators.CompareString(left, "GannttStripItemClik", True) <> 0 Then
					GoTo IL_2E4
				End If
				IL_2D6:
				num2 = 47
				result = "GannttStripItemClikEventArgs"
				GoTo IL_E7C
				IL_2E4:
				num2 = 49
				If Operators.CompareString(left, "BeforeEditTask", True) <> 0 AndAlso Operators.CompareString(left, "AfterEditTask", True) <> 0 AndAlso Operators.CompareString(left, "BeforeRemoveTask", True) <> 0 AndAlso Operators.CompareString(left, "BeforeAddTask", True) <> 0 Then
					GoTo IL_331
				End If
				IL_323:
				num2 = 50
				result = "GanttTaskEventArgs"
				GoTo IL_E7C
				IL_331:
				num2 = 52
				If Operators.CompareString(left, "BeforeMoveTasks", True) <> 0 Then
					GoTo IL_351
				End If
				IL_343:
				num2 = 53
				result = "GanttTasksEventArgs"
				GoTo IL_E7C
				IL_351:
				num2 = 55
				If Operators.CompareString(left, "TaskBarTooltip", True) <> 0 Then
					GoTo IL_371
				End If
				IL_363:
				num2 = 56
				result = "GanttTaskBarTooltipEventArgs"
				GoTo IL_E7C
				IL_371:
				num2 = 58
				If Operators.CompareString(left, "TaskBarClick", True) <> 0 Then
					GoTo IL_391
				End If
				IL_383:
				num2 = 59
				result = "GanttTaskBarClickEventArgs"
				GoTo IL_E7C
				IL_391:
				num2 = 61
				If Operators.CompareString(left, "PaintDay", True) <> 0 Then
					GoTo IL_3B1
				End If
				IL_3A3:
				num2 = 62
				result = "GanttPaintDayEventArgs"
				GoTo IL_E7C
				IL_3B1:
				num2 = 64
				If Operators.CompareString(left, "ChartClick", True) <> 0 AndAlso Operators.CompareString(left, "ChartDoubleClick", True) <> 0 AndAlso Operators.CompareString(left, "ChartMouseHover", True) <> 0 Then
					GoTo IL_3EF
				End If
				IL_3E1:
				num2 = 65
				result = "ChartEventArgs"
				GoTo IL_E7C
				IL_3EF:
				num2 = 67
				If Operators.CompareString(left, "GetMapTile", True) <> 0 Then
					GoTo IL_40F
				End If
				IL_401:
				num2 = 68
				result = "GetMapTileEventArgs"
				GoTo IL_E7C
				IL_40F:
				num2 = 70
				If Operators.CompareString(left, "GetVirtualItems", True) <> 0 Then
					GoTo IL_42F
				End If
				IL_421:
				num2 = 71
				result = "GetVirtualItemsEventArgs"
				GoTo IL_E7C
				IL_42F:
				num2 = 73
				If Operators.CompareString(left, "OwerDrawMark", True) <> 0 AndAlso Operators.CompareString(left, "GetDrawingBounds", True) <> 0 Then
					GoTo IL_45E
				End If
				IL_450:
				num2 = 74
				result = "OwerDrawMarkEventArgs"
				GoTo IL_E7C
				IL_45E:
				num2 = 76
				If Operators.CompareString(left, "ChartMouseDown", True) <> 0 AndAlso Operators.CompareString(left, "ChartMouseUp", True) <> 0 AndAlso Operators.CompareString(left, "ChartMouseMove", True) <> 0 Then
					GoTo IL_49C
				End If
				IL_48E:
				num2 = 77
				result = "ChartMouseEventArgs"
				GoTo IL_E7C
				IL_49C:
				num2 = 79
				If Operators.CompareString(left, "ChartShowTooltip", True) <> 0 Then
					GoTo IL_4BC
				End If
				IL_4AE:
				num2 = 80
				result = "ChartToolTipEventArgs"
				GoTo IL_E7C
				IL_4BC:
				num2 = 82
				If Operators.CompareString(left, "MouseClick", True) <> 0 Then
					GoTo IL_4DC
				End If
				IL_4CE:
				num2 = 83
				result = "ControlMouseEventArgs"
				GoTo IL_E7C
				IL_4DC:
				num2 = 85
				If Operators.CompareString(left, "CenterChanged", True) <> 0 AndAlso Operators.CompareString(left, "ZoomChanged", True) <> 0 Then
					GoTo IL_50B
				End If
				IL_4FD:
				num2 = 86
				result = "ControlEventArgs"
				GoTo IL_E7C
				IL_50B:
				num2 = 88
				If Operators.CompareString(left, "InitializationCompleted", True) <> 0 Then
					GoTo IL_52B
				End If
				IL_51D:
				num2 = 89
				result = "InitializationCompletedEventArgs"
				GoTo IL_E7C
				IL_52B:
				num2 = 91
				If Operators.CompareString(left, "NavigationStarting", True) <> 0 Then
					GoTo IL_54B
				End If
				IL_53D:
				num2 = 92
				result = "NavigationStartingEventArgs"
				GoTo IL_E7C
				IL_54B:
				num2 = 94
				If Operators.CompareString(left, "NavigationCompleted", True) <> 0 Then
					GoTo IL_56B
				End If
				IL_55D:
				num2 = 95
				result = "NavigationCompletedEventArgs"
				GoTo IL_E7C
				IL_56B:
				num2 = 97
				If Operators.CompareString(left, "SourceChanged", True) <> 0 Then
					GoTo IL_58B
				End If
				IL_57D:
				num2 = 98
				result = "SourceChangedEventArgs"
				GoTo IL_E7C
				IL_58B:
				num2 = 100
				If Operators.CompareString(left, "ContextMenuRequested", True) <> 0 Then
					GoTo IL_5AB
				End If
				IL_59D:
				num2 = 101
				result = "ContextMenuRequestedEventArgs"
				GoTo IL_E7C
				IL_5AB:
				num2 = 103
				If Operators.CompareString(left, "DOMContentLoaded", True) <> 0 Then
					GoTo IL_5CB
				End If
				IL_5BD:
				num2 = 104
				result = "DOMContentLoadedEventArgs"
				GoTo IL_E7C
				IL_5CB:
				num2 = 106
				If Operators.CompareString(left, "ContentLoading", True) <> 0 Then
					GoTo IL_5EB
				End If
				IL_5DD:
				num2 = 107
				result = "ContentLoadingEventArgs"
				GoTo IL_E7C
				IL_5EB:
				num2 = 109
				If Operators.CompareString(left, "ZoomFactorChanged", True) <> 0 AndAlso Operators.CompareString(left, "HistoryChanged", True) <> 0 Then
					GoTo IL_61A
				End If
				IL_60C:
				num2 = 110
				result = "ControlEventArgs"
				GoTo IL_E7C
				IL_61A:
				num2 = 112
				If Operators.CompareString(left, "WebMessageReceived", True) <> 0 Then
					GoTo IL_63A
				End If
				IL_62C:
				num2 = 113
				result = "WebMessageReceivedEventArgs"
				GoTo IL_E7C
				IL_63A:
				num2 = 115
				If Operators.CompareString(left, "NewWindowRequested", True) <> 0 Then
					GoTo IL_65A
				End If
				IL_64C:
				num2 = 116
				result = "NewWindowRequestedEventArgs"
				GoTo IL_E7C
				IL_65A:
				num2 = 118
				If Operators.CompareString(left, "WebResourceRequested", True) <> 0 Then
					GoTo IL_67A
				End If
				IL_66C:
				num2 = 119
				result = "WebResourceRequestedEventArgs"
				GoTo IL_E7C
				IL_67A:
				num2 = 121
				If Operators.CompareString(left, "WebResourceResponseReceived", True) <> 0 Then
					GoTo IL_69A
				End If
				IL_68C:
				num2 = 122
				result = "WebResourceResponseReceivedEventArgs"
				GoTo IL_E7C
				IL_69A:
				num2 = 124
				If Operators.CompareString(left, "StatusBarTextChanged", True) <> 0 Then
					GoTo IL_6BA
				End If
				IL_6AC:
				num2 = 125
				result = "ControlEventArgs"
				GoTo IL_E7C
				IL_6BA:
				num2 = 127
				If Operators.CompareString(left, "ScriptDialogOpening", True) <> 0 Then
					GoTo IL_6DD
				End If
				IL_6CC:
				num2 = 128
				result = "ScriptDialogOpeningEventArgs"
				GoTo IL_E7C
				IL_6DD:
				num2 = 130
				If Operators.CompareString(left, "DownloadStarting", True) <> 0 Then
					GoTo IL_703
				End If
				IL_6F2:
				num2 = 131
				result = "DownloadStartingEventArgs"
				GoTo IL_E7C
				IL_703:
				num2 = 133
				If Operators.CompareString(left, "DownloadStateChanged", True) <> 0 AndAlso Operators.CompareString(left, "DownloadProgressChanged", True) <> 0 Then
					GoTo IL_738
				End If
				IL_727:
				num2 = 134
				result = "DownloadStateChangedEventArgs"
				GoTo IL_E7C
				IL_738:
				num2 = 135
				If Operators.CompareString(A_0, "Project", True) <> 0 Then
					GoTo IL_BBB
				End If
				IL_74F:
				num2 = 136
				Dim left2 As String = A_1
				IL_758:
				num2 = 138
				If Operators.CompareString(left2, "Server_UserLogging", True) <> 0 Then
					GoTo IL_77E
				End If
				IL_76D:
				num2 = 139
				result = "Server_UserLoggingEventArgs"
				GoTo IL_E7C
				IL_77E:
				num2 = 141
				If Operators.CompareString(left2, "Server_UserLogged", True) <> 0 Then
					GoTo IL_7A4
				End If
				IL_793:
				num2 = 142
				result = "Server_UserEventArgs"
				GoTo IL_E7C
				IL_7A4:
				num2 = 144
				If Operators.CompareString(left2, "Server_UserLogout", True) <> 0 Then
					GoTo IL_7CA
				End If
				IL_7B9:
				num2 = 145
				result = "Server_UserLogoutEventArgs"
				GoTo IL_E7C
				IL_7CA:
				num2 = 147
				If Operators.CompareString(left2, "Server_ReceivedMessage", True) <> 0 Then
					GoTo IL_7F0
				End If
				IL_7DF:
				num2 = 148
				result = "Server_MessageEventargs"
				GoTo IL_E7C
				IL_7F0:
				num2 = 150
				If Operators.CompareString(left2, "Server_UserChangePassword", True) <> 0 Then
					GoTo IL_816
				End If
				IL_805:
				num2 = 151
				result = "Server_ChangeUserPasswordEventArgs"
				GoTo IL_E7C
				IL_816:
				num2 = 153
				If Operators.CompareString(left2, "Server_WeMessageReceived", True) <> 0 Then
					GoTo IL_83C
				End If
				IL_82B:
				num2 = 154
				result = "WeChatMessageReceived"
				GoTo IL_E7C
				IL_83C:
				num2 = 156
				If Operators.CompareString(left2, "Client_BuddyLogin", True) <> 0 Then
					GoTo IL_862
				End If
				IL_851:
				num2 = 157
				result = "Client_BuddyLoginEventArgs"
				GoTo IL_E7C
				IL_862:
				num2 = 159
				If Operators.CompareString(left2, "Client_BuddyLogout", True) <> 0 Then
					GoTo IL_888
				End If
				IL_877:
				num2 = 160
				result = "Client_BuddyLogoutEventArgs"
				GoTo IL_E7C
				IL_888:
				num2 = 162
				If Operators.CompareString(left2, "Client_ReceivedMessage", True) <> 0 Then
					GoTo IL_8AE
				End If
				IL_89D:
				num2 = 163
				result = "Client_MessageEventargs"
				GoTo IL_E7C
				IL_8AE:
				num2 = 165
				If Operators.CompareString(left2, "Disconnected", True) <> 0 Then
					GoTo IL_8D4
				End If
				IL_8C3:
				num2 = 166
				result = "Client_LogoutEventArgs"
				GoTo IL_E7C
				IL_8D4:
				num2 = 168
				If Operators.CompareString(left2, "Client_UserChangePassword", True) <> 0 Then
					GoTo IL_8FA
				End If
				IL_8E9:
				num2 = 169
				result = "Client_ChangeUserPasswordEventArgs"
				GoTo IL_E7C
				IL_8FA:
				num2 = 171
				If Operators.CompareString(left2, "Connected", True) <> 0 Then
					GoTo IL_920
				End If
				IL_90F:
				num2 = 172
				result = "Client_UserEventArgs"
				GoTo IL_E7C
				IL_920:
				num2 = 174
				If Operators.CompareString(left2, "Client_AfterSendFile", True) <> 0 AndAlso Operators.CompareString(left2, "Server_AfterSendFile", True) <> 0 Then
					GoTo IL_955
				End If
				IL_944:
				num2 = 175
				result = "AfterSendFileEventArgs"
				GoTo IL_E7C
				IL_955:
				num2 = 177
				If Operators.CompareString(left2, "Client_AfterReveiveFile", True) <> 0 AndAlso Operators.CompareString(left2, "Server_AfterReveiveFile", True) <> 0 Then
					GoTo IL_98A
				End If
				IL_979:
				num2 = 178
				result = "AfterReceiveFileEventArgs"
				GoTo IL_E7C
				IL_98A:
				num2 = 180
				If Operators.CompareString(left2, "Client_WeMessageReceived", True) <> 0 Then
					GoTo IL_9B0
				End If
				IL_99F:
				num2 = 181
				result = "weMessageReceived"
				GoTo IL_E7C
				IL_9B0:
				num2 = 183
				If Operators.CompareString(left2, "Client_NewWeChatUser", True) <> 0 Then
					GoTo IL_9D6
				End If
				IL_9C5:
				num2 = 184
				result = "NewWeChatUser"
				GoTo IL_E7C
				IL_9D6:
				num2 = 186
				If Operators.CompareString(left2, "BeforeShowMenu", True) <> 0 Then
					GoTo IL_9FC
				End If
				IL_9EB:
				num2 = 187
				result = "OpenQQMenuEventArgs"
				GoTo IL_E7C
				IL_9FC:
				num2 = 189
				If Operators.CompareString(left2, "CustomMenuClick", True) <> 0 Then
					GoTo IL_A22
				End If
				IL_A11:
				num2 = 190
				result = "CustomMenuClickEventArgs"
				GoTo IL_E7C
				IL_A22:
				num2 = 192
				If Operators.CompareString(left2, "UDPClient_ReceivedMessage", True) <> 0 Then
					GoTo IL_A48
				End If
				IL_A37:
				num2 = 193
				result = "UDPClient_MessageReceived"
				GoTo IL_E7C
				IL_A48:
				num2 = 195
				If Operators.CompareString(left2, "HttpRequest", True) <> 0 AndAlso Operators.CompareString(left2, "BeforeHttpRequest", True) <> 0 Then
					GoTo IL_A7D
				End If
				IL_A6C:
				num2 = 196
				result = "RequestEventArgs"
				GoTo IL_E7C
				IL_A7D:
				num2 = 198
				If Operators.CompareString(left2, "BeforeRename", True) <> 0 AndAlso Operators.CompareString(left2, "AfterRename", True) <> 0 Then
					GoTo IL_AB2
				End If
				IL_AA1:
				num2 = 199
				result = "FTPRenameEventArgs"
				GoTo IL_E7C
				IL_AB2:
				num2 = 201
				If Operators.CompareString(left2, "BeforeDelete", True) <> 0 AndAlso Operators.CompareString(left2, "AfterDelete", True) <> 0 Then
					GoTo IL_AE7
				End If
				IL_AD6:
				num2 = 202
				result = "FTPDeleteEventargs"
				GoTo IL_E7C
				IL_AE7:
				num2 = 204
				If Operators.CompareString(left2, "BeforeEnterFolder", True) <> 0 AndAlso Operators.CompareString(left2, "BeforeCreateFolder", True) <> 0 AndAlso Operators.CompareString(left2, "AfterCreateFolder", True) <> 0 Then
					GoTo IL_B2B
				End If
				IL_B1A:
				num2 = 205
				result = "FTPFolderEventArgs"
				GoTo IL_E7C
				IL_B2B:
				num2 = 207
				If Operators.CompareString(left2, "BeforeDownload", True) <> 0 AndAlso Operators.CompareString(left2, "AfterDownload", True) <> 0 Then
					GoTo IL_B60
				End If
				IL_B4F:
				num2 = 208
				result = "FTPDownloadEventArgs"
				GoTo IL_E7C
				IL_B60:
				num2 = 210
				If Operators.CompareString(left2, "BeforeUpload", True) <> 0 AndAlso Operators.CompareString(left2, "AfterUpload", True) <> 0 Then
					GoTo IL_B95
				End If
				IL_B84:
				num2 = 211
				result = "FTPUploadEventArgs"
				GoTo IL_E7C
				IL_B95:
				num2 = 213
				If Operators.CompareString(left2, "BeforeListDetails", True) <> 0 Then
					GoTo IL_BBB
				End If
				IL_BAA:
				num2 = 214
				result = "FTPBeforeListDetailsEventArgs"
				GoTo IL_E7C
				IL_BBB:
				num2 = 215
				If Operators.CompareString(A_0, "Table", True) <> 0 AndAlso Operators.CompareString(A_0, "Project", True) <> 0 Then
					GoTo IL_C9E
				End If
				IL_BE0:
				num2 = 216
				If Operators.CompareString(A_1, "TableAllowEditChanged", True) <> 0 AndAlso Operators.CompareString(A_1, "BeforeUnhideColumn", True) <> 0 Then
					GoTo IL_C13
				End If
				IL_C02:
				num2 = 217
				result = "TableEventArgs"
				GoTo IL_E7C
				IL_C13:
				num2 = 218
				If Operators.CompareString(A_1, "Click", True) <> 0 AndAlso Operators.CompareString(A_1, "DoubleClick", True) <> 0 AndAlso Operators.CompareString(A_1, "DoubleClickRowHeader", True) <> 0 Then
					GoTo IL_C54
				End If
				IL_C43:
				num2 = 219
				result = "CellClickEventArgs"
				GoTo IL_E7C
				IL_C54:
				num2 = 220
				If Operators.CompareString(A_1, "MouseHoverCell", True) <> 0 Then
					GoTo IL_C79
				End If
				IL_C68:
				num2 = 221
				result = "MouseHoverCellEventArgs"
				GoTo IL_E7C
				IL_C79:
				num2 = 222
				If Operators.CompareString(A_1, "AfterSaveDataRow", True) <> 0 Then
					GoTo IL_C9E
				End If
				IL_C8D:
				num2 = 223
				result = "UpdateRowEventArgs"
				GoTo IL_E7C
				IL_C9E:
				num2 = 224
				If Operators.CompareString(A_0, "RibbonGallery", True) <> 0 Then
					GoTo IL_CC3
				End If
				IL_CB2:
				num2 = 225
				result = "RibbonGalleryEventArgs"
				GoTo IL_E7C
				IL_CC3:
				num2 = 227
				If Operators.CompareString(A_0, "RibbonTrackBar", True) <> 0 Then
					GoTo IL_CE8
				End If
				IL_CD7:
				num2 = 228
				result = "RibbonTrackBarEventArgs"
				GoTo IL_E7C
				IL_CE8:
				num2 = 230
				If Operators.CompareString(A_0, "RibbonTimePicker", True) <> 0 Then
					GoTo IL_D0D
				End If
				IL_CFC:
				num2 = 231
				result = "RibbonTimePickerEventArgs"
				GoTo IL_E7C
				IL_D0D:
				num2 = 232
				If Operators.CompareString(A_0, "Form", True) <> 0 Then
					GoTo IL_E2B
				End If
				IL_D24:
				num2 = 233
				Dim left3 As String = A_1
				IL_D2D:
				num2 = 235
				If Operators.CompareString(left3, "ItemClick", True) <> 0 AndAlso Operators.CompareString(left3, "ItemSelectedIndexChanged", True) <> 0 AndAlso Operators.CompareString(left3, "ItemEnter", True) <> 0 AndAlso Operators.CompareString(left3, "ItemLeave", True) <> 0 AndAlso Operators.CompareString(left3, "ItemMouseEnter", True) <> 0 AndAlso Operators.CompareString(left3, "ItemMouseLeave", True) <> 0 AndAlso Operators.CompareString(left3, "ItemMouseHover", True) <> 0 Then
					GoTo IL_DAD
				End If
				IL_D9C:
				num2 = 236
				result = "StripItemEventArgs"
				GoTo IL_E7C
				IL_DAD:
				num2 = 238
				If Operators.CompareString(left3, "DataFormat", True) <> 0 Then
					GoTo IL_DD3
				End If
				IL_DC2:
				num2 = 239
				result = "FormattingEventArgs"
				GoTo IL_E7C
				IL_DD3:
				num2 = 241
				If Operators.CompareString(left3, "DataParse", True) <> 0 Then
					GoTo IL_DF9
				End If
				IL_DE8:
				num2 = 242
				result = "ParsingEventArgs"
				GoTo IL_E7C
				IL_DF9:
				num2 = 244
				If Operators.CompareString(left3, "ResizingControl", True) <> 0 AndAlso Operators.CompareString(left3, "ResizingFont", True) <> 0 Then
					GoTo IL_E2B
				End If
				IL_E1D:
				num2 = 245
				result = "ControlEventArgs"
				GoTo IL_E7C
				IL_E2B:
				num2 = 246
				If o0_.o_000Oo0O_.00o. IsNot Nothing Then
					GoTo IL_E59
				End If
				IL_E38:
				num2 = 247
				o0_.o_000Oo0O_.00o. = New Table.Oo_0O0o_()
				IL_E48:
				num2 = 248
				o0_.o_000Oo0O_.00o..o_Oo.0o0oo__o.()
				IL_E59:
				num2 = 249
				result = o0_.o_000Oo0O_.00o..o_Oo.0o0oo__o.(A_0, A_1).Trim(New Char(0) {}).Trim()
				IL_E7C:
				GoTo IL_12B6
				IL_E81:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1277:
				GoTo IL_12AB
				IL_1279:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1289:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1279
			End Try
			IL_12AB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_12B6:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060046C3 RID: 18115 RVA: 0x001CDE68 File Offset: 0x001CC068
		Private Function <<EMPTY_NAME>>() As String
			Return "1ZU9/5j/Mx7bGNZYTZuqfg=="
		End Function

		' Token: 0x04001CF0 RID: 7408
		Friend <<EMPTY_NAME>> As Table.Oo_0O0o_

		' Token: 0x04001CF1 RID: 7409
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001CF2 RID: 7410
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001CF3 RID: 7411
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001CF4 RID: 7412
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001CF5 RID: 7413
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001CF6 RID: 7414
		Private <<EMPTY_NAME>> As Object

		' Token: 0x04001CF7 RID: 7415
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001CF8 RID: 7416
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001CF9 RID: 7417
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001CFA RID: 7418
		Private <<EMPTY_NAME>> As Integer
	End Module
End Namespace
