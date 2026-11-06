Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x020000BF RID: 191
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module oOO0oO000_0_0
		' Token: 0x06000848 RID: 2120 RVA: 0x0003824C File Offset: 0x0003644C
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, ParamArray A_1 As DataRow()) As Boolean
			Dim list As List(Of String) = A_0.UpdateColumns
			New Boolean(A_1.Length - 1 + 1 - 1) {}
			Dim text As String = Nothing
			Dim text2 As String = vbVerticalTab & vbTab
			Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(A_0.ConnectionName).oO0_0.o.()
			Dim text3 As String = Oo00.o_OoO._0_00.(A_0.HttpSelect).Trim()
			If text3.StartsWith("(") Then
				text3 = Oo00.oo_0__0.o.(text3)
			End If
			Dim dictionary As Dictionary(Of String, String) = httpClient.FormData
			Dim key As String = "Action"
			Dim num As Integer = 4
			dictionary.Add(key, num.ToString())
			httpClient.FormData("DataTable") = text3
			Dim flag As Boolean
			If A_0.BaseTable.PrimaryKey.Length = 1 AndAlso A_0.BaseTable.PrimaryKey(0).AutoIncrement Then
				flag = True
				text = A_0.BaseTable.PrimaryKey(0).ColumnName
				httpClient.FormData.Add("AutoIncrement", A_0.BaseTable.PrimaryKey(0).ColumnName)
			End If
			num = A_1.Length - 1
			For i As Integer = 0 To num
				Dim dataRow As DataRow = A_1(i)
				Dim text4 As String = Nothing
				Dim text5 As String = ""
				Try
					For Each obj As Object In dataRow.Table.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If(Not flag OrElse Operators.CompareString(dataColumn.ColumnName, text, True) <> 0) AndAlso list.Contains(dataColumn.ColumnName.ToLower()) Then
							Dim text6 As String = oOO0oO000_0_0.OO.OoO0.(dataColumn.DataType)
							If Operators.CompareString(text5, "", True) = 0 Then
								text5 = dataColumn.ColumnName + text2 + text6 + "{{null}}"
							End If
							If Not dataRow.IsNull(dataColumn) Then
								Dim text7 As String
								If dataColumn.DataType Is GetType(DateTime) Then
									text7 = text6 + Conversions.ToString(Conversions.ToDate(dataRow(dataColumn)).ToBinary())
								Else
									text7 = text6 + dataRow(dataColumn).ToString()
								End If
								text4 = String.Concat(New String() { text4, Interaction.IIf(Operators.CompareString(text4, "", True) > 0, text2, "").ToString(), dataColumn.ColumnName, text2, text7.Replace(text2, "") })
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Operators.CompareString(text4, "", True) > 0 Then
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text4, "fox", "table"))
				Else
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text5, "fox", "table"))
				End If
			Next
			Dim result As Boolean
			Try
				Dim data As String = httpClient.GetData(True)
				If httpClient.RCookies.ContainsKey("Error") Then
					Throw New Exception(httpClient.RCookies("Error"))
				End If
				If Operators.CompareString(data, "", True) <= 0 Then
					Throw New Exception("未知HttpInsert错误")
				End If
				Dim array As String() = data.Split(New Char() { "|"c })
				Dim num2 As Integer = array.Length - 1
				For j As Integer = 0 To num2
					If Not Versioned.IsNumeric(array(j)) Then
						Throw New Exception("HttpInsert错误(" + array(j) + ")")
					End If
					If flag Then
						A_1(j)(text) = Conversions.ToInteger(array(j))
					ElseIf Conversions.ToInteger(array(j)) <> 1 Then
						Throw New Exception("HttpInsert错误(" + array(j) + ")")
					End If
					A_1(j).AcceptChanges()
					oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1(j), 0, 1)
				Next
				result = (array.Length = A_1.Length)
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			Return result
		End Function

		' Token: 0x06000849 RID: 2121 RVA: 0x000386B0 File Offset: 0x000368B0
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, ParamArray A_1 As DataRow()) As Boolean
			Dim list As List(Of String) = A_0.UpdateColumns
			New Boolean(A_1.Length - 1 + 1 - 1) {}
			Dim text As String = vbVerticalTab & vbTab
			Dim text2 As String = vbTab & vbVerticalTab
			Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(A_0.ConnectionName).oO0_0.o.()
			Dim text3 As String = Oo00.o_OoO._0_00.(A_0.HttpSelect).Trim()
			If text3.StartsWith("(") Then
				text3 = Oo00.oo_0__0.o.(text3)
			End If
			Dim dictionary As Dictionary(Of String, String) = httpClient.FormData
			Dim key As String = "Action"
			Dim num As Integer = 3
			dictionary.Add(key, num.ToString())
			httpClient.FormData("DataTable") = text3
			Dim num2 As Integer = 0
			num = A_1.Length - 1
			For i As Integer = 0 To num
				Dim dataRow As DataRow = A_1(i)
				Dim text4 As String = Nothing
				Dim text5 As String = Nothing
				Try
					For Each obj As Object In dataRow.Table.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If list.Contains(dataColumn.ColumnName.ToLower()) Then
							Dim str As String = oOO0oO000_0_0.OO.OoO0.(dataColumn.DataType)
							Dim text6 As String = ""
							If dataRow.IsNull(dataColumn) Then
								If Not dataRow.IsNull(dataColumn, DataRowVersion.Original) Then
									text6 = str + "{{null}}"
								End If
							ElseIf Operators.CompareString(dataRow(dataColumn).ToString(), dataRow(dataColumn, DataRowVersion.Original).ToString(), True) <> 0 Then
								If dataColumn.DataType Is GetType(DateTime) Then
									text6 = str + Conversions.ToDate(dataRow(dataColumn)).ToBinary().ToString()
								Else
									text6 = str + dataRow(dataColumn).ToString()
								End If
							End If
							If Operators.CompareString(text6, "", True) > 0 Then
								text4 = String.Concat(New String() { text4, Interaction.IIf(Operators.CompareString(text4, "", True) > 0, text, "").ToString(), dataColumn.ColumnName, text, text6.Replace(text, "").Replace(text2, "") })
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Operators.CompareString(text4, "", True) > 0 Then
					num2 += 1
					For Each dataColumn2 As DataColumn In dataRow.Table.PrimaryKey
						If list.Contains(dataColumn2.ColumnName.ToLower()) Then
							Dim str2 As String = oOO0oO000_0_0.OO.OoO0.(dataColumn2.DataType)
							Dim text7 As String
							If dataRow.IsNull(dataColumn2, DataRowVersion.Original) Then
								text7 = str2 + "{{null}}"
							ElseIf dataColumn2.DataType Is GetType(DateTime) Then
								text7 = str2 + Conversions.ToDate(dataRow(dataColumn2, DataRowVersion.Original)).ToBinary().ToString()
							Else
								text7 = str2 + dataRow(dataColumn2, DataRowVersion.Original).ToString()
							End If
							text5 = String.Concat(New String() { text5, Interaction.IIf(Operators.CompareString(text5, "", True) > 0, text, "").ToString(), dataColumn2.ColumnName, text, text7.Replace(text, "").Replace(text2, "") })
						End If
					Next
					text4 = text4 + text2 + text5
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text4, "fox", "table"))
				Else
					dataRow.AcceptChanges()
				End If
			Next
			Dim result As Boolean
			If num2 = 0 Then
				result = True
			Else
				Try
					Dim data As String = httpClient.GetData(True)
					If httpClient.RCookies.ContainsKey("Error") Then
						Throw New Exception(httpClient.RCookies("Error"))
					End If
					If Operators.CompareString(data, "", True) <= 0 Then
						Throw New Exception("未知HttpUpdate错误")
					End If
					Dim array As String() = data.Split(New Char() { "|"c })
					Dim num3 As Integer = array.Length - 1
					For k As Integer = 0 To num3
						If Versioned.IsNumeric(array(k)) AndAlso Conversions.ToInteger(array(k)) >= 1 Then
							A_1(k).AcceptChanges()
							oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1(k), 1, 1)
						Else
							If Operators.CompareString(array(k), "0", True) <> 0 Then
								Throw New Exception("HttpUpdate错误)" + array(k) + ")")
							End If
							oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1(k), 1, 0)
							A_1(k).Table.Rows.Remove(A_1(k))
						End If
					Next
					result = (array.Length = A_1.Length)
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
			Return result
		End Function

		' Token: 0x0600084A RID: 2122 RVA: 0x00038C10 File Offset: 0x00036E10
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataRow, A_2 As Integer, A_3 As Integer)
			Dim updateRowEventArgs As UpdateRowEventArgs = New UpdateRowEventArgs(A_0, New DataRow(A_1), A_2, A_3)
			If A_0.O_000o_.O. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
				Try
					A_0.O_000o_.O..Invoke(Nothing, New Object() { updateRowEventArgs })
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "表，" + A_0.Name + "，AfterSaveDataRow")
				End Try
			End If
			If Not updateRowEventArgs.Cancel AndAlso A_0.GlobalHandler.AfterSaveDataRow AndAlso OO_00oOO.SystemReady AndAlso O_O0OO.O0_00o.o0__o..Oo.o0_O. IsNot Nothing Then
				Try
					O_O0OO.O0_00o.o0__o..Oo.o0_O..Invoke(Nothing, New Object() { updateRowEventArgs })
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "全局表事件, AfterSaveDataRow")
				End Try
			End If
		End Sub

		' Token: 0x0600084B RID: 2123 RVA: 0x00038CF8 File Offset: 0x00036EF8
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, ParamArray A_1 As DataRow()) As Boolean
			Dim list As List(Of String) = A_0.UpdateColumns
			New Boolean(A_1.Length - 1 + 1 - 1) {}
			Dim text As String = vbVerticalTab & vbTab
			Dim oldValue As String = vbTab & vbVerticalTab
			Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(A_0.ConnectionName).oO0_0.o.()
			Dim text2 As String = Oo00.o_OoO._0_00.(A_0.HttpSelect).Trim()
			If text2.StartsWith("(") Then
				text2 = Oo00.oo_0__0.o.(text2)
			End If
			httpClient.FormData.Add("Action", 5.ToString())
			httpClient.FormData("DataTable") = text2
			Dim num As Integer = A_1.Length - 1
			For i As Integer = 0 To num
				Dim dataRow As DataRow = A_1(i)
				Dim text3 As String = Nothing
				For Each dataColumn As DataColumn In dataRow.Table.PrimaryKey
					If list.Contains(dataColumn.ColumnName.ToLower()) Then
						Dim str As String = oOO0oO000_0_0.OO.OoO0.(dataColumn.DataType)
						Dim text4 As String
						If dataRow.IsNull(dataColumn, DataRowVersion.Original) Then
							text4 = str + "{{null}}"
						ElseIf dataColumn.DataType Is GetType(DateTime) Then
							text4 = str + Conversions.ToDate(dataRow(dataColumn, DataRowVersion.Original)).ToBinary().ToString()
						Else
							text4 = str + dataRow(dataColumn, DataRowVersion.Original).ToString()
						End If
						text3 = String.Concat(New String() { text3, Interaction.IIf(Operators.CompareString(text3, "", True) > 0, text, "").ToString(), dataColumn.ColumnName, text, text4.Replace(text, "").Replace(oldValue, "") })
					End If
				Next
				If Operators.CompareString(text3, "", True) > 0 Then
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text3, "fox", "table"))
				End If
			Next
			Dim result As Boolean
			Try
				Dim data As String = httpClient.GetData(True)
				If httpClient.RCookies.ContainsKey("Error") Then
					Throw New Exception(httpClient.RCookies("Error"))
				End If
				If Operators.CompareString(data, "", True) <= 0 Then
					Throw New Exception("未知HttpDelete错误")
				End If
				Dim array As String() = data.Split(New Char() { "|"c })
				Dim num2 As Integer = array.Length - 1
				For k As Integer = 0 To num2
					If Operators.CompareString(array(k), "1", True) <> 0 AndAlso Operators.CompareString(array(k), "0", True) <> 0 Then
						Throw New Exception("HttpDelete错误(" + array(k) + ")")
					End If
					oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1(k), 2, 1)
					A_1(k).AcceptChanges()
				Next
				result = (array.Length = A_1.Length)
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			Return result
		End Function

		' Token: 0x0600084C RID: 2124 RVA: 0x00039044 File Offset: 0x00037244
		Private Function <<EMPTY_NAME>>(A_0 As Type) As String
			Dim result As String
			If A_0 Is GetType(String) Then
				result = "sr"
			ElseIf A_0 Is GetType(Boolean) Then
				result = "bl"
			ElseIf A_0 Is GetType(DateTime) Then
				result = "dt"
			ElseIf A_0 Is GetType(Byte) Then
				result = "bt"
			ElseIf A_0 Is GetType(Short) Then
				result = "st"
			ElseIf A_0 Is GetType(Integer) Then
				result = "in"
			ElseIf A_0 Is GetType(Long) Then
				result = "lg"
			ElseIf A_0 Is GetType(Single) Then
				result = "sg"
			ElseIf A_0 Is GetType(Double) Then
				result = "db"
			ElseIf A_0 Is GetType(Decimal) Then
				result = "dm"
			Else
				result = "sr"
			End If
			Return result
		End Function

		' Token: 0x0600084D RID: 2125 RVA: 0x00039138 File Offset: 0x00037338
		Friend Function <<EMPTY_NAME>>(A_0 As JObject) As Object
			Select Case CInt(A_0("Type"))
				Case 2
					Return CShort(A_0("Value"))
				Case 3
					Return CInt(A_0("Value"))
				Case 4
					Return CSng(A_0("Value"))
				Case 5
					Return CDbl(A_0("Value"))
				Case 7
					Return CType(A_0("Value"), DateTime)
				Case 8
					Return A_0("Value").ToString()
				Case 11
					Return CBool(A_0("Value"))
				Case 14
					Return CDec(A_0("Value"))
				Case 17
					Return CByte(A_0("Value"))
				Case 18
					Return CChar(A_0("Value"))
				Case 20
					Return CLng(A_0("Value"))
			End Select
			Return A_0("Value").ToString()
		End Function
	End Module
End Namespace
