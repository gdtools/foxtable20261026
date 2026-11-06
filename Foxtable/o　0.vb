Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000D8 RID: 216
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class o\u30000
		Inherits Form

		' Token: 0x06000BEC RID: 3052 RVA: 0x00056864 File Offset: 0x00054A64
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOO_.o_0O. IsNot Nothing Then
					Me.oOO_.o_0O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000BED RID: 3053 RVA: 0x000568A4 File Offset: 0x00054AA4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o00_0_o._0_.(New C1Button())
			Me.OO.0_00o.(New C1Button())
			Me.OO.0_00o.(New CheckedListBox())
			Me.O.Oo_00.(New C1Button())
			Me.o0O_.0.(New C1Button())
			Me.OO.0_00o.(New Label())
			Me.OO.0_00o.(New C1CheckBox())
			MyBase.SuspendLayout()
			Me.O0O0o.o.().Location = New Point(295, 335)
			Me.O0O0o.o.().Name = "Button4"
			Me.O0O0o.o.().Size = New Size(75, 23)
			Me.O0O0o.o.().TabIndex = 10
			Me.O0O0o.o.().Text = "反选"
			Me.O0O0o.o.().UseVisualStyleBackColor = True
			Me.o0O._o__.().Location = New Point(295, 306)
			Me.o0O._o__.().Name = "Button3"
			Me.o0O._o__.().Size = New Size(75, 23)
			Me.o0O._o__.().TabIndex = 9
			Me.o0O._o__.().Text = "全选"
			Me.o0O._o__.().UseVisualStyleBackColor = True
			Me.oo_O_.O0___.().CheckOnClick = True
			Me.oo_O_.O0___.().FormattingEnabled = True
			Me.oo_O_.O0___.().Location = New Point(12, 36)
			Me.oo_O_.O0___.().Name = "CheckedListBox1"
			Me.oo_O_.O0___.().Size = New Size(266, 324)
			Me.oo_O_.O0___.().TabIndex = 5
			Me.oo_O_.O0___.().Location = New Point(295, 65)
			Me.oo_O_.O0___.().Name = "Button2"
			Me.oo_O_.O0___.().Size = New Size(75, 23)
			Me.oo_O_.O0___.().TabIndex = 8
			Me.oo_O_.O0___.().Text = "取消"
			Me.oo_O_.O0___.().UseVisualStyleBackColor = True
			Me.o0__ooo0.O0.().Location = New Point(295, 36)
			Me.o0__ooo0.O0.().Name = "Button1"
			Me.o0__ooo0.O0.().Size = New Size(75, 23)
			Me.o0__ooo0.O0.().TabIndex = 6
			Me.o0__ooo0.O0.().Text = "确定"
			Me.o0__ooo0.O0.().UseVisualStyleBackColor = True
			Me.oo_O_.O0___.().AutoSize = True
			Me.oo_O_.O0___.().Location = New Point(10, 13)
			Me.oo_O_.O0___.().Name = "Label1"
			Me.oo_O_.O0___.().Size = New Size(107, 12)
			Me.oo_O_.O0___.().TabIndex = 7
			Me.oo_O_.O0___.().Text = "请选择要合计的列:"
			Me.oo_O_.O0___.().AutoSize = True
			Me.oo_O_.O0___.().Location = New Point(13, 367)
			Me.oo_O_.O0___.().Name = "CheckBox1"
			Me.oo_O_.O0___.().Size = New Size(120, 16)
			Me.oo_O_.O0___.().TabIndex = 11
			Me.oo_O_.O0___.().Text = "自动进入合计模式"
			Me.oo_O_.O0___.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(380, 397)
			MyBase.Controls.Add(Me.oo_O_.O0___.())
			MyBase.Controls.Add(Me.O0O0o.o.())
			MyBase.Controls.Add(Me.o0O._o__.())
			MyBase.Controls.Add(Me.oo_O_.O0___.())
			MyBase.Controls.Add(Me.oo_O_.O0___.())
			MyBase.Controls.Add(Me.o0__ooo0.O0.())
			MyBase.Controls.Add(Me.oo_O_.O0___.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o..ooO.."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设置合计模式"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000BEE RID: 3054 RVA: 0x00056CB8 File Offset: 0x00054EB8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOO_.o_0O.
		End Function

		' Token: 0x06000BEF RID: 3055 RVA: 0x00056CC0 File Offset: 0x00054EC0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_.ooO.
			Dim c1Button As C1Button = Me.oOO_.o_0O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOO_.o_0O. = A_0
			c1Button = Me.oOO_.o_0O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000BF0 RID: 3056 RVA: 0x00056D03 File Offset: 0x00054F03
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_o_0O.O.
		End Function

		' Token: 0x06000BF1 RID: 3057 RVA: 0x00056D0C File Offset: 0x00054F0C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO.o_O_OO.
			Dim c1Button As C1Button = Me.oO_o_0O.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO_o_0O.O. = A_0
			c1Button = Me.oO_o_0O.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000BF2 RID: 3058 RVA: 0x00056D4F File Offset: 0x00054F4F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.oOO_.o_0O.
		End Function

		' Token: 0x06000BF3 RID: 3059 RVA: 0x00056D57 File Offset: 0x00054F57
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Me.oOO_.o_0O. = A_0
		End Sub

		' Token: 0x06000BF4 RID: 3060 RVA: 0x00056D60 File Offset: 0x00054F60
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0.0O_o_.
		End Function

		' Token: 0x06000BF5 RID: 3061 RVA: 0x00056D68 File Offset: 0x00054F68
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__O00.__o.
			Dim o0.0O_o_. As C1Button = Me.O0.0O_o_.
			If o0.0O_o_. IsNot Nothing Then
				RemoveHandler o0.0O_o_..Click, value
			End If
			Me.O0.0O_o_. = A_0
			o0.0O_o_. = Me.O0.0O_o_.
			If o0.0O_o_. IsNot Nothing Then
				AddHandler o0.0O_o_..Click, value
			End If
		End Sub

		' Token: 0x06000BF6 RID: 3062 RVA: 0x00056DAB File Offset: 0x00054FAB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.Oo_00.
		End Function

		' Token: 0x06000BF7 RID: 3063 RVA: 0x00056DB4 File Offset: 0x00054FB4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_O0.oOOo_00oO.
			Dim o.Oo_00. As C1Button = Me.O.Oo_00.
			If o.Oo_00. IsNot Nothing Then
				RemoveHandler o.Oo_00..Click, value
			End If
			Me.O.Oo_00. = A_0
			o.Oo_00. = Me.O.Oo_00.
			If o.Oo_00. IsNot Nothing Then
				AddHandler o.Oo_00..Click, value
			End If
		End Sub

		' Token: 0x06000BF8 RID: 3064 RVA: 0x00056DF7 File Offset: 0x00054FF7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOO_.o_0O.
		End Function

		' Token: 0x06000BF9 RID: 3065 RVA: 0x00056DFF File Offset: 0x00054FFF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOO_.o_0O. = A_0
		End Sub

		' Token: 0x06000BFA RID: 3066 RVA: 0x00056E08 File Offset: 0x00055008
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oOO_.o_0O.
		End Function

		' Token: 0x06000BFB RID: 3067 RVA: 0x00056E10 File Offset: 0x00055010
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oOO_.o_0O. = A_0
		End Sub

		' Token: 0x06000BFC RID: 3068 RVA: 0x00056E19 File Offset: 0x00055019
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a = 0 Then
				Me.a = 1
				Me.oOO_.o_0O..Oo0Oo___.o0o.()
			End If
		End Sub

		' Token: 0x06000BFD RID: 3069 RVA: 0x00056E38 File Offset: 0x00055038
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim list As List(Of String) = New List(Of String)()
			If Operators.CompareString(Me.oOO_.o_0O..ooo_O0oOo.0O., "", True) > 0 Then
				list.AddRange(Me.oOO_.o_0O..ooo_O0oOo.0O..Split(New Char() { ","c }))
			End If
			Try
				For Each col As Col In Me.oOO_.o_0O..Cols
					If col.IsNumeric() Then
						Me.oo_O_.O0___.().Items.Add(col.Name)
						If list.Contains(col.Name) Then
							Me.oo_O_.O0___.().SetItemChecked(Me.oo_O_.O0___.().Items.Count - 1, True)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Col)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.oo_O_.O0___.().Checked = Me.oOO_.o_0O..Oo.Oo0OoOOoo_.
		End Sub

		' Token: 0x06000BFE RID: 3070 RVA: 0x00056F28 File Offset: 0x00055128
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = Me.oo_O_.O0___.().Items.Count - 1
			For i As Integer = 0 To num
				Me.oo_O_.O0___.().SetItemChecked(i, True)
			Next
		End Sub

		' Token: 0x06000BFF RID: 3071 RVA: 0x00056F64 File Offset: 0x00055164
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = Me.oo_O_.O0___.().Items.Count - 1
			For i As Integer = 0 To num
				Me.oo_O_.O0___.().SetItemChecked(i, False)
			Next
		End Sub

		' Token: 0x06000C00 RID: 3072 RVA: 0x00056F9D File Offset: 0x0005519D
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000C01 RID: 3073 RVA: 0x00056FA8 File Offset: 0x000551A8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = ""
			Dim num As Integer = Me.oo_O_.O0___.().Items.Count - 1
			Dim num2 As Integer
			For i As Integer = 0 To num
				If Me.oo_O_.O0___.().GetItemChecked(i) Then
					Me.oOO_.o_0O..Cols(Me.oo_O_.O0___.().Items(i).ToString()).GrandTotal = True
					num2 += 1
					text = text + Me.oo_O_.O0___.().Items(i).ToString() + ","
				Else
					Me.oOO_.o_0O..Cols(Me.oo_O_.O0___.().Items(i).ToString()).GrandTotal = False
				End If
			Next
			If num2 = 0 Then
				MessageBox.Show("至少要选择一个需要合计的列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Me.oOO_.o_0O..Oo.Oo0OoOOoo_. = Me.oo_O_.O0___.().Checked
			Me.oOO_.o_0O..ClearSubtotal()
			Me.oOO_.o_0O..ooo_O0oOo.0O. = text.Trim(New Char() { ","c })
			Me.oOO_.o_0O..GrandTotal = True
			MyBase.Close()
			Dim c1FlexGrid As C1FlexGrid = Me.oOO_.o_0O..Grid
			c1FlexGrid.TopRow = c1FlexGrid.Rows.Count - 1
			Me.oOO_.o_0O..NeedSaveSetting = True
			Me.oOO_.o_0O..oo0OO0Ooo._.(True)
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
		End Sub

		' Token: 0x06000C02 RID: 3074 RVA: 0x00057128 File Offset: 0x00055328
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Activated, AddressOf Me.oOo.O0OO__O_.
			AddHandler MyBase.Load, AddressOf Me.o0o0O.o0o0.
			AddHandler MyBase.FormClosed, AddressOf Me.oo_O_.O0___.
			Me.OO.0_00o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oOO_.o_0O. = A_0
		End Sub

		' Token: 0x06000C03 RID: 3075 RVA: 0x00057193 File Offset: 0x00055393
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400048E RID: 1166
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400048F RID: 1167
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000490 RID: 1168
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000491 RID: 1169
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04000492 RID: 1170
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000493 RID: 1171
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000494 RID: 1172
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000495 RID: 1173
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000496 RID: 1174
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04000497 RID: 1175
		Private a As Integer
	End Class
End Namespace
