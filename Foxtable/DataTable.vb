Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Foxtable.My.Resources
Imports Foxtable.RibbonMenu
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000299 RID: 665
	<ComVisible(True)>
	<oO0oooo("1584")>
	Public Class DataTable
		' Token: 0x170007CD RID: 1997
		' (get) Token: 0x0600216C RID: 8556 RVA: 0x000DD475 File Offset: 0x000DB675
		' (set) Token: 0x0600216D RID: 8557 RVA: 0x000DD480 File Offset: 0x000DB680
		Friend Overridable Property _DataTable As DataTable
			<CompilerGenerated()>
			Get
				Return Me.O0O__o.00_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataTable)
				Dim value2 As DataColumnChangeEventHandler = AddressOf Me.o_oO.o.
				Dim value3 As DataColumnChangeEventHandler = AddressOf Me.oo__._.
				Dim value4 As DataTableNewRowEventHandler = AddressOf Me.oo__._.
				Dim value5 As DataRowChangeEventHandler = AddressOf Me.O_0.O.
				Dim value6 As DataRowChangeEventHandler = AddressOf Me.o_oO.o.
				Dim value7 As DataRowChangeEventHandler = AddressOf Me.oo__._.
				Dim o0O__o.00_. As DataTable = Me.O0O__o.00_.
				If o0O__o.00_. IsNot Nothing Then
					RemoveHandler o0O__o.00_..ColumnChanged, value2
					RemoveHandler o0O__o.00_..ColumnChanging, value3
					RemoveHandler o0O__o.00_..TableNewRow, value4
					RemoveHandler o0O__o.00_..RowChanged, value5
					RemoveHandler o0O__o.00_..RowDeleted, value6
					RemoveHandler o0O__o.00_..RowDeleting, value7
				End If
				Me.O0O__o.00_. = value
				o0O__o.00_. = Me.O0O__o.00_.
				If o0O__o.00_. IsNot Nothing Then
					AddHandler o0O__o.00_..ColumnChanged, value2
					AddHandler o0O__o.00_..ColumnChanging, value3
					AddHandler o0O__o.00_..TableNewRow, value4
					AddHandler o0O__o.00_..RowChanged, value5
					AddHandler o0O__o.00_..RowDeleted, value6
					AddHandler o0O__o.00_..RowDeleting, value7
				End If
			End Set
		End Property

		' Token: 0x170007CE RID: 1998
		' (get) Token: 0x0600216E RID: 8558 RVA: 0x000DD560 File Offset: 0x000DB760
		' (set) Token: 0x0600216F RID: 8559 RVA: 0x000DD568 File Offset: 0x000DB768
		Friend Overridable Property _Adapter As OleDbDataAdapter
			<CompilerGenerated()>
			Get
				Return Me.O0O__o.00_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbDataAdapter)
				Dim value2 As OleDbRowUpdatedEventHandler = AddressOf Me.O._0O_O0O.
				Dim o0O__o.00_. As OleDbDataAdapter = Me.O0O__o.00_.
				If o0O__o.00_. IsNot Nothing Then
					RemoveHandler o0O__o.00_..RowUpdated, value2
				End If
				Me.O0O__o.00_. = value
				o0O__o.00_. = Me.O0O__o.00_.
				If o0O__o.00_. IsNot Nothing Then
					AddHandler o0O__o.00_..RowUpdated, value2
				End If
			End Set
		End Property

		' Token: 0x06002170 RID: 8560 RVA: 0x000DD5AB File Offset: 0x000DB7AB
		Friend Sub New(A_0 As DataTable, A_1 As OleDbDataAdapter, A_2 As OleDbConnection, A_3 As String, A_4 As DataSet)
			Me.New(A_0, A_1, A_2, A_3, A_4, Nothing)
		End Sub

		' Token: 0x06002171 RID: 8561 RVA: 0x000DD5BC File Offset: 0x000DB7BC
		Friend Sub New(A_0 As DataTable, A_1 As OleDbDataAdapter, A_2 As OleDbConnection, A_3 As String, A_4 As DataSet, A_5 As HttpClient)
			Me.o_0_00_.oo0O0. = New GlobalEvents()
			Me.o.O0O_0__OOo_. = Nothing
			Me.o_oO0O_.O0. = Nothing
			Me.o0__.Oo0o__O. = Nothing
			Me.o_oO0O_.O0. = Nothing
			Me.o._OOO0oOo0__. = Nothing
			Me.o_oO0O_.O0. = New DataTableProperty(Me)
			Me.OO._Ooo0. = New LookAndFeelProperty()
			Me.o._000. = True
			Me.o0O._ooo_o___. = False
			Me.oo0__.00_. = True
			Me.Ooo._O_0Oo___. = True
			Me.O_oo0o_O0._0o. = True
			Me.o_0._Ooo____OO. = True
			Me.Oo0.O__OO. = True
			Me.oO0oO._0_. = True
			Me.o.___. = True
			Me.o0O.O0o_OOOoo. = True
			Me.Oo0o00o.Oo0_O. = True
			Me.O_O._. = True
			Me.O0.oOO0_. = False
			Me.OOooo.0o_0O_O_. = True
			Me.Ooo00.oo. = True
			Me.oO.0o0O0oO. = True
			Me.o.o_O00O_O_0. = True
			Me.oo._O_o0_O. = True
			Me.O.__00_o0. = Nothing
			Me.O_oo.__0_. = Nothing
			Me.o_0o0o0oo0.O. = Nothing
			Me.Oo0O00Ooo._. = Nothing
			Me.o_oO0O_.O0. = 0
			Me.OO._0oo000_00. = 0
			Me.o0O._ooo_o___. = 0
			Me.o_o._OOoo0OOoO. = 0
			Me.O.oo. = 30
			Me.o_oO0O_.O0. = 0
			Me.O.00oo0oOoOOo0. = 0
			Me.O_Oo._. = Nothing
			Me.O0___.O. = False
			Me.Oo0Oo_.O000. = False
			Me.o_O_0.0_O. = Nothing
			Me.Ooo00._0_oO_. = Nothing
			Me.OOoO._o. = Nothing
			Me.O_.oO_O_. = -1
			Me.O_0o0._O0. = False
			Me.o0_oO00.0oO_. = Nothing
			Me.O0o0__o.0000__. = Nothing
			Me.Oo.OO0ooOOo_. = False
			Me.O000_00._0_o. = True
			Me.OO00.oO_. = Nothing
			Me.o_0.0O0o__0. = Nothing
			Me.Oo0O0.0. = Nothing
			Me.oo.o0_oO__o. = Nothing
			Me.Ooo.Oo0o0. = Nothing
			Me.oOo0_oo.OOo_. = Nothing
			Me.Oo0O00Ooo._. = Nothing
			Me.Oo_.O_. = Nothing
			Me.O0O00o_.0Oo. = Nothing
			Me.o.__Oo_Oo_. = Nothing
			Me.O_000o_.O. = Nothing
			Me.O.oO0_00. = Nothing
			Me.Oo0__O0.0. = Nothing
			Me.O0__oo_0O_.__. = Nothing
			Me.o.O_0. = Nothing
			Me.O_.__0. = Nothing
			Me.OOoOO0O_._0__. = Nothing
			Me.O00.O. = Nothing
			Me.O._O00000. = Nothing
			Me.o_o._000_0_. = Nothing
			Me.o0OOOo_.0_o_0o. = False
			Me.o00o.00oO___0. = New List(Of String)()
			Me.O0O00ooOo.o_. = 200
			Me.O._O0__. = ""
			Me.o_oO0O_.O0. = 0
			Me.O0__.00. = "(default)"
			Me._DataTable = A_0
			Me._Adapter = A_1
			Me.o0__.Oo0o__O. = A_2
			Me.o._OOO0oOo0__. = A_3
			Me.o_oO0O_.O0. = New DataRowCollection(A_0)
			If Not Me._DataTable.Columns.Contains("_Locked") Then
				Me._DataTable.Columns.Add("_Locked", GetType(Boolean))
				Me.O000_00._0_o. = False
			End If
			If Me._DataTable.PrimaryKey.Length = 1 AndAlso Not Me._DataTable.PrimaryKey(0).AutoIncrement AndAlso A_2 IsNot Nothing AndAlso o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_2) AndAlso o_O_o_oOoo__.OO_.O.(Me._DataTable.PrimaryKey(0).DataType) Then
				Dim dataRow As DataRow = A_4.Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { Me.Name, "SEQUENCE", 8 })
				If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Property") Then
					Me.SEQUENCE = dataRow("Property").ToString()
					Me._DataTable.PrimaryKey(0).AutoIncrement = True
					If Me._DataTable.Rows.Count = 0 Then
						Me._DataTable.PrimaryKey(0).AutoIncrementSeed = 1L
					Else
						Me._DataTable.PrimaryKey(0).AutoIncrementSeed = Convert.ToInt64(RuntimeHelpers.GetObjectValue(Me._DataTable.Compute("Max([" + Me._DataTable.PrimaryKey(0).ColumnName + "])", ""))) + 1L
					End If
				Else
					Me.SEQUENCE = "@@@"
				End If
			End If
			If Me._DataTable.PrimaryKey.Length = 1 AndAlso Me._DataTable.PrimaryKey(0).AutoIncrement Then
				Me.O_.__0. = Me._DataTable.PrimaryKey(0).ColumnName
			End If
			If Me._DataTable.Columns.Contains("_SortKey") Then
				Me.o0O.O_0.(A_5)
			End If
			If Not Me._DataTable.Columns.Contains("System_Sort_Temporary") Then
				Me._DataTable.Columns.Add("System_Sort_Temporary", GetType(Double))
				Me._DataTable.Columns.Add("System_Filter_Temporary", GetType(Integer))
				Me._DataTable.Columns.Add("System_Filter_Unique", GetType(Integer))
			End If
			If Me._Adapter IsNot Nothing Then
				If Me._Adapter.UpdateCommand Is Nothing Then
					Me.Ooo._O_0Oo___. = False
				End If
				Dim a_ As String = Me.frd_SelectCommandString
				Dim a_2 As String = Me.LoadFilter
				Dim a_3 As String = Me.LoadTop
				Dim a_4 As String = Me.LoadOrder
				Oo00.ooO.ooo.(a_, a_2, a_3, Me.o0_oO00.0oO_., Me.O0o0__o.0000__., a_4)
				Me.LoadOrder = a_4
				Me.LoadTop = a_3
				Me.LoadFilter = a_2
				Me.ooO.oO0O0_oo. = False
			Else
				Operators.CompareString(Me.DataServer, "", True)
			End If
			If Me._DataTable.ExtendedProperties.ContainsKey("foxtable.datatable") Then
				Me._DataTable.ExtendedProperties.Remove("foxtable.datatable")
			End If
			Me._DataTable.ExtendedProperties.Add("foxtable.datatable", Me)
			If Me._DataTable.Columns.Contains("sys_Hierarchy_Level") Then
				Me.oOOO.OOO_0ooO0. = True
			End If
		End Sub

		' Token: 0x170007CF RID: 1999
		' (get) Token: 0x06002172 RID: 8562 RVA: 0x000DDB6A File Offset: 0x000DBD6A
		' (set) Token: 0x06002173 RID: 8563 RVA: 0x000DDB72 File Offset: 0x000DBD72
		Friend Property IsDeletingRows As Boolean

		' Token: 0x170007D0 RID: 2000
		' (get) Token: 0x06002174 RID: 8564 RVA: 0x000DDB7B File Offset: 0x000DBD7B
		' (set) Token: 0x06002175 RID: 8565 RVA: 0x000DDB84 File Offset: 0x000DBD84
		Public Property BaseTable As DataTable
			Get
				Return Me._DataTable
			End Get
			Set(value As DataTable)
				Me._DataTable = value
				If Me.OO._0oo000_00. IsNot Nothing Then
					Me.OO._0oo000_00..ExtendedProperties.Clear()
					Me.OO._0oo000_00. = Nothing
				End If
				Me.o_oO0O_.O0. = Nothing
				Me._Adapter = Nothing
				Me.o0__.Oo0o__O. = Nothing
				Me.o._OOO0oOo0__. = Nothing
			End Set
		End Property

		' Token: 0x170007D1 RID: 2001
		' (get) Token: 0x06002176 RID: 8566 RVA: 0x000DDBD3 File Offset: 0x000DBDD3
		' (set) Token: 0x06002177 RID: 8567 RVA: 0x000DDBDB File Offset: 0x000DBDDB
		Friend Property frd_Setting As DataTableProperty
			Get
				Return Me.o_oO0O_.O0.
			End Get
			Set(value As DataTableProperty)
			End Set
		End Property

		' Token: 0x170007D2 RID: 2002
		' (get) Token: 0x06002178 RID: 8568 RVA: 0x000DDBDD File Offset: 0x000DBDDD
		' (set) Token: 0x06002179 RID: 8569 RVA: 0x000DDBE5 File Offset: 0x000DBDE5
		Friend Property frd_LookAndFeel As LookAndFeelProperty
			Get
				Return Me.OO._Ooo0.
			End Get
			Set(value As LookAndFeelProperty)
				Me.OO._Ooo0. = value
			End Set
		End Property

		' Token: 0x0600217A RID: 8570 RVA: 0x000DDBEE File Offset: 0x000DBDEE
		Friend Sub <<EMPTY_NAME>>()
			Me.o.O0O_0__OOo_. = New DataColCollection(Me._DataTable)
		End Sub

		' Token: 0x0600217B RID: 8571 RVA: 0x000DDC04 File Offset: 0x000DBE04
		Friend Sub <<EMPTY_NAME>>()
			Me.o.O0O_0__OOo_. = New DataColCollection(Me._DataTable)
			If Me._DataTable.DataSet IsNot Nothing Then
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { Me._DataTable.TableName, "" })
				If dataRow IsNot Nothing Then
					o_O_o_oOoo__.OOOO_OO._oo.(Me.o_oO0O_.O0., Conversions.ToString(dataRow("Config")), vbVerticalTab)
				End If
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "{" + Me._DataTable.TableName + "}", "" })
				If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") Then
					o_O_o_oOoo__.OOOO_OO._oo.(Me.frd_LookAndFeel, Conversions.ToString(dataRow("Config")), vbVerticalTab)
				End If
				If OO_00oOO.User.Type Is Nothing AndAlso OO_00oOO.ModifierKey = Keys.Control Then
					Me.o_0_00_.oo0O0. = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
				Else
					Me.o0.0_0OO0o_0o.(False)
				End If
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { Me.Name, "", 4 })
				If dataRow IsNot Nothing Then
					o_O_o_oOoo__.OOOO_OO._oo.(New DockSetting(Me), Conversions.ToString(dataRow("Property")), vbVerticalTab)
				End If
			End If
		End Sub

		' Token: 0x0600217C RID: 8572 RVA: 0x000DDDB4 File Offset: 0x000DBFB4
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = String.Concat(New String() { OO_00oOO.ProjectPath, "Bin\", o0OoOOoOOo0.oo00o.0OoO.(""), ".DataTable.", o0OoOOoOOo0.OO0._Oo0o.(Me.Name), ".dll" })
				IL_50:
				num2 = 3
				Me.oOOO.0. = False
				IL_59:
				num2 = 4
				If Not OO_00oOO.FileSys.FileExists(text) Then
					GoTo IL_83
				End If
				IL_68:
				num2 = 5
				Dim rawAssembly As Byte() = File.ReadAllBytes(text)
				IL_72:
				num2 = 6
				Me.o_0_00_.oo0O0. = Assembly.Load(rawAssembly)
				GoTo IL_8C
				IL_83:
				num2 = 8
				Me.o_0_00_.oo0O0. = Nothing
				IL_8C:
				num2 = 9
				Me.o0O.O_0.(Me.o_0_00_.oo0O0.)
				IL_9B:
				GoTo IL_112
				IL_9D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_D3:
				GoTo IL_107
				IL_D5:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_E5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_D5
			End Try
			IL_107:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_112:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600217D RID: 8573 RVA: 0x000DDEEC File Offset: 0x000DC0EC
		Friend Sub <<EMPTY_NAME>>(A_0 As Assembly)
			Dim type As Type = Nothing
			If A_0 IsNot Nothing Then
				type = A_0.[GetType]("UserCode")
			End If
			If type IsNot Nothing Then
				Me.oOo0_oo.OOo_. = type.GetMethod("FilterRow")
				Me.OO00.oO_. = type.GetMethod("DrawCell")
				Me.o_0.0O0o__0. = type.GetMethod("MouseEnterCell")
				Me.Oo0O0.0. = type.GetMethod("MouseLeaveCell")
				Me.oo.o0_oO__o. = type.GetMethod("MouseHoverCell")
				Me.Ooo.Oo0o0. = type.GetMethod("BeforeDrawRow")
				Me.Oo0O00Ooo._. = type.GetMethod("PrepareEdit")
				Me.Oo_.O_. = type.GetMethod("StartEdit")
				Me.O0O00o_.0Oo. = type.GetMethod("AfterEdit")
				Me.o.__Oo_Oo_. = type.GetMethod("BeforeSaveDataRow")
				Me.O_000o_.O. = type.GetMethod("AfterSaveDataRow")
				Me.O.oO0_00. = type.GetMethod("BeforeDeleteDataRow")
				Me.Oo0__O0.0. = type.GetMethod("DataRowLockedChanging")
				Me.O0__oo_0O_.__. = type.GetMethod("DataRowLockedChanged")
				Me.o.O_0. = type.GetMethod("DataColChanged")
				Me.O_.__0. = type.GetMethod("DataColChanging")
				Me.OOoOO0O_._0__. = type.GetMethod("DataRowAdding")
				Me.O00.O. = type.GetMethod("DataRowAdded")
				Me.O._O00000. = type.GetMethod("DataRowDeleted")
				Me.o_o._000_0_. = type.GetMethod("DataRowDeleting")
				Return
			End If
			Me.oOo0_oo.OOo_. = Nothing
			Me.OO00.oO_. = Nothing
			Me.o_0.0O0o__0. = Nothing
			Me.Oo0O0.0. = Nothing
			Me.oo.o0_oO__o. = Nothing
			Me.Ooo.Oo0o0. = Nothing
			Me.Oo0O00Ooo._. = Nothing
			Me.Oo_.O_. = Nothing
			Me.O0O00o_.0Oo. = Nothing
			Me.o.__Oo_Oo_. = Nothing
			Me.O_000o_.O. = Nothing
			Me.O.oO0_00. = Nothing
			Me.Oo0__O0.0. = Nothing
			Me.O0__oo_0O_.__. = Nothing
			Me.o.O_0. = Nothing
			Me.O_.__0. = Nothing
			Me.OOoOO0O_._0__. = Nothing
			Me.O00.O. = Nothing
			Me.O._O00000. = Nothing
			Me.o_o._000_0_. = Nothing
		End Sub

		' Token: 0x170007D3 RID: 2003
		' (get) Token: 0x0600217E RID: 8574 RVA: 0x000DE0F1 File Offset: 0x000DC2F1
		' (set) Token: 0x0600217F RID: 8575 RVA: 0x000DE0F9 File Offset: 0x000DC2F9
		Friend Property frd_Connection As OleDbConnection
			Get
				Return Me.o0__.Oo0o__O.
			End Get
			Set(value As OleDbConnection)
			End Set
		End Property

		' Token: 0x170007D4 RID: 2004
		' (get) Token: 0x06002180 RID: 8576 RVA: 0x000DE0FC File Offset: 0x000DC2FC
		<oO0oooo("2343")>
		Public ReadOnly Property SourceType As Integer
			Get
				Dim result As Integer
				If Me.o0__.Oo0o__O. IsNot Nothing Then
					result = CInt(Oo00.OoO_.__o.(Me.o0__.Oo0o__O.))
				ElseIf Operators.CompareString(Me.DataServer, "", True) > 0 Then
					Dim oo.OoO0. As Integer = CInt(O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).OO.OoO0.)
					If oo.OoO0. >= 1 AndAlso oo.OoO0. <= 3 Then
						result = oo.OoO0.
					End If
				Else
					result = 0
				End If
				Return result
			End Get
		End Property

		' Token: 0x170007D5 RID: 2005
		' (get) Token: 0x06002181 RID: 8577 RVA: 0x000DE158 File Offset: 0x000DC358
		' (set) Token: 0x06002182 RID: 8578 RVA: 0x000DE160 File Offset: 0x000DC360
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SEQUENCE As String
			Get
				Return Me.o_oO0O_.O0.
			End Get
			Set(value As String)
				Me.o_oO0O_.O0. = value
			End Set
		End Property

		' Token: 0x170007D6 RID: 2006
		' (get) Token: 0x06002183 RID: 8579 RVA: 0x000DE169 File Offset: 0x000DC369
		' (set) Token: 0x06002184 RID: 8580 RVA: 0x000DE174 File Offset: 0x000DC374
		Friend Property frd_ActualName As String
			Get
				Return Me.o._OOO0oOo0__.
			End Get
			Set(value As String)
				If Operators.CompareString(Me.o._OOO0oOo0__., value, True) <> 0 Then
					Dim text As String = Me._Adapter.SelectCommand.CommandText
					Dim text2 As String
					Dim str As String
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
						text2 = Me.o._OOO0oOo0__.
						str = value
					Else
						text2 = "[" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
						str = "[" + value + "]"
					End If
					Dim num As Integer = text.LastIndexOf(text2)
					If num + text2.Length < text.Length Then
						text = text.Substring(0, num) + str + text.Substring(num + text2.Length)
					Else
						text = text.Substring(0, num) + str
					End If
					Me.o._OOO0oOo0__. = value
					Me._Adapter.SelectCommand.CommandText = text
					Me.O_00_._.()
				End If
			End Set
		End Property

		' Token: 0x170007D7 RID: 2007
		' (get) Token: 0x06002185 RID: 8581 RVA: 0x000DE25C File Offset: 0x000DC45C
		' (set) Token: 0x06002186 RID: 8582 RVA: 0x000DE26E File Offset: 0x000DC46E
		Friend Property frd_SelectCommandString As String
			Get
				Return Me._Adapter.SelectCommand.CommandText
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x06002187 RID: 8583 RVA: 0x000DE270 File Offset: 0x000DC470
		Private Sub <<EMPTY_NAME>>()
			If OO_00oOO.Tables IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.View.o_o.O0ooOo.() Is Me._DataTable Then
							table.Ooo0ooOOo.o.()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06002188 RID: 8584 RVA: 0x000DE2D8 File Offset: 0x000DC4D8
		Friend Sub <<EMPTY_NAME>>(A_0 As DataCol)
			Dim obj As Object = Me._DataTable
			Dim array As DataRow()
			SyncLock obj
				array = Me._DataTable.[Select]("", "", DataViewRowState.CurrentRows)
			End SyncLock
			For Each dataRow As DataRow In array
				Dim dataColEventArgs As DataColEventArgs = New DataColEventArgs(Me, New DataRow(dataRow), A_0, RuntimeHelpers.GetObjectValue(dataRow(A_0.Name)), RuntimeHelpers.GetObjectValue(dataRow(A_0.Name)))
				If Me.o.O_0. IsNot Nothing Then
					Try
						Me.o.O_0..Invoke(Nothing, New Object() { dataColEventArgs })
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "表，" + Me.Name + "， DataColChanged")
						Exit Try
					End Try
				End If
				If Me.GlobalHandler.DataColChanged AndAlso O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O. IsNot Nothing Then
					Try
						O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O..Invoke(Nothing, New Object() { dataColEventArgs })
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "全局表事件, DataColChanged")
					End Try
				End If
			Next
		End Sub

		' Token: 0x06002189 RID: 8585 RVA: 0x000DE438 File Offset: 0x000DC638
		Friend Sub <<EMPTY_NAME>>(A_0 As DataCol, A_1 As DataRow)
			Dim dataColEventArgs As DataColEventArgs = New DataColEventArgs(Me, A_1, A_0, RuntimeHelpers.GetObjectValue(A_1(A_0.Name)), RuntimeHelpers.GetObjectValue(A_1(A_0.Name)))
			If Me.o.O_0. IsNot Nothing Then
				Try
					Me.o.O_0..Invoke(Nothing, New Object() { dataColEventArgs })
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "表，" + Me.Name + "， DataColChanged")
				End Try
			End If
			If Me.GlobalHandler.DataColChanged AndAlso O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O. IsNot Nothing Then
				Try
					O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O..Invoke(Nothing, New Object() { dataColEventArgs })
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "全局表事件, DataColChanged")
				End Try
			End If
		End Sub

		' Token: 0x0600218A RID: 8586 RVA: 0x000DE528 File Offset: 0x000DC728
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataColumnChangeEventArgs)
			If Operators.CompareString(A_1.Column.ColumnName, Me.OO_.OOo0o0., True) <> 0 AndAlso Me._DataTable.DataSet IsNot Nothing AndAlso Not Me.o.OOO_oO0_0O_o. Then
				Dim obj As Object = Nothing
				Me.o0._o_. = False
				If Operators.CompareString(A_1.Column.ColumnName, "_SortKey", True) <> 0 Then
					If Operators.CompareString(A_1.Column.ColumnName, "_Locked", True) = 0 AndAlso A_1.Row.RowState <> DataRowState.Detached Then
						If Not Me.O000_00._0_o. Then
							If A_1.Row.RowState = DataRowState.Unchanged Then
								Me.o0._o_. = True
								Return
							End If
							Return
						Else
							Try
								A_1.Row.EndEdit()
								Return
							Catch a_ As Exception
								ooO.oOo0Oo.o.(a_, "")
								A_1.Row.CancelEdit()
								Return
							End Try
						End If
					End If
					If o_O_o_oOoo__.oO.O_..Contains(A_1.Column.ColumnName) Then
						If A_1.Row.RowState = DataRowState.Unchanged Then
							Me.o0._o_. = True
							Return
						End If
					Else
						If A_1.Column.ExtendedProperties.Contains("ov") Then
							Dim dictionary As Dictionary(Of DataRow, Object) = CType(A_1.Column.ExtendedProperties("ov"), Dictionary(Of DataRow, Object))
							If dictionary.ContainsKey(A_1.Row) Then
								obj = RuntimeHelpers.GetObjectValue(dictionary(A_1.Row))
								dictionary.Remove(A_1.Row)
							End If
						End If
						If A_1.Row.HasVersion(DataRowVersion.Current) AndAlso String.Compare(A_1.ProposedValue.ToString(), A_1.Row(A_1.Column, DataRowVersion.Current).ToString(), False) = 0 Then
							If A_1.Row.RowState = DataRowState.Unchanged Then
								Me.o0._o_. = True
								Return
							End If
						ElseIf OO_00oOO.SystemReady Then
							If Me.DataCols(A_1.Column.ColumnName).IsTemporary AndAlso A_1.Row.RowState = DataRowState.Unchanged AndAlso (Me.frd_IsOuterTable OrElse Me.frd_IsInnerTable) Then
								Me.o0._o_. = True
							End If
							Try
								A_1.Row.EndEdit()
							Catch a_2 As Exception
								ooO.oOo0Oo.o.(a_2, "")
								A_1.Row.CancelEdit()
								Return
							End Try
							Dim dataColEventArgs As DataColEventArgs = New DataColEventArgs(Me, New DataRow(A_1.Row), Me.DataCols(A_1.Column.ColumnName), RuntimeHelpers.GetObjectValue(A_1.ProposedValue), RuntimeHelpers.GetObjectValue(obj))
							If Me.o.O_0. IsNot Nothing Then
								Try
									Me.o.O_0..Invoke(Nothing, New Object() { dataColEventArgs })
								Catch a_3 As Exception
									ooO.oOo0Oo.o.(a_3, "表，" + Me.Name + "，DataColChanged")
								End Try
							End If
							If Me.GlobalHandler.DataColChanged AndAlso O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O. IsNot Nothing Then
								Try
									O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O..Invoke(Nothing, New Object() { dataColEventArgs })
								Catch a_4 As Exception
									ooO.oOo0Oo.o.(a_4, "全局表事件, DataColChanged")
								End Try
							End If
							If Me.DataCols(A_1.Column.ColumnName).IsNumeric Then
								Try
									For Each table As Table In OO_00oOO.Tables
										If table.DataTable.BaseTable Is Me.BaseTable Then
											If table.GridTreeVisible AndAlso table.o.0ooOO_0__. IsNot Nothing Then
												Try
													For Each text As String In table.o.0ooOO_0__.
														If Operators.CompareString(text, A_1.Column.ColumnName, True) = 0 Then
															table.O0o._oo_.(A_1.Row, A_1.Column.ColumnName, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(A_1.ProposedValue))
														Else
															Dim dataColumn As DataColumn = table.DataTable.BaseTable.Columns(text)
															If Operators.CompareString(dataColumn.Expression, "", True) > 0 AndAlso dataColumn.Expression.IndexOf(A_1.Column.ColumnName, StringComparison.OrdinalIgnoreCase) >= 0 Then
																table.O0o._oo_.(A_1.Row, text)
															End If
														End If
													Next
													Continue For
												Finally
													Dim enumerator2 As HashSet(Of String).Enumerator
													CType(enumerator2, IDisposable).Dispose()
												End Try
											End If
											If table.foxGrid.OO.o_o00o.() Then
												Try
													For Each text2 As String In table.o.0ooOO_0__.
														If Operators.CompareString(text2, A_1.Column.ColumnName, True) = 0 Then
															table.O_0o__O0O0_0.0.(A_1.Row, A_1.Column.ColumnName, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(A_1.ProposedValue))
														Else
															Dim dataColumn2 As DataColumn = table.DataTable.BaseTable.Columns(text2)
															If Operators.CompareString(dataColumn2.Expression, "", True) > 0 AndAlso dataColumn2.Expression.IndexOf(A_1.Column.ColumnName, StringComparison.OrdinalIgnoreCase) >= 0 Then
																table.O_0o__O0O0_0.0.(A_1.Row, text2)
															End If
														End If
													Next
												Finally
													Dim enumerator3 As HashSet(Of String).Enumerator
													CType(enumerator3, IDisposable).Dispose()
												End Try
											End If
										End If
									Next
								Finally
									Dim enumerator As IEnumerator(Of Table)
									If enumerator IsNot Nothing Then
										enumerator.Dispose()
									End If
								End Try
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600218B RID: 8587 RVA: 0x000DEB38 File Offset: 0x000DCD38
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataColumnChangeEventArgs)
			If Operators.CompareString(A_1.Column.ColumnName, Me.OO_.OOo0o0., True) <> 0 AndAlso Me._DataTable.DataSet IsNot Nothing AndAlso Not Me.o.OOO_oO0_0O_o. Then
				If A_1.ProposedValue Is Nothing Then
					A_1.ProposedValue = DBNull.Value
				End If
				If Operators.CompareString(A_1.Column.ColumnName, "_SortKey", True) <> 0 Then
					If A_1.Column.DataType Is GetType(Boolean) AndAlso A_1.ProposedValue Is DBNull.Value Then
						A_1.ProposedValue = False
					End If
					If Operators.CompareString(A_1.Column.ColumnName, "System_Sort_Temporary", True) <> 0 Then
						If A_1.Column.DataType Is GetType(String) AndAlso A_1.ProposedValue IsNot DBNull.Value AndAlso A_1.ProposedValue IsNot Nothing Then
							Dim text As String = Conversions.ToString(A_1.ProposedValue).Trim()
							If text.Length = 0 Then
								A_1.ProposedValue = DBNull.Value
							ElseIf A_1.Column.MaxLength >= 0 AndAlso text.Length > A_1.Column.MaxLength Then
								MessageBox.Show(String.Concat(New String() { """", A_1.ProposedValue.ToString(), """ 的长度超出了[", A_1.Column.ColumnName, "]列允许的最大长度", Conversions.ToString(A_1.Column.MaxLength), "，将被自动截短！" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								A_1.ProposedValue = text.Substring(0, A_1.Column.MaxLength)
							End If
						ElseIf A_1.Column.DataType Is GetType(Single) OrElse A_1.Column.DataType Is GetType(Double) OrElse A_1.Column.DataType Is GetType(Decimal) Then
							If A_1.ProposedValue IsNot DBNull.Value AndAlso A_1.Column.DataType IsNot GetType(Decimal) Then
								Dim d As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(A_1.ProposedValue))
								If Double.IsInfinity(d) OrElse Double.IsNaN(d) Then
									A_1.ProposedValue = DBNull.Value
								End If
							End If
							If A_1.ProposedValue IsNot DBNull.Value Then
								Dim decimals As Integer = Me.o.O0O_0__OOo_.(A_1.Column.ColumnName).Decimals
								If A_1.Column.DataType Is GetType(Decimal) Then
									A_1.ProposedValue = Math.Round(Conversions.ToDecimal(A_1.ProposedValue), decimals)
								ElseIf A_1.Column.DataType Is GetType(Double) Then
									A_1.ProposedValue = Math.Round(Conversions.ToDouble(A_1.ProposedValue), decimals)
								ElseIf A_1.Column.DataType Is GetType(Single) Then
									A_1.ProposedValue = Math.Round(CDbl(Conversions.ToSingle(A_1.ProposedValue)), decimals)
								End If
							End If
						ElseIf A_1.Column.DataType Is GetType(DateTime) AndAlso A_1.ProposedValue IsNot DBNull.Value Then
							Dim dateTime As DateTime = Conversions.ToDate(A_1.ProposedValue)
							If DateTime.Compare(dateTime, DateTime.MinValue) = 0 Then
								A_1.ProposedValue = DBNull.Value
							Else
								Select Case Me.DataCols(A_1.Column.ColumnName).DateTimeFormat
									Case 0
										A_1.ProposedValue = dateTime.[Date]
									Case 1
										A_1.ProposedValue = New DateTime(599266080000000000L).AddHours(CDbl(dateTime.Hour)).AddMinutes(CDbl(dateTime.Minute))
									Case 2
										A_1.ProposedValue = New DateTime(599266080000000000L).AddHours(CDbl(dateTime.Hour)).AddMinutes(CDbl(dateTime.Minute)).AddSeconds(CDbl(dateTime.Second))
									Case 3
										A_1.ProposedValue = dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
									Case 4
										A_1.ProposedValue = dateTime
								End Select
								A_1.ProposedValue = Conversions.ToDate(A_1.ProposedValue)
							End If
						End If
					End If
					If OO_00oOO.SystemReady Then
						If o_O_o_oOoo__.oO.O_..Contains(A_1.Column.ColumnName) Then
							If Operators.CompareString(A_1.Column.ColumnName, "_Identify", True) <> 0 Then
								If Operators.CompareString(A_1.Column.ColumnName, "_Locked", True) <> 0 OrElse A_1.Row.RowState = DataRowState.Detached Then
									Return
								End If
								Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(A_1.Row))
								If Me.Oo0__O0.0. IsNot Nothing Then
									Try
										Me.Oo0__O0.0..Invoke(Nothing, New Object() { dataRowEventArgs })
									Catch a_ As Exception
										ooO.oOo0Oo.o.(a_, "表，" + Me.Name + "，DataRowLockedChanging")
									End Try
									If dataRowEventArgs.Cancel Then
										A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row(A_1.Column))
									End If
								End If
								If dataRowEventArgs.Cancel OrElse Not Me.GlobalHandler.DataRowLockedChanging Then
									Return
								End If
								Try
									If O_O0OO.O0_00o.o0__o..Ooo0000o.o0. IsNot Nothing Then
										O_O0OO.O0_00o.o0__o..Ooo0000o.o0..Invoke(Nothing, New Object() { dataRowEventArgs })
									End If
								Catch a_2 As Exception
									ooO.oOo0Oo.o.(a_2, "全局表事件，DataRowLockedChanging")
								End Try
								If dataRowEventArgs.Cancel Then
									A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row(A_1.Column))
									Return
								End If
								Return
							End If
						Else
							If Not A_1.Column.ExtendedProperties.Contains("ov") Then
								A_1.Column.ExtendedProperties.Add("ov", New Dictionary(Of DataRow, Object)())
							End If
							CType(A_1.Column.ExtendedProperties("ov"), Dictionary(Of DataRow, Object))(A_1.Row) = RuntimeHelpers.GetObjectValue(A_1.Row(A_1.Column))
							If(A_1.ProposedValue Is DBNull.Value And A_1.Row.IsNull(A_1.Column)) OrElse String.Compare(A_1.ProposedValue.ToString(), A_1.Row(A_1.Column).ToString(), False) = 0 Then
								Return
							End If
							Dim dataColEventArgs As DataColEventArgs = New DataColEventArgs(Me, New DataRow(A_1.Row), Me.DataCols(A_1.Column.ColumnName), RuntimeHelpers.GetObjectValue(A_1.ProposedValue), RuntimeHelpers.GetObjectValue(A_1.Row(A_1.Column)))
							If Me.O_.__0. IsNot Nothing Then
								Try
									Me.O_.__0..Invoke(Nothing, New Object() { dataColEventArgs })
								Catch a_3 As Exception
									ooO.oOo0Oo.o.(a_3, "表，" + Me.Name + "，DataColChanging")
								End Try
							End If
							If Not dataColEventArgs.Cancel AndAlso Me.GlobalHandler.DataColChanging AndAlso O_O0OO.O0_00o.o0__o..oOO0_O.o. IsNot Nothing Then
								Try
									O_O0OO.O0_00o.o0__o..oOO0_O.o..Invoke(Nothing, New Object() { dataColEventArgs })
								Catch a_4 As Exception
									ooO.oOo0Oo.o.(a_4, "全局表事件, DataColChanging")
								End Try
							End If
							If dataColEventArgs.Cancel Then
								If A_1.Column.DataType IsNot GetType(Boolean) Then
									A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row(A_1.Column))
									Return
								End If
								If A_1.Row.IsNull(A_1.Column) Then
									A_1.ProposedValue = False
									Return
								End If
								A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row(A_1.Column))
								Return
							Else
								If dataColEventArgs.NewValue Is Nothing Then
									dataColEventArgs.NewValue = DBNull.Value
								End If
								A_1.ProposedValue = RuntimeHelpers.GetObjectValue(dataColEventArgs.NewValue)
							End If
						End If
						Try
							For Each obj As Object In Me._DataTable.ChildRelations
								Dim o0Oo As O0Oo = CType(obj, O0Oo)
								If o0Oo.oo0__.0Oo0o_.() Then
									Dim num As Integer = o0Oo.ParentColumns.Length - 1
									For i As Integer = 0 To num
										' The following expression was wrapped in a checked-statement
										If o0Oo.ParentColumns(i) Is A_1.Column Then
											Dim column As DataColumn = o0Oo.ChildColumns(i)
											Dim childRows As DataRow() = A_1.Row.GetChildRows(o0Oo)
											If A_1.ProposedValue Is DBNull.Value Then
												If childRows.Length > 0 Then
													A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row(A_1.Column))
												End If
											Else
												Dim array As DataRow() = childRows
												For j As Integer = 0 To array.Length - 1
													array(j)(column) = RuntimeHelpers.GetObjectValue(A_1.ProposedValue)
												Next
											End If
										End If
									Next
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x0600218C RID: 8588 RVA: 0x000DF4F4 File Offset: 0x000DD6F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataTableNewRowEventArgs)
			If Me._DataTable.DataSet Is Nothing Then
				If Me._DataTable.Columns.Contains("_SortKey") Then
					A_1.Row("_SortKey") = Me.OO00.oO_.
					Me.OO00.oO_. = Decimal.Add(Me.OO00.oO_., 1D)
					Return
				End If
			ElseIf Not Me.o.OOO_oO0_0O_o. Then
				A_1.Row("System_Filter_Temporary") = 1
				Dim o_ As O_0 = OO_00oOO.Tables(Me.Name).View
				If o_.Count > 0 AndAlso Not o_.O0O_0_0__.0O.(o_.Count - 1).Row.IsNull("System_Sort_Temporary") Then
					A_1.Row("System_Sort_Temporary") = Conversion.Val(RuntimeHelpers.GetObjectValue(o_.O0O_0_0__.0O.(o_.Count - 1)("System_Sort_Temporary"))) + 1.0
				Else
					A_1.Row("System_Sort_Temporary") = 1
				End If
				If Me._DataTable.Columns.Contains("_SortKey") Then
					A_1.Row("_SortKey") = Me.OO00.oO_.
					Me.OO00.oO_. = Decimal.Add(Me.OO00.oO_., 1D)
				End If
				Try
					For Each obj As Object In Me._DataTable.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If dataColumn.DataType Is GetType(Boolean) AndAlso Operators.CompareString(dataColumn.ColumnName, "_Locked", True) = 0 Then
							A_1.Row(dataColumn) = False
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Me.DataCols IsNot Nothing Then
					Try
						For Each dataCol As DataCol In Me.DataCols
							If Operators.CompareString(dataCol.DefaultValue, "", True) > 0 Then
								Try
									A_1.Row(dataCol.Name) = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval(dataCol.DefaultValue, New DataRow(A_1.Row)))
								Catch a_ As Exception
									ooO.oOo0Oo.o.(a_, String.Concat(New String() { "[", Me.Name, "]表的[", dataCol.Name, "]列的默认值计算错误。" }))
								End Try
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of DataCol)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
				End If
				Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(A_1.Row))
				If Me.OOoOO0O_._0__. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Try
						Me.OOoOO0O_._0__..Invoke(Nothing, New Object() { dataRowEventArgs })
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "表，" + Me.Name + "，DataRowAdding")
					End Try
				End If
				If Me.GlobalHandler.DataRowAdding AndAlso O_O0OO.O0_00o.o0__o..OO0_0_._. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Try
						O_O0OO.O0_00o.o0__o..OO0_0_._..Invoke(Nothing, New Object() { dataRowEventArgs })
					Catch a_3 As Exception
						ooO.oOo0Oo.o.(a_3, "全局事件, DataRowAdding")
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600218D RID: 8589 RVA: 0x000DF8A0 File Offset: 0x000DDAA0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataRowChangeEventArgs)
			If A_1.Action = DataRowAction.Add Then
				Try
					For Each obj As Object In Me._DataTable.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If dataColumn.DataType Is GetType(Boolean) AndAlso A_1.Row.IsNull(dataColumn) Then
							A_1.Row(dataColumn) = False
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			If Me._DataTable.DataSet Is Nothing Then
				If A_1.Action = DataRowAction.Add Then
					Me.o_oO0O_.O0. = Nothing
				End If
				If A_1.Action = DataRowAction.Rollback AndAlso A_1.Row.RowState = DataRowState.Detached Then
					Me.o_oO0O_.O0. = Nothing
					Return
				End If
			ElseIf Operators.CompareString(A_1.Row.RowError, "", True) <= 0 AndAlso Not Me.o.OOO_oO0_0O_o. Then
				If A_1.Action = DataRowAction.Change AndAlso Me.o0._o_. AndAlso A_1.Row.RowState = DataRowState.Modified Then
					A_1.Row.AcceptChanges()
					Return
				End If
				If A_1.Action = DataRowAction.Add OrElse (A_1.Action = DataRowAction.Rollback AndAlso A_1.Row.RowState = DataRowState.Detached) Then
					Me.o_oO0O_.O0. = Nothing
				End If
				If A_1.Action = DataRowAction.Add AndAlso OO_00oOO.SystemReady AndAlso Me.DataCols IsNot Nothing Then
					Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(A_1.Row))
					If Me.O00.O. IsNot Nothing Then
						Try
							Me.O00.O..Invoke(Nothing, New Object() { dataRowEventArgs })
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "表，" + Me.Name + "，DataRowAdded")
						End Try
					End If
					If Me.GlobalHandler.DataRowAdded AndAlso O_O0OO.O0_00o.o0__o..Oo0.oo_o. IsNot Nothing Then
						Try
							O_O0OO.O0_00o.o0__o..Oo0.oo_o..Invoke(Nothing, New Object() { dataRowEventArgs })
						Catch a_2 As Exception
							ooO.oOo0Oo.o.(a_2, "全局事件, DataRowAdded")
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x0600218E RID: 8590 RVA: 0x000DFADC File Offset: 0x000DDCDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataRowChangeEventArgs)
			Me.o_oO0O_.O0. = Nothing
			If Me._DataTable.DataSet IsNot Nothing AndAlso Not Me.o.OOO_oO0_0O_o. AndAlso Operators.CompareString(A_1.Row.RowError, "", True) <= 0 Then
				If Me.O._O00000. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(A_1.Row))
					Try
						Me.O._O00000..Invoke(Nothing, New Object() { dataRowEventArgs })
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "表，" + Me.Name + "，DataRowDeleted")
					End Try
				End If
				If Me.GlobalHandler.DataRowDeleted AndAlso O_O0OO.O0_00o.o0__o..ooo._o000. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Dim dataRowEventArgs2 As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(A_1.Row))
					Try
						O_O0OO.O0_00o.o0__o..ooo._o000..Invoke(Nothing, New Object() { dataRowEventArgs2 })
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "全局表事件, DataRowDeleted")
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600218F RID: 8591 RVA: 0x000DFC10 File Offset: 0x000DDE10
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataRowChangeEventArgs)
			If Operators.CompareString(A_1.Row.RowError, "", True) <= 0 AndAlso Not Me.o.OOO_oO0_0O_o. Then
				If Me.o_o._000_0_. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(A_1.Row))
					Try
						Me.o_o._000_0_..Invoke(Nothing, New Object() { dataRowEventArgs })
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "表，" + Me.Name + "，DataRowDeleting")
					End Try
				End If
				If Me.GlobalHandler.DataRowDeleting AndAlso O_O0OO.O0_00o.o0__o..O.__0__O0O0oOo. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Dim dataRowEventArgs2 As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(A_1.Row))
					Try
						O_O0OO.O0_00o.o0__o..O.__0__O0O0oOo..Invoke(Nothing, New Object() { dataRowEventArgs2 })
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "全局表事件, DataRowDeleting")
					End Try
				End If
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable.BaseTable Is Me.BaseTable Then
							table.O0o._oo_.(A_1.Row, False)
							table.o.0oOoO__0_o0.(A_1.Row)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Try
					For Each obj As Object In Me.BaseTable.ChildRelations
						Dim o0Oo As O0Oo = CType(obj, O0Oo)
						If o0Oo.o.O0_o.() Then
							For Each a_3 As DataRow In A_1.Row.GetChildRows(o0Oo)
								New DataRow(a_3).Delete()
							Next
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06002190 RID: 8592 RVA: 0x000DFE24 File Offset: 0x000DE024
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = False)
			If Not Me.AddByCode Then
				Try
					Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { Me.Name, "" })
					If dataRow Is Nothing Then
						dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).NewRow()
						dataRow("Table") = Me.Name
						dataRow("Column") = ""
						O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Add(dataRow)
					End If
					dataRow("Config") = o_O_o_oOoo__.OOOO_OO._oo.(Me.frd_Setting, False, vbVerticalTab, False)
					If A_0 Then
						Dim text As String = o_O_o_oOoo__.OOOO_OO._oo.(Me.frd_Setting, True, vbVerticalTab, False)
						If Operators.CompareString(text, "", True) > 0 Then
							dataRow("Code") = O00.ooo000o_0.00o0.(text, O_O0OO.O_O._Oo.(), ooO0__OO.o.0_0_ooO.())
						Else
							dataRow("Code") = Nothing
						End If
					End If
					dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "{" + Me.Name + "}", "" })
					If dataRow Is Nothing Then
						dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).NewRow()
						dataRow("Table") = "{" + Me.Name + "}"
						dataRow("Column") = ""
						O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Add(dataRow)
					End If
					dataRow("Config") = o_O_o_oOoo__.OOOO_OO._oo.(Me.frd_LookAndFeel, False, vbVerticalTab, False)
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
		End Sub

		' Token: 0x06002191 RID: 8593 RVA: 0x000E0054 File Offset: 0x000DE254
		Friend Shared Function <<EMPTY_NAME>>(A_0 As String) As String
			Return O00.oO_.0o_oo_0O_.(A_0, O_O0OO.O_O._Oo.(), ooO0__OO.o.0_0_ooO.())
		End Function

		' Token: 0x170007D8 RID: 2008
		' (get) Token: 0x06002192 RID: 8594 RVA: 0x000E0066 File Offset: 0x000DE266
		' (set) Token: 0x06002193 RID: 8595 RVA: 0x000E008C File Offset: 0x000DE28C
		Friend Property frd_AutoIncrement As Boolean
			Get
				Return Me.BaseTable.PrimaryKey.Length = 1 AndAlso Me.BaseTable.PrimaryKey(0).AutoIncrement
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x06002194 RID: 8596 RVA: 0x000E0090 File Offset: 0x000DE290
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow())
			If Not Me.frd_IsTemporary AndAlso Not Me.frd_IsInnerQuery AndAlso Not Me.frd_IsOuterQuery AndAlso Me._Adapter.InsertCommand IsNot Nothing Then
				Me._Adapter.InsertCommand.CommandTimeout = Me.FillLoadTimeOut
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.View.o_o.O0ooOo.() Is Me._DataTable Then
							table.ClearEditInfos()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Dim state As ConnectionState = Me.o0__.Oo0o__O..State
				Dim oleDbCommand As OleDbCommand = New OleDbCommand("", Me.o0__.Oo0o__O.)
				If A_0.Length = 0 Then
					Dim obj As Object = Me._DataTable
					SyncLock obj
						A_0 = Me._DataTable.[Select]("", "", DataViewRowState.Added)
					End SyncLock
				End If
				If A_0.Length > 0 Then
					Try
						If state <> ConnectionState.Open Then
							Me.o0__.Oo0o__O..Open()
						End If
						Me.StopRedraw()
						If Me.frd_IsOuterTable Then
							Me.o00o.00oO___0. = Nothing
							Me.O_0o._o0_0. = (A_0.Length = 1)
							If Me.frd_AutoIncrement Then
								Dim provider As String = Me.o0__.Oo0o__O..Provider
								If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.o0__.Oo0o__O.) Then
									If Operators.CompareString(Me.SEQUENCE, "", True) > 0 AndAlso Operators.CompareString(Me.SEQUENCE, "@@@", True) <> 0 Then
										Dim oleDbCommand2 As OleDbCommand = New OleDbCommand("SELECT " + Me.SEQUENCE + ".NEXTVAl FROM DUAL", Me.o0__.Oo0o__O.)
										Dim columnName As String = Me.BaseTable.PrimaryKey(0).ColumnName
										Dim list As List(Of Long) = New List(Of Long)()
										Dim num As Integer = A_0.Length - 1
										For i As Integer = 0 To num
											list.Add(Convert.ToInt64(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
										Next
										For j As Integer = A_0.Length - 1 To 0 Step -1
											A_0(j)(columnName) = list(j)
										Next
									End If
								Else
									Me.o00o.00oO___0. = New OleDbCommand("Select @@IDENTITY", Me.o0__.Oo0o__O.)
									Me.o00o.00oO___0..Transaction = Me._Adapter.SelectCommand.Transaction
								End If
							End If
							Try
								Try
									Me._DataTable.BeginLoadData()
									Me._Adapter.Update(A_0)
								Catch a_ As Exception
									ooO.oOo0Oo.o.(a_, "")
								End Try
								GoTo IL_524
							Finally
								Me._DataTable.EndLoadData()
							End Try
						End If
						Dim oleDbCommand3 As OleDbCommand = New OleDbCommand(String.Concat(New String() { "Select [Identify] From [", ooO0__OO.O00.O__o.(), "] Where [Table] = '", Me.o._OOO0oOo0__., "'" }), Me.o0__.Oo0o__O.)
						Dim oleDbCommand4 As OleDbCommand = New OleDbCommand("Select Max([_Identify]) From [" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]", Me.o0__.Oo0o__O.)
						Dim num3 As Integer
						While True
							Dim num2 As Integer = Conversions.ToInteger(oleDbCommand3.ExecuteScalar())
							Dim obj2 As Object = RuntimeHelpers.GetObjectValue(oleDbCommand4.ExecuteScalar())
							If obj2 Is DBNull.Value Then
								obj2 = 0
							End If
							num3 = Math.Max(num2, Conversions.ToInteger(obj2) + 1)
							oleDbCommand.CommandText = String.Concat(New String() { "Update [", ooO0__OO.O00.O__o.(), "] Set [Identify]  = ", Conversions.ToString(num3 + A_0.Length), " where [Table] = '", Me.o._OOO0oOo0__., "' And [Identify] = ", Conversions.ToString(num2) })
							If oleDbCommand.ExecuteNonQuery() > 0 Then
								Exit For
							End If
							Me.o0.O_o.()
						End While
						Me.O._0O_O0O.(num3)
						If A_0.Length = 1 Then
							Dim dataRow As DataRow = A_0(0)
							Dim obj3 As Object = Me._DataTable
							Dim array As DataRow()
							SyncLock obj3
								array = Me._DataTable.[Select]("", "", DataViewRowState.Added)
							End SyncLock
							For Each dataRow2 As DataRow In array
								If dataRow2 IsNot dataRow AndAlso Conversions.ToInteger(dataRow2("_Identify")) = num3 Then
									dataRow2("_Identify") = Conversions.ToInteger(Me.BaseTable.Compute("Max([_Identify])", "")) + 1
									Exit For
								End If
							Next
						End If
						Dim num4 As Integer = num3
						Dim num5 As Integer = Conversions.ToInteger(A_0(0)("_Identify"))
						Try
							Me._DataTable.BeginLoadData()
							If num4 <= num5 Then
								Dim num6 As Integer = A_0.Length - 1
								For l As Integer = 0 To num6
									A_0(l)("_Identify") = num3 + l
								Next
							Else
								For m As Integer = A_0.Length - 1 To 0 Step -1
									A_0(m)("_Identify") = num3 + m
								Next
							End If
							Me._Adapter.Update(A_0)
						Catch a_2 As Exception
							ooO.oOo0Oo.o.(a_2, "")
						Finally
							Me._DataTable.EndLoadData()
						End Try
						IL_524:
					Catch a_3 As Exception
						ooO.oOo0Oo.o.(a_3, "")
					Finally
						Me.ResumeRedraw()
						If state <> ConnectionState.Open Then
							Me.o0__.Oo0o__O..Close()
						End If
					End Try
					If A_0.Length > 0 AndAlso DateTime.Now.Second Mod 7 = 3 Then
						Me.a()
					End If
				End If
			End If
		End Sub

		' Token: 0x06002195 RID: 8597 RVA: 0x000E06F0 File Offset: 0x000DE8F0
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim obj As Object = Me._DataTable
			Dim array As DataRow()
			SyncLock obj
				array = Me._DataTable.[Select]("[_Identify] >= " + Conversions.ToString(A_0))
			End SyncLock
			If array.Length > 0 Then
				For Each dataRow As DataRow In array
					If dataRow.RowState <> DataRowState.Added Then
						dataRow.RowError = "a"
						Me._DataTable.Rows.Remove(dataRow)
					End If
				Next
			End If
		End Sub

		' Token: 0x06002196 RID: 8598 RVA: 0x000E0790 File Offset: 0x000DE990
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow())
			If Not Me.frd_IsTemporary AndAlso Not Me.frd_IsInnerQuery AndAlso Not Me.frd_IsOuterQuery AndAlso Me._Adapter.UpdateCommand IsNot Nothing Then
				Me._Adapter.UpdateCommand.CommandTimeout = Me.FillLoadTimeOut
				Dim state As ConnectionState = Me.o0__.Oo0o__O..State
				If A_0.Length = 0 Then
					Dim obj As Object = Me._DataTable
					SyncLock obj
						A_0 = Me._DataTable.[Select]("", "", DataViewRowState.ModifiedCurrent)
					End SyncLock
				End If
				If A_0.Length > 0 Then
					Dim num As Integer
					For Each dataRow As DataRow In A_0
						Oo00.o0_o._O_.(dataRow)
						If dataRow.RowState = DataRowState.Modified Then
							num += 1
						End If
					Next
					If num <> 0 Then
						Try
							If state <> ConnectionState.Open Then
								Me.o0__.Oo0o__O..Open()
							End If
							Me._Adapter.Update(A_0)
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "")
						Finally
							If state <> ConnectionState.Open Then
								Me.o0__.Oo0o__O..Close()
							End If
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x06002197 RID: 8599 RVA: 0x000E08D4 File Offset: 0x000DEAD4
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow())
			If Not Me.frd_IsTemporary AndAlso Not Me.frd_IsInnerQuery AndAlso Not Me.frd_IsOuterQuery AndAlso Me._Adapter.DeleteCommand IsNot Nothing Then
				Me._Adapter.DeleteCommand.CommandTimeout = Me.FillLoadTimeOut
				Dim state As ConnectionState = Me.o0__.Oo0o__O..State
				If A_0.Length = 0 Then
					Dim obj As Object = Me._DataTable
					SyncLock obj
						A_0 = Me._DataTable.[Select]("", "", DataViewRowState.Deleted)
					End SyncLock
				End If
				If A_0.Length > 0 Then
					Try
						If state <> ConnectionState.Open Then
							Me.o0__.Oo0o__O..Open()
						End If
						Me._Adapter.Update(A_0)
						If Me.frd_IsInnerTable Then
							Me.o0_0.o_.()
						End If
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If state <> ConnectionState.Open Then
							Me.o0__.Oo0o__O..Close()
						End If
					End Try
				End If
			End If
		End Sub

		' Token: 0x06002198 RID: 8600 RVA: 0x000E09F4 File Offset: 0x000DEBF4
		Friend Sub <<EMPTY_NAME>>()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("Select Max([_Identify]) From [" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]", Me.o0__.Oo0o__O.)
			Dim num As Long = CLng(Conversions.ToInteger(New OleDbCommand(String.Concat(New String() { "Select [Identify] From [", ooO0__OO.O00.O__o.(), "] Where [Table] = '", Me.o._OOO0oOo0__., "'" }), Me.o0__.Oo0o__O.).ExecuteScalar()))
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
			Dim num2 As Long
			If objectValue Is DBNull.Value Then
				num2 = 1L
			Else
				num2 = CLng((Conversions.ToInteger(objectValue) + 1))
			End If
			If num > num2 Then
				oleDbCommand.CommandText = String.Concat(New String() { "Update [", ooO0__OO.O00.O__o.(), "] Set [Identify]  = ", Conversions.ToString(num2), " Where [Table] = '", Me.o._OOO0oOo0__., "' And [Identify] = ", Conversions.ToString(num) })
				oleDbCommand.ExecuteNonQuery()
			End If
		End Sub

		' Token: 0x06002199 RID: 8601 RVA: 0x000E0B04 File Offset: 0x000DED04
		Friend Sub <<EMPTY_NAME>>()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("", Me.o0__.Oo0o__O.)
			Dim oleDbCommand2 As OleDbCommand = New OleDbCommand("", Me.o0__.Oo0o__O.)
			oleDbCommand.CommandText = String.Concat(New String() { "Select Count(*) From [", ooO0__OO.O00.O__o.(), "] Where [Table] = '", Me.o._OOO0oOo0__., "'" })
			oleDbCommand2.CommandText = "Select Max([_Identify]) From [" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
			Dim value As Integer
			If Me.BaseTable.Rows.Count > 0 Then
				value = Conversions.ToInteger(Me.Compute("Max([_Identify])")) + 1
			Else
				value = 1
			End If
			oleDbCommand2.CommandText = String.Concat(New String() { "Insert into [", ooO0__OO.O00.O__o.(), "] ([Table],[Identify]) values ('", Me.o._OOO0oOo0__., "',", Conversions.ToString(value), ")" })
			Dim state As Integer = CInt(Me.o0__.Oo0o__O..State)
			If Me.o0__.Oo0o__O..State <> ConnectionState.Open Then
				Me.o0__.Oo0o__O..Open()
			End If
			If Conversions.ToInteger(oleDbCommand.ExecuteScalar()) = 0 Then
				oleDbCommand2.ExecuteNonQuery()
			End If
			If state <> 1 Then
				Me.o0__.Oo0o__O..Close()
			End If
		End Sub

		' Token: 0x0600219A RID: 8602 RVA: 0x000E0C58 File Offset: 0x000DEE58
		Friend Function <<EMPTY_NAME>>(A_0 As Boolean, A_1 As Boolean) As Boolean
			Dim result As Boolean
			If Me.frd_IsTemporary OrElse Me.frd_IsInnerQuery OrElse Me.frd_IsOuterQuery Then
				Me._DataTable.AcceptChanges()
				result = True
			ElseIf A_1 AndAlso Not Me.o.o_O.() Then
				result = False
			Else
				Me.O0_0oOO.0.(New DataRow(-1) {})
				Me.oO.o_0.(New DataRow(-1) {})
				Me.oo_.0oo_.(New DataRow(-1) {})
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.View.o_o.O0ooOo.() Is Me._DataTable Then
							table.foxGrid.Invalidate()
							table.foxGrid.Refresh()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				If A_0 Then
					Try
						For Each table2 As Table In OO_00oOO.Tables
							If table2.View.o_o.O0ooOo.() Is Me._DataTable Then
								table2.Oo._0oO.()
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of Table)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
				End If
				result = True
			End If
			Return result
		End Function

		' Token: 0x0600219B RID: 8603 RVA: 0x000E0D7C File Offset: 0x000DEF7C
		Friend Sub <<EMPTY_NAME>>()
			If Not Me.AddByCode Then
				Dim a_ As DockSetting = New DockSetting(Me)
				Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
				Dim dataRow As DataRow = dataTable.Rows.Find(New Object() { Me.Name, "", 4 })
				If dataRow Is Nothing Then
					dataRow = dataTable.NewRow()
					dataRow("Table") = Me.Name
					dataRow("Type") = 4
					dataRow("Name") = ""
					dataTable.Rows.Add(dataRow)
				End If
				dataRow("Property") = o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbVerticalTab, False)
			End If
		End Sub

		' Token: 0x0600219C RID: 8604 RVA: 0x000E0E3C File Offset: 0x000DF03C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim array As DataRow() = Me.BaseTable.[Select]("", "", DataViewRowState.ModifiedCurrent)
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			Dim num As Integer = array.Length - 1
			Dim result As Boolean
			For i As Integer = 0 To num
				list.Add(array(i))
				If list.Count >= Me.BatchUpdateSize OrElse i = array.Length - 1 Then
					If Not oOO0oO000_0_0.oOoOo_o.__.(Me, list.ToArray()) Then
						result = False
						Return result
					End If
					list.Clear()
				End If
			Next
			array = Me.BaseTable.[Select]("", "", DataViewRowState.Deleted)
			Dim num2 As Integer = array.Length - 1
			For j As Integer = 0 To num2
				list.Add(array(j))
				If list.Count >= Me.BatchUpdateSize OrElse j = array.Length - 1 Then
					If Not oOO0oO000_0_0.OO.OoO0.(Me, list.ToArray()) Then
						Return False
					End If
					list.Clear()
				End If
			Next
			Try
				Me.StopRedraw()
				Me.BaseTable.BeginLoadData()
				array = Me.BaseTable.[Select]("", "", DataViewRowState.Added)
				Dim num3 As Integer = array.Length - 1
				For k As Integer = 0 To num3
					list.Add(array(k))
					If list.Count >= Me.BatchUpdateSize OrElse k = array.Length - 1 Then
						If Not oOO0oO000_0_0.o__o.OOO__.(Me, list.ToArray()) Then
							Return False
						End If
						list.Clear()
					End If
				Next
				result = True
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.BaseTable.EndLoadData()
				Me.ResumeRedraw()
			End Try
			Return result
		End Function

		' Token: 0x0600219D RID: 8605 RVA: 0x000E0FEC File Offset: 0x000DF1EC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Save(ParamArray args As Object())
			If args.Length = 0 Then
				Me.Save()
				Return
			End If
			If args.Length = 1 Then
				Me.Save(Conversions.ToBoolean(args(0)))
			End If
		End Sub

		' Token: 0x0600219E RID: 8606 RVA: 0x000E1010 File Offset: 0x000DF210
		<oO0oooo("0399")>
		Public Sub Save()
			If Operators.CompareString(Me.DataServer, "", True) > 0 Then
				If Operators.CompareString(Me.UpdateServer, "", True) <= 0 Then
					Me._DataTable.AcceptChanges()
					Return
				End If
				If Me.o.o_O.() Then
					Me.O0o0.O_0_.()
					Return
				End If
			ElseIf Me.frd_IsTemporary OrElse Me.frd_IsInnerQuery OrElse Me.frd_IsOuterQuery Then
				If Me._DataTable.GetChanges() IsNot Nothing Then
					Me._DataTable.AcceptChanges()
					Return
				End If
			ElseIf Me.o.o_O.() Then
				Me.O0_0oOO.0.(New DataRow(-1) {})
				Me.oO.o_0.(New DataRow(-1) {})
				Me.oo_.0oo_.(New DataRow(-1) {})
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.View.o_o.O0ooOo.() Is Me._DataTable Then
							table.foxGrid.Invalidate()
							table.foxGrid.Refresh()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600219F RID: 8607 RVA: 0x000E1128 File Offset: 0x000DF328
		<oO0oooo("0399")>
		Public Sub Save(saveSetting As Boolean)
			Me.Save()
			If saveSetting Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.View.o_o.O0ooOo.() Is Me._DataTable Then
							table.oo0OO0Ooo._.(True)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060021A0 RID: 8608 RVA: 0x000E1190 File Offset: 0x000DF390
		Friend Sub <<EMPTY_NAME>>()
			o_O_o_oOoo__.OO_O0oO0.oooO_.(Me._Adapter)
		End Sub

		' Token: 0x060021A1 RID: 8609 RVA: 0x000E11A0 File Offset: 0x000DF3A0
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable) As StructureCompareResult
			Dim list As List(Of String) = New List(Of String)()
			Dim dataTable As DataTable = New DataTable()
			Dim structureCompareResult As StructureCompareResult = New StructureCompareResult()
			If Me._Adapter IsNot Nothing Then
				Me._Adapter.FillSchema(dataTable, SchemaType.Source)
			ElseIf Me.DataServer IsNot Nothing Then
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				httpClient.[Select] = Me.HttpSelect
				httpClient.FormData("Action") = 12.ToString()
				dataTable = httpClient.GetBaseDataTable()
			End If
			If dataTable.PrimaryKey.Length <> A_0.PrimaryKey.Length OrElse dataTable.PrimaryKey.Length = 0 Then
				structureCompareResult.Ooo0.o. = False
			Else
				For Each dataColumn As DataColumn In dataTable.PrimaryKey
					Dim flag As Boolean
					For Each dataColumn2 As DataColumn In A_0.PrimaryKey
						If Operators.CompareString(dataColumn.ColumnName, dataColumn2.ColumnName, True) = 0 AndAlso dataColumn.DataType Is dataColumn2.DataType Then
							flag = True
							Exit For
						End If
					Next
					If Not flag Then
						structureCompareResult.Ooo0.o. = False
						Exit For
					End If
				Next
			End If
			Try
				For Each obj As Object In Me._DataTable.Columns
					Dim dataColumn3 As DataColumn = CType(obj, DataColumn)
					If dataTable.Columns.Contains(dataColumn3.ColumnName) Then
						Try
							For Each obj2 As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
								Dim dataRelation As DataRelation = CType(obj2, DataRelation)
								Dim num As Integer = dataRelation.ParentColumns.Length - 1
								For k As Integer = 0 To num
									If dataRelation.ParentColumns(k) Is dataColumn3 Or dataRelation.ChildColumns(k) Is dataColumn3 Then
										list.Add(dataColumn3.ColumnName)
										Exit For
									End If
								Next
								If list.Contains(dataColumn3.ColumnName) Then
									Exit For
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each text As String In list
					If Not A_0.Columns.Contains(text) OrElse dataTable.Columns(text).DataType IsNot A_0.Columns(text).DataType Then
						MessageBox.Show(String.Concat(New String() { "[", Me.Name, "]通过列[", text, "]和其他表建立了关联，新的数据源必须包括此列！" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						structureCompareResult.o_O__.0O. = False
						Exit For
					End If
				Next
			Finally
				Dim enumerator3 As List(Of String).Enumerator
				CType(enumerator3, IDisposable).Dispose()
			End Try
			Return structureCompareResult
		End Function

		' Token: 0x060021A2 RID: 8610 RVA: 0x000E1498 File Offset: 0x000DF698
		Friend Function <<EMPTY_NAME>>(A_0 As String, Optional A_1 As Boolean = True) As String
			Dim dataColumn As DataColumn = Me._DataTable.Columns.Add()
			Try
				For Each table As Table In OO_00oOO.Tables
					If(table.Name.StartsWith(Me.Name + ".") OrElse table.View.o_o.O0ooOo.() Is Me._DataTable) AndAlso table.foxGrid.Cols.Contains(dataColumn.ColumnName) Then
						table.foxGrid.Cols.Remove(dataColumn.ColumnName)
					End If
					table.O.__O0o0.(True, False)
					If(table.Name.StartsWith(Me.Name + ".") OrElse table.View.o_o.O0ooOo.() Is Me._DataTable) AndAlso table.foxGrid.FindForm() IsNot Nothing Then
						table._frdTableLayout.OOooOOo_.0_0_o.()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim result As String
			Try
				Dim o_u3002o_u3002_u3002_u As O\u3002o\u3002\u3002\u3000 = New O\u3002o\u3002\u3002\u3000(Me._DataTable, dataColumn, A_0, A_1)
				If o_u3002o_u3002_u3002_u.ShowDialog() = DialogResult.OK Then
					result = o_u3002o_u3002_u3002_u.oO.o0oOo_o__O.().Text
				Else
					result = A_0
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				result = A_0
			Finally
				OO_00oOO.SystemReady = False
				Me._DataTable.Columns.Remove(dataColumn)
				OO_00oOO.SystemReady = True
				Try
					For Each table2 As Table In OO_00oOO.Tables
						table2.O.__O0o0.(True, False)
						If(table2.Name.StartsWith(Me.Name + ".") OrElse table2.View.o_o.O0ooOo.() Is Me._DataTable) AndAlso table2.foxGrid.FindForm() IsNot Nothing Then
							table2._frdTableLayout.Oo_.oo_oOo_oO.()
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of Table)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
			End Try
			Return result
		End Function

		' Token: 0x060021A3 RID: 8611 RVA: 0x000E16C0 File Offset: 0x000DF8C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OleDbRowUpdatedEventArgs)
			If Me.o00o.00oO___0. IsNot Nothing AndAlso A_1.Status = UpdateStatus.[Continue] AndAlso A_1.StatementType = StatementType.Insert AndAlso A_1.RecordsAffected = 1 Then
				If Me.O_0o._o0_0. Then
					Me.O_0o._o0_0. = False
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o00o.00oO___0..ExecuteScalar())
					Dim dataRow As DataRow = Me._DataTable.Rows.Find(RuntimeHelpers.GetObjectValue(objectValue))
					If dataRow IsNot Nothing AndAlso dataRow IsNot A_1.Row Then
						dataRow(Me._DataTable.PrimaryKey(0).ColumnName) = Conversions.ToInteger(Me.BaseTable.Compute("Max([" + Me._DataTable.PrimaryKey(0).ColumnName + "])", "")) + 1
					End If
					A_1.Row(Me._DataTable.PrimaryKey(0).ColumnName) = RuntimeHelpers.GetObjectValue(objectValue)
				Else
					A_1.Row(Me._DataTable.PrimaryKey(0).ColumnName) = RuntimeHelpers.GetObjectValue(Me.o00o.00oO___0..ExecuteScalar())
				End If
			End If
			Dim updateRowEventArgs As UpdateRowEventArgs = New UpdateRowEventArgs(Me, New DataRow(A_1.Row), A_1)
			If Me.O_000o_.O. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
				Try
					Me.O_000o_.O..Invoke(Nothing, New Object() { updateRowEventArgs })
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "表，" + Me.Name + "，AfterSaveDataRow")
				End Try
			End If
			If Not updateRowEventArgs.Cancel AndAlso Me.GlobalHandler.AfterSaveDataRow AndAlso OO_00oOO.SystemReady AndAlso O_O0OO.O0_00o.o0__o..Oo.o0_O. IsNot Nothing Then
				Try
					O_O0OO.O0_00o.o0__o..Oo.o0_O..Invoke(Nothing, New Object() { updateRowEventArgs })
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "全局表事件, AfterSaveDataRow")
				End Try
			End If
			If A_1.RecordsAffected = 0 Then
				If A_1.StatementType = StatementType.Delete Then
					If TypeOf A_1.Errors Is DBConcurrencyException Then
						A_1.Status = UpdateStatus.SkipCurrentRow
					Else
						ooO.oOo0Oo.o.(A_1.Errors, "")
						A_1.Status = UpdateStatus.SkipAllRemainingRows
					End If
					A_1.Row.AcceptChanges()
					Return
				End If
				If A_1.StatementType = StatementType.Update Then
					If TypeOf A_1.Errors Is DBConcurrencyException Then
						A_1.Row.RowError = "a"
						A_1.Row.Delete()
						A_1.Row.AcceptChanges()
						A_1.Status = UpdateStatus.SkipCurrentRow
						Return
					End If
					ooO.oOo0Oo.o.(A_1.Errors, "")
					A_1.Status = UpdateStatus.SkipAllRemainingRows
					Return
				ElseIf A_1.StatementType = StatementType.Insert Then
					ooO.oOo0Oo.o.(A_1.Errors, "")
					If Me.frd_IsInnerTable Then
						A_1.Status = UpdateStatus.SkipCurrentRow
						Return
					End If
					A_1.Status = UpdateStatus.SkipAllRemainingRows
				End If
			End If
		End Sub

		' Token: 0x060021A4 RID: 8612 RVA: 0x000E19A4 File Offset: 0x000DFBA4
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim obj As Object = Me._DataTable
			Dim array As DataRow()
			SyncLock obj
				array = Me._DataTable.[Select]("", "", DataViewRowState.Added Or DataViewRowState.ModifiedCurrent)
			End SyncLock
			Dim result As Boolean
			If array.Length = 0 Then
				result = True
			Else
				For Each a_ As DataRow In array
					Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me, New DataRow(a_))
					If Me.o.__Oo_Oo_. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
						Try
							Me.o.__Oo_Oo_..Invoke(Nothing, New Object() { dataRowEventArgs })
						Catch a_2 As Exception
							ooO.oOo0Oo.o.(a_2, "表，" + Me.Name + "，BeforeSaveDataRow")
						End Try
					End If
					If Not dataRowEventArgs.Cancel AndAlso Me.GlobalHandler.BeforeSaveDataRow AndAlso OO_00oOO.SystemReady AndAlso O_O0OO.O0_00o.o0__o..O__0o._O_oo. IsNot Nothing Then
						Try
							O_O0OO.O0_00o.o0__o..O__0o._O_oo..Invoke(Nothing, New Object() { dataRowEventArgs })
						Catch a_3 As Exception
							ooO.oOo0Oo.o.(a_3, "全局表事件, BeforeSaveDataRow")
						End Try
					End If
					If dataRowEventArgs.Cancel Then
						Return False
					End If
				Next
				result = True
			End If
			Return result
		End Function

		' Token: 0x170007D9 RID: 2009
		' (get) Token: 0x060021A5 RID: 8613 RVA: 0x000E1B14 File Offset: 0x000DFD14
		' (set) Token: 0x060021A6 RID: 8614 RVA: 0x000E1BA4 File Offset: 0x000DFDA4
		Friend Property frd_RightDockOrder As String
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.o.0O_O0o_.() Then
								Return oo0__Oo.o__0_.o0OoOOO.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Me.O.__00_o0. = value
			End Set
		End Property

		' Token: 0x170007DA RID: 2010
		' (get) Token: 0x060021A7 RID: 8615 RVA: 0x000E1BB0 File Offset: 0x000DFDB0
		' (set) Token: 0x060021A8 RID: 8616 RVA: 0x000E1C58 File Offset: 0x000DFE58
		Friend Property frd_RightDockSize As Integer
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.o.0O_O0o_.() AndAlso oo0__Oo.o__0_.o0OoOOO.().Controls.Count > 0 Then
								Return oo0__Oo.o__0_.o0OoOOO.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Me.o_oO0O_.O0.
			End Get
			Set(value As Integer)
				Me.o_oO0O_.O0. = value
			End Set
		End Property

		' Token: 0x170007DB RID: 2011
		' (get) Token: 0x060021A9 RID: 8617 RVA: 0x000E1C64 File Offset: 0x000DFE64
		' (set) Token: 0x060021AA RID: 8618 RVA: 0x000E1CF4 File Offset: 0x000DFEF4
		Friend Property frd_BottomDockOrder As String
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.O_0.o0.() Then
								Return oo0__Oo.O._o_00__.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Me.O_oo.__0_. = value
			End Set
		End Property

		' Token: 0x170007DC RID: 2012
		' (get) Token: 0x060021AB RID: 8619 RVA: 0x000E1D00 File Offset: 0x000DFF00
		' (set) Token: 0x060021AC RID: 8620 RVA: 0x000E1DA8 File Offset: 0x000DFFA8
		Friend Property frd_BottomDockSize As Integer
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.O_0.o0.() AndAlso oo0__Oo.O._o_00__.().Controls.Count > 0 Then
								Return oo0__Oo.O._o_00__.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Me.o0O._ooo_o___.
			End Get
			Set(value As Integer)
				Me.o0O._ooo_o___. = value
			End Set
		End Property

		' Token: 0x170007DD RID: 2013
		' (get) Token: 0x060021AD RID: 8621 RVA: 0x000E1DB4 File Offset: 0x000DFFB4
		' (set) Token: 0x060021AE RID: 8622 RVA: 0x000E1E44 File Offset: 0x000E0044
		Friend Property frd_TopDockOrder As String
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.O.o__OO0oO_0.() Then
								Return oo0__Oo.O_000__.o.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Me.o_0o0o0oo0.O. = value
			End Set
		End Property

		' Token: 0x170007DE RID: 2014
		' (get) Token: 0x060021AF RID: 8623 RVA: 0x000E1E50 File Offset: 0x000E0050
		' (set) Token: 0x060021B0 RID: 8624 RVA: 0x000E1EF8 File Offset: 0x000E00F8
		Friend Property frd_TopDockSize As Integer
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.O.o__OO0oO_0.() AndAlso oo0__Oo.O_000__.o.().Controls.Count > 0 Then
								Return oo0__Oo.O_000__.o.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Me.o_o._OOoo0OOoO.
			End Get
			Set(value As Integer)
				Me.o_o._OOoo0OOoO. = value
			End Set
		End Property

		' Token: 0x170007DF RID: 2015
		' (get) Token: 0x060021B1 RID: 8625 RVA: 0x000E1F04 File Offset: 0x000E0104
		' (set) Token: 0x060021B2 RID: 8626 RVA: 0x000E1F94 File Offset: 0x000E0194
		Friend Property frd_LeftDockOrder As String
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.O._o_00__.() Then
								Return oo0__Oo.O__O.o_oOO.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Me.Oo0O00Ooo._. = value
			End Set
		End Property

		' Token: 0x170007E0 RID: 2016
		' (get) Token: 0x060021B3 RID: 8627 RVA: 0x000E1FA0 File Offset: 0x000E01A0
		' (set) Token: 0x060021B4 RID: 8628 RVA: 0x000E2058 File Offset: 0x000E0258
		Friend Property frd_LeftDockSize As Integer
			Get
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
							If oo0__Oo.O._o_00__.() AndAlso oo0__Oo.O__O.o_oOO.().Controls.Count > 0 Then
								Return oo0__Oo.O__O.o_oOO.().OO_o0_oO.0.()
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim result As Integer
				If Me.OO._0oo000_00. = 0 Then
					result = 200
				Else
					result = Me.OO._0oo000_00.
				End If
				Return result
			End Get
			Set(value As Integer)
				Me.OO._0oo000_00. = value
			End Set
		End Property

		' Token: 0x170007E1 RID: 2017
		' (get) Token: 0x060021B5 RID: 8629 RVA: 0x000E2061 File Offset: 0x000E0261
		' (set) Token: 0x060021B6 RID: 8630 RVA: 0x000E2069 File Offset: 0x000E0269
		Friend Property frd_AsmCrcString As String
			Get
				Return Me.OO0__o0o0O_O.0.
			End Get
			Set(value As String)
				Me.OO0__o0o0O_O.0. = value
			End Set
		End Property

		' Token: 0x060021B7 RID: 8631 RVA: 0x000E2074 File Offset: 0x000E0274
		Friend Sub <<EMPTY_NAME>>()
			Try
				For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
					Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
					If Operators.CompareString(oo0__Oo.O_000__.o.().Name, Me.Name, True) = 0 Then
						If oo0__Oo.o.0O_O0o_.() Then
							oo0__Oo.o__0_.o0OoOOO.().OoOoo_O0o0.0O_.(Me.O.__00_o0.)
							oo0__Oo.o__0_.o0OoOOO.().o_o.O___0o.()
						End If
						If oo0__Oo.O._o_00__.() Then
							oo0__Oo.O__O.o_oOO.().OoOoo_O0o0.0O_.(Me.Oo0O00Ooo._.)
							oo0__Oo.O__O.o_oOO.().o_o.O___0o.()
						End If
						If oo0__Oo.O_0.o0.() Then
							oo0__Oo.O._o_00__.().OoOoo_O0o0.0O_.(Me.O_oo.__0_.)
							oo0__Oo.O._o_00__.().o_o.O___0o.()
						End If
						If oo0__Oo.O.o__OO0oO_0.() Then
							oo0__Oo.O_000__.o.().OoOoo_O0o0.0O_.(Me.o_0o0o0oo0.O.)
							oo0__Oo.O_000__.o.().o_o.O___0o.()
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x170007E2 RID: 2018
		' (get) Token: 0x060021B8 RID: 8632 RVA: 0x000E2184 File Offset: 0x000E0384
		' (set) Token: 0x060021B9 RID: 8633 RVA: 0x000E218C File Offset: 0x000E038C
		Friend Property frd_CustomImage As String
			Get
				Return Me.O_Oo._.
			End Get
			Set(value As String)
				Me.O_Oo._. = value
			End Set
		End Property

		' Token: 0x170007E3 RID: 2019
		' (get) Token: 0x060021BA RID: 8634 RVA: 0x000E2198 File Offset: 0x000E0398
		' (set) Token: 0x060021BB RID: 8635 RVA: 0x000E21D6 File Offset: 0x000E03D6
		Friend Property frd_Icon As Image
			Get
				Dim image As Image = Nothing
				If Operators.CompareString(Me.frd_CustomImage, "", True) > 0 Then
					image = OO_00oOO.GetImage(Me.frd_CustomImage)
				End If
				If image Is Nothing Then
					image = Foxtable.My.Resources.a.oo.O00O.().ToBitmap()
				End If
				Return image
			End Get
			Set(value As Image)
			End Set
		End Property

		' Token: 0x170007E4 RID: 2020
		' (get) Token: 0x060021BC RID: 8636 RVA: 0x000E21D8 File Offset: 0x000E03D8
		' (set) Token: 0x060021BD RID: 8637 RVA: 0x000E224F File Offset: 0x000E044F
		Friend Property frd_IsOuterQuery As Boolean
			Get
				Return Not Me.oOo.oO. AndAlso ((Me._Adapter IsNot Nothing AndAlso Me._Adapter.UpdateCommand Is Nothing AndAlso Me._Adapter.SelectCommand.Connection IsNot O_O0OO.OoO.0OO__0ooo.()) OrElse (Operators.CompareString(Me.DataServer, "", True) > 0 AndAlso Operators.CompareString(Me.UpdateServer, "", True) = 0))
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170007E5 RID: 2021
		' (get) Token: 0x060021BE RID: 8638 RVA: 0x000E2254 File Offset: 0x000E0454
		' (set) Token: 0x060021BF RID: 8639 RVA: 0x000E22CC File Offset: 0x000E04CC
		Friend Property frd_IsOuterTable As Boolean
			Get
				Return Not Me.oOo.oO. AndAlso ((Me._Adapter IsNot Nothing AndAlso Me._Adapter.UpdateCommand IsNot Nothing AndAlso Me._Adapter.SelectCommand.Connection IsNot O_O0OO.OoO.0OO__0ooo.()) OrElse (Operators.CompareString(Me.DataServer, "", True) > 0 AndAlso Operators.CompareString(Me.UpdateServer, "", True) > 0))
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170007E6 RID: 2022
		' (get) Token: 0x060021C0 RID: 8640 RVA: 0x000E22D0 File Offset: 0x000E04D0
		' (set) Token: 0x060021C1 RID: 8641 RVA: 0x000E231C File Offset: 0x000E051C
		Friend Property frd_IsInnerQuery As Boolean
			Get
				Return Not Me.oOo.oO. AndAlso (Me._Adapter IsNot Nothing AndAlso Me._Adapter.UpdateCommand Is Nothing AndAlso Me._Adapter.SelectCommand.Connection Is O_O0OO.OoO.0OO__0ooo.())
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170007E7 RID: 2023
		' (get) Token: 0x060021C2 RID: 8642 RVA: 0x000E2320 File Offset: 0x000E0520
		' (set) Token: 0x060021C3 RID: 8643 RVA: 0x000E236C File Offset: 0x000E056C
		Friend Property frd_IsInnerTable As Boolean
			Get
				Return Me.oOo.oO. OrElse (Me._Adapter IsNot Nothing AndAlso Me._Adapter.UpdateCommand IsNot Nothing AndAlso Me._Adapter.SelectCommand.Connection Is O_O0OO.OoO.0OO__0ooo.())
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170007E8 RID: 2024
		' (get) Token: 0x060021C4 RID: 8644 RVA: 0x000E236E File Offset: 0x000E056E
		' (set) Token: 0x060021C5 RID: 8645 RVA: 0x000E238E File Offset: 0x000E058E
		Friend Property frd_IsTemporary As Boolean
			Get
				Return Operators.CompareString(Me.DataServer, "", True) = 0 AndAlso Me._Adapter Is Nothing
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170007E9 RID: 2025
		' (get) Token: 0x060021C6 RID: 8646 RVA: 0x000E2390 File Offset: 0x000E0590
		' (set) Token: 0x060021C7 RID: 8647 RVA: 0x000E2398 File Offset: 0x000E0598
		<oO0oooo("0372")>
		Public Property AllowDragColumn As Boolean
			Get
				Return Me.o_0._Ooo____OO.
			End Get
			Set(value As Boolean)
				Me.o_0._Ooo____OO. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.o_.Oooo000O.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x170007EA RID: 2026
		' (get) Token: 0x060021C8 RID: 8648 RVA: 0x000E2404 File Offset: 0x000E0604
		' (set) Token: 0x060021C9 RID: 8649 RVA: 0x000E240C File Offset: 0x000E060C
		<oO0oooo("0373")>
		Public Property AllowFreezeColumn As Boolean
			Get
				Return Me.o0O.O0o_OOOoo.
			End Get
			Set(value As Boolean)
				Me.o0O.O0o_OOOoo. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.o_o_o_0.O_OOo_.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				Me.o.OO_00.()
			End Set
		End Property

		' Token: 0x170007EB RID: 2027
		' (get) Token: 0x060021CA RID: 8650 RVA: 0x000E2480 File Offset: 0x000E0680
		' (set) Token: 0x060021CB RID: 8651 RVA: 0x000E2488 File Offset: 0x000E0688
		<oO0oooo("0374")>
		Public Property AllowResizeColumn As Boolean
			Get
				Return Me.oO0oO._0_.
			End Get
			Set(value As Boolean)
				Me.oO0oO._0_. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.OO_._o_0o_.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				Me.o.OO_00.()
			End Set
		End Property

		' Token: 0x170007EC RID: 2028
		' (get) Token: 0x060021CC RID: 8652 RVA: 0x000E24FC File Offset: 0x000E06FC
		' (set) Token: 0x060021CD RID: 8653 RVA: 0x000E2504 File Offset: 0x000E0704
		<oO0oooo("0375")>
		Public Property AllowResizeRow As Boolean
			Get
				Return Me.o.___.
			End Get
			Set(value As Boolean)
				Me.o.___. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.o.0o_oO0.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				Me.o.OO_00.()
			End Set
		End Property

		' Token: 0x170007ED RID: 2029
		' (get) Token: 0x060021CE RID: 8654 RVA: 0x000E2578 File Offset: 0x000E0778
		' (set) Token: 0x060021CF RID: 8655 RVA: 0x000E25A4 File Offset: 0x000E07A4
		<oO0oooo("0379")>
		Public Property AutoAddNew As Boolean
			Get
				Return Not Me.frd_IsOuterQuery AndAlso Not Me.frd_IsInnerQuery AndAlso Me.o0O._ooo_o___.
			End Get
			Set(value As Boolean)
				Me.o0O._ooo_o___. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.O0o000_oo.00_.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x170007EE RID: 2030
		' (get) Token: 0x060021D0 RID: 8656 RVA: 0x000E2610 File Offset: 0x000E0810
		' (set) Token: 0x060021D1 RID: 8657 RVA: 0x000E2618 File Offset: 0x000E0818
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SystemVisualStyle As Boolean
			Get
				Return Me.o._000.
			End Get
			Set(value As Boolean)
				Me.o._000. = value
			End Set
		End Property

		' Token: 0x170007EF RID: 2031
		' (get) Token: 0x060021D2 RID: 8658 RVA: 0x000E2624 File Offset: 0x000E0824
		' (set) Token: 0x060021D3 RID: 8659 RVA: 0x000E2650 File Offset: 0x000E0850
		<oO0oooo("0377")>
		Public Property AllowAddNew As Boolean
			Get
				Return Not Me.frd_IsOuterQuery AndAlso Not Me.frd_IsInnerQuery AndAlso Me.oo0__.00_.
			End Get
			Set(value As Boolean)
				Me.oo0__.00_. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.O.oOO_OO0oo00.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x170007F0 RID: 2032
		' (get) Token: 0x060021D4 RID: 8660 RVA: 0x000E26BC File Offset: 0x000E08BC
		' (set) Token: 0x060021D5 RID: 8661 RVA: 0x000E26E4 File Offset: 0x000E08E4
		<oO0oooo("0378")>
		Public Property AllowEdit As Boolean
			Get
				Return OO_00oOO.DataTables.AllowEdit AndAlso Me.Ooo._O_0Oo___.
			End Get
			Set(value As Boolean)
				Me.Ooo._O_0Oo___. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.OO_0_oo0_.oO__.()
								table.foxGrid.Rows(0).Invalidate()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				Main.OO_O.o..O.ooO0. = True
			End Set
		End Property

		' Token: 0x170007F1 RID: 2033
		' (get) Token: 0x060021D6 RID: 8662 RVA: 0x000E2774 File Offset: 0x000E0974
		' (set) Token: 0x060021D7 RID: 8663 RVA: 0x000E277C File Offset: 0x000E097C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property PreserveEditMode2 As BooleanEnum
			Get
				Return Me.o_oO0O_.O0.
			End Get
			Set(value As BooleanEnum)
				Me.o_oO0O_.O0. = value
			End Set
		End Property

		' Token: 0x170007F2 RID: 2034
		' (get) Token: 0x060021D8 RID: 8664 RVA: 0x000E2788 File Offset: 0x000E0988
		' (set) Token: 0x060021D9 RID: 8665 RVA: 0x000E27B5 File Offset: 0x000E09B5
		<oO0oooo("3278")>
		Public Property PreserveEditMode As Boolean
			Get
				Dim result As Boolean
				If Me.o_oO0O_.O0. Is Nothing Then
					result = OO_00oOO.DataTables.PreserveEditMode
				Else
					result = (Me.o_oO0O_.O0. = 1)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.o_oO0O_.O0. = 1
				Else
					Me.o_oO0O_.O0. = 2
				End If
				Me.o0.0o_0.()
			End Set
		End Property

		' Token: 0x060021DA RID: 8666 RVA: 0x000E27D4 File Offset: 0x000E09D4
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim a_ As Boolean = Me.PreserveEditMode
			If OO_00oOO.Tables IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.View.o_o.O0ooOo.() Is Me._DataTable Then
							table.oOoo_oOO0.O0.(a_)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			Dim result As Boolean
			Return result
		End Function

		' Token: 0x170007F3 RID: 2035
		' (get) Token: 0x060021DB RID: 8667 RVA: 0x000E2844 File Offset: 0x000E0A44
		' (set) Token: 0x060021DC RID: 8668 RVA: 0x000E2870 File Offset: 0x000E0A70
		<oO0oooo("0380")>
		Public Property AllowDelete As Boolean
			Get
				Return Not Me.frd_IsOuterQuery AndAlso Not Me.frd_IsInnerQuery AndAlso Me.O_oo0o_O0._0o.
			End Get
			Set(value As Boolean)
				Me.O_oo0o_O0._0o. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.o00O.0O.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x170007F4 RID: 2036
		' (get) Token: 0x060021DD RID: 8669 RVA: 0x000E28DC File Offset: 0x000E0ADC
		' (set) Token: 0x060021DE RID: 8670 RVA: 0x000E28E4 File Offset: 0x000E0AE4
		<oO0oooo("0110")>
		Public Property DeleteRowPrompt As Boolean
			Get
				Return Me.o.o_O00O_O_0.
			End Get
			Set(value As Boolean)
				Me.o.o_O00O_O_0. = value
			End Set
		End Property

		' Token: 0x170007F5 RID: 2037
		' (get) Token: 0x060021DF RID: 8671 RVA: 0x000E28ED File Offset: 0x000E0AED
		' (set) Token: 0x060021E0 RID: 8672 RVA: 0x000E28F8 File Offset: 0x000E0AF8
		<oO0oooo("0381")>
		Public Property AllowLockRow As Boolean
			Get
				Return Me.Oo0o00o.Oo0_O.
			End Get
			Set(value As Boolean)
				Me.Oo0o00o.Oo0_O. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.oO0oOo0_o00._O.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x170007F6 RID: 2038
		' (get) Token: 0x060021E1 RID: 8673 RVA: 0x000E2964 File Offset: 0x000E0B64
		' (set) Token: 0x060021E2 RID: 8674 RVA: 0x000E299C File Offset: 0x000E0B9C
		<oO0oooo("3305")>
		Public Property Theme As String
			Get
				Dim result As String
				If Operators.CompareString(Me.O0__.00., "(default)", True) = 0 Then
					result = O_O0OO.O0_00o.o0__o..GridThemeName
				Else
					result = Me.O0__.00.
				End If
				Return result
			End Get
			Set(value As String)
				Me.O0__.00. = value
				If Me.BaseTable.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() AndAlso Not O_O0OO.o0OoO00OO.00O. Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.DataTable Is Me Then
								Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { table.Grid })
								Main.OO_O.o..Oo.oOo_o0Oo0.(table.Theme, New Object() { table.Grid })
								table.foxGrid.Oo0._0.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x060021E3 RID: 8675 RVA: 0x000E2A50 File Offset: 0x000E0C50
		Friend Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.O0__.00., "(default)", True) = 0 Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me AndAlso Operators.CompareString(table.ooo00.o0__OO0., "(default)", True) = 0 Then
							table.Theme = table.ooo00.o0__OO0.
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x170007F7 RID: 2039
		' (get) Token: 0x060021E4 RID: 8676 RVA: 0x000E2AD0 File Offset: 0x000E0CD0
		' (set) Token: 0x060021E5 RID: 8677 RVA: 0x000E2AD8 File Offset: 0x000E0CD8
		<oO0oooo("0382")>
		Public Property AllowUnlockRow As Boolean
			Get
				Return Me.O_O._.
			End Get
			Set(value As Boolean)
				Me.O_O._. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.O0Oo000o0_O.o0.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x170007F8 RID: 2040
		' (get) Token: 0x060021E6 RID: 8678 RVA: 0x000E2B44 File Offset: 0x000E0D44
		' (set) Token: 0x060021E7 RID: 8679 RVA: 0x000E2B4C File Offset: 0x000E0D4C
		<oO0oooo("0376")>
		Public Property AllowResizeSingleRow As Boolean
			Get
				Return Me.O0.oOO0_.
			End Get
			Set(value As Boolean)
				Me.O0.oOO0_. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.OOo_.__Oo00o.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x170007F9 RID: 2041
		' (get) Token: 0x060021E8 RID: 8680 RVA: 0x000E2BB8 File Offset: 0x000E0DB8
		' (set) Token: 0x060021E9 RID: 8681 RVA: 0x000E2BC0 File Offset: 0x000E0DC0
		<oO0oooo("1515")>
		Public Property AllowClipBoard As Boolean
			Get
				Return Me.OOooo.0o_0O_O_.
			End Get
			Set(value As Boolean)
				Me.OOooo.0o_0O_O_. = value
			End Set
		End Property

		' Token: 0x170007FA RID: 2042
		' (get) Token: 0x060021EA RID: 8682 RVA: 0x000E2BC9 File Offset: 0x000E0DC9
		' (set) Token: 0x060021EB RID: 8683 RVA: 0x000E2BD1 File Offset: 0x000E0DD1
		<oO0oooo("2630")>
		Public Property AllowCopyHeader As Boolean
			Get
				Return Me.o_.O_0_0_ooOo.
			End Get
			Set(value As Boolean)
				Me.o_.O_0_0_ooOo. = value
			End Set
		End Property

		' Token: 0x170007FB RID: 2043
		' (get) Token: 0x060021EC RID: 8684 RVA: 0x000E2BDA File Offset: 0x000E0DDA
		' (set) Token: 0x060021ED RID: 8685 RVA: 0x000E2BE2 File Offset: 0x000E0DE2
		<oO0oooo("1527")>
		Public Property AllowInitialize As Boolean
			Get
				Return Me.Ooo00.oo.
			End Get
			Set(value As Boolean)
				Me.Ooo00.oo. = value
			End Set
		End Property

		' Token: 0x170007FC RID: 2044
		' (get) Token: 0x060021EE RID: 8686 RVA: 0x000E2BEB File Offset: 0x000E0DEB
		' (set) Token: 0x060021EF RID: 8687 RVA: 0x000E2BF3 File Offset: 0x000E0DF3
		<oO0oooo("2297")>
		Public Property AllowRedirect As Boolean
			Get
				Return Me.oO.0o0O0oO.
			End Get
			Set(value As Boolean)
				Me.oO.0o0O0oO. = value
			End Set
		End Property

		' Token: 0x170007FD RID: 2045
		' (get) Token: 0x060021F0 RID: 8688 RVA: 0x000E2BFC File Offset: 0x000E0DFC
		' (set) Token: 0x060021F1 RID: 8689 RVA: 0x000E2C04 File Offset: 0x000E0E04
		<oO0oooo("0371")>
		Public Property Caption As String
			Get
				Return Me.o0O._ooo_o___.
			End Get
			Friend Set(value As String)
				Me.o0O._ooo_o___. = value
			End Set
		End Property

		' Token: 0x170007FE RID: 2046
		' (get) Token: 0x060021F2 RID: 8690 RVA: 0x000E2C0D File Offset: 0x000E0E0D
		' (set) Token: 0x060021F3 RID: 8691 RVA: 0x000E2C18 File Offset: 0x000E0E18
		<oO0oooo("0386")>
		Public Property TabKeyActionDown As Boolean
			Get
				Return Me.O0___.O.
			End Get
			Set(value As Boolean)
				Me.O0___.O. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.oo_.o_0o.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				Me.o.OO_00.()
			End Set
		End Property

		' Token: 0x170007FF RID: 2047
		' (get) Token: 0x060021F4 RID: 8692 RVA: 0x000E2C8C File Offset: 0x000E0E8C
		' (set) Token: 0x060021F5 RID: 8693 RVA: 0x000E2C94 File Offset: 0x000E0E94
		<oO0oooo("0385")>
		Public Property EnterKeyActionDown As Boolean
			Get
				Return Me.Oo0Oo_.O000.
			End Get
			Set(value As Boolean)
				Me.Oo0Oo_.O000. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me._DataTable Then
								table.o_0.__0_.()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				Me.o.OO_00.()
			End Set
		End Property

		' Token: 0x17000800 RID: 2048
		' (get) Token: 0x060021F6 RID: 8694 RVA: 0x000E2D08 File Offset: 0x000E0F08
		<oO0oooo("1428")>
		Public ReadOnly Property DataCols As DataColCollection
			Get
				Return Me.o.O0O_0__OOo_.
			End Get
		End Property

		' Token: 0x17000801 RID: 2049
		' (get) Token: 0x060021F7 RID: 8695 RVA: 0x000E2D10 File Offset: 0x000E0F10
		<oO0oooo("0370")>
		Public ReadOnly Property Name As String
			Get
				Return Me._DataTable.TableName
			End Get
		End Property

		' Token: 0x17000802 RID: 2050
		' (get) Token: 0x060021F8 RID: 8696 RVA: 0x000E2D1D File Offset: 0x000E0F1D
		<oO0oooo("0419")>
		Public ReadOnly Property DataRows As DataRowCollection
			Get
				If Me.o_oO0O_.O0. Is Nothing Then
					Me.o_oO0O_.O0. = New DataRowCollection(Me._DataTable)
				End If
				Return Me.o_oO0O_.O0.
			End Get
		End Property

		' Token: 0x060021F9 RID: 8697 RVA: 0x000E2D40 File Offset: 0x000E0F40
		<oO0oooo("1579")>
		Public Sub AddUserStyle(Name As String, Optional BackColor As Color? = Nothing, Optional Forecolor As Color? = Nothing)
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me AndAlso Not table.foxGrid.Styles.Contains("User" + Name) Then
						Dim cellStyle As CellStyle = table.foxGrid.Styles.Add("User" + Name)
						If BackColor IsNot Nothing Then
							cellStyle.BackColor = BackColor.Value
						End If
						If Forecolor IsNot Nothing Then
							cellStyle.ForeColor = Forecolor.Value
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x17000803 RID: 2051
		' (get) Token: 0x060021FA RID: 8698 RVA: 0x000E2DF4 File Offset: 0x000E0FF4
		<oO0oooo("0656")>
		Public ReadOnly Property Styles(A_0 As String) As CellStyle
			Get
				Return New CellStyle(Me, "User" + A_0)
			End Get
		End Property

		' Token: 0x17000804 RID: 2052
		' (get) Token: 0x060021FB RID: 8699 RVA: 0x000E2E07 File Offset: 0x000E1007
		<oO0oooo("1577")>
		Public ReadOnly Property SysStyles(A_0 As String) As CellStyle
			Get
				Return New CellStyle(Me, A_0)
			End Get
		End Property

		' Token: 0x17000805 RID: 2053
		' (get) Token: 0x060021FC RID: 8700 RVA: 0x000E2E10 File Offset: 0x000E1010
		<oO0oooo("0387")>
		Public ReadOnly Property HasChanges As Boolean
			Get
				Dim obj As Object = Me._DataTable
				Dim result As Boolean
				SyncLock obj
					result = (Me._DataTable.[Select]("", "", DataViewRowState.Unchanged).Length <> Me._DataTable.Rows.Count)
				End SyncLock
				Return result
			End Get
		End Property

		' Token: 0x17000806 RID: 2054
		' (get) Token: 0x060021FD RID: 8701 RVA: 0x000E2E7C File Offset: 0x000E107C
		<oO0oooo("0389")>
		Public ReadOnly Property Type As Integer
			Get
				Dim result As Integer
				If Me.frd_IsInnerTable Then
					result = 1
				ElseIf Me.frd_IsInnerQuery Then
					result = 2
				ElseIf Me.frd_IsOuterTable Then
					result = 3
				ElseIf Me.frd_IsOuterQuery Then
					result = 4
				ElseIf Me.frd_IsTemporary Then
					result = 5
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000807 RID: 2055
		' (get) Token: 0x060021FE RID: 8702 RVA: 0x000E2EC4 File Offset: 0x000E10C4
		' (set) Token: 0x060021FF RID: 8703 RVA: 0x000E2ECC File Offset: 0x000E10CC
		Public Property AddByCode As Boolean
			Get
				Return Me.Oo.OO0ooOOo_.
			End Get
			Friend Set(value As Boolean)
				Me.Oo.OO0ooOOo_. = value
			End Set
		End Property

		' Token: 0x17000808 RID: 2056
		' (set) Token: 0x06002200 RID: 8704 RVA: 0x000E2ED5 File Offset: 0x000E10D5
		Friend WriteOnly Property LoadFilter3 As String
			Set(value As String)
				Me.o_O_0.0_O. = value
				Me.ooO.oO0O0_oo. = True
			End Set
		End Property

		' Token: 0x06002201 RID: 8705 RVA: 0x000E2EE5 File Offset: 0x000E10E5
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Operators.CompareString(Me.LoadFilter, Me.OOOOO._., True) = 0 Then
				Me.o00o.00oO___0..Clear()
			End If
			Me.o_O_0.0_O. = A_0
			Me.ooO.oO0O0_oo. = True
			Me.o00o.00oO___0..Add(A_1)
		End Sub

		' Token: 0x17000809 RID: 2057
		' (get) Token: 0x06002202 RID: 8706 RVA: 0x000E2F20 File Offset: 0x000E1120
		' (set) Token: 0x06002203 RID: 8707 RVA: 0x000E2F28 File Offset: 0x000E1128
		<oO0oooo("1928")>
		Public Property LoadFilter As String
			Get
				Return Me.o_O_0.0_O.
			End Get
			Set(value As String)
				Me.o_O_0.0_O. = value
				Me.ooO.oO0O0_oo. = True
				Me.OOOOO._. = value
			End Set
		End Property

		' Token: 0x1700080A RID: 2058
		' (get) Token: 0x06002204 RID: 8708 RVA: 0x000E2F3F File Offset: 0x000E113F
		' (set) Token: 0x06002205 RID: 8709 RVA: 0x000E2F47 File Offset: 0x000E1147
		<oO0oooo("1928")>
		Public Property LoadTop As String
			Get
				Return Me.Ooo00._0_oO_.
			End Get
			Set(value As String)
				Me.Ooo00._0_oO_. = value
				Me.ooO.oO0O0_oo. = True
			End Set
		End Property

		' Token: 0x1700080B RID: 2059
		' (get) Token: 0x06002206 RID: 8710 RVA: 0x000E2F58 File Offset: 0x000E1158
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property LoadTop2 As String
			Get
				Dim result As String
				If Operators.CompareString(Me.Ooo00._0_oO_., "", True) = 0 AndAlso Operators.CompareString(Me.OOoO._o., "", True) > 0 Then
					result = "100 PERCENT"
				Else
					result = Me.Ooo00._0_oO_.
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700080C RID: 2060
		' (get) Token: 0x06002207 RID: 8711 RVA: 0x000E2F9C File Offset: 0x000E119C
		' (set) Token: 0x06002208 RID: 8712 RVA: 0x000E2FA4 File Offset: 0x000E11A4
		<oO0oooo("1928")>
		Public Property LoadReverse As Boolean
			Get
				Return Me.O_0o0._O0.
			End Get
			Set(value As Boolean)
				Me.O_0o0._O0. = value
				Me.ooO.oO0O0_oo. = True
			End Set
		End Property

		' Token: 0x1700080D RID: 2061
		' (get) Token: 0x06002209 RID: 8713 RVA: 0x000E2FB4 File Offset: 0x000E11B4
		' (set) Token: 0x0600220A RID: 8714 RVA: 0x000E2FBC File Offset: 0x000E11BC
		<oO0oooo("1928")>
		Public Property LoadOrder As String
			Get
				Return Me.OOoO._o.
			End Get
			Set(value As String)
				Me.OOoO._o. = value
				Me.ooO.oO0O0_oo. = True
			End Set
		End Property

		' Token: 0x1700080E RID: 2062
		' (get) Token: 0x0600220B RID: 8715 RVA: 0x000E2FCC File Offset: 0x000E11CC
		' (set) Token: 0x0600220C RID: 8716 RVA: 0x000E2FD4 File Offset: 0x000E11D4
		<oO0oooo("1928")>
		Public Property LoadOver As String
			Get
				Return Me.o_OOo0.o.
			End Get
			Set(value As String)
				Me.o_OOo0.o. = value
				Me.ooO.oO0O0_oo. = True
			End Set
		End Property

		' Token: 0x1700080F RID: 2063
		' (get) Token: 0x0600220D RID: 8717 RVA: 0x000E2FE4 File Offset: 0x000E11E4
		' (set) Token: 0x0600220E RID: 8718 RVA: 0x000E2FEC File Offset: 0x000E11EC
		<oO0oooo("1928")>
		Public Property LoadPage As Integer
			Get
				Return Me.O_.oO_O_.
			End Get
			Set(value As Integer)
				Me.O_.oO_O_. = value
				Me.ooO.oO0O0_oo. = True
			End Set
		End Property

		' Token: 0x17000810 RID: 2064
		' (get) Token: 0x0600220F RID: 8719 RVA: 0x000E2FFC File Offset: 0x000E11FC
		<oO0oooo("1928")>
		Public ReadOnly Property TotalPages As Double
			Get
				Dim num As Integer = Me.TotalRows
				Dim result As Double
				If num >= 0 Then
					result = Math.Ceiling(CDbl(num) / CDbl(Conversions.ToInteger(Me.LoadTop)))
				Else
					result = -1.0
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000811 RID: 2065
		' (get) Token: 0x06002210 RID: 8720 RVA: 0x000E3038 File Offset: 0x000E1238
		<oO0oooo("1928")>
		Public ReadOnly Property TotalRows As Integer
			Get
				Dim flag As Boolean
				If Operators.CompareString(Me.DataServer, "", True) > 0 Then
					flag = (Me.DataServerType = DataServerTypeEnum.Oracle)
				Else
					flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection)
				End If
				Dim result As Integer
				If Me._Adapter Is Nothing AndAlso Operators.CompareString(Me.DataServer, "", True) = 0 Then
					result = -1
				Else
					If Operators.CompareString(Me.LoadTop, "", True) > 0 AndAlso Versioned.IsNumeric(Me.LoadTop) AndAlso (Me.BaseTable.PrimaryKey.Length = 1 OrElse Operators.CompareString(Me.LoadOver, "", True) > 0 OrElse Me.BaseTable.Columns.Contains("_SortKey") OrElse Me.BaseTable.Columns.Contains("_Identify")) Then
						Dim text As String = ""
						If Operators.CompareString(Me.LoadOver, "", True) > 0 Then
							text = Me.LoadOver
						ElseIf Me.BaseTable.Columns.Contains("_SortKey") Then
							text = "_SortKey"
						ElseIf Me.BaseTable.Columns.Contains("_Identify") Then
							text = "_Identify"
						ElseIf Me.BaseTable.PrimaryKey.Length = 1 Then
							text = Me.BaseTable.PrimaryKey(0).ColumnName
						End If
						If Operators.CompareString(text, "", True) > 0 Then
							If flag Then
								text = """" + text + """"
							ElseIf Not text.EndsWith("]") Then
								text = "[" + text + "]"
							End If
						End If
						Dim str As String
						If Operators.CompareString(Me.o._OOO0oOo0__., "", True) > 0 Then
							If flag Then
								str = Me.o._OOO0oOo0__.
							Else
								str = "[" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
							End If
						ElseIf Operators.CompareString(Me.DataServer, "", True) > 0 Then
							str = Oo00.O0__oo.__0o.(Me.HttpSelect)
						Else
							str = Oo00.O0__oo.__0o.(Me.frd_SelectCommandString)
						End If
						If Operators.CompareString(text, "", True) > 0 AndAlso text.IndexOf(".") < 0 Then
							text = str + "." + text
						End If
						Dim text2 As String
						If Operators.CompareString(Me.DataServer, "", True) > 0 Then
							text2 = "Select Count(" + text + ") From " + Oo00.o_0o0O.0_O.(Me.HttpSelect)
						Else
							text2 = "Select Count(" + text + ") From " + Oo00.o_0o0O.0_O.(Me._Adapter.SelectCommand.CommandText)
						End If
						If Operators.CompareString(Me.LoadFilter, "", True) > 0 Then
							If Operators.CompareString(Me.DataServer, "", True) = 0 Then
								text2 = text2 + " Where " + Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Me.LoadFilter, False)
							Else
								text2 = text2 + " Where " + Oo00.o0_o._O_.(Me.DataServerType, Me.LoadFilter, False)
							End If
						End If
						Dim obj As Object
						If Operators.CompareString(Me.DataServer, "", True) > 0 Then
							Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
							httpClient.FormData.Add("Action", 6.ToString())
							httpClient.[Select] = text2
							obj = httpClient.GetData()
						Else
							Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, Me.frd_Connection)
							oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
							Dim state As ConnectionState = Me.frd_Connection.State
							If state <> ConnectionState.Open Then
								Me.frd_Connection.Open()
							End If
							obj = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
							If state <> ConnectionState.Open Then
								Me.frd_Connection.Close()
							End If
						End If
						If obj IsNot Nothing Then
							Return Conversions.ToInteger(obj)
						End If
					End If
					result = -1
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002211 RID: 8721 RVA: 0x000E3408 File Offset: 0x000E1608
		<oO0oooo("2721")>
		Public Sub SQLLoad(SelectString As String, Optional SaveData As Boolean = True)
			If Me._Adapter IsNot Nothing OrElse Operators.CompareString(Me.DataServer, "", True) > 0 Then
				Dim loadEventArgs As LoadEventArgs = New LoadEventArgs(Me)
				Dim a_ As String = "BeforeLoad"
				O_O0OO.OoO_o.oO0o0O.(Me.o_0_00_.oo0O0., a_, New Object() { loadEventArgs }, False, Me.BaseTable.TableName, False)
				If Not loadEventArgs.Cancel AndAlso OO_00oOO.DataTables(Me.BaseTable.TableName).GlobalHandler.BeforeLoad Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { loadEventArgs }, False, "全局表事件", False)
				End If
				If loadEventArgs.Cancel Then
					Return
				End If
				If SaveData AndAlso (Me.frd_IsInnerTable OrElse Me.frd_IsOuterTable) Then
					If Operators.CompareString(Me.DataServer, "", True) > 0 Then
						If Operators.CompareString(Me.UpdateServer, "", True) > 0 Then
							If Not Me.o.o_O.() Then
								Return
							End If
							If Not Me.O0o0.O_0_.() Then
								Return
							End If
						End If
					ElseIf Not Me.oO.o_0.(False, True) Then
						Return
					End If
				End If
			End If
			If Me._Adapter IsNot Nothing Then
				Me._Adapter.SelectCommand.CommandText = Oo00.o0_o._O_.(Me.frd_Connection, SelectString, False)
				Me.O._0O_O0O.(Me._Adapter, Nothing)
				Return
			End If
			If Operators.CompareString(Me.DataServer, "", True) > 0 Then
				SelectString = Oo00.o0_o._O_.(O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).OO.OoO0., SelectString, False)
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				httpClient.FormData("Action") = 2.ToString()
				httpClient.[Select] = SelectString
				Me.O._O0__. = SelectString
				httpClient.FormData.Add("IgnoreSchema", "True")
				Me.O._0O_O0O.(Nothing, httpClient)
			End If
		End Sub

		' Token: 0x06002212 RID: 8722 RVA: 0x000E35D1 File Offset: 0x000E17D1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub LoadAsync(Optional SaveData As Boolean = True)
			If SaveData Then
				AddressOf Me.oOo0.OO0..Start()
				Return
			End If
			AddressOf Me.o0.o..Start()
		End Sub

		' Token: 0x06002213 RID: 8723 RVA: 0x000E3603 File Offset: 0x000E1803
		Private Sub <<EMPTY_NAME>>()
			Me.o0.o.(True, Me.Apapter2)
		End Sub

		' Token: 0x06002214 RID: 8724 RVA: 0x000E3612 File Offset: 0x000E1812
		Private Sub <<EMPTY_NAME>>()
			Me.o0.o.(False, Me.Apapter2)
		End Sub

		' Token: 0x06002215 RID: 8725 RVA: 0x000E3621 File Offset: 0x000E1821
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AppendLoadAsync(Filter As String, Optional SaveBefore As Boolean = True)
			Me.OOOo.O0_. = Filter
			Me.O0Oo0oo_._o_0O. = SaveBefore
			AddressOf Me.o0O.O_0..Start()
		End Sub

		' Token: 0x06002216 RID: 8726 RVA: 0x000E3647 File Offset: 0x000E1847
		Private Sub <<EMPTY_NAME>>()
			Me.o0O.O_0.(Me.OOOo.O0_., Me.O0Oo0oo_._o_0O., Me.Apapter2)
		End Sub

		' Token: 0x06002217 RID: 8727 RVA: 0x000E3662 File Offset: 0x000E1862
		<oO0oooo("1928")>
		Public Sub Load(Optional SaveData As Boolean = True)
			Me.o0.o.(SaveData, Nothing)
		End Sub

		' Token: 0x06002218 RID: 8728 RVA: 0x000E366C File Offset: 0x000E186C
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = True, Optional A_1 As OleDbDataAdapter = Nothing)
			Dim oo_O.o. As Object = Main.OO_O.o.
			SyncLock oo_O.o.
				While O_O0OO.O_O00OOooo.O_. Or Me.o00o.00oO___0.
					Thread.Sleep(1)
				End While
				O_O0OO.O_O00OOooo.O_. = True
				Me.o00o.00oO___0. = True
			End SyncLock
			Try
				If A_1 Is Nothing Then
					A_1 = Me._Adapter
				End If
				Me.o.o00O.(A_0, A_1)
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				O_O0OO.O_O00OOooo.O_. = False
				Me.o00o.00oO___0. = False
			End Try
			If OO_00oOO.Tables IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me Then
							table.ResetCurrentItem()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06002219 RID: 8729 RVA: 0x000E376C File Offset: 0x000E196C
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean, A_1 As OleDbDataAdapter)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me._Adapter Is Nothing AndAlso Operators.CompareString(Me.DataServer, "", True) = 0 Then
					GoTo IL_DAE
				End If
				IL_27:
				num2 = 4
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_4B
				End If
				IL_3D:
				num2 = 5
				Dim flag As Boolean = Me.DataServerType = DataServerTypeEnum.Oracle
				GoTo IL_59
				IL_4B:
				num2 = 7
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection)
				IL_59:
				num2 = 8
				If Not A_0 OrElse (Not Me.frd_IsInnerTable AndAlso Not Me.frd_IsOuterTable) Then
					GoTo IL_CA
				End If
				IL_6E:
				num2 = 9
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_BA
				End If
				IL_85:
				num2 = 10
				If Operators.CompareString(Me.UpdateServer, "", True) <= 0 Then
					GoTo IL_CA
				End If
				IL_9C:
				num2 = 11
				If Not Me.o.o_O.() Then
					GoTo IL_DAE
				End If
				IL_AA:
				num2 = 13
				If Not Me.O0o0.O_0_.() Then
					GoTo IL_DAE
				End If
				GoTo IL_CA
				IL_BA:
				num2 = 16
				If Not Me.oO.o_0.(False, True) Then
					GoTo IL_DAE
				End If
				IL_CA:
				num2 = 18
				Dim loadEventArgs As LoadEventArgs = New LoadEventArgs(Me)
				IL_D5:
				num2 = 19
				Dim a_ As String = "BeforeLoad"
				IL_DF:
				num2 = 20
				O_O0OO.OoO_o.oO0o0O.(Me.o_0_00_.oo0O0., a_, New Object() { loadEventArgs }, False, Me.BaseTable.TableName, False)
				IL_108:
				num2 = 21
				If Me._DataTable.DataSet IsNot O_O0OO.OOOo.oo_OOOO_0.() OrElse loadEventArgs.Cancel Then
					GoTo IL_16C
				End If
				IL_126:
				num2 = 22
				If Not OO_00oOO.DataTables(Me.BaseTable.TableName).GlobalHandler.BeforeLoad Then
					GoTo IL_16C
				End If
				IL_14A:
				num2 = 23
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { loadEventArgs }, False, "全局表事件", False)
				IL_16C:
				num2 = 24
				If loadEventArgs.Cancel Then
					GoTo IL_DAE
				End If
				IL_17B:
				num2 = 26
				If Me.ooO.oO0O0_oo. OrElse Operators.CompareString(Me.DataServer, "", True) <> 0 Then
					GoTo IL_1A9
				End If
				IL_199:
				num2 = 27
				Me.O._0O_O0O.(A_1, Nothing)
				GoTo IL_DAE
				IL_1A9:
				num2 = 29
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_1CD
				End If
				IL_1C0:
				num2 = 30
				Dim text As String = Me.HttpSelect
				GoTo IL_1E2
				IL_1CD:
				num2 = 32
				text = Me._Adapter.SelectCommand.CommandText
				IL_1E2:
				num2 = 33
				text = text.Trim()
				IL_1EE:
				num2 = 34
				Dim text2 As String = Oo00.o_0o0O.0_O.(text)
				IL_1FA:
				num2 = 35
				Dim array As String() = Regex.Split(text, "[\s]+")
				IL_20B:
				num2 = 36
				Dim text3 As String = ""
				IL_215:
				num2 = 37
				Dim text4 As String = ""
				IL_21F:
				num2 = 38
				If Operators.CompareString(array(1), "Distinct", True) <> 0 Then
					GoTo IL_23F
				End If
				IL_233:
				num2 = 39
				text3 = "Select Distinct"
				GoTo IL_249
				IL_23F:
				num2 = 41
				text3 = "Select"
				IL_249:
				num2 = 42
				If Operators.CompareString(array(1), "top", True) <> 0 Then
					GoTo IL_281
				End If
				IL_25D:
				num2 = 43
				If Operators.CompareString(array(3), "PERCENT", True) <> 0 Then
					GoTo IL_279
				End If
				IL_271:
				num2 = 44
				Dim num3 As Integer = 4
				GoTo IL_2DB
				IL_279:
				num2 = 46
				num3 = 3
				GoTo IL_2DB
				IL_281:
				num2 = 48
				If Operators.CompareString(array(2), "top", True) <> 0 Then
					GoTo IL_2B9
				End If
				IL_295:
				num2 = 49
				If Operators.CompareString(array(4), "PERCENT", True) <> 0 Then
					GoTo IL_2B1
				End If
				IL_2A9:
				num2 = 50
				num3 = 5
				GoTo IL_2DB
				IL_2B1:
				num2 = 52
				num3 = 4
				GoTo IL_2DB
				IL_2B9:
				num2 = 54
				If Operators.CompareString(array(1), "Distinct", True) <> 0 Then
					GoTo IL_2D5
				End If
				IL_2CD:
				num2 = 55
				num3 = 2
				GoTo IL_2DB
				IL_2D5:
				num2 = 57
				num3 = 1
				IL_2DB:
				num2 = 58
				Dim text5 As String = array(num3)
				IL_2E5:
				num2 = 59
				For Each value As Char In "\$()*+.[]?^{}|"
					IL_2FF:
					num2 = 60
					text5 = text5.Replace(Conversions.ToString(value), "\" + Conversions.ToString(value))
					IL_323:
					num2 = 61
				Next
				IL_337:
				num2 = 62
				Dim regex As Regex = New Regex("[\s]+" + text5 + "[\s]+", RegexOptions.IgnoreCase)
				IL_353:
				num2 = 63
				Dim match As Match = regex.Match(text)
				IL_361:
				num2 = 64
				If Not match.Success Then
					GoTo IL_3EB
				End If
				IL_36D:
				num2 = 65
				Dim startIndex As Integer = match.Index + 1
				IL_37B:
				num2 = 66
				If Operators.CompareString(Me.LoadTop2, "", True) <= 0 OrElse flag Then
					GoTo IL_3D1
				End If
				IL_395:
				num2 = 67
				text = String.Concat(New String() { text3, " Top ", Me.LoadTop2, " ", text.Substring(startIndex) })
				GoTo IL_3EB
				IL_3D1:
				num2 = 69
				text = text3 + " " + text.Substring(startIndex)
				IL_3EB:
				num2 = 70
				Dim num4 As Integer = Oo00.OoO_.__o.(text)
				IL_3F7:
				num2 = 71
				regex = New Regex("[\s]+join[\s]+", RegexOptions.IgnoreCase)
				IL_407:
				num2 = 72
				match = regex.Match(text, num4)
				IL_417:
				num2 = 73
				If Not match.Success Then
					GoTo IL_469
				End If
				IL_423:
				num2 = 74
				regex = New Regex("[\s]+on[\s]+", RegexOptions.IgnoreCase)
				IL_433:
				num2 = 75
				match = regex.Match(text, match.Index + 1)
				IL_44A:
				num2 = 76
				If Not match.Success Then
					GoTo IL_469
				End If
				IL_456:
				num2 = 77
				num4 = Math.Max(match.Index, num4)
				IL_469:
				num2 = 78
				regex = New Regex("[\s]+where[\s]+", RegexOptions.IgnoreCase)
				IL_479:
				num2 = 79
				match = regex.Match(text, num4)
				IL_489:
				num2 = 80
				If Not match.Success Then
					GoTo IL_4A9
				End If
				IL_495:
				num2 = 81
				text = text.Substring(0, match.Index)
				IL_4A9:
				num2 = 82
				regex = New Regex("[\s]+group[\s]+by[\s]+", RegexOptions.IgnoreCase)
				IL_4B9:
				num2 = 83
				match = regex.Match(text, num4)
				IL_4C9:
				num2 = 84
				If Not match.Success Then
					GoTo IL_4E9
				End If
				IL_4D5:
				num2 = 85
				text = text.Substring(0, match.Index)
				IL_4E9:
				num2 = 86
				regex = New Regex("[\s]+order[\s]+by[\s]+", RegexOptions.IgnoreCase)
				IL_4F9:
				num2 = 87
				match = regex.Match(text, num4)
				IL_509:
				num2 = 88
				If Not match.Success Then
					GoTo IL_529
				End If
				IL_515:
				num2 = 89
				text = text.Substring(0, match.Index)
				IL_529:
				num2 = 90
				If Operators.CompareString(Me.LoadOver, "", True) <= 0 Then
					GoTo IL_54D
				End If
				IL_540:
				num2 = 91
				text4 = Me.LoadOver
				GoTo IL_5C3
				IL_54D:
				num2 = 93
				If Not Me.BaseTable.Columns.Contains("_SortKey") Then
					GoTo IL_573
				End If
				IL_567:
				num2 = 94
				text4 = "_SortKey"
				GoTo IL_5C3
				IL_573:
				num2 = 96
				If Not Me.BaseTable.Columns.Contains("_Identify") Then
					GoTo IL_599
				End If
				IL_58D:
				num2 = 97
				text4 = "_Identify"
				GoTo IL_5C3
				IL_599:
				num2 = 99
				If Me.BaseTable.PrimaryKey.Length <> 1 Then
					GoTo IL_5C3
				End If
				IL_5AC:
				num2 = 100
				text4 = Me.BaseTable.PrimaryKey(0).ColumnName
				IL_5C3:
				num2 = 101
				If Operators.CompareString(text4, "", True) <= 0 Then
					GoTo IL_61D
				End If
				IL_5D6:
				num2 = 102
				If Not flag Then
					GoTo IL_5F4
				End If
				IL_5DC:
				num2 = 103
				text4 = """" + text4 + """"
				GoTo IL_637
				IL_5F4:
				num2 = 105
				If text4.EndsWith("]") Then
					GoTo IL_637
				End If
				IL_605:
				num2 = 106
				text4 = "[" + text4 + "]"
				GoTo IL_637
				IL_61D:
				num2 = 108
				If Me.LoadPage <= 0 Then
					GoTo IL_637
				End If
				IL_629:
				num2 = 109
				MessageBox.Show("对于无主键的表，必须指定LoadOver属性才能分页加载!")
				IL_637:
				num2 = 110
				Dim text7 As String = ""
				IL_641:
				num2 = 111
				If Operators.CompareString(Me.o._OOO0oOo0__., "", True) <= 0 Then
					GoTo IL_69C
				End If
				IL_658:
				num2 = 112
				If Not flag Then
					GoTo IL_66B
				End If
				IL_65E:
				num2 = 113
				text7 = Me.o._OOO0oOo0__.
				GoTo IL_6D5
				IL_66B:
				num2 = 115
				text7 = "[" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
				GoTo IL_6D5
				IL_69C:
				num2 = 117
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_6C5
				End If
				IL_6B3:
				num2 = 118
				text7 = Oo00.O0__oo.__0o.(Me.HttpSelect)
				GoTo IL_6D5
				IL_6C5:
				num2 = 120
				text7 = Oo00.O0__oo.__0o.(Me.frd_SelectCommandString)
				IL_6D5:
				num2 = 121
				Dim text8 As String = text4
				IL_6DC:
				num2 = 122
				If Operators.CompareString(text4, "", True) <= 0 OrElse text4.IndexOf(".") >= 0 Then
					GoTo IL_730
				End If
				IL_6FE:
				num2 = 123
				If text7.StartsWith("(") AndAlso text7.EndsWith(")") Then
					GoTo IL_730
				End If
				IL_71D:
				num2 = 124
				text4 = text7 + "." + text4
				IL_730:
				num2 = 125
				If Not(Me.LoadPage > 0 And Operators.CompareString(Me.LoadTop, "", True) > 0) OrElse Not Versioned.IsNumeric(Me.LoadTop) OrElse Operators.CompareString(text4, "", True) <= 0 Then
					GoTo IL_AA5
				End If
				IL_779:
				num2 = 126
				Dim num5 As Integer = Convert.ToInt32(Me.LoadTop)
				IL_789:
				num2 = 127
				Dim text9 As String = ""
				IL_793:
				num2 = 128
				If Not flag Then
					GoTo IL_845
				End If
				IL_79F:
				num2 = 129
				If Not Me.LoadReverse Then
					GoTo IL_7F9
				End If
				IL_7AD:
				num2 = 130
				text9 = String.Concat(New String() { "(", text4, " < (Select Min(", text8, ") From (Select ", text4, " From ", text2 })
				GoTo IL_919
				IL_7F9:
				num2 = 132
				text9 = String.Concat(New String() { "(", text4, " > (Select Max(", text8, ") From (Select ", text4, " From ", text2 })
				GoTo IL_919
				IL_845:
				num2 = 134
				If Not Me.LoadReverse Then
					GoTo IL_8B7
				End If
				IL_853:
				num2 = 135
				text9 = String.Concat(New String() { "(", text4, " < (Select Min(", text8, ") From (Select Top ", Conversions.ToString(num5 * Me.LoadPage), " ", text4, " From ", text2 })
				GoTo IL_919
				IL_8B7:
				num2 = 137
				text9 = String.Concat(New String() { "(", text4, " > (Select Max(", text8, ") From (Select Top ", Conversions.ToString(num5 * Me.LoadPage), " ", text4, " From ", text2 })
				IL_919:
				num2 = 138
				If Operators.CompareString(Me.LoadFilter, "", True) <= 0 Then
					GoTo IL_952
				End If
				IL_933:
				num2 = 139
				text9 = text9 + " Where (" + Me.LoadFilter + ")"
				IL_952:
				num2 = 140
				If Not flag Then
					GoTo IL_9BB
				End If
				IL_95B:
				num2 = 141
				If Operators.CompareString(Me.LoadFilter, "", True) <= 0 Then
					GoTo IL_999
				End If
				IL_975:
				num2 = 142
				text9 = text9 + " And ROWNUM <= " + Conversions.ToString(num5 * Me.LoadPage)
				GoTo IL_9BB
				IL_999:
				num2 = 144
				text9 = text9 + " Where ROWNUM <= " + Conversions.ToString(num5 * Me.LoadPage)
				IL_9BB:
				num2 = 145
				text9 = text9 + " Order By " + text4
				IL_9D1:
				num2 = 146
				If Not Me.LoadReverse Then
					GoTo IL_9F3
				End If
				IL_9DF:
				num2 = 147
				text9 += " DESC"
				IL_9F3:
				num2 = 148
				If Not flag Then
					GoTo IL_A12
				End If
				IL_9FC:
				num2 = 149
				text9 += ")))"
				GoTo IL_A26
				IL_A12:
				num2 = 151
				text9 += ") As [fox_tmp] ))"
				IL_A26:
				num2 = 152
				text = text + " Where (" + text9 + ")"
				IL_A41:
				num2 = 153
				If Operators.CompareString(Me.LoadFilter, "", True) <= 0 Then
					GoTo IL_A7A
				End If
				IL_A5B:
				num2 = 154
				text = text + " And (" + Me.LoadFilter + ")"
				IL_A7A:
				num2 = 155
				If Not flag Then
					GoTo IL_B86
				End If
				IL_A86:
				num2 = 156
				text = text + " And ROWNUM <=" + Me.LoadTop
				GoTo IL_B86
				IL_AA5:
				num2 = 158
				Dim text10 As String = Me.LoadFilter
				IL_AB3:
				num2 = 159
				If Not(Me.LoadPage <= 0 And Operators.CompareString(Me.LoadTop, "", True) > 0) OrElse Not Versioned.IsNumeric(Me.LoadTop) Then
					GoTo IL_B55
				End If
				IL_AE9:
				num2 = 160
				If Operators.CompareString(Me.DataServer, "", True) <> 0 OrElse Not flag Then
					GoTo IL_B55
				End If
				IL_B05:
				num2 = 161
				Dim text11 As String = "ROWNUM <= " + Me.LoadTop
				IL_B1D:
				num2 = 162
				If Operators.CompareString(text10, "", True) <= 0 Then
					GoTo IL_B4B
				End If
				IL_B33:
				num2 = 163
				text10 = text10 + " AND " + text11
				GoTo IL_B55
				IL_B4B:
				num2 = 165
				text10 = text11
				IL_B55:
				num2 = 166
				If Operators.CompareString(text10, "", True) <= 0 Then
					GoTo IL_B86
				End If
				IL_B6B:
				num2 = 167
				text = text + " Where (" + text10 + ")"
				IL_B86:
				num2 = 168
				If Operators.CompareString(Me.o0_oO00.0oO_., "", True) <= 0 Then
					GoTo IL_BBA
				End If
				IL_BA0:
				num2 = 169
				text = text + " Group By " + Me.o0_oO00.0oO_.
				IL_BBA:
				num2 = 170
				If Operators.CompareString(Me.O0o0__o.0000__., "", True) <= 0 Then
					GoTo IL_BEE
				End If
				IL_BD4:
				num2 = 171
				text = text + " having " + Me.O0o0__o.0000__.
				IL_BEE:
				num2 = 172
				If Not(Operators.CompareString(Me.LoadTop, "", True) > 0 And Me.LoadPage >= 0) OrElse Operators.CompareString(text4, "", True) <= 0 Then
					GoTo IL_C61
				End If
				IL_C27:
				num2 = 173
				text = text + " Order By " + text4
				IL_C3D:
				num2 = 174
				If Not Me.LoadReverse Then
					GoTo IL_C95
				End If
				IL_C4B:
				num2 = 175
				text += " DESC"
				GoTo IL_C95
				IL_C61:
				num2 = 177
				If Operators.CompareString(Me.LoadOrder, "", True) <= 0 Then
					GoTo IL_C95
				End If
				IL_C7B:
				num2 = 178
				text = text + " Order By " + Me.LoadOrder
				IL_C95:
				num2 = 179
				OO_00oOO.LockBaseMainForm()
				IL_CA0:
				num2 = 180
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_D45
				End If
				IL_CBD:
				num2 = 181
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				IL_CDA:
				num2 = 182
				httpClient.FormData.Add("IgnoreSchema", "True")
				IL_CF6:
				num2 = 183
				httpClient.[Select] = text
				IL_D05:
				num2 = 184
				Me.O._O0__. = text
				IL_D13:
				num2 = 185
				httpClient.FormData("Action") = 2.ToString()
				IL_D34:
				num2 = 186
				Me.O._0O_O0O.(Nothing, httpClient)
				GoTo IL_DA3
				IL_D45:
				num2 = 188
				text = Oo00.o0_o._O_.(Me.frd_Connection, text, False)
				IL_D5B:
				num2 = 189
				A_1.SelectCommand.CommandText = text
				IL_D6E:
				num2 = 190
				If A_1 Is Me._Adapter Then
					GoTo IL_D95
				End If
				IL_D7D:
				num2 = 191
				Me._Adapter.SelectCommand.CommandText = text
				IL_D95:
				num2 = 192
				Me.O._0O_O0O.(A_1, Nothing)
				IL_DA3:
				num2 = 193
				OO_00oOO.UnlockBaseMainForm()
				IL_DAE:
				GoTo IL_1108
				IL_DB3:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_10C9:
				GoTo IL_10FD
				IL_10CB:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_10DB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_10CB
			End Try
			IL_10FD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1108:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600221A RID: 8730 RVA: 0x000E48A8 File Offset: 0x000E2AA8
		Private Sub <<EMPTY_NAME>>(A_0 As OleDbDataAdapter, Optional A_1 As HttpClient = Nothing)
			Me.o_oO0O_.O0. = Nothing
			Dim state As ConnectionState
			If A_0 IsNot Nothing Then
				state = Me.o0__.Oo0o__O..State
				If A_0 Is Me._Adapter AndAlso Me.o0__.Oo0o__O..State <> ConnectionState.Open Then
					Me.o0__.Oo0o__O..Open()
				End If
			End If
			Dim a_ As Boolean = OO_00oOO.SystemReady
			Try
				OO_00oOO.SystemReady = False
				Me.O.0_0O. = False
				Me.o0_OO.o00OO. = False
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.Name.StartsWith(Me.Name + ".") Then
							table.StopRedraw()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Try
					For Each table2 As Table In OO_00oOO.Tables
						If table2.View.o_o.O0ooOo.() Is Me._DataTable Then
							table2.StopRedraw()
							Dim a_2 As String = table2._frdFilterString
							table2.Filter = "False"
							table2._frdFilterString = a_2
							table2.View.O00o0.0_0O_.(False)
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of Table)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				If A_0 IsNot Nothing Then
					Me.BaseTable.Rows.Clear()
					A_0.Fill(Me._DataTable)
				ElseIf A_1 IsNot Nothing Then
					Dim baseDataTable As DataTable = A_1.GetBaseDataTable()
					Me.BaseTable.Rows.Clear()
					Me.BaseTable.Merge(baseDataTable, False, MissingSchemaAction.Ignore)
					Me.BaseTable.AcceptChanges()
				End If
				If Me._DataTable.Columns.Contains("_SortKey") Then
					Me.FillSortKeyValue()
				End If
				Me.ooO.oO0O0_oo. = False
				Dim flag As Boolean = True
			Catch a_3 As Exception
				ooO.oOo0Oo.o.(a_3, "加载[" + Me.Name + "]失败!")
			Finally
				If A_0 IsNot Nothing AndAlso A_0 Is Me._Adapter AndAlso state <> ConnectionState.Open Then
					Me.o0__.Oo0o__O..Close()
				End If
				Try
					For Each table3 As Table In OO_00oOO.Tables
						If table3.View.o_o.O0ooOo.() Is Me._DataTable Then
							table3.ClearEditInfos()
							table3.View.O00o0.0_0O_.(True)
							table3.ApplyFilter = False
							table3.StateFilter = 0
							table3.ResumeRedraw()
						ElseIf table3.Name.StartsWith(Me.Name + ".") Then
							table3.ResumeRedraw()
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of Table)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
				OO_00oOO.SystemReady = a_
				Dim flag As Boolean
				If flag AndAlso Me._DataTable.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() Then
					Me.O.0_0O. = True
					Me.o0_OO.o00OO. = True
				End If
			End Try
		End Sub

		' Token: 0x0600221B RID: 8731 RVA: 0x000E4BD0 File Offset: 0x000E2DD0
		Friend Sub <<EMPTY_NAME>>()
			Dim loadEventArgs As LoadEventArgs = New LoadEventArgs(Me)
			Dim a_ As String = "AfterLoad"
			O_O0OO.OoO_o.oO0o0O.(Me.o_0_00_.oo0O0., a_, New Object() { loadEventArgs }, False, Me.BaseTable.TableName, False)
			If Not loadEventArgs.Cancel AndAlso OO_00oOO.DataTables(Me.BaseTable.TableName).GlobalHandler.AfterLoad Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { loadEventArgs }, False, "全局表事件", False)
			End If
		End Sub

		' Token: 0x0600221C RID: 8732 RVA: 0x000E4C54 File Offset: 0x000E2E54
		Friend Sub <<EMPTY_NAME>>()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.View.o_o.O0ooOo.() Is Me._DataTable OrElse table.Name.StartsWith(Me.Name + ".") Then
						table.RaiseCurrentChanged()
						table.RaisePositionChanged()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600221D RID: 8733 RVA: 0x000E4CD8 File Offset: 0x000E2ED8
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As OleDbConnection, A_2 As O0O, A_3 As Boolean)
			If Me._DataTable.ChildRelations.Count > 0 OrElse Me._DataTable.ParentRelations.Count > 0 Then
				MessageBox.Show("当前表存在关联，不允许使用此方法加载数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Dim httpClient As HttpClient = Nothing
			Dim a_ As DataServerTypeEnum = DataServerTypeEnum.Access
			Me.DataServer = ""
			Me.UpdateServer = ""
			Me.HttpSelect = ""
			Me.UpdateColumns = Nothing
			Me.o0__.Oo0o__O. = Nothing
			Me.O._O0__. = Nothing
			If A_2 IsNot Nothing Then
				httpClient = A_2.oO0_0.o.()
				a_ = A_2.OO.OoO0.
			ElseIf o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1) Then
				a_ = DataServerTypeEnum.Oracle
			ElseIf o_O_o_oOoo__.OOOO_OO._oo.(A_1) Then
				a_ = DataServerTypeEnum.SqlServer
			End If
			Me.o00o.00oO___0..Clear()
			If httpClient Is Nothing Then
				A_0 = Oo00.o0_o._O_.(A_1, A_0, False)
				Me._Adapter = New OleDbDataAdapter(A_0, A_1)
				Me.o0__.Oo0o__O. = A_1
				If A_3 Then
					Me.o._OOO0oOo0__. = ""
				Else
					o_O_o_oOoo__.OO_O0oO0.oooO_.(Me._Adapter)
					Me.o._OOO0oOo0__. = Oo00.ooO.ooo.(Me._Adapter)
				End If
				Me._Adapter.SelectCommand.CommandTimeout = Me.FillLoadTimeOut
			Else
				A_0 = Oo00.o0_o._O_.(a_, A_0, False)
				Me.DataServer = httpClient.Oo_0oO0Oo0_.O_.
				Me.HttpSelect = A_0
				If A_3 Then
					Me.o._OOO0oOo0__. = ""
				Else
					Me.o._OOO0oOo0__. = Oo00.o.Oo0oO.(A_0)
					Me.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.
				End If
			End If
			Dim form As Form = Nothing
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me AndAlso Not table.IsRelation Then
						form = table.foxGrid.FindForm()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim a_2 As Boolean = OO_00oOO.SystemReady
			If Me.OO._0oo000_00. IsNot Nothing Then
				Me.OO._0oo000_00..ExtendedProperties.Clear()
				Me.OO._0oo000_00. = Nothing
			End If
			Try
				If form IsNot Nothing Then
					ShareLibriay.LockWindowUpdate(form.Handle)
				End If
				OO_00oOO.SystemReady = False
				Me.o0O_ooo__.O0o_.()
				Try
					For Each table2 As Table In OO_00oOO.Tables
						If table2.DataTable Is Me Then
							table2.CloseRecordGrid()
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of Table)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				Try
					For Each table3 As Table In OO_00oOO.Tables
						If table3.DataTable Is Me Then
							table3.StopRedraw()
							table3.Sort = ""
							table3.Filter = ""
							table3.O_O__.ooOo..Clear()
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of Table)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
				Me.BaseTable.Reset()
				Try
					If httpClient Is Nothing Then
						If Not A_3 Then
							Me._Adapter.FillSchema(Me._DataTable, SchemaType.Source)
						End If
						Me._Adapter.Fill(Me._DataTable)
					Else
						If Not A_3 Then
							httpClient.FormData("Action") = 1.ToString()
						Else
							httpClient.FormData("Action") = 2.ToString()
						End If
						httpClient.[Select] = A_0
						Dim baseDataTable As DataTable = httpClient.GetBaseDataTable()
						If baseDataTable IsNot Nothing AndAlso baseDataTable.Columns.Count > 0 Then
							If Not A_3 Then
								Me.UpdateColumns = CType(baseDataTable.ExtendedProperties("UpdateColumns"), List(Of String))
							End If
							Me._DataTable.Reset()
							Me._DataTable.Merge(baseDataTable, False, MissingSchemaAction.AddWithKey)
							baseDataTable.Dispose()
						End If
					End If
				Catch ex As Exception
					MessageBox.Show("Select语句执行错误，请检查语法及数据源设置。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me._DataTable.Reset()
					Dim text As String = "一二三四五六七八九十"
					Dim num As Integer = 0
					Do
						Me._DataTable.Columns.Add("第" + Conversions.ToString(text(num)) + "列", GetType(String))
						num += 1
					Loop While num <= 9
					Me._DataTable.AcceptChanges()
					Me.o0__.Oo0o__O. = Nothing
				End Try
				If Not Me._DataTable.Columns.Contains("_Locked") Then
					Me._DataTable.Columns.Add("_Locked", GetType(Boolean))
					Me.O000_00._0_o. = False
				Else
					Me.O000_00._0_o. = True
				End If
				If Me._DataTable.PrimaryKey.Length = 1 AndAlso Me._DataTable.PrimaryKey(0).AutoIncrement Then
					Me._DataTable.PrimaryKey(0).[ReadOnly] = False
					Me.O_.__0. = Me._DataTable.PrimaryKey(0).ColumnName
				End If
				If Me._DataTable.Columns.Contains("_SortKey") Then
					Me.FillSortKeyValue()
				End If
				If Me.o0__.Oo0o__O. Is O_O0OO.OoO.0OO__0ooo.() AndAlso Me._DataTable.PrimaryKey.Length = 1 AndAlso Operators.CompareString(Me._DataTable.PrimaryKey(0).ColumnName, "_Identify", True) = 0 Then
					Me._DataTable.Columns("_Identify").AutoIncrement = True
					Me._DataTable.Columns("_Identify").AutoIncrementStep = 1L
					Me._DataTable.Columns("_Identify").AutoIncrementSeed = 1L
					If Me._DataTable.Rows.Count > 0 AndAlso Me._DataTable.Rows.Count > 0 Then
						Me._DataTable.Columns("_Identify").AutoIncrementSeed = CLng((Conversions.ToInteger(Me._DataTable.Compute("Max([_Identify])", "")) + 1))
					End If
				End If
				Me._DataTable.Columns.Add("System_Sort_Temporary", GetType(Double))
				Me._DataTable.Columns.Add("System_Filter_Temporary", GetType(Integer))
				Me._DataTable.Columns.Add("System_Filter_Unique", GetType(Integer))
				Me.o_oO0O_.O0. = Nothing
				Me.o.0O000_.()
				Try
					For Each table4 As Table In OO_00oOO.Tables
						If table4.View.o_o.O0ooOo.() Is Me.BaseTable Then
							table4.View.oO0o0_.OoO_.("")
							table4.View.set_Filter("True")
							table4.View.set_Filter("")
							table4.Cols.Reset()
							table4.oO_o_0o._0oooo.(True)
						End If
					Next
				Finally
					Dim enumerator4 As IEnumerator(Of Table)
					If enumerator4 IsNot Nothing Then
						enumerator4.Dispose()
					End If
				End Try
				OO_00oOO.SystemReady = a_2
				Try
					For Each table5 As Table In OO_00oOO.Tables
						If table5.DataTable Is Me Then
							table5.ResumeRedraw()
							table5.RaiseCurrentChanged()
							table5.RaisePositionChanged()
						End If
					Next
				Finally
					Dim enumerator5 As IEnumerator(Of Table)
					If enumerator5 IsNot Nothing Then
						enumerator5.Dispose()
					End If
				End Try
				If A_3 Then
					Me.AllowEdit = False
				End If
				Me.ooO.oO0O0_oo. = False
			Catch a_3 As Exception
				ooO.oOo0Oo.o.(a_3, "")
			Finally
				If form IsNot Nothing Then
					ShareLibriay.LockWindowUpdate(IntPtr.Zero)
				End If
				OO_00oOO.SystemReady = a_2
			End Try
		End Sub

		' Token: 0x0600221E RID: 8734 RVA: 0x000E54D4 File Offset: 0x000E36D4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Fill(ParamArray args As Object())
			If args.Length = 2 Then
				Me.Fill(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)))
				Return
			End If
			If args.Length = 3 Then
				Me.Fill(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToBoolean(args(2)))
			End If
		End Sub

		' Token: 0x0600221F RID: 8735 RVA: 0x000E5524 File Offset: 0x000E3724
		<oO0oooo("1929")>
		Public Sub Fill(selectString As String, connName As String, isQuery As Boolean)
			If Operators.CompareString(connName, "", True) = 0 Then
				Me.o0O.O_0.(selectString, O_O0OO.OoO.0OO__0ooo.(), Nothing, isQuery)
				Return
			End If
			Dim oleDbConnection As OleDbConnection = Nothing
			Dim o0O As O0O = Nothing
			If Operators.CompareString(connName, "", True) = 0 Then
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
			ElseIf O_O0OO.O._o_.().ContainsKey(connName) Then
				oleDbConnection = O_O0OO.O._o_.()(connName)
			ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(connName) Then
				o0O = O_O0OO.OoO__.0oO0oo.()(connName)
			End If
			If oleDbConnection Is Nothing AndAlso o0O Is Nothing Then
				MessageBox.Show("不存在名为""" + connName + """的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return
			End If
			Me.o0O.O_0.(selectString, oleDbConnection, o0O, isQuery)
			Me.ConnectionName = connName
		End Sub

		' Token: 0x06002220 RID: 8736 RVA: 0x000E55D2 File Offset: 0x000E37D2
		<oO0oooo("1929")>
		Public Sub Fill(SelectString As String, isQuery As Boolean)
			Me.o0O.O_0.(SelectString, O_O0OO.OoO.0OO__0ooo.(), Nothing, isQuery)
		End Sub

		' Token: 0x06002221 RID: 8737 RVA: 0x000E55E4 File Offset: 0x000E37E4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function NewRow() As DataRow
			Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me, Nothing)
			Dim a_ As String = "BeforeAddDataRow"
			O_O0OO.OoO_o.oO0o0O.(Me.o_0_00_.oo0O0., a_, New Object() { dataRowEventArgs }, False, Me.Name, False)
			If Not dataRowEventArgs.Cancel AndAlso Me.GlobalHandler.BeforeAddDataRow Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { dataRowEventArgs }, False, "全局表事件", False)
			End If
			Dim result As DataRow
			If dataRowEventArgs.Cancel Then
				result = Nothing
			Else
				result = New DataRow(Me._DataTable.NewRow())
			End If
			Return result
		End Function

		' Token: 0x06002222 RID: 8738 RVA: 0x000E566E File Offset: 0x000E386E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddRow(Row As DataRow)
			Me._DataTable.Rows.Add(Row.BaseRow)
		End Sub

		' Token: 0x06002223 RID: 8739 RVA: 0x000E5688 File Offset: 0x000E3888
		<oO0oooo("0421")>
		Public Function AddNew(Optional Count As Integer = 1) As DataRow
			Dim dataRow As DataRow = Nothing
			Dim list As List(Of Table) = New List(Of Table)()
			If Count > 5 Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me Then
							table.foxGrid.BeginUpdate()
							list.Add(table)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			For i As Integer = 1 To Count
				Dim dataRow2 As DataRow = Me.NewRow()
				If dataRow2 Is Nothing Then
					Exit For
				End If
				Me._DataTable.Rows.Add(dataRow2.BaseRow)
				If dataRow Is Nothing Then
					dataRow = dataRow2
				End If
			Next
			Try
				For Each table2 As Table In OO_00oOO.Tables
					If table2.View.o_o.O0ooOo.() Is Me._DataTable Then
						Dim o_oOooO_O As O_oOooO_O = table2.foxGrid
						If o_oOooO_O.Row < o_oOooO_O.Rows.Fixed And o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed Then
							o_oOooO_O.Row = o_oOooO_O.Rows.Fixed
							table2.View.o_._0O0o_OoO.()
							table2.View.Oo._Oo0OO.()
						End If
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of Table)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
			Try
				For Each table3 As Table In list
					table3.foxGrid.EndUpdate()
				Next
			Finally
				Dim enumerator3 As List(Of Table).Enumerator
				CType(enumerator3, IDisposable).Dispose()
			End Try
			Return dataRow
		End Function

		' Token: 0x06002224 RID: 8740 RVA: 0x000E5834 File Offset: 0x000E3A34
		<oO0oooo("0396")>
		Public Function Find(Filter As String, Optional Sort As String = "", Optional Index As Integer = 0) As DataRow
			Dim obj As Object = Me._DataTable
			Dim array As DataRow()
			SyncLock obj
				array = Me._DataTable.[Select](Filter, Sort)
			End SyncLock
			Dim result As DataRow
			If array.Length > 0 Then
				If Index > array.Length - 1 OrElse Index < 0 Then
					result = Nothing
				Else
					result = New DataRow(array(Index))
				End If
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06002225 RID: 8741 RVA: 0x000E58A0 File Offset: 0x000E3AA0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function [Select](ParamArray args As Object()) As Object
			Dim list As List(Of DataRow) = Nothing
			Select Case args.Length
				Case 1
					list = Me.[Select](Conversions.ToString(args(0)))
				Case 2
					list = Me.[Select](Conversions.ToString(args(0)), Conversions.ToString(args(1)))
				Case 3
					list = Me.[Select](Conversions.ToString(args(0)), Conversions.ToString(args(1)), CType(Conversions.ToInteger(args(2)), DataViewRowState))
			End Select
			Dim result As Object
			If ooO.o.O_0000_O.() Then
				result = If((list IsNot Nothing), list.ToArray(), New DataRow(-1) {})
			Else
				result = list
			End If
			Return result
		End Function

		' Token: 0x06002226 RID: 8742 RVA: 0x000E5930 File Offset: 0x000E3B30
		<oO0oooo("0400")>
		Public Function [Select](Filter As String) As List(Of DataRow)
			Return Me.[Select](Filter, "", DataViewRowState.CurrentRows)
		End Function

		' Token: 0x06002227 RID: 8743 RVA: 0x000E5940 File Offset: 0x000E3B40
		<oO0oooo("0400")>
		Public Function [Select](Filter As String, Sort As String) As List(Of DataRow)
			Return Me.[Select](Filter, Sort, DataViewRowState.CurrentRows)
		End Function

		' Token: 0x06002228 RID: 8744 RVA: 0x000E594C File Offset: 0x000E3B4C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function [Select](Filter As String, Sort As String, RowState As DataViewRowState) As List(Of DataRow)
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			Dim obj As Object = Me._DataTable
			Dim array As DataRow()
			SyncLock obj
				array = Me._DataTable.[Select](Filter, Sort, RowState)
			End SyncLock
			Dim result As List(Of DataRow)
			If array.Length = 0 Then
				result = list
			Else
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					list.Add(New DataRow(array(i)))
				Next
				result = list
			End If
			Return result
		End Function

		' Token: 0x06002229 RID: 8745 RVA: 0x000E59D0 File Offset: 0x000E3BD0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Compute(ParamArray Args As Object()) As Object
			Dim result As Object
			If Args.Length = 1 Then
				result = Me.Compute(Conversions.ToString(Args(0)))
			ElseIf Args.Length = 2 Then
				result = Me.Compute(Conversions.ToString(Args(0)), Conversions.ToString(Args(1)))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x0600222A RID: 8746 RVA: 0x000E5A16 File Offset: 0x000E3C16
		<oO0oooo("0393")>
		Public Function Compute(Expression As String) As Object
			Return Me.Compute(Expression, "")
		End Function

		' Token: 0x0600222B RID: 8747 RVA: 0x000E5A24 File Offset: 0x000E3C24
		<oO0oooo("0393")>
		Public Function Compute(Expression As String, Filter As String) As Object
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me._DataTable.Compute(Expression, Filter))
			Dim result As Object
			If objectValue Is DBNull.Value Then
				result = Nothing
			Else
				result = objectValue
			End If
			Return result
		End Function

		' Token: 0x0600222C RID: 8748 RVA: 0x000E5A54 File Offset: 0x000E3C54
		<oO0oooo("0401")>
		Public Sub StopRedraw()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.View.o_o.O0ooOo.() Is Me._DataTable Then
						table.StopRedraw()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600222D RID: 8749 RVA: 0x000E5AB4 File Offset: 0x000E3CB4
		<oO0oooo("0402")>
		Public Sub ResumeRedraw()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.View.o_o.O0ooOo.() Is Me._DataTable Then
						table.ResumeRedraw()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600222E RID: 8750 RVA: 0x000E5B14 File Offset: 0x000E3D14
		<oO0oooo("1435")>
		Public Function GetComboListString(ColumnName As String, Optional Filter As String = "", Optional Sort As String = "") As String
			Dim result As String
			If Operators.CompareString(Sort, "", True) = 0 Then
				Dim uniqueValues As List(Of String) = Me.GetUniqueValues(Filter, ColumnName)
				result = String.Join("|", uniqueValues.ToArray())
			Else
				Dim list As List(Of String) = New List(Of String)()
				Dim num As Integer = Me._DataTable.Columns.IndexOf(ColumnName)
				Dim dataView As DataView = New DataView(Me._DataTable, Filter, Sort, DataViewRowState.CurrentRows)
				Dim num2 As Integer = dataView.Count - 1
				For i As Integer = 0 To num2
					If Not dataView(i).Row.IsNull(num) Then
						Dim item As String = dataView(i)(num).ToString()
						If Not list.Contains(item) Then
							list.Add(item)
						End If
					End If
				Next
				result = String.Join("|", list.ToArray())
			End If
			Return result
		End Function

		' Token: 0x0600222F RID: 8751 RVA: 0x000E5BE3 File Offset: 0x000E3DE3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetStrings(ColumnName As String, Optional Filter As String = "", Optional sort As String = "") As String
			Return Me.GetComboListString(ColumnName, Filter, sort)
		End Function

		' Token: 0x06002230 RID: 8752 RVA: 0x000E5BF0 File Offset: 0x000E3DF0
		<oO0oooo("2747")>
		Public Function GetValues(ColumnNames As String, Optional Filter As String = "", Optional Sort As String = "") As Object
			Dim array As String() = ColumnNames.Split(New Char() { "|"c })
			Dim result As Object
			If array.Length = 1 Then
				Dim list As List(Of String) = New List(Of String)()
				list = Oo00.O____0O._0.(Me.BaseTable, Filter, Sort, array(0))
				If ooO.o.O_0000_O.() Then
					result = list.ToArray()
				Else
					result = list
				End If
			Else
				Dim list2 As List(Of String()) = New List(Of String())()
				list2 = Oo00.O____0O._0.(Me.BaseTable, Filter, Sort, array)
				If ooO.o.O_0000_O.() Then
					Dim arrayList As ArrayList = New ArrayList()
					Try
						For Each value As String() In list2
							arrayList.Add(value)
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					result = arrayList
				Else
					result = list2
				End If
			End If
			Return result
		End Function

		' Token: 0x06002231 RID: 8753 RVA: 0x000E5CB4 File Offset: 0x000E3EB4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetUniqueValues(Filter As String, ColumnName As String) As List(Of String)
			Return Oo00.O____0O._0.(Me.BaseTable, Filter, "", ColumnName)
		End Function

		' Token: 0x06002232 RID: 8754 RVA: 0x000E5CC8 File Offset: 0x000E3EC8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetUniqueValues(Filter As String, ParamArray ColumnNames As String()) As List(Of String())
			Return Oo00.O____0O._0.(Me.BaseTable, Filter, "", ColumnNames)
		End Function

		' Token: 0x17000812 RID: 2066
		' (get) Token: 0x06002233 RID: 8755 RVA: 0x000E5CDC File Offset: 0x000E3EDC
		' (set) Token: 0x06002234 RID: 8756 RVA: 0x000E5CE4 File Offset: 0x000E3EE4
		<oO0oooo("1992")>
		Public Property MultiRowHeader As Boolean
			Get
				Return Me.oo._O_o0_O.
			End Get
			Set(value As Boolean)
				Me.oo._O_o0_O. = value
			End Set
		End Property

		' Token: 0x06002235 RID: 8757 RVA: 0x000E5CF0 File Offset: 0x000E3EF0
		<oO0oooo("0394")>
		Public Sub DeleteFor(Filter As String)
			If Me._DataTable.DataSet Is Nothing Then
				Dim obj As Object = Me._DataTable
				Dim array As DataRow()
				SyncLock obj
					array = Me._DataTable.[Select](Filter, "", DataViewRowState.CurrentRows)
				End SyncLock
				For i As Integer = array.Length - 1 To 0 Step -1
					array(i).Delete()
				Next
				Return
			End If
			Dim list As List(Of OoO_O00) = New List(Of OoO_O00)()
			Dim array2 As DataRow() = Me.BaseTable.[Select](Filter, "", DataViewRowState.CurrentRows)
			Try
				Me.StopRedraw()
				Dim list2 As List(Of DataTable) = New List(Of DataTable)()
				Row.OO.OO_0o.(list2, Me.BaseTable)
				If array2.Length > 1 Then
					Try
						For Each dataTable As DataTable In list2
							Try
								For Each table As Table In OO_00oOO.Tables
									If table.View.o_o.O0ooOo.() Is dataTable Then
										list.Add(New OoO_O00(table))
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator(Of Table)
								If enumerator2 IsNot Nothing Then
									enumerator2.Dispose()
								End If
							End Try
						Next
					Finally
						Dim enumerator As List(Of DataTable).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				For Each a_ As DataRow In array2
					New DataRow(a_).Delete()
				Next
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Foxtable.RibbonMenu.StatusBar.Message1 = ""
				Try
					For Each ooO_O As OoO_O00 In list
						ooO_O.O._00000.(Nothing)
					Next
				Finally
					Dim enumerator3 As List(Of OoO_O00).Enumerator
					CType(enumerator3, IDisposable).Dispose()
				End Try
				Me.ResumeRedraw()
			End Try
			Try
				For Each table2 As Table In OO_00oOO.Tables
					If table2.DataTable Is Me Then
						table2.ClearEditInfos()
					End If
				Next
			Finally
				Dim enumerator4 As IEnumerator(Of Table)
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002236 RID: 8758 RVA: 0x000E5F30 File Offset: 0x000E4130
		<oO0oooo("1532")>
		Public Sub ReplaceFor(ColumnName As String, Value As Object, Optional Filter As String = "")
			Dim obj As Object = Me._DataTable
			Dim array As DataRow()
			SyncLock obj
				array = Me.BaseTable.[Select](Filter, "")
			End SyncLock
			Dim array2 As DataRow() = array
			For i As Integer = 0 To array2.Length - 1
				array2(i)(ColumnName) = RuntimeHelpers.GetObjectValue(Value)
			Next
		End Sub

		' Token: 0x06002237 RID: 8759 RVA: 0x000E5FA0 File Offset: 0x000E41A0
		<oO0oooo("0408")>
		Public Sub RemoveFor(Filter As String)
			If Me._DataTable.DataSet Is Nothing Then
				Dim obj As Object = Me._DataTable
				Dim array As DataRow()
				SyncLock obj
					array = Me._DataTable.[Select](Filter, "", DataViewRowState.CurrentRows)
				End SyncLock
				For i As Integer = array.Length - 1 To 0 Step -1
					array(i).RowError = "a"
					Me._DataTable.Rows.Remove(array(i))
				Next
				Return
			End If
			Dim num As Integer = -1
			If O_O0OO.o__.O.()(Me.Name).Position > -1 Then
				o_O_o_oOoo__.OO_O0oO0.oooO_.(O_O0OO.o__.O.()(Me.Name).o_o.O0ooOo.().Row)
			End If
			If O_O0OO.o__.O.()(Me.Name).Count > 0 Then
				num = O_O0OO.o__.O.()(Me.Name).Position
			End If
			If OO_00oOO.Tables(Me.Name).ApplySort Then
				OO_00oOO.Tables(Me.Name).Sort
			End If
			Try
				OO_00oOO.Tables(Me.Name).StopRedraw()
				Dim obj2 As Object = Me._DataTable
				Dim array2 As DataRow()
				SyncLock obj2
					array2 = Me._DataTable.[Select](Filter, OO_00oOO.Tables(Me.Name).Sort, DataViewRowState.CurrentRows)
				End SyncLock
				For j As Integer = array2.Length - 1 To 0 Step -1
					array2(j).RowError = "a"
					Me._DataTable.Rows.Remove(array2(j))
				Next
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				OO_00oOO.Tables(Me.Name).ResumeRedraw()
			End Try
			If num >= 0 AndAlso O_O0OO.o__.O.()(Me.Name).Count > num Then
				O_O0OO.o__.O.()(Me.Name).Position = num
			End If
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me Then
						table.ClearEditInfos()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002238 RID: 8760 RVA: 0x000E6234 File Offset: 0x000E4434
		<oO0oooo("1932")>
		Public Sub ChangeConnection(ConnectionName As String)
			If Me.frd_IsOuterTable OrElse Me.frd_IsOuterQuery Then
				Try
					For Each text As String In O_O0OO.O._o_.().Keys
						If Operators.CompareString(text, ConnectionName, True) = 0 Then
							Dim flag As Boolean = Me.frd_IsOuterTable
							Me.o0__.Oo0o__O. = O_O0OO.O._o_.()(text)
							Me._Adapter = New OleDbDataAdapter(Me._Adapter.SelectCommand.CommandText, Me.o0__.Oo0o__O.)
							If flag Then
								Me.O_00_._.()
							End If
							Me.o._OOO0oOo0__. = Nothing
							Me.o0.o.(True, Nothing)
						End If
					Next
					Return
				Finally
					Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			MessageBox.Show("只有外部数据表和外部查询表才能切换数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06002239 RID: 8761 RVA: 0x000E6304 File Offset: 0x000E4504
		<oO0oooo("2365")>
		Public Sub AcceptChanges()
			Me.BaseTable.AcceptChanges()
		End Sub

		' Token: 0x0600223A RID: 8762 RVA: 0x000E6314 File Offset: 0x000E4514
		<oO0oooo("1538")>
		Public Sub RejectChanges()
			Dim list As List(Of DataColumn) = New List(Of DataColumn)()
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If dataRelation.ParentTable Is Me.BaseTable Then
						For Each item As DataColumn In dataRelation.ParentColumns
							If Not list.Contains(item) Then
								list.Add(item)
							End If
						Next
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each obj2 As Object In Me.BaseTable.Rows
					Dim dataRow As DataRow = CType(obj2, DataRow)
					If dataRow.RowState = DataRowState.Modified Then
						Try
							For Each column As DataColumn In list
								dataRow(column) = RuntimeHelpers.GetObjectValue(dataRow(column, DataRowVersion.Original))
							Next
						Finally
							Dim enumerator3 As List(Of DataColumn).Enumerator
							CType(enumerator3, IDisposable).Dispose()
						End Try
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Me.BaseTable.RejectChanges()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me Then
						table.ClearEditInfos()
					End If
					If table.o00oOO00_.ooOo. IsNot Nothing AndAlso table.o00oOO00_.ooOo..FindForm() IsNot Nothing Then
						table.o00oOO00_.ooOo..Oo0o__.OO0o__O.()
					End If
				Next
			Finally
				Dim enumerator4 As IEnumerator(Of Table)
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
			End Try
			If O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.BaseTable.TableName) Then
				OO_00oOO.Tables(Me.BaseTable.TableName).RefreshChildTables()
			End If
		End Sub

		' Token: 0x17000813 RID: 2067
		' (get) Token: 0x0600223B RID: 8763 RVA: 0x000E6510 File Offset: 0x000E4710
		<oO0oooo("0671")>
		Public ReadOnly Property GlobalHandler As GlobalEvents
			Get
				Return Me.o_0_00_.oo0O0.
			End Get
		End Property

		' Token: 0x0600223C RID: 8764 RVA: 0x000E6518 File Offset: 0x000E4718
		Private Function <<EMPTY_NAME>>() As String
			Dim result As String
			If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
				result = Me.o._OOO0oOo0__.
			Else
				result = "[" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
			End If
			Return result
		End Function

		' Token: 0x0600223D RID: 8765 RVA: 0x000E6568 File Offset: 0x000E4768
		Friend Sub <<EMPTY_NAME>>()
			If(Me.frd_IsInnerTable OrElse Me.frd_IsOuterTable) AndAlso Not Me.BaseTable.Columns.Contains("_SortKey") Then
				Dim a_ As Type = Nothing
				If Me.BaseTable.PrimaryKey.Length = 1 Then
					a_ = Me.BaseTable.PrimaryKey(0).DataType
				End If
				Dim text As String = Me.o.o00O.()
				If o_O_o_oOoo__.OO_.O.(a_) Then
					If Operators.CompareString(Me.UpdateServer, "", True) = 0 Then
						Dim oleDbCommand As OleDbCommand = New OleDbCommand("", Me.frd_Connection)
						oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
						If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
							oleDbCommand.CommandText = "Alter Table " + text + " ADD ""_SortKey"" Number(28,14)"
						Else
							oleDbCommand.CommandText = "Alter Table " + text + " ADD [_SortKey] Decimal(28,14)"
						End If
						Me.frd_Connection.Open()
						oleDbCommand.ExecuteNonQuery()
						oleDbCommand.CommandText = String.Concat(New String() { "UPDATE ", text, " Set [_SortKey]  = [", Me.BaseTable.PrimaryKey(0).ColumnName, "]" })
						If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
							oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", """").Replace("]", """")
						End If
						oleDbCommand.ExecuteNonQuery()
						Me.frd_Connection.Close()
						Return
					End If
					Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					httpClient.[Select] = "Alter Table " + text + " ADD [_SortKey] Decimal(28,14)"
					httpClient.FormData.Add("Action", 7.ToString())
					httpClient.GetData()
					httpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					httpClient.[Select] = String.Concat(New String() { "UPDATE ", text, " Set [_SortKey]  = [", Me.BaseTable.PrimaryKey(0).ColumnName, "]" })
					httpClient.FormData.Add("Action", 7.ToString())
					httpClient.GetData()
					Return
				Else
					MessageBox.Show("主键列必须是数值型，才可以添加排序标志列。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x0600223E RID: 8766 RVA: 0x000E67CC File Offset: 0x000E49CC
		Friend Sub <<EMPTY_NAME>>()
			If(Me.frd_IsInnerTable OrElse Me.frd_IsOuterTable) AndAlso Operators.CompareString(Me.O_.__0., "", True) > 0 AndAlso Me.BaseTable.Columns.Contains("_SortKey") Then
				Dim str As String = Me.o.o00O.()
				Dim text As String = "Alter Table " + str + " Drop COLUMN [_SortKey]"
				If Operators.CompareString(Me.UpdateServer, "", True) = 0 Then
					Dim oleDbCommand As OleDbCommand = New OleDbCommand("", Me.frd_Connection)
					oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
					oleDbCommand.CommandText = text
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
						oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", """").Replace("]", """")
					End If
					Me.frd_Connection.Open()
					oleDbCommand.ExecuteNonQuery()
					Me.frd_Connection.Close()
					Return
				End If
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				httpClient.[Select] = text
				httpClient.FormData.Add("Action", 7.ToString())
				httpClient.GetData()
			End If
		End Sub

		' Token: 0x0600223F RID: 8767 RVA: 0x000E690C File Offset: 0x000E4B0C
		Friend Sub <<EMPTY_NAME>>()
			If(Me.frd_IsInnerTable OrElse Me.frd_IsOuterTable) AndAlso Not Me.O000_00._0_o. Then
				Dim str As String = Me.o.o00O.()
				Dim text As String
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
					text = "Alter Table " + str + " ADD ""_Locked"" NUMBER(1,0)"
				Else
					text = "Alter Table " + str + " ADD [_Locked] bit"
				End If
				If Operators.CompareString(Me.UpdateServer, "", True) = 0 Then
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, Me.frd_Connection)
					oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
					Me.frd_Connection.Open()
					oleDbCommand.ExecuteNonQuery()
					Me.frd_Connection.Close()
					Return
				End If
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				httpClient.[Select] = text
				httpClient.FormData.Add("Action", 7.ToString())
				httpClient.GetData()
			End If
		End Sub

		' Token: 0x06002240 RID: 8768 RVA: 0x000E6A04 File Offset: 0x000E4C04
		Friend Sub <<EMPTY_NAME>>()
			If Me.frd_IsInnerTable OrElse Me.frd_IsOuterTable Then
				Dim str As String = Me.o.o00O.()
				Dim text As String = "Alter Table " + str + " Drop COLUMN [_Locked]"
				If Me.O000_00._0_o. Then
					If Operators.CompareString(Me.UpdateServer, "", True) = 0 Then
						Dim oleDbCommand As OleDbCommand = New OleDbCommand("", Me.frd_Connection)
						oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
						oleDbCommand.CommandText = text
						If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
							oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", """").Replace("]", """")
						End If
						Me.frd_Connection.Open()
						oleDbCommand.ExecuteNonQuery()
						Me.frd_Connection.Close()
						Return
					End If
					Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					httpClient.[Select] = text
					httpClient.FormData.Add("Action", 7.ToString())
					httpClient.GetData()
				End If
			End If
		End Sub

		' Token: 0x06002241 RID: 8769 RVA: 0x000E6B1B File Offset: 0x000E4D1B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub FillSortKeyValue()
			Me.o0O.O_0.(Nothing)
		End Sub

		' Token: 0x06002242 RID: 8770 RVA: 0x000E6B24 File Offset: 0x000E4D24
		Private Sub <<EMPTY_NAME>>(A_0 As HttpClient)
			If Me.BaseTable.PrimaryKey.Length = 1 AndAlso o_O_o_oOoo__.OO_.O.(Me.BaseTable.PrimaryKey(0).DataType) Then
				Dim columnName As String = Me.BaseTable.PrimaryKey(0).ColumnName
				Dim obj As Object = Me._DataTable
				Dim array As DataRow()
				SyncLock obj
					array = Me._DataTable.[Select]("[_SortKey] Is Null")
				End SyncLock
				If array.Length > 0 Then
					For Each dataRow As DataRow In array
						dataRow("_SortKey") = RuntimeHelpers.GetObjectValue(dataRow(columnName))
					Next
					If Operators.CompareString(Me.UpdateServer, "", True) > 0 AndAlso A_0 Is Nothing Then
						A_0 = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					End If
					Dim text As String = Me.o.o00O.()
					Dim text2 As String = String.Concat(New String() { "UPDATE ", text, " Set [_SortKey]  = [", columnName, "] Where [_SortKey] Is Null" })
					If A_0 Is Nothing Then
						If Me._Adapter IsNot Nothing AndAlso Me._Adapter.UpdateCommand IsNot Nothing Then
							Dim oleDbCommand As OleDbCommand = New OleDbCommand("", Me.frd_Connection)
							oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
							oleDbCommand.CommandText = text2
							If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
								oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", """").Replace("]", """")
							End If
							Dim state As ConnectionState = Me.frd_Connection.State
							If state <> ConnectionState.Open Then
								Me.frd_Connection.Open()
							End If
							oleDbCommand.ExecuteNonQuery()
							If state <> ConnectionState.Open Then
								Me.frd_Connection.Close()
							End If
						End If
					Else
						Dim httpClient As HttpClient = A_0.o0.o0_o.()
						httpClient.[Select] = text2
						httpClient.FormData("Action") = 7.ToString()
						httpClient.GetData()
					End If
					Me._DataTable.AcceptChanges()
				End If
				If Me._DataTable.Rows.Count > 0 Then
					Me.OO00.oO_. = Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me._DataTable.Compute("Max([_SortKey])", ""))), 1D)
					Return
				End If
				Me.OO00.oO_. = 1D
			End If
		End Sub

		' Token: 0x06002243 RID: 8771 RVA: 0x000E6D9C File Offset: 0x000E4F9C
		<oO0oooo("1275")>
		Public Sub BuildHeader()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me Then
						table.BuildHeader()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002244 RID: 8772 RVA: 0x000E6DF0 File Offset: 0x000E4FF0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Refresh()
			Me.o_oO0O_.O0. = Nothing
		End Sub

		' Token: 0x17000814 RID: 2068
		' (get) Token: 0x06002245 RID: 8773 RVA: 0x000E6DF9 File Offset: 0x000E4FF9
		' (set) Token: 0x06002246 RID: 8774 RVA: 0x000E6E01 File Offset: 0x000E5001
		Public Property FillLoadTimeOut As Integer
			Get
				Return Me.O.oo.
			End Get
			Set(value As Integer)
				Me.O.oo. = value
				Me._Adapter.SelectCommand.CommandTimeout = value
			End Set
		End Property

		' Token: 0x06002247 RID: 8775 RVA: 0x000E6E1C File Offset: 0x000E501C
		Friend Sub <<EMPTY_NAME>>()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me Then
						Dim o_oOooO_O As O_oOooO_O = table.foxGrid
						Dim fixed As Integer = o_oOooO_O.Cols.Fixed
						Dim num As Integer = o_oOooO_O.Cols.Count - 1
						For i As Integer = fixed To num
							If o_oOooO_O.Cols(i).Editor IsNot Nothing AndAlso TypeOf o_oOooO_O.Cols(i).Editor Is OooO00O Then
								Dim oooO00O As OooO00O = CType(o_oOooO_O.Cols(i).Editor, OooO00O)
								If oooO00O.DropDownForm IsNot Nothing Then
									oooO00O.DropDownForm.Controls.Clear()
								End If
							End If
						Next
						Try
							For Each col As Col In table.Cols
								col.CloseWindow()
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Col)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002248 RID: 8776 RVA: 0x000E6F48 File Offset: 0x000E5148
		<oO0oooo("2276")>
		Public Function AppendLoad(Filter As String, Optional SaveData As Boolean = True) As List(Of DataRow)
			Return Me.o0O.O_0.(Filter, SaveData, Nothing)
		End Function

		' Token: 0x06002249 RID: 8777 RVA: 0x000E6F54 File Offset: 0x000E5154
		Friend Function <<EMPTY_NAME>>(A_0 As String, Optional A_1 As Boolean = True, Optional A_2 As OleDbDataAdapter = Nothing) As List(Of DataRow)
			Dim oo_O.o. As Object = Main.OO_O.o.
			SyncLock oo_O.o.
				While O_O0OO.O_O00OOooo.O_.
					Thread.Sleep(1)
				End While
				O_O0OO.O_O00OOooo.O_. = True
				Me.o00o.00oO___0. = True
			End SyncLock
			Dim result As List(Of DataRow)
			Try
				Dim text As String
				If Operators.CompareString(Me.DataServer, "", True) = 0 Then
					If A_2 Is Nothing Then
						A_2 = New OleDbDataAdapter(Me._Adapter.SelectCommand.CommandText, Me._Adapter.SelectCommand.Connection)
					End If
					If Operators.CompareString(A_0.Trim(), "", True) = 0 Then
						MessageBox.Show("AppendLoad的条件不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return New List(Of DataRow)()
					End If
					If Not Me.frd_IsInnerTable AndAlso Not Me.frd_IsOuterTable Then
						MessageBox.Show("查询表或临时表不能执行AppendLoad!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return New List(Of DataRow)()
					End If
					text = Me._Adapter.SelectCommand.CommandText
				Else
					text = Me.HttpSelect
				End If
				Dim array As String() = text.Split(New Char() { " "c, vbLf, vbCr, vbTab }, StringSplitOptions.RemoveEmptyEntries)
				text = ""
				For Each text2 As String In array
					If Operators.CompareString(text2.ToLower(), "from", True) = 0 Then
						Exit For
					End If
					text = text + text2 + " "
				Next
				Dim dataServerTypeEnum As DataServerTypeEnum = DataServerTypeEnum.Access
				If Operators.CompareString(Me.DataServer, "", True) > 0 Then
					dataServerTypeEnum = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).OO.OoO0.
				ElseIf o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection) Then
					dataServerTypeEnum = DataServerTypeEnum.Oracle
				ElseIf o_O_o_oOoo__.OOOO_OO._oo.(Me.frd_Connection) Then
					dataServerTypeEnum = DataServerTypeEnum.SqlServer
				End If
				Dim text3 As String
				If Operators.CompareString(Me.o._OOO0oOo0__., "", True) > 0 Then
					If dataServerTypeEnum = DataServerTypeEnum.Oracle Then
						text3 = Me.o._OOO0oOo0__.
					Else
						text3 = "[" + Me.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
					End If
				ElseIf Operators.CompareString(Me.DataServer, "", True) = 0 Then
					text3 = Oo00.o.Oo0oO.(Me.frd_SelectCommandString)
				Else
					text3 = Oo00.o.Oo0oO.(Me.HttpSelect)
				End If
				A_0 = Oo00.o0_o._O_.(Me.o0__.Oo0o__O., A_0, False)
				If Operators.CompareString(Me.DataServer, "", True) = 0 Then
					If A_2 Is Nothing Then
						New OleDbDataAdapter(String.Concat(New String() { text, " From ", text3, " Where ", A_0 }), Me.frd_Connection)
					Else
						A_2.SelectCommand.CommandText = String.Concat(New String() { text, " From ", text3, " Where ", A_0 })
					End If
					result = Me.o0O.O_0.(A_1, A_2)
				Else
					result = Me.o0O.O_0.(A_1, String.Concat(New String() { text, " From ", text3, " Where ", A_0 }))
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				result = New List(Of DataRow)()
			Finally
				O_O0OO.O_O00OOooo.O_. = False
				Me.o00o.00oO___0. = False
			End Try
			Return result
		End Function

		' Token: 0x0600224A RID: 8778 RVA: 0x000E72D0 File Offset: 0x000E54D0
		Private Function <<EMPTY_NAME>>(A_0 As Boolean, A_1 As String) As List(Of DataRow)
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			If A_0 AndAlso Operators.CompareString(Me.UpdateServer, "", True) > 0 Then
				If Not Me.o.o_O.() Then
					Return list
				End If
				If Not Me.O0o0.O_0_.() Then
					Return list
				End If
			End If
			Dim a_ As Boolean = OO_00oOO.SystemReady
			Try
				Dim count As Integer = Me.BaseTable.Rows.Count
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				httpClient.FormData.Add("IgnoreSchema", "True")
				httpClient.[Select] = A_1
				httpClient.FormData("Action") = 2.ToString()
				Dim baseDataTable As DataTable = httpClient.GetBaseDataTable()
				Me.StopRedraw()
				OO_00oOO.SystemReady = False
				Me.O.0_0O. = False
				Try
					For Each obj As Object In baseDataTable.Rows
						Dim row As DataRow = CType(obj, DataRow)
						Me.BaseTable.ImportRow(row)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim num As Integer = count
				Dim num2 As Integer = Me.BaseTable.Rows.Count - 1
				For i As Integer = num To num2
					list.Add(New DataRow(Me.BaseTable.Rows(i)))
					Me.BaseTable.Rows(i).AcceptChanges()
				Next
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Me.o_oO0O_.O0. = Nothing
				OO_00oOO.SystemReady = a_
				Me.ResumeRedraw()
			End Try
			If list.Count > 0 Then
				If Me._DataTable.Columns.Contains("_SortKey") Then
					Me.FillSortKeyValue()
				End If
				Me.O.0_0O. = True
			End If
			Return list
		End Function

		' Token: 0x0600224B RID: 8779 RVA: 0x000E74E8 File Offset: 0x000E56E8
		Private Function <<EMPTY_NAME>>(A_0 As Boolean, A_1 As OleDbDataAdapter) As List(Of DataRow)
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			Dim result As List(Of DataRow)
			If A_0 AndAlso Not Me.oO.o_0.(False, True) Then
				result = list
			Else
				Dim a_ As Boolean = OO_00oOO.SystemReady
				Try
					Dim dataTable As DataTable = New DataTable()
					Dim count As Integer = Me.BaseTable.Rows.Count
					A_1.Fill(dataTable)
					Me.StopRedraw()
					OO_00oOO.SystemReady = False
					Me.O.0_0O. = False
					Try
						For Each obj As Object In dataTable.Rows
							Dim row As DataRow = CType(obj, DataRow)
							Me.BaseTable.ImportRow(row)
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Dim num As Integer = count
					Dim num2 As Integer = Me.BaseTable.Rows.Count - 1
					For i As Integer = num To num2
						list.Add(New DataRow(Me.BaseTable.Rows(i)))
						Me.BaseTable.Rows(i).AcceptChanges()
					Next
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "")
				Finally
					Me.o_oO0O_.O0. = Nothing
					OO_00oOO.SystemReady = a_
					Me.ResumeRedraw()
				End Try
				If list.Count > 0 Then
					If Me._DataTable.Columns.Contains("_SortKey") Then
						Me.FillSortKeyValue()
					End If
					Me.O.0_0O. = True
				End If
				result = list
			End If
			Return result
		End Function

		' Token: 0x17000815 RID: 2069
		' (get) Token: 0x0600224C RID: 8780 RVA: 0x000E7678 File Offset: 0x000E5878
		' (set) Token: 0x0600224D RID: 8781 RVA: 0x000E7680 File Offset: 0x000E5880
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Developer As String
			Get
				Return Me.O.___oo_0OoO.
			End Get
			Set(value As String)
				Me.O.___oo_0OoO. = value
			End Set
		End Property

		' Token: 0x0600224E RID: 8782 RVA: 0x000E7689 File Offset: 0x000E5889
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Dispose()
			Me._DataTable = Nothing
			Me._Adapter = Nothing
			Me.o.O0O_0__OOo_. = Nothing
			Me.o_oO0O_.O0. = Nothing
			Me.o0__.Oo0o__O. = Nothing
		End Sub

		' Token: 0x0600224F RID: 8783 RVA: 0x000E76B0 File Offset: 0x000E58B0
		Private Sub a()
			If Operators.CompareString(Me.a, O_O0OO.O_O._Oo.(), True) <> 0 Then
				Me.a = O_O0OO.O_O._Oo.()
				If Not O_O0OO.O0_00o.o0__o..PropertyIsValid Then
					Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.())
					Dim str As String = Guid.NewGuid().ToString().Substring(0, 6)
					If dataTable.Rows.Count = 0 Then
						Oo00.o_o_oo.0o.()
					End If
					Dim num As Integer = dataTable.Rows.Count - 1
					For i As Integer = 0 To num
						Dim dataRow As DataRow = dataTable.Rows(i)
						If Conversions.ToInteger(dataRow("Type")) = 4 Then
							dataRow("Type") = 2
						End If
						dataRow("Name") = str + Conversions.ToString(i)
						Dim userProperty As UserProperty = New UserProperty()
						o_O_o_oOoo__.OOOO_OO._oo.(userProperty, Conversions.ToString(dataRow("Config")), vbVerticalTab)
						userProperty.PassWord = O00.ooo000o_0.00o0.(userProperty.PassWord, ooO0__OO.O_Oo00oO.Ooo.(), ooO0__OO.O_Oo00oO.Ooo.())
						dataRow("Config") = o_O_o_oOoo__.OOOO_OO._oo.(userProperty, False, vbVerticalTab, False)
					Next
					Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.o.0_O_O. })
					If dataRow2 IsNot Nothing Then
						dataRow2.Delete()
					End If
					O_O0OO.O0_00o.o0__o..HasUsers = True
					Oo00.o0_o._O_.(dataTable, True)
					O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
				End If
			End If
		End Sub

		' Token: 0x06002250 RID: 8784 RVA: 0x000E7854 File Offset: 0x000E5A54
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If OO_00oOO.User.Type Is Nothing Then
				result = True
			ElseIf Operators.CompareString(Me.Developer, "", True) > 0 AndAlso Operators.CompareString(Me.Developer, OO_00oOO.User.Name, True) <> 0 Then
				MessageBox.Show("此表的责任设计者为""" + Me.Developer + """, 请不要越权设计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x17000816 RID: 2070
		' (get) Token: 0x06002251 RID: 8785 RVA: 0x000E78C8 File Offset: 0x000E5AC8
		' (set) Token: 0x06002252 RID: 8786 RVA: 0x000E794F File Offset: 0x000E5B4F
		Friend Property CannBackEndFilter As Boolean
			Get
				Return Operators.CompareString(Me.LoadTop, "", True) > 0 AndAlso Versioned.IsNumeric(Me.LoadTop) AndAlso (Me.BaseTable.PrimaryKey.Length = 1 OrElse Operators.CompareString(Me.LoadOver, "", True) > 0 OrElse Me.BaseTable.Columns.Contains("_SortKey") OrElse Me.BaseTable.Columns.Contains("_Identify"))
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000817 RID: 2071
		' (get) Token: 0x06002253 RID: 8787 RVA: 0x000E7954 File Offset: 0x000E5B54
		' (set) Token: 0x06002254 RID: 8788 RVA: 0x000E7975 File Offset: 0x000E5B75
		<oO0oooo("2892")>
		Public Property AllowBackEndFilter As Boolean
			Get
				Return Me.CannBackEndFilter AndAlso Me.o0OOOo_.0_o_0o.
			End Get
			Set(value As Boolean)
				Me.o0OOOo_.0_o_0o. = value
			End Set
		End Property

		' Token: 0x17000818 RID: 2072
		' (get) Token: 0x06002255 RID: 8789 RVA: 0x000E797E File Offset: 0x000E5B7E
		<oO0oooo("2892")>
		Public ReadOnly Property InBackEndFilterMode As Boolean
			Get
				Return Operators.CompareString(Me.OOOOO._., Me.LoadFilter, True) <> 0
			End Get
		End Property

		' Token: 0x06002256 RID: 8790 RVA: 0x000E7998 File Offset: 0x000E5B98
		Friend Sub <<EMPTY_NAME>>()
			If Me.InBackEndFilterMode Then
				Me.o00o.00oO___0..Clear()
				Me.LoadFilter = Me.OOOOO._.
				Me.LoadPage = 0
				Me.o0.o.(True, Nothing)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me AndAlso table.O.OoOo_. IsNot Nothing AndAlso table.O.OoOo_..FindForm() IsNot Nothing Then
							table.O.OoOo_..oO.Oo0__O_.()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06002257 RID: 8791 RVA: 0x000E7A34 File Offset: 0x000E5C34
		Friend Sub <<EMPTY_NAME>>()
			' The following expression was wrapped in a checked-statement
			If Operators.CompareString(Me.LoadFilter, Me.OOOOO._., True) = 0 Then
				If Me.o00o.00oO___0..Count <= 0 Then
					GoTo IL_20C
				End If
				Dim array As String() = Me.o00o.00oO___0..ToArray()
				Me.o00o.00oO___0..Clear()
				Try
					OO_00oOO.LockBaseMainForm()
					Dim array2 As String() = array
					For i As Integer = 0 To array2.Length - 1
						Dim array3 As String() = array2(i).Split(New Char() { vbVerticalTab })
						Dim left As String = array3(0)
						If Operators.CompareString(left, "RelationFilter3", True) = 0 Then
							If OO_00oOO.DataTables.Contains(array3(2)) Then
								Dim a_ As String = array3(1)
								Dim a_2 As DataTable = OO_00oOO.DataTables(array3(2))
								Dim a_3 As String = array3(3)
								Dim a_4 As Boolean = Conversions.ToBoolean(array3(4))
								OO_00oOO.Tables(Me.Name).o0O0oo.o.(a_, a_2, a_3, a_4)
							End If
						ElseIf Operators.CompareString(left, "ShowBackSameValues", True) = 0 Then
							Dim a_5 As String = array3(1)
							Dim a_6 As Integer = Conversions.ToInteger(array3(2))
							OO_00oOO.Tables(Me.Name).o_0_O__o0O.oo.(a_5, a_6)
						ElseIf Operators.CompareString(left, "BackSameValuesFilter", True) = 0 Then
							Dim a_7 As String = array3(1)
							Dim a_8 As String = array3(2)
							OO_00oOO.Tables(Me.Name).O____o.0.(a_7, a_8)
						ElseIf Operators.CompareString(left, "FilterDateBetween", True) = 0 Then
							Dim a_9 As Table = OO_00oOO.Tables(array3(1))
							Dim a_10 As String = array3(2)
							Dim a_11 As DateTime = Conversions.ToDate(array3(3))
							Dim a_12 As DateTime = Conversions.ToDate(array3(4))
							Dim a_13 As Boolean = Conversions.ToBoolean(array3(5))
							Filter.O0O0o.Oo0OO_oO.(a_9, a_10, a_11, a_12, a_13)
						ElseIf Operators.CompareString(left, "FilterByExpression", True) = 0 Then
							Dim a_14 As Table = OO_00oOO.Tables(array3(1))
							Dim a_15 As String = array3(2)
							Dim a_16 As Boolean = Conversions.ToBoolean(array3(3))
							Filter.O0O0o.Oo0OO_oO.(a_14, a_15, a_16)
						End If
					Next
					GoTo IL_20C
				Catch a_17 As Exception
					ooO.oOo0Oo.o.(a_17, "")
					GoTo IL_20C
				Finally
					OO_00oOO.UnlockBaseMainForm()
				End Try
			End If
			Me.LoadFilter3 = Me.OOOOO._.
			Me.LoadPage = 0
			Me.o0.o.(True, Nothing)
			IL_20C:
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me AndAlso table.O.OoOo_. IsNot Nothing AndAlso table.O.OoOo_..FindForm() IsNot Nothing Then
						table.O.OoOo_..oO.Oo0__O_.()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002258 RID: 8792 RVA: 0x000E7CF8 File Offset: 0x000E5EF8
		<oO0oooo("2894")>
		Public Sub LoadChildren(ChildName As String)
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If dataRelation.ParentTable Is Me.BaseTable AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, ChildName, True) = 0 Then
						Dim dataTable As DataTable = OO_00oOO.DataTables(ChildName)
						If(Me.frd_Connection IsNot Nothing AndAlso dataTable.frd_Connection Is Me.frd_Connection) OrElse (Operators.CompareString(Me.DataServer, "", True) > 0 AndAlso Operators.CompareString(Me.DataServer, OO_00oOO.DataTables(dataRelation.ChildTable.TableName).DataServer, True) = 0) Then
							If dataRelation.ParentColumns.Length = 1 Then
								Dim text As String = dataRelation.ChildColumns(0).ColumnName
								Dim text2 As String = dataRelation.ParentColumns(0).ColumnName
								text = Oo00.OoOo_oo_.o_o.(text, OO_00oOO.DataTables(dataRelation.ChildTable.TableName))
								If Me.DataServerType = DataServerTypeEnum.Oracle Then
									text2 = """" + text2 + """"
								Else
									text2 = "[" + text2 + "]"
								End If
								Dim a_ As String
								If Operators.CompareString(Me.DataServer, "", True) > 0 Then
									If Operators.CompareString(Me.O._O0__., "", True) > 0 Then
										a_ = String.Concat(New String() { text, " in (Select ", text2, " From  (", Oo00.O0_._o0__.(Me.O._O0__.), ") FoxTempaX)" })
									Else
										a_ = String.Concat(New String() { text, " in (Select ", text2, " From  (", Oo00.O0_._o0__.(Me.HttpSelect), ") FoxTempaX)" })
									End If
								Else
									a_ = String.Concat(New String() { text, " in (Select ", text2, " From  (", Oo00.O0_._o0__.(Me._Adapter.SelectCommand.CommandText), ") FoxTempaX)" })
								End If
								OO_00oOO.DataTables(dataRelation.ChildTable.TableName).LoadFilter = a_
								OO_00oOO.DataTables(dataRelation.ChildTable.TableName).o0.o.(True, Nothing)
							Else
								MessageBox.Show("多列关联的时候，不能使用LoadChildren方法同步加载子表数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
						Else
							MessageBox.Show("父表和子表必须来自同一个数据源，才能同步加载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002259 RID: 8793 RVA: 0x000E7FC4 File Offset: 0x000E61C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub LoadChildren(ParamArray args As Object())
			If args.Length = 1 Then
				Me.LoadChildren(Conversions.ToString(args(0)))
				Return
			End If
			If args.Length = 3 Then
				Me.LoadChildren(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToString(args(2)))
			End If
		End Sub

		' Token: 0x0600225A RID: 8794 RVA: 0x000E8000 File Offset: 0x000E6200
		<oO0oooo("2894")>
		Public Sub LoadChildren(ChildName As String, ParentCol As String, ChildCol As String)
			Dim dataTable As DataTable = OO_00oOO.DataTables(ChildName)
			If(Me.frd_Connection IsNot Nothing AndAlso dataTable.frd_Connection Is Me.frd_Connection) OrElse (Operators.CompareString(Me.DataServer, "", True) > 0 AndAlso Operators.CompareString(Me.DataServer, dataTable.DataServer, True) = 0) Then
				ChildCol = Oo00.OoOo_oo_.o_o.(ChildCol, OO_00oOO.DataTables(ChildName))
				If Me.DataServerType = DataServerTypeEnum.Oracle Then
					ParentCol = """" + ParentCol + """"
				Else
					ParentCol = "[" + ParentCol + "]"
				End If
				Dim a_ As String
				If Operators.CompareString(Me.DataServer, "", True) > 0 Then
					If Operators.CompareString(Me.O._O0__., "", True) > 0 Then
						a_ = String.Concat(New String() { ChildCol, " in (Select DISTINCT ", ParentCol, " From  (", Oo00.O0_._o0__.(Me.O._O0__.), ") FoxTempaX)" })
					Else
						a_ = String.Concat(New String() { ChildCol, " in (Select DISTINCT ", ParentCol, " From  (", Oo00.O0_._o0__.(Me.HttpSelect), ") FoxTempaX)" })
					End If
				Else
					a_ = String.Concat(New String() { ChildCol, " in (Select DISTINCT ", ParentCol, " From  (", Oo00.O0_._o0__.(Me._Adapter.SelectCommand.CommandText), ") FoxTempaX)" })
				End If
				OO_00oOO.DataTables(ChildName).LoadFilter = a_
				OO_00oOO.DataTables(ChildName).o0.o.(True, Nothing)
			End If
		End Sub

		' Token: 0x0600225B RID: 8795 RVA: 0x000E81AC File Offset: 0x000E63AC
		<oO0oooo("2899")>
		Public Function SQLDeleteFor(Filter As String) As Integer
			Dim result As Integer
			If Not Me.frd_IsInnerTable AndAlso Not Me.frd_IsOuterTable AndAlso Operators.CompareString(Me.UpdateServer, "", True) <= 0 Then
				MessageBox.Show("查询表或临时表不能使用SQLReplaceFor更新后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = 0
			Else
				Dim flag As Boolean
				If Operators.CompareString(Me.DataServer, "", True) > 0 Then
					flag = (Me.DataServerType = DataServerTypeEnum.Oracle)
				Else
					flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection)
				End If
				Dim text As String
				If flag Then
					If Me.o._OOO0oOo0__..IndexOf("""") < 0 Then
						text = "Delete From """ + Me.o._OOO0oOo0__. + """"
					Else
						text = "Delete From " + Me.o._OOO0oOo0__.
					End If
				Else
					text = "Delete From [" + Me.o._OOO0oOo0__. + "]"
				End If
				If Operators.CompareString(Filter, "", True) > 0 Then
					text = text + " where " + Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Filter, False)
				End If
				If Operators.CompareString(Me.DataServer, "", True) = 0 Then
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, Me.o0__.Oo0o__O.)
					oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
					Dim state As ConnectionState = Me.o0__.Oo0o__O..State
					If state <> ConnectionState.Open Then
						Me.o0__.Oo0o__O..Open()
					End If
					Try
						Return oleDbCommand.ExecuteNonQuery()
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If state <> ConnectionState.Open Then
							Me.o0__.Oo0o__O..Close()
						End If
					End Try
					result = 0
				Else
					Oo00.o.Oo0oO.(Me.HttpSelect)
					Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					httpClient.[Select] = text
					httpClient.FormData.Add("Action", 7.ToString())
					Dim data As Object = httpClient.GetData()
					If data IsNot Nothing AndAlso Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(data)) Then
						result = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(data))))
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600225C RID: 8796 RVA: 0x000E83C4 File Offset: 0x000E65C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SQLCompute(ParamArray args As Object()) As Object
			Dim num As Integer = args.Length
			Dim result As Object
			If num <> 1 Then
				If num = 2 Then
					result = Me.SQLCompute(Conversions.ToString(args(0)), Conversions.ToString(args(1)))
				End If
			Else
				result = Me.SQLCompute(Conversions.ToString(args(0)))
			End If
			Return result
		End Function

		' Token: 0x0600225D RID: 8797 RVA: 0x000E8408 File Offset: 0x000E6608
		<oO0oooo("2897")>
		Public Function SQLCompute(Expression As String) As Object
			Return Me.SQLCompute(Expression, "")
		End Function

		' Token: 0x0600225E RID: 8798 RVA: 0x000E8418 File Offset: 0x000E6618
		<oO0oooo("2897")>
		Public Function SQLCompute(Expression As String, Filter As String) As Object
			Dim result As Object
			If Me.o0__.Oo0o__O. Is Nothing AndAlso Operators.CompareString(Me.DataServer, "", True) = 0 Then
				MessageBox.Show("临时表不能使用SQLCompute统计后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			Else
				Dim text As String = "Select " + Expression
				If Operators.CompareString(Me.DataServer, "", True) = 0 Then
					text = text + " From " + Oo00.O__0oO_oo.Ooo.(Me._Adapter.SelectCommand.CommandText)
					If Operators.CompareString(Filter, "", True) > 0 Then
						text = text + " Where " + Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Filter, False)
					End If
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, Me.o0__.Oo0o__O.)
					oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
					Dim state As ConnectionState = Me.o0__.Oo0o__O..State
					If state <> ConnectionState.Open Then
						Me.o0__.Oo0o__O..Open()
					End If
					Try
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
						If objectValue Is DBNull.Value Then
							Return Nothing
						End If
						Return objectValue
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If state <> ConnectionState.Open Then
							Me.o0__.Oo0o__O..Close()
						End If
					End Try
					result = Nothing
				Else
					text = text + " From " + Oo00.oo_0__0.o.(Me.HttpSelect)
					If Operators.CompareString(Filter, "", True) > 0 Then
						text = text + " Where " + Oo00.o0_o._O_.(Me.DataServerType, Filter, False)
					End If
					Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					httpClient.FormData.Add("Action", 6.ToString())
					httpClient.[Select] = text
					Dim data As Object = httpClient.GetData()
					If data IsNot Nothing AndAlso (String.IsNullOrEmpty(data.ToString()) OrElse String.IsNullOrWhiteSpace(data.ToString())) Then
						result = Nothing
					Else
						result = data
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600225F RID: 8799 RVA: 0x000E861C File Offset: 0x000E681C
		<oO0oooo("2898")>
		Public Function SQLReplaceFor(ColumnName As String, Value As Object, Optional Filter As String = "", Optional IsExpression As Boolean = False) As Integer
			Dim result As Integer
			If Not Me.frd_IsInnerTable AndAlso Not Me.frd_IsOuterTable AndAlso Operators.CompareString(Me.UpdateServer, "", True) <= 0 Then
				MessageBox.Show("查询表或临时表不能使用SQLReplaceFor更新后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = 0
			Else
				Dim text As String = ""
				Dim flag As Boolean
				If Operators.CompareString(Me.DataServer, "", True) > 0 Then
					flag = (Me.DataServerType = DataServerTypeEnum.Oracle)
				Else
					flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.frd_Connection)
				End If
				Dim flag2 As Boolean
				If Operators.CompareString(Me.DataServer, "", True) > 0 Then
					flag2 = (Me.DataServerType = DataServerTypeEnum.SqlServer)
				Else
					flag2 = o_O_o_oOoo__.OOOO_OO._oo.(Me.frd_Connection)
				End If
				If Not IsExpression Then
					If Me.DataCols.Contains(ColumnName) Then
						If Me.DataCols(ColumnName).IsString Then
							text = "'"
						ElseIf Me.DataCols(ColumnName).IsDate Then
							If flag OrElse flag2 Then
								text = "'"
							Else
								text = "#"
							End If
						End If
					ElseIf Value IsNot Nothing Then
						If TypeOf Value Is String Then
							text = "'"
						ElseIf TypeOf Value Is DateTime Then
							If flag OrElse flag2 Then
								text = "'"
							Else
								text = "#"
							End If
						End If
					End If
				End If
				ColumnName = ColumnName.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
				If flag Then
					ColumnName = """" + ColumnName + """"
				Else
					ColumnName = "[" + ColumnName + "]"
				End If
				Dim text2 As String
				If flag Then
					If Me.o._OOO0oOo0__..IndexOf("""") < 0 Then
						text2 = String.Concat(New String() { "update """, Me.o._OOO0oOo0__., """ Set ", ColumnName, " = " })
					Else
						text2 = String.Concat(New String() { "update ", Me.o._OOO0oOo0__., " Set ", ColumnName, " = " })
					End If
				Else
					text2 = String.Concat(New String() { "update [", Me.o._OOO0oOo0__., "] Set ", ColumnName, " = " })
				End If
				If Value Is Nothing Then
					text2 += "Null"
				Else
					text2 = text2 + text + Value.ToString() + text
				End If
				If Operators.CompareString(Filter, "", True) > 0 Then
					text2 = text2 + " Where " + Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Filter, False)
				End If
				If Operators.CompareString(Me.UpdateServer, "", True) = 0 Then
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, Me.o0__.Oo0o__O.)
					oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
					Dim state As ConnectionState = Me.o0__.Oo0o__O..State
					If state <> ConnectionState.Open Then
						Me.o0__.Oo0o__O..Open()
					End If
					Try
						Return oleDbCommand.ExecuteNonQuery()
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If state <> ConnectionState.Open Then
							Me.o0__.Oo0o__O..Close()
						End If
					End Try
					result = 0
				Else
					Oo00.o.Oo0oO.(Me.HttpSelect)
					Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					httpClient.[Select] = text2
					httpClient.FormData("Action") = 7.ToString()
					Dim data As Object = httpClient.GetData()
					If data IsNot Nothing AndAlso Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(data)) Then
						result = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(data))))
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x06002260 RID: 8800 RVA: 0x000E89B8 File Offset: 0x000E6BB8
		<oO0oooo("2909")>
		Public Function SQLGetValues(ColumnName As String, Optional Filter As String = "", Optional Sort As String = "") As Object
			Dim num As Integer
			Dim result As Object
			Dim num8 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim list As List(Of String) = New List(Of String)()
				IL_10:
				num2 = 3
				Dim list2 As List(Of String()) = New List(Of String())()
				IL_19:
				num2 = 4
				Dim text As String = ""
				IL_22:
				num2 = 5
				Dim text2 As String = ""
				IL_2B:
				num2 = 6
				Dim array As String() = ColumnName.Split(New Char() { "|"c })
				IL_40:
				num2 = 7
				For Each text3 As String In array
					IL_52:
					num2 = 8
					text3 = Oo00.OoOo_oo_.o_o.(text3, Me)
					IL_5E:
					num2 = 9
					If Operators.CompareString(text, "", True) > 0 Then
						IL_71:
						num2 = 10
						text += ","
					End If
					IL_82:
					num2 = 11
					text += text3
					IL_90:
					num2 = 12
				Next
				IL_A1:
				num2 = 13
				If Not text.StartsWith("(") OrElse Not text.EndsWith(")") OrElse Operators.CompareString(Sort, "", True) <= 0 Then
					GoTo IL_E4
				End If
				IL_CF:
				num2 = 14
				text2 = " a_" + OoOo0O.OO_o.0o_O.(7)
				IL_E4:
				num2 = 15
				If Me.o0__.Oo0o__O. IsNot Nothing OrElse Operators.CompareString(Me.DataServer, "", True) <> 0 Then
					GoTo IL_123
				End If
				IL_102:
				num2 = 16
				MessageBox.Show("临时表不能使用SQLSelect查询后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_118:
				num2 = 17
				result = list
				GoTo IL_6F1
				IL_123:
				num2 = 18
				If Operators.CompareString(Filter, "", True) <= 0 Then
					GoTo IL_172
				End If
				IL_135:
				num2 = 19
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_160
				End If
				IL_14C:
				num2 = 20
				Filter = Oo00.o0_o._O_.(Me.DataServerType, Filter, False)
				GoTo IL_172
				IL_160:
				num2 = 22
				Filter = Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Filter, False)
				IL_172:
				num2 = 23
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_196
				End If
				IL_189:
				num2 = 24
				Dim a_ As String = Me.HttpSelect
				GoTo IL_1AB
				IL_196:
				num2 = 26
				a_ = Me._Adapter.SelectCommand.CommandText
				IL_1AB:
				num2 = 27
				If Operators.CompareString(Sort, "", True) <> 0 Then
					GoTo IL_211
				End If
				IL_1BC:
				num2 = 28
				Dim text4 As String = "Select Distinct " + text + " From " + Oo00.oo_0__0.o.(a_)
				IL_1D9:
				num2 = 29
				If Operators.CompareString(Filter, "", True) <= 0 Then
					GoTo IL_4E5
				End If
				IL_1EE:
				num2 = 30
				text4 = text4 + " Where " + Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Filter, False)
				GoTo IL_4E5
				IL_211:
				num2 = 32
				Dim array3 As String() = Sort.Split(New Char() { ","c }, StringSplitOptions.RemoveEmptyEntries)
				IL_228:
				num2 = 33
				Dim array4 As String() = New String(array3.Length - 1 + 1 - 1) {}
				IL_23A:
				num2 = 34
				Sort = ""
				IL_244:
				num2 = 35
				Dim num3 As Integer = array3.Length - 1
				For j As Integer = 0 To num3
					IL_257:
					num2 = 36
					Dim text5 As String = Oo00.OoOo_oo_.o_o.(array3(j).Trim().Split(New Char() { " "c })(0), Me)
					IL_27E:
					num2 = 37
					If array3(j).EndsWith(" Desc", StringComparison.CurrentCultureIgnoreCase) Then
						IL_293:
						num2 = 38
						array4(j) = String.Concat(New String() { "Max(", text5, ") As [_temsortcol", Conversions.ToString(j), "]" })
						IL_2CD:
						num2 = 39
						array3(j) = "d200ad3c.[_temsortcol" + Conversions.ToString(j) + "] Desc"
					Else
						IL_2ED:
						num2 = 41
						array4(j) = String.Concat(New String() { "Min(", text5, ") As [_temsortcol", Conversions.ToString(j), "]" })
						IL_327:
						num2 = 42
						array3(j) = "d200ad3c.[_temsortcol" + Conversions.ToString(j) + "]"
					End If
					IL_345:
					num2 = 43
				Next
				IL_357:
				num2 = 44
				If Operators.CompareString(text2, "", True) <= 0 Then
					GoTo IL_3B9
				End If
				IL_36A:
				num2 = 45
				text4 = "Select " + text2 + " From ("
				IL_380:
				num2 = 46
				text4 = String.Concat(New String() { text4, "Select  Top 100 PERCENT ", text, " As ", text2, "," })
				GoTo IL_3E7
				IL_3B9:
				num2 = 48
				text4 = "Select " + text + " From ("
				IL_3CF:
				num2 = 49
				text4 = text4 + "Select  Top 100 PERCENT " + text + ","
				IL_3E7:
				num2 = 50
				Dim num4 As Integer = array3.Length - 1
				For k As Integer = 0 To num4
					IL_3F7:
					num2 = 51
					If k > 0 Then
						IL_3FF:
						num2 = 52
						text4 += ","
					End If
					IL_410:
					num2 = 53
					text4 += array4(k)
					IL_421:
					num2 = 54
				Next
				IL_430:
				num2 = 55
				text4 = text4 + " From " + Oo00.oo_0__0.o.(a_)
				IL_448:
				num2 = 56
				If Operators.CompareString(Filter, "", True) <= 0 Then
					GoTo IL_478
				End If
				IL_45A:
				num2 = 57
				text4 = text4 + " Where " + Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Filter, False)
				IL_478:
				num2 = 58
				text4 = text4 + " Group By " + text
				IL_48B:
				num2 = 59
				text4 += ") d200ad3c Order By "
				IL_49C:
				num2 = 60
				Dim num5 As Integer = array3.Length - 1
				For l As Integer = 0 To num5
					IL_4AC:
					num2 = 61
					If l > 0 Then
						IL_4B4:
						num2 = 62
						text4 += ","
					End If
					IL_4C5:
					num2 = 63
					text4 += array3(l)
					IL_4D6:
					num2 = 64
				Next
				IL_4E5:
				num2 = 65
				Dim dataTable As DataTable = New DataTable()
				IL_4EF:
				num2 = 66
				If Operators.CompareString(Me.DataServer, "", True) <> 0 Then
					GoTo IL_54C
				End If
				IL_505:
				num2 = 67
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text4, Me.o0__.Oo0o__O.)
				IL_517:
				num2 = 68
				oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
				IL_531:
				num2 = 69
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand)
				IL_53D:
				num2 = 70
				oleDbDataAdapter.Fill(dataTable)
				GoTo IL_5B5
				IL_54C:
				num2 = 72
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				IL_566:
				num2 = 73
				httpClient.FormData.Add("IgnoreSchema", "True")
				IL_57F:
				num2 = 74
				httpClient.[Select] = text4
				IL_58B:
				num2 = 75
				Dim dictionary As Dictionary(Of String, String) = httpClient.FormData
				Dim key As String = "Action"
				Dim num6 As Integer = 2
				dictionary(key) = num6.ToString()
				IL_5A9:
				num2 = 76
				dataTable = httpClient.GetBaseDataTable()
				IL_5B5:
				num2 = 77
				If array.Length <> 1 Then
					GoTo IL_650
				End If
				IL_5C2:
				num2 = 78
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_5E3:
					num2 = 79
					If Not dataRow.IsNull(0) Then
						IL_5F0:
						num2 = 80
						list.Add(dataRow(0).ToString())
					End If
					IL_607:
					num2 = 81
				End While
				IL_613:
				num2 = 82
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_62B:
				num2 = 83
				If Not ooO.o.O_0000_O.() Then
					GoTo IL_645
				End If
				IL_635:
				num2 = 84
				result = list.ToArray()
				GoTo IL_6F1
				IL_645:
				num2 = 86
				result = list
				GoTo IL_6F1
				IL_650:
				num2 = 88
				Dim enumerator2 As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					IL_671:
					num2 = 89
					Dim array5 As String() = New String(array.Length - 1 + 1 - 1) {}
					IL_683:
					num2 = 90
					num6 = array.Length - 1
					For m As Integer = 0 To num6
						IL_693:
						num2 = 91
						array5(m) = dataRow2(array(m)).ToString()
						IL_6AC:
						num2 = 92
					Next
					IL_6BB:
					num2 = 93
					list2.Add(array5)
					IL_6C7:
					num2 = 94
				End While
				IL_6D3:
				num2 = 95
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_6EB:
				num2 = 96
				result = list2
				IL_6F1:
				GoTo IL_8C7
				IL_6F6:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_888:
				GoTo IL_8BC
				IL_88A:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_89A:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_88A
			End Try
			IL_8BC:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8C7:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002261 RID: 8801 RVA: 0x000E92B4 File Offset: 0x000E74B4
		<oO0oooo("2910")>
		Public Function SQLGetComboListString(ColumnName As String, Optional Filter As String = "", Optional Sort As String = "") As String
			Dim list As List(Of String) = CType(Me.SQLGetValues(ColumnName, Filter, Sort), List(Of String))
			Dim result As String
			If list.Count = 0 Then
				result = ""
			Else
				Dim value As String() = list.ToArray()
				result = String.Join("|", value)
			End If
			Return result
		End Function

		' Token: 0x06002262 RID: 8802 RVA: 0x000E92F4 File Offset: 0x000E74F4
		<oO0oooo("3228")>
		Public Function SQLAddNew() As DataRow
			If Me.OO._0oo000_00. Is Nothing Then
				Me.OO._0oo000_00. = Me.o0O.O_0.()
				Me.OO._0oo000_00..ExtendedProperties.Add("DataAdapter", Me._Adapter)
				Me.OO._0oo000_00..ExtendedProperties.Add("Mirror", True)
				If Operators.CompareString(Me.UpdateServer, "", True) > 0 Then
					Me.OO._0oo000_00..ExtendedProperties.Add("MirrorFromDataTable", Me)
				End If
			End If
			Dim dataRow As DataRow = Me.OO._0oo000_00..NewRow()
			dataRow.RowError = "Mirror"
			Return New DataRow(dataRow)
		End Function

		' Token: 0x06002263 RID: 8803 RVA: 0x000E9394 File Offset: 0x000E7594
		Private Function <<EMPTY_NAME>>() As DataTable
			Dim dataTable As DataTable = New DataTable()
			Try
				For Each obj As Object In Me._DataTable.Columns
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					dataTable.Columns.Add(dataColumn.ColumnName, dataColumn.DataType)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return dataTable
		End Function

		' Token: 0x06002264 RID: 8804 RVA: 0x000E9410 File Offset: 0x000E7610
		<oO0oooo("2911")>
		Public Function SQLFind(Filter As String, Optional Sort As String = "", Optional Index As Integer = 0) As DataRow
			Dim top As String = (Index + 1).ToString()
			Dim list As List(Of DataRow) = Me.SQLSelect(Filter, top, Sort)
			Dim result As DataRow
			If list.Count > Index Then
				result = list(Index)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06002265 RID: 8805 RVA: 0x000E944C File Offset: 0x000E764C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SQLSelect(ParamArray args As Object()) As Object
			Dim filter As String = args(0).ToString()
			Dim top As String = ""
			Dim sort As String = ""
			If args.Length > 1 Then
				top = args(1).ToString()
			End If
			If args.Length > 2 Then
				sort = args(2).ToString()
			End If
			Dim list As List(Of DataRow) = Me.SQLSelect(filter, top, sort)
			Dim result As Object
			If ooO.o.O_0000_O.() Then
				result = list.ToArray()
			Else
				result = list
			End If
			Return result
		End Function

		' Token: 0x06002266 RID: 8806 RVA: 0x000E94AC File Offset: 0x000E76AC
		<oO0oooo("2900")>
		Public Function SQLSelect(Filter As String, Optional Top As String = "", Optional Sort As String = "") As List(Of DataRow)
			Dim num As Integer
			Dim result As List(Of DataRow)
			Dim num7 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_10:
				num2 = 3
				If Me.o0__.Oo0o__O. IsNot Nothing OrElse Operators.CompareString(Me.DataServer, "", True) <> 0 Then
					GoTo IL_4C
				End If
				IL_2D:
				num2 = 4
				MessageBox.Show("临时表不能使用SQLSelect查询后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_42:
				num2 = 5
				result = list
				GoTo IL_47D
				IL_4C:
				num2 = 6
				If Operators.CompareString(Me.DataServer, "", True) <= 0 Then
					GoTo IL_6E
				End If
				IL_62:
				num2 = 7
				Dim text As String = Me.HttpSelect
				GoTo IL_83
				IL_6E:
				num2 = 9
				text = Me._Adapter.SelectCommand.CommandText
				IL_83:
				num2 = 10
				Dim text2 As String = "Select"
				IL_8D:
				num2 = 11
				Dim text3 As String = Oo00.O__0oO_oo.Ooo.(text)
				IL_99:
				num2 = 12
				text = text.Replace(vbCr, " ")
				IL_AF:
				num2 = 13
				text = text.Replace(vbLf, " ")
				IL_C5:
				num2 = 14
				text = text.Replace("  ", " ")
				IL_DB:
				num2 = 15
				text = text.Replace("  ", " ")
				IL_F1:
				num2 = 16
				Dim array As String() = text.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
				IL_109:
				num2 = 17
				If Operators.CompareString(array(1), "top", True) <> 0 Then
					GoTo IL_141
				End If
				IL_11D:
				num2 = 18
				If Operators.CompareString(array(3), "PERCENT", True) <> 0 Then
					GoTo IL_139
				End If
				IL_131:
				num2 = 19
				Dim num3 As Integer = 4
				GoTo IL_19B
				IL_139:
				num2 = 21
				num3 = 3
				GoTo IL_19B
				IL_141:
				num2 = 23
				If Operators.CompareString(array(2), "top", True) <> 0 Then
					GoTo IL_179
				End If
				IL_155:
				num2 = 24
				If Operators.CompareString(array(4), "PERCENT", True) <> 0 Then
					GoTo IL_171
				End If
				IL_169:
				num2 = 25
				num3 = 5
				GoTo IL_19B
				IL_171:
				num2 = 27
				num3 = 4
				GoTo IL_19B
				IL_179:
				num2 = 29
				If Operators.CompareString(array(1), "Distinct", True) <> 0 Then
					GoTo IL_195
				End If
				IL_18D:
				num2 = 30
				num3 = 2
				GoTo IL_19B
				IL_195:
				num2 = 32
				num3 = 1
				IL_19B:
				num2 = 33
				Dim num4 As Integer = text.IndexOf(" " + array(num3) + " ", StringComparison.CurrentCultureIgnoreCase)
				IL_1BC:
				num2 = 34
				Dim num5 As Integer = text.IndexOf(" from ", StringComparison.CurrentCultureIgnoreCase)
				IL_1CE:
				num2 = 35
				text = text.Substring(num4, num5 - num4)
				IL_1E1:
				num2 = 36
				If Operators.CompareString(Top, "", True) <= 0 Then
					GoTo IL_207
				End If
				IL_1F3:
				num2 = 37
				text2 = text2 + " Top " + Top
				GoTo IL_22A
				IL_207:
				num2 = 39
				If Operators.CompareString(Sort, "", True) <= 0 Then
					GoTo IL_22A
				End If
				IL_219:
				num2 = 40
				text2 += " Top 100 PERCENT "
				IL_22A:
				num2 = 41
				text2 = String.Concat(New String() { text2, " ", text, " From ", text3 })
				IL_259:
				num2 = 42
				If Operators.CompareString(Filter, "", True) <= 0 Then
					GoTo IL_2BF
				End If
				IL_26B:
				num2 = 43
				If Operators.CompareString(Me.DataServer, "", True) <> 0 Then
					GoTo IL_2A1
				End If
				IL_281:
				num2 = 44
				text2 = text2 + " Where " + Oo00.o0_o._O_.(Me.o0__.Oo0o__O., Filter, False)
				GoTo IL_2BF
				IL_2A1:
				num2 = 46
				text2 = text2 + " Where " + Oo00.o0_o._O_.(Me.DataServerType, Filter, False)
				IL_2BF:
				num2 = 47
				If Operators.CompareString(Sort, "", True) <= 0 Then
					GoTo IL_2E3
				End If
				IL_2D1:
				num2 = 48
				text2 = text2 + " order by " + Sort
				IL_2E3:
				num2 = 49
				Dim dataTable As DataTable = New DataTable()
				IL_2ED:
				num2 = 50
				If Operators.CompareString(Me.DataServer, "", True) <> 0 Then
					GoTo IL_364
				End If
				IL_303:
				num2 = 51
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, Me.o0__.Oo0o__O.)
				IL_315:
				num2 = 52
				oleDbCommand.Transaction = Me._Adapter.SelectCommand.Transaction
				IL_32F:
				num2 = 53
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand)
				IL_33B:
				num2 = 54
				oleDbDataAdapter.Fill(dataTable)
				IL_348:
				num2 = 55
				dataTable.ExtendedProperties.Add("DataAdapter", Me._Adapter)
				GoTo IL_3E3
				IL_364:
				num2 = 57
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				IL_37E:
				num2 = 58
				If Operators.CompareString(Me.UpdateServer, "", True) <> 0 Then
					GoTo IL_3AD
				End If
				IL_394:
				num2 = 59
				httpClient.FormData.Add("IgnoreSchema", "True")
				IL_3AD:
				num2 = 60
				httpClient.[Select] = text2
				IL_3B9:
				num2 = 61
				httpClient.FormData("Action") = 2.ToString()
				IL_3D7:
				num2 = 62
				dataTable = httpClient.GetBaseDataTable()
				IL_3E3:
				num2 = 63
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim a_ As DataRow = CType(obj, DataRow)
					IL_404:
					num2 = 64
					list.Add(New DataRow(a_))
					IL_415:
					num2 = 65
				End While
				IL_421:
				num2 = 66
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_439:
				num2 = 67
				Dim enumerator2 As List(Of DataRow).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim dataRow As DataRow = enumerator2.Current
					IL_450:
					num2 = 68
					dataRow.OO0._o_00000. = Me
					IL_45B:
					num2 = 69
				End While
				IL_467:
				num2 = 70
				CType(enumerator2, IDisposable).Dispose()
				IL_477:
				num2 = 71
				result = list
				IL_47D:
				GoTo IL_5EF
				IL_482:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_5B0:
				GoTo IL_5E4
				IL_5B2:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5C2:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_5B2
			End Try
			IL_5E4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5EF:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002267 RID: 8807 RVA: 0x000E9AD0 File Offset: 0x000E7CD0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SQLUpdate(args As Object())
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			For i As Integer = 0 To args.Length - 1
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(i))
				list.Add(CType(objectValue, DataRow))
			Next
			Me.SQLUpdate(list)
		End Sub

		' Token: 0x06002268 RID: 8808 RVA: 0x000E9B10 File Offset: 0x000E7D10
		<oO0oooo("2901")>
		Public Sub SQLUpdate(lstRows As List(Of DataRow))
			If Operators.CompareString(Me.DataServer, "", True) > 0 Then
				If Operators.CompareString(Me.UpdateServer, "", True) > 0 Then
					Dim list As List(Of DataRow) = New List(Of DataRow)()
					Dim list2 As List(Of DataRow) = New List(Of DataRow)()
					Try
						For Each dataRow As DataRow In lstRows
							Dim rowState As DataRowState = dataRow.RowState
							If rowState <> 8 Then
								If rowState = 16 Then
									list.Add(dataRow.BaseRow)
									If list.Count >= Me.BatchUpdateSize Then
										oOO0oO000_0_0.oOoOo_o.__.(Me, list.ToArray())
										list.Clear()
									End If
								End If
							Else
								list2.Add(dataRow.BaseRow)
								If list2.Count >= Me.BatchUpdateSize Then
									oOO0oO000_0_0.OO.OoO0.(Me, list2.ToArray())
									list2.Clear()
								End If
							End If
						Next
					Finally
						Dim enumerator As List(Of DataRow).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					If list.Count > 0 Then
						oOO0oO000_0_0.oOoOo_o.__.(Me, list.ToArray())
					End If
					If list2.Count > 0 Then
						oOO0oO000_0_0.OO.OoO0.(Me, list2.ToArray())
						Return
					End If
				End If
			Else
				Dim array As DataRow() = New DataRow(lstRows.Count - 1 + 1 - 1) {}
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					array(i) = lstRows(i).BaseRow
				Next
				If array.Length > 0 Then
					If array(0).Table.ExtendedProperties.Contains("DataAdapter") AndAlso array(0).Table.ExtendedProperties("DataAdapter") Is Me._Adapter Then
						Me._Adapter.Update(array)
						Return
					End If
					MessageBox.Show("SQLUpdate更新后台数据失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x17000819 RID: 2073
		' (get) Token: 0x06002269 RID: 8809 RVA: 0x000E9CD0 File Offset: 0x000E7ED0
		' (set) Token: 0x0600226A RID: 8810 RVA: 0x000E9D90 File Offset: 0x000E7F90
		Private Property Apapter2 As OleDbDataAdapter
			Get
				Dim result As OleDbDataAdapter
				If Me.o._OOO0oOo0__. IsNot Nothing Then
					result = Me.o._OOO0oOo0__.
				Else
					Dim oleDbConnection As OleDbConnection = Nothing
					Try
						For Each oleDbConnection2 As OleDbConnection In DataTable.oO_.oOO0o_oo0_.
							If Operators.CompareString(oleDbConnection2.ConnectionString, Me.o0__.Oo0o__O..ConnectionString, True) = 0 Then
								oleDbConnection = oleDbConnection2
							End If
						Next
					Finally
						Dim enumerator As List(Of OleDbConnection).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					If oleDbConnection Is Nothing Then
						oleDbConnection = New OleDbConnection(Me.o0__.Oo0o__O..ConnectionString)
						DataTable.oO_.oOO0o_oo0_..Add(oleDbConnection)
					End If
					Me.o._OOO0oOo0__. = New OleDbDataAdapter(Me._Adapter.SelectCommand.CommandText, oleDbConnection)
					result = Me.o._OOO0oOo0__.
				End If
				Return result
			End Get
			Set(value As OleDbDataAdapter)
			End Set
		End Property

		' Token: 0x1700081A RID: 2074
		' (get) Token: 0x0600226B RID: 8811 RVA: 0x000E9D94 File Offset: 0x000E7F94
		' (set) Token: 0x0600226C RID: 8812 RVA: 0x000E9E20 File Offset: 0x000E8020
		Public Property ConnectionName As String
			Get
				Dim result As String
				If Operators.CompareString(Me.o_oOo00.00ooo_., "", True) > 0 Then
					result = Me.o_oOo00.00ooo_.
				Else
					Try
						For Each text As String In O_O0OO.O._o_.().Keys
							If O_O0OO.O._o_.()(text) Is Me.frd_Connection Then
								Return text
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					result = ""
				End If
				Return result
			End Get
			Friend Set(value As String)
				Me.o_oOo00.00ooo_. = value
			End Set
		End Property

		' Token: 0x0600226D RID: 8813 RVA: 0x000E9E2C File Offset: 0x000E802C
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Me._Adapter IsNot Nothing Then
				Me._Adapter.SelectCommand.CommandText = Me._Adapter.SelectCommand.CommandText.Replace(Me.o._OOO0oOo0__., A_0)
				Me.o._OOO0oOo0__. = A_0
				Me.o._OOO0oOo0__. = Nothing
				Me.O_00_._.()
			End If
		End Sub

		' Token: 0x1700081B RID: 2075
		' (get) Token: 0x0600226E RID: 8814 RVA: 0x000E9E81 File Offset: 0x000E8081
		' (set) Token: 0x0600226F RID: 8815 RVA: 0x000E9E89 File Offset: 0x000E8089
		Friend Property DataServer As String
			Get
				Return Me.oO_.o.
			End Get
			Set(value As String)
				Me.oO_.o. = value
			End Set
		End Property

		' Token: 0x1700081C RID: 2076
		' (get) Token: 0x06002270 RID: 8816 RVA: 0x000E9E94 File Offset: 0x000E8094
		Public ReadOnly Property DataServerType As DataServerTypeEnum
			Get
				If Operators.CompareString(Me.ConnectionName, "", True) > 0 Then
					If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.ConnectionName) Then
						Return O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).OO.OoO0.
					End If
					Dim a_ As OleDbConnection = O_O0OO.O._o_.()(Me.ConnectionName)
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(a_) Then
						Return DataServerTypeEnum.Oracle
					End If
					If o_O_o_oOoo__.OOOO_OO._oo.(a_) Then
						Return DataServerTypeEnum.SqlServer
					End If
				End If
				Return DataServerTypeEnum.Access
			End Get
		End Property

		' Token: 0x1700081D RID: 2077
		' (get) Token: 0x06002271 RID: 8817 RVA: 0x000E9F0B File Offset: 0x000E810B
		' (set) Token: 0x06002272 RID: 8818 RVA: 0x000E9F13 File Offset: 0x000E8113
		Friend Property UpdateServer As String
			Get
				Return Me.OOo0Ooo_o.Oo.
			End Get
			Set(value As String)
				Me.OOo0Ooo_o.Oo. = value
			End Set
		End Property

		' Token: 0x1700081E RID: 2078
		' (get) Token: 0x06002273 RID: 8819 RVA: 0x000E9F1C File Offset: 0x000E811C
		' (set) Token: 0x06002274 RID: 8820 RVA: 0x000E9F24 File Offset: 0x000E8124
		Friend Property HttpSelect As String
			Get
				Return Me.ooo0.0o0ooOo.
			End Get
			Set(value As String)
				Me.ooo0.0o0ooOo. = value
			End Set
		End Property

		' Token: 0x1700081F RID: 2079
		' (get) Token: 0x06002275 RID: 8821 RVA: 0x000E9F2D File Offset: 0x000E812D
		' (set) Token: 0x06002276 RID: 8822 RVA: 0x000E9F35 File Offset: 0x000E8135
		Friend Property UpdateColumns As List(Of String)
			Get
				Return Me.O0o0_oo.0.
			End Get
			Set(value As List(Of String))
				Me.O0o0_oo.0. = value
			End Set
		End Property

		' Token: 0x17000820 RID: 2080
		' (get) Token: 0x06002277 RID: 8823 RVA: 0x000E9F3E File Offset: 0x000E813E
		' (set) Token: 0x06002278 RID: 8824 RVA: 0x000E9F46 File Offset: 0x000E8146
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BatchUpdateSize As Integer
			Get
				Return Me.O0O00ooOo.o_.
			End Get
			Set(value As Integer)
				Me.O0O00ooOo.o_. = value
			End Set
		End Property

		' Token: 0x17000821 RID: 2081
		' (get) Token: 0x06002279 RID: 8825 RVA: 0x000E9F4F File Offset: 0x000E814F
		Public ReadOnly Property BuildinLock As Boolean
			Get
				Return Me.O000_00._0_o.
			End Get
		End Property

		' Token: 0x0600227A RID: 8826 RVA: 0x000E9F58 File Offset: 0x000E8158
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetQuikKey(ParamArray args As Object())
			If args.Length = 1 Then
				Me.SetQuikKey(Conversions.ToString(args(0)))
				Return
			End If
			If args.Length > 1 Then
				Dim array As String() = New String(args.Length - 1 + 1 - 1) {}
				Dim num As Integer = args.Length - 1
				For i As Integer = 0 To num
					array(i) = Conversions.ToString(args(i))
				Next
				Me.SetQuikKey(array)
			End If
		End Sub

		' Token: 0x0600227B RID: 8827 RVA: 0x000E9FB4 File Offset: 0x000E81B4
		Public Sub SetQuikKey(key As String)
			If Operators.CompareString(key, "", True) = 0 Then
				If Me.o_oO0O_.O0. IsNot Nothing Then
					Me.o_oO0O_.O0..Dispose()
					Me.o_oO0O_.O0. = Nothing
					Return
				End If
			Else
				Me.o_oO0O_.O0. = New DataView(Me._DataTable, "", key, DataViewRowState.CurrentRows)
			End If
		End Sub

		' Token: 0x0600227C RID: 8828 RVA: 0x000EA004 File Offset: 0x000E8204
		Public Sub SetQuikKey(ParamArray keys As String())
			If keys.Length = 0 Then
				If Me.o_oO0O_.O0. IsNot Nothing Then
					Me.o_oO0O_.O0..Dispose()
					Me.o_oO0O_.O0. = Nothing
					Return
				End If
			Else
				Me.o_oO0O_.O0. = New DataView(Me._DataTable, "", String.Join(",", keys), DataViewRowState.CurrentRows)
			End If
		End Sub

		' Token: 0x0600227D RID: 8829 RVA: 0x000EA054 File Offset: 0x000E8254
		Public Function QuikFind(ParamArray Values As Object()) As DataRow
			Dim result As DataRow
			If Values.Length = 1 Then
				result = Me.QuikFind(RuntimeHelpers.GetObjectValue(Values(0)))
			Else
				If Me.o_oO0O_.O0. IsNot Nothing Then
					Dim num As Integer = Me.o_oO0O_.O0..Find(Values)
					If num >= 0 Then
						Return New DataRow(Me.o_oO0O_.O0.(num).Row)
					End If
				End If
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x0600227E RID: 8830 RVA: 0x000EA0B0 File Offset: 0x000E82B0
		Public Function QuikFind(Value As Object) As DataRow
			If Me.o_oO0O_.O0. IsNot Nothing Then
				Dim num As Integer = Me.o_oO0O_.O0..Find(RuntimeHelpers.GetObjectValue(Value))
				If num >= 0 Then
					Return New DataRow(Me.o_oO0O_.O0.(num).Row)
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x0600227F RID: 8831 RVA: 0x000EA0F8 File Offset: 0x000E82F8
		Public Function QuikSelect(ParamArray Values As Object()) As List(Of DataRow)
			Dim result As List(Of DataRow)
			If Values.Length = 1 Then
				result = Me.QuikSelect(RuntimeHelpers.GetObjectValue(Values(1)))
			Else
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				If Me.o_oO0O_.O0. IsNot Nothing Then
					For Each dataRowView As DataRowView In Me.o_oO0O_.O0..FindRows(Values)
						list.Add(New DataRow(dataRowView.Row))
					Next
				End If
				result = list
			End If
			Return result
		End Function

		' Token: 0x06002280 RID: 8832 RVA: 0x000EA160 File Offset: 0x000E8360
		Public Function QuikSelect(Value As Object) As List(Of DataRow)
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			If Me.o_oO0O_.O0. IsNot Nothing Then
				For Each dataRowView As DataRowView In Me.o_oO0O_.O0..FindRows(RuntimeHelpers.GetObjectValue(Value))
					list.Add(New DataRow(dataRowView.Row))
				Next
			End If
			Return list
		End Function

		' Token: 0x04000DC5 RID: 3525
		<CompilerGenerated()>
		<AccessedThroughProperty("_DataTable")>
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000DC6 RID: 3526
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000DC7 RID: 3527
		Private Shared <<EMPTY_NAME>> As List(Of OleDbConnection) = New List(Of OleDbConnection)()

		' Token: 0x04000DC8 RID: 3528
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DC9 RID: 3529
		<CompilerGenerated()>
		<AccessedThroughProperty("_Adapter")>
		Private <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x04000DCA RID: 3530
		Private <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x04000DCB RID: 3531
		Private <<EMPTY_NAME>> As GlobalEvents

		' Token: 0x04000DCC RID: 3532
		Friend <<EMPTY_NAME>> As DataColCollection

		' Token: 0x04000DCD RID: 3533
		Friend <<EMPTY_NAME>> As DataRowCollection

		' Token: 0x04000DCE RID: 3534
		Friend <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04000DCF RID: 3535
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DD0 RID: 3536
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000DD1 RID: 3537
		Private <<EMPTY_NAME>> As DataTableProperty

		' Token: 0x04000DD2 RID: 3538
		Private <<EMPTY_NAME>> As LookAndFeelProperty

		' Token: 0x04000DD3 RID: 3539
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DD4 RID: 3540
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DD5 RID: 3541
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DD6 RID: 3542
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DD7 RID: 3543
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DD8 RID: 3544
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DD9 RID: 3545
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DDA RID: 3546
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DDB RID: 3547
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DDC RID: 3548
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DDD RID: 3549
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DDE RID: 3550
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DDF RID: 3551
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DE0 RID: 3552
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DE1 RID: 3553
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DE2 RID: 3554
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DE3 RID: 3555
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DE4 RID: 3556
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DE5 RID: 3557
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DE6 RID: 3558
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DE7 RID: 3559
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DE8 RID: 3560
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DE9 RID: 3561
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DEA RID: 3562
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DEB RID: 3563
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000DEC RID: 3564
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000DED RID: 3565
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000DEE RID: 3566
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000DEF RID: 3567
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000DF0 RID: 3568
		Private <<EMPTY_NAME>> As DockArrageTypeEnum

		' Token: 0x04000DF1 RID: 3569
		Private <<EMPTY_NAME>> As DockArrageTypeEnum

		' Token: 0x04000DF2 RID: 3570
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DF3 RID: 3571
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DF4 RID: 3572
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DF5 RID: 3573
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DF6 RID: 3574
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DF7 RID: 3575
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DF8 RID: 3576
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000DF9 RID: 3577
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DFA RID: 3578
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000DFB RID: 3579
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000DFC RID: 3580
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DFD RID: 3581
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DFE RID: 3582
		Friend <<EMPTY_NAME>> As Assembly

		' Token: 0x04000DFF RID: 3583
		Friend <<EMPTY_NAME>> As Long

		' Token: 0x04000E00 RID: 3584
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E01 RID: 3585
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E02 RID: 3586
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E03 RID: 3587
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E04 RID: 3588
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E05 RID: 3589
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E06 RID: 3590
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E07 RID: 3591
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E08 RID: 3592
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E09 RID: 3593
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E0A RID: 3594
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E0B RID: 3595
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E0C RID: 3596
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E0D RID: 3597
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E0E RID: 3598
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E0F RID: 3599
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E10 RID: 3600
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E11 RID: 3601
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E12 RID: 3602
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E13 RID: 3603
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E14 RID: 3604
		Friend <<EMPTY_NAME>> As MethodInfo

		' Token: 0x04000E15 RID: 3605
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E16 RID: 3606
		Private <<EMPTY_NAME>> As OleDbCommand

		' Token: 0x04000E17 RID: 3607
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000E18 RID: 3608
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E19 RID: 3609
		Friend <<EMPTY_NAME>> As Decimal

		' Token: 0x04000E1A RID: 3610
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E1B RID: 3611
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000E1C RID: 3612
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E1D RID: 3613
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E1E RID: 3614
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000E1F RID: 3615
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E20 RID: 3616
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E21 RID: 3617
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E22 RID: 3618
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E23 RID: 3619
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E24 RID: 3620
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000E25 RID: 3621
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E26 RID: 3622
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E27 RID: 3623
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E28 RID: 3624
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E29 RID: 3625
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000E2A RID: 3626
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04000E2B RID: 3627
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E2C RID: 3628
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000E2D RID: 3629
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E2E RID: 3630
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E2F RID: 3631
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E30 RID: 3632
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E31 RID: 3633
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E32 RID: 3634
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E33 RID: 3635
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E34 RID: 3636
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000E35 RID: 3637
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E36 RID: 3638
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x04000E37 RID: 3639
		Private a As String
	End Class
End Namespace
