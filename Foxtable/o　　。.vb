Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000376 RID: 886
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3000\u3002\u3000\u3000
		Inherits Form

		' Token: 0x06003835 RID: 14389 RVA: 0x00180760 File Offset: 0x0017E960
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.O_0__.O_ooo00O. IsNot Nothing Then
				Me.O_0__.O_ooo00O..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003836 RID: 14390 RVA: 0x00180780 File Offset: 0x0017E980
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oO.o_.(New ListBox())
			Me.O.__O0.(New C1Button())
			Me.O.Oo_oo.(New C1Button())
			Me.o.oO_0o_o.(New C1Button())
			Me.oO.o_.(New C1Button())
			Me.o00_o_OoO_o.O.(New C1Button())
			MyBase.SuspendLayout()
			Me.o00o.0oOoO_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.o00o.0oOoO_.().FormattingEnabled = True
			Me.o00o.0oOoO_.().ItemHeight = 12
			Me.o00o.0oOoO_.().Location = New Point(12, 16)
			Me.o00o.0oOoO_.().Name = "lstRelations"
			Me.o00o.0oOoO_.().Size = New Size(308, 364)
			Me.o00o.0oOoO_.().TabIndex = 0
			Me.O__.OOo0oo0o__.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O__.OOo0oo0o__.().Location = New Point(330, 16)
			Me.O__.OOo0oo0o__.().Name = "btnAdd"
			Me.O__.OOo0oo0o__.().Size = New Size(75, 23)
			Me.O__.OOo0oo0o__.().TabIndex = 1
			Me.O__.OOo0oo0o__.().Text = "增加"
			Me.O__.OOo0oo0o__.().UseVisualStyleBackColor = True
			Me.O0O00.__o_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O0O00.__o_.().Location = New Point(330, 46)
			Me.O0O00.__o_.().Name = "btnEdit"
			Me.O0O00.__o_.().Size = New Size(75, 23)
			Me.O0O00.__o_.().TabIndex = 2
			Me.O0O00.__o_.().Text = "编辑"
			Me.O0O00.__o_.().UseVisualStyleBackColor = True
			Me.o00o.0oOoO_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.o00o.0oOoO_.().Location = New Point(330, 75)
			Me.o00o.0oOoO_.().Name = "btnDelete"
			Me.o00o.0oOoO_.().Size = New Size(75, 23)
			Me.o00o.0oOoO_.().TabIndex = 3
			Me.o00o.0oOoO_.().Text = "删除"
			Me.o00o.0oOoO_.().UseVisualStyleBackColor = True
			Me.O.__O0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O.__O0.().Location = New Point(330, 105)
			Me.O.__O0.().Name = "btnRename"
			Me.O.__O0.().Size = New Size(75, 23)
			Me.O.__O0.().TabIndex = 5
			Me.O.__O0.().Text = "重命名"
			Me.O.__O0.().UseVisualStyleBackColor = True
			Me.oO0oOOO.0__0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oO0oOOO.0__0.().Location = New Point(330, 357)
			Me.oO0oOOO.0__0.().Name = "btnClose"
			Me.oO0oOOO.0__0.().Size = New Size(75, 23)
			Me.oO0oOOO.0__0.().TabIndex = 7
			Me.oO0oOOO.0__0.().Text = "关闭"
			Me.oO0oOOO.0__0.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(417, 397)
			MyBase.Controls.Add(Me.oO0oOOO.0__0.())
			MyBase.Controls.Add(Me.O.__O0.())
			MyBase.Controls.Add(Me.o00o.0oOoO_.())
			MyBase.Controls.Add(Me.O0O00.__o_.())
			MyBase.Controls.Add(Me.O__.OOo0oo0o__.())
			MyBase.Controls.Add(Me.o00o.0oOoO_.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o...Oo.o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "表间关联"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003837 RID: 14391 RVA: 0x00180B4F File Offset: 0x0017ED4F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.O_0__.O_ooo00O.
		End Function

		' Token: 0x06003838 RID: 14392 RVA: 0x00180B57 File Offset: 0x0017ED57
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.O_0__.O_ooo00O. = A_0
		End Sub

		' Token: 0x06003839 RID: 14393 RVA: 0x00180B60 File Offset: 0x0017ED60
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO.o_.
		End Function

		' Token: 0x0600383A RID: 14394 RVA: 0x00180B68 File Offset: 0x0017ED68
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_o.O__o.
			Dim c1Button As C1Button = Me.oO.o_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO.o_. = A_0
			c1Button = Me.oO.o_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600383B RID: 14395 RVA: 0x00180BAB File Offset: 0x0017EDAB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o00_o_OoO_o.O.
		End Function

		' Token: 0x0600383C RID: 14396 RVA: 0x00180BB4 File Offset: 0x0017EDB4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.__0o.
			Dim c1Button As C1Button = Me.o00_o_OoO_o.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o00_o_OoO_o.O. = A_0
			c1Button = Me.o00_o_OoO_o.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600383D RID: 14397 RVA: 0x00180BF7 File Offset: 0x0017EDF7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.Oo_oo.
		End Function

		' Token: 0x0600383E RID: 14398 RVA: 0x00180C00 File Offset: 0x0017EE00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo0.oO_OOoo.
			Dim o.Oo_oo. As C1Button = Me.O.Oo_oo.
			If o.Oo_oo. IsNot Nothing Then
				RemoveHandler o.Oo_oo..Click, value
			End If
			Me.O.Oo_oo. = A_0
			o.Oo_oo. = Me.O.Oo_oo.
			If o.Oo_oo. IsNot Nothing Then
				AddHandler o.Oo_oo..Click, value
			End If
		End Sub

		' Token: 0x0600383F RID: 14399 RVA: 0x00180C43 File Offset: 0x0017EE43
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.oO_0o_o.
		End Function

		' Token: 0x06003840 RID: 14400 RVA: 0x00180C4C File Offset: 0x0017EE4C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.o0O_O0o0_O.
			Dim c1Button As C1Button = Me.o.oO_0o_o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.oO_0o_o. = A_0
			c1Button = Me.o.oO_0o_o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003841 RID: 14401 RVA: 0x00180C8F File Offset: 0x0017EE8F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0.0_00_.
		End Function

		' Token: 0x06003842 RID: 14402 RVA: 0x00180C98 File Offset: 0x0017EE98
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO0oo0.O_OoOo_.
			Dim o0.0_00_. As C1Button = Me.O0.0_00_.
			If o0.0_00_. IsNot Nothing Then
				RemoveHandler o0.0_00_..Click, value
			End If
			Me.O0.0_00_. = A_0
			o0.0_00_. = Me.O0.0_00_.
			If o0.0_00_. IsNot Nothing Then
				AddHandler o0.0_00_..Click, value
			End If
		End Sub

		' Token: 0x06003843 RID: 14403 RVA: 0x00180CDC File Offset: 0x0017EEDC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O._0o__oo0Oo_o.
			AddHandler MyBase.FormClosed, AddressOf Me.o00o.0oOoO_.
			Me.o00o.0oOoO_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003844 RID: 14404 RVA: 0x00180D30 File Offset: 0x0017EF30
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataSource As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.())
			Me.o00o.0oOoO_.().DisplayMember = "Name"
			Me.o00o.0oOoO_.().DataSource = dataSource
			OO_00oOO.CurrentTable = OO_00oOO.MainTable
		End Sub

		' Token: 0x06003845 RID: 14405 RVA: 0x00180D78 File Offset: 0x0017EF78
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).NewRow()
			Dim form As Form = New O\u3000\u3000(dataRow)
			OO_00oOO.Forms.ooO0_o._o.()
			If form.ShowDialog() = DialogResult.OK Then
				Me.o00o.0oOoO_.().SelectedIndex = Me.o00o.0oOoO_.().Items.Count - 1
				o0OoOOoOOo0.OO0._Oo0o.(dataRow, O_O0OO.OOOo.oo_OOOO_0.())
				Oo00.o00O0O_.O.(Conversions.ToString(dataRow("Name")), True, True)
			End If
		End Sub

		' Token: 0x06003846 RID: 14406 RVA: 0x00180DF8 File Offset: 0x0017EFF8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			OO_00oOO.Forms.ooO0_o._o.()
			If Me.o00o.0oOoO_.().SelectedItem IsNot Nothing Then
				Dim row As DataRow = CType(Me.o00o.0oOoO_.().SelectedItem, DataRowView).Row
				Dim text As String = Conversions.ToString(row("Name"))
				If New O\u3000\u3000(row).ShowDialog() = DialogResult.OK Then
					If O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(text) Then
						Oo00.OO.0O0o.(text)
					End If
					o0OoOOoOOo0.OO0._Oo0o.(row, O_O0OO.OOOo.oo_OOOO_0.())
					Oo00.o00O0O_.O.(text, True, True)
				End If
			End If
		End Sub

		' Token: 0x06003847 RID: 14407 RVA: 0x00180E7C File Offset: 0x0017F07C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.o00o.0oOoO_.().SelectedItem Is Nothing Then
					GoTo IL_29E
				End If
				IL_19:
				num2 = 4
				OO_00oOO.Forms.ooO0_o._o.()
				IL_25:
				num2 = 5
				Dim dataRowView As DataRowView = CType(Me.o00o.0oOoO_.().SelectedItem, DataRowView)
				IL_38:
				num2 = 6
				Dim text As String = Conversions.ToString(dataRowView("Name"))
				IL_4C:
				num2 = 7
				If Not O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(text) Then
					GoTo IL_273
				End If
				IL_64:
				num2 = 8
				Dim flag As Boolean = False
				IL_69:
				num2 = 9
				Dim value As String = "Child(" + text + ")."
				IL_7F:
				num2 = 10
				Dim value2 As String = "Child([" + text + "])."
				IL_95:
				num2 = 11
				Dim value3 As String = "Parent(" + text + ")."
				IL_AB:
				num2 = 12
				Dim value4 As String = "Parent([" + text + "])."
				IL_C1:
				num2 = 13
				Dim enumerator As IEnumerator = O_O0OO.OOOo.oo_OOOO_0.().Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataTable As DataTable = CType(obj, DataTable)
					IL_E8:
					num2 = 14
					Dim enumerator2 As IEnumerator = dataTable.Columns.GetEnumerator()
					While enumerator2.MoveNext()
						Dim obj2 As Object = enumerator2.Current
						Dim dataColumn As DataColumn = CType(obj2, DataColumn)
						IL_10C:
						num2 = 15
						If Operators.CompareString(dataColumn.Expression, "", True) > 0 Then
							IL_127:
							num2 = 16
							Dim expression As String = dataColumn.Expression
							IL_133:
							num2 = 17
							If expression.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse expression.IndexOf(value2, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse expression.IndexOf(value3, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse expression.IndexOf(value4, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
								IL_16D:
								num2 = 18
								If Not flag AndAlso MessageBox.Show("一些计算表达式引用了关联" + text + "，如果删除该关联，有关计算表达式将自动删除，确认要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
									GoTo IL_29E
								End If
								IL_198:
								num2 = 21
								flag = True
								IL_19E:
								num2 = 22
								dataColumn.Expression = String.Empty
								IL_1AD:
								num2 = 23
								Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { dataTable.TableName, dataColumn.ColumnName })
								IL_1EA:
								num2 = 24
								dataRow("Expression") = ""
							End If
						End If
						IL_1FE:
						num2 = 25
					End While
					IL_20D:
					num2 = 26
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
					IL_225:
					num2 = 27
				End While
				IL_234:
				num2 = 28
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_24C:
				num2 = 29
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
				IL_269:
				num2 = 30
				Oo00.OO.0O0o.(text)
				IL_273:
				num2 = 31
				dataRowView.Row.Delete()
				IL_281:
				num2 = 32
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()), True)
				IL_29E:
				GoTo IL_374
				IL_2A3:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_335:
				GoTo IL_369
				IL_337:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_347:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_337
			End Try
			IL_369:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_374:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003848 RID: 14408 RVA: 0x00181224 File Offset: 0x0017F424
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o00o.0oOoO_.().SelectedItem IsNot Nothing Then
				Dim row As DataRow = CType(Me.o00o.0oOoO_.().SelectedItem, DataRowView).Row
				Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("重命名", "请输入关联名称:", Conversions.ToString(row("Name")))
				o_u3000_u.Oo.__0o_0_Oo.(AddressOf Oo00.O0o._.)
				If o_u3000_u.ShowDialog() = DialogResult.OK Then
					Dim text As String = Conversions.ToString(row("Name"))
					If Oo00.o0.__oO0_.(o_u3000_u.Value, O_O0OO.OOOo.oo_OOOO_0.().Relations(text).ParentTable, O_O0OO.OOOo.oo_OOOO_0.().Relations(text).ChildTable) Then
						row("Name") = o_u3000_u.Value
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()), True)
						Try
							For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
								Dim dataRelation As DataRelation = CType(obj, DataRelation)
								If Operators.CompareString(dataRelation.RelationName, text, True) = 0 Then
									dataRelation.RelationName = o_u3000_u.Value
									Dim text2 As String = "Child(" + text + ")."
									Dim text3 As String = "Child([" + text + "])."
									Dim text4 As String = "Child(" + dataRelation.RelationName + ")."
									Dim text5 As String = "Child([" + dataRelation.RelationName + "])."
									Try
										For Each obj2 As Object In dataRelation.ParentTable.Columns
											Dim dataColumn As DataColumn = CType(obj2, DataColumn)
											If Operators.CompareString(dataColumn.Expression, "", True) > 0 Then
												Dim text6 As String = dataColumn.Expression
												If text6.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase) > 0 OrElse text6.IndexOf(text3, StringComparison.CurrentCultureIgnoreCase) > 0 Then
													text6 = ShareLibriay.ReplaceIgnoreCase(text6, text2, text4)
													text6 = ShareLibriay.ReplaceIgnoreCase(text6, text3, text5)
													Try
														dataColumn.Expression = text6
														Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { dataRelation.ParentTable.TableName, dataColumn.ColumnName })
														If dataRow IsNot Nothing Then
															dataRow("Expression") = text6
														End If
													Catch ex As Exception
													End Try
												End If
											End If
										Next
									Finally
										Dim enumerator2 As IEnumerator
										If TypeOf enumerator2 Is IDisposable Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									End Try
									text2 = "Parent(" + text + ")."
									text3 = "Parent([" + text + "])."
									text4 = "Parent(" + dataRelation.RelationName + ")."
									text5 = "Parent([" + dataRelation.RelationName + "])."
									Try
										For Each obj3 As Object In dataRelation.ChildTable.Columns
											Dim dataColumn2 As DataColumn = CType(obj3, DataColumn)
											If Operators.CompareString(dataColumn2.Expression, "", True) > 0 Then
												Dim text7 As String = dataColumn2.Expression
												If text7.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse text7.IndexOf(text3, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
													text7 = ShareLibriay.ReplaceIgnoreCase(text7, text2, text4)
													text7 = ShareLibriay.ReplaceIgnoreCase(text7, text3, text5)
													Try
														dataColumn2.Expression = text7
														Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { dataRelation.ChildTable.TableName, dataColumn2.ColumnName })
														If dataRow2 IsNot Nothing Then
															dataRow2("Expression") = text7
														End If
													Catch ex2 As Exception
													End Try
												End If
											End If
										Next
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End Try
									Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
									Try
										For Each table As Table In OO_00oOO.Tables
											table.O.__O0o0.(True, False)
										Next
										Exit Try
									Finally
										Dim enumerator4 As IEnumerator(Of Table)
										If enumerator4 IsNot Nothing Then
											enumerator4.Dispose()
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
					End If
				End If
			End If
		End Sub

		' Token: 0x06003849 RID: 14409 RVA: 0x00181714 File Offset: 0x0017F914
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Tables
					Dim dataTable As DataTable = CType(obj, DataTable)
					Try
						For Each obj2 As Object In dataTable.Columns
							Dim dataColumn As DataColumn = CType(obj2, DataColumn)
							If Operators.CompareString(dataColumn.Expression, "", True) > 0 AndAlso (dataColumn.Expression.IndexOf("parent", StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse dataColumn.Expression.IndexOf("child", StringComparison.CurrentCultureIgnoreCase) >= 0) Then
								Dim expression As String = dataColumn.Expression
								dataColumn.Expression = ""
								dataColumn.Expression = expression
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x0600384A RID: 14410 RVA: 0x00181818 File Offset: 0x0017FA18
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001730 RID: 5936
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001731 RID: 5937
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001732 RID: 5938
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001733 RID: 5939
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001734 RID: 5940
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001735 RID: 5941
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001736 RID: 5942
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
