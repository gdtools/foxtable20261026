Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004B1 RID: 1201
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3000\u3000\u3002
		Inherits Form

		' Token: 0x06004D9D RID: 19869 RVA: 0x00201C1C File Offset: 0x001FFE1C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OO._O_00O. IsNot Nothing Then
					Me.OO._O_00O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06004D9E RID: 19870 RVA: 0x00201C5C File Offset: 0x001FFE5C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.ooO.0o_o0.(New Label())
			Me.oO0.O0_.(New C1CheckBox())
			Me.oO0.O0_.(New Label())
			Me.oO0.O0_.(New C1Button())
			MyBase.SuspendLayout()
			Me.oO0.O0_.().AutoSize = True
			Me.oO0.O0_.().Location = New Point(24, 24)
			Me.oO0.O0_.().Name = "Label1"
			Me.oO0.O0_.().Size = New Size(257, 12)
			Me.oO0.O0_.().TabIndex = 0
			Me.oO0.O0_.().Text = "其他人正在编辑NameValue,请等对方结束编辑。"
			Me.oO0.O0_.().TextAlign = ContentAlignment.TopCenter
			Me.oO0.O0_.().AutoSize = True
			Me.oO0.O0_.().Location = New Point(67, 94)
			Me.oO0.O0_.().Name = "CheckBox1"
			Me.oO0.O0_.().Size = New Size(216, 16)
			Me.oO0.O0_.().TabIndex = 1
			Me.oO0.O0_.().Text = "强行编辑NameValue(仅开发者可选!)"
			Me.oO0.O0_.().UseVisualStyleBackColor = True
			Me.ooO.0o_o0.().AutoSize = True
			Me.ooO.0o_o0.().Location = New Point(38, 58)
			Me.ooO.0o_o0.().Name = "Label2"
			Me.ooO.0o_o0.().Size = New Size(191, 12)
			Me.ooO.0o_o0.().TabIndex = 4
			Me.ooO.0o_o0.().Text = "若要解决异常导致的死锁，可选择:"
			Me.oO0.O0_.().Location = New Point(129, 143)
			Me.oO0.O0_.().Name = "Button1"
			Me.oO0.O0_.().Size = New Size(75, 23)
			Me.oO0.O0_.().TabIndex = 5
			Me.oO0.O0_.().Text = "确定"
			Me.oO0.O0_.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(333, 187)
			MyBase.Controls.Add(Me.oO0.O0_.())
			MyBase.Controls.Add(Me.ooO.0o_o0.())
			MyBase.Controls.Add(Me.oO0.O0_.())
			MyBase.Controls.Add(Me.oO0.O0_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o0O....."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "提示"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06004D9F RID: 19871 RVA: 0x00201F04 File Offset: 0x00200104
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OO._O_00O.
		End Function

		' Token: 0x06004DA0 RID: 19872 RVA: 0x00201F0C File Offset: 0x0020010C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO._O_00O. = A_0
		End Sub

		' Token: 0x06004DA1 RID: 19873 RVA: 0x00201F15 File Offset: 0x00200115
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.OO._O_00O.
		End Function

		' Token: 0x06004DA2 RID: 19874 RVA: 0x00201F1D File Offset: 0x0020011D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.OO._O_00O. = A_0
		End Sub

		' Token: 0x06004DA3 RID: 19875 RVA: 0x00201F26 File Offset: 0x00200126
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOO_._.
		End Function

		' Token: 0x06004DA4 RID: 19876 RVA: 0x00201F2E File Offset: 0x0020012E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOO_._. = A_0
		End Sub

		' Token: 0x06004DA5 RID: 19877 RVA: 0x00201F37 File Offset: 0x00200137
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO._O_00O.
		End Function

		' Token: 0x06004DA6 RID: 19878 RVA: 0x00201F40 File Offset: 0x00200140
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_.OOo_.
			Dim oo._O_00O. As C1Button = Me.OO._O_00O.
			If oo._O_00O. IsNot Nothing Then
				RemoveHandler oo._O_00O..Click, value
			End If
			Me.OO._O_00O. = A_0
			oo._O_00O. = Me.OO._O_00O.
			If oo._O_00O. IsNot Nothing Then
				AddHandler oo._O_00O..Click, value
			End If
		End Sub

		' Token: 0x06004DA7 RID: 19879 RVA: 0x00201F83 File Offset: 0x00200183
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO0.O0_.().Checked Then
				MyBase.DialogResult = DialogResult.OK
				Return
			End If
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06004DA8 RID: 19880 RVA: 0x00201FA1 File Offset: 0x002001A1
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.User.Type IsNot Nothing Then
				Me.oO0.O0_.().Enabled = False
			End If
		End Sub

		' Token: 0x06004DA9 RID: 19881 RVA: 0x00201FBC File Offset: 0x002001BC
		Friend Sub New(A_0 As String)
			AddHandler MyBase.Load, AddressOf Me.oO0.O0_.
			AddHandler MyBase.FormClosed, AddressOf Me.o._0O_ooOo0__.
			Me.oO0.O0_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oO0.O0_.().Text = Me.oO0.O0_.().Text.Replace("NameValue", A_0)
			Me.oO0.O0_.().Text = Me.oO0.O0_.().Text.Replace("NameValue", A_0)
		End Sub

		' Token: 0x06004DAA RID: 19882 RVA: 0x00202050 File Offset: 0x00200250
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400201A RID: 8218
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400201B RID: 8219
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400201C RID: 8220
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400201D RID: 8221
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400201E RID: 8222
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
