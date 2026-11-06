Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000DA RID: 218
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class o\u3000\u3000
		Inherits Form

		' Token: 0x06000C44 RID: 3140 RVA: 0x0005934B File Offset: 0x0005754B
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.oo0OO.0O0_0. IsNot Nothing Then
				Me.oo0OO.0O0_0..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06000C45 RID: 3141 RVA: 0x0005936C File Offset: 0x0005756C
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.OO_O.O_00.(New C1TextBox())
			Me.oO__o0.____O.(New C1Button())
			Me.OO_O.O_00.(New C1Button())
			Me.OO_O.O_00.(New Label())
			MyBase.SuspendLayout()
			Me.o_.o___o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.o_.o___o.().Location = New Point(12, 77)
			Me.o_.o___o.().Name = "TextBox1"
			Me.o_.o___o.().Size = New Size(399, 21)
			Me.o_.o___o.().TabIndex = 1
			Me.o_.o___o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.o_.o___o.().Location = New Point(336, 13)
			Me.o_.o___o.().Name = "btnAccept"
			Me.o_.o___o.().Size = New Size(75, 23)
			Me.o_.o___o.().TabIndex = 2
			Me.o_.o___o.().Text = "确定"
			Me.o_.o___o.().UseVisualStyleBackColor = True
			Me.O_Oo.oo_O__.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O_Oo.oo_O__.().DialogResult = DialogResult.Cancel
			Me.O_Oo.oo_O__.().Location = New Point(336, 42)
			Me.O_Oo.oo_O__.().Name = "btnCancel"
			Me.O_Oo.oo_O__.().Size = New Size(75, 23)
			Me.O_Oo.oo_O__.().TabIndex = 3
			Me.O_Oo.oo_O__.().Text = "取消"
			Me.O_Oo.oo_O__.().UseVisualStyleBackColor = True
			Me.o_.o___o.().AutoSize = True
			Me.o_.o___o.().Location = New Point(12, 23)
			Me.o_.o___o.().Name = "Label1"
			Me.o_.o___o.().Size = New Size(41, 12)
			Me.o_.o___o.().TabIndex = 4
			Me.o_.o___o.().Text = "Label1"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.O_Oo.oo_O__.()
			MyBase.ClientSize = New Size(424, 110)
			MyBase.Controls.Add(Me.o_.o___o.())
			MyBase.Controls.Add(Me.O_Oo.oo_O__.())
			MyBase.Controls.Add(Me.o_.o___o.())
			MyBase.Controls.Add(Me.o_.o___o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Tables"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "frmInputText"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000C46 RID: 3142 RVA: 0x00059608 File Offset: 0x00057808
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO_O.O_00.
		End Function

		' Token: 0x06000C47 RID: 3143 RVA: 0x00059610 File Offset: 0x00057810
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_.o___o.
			Dim oo_O.O_00. As C1Button = Me.OO_O.O_00.
			If oo_O.O_00. IsNot Nothing Then
				RemoveHandler oo_O.O_00..Click, value
			End If
			Me.OO_O.O_00. = A_0
			oo_O.O_00. = Me.OO_O.O_00.
			If oo_O.O_00. IsNot Nothing Then
				AddHandler oo_O.O_00..Click, value
			End If
		End Sub

		' Token: 0x06000C48 RID: 3144 RVA: 0x00059653 File Offset: 0x00057853
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO__o0.____O.
		End Function

		' Token: 0x06000C49 RID: 3145 RVA: 0x0005965B File Offset: 0x0005785B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oO__o0.____O. = A_0
		End Sub

		' Token: 0x06000C4A RID: 3146 RVA: 0x00059664 File Offset: 0x00057864
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.OO_O.O_00.
		End Function

		' Token: 0x06000C4B RID: 3147 RVA: 0x0005966C File Offset: 0x0005786C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO_O.O_00. = A_0
		End Sub

		' Token: 0x06000C4C RID: 3148 RVA: 0x00059675 File Offset: 0x00057875
		<CompilerGenerated()>
		Public Overridable Overloads Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oo0OO.0O0_0.
		End Function

		' Token: 0x06000C4D RID: 3149 RVA: 0x0005967D File Offset: 0x0005787D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oo0OO.0O0_0. = A_0
		End Sub

		' Token: 0x06000C4E RID: 3150 RVA: 0x00059688 File Offset: 0x00057888
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000.ooOOO_O_Oo_0)
			Dim ooOOO_O_Oo_ As o\u3000\u3000.ooOOO_O_Oo_0 = Me.oo0OO.0O0_0.
			Dim ooOOO_O_Oo_2 As o\u3000\u3000.ooOOO_O_Oo_0
			Do
				ooOOO_O_Oo_2 = ooOOO_O_Oo_
				Dim value As o\u3000\u3000.ooOOO_O_Oo_0 = CType([Delegate].Combine(ooOOO_O_Oo_2, A_0), o\u3000\u3000.ooOOO_O_Oo_0)
				ooOOO_O_Oo_ = Interlocked.CompareExchange(Of o\u3000\u3000.ooOOO_O_Oo_0)(Me.oo0OO.0O0_0., value, ooOOO_O_Oo_2)
			Loop While ooOOO_O_Oo_ IsNot ooOOO_O_Oo_2
		End Sub

		' Token: 0x06000C4F RID: 3151 RVA: 0x000596C0 File Offset: 0x000578C0
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000.ooOOO_O_Oo_0)
			Dim ooOOO_O_Oo_ As o\u3000\u3000.ooOOO_O_Oo_0 = Me.oo0OO.0O0_0.
			Dim ooOOO_O_Oo_2 As o\u3000\u3000.ooOOO_O_Oo_0
			Do
				ooOOO_O_Oo_2 = ooOOO_O_Oo_
				Dim value As o\u3000\u3000.ooOOO_O_Oo_0 = CType([Delegate].Remove(ooOOO_O_Oo_2, A_0), o\u3000\u3000.ooOOO_O_Oo_0)
				ooOOO_O_Oo_ = Interlocked.CompareExchange(Of o\u3000\u3000.ooOOO_O_Oo_0)(Me.oo0OO.0O0_0., value, ooOOO_O_Oo_2)
			Loop While ooOOO_O_Oo_ IsNot ooOOO_O_Oo_2
		End Sub

		' Token: 0x06000C50 RID: 3152 RVA: 0x000596F8 File Offset: 0x000578F8
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.o_.o___o.
			Me.o_.o___o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.Text = A_0
			Me.o_.o___o.().Text = A_1
			Me.o_.o___o.().Value = A_2
			Me.OO_O.O_00. = A_2
		End Sub

		' Token: 0x06000C51 RID: 3153 RVA: 0x00059760 File Offset: 0x00057960
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim validateInputTextEventArgs As ValidateInputTextEventArgs = New ValidateInputTextEventArgs(Me, Me.o_.o___o.().Text.Trim(), Me.o_.o___o.())
			validateInputTextEventArgs.parentNode = Me.oo0OO.0O0_0.
			Dim ooOOO_O_Oo_ As o\u3000\u3000.ooOOO_O_Oo_0 = Me.oo0OO.0O0_0.
			If ooOOO_O_Oo_ IsNot Nothing Then
				ooOOO_O_Oo_(Me, validateInputTextEventArgs)
			End If
			If validateInputTextEventArgs.Cancel Then
				Me.o_.o___o.().Focus()
				Return
			End If
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06000C52 RID: 3154 RVA: 0x000597C4 File Offset: 0x000579C4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x06000C53 RID: 3155 RVA: 0x000597D6 File Offset: 0x000579D6
		Public Overloads Function <<EMPTY_NAME>>() As String
			Return Me.OO_O.O_00.
		End Function

		' Token: 0x1700020C RID: 524
		' (get) Token: 0x06000C54 RID: 3156 RVA: 0x000597DE File Offset: 0x000579DE
		' (set) Token: 0x06000C55 RID: 3157 RVA: 0x000597EB File Offset: 0x000579EB
		Public Property Value As String
			Get
				Return Me.o_.o___o.().Text
			End Get
			Set(value As String)
				Me.o_.o___o.().Value = Me.Text
			End Set
		End Property

		' Token: 0x040004B5 RID: 1205
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040004B6 RID: 1206
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004B7 RID: 1207
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040004B8 RID: 1208
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040004B9 RID: 1209
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040004BA RID: 1210
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As o\u3000\u3000.ooOOO_O_Oo_0

		' Token: 0x040004BB RID: 1211
		Private <<EMPTY_NAME>> As String

		' Token: 0x040004BC RID: 1212
		Friend <<EMPTY_NAME>> As TreeNode

		' Token: 0x020000DB RID: 219
		' (Invoke) Token: 0x06000C59 RID: 3161
		Public Delegate Sub ooOOO_O_Oo_0(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
	End Class
End Namespace
