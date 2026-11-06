Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200037A RID: 890
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002
		Inherits Form

		' Token: 0x060038C0 RID: 14528 RVA: 0x0018568C File Offset: 0x0018388C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_0.O_000_. IsNot Nothing Then
					Me.O_0.O_000_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060038C1 RID: 14529 RVA: 0x001856CC File Offset: 0x001838CC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0Oo0o0__o.Oo_.(New C1Button())
			Me.OO.0O000o_O_0.(New C1Button())
			Me.OO.0O000o_O_0.(New Label())
			Me.o0Oo0o0__o.Oo_.(New Label())
			Me.o0Oo0o0__o.Oo_.(New C1FlexGrid())
			Me.o0Oo0o0__o.Oo_.().BeginInit()
			MyBase.SuspendLayout()
			Me.OOo_O0_o._0.().Location = New Point(171, 337)
			Me.OOo_O0_o._0.().Name = "btnOK"
			Me.OOo_O0_o._0.().Size = New Size(75, 23)
			Me.OOo_O0_o._0.().TabIndex = 1
			Me.OOo_O0_o._0.().Text = "确定"
			Me.OOo_O0_o._0.().UseVisualStyleBackColor = True
			Me.OO.0O000o_O_0.().DialogResult = DialogResult.Cancel
			Me.OO.0O000o_O_0.().Location = New Point(266, 337)
			Me.OO.0O000o_O_0.().Name = "Button2"
			Me.OO.0O000o_O_0.().Size = New Size(75, 23)
			Me.OO.0O000o_O_0.().TabIndex = 2
			Me.OO.0O000o_O_0.().Text = "取消"
			Me.OO.0O000o_O_0.().UseVisualStyleBackColor = True
			Me.o0Oo0o0__o.Oo_.().AutoSize = True
			Me.o0Oo0o0__o.Oo_.().ForeColor = Color.Red
			Me.o0Oo0o0__o.Oo_.().Location = New Point(12, 285)
			Me.o0Oo0o0__o.Oo_.().Name = "Label1"
			Me.o0Oo0o0__o.Oo_.().Size = New Size(227, 12)
			Me.o0Oo0o0__o.Oo_.().TabIndex = 3
			Me.o0Oo0o0__o.Oo_.().Text = "1、迁移前请备份自己的项目，以防万一。"
			Me.OO.0O000o_O_0.().AutoSize = True
			Me.OO.0O000o_O_0.().ForeColor = Color.Red
			Me.OO.0O000o_O_0.().Location = New Point(12, 301)
			Me.OO.0O000o_O_0.().Name = "Label2"
			Me.OO.0O000o_O_0.().Size = New Size(263, 12)
			Me.OO.0O000o_O_0.().TabIndex = 4
			Me.OO.0O000o_O_0.().Text = "2、内部表迁移到外部数据源后，会被自动删除。"
			Me.o0Oo0o0__o.Oo_.().ColumnInfo = "10,0,0,0,0,0,Columns:"
			Me.o0Oo0o0__o.Oo_.().Location = New Point(14, 12)
			Me.o0Oo0o0__o.Oo_.().Name = "C1FlexGrid1"
			Me.o0Oo0o0__o.Oo_.().Rows.DefaultSize = 19
			Me.o0Oo0o0__o.Oo_.().Size = New Size(485, 257)
			Me.o0Oo0o0__o.Oo_.().TabIndex = 5
			Me.o0Oo0o0__o.Oo_.().VisualStyle = 2
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(511, 372)
			MyBase.Controls.Add(Me.o0Oo0o0__o.Oo_.())
			MyBase.Controls.Add(Me.OO.0O000o_O_0.())
			MyBase.Controls.Add(Me.o0Oo0o0__o.Oo_.())
			MyBase.Controls.Add(Me.OO.0O000o_O_0.())
			MyBase.Controls.Add(Me.OOo_O0_o._0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.O.O..."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Redirect"
			Me.o0Oo0o0__o.Oo_.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060038C2 RID: 14530 RVA: 0x00185A3B File Offset: 0x00183C3B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_0.O_000_.
		End Function

		' Token: 0x060038C3 RID: 14531 RVA: 0x00185A44 File Offset: 0x00183C44
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOo_O0_o._0.
			Dim o_0.O_000_. As C1Button = Me.O_0.O_000_.
			If o_0.O_000_. IsNot Nothing Then
				RemoveHandler o_0.O_000_..Click, value
			End If
			Me.O_0.O_000_. = A_0
			o_0.O_000_. = Me.O_0.O_000_.
			If o_0.O_000_. IsNot Nothing Then
				AddHandler o_0.O_000_..Click, value
			End If
		End Sub

		' Token: 0x060038C4 RID: 14532 RVA: 0x00185A87 File Offset: 0x00183C87
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO__.00000_o.
		End Function

		' Token: 0x060038C5 RID: 14533 RVA: 0x00185A8F File Offset: 0x00183C8F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OO__.00000_o. = A_0
		End Sub

		' Token: 0x060038C6 RID: 14534 RVA: 0x00185A98 File Offset: 0x00183C98
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_0.O_000_.
		End Function

		' Token: 0x060038C7 RID: 14535 RVA: 0x00185AA0 File Offset: 0x00183CA0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_0.O_000_. = A_0
		End Sub

		' Token: 0x060038C8 RID: 14536 RVA: 0x00185AA9 File Offset: 0x00183CA9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OO__.00000_o.
		End Function

		' Token: 0x060038C9 RID: 14537 RVA: 0x00185AB1 File Offset: 0x00183CB1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO__.00000_o. = A_0
		End Sub

		' Token: 0x060038CA RID: 14538 RVA: 0x00185ABA File Offset: 0x00183CBA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_0.O_000_.
		End Function

		' Token: 0x060038CB RID: 14539 RVA: 0x00185AC4 File Offset: 0x00183CC4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.OOo_O0_o._0.
			Dim o_0.O_000_. As C1FlexGrid = Me.O_0.O_000_.
			If o_0.O_000_. IsNot Nothing Then
				o_0.O_000_..BeforeEdit -= rowColEventHandler
			End If
			Me.O_0.O_000_. = A_0
			o_0.O_000_. = Me.O_0.O_000_.
			If o_0.O_000_. IsNot Nothing Then
				o_0.O_000_..BeforeEdit += rowColEventHandler
			End If
		End Sub

		' Token: 0x060038CC RID: 14540 RVA: 0x00185B08 File Offset: 0x00183D08
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.OOo_O0_o._0.
			Me.O_0.O_000_. = New List(Of String)()
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_23:
				Dim num As Integer = 1
				Me.o0Oo0o0__o.Oo_.()
				IL_2B:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_42:
				num = 3
				Dim c1FlexGrid As C1FlexGrid = Me.o0Oo0o0__o.Oo_.()
				IL_4B:
				num = 4
				c1FlexGrid.Styles.SelectedColumnHeader.Clear()
				IL_5D:
				num = 5
				c1FlexGrid.Styles.Alternate.Clear()
				IL_6F:
				num = 6
				c1FlexGrid.Styles.Focus.Clear()
				IL_81:
				num = 7
				c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal)
				IL_9E:
				num = 8
				c1FlexGrid.FocusRect = 3
				IL_A7:
				num = 9
				c1FlexGrid.AllowSorting = 0
				IL_B1:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_B8:
				num = 11
				Me.O_0.O_000_..Add("内部数据源")
				IL_CB:
				num = 12
				Me.O_0.O_000_. = New DataTable()
				IL_D9:
				num = 13
				Me.O_0.O_000_..Columns.Add("表", GetType(String))
				IL_FC:
				num = 14
				Me.O_0.O_000_..Columns.Add("数据源", GetType(String))
				IL_11F:
				num = 15
				Me.O_0.O_000_..Columns.Add("定向到", GetType(String))
				IL_142:
				num = 16
				Me.O_0.O_000_..Columns.Add("目标名称", GetType(String))
				IL_165:
				num = 17
				Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataTable As DataTable = enumerator.Current
					IL_182:
					num = 18
					If dataTable.AllowRedirect Then
						IL_191:
						num = 20
						If Not dataTable.frd_IsTemporary AndAlso Not dataTable.AddByCode Then
							IL_1AC:
							num = 22
							If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(dataTable.frd_Connection) Then
								IL_1C0:
								num = 24
								Dim dataRow As DataRow = Me.O_0.O_000_..NewRow()
								IL_1D0:
								num = 25
								dataRow("表") = dataTable.Name
								IL_1E6:
								num = 26
								If dataTable.frd_IsInnerTable OrElse dataTable.frd_IsInnerQuery Then
									IL_1FB:
									num = 27
									dataRow("数据源") = Me.O_0.O_000_.(0)
								Else
									IL_218:
									num = 29
									If dataTable.frd_IsOuterTable OrElse dataTable.frd_IsOuterQuery Then
										IL_22D:
										num = 30
										Dim enumerator2 As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
										While enumerator2.MoveNext()
											Dim text As String = enumerator2.Current
											IL_24C:
											num = 31
											If O_O0OO.O._o_.()(text) Is dataTable.frd_Connection Then
												IL_264:
												num = 32
												dataRow("数据源") = text
											End If
											IL_275:
											num = 33
										End While
										IL_281:
										num = 34
										CType(enumerator2, IDisposable).Dispose()
									End If
								End If
								IL_291:
								num = 35
								Me.O_0.O_000_..Rows.Add(dataRow)
							End If
						End If
					End If
					IL_2A6:
					num = 36
				End While
				IL_2B5:
				num = 37
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_2C3:
				num = 38
				Dim c1FlexGrid2 As C1FlexGrid = Me.o0Oo0o0__o.Oo_.()
				IL_2CE:
				num = 39
				c1FlexGrid2.DataSource = Me.O_0.O_000_.
				IL_2DE:
				num = 40
				c1FlexGrid2.Styles.Fixed.TextAlign = 4
				IL_2F3:
				num = 41
				Dim num3 As Integer = c1FlexGrid2.Cols.Count - 1
				For i As Integer = 0 To num3
					IL_30B:
					num = 42
					c1FlexGrid2.Cols(i).Width = Me.o0Oo0o0__o.Oo_.().ClientSize.Width / 3 - 1
					IL_339:
					num = 43
				Next
				IL_348:
				num = 44
				c1FlexGrid2.ExtendLastCol = True
				IL_353:
				c1FlexGrid2 = Nothing
				IL_356:
				num = 46
				Dim enumerator3 As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator3.MoveNext()
					Dim text2 As String = enumerator3.Current
					IL_375:
					num = 47
					If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()(text2)) Then
						IL_38B:
						num = 49
						Me.O_0.O_000_..Add(text2)
					End If
					IL_39B:
					num = 50
				End While
				IL_3A7:
				num = 51
				CType(enumerator3, IDisposable).Dispose()
				IL_3B7:
				num = 52
				Me.o0Oo0o0__o.Oo_.().Cols(0).AllowEditing = False
				IL_3D1:
				num = 53
				Me.o0Oo0o0__o.Oo_.().Cols(1).AllowEditing = False
				IL_3EB:
				num = 54
				Me.o0Oo0o0__o.Oo_.().Cols.Remove(3)
				IL_400:
				num = 55
				Me.o0Oo0o0__o.Oo_.().AutoGenerateColumns = False
				IL_40F:
				num = 56
				Me.O_0.O_000_..Columns.Add("Mode", GetType(Integer))
				IL_432:
				GoTo IL_568
				IL_437:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_529:
				GoTo IL_55D
				IL_52B:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_53B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_52B
			End Try
			IL_55D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_568:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060038CD RID: 14541 RVA: 0x001860A4 File Offset: 0x001842A4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj4 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				c.OOOOO.o.().FileSystem.CopyFile(OO_00oOO.ProjectFile, OO_00oOO.ProjectFile + ".bak", True)
				IL_2D:
				num2 = 3
				OO_00oOO.Forms.ooO0_o._o.()
				IL_39:
				num2 = 4
				Application.DoEvents()
				IL_40:
				num2 = 5
				Dim enumerator As IEnumerator = Me.O_0.O_000_..Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_65:
					num2 = 6
					dataRow("Mode") = DBNull.Value
					IL_78:
					num2 = 7
					If Not dataRow.IsNull("定向到") AndAlso Operators.CompareString(dataRow("定向到").ToString(), "", True) > 0 Then
						IL_AD:
						num2 = 8
						If Operators.CompareString(dataRow("定向到").ToString(), dataRow("数据源").ToString(), True) <> 0 Then
							IL_DC:
							num2 = 9
							Dim a_ As String = dataRow("表").ToString()
							IL_F2:
							num2 = 10
							Dim text As String = ""
							IL_FC:
							num2 = 11
							Dim a_2 As OleDbConnection = OO_00oOO.DataTables(a_).frd_Connection
							IL_112:
							num2 = 12
							Dim a_3 As OleDbConnection
							If Operators.CompareString(dataRow("定向到").ToString(), "内部数据源", True) = 0 Then
								IL_133:
								num2 = 13
								a_3 = O_O0OO.OoO.0OO__0ooo.()
							Else
								IL_13F:
								num2 = 15
								a_3 = O_O0OO.O._o_.()(dataRow("定向到").ToString())
							End If
							IL_15F:
							num2 = 16
							If OO_00oOO.DataTables(a_).frd_IsOuterQuery OrElse OO_00oOO.DataTables(a_).frd_IsInnerQuery Then
								IL_188:
								num2 = 17
								dataRow("Mode") = 2
							Else
								IL_19F:
								num2 = 19
								Dim num3 As Integer = Me.OOo_O0_o._0.(a_2, a_3, OO_00oOO.DataTables(a_), text)
								IL_1BC:
								num2 = 20
								If num3 = 0 Then
									IL_C44:
									GoTo IL_F42
								End If
								IL_1C6:
								num2 = 23
								dataRow("Mode") = num3
								IL_1DC:
								num2 = 24
								If Operators.CompareString(text, "", True) > 0 Then
									IL_1EF:
									num2 = 25
									dataRow("目标名称") = text
								End If
							End If
						End If
					End If
					IL_200:
					num2 = 26
				End While
				IL_20E:
				num2 = 27
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_224:
				num2 = 28
				Dim enumerator2 As IEnumerator = Me.O_0.O_000_..Rows.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					IL_24C:
					num2 = 29
					If Not dataRow2.IsNull("Mode") Then
						IL_260:
						num2 = 31
						Dim text2 As String = dataRow2("表").ToString()
						IL_276:
						num2 = 32
						Dim num4 As Integer = Conversions.ToInteger(dataRow2("Mode"))
						IL_28C:
						num2 = 33
						Dim oleDbConnection As OleDbConnection = OO_00oOO.DataTables(text2).frd_Connection
						IL_2A2:
						num2 = 34
						Dim oleDbConnection2 As OleDbConnection
						If Operators.CompareString(dataRow2("定向到").ToString(), "内部数据源", True) = 0 Then
							IL_2C3:
							num2 = 35
							oleDbConnection2 = O_O0OO.OoO.0OO__0ooo.()
						Else
							IL_2CF:
							num2 = 37
							oleDbConnection2 = O_O0OO.O._o_.()(dataRow2("定向到").ToString())
						End If
						IL_2EF:
						num2 = 38
						If num4 = 1 Then
							IL_2FA:
							num2 = 39
							Dim selectCommandText As String
							If OO_00oOO.DataTables(text2).o._OOO0oOo0__..IndexOf("].[") > 0 AndAlso OO_00oOO.DataTables(text2).o._OOO0oOo0__..StartsWith("[") AndAlso OO_00oOO.DataTables(text2).o._OOO0oOo0__..EndsWith("]") Then
								IL_355:
								num2 = 40
								selectCommandText = "Select * From " + OO_00oOO.DataTables(text2).o._OOO0oOo0__.
							Else
								IL_377:
								num2 = 42
								selectCommandText = "Select * From [" + OO_00oOO.DataTables(text2).o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
							End If
							IL_3B1:
							num2 = 43
							Dim dataTable As DataTable = New DataTable()
							IL_3BB:
							num2 = 44
							Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
							IL_3C9:
							num2 = 45
							oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
							IL_3D7:
							num2 = 46
							Dim index As Index = New IndexClass()
							IL_3E1:
							num2 = 47
							Dim catalog As Catalog = New CatalogClass()
							IL_3EB:
							num2 = 48
							Dim connection As Connection = New ConnectionClass()
							IL_3F5:
							num2 = 49
							Dim flag As Boolean = o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection2)
							IL_401:
							num2 = 50
							connection.ConnectionString = oleDbConnection2.ConnectionString
							IL_412:
							num2 = 51
							Dim table As Table = New TableClass()
							IL_41C:
							num2 = 52
							connection.Open("", "", "", -1)
							IL_436:
							num2 = 53
							catalog.ActiveConnection = connection
							IL_442:
							num2 = 54
							If oleDbConnection2 Is O_O0OO.OoO.0OO__0ooo.() Then
								IL_44E:
								num2 = 55
								table.Name = "~TMPCLP" + text2
							Else
								IL_466:
								num2 = 57
								table.Name = text2
							End If
							IL_472:
							num2 = 58
							table.ParentCatalog = catalog
							IL_47E:
							num2 = 59
							Dim enumerator3 As IEnumerator = dataTable.Columns.GetEnumerator()
							While enumerator3.MoveNext()
								Dim obj3 As Object = enumerator3.Current
								Dim dataColumn As DataColumn = CType(obj3, DataColumn)
								IL_4A2:
								num2 = 60
								Dim text3 As String = dataColumn.ColumnName
								IL_4AE:
								num2 = 61
								If Not o_O_o_oOoo__.oO.O_..Contains(text3) Then
									IL_4BF:
									num2 = 62
									If flag Then
										IL_4C6:
										num2 = 63
										text3 = "[" + text3 + "]"
									End If
								End If
								IL_4DC:
								num2 = 64
								Dim name As String = dataColumn.DataType.Name
								IL_4ED:
								num2 = 66
								If Operators.CompareString(name, "String", True) = 0 Then
									IL_4FF:
									num2 = 67
									If dataColumn.MaxLength < 0 OrElse dataColumn.MaxLength > 255 Then
										IL_51A:
										num2 = 68
										table.Columns.Append(text3, 203, 0)
										GoTo IL_710
									End If
									IL_536:
									num2 = 70
									table.Columns.Append(text3, 202, dataColumn.MaxLength)
									GoTo IL_710
								Else
									IL_558:
									num2 = 72
									If Operators.CompareString(name, "DateTime", True) = 0 Then
										IL_56A:
										num2 = 73
										If flag Then
											IL_571:
											num2 = 74
											table.Columns.Append(text3, 135, 0)
											GoTo IL_710
										End If
										IL_58D:
										num2 = 76
										table.Columns.Append(text3, 7, 0)
										GoTo IL_710
									Else
										IL_5A5:
										num2 = 78
										If Operators.CompareString(name, "Boolean", True) = 0 Then
											IL_5B7:
											num2 = 79
											table.Columns.Append(text3, 11, 0)
											GoTo IL_710
										End If
										IL_5D0:
										num2 = 81
										If Operators.CompareString(name, "Double", True) = 0 Then
											IL_5E2:
											num2 = 82
											table.Columns.Append(text3, 5, 0)
											GoTo IL_710
										End If
										IL_5FA:
										num2 = 84
										If Operators.CompareString(name, "Single", True) = 0 Then
											IL_60C:
											num2 = 85
											table.Columns.Append(text3, 4, 0)
											GoTo IL_710
										End If
										IL_624:
										num2 = 87
										If Operators.CompareString(name, "Decimal", True) = 0 Then
											IL_636:
											num2 = 88
											table.Columns.Append(text3, 131, 0)
											GoTo IL_710
										End If
										IL_652:
										num2 = 90
										If Operators.CompareString(name, "Int64", True) = 0 Then
											IL_664:
											num2 = 91
											If flag Then
												IL_66B:
												num2 = 92
												table.Columns.Append(text3, 20, 0)
												GoTo IL_710
											End If
											IL_684:
											num2 = 94
											table.Columns.Append(text3, 3, 0)
											GoTo IL_710
										Else
											IL_699:
											num2 = 96
											If Operators.CompareString(name, "Int32", True) = 0 Then
												IL_6AB:
												num2 = 97
												table.Columns.Append(text3, 3, 0)
												GoTo IL_710
											End If
											IL_6C0:
											num2 = 99
											If Operators.CompareString(name, "Int16", True) = 0 Then
												IL_6D2:
												num2 = 100
												table.Columns.Append(text3, 2, 0)
												GoTo IL_710
											End If
											IL_6E7:
											num2 = 102
											If Operators.CompareString(name, "Byte", True) = 0 Then
												IL_6FC:
												num2 = 103
												table.Columns.Append(text3, 17, 0)
												GoTo IL_710
											End If
										End If
									End If
								End If
								IL_7C7:
								num2 = 114
								Continue While
								IL_710:
								num2 = 106
								Dim column As Column = table.Columns(text3)
								IL_723:
								num2 = 107
								If column.Type = 131 Then
									IL_734:
									num2 = 108
									column.Precision = 28
									IL_740:
									num2 = 109
									column.NumericScale = 14
									IL_74C:
									num2 = 110
									If OO_00oOO.DataTables(text2).DataCols.Contains(text3) Then
										IL_769:
										num2 = 111
										column.NumericScale = CByte(OO_00oOO.DataTables(text2).DataCols(text3).Decimals)
									End If
								End If
								IL_791:
								num2 = 112
								If(column.Type <> 11 OrElse o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection2)) AndAlso Operators.CompareString(column.Name, "_Identify", True) <> 0 Then
									IL_7BC:
									num2 = 113
									column.Attributes = 2
									GoTo IL_7C7
								End If
								GoTo IL_7C7
							End While
							IL_7D6:
							num2 = 115
							If TypeOf enumerator3 Is IDisposable Then
								TryCast(enumerator3, IDisposable).Dispose()
							End If
							IL_7EE:
							num2 = 116
							If oleDbConnection2 IsNot O_O0OO.OoO.0OO__0ooo.() Then
								IL_7FA:
								num2 = 117
								table.Columns("_Identify").Properties("AutoIncrement").Value = True
							End If
							IL_828:
							num2 = 118
							index.Name = text2 + "_PrimaryKey"
							IL_83E:
							num2 = 119
							index.Columns.Append("_Identify", 202, 0)
							IL_858:
							num2 = 120
							index.PrimaryKey = True
							IL_863:
							num2 = 121
							index.Unique = True
							IL_86E:
							num2 = 122
							table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
							IL_889:
							num2 = 123
							catalog.Tables.Append(table)
							IL_89A:
							num2 = 124
							connection.Close()
							IL_8A4:
							num2 = 125
							catalog = Nothing
						End If
						IL_8AA:
						num2 = 126
						If oleDbConnection Is O_O0OO.OoO.0OO__0ooo.() Then
							IL_8B9:
							num2 = 127
							If OO_00oOO.DataTables(text2).frd_IsInnerTable Then
								IL_8D2:
								num2 = 128
								Dim o_oo As o_oo0 = New o_oo0(O_O0OO.OoO.0OO__0ooo.(), False, True)
								IL_8E6:
								num2 = 129
								o_oo.o0_oo0._.().oooO__O_0o_.o_.(text2)
								IL_8FA:
								num2 = 130
								o_oo.o0_oo0._.(False, False)
								IL_90A:
								num2 = 131
								Dim dataTable2 As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.())
								IL_926:
								num2 = 132
								Dim dataRow3 As DataRow = dataTable2.NewRow()
								IL_935:
								num2 = 133
								dataRow3("Name") = text2
								IL_949:
								num2 = 134
								dataRow3("DataSource") = dataRow2("定向到").ToString()
								IL_96C:
								num2 = 135
								dataRow3("Type") = 0
								IL_984:
								num2 = 136
								Dim outerTableSetting As OuterTableSetting = New OuterTableSetting()
								IL_991:
								num2 = 137
								If Not dataRow2.IsNull("目标名称") Then
									IL_9A5:
									num2 = 138
									outerTableSetting.SourceTable = dataRow2("目标名称").ToString()
								Else
									IL_9C5:
									num2 = 140
									outerTableSetting.SourceTable = text2
								End If
								IL_9D4:
								num2 = 141
								dataRow3("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, False, vbVerticalTab, False)
								IL_9F1:
								num2 = 142
								dataTable2.Rows.Add(dataRow3)
								IL_A05:
								dataTable2 = Nothing
							Else
								IL_A0D:
								num2 = 145
								Dim dataRow4 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Find(text2)
								IL_A35:
								num2 = 146
								dataRow4("Type") = 1
								IL_A4D:
								num2 = 147
								dataRow4("DataSource") = dataRow2("定向到").ToString()
							End If
						Else
							IL_A75:
							num2 = 149
							Dim dataRow5 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Find(text2)
							IL_A9D:
							num2 = 150
							If oleDbConnection2 Is O_O0OO.OoO.0OO__0ooo.() Then
								IL_AAC:
								num2 = 151
								If OO_00oOO.DataTables(text2).frd_IsOuterTable Then
									IL_AC5:
									num2 = 152
									dataRow5.Delete()
								Else
									IL_AD7:
									num2 = 154
									dataRow5("Type") = 1
									IL_AEF:
									num2 = 155
									dataRow5("DataSource") = DBNull.Value
								End If
							Else
								IL_B0B:
								num2 = 157
								dataRow5("DataSource") = dataRow2("定向到").ToString()
								IL_B2E:
								num2 = 158
								Dim outerTableSetting2 As OuterTableSetting = New OuterTableSetting()
								IL_B3B:
								num2 = 159
								o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting2, dataRow5("property").ToString(), vbVerticalTab)
								IL_B5B:
								num2 = 160
								If Not dataRow2.IsNull("目标名称") Then
									IL_B6F:
									num2 = 161
									outerTableSetting2.SourceTable = dataRow2("目标名称").ToString()
								Else
									IL_B8F:
									num2 = 163
									outerTableSetting2.SourceTable = text2
								End If
								IL_B9E:
								num2 = 164
								dataRow5("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting2, False, vbVerticalTab, False)
							End If
						End If
						IL_BBB:
						num2 = 165
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
					End If
					IL_BDB:
					num2 = 166
				End While
				IL_BED:
				num2 = 167
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_C08:
				num2 = 168
				MyBase.Close()
				IL_C14:
				num2 = 169
				MessageBox.Show("定向结束，即将重新打开项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_C2D:
				num2 = 170
				Project.Open(OO_00oOO.ProjectFile, New String(-1) {})
				GoTo IL_C44
				IL_C49:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_F03:
				GoTo IL_F37
				IL_F05:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F15:
			Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj5, Exception)
				GoTo IL_F05
			End Try
			IL_F37:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F42:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060038CE RID: 14542 RVA: 0x00187018 File Offset: 0x00185218
		Private Overloads Function <<EMPTY_NAME>>(A_0 As OleDbConnection, A_1 As OleDbConnection, A_2 As DataTable, ByRef A_3 As String) As Integer
			Dim num As Integer
			Dim result As Integer
			Dim num4 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				A_3 = ""
				IL_11:
				num2 = 3
				A_1.Open()
				IL_19:
				num2 = 4
				Dim schema As DataTable = A_1.GetSchema("Tables")
				IL_28:
				num2 = 5
				A_1.Close()
				IL_30:
				num2 = 6
				Dim enumerator As IEnumerator = schema.Rows.GetEnumerator()
				Dim flag As Boolean
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_53:
					num2 = 7
					If A_1 Is O_O0OO.OoO.0OO__0ooo.() Then
						IL_60:
						num2 = 8
						If(dataRow("TABLE_NAME").ToString().Length > 7 AndAlso Operators.CompareString(dataRow("TABLE_NAME").ToString().Substring(7), A_2.Name, True) = 0) OrElse Operators.CompareString(dataRow("TABLE_NAME").ToString(), A_2.Name, True) = 0 Then
							IL_C2:
							num2 = 9
							MessageBox.Show("无法定向表""" + A_2.Name + "，内部数据源存已经存在同名数据表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							IL_E8:
							num2 = 10
							result = 0
							GoTo IL_68D
						End If
					Else
						IL_F2:
						num2 = 12
						If Operators.CompareString(dataRow("TABLE_NAME").ToString(), A_2.Name, True) = 0 Then
							IL_117:
							num2 = 13
							If Operators.CompareString(dataRow("TABLE_TYPE").ToString(), "TABLE", True) <> 0 Then
								IL_138:
								num2 = 14
								MessageBox.Show("无法定向表""" + A_2.Name + "，目标外部数据源存在类型不匹配的同名表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								IL_15E:
								num2 = 15
								result = 0
								GoTo IL_68D
							End If
							IL_168:
							num2 = 16
							flag = True
							IL_16E:
							num2 = 17
							If dataRow.IsNull("TABLE_SCHEMA") OrElse Operators.CompareString(dataRow("TABLE_SCHEMA").ToString(), "dbo", True) = 0 Then
								IL_19D:
								num2 = 18
								A_3 = dataRow("TABLE_NAME").ToString()
								Exit While
							End If
							IL_1B6:
							num2 = 20
							A_3 = String.Concat(New String() { "[", dataRow("TABLE_SCHEMA").ToString(), "].[", dataRow("TABLE_NAME").ToString(), "]" })
							Exit While
						End If
					End If
					IL_209:
					num2 = 22
					Continue While
					IL_68D:
					GoTo IL_83F
				End While
				IL_218:
				num2 = 23
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_230:
				num2 = 24
				If A_2.o._OOO0oOo0__..IndexOf("].[") <= 0 OrElse Not A_2.o._OOO0oOo0__..StartsWith("[") OrElse Not A_2.o._OOO0oOo0__..EndsWith("]") Then
					GoTo IL_281
				End If
				IL_26A:
				num2 = 25
				Dim selectCommandText As String = "Select * From " + A_2.o._OOO0oOo0__.
				GoTo IL_2B0
				IL_281:
				num2 = 27
				selectCommandText = "Select * From [" + A_2.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
				IL_2B0:
				num2 = 28
				A_0.Open()
				IL_2B9:
				num2 = 29
				Dim dataTable As DataTable = New DataTable()
				IL_2C3:
				num2 = 30
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, A_0)
				IL_2D0:
				num2 = 31
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				IL_2DE:
				num2 = 32
				A_0.Close()
				IL_2E7:
				num2 = 33
				If Information.Err().Number = 0 Then
					GoTo IL_31B
				End If
				IL_2F6:
				num2 = 34
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_311:
				num2 = 35
				result = 0
				GoTo IL_68D
				IL_31B:
				num2 = 36
				If A_0 Is O_O0OO.OoO.0OO__0ooo.() Then
					GoTo IL_40E
				End If
				IL_329:
				num2 = 37
				If dataTable.PrimaryKey.Length <> 0 Then
					GoTo IL_342
				End If
				IL_337:
				num2 = 38
				Dim flag2 As Boolean = True
				GoTo IL_3D7
				IL_342:
				num2 = 40
				Dim dataColumn As DataColumn = dataTable.PrimaryKey(0)
				IL_350:
				num2 = 41
				If dataTable.PrimaryKey.Length = 1 AndAlso Operators.CompareString(dataColumn.ColumnName, "_Identify", True) = 0 AndAlso (dataColumn.DataType Is GetType(Integer) OrElse dataColumn.DataType Is GetType(Long)) AndAlso dataTable.Columns.Contains("_Locked") AndAlso dataTable.Columns("_Locked").DataType Is GetType(Boolean) Then
					GoTo IL_3D4
				End If
				IL_3CE:
				num2 = 42
				flag2 = True
				IL_3D4:
				dataColumn = Nothing
				IL_3D7:
				num2 = 44
				If Not flag2 Then
					GoTo IL_40E
				End If
				IL_3DE:
				num2 = 45
				MessageBox.Show("无法定向表""" + A_2.Name + "，没有找到可用的关键列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_404:
				num2 = 46
				result = 0
				GoTo IL_68D
				IL_40E:
				num2 = 47
				If flag Then
					GoTo IL_41F
				End If
				IL_415:
				num2 = 48
				result = 1
				GoTo IL_68D
				IL_41F:
				num2 = 50
				A_1.Open()
				IL_428:
				num2 = 51
				Dim dataTable2 As DataTable = New DataTable()
				IL_432:
				num2 = 52
				Dim oleDbDataAdapter2 As OleDbDataAdapter = New OleDbDataAdapter("Select * from " + A_3, A_1)
				IL_44A:
				num2 = 53
				Dim flag3 As Boolean = True
				IL_450:
				num2 = 54
				oleDbDataAdapter2.FillSchema(dataTable2, SchemaType.Source)
				IL_45E:
				num2 = 55
				A_1.Close()
				IL_467:
				num2 = 56
				If Information.Err().Number = 0 Then
					GoTo IL_49B
				End If
				IL_476:
				num2 = 57
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_491:
				num2 = 58
				result = 0
				GoTo IL_68D
				IL_49B:
				num2 = 59
				If dataTable.Columns.Count <> dataTable2.Columns.Count Then
					GoTo IL_596
				End If
				IL_4BB:
				num2 = 60
				Dim enumerator2 As IEnumerator = dataTable.Columns.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataColumn2 As DataColumn = CType(obj2, DataColumn)
					IL_4DF:
					num2 = 61
					If dataTable2.Columns.Contains(dataColumn2.ColumnName) Then
						IL_4F7:
						num2 = 62
						Dim dataColumn3 As DataColumn = dataTable2.Columns(dataColumn2.ColumnName)
						IL_50F:
						num2 = 63
						If dataColumn2.DataType IsNot GetType(String) OrElse dataColumn3.DataType IsNot dataColumn2.[GetType]() OrElse dataColumn3.MaxLength <> dataColumn2.MaxLength Then
							IL_545:
							num2 = 65
							If dataColumn2.DataType IsNot dataColumn3.DataType Then
								IL_558:
								num2 = 67
								flag3 = False
							End If
						End If
					Else
						IL_560:
						num2 = 69
						flag3 = False
					End If
					IL_566:
					num2 = 70
					If Not flag3 Then
						Exit While
					End If
					IL_56D:
					num2 = 72
				End While
				IL_57C:
				num2 = 73
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
					GoTo IL_59C
				End If
				GoTo IL_59C
				IL_596:
				num2 = 75
				flag3 = False
				IL_59C:
				num2 = 76
				If Not flag3 Then
					GoTo IL_654
				End If
				IL_5A6:
				num2 = 77
				If dataTable2.PrimaryKey.Length <> 0 Then
					GoTo IL_5BF
				End If
				IL_5B4:
				num2 = 78
				flag3 = False
				GoTo IL_654
				IL_5BF:
				num2 = 80
				Dim dataColumn4 As DataColumn = dataTable2.PrimaryKey(0)
				IL_5CD:
				num2 = 81
				If dataTable2.PrimaryKey.Length = 1 AndAlso Operators.CompareString(dataColumn4.ColumnName, "_Identify", True) = 0 AndAlso (dataColumn4.DataType Is GetType(Integer) OrElse dataColumn4.DataType Is GetType(Long)) AndAlso dataTable2.Columns.Contains("_Locked") AndAlso dataTable2.Columns("_Locked").DataType Is GetType(Boolean) Then
					GoTo IL_651
				End If
				IL_64B:
				num2 = 82
				flag3 = False
				IL_651:
				dataColumn4 = Nothing
				IL_654:
				num2 = 84
				If flag3 Then
					GoTo IL_688
				End If
				IL_65B:
				num2 = 85
				MessageBox.Show("无法定向表""" + A_2.Name + "，目标数据源存在结构或主键不匹配的同名表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_681:
				num2 = 86
				result = 0
				GoTo IL_68D
				IL_688:
				num2 = 87
				result = 2
				GoTo IL_68D
				IL_692:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_800:
				GoTo IL_834
				IL_802:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_812:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_802
			End Try
			IL_834:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_83F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060038CF RID: 14543 RVA: 0x0018788C File Offset: 0x00185A8C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Col = 2 Then
				Dim right As String = Me.o0Oo0o0__o.Oo_.().GetData(A_1.Row, "数据源").ToString()
				Dim text As String = ""
				Try
					For Each text2 As String In Me.O_0.O_000_.
						If Operators.CompareString(text2, right, True) <> 0 Then
							text = text + "|" + text2
						End If
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.o0Oo0o0__o.Oo_.().Cols(A_1.Col).ComboList = text
				If Operators.CompareString(text, "", True) = 0 Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x060038D0 RID: 14544 RVA: 0x00187950 File Offset: 0x00185B50
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001774 RID: 6004
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001775 RID: 6005
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001776 RID: 6006
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001777 RID: 6007
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001778 RID: 6008
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001779 RID: 6009
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x0400177A RID: 6010
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400177B RID: 6011
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
