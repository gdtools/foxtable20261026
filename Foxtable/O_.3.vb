Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
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
Imports Foxtable.RibbonMenu
Imports Microsoft.VisualBasic.CompilerServices
Imports MSDASC

Namespace Foxtable
	' Token: 0x02000330 RID: 816
	<DesignerGenerated()>
	Friend Partial Class O_\u3000\u3000
		Inherits Form

		' Token: 0x06003094 RID: 12436 RVA: 0x0013A2C0 File Offset: 0x001384C0
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O__.oOO. IsNot Nothing Then
					Me.O__.oOO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003095 RID: 12437 RVA: 0x0013A300 File Offset: 0x00138500
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Ooo000_OO00.o.(New C1Button())
			Me.O.OOo_.(New C1ComboBox())
			Me.O.OOo_.(New C1Button())
			Me.Ooo.0O_O0.(New C1Button())
			Me.O.OOo_.(New System.Windows.Forms.Label())
			Me.O.OOo_.(New C1TextBox())
			Me.O.OOo_.(New C1CheckBox())
			Me.O.OOo_.(New C1FlexGrid())
			Me.ooO_o_.oo.().BeginInit()
			Me.oO0O.OO_.().BeginInit()
			Me.OOOo000._o.().BeginInit()
			Me.O0OO.o.().BeginInit()
			Me.oO0O.OO_.().BeginInit()
			Me.O0OO.o.().BeginInit()
			Me.O0OO.o.().BeginInit()
			MyBase.SuspendLayout()
			Me.ooO_o_.oo.().Location = New Point(18, 548)
			Me.ooO_o_.oo.().Margin = New Padding(4)
			Me.ooO_o_.oo.().Name = "Button1"
			Me.ooO_o_.oo.().Size = New Size(112, 34)
			Me.ooO_o_.oo.().TabIndex = 4
			Me.ooO_o_.oo.().Text = "删除列"
			Me.ooO_o_.oo.().UseVisualStyleBackColor = True
			Me.oO0O.OO_.().AllowSpinLoop = False
			Me.oO0O.OO_.().Cursor = Cursors.Arrow
			Me.oO0O.OO_.().DropDownStyle = 1
			Me.oO0O.OO_.().GapHeight = 0
			Me.oO0O.OO_.().ImagePadding = New Padding(0)
			Me.oO0O.OO_.().ItemsDisplayMember = ""
			Me.oO0O.OO_.().ItemsValueMember = ""
			Me.oO0O.OO_.().Location = New Point(22, 19)
			Me.oO0O.OO_.().Margin = New Padding(4)
			Me.oO0O.OO_.().Name = "lstTables"
			Me.oO0O.OO_.().Size = New Size(561, 26)
			Me.oO0O.OO_.().TabIndex = 0
			Me.oO0O.OO_.().Tag = Nothing
			Me.OOOo000._o.().DialogResult = DialogResult.Cancel
			Me.OOOo000._o.().Location = New Point(806, 548)
			Me.OOOo000._o.().Margin = New Padding(4)
			Me.OOOo000._o.().Name = "Button3"
			Me.OOOo000._o.().Size = New Size(112, 34)
			Me.OOOo000._o.().TabIndex = 6
			Me.OOOo000._o.().Text = "取消"
			Me.OOOo000._o.().UseVisualStyleBackColor = True
			Me.O0OO.o.().Location = New Point(684, 548)
			Me.O0OO.o.().Margin = New Padding(4)
			Me.O0OO.o.().Name = "Button2"
			Me.O0OO.o.().Size = New Size(112, 34)
			Me.O0OO.o.().TabIndex = 5
			Me.O0OO.o.().Text = "确定"
			Me.O0OO.o.().UseVisualStyleBackColor = True
			Me.oO0O.OO_.().AutoSize = True
			Me.oO0O.OO_.().Location = New Point(608, 23)
			Me.oO0O.OO_.().Margin = New Padding(4, 0, 4, 0)
			Me.oO0O.OO_.().Name = "Label2"
			Me.oO0O.OO_.().Size = New Size(53, 18)
			Me.oO0O.OO_.().TabIndex = 43
			Me.oO0O.OO_.().Text = "行数:"
			Me.oO0O.OO_.().Location = New Point(669, 19)
			Me.oO0O.OO_.().Margin = New Padding(4)
			Me.oO0O.OO_.().Name = "TextBox1"
			Me.oO0O.OO_.().Size = New Size(102, 26)
			Me.oO0O.OO_.().TabIndex = 1
			Me.oO0O.OO_.().Tag = Nothing
			Me.oO0O.OO_.().Value = "10"
			Me.O0OO.o.().AutoSize = True
			Me.O0OO.o.().BorderStyle = BorderStyle.None
			Me.O0OO.o.().Location = New Point(806, 21)
			Me.O0OO.o.().Margin = New Padding(4)
			Me.O0OO.o.().Name = "chkAll"
			Me.O0OO.o.().Size = New Size(106, 22)
			Me.O0OO.o.().TabIndex = 2
			Me.O0OO.o.().Text = "全部导入"
			Me.O0OO.o.().UseVisualStyleBackColor = True
			Me.O0OO.o.().Value = Nothing
			Me.O0OO.o.().AllowDragging = 0
			Me.O0OO.o.().AllowEditing = False
			Me.O0OO.o.().AllowSorting = 0
			Me.O0OO.o.().ColumnInfo = "0,0,0,0,0,135,Columns:"
			Me.O0OO.o.().Location = New Point(18, 64)
			Me.O0OO.o.().Name = "grid"
			Me.O0OO.o.().Rows.Count = 2
			Me.O0OO.o.().Rows.DefaultSize = 19
			Me.O0OO.o.().SelectionMode = 5
			Me.O0OO.o.().Size = New Size(894, 450)
			Me.O0OO.o.().TabIndex = 44
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(940, 600)
			MyBase.Controls.Add(Me.O0OO.o.())
			MyBase.Controls.Add(Me.O0OO.o.())
			MyBase.Controls.Add(Me.oO0O.OO_.())
			MyBase.Controls.Add(Me.oO0O.OO_.())
			MyBase.Controls.Add(Me.ooO_o_.oo.())
			MyBase.Controls.Add(Me.oO0O.OO_.())
			MyBase.Controls.Add(Me.OOOo000._o.())
			MyBase.Controls.Add(Me.O0OO.o.())
			MyBase.Margin = New Padding(4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "_o......o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "导入"
			Me.ooO_o_.oo.().EndInit()
			Me.oO0O.OO_.().EndInit()
			Me.OOOo000._o.().EndInit()
			Me.O0OO.o.().EndInit()
			Me.oO0O.OO_.().EndInit()
			Me.O0OO.o.().EndInit()
			Me.O0OO.o.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003096 RID: 12438 RVA: 0x0013A972 File Offset: 0x00138B72
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.OOo_.
		End Function

		' Token: 0x06003097 RID: 12439 RVA: 0x0013A97C File Offset: 0x00138B7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_.0__oo_O.
			Dim o.OOo_. As C1Button = Me.O.OOo_.
			If o.OOo_. IsNot Nothing Then
				RemoveHandler o.OOo_..Click, value
			End If
			Me.O.OOo_. = A_0
			o.OOo_. = Me.O.OOo_.
			If o.OOo_. IsNot Nothing Then
				AddHandler o.OOo_..Click, value
			End If
		End Sub

		' Token: 0x06003098 RID: 12440 RVA: 0x0013A9BF File Offset: 0x00138BBF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O__.oOO.
		End Function

		' Token: 0x06003099 RID: 12441 RVA: 0x0013A9C8 File Offset: 0x00138BC8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o_0.o_oo0_OO.
			Dim o__.oOO. As C1ComboBox = Me.O__.oOO.
			If o__.oOO. IsNot Nothing Then
				o__.oOO..SelectedIndexChanged -= eventHandler
			End If
			Me.O__.oOO. = A_0
			o__.oOO. = Me.O__.oOO.
			If o__.oOO. IsNot Nothing Then
				o__.oOO..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600309A RID: 12442 RVA: 0x0013AA0B File Offset: 0x00138C0B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOOO0oo000.00o.
		End Function

		' Token: 0x0600309B RID: 12443 RVA: 0x0013AA13 File Offset: 0x00138C13
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oOOO0oo000.00o. = A_0
		End Sub

		' Token: 0x0600309C RID: 12444 RVA: 0x0013AA1C File Offset: 0x00138C1C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O0_.Oo0o.
		End Function

		' Token: 0x0600309D RID: 12445 RVA: 0x0013AA24 File Offset: 0x00138C24
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo_ooOo0oo.OOo.
			Dim c1Button As C1Button = Me.o0O0_.Oo0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O0_.Oo0o. = A_0
			c1Button = Me.o0O0_.Oo0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600309E RID: 12446 RVA: 0x0013AA67 File Offset: 0x00138C67
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Label
			Return Me.O__.oOO.
		End Function

		' Token: 0x0600309F RID: 12447 RVA: 0x0013AA6F File Offset: 0x00138C6F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Label)
			Me.O__.oOO. = A_0
		End Sub

		' Token: 0x060030A0 RID: 12448 RVA: 0x0013AA78 File Offset: 0x00138C78
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O__.oOO.
		End Function

		' Token: 0x060030A1 RID: 12449 RVA: 0x0013AA80 File Offset: 0x00138C80
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As EventHandler = AddressOf Me.O.OOo_.
			Dim o__.oOO. As C1TextBox = Me.O__.oOO.
			If o__.oOO. IsNot Nothing Then
				RemoveHandler o__.oOO..Validated, value
			End If
			Me.O__.oOO. = A_0
			o__.oOO. = Me.O__.oOO.
			If o__.oOO. IsNot Nothing Then
				AddHandler o__.oOO..Validated, value
			End If
		End Sub

		' Token: 0x060030A2 RID: 12450 RVA: 0x0013AAC3 File Offset: 0x00138CC3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O__.oOO.
		End Function

		' Token: 0x060030A3 RID: 12451 RVA: 0x0013AACC File Offset: 0x00138CCC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.OOOo000._o.
			Dim o__.oOO. As C1CheckBox = Me.O__.oOO.
			If o__.oOO. IsNot Nothing Then
				RemoveHandler o__.oOO..CheckedChanged, value
			End If
			Me.O__.oOO. = A_0
			o__.oOO. = Me.O__.oOO.
			If o__.oOO. IsNot Nothing Then
				AddHandler o__.oOO..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060030A4 RID: 12452 RVA: 0x0013AB0F File Offset: 0x00138D0F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O__.oOO.
		End Function

		' Token: 0x060030A5 RID: 12453 RVA: 0x0013AB17 File Offset: 0x00138D17
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.O__.oOO. = A_0
		End Sub

		' Token: 0x060030A6 RID: 12454 RVA: 0x0013AB20 File Offset: 0x00138D20
		Friend Overloads Function <<EMPTY_NAME>>() As String
			Return Me.O__.oOO..ConnectionString
		End Function

		' Token: 0x060030A7 RID: 12455 RVA: 0x0013AB2D File Offset: 0x00138D2D
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O__.oOO..ConnectionString = A_0
		End Sub

		' Token: 0x060030A8 RID: 12456 RVA: 0x0013AB3C File Offset: 0x00138D3C
		Friend Function <<EMPTY_NAME>>() As Boolean
			' The following expression was wrapped in a checked-statement
			Try
				Me.O__.oOO..Open()
				Me.oO0O.OO_.().Items.Add("请选择要导入的表...")
				Dim filterExpression As String = "[TABLE_TYPE]='TABLE' Or [TABLE_TYPE]='VIEW'"
				Dim dataTable As DataTable
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O__.oOO.) Then
					o_O_o_oOoo__.o.oO0.(Me.O__.oOO..ConnectionString)
					Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", Me.O__.oOO.)
					dataTable = New DataTable()
					dbDataAdapter.Fill(dataTable)
					Try
						For Each obj As Object In dataTable.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Me.oO0O.OO_.().Items.Add(String.Concat(New String() { """", dataRow("OWNER").ToString(), """.""", dataRow("TABLE_NAME").ToString(), """" }))
						Next
						GoTo IL_16F
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				dataTable = Me.O__.oOO..GetSchema("Tables")
				Dim array As DataRow() = dataTable.[Select](filterExpression)
				For i As Integer = 0 To array.Length - 1
					Dim text As String = Conversions.ToString(array(i)("TABLE_NAME"))
					If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) AndAlso Not text.StartsWith("~") Then
						Me.oO0O.OO_.().Items.Add(text)
					End If
				Next
				IL_16F:
				If Me.oO0O.OO_.().Items.Count > 0 Then
					Me.oO0O.OO_.().SelectedIndex = 0
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				Return False
			Finally
				If Me.O__.oOO..State = ConnectionState.Open Then
					Me.O__.oOO..Close()
				End If
			End Try
			Return True
		End Function

		' Token: 0x060030A9 RID: 12457 RVA: 0x0013AD60 File Offset: 0x00138F60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO0O.OO_.().SelectedIndex = 0 Then
				Me.O0OO.o.().DataSource = Nothing
				Return
			End If
			Dim value As Integer
			If Not Integer.TryParse(Me.oO0O.OO_.().Text, value) Then
				value = 10
			End If
			Dim oleDbDataAdapter As OleDbDataAdapter
			If Not Me.O0OO.o.().Checked Then
				Dim selectCommandText As String
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O__.oOO.) Then
					selectCommandText = "Select * From " + Me.oO0O.OO_.().SelectedItem.ToString() + " Where ROWNUM <= " + Conversions.ToString(value)
				Else
					selectCommandText = String.Concat(New String() { "Select Top ", Conversions.ToString(value), " * From [", Me.oO0O.OO_.().SelectedItem.ToString(), "]" })
				End If
				oleDbDataAdapter = New OleDbDataAdapter(selectCommandText, Me.O__.oOO.)
			Else
				Dim selectCommandText2 As String
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O__.oOO.) Then
					selectCommandText2 = "Select * From " + Me.oO0O.OO_.().SelectedItem.ToString()
				Else
					selectCommandText2 = "Select * From [" + Me.oO0O.OO_.().SelectedItem.ToString() + "]"
				End If
				oleDbDataAdapter = New OleDbDataAdapter(selectCommandText2, Me.O__.oOO.)
			End If
			Dim dataTable As DataTable = New DataTable()
			oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
			oleDbDataAdapter.Fill(dataTable)
			Me.O0OO.o.().DataSource = dataTable
			Me.O0OO.o.().AutoSizeCols(15)
		End Sub

		' Token: 0x060030AA RID: 12458 RVA: 0x0013AEBC File Offset: 0x001390BC
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim connection As Connection = New ConnectionClass()
			Dim dataLinks As DataLinks = New DataLinksClass()
			connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
			Try
				Dim dataSourceLocator As IDataSourceLocator = dataLinks
				Dim obj As Object = connection
				If dataSourceLocator.PromptEdit(obj) AndAlso Operators.CompareString(connection.ConnectionString, "Provider=Microsoft.Jet.OLEDB.4.0;", True) <> 0 Then
					Me.O.OOo_.(connection.ConnectionString)
					Return True
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			Return False
		End Function

		' Token: 0x060030AB RID: 12459 RVA: 0x0013AF40 File Offset: 0x00139140
		Public Sub New(A_0 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.O0OO.o.
			Me.O__.oOO. = New OleDbConnection()
			Me.oO0O.OO_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O.OOo_.(A_0)
		End Sub

		' Token: 0x060030AC RID: 12460 RVA: 0x0013AF94 File Offset: 0x00139194
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO0O.OO_.().SelectedIndex >= 1 Then
				If Me.O0OO.o.().Cols.Fixed = Me.O0OO.o.().Cols.Count Then
					MessageBox.Show("没有数据可导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(Me.oO0O.OO_.().SelectedItem.ToString(), "")
				o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(True)
				Dim str As String = "_Identify"
				Dim list As List(Of String) = New List(Of String)()
				If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
					Dim text As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
					Dim text2 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
					Dim o_oo As o_oo0 = New o_oo0(O_O0OO.OoO.0OO__0ooo.(), False, True)
					Try
						Me.Cursor = Cursors.WaitCursor
						Foxtable.RibbonMenu.StatusBar.Message1 = "正在导入..."
						Application.DoEvents()
						o_oo.o0_oo0._.().Open("", "", "", -1)
						o_oo.o0_oo0._.().ActiveConnection = o_oo.o0_oo0._.()
						Dim table As Table = New TableClass()
						Dim index As Index = New IndexClass()
						table.Name = "~TMPCLP" + text
						table.Columns.Append("_Identify", 3, 0)
						table.Columns.Append("_Locked", 11, 0)
						index.Name = "PrimaryKey"
						index.Columns.Append("_Identify", 202, 0)
						index.PrimaryKey = True
						index.Unique = True
						table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
						Dim fixed As Integer = Me.O0OO.o.().Cols.Fixed
						Dim num As Integer = Me.O0OO.o.().Cols.Count - 1
						For i As Integer = fixed To num
							Dim dataColumn As DataColumn = CType(Me.O0OO.o.().DataSource, DataTable).Columns(Me.O0OO.o.().Cols(i).Name)
							If Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) Then
								Dim left As String = dataColumn.DataType.Name.ToLower()
								If Operators.CompareString(left, "string", True) = 0 Then
									If dataColumn.MaxLength = -1 Or dataColumn.MaxLength > 255 Then
										table.Columns.Append(dataColumn.ColumnName, 203, 0)
									Else
										table.Columns.Append(dataColumn.ColumnName, 202, dataColumn.MaxLength)
									End If
								ElseIf Operators.CompareString(left, "datetime", True) = 0 Then
									table.Columns.Append(dataColumn.ColumnName, 7, 0)
								ElseIf Operators.CompareString(left, "boolean", True) = 0 Then
									table.Columns.Append(dataColumn.ColumnName, 11, 0)
								ElseIf Operators.CompareString(left, "byte", True) = 0 Then
									table.Columns.Append(dataColumn.ColumnName, 17, 0)
								ElseIf Operators.CompareString(left, "int16", True) = 0 Then
									table.Columns.Append(dataColumn.ColumnName, 2, 0)
								ElseIf Operators.CompareString(left, "int32", True) = 0 Then
									table.Columns.Append(dataColumn.ColumnName, 3, 0)
								ElseIf Operators.CompareString(left, "int64", True) = 0 Then
									If Me.O0OO.o.().IndexOf("Microsoft.Jet.OLEDB.4.0", StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse Me.O0OO.o.().IndexOf("Microsoft.ACE.OLEDB.12.0", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
										table.Columns.Append(dataColumn.ColumnName, 5, 0)
									Else
										table.Columns.Append(dataColumn.ColumnName, 20, 0)
									End If
								ElseIf Operators.CompareString(left, "single", True) = 0 Then
									table.Columns.Append(dataColumn.ColumnName, 4, 0)
								ElseIf Operators.CompareString(left, "double", True) = 0 Then
									table.Columns.Append(dataColumn.ColumnName, 5, 0)
								Else
									If Operators.CompareString(left, "decimal", True) <> 0 Then
										GoTo IL_4B0
									End If
									table.Columns.Append(dataColumn.ColumnName, 131, 0)
									table.Columns(dataColumn.ColumnName).Precision = 28
									table.Columns(dataColumn.ColumnName).NumericScale = Me.oO0O.OO_.(dataColumn.ColumnName)
								End If
								If dataColumn.DataType IsNot GetType(Boolean) Then
									table.Columns(dataColumn.ColumnName).Attributes = 2
								End If
								str = str + "," + dataColumn.ColumnName
								list.Add(dataColumn.ColumnName)
							End If
							IL_4B0:
						Next
						Dim connection As _Connection = o_oo.o0_oo0._.()
						Dim text3 As String = String.Concat(New String() { "Delete * From [", ooO0__OO.O00.O__o.(), "] Where [Table]  = '", table.Name, "'" })
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection.Execute(text3, objectValue, -1)
						Dim connection2 As _Connection = o_oo.o0_oo0._.()
						Dim text4 As String = String.Concat(New String() { "Insert into [", ooO0__OO.O00.O__o.(), "] ([Table],[Identify]) values ('", table.Name, "', 1)" })
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection2.Execute(text4, objectValue, -1)
						o_oo.o0_oo0._.().Tables.Append(table)
						o_oo.o0_oo0._.().Close()
						O_O0OO.OoO.0OO__0ooo.().Open()
						o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text, True, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), False)
						O_O0OO.OoO.0OO__0ooo.().Close()
						OO_00oOO.DataTables(text).o.0O000_.()
						Try
							For Each obj As Object In CType(Me.O0OO.o.().DataSource, DataTable).Rows
								Dim dataRow As DataRow = CType(obj, DataRow)
								Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(text)
								Dim dataRow2 As DataRow = dataTable.NewRow()
								Dim num2 As Integer
								num2 += 1
								Try
									For Each columnName As String In list
										dataRow2(columnName) = RuntimeHelpers.GetObjectValue(dataRow(columnName))
									Next
								Finally
									Dim enumerator2 As List(Of String).Enumerator
									CType(enumerator2, IDisposable).Dispose()
								End Try
								dataTable.Rows.Add(dataRow2)
								dataTable = Nothing
								If num2 Mod 100 = 0 Then
									Foxtable.RibbonMenu.StatusBar.Message1 = "正在导入，已经完成" + Conversions.ToString(num2) + "条记录..."
									Application.DoEvents()
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						Foxtable.RibbonMenu.StatusBar.Message1 = "导入完成，正在保存数据..."
						Application.DoEvents()
						OO_00oOO.DataTables(text).oO.o_0.(False, True)
						OO_00oOO.DataTables(text).Caption = text2
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text))
						Main.OO_O.o..o0_o_o_0.0O.(text, True, False)
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
						If Operators.CompareString(text2, "", True) > 0 Then
							OO_00oOO.DataTables(text).OO00_o.ooOO.(False)
						End If
						O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
						o_oo.ooo.0.()
						If MessageBox.Show("已经成功导入，是否继续导入其它表？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
							MyBase.DialogResult = DialogResult.OK
						End If
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If o_oo.o0_oo0._.().State = 1 Then
							o_oo.o0_oo0._.().Close()
						End If
						If O_O0OO.OoO.0OO__0ooo.().State = ConnectionState.Open Then
							O_O0OO.OoO.0OO__0ooo.().Close()
						End If
						Foxtable.RibbonMenu.StatusBar.Message1 = ""
						Me.Cursor = Cursors.[Default]
					End Try
				End If
			End If
		End Sub

		' Token: 0x060030AD RID: 12461 RVA: 0x0013B7F4 File Offset: 0x001399F4
		Private Function <<EMPTY_NAME>>(A_0 As String) As Byte
			Dim catalog As Catalog = New CatalogClass()
			Dim connection As Connection = New ConnectionClass()
			Try
				connection.ConnectionString = Me.O__.oOO..ConnectionString
				connection.Open("", "", "", -1)
				catalog.ActiveConnection = connection
				Dim text As String = Me.oO0O.OO_.().SelectedItem.ToString()
				Dim provider As String = connection.Provider
				If provider.StartsWith("OraOLEDB", StringComparison.CurrentCultureIgnoreCase) OrElse provider.StartsWith("MSDAORA", StringComparison.CurrentCultureIgnoreCase) Then
					text = text.Replace("""", "")
					text = text.Substring(text.IndexOf(".") + 1)
				End If
				Return catalog.Tables(text).Columns(A_0).NumericScale
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				If connection.State = 1 Then
					connection.Close()
				End If
			End Try
			Return 4
		End Function

		' Token: 0x060030AE RID: 12462 RVA: 0x0013B904 File Offset: 0x00139B04
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0OO.o.().Col >= Me.O0OO.o.().Cols.Fixed Then
				Dim leftCol As Integer = Me.O0OO.o.().Selection.LeftCol
				Dim rightCol As Integer = Me.O0OO.o.().Selection.RightCol
				Dim num As Integer = leftCol
				Dim num2 As Integer = rightCol
				For i As Integer = num To num2
					Me.O0OO.o.().Cols.Remove(leftCol)
				Next
			End If
		End Sub

		' Token: 0x060030AF RID: 12463 RVA: 0x0013B97A File Offset: 0x00139B7A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_0.o_oo0_OO.(Nothing, Nothing)
		End Sub

		' Token: 0x060030B0 RID: 12464 RVA: 0x0013B984 File Offset: 0x00139B84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO0O.OO_.().Modified Then
				Me.o_0.o_oo0_OO.(Nothing, Nothing)
				Me.oO0O.OO_.().Modified = False
			End If
		End Sub

		' Token: 0x060030B1 RID: 12465 RVA: 0x0013B9A7 File Offset: 0x00139BA7
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400137F RID: 4991
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001380 RID: 4992
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001381 RID: 4993
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001382 RID: 4994
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001383 RID: 4995
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001384 RID: 4996
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Label

		' Token: 0x04001385 RID: 4997
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001386 RID: 4998
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001387 RID: 4999
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001388 RID: 5000
		Private <<EMPTY_NAME>> As OleDbConnection
	End Class
End Namespace
