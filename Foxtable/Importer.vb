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
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000339 RID: 825
	<oO0oooo("0684")>
	<ComVisible(True)>
	Public Class Importer
		' Token: 0x06003176 RID: 12662 RVA: 0x00141130 File Offset: 0x0013F330
		Public Sub New()
			Me.o.OOo_oO. = True
		End Sub

		' Token: 0x17000CB0 RID: 3248
		' (get) Token: 0x06003177 RID: 12663 RVA: 0x0014113F File Offset: 0x0013F33F
		' (set) Token: 0x06003178 RID: 12664 RVA: 0x00141147 File Offset: 0x0013F347
		Public Property SourcePath As String
			Get
				Return Me.o.OOo_oO.
			End Get
			Set(value As String)
				Me.o.OOo_oO. = value
			End Set
		End Property

		' Token: 0x17000CB1 RID: 3249
		' (get) Token: 0x06003179 RID: 12665 RVA: 0x00141150 File Offset: 0x0013F350
		' (set) Token: 0x0600317A RID: 12666 RVA: 0x00141158 File Offset: 0x0013F358
		Public Property SourceTableName As String
			Get
				Return Me.O.Oo_oO0_0.
			End Get
			Set(value As String)
				Me.O.Oo_oO0_0. = value
			End Set
		End Property

		' Token: 0x17000CB2 RID: 3250
		' (get) Token: 0x0600317B RID: 12667 RVA: 0x00141161 File Offset: 0x0013F361
		' (set) Token: 0x0600317C RID: 12668 RVA: 0x00141169 File Offset: 0x0013F369
		Public Property Format As String
			Get
				Return Me.o_.__oo0O0oO0o.
			End Get
			Set(value As String)
				Me.o_.__oo0O0oO0o. = value
			End Set
		End Property

		' Token: 0x17000CB3 RID: 3251
		' (get) Token: 0x0600317D RID: 12669 RVA: 0x00141172 File Offset: 0x0013F372
		' (set) Token: 0x0600317E RID: 12670 RVA: 0x0014117A File Offset: 0x0013F37A
		Public Property Fields As String
			Get
				Return Me.OOoO0O_oo.o.
			End Get
			Set(value As String)
				Me.OOoO0O_oo.o. = value
			End Set
		End Property

		' Token: 0x17000CB4 RID: 3252
		' (get) Token: 0x0600317F RID: 12671 RVA: 0x00141183 File Offset: 0x0013F383
		' (set) Token: 0x06003180 RID: 12672 RVA: 0x0014118B File Offset: 0x0013F38B
		Public Property PassWord As String
			Get
				Return Me.O00.O0OO_0oO.
			End Get
			Set(value As String)
				Me.O00.O0OO_0oO. = value
			End Set
		End Property

		' Token: 0x17000CB5 RID: 3253
		' (get) Token: 0x06003181 RID: 12673 RVA: 0x00141194 File Offset: 0x0013F394
		' (set) Token: 0x06003182 RID: 12674 RVA: 0x0014119C File Offset: 0x0013F39C
		Public Property Filter As String
			Get
				Return Me.o00O_O.O.
			End Get
			Set(value As String)
				Me.o00O_O.O. = value
			End Set
		End Property

		' Token: 0x17000CB6 RID: 3254
		' (get) Token: 0x06003183 RID: 12675 RVA: 0x001411A5 File Offset: 0x0013F3A5
		' (set) Token: 0x06003184 RID: 12676 RVA: 0x001411AD File Offset: 0x0013F3AD
		Public Property NewTableName As String
			Get
				Return Me.oO00._o__0oO.
			End Get
			Set(value As String)
				Me.oO00._o__0oO. = value
			End Set
		End Property

		' Token: 0x17000CB7 RID: 3255
		' (get) Token: 0x06003185 RID: 12677 RVA: 0x001411B6 File Offset: 0x0013F3B6
		' (set) Token: 0x06003186 RID: 12678 RVA: 0x001411BE File Offset: 0x0013F3BE
		Public Property NewTableCaption As String
			Get
				Return Me.oOOoOo.0_0.
			End Get
			Set(value As String)
				Me.oOOoOo.0_0. = value
			End Set
		End Property

		' Token: 0x17000CB8 RID: 3256
		' (get) Token: 0x06003187 RID: 12679 RVA: 0x001411C7 File Offset: 0x0013F3C7
		' (set) Token: 0x06003188 RID: 12680 RVA: 0x001411CF File Offset: 0x0013F3CF
		Public Property Header As Boolean
			Get
				Return Me.o.OOo_oO.
			End Get
			Set(value As Boolean)
				Me.o.OOo_oO. = value
			End Set
		End Property

		' Token: 0x06003189 RID: 12681 RVA: 0x001411D8 File Offset: 0x0013F3D8
		Public Function Import() As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim oleDbCommand As OleDbCommand = New OleDbCommand()
				IL_10:
				num2 = 3
				Dim text As String = OO_00oOO.ProjectFile + ".bak"
				IL_23:
				num2 = 4
				If Not OO_00oOO.FileSys.FileExists(text) Then
					GoTo IL_41
				End If
				IL_33:
				num2 = 5
				OO_00oOO.FileSys.DeleteFile(text)
				IL_41:
				num2 = 6
				OO_00oOO.FileSys.CopyFile(OO_00oOO.ProjectFile, text)
				IL_54:
				num2 = 7
				If Not Me.SourcePath.ToLower().EndsWith(".accdb") AndAlso Not Me.SourcePath.ToLower().EndsWith(".xlsx") Then
					GoTo IL_9E
				End If
				IL_84:
				num2 = 8
				oleDbCommand.Connection = New OleDbConnection(Oo00.OOO_O0O0.o.(OO_00oOO.ProjectFile))
				GoTo IL_AD
				IL_9E:
				num2 = 10
				oleDbCommand.Connection = O_O0OO.OoO.0OO__0ooo.()
				IL_AD:
				num2 = 11
				If Operators.CompareString(Me.Fields, "", True) <> 0 Then
					GoTo IL_D1
				End If
				IL_C3:
				num2 = 12
				Me.Fields = "*"
				IL_D1:
				num2 = 13
				If Operators.CompareString(Me.NewTableName, "", True) <> 0 Then
					GoTo IL_107
				End If
				IL_E7:
				num2 = 14
				MessageBox.Show("请指定表名!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_FD:
				num2 = 15
				result = True
				GoTo IL_575
				IL_107:
				num2 = 16
				If Not O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.NewTableName) Then
					GoTo IL_151
				End If
				IL_121:
				num2 = 17
				MessageBox.Show("已经存在同名表""" + Me.NewTableName + """！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_147:
				num2 = 18
				result = False
				GoTo IL_575
				IL_151:
				num2 = 19
				Dim format As String = Me.Format
				IL_15C:
				num2 = 21
				If Operators.CompareString(format, "", True) <> 0 AndAlso Operators.CompareString(format, "access", True) <> 0 AndAlso Operators.CompareString(format, "access2007", True) <> 0 AndAlso Operators.CompareString(format, "access 2007", True) <> 0 Then
					GoTo IL_243
				End If
				IL_19E:
				num2 = 22
				If Operators.CompareString(Me.PassWord, "", True) <> 0 Then
					GoTo IL_1F3
				End If
				IL_1B4:
				num2 = 23
				Dim text2 As String = String.Concat(New String() { "[;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_1F3:
				num2 = 25
				text2 = String.Concat(New String() { "[;DATABASE=", Me.SourcePath, ";PWD=", Me.PassWord, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_243:
				num2 = 27
				If Operators.CompareString(format, "excel", True) <> 0 AndAlso Operators.CompareString(format, "excel2007", True) <> 0 AndAlso Operators.CompareString(format, "excel 2007", True) <> 0 Then
					GoTo IL_339
				End If
				IL_276:
				num2 = 28
				If Me.SourceTableName.EndsWith("$", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_2A5
				End If
				IL_28C:
				num2 = 29
				Me.SourceTableName += "$"
				IL_2A5:
				num2 = 30
				If Me.Format.IndexOf("2007") <= 0 Then
					GoTo IL_2FA
				End If
				IL_2BB:
				num2 = 31
				text2 = String.Concat(New String() { "[EXCEL 12.0;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_2FA:
				num2 = 33
				text2 = String.Concat(New String() { "[EXCEL 8.0;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_339:
				num2 = 35
				If Operators.CompareString(format, "dbase", True) <> 0 Then
					GoTo IL_38A
				End If
				IL_34B:
				num2 = 36
				text2 = String.Concat(New String() { "[dBASE IV;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_38A:
				num2 = 38
				If Operators.CompareString(format, "Fixed", True) <> 0 Then
					GoTo IL_457
				End If
				IL_39F:
				num2 = 39
				If Me.SourceTableName.EndsWith("#txt", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_3CE
				End If
				IL_3B5:
				num2 = 40
				Me.SourceTableName += "#txt"
				IL_3CE:
				num2 = 41
				If Not Me.Header Then
					GoTo IL_418
				End If
				IL_3D9:
				num2 = 42
				text2 = String.Concat(New String() { "[text;HDR=Yes;FMT=Fixed;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_418:
				num2 = 44
				text2 = String.Concat(New String() { "[text;HDR=No;FMT=Fixed;DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_457:
				num2 = 46
				If Me.Format.IndexOf("Delimited", StringComparison.CurrentCultureIgnoreCase) < 0 Then
					GoTo IL_545
				End If
				IL_471:
				num2 = 47
				If Me.SourceTableName.EndsWith("#txt", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_4A0
				End If
				IL_487:
				num2 = 48
				Me.SourceTableName += "#txt"
				IL_4A0:
				num2 = 49
				If Not Me.Header Then
					GoTo IL_4F8
				End If
				IL_4AB:
				num2 = 50
				text2 = String.Concat(New String() { "[text;HDR=Yes;FMT=", Me.Format, ";DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_4F8:
				num2 = 52
				text2 = String.Concat(New String() { "[text;HDR=No;FMT=", Me.Format, ";DATABASE=", Me.SourcePath, "].[", Me.SourceTableName, "]" })
				GoTo IL_54C
				IL_545:
				num2 = 54
				result = False
				GoTo IL_575
				IL_54C:
				num2 = 55
				If Operators.CompareString(text2, "", True) <> 0 Then
					GoTo IL_565
				End If
				IL_55E:
				num2 = 56
				result = False
				GoTo IL_575
				IL_565:
				num2 = 57
				result = Me.o.OOo_oO.(oleDbCommand, text2, text)
				IL_575:
				GoTo IL_6AF
				IL_57A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_670:
				GoTo IL_6A4
				IL_672:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_682:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_672
			End Try
			IL_6A4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6AF:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0600318A RID: 12682 RVA: 0x001418BC File Offset: 0x0013FABC
		Private Function <<EMPTY_NAME>>(A_0 As OleDbCommand, A_1 As String, A_2 As String) As Boolean
			Dim result As Boolean
			Try
				Dim dataTable As DataTable = New DataTable()
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("", A_0.Connection)
				Dim list As List(Of String) = New List(Of String)()
				oleDbDataAdapter.SelectCommand.CommandText = "Select " + Me.Fields + " From " + A_1
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				Try
					For Each obj As Object In dataTable.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) OrElse dataColumn.AutoIncrement Then
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
						dataTable.Columns.Remove(name)
					Next
				Finally
					Dim enumerator2 As List(Of String).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				If dataTable.Columns.Count > 253 Then
					MessageBox.Show("不能导入超过253列的表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = False
				Else
					Me.Fields = ""
					Try
						For Each obj2 As Object In dataTable.Columns
							Dim dataColumn2 As DataColumn = CType(obj2, DataColumn)
							If Operators.CompareString(Me.Fields, "", True) > 0 Then
								Me.Fields += ","
							End If
							Me.Fields = Me.Fields + "[" + dataColumn2.ColumnName + "]"
						Next
					Finally
						Dim enumerator3 As IEnumerator
						If TypeOf enumerator3 Is IDisposable Then
							TryCast(enumerator3, IDisposable).Dispose()
						End If
					End Try
					A_0.CommandText = String.Concat(New String() { "Select ", Me.Fields, " Into [~TMPCLP", Me.NewTableName, "] From ", A_1 })
					If Operators.CompareString(Me.Filter, "", True) > 0 Then
						A_0.CommandText = A_0.CommandText + " Where " + Me.Filter
					End If
					A_0.Connection.Close()
					A_0.Connection.Open()
					A_0.ExecuteNonQuery()
					A_0.Connection.Close()
					If Not Me.CreatePrimaryKey() Then
						OO_00oOO.FileSys.DeleteFile(OO_00oOO.ProjectFile)
						OO_00oOO.FileSys.RenameFile(A_2, OO_00oOO.FileSys.GetName(OO_00oOO.ProjectFile))
						result = False
					Else
						Me.o.OOo_oO.()
						Application.DoEvents()
						result = True
					End If
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				A_0.Connection.Close()
				result = False
			End Try
			Return result
		End Function

		' Token: 0x0600318B RID: 12683 RVA: 0x00141BD4 File Offset: 0x0013FDD4
		Private Function CreatePrimaryKey() As Boolean
			Dim catalog As Catalog = New CatalogClass()
			Dim connection As Connection = New ConnectionClass()
			Dim text As String = "~TMPCLP" + Me.NewTableName
			Dim text2 As String = "__Identify"
			connection.ConnectionString = O_O0OO.OoO.0OO__0ooo.().ConnectionString
			connection.Open("", "", "", -1)
			catalog.ActiveConnection = connection
			Dim table As Table = catalog.Tables(text)
			Try
				table.Columns.Append("_Locked", 11, 0)
				table.Columns.Append("_Identify", 3, 0)
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				connection.Close()
				catalog = Nothing
				Return False
			End Try
			Dim columnClass As ColumnClass = New ColumnClass()
			columnClass.ParentCatalog = catalog
			columnClass.Type = 3
			columnClass.Name = text2
			columnClass.Properties("AutoIncrement").Value = True
			table.Columns.Append(columnClass, 3, 0)
			Dim connection2 As _Connection = connection
			Dim text3 As String = String.Concat(New String() { "update [", text, "] Set [_Identify] = [", text2, "]" })
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			connection2.Execute(text3, objectValue, -1)
			catalog.Tables(text).Columns.Delete(text2)
			Dim index As Index = New IndexClass()
			index.Name = "PrimaryKey"
			index.Columns.Append("_Identify", 202, 0)
			index.PrimaryKey = True
			index.Unique = True
			table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
			Dim connection3 As _Connection = connection
			Dim text4 As String = String.Concat(New String() { "Delete * From [", ooO0__OO.O00.O__o.(), "] Where [Table]  = '", text, "'" })
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
			connection3.Execute(text4, objectValue, -1)
			connection.Close()
			catalog = Nothing
			O_O0OO.OoO.0OO__0ooo.().Open()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("Select Max([_Identify]) From [" + text + "]", O_O0OO.OoO.0OO__0ooo.())
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
			Dim value As Integer
			If objectValue2 Is DBNull.Value Then
				value = 1
			Else
				value = Conversions.ToInteger(objectValue2) + 1
			End If
			oleDbCommand.CommandText = String.Concat(New String() { "Insert into [", ooO0__OO.O00.O__o.(), "] ([Table],[Identify]) values ('", text, "',", Conversions.ToString(value), ")" })
			oleDbCommand.ExecuteNonQuery()
			O_O0OO.OoO.0OO__0ooo.().Close()
			Return True
		End Function

		' Token: 0x0600318C RID: 12684 RVA: 0x00141E94 File Offset: 0x00140094
		Private Sub <<EMPTY_NAME>>()
			O_O0OO.OoO.0OO__0ooo.().Open()
			o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + Me.NewTableName, True, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), False)
			OO_00oOO.DataTables(Me.NewTableName).o.0O000_.()
			If Operators.CompareString(Me.NewTableCaption, "", True) > 0 Then
				OO_00oOO.DataTables(Me.NewTableName).Caption = Me.NewTableCaption
			End If
			O_O0OO.OoO.0OO__0ooo.().Close()
			OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.NewTableName))
			Main.OO_O.o..o0_o_o_0.0O.(Me.NewTableName, True, False)
			If Operators.CompareString(Me.NewTableCaption, "", True) > 0 Then
				OO_00oOO.DataTables(Me.NewTableName).OO00_o.ooOO.(False)
			End If
		End Sub

		' Token: 0x040013DE RID: 5086
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013DF RID: 5087
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E0 RID: 5088
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E1 RID: 5089
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E2 RID: 5090
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E3 RID: 5091
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E4 RID: 5092
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E5 RID: 5093
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013E6 RID: 5094
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
