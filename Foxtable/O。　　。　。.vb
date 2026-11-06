Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Foxtable.RibbonMenu
Imports Microsoft.VisualBasic.CompilerServices
Imports MSDASC

Namespace Foxtable
	' Token: 0x02000333 RID: 819
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3000\u3002\u3000\u3002
		Inherits Form

		' Token: 0x060030E4 RID: 12516 RVA: 0x0013CEC8 File Offset: 0x0013B0C8
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo_o0.O0oOOo_. IsNot Nothing Then
					Me.Oo_o0.O0oOOo_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060030E5 RID: 12517 RVA: 0x0013CF08 File Offset: 0x0013B108
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo0o_o._.(New C1FlexGrid())
			Me.oo0o_o._.(New C1ComboBox())
			Me.oo0o_o._.(New C1Button())
			Me.O0o__o_Oo00.o_.(New C1Button())
			Me.O0OOoO0O.__0_.(New RadioButton())
			Me.oo0o_o._.(New RadioButton())
			Me.O0o__o_Oo00.o_.(New RadioButton())
			Me.OOo.0_O.().BeginInit()
			MyBase.SuspendLayout()
			Me.OOo.0_O.().AllowEditing = False
			Me.OOo.0_O.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.OOo.0_O.().Location = New Point(12, 49)
			Me.OOo.0_O.().Name = "Grid"
			Me.OOo.0_O.().Rows.Count = 1
			Me.OOo.0_O.().Rows.DefaultSize = 20
			Me.OOo.0_O.().SelectionMode = 5
			Me.OOo.0_O.().Size = New Size(596, 272)
			Me.OOo.0_O.().TabIndex = 1
			Me.OOo.0_O.().DropDownStyle = 1
			Me.OOo.0_O.().Location = New Point(12, 13)
			Me.OOo.0_O.().Name = "lstTables"
			Me.OOo.0_O.().Size = New Size(374, 20)
			Me.OOo.0_O.().TabIndex = 0
			Me.o0_o.__ooo_0_.().DialogResult = DialogResult.Cancel
			Me.o0_o.__ooo_0_.().Location = New Point(313, 370)
			Me.o0_o.__ooo_0_.().Name = "Button3"
			Me.o0_o.__ooo_0_.().Size = New Size(75, 23)
			Me.o0_o.__ooo_0_.().TabIndex = 6
			Me.o0_o.__ooo_0_.().Text = "取消"
			Me.o0_o.__ooo_0_.().UseVisualStyleBackColor = True
			Me.OOo.0_O.().Location = New Point(232, 370)
			Me.OOo.0_O.().Name = "Button2"
			Me.OOo.0_O.().Size = New Size(75, 23)
			Me.OOo.0_O.().TabIndex = 5
			Me.OOo.0_O.().Text = "确定"
			Me.OOo.0_O.().UseVisualStyleBackColor = True
			Me.o0_o.__ooo_0_.().AutoSize = True
			Me.o0_o.__ooo_0_.().Location = New Point(12, 338)
			Me.o0_o.__ooo_0_.().Name = "UpdateExistRow"
			Me.o0_o.__ooo_0_.().Size = New Size(107, 16)
			Me.o0_o.__ooo_0_.().TabIndex = 2
			Me.o0_o.__ooo_0_.().Text = "更新同主键记录"
			Me.o0_o.__ooo_0_.().UseVisualStyleBackColor = True
			Me.O.__o_.().AutoSize = True
			Me.O.__o_.().Location = New Point(142, 338)
			Me.O.__o_.().Name = "SkipExistRow"
			Me.O.__o_.().Size = New Size(107, 16)
			Me.O.__o_.().TabIndex = 3
			Me.O.__o_.().Text = "跳过同主键记录"
			Me.O.__o_.().UseVisualStyleBackColor = True
			Me.OOo.0_O.().AutoSize = True
			Me.OOo.0_O.().Checked = True
			Me.OOo.0_O.().Location = New Point(272, 338)
			Me.OOo.0_O.().Name = "IgnorePrimaryKey"
			Me.OOo.0_O.().Size = New Size(203, 16)
			Me.OOo.0_O.().TabIndex = 4
			Me.OOo.0_O.().TabStop = True
			Me.OOo.0_O.().Text = "合并过程不比较主键(无条件合并)"
			Me.OOo.0_O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(620, 407)
			MyBase.Controls.Add(Me.OOo.0_O.())
			MyBase.Controls.Add(Me.O.__o_.())
			MyBase.Controls.Add(Me.o0_o.__ooo_0_.())
			MyBase.Controls.Add(Me.OOo.0_O.())
			MyBase.Controls.Add(Me.OOo.0_O.())
			MyBase.Controls.Add(Me.o0_o.__ooo_0_.())
			MyBase.Controls.Add(Me.OOo.0_O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.0o..O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "合并"
			Me.OOo.0_O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060030E6 RID: 12518 RVA: 0x0013D39A File Offset: 0x0013B59A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Oo_o0.O0oOOo_.
		End Function

		' Token: 0x060030E7 RID: 12519 RVA: 0x0013D3A2 File Offset: 0x0013B5A2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.Oo_o0.O0oOOo_. = A_0
		End Sub

		' Token: 0x060030E8 RID: 12520 RVA: 0x0013D3AB File Offset: 0x0013B5AB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Oo_o0.O0oOOo_.
		End Function

		' Token: 0x060030E9 RID: 12521 RVA: 0x0013D3B4 File Offset: 0x0013B5B4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O0o__o_Oo00.o_.
			Dim oo_o0.O0oOOo_. As C1ComboBox = Me.Oo_o0.O0oOOo_.
			If oo_o0.O0oOOo_. IsNot Nothing Then
				oo_o0.O0oOOo_..SelectedIndexChanged -= eventHandler
			End If
			Me.Oo_o0.O0oOOo_. = A_0
			oo_o0.O0oOOo_. = Me.Oo_o0.O0oOOo_.
			If oo_o0.O0oOOo_. IsNot Nothing Then
				oo_o0.O0oOOo_..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x060030EA RID: 12522 RVA: 0x0013D3F7 File Offset: 0x0013B5F7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_o0.O0oOOo_.
		End Function

		' Token: 0x060030EB RID: 12523 RVA: 0x0013D3FF File Offset: 0x0013B5FF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo_o0.O0oOOo_. = A_0
		End Sub

		' Token: 0x060030EC RID: 12524 RVA: 0x0013D408 File Offset: 0x0013B608
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.oO0o.
		End Function

		' Token: 0x060030ED RID: 12525 RVA: 0x0013D410 File Offset: 0x0013B610
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0OO0OoOO0._.
			Dim o.oO0o. As C1Button = Me.O.oO0o.
			If o.oO0o. IsNot Nothing Then
				RemoveHandler o.oO0o..Click, value
			End If
			Me.O.oO0o. = A_0
			o.oO0o. = Me.O.oO0o.
			If o.oO0o. IsNot Nothing Then
				AddHandler o.oO0o..Click, value
			End If
		End Sub

		' Token: 0x060030EE RID: 12526 RVA: 0x0013D453 File Offset: 0x0013B653
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.Oo_o0.O0oOOo_.
		End Function

		' Token: 0x060030EF RID: 12527 RVA: 0x0013D45B File Offset: 0x0013B65B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.Oo_o0.O0oOOo_. = A_0
		End Sub

		' Token: 0x060030F0 RID: 12528 RVA: 0x0013D464 File Offset: 0x0013B664
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O.oO0o.
		End Function

		' Token: 0x060030F1 RID: 12529 RVA: 0x0013D46C File Offset: 0x0013B66C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O.oO0o. = A_0
		End Sub

		' Token: 0x060030F2 RID: 12530 RVA: 0x0013D475 File Offset: 0x0013B675
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O0OOoO0O.__0_.
		End Function

		' Token: 0x060030F3 RID: 12531 RVA: 0x0013D47D File Offset: 0x0013B67D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O0OOoO0O.__0_. = A_0
		End Sub

		' Token: 0x060030F4 RID: 12532 RVA: 0x0013D486 File Offset: 0x0013B686
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.Oo_o0.O0oOOo_..ConnectionString
		End Function

		' Token: 0x060030F5 RID: 12533 RVA: 0x0013D493 File Offset: 0x0013B693
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.Oo_o0.O0oOOo_..ConnectionString = A_0
		End Sub

		' Token: 0x060030F6 RID: 12534 RVA: 0x0013D4A4 File Offset: 0x0013B6A4
		Friend Function <<EMPTY_NAME>>() As Boolean
			' The following expression was wrapped in a checked-statement
			Try
				Me.Oo_o0.O0oOOo_..Open()
				Dim dataTable As DataTable = Me.Oo_o0.O0oOOo_..GetSchema("Tables")
				Me.OOo.0_O.().Items.Add("请选择要合并的表...")
				Dim filterExpression As String = "[TABLE_TYPE]='TABLE'"
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.Oo_o0.O0oOOo_.) Then
					o_O_o_oOoo__.o.oO0.(Me.Oo_o0.O0oOOo_..ConnectionString)
					Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", Me.Oo_o0.O0oOOo_.)
					dataTable = New DataTable()
					dbDataAdapter.Fill(dataTable)
					Try
						For Each obj As Object In dataTable.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Me.OOo.0_O.().Items.Add(String.Concat(New String() { """", dataRow("OWNER").ToString(), """.""", dataRow("TABLE_NAME").ToString(), """" }))
						Next
						GoTo IL_15E
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Dim array As DataRow() = dataTable.[Select](filterExpression)
				For i As Integer = 0 To array.Length - 1
					Dim text As String = Conversions.ToString(array(i)("TABLE_NAME"))
					If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) Then
						Me.OOo.0_O.().Items.Add(text)
					End If
				Next
				IL_15E:
				If Me.OOo.0_O.().Items.Count > 0 Then
					Me.OOo.0_O.().SelectedIndex = 0
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				Return False
			Finally
				If Me.Oo_o0.O0oOOo_..State = ConnectionState.Open Then
					Me.Oo_o0.O0oOOo_..Close()
				End If
			End Try
			Return True
		End Function

		' Token: 0x060030F7 RID: 12535 RVA: 0x0013D6B8 File Offset: 0x0013B8B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OOo.0_O.().SelectedIndex = 0 Then
				Me.OOo.0_O.().DataSource = Nothing
				Return
			End If
			Dim selectCommandText As String
			If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.Oo_o0.O0oOOo_.) Then
				selectCommandText = "Select * From " + Me.OOo.0_O.().SelectedItem.ToString()
			Else
				selectCommandText = "Select * From [" + Me.OOo.0_O.().SelectedItem.ToString() + "]"
			End If
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, Me.Oo_o0.O0oOOo_.)
			Dim dataTable As DataTable = New DataTable()
			oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
			oleDbDataAdapter.Fill(dataTable)
			Me.OOo.0_O.().AutoResize = True
			Me.OOo.0_O.().DataSource = dataTable
		End Sub

		' Token: 0x060030F8 RID: 12536 RVA: 0x0013D764 File Offset: 0x0013B964
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim connection As Connection = New ConnectionClass()
			Dim dataLinks As DataLinks = New DataLinksClass()
			connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
			Try
				Dim dataSourceLocator As IDataSourceLocator = dataLinks
				Dim obj As Object = connection
				If dataSourceLocator.PromptEdit(obj) AndAlso Operators.CompareString(connection.ConnectionString, "Provider=Microsoft.Jet.OLEDB.4.0;", True) <> 0 Then
					Me.oo0o_o._.(connection.ConnectionString)
					Return True
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			Return False
		End Function

		' Token: 0x060030F9 RID: 12537 RVA: 0x0013D7E8 File Offset: 0x0013B9E8
		Public Sub New(A_0 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.OOo.0_O.
			Me.Oo_o0.O0oOOo_. = New OleDbConnection()
			Me.oo0o_o._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oo0o_o._.(A_0)
		End Sub

		' Token: 0x060030FA RID: 12538 RVA: 0x0013D83C File Offset: 0x0013BA3C
		Public Sub New(A_0 As String, A_1 As Boolean)
			AddHandler MyBase.FormClosed, AddressOf Me.OOo.0_O.
			Me.Oo_o0.O0oOOo_. = New OleDbConnection()
			Me.oo0o_o._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Dim extension As String = Path.GetExtension(A_0)
			If Operators.CompareString(extension, ".mdb", True) = 0 Then
				Me.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password="
				Me.oo0o_o._.()
				Return
			End If
			If Operators.CompareString(extension, ".accdb", True) = 0 Then
				Me.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password="
				Me.oo0o_o._.()
				Return
			End If
			If Operators.CompareString(extension, ".xls", True) = 0 Then
				Me.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Extended Properties=""Excel 8.0;HDR=YES"""
				Me.oo0o_o._.()
				Return
			End If
			If Operators.CompareString(extension, ".xlsx", True) = 0 Then
				Me.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Extended Properties=""Excel 12.0;HDR=YES"""
				Me.oo0o_o._.()
				Return
			End If
			If Operators.CompareString(extension, ".dbf", True) = 0 Then
				Me.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=dBASE IV"
				Me.OOo.0_O.().Items.Add("请选择要合并的表...")
				Me.OOo.0_O.().Items.Add(Path.GetFileNameWithoutExtension(A_0))
				Me.OOo.0_O.().SelectedIndex = 1
				Return
			End If
			If Operators.CompareString(extension, ".txt", True) = 0 Then
				Me.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=""text;HDR=Yes;FMT=Delimited"""
				Me.OOo.0_O.().Items.Add("请选择要合并的表...")
				Me.OOo.0_O.().Items.Add(Path.GetFileNameWithoutExtension(A_0) + "#TXT")
				Me.OOo.0_O.().SelectedIndex = 1
			End If
		End Sub

		' Token: 0x060030FB RID: 12539 RVA: 0x0013DA40 File Offset: 0x0013BC40
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OOo.0_O.().SelectedIndex >= 1 Then
				Dim dataTable As DataTable = CType(Me.OOo.0_O.().DataSource, DataTable)
				Dim dataTable2 As DataTable = OO_00oOO.CurrentTable.DataTable.BaseTable
				Dim flag As Boolean = True
				Dim flag2 As Boolean = True
				Dim flag3 As Boolean
				If OO_00oOO.CurrentTable.DataTable.frd_IsInnerTable AndAlso dataTable.PrimaryKey.Length = 1 AndAlso Operators.CompareString(dataTable.PrimaryKey(0).ColumnName, "_Identiify", True) = 0 AndAlso (dataTable.PrimaryKey(0).DataType Is GetType(Integer) OrElse dataTable.PrimaryKey(0).DataType Is GetType(Long)) Then
					flag3 = True
				End If
				Dim list As List(Of String)
				If Not flag3 Then
					Dim primaryKey As DataColumn() = dataTable2.PrimaryKey
					Dim i As Integer = 0
					While i < primaryKey.Length
						Dim dataColumn As DataColumn = primaryKey(i)
						If Not dataTable.Columns.Contains(dataColumn.ColumnName) OrElse dataTable.Columns(dataColumn.ColumnName).DataType IsNot dataColumn.DataType Then
							flag = False
							If dataTable2.PrimaryKey.Length <> 1 OrElse Not dataTable2.PrimaryKey(0).AutoIncrement Then
								MessageBox.Show("对于非兼容外部表，如果主键列不是自动增量型，则所有主键列必须在要合并的表中，有同名、同类型的对应列，否则无法合并。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Return
							End If
							Exit While
						Else
							i += 1
						End If
					End While
				End If
				If dataTable2.PrimaryKey.Length = 1 AndAlso dataTable2.PrimaryKey(0).AutoIncrement Then
					flag2 = True
				End If
				Me.OOo.0_O.().BeginUpdate()
				list = New List(Of String)()
				For j As Integer = dataTable.Columns.Count - 1 To 0 Step -1
					If dataTable2.Columns.Contains(dataTable.Columns(j).ColumnName) Then
						Dim columnName As String = dataTable.Columns(j).ColumnName
						If Not flag2 OrElse Operators.CompareString(dataTable2.PrimaryKey(0).ColumnName, columnName, True) <> 0 Then
							list.Add(dataTable.Columns(j).ColumnName)
						End If
					End If
				Next
				Try
					Me.Cursor = Cursors.WaitCursor
					Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并..."
					Application.DoEvents()
					OO_00oOO.CurrentTable.StopRedraw()
					Try
						For Each obj As Object In dataTable.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Dim dataRow2 As DataRow = Nothing
							If flag And Not Me.OOo.0_O.().Checked Then
								Dim array As Object() = New Object(dataTable2.PrimaryKey.Length - 1 + 1 - 1) {}
								Dim num As Integer = dataTable2.PrimaryKey.Length - 1
								For k As Integer = 0 To num
									array(k) = RuntimeHelpers.GetObjectValue(dataRow(dataTable2.PrimaryKey(k).ColumnName))
								Next
								dataRow2 = dataTable2.Rows.Find(array)
							End If
							If Me.o0_o.__ooo_0_.().Checked OrElse dataRow2 Is Nothing Then
								If dataRow2 Is Nothing Then
									dataRow2 = dataTable2.NewRow()
								End If
								Try
									For Each columnName2 As String In list
										dataRow2(columnName2) = RuntimeHelpers.GetObjectValue(dataRow(columnName2))
									Next
								Finally
									Dim enumerator2 As List(Of String).Enumerator
									CType(enumerator2, IDisposable).Dispose()
								End Try
								If dataRow2.RowState = DataRowState.Detached Then
									dataTable2.Rows.Add(dataRow2)
								End If
								Dim num2 As Integer
								num2 += 1
								If num2 Mod 100 = 0 Then
									Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并，已经合并" + Conversions.ToString(num2) + "条记录"
									Application.DoEvents()
								End If
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
					Return
				Finally
					Me.Cursor = Cursors.[Default]
					Foxtable.RibbonMenu.StatusBar.Message1 = ""
					OO_00oOO.CurrentTable.ResumeRedraw()
				End Try
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x060030FC RID: 12540 RVA: 0x0013DE58 File Offset: 0x0013C058
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400139E RID: 5022
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400139F RID: 5023
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040013A0 RID: 5024
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040013A1 RID: 5025
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013A2 RID: 5026
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013A3 RID: 5027
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013A4 RID: 5028
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013A5 RID: 5029
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013A6 RID: 5030
		Private <<EMPTY_NAME>> As OleDbConnection
	End Class
End Namespace
