Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000DD RID: 221
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class o\u3000\u3000\u3002\u3002
		Inherits Form

		' Token: 0x06000C63 RID: 3171 RVA: 0x00059AB8 File Offset: 0x00057CB8
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O._0O0OO0_o00_. IsNot Nothing Then
					Me.O._0O0OO0_o00_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000C64 RID: 3172 RVA: 0x00059AF8 File Offset: 0x00057CF8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oOoo.o0_00o_o.(New Label())
			Me.Oo_.O__0o.(New RadioButton())
			Me.O._0O0OO0_o00_.(New RadioButton())
			Me.O._0O0OO0_o00_.(New C1TextBox())
			Me.oOoo.o0_00o_o.(New C1Button())
			Me.O0_o._O0oo.(New C1Button())
			MyBase.SuspendLayout()
			Me.oOoo.o0_00o_o.().AutoSize = True
			Me.oOoo.o0_00o_o.().Location = New Point(13, 18)
			Me.oOoo.o0_00o_o.().Name = "Label1"
			Me.oOoo.o0_00o_o.().Size = New Size(119, 12)
			Me.oOoo.o0_00o_o.().TabIndex = 0
			Me.oOoo.o0_00o_o.().Text = "文件已存在，请选择:"
			Me.oOoo.o0_00o_o.().AutoSize = True
			Me.oOoo.o0_00o_o.().Checked = True
			Me.oOoo.o0_00o_o.().Location = New Point(31, 42)
			Me.oOoo.o0_00o_o.().Name = "rdoOverWrite"
			Me.oOoo.o0_00o_o.().Size = New Size(95, 16)
			Me.oOoo.o0_00o_o.().TabIndex = 1
			Me.oOoo.o0_00o_o.().TabStop = True
			Me.oOoo.o0_00o_o.().Text = "覆盖现有文件"
			Me.oOoo.o0_00o_o.().UseVisualStyleBackColor = True
			Me.O0_o._O0oo.().AutoSize = True
			Me.O0_o._O0oo.().Location = New Point(31, 65)
			Me.O0_o._O0oo.().Name = "rdoRename"
			Me.O0_o._O0oo.().Size = New Size(113, 16)
			Me.O0_o._O0oo.().TabIndex = 2
			Me.O0_o._O0oo.().Text = "将文件重命名为:"
			Me.O0_o._O0oo.().UseVisualStyleBackColor = True
			Me.oOoo.o0_00o_o.().Enabled = False
			Me.oOoo.o0_00o_o.().Location = New Point(31, 87)
			Me.oOoo.o0_00o_o.().Name = "TextBox1"
			Me.oOoo.o0_00o_o.().Size = New Size(245, 21)
			Me.oOoo.o0_00o_o.().TabIndex = 4
			Me.Oo__.O_O__oO.().Location = New Point(69, 126)
			Me.Oo__.O_O__oO.().Name = "Button1"
			Me.Oo__.O_O__oO.().Size = New Size(75, 23)
			Me.Oo__.O_O__oO.().TabIndex = 5
			Me.Oo__.O_O__oO.().Text = "确定"
			Me.Oo__.O_O__oO.().UseVisualStyleBackColor = True
			Me.oOoo.o0_00o_o.().DialogResult = DialogResult.Cancel
			Me.oOoo.o0_00o_o.().Location = New Point(159, 126)
			Me.oOoo.o0_00o_o.().Name = "Button2"
			Me.oOoo.o0_00o_o.().Size = New Size(75, 23)
			Me.oOoo.o0_00o_o.().TabIndex = 6
			Me.oOoo.o0_00o_o.().Text = "取消"
			Me.oOoo.o0_00o_o.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(304, 169)
			MyBase.Controls.Add(Me.oOoo.o0_00o_o.())
			MyBase.Controls.Add(Me.Oo__.O_O__oO.())
			MyBase.Controls.Add(Me.oOoo.o0_00o_o.())
			MyBase.Controls.Add(Me.O0_o._O0oo.())
			MyBase.Controls.Add(Me.oOoo.o0_00o_o.())
			MyBase.Controls.Add(Me.oOoo.o0_00o_o.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "MainTable"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "提示"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000C65 RID: 3173 RVA: 0x00059E9C File Offset: 0x0005809C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O._0O0OO0_o00_.
		End Function

		' Token: 0x06000C66 RID: 3174 RVA: 0x00059EA4 File Offset: 0x000580A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O._0O0OO0_o00_. = A_0
		End Sub

		' Token: 0x06000C67 RID: 3175 RVA: 0x00059EAD File Offset: 0x000580AD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O._0O0OO0_o00_.
		End Function

		' Token: 0x06000C68 RID: 3176 RVA: 0x00059EB5 File Offset: 0x000580B5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O._0O0OO0_o00_. = A_0
		End Sub

		' Token: 0x06000C69 RID: 3177 RVA: 0x00059EBE File Offset: 0x000580BE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._0O0OO0_o00_.
		End Function

		' Token: 0x06000C6A RID: 3178 RVA: 0x00059EC8 File Offset: 0x000580C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo__.O_O__oO.
			Dim o._0O0OO0_o00_. As C1Button = Me.O._0O0OO0_o00_.
			If o._0O0OO0_o00_. IsNot Nothing Then
				RemoveHandler o._0O0OO0_o00_..Click, value
			End If
			Me.O._0O0OO0_o00_. = A_0
			o._0O0OO0_o00_. = Me.O._0O0OO0_o00_.
			If o._0O0OO0_o00_. IsNot Nothing Then
				AddHandler o._0O0OO0_o00_..Click, value
			End If
		End Sub

		' Token: 0x06000C6B RID: 3179 RVA: 0x00059F0B File Offset: 0x0005810B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_.O__0o.
		End Function

		' Token: 0x06000C6C RID: 3180 RVA: 0x00059F13 File Offset: 0x00058113
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo_.O__0o. = A_0
		End Sub

		' Token: 0x06000C6D RID: 3181 RVA: 0x00059F1C File Offset: 0x0005811C
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O._0O0OO0_o00_.
		End Function

		' Token: 0x06000C6E RID: 3182 RVA: 0x00059F24 File Offset: 0x00058124
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O._0O0OO0_o00_. = A_0
		End Sub

		' Token: 0x06000C6F RID: 3183 RVA: 0x00059F2D File Offset: 0x0005812D
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.Oo_.O__0o.
		End Function

		' Token: 0x06000C70 RID: 3184 RVA: 0x00059F38 File Offset: 0x00058138
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.oOoo.o0_00o_o.
			Dim oo_.O__0o. As RadioButton = Me.Oo_.O__0o.
			If oo_.O__0o. IsNot Nothing Then
				RemoveHandler oo_.O__0o..CheckedChanged, value
			End If
			Me.Oo_.O__0o. = A_0
			oo_.O__0o. = Me.Oo_.O__0o.
			If oo_.O__0o. IsNot Nothing Then
				AddHandler oo_.O__0o..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C71 RID: 3185 RVA: 0x00059F7C File Offset: 0x0005817C
		Public Sub New(A_0 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.oo0_O0Oo._.
			Me.oOoo.o0_00o_o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oOoo.o0_00o_o.().Value = c.OOOOO.o.().FileSystem.GetName(A_0)
			Me.O0o0o0_00OO.oO. = A_0
			Me.OooO_0.o00O. = c.OOOOO.o.().FileSystem.GetParentPath(A_0)
		End Sub

		' Token: 0x06000C72 RID: 3186 RVA: 0x00059FF4 File Offset: 0x000581F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0_o._O0oo.().Checked Then
				If Operators.CompareString(Me.oOoo.o0_00o_o.().Text.Trim(), "", True) = 0 Then
					Return
				End If
				If c.OOOOO.o.().FileSystem.FileExists(Me.OooO_0.o00O. + "\" + Me.oOoo.o0_00o_o.().Text.Trim()) Then
					MessageBox.Show("文件已经存在，请输入新的文件名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
			Else
				Try
					c.OOOOO.o.().FileSystem.DeleteFile(Me.O0o0o0_00OO.oO.)
				Catch ex As Exception
					Return
				End Try
			End If
			Me.O0o0o0_00OO.oO. = Me.OooO_0.o00O. + "\" + Me.oOoo.o0_00o_o.().Text.Trim()
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06000C73 RID: 3187 RVA: 0x0005A0D8 File Offset: 0x000582D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oOoo.o0_00o_o.().Enabled = Me.O0_o._O0oo.().Checked
		End Sub

		' Token: 0x06000C74 RID: 3188 RVA: 0x0005A0F0 File Offset: 0x000582F0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040004C1 RID: 1217
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040004C2 RID: 1218
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040004C3 RID: 1219
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040004C4 RID: 1220
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004C5 RID: 1221
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004C6 RID: 1222
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040004C7 RID: 1223
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040004C8 RID: 1224
		Private <<EMPTY_NAME>> As String

		' Token: 0x040004C9 RID: 1225
		Public <<EMPTY_NAME>> As String
	End Class
End Namespace
