Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports C1.C1Excel
Imports Foxtable.My
Imports Foxtable.XLS
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200032D RID: 813
	<oO0oooo("0683")>
	<ComVisible(True)>
	Public Class Exporter
		' Token: 0x06003050 RID: 12368 RVA: 0x00137589 File Offset: 0x00135789
		Public Sub New()
			Me.O.0o_0o_. = "Access"
			Me.oo0oO0__.O0O_. = True
			Me.O_0_O.OoO_0_0O. = New C1XLBook()
		End Sub

		' Token: 0x17000CA8 RID: 3240
		' (get) Token: 0x06003051 RID: 12369 RVA: 0x001375AE File Offset: 0x001357AE
		' (set) Token: 0x06003052 RID: 12370 RVA: 0x001375B6 File Offset: 0x001357B6
		Public Property SourceTableName As String
			Get
				Return Me.oo0oO0__.O0O_.
			End Get
			Set(value As String)
				Me.oo0oO0__.O0O_. = value
				Me.O_0_O.OoO_0_0O. = OO_00oOO.DataTables(value)
			End Set
		End Property

		' Token: 0x17000CA9 RID: 3241
		' (get) Token: 0x06003053 RID: 12371 RVA: 0x001375D0 File Offset: 0x001357D0
		' (set) Token: 0x06003054 RID: 12372 RVA: 0x001375D8 File Offset: 0x001357D8
		Public Property Filter As String
			Get
				Return Me.Oo0.o.
			End Get
			Set(value As String)
				Me.Oo0.o. = value
			End Set
		End Property

		' Token: 0x17000CAA RID: 3242
		' (get) Token: 0x06003055 RID: 12373 RVA: 0x001375E1 File Offset: 0x001357E1
		' (set) Token: 0x06003056 RID: 12374 RVA: 0x001375E9 File Offset: 0x001357E9
		Public Property Fields As String
			Get
				Return Me.O00._0O.
			End Get
			Set(value As String)
				Me.O00._0O. = value
			End Set
		End Property

		' Token: 0x17000CAB RID: 3243
		' (get) Token: 0x06003057 RID: 12375 RVA: 0x001375F2 File Offset: 0x001357F2
		' (set) Token: 0x06003058 RID: 12376 RVA: 0x001375FA File Offset: 0x001357FA
		Public Property FilePath As String
			Get
				Return Me.O0._0__oO_.
			End Get
			Set(value As String)
				Me.O0._0__oO_. = value
			End Set
		End Property

		' Token: 0x17000CAC RID: 3244
		' (get) Token: 0x06003059 RID: 12377 RVA: 0x00137603 File Offset: 0x00135803
		' (set) Token: 0x0600305A RID: 12378 RVA: 0x0013760B File Offset: 0x0013580B
		Public Property NewTableName As String
			Get
				Return Me.O0.o.
			End Get
			Set(value As String)
				Me.O0.o. = value
			End Set
		End Property

		' Token: 0x17000CAD RID: 3245
		' (get) Token: 0x0600305B RID: 12379 RVA: 0x00137614 File Offset: 0x00135814
		' (set) Token: 0x0600305C RID: 12380 RVA: 0x0013761C File Offset: 0x0013581C
		Public Property Format As String
			Get
				Return Me.O.0o_0o_.
			End Get
			Set(value As String)
				Me.O.0o_0o_. = value
			End Set
		End Property

		' Token: 0x17000CAE RID: 3246
		' (get) Token: 0x0600305D RID: 12381 RVA: 0x00137625 File Offset: 0x00135825
		' (set) Token: 0x0600305E RID: 12382 RVA: 0x0013762D File Offset: 0x0013582D
		Public Property PassWord As String
			Get
				Return Me.O0_0Oo.O0Oo_.
			End Get
			Set(value As String)
				Me.O0_0Oo.O0Oo_. = value
			End Set
		End Property

		' Token: 0x17000CAF RID: 3247
		' (get) Token: 0x0600305F RID: 12383 RVA: 0x00137636 File Offset: 0x00135836
		' (set) Token: 0x06003060 RID: 12384 RVA: 0x0013763E File Offset: 0x0013583E
		Public Property Header As Boolean
			Get
				Return Me.oo0oO0__.O0O_.
			End Get
			Set(value As Boolean)
				Me.oo0oO0__.O0O_. = value
			End Set
		End Property

		' Token: 0x06003061 RID: 12385 RVA: 0x00137648 File Offset: 0x00135848
		Public Sub Export()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Information.Err().Clear()
				IL_13:
				num2 = 3
				Dim oleDbCommand As OleDbCommand = New OleDbCommand()
				IL_1C:
				num2 = 4
				Dim text As String = ""
				IL_25:
				num2 = 5
				Dim text2 As String = OO_00oOO.FileSys.GetParentPath(OO_00oOO.FileSys.GetTempFileName()) + "\" + OoOo0O.OO_o.0o_O.(6) + ".tmp"
				IL_52:
				num2 = 6
				Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(Me.FilePath)
				IL_66:
				num2 = 7
				If OO_00oOO.FileSys.DirectoryExists(parentPath) Then
					GoTo IL_84
				End If
				IL_76:
				num2 = 8
				OO_00oOO.FileSys.CreateDirectory(parentPath)
				IL_84:
				num2 = 9
				If Operators.CompareString(Me.Fields, "", True) <> 0 Then
					GoTo IL_15F
				End If
				IL_9D:
				num2 = 10
				Dim enumerator As IEnumerator(Of DataCol) = OO_00oOO.DataTables(Me.SourceTableName).DataCols.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataCol As DataCol = enumerator.Current
					IL_CA:
					num2 = 11
					If Not dataCol.IsTemporary OrElse OO_00oOO.DataTables(Me.SourceTableName).frd_IsTemporary Then
						IL_ED:
						num2 = 12
						If Operators.CompareString(Me.Fields, "", True) > 0 Then
							IL_104:
							num2 = 13
							Me.Fields += ","
						End If
						IL_11D:
						num2 = 14
						Me.Fields = Me.Fields + "[" + dataCol.Name + "]"
					End If
					IL_142:
					num2 = 15
				End While
				IL_151:
				num2 = 16
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_15F:
				num2 = 17
				If Operators.CompareString(Me.O_0_O.OoO_0_0O..O_.__0., "", True) <= 0 OrElse Not Me.O_0_O.OoO_0_0O..BaseTable.Columns.Contains("_SortKey") OrElse Not Me.O_0_O.OoO_0_0O..frd_IsInnerTable Then
					GoTo IL_1AE
				End If
				IL_1A4:
				num2 = 18
				text = " Order By [_SortKey] "
				IL_1AE:
				num2 = 19
				If Operators.CompareString(Me.O_0_O.OoO_0_0O..o._OOO0oOo0__., "", True) <= 0 Then
					GoTo IL_1DC
				End If
				IL_1CA:
				num2 = 20
				Dim text3 As String = Me.O_0_O.OoO_0_0O..o._OOO0oOo0__.
				GoTo IL_1EC
				IL_1DC:
				num2 = 22
				text3 = Me.O_0_O.OoO_0_0O..Name
				IL_1EC:
				num2 = 23
				If Me.O_0_O.OoO_0_0O..frd_Connection IsNot O_O0OO.OoO.0OO__0ooo.() OrElse Not Me.O_0_O.OoO_0_0O..frd_IsInnerTable OrElse Operators.CompareString(Me.O_0_O.OoO_0_0O..DataServer, "", True) <> 0 Then
					GoTo IL_273
				End If
				IL_226:
				num2 = 24
				If Not Me.Format.EndsWith("2007") Then
					GoTo IL_259
				End If
				IL_23B:
				num2 = 25
				oleDbCommand.Connection = New OleDbConnection(Oo00.OOO_O0O0.o.(OO_00oOO.ProjectFile))
				GoTo IL_AAA
				IL_259:
				num2 = 27
				oleDbCommand.Connection = Me.O_0_O.OoO_0_0O..frd_Connection
				GoTo IL_AAA
				IL_273:
				num2 = 29
				If Operators.CompareString(Me.O_0_O.OoO_0_0O..DataServer, "", True) <> 0 OrElse Not Me.O_0_O.OoO_0_0O..frd_IsOuterTable OrElse (Operators.CompareString(Me.O_0_O.OoO_0_0O..frd_Connection.Provider, "Microsoft.Jet.OLEDB.4.0", True) <> 0 AndAlso Operators.CompareString(Me.O_0_O.OoO_0_0O..frd_Connection.Provider, "Microsoft.ACE.OLEDB.12.0", True) <> 0) Then
					GoTo IL_333
				End If
				IL_2DB:
				num2 = 30
				If Not Me.Format.EndsWith("2007") Then
					GoTo IL_319
				End If
				IL_2F0:
				num2 = 31
				oleDbCommand.Connection = New OleDbConnection(Oo00.OOO_O0O0.o.(Me.O_0_O.OoO_0_0O..frd_Connection.DataSource))
				GoTo IL_AAA
				IL_319:
				num2 = 33
				oleDbCommand.Connection = Me.O_0_O.OoO_0_0O..frd_Connection
				GoTo IL_AAA
				IL_333:
				num2 = 35
				text3 = Me.O_0_O.OoO_0_0O..Name
				IL_343:
				num2 = 36
				Dim catalog As Catalog = New CatalogClass()
				IL_34D:
				num2 = 37
				Dim table As Table = New TableClass()
				IL_357:
				num2 = 38
				Dim index As Index = New IndexClass()
				IL_361:
				num2 = 39
				Dim list As List(Of String) = New List(Of String)()
				IL_36B:
				num2 = 40
				If Not OO_00oOO.FileSys.FileExists(text2) Then
					GoTo IL_38B
				End If
				IL_37C:
				num2 = 41
				OO_00oOO.FileSys.DeleteFile(text2)
				IL_38B:
				num2 = 42
				catalog.Create(Oo00.o00.0OO.(text2))
				IL_39D:
				num2 = 43
				table = New TableClass()
				IL_3A7:
				num2 = 44
				index = New IndexClass()
				IL_3B1:
				num2 = 45
				table.Name = text3
				IL_3BD:
				num2 = 46
				table.ParentCatalog = catalog
				IL_3C9:
				num2 = 47
				list.AddRange(Me.Fields.ToLower().Split(New Char() { ","c, " "c, "["c, "]"c }, StringSplitOptions.RemoveEmptyEntries))
				IL_3F5:
				num2 = 48
				For Each dataColumn As DataColumn In Me.O_0_O.OoO_0_0O..BaseTable.PrimaryKey
					IL_416:
					num2 = 49
					If Not list.Contains(dataColumn.ColumnName.ToLower()) Then
						IL_42E:
						num2 = 50
						list.Add(dataColumn.ColumnName.ToLower())
					End If
					IL_444:
					num2 = 51
				Next
				IL_455:
				num2 = 52
				Dim enumerator2 As IEnumerator = Me.O_0_O.OoO_0_0O..BaseTable.Columns.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj As Object = enumerator2.Current
					Dim dataColumn2 As DataColumn = CType(obj, DataColumn)
					IL_482:
					num2 = 53
					If list.Contains(dataColumn2.ColumnName.ToLower()) Then
						IL_49D:
						num2 = 55
						Dim name As String = dataColumn2.DataType.Name
						IL_4AE:
						num2 = 57
						If Operators.CompareString(name, "String", True) = 0 Then
							IL_4C0:
							num2 = 58
							If dataColumn2.MaxLength < 0 OrElse dataColumn2.MaxLength > 255 Then
								IL_4DB:
								num2 = 59
								table.Columns.Append(dataColumn2.ColumnName, 203, 0)
							Else
								IL_4FC:
								num2 = 61
								table.Columns.Append(dataColumn2.ColumnName, 202, dataColumn2.MaxLength)
							End If
						Else
							IL_523:
							num2 = 63
							If Operators.CompareString(name, "DateTime", True) = 0 Then
								IL_535:
								num2 = 64
								table.Columns.Append(dataColumn2.ColumnName, 7, 0)
							Else
								IL_552:
								num2 = 66
								If Operators.CompareString(name, "Boolean", True) = 0 Then
									IL_564:
									num2 = 67
									table.Columns.Append(dataColumn2.ColumnName, 11, 0)
								Else
									IL_582:
									num2 = 69
									If Operators.CompareString(name, "Double", True) = 0 Then
										IL_594:
										num2 = 70
										table.Columns.Append(dataColumn2.ColumnName, 5, 0)
									Else
										IL_5B1:
										num2 = 72
										If Operators.CompareString(name, "Single", True) = 0 Then
											IL_5C3:
											num2 = 73
											table.Columns.Append(dataColumn2.ColumnName, 4, 0)
										Else
											IL_5E0:
											num2 = 75
											If Operators.CompareString(name, "Decimal", True) = 0 Then
												IL_5F2:
												num2 = 76
												table.Columns.Append(dataColumn2.ColumnName, 131, 0)
											Else
												IL_613:
												num2 = 78
												If Operators.CompareString(name, "Int64", True) = 0 Then
													IL_625:
													num2 = 79
													table.Columns.Append(dataColumn2.ColumnName, 3, 0)
												Else
													IL_642:
													num2 = 81
													If Operators.CompareString(name, "Int32", True) = 0 Then
														IL_654:
														num2 = 82
														table.Columns.Append(dataColumn2.ColumnName, 3, 0)
													Else
														IL_66E:
														num2 = 84
														If Operators.CompareString(name, "Int16", True) = 0 Then
															IL_680:
															num2 = 85
															table.Columns.Append(dataColumn2.ColumnName, 2, 0)
														Else
															IL_69A:
															num2 = 87
															If Operators.CompareString(name, "Byte", True) <> 0 Then
																GoTo IL_759
															End If
															IL_6AF:
															num2 = 88
															table.Columns.Append(dataColumn2.ColumnName, 17, 0)
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
						IL_6C8:
						num2 = 91
						Dim column As Column = table.Columns(dataColumn2.ColumnName)
						IL_6E0:
						num2 = 92
						If column.Type = 131 Then
							IL_6F1:
							num2 = 93
							column.Precision = 28
							IL_6FD:
							num2 = 94
							If Me.O_0_O.OoO_0_0O..DataCols.Contains(dataColumn2.ColumnName) Then
								IL_719:
								num2 = 95
								column.NumericScale = CByte(Me.O_0_O.OoO_0_0O..DataCols(dataColumn2.ColumnName).Decimals)
							End If
						End If
						IL_740:
						num2 = 96
						If column.Type <> 11 Then
							IL_74E:
							num2 = 97
							column.Attributes = 2
						End If
					End If
					IL_759:
					num2 = 98
				End While
				IL_768:
				num2 = 99
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_780:
				num2 = 100
				index.Name = "PrimaryKey"
				IL_78F:
				num2 = 101
				If Me.O_0_O.OoO_0_0O..BaseTable.PrimaryKey.Length <= 0 Then
					GoTo IL_803
				End If
				IL_7A7:
				num2 = 102
				Dim num3 As Integer = Me.O_0_O.OoO_0_0O..BaseTable.PrimaryKey.Length - 1
				For j As Integer = 0 To num3
					IL_7C5:
					num2 = 103
					index.Columns.Append(Me.O_0_O.OoO_0_0O..BaseTable.PrimaryKey(j).ColumnName, 202, 0)
					IL_7F2:
					num2 = 104
				Next
				GoTo IL_861
				IL_803:
				num2 = 106
				table.Columns.Append("_Identify", 3, 0)
				IL_819:
				num2 = 107
				index.Columns.Append("_Identify", 202, 0)
				IL_833:
				num2 = 108
				table.Columns("_Identify").Properties("AutoIncrement").Value = True
				IL_861:
				num2 = 109
				index.PrimaryKey = True
				IL_86C:
				num2 = 110
				index.Unique = True
				IL_877:
				num2 = 111
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
				IL_892:
				num2 = 112
				catalog.Tables.Append(table)
				IL_8A3:
				num2 = 113
				CType(catalog.ActiveConnection, Connection).Close()
				IL_8B7:
				num2 = 114
				catalog = Nothing
				IL_8BD:
				num2 = 115
				If Information.Err().Number = 0 Then
					GoTo IL_8EC
				End If
				IL_8CC:
				num2 = 116
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_12E9
				IL_8EC:
				num2 = 118
				If Not Me.Format.EndsWith("2007") Then
					GoTo IL_914
				End If
				IL_901:
				num2 = 119
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Oo00.OOO_O0O0.o.(text2))
				GoTo IL_925
				IL_914:
				num2 = 121
				oleDbConnection = New OleDbConnection(Oo00.o_._0OOo.(text2))
				IL_925:
				num2 = 122
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("Select * From [" + Me.O_0_O.OoO_0_0O..Name + "]", oleDbConnection)
				IL_94B:
				num2 = 123
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
				IL_955:
				num2 = 124
				Dim dataTable As DataTable = New DataTable()
				IL_95F:
				num2 = 125
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				IL_96D:
				num2 = 126
				oleDbDataAdapter.Fill(dataTable)
				IL_97A:
				num2 = 127
				For Each dataRow As DataRow In Me.O_0_O.OoO_0_0O..BaseTable.[Select](Me.Filter, "")
					IL_9A9:
					num2 = 128
					Dim dataRow2 As DataRow = dataTable.NewRow()
					IL_9B8:
					num2 = 129
					Dim enumerator3 As List(Of String).Enumerator = list.GetEnumerator()
					While enumerator3.MoveNext()
						Dim columnName As String = enumerator3.Current
						IL_9D2:
						num2 = 130
						dataRow2(columnName) = RuntimeHelpers.GetObjectValue(dataRow(columnName))
						IL_9EF:
						num2 = 131
					End While
					IL_9FE:
					num2 = 132
					CType(enumerator3, IDisposable).Dispose()
					IL_A11:
					num2 = 133
					dataTable.Rows.Add(dataRow2)
					IL_A25:
					num2 = 134
				Next
				IL_A3C:
				num2 = 135
				oleDbConnection.Open()
				IL_A49:
				num2 = 136
				oleDbDataAdapter.Update(dataTable)
				IL_A59:
				num2 = 137
				oleDbConnection.Close()
				IL_A66:
				num2 = 138
				oleDbCommand.Connection = oleDbConnection
				IL_A75:
				num2 = 139
				If Information.Err().Number = 0 Then
					GoTo IL_AAA
				End If
				IL_A87:
				num2 = 140
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_12E9
				IL_AAA:
				num2 = 142
				If Operators.CompareString(Me.NewTableName, "", True) <> 0 Then
					GoTo IL_AD5
				End If
				IL_AC3:
				num2 = 143
				Me.NewTableName = Me.SourceTableName
				IL_AD5:
				num2 = 144
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbCommand.Connection) Then
					GoTo IL_B43
				End If
				IL_AE9:
				num2 = 145
				Me.Fields = Me.Fields.Replace("[", """").Replace("]", """")
				IL_B19:
				num2 = 146
				text = text.Replace("[", """").Replace("]", """")
				GoTo IL_B5C
				IL_B43:
				num2 = 148
				text3 = "[" + text3 + "]"
				IL_B5C:
				num2 = 149
				If Operators.CompareString(Me.Format, "", True) <> 0 AndAlso Operators.CompareString(Me.Format, "access", True) <> 0 AndAlso Operators.CompareString(Me.Format, "access2007", True) <> 0 AndAlso Operators.CompareString(Me.Format, "access 2007", True) <> 0 Then
					GoTo IL_D73
				End If
				IL_BB1:
				num2 = 150
				If Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(Me.FilePath) Then
					GoTo IL_C8D
				End If
				IL_BD1:
				num2 = 151
				Dim catalog2 As Catalog = New CatalogClass()
				IL_BDE:
				num2 = 152
				If Me.Format.IndexOf("2007") <= 0 Then
					GoTo IL_C11
				End If
				IL_BF7:
				num2 = 153
				Dim text4 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Me.FilePath
				GoTo IL_C29
				IL_C11:
				num2 = 155
				text4 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Me.FilePath
				IL_C29:
				num2 = 156
				If Operators.CompareString(Me.PassWord, "", True) <= 0 Then
					GoTo IL_C5D
				End If
				IL_C43:
				num2 = 157
				text4 = text4 + ";Jet OLEDB:Database Password=" + Me.PassWord
				IL_C5D:
				num2 = 158
				catalog2.Create(text4)
				IL_C6D:
				num2 = 159
				CType(catalog2.ActiveConnection, Connection).Close()
				IL_C84:
				num2 = 160
				catalog2 = Nothing
				IL_C8D:
				num2 = 161
				If Operators.CompareString(Me.PassWord, "", True) <> 0 Then
					GoTo IL_D03
				End If
				IL_CA6:
				num2 = 162
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [;DATABASE=", Me.FilePath, "].[", Me.NewTableName, "] From ", text3 })
				GoTo IL_11C4
				IL_D03:
				num2 = 164
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [;DATABASE=", Me.FilePath, ";PWD=", Me.PassWord, "].[", Me.NewTableName, "] From ", text3 })
				GoTo IL_11C4
				IL_D73:
				num2 = 166
				If Operators.CompareString(Me.Format, "dbase", True) <> 0 Then
					GoTo IL_DE9
				End If
				IL_D8C:
				num2 = 167
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [dBASE IV;DATABASE=", Me.FilePath, "].[", Me.NewTableName, "] From ", text3 })
				GoTo IL_11C4
				IL_DE9:
				num2 = 169
				If Operators.CompareString(Me.Format, "excel", True) <> 0 Then
					GoTo IL_E5F
				End If
				IL_E02:
				num2 = 170
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [EXCEL 8.0;DATABASE=", Me.FilePath, "].[", Me.NewTableName, "] From ", text3 })
				GoTo IL_11C4
				IL_E5F:
				num2 = 172
				If Operators.CompareString(Me.Format, "excel2007", True) <> 0 AndAlso Operators.CompareString(Me.Format, "excel 2007", True) <> 0 Then
					GoTo IL_F3E
				End If
				IL_E8E:
				num2 = 173
				If Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(Me.FilePath) Then
					GoTo IL_EE1
				End If
				IL_EAB:
				num2 = 174
				Me.O_0_O.OoO_0_0O. = New C1XLBook()
				IL_EBC:
				num2 = 175
				Me.O_0_O.OoO_0_0O..Save(Me.FilePath, 2)
				IL_ED4:
				num2 = 176
				Me.Oo0.o. = True
				IL_EE1:
				num2 = 177
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [EXCEL 12.0;DATABASE=", Me.FilePath, "].[", Me.NewTableName, "] From ", text3 })
				GoTo IL_11C4
				IL_F3E:
				num2 = 179
				Dim file As String = Foxtable.My.c.OOOOO.o.().FileSystem.CombinePath(Me.FilePath, Me.NewTableName)
				IL_F60:
				num2 = 180
				If Not Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(file) Then
					GoTo IL_F8E
				End If
				IL_F78:
				num2 = 181
				Foxtable.My.c.OOOOO.o.().FileSystem.DeleteFile(file)
				IL_F8E:
				num2 = 182
				file = Foxtable.My.c.OOOOO.o.().FileSystem.CombinePath(Me.FilePath, "schema.ini")
				IL_FAF:
				num2 = 183
				If Not Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(file) Then
					GoTo IL_FDD
				End If
				IL_FC7:
				num2 = 184
				Foxtable.My.c.OOOOO.o.().FileSystem.DeleteFile(file)
				IL_FDD:
				num2 = 185
				If Me.Format.IndexOf("Delimited", StringComparison.CurrentCultureIgnoreCase) < 0 Then
					GoTo IL_10E8
				End If
				IL_FFA:
				num2 = 186
				If Not Me.Header Then
					GoTo IL_1078
				End If
				IL_1008:
				num2 = 187
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [text;FMT=", Me.Format, ";DATABASE=", Me.FilePath, "].[", Me.NewTableName, "#txt] From ", text3 })
				GoTo IL_11C4
				IL_1078:
				num2 = 189
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [text;HDR=No;FMT=", Me.Format, ";DATABASE=", Me.FilePath, "].[", Me.NewTableName, "#txt] From ", text3 })
				GoTo IL_11C4
				IL_10E8:
				num2 = 191
				If Operators.CompareString(Me.Format, "Fixed", True) <> 0 Then
					GoTo IL_11C4
				End If
				IL_1104:
				num2 = 192
				If Not Me.Header Then
					GoTo IL_116C
				End If
				IL_1112:
				num2 = 193
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [text;HDR=Yes;FMT=Fixed;DATABASE=", Me.FilePath, "].[", Me.NewTableName, "#txt] From ", text3 })
				GoTo IL_11C4
				IL_116C:
				num2 = 195
				oleDbCommand.CommandText = String.Concat(New String() { "Select ", Me.Fields, " INTO [text;HDR=No;FMT=Fixed;DATABASE=", Me.FilePath, "].[", Me.NewTableName, "#txt] From ", text3 })
				IL_11C4:
				num2 = 196
				If Operators.CompareString(Me.Filter, "", True) <= 0 Then
					GoTo IL_1202
				End If
				IL_11DE:
				num2 = 197
				oleDbCommand.CommandText = oleDbCommand.CommandText + " Where " + Me.Filter
				IL_1202:
				num2 = 198
				oleDbCommand.CommandText += text
				IL_121D:
				num2 = 199
				Me.O0o.__O.(oleDbCommand, text2, False)
				IL_122E:
				num2 = 200
				If Not Me.Oo0.o. Then
					GoTo IL_12E9
				End If
				IL_123F:
				num2 = 201
				Dim book As Book = New Book(Me.FilePath)
				IL_1252:
				num2 = 202
				Dim enumerator4 As IEnumerator(Of Sheet) = book.Sheets.GetEnumerator()
				While enumerator4.MoveNext()
					Dim sheet As Sheet = enumerator4.Current
					IL_1271:
					num2 = 203
					If Operators.CompareString(sheet.Name, "Sheet1", True) = 0 OrElse Operators.CompareString(sheet.Name, "Sheet1$", True) = 0 Then
						IL_129F:
						num2 = 204
						book.Sheets.Remove(sheet)
						IL_12B3:
						num2 = 205
						book.Save(Me.FilePath)
						Exit While
					End If
					IL_12C9:
					num2 = 207
				End While
				IL_12D8:
				num2 = 208
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
				IL_12E9:
				GoTo IL_167F
				IL_12EE:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_1640:
				GoTo IL_1674
				IL_1642:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1652:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_1642
			End Try
			IL_1674:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_167F:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003062 RID: 12386 RVA: 0x00138CF8 File Offset: 0x00136EF8
		Private Sub <<EMPTY_NAME>>(A_0 As OleDbCommand, A_1 As String, Optional A_2 As Boolean = False)
			Try
				A_0.Connection.Open()
				A_0.ExecuteNonQuery()
			Catch a_ As Exception
				If A_2 Then
					ooO.oOo0Oo.o.(a_, "")
				End If
			Finally
				A_0.Connection.Close()
				If OO_00oOO.FileSys.FileExists(A_1) Then
					OO_00oOO.FileSys.DeleteFile(A_1)
				End If
			End Try
		End Sub

		' Token: 0x0400135E RID: 4958
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400135F RID: 4959
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001360 RID: 4960
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001361 RID: 4961
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001362 RID: 4962
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001363 RID: 4963
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001364 RID: 4964
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001365 RID: 4965
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001366 RID: 4966
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001367 RID: 4967
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001368 RID: 4968
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04001369 RID: 4969
		Private <<EMPTY_NAME>> As C1XLBook
	End Class
End Namespace
