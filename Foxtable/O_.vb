Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000066 RID: 102
	<DesignerGenerated()>
	Friend Partial Class O_\u3000
		Inherits Form

		' Token: 0x06000375 RID: 885 RVA: 0x0000B710 File Offset: 0x00009910
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_o.ooO0oo. IsNot Nothing Then
					Me.O_o.ooO0oo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000376 RID: 886 RVA: 0x0000B750 File Offset: 0x00009950
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O_0._o_O0o.(New C1Button())
			Me.O.__Ooo.(New C1Button())
			Me.O_0._o_O0o.(New C1TextBox())
			Me.O.__Ooo.().BeginInit()
			Me.O_0._o_O0o.().BeginInit()
			Me.O_0._o_O0o.().BeginInit()
			MyBase.SuspendLayout()
			Me.O.__Ooo.().Anchor = AnchorStyles.Bottom
			Me.O.__Ooo.().DialogResult = DialogResult.Cancel
			Me.O.__Ooo.().Location = New Point(267, 251)
			Me.O.__Ooo.().Name = "btnCancel"
			Me.O.__Ooo.().Size = New Size(75, 23)
			Me.O.__Ooo.().TabIndex = 9
			Me.O.__Ooo.().Text = "取消"
			Me.O.__Ooo.().UseVisualStyleBackColor = True
			Me.O_0._o_O0o.().Anchor = AnchorStyles.Bottom
			Me.O_0._o_O0o.().DialogResult = DialogResult.OK
			Me.O_0._o_O0o.().Location = New Point(175, 251)
			Me.O_0._o_O0o.().Name = "btnAccept"
			Me.O_0._o_O0o.().Size = New Size(75, 23)
			Me.O_0._o_O0o.().TabIndex = 8
			Me.O_0._o_O0o.().Text = "确定"
			Me.O_0._o_O0o.().UseVisualStyleBackColor = True
			Me.O_0._o_O0o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_0._o_O0o.().Location = New Point(12, 12)
			Me.O_0._o_O0o.().Multiline = True
			Me.O_0._o_O0o.().Name = "TextBox1"
			Me.O_0._o_O0o.().ScrollBars = ScrollBars.Vertical
			Me.O_0._o_O0o.().Size = New Size(493, 221)
			Me.O_0._o_O0o.().TabIndex = 6
			Me.O_0._o_O0o.().Tag = Nothing
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(517, 288)
			MyBase.Controls.Add(Me.O.__Ooo.())
			MyBase.Controls.Add(Me.O_0._o_O0o.())
			MyBase.Controls.Add(Me.O_0._o_O0o.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "frmTextEditor"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterParent
			Me.Text = "属性"
			Me.O.__Ooo.().EndInit()
			Me.O_0._o_O0o.().EndInit()
			Me.O_0._o_O0o.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06000377 RID: 887 RVA: 0x0000B9E2 File Offset: 0x00009BE2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_o.ooO0oo.
		End Function

		' Token: 0x06000378 RID: 888 RVA: 0x0000B9EA File Offset: 0x00009BEA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O_o.ooO0oo. = A_0
		End Sub

		' Token: 0x06000379 RID: 889 RVA: 0x0000B9F3 File Offset: 0x00009BF3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.__Ooo.
		End Function

		' Token: 0x0600037A RID: 890 RVA: 0x0000B9FB File Offset: 0x00009BFB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O.__Ooo. = A_0
		End Sub

		' Token: 0x0600037B RID: 891 RVA: 0x0000BA04 File Offset: 0x00009C04
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_o.ooO0oo.
		End Function

		' Token: 0x0600037C RID: 892 RVA: 0x0000BA0C File Offset: 0x00009C0C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_o.ooO0oo. = A_0
		End Sub

		' Token: 0x0600037D RID: 893 RVA: 0x0000BA15 File Offset: 0x00009C15
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.O_0._o_O0o.
			Me.O_0._o_O0o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600037E RID: 894 RVA: 0x0000BA4A File Offset: 0x00009C4A
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040000AB RID: 171
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040000AC RID: 172
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040000AD RID: 173
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040000AE RID: 174
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox
	End Class
End Namespace
