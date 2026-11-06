Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200037D RID: 893
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002
		Inherits Form

		' Token: 0x060038FA RID: 14586 RVA: 0x00188DE7 File Offset: 0x00186FE7
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.O0O__O0oo_._. IsNot Nothing Then
				Me.O0O__O0oo_._..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x060038FB RID: 14587 RVA: 0x00188E08 File Offset: 0x00187008
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo__0OO_.O__.(New SplitContainer())
			Me.oo__0OO_.O__.(New ListBox())
			Me.o_.o_oo0O_oo_.(New C1FlexGrid())
			Me.o.00_0_0.(New C1Button())
			Me.o_.o_oo0O_oo_.(New C1Button())
			Me.oo__0OO_.O__.(New Label())
			Me.o_.o_oo0O_oo_.().Panel1.SuspendLayout()
			Me.o_.o_oo0O_oo_.().Panel2.SuspendLayout()
			Me.o_.o_oo0O_oo_.().SuspendLayout()
			Me.o_.o_oo0O_oo_.().BeginInit()
			MyBase.SuspendLayout()
			Me.o_.o_oo0O_oo_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.o_.o_oo0O_oo_.().FixedPanel = FixedPanel.Panel1
			Me.o_.o_oo0O_oo_.().Location = New Point(0, 0)
			Me.o_.o_oo0O_oo_.().Name = "SplitContainer1"
			Me.o_.o_oo0O_oo_.().Panel1.Controls.Add(Me.o_.o_oo0O_oo_.())
			Me.o_.o_oo0O_oo_.().Panel2.Controls.Add(Me.o_.o_oo0O_oo_.())
			Me.o_.o_oo0O_oo_.().Size = New Size(860, 523)
			Me.o_.o_oo0O_oo_.().SplitterDistance = 216
			Me.o_.o_oo0O_oo_.().TabIndex = 0
			Me.o_.o_oo0O_oo_.().Dock = DockStyle.Fill
			Me.o_.o_oo0O_oo_.().FormattingEnabled = True
			Me.o_.o_oo0O_oo_.().IntegralHeight = False
			Me.o_.o_oo0O_oo_.().ItemHeight = 12
			Me.o_.o_oo0O_oo_.().Location = New Point(0, 0)
			Me.o_.o_oo0O_oo_.().Name = "TableList"
			Me.o_.o_oo0O_oo_.().Size = New Size(216, 523)
			Me.o_.o_oo0O_oo_.().TabIndex = 0
			Me.o_.o_oo0O_oo_.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.o_.o_oo0O_oo_.().Dock = DockStyle.Fill
			Me.o_.o_oo0O_oo_.().Location = New Point(0, 0)
			Me.o_.o_oo0O_oo_.().Name = "C1FlexGrid1"
			Me.o_.o_oo0O_oo_.().Rows.DefaultSize = 19
			Me.o_.o_oo0O_oo_.().Size = New Size(640, 523)
			Me.o_.o_oo0O_oo_.().TabIndex = 0
			Me.o0oo_o_0OOo_.O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o0oo_o_0OOo_.O.().Location = New Point(86, 537)
			Me.o0oo_o_0OOo_.O.().Name = "btnDelete"
			Me.o0oo_o_0OOo_.O.().Size = New Size(75, 23)
			Me.o0oo_o_0OOo_.O.().TabIndex = 3
			Me.o0oo_o_0OOo_.O.().Text = "删除"
			Me.o0oo_o_0OOo_.O.().UseVisualStyleBackColor = True
			Me.o.00_0_0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o.00_0_0.().Location = New Point(5, 537)
			Me.o.00_0_0.().Name = "btnRename"
			Me.o.00_0_0.().Size = New Size(75, 23)
			Me.o.00_0_0.().TabIndex = 2
			Me.o.00_0_0.().Text = "重命名"
			Me.o.00_0_0.().UseVisualStyleBackColor = True
			Me.o_.o_oo0O_oo_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o_.o_oo0O_oo_.().AutoSize = True
			Me.o_.o_oo0O_oo_.().ForeColor = Color.Red
			Me.o_.o_oo0O_oo_.().Location = New Point(681, 542)
			Me.o_.o_oo0O_oo_.().Name = "Label1"
			Me.o_.o_oo0O_oo_.().Size = New Size(167, 12)
			Me.o_.o_oo0O_oo_.().TabIndex = 1
			Me.o_.o_oo0O_oo_.().Text = "提示：这里只显示100行的数据"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(860, 566)
			MyBase.Controls.Add(Me.o0oo_o_0OOo_.O.())
			MyBase.Controls.Add(Me.o_.o_oo0O_oo_.())
			MyBase.Controls.Add(Me.o.00_0_0.())
			MyBase.Controls.Add(Me.o_.o_oo0O_oo_.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O0..0..."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "数据源预览"
			Me.o_.o_oo0O_oo_.().Panel1.ResumeLayout(False)
			Me.o_.o_oo0O_oo_.().Panel2.ResumeLayout(False)
			Me.o_.o_oo0O_oo_.().ResumeLayout(False)
			Me.o_.o_oo0O_oo_.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060038FC RID: 14588 RVA: 0x00189279 File Offset: 0x00187479
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.oo__0OO_.O__.
		End Function

		' Token: 0x060038FD RID: 14589 RVA: 0x00189281 File Offset: 0x00187481
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.oo__0OO_.O__. = A_0
		End Sub

		' Token: 0x060038FE RID: 14590 RVA: 0x0018928A File Offset: 0x0018748A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.oo__0OO_.O__.
		End Function

		' Token: 0x060038FF RID: 14591 RVA: 0x00189294 File Offset: 0x00187494
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Dim value As EventHandler = AddressOf Me.O_0OoO.0O.
			Dim listBox As ListBox = Me.oo__0OO_.O__.
			If listBox IsNot Nothing Then
				RemoveHandler listBox.SelectedIndexChanged, value
			End If
			Me.oo__0OO_.O__. = A_0
			listBox = Me.oo__0OO_.O__.
			If listBox IsNot Nothing Then
				AddHandler listBox.SelectedIndexChanged, value
			End If
		End Sub

		' Token: 0x06003900 RID: 14592 RVA: 0x001892D7 File Offset: 0x001874D7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.oo__0OO_.O__.
		End Function

		' Token: 0x06003901 RID: 14593 RVA: 0x001892DF File Offset: 0x001874DF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.oo__0OO_.O__. = A_0
		End Sub

		' Token: 0x06003902 RID: 14594 RVA: 0x001892E8 File Offset: 0x001874E8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo__0OO_.O__.
		End Function

		' Token: 0x06003903 RID: 14595 RVA: 0x001892F0 File Offset: 0x001874F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo__0OO_.O__. = A_0
		End Sub

		' Token: 0x06003904 RID: 14596 RVA: 0x001892F9 File Offset: 0x001874F9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo__0OO_.O__.
		End Function

		' Token: 0x06003905 RID: 14597 RVA: 0x00189304 File Offset: 0x00187504
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.ooo0.
			Dim c1Button As C1Button = Me.oo__0OO_.O__.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo__0OO_.O__. = A_0
			c1Button = Me.oo__0OO_.O__.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003906 RID: 14598 RVA: 0x00189347 File Offset: 0x00187547
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_.o0Oo.
		End Function

		' Token: 0x06003907 RID: 14599 RVA: 0x00189350 File Offset: 0x00187550
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oo_o_0OOo_.O.
			Dim o_.o0Oo. As C1Button = Me.O_.o0Oo.
			If o_.o0Oo. IsNot Nothing Then
				RemoveHandler o_.o0Oo..Click, value
			End If
			Me.O_.o0Oo. = A_0
			o_.o0Oo. = Me.O_.o0Oo.
			If o_.o0Oo. IsNot Nothing Then
				AddHandler o_.o0Oo..Click, value
			End If
		End Sub

		' Token: 0x06003908 RID: 14600 RVA: 0x00189394 File Offset: 0x00187594
		Friend Sub New(A_0 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.o0oo_o_0OOo_.O.
			Me.O0O__O0oo_._. = 10
			Me.o_.o_oo0O_oo_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O0O__O0oo_._. = A_0.Trim()
			Me.o0oo_o_0OOo_.O.().Visible = False
			Me.o.00_0_0.().Visible = False
		End Sub

		' Token: 0x06003909 RID: 14601 RVA: 0x00189400 File Offset: 0x00187600
		Friend Sub New(A_0 As OleDbConnection, A_1 As O0O, A_2 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.o0oo_o_0OOo_.O.
			Me.O0O__O0oo_._. = 10
			Me.o_.o_oo0O_oo_.()
			Me.O0O__O0oo_._. = A_0
			Me.O0O__O0oo_._. = A_1
			Me.OO0_0oO.o. = A_2
			If Me.O0O__O0oo_._. Is Nothing Then
				Me.o0oo_o_0OOo_.O.().Visible = False
				Me.o.00_0_0.().Visible = False
			End If
		End Sub

		' Token: 0x0600390A RID: 14602 RVA: 0x00189468 File Offset: 0x00187668
		Friend Sub <<EMPTY_NAME>>()
			Try
				If Me.O0O__O0oo_._. Is Nothing AndAlso Me.O0O__O0oo_._. Is Nothing Then
					If Me.O0O__O0oo_._..StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse Me.O0O__O0oo_._..StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
						Me.O0O__O0oo_._. = New O0O(Me.O0O__O0oo_._.)
					Else
						Me.O0O__O0oo_._. = New OleDbConnection(Me.O0O__O0oo_._.)
					End If
				End If
				If Me.O0O__O0oo_._. IsNot Nothing Then
					Me.O0O__O0oo_._..Open()
					Dim dataTable As DataTable
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O0O__O0oo_._.) Then
						o_O_o_oOoo__.o.oO0.(Me.O0O__O0oo_._..ConnectionString)
						Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", Me.O0O__O0oo_._.)
						dataTable = New DataTable()
						dbDataAdapter.Fill(dataTable)
						Try
							For Each obj As Object In dataTable.Rows
								Dim dataRow As DataRow = CType(obj, DataRow)
								Me.o_.o_oo0O_oo_.().Items.Add(String.Concat(New String() { """", dataRow("OWNER").ToString(), """.""", dataRow("TABLE_NAME").ToString(), """" }))
							Next
							GoTo IL_23F
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
					dataTable = Me.O0O__O0oo_._..GetSchema("Tables")
					Dim filterExpression As String
					If Me.O0O__O0oo_._. Is Nothing Then
						filterExpression = "[TABLE_TYPE]='TABLE' Or [TABLE_TYPE]='VIEW'"
					Else
						filterExpression = "[TABLE_TYPE]='TABLE'"
					End If
					For Each dataRow2 As DataRow In dataTable.[Select](filterExpression)
						Dim text As String = Conversions.ToString(dataRow2("TABLE_NAME"))
						If Not dataRow2.IsNull("TABLE_SCHEMA") AndAlso Operators.CompareString(dataRow2("TABLE_SCHEMA").ToString(), "dbo", True) <> 0 Then
							text = String.Concat(New String() { "[", dataRow2("TABLE_SCHEMA").ToString(), "].[", text, "]" })
						End If
						If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) AndAlso Not text.StartsWith("~") Then
							Me.o_.o_oo0O_oo_.().Items.Add(text)
						End If
					Next
					IL_23F:
					Me.O0O__O0oo_._..Close()
				Else
					Dim list As List(Of String) = Me.O0O__O0oo_._..OO._o_OO.()
					Try
						For Each text2 As String In list
							If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text2) AndAlso Not text2.StartsWith("~") Then
								Me.o_.o_oo0O_oo_.().Items.Add(text2)
							End If
						Next
					Finally
						Dim enumerator2 As List(Of String).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
				End If
				If Me.o_.o_oo0O_oo_.().Items.Count > 0 Then
					Me.o_.o_oo0O_oo_.().SelectedIndex = 0
				End If
				MyBase.ShowDialog()
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x0600390B RID: 14603 RVA: 0x001897C0 File Offset: 0x001879C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataTable As DataTable = New DataTable()
			If Me.o_.o_oo0O_oo_.().SelectedItem IsNot Nothing Then
				Dim text As String = Conversions.ToString(Me.o_.o_oo0O_oo_.().SelectedItem)
				If Me.O0O__O0oo_._. IsNot Nothing Then
					If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O0O__O0oo_._.) AndAlso Not text.StartsWith("[") Then
						text = "[" + text + "]"
					End If
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O0O__O0oo_._.) Then
						oleDbDataAdapter = New OleDbDataAdapter("Select * From " + text + " WHERE ROWNUM <= 100", Me.O0O__O0oo_._.)
					Else
						oleDbDataAdapter = New OleDbDataAdapter("Select Top 10 * From " + text, Me.O0O__O0oo_._.)
					End If
					oleDbDataAdapter.Fill(dataTable)
				Else
					Dim httpClient As HttpClient = Me.O0O__O0oo_._..oO0_0.o.()
					httpClient.FormData("Datatable") = text
					httpClient.FormData("Top") = "100"
					httpClient.FormData("Action") = 2.ToString()
					httpClient.FormData("IgnoreSchema") = "True"
					dataTable = httpClient.GetBaseDataTable()
					httpClient.Reset()
				End If
				Me.o_.o_oo0O_oo_.().BeginUpdate()
				Me.o_.o_oo0O_oo_.().AutoResize = True
				Me.o_.o_oo0O_oo_.().DataSource = dataTable
				Dim num As Integer = Me.o_.o_oo0O_oo_.().Cols.Count - 1
				Dim fixed As Integer = Me.o_.o_oo0O_oo_.().Cols.Fixed
				For i As Integer = num To fixed Step -1
					If o_O_o_oOoo__.oO.O_..Contains(Me.o_.o_oo0O_oo_.().Cols(i).Name) Then
						Me.o_.o_oo0O_oo_.().Cols.Remove(i)
					End If
				Next
				Me.o_.o_oo0O_oo_.().EndUpdate()
				Return
			End If
			Me.o_.o_oo0O_oo_.().DataSource = Nothing
		End Sub

		' Token: 0x0600390C RID: 14604 RVA: 0x00189988 File Offset: 0x00187B88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o_.o_oo0O_oo_.().SelectedItem IsNot Nothing Then
				Dim selectedIndex As Integer = Me.o_.o_oo0O_oo_.().SelectedIndex
				Dim text As String = Me.o_.o_oo0O_oo_.().SelectedItem.ToString()
				Dim obj As Object = text
				If text.StartsWith("[") AndAlso text.EndsWith("]") AndAlso text.IndexOf("].[") > 0 Then
					obj = text.Substring(text.LastIndexOf("].[") + 3).Trim(New Char() { "]"c })
				End If
				If OO_00oOO.InputValue(obj, "重命名", "请输入新的表名:") Then
					Dim text2 As String = obj.ToString()
					If Operators.CompareString(text2, "", True) <> 0 AndAlso Operators.CompareString(text2, text, True) <> 0 Then
						If o_O_o_oOoo__.OOOO_OO._oo.(Me.O0O__O0oo_._.) Then
							Dim oleDbCommand As OleDbCommand = New OleDbCommand(String.Concat(New String() { "exec sp_rename '", text, "','", text2, "'" }), Me.O0O__O0oo_._.)
							Try
								Me.O0O__O0oo_._..Open()
								oleDbCommand.ExecuteNonQuery()
								GoTo IL_165
							Catch a_ As Exception
								ooO.oOo0Oo.o.(a_, "")
								Return
							Finally
								Me.O0O__O0oo_._..Close()
							End Try
						End If
						Dim o_oo As o_oo0 = New o_oo0(Me.O0O__O0oo_._., False, False)
						o_oo.o0_oo0._.().O.0_O.(text).Name = text2
						If o_oo.o0_oo0._.(True, False) = 0 Then
							Return
						End If
						IL_165:
						If text.StartsWith("[") AndAlso text.EndsWith("]") AndAlso text.IndexOf("].[") > 0 Then
							text2 = text.Substring(0, text.LastIndexOf("].[")) + "].[" + text2 + "]"
						End If
						Me.o_.o_oo0O_oo_.().Items.Insert(selectedIndex, text2)
						Me.o_.o_oo0O_oo_.().SelectedIndex = selectedIndex
						Me.o_.o_oo0O_oo_.().Items.RemoveAt(selectedIndex + 1)
						Try
							For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows
								Dim dataRow As DataRow = CType(obj2, DataRow)
								If Conversions.ToInteger(dataRow("Type")) = 0 AndAlso Operators.CompareString(dataRow("DataSource").ToString(), Me.OO0_0oO.o., True) = 0 Then
									Dim outerTableSetting As OuterTableSetting = New OuterTableSetting()
									o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, dataRow("Property").ToString(), vbVerticalTab)
									If Operators.CompareString(outerTableSetting.SourceTable, text, True) = 0 Then
										outerTableSetting.SourceTable = text2
										dataRow("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, False, vbVerticalTab, False)
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						Try
							For Each obj3 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows
								Dim dataRow2 As DataRow = CType(obj3, DataRow)
								If Conversions.ToInteger(dataRow2("Type")) = 1 AndAlso Operators.CompareString(dataRow2("DataSource").ToString(), Me.OO0_0oO.o., True) = 0 Then
									Dim text3 As String = dataRow2("Property").ToString()
									If text3.StartsWith("{") AndAlso text3.EndsWith("}") Then
										Dim joinTableProperty As JoinTableProperty = New JoinTableProperty()
										text3 = text3.Trim(New Char() { "{"c, "}"c })
										o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, text3, vbVerticalTab)
										If Operators.CompareString(joinTableProperty.BaseTable, text, True) = 0 Then
											joinTableProperty.BaseTable = text2
										End If
										If Operators.CompareString(joinTableProperty.Columns, "", True) > 0 Then
											joinTableProperty.Columns = joinTableProperty.Columns.Replace("{" + text + "}", "{" + text2 + "}")
										End If
										If Operators.CompareString(joinTableProperty.LinkTables, "", True) > 0 Then
											Dim array As String() = joinTableProperty.LinkTables.Split(New Char() { vbLf })
											Dim num As Integer = array.Length - 1
											For i As Integer = 0 To num
												Dim array2 As String() = array(i).Split(New Char() { vbTab })
												If Operators.CompareString(array2(0), text, True) = 0 Then
													array2(0) = text2
												End If
												If Operators.CompareString(array2(2), text, True) = 0 Then
													array2(2) = text2
												End If
												array(i) = String.Join(vbTab, array2)
											Next
											joinTableProperty.LinkTables = String.Join(vbLf, array)
										End If
										dataRow2("Property") = "{" + o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, False, vbVerticalTab, False) + "}"
									End If
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
						Me.O0O__O0oo_._. = True
					End If
				End If
			End If
		End Sub

		' Token: 0x0600390D RID: 14605 RVA: 0x00189EF4 File Offset: 0x001880F4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o_.o_oo0O_oo_.().SelectedItem IsNot Nothing Then
				Dim text As String = Me.o_.o_oo0O_oo_.().SelectedItem.ToString()
				Dim flag As Boolean = True
				Try
					For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						If Conversions.ToInteger(dataRow("Type")) = 0 Then
							Dim key As String = dataRow("DataSource").ToString()
							If O_O0OO.O._o_.().ContainsKey(key) AndAlso Operators.CompareString(O_O0OO.O._o_.()(key).ConnectionString, Me.O0O__O0oo_._..ConnectionString, True) = 0 Then
								Dim outerTableSetting As OuterTableSetting = New OuterTableSetting()
								o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, dataRow("Property").ToString(), vbVerticalTab)
								If Operators.CompareString(outerTableSetting.SourceTable, text, True) = 0 Then
									flag = False
									Exit For
								End If
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If flag Then
					Try
						For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows
							Dim dataRow2 As DataRow = CType(obj2, DataRow)
							If Conversions.ToInteger(dataRow2("Type")) = 1 Then
								Dim key2 As String = dataRow2("DataSource").ToString()
								If O_O0OO.O._o_.().ContainsKey(key2) AndAlso Operators.CompareString(O_O0OO.O._o_.()(key2).ConnectionString, Me.O0O__O0oo_._..ConnectionString, True) = 0 Then
									Dim text2 As String = dataRow2("Property").ToString()
									If text2.StartsWith("{") AndAlso text2.EndsWith("}") Then
										Dim joinTableProperty As JoinTableProperty = New JoinTableProperty()
										text2 = text2.Trim(New Char() { "{"c, "}"c })
										o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, text2, vbVerticalTab)
										If Operators.CompareString(joinTableProperty.BaseTable, text, True) = 0 Then
											flag = False
											Exit For
										End If
										If Operators.CompareString(joinTableProperty.LinkTables, "", True) > 0 Then
											Dim array As String() = joinTableProperty.LinkTables.Split(New Char() { vbLf })
											Dim num As Integer = array.Length - 1
											For i As Integer = 0 To num
												Dim array2 As String() = array(i).Split(New Char() { vbTab })
												If Operators.CompareString(array2(0), text, True) = 0 Then
													flag = False
													Exit For
												End If
												If Operators.CompareString(array2(2), text, True) = 0 Then
													flag = False
													Exit For
												End If
											Next
											If Not flag Then
												Exit For
											End If
										End If
									End If
								End If
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				End If
				If flag Then
					If MessageBox.Show("删除表是不可撤销的，确定要删除表" + text + "吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
						Return
					End If
					Try
						Me.O0O__O0oo_._..Open()
						New OleDbCommand("Drop Table [" + text + "]", Me.O0O__O0oo_._.).ExecuteScalar()
						Me.o_.o_oo0O_oo_.().Items.RemoveAt(Me.o_.o_oo0O_oo_.().SelectedIndex)
						Return
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
						Return
					Finally
						Me.O0O__O0oo_._..Close()
					End Try
				End If
				MessageBox.Show(text + "表已经被当前项目使用，不能删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x0600390E RID: 14606 RVA: 0x0018A2CC File Offset: 0x001884CC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400178E RID: 6030
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400178F RID: 6031
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04001790 RID: 6032
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001791 RID: 6033
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001792 RID: 6034
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001793 RID: 6035
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001794 RID: 6036
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001795 RID: 6037
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04001796 RID: 6038
		Private <<EMPTY_NAME>> As O0O

		' Token: 0x04001797 RID: 6039
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001798 RID: 6040
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001799 RID: 6041
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400179A RID: 6042
		Private <<EMPTY_NAME>> As HttpClient

		' Token: 0x0400179B RID: 6043
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
