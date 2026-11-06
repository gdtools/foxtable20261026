Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000304 RID: 772
	<oO0oooo("1375")>
	<ComVisible(True)>
	Public Class Col
		' Token: 0x06002857 RID: 10327 RVA: 0x0010DE93 File Offset: 0x0010C093
		Friend Sub New(A_0 As Table, A_1 As String)
			Me.O_00_o.__. = 0
			Me.O0o0._O. = 1
			Me.o0O0oO.0. = 0
			Me.o0OO_.O00___. = 0
			Me.oOoO00.o. = 0
			Me.ooO_o.o___o. = 0
			Me.o_o_O.0000_O. = A_0
			Me.o_o_O.0000_O. = A_1
		End Sub

		' Token: 0x1700095C RID: 2396
		' (get) Token: 0x06002858 RID: 10328 RVA: 0x0010DED3 File Offset: 0x0010C0D3
		<oO0oooo("0568")>
		Public ReadOnly Property Name As String
			Get
				Return Me.o_o_O.0000_O.
			End Get
		End Property

		' Token: 0x1700095D RID: 2397
		' (get) Token: 0x06002859 RID: 10329 RVA: 0x0010DEDC File Offset: 0x0010C0DC
		' (set) Token: 0x0600285A RID: 10330 RVA: 0x0010DF70 File Offset: 0x0010C170
		<oO0oooo("0570")>
		Public Property Caption As String
			Get
				Dim caption As String
				If Operators.CompareString(Me.o0O0oO.0., "", True) > 0 Then
					caption = Me.o0O0oO.0.
				ElseIf Operators.CompareString(Me.DataCol.Setting.Caption, "", True) > 0 Then
					caption = Me.DataCol.Setting.Caption
				ElseIf Operators.CompareString(Me.DataCol.BaseColumn.Caption, "", True) > 0 Then
					caption = Me.DataCol.BaseColumn.Caption
				Else
					caption = Me.o_o_O.0000_O.
				End If
				Return caption
			End Get
			Set(value As String)
				Me.o0O0oO.0. = value
			End Set
		End Property

		' Token: 0x1700095E RID: 2398
		' (get) Token: 0x0600285B RID: 10331 RVA: 0x0010DF7C File Offset: 0x0010C17C
		' (set) Token: 0x0600285C RID: 10332 RVA: 0x0010DFD5 File Offset: 0x0010C1D5
		<oO0oooo("2201")>
		Public Property ShortCaption As String
			Get
				Dim result As String
				If Operators.CompareString(Me.oo_.OoOO0., "", True) > 0 Then
					result = Me.oo_.OoOO0.
				ElseIf Operators.CompareString(Me.DataCol.ShortCaption, "", True) > 0 Then
					result = Me.DataCol.ShortCaption
				Else
					result = Me.Caption
				End If
				Return result
			End Get
			Set(value As String)
				Me.oo_.OoOO0. = value
				If Me.Table.RecordGridVisible Then
					Me.Table.o00oOO00_.ooOo..O0_00O.0__.()
				End If
			End Set
		End Property

		' Token: 0x1700095F RID: 2399
		' (get) Token: 0x0600285D RID: 10333 RVA: 0x0010DFFC File Offset: 0x0010C1FC
		' (set) Token: 0x0600285E RID: 10334 RVA: 0x0010E028 File Offset: 0x0010C228
		<oO0oooo("2201")>
		Public Property RecordRowHeight As Integer
			Get
				Dim result As Integer
				If Me.O0o0._O. <> 1 Then
					result = Me.O0o0._O.
				Else
					result = Me.DataCol.RecordRowHeight
				End If
				Return result
			End Get
			Set(value As Integer)
				Me.O0o0._O. = value
				If Me.Table.RecordGridVisible Then
					Me.Table.o00oOO00_.ooOo..O0_00O.0__.()
				End If
			End Set
		End Property

		' Token: 0x17000960 RID: 2400
		' (get) Token: 0x0600285F RID: 10335 RVA: 0x0010E050 File Offset: 0x0010C250
		' (set) Token: 0x06002860 RID: 10336 RVA: 0x0010E097 File Offset: 0x0010C297
		<oO0oooo("2201")>
		Public Property ShowInRecordGrid As Boolean
			Get
				Dim result As Boolean
				If Me.ooO_o.o___o. Is Nothing Then
					If Me.DataCol.ShowInRecordGrid Is Nothing Then
						result = Me.Visible
					Else
						result = (Me.DataCol.ShowInRecordGrid = 1)
					End If
				Else
					result = (Me.ooO_o.o___o. = 1)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.ooO_o.o___o. = 1
				Else
					Me.ooO_o.o___o. = 2
				End If
				If Me.Table.RecordGridVisible Then
					Me.Table.o00oOO00_.ooOo..O0_00O.0__.()
				End If
			End Set
		End Property

		' Token: 0x17000961 RID: 2401
		' (get) Token: 0x06002861 RID: 10337 RVA: 0x0010E0C9 File Offset: 0x0010C2C9
		<oO0oooo("0571")>
		Public ReadOnly Property DataCol As DataCol
			Get
				Return Me.Table.DataTable.DataCols(Me.o_o_O.0000_O.)
			End Get
		End Property

		' Token: 0x17000962 RID: 2402
		' (get) Token: 0x06002862 RID: 10338 RVA: 0x0010E0E6 File Offset: 0x0010C2E6
		Public ReadOnly Property DataTable As DataTable
			Get
				Return Me.Table.DataTable
			End Get
		End Property

		' Token: 0x17000963 RID: 2403
		' (get) Token: 0x06002863 RID: 10339 RVA: 0x0010E0F3 File Offset: 0x0010C2F3
		Public ReadOnly Property Table As Table
			Get
				Return Me.o_o_O.0000_O.
			End Get
		End Property

		' Token: 0x17000964 RID: 2404
		' (get) Token: 0x06002864 RID: 10340 RVA: 0x0010E0FC File Offset: 0x0010C2FC
		<oO0oooo("0569")>
		Public ReadOnly Property Index As Integer
			Get
				Dim result As Integer
				If Me.o_o_O.0000_O..foxGrid.Cols.Contains(Me.o_o_O.0000_O.) Then
					result = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Index - Me.o_o_O.0000_O..foxGrid.Cols.Fixed
				Else
					result = -1
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000965 RID: 2405
		' (get) Token: 0x06002865 RID: 10341 RVA: 0x0010E162 File Offset: 0x0010C362
		' (set) Token: 0x06002866 RID: 10342 RVA: 0x0010E184 File Offset: 0x0010C384
		<oO0oooo("0572")>
		Public Property Visible As Boolean
			Get
				Return Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Visible
			End Get
			Set(value As Boolean)
				Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Visible = value
			End Set
		End Property

		' Token: 0x06002867 RID: 10343 RVA: 0x0010E1A7 File Offset: 0x0010C3A7
		<oO0oooo("0587")>
		Public Sub Move(Position As Integer)
			Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Move(Position + Me.o_o_O.0000_O..foxGrid.Cols.Fixed)
		End Sub

		' Token: 0x17000966 RID: 2406
		' (get) Token: 0x06002868 RID: 10344 RVA: 0x0010E1E0 File Offset: 0x0010C3E0
		' (set) Token: 0x06002869 RID: 10345 RVA: 0x0010E213 File Offset: 0x0010C413
		<oO0oooo("0573")>
		Public Property AllowEdit As Boolean
			Get
				Dim result As Boolean
				If Me.O_00_o.__. Is Nothing Then
					result = Me.DataCol.AllowEdit
				Else
					result = (Me.O_00_o.__. = 1)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.O_00_o.__. = 1
				Else
					Me.O_00_o.__. = 2
				End If
				Main.OO_O.o..O.ooO0. = True
			End Set
		End Property

		' Token: 0x17000967 RID: 2407
		' (get) Token: 0x0600286A RID: 10346 RVA: 0x0010E233 File Offset: 0x0010C433
		' (set) Token: 0x0600286B RID: 10347 RVA: 0x0010E23B File Offset: 0x0010C43B
		<oO0oooo("2750")>
		Public Property GrandTotal As Boolean
			Get
				Return Me.O0o0._O.
			End Get
			Set(value As Boolean)
				Me.O0o0._O. = value
			End Set
		End Property

		' Token: 0x17000968 RID: 2408
		' (get) Token: 0x0600286C RID: 10348 RVA: 0x0010E244 File Offset: 0x0010C444
		' (set) Token: 0x0600286D RID: 10349 RVA: 0x0010E24C File Offset: 0x0010C44C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property CodeDictonary As Dictionary(Of String, String)
			Get
				Return Me.O0o0._O.
			End Get
			Set(value As Dictionary(Of String, String))
				Me.O0o0._O. = value
			End Set
		End Property

		' Token: 0x17000969 RID: 2409
		' (get) Token: 0x0600286E RID: 10350 RVA: 0x0010E255 File Offset: 0x0010C455
		' (set) Token: 0x0600286F RID: 10351 RVA: 0x0010E25D File Offset: 0x0010C45D
		<oO0oooo("2125")>
		Public Property CodeDictionary As Dictionary(Of String, String)
			Get
				Return Me.O0o0._O.
			End Get
			Set(value As Dictionary(Of String, String))
				Me.O0o0._O. = value
			End Set
		End Property

		' Token: 0x1700096A RID: 2410
		' (get) Token: 0x06002870 RID: 10352 RVA: 0x0010E266 File Offset: 0x0010C466
		' (set) Token: 0x06002871 RID: 10353 RVA: 0x0010E288 File Offset: 0x0010C488
		<oO0oooo("1836")>
		Public Property DataMap As IDictionary
			Get
				Return Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).DataMap
			End Get
			Set(value As IDictionary)
				If value IsNot Nothing Then
					Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Editor = Nothing
				ElseIf Me.ImageMap Is Nothing And Operators.CompareString(Me.ComboList, "", True) = 0 Then
					Me.oo_0_oO._.()
				End If
				Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).DataMap = value
			End Set
		End Property

		' Token: 0x06002872 RID: 10354 RVA: 0x0010E304 File Offset: 0x0010C504
		Public Sub SetDataMap(dataMap As Object)
			If TypeOf dataMap Is MultiDataMap Then
				Me.DataMap = CType(dataMap, MultiDataMap).CreateDataMap()
				Return
			End If
			If TypeOf dataMap Is TableDataMap Then
				Me.DataMap = CType(dataMap, TableDataMap).CreateDataMap()
				Return
			End If
			If TypeOf dataMap Is DataMapJs Then
				Me.DataMap = CType(dataMap, DataMapJs).oo._Oo0.
			End If
		End Sub

		' Token: 0x1700096B RID: 2411
		' (get) Token: 0x06002873 RID: 10355 RVA: 0x0010E35E File Offset: 0x0010C55E
		' (set) Token: 0x06002874 RID: 10356 RVA: 0x0010E380 File Offset: 0x0010C580
		<oO0oooo("0583")>
		Public Property ImageMap As IDictionary
			Get
				Return Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).ImageMap
			End Get
			Set(value As IDictionary)
				If value IsNot Nothing AndAlso TypeOf value Is ImageMap Then
					Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Editor = Nothing
					Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).ImageMap = CType(value, ImageMap).o0oo.Oo.()
					If Operators.CompareString(Me.ComboList, "", True) = 0 And Me.DataMap Is Nothing Then
						Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).ComboList = CType(value, ImageMap).ImageKeys
						Return
					End If
				Else
					Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).ImageMap = Nothing
					If Me.DataMap Is Nothing And Operators.CompareString(Me.ComboList, "", True) = 0 Then
						Me.oo_0_oO._.()
					End If
				End If
			End Set
		End Property

		' Token: 0x1700096C RID: 2412
		' (get) Token: 0x06002875 RID: 10357 RVA: 0x0010E47D File Offset: 0x0010C67D
		' (set) Token: 0x06002876 RID: 10358 RVA: 0x0010E488 File Offset: 0x0010C688
		Friend Property DisplayMember As String
			Get
				Return Me.Oo_O.00o.
			End Get
			Set(value As String)
				Me.Oo_O.00o. = value
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is o0_o_o_0 Then
					CType(column.Editor, o0_o_o_0).OoO00_0_._0.(Nothing)
					Return
				End If
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is O0_0_0_Oo_o Then
					CType(column.Editor, O0_0_0_Oo_o).oO_0.__oO0_000.(Nothing)
				End If
			End Set
		End Property

		' Token: 0x1700096D RID: 2413
		' (get) Token: 0x06002877 RID: 10359 RVA: 0x0010E505 File Offset: 0x0010C705
		' (set) Token: 0x06002878 RID: 10360 RVA: 0x0010E510 File Offset: 0x0010C710
		Friend Property ValueMember As String
			Get
				Return Me.o__0_O.o_.
			End Get
			Set(value As String)
				Me.o__0_O.o_. = value
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is o0_o_o_0 Then
					CType(column.Editor, o0_o_o_0).o_.O_.(Nothing)
					Return
				End If
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is O0_0_0_Oo_o Then
					CType(column.Editor, O0_0_0_Oo_o).O.00o0o_.(Nothing)
				End If
			End Set
		End Property

		' Token: 0x1700096E RID: 2414
		' (get) Token: 0x06002879 RID: 10361 RVA: 0x0010E58D File Offset: 0x0010C78D
		' (set) Token: 0x0600287A RID: 10362 RVA: 0x0010E598 File Offset: 0x0010C798
		Friend Property DataFilter As String
			Get
				Return Me.o0.OO.
			End Get
			Set(value As String)
				Me.o0.OO. = value
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is o0_o_o_0 Then
					CType(CType(column.Editor, o0_o_o_0).o.O0.(), DataView).RowFilter = value
					Return
				End If
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is O0_0_0_Oo_o Then
					CType(CType(column.Editor, O0_0_0_Oo_o).O___0oO__.0oO.(), DataView).RowFilter = value
				End If
			End Set
		End Property

		' Token: 0x1700096F RID: 2415
		' (get) Token: 0x0600287B RID: 10363 RVA: 0x0010E629 File Offset: 0x0010C829
		' (set) Token: 0x0600287C RID: 10364 RVA: 0x0010E634 File Offset: 0x0010C834
		Friend Property DataSort As String
			Get
				Return Me.o0._O_Oo_ooOO.
			End Get
			Set(value As String)
				Me.o0._O_Oo_ooOO. = value
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is o0_o_o_0 Then
					CType(CType(column.Editor, o0_o_o_0).o.O0.(), DataView).Sort = value
					Return
				End If
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is O0_0_0_Oo_o Then
					CType(CType(column.Editor, O0_0_0_Oo_o).O___0oO__.0oO.(), DataView).Sort = value
				End If
			End Set
		End Property

		' Token: 0x17000970 RID: 2416
		' (get) Token: 0x0600287D RID: 10365 RVA: 0x0010E6C5 File Offset: 0x0010C8C5
		' (set) Token: 0x0600287E RID: 10366 RVA: 0x0010E6D0 File Offset: 0x0010C8D0
		Friend Property DataSource As String
			Get
				Return Me.oO0OO.oO.
			End Get
			Set(value As String)
				Me.oO0OO.oO. = value
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				If Operators.CompareString(value, "", True) = 0 Then
					If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is o0_o_o_0 Then
						If CType(column.Editor, o0_o_o_0).o.O0.() IsNot Nothing Then
							column.Editor = O_O0OO.OoO.0OO__0ooo.()
							Return
						End If
					ElseIf column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is O0_0_0_Oo_o AndAlso CType(column.Editor, O0_0_0_Oo_o).O___0oO__.0oO.() IsNot Nothing Then
						column.Editor = O_O0OO.OoO.0OO__0ooo.()
						Return
					End If
				ElseIf Me.DataCol.ExtendColumnType = 7 Then
					Dim o0_o_o_ As o0_o_o_0 = New o0_o_o_0()
					o0_o_o_.Oo_o0_O00_00.O.(Me.DataCol.Separator)
					If Operators.CompareString(Me.DataSource, "", True) > 0 AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.DataSource) Then
						Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.DataSource)
						If Operators.CompareString(Me.ValueMember, "", True) <> 0 AndAlso dataTable.Columns.Contains(Me.ValueMember) AndAlso Operators.CompareString(Me.DisplayMember, "", True) <> 0 AndAlso dataTable.Columns.Contains(Me.DisplayMember) Then
							Dim dataView As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.DataSource), "", "", DataViewRowState.CurrentRows)
							Try
								dataView.Sort = Me.DataSort
								dataView.RowFilter = Me.DataFilter
								If Operators.CompareString(Me.DataSort, "", True) = 0 Then
									dataView.Sort = Me.ValueMember
								End If
								o0_o_o_.o_.O_.(Me.ValueMember)
								o0_o_o_.OoO00_0_._0.(Me.DisplayMember)
								o0_o_o_.O.0o0O.(dataView)
							Catch ex As Exception
								MessageBox.Show(String.Concat(New String() { Me.Table.Name, ".", Me.Name, "的列表项目设置出错，原因：", ex.Message }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End Try
						End If
					End If
					If o0_o_o_.o.O0.() IsNot Nothing Then
						o0_o_o_.O.0o0O.(Me.AllowDirectType)
						o0_o_o_.Oo_o0_O00_00.O.(Me.DataCol.MultiColumn)
						o0_o_o_.o_0.0_.(Me.DataCol.ColumnWidth)
						o0_o_o_.Oo.0oO0__O.(Me.DataCol.DropDownWidth)
						o0_o_o_.OoO00_0_._0.(Me.DataCol.DropDownHeight)
						o0_o_o_.o_.O_.(Me.DataCol.MaxDropDownItems)
						column.Editor = o0_o_o_
						Return
					End If
				Else
					Dim o0_0_0_Oo_o As O0_0_0_Oo_o = New O0_0_0_Oo_o()
					If Operators.CompareString(Me.DataSource, "", True) > 0 AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.DataSource) Then
						Dim dataTable2 As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.DataSource)
						If Operators.CompareString(Me.ValueMember, "", True) = 0 OrElse Not dataTable2.Columns.Contains(Me.ValueMember) OrElse Operators.CompareString(Me.DisplayMember, "", True) = 0 OrElse Not dataTable2.Columns.Contains(Me.DisplayMember) Then
							o0_0_0_Oo_o.oO_0.__oO0_000.(Nothing)
						Else
							Dim dataView2 As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.DataSource), "", "", DataViewRowState.CurrentRows)
							Try
								dataView2.RowFilter = Me.DataFilter
								If Operators.CompareString(dataView2.RowFilter, "", True) > 0 Then
									dataView2.RowFilter = dataView2.RowFilter + " And [" + Me.ValueMember + "] Is Not Null"
								Else
									dataView2.RowFilter = "[" + Me.ValueMember + "] Is Not Null"
								End If
								If Operators.CompareString(Me.DataSort, "", True) = 0 Then
									dataView2.Sort = Me.ValueMember
								Else
									dataView2.Sort = Me.DataSort
								End If
								o0_0_0_Oo_o.O.00o0o_.(Me.ValueMember)
								o0_0_0_Oo_o.oO_0.__oO0_000.(Me.DisplayMember)
								o0_0_0_Oo_o.oO_0.__oO0_000.(dataView2)
							Catch ex2 As Exception
								MessageBox.Show(String.Concat(New String() { Me.Table.Name, ".", Me.Name, "的列表项目设置出错，原因：", ex2.Message }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End Try
						End If
					End If
					If o0_0_0_Oo_o.O___0oO__.0oO.() IsNot Nothing Then
						o0_0_0_Oo_o.oO_0.__oO0_000.(Me.AllowDirectType)
						o0_0_0_Oo_o.OO00_.O_.(Me.DataCol.MultiColumn)
						o0_0_0_Oo_o.oO_0.__oO0_000.(Me.DataCol.ColumnWidth)
						o0_0_0_Oo_o.o.ooo.(Me.DataCol.DropDownWidth)
						o0_0_0_Oo_o.O.0_0_.(Me.DataCol.DropDownHeight)
						o0_0_0_Oo_o.O.00o0o_.(Me.DataCol.MaxDropDownItems)
						o0_0_0_Oo_o.OoOo__.o.(Me.DataCol.ItemSpacing)
						column.Editor = o0_0_0_Oo_o
						If Me.AllowTypeAssistant AndAlso Me.AllowDirectType Then
							o0_0_0_Oo_o.AutoCompleteSource = AutoCompleteSource.CustomSource
							o0_0_0_Oo_o.AutoCompleteMode = AutoCompleteMode.SuggestAppend
							Me.ResetAutoCompleteSource()
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17000971 RID: 2417
		' (get) Token: 0x0600287F RID: 10367 RVA: 0x0010EC4C File Offset: 0x0010CE4C
		' (set) Token: 0x06002880 RID: 10368 RVA: 0x0010EDC4 File Offset: 0x0010CFC4
		<oO0oooo("0578")>
		Public Property ComboList As String
			Get
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				If TypeOf column.Editor Is o0_o_o_0 Then
					Dim o0_o_o_ As o0_o_o_0 = CType(column.Editor, o0_o_o_0)
					If o0_o_o_.o.O0.() Is Nothing Then
						Dim text As String = ""
						Try
							For Each value As Object In o0_o_o_.o.O0.()
								Dim str As String = Conversions.ToString(value)
								If Operators.CompareString(text, "", True) > 0 Then
									text += "|"
								End If
								text += str
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						Return text
					End If
				ElseIf TypeOf column.Editor Is O0_0_0_Oo_o Then
					Dim o0_0_0_Oo_o As O0_0_0_Oo_o = CType(column.Editor, O0_0_0_Oo_o)
					If o0_0_0_Oo_o.O___0oO__.0oO.() Is Nothing Then
						Dim text2 As String = ""
						Try
							For Each value2 As Object In o0_0_0_Oo_o.OO.0oo.()
								Dim str2 As String = Conversions.ToString(value2)
								If Operators.CompareString(text2, "", True) > 0 Then
									text2 += "|"
								End If
								text2 += str2
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
						Return text2
					End If
				End If
				Return Nothing
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num4 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Me.o_0.oo. = value
					IL_10:
					num2 = 3
					Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
					IL_2E:
					num2 = 4
					If Operators.CompareString(value, "", True) <> 0 Then
						GoTo IL_E0
					End If
					IL_41:
					num2 = 5
					If column.Editor Is Nothing OrElse Not(TypeOf column.Editor Is o0_o_o_0) Then
						GoTo IL_79
					End If
					IL_58:
					num2 = 6
					If CType(column.Editor, o0_o_o_0).o.O0.() IsNot Nothing Then
						GoTo IL_79
					End If
					IL_6C:
					num2 = 7
					column.Editor = O_O0OO.OoO.0OO__0ooo.()
					IL_79:
					num2 = 8
					If column.Editor Is Nothing OrElse Not(TypeOf column.Editor Is O0_0_0_Oo_o) Then
						GoTo IL_B3
					End If
					IL_90:
					num2 = 9
					If CType(column.Editor, O0_0_0_Oo_o).O___0oO__.0oO.() IsNot Nothing Then
						GoTo IL_B3
					End If
					IL_A5:
					num2 = 10
					column.Editor = O_O0OO.OoO.0OO__0ooo.()
					IL_B3:
					num2 = 11
					If Operators.CompareString(column.ComboList, "", True) <= 0 Then
						GoTo IL_3E1
					End If
					IL_CD:
					num2 = 12
					column.ComboList = ""
					GoTo IL_3E1
					IL_E0:
					num2 = 15
					If Operators.CompareString(value, "...", True) <> 0 Then
						GoTo IL_10E
					End If
					IL_F1:
					num2 = 16
					column.Editor = Nothing
					IL_FB:
					num2 = 17
					column.ComboList = "..."
					GoTo IL_3E1
					IL_10E:
					num2 = 20
					If Operators.CompareString(value, "|...", True) <> 0 Then
						GoTo IL_13C
					End If
					IL_11F:
					num2 = 21
					column.Editor = Nothing
					IL_129:
					num2 = 22
					column.ComboList = "|..."
					GoTo IL_3E1
					IL_13C:
					num2 = 24
					If Me.DataCol.ExtendColumnType <> 7 Then
						GoTo IL_257
					End If
					IL_150:
					num2 = 25
					If Not(TypeOf column.Editor Is o0_o_o_0) Then
						GoTo IL_181
					End If
					IL_160:
					num2 = 26
					Dim o0_o_o_ As o0_o_o_0 = CType(column.Editor, o0_o_o_0)
					IL_170:
					num2 = 27
					o0_o_o_.o.O0.().Clear()
					GoTo IL_18B
					IL_181:
					num2 = 29
					o0_o_o_ = New o0_o_o_0()
					IL_18B:
					num2 = 30
					o0_o_o_.Oo_o0_O00_00.O.(Me.DataCol.Separator)
					IL_1A0:
					num2 = 31
					Dim items As String() = value.Split(New Char() { vbLf, vbCr, "|"c }, StringSplitOptions.RemoveEmptyEntries)
					IL_1BD:
					num2 = 32
					o0_o_o_.o.O0.().AddRange(items)
					IL_1CE:
					num2 = 33
					o0_o_o_.O.0o0O.(Me.AllowDirectType)
					IL_1DE:
					num2 = 34
					o0_o_o_.Oo_o0_O00_00.O.(Me.DataCol.MultiColumn)
					IL_1F3:
					num2 = 35
					o0_o_o_.o_0.0_.(Me.DataCol.ColumnWidth)
					IL_208:
					num2 = 36
					o0_o_o_.Oo.0oO0__O.(Me.DataCol.DropDownWidth)
					IL_21D:
					num2 = 37
					o0_o_o_.OoO00_0_._0.(Me.DataCol.DropDownHeight)
					IL_232:
					num2 = 38
					o0_o_o_.o_.O_.(Me.DataCol.MaxDropDownItems)
					IL_247:
					num2 = 39
					column.Editor = o0_o_o_
					GoTo IL_3E1
					IL_257:
					num2 = 41
					If Operators.CompareString(value, "", True) <> 0 Then
						GoTo IL_295
					End If
					IL_268:
					num2 = 42
					If column.Editor Is Nothing OrElse Not(TypeOf column.Editor Is O0_0_0_Oo_o) Then
						GoTo IL_3E1
					End If
					IL_286:
					num2 = 43
					column.Editor = Nothing
					GoTo IL_3E1
					IL_295:
					num2 = 45
					If Not(TypeOf column.Editor Is O0_0_0_Oo_o) Then
						GoTo IL_2C6
					End If
					IL_2A5:
					num2 = 46
					Dim o0_0_0_Oo_o As O0_0_0_Oo_o = CType(column.Editor, O0_0_0_Oo_o)
					IL_2B5:
					num2 = 47
					o0_0_0_Oo_o.OO.0oo.().Clear()
					GoTo IL_2D0
					IL_2C6:
					num2 = 49
					o0_0_0_Oo_o = New O0_0_0_Oo_o()
					IL_2D0:
					num2 = 50
					Dim array As String() = value.Split(New Char() { vbLf, vbCr, "|"c }, StringSplitOptions.RemoveEmptyEntries)
					IL_2ED:
					num2 = 51
					o0_0_0_Oo_o.OO.0oo.().AddRange(array)
					IL_2FE:
					num2 = 52
					If Not Me.AllowTypeAssistant OrElse Not Me.AllowDirectType Then
						GoTo IL_348
					End If
					IL_311:
					num2 = 53
					o0_0_0_Oo_o.AutoCompleteSource = AutoCompleteSource.CustomSource
					IL_31D:
					num2 = 54
					o0_0_0_Oo_o.AutoCompleteMode = AutoCompleteMode.SuggestAppend
					IL_328:
					num2 = 55
					o0_0_0_Oo_o.AutoCompleteCustomSource.Clear()
					IL_337:
					num2 = 56
					o0_0_0_Oo_o.AutoCompleteCustomSource.AddRange(array)
					IL_348:
					num2 = 57
					o0_0_0_Oo_o.oO_0.__oO0_000.(Me.AllowDirectType)
					IL_358:
					num2 = 58
					o0_0_0_Oo_o.OO00_.O_.(Me.DataCol.MultiColumn)
					IL_36D:
					num2 = 59
					o0_0_0_Oo_o.oO_0.__oO0_000.(Me.DataCol.ColumnWidth)
					IL_382:
					num2 = 60
					o0_0_0_Oo_o.o.ooo.(Me.DataCol.DropDownWidth)
					IL_397:
					num2 = 61
					o0_0_0_Oo_o.O.0_0_.(Me.DataCol.DropDownHeight)
					IL_3AC:
					num2 = 62
					o0_0_0_Oo_o.O.00o0o_.(Me.DataCol.MaxDropDownItems)
					IL_3C1:
					num2 = 63
					o0_0_0_Oo_o.OoOo__.o.(Me.DataCol.ItemSpacing)
					IL_3D6:
					num2 = 64
					column.Editor = o0_0_0_Oo_o
					IL_3E1:
					GoTo IL_537
					IL_3E6:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_4F8:
					GoTo IL_52C
					IL_4FA:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_50A:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_4FA
				End Try
				IL_52C:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_537:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x17000972 RID: 2418
		' (get) Token: 0x06002881 RID: 10369 RVA: 0x0010F32C File Offset: 0x0010D52C
		' (set) Token: 0x06002882 RID: 10370 RVA: 0x0010F35F File Offset: 0x0010D55F
		<oO0oooo("1784")>
		Public Property AllowDirectType As Boolean
			Get
				Dim result As Boolean
				If Me.o0O0oO.0. Is Nothing Then
					result = Me.DataCol.AllowEditValue
				Else
					result = (Me.o0O0oO.0. = 1)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.o0O0oO.0. = 1
					Return
				End If
				Me.o0O0oO.0. = 2
			End Set
		End Property

		' Token: 0x17000973 RID: 2419
		' (get) Token: 0x06002883 RID: 10371 RVA: 0x0010F374 File Offset: 0x0010D574
		' (set) Token: 0x06002884 RID: 10372 RVA: 0x0010F3A7 File Offset: 0x0010D5A7
		<oO0oooo("1785")>
		Public Property AllowTypeAssistant As Boolean
			Get
				Dim result As Boolean
				If Me.o0OO_.O00___. Is Nothing Then
					result = Me.DataCol.AutoComplete
				Else
					result = (Me.o0OO_.O00___. = 1)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.o0OO_.O00___. = 1
					Return
				End If
				Me.o0OO_.O00___. = 2
			End Set
		End Property

		' Token: 0x17000974 RID: 2420
		' (get) Token: 0x06002885 RID: 10373 RVA: 0x0010F3BC File Offset: 0x0010D5BC
		' (set) Token: 0x06002886 RID: 10374 RVA: 0x0010F3EF File Offset: 0x0010D5EF
		<oO0oooo("1783")>
		Public Property UsetBuildInEditor As Boolean
			Get
				Dim result As Boolean
				If Me.oOoO00.o. Is Nothing Then
					result = Me.DataCol.UsetBuildInEditor
				Else
					result = (Me.oOoO00.o. = 1)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.oOoO00.o. = 1
				Else
					Me.oOoO00.o. = 2
				End If
				Me.oo_0_oO._.()
			End Set
		End Property

		' Token: 0x06002887 RID: 10375 RVA: 0x0010F40C File Offset: 0x0010D60C
		Public Sub ResetAutoCompleteSource()
			Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
			If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is O0_0_0_Oo_o Then
				Dim o0_0_0_Oo_o As O0_0_0_Oo_o = CType(column.Editor, O0_0_0_Oo_o)
				If o0_0_0_Oo_o.AutoCompleteMode <> AutoCompleteMode.None Then
					Dim list As List(Of String) = New List(Of String)()
					o0_0_0_Oo_o.AutoCompleteCustomSource.Clear()
					If o0_0_0_Oo_o.O___0oO__.0oO.() IsNot Nothing Then
						Dim dataView As DataView = CType(o0_0_0_Oo_o.O___0oO__.0oO.(), DataView)
						Dim num As Integer = dataView.Count - 1
						For i As Integer = 0 To num
							If Not dataView(i).Row.IsNull(o0_0_0_Oo_o.oO_0.__oO0_000.()) Then
								list.Add(dataView(i)(o0_0_0_Oo_o.oO_0.__oO0_000.()).ToString())
							End If
						Next
					Else
						Try
							For Each value As Object In o0_0_0_Oo_o.OO.0oo.()
								Dim item As String = Conversions.ToString(value)
								list.Add(item)
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
					o0_0_0_Oo_o.AutoCompleteCustomSource.AddRange(list.ToArray())
				End If
			End If
		End Sub

		' Token: 0x06002888 RID: 10376 RVA: 0x0010F54C File Offset: 0x0010D74C
		<oO0oooo("0585")>
		Public Sub OpenWindow(Optional size As Integer = 0)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.Name.StartsWith("~") OrElse Me.Name.IndexOf(".") >= 0 Then
					GoTo IL_1AC
				End If
				IL_34:
				num2 = 4
				If Me.o_o_O.0000_O. Is Nothing Then
					GoTo IL_58
				End If
				IL_3E:
				num2 = 5
				If Me.o_o_O.0000_O..FindForm() IsNot Nothing Then
					GoTo IL_1AC
				End If
				IL_50:
				num2 = 8
				Me.CloseWindow()
				IL_58:
				num2 = 9
				Me.o_o_O.0000_O. = Me.oo_0_oO._.()
				IL_67:
				num2 = 10
				If Me.o_o_O.0000_O. Is Nothing Then
					GoTo IL_1AC
				End If
				IL_75:
				num2 = 12
				Dim text As String = Me.Table.Name
				IL_85:
				num2 = 13
				If text.IndexOf(".") <= 0 Then
					GoTo IL_B0
				End If
				IL_97:
				num2 = 14
				text = text.Substring(0, text.IndexOf("."))
				IL_B0:
				num2 = 15
				Dim o_O0_0O As o_O0_0O0
				Select Case Me.DataCol.DockArea
					Case 1
						IL_D7:
						num2 = 17
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O._o_00__.()
					Case 2
						IL_FD:
						num2 = 19
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O__O.o_oOO.()
					Case 3
						IL_123:
						num2 = 21
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O_000__.o.()
					Case Else
						IL_149:
						num2 = 23
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).o__0_.o0OoOOO.()
				End Select
				IL_16D:
				num2 = 25
				If size <= 0 Then
					GoTo IL_17E
				End If
				IL_174:
				num2 = 26
				o_O0_0O.OoOoo_O0o0.0O_.(size)
				IL_17E:
				num2 = 27
				o_O0_0O.OO_o0_oO.0.(Me.o_o_O.0000_O., Me.Caption, Me.DataCol.DockTitle, Me.Icon, Me.DataCol, True)
				IL_1AC:
				GoTo IL_26E
				IL_1B1:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_22F:
				GoTo IL_263
				IL_231:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_241:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_231
			End Try
			IL_263:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_26E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002889 RID: 10377 RVA: 0x0010F7EC File Offset: 0x0010D9EC
		<oO0oooo("0586")>
		Public Sub CloseWindow()
			If Me.o_o_O.0000_O. IsNot Nothing Then
				Dim parent As System.Windows.Forms.Control = Me.o_o_O.0000_O..Parent
				Me.o_o_O.0000_O..DataBindings.Clear()
				While parent IsNot Nothing AndAlso Not(TypeOf parent Is FormPanel)
					If TypeOf parent Is o_O0_0O0 Then
						CType(parent, o_O0_0O0).o_o.O___0o.(Me.o_o_O.0000_O.)
						Exit While
					End If
					parent = parent.Parent
				End While
				Me.o_o_O.0000_O..Dispose()
			End If
		End Sub

		' Token: 0x0600288A RID: 10378 RVA: 0x0010F857 File Offset: 0x0010DA57
		Public Function IsDate() As Boolean
			Return Me.DataCol.IsDate
		End Function

		' Token: 0x0600288B RID: 10379 RVA: 0x0010F864 File Offset: 0x0010DA64
		Public Function IsNumeric() As Boolean
			Return Me.DataCol.IsNumeric
		End Function

		' Token: 0x0600288C RID: 10380 RVA: 0x0010F871 File Offset: 0x0010DA71
		Public Function IsBoolean() As Boolean
			Return Me.DataCol.IsBoolean
		End Function

		' Token: 0x0600288D RID: 10381 RVA: 0x0010F87E File Offset: 0x0010DA7E
		Public Function IsString() As Boolean
			Return Me.DataCol.IsString
		End Function

		' Token: 0x17000975 RID: 2421
		' (get) Token: 0x0600288E RID: 10382 RVA: 0x0010F88B File Offset: 0x0010DA8B
		' (set) Token: 0x0600288F RID: 10383 RVA: 0x0010F8AD File Offset: 0x0010DAAD
		<oO0oooo("0584")>
		Public Property ImageAndText As Boolean
			Get
				Return Me.Table.foxGrid.Cols(Me.o_o_O.0000_O.).ImageAndText
			End Get
			Set(value As Boolean)
				Me.Table.foxGrid.Cols(Me.o_o_O.0000_O.).ImageAndText = value
			End Set
		End Property

		' Token: 0x06002890 RID: 10384 RVA: 0x0010F8D0 File Offset: 0x0010DAD0
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o_o_O.0000_O. = A_0
		End Sub

		' Token: 0x17000976 RID: 2422
		' (get) Token: 0x06002891 RID: 10385 RVA: 0x0010F8D9 File Offset: 0x0010DAD9
		Friend ReadOnly Property DataTableName As String
			Get
				Return Me.o_o_O.0000_O..View.o_o.O0ooOo.().TableName
			End Get
		End Property

		' Token: 0x17000977 RID: 2423
		' (get) Token: 0x06002892 RID: 10386 RVA: 0x0010F8F0 File Offset: 0x0010DAF0
		' (set) Token: 0x06002893 RID: 10387 RVA: 0x0010F912 File Offset: 0x0010DB12
		Friend Property AllowMerging As Boolean
			Get
				Return Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).AllowMerging
			End Get
			Set(value As Boolean)
				Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).AllowMerging = value
			End Set
		End Property

		' Token: 0x06002894 RID: 10388 RVA: 0x0010F938 File Offset: 0x0010DB38
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If Me.Table.TableType Is Nothing AndAlso Not Me.Table.IsCopy Then
				If Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsString() AndAlso Me.DataCol.ExtendColumnType Is Nothing AndAlso (Me.o_o_O.0000_O..View.o_o.O0ooOo.().Columns(Me.o_o_O.0000_O.).MaxLength > 255 OrElse Me.o_o_O.0000_O..View.o_o.O0ooOo.().Columns(Me.o_o_O.0000_O.).MaxLength = -1) Then
					result = True
				ElseIf Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsString() AndAlso Me.DataCol.ExtendColumnType = 4 Then
					result = True
				ElseIf Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsString() AndAlso Me.DataCol.ExtendColumnType = 6 Then
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x06002895 RID: 10389 RVA: 0x0010FA44 File Offset: 0x0010DC44
		Friend Function <<EMPTY_NAME>>() As System.Windows.Forms.Control
			Dim num2 As Integer
			Dim result As System.Windows.Forms.Control
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Me.o_o_O.0000_O..TableType IsNot Nothing OrElse Me.o_o_O.0000_O..IsCopy Then
					GoTo IL_2AD
				End If
				IL_22:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_29:
				num = 3
				If Not Me.IsString() OrElse Me.DataCol.ExtendColumnType IsNot Nothing OrElse (Me.o_o_O.0000_O..View.o_o.O0ooOo.().Columns(Me.o_o_O.0000_O.).MaxLength <= 255 AndAlso Me.o_o_O.0000_O..View.o_o.O0ooOo.().Columns(Me.o_o_O.0000_O.).MaxLength <> -1) Then
					GoTo IL_F6
				End If
				IL_9A:
				num = 4
				Dim o__o As O__o = New O__o()
				IL_A3:
				num = 5
				Dim font As Font = Me.Table.Grid.Font
				IL_B7:
				num = 6
				o__o.Font = New Font("微软雅黑", font.Size + 1F)
				IL_D7:
				num = 7
				o__o.o__0_o0.OOO_.(Me.Table, Me.o_o_O.0000_O.)
				IL_EC:
				num = 8
				result = o__o
				GoTo IL_2B2
				IL_F6:
				num = 9
				If Not Me.IsString() OrElse Me.DataCol.ExtendColumnType <> 4 Then
					GoTo IL_1D3
				End If
				IL_115:
				num = 10
				Dim pictureViewer As PictureViewer = New PictureViewer()
				IL_11F:
				num = 11
				pictureViewer.DataBindings.Add("ImageFiles", Me.Table.View, Me.o_o_O.0000_O.)
				IL_145:
				num = 12
				pictureViewer.DataBindings(0).DataSourceUpdateMode = DataSourceUpdateMode.Never
				IL_15B:
				num = 13
				pictureViewer.AutoDownLoad = Me.DataCol.AutoDownload
				IL_170:
				num = 14
				pictureViewer.AutoUpdate = Me.DataCol.AutoUpdate
				IL_185:
				num = 15
				If Not Me.DataCol.Remote Then
					GoTo IL_1B3
				End If
				IL_195:
				num = 16
				If Me.DataCol.FTPClient IsNot Nothing Then
					GoTo IL_1B3
				End If
				IL_1A5:
				num = 17
				Me.DataCol.o_.Oo00_O_00_.()
				IL_1B3:
				num = 18
				pictureViewer.FTPclient = Me.DataCol.FTPClient
				IL_1C8:
				num = 19
				result = pictureViewer
				GoTo IL_2B2
				IL_1D3:
				num = 20
				If Not Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsString() OrElse Me.DataCol.ExtendColumnType <> 6 Then
					GoTo IL_2AD
				End If
				IL_207:
				num = 21
				Dim fileManager As FileManager = New FileManager()
				IL_211:
				num = 22
				fileManager.DataBindings.Add("FileString", Me.Table.View, Me.o_o_O.0000_O.)
				IL_237:
				num = 23
				fileManager.DataBindings(0).DataSourceUpdateMode = DataSourceUpdateMode.Never
				IL_24D:
				num = 24
				If Not Me.DataCol.Remote Then
					GoTo IL_27B
				End If
				IL_25D:
				num = 25
				If Me.DataCol.FTPClient IsNot Nothing Then
					GoTo IL_27B
				End If
				IL_26D:
				num = 26
				Me.DataCol.o_.Oo00_O_00_.()
				IL_27B:
				num = 27
				fileManager.FTPclient = Me.DataCol.FTPClient
				IL_290:
				num = 28
				fileManager.AutoUpdate = Me.DataCol.AutoUpdate
				IL_2A5:
				num = 29
				result = fileManager
				GoTo IL_2B2
				IL_2AD:
				num = 30
				result = Nothing
				IL_2B2:
				GoTo IL_380
				IL_2B7:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_341:
				GoTo IL_375
				IL_343:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_353:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_343
			End Try
			IL_375:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_380:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x17000978 RID: 2424
		' (set) Token: 0x06002896 RID: 10390 RVA: 0x0010FDF8 File Offset: 0x0010DFF8
		<oO0oooo("2031")>
		Public WriteOnly Property DropTree As BuildInDropTree
			Set(value As BuildInDropTree)
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				If value Is Nothing Then
					If TypeOf column.Editor Is BuildInDropTree Then
						column.Editor = Nothing
						Me.oo_0_oO._.()
						Return
					End If
				Else
					column.Editor = value
					value.AllowEditValue = Me.AllowDirectType
				End If
			End Set
		End Property

		' Token: 0x06002897 RID: 10391 RVA: 0x0010FE54 File Offset: 0x0010E054
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				IL_25:
				num2 = 3
				Me.O_00_o.__. = 0
				IL_2E:
				num2 = 4
				column.DataMap = Nothing
				IL_37:
				num2 = 5
				column.ImageMap = Nothing
				IL_40:
				num2 = 6
				column.Editor = Nothing
				IL_49:
				num2 = 7
				column.EditMask = Nothing
				IL_52:
				num2 = 8
				column.Format = Nothing
				IL_5B:
				num2 = 9
				column.Editor = Nothing
				IL_65:
				num2 = 10
				Me.CodeDictonary = Me.DataCol.oO0._00o_0.
				IL_79:
				num2 = 11
				If Me.DataCol.ExtendColumnType <> 8 Then
					GoTo IL_9D
				End If
				IL_8A:
				num2 = 12
				column.Editor = O_O0OO.OoO.0OO__0ooo.()
				GoTo IL_4A0
				IL_9D:
				num2 = 14
				If Me.DataCol.oO0._00o_0. IsNot Nothing Then
					GoTo IL_42E
				End If
				IL_B0:
				num2 = 15
				Me.DisplayMember = Me.DataCol.DisplayMember
				IL_C4:
				num2 = 16
				Me.ValueMember = Me.DataCol.ValueMember
				IL_D8:
				num2 = 17
				Me.DataFilter = Me.DataCol.DataFilter
				IL_EC:
				num2 = 18
				Me.DataSort = Me.DataCol.DataSort
				IL_100:
				num2 = 19
				Me.oO0OO.oO. = ""
				IL_10E:
				num2 = 20
				If Operators.CompareString(Me.DataCol.DataSource, "", True) <= 0 Then
					GoTo IL_13E
				End If
				IL_12A:
				num2 = 21
				Me.DataSource = Me.DataCol.DataSource
				IL_13E:
				num2 = 22
				If column.Editor IsNot Nothing Then
					GoTo IL_3CF
				End If
				IL_14C:
				num2 = 23
				Dim buildInDropTree As BuildInDropTree = Nothing
				IL_152:
				num2 = 24
				If Operators.CompareString(Me.DataCol.TreeFile, "", True) <= 0 OrElse Operators.CompareString(Me.DataCol.TreeReceiveCols, "", True) <= 0 Then
					GoTo IL_24A
				End If
				IL_18D:
				num2 = 25
				Dim text As String = ooO.OoO0o_o___.O.(Me.DataCol.TreeFile)
				IL_1A2:
				num2 = 26
				If OO_00oOO.FileSys.FileExists(text) Then
					GoTo IL_21F
				End If
				IL_1B3:
				num2 = 27
				MessageBox.Show(String.Concat(New String() { "[", Me.Table.DataTable.Name, "]的[", Me.Name, "]调用的目录树文件""", OO_00oOO.FileSys.GetName(text), """不存在！" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_2EC
				IL_21F:
				num2 = 29
				buildInDropTree = New BuildInDropTree(ooO.OoO0o_o___.O.(Me.DataCol.TreeFile), Me.DataCol.TreeReceiveCols, True)
				GoTo IL_2EC
				IL_24A:
				num2 = 31
				If Operators.CompareString(Me.DataCol.TreeSourceTable, "", True) <= 0 OrElse Operators.CompareString(Me.DataCol.TreeReceiveCols, "", True) <= 0 OrElse Operators.CompareString(Me.DataCol.TreeBuildCols, "", True) <= 0 Then
					GoTo IL_2EC
				End If
				IL_29B:
				num2 = 32
				buildInDropTree = New BuildInDropTree(Me.DataCol.TreeSourceTable, Me.DataCol.TreeBuildCols, Me.DataCol.TreeSourceCols, Me.DataCol.TreeReceiveCols, Me.DataCol.TreePathSeparator, Me.DataCol.TreeFilter, "")
				IL_2EC:
				num2 = 33
				If buildInDropTree Is Nothing Then
					GoTo IL_3CF
				End If
				IL_2F6:
				num2 = 34
				If Me.DataCol.DropDownWidth <= 0 Then
					GoTo IL_321
				End If
				IL_307:
				num2 = 35
				buildInDropTree.Ooo._0oO..Width = Me.DataCol.DropDownWidth
				IL_321:
				num2 = 36
				If Me.DataCol.DropDownHeight <= 0 Then
					GoTo IL_34C
				End If
				IL_332:
				num2 = 37
				buildInDropTree.Ooo._0oO..Height = Me.DataCol.DropDownHeight
				IL_34C:
				num2 = 38
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = Me.DataCol.TreePathSeparator
				IL_366:
				num2 = 39
				buildInDropTree.Ooo._0oO..O0ooOO_o0.00. = Me.DataCol.TreeContentSeparator
				IL_380:
				num2 = 40
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = Me.DataCol.TreeSeparateContent
				IL_39A:
				num2 = 41
				buildInDropTree.AllowEditValue = Me.AllowDirectType
				IL_3AA:
				num2 = 42
				buildInDropTree.Font = Me.Table.Grid.Font
				IL_3C4:
				num2 = 43
				column.Editor = buildInDropTree
				IL_3CF:
				num2 = 44
				If column.Editor IsNot Nothing Then
					GoTo IL_40A
				End If
				IL_3DA:
				num2 = 45
				If Operators.CompareString(Me.DataCol.ComboList, "", True) <= 0 Then
					GoTo IL_40A
				End If
				IL_3F6:
				num2 = 46
				Me.ComboList = Me.DataCol.ComboList
				IL_40A:
				num2 = 47
				If column.Editor Is Nothing Then
					GoTo IL_4A0
				End If
				IL_418:
				num2 = 48
				Me.DataCol.oO0._00o_0. = column.Editor
				GoTo IL_4A0
				IL_42E:
				num2 = 50
				Me.Oo_O.00o. = Me.DataCol.DisplayMember
				IL_442:
				num2 = 51
				Me.o__0_O.o_. = Me.DataCol.ValueMember
				IL_456:
				num2 = 52
				Me.o0.OO. = Me.DataCol.DataFilter
				IL_46A:
				num2 = 53
				Me.o0._O_Oo_ooOO. = Me.DataCol.DataSort
				IL_47E:
				num2 = 54
				Me.oO0OO.oO. = ""
				IL_48C:
				num2 = 55
				column.Editor = Me.DataCol.oO0._00o_0.
				IL_4A0:
				num2 = 56
				If Not Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsBoolean() Then
					GoTo IL_4D9
				End If
				IL_4C0:
				num2 = 57
				column.Format = Me.DataCol.BooleanFormat
				GoTo IL_8D2
				IL_4D9:
				num2 = 59
				If Not Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsDate() Then
					GoTo IL_512
				End If
				IL_4F9:
				num2 = 60
				Me.SetDateTimeFormat(Me.DataCol.DateTimeFormat)
				GoTo IL_8D2
				IL_512:
				num2 = 62
				If(Me.DataCol.ExtendColumnType <> 4 AndAlso Me.DataCol.ExtendColumnType <> 3 AndAlso Me.DataCol.ExtendColumnType <> 6) OrElse Me.o_o_O.0000_O..View.o_o.O0ooOo.().Columns(Me.o_o_O.0000_O.).DataType IsNot GetType(String) Then
					GoTo IL_583
				End If
				IL_570:
				num2 = 63
				column.ComboList = "|..."
				GoTo IL_8D2
				IL_583:
				num2 = 65
				If Me.DataCol.ExtendColumnType <> 5 OrElse Me.o_o_O.0000_O..View.o_o.O0ooOo.().Columns(Me.o_o_O.0000_O.).DataType IsNot GetType(Integer) Then
					GoTo IL_5D8
				End If
				IL_5C5:
				num2 = 66
				column.ComboList = "..."
				GoTo IL_8D2
				IL_5D8:
				num2 = 68
				If(Me.DataCol.ExtendColumnType <> 1 AndAlso Me.DataCol.ExtendColumnType <> 2 AndAlso Me.DataCol.ExtendColumnType <> 9 AndAlso Me.DataCol.ExtendColumnType <> 10) OrElse Me.o_o_O.0000_O..View.o_o.O0ooOo.().Columns(Me.o_o_O.0000_O.).DataType IsNot GetType(String) Then
					GoTo IL_659
				End If
				IL_646:
				num2 = 69
				column.ComboList = "|..."
				GoTo IL_8D2
				IL_659:
				num2 = 71
				If Not Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsNumeric() OrElse Me.DataCol.ExtendColumnType = 8 Then
					GoTo IL_8BE
				End If
				IL_68D:
				num2 = 72
				Dim text2 As String = ""
				IL_697:
				num2 = 73
				If Not Me.DataCol.ShowCurrencySymbol Then
					GoTo IL_6D3
				End If
				IL_6A7:
				num2 = 74
				text2 = Me.DataCol.CurrencySymbol
				IL_6B7:
				num2 = 75
				If Operators.CompareString(text2, "", True) <> 0 Then
					GoTo IL_6D3
				End If
				IL_6C9:
				num2 = 76
				text2 = "￥"
				IL_6D3:
				num2 = 77
				If Not Me.DataCol.ThousandSeparator Then
					GoTo IL_72D
				End If
				IL_6E3:
				num2 = 78
				If Me.DataCol.FixedDigits <> 0 Then
					GoTo IL_706
				End If
				IL_6F3:
				num2 = 79
				text2 += "#,0"
				GoTo IL_76E
				IL_706:
				num2 = 81
				text2 = text2 + New String("0"c, Me.DataCol.FixedDigits - 1) + ",0)"
				GoTo IL_76E
				IL_72D:
				num2 = 83
				If Me.DataCol.FixedDigits <> 0 Then
					GoTo IL_750
				End If
				IL_73D:
				num2 = 84
				text2 += "#0"
				GoTo IL_76E
				IL_750:
				num2 = 86
				text2 += New String("0"c, Me.DataCol.FixedDigits)
				IL_76E:
				num2 = 87
				If Not(column.DataType Is GetType(Single) Or column.DataType Is GetType(Double)) AndAlso column.DataType IsNot GetType(Decimal) Then
					GoTo IL_85F
				End If
				IL_7AD:
				num2 = 88
				If Me.DataCol.Decimals <= 0 Then
					GoTo IL_85F
				End If
				IL_7C1:
				num2 = 89
				If Not Me.DataCol.FixedDecimals Then
					GoTo IL_83C
				End If
				IL_7D1:
				num2 = 90
				If Not Me.DataCol.PercentStyle Then
					GoTo IL_817
				End If
				IL_7E1:
				num2 = 91
				Dim num3 As Integer = Me.DataCol.Decimals - 2
				IL_7F3:
				num2 = 92
				If num3 <= 0 Then
					GoTo IL_85F
				End If
				IL_7FB:
				num2 = 93
				text2 = text2 + "." + New String("0"c, num3)
				GoTo IL_85F
				IL_817:
				num2 = 95
				text2 = text2 + "." + New String("0"c, Me.DataCol.Decimals)
				GoTo IL_85F
				IL_83C:
				num2 = 97
				text2 = text2 + "." + New String("#"c, Me.DataCol.Decimals)
				IL_85F:
				num2 = 98
				If Not Me.DataCol.PercentStyle Then
					GoTo IL_880
				End If
				IL_86F:
				num2 = 99
				text2 += "%"
				IL_880:
				num2 = 100
				If Not Me.UsetBuildInEditor Then
					GoTo IL_8B1
				End If
				IL_88B:
				num2 = 101
				column.Editor = O_O0OO.OoO.0OO__0ooo.()
				IL_899:
				num2 = 102
				CType(column.Editor, OO__oo_0ooo0_).CustomFormat = ""
				IL_8B1:
				num2 = 103
				column.Format = text2
				GoTo IL_8D2
				IL_8BE:
				num2 = 105
				column.EditMask = Me.DataCol.EditMask
				IL_8D2:
				num2 = 106
				If Me.DataCol.ExtendColumnType = 7 Then
					GoTo IL_947
				End If
				IL_8E3:
				num2 = 107
				column.DataMap = Me.DataCol.DataDictionary
				IL_8F7:
				num2 = 108
				column.ImageMap = Me.DataCol.imageDictionary
				IL_90B:
				num2 = 109
				If Not(Operators.CompareString(Me.DataCol.ComboList, "", True) = 0 And column.ImageMap IsNot Nothing) Then
					GoTo IL_947
				End If
				IL_933:
				num2 = 110
				column.ComboList = Me.DataCol.imageValues
				IL_947:
				num2 = 111
				Me.TextAlign = Me.DataCol.TextAlign
				IL_95B:
				num2 = 112
				Me.TextAlignFixed = Me.DataCol.TextAlignFixed
				IL_96F:
				num2 = 113
				If column.Editor IsNot Nothing OrElse Operators.CompareString(column.ComboList, "", True) <> 0 OrElse column.DataMap IsNot Nothing OrElse column.ImageMap IsNot Nothing OrElse column.DataType Is GetType(Boolean) Then
					GoTo IL_9BD
				End If
				IL_9AF:
				num2 = 114
				column.Editor = O_O0OO.OoO.0OO__0ooo.()
				IL_9BD:
				num2 = 115
				If column.ImageMap Is Nothing Then
					GoTo IL_9DE
				End If
				IL_9C8:
				num2 = 116
				column.ImageAndText = Me.DataCol.ImageAndText
				GoTo IL_9E8
				IL_9DE:
				num2 = 118
				column.ImageAndText = True
				IL_9E8:
				GoTo IL_C16
				IL_9ED:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_BD7:
				GoTo IL_C0B
				IL_BD9:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_BE9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_BD9
			End Try
			IL_C0B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_C16:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x17000979 RID: 2425
		' (get) Token: 0x06002898 RID: 10392 RVA: 0x00110A9C File Offset: 0x0010EC9C
		' (set) Token: 0x06002899 RID: 10393 RVA: 0x00110AE8 File Offset: 0x0010ECE8
		<oO0oooo("1786")>
		Public Property TextAlign As TextAlignEnum
			Get
				Dim textAlign As TextAlignEnum = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).TextAlign
				Dim result As TextAlignEnum
				If textAlign <> 1 Then
					If textAlign <> 4 Then
						If textAlign <> 7 Then
							result = 0
						Else
							result = 3
						End If
					Else
						result = 2
					End If
				Else
					result = 1
				End If
				Return result
			End Get
			Set(value As TextAlignEnum)
				If Not Me.Table.GridTreeVisible OrElse Operators.CompareString(Me.Table.OO0o_o0.0oOo0o., Me.o_o_O.0000_O., True) <> 0 OrElse value = 1 Then
					Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
					Select Case value
						Case 0
							If column.DataType Is GetType(String) OrElse column.DataType Is GetType(DateTime) OrElse column.DataType Is GetType(Boolean) Then
								column.TextAlign = 1
								Return
							End If
							If Me.DataCol.ExtendColumnType = 8 Then
								column.TextAlign = 1
								Return
							End If
							column.TextAlign = 7
							Return
						Case 1
							column.TextAlign = 1
							Return
						Case 2
							column.TextAlign = 4
							Return
						Case 3
							column.TextAlign = 7
						Case Else
							Return
					End Select
				End If
			End Set
		End Property

		' Token: 0x1700097A RID: 2426
		' (get) Token: 0x0600289A RID: 10394 RVA: 0x00110BCC File Offset: 0x0010EDCC
		' (set) Token: 0x0600289B RID: 10395 RVA: 0x00110C18 File Offset: 0x0010EE18
		<oO0oooo("1787")>
		Public Property TextAlignFixed As TextAlignEnum
			Get
				Dim textAlignFixed As TextAlignEnum = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).TextAlignFixed
				Dim result As TextAlignEnum
				If textAlignFixed <> 1 Then
					If textAlignFixed <> 4 Then
						If textAlignFixed <> 7 Then
							result = 0
						Else
							result = 3
						End If
					Else
						result = 2
					End If
				Else
					result = 1
				End If
				Return result
			End Get
			Set(value As TextAlignEnum)
				Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
				Select Case value
					Case 0, 2
						column.TextAlignFixed = 4
						Return
					Case 1
						column.TextAlignFixed = 1
						Return
					Case 3
						column.TextAlignFixed = 7
						Return
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x0600289C RID: 10396 RVA: 0x00110C74 File Offset: 0x0010EE74
		Private Sub <<EMPTY_NAME>>()
			Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
			If Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsDate() Then
				Select Case Me.DataCol.DateTimeFormat
					Case 0
						If Me.UsetBuildInEditor Then
							column.Editor = O_O0OO.o0_OO.000.()
						Else
							column.Editor = O_O0OO.OoO.0OO__0ooo.()
						End If
					Case 1
						column.Editor = O_O0OO.OoO.0OO__0ooo.()
					Case 2
						column.Editor = O_O0OO.o0_OO.000.()
				End Select
			ElseIf Me.o_o_O.0000_O..Cols(Me.o_o_O.0000_O.).IsNumeric() AndAlso Me.UsetBuildInEditor Then
				column.Editor = O_O0OO.OoO.0OO__0ooo.()
			End If
			If column.Editor Is Nothing AndAlso Operators.CompareString(column.ComboList, "", True) = 0 AndAlso column.DataType IsNot GetType(Boolean) Then
				column.Editor = O_O0OO.OoO.0OO__0ooo.()
			End If
		End Sub

		' Token: 0x1700097B RID: 2427
		' (get) Token: 0x0600289D RID: 10397 RVA: 0x00110D80 File Offset: 0x0010EF80
		Private ReadOnly Property Icon As Image
			Get
				Dim image As Image = Nothing
				If Operators.CompareString(Me.DataCol.CustomImage, "", True) > 0 Then
					image = OO_00oOO.GetImage(Me.DataCol.CustomImage)
				End If
				Dim result As Image
				If image IsNot Nothing Then
					result = image
				Else
					If Me.o_o_O.0000_O. IsNot Nothing Then
						If TypeOf Me.o_o_O.0000_O. Is O__o Then
							Return a.Text.ToBitmap()
						End If
						If TypeOf Me.o_o_O.0000_O. Is PictureViewer Then
							Return a.o_O00_0.oooO.().ToBitmap()
						End If
						If TypeOf Me.o_o_O.0000_O. Is FileManager Then
							Return a.O0oOo._.().ToBitmap()
						End If
					End If
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700097C RID: 2428
		' (get) Token: 0x0600289E RID: 10398 RVA: 0x00110E19 File Offset: 0x0010F019
		' (set) Token: 0x0600289F RID: 10399 RVA: 0x00110E3B File Offset: 0x0010F03B
		<oO0oooo("0566")>
		Public Property Width As Integer
			Get
				Return Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Width
			End Get
			Set(value As Integer)
				Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Width = value
			End Set
		End Property

		' Token: 0x1700097D RID: 2429
		' (get) Token: 0x060028A0 RID: 10400 RVA: 0x00110E60 File Offset: 0x0010F060
		' (set) Token: 0x060028A1 RID: 10401 RVA: 0x00110EDE File Offset: 0x0010F0DE
		<oO0oooo("0567")>
		Public Property PrintWidth As Double
			Get
				Dim result As Double
				If Me.Visible Then
					result = CDbl((CSng(Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).WidthDisplay) / SysInfo.ScreenDpiX)) * 25.4
				Else
					result = CDbl((CSng(Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Width) / SysInfo.ScreenDpiX)) * 25.4
				End If
				Return result
			End Get
			Set(value As Double)
				Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.).Width = CInt(Math.Round(CDbl(SysInfo.ScreenDpiX) / 25.4 * value))
			End Set
		End Property

		' Token: 0x060028A2 RID: 10402 RVA: 0x00110F18 File Offset: 0x0010F118
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetDateTimeFormat(format As DateTimeFormatEnum)
			Dim column As Column = Me.o_o_O.0000_O..foxGrid.Cols(Me.o_o_O.0000_O.)
			Select Case format
				Case 0
					column.Format = "yyyy-MM-dd"
					column.EditMask = "0000-00-00"
					If Operators.CompareString(column.ComboList, "", True) = 0 Then
						If Me.UsetBuildInEditor Then
							column.Editor = O_O0OO.o0_OO.000.()
							Return
						End If
						column.Editor = O_O0OO.OoO.0OO__0ooo.()
						Return
					End If
				Case 1
					column.Format = "HH:mm"
					column.EditMask = "00:00"
					If Operators.CompareString(column.ComboList, "", True) = 0 Then
						column.Editor = O_O0OO.OoO.0OO__0ooo.()
						Return
					End If
				Case 2
					column.Format = "HH:mm:ss"
					column.EditMask = "00:00:00"
					If Operators.CompareString(column.ComboList, "", True) = 0 Then
						column.Editor = O_O0OO.o0_OO.000.()
						Return
					End If
				Case 3
					column.Format = "yyyy-MM-dd HH:mm"
					column.EditMask = "0000-00-00 00:00"
					If Operators.CompareString(column.ComboList, "", True) = 0 Then
						If Me.UsetBuildInEditor Then
							column.Editor = O_O0OO.o0_OO.000.()
							Return
						End If
						column.Editor = O_O0OO.OoO.0OO__0ooo.()
						Return
					End If
				Case 4
					column.Format = "yyyy-MM-dd HH:mm:ss"
					column.EditMask = "0000-00-00 00:00:00"
					If Operators.CompareString(column.ComboList, "", True) = 0 Then
						If Me.UsetBuildInEditor Then
							column.Editor = O_O0OO.o0_OO.000.()
							Return
						End If
						column.Editor = O_O0OO.OoO.0OO__0ooo.()
					End If
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x1700097E RID: 2430
		' (get) Token: 0x060028A3 RID: 10403 RVA: 0x001110AB File Offset: 0x0010F2AB
		' (set) Token: 0x060028A4 RID: 10404 RVA: 0x001110B4 File Offset: 0x0010F2B4
		<oO0oooo("2115")>
		Public Property DropForm As String
			Get
				Return Me.OO_0._O00_O_o0.
			End Get
			Set(value As String)
				Me.OO_0._O00_O_o0. = value
				If Operators.CompareString(value, "", True) = 0 Then
					Dim column As Column = Me.Table.foxGrid.Cols(Me.Name)
					If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is OooO00O Then
						CType(column.Editor, OooO00O).DropDownForm.Controls.Clear()
						column.Editor = Nothing
					End If
					Me.oo_0_oO._.()
					Return
				End If
				If Operators.CompareString(value, "", True) > 0 Then
					If Conversions.ToInteger(OO_00oOO.Forms(value).O_o_.0o0__o0O.("Type")) <> 233 Then
						MessageBox.Show(value + """不能作为下拉窗口使用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					Dim column2 As Column = Me.Table.foxGrid.Cols(Me.Name)
					Dim oooO00O As OooO00O = Nothing
					If column2.Editor IsNot Nothing AndAlso TypeOf column2.Editor Is OooO00O Then
						oooO00O = CType(column2.Editor, OooO00O)
					End If
					If oooO00O Is Nothing Then
						oooO00O = New OooO00O()
					End If
					oooO00O.OO.o.(value)
					column2.Editor = oooO00O
					oooO00O.o0O.0___0_.(Me.AllowDirectType)
				End If
			End Set
		End Property

		' Token: 0x060028A5 RID: 10405 RVA: 0x001111E4 File Offset: 0x0010F3E4
		Public Sub OpenDropDown()
			Dim column As Column = Me.Table.foxGrid.Cols(Me.Name)
			If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is C1DropDownControl AndAlso column.Editor.Focused Then
				CType(column.Editor, C1DropDownControl).OpenDropDown()
			End If
		End Sub

		' Token: 0x060028A6 RID: 10406 RVA: 0x00111240 File Offset: 0x0010F440
		Public Sub CloseDropDown()
			Dim column As Column = Me.Table.foxGrid.Cols(Me.Name)
			If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is C1DropDownControl AndAlso Me.Table.foxGrid.Editor Is column.Editor Then
				CType(column.Editor, C1DropDownControl).CloseDropDown()
			End If
		End Sub

		' Token: 0x1700097F RID: 2431
		' (get) Token: 0x060028A7 RID: 10407 RVA: 0x001112A8 File Offset: 0x0010F4A8
		Public ReadOnly Property DroppedDown As Boolean
			Get
				Dim column As Column = Me.Table.foxGrid.Cols(Me.Name)
				Dim droppedDown As Boolean
				If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is C1DropDownControl Then
					droppedDown = CType(column.Editor, C1DropDownControl).DroppedDown
				End If
				Return droppedDown
			End Get
		End Property

		' Token: 0x17000980 RID: 2432
		' (get) Token: 0x060028A8 RID: 10408 RVA: 0x001112F8 File Offset: 0x0010F4F8
		<oO0oooo("2469")>
		Public ReadOnly Property FileManager As FileManager
			Get
				Dim result As FileManager
				If Me.o_o_O.0000_O. IsNot Nothing AndAlso TypeOf Me.o_o_O.0000_O. Is FileManager Then
					result = New FileManager(CType(Me.o_o_O.0000_O., FileManager))
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000981 RID: 2433
		' (get) Token: 0x060028A9 RID: 10409 RVA: 0x00111330 File Offset: 0x0010F530
		<oO0oooo("2470")>
		Public ReadOnly Property PictureViewer As PictureViewer
			Get
				Dim result As PictureViewer
				If Me.o_o_O.0000_O. IsNot Nothing AndAlso TypeOf Me.o_o_O.0000_O. Is PictureViewer Then
					result = New PictureViewer(CType(Me.o_o_O.0000_O., PictureViewer))
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x060028AA RID: 10410 RVA: 0x00111368 File Offset: 0x0010F568
		Public Sub Refresh()
			If Me.Table.foxGrid.Cols.Contains(Me.Name) Then
				Me.Table.foxGrid.Cols(Me.Name).Invalidate()
			End If
		End Sub

		' Token: 0x040010B1 RID: 4273
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010B2 RID: 4274
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040010B3 RID: 4275
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010B4 RID: 4276
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010B5 RID: 4277
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010B6 RID: 4278
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010B7 RID: 4279
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040010B8 RID: 4280
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040010B9 RID: 4281
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010BA RID: 4282
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010BB RID: 4283
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010BC RID: 4284
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010BD RID: 4285
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010BE RID: 4286
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010BF RID: 4287
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010C0 RID: 4288
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010C1 RID: 4289
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010C2 RID: 4290
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010C3 RID: 4291
		Friend <<EMPTY_NAME>> As System.Windows.Forms.Control

		' Token: 0x040010C4 RID: 4292
		Friend <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
