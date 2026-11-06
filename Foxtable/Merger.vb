Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200033A RID: 826
	<oO0oooo("0685")>
	<ComVisible(True)>
	Public Class Merger
		' Token: 0x0600318D RID: 12685 RVA: 0x00141F84 File Offset: 0x00140184
		Public Sub New()
			Me.o_O00_O.Oo. = True
			Me.o_O00_O.Oo. = New Dictionary(Of String, String)()
			Me.o.o_oo0OoO. = New DataTable()
		End Sub

		' Token: 0x17000CB9 RID: 3257
		' (get) Token: 0x0600318E RID: 12686 RVA: 0x00141FA9 File Offset: 0x001401A9
		' (set) Token: 0x0600318F RID: 12687 RVA: 0x00141FB1 File Offset: 0x001401B1
		Public Property SourcePath As String
			Get
				Return Me.o_O00_O.Oo.
			End Get
			Set(value As String)
				Me.o_O00_O.Oo. = value
			End Set
		End Property

		' Token: 0x17000CBA RID: 3258
		' (get) Token: 0x06003190 RID: 12688 RVA: 0x00141FBA File Offset: 0x001401BA
		' (set) Token: 0x06003191 RID: 12689 RVA: 0x00141FC2 File Offset: 0x001401C2
		Public Property ConnectionName As String
			Get
				Return Me.oo_o.ooO0_o.
			End Get
			Set(value As String)
				Me.oo_o.ooO0_o. = value
			End Set
		End Property

		' Token: 0x17000CBB RID: 3259
		' (get) Token: 0x06003192 RID: 12690 RVA: 0x00141FCB File Offset: 0x001401CB
		' (set) Token: 0x06003193 RID: 12691 RVA: 0x00141FD3 File Offset: 0x001401D3
		Public Property SourceTableName As String
			Get
				Return Me.oO__.o.
			End Get
			Set(value As String)
				Me.oO__.o. = value
			End Set
		End Property

		' Token: 0x17000CBC RID: 3260
		' (get) Token: 0x06003194 RID: 12692 RVA: 0x00141FDC File Offset: 0x001401DC
		' (set) Token: 0x06003195 RID: 12693 RVA: 0x00141FE4 File Offset: 0x001401E4
		Public Property Format As String
			Get
				Return Me.o_0_o_0_0.o.
			End Get
			Set(value As String)
				Me.o_0_o_0_0.o. = value
			End Set
		End Property

		' Token: 0x17000CBD RID: 3261
		' (get) Token: 0x06003196 RID: 12694 RVA: 0x00141FED File Offset: 0x001401ED
		' (set) Token: 0x06003197 RID: 12695 RVA: 0x00141FF5 File Offset: 0x001401F5
		Public Property Fields As String
			Get
				Return Me.O_o0OO0.O0O_.
			End Get
			Set(value As String)
				Me.O_o0OO0.O0O_. = value
			End Set
		End Property

		' Token: 0x17000CBE RID: 3262
		' (get) Token: 0x06003198 RID: 12696 RVA: 0x00141FFE File Offset: 0x001401FE
		' (set) Token: 0x06003199 RID: 12697 RVA: 0x00142006 File Offset: 0x00140206
		Public Property PassWord As String
			Get
				Return Me.O_OoOoO.oo0o_.
			End Get
			Set(value As String)
				Me.O_OoOoO.oo0o_. = value
			End Set
		End Property

		' Token: 0x17000CBF RID: 3263
		' (get) Token: 0x0600319A RID: 12698 RVA: 0x0014200F File Offset: 0x0014020F
		' (set) Token: 0x0600319B RID: 12699 RVA: 0x00142017 File Offset: 0x00140217
		Public Property Filter As String
			Get
				Return Me.o_oo00.o_oo.
			End Get
			Set(value As String)
				Me.o_oo00.o_oo. = value
			End Set
		End Property

		' Token: 0x17000CC0 RID: 3264
		' (get) Token: 0x0600319C RID: 12700 RVA: 0x00142020 File Offset: 0x00140220
		' (set) Token: 0x0600319D RID: 12701 RVA: 0x00142028 File Offset: 0x00140228
		Public Property DataTableName As String
			Get
				Return Me.OO0.0O_000.
			End Get
			Set(value As String)
				Me.OO0.0O_000. = value
			End Set
		End Property

		' Token: 0x17000CC1 RID: 3265
		' (get) Token: 0x0600319E RID: 12702 RVA: 0x00142031 File Offset: 0x00140231
		' (set) Token: 0x0600319F RID: 12703 RVA: 0x00142039 File Offset: 0x00140239
		Public Property Header As Boolean
			Get
				Return Me.o_O00_O.Oo.
			End Get
			Set(value As Boolean)
				Me.o_O00_O.Oo. = value
			End Set
		End Property

		' Token: 0x17000CC2 RID: 3266
		' (get) Token: 0x060031A0 RID: 12704 RVA: 0x00142042 File Offset: 0x00140242
		Public ReadOnly Property FieldMaps As Dictionary(Of String, String)
			Get
				Return Me.o_O00_O.Oo.
			End Get
		End Property

		' Token: 0x060031A1 RID: 12705 RVA: 0x0014204C File Offset: 0x0014024C
		Public Sub Merge()
			If Operators.CompareString(Me.Fields, "", True) = 0 Then
				Me.Fields = "*"
			End If
			If Operators.CompareString(Me.ConnectionName, "", True) = 0 Then
				Dim format As String = Me.Format
				Dim text As String
				If Operators.CompareString(format, "", True) = 0 OrElse Operators.CompareString(format, "access", True) = 0 OrElse Operators.CompareString(format, "access2007", True) = 0 OrElse Operators.CompareString(format, "access 2007", True) = 0 Then
					If Operators.CompareString(Me.PassWord, "", True) = 0 Then
						text = String.Concat(New String() { "[;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
					Else
						text = String.Concat(New String() { "[;DATABASE=", Me.SourcePath, ";PWD=", Me.PassWord, "].[", Me.SourceTableName, "]" })
					End If
				ElseIf Operators.CompareString(format, "excel", True) = 0 Then
					text = String.Concat(New String() { "[EXCEL 8.0;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				ElseIf Operators.CompareString(format, "excel2007", True) = 0 OrElse Operators.CompareString(format, "excel 2007", True) = 0 Then
					text = String.Concat(New String() { "[EXCEL 12.0;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				ElseIf Operators.CompareString(format, "dbase", True) = 0 Then
					text = String.Concat(New String() { "[dBASE IV;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				ElseIf Operators.CompareString(format, "Delimited", True) = 0 Then
					If Me.Header Then
						text = String.Concat(New String() { "[text;HDR=Yes;FMT=Delimited;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "#txt]" })
					Else
						text = String.Concat(New String() { "[text;HDR=No;FMT=Delimited;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "#txt]" })
					End If
				Else
					If Operators.CompareString(format, "Fixed", True) <> 0 Then
						Return
					End If
					If Me.Header Then
						text = String.Concat(New String() { "[text;HDR=Yes;FMT=Fixed;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "#txt]" })
					Else
						text = String.Concat(New String() { "[text;HDR=No;FMT=Fixed;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "#txt]" })
					End If
				End If
				text = "Select " + Me.Fields + " From " + text
				If Operators.CompareString(Me.Filter, "", True) > 0 Then
					text = text + " Where " + Me.Filter
				End If
				If Me.SourcePath.ToLower().EndsWith(".accdb") OrElse Me.SourcePath.ToLower().EndsWith(".xlsx") Then
					Me.o.o_oo0OoO. = New OleDbDataAdapter("", Oo00.OOO_O0O0.o.(OO_00oOO.ProjectFile))
				Else
					Me.o.o_oo0OoO. = New OleDbDataAdapter("", O_O0OO.OoO.0OO__0ooo.())
				End If
				Me.o.o_oo0OoO..SelectCommand.CommandText = text
			Else
				Dim text As String = "Select " + Me.Fields + " From " + Me.SourceTableName
				If Operators.CompareString(Me.Filter, "", True) > 0 Then
					text = text + " Where " + Me.Filter
				End If
				Me.o.o_oo0OoO. = New OleDbDataAdapter(text, O_O0OO.O._o_.()(Me.ConnectionName))
			End If
			Try
				Dim list As List(Of String) = New List(Of String)()
				New Dictionary(Of String, String)()
				Me.o.o_oo0OoO..Fill(Me.o.o_oo0OoO.)
				Try
					For Each obj As Object In Me.o.o_oo0OoO..Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) AndAlso Operators.CompareString(dataColumn.ColumnName, "_SortKey", True) <> 0 Then
							list.Add(dataColumn.ColumnName)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Try
					For Each name As String In list
						Me.o.o_oo0OoO..Columns.Remove(name)
					Next
				Finally
					Dim enumerator2 As List(Of String).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				list.Clear()
				Try
					For Each obj2 As Object In Me.o.o_oo0OoO..Columns
						Dim dataColumn2 As DataColumn = CType(obj2, DataColumn)
						If Me.FieldMaps.ContainsKey(dataColumn2.ColumnName) Then
							dataColumn2.Caption = Me.FieldMaps(dataColumn2.ColumnName)
						ElseIf O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.DataTableName).Columns.Contains(dataColumn2.ColumnName) Then
							If Not Me.FieldMaps.ContainsValue(dataColumn2.ColumnName) Then
								dataColumn2.Caption = dataColumn2.ColumnName
							Else
								list.Add(dataColumn2.ColumnName)
							End If
						Else
							list.Add(dataColumn2.ColumnName)
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator
					If TypeOf enumerator3 Is IDisposable Then
						TryCast(enumerator3, IDisposable).Dispose()
					End If
				End Try
				Try
					For Each name2 As String In list
						Me.o.o_oo0OoO..Columns.Remove(name2)
					Next
				Finally
					Dim enumerator4 As List(Of String).Enumerator
					CType(enumerator4, IDisposable).Dispose()
				End Try
				OO_00oOO.DataTables(Me.DataTableName).StopRedraw()
				Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.DataTableName)
				Dim list2 As List(Of DataRow) = New List(Of DataRow)()
				Dim array As DataRow()
				If Me.o.o_oo0OoO..Columns.Contains("_SortKey") Then
					array = Me.o.o_oo0OoO..[Select]("", "[_SortKey]")
				Else
					array = Me.o.o_oo0OoO..[Select]()
				End If
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					list2.Add(dataTable.NewRow())
				Next
				Try
					For Each obj3 As Object In Me.o.o_oo0OoO..Columns
						Dim dataColumn3 As DataColumn = CType(obj3, DataColumn)
						Dim caption As String = dataColumn3.Caption
						If Operators.CompareString(caption, "_SortKey", True) <> 0 Then
							Dim num2 As Integer = list2.Count - 1
							For j As Integer = 0 To num2
								list2(j)(caption) = RuntimeHelpers.GetObjectValue(array(j)(dataColumn3))
							Next
						End If
					Next
				Finally
					Dim enumerator5 As IEnumerator
					If TypeOf enumerator5 Is IDisposable Then
						TryCast(enumerator5, IDisposable).Dispose()
					End If
				End Try
				Try
					For Each row As DataRow In list2
						dataTable.Rows.Add(row)
					Next
				Finally
					Dim enumerator6 As List(Of DataRow).Enumerator
					CType(enumerator6, IDisposable).Dispose()
				End Try
				dataTable = Nothing
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				OO_00oOO.DataTables(Me.DataTableName).ResumeRedraw()
			End Try
		End Sub

		' Token: 0x040013E7 RID: 5095
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E8 RID: 5096
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E9 RID: 5097
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013EA RID: 5098
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013EB RID: 5099
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013EC RID: 5100
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013ED RID: 5101
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013EE RID: 5102
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040013EF RID: 5103
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x040013F0 RID: 5104
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013F1 RID: 5105
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040013F2 RID: 5106
		Private <<EMPTY_NAME>> As OleDbDataAdapter
	End Class
End Namespace
