Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200037C RID: 892
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3002
		Inherits Form

		' Token: 0x060038E5 RID: 14565 RVA: 0x00188496 File Offset: 0x00186696
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.o0oo_o_0OOo_.O. IsNot Nothing Then
				Me.o0oo_o_0OOo_.O..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x060038E6 RID: 14566 RVA: 0x001884B8 File Offset: 0x001866B8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o00o.o_o__.(New ListBox())
			Me.o.0oo0__O_.(New C1Button())
			Me.oo.0oOoo_O0O.(New C1Button())
			Me.o00o.o_o__.(New C1Button())
			Me.oOooo.O.(New C1Button())
			Me.O.0_Oo_0.(New C1Button())
			MyBase.SuspendLayout()
			Me.oOO.00O0_00Oo.().FormattingEnabled = True
			Me.oOO.00O0_00Oo.().ItemHeight = 12
			Me.oOO.00O0_00Oo.().Location = New Point(14, 16)
			Me.oOO.00O0_00Oo.().Name = "DataSourceList"
			Me.oOO.00O0_00Oo.().Size = New Size(222, 280)
			Me.oOO.00O0_00Oo.().TabIndex = 0
			Me.oo._O__.().Location = New Point(255, 16)
			Me.oo._O__.().Name = "Add"
			Me.oo._O__.().Size = New Size(75, 23)
			Me.oo._O__.().TabIndex = 1
			Me.oo._O__.().Text = "增加"
			Me.oo._O__.().UseVisualStyleBackColor = True
			Me.oOO.00O0_00Oo.().Location = New Point(255, 74)
			Me.oOO.00O0_00Oo.().Name = "btnDelete"
			Me.oOO.00O0_00Oo.().Size = New Size(75, 23)
			Me.oOO.00O0_00Oo.().TabIndex = 3
			Me.oOO.00O0_00Oo.().Text = "删除"
			Me.oOO.00O0_00Oo.().UseVisualStyleBackColor = True
			Me.O0_0_00o0O._OO.().Location = New Point(255, 273)
			Me.O0_0_00o0O._OO.().Name = "btnClose"
			Me.O0_0_00o0O._OO.().Size = New Size(75, 23)
			Me.O0_0_00o0O._OO.().TabIndex = 5
			Me.O0_0_00o0O._OO.().Text = "关闭"
			Me.O0_0_00o0O._OO.().UseVisualStyleBackColor = True
			Me.o_O0.o00.().Location = New Point(255, 45)
			Me.o_O0.o00.().Name = "btnEdit"
			Me.o_O0.o00.().Size = New Size(75, 23)
			Me.o_O0.o00.().TabIndex = 2
			Me.o_O0.o00.().Text = "设置"
			Me.o_O0.o00.().UseVisualStyleBackColor = True
			Me.oo_0__OOO__0.o.().Location = New Point(255, 103)
			Me.oo_0__OOO__0.o.().Name = "Button1"
			Me.oo_0__OOO__0.o.().Size = New Size(75, 23)
			Me.oo_0__OOO__0.o.().TabIndex = 4
			Me.oo_0__OOO__0.o.().Text = "预览"
			Me.oo_0__OOO__0.o.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(342, 311)
			MyBase.Controls.Add(Me.oo_0__OOO__0.o.())
			MyBase.Controls.Add(Me.o_O0.o00.())
			MyBase.Controls.Add(Me.O0_0_00o0O._OO.())
			MyBase.Controls.Add(Me.oOO.00O0_00Oo.())
			MyBase.Controls.Add(Me.oo._O__.())
			MyBase.Controls.Add(Me.oOO.00O0_00Oo.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Oo.....O"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "外部数据源"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060038E7 RID: 14567 RVA: 0x00188840 File Offset: 0x00186A40
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As ListBox
			Return Me.o0oo_o_0OOo_.O.
		End Function

		' Token: 0x060038E8 RID: 14568 RVA: 0x00188848 File Offset: 0x00186A48
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.o0oo_o_0OOo_.O. = A_0
		End Sub

		' Token: 0x060038E9 RID: 14569 RVA: 0x00188851 File Offset: 0x00186A51
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o00o.o_o__.
		End Function

		' Token: 0x060038EA RID: 14570 RVA: 0x0018885C File Offset: 0x00186A5C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.oo0o.
			Dim c1Button As C1Button = Me.o00o.o_o__.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o00o.o_o__. = A_0
			c1Button = Me.o00o.o_o__.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060038EB RID: 14571 RVA: 0x0018889F File Offset: 0x00186A9F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo.0oOoo_O0O.
		End Function

		' Token: 0x060038EC RID: 14572 RVA: 0x001888A8 File Offset: 0x00186AA8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_0_00o0O._OO.
			Dim c1Button As C1Button = Me.oo.0oOoo_O0O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo.0oOoo_O0O. = A_0
			c1Button = Me.oo.0oOoo_O0O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060038ED RID: 14573 RVA: 0x001888EB File Offset: 0x00186AEB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOooo.O.
		End Function

		' Token: 0x060038EE RID: 14574 RVA: 0x001888F4 File Offset: 0x00186AF4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo_0__OOO__0.o.
			Dim c1Button As C1Button = Me.oOooo.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOooo.O. = A_0
			c1Button = Me.oOooo.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060038EF RID: 14575 RVA: 0x00188937 File Offset: 0x00186B37
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0O_.o.
		End Function

		' Token: 0x060038F0 RID: 14576 RVA: 0x00188940 File Offset: 0x00186B40
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo0_00O.0_.
			Dim c1Button As C1Button = Me.oO0O_.o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO0O_.o. = A_0
			c1Button = Me.oO0O_.o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060038F1 RID: 14577 RVA: 0x00188983 File Offset: 0x00186B83
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_.___o_0.
		End Function

		' Token: 0x060038F2 RID: 14578 RVA: 0x0018898C File Offset: 0x00186B8C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO.o_000o.
			Dim o_.___o_0. As C1Button = Me.O_.___o_0.
			If o_.___o_0. IsNot Nothing Then
				RemoveHandler o_.___o_0..Click, value
			End If
			Me.O_.___o_0. = A_0
			o_.___o_0. = Me.O_.___o_0.
			If o_.___o_0. IsNot Nothing Then
				AddHandler o_.___o_0..Click, value
			End If
		End Sub

		' Token: 0x060038F3 RID: 14579 RVA: 0x001889CF File Offset: 0x00186BCF
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.o.000o000O0.
			Me.o00o.o_o__.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060038F4 RID: 14580 RVA: 0x00188A04 File Offset: 0x00186C04
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oOO.00O0_00Oo.().DataSource = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.())
			Me.oOO.00O0_00Oo.().DisplayMember = "Name"
		End Sub

		' Token: 0x060038F5 RID: 14581 RVA: 0x00188A35 File Offset: 0x00186C35
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060038F6 RID: 14582 RVA: 0x00188A40 File Offset: 0x00186C40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oOO.00O0_00Oo.().SelectedItem IsNot Nothing Then
				Dim row As DataRow = CType(Me.oOO.00O0_00Oo.().SelectedItem, DataRowView).Row
				Dim right As String = Conversions.ToString(row("Name"))
				Dim flag As Boolean
				Try
					Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current.ConnectionName, right, True) = 0 Then
							flag = True
							Exit While
						End If
					End While
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				If row.GetChildRows("OuterDataSource").Length > 0 Then
					flag = True
				End If
				If flag Then
					MessageBox.Show("请在删除该数据源之前，先删除来自该数据源的外部表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If OO_00oOO.Connections.Contains(Conversions.ToString(row("Name"))) Then
					OO_00oOO.Connections.Delete(Conversions.ToString(row("Name")))
				End If
				CType(Me.oOO.00O0_00Oo.().SelectedItem, DataRowView).Delete()
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()), True)
			End If
		End Sub

		' Token: 0x060038F7 RID: 14583 RVA: 0x00188B5C File Offset: 0x00186D5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If New O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002(Nothing) With { .Location = New Point(MyBase.Left + 60, MyBase.Top + 60), .Text = "新建数据源" }.ShowDialog() = DialogResult.OK Then
				Me.oOO.00O0_00Oo.().SelectedIndex = Me.oOO.00O0_00Oo.().Items.Count - 1
			End If
		End Sub

		' Token: 0x060038F8 RID: 14584 RVA: 0x00188BBC File Offset: 0x00186DBC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oOO.00O0_00Oo.().SelectedItem IsNot Nothing Then
				Dim row As DataRow = CType(Me.oOO.00O0_00Oo.().SelectedItem, DataRowView).Row
				Try
					Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current.ConnectionName, Conversions.ToString(row("Name")), True) = 0 Then
							If MessageBox.Show("因为已经载入该数据源中的表，修改数据源的设置会带来不可预知的后果，建议删除所有来自该数据源中的外部表，然后再修改该数据源；如果一定要现在修改，那么必须保证修改后的数据源包括所有已经加载的外部表，且表结构完全相同！" & vbLf & "确定要修改数据源吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.No Then
								Return
							End If
							Exit While
						End If
					End While
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Dim o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u As O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002 = New O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002(row)
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.Text = o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.Text + " - " + Conversions.ToString(row("Name"))
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.OO.0O_.().Value = O00.oO_.0o_oo_0O_.(Conversions.ToString(row("ConnectionString")), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.())
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.Location = New Point(MyBase.Left + 60, MyBase.Top + 60)
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.ShowDialog()
				If o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.OO.o_000o. Then
					Me.o0oo_o_0OOo_.O. = True
				End If
			End If
		End Sub

		' Token: 0x060038F9 RID: 14585 RVA: 0x00188CE8 File Offset: 0x00186EE8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oOO.00O0_00Oo.().SelectedIndex >= 0 Then
				Dim row As DataRow = CType(Me.oOO.00O0_00Oo.().SelectedItem, DataRowView).Row
				If Not row.IsNull("ConnectionString") Then
					Dim text As String = O00.oO_.0o_oo_0O_.(Conversions.ToString(row("ConnectionString")), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.())
					Dim o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u As o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002
					If text.Trim().StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse text.Trim().StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
						Dim a_ As O0O = New O0O(text)
						o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u = New o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(Nothing, a_, CType(Me.oOO.00O0_00Oo.().SelectedItem, DataRowView)("Name").ToString())
					Else
						Dim a_2 As OleDbConnection = New OleDbConnection(text)
						o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u = New o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(a_2, Nothing, CType(Me.oOO.00O0_00Oo.().SelectedItem, DataRowView)("Name").ToString())
					End If
					o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u.o.00_0_0.()
					If o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u.O0O__O0oo_._. Then
						Me.o0oo_o_0OOo_.O. = True
					End If
				End If
			End If
		End Sub

		' Token: 0x04001786 RID: 6022
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001787 RID: 6023
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001788 RID: 6024
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001789 RID: 6025
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400178A RID: 6026
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400178B RID: 6027
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400178C RID: 6028
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400178D RID: 6029
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
