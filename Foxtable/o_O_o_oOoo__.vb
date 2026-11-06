Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200042E RID: 1070
	Friend NotInheritable Module o_O_o_oOoo__
		' Token: 0x0600468F RID: 18063 RVA: 0x001C7CF4 File Offset: 0x001C5EF4
		Friend Sub <<EMPTY_NAME>>(A_0 As OleDbDataAdapter)
			Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder()
			oleDbCommandBuilder.ConflictOption = ConflictOption.OverwriteChanges
			oleDbCommandBuilder.SetAllValues = False
			oleDbCommandBuilder.QuotePrefix = "["
			oleDbCommandBuilder.QuoteSuffix = "]"
			If o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.SelectCommand.Connection) Then
				oleDbCommandBuilder.QuotePrefix = """"
				oleDbCommandBuilder.QuoteSuffix = """"
			End If
			oleDbCommandBuilder.DataAdapter = A_0
			oleDbCommandBuilder.RefreshSchema()
			A_0.InsertCommand = oleDbCommandBuilder.GetInsertCommand()
			A_0.UpdateCommand = oleDbCommandBuilder.GetUpdateCommand()
			A_0.DeleteCommand = oleDbCommandBuilder.GetDeleteCommand()
			A_0.ContinueUpdateOnError = True
		End Sub

		' Token: 0x06004690 RID: 18064 RVA: 0x001C7D8C File Offset: 0x001C5F8C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Integer, A_3 As Boolean) As Boolean
			Dim anyOf As Char() = New Char() { "."c, "["c, "]"c, "!"c, "`"c }
			Try
				Dim enumerator As List(Of String).Enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(enumerator.Current, A_0, True) = 0 Then
						MessageBox.Show(String.Concat(New String() { """", A_0, """为保留名称，不能作为", A_1, "使用！" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return False
					End If
				End While
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Dim result As Boolean
			If Not A_3 And (A_0 Is Nothing OrElse Operators.CompareString(A_0, "", True) = 0) Then
				MessageBox.Show(A_1 + "不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				result = False
			ElseIf A_0.Length > A_2 Then
				MessageBox.Show("ValueName长度不能超过" + Conversions.ToString(A_2) + "个字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				result = False
			ElseIf A_0.IndexOfAny(anyOf) > -1 Then
				MessageBox.Show(A_1 + "不能包括小数点(.)、感叹号(!)、重音符号(`) 和方括号([ ])", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				result = False
			ElseIf Char.IsDigit(A_0(0)) Then
				MessageBox.Show(A_1 + "不能以数字开头！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				result = False
			Else
				For Each c As Char In A_0
					If(Char.IsSymbol(c) OrElse Char.IsPunctuation(c)) AndAlso c <> "_"c Then
						MessageBox.Show(A_1 + "不能包括除下划线(_)之外的符号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return False
					End If
					If Char.IsControl(c) Or Char.IsWhiteSpace(c) Or Char.IsSeparator(c) Then
						MessageBox.Show(A_1 + "不能包含控制字符(从 0 到 31 的 ASCII 值)以及空格，如果是从其他应用程序中粘贴过来的，请删除后重新输入！ ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End If
				Next
				result = True
			End If
			Return result
		End Function

		' Token: 0x06004691 RID: 18065 RVA: 0x001C7F84 File Offset: 0x001C6184
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If Operators.CompareString(A_0, "", True) = 0 Then
				MessageBox.Show("列名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf o_O_o_oOoo__.oO.O_..Contains("~TMPCLP" + A_0) Then
				MessageBox.Show("无效的列名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = o_O_o_oOoo__.O_o_._o0.(A_0, "列名", 64, False)
			End If
			Return result
		End Function

		' Token: 0x06004692 RID: 18066 RVA: 0x001C7FFC File Offset: 0x001C61FC
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean) As Boolean
			Dim result As Boolean
			If o_O_o_oOoo__.oO.O_..Contains(A_0) Then
				result = False
			ElseIf A_0.Length > 64 Then
				result = False
			Else
				Dim anyOf As Char() = New Char() { "."c, "["c, "]"c, "!"c, "`"c }
				If A_0.IndexOfAny(anyOf) > -1 Then
					result = False
				Else
					For Each c As Char In A_0
						If Char.IsControl(c) Or Char.IsWhiteSpace(c) Or Char.IsSeparator(c) Then
							Return False
						End If
					Next
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x06004693 RID: 18067 RVA: 0x001C8088 File Offset: 0x001C6288
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If Operators.CompareString(A_0, "like", True) = 0 OrElse Operators.CompareString(A_0, "where", True) = 0 OrElse Operators.CompareString(A_0, "as", True) = 0 OrElse Operators.CompareString(A_0, "select", True) = 0 OrElse Operators.CompareString(A_0, "from", True) = 0 OrElse Operators.CompareString(A_0, "variables", True) = 0 OrElse Operators.CompareString(A_0, "全局变量", True) = 0 Then
				MessageBox.Show("无效表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf Operators.CompareString(A_0, "", True) = 0 Then
				MessageBox.Show("表名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf Char.IsDigit(A_0(0)) Then
				MessageBox.Show("表名第一个字符不能为数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf Versioned.IsNumeric(A_0) Then
				MessageBox.Show("表名不能是纯数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf o_O_o_oOoo__.Oo_0.OOo0oO0..Contains("~TMPCLP" + A_0) Then
				MessageBox.Show("无效的表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = o_O_o_oOoo__.O_o_._o0.(A_0, "表名", 57, False)
			End If
			Return result
		End Function

		' Token: 0x06004694 RID: 18068 RVA: 0x001C81C4 File Offset: 0x001C63C4
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataColumn, A_2 As String) As String
			Dim num As Integer = 1
			Dim text As String
			While True
				text = A_2 + Conversions.ToString(num)
				If A_0.[Select](String.Concat(New String() { "[", A_1.ColumnName, "] = '", text, "'" })).Length = 0 Then
					Exit For
				End If
				num += 1
				If num > 2147483647 Then
					GoTo Block_2
				End If
			End While
			Return text
			Block_2:
			Return A_2 + Conversions.ToString(num)
		End Function

		' Token: 0x06004695 RID: 18069 RVA: 0x001C8238 File Offset: 0x001C6438
		Friend Function <<EMPTY_NAME>>(A_0 As DataColumn, A_1 As String) As Boolean
			For Each dataRow As DataRow In A_0.Table.[Select]("", "", DataViewRowState.CurrentRows)
				If Not dataRow.IsNull(A_0) AndAlso Operators.CompareString(Conversions.ToString(dataRow(A_0)), A_1, True) = 0 Then
					Return True
				End If
			Next
			Return False
		End Function

		' Token: 0x06004696 RID: 18070 RVA: 0x001C8294 File Offset: 0x001C6494
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataColumn(), A_2 As String()) As Boolean
			For Each dataRow As DataRow In A_0.[Select]("", "", DataViewRowState.CurrentRows)
				Dim flag As Boolean = True
				Dim num As Integer = A_1.Length - 1
				For j As Integer = 0 To num
					Dim column As DataColumn = A_1(j)
					If dataRow(column) Is DBNull.Value Then
						If Operators.CompareString(A_2(j), "", True) <> 0 Then
							flag = False
						End If
					ElseIf Operators.CompareString(Conversions.ToString(dataRow(column)), A_2(j), True) <> 0 Then
						flag = False
					End If
				Next
				If flag Then
					Return flag
				End If
			Next
			Return False
		End Function

		' Token: 0x06004697 RID: 18071 RVA: 0x001C8334 File Offset: 0x001C6534
		Friend Function <<EMPTY_NAME>>(A_0 As OuterTableSetting, A_1 As OleDbConnection) As String
			Dim result As String
			If o_O_o_oOoo__.OOOO_OO._oo.(A_1) Then
				result = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0, DataServerTypeEnum.SqlServer)
			ElseIf o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1) Then
				result = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0, DataServerTypeEnum.Oracle)
			Else
				result = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0, DataServerTypeEnum.Access)
			End If
			Return result
		End Function

		' Token: 0x06004698 RID: 18072 RVA: 0x001C8370 File Offset: 0x001C6570
		Friend Function <<EMPTY_NAME>>(A_0 As OuterTableSetting, A_1 As DataServerTypeEnum) As String
			Dim fields As String = A_0.Fields
			Dim text As String = A_0.SourceTable
			If A_1 <> DataServerTypeEnum.Oracle AndAlso Not text.StartsWith("[") Then
				text = "[" + text + "]"
			End If
			Dim text2 As String
			If A_0.AllRows OrElse A_1 = DataServerTypeEnum.Oracle Then
				text2 = "Select "
			ElseIf A_0.Percent Then
				A_0.Top = Math.Min(A_0.Top, 100)
				text2 = "Select Top " + Conversions.ToString(A_0.Top) + " PERCENT "
			Else
				text2 = "Select Top " + Conversions.ToString(A_0.Top) + " "
			End If
			If Operators.CompareString(fields, "", True) > 0 AndAlso Operators.CompareString(fields.Trim(), "", True) > 0 AndAlso Not A_0.AllFields AndAlso Not A_0.Exclude Then
				text2 = text2 + fields + " "
			Else
				text2 += "* "
			End If
			text2 = text2 + "From " + text
			Dim text3 As String = A_0.Filter
			If Not A_0.AllRows AndAlso A_1 = DataServerTypeEnum.Oracle Then
				Dim text4 As String = "ROWNUM <= " + Conversions.ToString(A_0.Top)
				If Operators.CompareString(text3, "", True) > 0 Then
					text3 = text3 + " AND " + text4
				Else
					text3 = text4
				End If
			End If
			If Operators.CompareString(text3, "", True) > 0 Then
				text2 = text2 + " Where " + text3 + " "
			End If
			If Operators.CompareString(A_0.Order, " ", True) > 0 Then
				text2 = text2 + " ORDER BY " + A_0.Order
			End If
			If A_1 = DataServerTypeEnum.Oracle Then
				text2 = text2.Replace("[", """").Replace("]", """")
			End If
			Return text2
		End Function

		' Token: 0x06004699 RID: 18073 RVA: 0x001C8527 File Offset: 0x001C6727
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable)
			CType(A_0.ExtendedProperties("DataAdapter"), OleDbDataAdapter).Fill(A_0)
		End Sub

		' Token: 0x0600469A RID: 18074 RVA: 0x001C8548 File Offset: 0x001C6748
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow) As Object()
			Dim table As DataTable = A_0.Table
			Dim array As Object() = New Object(table.PrimaryKey.Length - 1 + 1 - 1) {}
			Dim num As Integer = table.PrimaryKey.Length - 1
			For i As Integer = 0 To num
				array(i) = RuntimeHelpers.GetObjectValue(A_0(table.PrimaryKey(i)))
			Next
			Return array
		End Function

		' Token: 0x0600469B RID: 18075 RVA: 0x001C859C File Offset: 0x001C679C
		Friend Function <<EMPTY_NAME>>(A_0 As Object, Optional A_1 As Boolean = False, Optional A_2 As Char = vbVerticalTab, Optional A_3 As Boolean = False) As String
			Dim arrayList As ArrayList = New ArrayList()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim properties As PropertyInfo() = A_0.[GetType]().GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
			Dim properties2 As PropertyDescriptorCollection = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(A_0))
			For Each propertyInfo As PropertyInfo In properties
				Dim propertyInfo As PropertyInfo
				If propertyInfo.GetSetMethod() IsNot Nothing AndAlso Not O00OOOo_O0_O.O.0o_0_o.(propertyInfo) Then
					If O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) AndAlso A_1 Then
						arrayList.Add(propertyInfo)
					ElseIf Not O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) And Not A_1 Then
						arrayList.Add(propertyInfo)
					End If
				End If
			Next
			Dim num As Integer = arrayList.Count - 1
			Dim j As Integer = 0
			While j <= num
				Dim propertyInfo As PropertyInfo = CType(arrayList(j), PropertyInfo)
				Dim propertyDescriptor As PropertyDescriptor = properties2(propertyInfo.Name)
				If propertyDescriptor Is Nothing Then
					If A_3 Then
						GoTo IL_CB
					End If
				ElseIf ooO.OO_oOO0O.O00.(RuntimeHelpers.GetObjectValue(A_0), propertyDescriptor) OrElse A_3 Then
					GoTo IL_CB
				End If
				IL_736:
				j += 1
				Continue While
				IL_CB:
				Dim defaultValueAttribute As DefaultValueAttribute = CType(propertyDescriptor.Attributes(GetType(DefaultValueAttribute)), DefaultValueAttribute)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing))
				Dim text As String = ""
				If objectValue IsNot Nothing Then
					If propertyInfo.PropertyType.IsEnum Then
						text = Conversions.ToInteger(objectValue).ToString()
					ElseIf propertyInfo.PropertyType Is GetType(Font) Then
						Dim font As Font = CType(objectValue, Font)
						If font.Style = FontStyle.Regular Then
							text = font.Name + "," + Conversions.ToString(font.Size)
						Else
							text = String.Concat(New String() { font.Name, ",", Conversions.ToString(font.Size), ",", font.Style.ToString() }).Trim(New Char() { ","c })
						End If
					ElseIf propertyInfo.PropertyType Is GetType(Color) Then
						Dim obj As Object = objectValue
						Dim color As Color = If((obj IsNot Nothing), CType(obj, Color), Nothing)
						If color.IsEmpty Then
							If Not A_3 Then
								GoTo IL_736
							End If
						Else
							text = color.ToArgb().ToString()
						End If
						color = Nothing
					ElseIf propertyInfo.PropertyType Is GetType(DateTime) Then
						Dim t As DateTime
						If DateTime.Compare(t, Conversions.ToDate(objectValue)) = 0 Then
							If Not A_3 Then
								GoTo IL_736
							End If
						Else
							text = objectValue.ToString()
						End If
					ElseIf propertyInfo.PropertyType Is GetType(Char) Then
						If Conversions.ToChar(objectValue) = vbNullChar AndAlso Not A_3 Then
							GoTo IL_736
						End If
						text = Conversions.ToString(Conversions.ToChar(objectValue))
					Else
						text = objectValue.ToString()
					End If
				ElseIf Not A_3 Then
					GoTo IL_736
				End If
				If defaultValueAttribute IsNot Nothing Then
					If String.Compare(defaultValueAttribute.Value.ToString(), text, False) = 0 AndAlso Not A_3 Then
						GoTo IL_736
					End If
				ElseIf Operators.CompareString(text, "", True) = 0 AndAlso Not A_3 Then
					GoTo IL_736
				End If
				stringBuilder.Append(propertyInfo.Name)
				stringBuilder.Append(A_2)
				If propertyInfo.PropertyType Is GetType(String) OrElse propertyInfo.PropertyType Is GetType(Char) Then
					stringBuilder.Append(text.Replace(Conversions.ToString(A_2), ""))
				ElseIf propertyInfo.PropertyType Is GetType(DateTime) Then
					stringBuilder.Append(RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing)))
				ElseIf propertyInfo.PropertyType Is GetType(Integer) OrElse propertyInfo.PropertyType Is GetType(Byte) OrElse propertyInfo.PropertyType Is GetType(Double) OrElse propertyInfo.PropertyType Is GetType(Single) OrElse propertyInfo.PropertyType Is GetType(Decimal) OrElse propertyInfo.PropertyType Is GetType(Long) Then
					stringBuilder.Append(text)
				ElseIf propertyInfo.PropertyType Is GetType(Boolean) Then
					If Conversions.ToBoolean(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing)) Then
						stringBuilder.Append("1")
					Else
						stringBuilder.Append("0")
					End If
				ElseIf propertyInfo.PropertyType Is GetType(EventString) OrElse propertyInfo.PropertyType Is GetType(StringCollection) Then
					Dim eventString As EventString = CType(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing), EventString)
					If eventString IsNot Nothing AndAlso eventString.Count > 0 Then
						stringBuilder.Append(eventString(0))
					Else
						stringBuilder.Append("")
					End If
				ElseIf propertyInfo.PropertyType Is GetType(Size) Then
					Dim value As Object = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing)
					Dim size As Size = If((value IsNot Nothing), CType(value, Size), Nothing)
					stringBuilder.Append(Conversions.ToString(size.Width) + "," + Conversions.ToString(size.Height))
				ElseIf propertyInfo.PropertyType Is GetType(Point) Then
					Dim value2 As Object = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing)
					Dim point As Point = If((value2 IsNot Nothing), CType(value2, Point), Nothing)
					stringBuilder.Append(Conversions.ToString(point.X) + "," + Conversions.ToString(point.Y))
				ElseIf propertyInfo.PropertyType Is GetType(PointF) Then
					Dim value3 As Object = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing)
					Dim pointF As PointF = If((value3 IsNot Nothing), CType(value3, PointF), Nothing)
					stringBuilder.Append(Conversions.ToString(pointF.X) + "," + Conversions.ToString(pointF.Y))
				ElseIf propertyInfo.PropertyType Is GetType(Font) Then
					Dim font2 As Font = CType(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing), Font)
					If font2 IsNot Nothing Then
						stringBuilder.Append(String.Concat(New String() { font2.Name, ",", Conversions.ToString(font2.Size), ",", Conversions.ToString(CInt(font2.Style)), ",", Conversions.ToString(CInt(font2.Unit)) }))
					Else
						stringBuilder.Append("")
					End If
				ElseIf propertyInfo.PropertyType Is GetType(Color) Then
					Dim value4 As Object = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing)
					Dim color2 As Color = If((value4 IsNot Nothing), CType(value4, Color), Nothing)
					If color2.IsEmpty Then
						stringBuilder.Append("")
					ElseIf color2.ToKnownColor() > CType(0, KnownColor) Then
						stringBuilder.Append(CInt(color2.ToKnownColor()))
					Else
						stringBuilder.Append(color2.ToArgb())
					End If
				ElseIf propertyInfo.PropertyType.IsEnum Then
					stringBuilder.Append(Conversions.ToInteger(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing)))
				End If
				If j < arrayList.Count - 1 Then
					stringBuilder.Append(A_2)
				End If
				If o_O_o_oOoo__.O_o_._o0. IsNot Nothing AndAlso o_O_o_oOoo__.O_o_._o0..Value Then
					j += 1
					GoTo IL_736
				End If
				GoTo IL_736
			End While
			Return stringBuilder.ToString().Trim(New Char() { A_2 })
		End Function

		' Token: 0x0600469C RID: 18076 RVA: 0x001C8D04 File Offset: 0x001C6F04
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataRow, Optional A_2 As Boolean = False)
			If Not A_2 AndAlso Not A_1.IsNull("Property") Then
				o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToString(A_1("Property")), vbVerticalTab)
			End If
			If Not A_1.IsNull("Code") Then
				Dim text As String = Conversions.ToString(A_1("Code"))
				Dim a_ As String = ooO0__OO.O_Oo00oO.Ooo.()
				If text.StartsWith("{") AndAlso text.EndsWith("}") Then
					text = text.TrimStart(New Char() { "{"c }).TrimEnd(New Char() { "}"c })
					a_ = Oo00.ooO.ooo.()
				ElseIf text.StartsWith(" ") AndAlso text.EndsWith(" ") Then
					text = text.Trim()
					a_ = o_O_o_oOoo__.OOOO_OO._oo.(ooO0__OO.O_Oo00oO.Ooo.())
				End If
				o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(A_0), O00.oO_.0o_oo_0O_.(text, ooO0__OO.O_Oo00oO.Ooo.(), a_), vbVerticalTab)
			End If
		End Sub

		' Token: 0x0600469D RID: 18077 RVA: 0x001C8DF0 File Offset: 0x001C6FF0
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String, Optional A_2 As Char = vbVerticalTab)
			Dim array As String() = A_1.Split(New Char() { A_2 })
			Dim num As Integer = array.Length - 2
			For i As Integer = 0 To num Step 2
				Dim [property] As PropertyInfo = A_0.[GetType]().GetProperty(array(i))
				If [property] IsNot Nothing AndAlso [property].GetSetMethod() IsNot Nothing Then
					Operators.CompareString(array(i + 1), "", True)
					If [property] IsNot Nothing Then
						If [property].PropertyType Is GetType(String) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), array(i + 1), Nothing)
						ElseIf [property].PropertyType Is GetType(DateTime) Then
							Dim dateTime As DateTime
							If DateTime.TryParse(array(i + 1), dateTime) Then
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), dateTime, Nothing)
							End If
						ElseIf [property].PropertyType Is GetType(Char) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), array(i + 1)(0), Nothing)
						ElseIf [property].PropertyType Is GetType(Integer) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToInteger(array(i + 1)), Nothing)
						ElseIf [property].PropertyType Is GetType(Long) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToInteger(array(i + 1)), Nothing)
						ElseIf [property].PropertyType Is GetType(Byte) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToByte(array(i + 1)), Nothing)
						ElseIf [property].PropertyType Is GetType(Double) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToDouble(array(i + 1)), Nothing)
						ElseIf [property].PropertyType Is GetType(Decimal) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToDecimal(array(i + 1)), Nothing)
						ElseIf [property].PropertyType Is GetType(Single) Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToSingle(array(i + 1)), Nothing)
						ElseIf [property].PropertyType Is GetType(Boolean) Then
							If Operators.CompareString(array(i + 1), "1", True) = 0 Then
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), True, Nothing)
							Else
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), False, Nothing)
							End If
						ElseIf [property].PropertyType Is GetType(EventString) OrElse [property].PropertyType Is GetType(StringCollection) Then
							Dim eventString As EventString = New EventString()
							If Operators.CompareString(array(i + 1), "", True) > 0 Then
								eventString.Add(array(i + 1))
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), eventString, Nothing)
							Else
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing, Nothing)
							End If
							If o_O_o_oOoo__.Oo_0.OOo0oO0. Then
								i += 2
							End If
						ElseIf [property].PropertyType Is GetType(Size) Then
							Dim width As Integer = Conversions.ToInteger(array(i + 1).Substring(0, array(i + 1).IndexOf(",")))
							Dim height As Integer = Conversions.ToInteger(array(i + 1).Substring(array(i + 1).IndexOf(",") + 1))
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), New Size(width, height), Nothing)
						ElseIf [property].PropertyType Is GetType(Point) Then
							Dim x As Integer = Conversions.ToInteger(array(i + 1).Substring(0, array(i + 1).IndexOf(",")))
							Dim y As Integer = Conversions.ToInteger(array(i + 1).Substring(array(i + 1).IndexOf(",") + 1))
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), New Point(x, y), Nothing)
						ElseIf [property].PropertyType Is GetType(PointF) Then
							Dim x2 As Single = Conversions.ToSingle(array(i + 1).Substring(0, array(i + 1).IndexOf(",")))
							Dim y2 As Single = Conversions.ToSingle(array(i + 1).Substring(array(i + 1).IndexOf(",") + 1))
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), New PointF(x2, y2), Nothing)
						ElseIf [property].PropertyType Is GetType(Font) Then
							If Operators.CompareString(array(i + 1), "", True) = 0 Then
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing, Nothing)
							Else
								Dim array2 As String() = array(i + 1).Split(New Char() { ","c })
								Dim familyName As String = array2(0)
								Dim emSize As Single = Conversions.ToSingle(array2(1))
								Dim style As FontStyle = CType(Conversions.ToInteger(array2(2)), FontStyle)
								Dim unit As GraphicsUnit = CType(Conversions.ToInteger(array2(3)), GraphicsUnit)
								Dim value As Font = New Font(familyName, emSize, style, unit)
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), value, Nothing)
							End If
						ElseIf [property].PropertyType Is GetType(Color) Then
							If Operators.CompareString(array(i + 1), "", True) = 0 Then
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), Color.Empty, Nothing)
							ElseIf [Enum].GetName(GetType(KnownColor), Conversions.ToInteger(array(i + 1))) IsNot Nothing Then
								Dim color As Color = Color.FromKnownColor(CType(Conversions.ToInteger(array(i + 1)), KnownColor))
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), color, Nothing)
							Else
								Dim color2 As Color = Color.FromArgb(Conversions.ToInteger(array(i + 1)))
								[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), color2, Nothing)
							End If
						ElseIf [property].PropertyType.IsEnum Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), RuntimeHelpers.GetObjectValue([Enum].Parse([property].PropertyType, array(i + 1))), Nothing)
						ElseIf Operators.CompareString(array(i + 1), "", True) > 0 AndAlso Operators.CompareString([property].PropertyType.Name, "Object", True) = 0 Then
							[property].SetValue(RuntimeHelpers.GetObjectValue(A_0), array(i + 1), Nothing)
						End If
					End If
				End If
			Next
		End Sub

		' Token: 0x0600469E RID: 18078 RVA: 0x001C9410 File Offset: 0x001C7610
		Friend Function <<EMPTY_NAME>>(A_0 As OleDbConnection) As Boolean
			Dim result As Boolean
			If A_0 Is Nothing Then
				result = False
			ElseIf A_0.Provider Is Nothing Then
				result = False
			Else
				Dim provider As String = A_0.Provider
				result = (provider.StartsWith("OraOLEDB", StringComparison.CurrentCultureIgnoreCase) OrElse provider.StartsWith("MSDAORA", StringComparison.CurrentCultureIgnoreCase))
			End If
			Return result
		End Function

		' Token: 0x0600469F RID: 18079 RVA: 0x001C945C File Offset: 0x001C765C
		Friend Function <<EMPTY_NAME>>(A_0 As OleDbConnection) As Boolean
			Dim provider As String = A_0.Provider
			Return provider.StartsWith("SQLOLEDB", StringComparison.CurrentCultureIgnoreCase) OrElse provider.StartsWith("SQLNCLI", StringComparison.CurrentCultureIgnoreCase)
		End Function

		' Token: 0x060046A0 RID: 18080 RVA: 0x001C9498 File Offset: 0x001C7698
		Friend Function <<EMPTY_NAME>>(A_0 As Type) As Boolean
			Return A_0 Is GetType(Long) OrElse A_0 Is GetType(Integer) OrElse A_0 Is GetType(Short) OrElse A_0 Is GetType(Byte) OrElse A_0 Is GetType(Decimal) OrElse A_0 Is GetType(Double) OrElse A_0 Is GetType(Single)
		End Function

		' Token: 0x060046A1 RID: 18081 RVA: 0x001C9508 File Offset: 0x001C7708
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim num As Integer = A_0.IndexOf("USER ID", StringComparison.CurrentCultureIgnoreCase)
			Dim result As String
			If num > 0 Then
				Dim num2 As Integer = A_0.IndexOf("=", num)
				Dim num3 As Integer = A_0.IndexOf(";", num2)
				result = A_0.Substring(num2 + 1, num3 - num2 - 1).Trim()
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x060046A2 RID: 18082 RVA: 0x001C9560 File Offset: 0x001C7760
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As DateGroupEnum, A_3 As DataServerTypeEnum) As String
			Dim text As String = ""
			A_1 = A_1.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			If A_3 = DataServerTypeEnum.Oracle Then
				text = "TO_CHAR("
				If Operators.CompareString(A_0, "", True) > 0 Then
					text = text + A_0 + "."
				End If
				text = text + """" + A_1 + ""","
				Select Case A_2
					Case 1
						text += "'YYYY')"
					Case 2
						text += "'Q')"
					Case 3
						text += "'MM')"
					Case 4
						text += "'WW')"
					Case 5
						text += "'DD')"
					Case 6
						text += "'HH24')"
					Case 7
						text += "'MI')"
					Case 8
						text += "'SS')"
					Case 9
						text += "'DDD')"
					Case 10
						text += "'D')"
				End Select
			Else
				Select Case A_2
					Case 1
						text = "DatePart('yyyy',"
					Case 2
						text = "DatePart('q',"
					Case 3
						text = "DatePart('m',"
					Case 4
						text = "DatePart('ww',"
					Case 5
						text = "DatePart('d',"
					Case 6
						If A_3 = DataServerTypeEnum.SqlServer Then
							text = "DatePart('hh',"
						Else
							text = "DatePart('h',"
						End If
					Case 7
						text = "DatePart('n',"
					Case 8
						text = "DatePart('s',"
					Case 9
						text = "DatePart('y',"
					Case 10
						text = "DatePart('w',"
				End Select
				If A_3 = DataServerTypeEnum.SqlServer Then
					text = text.Replace("'", "")
				End If
				If Operators.CompareString(A_0, "", True) > 0 Then
					text = text + "[" + A_0 + "]."
				End If
				text = text + "[" + A_1 + "])"
			End If
			Return text
		End Function

		' Token: 0x060046A3 RID: 18083 RVA: 0x001C978C File Offset: 0x001C798C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim version As Version = Environment.Version
			Return version.Build = 50727 AndAlso version.Revision < 1433
		End Function

		' Token: 0x060046A4 RID: 18084 RVA: 0x001C97C4 File Offset: 0x001C79C4
		Friend Sub <<EMPTY_NAME>>(A_0 As Table)
			Dim o_oOooO_O As O_oOooO_O = A_0.foxGrid
			Dim fixed As Integer = o_oOooO_O.Cols.Fixed
			Dim num As Integer = o_oOooO_O.Cols.Count - 1
			For i As Integer = fixed To num
				Dim column As Column = o_oOooO_O.Cols(i)
				If column.Editor IsNot Nothing AndAlso Not column.Editor.Disposing AndAlso Not column.Editor.IsDisposed Then
					If TypeOf column.Editor Is BuildInDropTree Then
						Dim buildInDropTree As BuildInDropTree = CType(column.Editor, BuildInDropTree)
						buildInDropTree.Ooo._0oO..o.00_O_.().Nodes.Clear()
						buildInDropTree.Ooo._0oO..o_Oo.O0o__o0O. = Nothing
						buildInDropTree.Ooo._0oO..Dispose()
						buildInDropTree.Ooo._0oO. = Nothing
						buildInDropTree.Dispose()
					End If
					column.Editor = Nothing
				End If
			Next
		End Sub

		' Token: 0x060046A5 RID: 18085 RVA: 0x001C9888 File Offset: 0x001C7A88
		Friend Function a() As Boolean
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.())
			Dim dataRow As DataRow = dataTable.Rows.Find(New Object() { "ProjectIdentify", o0_O.oO_0o__.O0_oo. })
			Dim result As Boolean
			If dataRow Is Nothing Then
				result = False
			Else
				Dim a_ As String = dataRow("Config").ToString()
				dataRow = dataTable.Rows.Find(New Object() { "Doogle", o0_O.o_.oooo0. })
				If dataRow Is Nothing Then
					result = False
				Else
					Dim text As String = dataRow("Config").ToString()
					Dim a_2 As String = text.Substring(0, 8)
					Dim a_3 As String = text.Substring(8)
					result = (Operators.CompareString(O00.oO_.0o_oo_0O_.(a_, a_2, a_3), O_O0OO.O_O._Oo.(), True) = 0)
				End If
			End If
			Return result
		End Function

		' Token: 0x060046A6 RID: 18086 RVA: 0x001C9950 File Offset: 0x001C7B50
		Friend Function <<EMPTY_NAME>>(A_0 As TreeView) As List(Of TreeNode)
			Dim list As List(Of TreeNode) = New List(Of TreeNode)()
			o_O_o_oOoo__.oo.O0o0o.(A_0.Nodes, list)
			Return list
		End Function

		' Token: 0x060046A7 RID: 18087 RVA: 0x001C9970 File Offset: 0x001C7B70
		Friend Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection, A_1 As List(Of TreeNode))
			Try
				For Each obj As Object In A_0
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					A_1.Add(treeNode)
					If treeNode.Nodes.Count > 0 Then
						o_O_o_oOoo__.oo.O0o0o.(treeNode.Nodes, A_1)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060046A8 RID: 18088 RVA: 0x001C99E4 File Offset: 0x001C7BE4
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Friend Function <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As Char) As String
			Dim text As String = A_0.Name
			Dim parent As TreeNode = A_0.Parent
			While parent IsNot Nothing
				text = parent.Name + Interaction.IIf(Operators.CompareString(Conversions.ToString(A_1), vbNullChar, True) = 0, "", A_1).ToString() + text
				parent = parent.Parent
			End While
			Return text
		End Function

		' Token: 0x060046A9 RID: 18089 RVA: 0x001C9A44 File Offset: 0x001C7C44
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Friend Function <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As Char, A_2 As Integer) As String
			Dim text As String = A_0.Name
			Dim parent As TreeNode = A_0.Parent
			While parent IsNot Nothing AndAlso parent.Level <> A_2
				text = parent.Name + Interaction.IIf(Operators.CompareString(Conversions.ToString(A_1), vbNullChar, True) = 0, "", A_1).ToString() + text
				parent = parent.Parent
			End While
			Return text
		End Function

		' Token: 0x060046AA RID: 18090 RVA: 0x001C9AAB File Offset: 0x001C7CAB
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Friend Function <<EMPTY_NAME>>(A_0 As TreeNode) As Integer
			Return o_O_o_oOoo__.OOOO_OO._oo.(A_0.Nodes)
		End Function

		' Token: 0x060046AB RID: 18091 RVA: 0x001C9AB8 File Offset: 0x001C7CB8
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Friend Function <<EMPTY_NAME>>(A_0 As TreeView) As Integer
			Return o_O_o_oOoo__.OOOO_OO._oo.(A_0.Nodes)
		End Function

		' Token: 0x060046AC RID: 18092 RVA: 0x001C9AC8 File Offset: 0x001C7CC8
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Friend Function <<EMPTY_NAME>>(A_0 As TreeNodeCollection, A_1 As String) As Boolean
			Try
				For Each obj As Object In A_0
					Dim text As String = CType(obj, TreeNode).Text
					If text.EndsWith(")") AndAlso text.IndexOf("(") > 0 Then
						text = text.Substring(0, text.LastIndexOf("("))
					End If
					If Operators.CompareString(text, A_1, True) = 0 Then
						Return True
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return False
		End Function

		' Token: 0x060046AD RID: 18093 RVA: 0x001C9B5C File Offset: 0x001C7D5C
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Friend Function <<EMPTY_NAME>>(A_0 As TreeNode) As String
			Dim text As String = A_0.Text
			If text.EndsWith(")") AndAlso text.IndexOf("(") > 0 Then
				text = text.Substring(0, text.LastIndexOf("("))
			End If
			Return text
		End Function

		' Token: 0x060046AE RID: 18094 RVA: 0x001C9BA0 File Offset: 0x001C7DA0
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Friend Function <<EMPTY_NAME>>(A_0 As TreeNode) As String
			Dim text As String = A_0.Text
			If text.EndsWith(")") AndAlso text.IndexOf("(") > 0 Then
				text = text.Substring(text.LastIndexOf("(") + 1).Trim(New Char() { ")"c })
				If Versioned.IsNumeric(text) Then
					Return text
				End If
			End If
			Return ""
		End Function

		' Token: 0x060046AF RID: 18095 RVA: 0x001C9C08 File Offset: 0x001C7E08
		Public Function <<EMPTY_NAME>>(A_0 As TreeNodeCollection) As Integer
			Dim sortedSet As SortedSet(Of Integer) = New SortedSet(Of Integer)()
			Try
				For Each obj As Object In A_0
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					If Versioned.IsNumeric(treeNode.Name) Then
						sortedSet.Add(Conversions.ToInteger(treeNode.Name))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim num As Integer = 1
			While sortedSet.Contains(num)
				num += 1
			End While
			Return num
		End Function

		' Token: 0x060046B0 RID: 18096 RVA: 0x001C9C90 File Offset: 0x001C7E90
		Friend Function <<EMPTY_NAME>>(A_0 As TreeView) As String
			Dim a As o_O_o_oOoo__.a = New o_O_o_oOoo__.a(a)
			Dim source As List(Of TreeNode) = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0)
			Dim num As Integer = 0
			Do
				num += 1
				a.a = "新节点" + Conversions.ToString(num)
			Loop While source.Any(AddressOf a.a)
			Return a.a
		End Function

		' Token: 0x060046B1 RID: 18097 RVA: 0x001C9CE4 File Offset: 0x001C7EE4
		Friend Function <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As TreeNode) As Boolean
			Dim result As Boolean
			If A_0.Nodes.Count <> A_1.Nodes.Count Then
				result = True
			Else
				Dim num As Integer = A_0.Nodes.Count - 1
				For i As Integer = 0 To num
					If Operators.CompareString(A_0.Nodes(i).Name, A_1.Nodes(i).Name, True) <> 0 Then
						Return True
					End If
					If Operators.CompareString(A_0.Nodes(i).Text, A_1.Nodes(i).Text, True) <> 0 Then
						Return True
					End If
				Next
				result = False
			End If
			Return result
		End Function

		' Token: 0x060046B2 RID: 18098 RVA: 0x001C9D88 File Offset: 0x001C7F88
		Friend Function <<EMPTY_NAME>>(A_0 As Type) As Boolean
			Return A_0 IsNot GetType(DateTime) AndAlso A_0 IsNot GetType(Double) AndAlso A_0 IsNot GetType(Single) AndAlso A_0 IsNot GetType(Decimal) AndAlso A_0 IsNot GetType(Boolean)
		End Function

		' Token: 0x060046B3 RID: 18099 RVA: 0x001C9DE0 File Offset: 0x001C7FE0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0 Is Nothing OrElse A_0.Length < 2 Then
				result = A_0
			Else
				Dim length As Integer = A_0.Length
				Dim array As Char() = New Char(length - 1 + 1 - 1) {}
				Dim num As Integer = length / 2 - 1
				For i As Integer = 0 To num
					Dim num2 As Integer = length - 1 - i
					Dim c As Char = A_0(i)
					Dim c2 As Char = A_0(num2)
					array(num2) = c
					array(i) = c2
				Next
				If length Mod 2 = 1 Then
					array(length / 2) = A_0(length / 2)
				End If
				result = New String(array)
			End If
			Return result
		End Function

		' Token: 0x04001CEB RID: 7403
		Friend <<EMPTY_NAME>> As List(Of String) = New List(Of String)()

		' Token: 0x04001CEC RID: 7404
		Friend <<EMPTY_NAME>> As List(Of String) = New List(Of String)()

		' Token: 0x04001CED RID: 7405
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001CEE RID: 7406
		Friend <<EMPTY_NAME>> As Boolean?

		' Token: 0x0200042F RID: 1071
		<CompilerGenerated()>
		Friend NotInheritable Class a
			' Token: 0x060046B4 RID: 18100 RVA: 0x001C9E69 File Offset: 0x001C8069
			Public Sub New(A_0 As o_O_o_oOoo__.a)
				If A_0 IsNot Nothing Then
					Me.a = A_0.a
				End If
			End Sub

			' Token: 0x060046B5 RID: 18101 RVA: 0x001C9E80 File Offset: 0x001C8080
			Friend Function a(A_0 As TreeNode) As Boolean
				Return Operators.CompareString(A_0.Name, Me.a, True) = 0
			End Function

			' Token: 0x04001CEF RID: 7407
			Public a As String
		End Class
	End Module
End Namespace
