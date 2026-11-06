Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000064 RID: 100
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3002\u3000\u3000
		Inherits Form

		' Token: 0x0600035B RID: 859 RVA: 0x0000A7B4 File Offset: 0x000089B4
		<DebuggerNonUserCode()>
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O.Oo0OO. IsNot Nothing Then
					Me.O.Oo0OO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600035C RID: 860 RVA: 0x0000A7F4 File Offset: 0x000089F4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Oo_.o___.(New C1Button())
			Me.o__O_0.o0OOO0.(New C1Button())
			Me.Oo_.o___.(New oO_oO000oo())
			Me.o__O_0.o0OOO0.().BeginInit()
			Me.Oo_.o___.().BeginInit()
			MyBase.SuspendLayout()
			Me.o__O_0.o0OOO0.().Anchor = AnchorStyles.Bottom
			Me.o__O_0.o0OOO0.().DialogResult = DialogResult.Cancel
			Me.o__O_0.o0OOO0.().Location = New Point(259, 244)
			Me.o__O_0.o0OOO0.().Name = "btnCancel"
			Me.o__O_0.o0OOO0.().Size = New Size(75, 24)
			Me.o__O_0.o0OOO0.().TabIndex = 2
			Me.o__O_0.o0OOO0.().Text = "取消"
			Me.o__O_0.o0OOO0.().UseVisualStyleBackColor = True
			Me.Oo_.o___.().Anchor = AnchorStyles.Bottom
			Me.Oo_.o___.().DialogResult = DialogResult.OK
			Me.Oo_.o___.().Location = New Point(167, 244)
			Me.Oo_.o___.().Name = "btnAccept"
			Me.Oo_.o___.().Size = New Size(75, 24)
			Me.Oo_.o___.().TabIndex = 1
			Me.Oo_.o___.().Text = "确定"
			Me.Oo_.o___.().UseVisualStyleBackColor = True
			Me.Oo_.o___.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.Oo_.o___.().Location = New Point(12, 12)
			Me.Oo_.o___.().Name = "txtSQL"
			Me.Oo_.o___.().Size = New Size(477, 214)
			Me.Oo_.o___.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(501, 281)
			MyBase.Controls.Add(Me.Oo_.o___.())
			MyBase.Controls.Add(Me.o__O_0.o0OOO0.())
			MyBase.Controls.Add(Me.Oo_.o___.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.....O0."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterParent
			Me.Text = "属性"
			Me.o__O_0.o0OOO0.().EndInit()
			Me.Oo_.o___.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600035D RID: 861 RVA: 0x0000AA4B File Offset: 0x00008C4B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_.o___.
		End Function

		' Token: 0x0600035E RID: 862 RVA: 0x0000AA53 File Offset: 0x00008C53
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo_.o___. = A_0
		End Sub

		' Token: 0x0600035F RID: 863 RVA: 0x0000AA5C File Offset: 0x00008C5C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o__O_0.o0OOO0.
		End Function

		' Token: 0x06000360 RID: 864 RVA: 0x0000AA64 File Offset: 0x00008C64
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o__O_0.o0OOO0. = A_0
		End Sub

		' Token: 0x06000361 RID: 865 RVA: 0x0000AA6D File Offset: 0x00008C6D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oO_oO000oo
			Return Me.O.Oo0OO.
		End Function

		' Token: 0x06000362 RID: 866 RVA: 0x0000AA75 File Offset: 0x00008C75
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oO_oO000oo)
			Me.O.Oo0OO. = A_0
		End Sub

		' Token: 0x06000363 RID: 867 RVA: 0x0000AA7E File Offset: 0x00008C7E
		Public Sub New()
			AddHandler MyBase.Closed, AddressOf Me.Oo_.o___.
			Me.Oo_.o___.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06000364 RID: 868 RVA: 0x0000AAB3 File Offset: 0x00008CB3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400009E RID: 158
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400009F RID: 159
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040000A0 RID: 160
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040000A1 RID: 161
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oO_oO000oo
	End Class
End Namespace
