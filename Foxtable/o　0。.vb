Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000DC RID: 220
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class o\u30000\u3002
		Inherits Form

		' Token: 0x06000C5A RID: 3162 RVA: 0x000597FE File Offset: 0x000579FE
		Public Sub New()
			Me.oo0OO.0O0_0.()
		End Sub

		' Token: 0x06000C5B RID: 3163 RVA: 0x0005980C File Offset: 0x00057A0C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo.___00_0. IsNot Nothing Then
					Me.Oo.___00_0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000C5C RID: 3164 RVA: 0x0005984C File Offset: 0x00057A4C
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.Oo.___00_0.(New Label())
			Me.oo0OO.0O0_0.(New C1Button())
			Me.O0_0_.___0oO.(New C1Button())
			MyBase.SuspendLayout()
			Me.oo0OO.0O0_0.().AutoSize = True
			Me.oo0OO.0O0_0.().Location = New Point(12, 23)
			Me.oo0OO.0O0_0.().Name = "Label1"
			Me.oo0OO.0O0_0.().Size = New Size(65, 12)
			Me.oo0OO.0O0_0.().TabIndex = 0
			Me.oo0OO.0O0_0.().Text = "请输入值："
			Me.O_O_.Oo.().DialogResult = DialogResult.OK
			Me.O_O_.Oo.().Location = New Point(336, 13)
			Me.O_O_.Oo.().Name = "Button1"
			Me.O_O_.Oo.().Size = New Size(75, 23)
			Me.O_O_.Oo.().TabIndex = 2
			Me.O_O_.Oo.().Text = "确定"
			Me.O_O_.Oo.().UseVisualStyleBackColor = True
			Me.oo0OO.0O0_0.().DialogResult = DialogResult.Abort
			Me.oo0OO.0O0_0.().Location = New Point(336, 42)
			Me.oo0OO.0O0_0.().Name = "Button2"
			Me.oo0OO.0O0_0.().Size = New Size(75, 23)
			Me.oo0OO.0O0_0.().TabIndex = 3
			Me.oo0OO.0O0_0.().Text = "取消"
			Me.oo0OO.0O0_0.().UseVisualStyleBackColor = True
			MyBase.AcceptButton = Me.O_O_.Oo.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.oo0OO.0O0_0.()
			MyBase.ClientSize = New Size(424, 110)
			MyBase.Controls.Add(Me.oo0OO.0O0_0.())
			MyBase.Controls.Add(Me.O_O_.Oo.())
			MyBase.Controls.Add(Me.oo0OO.0O0_0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.oo.O.O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "输入"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000C5D RID: 3165 RVA: 0x00059A84 File Offset: 0x00057C84
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo.___00_0.
		End Function

		' Token: 0x06000C5E RID: 3166 RVA: 0x00059A8C File Offset: 0x00057C8C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo.___00_0. = A_0
		End Sub

		' Token: 0x06000C5F RID: 3167 RVA: 0x00059A95 File Offset: 0x00057C95
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_0_.___0oO.
		End Function

		' Token: 0x06000C60 RID: 3168 RVA: 0x00059A9D File Offset: 0x00057C9D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O0_0_.___0oO. = A_0
		End Sub

		' Token: 0x06000C61 RID: 3169 RVA: 0x00059AA6 File Offset: 0x00057CA6
		<CompilerGenerated()>
		Public Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.Oo.___00_0.
		End Function

		' Token: 0x06000C62 RID: 3170 RVA: 0x00059AAE File Offset: 0x00057CAE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo.___00_0. = A_0
		End Sub

		' Token: 0x040004BD RID: 1213
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040004BE RID: 1214
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004BF RID: 1215
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004C0 RID: 1216
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label
	End Class
End Namespace
