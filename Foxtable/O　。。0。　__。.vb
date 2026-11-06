Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Namespace Foxtable
	' Token: 0x020000DE RID: 222
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class O\u3000\u3002\u30020\u3002\u3000__\u3002
		Inherits Form

		' Token: 0x06000C75 RID: 3189 RVA: 0x0005A104 File Offset: 0x00058304
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o00ooO_00._0. IsNot Nothing Then
					Me.o00ooO_00._0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000C76 RID: 3190 RVA: 0x0005A144 File Offset: 0x00058344
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O00O_00.oO__.(New C1ComboBox())
			Me.o00ooO_00._0.(New C1TextBox())
			Me.o00ooO_00._0.(New RadioButton())
			Me.ooO_.oO.(New RadioButton())
			Me.O00O_00.oO__.(New C1Button())
			Me.ooO_.oO.(New C1Button())
			Me.O00O_00.oO__.(New CheckBox())
			MyBase.SuspendLayout()
			Me.o0.O0o.().DropDownStyle = 1
			Me.o0.O0o.().Location = New Point(15, 36)
			Me.o0.O0o.().Name = "ComboBox1"
			Me.o0.O0o.().Size = New Size(218, 20)
			Me.o0.O0o.().TabIndex = 0
			Me.O00O_00.oO__.().Enabled = False
			Me.O00O_00.oO__.().Location = New Point(15, 96)
			Me.O00O_00.oO__.().Name = "TextBox1"
			Me.O00O_00.oO__.().Size = New Size(218, 21)
			Me.O00O_00.oO__.().TabIndex = 3
			Me.ooO_.oO.().AutoSize = True
			Me.ooO_.oO.().Checked = True
			Me.ooO_.oO.().Location = New Point(15, 14)
			Me.ooO_.oO.().Name = "rdoCurrent"
			Me.ooO_.oO.().Size = New Size(95, 16)
			Me.ooO_.oO.().TabIndex = 4
			Me.ooO_.oO.().TabStop = True
			Me.ooO_.oO.().Text = "选择现有目录"
			Me.ooO_.oO.().UseVisualStyleBackColor = True
			Me.o0.O0o.().AutoSize = True
			Me.o0.O0o.().Location = New Point(15, 74)
			Me.o0.O0o.().Name = "rdoCreate"
			Me.o0.O0o.().Size = New Size(95, 16)
			Me.o0.O0o.().TabIndex = 5
			Me.o0.O0o.().TabStop = True
			Me.o0.O0o.().Text = "创建新的目录"
			Me.o0.O0o.().UseVisualStyleBackColor = True
			Me.O.o0_o.().Location = New Point(42, 174)
			Me.O.o0_o.().Name = "Button1"
			Me.O.o0_o.().Size = New Size(75, 23)
			Me.O.o0_o.().TabIndex = 6
			Me.O.o0_o.().Text = "确定"
			Me.O.o0_o.().UseVisualStyleBackColor = True
			Me.o0.O0o.().DialogResult = DialogResult.Cancel
			Me.o0.O0o.().Location = New Point(132, 174)
			Me.o0.O0o.().Name = "Button2"
			Me.o0.O0o.().Size = New Size(75, 23)
			Me.o0.O0o.().TabIndex = 7
			Me.o0.O0o.().Text = "取消"
			Me.o0.O0o.().UseVisualStyleBackColor = True
			Me.o0.O0o.().AutoSize = True
			Me.o0.O0o.().Location = New Point(15, 134)
			Me.o0.O0o.().Name = "CheckBox1"
			Me.o0.O0o.().Size = New Size(108, 16)
			Me.o0.O0o.().TabIndex = 8
			Me.o0.O0o.().Text = "不再显示此窗口"
			Me.o0.O0o.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(249, 209)
			MyBase.Controls.Add(Me.o0.O0o.())
			MyBase.Controls.Add(Me.o0.O0o.())
			MyBase.Controls.Add(Me.O.o0_o.())
			MyBase.Controls.Add(Me.o0.O0o.())
			MyBase.Controls.Add(Me.ooO_.oO.())
			MyBase.Controls.Add(Me.O00O_00.oO__.())
			MyBase.Controls.Add(Me.o0.O0o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "ooo..O.O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择目录"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000C77 RID: 3191 RVA: 0x0005A57F File Offset: 0x0005877F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o00ooO_00._0.
		End Function

		' Token: 0x06000C78 RID: 3192 RVA: 0x0005A587 File Offset: 0x00058787
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o00ooO_00._0. = A_0
		End Sub

		' Token: 0x06000C79 RID: 3193 RVA: 0x0005A590 File Offset: 0x00058790
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o00ooO_00._0.
		End Function

		' Token: 0x06000C7A RID: 3194 RVA: 0x0005A598 File Offset: 0x00058798
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o00ooO_00._0. = A_0
		End Sub

		' Token: 0x06000C7B RID: 3195 RVA: 0x0005A5A1 File Offset: 0x000587A1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o00ooO_00._0.
		End Function

		' Token: 0x06000C7C RID: 3196 RVA: 0x0005A5AC File Offset: 0x000587AC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.oo000oOo.OOo.
			Dim radioButton As RadioButton = Me.o00ooO_00._0.
			If radioButton IsNot Nothing Then
				RemoveHandler radioButton.CheckedChanged, value
			End If
			Me.o00ooO_00._0. = A_0
			radioButton = Me.o00ooO_00._0.
			If radioButton IsNot Nothing Then
				AddHandler radioButton.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C7D RID: 3197 RVA: 0x0005A5EF File Offset: 0x000587EF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o00ooO_00._0.
		End Function

		' Token: 0x06000C7E RID: 3198 RVA: 0x0005A5F8 File Offset: 0x000587F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0.O0o.
			Dim c1Button As C1Button = Me.o00ooO_00._0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o00ooO_00._0. = A_0
			c1Button = Me.o00ooO_00._0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000C7F RID: 3199 RVA: 0x0005A63B File Offset: 0x0005883B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.O_Oo__O0.
		End Function

		' Token: 0x06000C80 RID: 3200 RVA: 0x0005A643 File Offset: 0x00058843
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O.O_Oo__O0. = A_0
		End Sub

		' Token: 0x06000C81 RID: 3201 RVA: 0x0005A64C File Offset: 0x0005884C
		<CompilerGenerated()>
		Public Overridable Overloads Function <<EMPTY_NAME>>() As CheckBox
			Return Me.o00ooO_00._0.
		End Function

		' Token: 0x06000C82 RID: 3202 RVA: 0x0005A654 File Offset: 0x00058854
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As CheckBox)
			Me.o00ooO_00._0. = A_0
		End Sub

		' Token: 0x06000C83 RID: 3203 RVA: 0x0005A65D File Offset: 0x0005885D
		<CompilerGenerated()>
		Public Overridable Overloads Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O.O_Oo__O0.
		End Function

		' Token: 0x06000C84 RID: 3204 RVA: 0x0005A668 File Offset: 0x00058868
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.o0OOOOOO000._O.
			Dim o.O_Oo__O0. As RadioButton = Me.O.O_Oo__O0.
			If o.O_Oo__O0. IsNot Nothing Then
				RemoveHandler o.O_Oo__O0..CheckedChanged, value
			End If
			Me.O.O_Oo__O0. = A_0
			o.O_Oo__O0. = Me.O.O_Oo__O0.
			If o.O_Oo__O0. IsNot Nothing Then
				AddHandler o.O_Oo__O0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C85 RID: 3205 RVA: 0x0005A6AB File Offset: 0x000588AB
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0.O0o.().Enabled = Me.ooO_.oO.().Checked
		End Sub

		' Token: 0x06000C86 RID: 3206 RVA: 0x0005A6C3 File Offset: 0x000588C3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O00O_00.oO__.().Enabled = Me.o0.O0o.().Checked
		End Sub

		' Token: 0x06000C87 RID: 3207 RVA: 0x0005A6DC File Offset: 0x000588DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0.O0o.().Items.Add("\")
			Me.o0.O0o.().SelectedIndex = 0
			Try
				For Each path As String In c.OOOOO.o.().FileSystem.GetDirectories(Me.oO_o_0_o.0_., SearchOption.SearchTopLevelOnly, New String(-1) {})
					Me.o0.O0o.().Items.Add(c.OOOOO.o.().FileSystem.GetName(path))
					If Operators.CompareString(c.OOOOO.o.().FileSystem.GetName(path), Me.OoO0o_oo0_.0O0., True) = 0 Then
						Me.o0.O0o.().SelectedIndex = Me.o0.O0o.().Items.Count - 1
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of String)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000C88 RID: 3208 RVA: 0x0005A7B8 File Offset: 0x000589B8
		Public Sub New(A_0 As String, A_1 As String)
			AddHandler MyBase.Load, AddressOf Me.O.o0_o.
			AddHandler MyBase.FormClosed, AddressOf Me.o0.O0o.
			Me.O00O_00.oO__.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oO_o_0_o.0_. = A_0
			Me.OoO0o_oo0_.0O0. = A_1
			Me.O00O_00.oO__.().Value = A_1
		End Sub

		' Token: 0x06000C89 RID: 3209 RVA: 0x0005A824 File Offset: 0x00058A24
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0.O0o.().Checked Then
				If Operators.CompareString(Me.O00O_00.oO__.().Text.Trim(), "", True) = 0 Then
					Return
				End If
				If c.OOOOO.o.().FileSystem.DirectoryExists(Me.oO_o_0_o.0_. + Me.O00O_00.oO__.().Text) Then
					MessageBox.Show("目录" + Me.O00O_00.oO__.().Text + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				c.OOOOO.o.().FileSystem.CreateDirectory(Me.oO_o_0_o.0_. + Me.O00O_00.oO__.().Text)
				Me.O0_00._O. = Me.oO_o_0_o.0_. + Me.O00O_00.oO__.().Text + "\"
			ElseIf Me.o0.O0o.().SelectedIndex = 0 Then
				Me.O0_00._O. = Me.oO_o_0_o.0_.
			Else
				Me.O0_00._O. = Me.oO_o_0_o.0_. + Me.o0.O0o.().SelectedItem.ToString() + "\"
			End If
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06000C8A RID: 3210 RVA: 0x0005A941 File Offset: 0x00058B41
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040004CA RID: 1226
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040004CB RID: 1227
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040004CC RID: 1228
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040004CD RID: 1229
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040004CE RID: 1230
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004CF RID: 1231
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004D0 RID: 1232
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckBox

		' Token: 0x040004D1 RID: 1233
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040004D2 RID: 1234
		Private <<EMPTY_NAME>> As String

		' Token: 0x040004D3 RID: 1235
		Public <<EMPTY_NAME>> As String

		' Token: 0x040004D4 RID: 1236
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
