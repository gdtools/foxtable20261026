Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000348 RID: 840
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3000\u3002\u3002\u3002\u3002o
		Inherits Form

		' Token: 0x06003326 RID: 13094 RVA: 0x0014EF20 File Offset: 0x0014D120
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo0___.o000_. IsNot Nothing Then
					Me.Oo0___.o000_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003327 RID: 13095 RVA: 0x0014EF60 File Offset: 0x0014D160
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O0oo_o0oo0._.(New C1Button())
			Me.O0___Oo.O_00o.(New C1Button())
			Me.OO0O__00o00O._.(New C1Button())
			Me.Oo0___.o000_.(New C1Button())
			Me.Oo0___.o000_.(New ListBox())
			MyBase.SuspendLayout()
			Me.o.OO0Oo_0.().Location = New Point(197, 170)
			Me.o.OO0Oo_0.().Name = "btnOk"
			Me.o.OO0Oo_0.().Size = New Size(75, 23)
			Me.o.OO0Oo_0.().TabIndex = 14
			Me.o.OO0Oo_0.().Text = "确定"
			Me.o.OO0Oo_0.().UseVisualStyleBackColor = True
			Me.OO0O__00o00O._.().Location = New Point(197, 199)
			Me.OO0O__00o00O._.().Name = "btnCancel"
			Me.OO0O__00o00O._.().Size = New Size(75, 23)
			Me.OO0O__00o00O._.().TabIndex = 13
			Me.OO0O__00o00O._.().Text = "取消"
			Me.OO0O__00o00O._.().UseVisualStyleBackColor = True
			Me.O.oO_.().Location = New Point(197, 43)
			Me.O.oO_.().Name = "btnDelete"
			Me.O.oO_.().Size = New Size(75, 23)
			Me.O.oO_.().TabIndex = 12
			Me.O.oO_.().Text = "删除"
			Me.O.oO_.().UseVisualStyleBackColor = True
			Me.O0___Oo.O_00o.().Location = New Point(197, 14)
			Me.O0___Oo.O_00o.().Name = "btnRename"
			Me.O0___Oo.O_00o.().Size = New Size(75, 23)
			Me.O0___Oo.O_00o.().TabIndex = 11
			Me.O0___Oo.O_00o.().Text = "重命名"
			Me.O0___Oo.O_00o.().UseVisualStyleBackColor = True
			Me.O.oO_.().FormattingEnabled = True
			Me.O.oO_.().ItemHeight = 12
			Me.O.oO_.().Location = New Point(13, 14)
			Me.O.oO_.().Name = "ListBox1"
			Me.O.oO_.().Size = New Size(169, 208)
			Me.O.oO_.().TabIndex = 10
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(285, 236)
			MyBase.Controls.Add(Me.o.OO0Oo_0.())
			MyBase.Controls.Add(Me.OO0O__00o00O._.())
			MyBase.Controls.Add(Me.O.oO_.())
			MyBase.Controls.Add(Me.O0___Oo.O_00o.())
			MyBase.Controls.Add(Me.O.oO_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.....O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设置管理"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003328 RID: 13096 RVA: 0x0014F271 File Offset: 0x0014D471
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo0___.o000_.
		End Function

		' Token: 0x06003329 RID: 13097 RVA: 0x0014F27C File Offset: 0x0014D47C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__oo.0.
			Dim oo0___.o000_. As C1Button = Me.Oo0___.o000_.
			If oo0___.o000_. IsNot Nothing Then
				RemoveHandler oo0___.o000_..Click, value
			End If
			Me.Oo0___.o000_. = A_0
			oo0___.o000_. = Me.Oo0___.o000_.
			If oo0___.o000_. IsNot Nothing Then
				AddHandler oo0___.o000_..Click, value
			End If
		End Sub

		' Token: 0x0600332A RID: 13098 RVA: 0x0014F2BF File Offset: 0x0014D4BF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0o_.O.
		End Function

		' Token: 0x0600332B RID: 13099 RVA: 0x0014F2C8 File Offset: 0x0014D4C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_Oo00oo.Ooo.
			Dim c1Button As C1Button = Me.o0o_.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0o_.O. = A_0
			c1Button = Me.o0o_.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600332C RID: 13100 RVA: 0x0014F30B File Offset: 0x0014D50B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o__o.0_O_O__O_.
		End Function

		' Token: 0x0600332D RID: 13101 RVA: 0x0014F314 File Offset: 0x0014D514
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_.o_.
			Dim c1Button As C1Button = Me.o__o.0_O_O__O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o__o.0_O_O__O_. = A_0
			c1Button = Me.o__o.0_O_O__O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600332E RID: 13102 RVA: 0x0014F357 File Offset: 0x0014D557
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0oo_o0oo0._.
		End Function

		' Token: 0x0600332F RID: 13103 RVA: 0x0014F360 File Offset: 0x0014D560
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo_oOoOO_oo0.0.
			Dim o0oo_o0oo0._. As C1Button = Me.O0oo_o0oo0._.
			If o0oo_o0oo0._. IsNot Nothing Then
				RemoveHandler o0oo_o0oo0._..Click, value
			End If
			Me.O0oo_o0oo0._. = A_0
			o0oo_o0oo0._. = Me.O0oo_o0oo0._.
			If o0oo_o0oo0._. IsNot Nothing Then
				AddHandler o0oo_o0oo0._..Click, value
			End If
		End Sub

		' Token: 0x06003330 RID: 13104 RVA: 0x0014F3A3 File Offset: 0x0014D5A3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As ListBox
			Return Me.Oo0___.o000_.
		End Function

		' Token: 0x06003331 RID: 13105 RVA: 0x0014F3AB File Offset: 0x0014D5AB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.Oo0___.o000_. = A_0
		End Sub

		' Token: 0x06003332 RID: 13106 RVA: 0x0014F3B4 File Offset: 0x0014D5B4
		Public Sub New(A_0 As Table, A_1 As ExtendTablePropertyTypeEnum)
			AddHandler MyBase.FormClosed, AddressOf Me.O.oO_.
			Me.O__0O.OO0Oo. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			Me.O.oO_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O__0O.OO0Oo. = A_0
			Me.O__0O.OO0Oo. = A_1
			Me.O__0O.OO0Oo. = New DataView(Me.O__0O.OO0Oo., "[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString(A_1), "", DataViewRowState.CurrentRows)
			Me.O__0O.OO0Oo. = CType(Me.BindingContext(Me.O__0O.OO0Oo.), CurrencyManager)
			Me.O.oO_.().DataSource = Me.O__0O.OO0Oo.
			Me.O.oO_.().DisplayMember = "Name"
		End Sub

		' Token: 0x06003333 RID: 13107 RVA: 0x0014F491 File Offset: 0x0014D691
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O__0O.OO0Oo..Position >= 0 Then
				CType(Me.O__0O.OO0Oo..Current, DataRowView).Delete()
			End If
		End Sub

		' Token: 0x06003334 RID: 13108 RVA: 0x0014F4B8 File Offset: 0x0014D6B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O__0O.OO0Oo..Position >= 0 Then
				Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("重命名", "请输入新的名称:", Conversions.ToString(CType(Me.O__0O.OO0Oo..Current, DataRowView)("Name")))
				o_u3000_u.Oo.__0o_0_Oo.(AddressOf Me.Oo0___.o000_.)
				If o_u3000_u.ShowDialog() = DialogResult.OK Then
					CType(Me.O__0O.OO0Oo..Current, DataRowView)("Name") = o_u3000_u.Value
					CType(Me.O__0O.OO0Oo..Current, DataRowView).EndEdit()
				End If
			End If
		End Sub

		' Token: 0x06003335 RID: 13109 RVA: 0x0014F554 File Offset: 0x0014D754
		Private Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If Operators.CompareString(A_1.Value, "", True) = 0 Then
				MessageBox.Show("请输入设置名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
				Return
			End If
			If Operators.CompareString(A_1.Value, A_1.OriginalValue, True) <> 0 AndAlso Me.O__0O.OO0Oo..Rows.Find(New Object() { Me.O__0O.OO0Oo..DataTable.Name, A_1.Value, 2 }) IsNot Nothing Then
				MessageBox.Show("已经存在同名设置，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06003336 RID: 13110 RVA: 0x0014F5FA File Offset: 0x0014D7FA
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Oo00.o0_o._O_.(Me.O__0O.OO0Oo., True)
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06003337 RID: 13111 RVA: 0x0014F60F File Offset: 0x0014D80F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O__0O.OO0Oo..RejectChanges()
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06003338 RID: 13112 RVA: 0x0014F623 File Offset: 0x0014D823
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040014AB RID: 5291
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040014AC RID: 5292
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014AD RID: 5293
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014AE RID: 5294
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014AF RID: 5295
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014B0 RID: 5296
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x040014B1 RID: 5297
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040014B2 RID: 5298
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x040014B3 RID: 5299
		Private <<EMPTY_NAME>> As CurrencyManager

		' Token: 0x040014B4 RID: 5300
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040014B5 RID: 5301
		Private <<EMPTY_NAME>> As ExtendTablePropertyTypeEnum
	End Class
End Namespace
