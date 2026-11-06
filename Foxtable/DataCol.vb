Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000294 RID: 660
	<oO0oooo("1356")>
	<ComVisible(True)>
	Public Class DataCol
		' Token: 0x0600204B RID: 8267 RVA: 0x000D6CB4 File Offset: 0x000D4EB4
		Friend Sub New(A_0 As DataColumn)
			Me.o_.O___. = New DataColumnProperty(Me)
			Me.O0O_0_._o__0. = 1
			Me.O_.O0o_00. = True
			Me.o0_o.o__o0_o. = False
			Me.o0oo__o0O.o. = False
			Me.o_O_00._O__. = 2
			Me.O0.00oOoOO0Oo_. = 1
			Me.Oo_o.OOO0_0OO0. = 0
			Me.O0_O_OOO_.0O. = 0
			Me.ooOo.O_o. = 4
			Me.OO0O._. = False
			Me.ooo_O0oOO._. = 0
			Me.O0_O_OOO_.0O. = 0
			Me.O_0_OO0___.0oo. = 0
			Me.OO0.o0oO. = 0
			Me.O.oO_O_o. = 0
			Me.ooOo.__. = True
			Me.oO.o_OOOO__O0. = ","
			Me.o0o.0_o. = True
			Me.OO0.o0oO. = "\"c
			Me.O.oO_O_o. = "|"c
			Me.oo.0_0_O. = 11
			Me.o0_00O.____. = 0
			Me.o._0O0Oo00. = 21
			Me.o0_00O.____. = 0
			Me.ooo0O0_o00.0o_. = False
			Me.OO.00o_Oo_o0_0. = False
			Me.O_O_0000O.o. = True
			Me.ooo0__o_o_o._. = True
			Me.O__0o0Oo_.O_. = True
			Me.oOo0o0.O000. = True
			Me.OOo.0. = True
			Me.ooo_.O0OO0_o. = 6
			Me.o0O_0_._oo. = A_0
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { Me.o0O_0_._oo..Table.TableName, Me.o0O_0_._oo..ColumnName })
			If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") Then
				o_O_o_oOoo__.OOOO_OO._oo.(Me.o_.O___., Conversions.ToString(dataRow("Config")), vbVerticalTab)
			End If
			If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { Me.o0O_0_._oo..Table.TableName, Me.o0O_0_._oo..ColumnName }) IsNot Nothing Then
				Me.o_.O___. = True
			End If
			Dim dataType As Type = A_0.DataType
			GetType(Boolean)
			If A_0.[ReadOnly] AndAlso Operators.CompareString(A_0.Expression, "", True) = 0 Then
				A_0.[ReadOnly] = False
			End If
			If A_0.Unique Then
				Dim num As Integer = A_0.Table.PrimaryKey.Length - 1
				Dim flag As Boolean
				For i As Integer = 0 To num
					If A_0 Is A_0.Table.PrimaryKey(i) Then
						flag = True
						Exit For
					End If
				Next
				If Not flag AndAlso A_0.Unique Then
					A_0.Unique = False
				End If
			End If
			If Not A_0.AllowDBNull Then
				A_0.AllowDBNull = True
			End If
		End Sub

		' Token: 0x0600204C RID: 8268 RVA: 0x000D6F10 File Offset: 0x000D5110
		Friend Sub <<EMPTY_NAME>>()
			Me.ooOO.oO0o. = Nothing
			Me.O._00_. = Nothing
			Me.O_oo0_00.__0__. = ""
			Me.o0_00O.____. = Nothing
			Me.oO0._00o_0. = Nothing
			If(Me.DataMapType = 1 OrElse Me.DataMapType = 4) AndAlso Me.DataMap IsNot Nothing Then
				Dim listDictionary As ListDictionary = New ListDictionary()
				For Each text As String In Me.DataMap.Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
					Dim obj As Object = Nothing
					If Me.OOOo_._oO0_O.(text.Substring(0, text.IndexOf(vbTab)), obj) Then
						listDictionary(RuntimeHelpers.GetObjectValue(obj)) = text.Substring(text.IndexOf(vbTab) + 1)
					End If
				Next
				If listDictionary.Count <= 0 Then
					GoTo IL_22D
				End If
				If Me.DataMapType = 1 Then
					Me.ooOO.oO0o. = listDictionary
					GoTo IL_22D
				End If
				Me.oO0._00o_0. = New Dictionary(Of String, String)()
				Try
					For Each obj2 As Object In listDictionary.Keys
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj2)
						If listDictionary(RuntimeHelpers.GetObjectValue(objectValue)) IsNot Nothing Then
							Me.oO0._00o_0..Add(objectValue.ToString(), listDictionary(RuntimeHelpers.GetObjectValue(objectValue)).ToString())
						End If
					Next
					GoTo IL_22D
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			If Me.DataMapType = 2 AndAlso Me.MultiDataMap IsNot Nothing Then
				Dim multiDataMap As MultiDataMap = New MultiDataMap()
				Dim array2 As String() = Me.MultiDataMap.Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				multiDataMap.DisplayCol = Me.MultiDataMapDisplayCol
				multiDataMap.ValueCol = Me.MultiDataMapValueCol
				For Each text2 As String In array2
					multiDataMap.Add(text2.Replace(vbTab, "|"))
				Next
				If array2.Length > 0 Then
					Me.ooOO.oO0o. = multiDataMap.CreateDataMap()
				End If
			ElseIf Me.DataMapType = 3 AndAlso Me.DataMapTable IsNot Nothing Then
				Me.ooOO.oO0o. = Oo00.OO.0O0o.(Me.DataMapTable, Me.DataMapListColumns, Me.DataMapValueColumn, Me.DataMapListColumn, Me.DataMapFilter, Me.DataMapSort)
			End If
			IL_22D:
			If Me.ImageMapType = 1 AndAlso Me.ImageMap IsNot Nothing Then
				Dim listDictionary2 As ListDictionary = New ListDictionary()
				Dim text3 As String = ""
				For Each text4 As String In Me.ImageMap.Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
					Dim text5 As String = text4.Substring(0, text4.IndexOf(vbTab))
					Dim imageFile As String = text4.Substring(text4.IndexOf(vbTab) + 1)
					listDictionary2(text5) = OO_00oOO.GetImage(imageFile)
					If Operators.CompareString(text3, "", True) > 0 Then
						text3 += "|"
					End If
					text3 += text5
				Next
				Me.O._00_. = listDictionary2
				Me.O_oo0_00.__0__. = text3
			End If
			If(Me.ExtendColumnType = 6 OrElse Me.ExtendColumnType = 3 OrElse Me.ExtendColumnType = 4) AndAlso Me.Remote Then
				Me.FTPClient = New FTPClient()
				Dim ftpclient As FTPClient = Me.FTPClient
				ftpclient.Host = Me.Host
				ftpclient.Account = Me.Account
				ftpclient.RootDir = Me.RootDir
				ftpclient.Password = Me.Password
				ftpclient.UTF8 = Me.UTF8
				ftpclient.Port = Me.Port
			End If
		End Sub

		' Token: 0x0600204D RID: 8269 RVA: 0x000D72A0 File Offset: 0x000D54A0
		Private Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As Object) As Boolean
			Dim result As Boolean
			If Me.BaseColumn.DataType Is GetType(String) Then
				A_1 = A_0
				result = True
			ElseIf Me.BaseColumn.DataType Is GetType(Integer) Then
				Dim num As Integer
				If Integer.TryParse(A_0, num) Then
					A_1 = num
					result = True
				Else
					result = False
				End If
			ElseIf Me.BaseColumn.DataType Is GetType(Long) Then
				Dim num2 As Long
				If Long.TryParse(A_0, num2) Then
					A_1 = num2
					result = True
				Else
					result = False
				End If
			ElseIf Me.BaseColumn.DataType Is GetType(Double) Then
				Dim num3 As Double
				If Double.TryParse(A_0, num3) Then
					A_1 = num3
					result = True
				Else
					result = False
				End If
			ElseIf Me.BaseColumn.DataType Is GetType(Single) Then
				Dim num4 As Single
				If Single.TryParse(A_0, num4) Then
					A_1 = num4
					result = True
				Else
					result = False
				End If
			ElseIf Me.BaseColumn.DataType Is GetType(Short) Then
				Dim num5 As Short
				If Short.TryParse(A_0, num5) Then
					A_1 = num5
					result = True
				Else
					result = False
				End If
			ElseIf Me.BaseColumn.DataType Is GetType(Byte) Then
				Dim b As Byte
				If Byte.TryParse(A_0, b) Then
					A_1 = b
					result = True
				Else
					result = False
				End If
			End If
			Return result
		End Function

		' Token: 0x0600204E RID: 8270 RVA: 0x000D7408 File Offset: 0x000D5608
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = True)
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { Me.o0O_0_._oo..Table.TableName, Me.o0O_0_._oo..ColumnName })
			If dataRow Is Nothing Then
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).NewRow()
				dataRow("Table") = Me.o0O_0_._oo..Table.TableName
				dataRow("Column") = Me.o0O_0_._oo..ColumnName
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Add(dataRow)
			End If
			dataRow("Config") = o_O_o_oOoo__.OOOO_OO._oo.(Me.o_.O___., False, vbVerticalTab, False)
			If A_0 Then
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
			End If
		End Sub

		' Token: 0x17000756 RID: 1878
		' (get) Token: 0x0600204F RID: 8271 RVA: 0x000D74FF File Offset: 0x000D56FF
		<oO0oooo("0409")>
		Public ReadOnly Property Name As String
			Get
				Return Me.o0O_0_._oo..ColumnName
			End Get
		End Property

		' Token: 0x17000757 RID: 1879
		' (get) Token: 0x06002050 RID: 8272 RVA: 0x000D750C File Offset: 0x000D570C
		' (set) Token: 0x06002051 RID: 8273 RVA: 0x000D751C File Offset: 0x000D571C
		<oO0oooo("0417")>
		Public Property Expression As String
			Get
				Return Me.o0O_0_._oo..Expression
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					value = String.Empty
				End If
				If Me.IsTemporary Then
					Me.o0O_0_._oo..Expression = value
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me.o0O_0_._oo..Table Then
								table.foxGrid.Invalidate()
							End If
						Next
						Return
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				MessageBox.Show("[" + Me.Name + "]非表达式列，不能设置计算表达式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End Set
		End Property

		' Token: 0x17000758 RID: 1880
		' (get) Token: 0x06002052 RID: 8274 RVA: 0x000D75D0 File Offset: 0x000D57D0
		' (set) Token: 0x06002053 RID: 8275 RVA: 0x000D75D8 File Offset: 0x000D57D8
		<oO0oooo("1281")>
		Public Property DefaultValue As String
			Get
				Return Me.oO_O_o.O0__.
			End Get
			Set(value As String)
				Me.oO_O_o.O0__. = value
			End Set
		End Property

		' Token: 0x17000759 RID: 1881
		' (get) Token: 0x06002054 RID: 8276 RVA: 0x000D75E1 File Offset: 0x000D57E1
		' (set) Token: 0x06002055 RID: 8277 RVA: 0x000D75EC File Offset: 0x000D57EC
		<oO0oooo("0410")>
		Public Property AllowEdit As Boolean
			Get
				Return Me.O_.O0o_00.
			End Get
			Set(value As Boolean)
				Me.O_.O0o_00. = value
				If OO_00oOO.Tables IsNot Nothing Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.View.o_o.O0ooOo.() Is Me.o0O_0_._oo..Table AndAlso table.Cols.Contains(Me.Name) AndAlso table.foxGrid.Cols.Contains(Me.Name) Then
								table.foxGrid.Cols(Me.Name).Invalidate()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					Main.OO_O.o..O.ooO0. = True
				End If
			End Set
		End Property

		' Token: 0x1700075A RID: 1882
		' (get) Token: 0x06002056 RID: 8278 RVA: 0x000D76AC File Offset: 0x000D58AC
		' (set) Token: 0x06002057 RID: 8279 RVA: 0x000D76B4 File Offset: 0x000D58B4
		<oO0oooo("0411")>
		Public Property Unique As Boolean
			Get
				Return Me.o0_o.o__o0_o.
			End Get
			Set(value As Boolean)
				Me.o0_o.o__o0_o. = value
			End Set
		End Property

		' Token: 0x06002058 RID: 8280 RVA: 0x000D76C0 File Offset: 0x000D58C0
		<oO0oooo("1611")>
		Public Sub SetDateTimeFormat(format As DateTimeFormatEnum)
			Me.DateTimeFormat = format
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable.BaseTable Is Me.o0O_0_._oo..Table AndAlso table.Loaded AndAlso table.Cols.Contains(Me.Name) Then
						table.Cols(Me.Name).SetDateTimeFormat(format)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002059 RID: 8281 RVA: 0x000D7758 File Offset: 0x000D5958
		<oO0oooo("1659")>
		Public Sub SetFormat(fmt As String)
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable.BaseTable Is Me.o0O_0_._oo..Table AndAlso table.Loaded AndAlso table.Cols.Contains(Me.Name) Then
						table.foxGrid.Cols(Me.Name).Format = fmt
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600205A RID: 8282 RVA: 0x000D77EC File Offset: 0x000D59EC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Recalc()
		End Sub

		' Token: 0x0600205B RID: 8283 RVA: 0x000D77EE File Offset: 0x000D59EE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Recalc(dr As DataRow)
		End Sub

		' Token: 0x1700075B RID: 1883
		' (get) Token: 0x0600205C RID: 8284 RVA: 0x000D77F0 File Offset: 0x000D59F0
		Public ReadOnly Property DataType As Type
			Get
				Return Me.o0O_0_._oo..DataType
			End Get
		End Property

		' Token: 0x1700075C RID: 1884
		' (get) Token: 0x0600205D RID: 8285 RVA: 0x000D77FD File Offset: 0x000D59FD
		<oO0oooo("0412")>
		Public ReadOnly Property MaxLength As Integer
			Get
				Return Me.o0O_0_._oo..MaxLength
			End Get
		End Property

		' Token: 0x1700075D RID: 1885
		' (get) Token: 0x0600205E RID: 8286 RVA: 0x000D780A File Offset: 0x000D5A0A
		<oO0oooo("0413")>
		Public ReadOnly Property IsNumeric As Boolean
			Get
				Return o_O_o_oOoo__.OO_.O.(Me.o0O_0_._oo..DataType)
			End Get
		End Property

		' Token: 0x1700075E RID: 1886
		' (get) Token: 0x0600205F RID: 8287 RVA: 0x000D781C File Offset: 0x000D5A1C
		<oO0oooo("0415")>
		Public ReadOnly Property IsDate As Boolean
			Get
				Dim result As Boolean
				If Me.o0O_0_._oo..DataType Is GetType(DateTime) Then
					result = True
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700075F RID: 1887
		' (get) Token: 0x06002060 RID: 8288 RVA: 0x000D7844 File Offset: 0x000D5A44
		<oO0oooo("0416")>
		Public ReadOnly Property IsBoolean As Boolean
			Get
				Dim result As Boolean
				If Me.o0O_0_._oo..DataType Is GetType(Boolean) Then
					result = True
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000760 RID: 1888
		' (get) Token: 0x06002061 RID: 8289 RVA: 0x000D786C File Offset: 0x000D5A6C
		<oO0oooo("0414")>
		Public ReadOnly Property IsString As Boolean
			Get
				Dim result As Boolean
				If Me.o0O_0_._oo..DataType Is GetType(String) Then
					result = True
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000761 RID: 1889
		' (get) Token: 0x06002062 RID: 8290 RVA: 0x000D7893 File Offset: 0x000D5A93
		' (set) Token: 0x06002063 RID: 8291 RVA: 0x000D789B File Offset: 0x000D5A9B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property DateTimeFormat As DateTimeFormatEnum
			Get
				Return Me.O0_O_OOO_.0O.
			End Get
			Set(value As DateTimeFormatEnum)
				Me.O0_O_OOO_.0O. = value
			End Set
		End Property

		' Token: 0x17000762 RID: 1890
		' (get) Token: 0x06002064 RID: 8292 RVA: 0x000D78A4 File Offset: 0x000D5AA4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property NumericType As oooOooo
			Get
				Dim result As oooOooo
				If Me.o0O_0_._oo..DataType Is GetType(Decimal) Then
					result = oooOooo.o___O_0O_O00.O.
				ElseIf Me.o0O_0_._oo..DataType Is GetType(Double) Then
					result = oooOooo.o_O_.Oo_0.
				ElseIf Me.o0O_0_._oo..DataType Is GetType(Single) Then
					result = oooOooo.Ooo00.o0_00o_.
				ElseIf Me.o0O_0_._oo..DataType Is GetType(Long) Then
					result = oooOooo.oo0OO.o.
				ElseIf Me.o0O_0_._oo..DataType Is GetType(Integer) Then
					result = oooOooo.O0_.O_.
				ElseIf Me.o0O_0_._oo..DataType Is GetType(Short) Then
					result = oooOooo.oo_O__0O_.O00o.
				ElseIf Me.o0O_0_._oo..DataType Is GetType(Byte) Then
					result = oooOooo.oOo._0O__0.
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000763 RID: 1891
		' (get) Token: 0x06002065 RID: 8293 RVA: 0x000D7973 File Offset: 0x000D5B73
		' (set) Token: 0x06002066 RID: 8294 RVA: 0x000D797B File Offset: 0x000D5B7B
		<oO0oooo("1477")>
		Public Property FTPClient As FTPClient
			Get
				Return Me.o0_00O.____.
			End Get
			Friend Set(value As FTPClient)
				Me.o0_00O.____. = value
			End Set
		End Property

		' Token: 0x17000764 RID: 1892
		' (get) Token: 0x06002067 RID: 8295 RVA: 0x000D7984 File Offset: 0x000D5B84
		' (set) Token: 0x06002068 RID: 8296 RVA: 0x000D798C File Offset: 0x000D5B8C
		Friend Property Separator As String
			Get
				Return Me.oO.o_OOOO__O0.
			End Get
			Set(value As String)
				Me.oO.o_OOOO__O0. = value
			End Set
		End Property

		' Token: 0x17000765 RID: 1893
		' (get) Token: 0x06002069 RID: 8297 RVA: 0x000D7995 File Offset: 0x000D5B95
		Public ReadOnly Property DataTable As DataTable
			Get
				Return OO_00oOO.DataTables(Me.o0O_0_._oo..Table.TableName)
			End Get
		End Property

		' Token: 0x17000766 RID: 1894
		' (get) Token: 0x0600206A RID: 8298 RVA: 0x000D79B1 File Offset: 0x000D5BB1
		Friend ReadOnly Property Setting As DataColumnProperty
			Get
				Return Me.o_.O___.
			End Get
		End Property

		' Token: 0x17000767 RID: 1895
		' (get) Token: 0x0600206B RID: 8299 RVA: 0x000D79BC File Offset: 0x000D5BBC
		' (set) Token: 0x0600206C RID: 8300 RVA: 0x000D7A32 File Offset: 0x000D5C32
		Friend Property IsTemporary As Boolean
			Get
				Dim result As Boolean
				If Operators.CompareString(Me.DataTable.UpdateServer, "", True) > 0 Then
					result = Not Me.DataTable.UpdateColumns.Contains(Me.Name.ToLower())
				Else
					result = (Me.o0O_0_._oo..Table.DataSet Is Nothing OrElse Me.DataTable.frd_IsTemporary OrElse Me.o_.O___.)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If Me.o0O_0_._oo..Table.DataSet IsNot Nothing AndAlso Not Me.DataTable.frd_IsTemporary Then
					Me.o_.O___. = value
				End If
			End Set
		End Property

		' Token: 0x0600206D RID: 8301 RVA: 0x000D7A5C File Offset: 0x000D5C5C
		Friend Function <<EMPTY_NAME>>() As Boolean
			' The following expression was wrapped in a checked-statement
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					Dim parentColumns As DataColumn() = dataRelation.ParentColumns
					For i As Integer = 0 To parentColumns.Length - 1
						If parentColumns(i) Is Me.o0O_0_._oo. Then
							Return True
						End If
					Next
					Dim childColumns As DataColumn() = dataRelation.ChildColumns
					For j As Integer = 0 To childColumns.Length - 1
						If childColumns(j) Is Me.o0O_0_._oo. Then
							Return True
						End If
					Next
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim result As Boolean
			Return result
		End Function

		' Token: 0x0600206E RID: 8302 RVA: 0x000D7B0C File Offset: 0x000D5D0C
		Friend Sub <<EMPTY_NAME>>()
			OO_00oOO.DataTables(Me.o0O_0_._oo..Table.TableName).DataCols.Delete(Me.o0O_0_._oo..ColumnName)
		End Sub

		' Token: 0x17000768 RID: 1896
		' (get) Token: 0x0600206F RID: 8303 RVA: 0x000D7B3D File Offset: 0x000D5D3D
		Friend ReadOnly Property BaseColumn As DataColumn
			Get
				Return Me.o0O_0_._oo.
			End Get
		End Property

		' Token: 0x17000769 RID: 1897
		' (get) Token: 0x06002070 RID: 8304 RVA: 0x000D7B45 File Offset: 0x000D5D45
		' (set) Token: 0x06002071 RID: 8305 RVA: 0x000D7B4D File Offset: 0x000D5D4D
		<oO0oooo("1447")>
		Public Property Caption As String
			Get
				Return Me.o0O_0_._oo.
			End Get
			Set(value As String)
				Me.o0O_0_._oo. = value
			End Set
		End Property

		' Token: 0x1700076A RID: 1898
		' (get) Token: 0x06002072 RID: 8306 RVA: 0x000D7B56 File Offset: 0x000D5D56
		' (set) Token: 0x06002073 RID: 8307 RVA: 0x000D7B5E File Offset: 0x000D5D5E
		<oO0oooo("2201")>
		Public Property ShortCaption As String
			Get
				Return Me.o.00_OO_O_o.
			End Get
			Set(value As String)
				Me.o.00_OO_O_o. = value
			End Set
		End Property

		' Token: 0x1700076B RID: 1899
		' (get) Token: 0x06002074 RID: 8308 RVA: 0x000D7B67 File Offset: 0x000D5D67
		' (set) Token: 0x06002075 RID: 8309 RVA: 0x000D7B6F File Offset: 0x000D5D6F
		<oO0oooo("2201")>
		Public Property ShowInRecordGrid As BooleanEnum
			Get
				Return Me.o_.O___.
			End Get
			Set(value As BooleanEnum)
				Me.o_.O___. = value
			End Set
		End Property

		' Token: 0x1700076C RID: 1900
		' (get) Token: 0x06002076 RID: 8310 RVA: 0x000D7B78 File Offset: 0x000D5D78
		' (set) Token: 0x06002077 RID: 8311 RVA: 0x000D7B80 File Offset: 0x000D5D80
		<oO0oooo("2201")>
		Public Property RecordRowHeight As Integer
			Get
				Return Me.O0O_0_._o__0.
			End Get
			Set(value As Integer)
				Me.O0O_0_._o__0. = value
			End Set
		End Property

		' Token: 0x1700076D RID: 1901
		' (get) Token: 0x06002078 RID: 8312 RVA: 0x000D7B89 File Offset: 0x000D5D89
		' (set) Token: 0x06002079 RID: 8313 RVA: 0x000D7B91 File Offset: 0x000D5D91
		Friend Property EditMask As String
			Get
				Return Me.O.OO0_oo_O0.
			End Get
			Set(value As String)
				Me.O.OO0_oo_O0. = value
			End Set
		End Property

		' Token: 0x1700076E RID: 1902
		' (get) Token: 0x0600207A RID: 8314 RVA: 0x000D7B9A File Offset: 0x000D5D9A
		' (set) Token: 0x0600207B RID: 8315 RVA: 0x000D7BA2 File Offset: 0x000D5DA2
		<oO0oooo("1660")>
		Public Property ImeMode As BooleanEnum
			Get
				Return Me.Oo_o.OOO0_0OO0.
			End Get
			Set(value As BooleanEnum)
				Me.Oo_o.OOO0_0OO0. = value
			End Set
		End Property

		' Token: 0x1700076F RID: 1903
		' (get) Token: 0x0600207C RID: 8316 RVA: 0x000D7BAB File Offset: 0x000D5DAB
		' (set) Token: 0x0600207D RID: 8317 RVA: 0x000D7BB3 File Offset: 0x000D5DB3
		<oO0oooo("1306")>
		Friend Property BooleanFormat As String
			Get
				Return Me.OoOo._.
			End Get
			Set(value As String)
				Me.OoOo._. = value
			End Set
		End Property

		' Token: 0x17000770 RID: 1904
		' (get) Token: 0x0600207E RID: 8318 RVA: 0x000D7BBC File Offset: 0x000D5DBC
		' (set) Token: 0x0600207F RID: 8319 RVA: 0x000D7BC4 File Offset: 0x000D5DC4
		Friend Property TextAlign As TextAlignEnum
			Get
				Return Me.OO0.o0oO.
			End Get
			Set(value As TextAlignEnum)
				Me.OO0.o0oO. = value
			End Set
		End Property

		' Token: 0x17000771 RID: 1905
		' (get) Token: 0x06002080 RID: 8320 RVA: 0x000D7BCD File Offset: 0x000D5DCD
		' (set) Token: 0x06002081 RID: 8321 RVA: 0x000D7BD5 File Offset: 0x000D5DD5
		Friend Property TextAlignFixed As TextAlignEnum
			Get
				Return Me.O.oO_O_o.
			End Get
			Set(value As TextAlignEnum)
				Me.O.oO_O_o. = value
			End Set
		End Property

		' Token: 0x17000772 RID: 1906
		' (get) Token: 0x06002082 RID: 8322 RVA: 0x000D7BDE File Offset: 0x000D5DDE
		' (set) Token: 0x06002083 RID: 8323 RVA: 0x000D7BE6 File Offset: 0x000D5DE6
		Public Property AutoComplete As Boolean
			Get
				Return Me.O_o00o00O.0o__.
			End Get
			Set(value As Boolean)
				Me.O_o00o00O.0o__. = value
			End Set
		End Property

		' Token: 0x06002084 RID: 8324 RVA: 0x000D7BEF File Offset: 0x000D5DEF
		<oO0oooo("1468")>
		Public Sub RaiseDataColChanged()
			Me.DataTable.oO.o_0.(Me)
		End Sub

		' Token: 0x06002085 RID: 8325 RVA: 0x000D7BFD File Offset: 0x000D5DFD
		<oO0oooo("1468")>
		Public Sub RaiseDataColChanged(dataRow As DataRow)
			Me.DataTable.oO.o_0.(Me, dataRow)
		End Sub

		' Token: 0x06002086 RID: 8326 RVA: 0x000D7C0C File Offset: 0x000D5E0C
		<oO0oooo("1468")>
		Public Sub RaiseDataColChanged(Filter As String)
			Try
				For Each a_ As DataRow In Me.DataTable.[Select](Filter)
					Me.DataTable.oO.o_0.(Me, a_)
				Next
			Finally
				Dim enumerator As List(Of DataRow).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x17000773 RID: 1907
		' (get) Token: 0x06002087 RID: 8327 RVA: 0x000D7C6C File Offset: 0x000D5E6C
		' (set) Token: 0x06002088 RID: 8328 RVA: 0x000D7C74 File Offset: 0x000D5E74
		Friend Property ComboList As String
			Get
				Return Me.oO__.o_oOoO.
			End Get
			Set(value As String)
				Me.oO__.o_oOoO. = value
			End Set
		End Property

		' Token: 0x17000774 RID: 1908
		' (get) Token: 0x06002089 RID: 8329 RVA: 0x000D7C7D File Offset: 0x000D5E7D
		' (set) Token: 0x0600208A RID: 8330 RVA: 0x000D7C85 File Offset: 0x000D5E85
		Friend Property DisplayMember As String
			Get
				Return Me.OOoo_.00oOo0o.
			End Get
			Set(value As String)
				Me.OOoo_.00oOo0o. = value
			End Set
		End Property

		' Token: 0x17000775 RID: 1909
		' (get) Token: 0x0600208B RID: 8331 RVA: 0x000D7C8E File Offset: 0x000D5E8E
		' (set) Token: 0x0600208C RID: 8332 RVA: 0x000D7C96 File Offset: 0x000D5E96
		Friend Property ValueMember As String
			Get
				Return Me.OOO.o.
			End Get
			Set(value As String)
				Me.OOO.o. = value
			End Set
		End Property

		' Token: 0x17000776 RID: 1910
		' (get) Token: 0x0600208D RID: 8333 RVA: 0x000D7C9F File Offset: 0x000D5E9F
		' (set) Token: 0x0600208E RID: 8334 RVA: 0x000D7CA7 File Offset: 0x000D5EA7
		Friend Property DataSource As String
			Get
				Return Me.OO_0_00.O0.
			End Get
			Set(value As String)
				Me.OO_0_00.O0. = value
			End Set
		End Property

		' Token: 0x17000777 RID: 1911
		' (get) Token: 0x0600208F RID: 8335 RVA: 0x000D7CB0 File Offset: 0x000D5EB0
		' (set) Token: 0x06002090 RID: 8336 RVA: 0x000D7CB8 File Offset: 0x000D5EB8
		Friend Property DataFilter As String
			Get
				Return Me.O.__O00o0_O.
			End Get
			Set(value As String)
				Me.O.__O00o0_O. = value
			End Set
		End Property

		' Token: 0x17000778 RID: 1912
		' (get) Token: 0x06002091 RID: 8337 RVA: 0x000D7CC1 File Offset: 0x000D5EC1
		' (set) Token: 0x06002092 RID: 8338 RVA: 0x000D7CC9 File Offset: 0x000D5EC9
		Friend Property DataSort As String
			Get
				Return Me.O_0_.0OO.
			End Get
			Set(value As String)
				Me.O_0_.0OO. = value
			End Set
		End Property

		' Token: 0x17000779 RID: 1913
		' (get) Token: 0x06002093 RID: 8339 RVA: 0x000D7CD2 File Offset: 0x000D5ED2
		' (set) Token: 0x06002094 RID: 8340 RVA: 0x000D7CDA File Offset: 0x000D5EDA
		Friend Property AllowEditValue As Boolean
			Get
				Return Me.o0o.0_o.
			End Get
			Set(value As Boolean)
				Me.o0o.0_o. = value
			End Set
		End Property

		' Token: 0x1700077A RID: 1914
		' (get) Token: 0x06002095 RID: 8341 RVA: 0x000D7CE3 File Offset: 0x000D5EE3
		' (set) Token: 0x06002096 RID: 8342 RVA: 0x000D7CEB File Offset: 0x000D5EEB
		Friend Property MultiColumn As Boolean
			Get
				Return Me.oO0.oO0_0.
			End Get
			Set(value As Boolean)
				Me.oO0.oO0_0. = value
			End Set
		End Property

		' Token: 0x1700077B RID: 1915
		' (get) Token: 0x06002097 RID: 8343 RVA: 0x000D7CF4 File Offset: 0x000D5EF4
		' (set) Token: 0x06002098 RID: 8344 RVA: 0x000D7CFC File Offset: 0x000D5EFC
		Friend Property ColumnWidth As Integer
			Get
				Return Me.o00ooO0Oo.oo0O.
			End Get
			Set(value As Integer)
				Me.o00ooO0Oo.oo0O. = value
			End Set
		End Property

		' Token: 0x1700077C RID: 1916
		' (get) Token: 0x06002099 RID: 8345 RVA: 0x000D7D05 File Offset: 0x000D5F05
		' (set) Token: 0x0600209A RID: 8346 RVA: 0x000D7D0D File Offset: 0x000D5F0D
		Friend Property DropDownWidth As Integer
			Get
				Return Me.OO0O._.
			End Get
			Set(value As Integer)
				Me.OO0O._. = value
			End Set
		End Property

		' Token: 0x1700077D RID: 1917
		' (get) Token: 0x0600209B RID: 8347 RVA: 0x000D7D16 File Offset: 0x000D5F16
		' (set) Token: 0x0600209C RID: 8348 RVA: 0x000D7D1E File Offset: 0x000D5F1E
		Friend Property DropDownHeight As Integer
			Get
				Return Me.Oo0O0Ooo0.0o.
			End Get
			Set(value As Integer)
				Me.Oo0O0Ooo0.0o. = value
			End Set
		End Property

		' Token: 0x1700077E RID: 1918
		' (get) Token: 0x0600209D RID: 8349 RVA: 0x000D7D27 File Offset: 0x000D5F27
		' (set) Token: 0x0600209E RID: 8350 RVA: 0x000D7D2F File Offset: 0x000D5F2F
		Friend Property MaxDropDownItems As Integer
			Get
				Return Me.oo.0_0_O.
			End Get
			Set(value As Integer)
				value = Math.Max(1, value)
				Me.oo.0_0_O. = value
			End Set
		End Property

		' Token: 0x1700077F RID: 1919
		' (get) Token: 0x0600209F RID: 8351 RVA: 0x000D7D41 File Offset: 0x000D5F41
		' (set) Token: 0x060020A0 RID: 8352 RVA: 0x000D7D49 File Offset: 0x000D5F49
		Friend Property ItemSpacing As Integer
			Get
				Return Me.ooo_.O0OO0_o.
			End Get
			Set(value As Integer)
				Me.ooo_.O0OO0_o. = value
			End Set
		End Property

		' Token: 0x17000780 RID: 1920
		' (get) Token: 0x060020A1 RID: 8353 RVA: 0x000D7D52 File Offset: 0x000D5F52
		' (set) Token: 0x060020A2 RID: 8354 RVA: 0x000D7D5A File Offset: 0x000D5F5A
		Friend Property TreeFile As String
			Get
				Return Me.o._Oo0.
			End Get
			Set(value As String)
				Me.o._Oo0. = value
			End Set
		End Property

		' Token: 0x17000781 RID: 1921
		' (get) Token: 0x060020A3 RID: 8355 RVA: 0x000D7D63 File Offset: 0x000D5F63
		' (set) Token: 0x060020A4 RID: 8356 RVA: 0x000D7D6B File Offset: 0x000D5F6B
		Friend Property TreeReceiveCols As String
			Get
				Return Me.o.oO.
			End Get
			Set(value As String)
				Me.o.oO. = value
			End Set
		End Property

		' Token: 0x17000782 RID: 1922
		' (get) Token: 0x060020A5 RID: 8357 RVA: 0x000D7D74 File Offset: 0x000D5F74
		' (set) Token: 0x060020A6 RID: 8358 RVA: 0x000D7D7C File Offset: 0x000D5F7C
		Friend Property TreeSourceTable As String
			Get
				Return Me.oO.O.
			End Get
			Set(value As String)
				Me.oO.O. = value
			End Set
		End Property

		' Token: 0x17000783 RID: 1923
		' (get) Token: 0x060020A7 RID: 8359 RVA: 0x000D7D85 File Offset: 0x000D5F85
		' (set) Token: 0x060020A8 RID: 8360 RVA: 0x000D7D8D File Offset: 0x000D5F8D
		Friend Property TreeBuildCols As String
			Get
				Return Me.O0o.oo_O0o.
			End Get
			Set(value As String)
				Me.O0o.oo_O0o. = value
			End Set
		End Property

		' Token: 0x17000784 RID: 1924
		' (get) Token: 0x060020A9 RID: 8361 RVA: 0x000D7D96 File Offset: 0x000D5F96
		' (set) Token: 0x060020AA RID: 8362 RVA: 0x000D7D9E File Offset: 0x000D5F9E
		Friend Property TreeFilter As String
			Get
				Return Me.OO.O00O0_o.
			End Get
			Set(value As String)
				Me.OO.O00O0_o. = value
			End Set
		End Property

		' Token: 0x17000785 RID: 1925
		' (get) Token: 0x060020AB RID: 8363 RVA: 0x000D7DA7 File Offset: 0x000D5FA7
		' (set) Token: 0x060020AC RID: 8364 RVA: 0x000D7DAF File Offset: 0x000D5FAF
		Friend Property TreeSourceCols As String
			Get
				Return Me.Oo0_0__o_.O0.
			End Get
			Set(value As String)
				Me.Oo0_0__o_.O0. = value
			End Set
		End Property

		' Token: 0x17000786 RID: 1926
		' (get) Token: 0x060020AD RID: 8365 RVA: 0x000D7DB8 File Offset: 0x000D5FB8
		' (set) Token: 0x060020AE RID: 8366 RVA: 0x000D7DC0 File Offset: 0x000D5FC0
		Friend Property TreePathSeparator As Char
			Get
				Return Me.OO0.o0oO.
			End Get
			Set(value As Char)
				If Operators.CompareString(Conversions.ToString(value), "", True) = 0 Then
					value = "\"c
				End If
				Me.OO0.o0oO. = value
			End Set
		End Property

		' Token: 0x17000787 RID: 1927
		' (get) Token: 0x060020AF RID: 8367 RVA: 0x000D7DE0 File Offset: 0x000D5FE0
		' (set) Token: 0x060020B0 RID: 8368 RVA: 0x000D7DE8 File Offset: 0x000D5FE8
		Friend Property TreeContentSeparator As Char
			Get
				Return Me.O.oO_O_o.
			End Get
			Set(value As Char)
				If Operators.CompareString(Conversions.ToString(value), "", True) = 0 Then
					value = "|"c
				End If
				Me.O.oO_O_o. = value
			End Set
		End Property

		' Token: 0x17000788 RID: 1928
		' (get) Token: 0x060020B1 RID: 8369 RVA: 0x000D7E08 File Offset: 0x000D6008
		' (set) Token: 0x060020B2 RID: 8370 RVA: 0x000D7E10 File Offset: 0x000D6010
		Friend Property TreeSeparateContent As Boolean
			Get
				Return Me.OoO.oOo.
			End Get
			Set(value As Boolean)
				Me.OoO.oOo. = value
			End Set
		End Property

		' Token: 0x17000789 RID: 1929
		' (get) Token: 0x060020B3 RID: 8371 RVA: 0x000D7E19 File Offset: 0x000D6019
		' (set) Token: 0x060020B4 RID: 8372 RVA: 0x000D7E21 File Offset: 0x000D6021
		Friend Property DataMapType As DataMapTypeEnum
			Get
				Return Me.O0_O_OOO_.0O.
			End Get
			Set(value As DataMapTypeEnum)
				Me.O0_O_OOO_.0O. = value
			End Set
		End Property

		' Token: 0x1700078A RID: 1930
		' (get) Token: 0x060020B5 RID: 8373 RVA: 0x000D7E2A File Offset: 0x000D602A
		' (set) Token: 0x060020B6 RID: 8374 RVA: 0x000D7E32 File Offset: 0x000D6032
		Friend Property ImageMapType As ImageMapTypeEnum
			Get
				Return Me.O_0_OO0___.0oo.
			End Get
			Set(value As ImageMapTypeEnum)
				Me.O_0_OO0___.0oo. = value
			End Set
		End Property

		' Token: 0x1700078B RID: 1931
		' (get) Token: 0x060020B7 RID: 8375 RVA: 0x000D7E3B File Offset: 0x000D603B
		' (set) Token: 0x060020B8 RID: 8376 RVA: 0x000D7E43 File Offset: 0x000D6043
		Friend Property ImageAndText As Boolean
			Get
				Return Me.ooOo.__.
			End Get
			Set(value As Boolean)
				Me.ooOo.__. = value
			End Set
		End Property

		' Token: 0x1700078C RID: 1932
		' (get) Token: 0x060020B9 RID: 8377 RVA: 0x000D7E4C File Offset: 0x000D604C
		' (set) Token: 0x060020BA RID: 8378 RVA: 0x000D7E54 File Offset: 0x000D6054
		Friend Property ExtendColumnType As ExtendColumnTypeEnum
			Get
				Return Me.o0_00O.____.
			End Get
			Set(value As ExtendColumnTypeEnum)
				If Me.o0O_0_._oo. IsNot Nothing Then
					Dim extendColumnTypeEnum As ExtendColumnTypeEnum = value
					If extendColumnTypeEnum IsNot Nothing Then
						If extendColumnTypeEnum <> 5 Then
							If extendColumnTypeEnum <> 8 Then
								If Me.o0O_0_._oo..DataType IsNot GetType(String) Then
									If OO_00oOO.SystemReady Then
										MessageBox.Show("只有字符列或者备注列才能扩展为" + value.ToString() + "列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
										Return
									End If
									Return
								End If
							ElseIf Me.o0O_0_._oo..DataType IsNot GetType(Double) Then
								If OO_00oOO.SystemReady Then
									MessageBox.Show("只有双精度小数列才能扩展为时段列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Return
								End If
								Return
							End If
						ElseIf Me.o0O_0_._oo..DataType IsNot GetType(Integer) Then
							If OO_00oOO.SystemReady Then
								MessageBox.Show("只有整数列才能扩展为色彩列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Return
							End If
							Return
						End If
					End If
				End If
				Me.o0_00O.____. = value
			End Set
		End Property

		' Token: 0x1700078D RID: 1933
		' (get) Token: 0x060020BB RID: 8379 RVA: 0x000D7F38 File Offset: 0x000D6138
		' (set) Token: 0x060020BC RID: 8380 RVA: 0x000D7F40 File Offset: 0x000D6140
		<oO0oooo("1656")>
		Public Property ExtendType As ExtendTypeEnum
			Get
				Return Me.o0_00O.____.
			End Get
			Set(value As ExtendTypeEnum)
				Me.o0_00O.____. = value
				If Me.o0O_0_._oo..Table.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.DataTable Is Me.DataTable AndAlso table.Cols.Contains(Me.Name) Then
								table.Cols(Me.Name).o0.O.()
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

		' Token: 0x1700078E RID: 1934
		' (get) Token: 0x060020BD RID: 8381 RVA: 0x000D7FDC File Offset: 0x000D61DC
		' (set) Token: 0x060020BE RID: 8382 RVA: 0x000D7FE4 File Offset: 0x000D61E4
		<oO0oooo("2040")>
		Public Property Remote As Boolean
			Get
				Return Me.oO00O_.00_O00_.
			End Get
			Set(value As Boolean)
				Me.oO00O_.00_O00_. = value
				If(Me.o0O_0_._oo..Table.DataSet IsNot O_O0OO.OOOo.oo_OOOO_0.() OrElse (O_O0OO.OOOo.oo_OOOO_0.() Is Me.DataTable.BaseTable.DataSet AndAlso OO_00oOO.SystemReady)) AndAlso ((Me.ExtendType = 3 OrElse Me.ExtendType = 6 OrElse Me.ExtendType = 4) And Me.Remote) Then
					Me.o_.Oo00_O_00_.()
				End If
			End Set
		End Property

		' Token: 0x1700078F RID: 1935
		' (get) Token: 0x060020BF RID: 8383 RVA: 0x000D805A File Offset: 0x000D625A
		' (set) Token: 0x060020C0 RID: 8384 RVA: 0x000D8062 File Offset: 0x000D6262
		Friend Property Host As String
			Get
				Return Me.O_o__o_.O.
			End Get
			Set(value As String)
				Me.O_o__o_.O. = value
			End Set
		End Property

		' Token: 0x17000790 RID: 1936
		' (get) Token: 0x060020C1 RID: 8385 RVA: 0x000D806B File Offset: 0x000D626B
		' (set) Token: 0x060020C2 RID: 8386 RVA: 0x000D8073 File Offset: 0x000D6273
		Friend Property Account As String
			Get
				Return Me.O.Oo0o.
			End Get
			Set(value As String)
				Me.O.Oo0o. = value
			End Set
		End Property

		' Token: 0x17000791 RID: 1937
		' (get) Token: 0x060020C3 RID: 8387 RVA: 0x000D807C File Offset: 0x000D627C
		' (set) Token: 0x060020C4 RID: 8388 RVA: 0x000D8084 File Offset: 0x000D6284
		Friend Property Password As String
			Get
				Return Me.OoO_.0O0.
			End Get
			Set(value As String)
				Me.OoO_.0O0. = value
			End Set
		End Property

		' Token: 0x17000792 RID: 1938
		' (get) Token: 0x060020C5 RID: 8389 RVA: 0x000D808D File Offset: 0x000D628D
		' (set) Token: 0x060020C6 RID: 8390 RVA: 0x000D8095 File Offset: 0x000D6295
		Friend Property UTF8 As Boolean
			Get
				Return Me.oO00O0O0.00_Oo.
			End Get
			Set(value As Boolean)
				Me.oO00O0O0.00_Oo. = value
			End Set
		End Property

		' Token: 0x17000793 RID: 1939
		' (get) Token: 0x060020C7 RID: 8391 RVA: 0x000D809E File Offset: 0x000D629E
		' (set) Token: 0x060020C8 RID: 8392 RVA: 0x000D80A6 File Offset: 0x000D62A6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Port As Integer
			Get
				Return Me.o._0O0Oo00.
			End Get
			Set(value As Integer)
				Me.o._0O0Oo00. = value
			End Set
		End Property

		' Token: 0x17000794 RID: 1940
		' (get) Token: 0x060020C9 RID: 8393 RVA: 0x000D80AF File Offset: 0x000D62AF
		' (set) Token: 0x060020CA RID: 8394 RVA: 0x000D80B7 File Offset: 0x000D62B7
		Friend Property RootDir As String
			Get
				Return Me.O__oO.o0oO00.
			End Get
			Set(value As String)
				Me.O__oO.o0oO00. = value
			End Set
		End Property

		' Token: 0x17000795 RID: 1941
		' (get) Token: 0x060020CB RID: 8395 RVA: 0x000D80C0 File Offset: 0x000D62C0
		' (set) Token: 0x060020CC RID: 8396 RVA: 0x000D80C8 File Offset: 0x000D62C8
		Friend Property AutoDownload As Boolean
			Get
				Return Me.oOo0o0.O000.
			End Get
			Set(value As Boolean)
				Me.oOo0o0.O000. = value
			End Set
		End Property

		' Token: 0x17000796 RID: 1942
		' (get) Token: 0x060020CD RID: 8397 RVA: 0x000D80D1 File Offset: 0x000D62D1
		' (set) Token: 0x060020CE RID: 8398 RVA: 0x000D80D9 File Offset: 0x000D62D9
		Friend Property AutoUpdate As Boolean
			Get
				Return Me.OOo.0.
			End Get
			Set(value As Boolean)
				Me.OOo.0. = value
			End Set
		End Property

		' Token: 0x17000797 RID: 1943
		' (get) Token: 0x060020CF RID: 8399 RVA: 0x000D80E2 File Offset: 0x000D62E2
		' (set) Token: 0x060020D0 RID: 8400 RVA: 0x000D80EA File Offset: 0x000D62EA
		<oO0oooo("2047")>
		Public Property FileFilter As String
			Get
				Return Me.o__O.o0O0o0OoO.
			End Get
			Set(value As String)
				Me.o__O.o0O0o0OoO. = value
			End Set
		End Property

		' Token: 0x17000798 RID: 1944
		' (get) Token: 0x060020D1 RID: 8401 RVA: 0x000D80F3 File Offset: 0x000D62F3
		' (set) Token: 0x060020D2 RID: 8402 RVA: 0x000D80FB File Offset: 0x000D62FB
		<oO0oooo("2043")>
		Public Property DefaultFolder As String
			Get
				Return Me.O_0.oO.
			End Get
			Set(value As String)
				Me.O_0.oO. = value
			End Set
		End Property

		' Token: 0x17000799 RID: 1945
		' (get) Token: 0x060020D3 RID: 8403 RVA: 0x000D8104 File Offset: 0x000D6304
		' (set) Token: 0x060020D4 RID: 8404 RVA: 0x000D810C File Offset: 0x000D630C
		<oO0oooo("2499")>
		Public Property SourceFolder As String
			Get
				Return Me.O_o_0OO0.0Oo.
			End Get
			Set(value As String)
				Me.O_o_0OO0.0Oo. = value
			End Set
		End Property

		' Token: 0x1700079A RID: 1946
		' (get) Token: 0x060020D5 RID: 8405 RVA: 0x000D8115 File Offset: 0x000D6315
		' (set) Token: 0x060020D6 RID: 8406 RVA: 0x000D811D File Offset: 0x000D631D
		Friend Property LastFolder As String
			Get
				Return Me.oo00_0o_0Oo.O.
			End Get
			Set(value As String)
				Me.oo00_0o_0Oo.O. = value
			End Set
		End Property

		' Token: 0x1700079B RID: 1947
		' (get) Token: 0x060020D7 RID: 8407 RVA: 0x000D8126 File Offset: 0x000D6326
		' (set) Token: 0x060020D8 RID: 8408 RVA: 0x000D812E File Offset: 0x000D632E
		Friend Property UsetBuildInEditor As Boolean
			Get
				Return Me.o0oo__o0O.o.
			End Get
			Set(value As Boolean)
				Me.o0oo__o0O.o. = value
			End Set
		End Property

		' Token: 0x1700079C RID: 1948
		' (get) Token: 0x060020D9 RID: 8409 RVA: 0x000D8137 File Offset: 0x000D6337
		' (set) Token: 0x060020DA RID: 8410 RVA: 0x000D813F File Offset: 0x000D633F
		<oO0oooo("2046")>
		Public Property Decimals As Integer
			Get
				Return Me.ooOo.O_o.
			End Get
			Set(value As Integer)
				If value > 28 Then
					value = 28
				ElseIf value < 0 Then
					value = 0
				End If
				Me.ooOo.O_o. = value
			End Set
		End Property

		' Token: 0x1700079D RID: 1949
		' (get) Token: 0x060020DB RID: 8411 RVA: 0x000D815A File Offset: 0x000D635A
		Friend ReadOnly Property DataDictionary As IDictionary
			Get
				Return Me.ooOO.oO0o.
			End Get
		End Property

		' Token: 0x1700079E RID: 1950
		' (get) Token: 0x060020DC RID: 8412 RVA: 0x000D8162 File Offset: 0x000D6362
		Friend ReadOnly Property imageDictionary As IDictionary
			Get
				Return Me.O._00_.
			End Get
		End Property

		' Token: 0x1700079F RID: 1951
		' (get) Token: 0x060020DD RID: 8413 RVA: 0x000D816A File Offset: 0x000D636A
		Friend ReadOnly Property imageValues As String
			Get
				Return Me.O_oo0_00.__0__.
			End Get
		End Property

		' Token: 0x170007A0 RID: 1952
		' (get) Token: 0x060020DE RID: 8414 RVA: 0x000D8172 File Offset: 0x000D6372
		' (set) Token: 0x060020DF RID: 8415 RVA: 0x000D817A File Offset: 0x000D637A
		Friend Property FixedDecimals As Boolean
			Get
				Return Me.OO0O._.
			End Get
			Set(value As Boolean)
				Me.OO0O._. = value
			End Set
		End Property

		' Token: 0x170007A1 RID: 1953
		' (get) Token: 0x060020E0 RID: 8416 RVA: 0x000D8183 File Offset: 0x000D6383
		' (set) Token: 0x060020E1 RID: 8417 RVA: 0x000D818B File Offset: 0x000D638B
		Friend Property FixedDigits As Integer
			Get
				Return Me.ooo_O0oOO._.
			End Get
			Set(value As Integer)
				Me.ooo_O0oOO._. = value
			End Set
		End Property

		' Token: 0x170007A2 RID: 1954
		' (get) Token: 0x060020E2 RID: 8418 RVA: 0x000D8194 File Offset: 0x000D6394
		' (set) Token: 0x060020E3 RID: 8419 RVA: 0x000D819C File Offset: 0x000D639C
		Friend Property ThousandSeparator As Boolean
			Get
				Return Me.OoO0.O_.
			End Get
			Set(value As Boolean)
				Me.OoO0.O_. = value
			End Set
		End Property

		' Token: 0x170007A3 RID: 1955
		' (get) Token: 0x060020E4 RID: 8420 RVA: 0x000D81A5 File Offset: 0x000D63A5
		' (set) Token: 0x060020E5 RID: 8421 RVA: 0x000D81AD File Offset: 0x000D63AD
		Friend Property PercentStyle As Boolean
			Get
				Return Me.OoO00O.00.
			End Get
			Set(value As Boolean)
				Me.OoO00O.00. = value
			End Set
		End Property

		' Token: 0x170007A4 RID: 1956
		' (get) Token: 0x060020E6 RID: 8422 RVA: 0x000D81B6 File Offset: 0x000D63B6
		' (set) Token: 0x060020E7 RID: 8423 RVA: 0x000D81BE File Offset: 0x000D63BE
		Friend Property ShowCurrencySymbol As Boolean
			Get
				Return Me.o0oo_.0o.
			End Get
			Set(value As Boolean)
				Me.o0oo_.0o. = value
			End Set
		End Property

		' Token: 0x170007A5 RID: 1957
		' (get) Token: 0x060020E8 RID: 8424 RVA: 0x000D81C7 File Offset: 0x000D63C7
		' (set) Token: 0x060020E9 RID: 8425 RVA: 0x000D81CF File Offset: 0x000D63CF
		Friend Property CurrencySymbol As String
			Get
				Return Me.o0.0OOO_0OOO_o.
			End Get
			Set(value As String)
				Me.o0.0OOO_0OOO_o. = value
			End Set
		End Property

		' Token: 0x170007A6 RID: 1958
		' (get) Token: 0x060020EA RID: 8426 RVA: 0x000D81D8 File Offset: 0x000D63D8
		' (set) Token: 0x060020EB RID: 8427 RVA: 0x000D81E0 File Offset: 0x000D63E0
		Friend Property DataMap As String
			Get
				Return Me.O.ooO_oOOO.
			End Get
			Set(value As String)
				Me.O.ooO_oOOO. = value
			End Set
		End Property

		' Token: 0x170007A7 RID: 1959
		' (get) Token: 0x060020EC RID: 8428 RVA: 0x000D81E9 File Offset: 0x000D63E9
		' (set) Token: 0x060020ED RID: 8429 RVA: 0x000D81F1 File Offset: 0x000D63F1
		Friend Property ImageMap As String
			Get
				Return Me.ooOo.__.
			End Get
			Set(value As String)
				Me.ooOo.__. = value
			End Set
		End Property

		' Token: 0x170007A8 RID: 1960
		' (get) Token: 0x060020EE RID: 8430 RVA: 0x000D81FA File Offset: 0x000D63FA
		' (set) Token: 0x060020EF RID: 8431 RVA: 0x000D8202 File Offset: 0x000D6402
		Friend Property DataMapTable As String
			Get
				Return Me.o.00__O.
			End Get
			Set(value As String)
				Me.o.00__O. = value
			End Set
		End Property

		' Token: 0x170007A9 RID: 1961
		' (get) Token: 0x060020F0 RID: 8432 RVA: 0x000D820B File Offset: 0x000D640B
		' (set) Token: 0x060020F1 RID: 8433 RVA: 0x000D8213 File Offset: 0x000D6413
		Friend Property DataMapListColumns As String
			Get
				Return Me.o0o_oO.ooo0O_o.
			End Get
			Set(value As String)
				Me.o0o_oO.ooo0O_o. = value
			End Set
		End Property

		' Token: 0x170007AA RID: 1962
		' (get) Token: 0x060020F2 RID: 8434 RVA: 0x000D821C File Offset: 0x000D641C
		' (set) Token: 0x060020F3 RID: 8435 RVA: 0x000D8224 File Offset: 0x000D6424
		Friend Property DataMapValueColumn As String
			Get
				Return Me.O00.O0O_.
			End Get
			Set(value As String)
				Me.O00.O0O_. = value
			End Set
		End Property

		' Token: 0x170007AB RID: 1963
		' (get) Token: 0x060020F4 RID: 8436 RVA: 0x000D822D File Offset: 0x000D642D
		' (set) Token: 0x060020F5 RID: 8437 RVA: 0x000D8235 File Offset: 0x000D6435
		Friend Property DataMapListColumn As String
			Get
				Return Me.O.00.
			End Get
			Set(value As String)
				Me.O.00. = value
			End Set
		End Property

		' Token: 0x170007AC RID: 1964
		' (get) Token: 0x060020F6 RID: 8438 RVA: 0x000D823E File Offset: 0x000D643E
		' (set) Token: 0x060020F7 RID: 8439 RVA: 0x000D8246 File Offset: 0x000D6446
		Friend Property DataMapFilter As String
			Get
				Return Me.oO._oo.
			End Get
			Set(value As String)
				Me.oO._oo. = value
			End Set
		End Property

		' Token: 0x170007AD RID: 1965
		' (get) Token: 0x060020F8 RID: 8440 RVA: 0x000D824F File Offset: 0x000D644F
		' (set) Token: 0x060020F9 RID: 8441 RVA: 0x000D8257 File Offset: 0x000D6457
		Friend Property DataMapSort As String
			Get
				Return Me.O0o0o0__0.o_.
			End Get
			Set(value As String)
				Me.O0o0o0__0.o_. = value
			End Set
		End Property

		' Token: 0x170007AE RID: 1966
		' (get) Token: 0x060020FA RID: 8442 RVA: 0x000D8260 File Offset: 0x000D6460
		' (set) Token: 0x060020FB RID: 8443 RVA: 0x000D8268 File Offset: 0x000D6468
		Friend Property MultiDataMap As String
			Get
				Return Me.o.0O_o00O.
			End Get
			Set(value As String)
				Me.o.0O_o00O. = value
			End Set
		End Property

		' Token: 0x170007AF RID: 1967
		' (get) Token: 0x060020FC RID: 8444 RVA: 0x000D8271 File Offset: 0x000D6471
		' (set) Token: 0x060020FD RID: 8445 RVA: 0x000D8279 File Offset: 0x000D6479
		Friend Property MultiDataMapAutoKeys As Boolean
			Get
				Return Me.Oo_0Ooo.O_O0o.
			End Get
			Set(value As Boolean)
				Me.Oo_0Ooo.O_O0o. = value
			End Set
		End Property

		' Token: 0x170007B0 RID: 1968
		' (get) Token: 0x060020FE RID: 8446 RVA: 0x000D8282 File Offset: 0x000D6482
		' (set) Token: 0x060020FF RID: 8447 RVA: 0x000D828A File Offset: 0x000D648A
		Friend Property MultiDataMapDisplayCol As Integer
			Get
				Return Me.ooO.O.
			End Get
			Set(value As Integer)
				Me.ooO.O. = value
			End Set
		End Property

		' Token: 0x170007B1 RID: 1969
		' (get) Token: 0x06002100 RID: 8448 RVA: 0x000D8293 File Offset: 0x000D6493
		' (set) Token: 0x06002101 RID: 8449 RVA: 0x000D829B File Offset: 0x000D649B
		Friend Property MultiDataMapValueCol As Integer
			Get
				Return Me.O0.Oo0__O_O.
			End Get
			Set(value As Integer)
				Me.O0.Oo0__O_O. = value
			End Set
		End Property

		' Token: 0x170007B2 RID: 1970
		' (get) Token: 0x06002102 RID: 8450 RVA: 0x000D82A4 File Offset: 0x000D64A4
		' (set) Token: 0x06002103 RID: 8451 RVA: 0x000D82AC File Offset: 0x000D64AC
		Friend Property DockArea As DockAreaEnum
			Get
				Return Me.o0_00O.____.
			End Get
			Set(value As DockAreaEnum)
				Me.o0_00O.____. = value
			End Set
		End Property

		' Token: 0x170007B3 RID: 1971
		' (get) Token: 0x06002104 RID: 8452 RVA: 0x000D82B5 File Offset: 0x000D64B5
		' (set) Token: 0x06002105 RID: 8453 RVA: 0x000D82BD File Offset: 0x000D64BD
		Friend Property DockTitle As Boolean
			Get
				Return Me.ooo0O0_o00.0o_.
			End Get
			Set(value As Boolean)
				Me.ooo0O0_o00.0o_. = value
			End Set
		End Property

		' Token: 0x170007B4 RID: 1972
		' (get) Token: 0x06002106 RID: 8454 RVA: 0x000D82C6 File Offset: 0x000D64C6
		' (set) Token: 0x06002107 RID: 8455 RVA: 0x000D82CE File Offset: 0x000D64CE
		Friend Property AutoHide As Boolean
			Get
				Return Me.OO.00o_Oo_o0_0.
			End Get
			Set(value As Boolean)
				Me.OO.00o_Oo_o0_0. = value
			End Set
		End Property

		' Token: 0x170007B5 RID: 1973
		' (get) Token: 0x06002108 RID: 8456 RVA: 0x000D82D7 File Offset: 0x000D64D7
		' (set) Token: 0x06002109 RID: 8457 RVA: 0x000D82DF File Offset: 0x000D64DF
		Friend Property ShowCaption As Boolean
			Get
				Return Me.O_O_0000O.o.
			End Get
			Set(value As Boolean)
				Me.O_O_0000O.o. = value
			End Set
		End Property

		' Token: 0x170007B6 RID: 1974
		' (get) Token: 0x0600210A RID: 8458 RVA: 0x000D82E8 File Offset: 0x000D64E8
		' (set) Token: 0x0600210B RID: 8459 RVA: 0x000D82F0 File Offset: 0x000D64F0
		Friend Property AllowClose As Boolean
			Get
				Return Me.ooo0__o_o_o._.
			End Get
			Set(value As Boolean)
				Me.ooo0__o_o_o._. = value
			End Set
		End Property

		' Token: 0x170007B7 RID: 1975
		' (get) Token: 0x0600210C RID: 8460 RVA: 0x000D82F9 File Offset: 0x000D64F9
		' (set) Token: 0x0600210D RID: 8461 RVA: 0x000D8301 File Offset: 0x000D6501
		Friend Property CustomImage As String
			Get
				Return Me.O0._o_.
			End Get
			Set(value As String)
				Me.O0._o_. = value
			End Set
		End Property

		' Token: 0x170007B8 RID: 1976
		' (get) Token: 0x0600210E RID: 8462 RVA: 0x000D830A File Offset: 0x000D650A
		' (set) Token: 0x0600210F RID: 8463 RVA: 0x000D8312 File Offset: 0x000D6512
		Friend Property AutoOpen As Boolean
			Get
				Return Me.O__0o0Oo_.O_.
			End Get
			Set(value As Boolean)
				Me.O__0o0Oo_.O_. = value
			End Set
		End Property

		' Token: 0x170007B9 RID: 1977
		' (get) Token: 0x06002110 RID: 8464 RVA: 0x000D831B File Offset: 0x000D651B
		' (set) Token: 0x06002111 RID: 8465 RVA: 0x000D8323 File Offset: 0x000D6523
		<oO0oooo("0088")>
		Public Property AutoDeleteAttachFile As BooleanEnum
			Get
				Return Me.o_O_00._O__.
			End Get
			Set(value As BooleanEnum)
				Me.o_O_00._O__. = value
			End Set
		End Property

		' Token: 0x170007BA RID: 1978
		' (get) Token: 0x06002112 RID: 8466 RVA: 0x000D832C File Offset: 0x000D652C
		' (set) Token: 0x06002113 RID: 8467 RVA: 0x000D8334 File Offset: 0x000D6534
		<oO0oooo("0088")>
		Public Property AutoCopyAttachFile As BooleanEnum
			Get
				Return Me.O0.00oOoOO0Oo_.
			End Get
			Set(value As BooleanEnum)
				Me.O0.00oOoOO0Oo_. = value
			End Set
		End Property

		' Token: 0x06002114 RID: 8468 RVA: 0x000D8340 File Offset: 0x000D6540
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Operators.CompareString(A_0.Substring(1, 1), ":", True) <> 0 AndAlso Not A_0.StartsWith("\\") Then
				If Me.Remote Then
					A_0 = OO_00oOO.ProjectPath + "RemoteFiles\" + A_0.Replace("/", "\").Trim(New Char() { "\"c })
				Else
					If Operators.CompareString(Me.DefaultFolder, "", True) > 0 Then
						A_0 = Me.DefaultFolder.TrimEnd(New Char() { "\"c }) + "\" + A_0
						If Operators.CompareString(A_0.Substring(1, 1), ":", True) <> 0 AndAlso Not A_0.StartsWith("\\") Then
							A_0 = OO_00oOO.ProjectPath + "Attachments\" + A_0.Trim(New Char() { "\"c })
						End If
					Else
						A_0 = ooO.OoO0o_o___.O.(A_0)
					End If
					If Not A_0.StartsWith(OO_00oOO.ProjectPath, StringComparison.CurrentCultureIgnoreCase) AndAlso (Operators.CompareString(Me.DefaultFolder, "", True) <= 0 OrElse Not A_0.StartsWith(Me.DefaultFolder, StringComparison.CurrentCultureIgnoreCase)) Then
						Return
					End If
				End If
			End If
			If c.OOOOO.o.().FileSystem.FileExists(A_0) Then
				Try
					c.OOOOO.o.().FileSystem.DeleteFile(A_0)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x04000D5B RID: 3419
		Private <<EMPTY_NAME>> As DataColumn

		' Token: 0x04000D5C RID: 3420
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D5D RID: 3421
		Private <<EMPTY_NAME>> As DataColumnProperty

		' Token: 0x04000D5E RID: 3422
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D5F RID: 3423
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D60 RID: 3424
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000D61 RID: 3425
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D62 RID: 3426
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D63 RID: 3427
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D64 RID: 3428
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D65 RID: 3429
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D66 RID: 3430
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000D67 RID: 3431
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000D68 RID: 3432
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000D69 RID: 3433
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D6A RID: 3434
		Private <<EMPTY_NAME>> As DateTimeFormatEnum

		' Token: 0x04000D6B RID: 3435
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D6C RID: 3436
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D6D RID: 3437
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D6E RID: 3438
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D6F RID: 3439
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D70 RID: 3440
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D71 RID: 3441
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D72 RID: 3442
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D73 RID: 3443
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D74 RID: 3444
		Private <<EMPTY_NAME>> As DataMapTypeEnum

		' Token: 0x04000D75 RID: 3445
		Private <<EMPTY_NAME>> As ImageMapTypeEnum

		' Token: 0x04000D76 RID: 3446
		Private <<EMPTY_NAME>> As TextAlignEnum

		' Token: 0x04000D77 RID: 3447
		Private <<EMPTY_NAME>> As TextAlignEnum

		' Token: 0x04000D78 RID: 3448
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D79 RID: 3449
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D7A RID: 3450
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D7B RID: 3451
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D7C RID: 3452
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D7D RID: 3453
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D7E RID: 3454
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D7F RID: 3455
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D80 RID: 3456
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D81 RID: 3457
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D82 RID: 3458
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D83 RID: 3459
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D84 RID: 3460
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D85 RID: 3461
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D86 RID: 3462
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D87 RID: 3463
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D88 RID: 3464
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D89 RID: 3465
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D8A RID: 3466
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D8B RID: 3467
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D8C RID: 3468
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D8D RID: 3469
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D8E RID: 3470
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D8F RID: 3471
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D90 RID: 3472
		Private <<EMPTY_NAME>> As Char

		' Token: 0x04000D91 RID: 3473
		Private <<EMPTY_NAME>> As Char

		' Token: 0x04000D92 RID: 3474
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D93 RID: 3475
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D94 RID: 3476
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D95 RID: 3477
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D96 RID: 3478
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D97 RID: 3479
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D98 RID: 3480
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D99 RID: 3481
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D9A RID: 3482
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D9B RID: 3483
		Private <<EMPTY_NAME>> As ExtendColumnTypeEnum

		' Token: 0x04000D9C RID: 3484
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D9D RID: 3485
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D9E RID: 3486
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D9F RID: 3487
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DA0 RID: 3488
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DA1 RID: 3489
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04000DA2 RID: 3490
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DA3 RID: 3491
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000DA4 RID: 3492
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DA5 RID: 3493
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DA6 RID: 3494
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DA7 RID: 3495
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DA8 RID: 3496
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DA9 RID: 3497
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DAA RID: 3498
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DAB RID: 3499
		Private <<EMPTY_NAME>> As DockAreaEnum

		' Token: 0x04000DAC RID: 3500
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DAD RID: 3501
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DAE RID: 3502
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DAF RID: 3503
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DB0 RID: 3504
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DB1 RID: 3505
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DB2 RID: 3506
		Private <<EMPTY_NAME>> As IDictionary

		' Token: 0x04000DB3 RID: 3507
		Private <<EMPTY_NAME>> As IDictionary

		' Token: 0x04000DB4 RID: 3508
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000DB5 RID: 3509
		Friend <<EMPTY_NAME>> As Control

		' Token: 0x04000DB6 RID: 3510
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DB7 RID: 3511
		Friend <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000DB8 RID: 3512
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DB9 RID: 3513
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000DBA RID: 3514
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
