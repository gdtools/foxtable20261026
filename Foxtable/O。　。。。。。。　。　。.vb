Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices
Imports MSDASC

Namespace Foxtable
	' Token: 0x0200037B RID: 891
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002
		Inherits Form

		' Token: 0x060038D1 RID: 14545 RVA: 0x00187962 File Offset: 0x00185B62
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.OO.o_000o. IsNot Nothing Then
				Me.OO.o_000o..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x060038D2 RID: 14546 RVA: 0x00187984 File Offset: 0x00185B84
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.o.oo_oo_.(New C1TextBox())
			Me.o.OO0o_o_oOoo.(New C1Button())
			Me.o.oo_oo_.(New C1Button())
			Me.O._00__o00o.(New C1Button())
			Me.oO0OOO000.o00O.(New C1Button())
			Me.o.oo_oo_.(New Label())
			MyBase.SuspendLayout()
			Me.OO.0O_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.OO.0O_.().Location = New Point(12, 38)
			Me.OO.0O_.().Multiline = True
			Me.OO.0O_.().Name = "TextBox1"
			Me.OO.0O_.().ScrollBars = ScrollBars.Vertical
			Me.OO.0O_.().Size = New Size(630, 295)
			Me.OO.0O_.().TabIndex = 0
			Me.oO00o0._O_Oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oO00o0._O_Oo.().Location = New Point(12, 351)
			Me.oO00o0._O_Oo.().Name = "btnCreator"
			Me.oO00o0._O_Oo.().Size = New Size(75, 23)
			Me.oO00o0._O_Oo.().TabIndex = 1
			Me.oO00o0._O_Oo.().Text = "生成器"
			Me.oO00o0._O_Oo.().UseVisualStyleBackColor = True
			Me.OO.0O_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.OO.0O_.().Location = New Point(486, 351)
			Me.OO.0O_.().Name = "btnOK"
			Me.OO.0O_.().Size = New Size(75, 23)
			Me.OO.0O_.().TabIndex = 3
			Me.OO.0O_.().Text = "确定"
			Me.OO.0O_.().UseVisualStyleBackColor = True
			Me.OO00o.OoooOo0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.OO00o.OoooOo0o.().DialogResult = DialogResult.Cancel
			Me.OO00o.OoooOo0o.().Location = New Point(567, 351)
			Me.OO00o.OoooOo0o.().Name = "btnCancel"
			Me.OO00o.OoooOo0o.().Size = New Size(75, 23)
			Me.OO00o.OoooOo0o.().TabIndex = 4
			Me.OO00o.OoooOo0o.().Text = "取消"
			Me.OO00o.OoooOo0o.().UseVisualStyleBackColor = True
			Me.Oo_.0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Oo_.0.().Location = New Point(94, 351)
			Me.Oo_.0.().Name = "Button1"
			Me.Oo_.0.().Size = New Size(75, 23)
			Me.Oo_.0.().TabIndex = 2
			Me.Oo_.0.().Text = "预览"
			Me.Oo_.0.().UseVisualStyleBackColor = True
			Me.OO.0O_.().AutoSize = True
			Me.OO.0O_.().Location = New Point(10, 16)
			Me.OO.0O_.().Name = "Label1"
			Me.OO.0O_.().Size = New Size(107, 12)
			Me.OO.0O_.().TabIndex = 5
			Me.OO.0O_.().Text = "请输入连接字符串:"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(655, 387)
			MyBase.Controls.Add(Me.OO.0O_.())
			MyBase.Controls.Add(Me.Oo_.0.())
			MyBase.Controls.Add(Me.OO00o.OoooOo0o.())
			MyBase.Controls.Add(Me.OO.0O_.())
			MyBase.Controls.Add(Me.oO00o0._O_Oo.())
			MyBase.Controls.Add(Me.OO.0O_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o....0.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.Manual
			Me.Text = "外部数据源"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060038D3 RID: 14547 RVA: 0x00187D5C File Offset: 0x00185F5C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OO.o_000o.
		End Function

		' Token: 0x060038D4 RID: 14548 RVA: 0x00187D64 File Offset: 0x00185F64
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OO.o_000o. = A_0
		End Sub

		' Token: 0x060038D5 RID: 14549 RVA: 0x00187D6D File Offset: 0x00185F6D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.oo_oo_.
		End Function

		' Token: 0x060038D6 RID: 14550 RVA: 0x00187D78 File Offset: 0x00185F78
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0_._0O_0.
			Dim c1Button As C1Button = Me.o.oo_oo_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.oo_oo_. = A_0
			c1Button = Me.o.oo_oo_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060038D7 RID: 14551 RVA: 0x00187DBB File Offset: 0x00185FBB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.OO0o_o_oOoo.
		End Function

		' Token: 0x060038D8 RID: 14552 RVA: 0x00187DC4 File Offset: 0x00185FC4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo_0oooo.00O_O.
			Dim c1Button As C1Button = Me.o.OO0o_o_oOoo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.OO0o_o_oOoo. = A_0
			c1Button = Me.o.OO0o_o_oOoo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060038D9 RID: 14553 RVA: 0x00187E07 File Offset: 0x00186007
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._00__o00o.
		End Function

		' Token: 0x060038DA RID: 14554 RVA: 0x00187E0F File Offset: 0x0018600F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O._00__o00o. = A_0
		End Sub

		' Token: 0x060038DB RID: 14555 RVA: 0x00187E18 File Offset: 0x00186018
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooO.O0_o_0.
		End Function

		' Token: 0x060038DC RID: 14556 RVA: 0x00187E20 File Offset: 0x00186020
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO00o0._O_Oo.
			Dim c1Button As C1Button = Me.ooO.O0_o_0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooO.O0_o_0. = A_0
			c1Button = Me.ooO.O0_o_0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060038DD RID: 14557 RVA: 0x00187E63 File Offset: 0x00186063
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.OO.o_000o.
		End Function

		' Token: 0x060038DE RID: 14558 RVA: 0x00187E6B File Offset: 0x0018606B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO.o_000o. = A_0
		End Sub

		' Token: 0x060038DF RID: 14559 RVA: 0x00187E74 File Offset: 0x00186074
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim connection As Connection = New ConnectionClass()
			Dim dataLinks As DataLinks = New DataLinksClass()
			If Operators.CompareString(Me.OO.0O_.().Text, "", True) > 0 Then
				If Me.OO.0O_.().Text.Trim().StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse Me.OO.0O_.().Text.Trim().StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
					MessageBox.Show("Web数据源无法使用生成器生成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				connection.ConnectionString = Me.OO.0O_.().Text
			Else
				connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
			End If
			Try
				Dim dataSourceLocator As IDataSourceLocator = dataLinks
				Dim obj As Object = connection
				If dataSourceLocator.PromptEdit(obj) AndAlso Operators.CompareString(connection.ConnectionString, "Provider=Microsoft.Jet.OLEDB.4.0;", True) <> 0 Then
					Me.OO.0O_.().Value = connection.ConnectionString
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x060038E0 RID: 14560 RVA: 0x00187F70 File Offset: 0x00186170
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.OO.0O_.().Text.Trim(), "", True) <> 0 Then
				New o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(Me.OO.0O_.().Text).o.00_0_0.()
			End If
		End Sub

		' Token: 0x060038E1 RID: 14561 RVA: 0x00187FA4 File Offset: 0x001861A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim oleDbConnection As OleDbConnection = Nothing
			Dim o0O As O0O = Nothing
			Dim text As String = Me.OO.0O_.().Text.Trim()
			If Operators.CompareString(text, "", True) <> 0 Then
				Try
					If text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse text.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
						o0O = New O0O(text)
						If Not o0O.OO._o_OO.() Then
							Return
						End If
					Else
						oleDbConnection = New OleDbConnection(Me.OO.0O_.().Text)
						oleDbConnection.Open()
						oleDbConnection.Close()
					End If
				Catch ex As Exception
					MessageBox.Show("无法连接数据源,错误:" & vbCrLf + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End Try
				If Me.OO.o_000o. Is Nothing Then
					Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("新建数据源", "请输入数据源名称:", "")
					o_u3000_u.Oo.__0o_0_Oo.(AddressOf Me.o.oo_oo_.)
					If o_u3000_u.ShowDialog() <> DialogResult.OK Then
						Return
					End If
					Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).NewRow()
					dataRow("Name") = o_u3000_u.Value
					dataRow("ConnectionString") = O00.ooo000o_0.00o0.(text, O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.())
					O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).Rows.Add(dataRow)
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()), True)
					o0OoOOoOOo0.OOOOO.o000.(O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), dataRow, O_O0OO.oo0_o_.o., OO_00oOO.ProjectFile, OO_00oOO.User, O_O0OO.O0_00o.o0__o.)
				Else
					If String.Compare(O00.oO_.0o_oo_0O_.(Conversions.ToString(Me.OO.o_000o.("ConnectionString")), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.()), text) = 0 Then
						MyBase.DialogResult = DialogResult.OK
						Return
					End If
					If Operators.CompareString(Me.OO.o_000o., "", True) > 0 Then
						Try
							For Each dataTable As DataTable In OO_00oOO.DataTables
								If Operators.CompareString(dataTable.ConnectionName, Me.OO.o_000o., True) = 0 Then
									Me.OO.o_000o. = True
									Dim dataTable2 As DataTable = New DataTable()
									Dim text2 As String
									If Operators.CompareString(dataTable.DataServer, "", True) > 0 Then
										text2 = dataTable.HttpSelect
									Else
										text2 = dataTable.frd_SelectCommandString
									End If
									If oleDbConnection IsNot Nothing Then
										New OleDbDataAdapter(text2, oleDbConnection).FillSchema(dataTable2, SchemaType.Source)
									Else
										dataTable2 = o0O.O_0_O_0_o_.0.(text2, True)
										If dataTable2 Is Nothing Then
											Return
										End If
									End If
									If dataTable2 Is Nothing OrElse dataTable2.Columns.Count = 0 Then
										MessageBox.Show("无法加载表""" + dataTable.Name + """，请检查新的数据源中是否包括该表!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
										Return
									End If
									If Not dataTable.OOoo__00O_.o_O.(dataTable2).o_O__.0O. Then
										Return
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator(Of DataTable)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						Me.OO.o_000o.("ConnectionString") = O00.ooo000o_0.00o0.(text, O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.())
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()), True)
						If Not Me.OO.o_000o. Then
							If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.OO.o_000o.) Then
								O_O0OO.OoO__.0oO0oo.().Remove(Me.OO.o_000o.)
							End If
							If O_O0OO.O._o_.().ContainsKey(Me.OO.o_000o.) Then
								O_O0OO.O._o_.().Remove(Me.OO.o_000o.)
							End If
							If O_O0OO.o_Oo_000_.0o_0.().ContainsKey(Me.OO.o_000o.) Then
								O_O0OO.o_Oo_000_.0o_0.().Remove(Me.OO.o_000o.)
							End If
							o0OoOOoOOo0.OOOOO.o000.(O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), Me.OO.o_000o., O_O0OO.oo0_o_.o., OO_00oOO.ProjectFile, OO_00oOO.User, O_O0OO.O0_00o.o0__o.)
						End If
					End If
				End If
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x060038E2 RID: 14562 RVA: 0x0018839C File Offset: 0x0018659C
		Private Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If Operators.CompareString(A_1.Value, "", True) = 0 Then
				MessageBox.Show("请输入数据源名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
				Return
			End If
			If o_O_o_oOoo__.oo.O0o0o.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).Columns("Name"), A_1.Value) Then
				MessageBox.Show("已经存在同名数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x060038E3 RID: 14563 RVA: 0x00188424 File Offset: 0x00186624
		Public Sub New(A_0 As DataRow)
			AddHandler MyBase.FormClosed, AddressOf Me.OO.0O_.
			Me.OO.0O_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.OO.o_000o. = A_0
			If A_0 IsNot Nothing Then
				Me.OO.o_000o. = Conversions.ToString(A_0("Name"))
			End If
		End Sub

		' Token: 0x060038E4 RID: 14564 RVA: 0x00188484 File Offset: 0x00186684
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400177C RID: 6012
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400177D RID: 6013
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400177E RID: 6014
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400177F RID: 6015
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001780 RID: 6016
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001781 RID: 6017
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001782 RID: 6018
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001783 RID: 6019
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001784 RID: 6020
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001785 RID: 6021
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
