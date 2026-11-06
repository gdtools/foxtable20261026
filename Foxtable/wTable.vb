Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000220 RID: 544
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0063")>
	Public Class wTable
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600193C RID: 6460 RVA: 0x000A3E3F File Offset: 0x000A203F
		Public Sub New(A_0 As String, A_1 As String)
			MyBase.New(A_0, A_1)
			Me.O_0oo._0O0. = New wRowCollection()
			Me.Oo__.o0_O. = New wRowCollection()
			Me.O_o_0.o___00. = New wRowCollection()
			Me.Oo__.o0_O. = "●○"
			Me.OOOOoO._0_O. = -1
		End Sub

		' Token: 0x17000596 RID: 1430
		' (get) Token: 0x0600193D RID: 6461 RVA: 0x000A3E7C File Offset: 0x000A207C
		<oO0oooo("A0064")>
		Public ReadOnly Property Head As wRowCollection
			Get
				Return Me.O_0oo._0O0.
			End Get
		End Property

		' Token: 0x17000597 RID: 1431
		' (get) Token: 0x0600193E RID: 6462 RVA: 0x000A3E84 File Offset: 0x000A2084
		Public ReadOnly Property Body As wRowCollection
			Get
				Return Me.Oo__.o0_O.
			End Get
		End Property

		' Token: 0x17000598 RID: 1432
		' (get) Token: 0x0600193F RID: 6463 RVA: 0x000A3E8C File Offset: 0x000A208C
		Public ReadOnly Property Foot As wRowCollection
			Get
				Return Me.O_o_0.o___00.
			End Get
		End Property

		' Token: 0x17000599 RID: 1433
		' (get) Token: 0x06001940 RID: 6464 RVA: 0x000A3E94 File Offset: 0x000A2094
		' (set) Token: 0x06001941 RID: 6465 RVA: 0x000A3E9C File Offset: 0x000A209C
		<oO0oooo("A0069")>
		Public Property Highlight As Integer
			Get
				Return Me.O_0oo._0O0.
			End Get
			Set(value As Integer)
				Me.O_0oo._0O0. = value
			End Set
		End Property

		' Token: 0x1700059A RID: 1434
		' (get) Token: 0x06001942 RID: 6466 RVA: 0x000A3EA5 File Offset: 0x000A20A5
		' (set) Token: 0x06001943 RID: 6467 RVA: 0x000A3EAD File Offset: 0x000A20AD
		<oO0oooo("A0070")>
		Public Property Alternate As Integer
			Get
				Return Me.Oo__.o0_O.
			End Get
			Set(value As Integer)
				Me.Oo__.o0_O. = value
			End Set
		End Property

		' Token: 0x1700059B RID: 1435
		' (get) Token: 0x06001944 RID: 6468 RVA: 0x000A3EB6 File Offset: 0x000A20B6
		' (set) Token: 0x06001945 RID: 6469 RVA: 0x000A3EBE File Offset: 0x000A20BE
		<oO0oooo("A0065")>
		Public Property MergeCols As Integer
			Get
				Return Me.oOoOoo0.OO_O.
			End Get
			Set(value As Integer)
				Me.oOoOoo0.OO_O. = value
			End Set
		End Property

		' Token: 0x1700059C RID: 1436
		' (get) Token: 0x06001946 RID: 6470 RVA: 0x000A3EC7 File Offset: 0x000A20C7
		' (set) Token: 0x06001947 RID: 6471 RVA: 0x000A3ECF File Offset: 0x000A20CF
		<oO0oooo("A0066")>
		Public Property RowHead As Integer
			Get
				Return Me.OOooO_o0.o.
			End Get
			Set(value As Integer)
				Me.OOooO_o0.o. = value
			End Set
		End Property

		' Token: 0x1700059D RID: 1437
		' (get) Token: 0x06001948 RID: 6472 RVA: 0x000A3ED8 File Offset: 0x000A20D8
		' (set) Token: 0x06001949 RID: 6473 RVA: 0x000A3EE0 File Offset: 0x000A20E0
		<oO0oooo("A0071")>
		Public Property ColWidth As String
			Get
				Return Me.O_0oo._0O0.
			End Get
			Set(value As String)
				Me.O_0oo._0O0. = value
			End Set
		End Property

		' Token: 0x1700059E RID: 1438
		' (get) Token: 0x0600194A RID: 6474 RVA: 0x000A3EE9 File Offset: 0x000A20E9
		' (set) Token: 0x0600194B RID: 6475 RVA: 0x000A3EF1 File Offset: 0x000A20F1
		<oO0oooo("A0074")>
		Public Property BooleanSymbol As String
			Get
				Return Me.Oo__.o0_O.
			End Get
			Set(value As String)
				If value IsNot Nothing AndAlso value.Length = 2 Then
					Me.Oo__.o0_O. = value
				End If
			End Set
		End Property

		' Token: 0x1700059F RID: 1439
		' (get) Token: 0x0600194C RID: 6476 RVA: 0x000A3F06 File Offset: 0x000A2106
		' (set) Token: 0x0600194D RID: 6477 RVA: 0x000A3F0E File Offset: 0x000A210E
		<oO0oooo("A0118")>
		Public Property Primarykey As String
			Get
				Return Me.OOooO_o0.o.
			End Get
			Set(value As String)
				Me.OOooO_o0.o. = value
			End Set
		End Property

		' Token: 0x170005A0 RID: 1440
		' (get) Token: 0x0600194E RID: 6478 RVA: 0x000A3F17 File Offset: 0x000A2117
		' (set) Token: 0x0600194F RID: 6479 RVA: 0x000A3F1F File Offset: 0x000A211F
		<oO0oooo("A0118")>
		Public Property PageNumber As Integer
			Get
				Return Me.OOOOoO._0_O.
			End Get
			Set(value As Integer)
				Me.OOOOoO._0_O. = value
			End Set
		End Property

		' Token: 0x170005A1 RID: 1441
		' (get) Token: 0x06001950 RID: 6480 RVA: 0x000A3F28 File Offset: 0x000A2128
		' (set) Token: 0x06001951 RID: 6481 RVA: 0x000A3F30 File Offset: 0x000A2130
		<oO0oooo("A0117")>
		Public Property ActiveSheet As String
			Get
				Return Me.oOoOoo0.OO_O.
			End Get
			Set(value As String)
				Me.oOoOoo0.OO_O. = value
			End Set
		End Property

		' Token: 0x170005A2 RID: 1442
		' (get) Token: 0x06001952 RID: 6482 RVA: 0x000A3F39 File Offset: 0x000A2139
		' (set) Token: 0x06001953 RID: 6483 RVA: 0x000A3F41 File Offset: 0x000A2141
		<oO0oooo("A0147")>
		Public Property AfterSelChange As String
			Get
				Return Me.OoO_O.o0.
			End Get
			Set(value As String)
				Me.OoO_O.o0. = value
			End Set
		End Property

		' Token: 0x06001954 RID: 6484 RVA: 0x000A3F4C File Offset: 0x000A214C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append(String.Concat(New String() { "<table id='", MyBase.ID, "' name='", MyBase.ID, "' class='fox_table" }))
			Select Case Me.Highlight
				Case 0
					A_0.Append(" fox_highligh_row fox_highligh_col")
				Case 1
					A_0.Append(" fox_highligh_row")
				Case 2
					A_0.Append(" fox_highligh_col")
			End Select
			A_0.Append("'")
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" " + MyBase.[Class])
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.Append(" data-fixed='" + Conversions.ToString(Me.O_0oo._0O0..Count) + "'")
			If Me.O_0oo._0O0..Count > 0 Then
				A_0.Append(" data-cols='" + Conversions.ToString(Me.O_0oo._0O0.(0).o0oO._0o0_O..Count) + "'")
			ElseIf Me.Oo__.o0_O..Count > 0 Then
				A_0.Append(" data-cols='" + Conversions.ToString(Me.Oo__.o0_O.(0).o0oO._0o0_O..Count) + "'")
			ElseIf Me.O_o_0.o___00..Count > 0 Then
				A_0.Append(" data-cols='" + Conversions.ToString(Me.O_o_0.o___00.(0).o0oO._0o0_O..Count) + "'")
			End If
			If Operators.CompareString(Me.oOoOoo0.OO_O., "", True) > 0 Then
				A_0.Append(" data-activesheet='" + Me.oOoOoo0.OO_O. + "'")
			End If
			If Me.OOOOoO._0_O. >= 0 Then
				A_0.Append(" data-pagenumber='" + Conversions.ToString(Me.OOOOoO._0_O.) + "'")
			End If
			If Operators.CompareString(Me.OoO_O.o0., "", True) > 0 Then
				A_0.Append(" data-afterselchange='" + Me.OoO_O.o0. + "'")
			End If
			A_0.AppendLine(">")
			If Me.O_0oo._0O0..Count > 0 Then
				A_0.AppendLine("<thead>")
				Dim num As Integer = Me.O_0oo._0O0..Count - 1
				For i As Integer = 0 To num
					Dim wTableRow As wTableRow = Me.O_0oo._0O0.(i)
					wTableRow.o0oO._0o0_O. = True
					wTableRow.OOooOo.00OO_.(A_0, i, Me.O_0oo._0O0., Me.oOoOoo0.OO_O., False, 0, Me.ColWidth)
				Next
				A_0.AppendLine("</thead>")
			End If
			If Me.Oo__.o0_O..Count > 0 Then
				A_0.AppendLine("<tbody>")
				Dim num2 As Integer = Me.Oo__.o0_O..Count - 1
				For j As Integer = 0 To num2
					Me.Oo__.o0_O.(j).OOooOo.00OO_.(A_0, j, Me.Oo__.o0_O., Me.oOoOoo0.OO_O., Me.o0OO0.oo0OO.(j), Me.OOooO_o0.o., "")
				Next
				A_0.AppendLine("</tbody>")
			End If
			If Me.O_o_0.o___00..Count > 0 Then
				A_0.AppendLine("<tfoot>")
				Dim num3 As Integer = Me.O_o_0.o___00..Count - 1
				For k As Integer = 0 To num3
					Me.O_o_0.o___00.(k).OOooOo.00OO_.(A_0, k, Me.O_o_0.o___00., Me.oOoOoo0.OO_O., False, Me.OOooO_o0.o., "")
				Next
				A_0.AppendLine("</tfoot>")
			End If
			A_0.AppendLine("</table>")
		End Sub

		' Token: 0x06001955 RID: 6485 RVA: 0x000A4320 File Offset: 0x000A2520
		Private Function <<EMPTY_NAME>>(A_0 As Integer) As Boolean
			Return Me.Alternate >= 2 AndAlso (A_0 + 1) Mod Me.Alternate = 0
		End Function

		' Token: 0x06001956 RID: 6486 RVA: 0x000A434C File Offset: 0x000A254C
		<oO0oooo("0074")>
		Public Sub CreateFromDataTable(dataTable As DataTable, RowNum As Boolean, Filter As String, Sort As String, ParamArray dataCols As String())
			If RowNum Then
				Me.RowHead = 1
			End If
			Dim num As Integer
			For Each text As String In dataCols
				Dim text2 As String = text
				If Operators.CompareString(dataTable.DataCols(text).Caption, "", True) > 0 Then
					text2 = dataTable.DataCols(text).Caption
				End If
				num = Math.Max(num, text2.Split(New Char() { "_"c }).Length)
			Next
			Dim num2 As Integer = num - 1
			For j As Integer = 0 To num2
				Dim list As List(Of String) = New List(Of String)()
				If RowNum Then
					list.Add("")
				End If
				For Each text3 As String In dataCols
					Dim text4 As String = text3
					If Operators.CompareString(dataTable.DataCols(text3).Caption, "", True) > 0 Then
						text4 = dataTable.DataCols(text3).Caption
					End If
					Dim array As String() = text4.Split(New Char() { "_"c })
					If array.Length > j Then
						list.Add(array(j))
					Else
						list.Add(array(array.Length - 1))
					End If
				Next
				Me.Head.AddRow(list)
			Next
			Dim dataColumn As DataColumn = Nothing
			If Operators.CompareString(Me.Primarykey, "", True) > 0 Then
				dataColumn = dataTable.BaseTable.Columns(Me.Primarykey)
			End If
			Try
				For Each dataRow As DataRow In dataTable.[Select](Filter, Sort)
					Dim num3 As Integer
					num3 += 1
					Dim wTableRow As wTableRow = Me.Body.AddRow(New String(-1) {})
					If dataColumn IsNot Nothing Then
						wTableRow.OOooO_o0.o. = dataRow.BaseRow(dataColumn).ToString()
					End If
					If RowNum Then
						wTableRow.AddCell(num3.ToString(), "")
					End If
					For Each text5 As String In dataCols
						If dataRow.get_IsNull(text5) Then
							wTableRow.AddCell("", "")
						ElseIf dataTable.DataCols(text5).IsBoolean Then
							If Conversions.ToBoolean(dataRow(text5)) Then
								wTableRow.AddCell(Conversions.ToString(Me.BooleanSymbol(0)), "")
							Else
								wTableRow.AddCell(Conversions.ToString(Me.BooleanSymbol(1)), "")
							End If
						ElseIf dataTable.DataCols(text5).IsDate Then
							wTableRow.AddCell(Strings.Format(RuntimeHelpers.GetObjectValue(dataRow(text5)), "yyyy-MM-dd"), "")
						Else
							Dim name As String = dataTable.DataCols(text5).DataType.Name
							If Operators.CompareString(name, "single", True) = 0 OrElse Operators.CompareString(name, "double", True) = 0 OrElse Operators.CompareString(name, "decimal", True) = 0 Then
								If dataTable.DataCols(text5).BaseColumn.ExtendedProperties.Contains("displayformat") Then
									wTableRow.AddCell(Strings.Format(RuntimeHelpers.GetObjectValue(dataRow(text5)), dataTable.DataCols(text5).BaseColumn.ExtendedProperties("displayformat").ToString()), "")
								Else
									wTableRow.AddCell(Strings.Format(RuntimeHelpers.GetObjectValue(dataRow(text5)), "#0.00"), "")
								End If
							Else
								wTableRow.AddCell(dataRow(text5).ToString(), "")
							End If
						End If
					Next
				Next
			Finally
				Dim enumerator As List(Of DataRow).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06001957 RID: 6487 RVA: 0x000A4754 File Offset: 0x000A2954
		Public Sub CreateFromDataTable(dataTable As DataTable, RowNum As Boolean, Filter As String, Sort As String, dataCols As List(Of String))
			Me.CreateFromDataTable(dataTable, RowNum, Filter, Sort, dataCols.ToArray())
		End Sub

		' Token: 0x06001958 RID: 6488 RVA: 0x000A4768 File Offset: 0x000A2968
		Public Sub CreateFromDataTable(dataTable As DataTable, RowNum As Boolean, Filter As String, Sort As String)
			Dim list As List(Of String) = New List(Of String)()
			Try
				For Each dataCol As DataCol In dataTable.DataCols
					list.Add(dataCol.Name)
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.CreateFromDataTable(dataTable, RowNum, Filter, Sort, list.ToArray())
		End Sub

		' Token: 0x06001959 RID: 6489 RVA: 0x000A47D4 File Offset: 0x000A29D4
		Public Sub CreateFromDataTable(dataTable As DataTable, RowNum As Boolean, Filter As String)
			Me.CreateFromDataTable(dataTable, RowNum, Filter, "")
		End Sub

		' Token: 0x0600195A RID: 6490 RVA: 0x000A47E4 File Offset: 0x000A29E4
		Public Sub CreateFromDataTable(dataTable As DataTable, RowNum As Boolean)
			Me.CreateFromDataTable(dataTable, RowNum, "", "")
		End Sub

		' Token: 0x0600195B RID: 6491 RVA: 0x000A47F8 File Offset: 0x000A29F8
		Public Sub CreateFromDataTable(dataTable As DataTable)
			Me.CreateFromDataTable(dataTable, False, "", "")
		End Sub

		' Token: 0x0600195C RID: 6492 RVA: 0x000A480C File Offset: 0x000A2A0C
		Public Sub CreateFromTable(table As Table, RowNum As Boolean, ParamArray Cols As String())
			If RowNum Then
				Me.RowHead = 1
			End If
			Dim num As Integer = table.Grid.Rows.Count - 1
			For i As Integer = 0 To num
				Dim list As List(Of String) = New List(Of String)()
				If RowNum Then
					If i < table.Grid.Rows.Fixed Then
						list.Add("")
					Else
						list.Add((i - table.Grid.Rows.Fixed + 1).ToString())
					End If
				End If
				For Each text As String In Cols
					If table.Cols(text).IsBoolean() AndAlso i >= table.Grid.Rows.Fixed Then
						If table.Grid.GetCellCheck(i, table.Grid.Cols(text).Index) = 1 Then
							list.Add(Conversions.ToString(Me.BooleanSymbol(0)))
						Else
							list.Add(Conversions.ToString(Me.BooleanSymbol(1)))
						End If
					Else
						list.Add(table.Grid.GetDataDisplay(i, text).ToString())
					End If
				Next
				If i < table.Grid.Rows.Fixed Then
					Me.Head.AddRow(list.ToArray())
				Else
					Me.Body.AddRow(list.ToArray())
				End If
			Next
		End Sub

		' Token: 0x0600195D RID: 6493 RVA: 0x000A4982 File Offset: 0x000A2B82
		Public Sub CreateFromTable(table As Table, RowNum As Boolean, Cols As List(Of String))
			Me.CreateFromTable(table, RowNum, Cols.ToArray())
		End Sub

		' Token: 0x0600195E RID: 6494 RVA: 0x000A4994 File Offset: 0x000A2B94
		Public Sub CreateFromTable(table As Table, RowNum As Boolean, OnlyVisible As Boolean)
			Dim list As List(Of String) = New List(Of String)()
			Dim num As Integer = table.Cols.Count - 1
			For i As Integer = 0 To num
				If table.Cols(i).Visible Then
					list.Add(table.Cols(i).Name)
				End If
			Next
			Me.CreateFromTable(table, RowNum, list.ToArray())
		End Sub

		' Token: 0x0600195F RID: 6495 RVA: 0x000A4A04 File Offset: 0x000A2C04
		Public Sub CreateFromTable(table As Table, RowNum As Boolean)
			Dim list As List(Of String) = New List(Of String)()
			Dim num As Integer = table.Cols.Count - 1
			For i As Integer = 0 To num
				list.Add(table.Cols(i).Name)
			Next
			Me.CreateFromTable(table, RowNum, list.ToArray())
		End Sub

		' Token: 0x06001960 RID: 6496 RVA: 0x000A4A5B File Offset: 0x000A2C5B
		Public Sub CreateFromTable(table As Table)
			Me.CreateFromTable(table, False)
		End Sub

		' Token: 0x04000AA4 RID: 2724
		Private <<EMPTY_NAME>> As wRowCollection

		' Token: 0x04000AA5 RID: 2725
		Private <<EMPTY_NAME>> As wRowCollection

		' Token: 0x04000AA6 RID: 2726
		Private <<EMPTY_NAME>> As wRowCollection

		' Token: 0x04000AA7 RID: 2727
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AA8 RID: 2728
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AA9 RID: 2729
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AAA RID: 2730
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AAB RID: 2731
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AAC RID: 2732
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AAD RID: 2733
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AAE RID: 2734
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AAF RID: 2735
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AB0 RID: 2736
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
