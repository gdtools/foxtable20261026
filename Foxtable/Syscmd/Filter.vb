Imports System
Imports System.Collections
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Syscmd
	' Token: 0x0200052C RID: 1324
	Public NotInheritable Module Filter
		' Token: 0x06005759 RID: 22361 RVA: 0x00227444 File Offset: 0x00225644
		<oO0oooo("0126")>
		Public Sub Advanced()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					Dim enumerator As IEnumerator = Application.OpenForms.GetEnumerator()
					While enumerator.MoveNext()
						If TypeOf CType(enumerator.Current, Form)Is ef Then
							Return
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				New ef(OO_00oOO.CurrentTable) With { .Owner = Main.OO_O.o. }.Show()
			End If
		End Sub

		' Token: 0x0600575A RID: 22362 RVA: 0x002274C4 File Offset: 0x002256C4
		<oO0oooo("0126")>
		Public Sub Equal(Optional Current As Boolean = True)
			If Current Then
				Filter.oo_0o_.___o0O.(" = ")
				Return
			End If
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsString() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.等于)
					Return
				End If
				If col.IsNumeric() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.等于)
					Return
				End If
				If col.IsDate() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.等于)
				End If
			End If
		End Sub

		' Token: 0x0600575B RID: 22363 RVA: 0x00227560 File Offset: 0x00225760
		Public Sub Unequal(Optional Current As Boolean = True)
			If Current Then
				Filter.oo_0o_.___o0O.(" <> ")
				Return
			End If
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsString() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.不等于)
					Return
				End If
				If col.IsNumeric() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不等于)
					Return
				End If
				If col.IsDate() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不等于)
				End If
			End If
		End Sub

		' Token: 0x0600575C RID: 22364 RVA: 0x002275FC File Offset: 0x002257FC
		Public Sub MoreThan(Optional Current As Boolean = True)
			If Current Then
				Filter.oo_0o_.___o0O.(" > ")
				Return
			End If
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsNumeric() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.大于)
					Return
				End If
				If col.IsDate() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.晚于)
				End If
			End If
		End Sub

		' Token: 0x0600575D RID: 22365 RVA: 0x00227688 File Offset: 0x00225888
		Public Sub NotMoreThan(Optional Current As Boolean = True)
			If Current Then
				Filter.oo_0o_.___o0O.(" <= ")
				Return
			End If
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsNumeric() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不大于)
					Return
				End If
				If col.IsDate() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不晚于)
				End If
			End If
		End Sub

		' Token: 0x0600575E RID: 22366 RVA: 0x00227714 File Offset: 0x00225914
		Public Sub LessThan(Optional Current As Boolean = True)
			If Current Then
				Filter.oo_0o_.___o0O.(" < ")
				Return
			End If
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsNumeric() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.小于)
					Return
				End If
				If col.IsDate() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.早于)
				End If
			End If
		End Sub

		' Token: 0x0600575F RID: 22367 RVA: 0x002277A0 File Offset: 0x002259A0
		Public Sub NotLessThan(Optional Current As Boolean = True)
			If Current Then
				Filter.oo_0o_.___o0O.(" >= ")
				Return
			End If
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsNumeric() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不小于)
					Return
				End If
				If col.IsDate() Then
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不早于)
				End If
			End If
		End Sub

		' Token: 0x06005760 RID: 22368 RVA: 0x0022782C File Offset: 0x00225A2C
		Public Sub FilterByQuarter(Quarter As Integer)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim dateTime As DateTime = Conversions.ToDate(table.Value)
				Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
				Dim a_ As DateTime = DateAndTime.DateSerial(dateTime.Year, Quarter * 3 - 2, 1)
				Dim a_2 As DateTime = DateAndTime.DateSerial(dateTime.Year, Quarter * 3, DateTime.DaysInMonth(dateTime.Year, Quarter * 3)).AddDays(1.0)
				Filter.O0O0o.Oo0OO_oO.(table, name, a_, a_2, False)
			End If
		End Sub

		' Token: 0x06005761 RID: 22369 RVA: 0x002278E0 File Offset: 0x00225AE0
		Friend Sub <<EMPTY_NAME>>(A_0 As Table, A_1 As String, A_2 As DateTime, A_3 As DateTime, Optional A_4 As Boolean = False)
			Dim flag As Boolean = Oo00.O____0O._0.(A_0)
			Dim text As String = ""
			Dim a_ As String = String.Concat(New String() { "FilterDateBetween" & vbVerticalTab, A_0.Name, vbVerticalTab, A_1, vbVerticalTab, Conversions.ToString(A_2), vbVerticalTab, Conversions.ToString(A_3), vbVerticalTab, Conversions.ToString(A_4) })
			Dim text2 As String = ""
			If flag Then
				If Operators.CompareString(A_0.DataTable.LoadFilter, "", True) > 0 Then
					text = "(" + A_0.DataTable.LoadFilter + ") And "
				End If
			ElseIf Operators.CompareString(A_0.View.get_Filter(), "", True) > 0 Then
				text = "(" + A_0.Filter + ") And "
			End If
			A_0.ClearEditInfos()
			Dim text3 As String = Strings.Format(A_2, "MM/dd/yyyy HH:mm:ss")
			Dim text4 As String = Strings.Format(A_3, "MM/dd/yyyy HH:mm:ss")
			Dim text5 As String
			If flag Then
				text5 = Oo00.OoOo_oo_.o_o.(A_1, A_0)
			Else
				text5 = "[" + A_1 + "]"
			End If
			If flag Then
				If A_0.DataTable.SourceType = 1 Then
					text2 = String.Concat(New String() { text5, " >= #", text3, "# And ", text5, "  < #", text4, "#" })
				ElseIf A_0.DataTable.SourceType = 2 Then
					text2 = String.Concat(New String() { text5, " >= '", text3, "' And ", text5, "  < '", text4, "'" })
				ElseIf A_0.DataTable.SourceType = 3 Then
					text2 = String.Concat(New String() { text5, " >= TO_DATE('", text3, "', 'MM/DD/YYYY HH24:MI:SS') And ", text5, "  < TO_DATE('", text4, "', 'MM/DD/YYYY HH24:MI:SS')" })
				End If
				If A_4 Then
					text2 = "Not (" + text2 + ")"
				End If
				text += text2
				A_0.DataTable.OOO_o_O.OO0o.(text, a_)
				A_0.DataTable.LoadPage = 0
				A_0.DataTable.o0.o.(True, Nothing)
				If A_0.O.OoOo_. IsNot Nothing AndAlso A_0.O.OoOo_..FindForm() IsNot Nothing Then
					A_0.O.OoOo_..oO.Oo0__O_.()
					Return
				End If
			Else
				text2 = String.Concat(New String() { text2, text5, " >= #", text3, "# And ", text5, "  < #", text4, "#" })
				If A_4 Then
					text2 = "Not (" + text2 + ")"
				End If
				text += text2
				A_0.Filter = text
			End If
		End Sub

		' Token: 0x06005762 RID: 22370 RVA: 0x00227BD8 File Offset: 0x00225DD8
		Friend Sub <<EMPTY_NAME>>(A_0 As Table, A_1 As String, Optional A_2 As Boolean = True)
			Dim flag As Boolean = Oo00.O____0O._0.(A_0)
			Dim a_ As String = String.Concat(New String() { "FilterByExpression" & vbVerticalTab, A_0.Name, vbVerticalTab, A_1, vbVerticalTab, Conversions.ToString(A_2) })
			A_0.ClearEditInfos()
			If flag Then
				Dim a_2 As String
				If Operators.CompareString(A_0.DataTable.LoadFilter, "", True) > 0 Then
					If A_2 Then
						a_2 = String.Concat(New String() { "(", A_0.DataTable.LoadFilter, ") And (", A_1, ")" })
					ElseIf Operators.CompareString(A_0.DataTable.OOOOO._., "", True) > 0 Then
						a_2 = String.Concat(New String() { "(", A_0.DataTable.OOOOO._., ") And (", A_1, ")" })
					Else
						a_2 = A_1
					End If
				Else
					a_2 = A_1
				End If
				A_0.DataTable.LoadPage = 0
				A_0.DataTable.OOO_o_O.OO0o.(a_2, a_)
				A_0.DataTable.o0.o.(True, Nothing)
				If A_0.O.OoOo_. IsNot Nothing AndAlso A_0.O.OoOo_..FindForm() IsNot Nothing Then
					A_0.O.OoOo_..oO.Oo0__O_.()
					Return
				End If
			Else
				Dim a_2 As String
				If Operators.CompareString(A_0.View.get_Filter(), "", True) > 0 AndAlso A_2 Then
					a_2 = String.Concat(New String() { "(", A_0.Filter, ") And (", A_1, ")" })
				Else
					a_2 = A_1
				End If
				A_0.Filter = a_2
			End If
		End Sub

		' Token: 0x06005763 RID: 22371 RVA: 0x00227D88 File Offset: 0x00225F88
		Public Sub FilterByMonth(Month As Integer)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Oo00.O____0O._0.(table)
				Dim dateTime As DateTime = Conversions.ToDate(table.Value)
				Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
				Dim a_ As DateTime = DateAndTime.DateSerial(dateTime.Year, Month, 1)
				Dim a_2 As DateTime = DateAndTime.DateSerial(dateTime.Year, Month, DateTime.DaysInMonth(dateTime.Year, Month)).AddDays(1.0)
				Filter.O0O0o.Oo0OO_oO.(table, name, a_, a_2, False)
			End If
		End Sub

		' Token: 0x06005764 RID: 22372 RVA: 0x00227E3C File Offset: 0x0022603C
		<oO0oooo("0123")>
		Public Sub FilterBoolean(Value As Boolean)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
				Dim flag As Boolean = Oo00.O____0O._0.(table)
				Dim text As String
				If flag Then
					text = Oo00.OoOo_oo_.o_o.(name, table)
				Else
					text = "[" + name + "]"
				End If
				Dim a_ As String
				If Value Then
					If flag Then
						If table.DataTable.SourceType = 1 Then
							a_ = text + " = True"
						Else
							a_ = text + " = 1"
						End If
					Else
						a_ = text + " = True"
					End If
				ElseIf flag Then
					If table.DataTable.SourceType = 1 Then
						a_ = String.Concat(New String() { "(", text, " = False Or ", text, " Is Null)" })
					Else
						a_ = String.Concat(New String() { "(", text, " = 0 Or ", text, " Is Null)" })
					End If
				Else
					a_ = String.Concat(New String() { "(", text, " = False Or ", text, " Is Null)" })
				End If
				Filter.O0O0o.Oo0OO_oO.(table, a_, True)
			End If
		End Sub

		' Token: 0x06005765 RID: 22373 RVA: 0x00227FB8 File Offset: 0x002261B8
		<oO0oooo("0125")>
		Public Sub LockStatusFilter(Locked As Boolean)
			Dim table As Table = OO_00oOO.CurrentTable
			Dim text As String = ""
			Dim text2 As String = ""
			If table IsNot Nothing Then
				Dim text3 As String
				If Oo00.O____0O._0.(table) AndAlso table.DataTable.O000_00._0_o. Then
					If table.DataTable.SourceType = 1 Then
						text = "([_Locked] = True)"
						text2 = "([_Locked] = False Or [_Locked] Is Null)"
					ElseIf table.DataTable.SourceType = 2 Then
						text = "([_Locked] = 1)"
						text2 = "([_Locked] = 0 Or [_Locked] Is Null)"
					ElseIf table.DataTable.SourceType = 3 Then
						text = "(""_Locked"" = 1)"
						text2 = "(""_Locked"" = False Or ""_Locked"" Is Null)"
					End If
					text3 = table.DataTable.LoadFilter
				Else
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(table.DataTable.frd_Connection) Then
						text = "([_Locked] IS NOT NULL)"
						text2 = "([_Locked] IS NULL)"
					Else
						text = "([_Locked] = True)"
						text2 = "([_Locked] = False Or [_Locked] Is Null)"
					End If
					text3 = table.View.get_Filter()
				End If
				If Operators.CompareString(text3, "", True) > 0 Then
					If text3.IndexOf("[_Locked]", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						If Locked Then
							If text3.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
								Return
							End If
							text3 = ShareLibriay.ReplaceIgnoreCase(text3, text2, text)
						Else
							If text3.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
								Return
							End If
							text3 = ShareLibriay.ReplaceIgnoreCase(text3, text, text2)
						End If
					ElseIf Locked Then
						text3 = text3 + " And " + text
					Else
						text3 = text3 + " And " + text2
					End If
				ElseIf Locked Then
					text3 = text
				Else
					text3 = text2
				End If
				If table.DataTable.O000_00._0_o. Then
					Filter.O0O0o.Oo0OO_oO.(table, text3, False)
					Return
				End If
				table.ClearEditInfos()
				table.Filter = text3
			End If
		End Sub

		' Token: 0x06005766 RID: 22374 RVA: 0x0022812C File Offset: 0x0022632C
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim text As String = ""
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
				Dim col As Col = table.Cols(name)
				If table.foxGrid.Rows(table.foxGrid.Row).DataIndex <> -1 Then
					Dim dataRowView As DataRowView = CType(table.foxGrid.Rows(table.foxGrid.Row).DataSource, DataRowView)
					Dim flag As Boolean = Oo00.O____0O._0.(table)
					Dim text2 As String
					If flag Then
						text2 = Oo00.OoOo_oo_.o_o.(name, table)
					Else
						text2 = "[" + name + "]"
					End If
					If dataRowView.Row.IsNull(name) Then
						If Operators.CompareString(A_0.Trim(), "=", True) = 0 Then
							text = text2 + " Is Null"
						Else
							text = text2 + " Is Not Null"
						End If
					Else
						Dim text3 As String = dataRowView(name).ToString()
						If col.IsString() Then
							text = String.Concat(New String() { text2, A_0, "'", text3.Replace("'", "''"), "'" })
						ElseIf col.IsNumeric() Then
							text = text2 + A_0 + text3
						ElseIf col.IsDate() Then
							If flag Then
								If table.DataTable.SourceType = 1 Then
									text = String.Concat(New String() { text2, A_0, "#", text3, "#" })
								ElseIf table.DataTable.SourceType = 2 Then
									text = String.Concat(New String() { text2, A_0, "'", text3, "'" })
								ElseIf table.DataTable.SourceType = 3 Then
									Dim text4 As String = Strings.Format(Conversions.ToDate(text3), "MM/dd/yyyy HH:mm:ss")
									text = String.Concat(New String() { text2, " ", A_0, " TO_DATE('", text4, "', 'MM/DD/YYYY HH24:MI:SS')" })
								End If
							Else
								text = String.Concat(New String() { text2, A_0, "#", text3, "#" })
							End If
						End If
						If Operators.CompareString(A_0, " <> ", True) = 0 Then
							text = String.Concat(New String() { "(", text, " Or ", text2, " Is Null)" })
						End If
					End If
					Filter.O0O0o.Oo0OO_oO.(table, text, True)
				End If
			End If
		End Sub

		' Token: 0x06005767 RID: 22375 RVA: 0x00228424 File Offset: 0x00226624
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
				If table.foxGrid.Rows(table.foxGrid.Row).DataIndex <> -1 Then
					Dim dataRowView As DataRowView = CType(table.foxGrid.Rows(table.foxGrid.Row).DataSource, DataRowView)
					Dim flag As Boolean = Oo00.O____0O._0.(table)
					If dataRowView.Row.IsNull(name) Then
						Dim str As String
						If flag Then
							str = Oo00.OoOo_oo_.o_o.(name, table)
						Else
							str = "[" + name + "]"
						End If
						Filter.O0O0o.Oo0OO_oO.(table, str + " Is Null", True)
						Return
					End If
					Dim dateValue As DateTime = Conversions.ToDate(dataRowView(name))
					Dim dateTime As DateTime
					Dim a_ As DateTime
					If Operators.CompareString(A_0, "Y", True) = 0 Then
						dateTime = DateAndTime.DateSerial(dateValue.Year, 1, 1)
						a_ = DateAndTime.DateAdd(DateInterval.Year, 1.0, dateTime)
					ElseIf Operators.CompareString(A_0, "Q", True) = 0 Then
						dateTime = DateAndTime.DateSerial(dateValue.Year, DateAndTime.DatePart(DateInterval.Quarter, dateValue, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) * 3 - 2, 1)
						a_ = DateAndTime.DateAdd(DateInterval.Month, 3.0, dateTime)
					ElseIf Operators.CompareString(A_0, "M", True) = 0 Then
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, 1)
						a_ = DateAndTime.DateAdd(DateInterval.Month, 1.0, dateTime)
					ElseIf Operators.CompareString(A_0, "W", True) = 0 Then
						dateValue = dateValue.[Date]
						If dateValue.DayOfWeek = DayOfWeek.Sunday Then
							dateTime = DateAndTime.DateAdd(DateInterval.Day, -6.0, dateValue)
						Else
							dateTime = DateAndTime.DateAdd(DateInterval.Day, CDbl((-CDbl(dateValue.DayOfWeek) + 1)), dateValue)
						End If
						a_ = DateAndTime.DateAdd(DateInterval.Day, 7.0, dateTime)
					ElseIf Operators.CompareString(A_0, "D", True) = 0 Then
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day)
						a_ = DateAndTime.DateAdd(DateInterval.Day, 1.0, dateTime)
					ElseIf Operators.CompareString(A_0, "H", True) = 0 Then
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day)
						dateTime = DateAndTime.DateAdd(DateInterval.Hour, CDbl(dateValue.Hour), dateTime)
						a_ = DateAndTime.DateAdd(DateInterval.Hour, 1.0, dateTime)
					ElseIf Operators.CompareString(A_0, "N", True) = 0 Then
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day)
						dateTime = DateAndTime.DateAdd(DateInterval.Hour, CDbl(dateValue.Hour), dateTime)
						dateTime = DateAndTime.DateAdd(DateInterval.Minute, CDbl(dateValue.Minute), dateTime)
						a_ = DateAndTime.DateAdd(DateInterval.Minute, 1.0, dateTime)
					ElseIf Operators.CompareString(A_0, "S", True) = 0 Then
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day)
						dateTime = DateAndTime.DateAdd(DateInterval.Hour, CDbl(dateValue.Hour), dateTime)
						dateTime = DateAndTime.DateAdd(DateInterval.Minute, CDbl(dateValue.Minute), dateTime)
						dateTime = DateAndTime.DateAdd(DateInterval.Second, CDbl(dateValue.Second), dateTime)
						a_ = DateAndTime.DateAdd(DateInterval.Second, 1.0, dateTime)
					End If
					Filter.O0O0o.Oo0OO_oO.(table, name, dateTime, a_, False)
				End If
			End If
		End Sub

		' Token: 0x06005768 RID: 22376 RVA: 0x002287A7 File Offset: 0x002269A7
		Public Sub SameYear()
			Filter.oo0Oo0Oo.OO.("Y")
		End Sub

		' Token: 0x06005769 RID: 22377 RVA: 0x002287B3 File Offset: 0x002269B3
		Public Sub SameQuarter()
			Filter.oo0Oo0Oo.OO.("Q")
		End Sub

		' Token: 0x0600576A RID: 22378 RVA: 0x002287BF File Offset: 0x002269BF
		Public Sub SameMonth()
			Filter.oo0Oo0Oo.OO.("M")
		End Sub

		' Token: 0x0600576B RID: 22379 RVA: 0x002287CB File Offset: 0x002269CB
		Public Sub SameDay()
			Filter.oo0Oo0Oo.OO.("D")
		End Sub

		' Token: 0x0600576C RID: 22380 RVA: 0x002287D7 File Offset: 0x002269D7
		Public Sub SameWeek()
			Filter.oo0Oo0Oo.OO.("W")
		End Sub

		' Token: 0x0600576D RID: 22381 RVA: 0x002287E3 File Offset: 0x002269E3
		Public Sub SameHour()
			Filter.oo0Oo0Oo.OO.("H")
		End Sub

		' Token: 0x0600576E RID: 22382 RVA: 0x002287EF File Offset: 0x002269EF
		Public Sub SameMinute()
			Filter.oo0Oo0Oo.OO.("N")
		End Sub

		' Token: 0x0600576F RID: 22383 RVA: 0x002287FB File Offset: 0x002269FB
		Public Sub SameSecond()
			Filter.oo0Oo0Oo.OO.("S")
		End Sub

		' Token: 0x06005770 RID: 22384 RVA: 0x00228808 File Offset: 0x00226A08
		<oO0oooo("0118")>
		Public Sub Values()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso Not table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name).IsBoolean() Then
				New oo\u3000\u30000\u3002\u3000o\u3002(table, table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)).ShowDialog()
			End If
		End Sub

		' Token: 0x06005771 RID: 22385 RVA: 0x00228888 File Offset: 0x00226A88
		<oO0oooo("0127")>
		Public Sub Expression()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				New o\u3000\u3002\u3002\u3002\u3002\u3002O\u3000\u3000\u3000\u3002\u3000(table).ShowDialog()
			End If
		End Sub

		' Token: 0x06005772 RID: 22386 RVA: 0x002288AC File Offset: 0x00226AAC
		Public Sub UnFilter()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				table.ClearEditInfos()
				If table.DataTable.InBackEndFilterMode Then
					table.DataTable.o0o_ooOOo0.OO.()
					Return
				End If
				table.Filter = ""
				table.StateFilter = 0
			End If
		End Sub

		' Token: 0x06005773 RID: 22387 RVA: 0x002288F3 File Offset: 0x00226AF3
		Public Sub StartsWith()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.开头是)
		End Sub

		' Token: 0x06005774 RID: 22388 RVA: 0x002288FB File Offset: 0x00226AFB
		Public Sub NotStartsWith()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.开头不是)
		End Sub

		' Token: 0x06005775 RID: 22389 RVA: 0x00228903 File Offset: 0x00226B03
		Public Sub EndsWith()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.结尾是)
		End Sub

		' Token: 0x06005776 RID: 22390 RVA: 0x0022890B File Offset: 0x00226B0B
		Public Sub NotEndsWith()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.结尾不是)
		End Sub

		' Token: 0x06005777 RID: 22391 RVA: 0x00228914 File Offset: 0x00226B14
		Public Sub Contains()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.包含)
		End Sub

		' Token: 0x06005778 RID: 22392 RVA: 0x0022891C File Offset: 0x00226B1C
		Public Sub NotContains()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.不包含)
		End Sub

		' Token: 0x06005779 RID: 22393 RVA: 0x00228924 File Offset: 0x00226B24
		Public Sub [Like]()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.类似)
		End Sub

		' Token: 0x0600577A RID: 22394 RVA: 0x0022892C File Offset: 0x00226B2C
		Public Sub NotLike()
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.不类似)
		End Sub

		' Token: 0x0600577B RID: 22395 RVA: 0x00228934 File Offset: 0x00226B34
		Public Sub Between()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsNumeric() Then
					New o\u3000\u30020\u3000(table, col, False).ShowDialog()
					Return
				End If
				If col.IsDate() Then
					New o\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3002\u3002\u3002(table, col, False).ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x0600577C RID: 22396 RVA: 0x002289C0 File Offset: 0x00226BC0
		Public Sub NotBetween()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsNumeric() Then
					New o\u3000\u30020\u3000(table, col, True).ShowDialog()
					Return
				End If
				If col.IsDate() Then
					New o\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3002\u3002\u3002(table, col, True).ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x0600577D RID: 22397 RVA: 0x00228A4C File Offset: 0x00226C4C
		<oO0oooo("1478")>
		Public Sub HideSameValues()
			Filter.O0O0o.Oo0OO_oO.(0)
		End Sub

		' Token: 0x0600577E RID: 22398 RVA: 0x00228A54 File Offset: 0x00226C54
		<oO0oooo("1478")>
		Public Sub ShowRedundantValues()
			Filter.O0O0o.Oo0OO_oO.(1)
		End Sub

		' Token: 0x0600577F RID: 22399 RVA: 0x00228A5C File Offset: 0x00226C5C
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				Dim backFilter As Boolean = Oo00.O____0O._0.(table)
				If table.View.Count > 1 Then
					table.ClearEditInfos()
					Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
					table.RepeatFilter(name, A_0 + 1, backFilter)
				End If
			End If
		End Sub

		' Token: 0x06005780 RID: 22400 RVA: 0x00228ABC File Offset: 0x00226CBC
		<oO0oooo("1478")>
		Public Sub ShowSameValues()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				Dim backFilter As Boolean = Oo00.O____0O._0.(table)
				If table.View.Count > 1 Then
					Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
					table.RepeatFilter(name, 0, backFilter)
				End If
			End If
		End Sub

		' Token: 0x06005781 RID: 22401 RVA: 0x00228B14 File Offset: 0x00226D14
		<oO0oooo("1478")>
		Public Sub ShowUnqiueValues()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				Dim backFilter As Boolean = Oo00.O____0O._0.(table)
				If table.View.Count > 1 Then
					Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
					table.RepeatFilter(name, 3, backFilter)
				End If
			End If
		End Sub

		' Token: 0x06005782 RID: 22402 RVA: 0x00228B6B File Offset: 0x00226D6B
		<oO0oooo("1479")>
		Public Sub RelationFilter()
			If O_O0OO.OOOo.oo_OOOO_0.().Tables.Count > 1 Then
				New oO0\u3002().ShowDialog()
			End If
		End Sub

		' Token: 0x06005783 RID: 22403 RVA: 0x00228B8C File Offset: 0x00226D8C
		Private Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsString() Then
					New O\u3000\u3002\u3000o\u3002\u3002(table, col, A_0).ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x06005784 RID: 22404 RVA: 0x00228C04 File Offset: 0x00226E04
		Private Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsNumeric() Then
					New O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002(table, col, A_0).ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x06005785 RID: 22405 RVA: 0x00228C7C File Offset: 0x00226E7C
		Private Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim col As Col = table.Cols(table.foxGrid.Cols(table.foxGrid.Col).Name)
				If col.IsDate() Then
					New O\u3002\u3000\u3002\u3000\u3002\u3000\u3000(table, col, A_0).ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x06005786 RID: 22406 RVA: 0x00228CF4 File Offset: 0x00226EF4
		<oO0oooo("0112")>
		Public Sub StateFilter(Value As StateFilterEnum)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				table.ClearEditInfos()
				table.StateFilter = Value
			End If
		End Sub

		' Token: 0x06005787 RID: 22407 RVA: 0x00228D18 File Offset: 0x00226F18
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim text As String = ""
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
				Dim name As String = table.foxGrid.Cols(table.foxGrid.Col).Name
				Dim str As String
				If Oo00.O____0O._0.(table) Then
					str = Oo00.OoOo_oo_.o_o.(name, table)
				Else
					str = "[" + name + "]"
				End If
				If A_0 Then
					text = text + str + " Is Null"
				Else
					text = text + str + " Is Not Null"
				End If
				Filter.O0O0o.Oo0OO_oO.(table, text, True)
			End If
		End Sub

		' Token: 0x06005788 RID: 22408 RVA: 0x00228DC0 File Offset: 0x00226FC0
		<oO0oooo("3330")>
		Public Sub DuplicateValuesFilter()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				New o\u3002\u3000\u30000\u3002\u3000\u3002(table).ShowDialog()
			End If
		End Sub

		' Token: 0x06005789 RID: 22409 RVA: 0x00228DE4 File Offset: 0x00226FE4
		<oO0oooo("3331")>
		Public Sub CircularFilter()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				New O\u3000\u3002\u3000(table).ShowDialog()
			End If
		End Sub

		' Token: 0x0600578A RID: 22410 RVA: 0x00228E06 File Offset: 0x00227006
		Public Sub Null()
			Filter.O0O0o.Oo0OO_oO.(True)
		End Sub

		' Token: 0x0600578B RID: 22411 RVA: 0x00228E0E File Offset: 0x0022700E
		Public Sub NotNull()
			Filter.O0O0o.Oo0OO_oO.(False)
		End Sub
	End Module
End Namespace
