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
	' Token: 0x020000DF RID: 223
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class O\u3000\u3002\u3002\u3000\u3000
		Inherits Form

		' Token: 0x06000C8B RID: 3211 RVA: 0x0005A954 File Offset: 0x00058B54
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_000o.0. IsNot Nothing Then
					Me.O_000o.0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000C8C RID: 3212 RVA: 0x0005A994 File Offset: 0x00058B94
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O_000o.0.(New C1Button())
			Me.O_000o.0.(New C1TextBox())
			Me.O_000o.0.(New C1CheckBox())
			MyBase.SuspendLayout()
			Me.OoO_O0o.O0__O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.OoO_O0o.O0__O.().Location = New Point(351, 229)
			Me.OoO_O0o.O0__O.().Name = "Button1"
			Me.OoO_O0o.O0__O.().Size = New Size(95, 23)
			Me.OoO_O0o.O0__O.().TabIndex = 1
			Me.OoO_O0o.O0__O.().Text = "复制详细信息"
			Me.OoO_O0o.O0__O.().UseVisualStyleBackColor = True
			Me.OoO_O0o.O0__O.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.OoO_O0o.O0__O.().Location = New Point(13, 15)
			Me.OoO_O0o.O0__O.().Multiline = True
			Me.OoO_O0o.O0__O.().Name = "TextBox1"
			Me.OoO_O0o.O0__O.().[ReadOnly] = True
			Me.OoO_O0o.O0__O.().ScrollBars = ScrollBars.Vertical
			Me.OoO_O0o.O0__O.().Size = New Size(433, 204)
			Me.OoO_O0o.O0__O.().TabIndex = 2
			Me.OoO_O0o.O0__O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.OoO_O0o.O0__O.().AutoSize = True
			Me.OoO_O0o.O0__O.().Location = New Point(13, 236)
			Me.OoO_O0o.O0__O.().Name = "CheckBox1"
			Me.OoO_O0o.O0__O.().Size = New Size(96, 16)
			Me.OoO_O0o.O0__O.().TabIndex = 3
			Me.OoO_O0o.O0__O.().Text = "显示详细信息"
			Me.OoO_O0o.O0__O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(459, 264)
			MyBase.Controls.Add(Me.OoO_O0o.O0__O.())
			MyBase.Controls.Add(Me.OoO_O0o.O0__O.())
			MyBase.Controls.Add(Me.OoO_O0o.O0__O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Oooo.O.O."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "运行错误"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000C8D RID: 3213 RVA: 0x0005ABE2 File Offset: 0x00058DE2
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_000o.0.
		End Function

		' Token: 0x06000C8E RID: 3214 RVA: 0x0005ABEC File Offset: 0x00058DEC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO.0__0__00_o.
			Dim o_000o.0. As C1Button = Me.O_000o.0.
			If o_000o.0. IsNot Nothing Then
				RemoveHandler o_000o.0..Click, value
			End If
			Me.O_000o.0. = A_0
			o_000o.0. = Me.O_000o.0.
			If o_000o.0. IsNot Nothing Then
				AddHandler o_000o.0..Click, value
			End If
		End Sub

		' Token: 0x06000C8F RID: 3215 RVA: 0x0005AC2F File Offset: 0x00058E2F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_000o.0.
		End Function

		' Token: 0x06000C90 RID: 3216 RVA: 0x0005AC37 File Offset: 0x00058E37
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_000o.0. = A_0
		End Sub

		' Token: 0x06000C91 RID: 3217 RVA: 0x0005AC40 File Offset: 0x00058E40
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_000o.0.
		End Function

		' Token: 0x06000C92 RID: 3218 RVA: 0x0005AC48 File Offset: 0x00058E48
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.o0Ooo.0O0_0.
			Dim o_000o.0. As C1CheckBox = Me.O_000o.0.
			If o_000o.0. IsNot Nothing Then
				RemoveHandler o_000o.0..CheckedChanged, value
			End If
			Me.O_000o.0. = A_0
			o_000o.0. = Me.O_000o.0.
			If o_000o.0. IsNot Nothing Then
				AddHandler o_000o.0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C93 RID: 3219 RVA: 0x0005AC8C File Offset: 0x00058E8C
		Public Sub New(A_0 As String, A_1 As Exception)
			AddHandler MyBase.Activated, AddressOf Me.OoO_O0o.O0__O.
			AddHandler MyBase.FormClosed, AddressOf Me.OoO_O0o.O0__O.
			Me.OoO_O0o.O0__O.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O_000o.0. = ".NET Framework 版本：" + Environment.Version.ToString() + vbCrLf
			Me.O_000o.0. = Me.O_000o.0. + "Foxtable 版本：" + c.Oo.__O0.().Info.Version.ToString() + vbCrLf
			Me.O_000o.0. = Me.O_000o.0. + "错误所在事件：" + A_0 + vbCrLf
			Me.O_000o.0. += "详细错误信息：" & vbCrLf
			Dim ex As Exception = A_1
			Do
				Me.O_000o.0. = Me.O_000o.0. + ex.Message + vbCrLf
				ex = ex.InnerException
			Loop While ex IsNot Nothing
			Me.O_000o.0. = A_1
			If Control.ModifierKeys = Keys.Control Then
				Me.OoO_O0o.O0__O.().Value = Me.O_000o.0.
				Me.OoO_O0o.O0__O.().Checked = True
				Return
			End If
			Me.OoO_O0o.O0__O.().Value = A_1.Message
		End Sub

		' Token: 0x06000C94 RID: 3220 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OoO_O0o.O0__O.().Checked Then
				Me.OoO_O0o.O0__O.().Value = Me.O_000o.0.
				Return
			End If
			Me.OoO_O0o.O0__O.().Value = Me.O_000o.0..Message
		End Sub

		' Token: 0x06000C95 RID: 3221 RVA: 0x0005ADFF File Offset: 0x00058FFF
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Clipboard.SetText(Me.O_000o.0.)
		End Sub

		' Token: 0x06000C96 RID: 3222 RVA: 0x0005AE0C File Offset: 0x0005900C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.BringToFront()
		End Sub

		' Token: 0x06000C97 RID: 3223 RVA: 0x0005AE14 File Offset: 0x00059014
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040004D5 RID: 1237
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040004D6 RID: 1238
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004D7 RID: 1239
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040004D8 RID: 1240
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040004D9 RID: 1241
		Private <<EMPTY_NAME>> As String

		' Token: 0x040004DA RID: 1242
		Private <<EMPTY_NAME>> As Exception
	End Class
End Namespace
