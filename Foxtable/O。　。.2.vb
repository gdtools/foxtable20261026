Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000CF RID: 207
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class O\u3002\u3000\u3002
		Inherits Form

		' Token: 0x06000991 RID: 2449 RVA: 0x00042C7C File Offset: 0x00040E7C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo.__0o_0_Oo. IsNot Nothing Then
					Me.Oo.__0o_0_Oo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000992 RID: 2450 RVA: 0x00042CBC File Offset: 0x00040EBC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oOoO._o0.(New Label())
			Me.oOoO._o0.(New C1NumericEdit())
			Me.oOoO._o0.(New C1Button())
			Me.O_o_.O_o_.(New C1Button())
			Me.oOoO._o0.().BeginInit()
			MyBase.SuspendLayout()
			Me.oOoO._o0.().AutoSize = True
			Me.oOoO._o0.().Location = New Point(14, 13)
			Me.oOoO._o0.().Name = "Label1"
			Me.oOoO._o0.().Size = New Size(41, 12)
			Me.oOoO._o0.().TabIndex = 0
			Me.oOoO._o0.().Text = "Label1"
			Me.oOoO._o0.().DataType = GetType(Integer)
			Me.oOoO._o0.().Location = New Point(16, 30)
			Me.oOoO._o0.().Name = "C1NumericEdit1"
			Me.oOoO._o0.().Size = New Size(176, 21)
			Me.oOoO._o0.().TabIndex = 1
			Me.oOoO._o0.().Tag = Nothing
			Me.oOoO._o0.().Value = 2
			Me.oOoO._o0.().VisibleButtons = 1
			Me.O_o000._o_.().Location = New Point(25, 71)
			Me.O_o000._o_.().Name = "Button1"
			Me.O_o000._o_.().Size = New Size(75, 23)
			Me.O_o000._o_.().TabIndex = 2
			Me.O_o000._o_.().Text = "确定"
			Me.O_o000._o_.().UseVisualStyleBackColor = True
			Me.oo_OOoOoo.OO.().DialogResult = DialogResult.Cancel
			Me.oo_OOoOoo.OO.().Location = New Point(106, 71)
			Me.oo_OOoOoo.OO.().Name = "Button2"
			Me.oo_OOoOoo.OO.().Size = New Size(75, 23)
			Me.oo_OOoOoo.OO.().TabIndex = 3
			Me.oo_OOoOoo.OO.().Text = "取消"
			Me.oo_OOoOoo.OO.().UseVisualStyleBackColor = True
			MyBase.AcceptButton = Me.O_o000._o_.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.oo_OOoOoo.OO.()
			MyBase.ClientSize = New Size(206, 106)
			MyBase.Controls.Add(Me.oo_OOoOoo.OO.())
			MyBase.Controls.Add(Me.O_o000._o_.())
			MyBase.Controls.Add(Me.oOoO._o0.())
			MyBase.Controls.Add(Me.oOoO._o0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O...oO0."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterParent
			Me.Text = "frmInputInteger"
			Me.oOoO._o0.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000993 RID: 2451 RVA: 0x00042F92 File Offset: 0x00041192
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo.__0o_0_Oo.
		End Function

		' Token: 0x06000994 RID: 2452 RVA: 0x00042F9A File Offset: 0x0004119A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo.__0o_0_Oo. = A_0
		End Sub

		' Token: 0x06000995 RID: 2453 RVA: 0x00042FA3 File Offset: 0x000411A3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.Oo.__0o_0_Oo.
		End Function

		' Token: 0x06000996 RID: 2454 RVA: 0x00042FAB File Offset: 0x000411AB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.Oo.__0o_0_Oo. = A_0
		End Sub

		' Token: 0x06000997 RID: 2455 RVA: 0x00042FB4 File Offset: 0x000411B4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo.__0o_0_Oo.
		End Function

		' Token: 0x06000998 RID: 2456 RVA: 0x00042FBC File Offset: 0x000411BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo_OOoOoo.OO.
			Dim oo.__0o_0_Oo. As C1Button = Me.Oo.__0o_0_Oo.
			If oo.__0o_0_Oo. IsNot Nothing Then
				RemoveHandler oo.__0o_0_Oo..Click, value
			End If
			Me.Oo.__0o_0_Oo. = A_0
			oo.__0o_0_Oo. = Me.Oo.__0o_0_Oo.
			If oo.__0o_0_Oo. IsNot Nothing Then
				AddHandler oo.__0o_0_Oo..Click, value
			End If
		End Sub

		' Token: 0x06000999 RID: 2457 RVA: 0x00042FFF File Offset: 0x000411FF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_0o0OoOoO._.
		End Function

		' Token: 0x0600099A RID: 2458 RVA: 0x00043007 File Offset: 0x00041207
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo_0o0OoOoO._. = A_0
		End Sub

		' Token: 0x0600099B RID: 2459 RVA: 0x00043010 File Offset: 0x00041210
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.Oo.__0o_0_Oo.
		End Function

		' Token: 0x1700020B RID: 523
		' (get) Token: 0x0600099C RID: 2460 RVA: 0x00043018 File Offset: 0x00041218
		' (set) Token: 0x0600099D RID: 2461 RVA: 0x0004302A File Offset: 0x0004122A
		Public Property Value As Integer
			Get
				Return Conversions.ToInteger(Me.oOoO._o0.().Value)
			End Get
			Set(value As Integer)
				Me.oOoO._o0.().Value = value
			End Set
		End Property

		' Token: 0x0600099E RID: 2462 RVA: 0x00043040 File Offset: 0x00041240
		Public Sub New(A_0 As String, A_1 As String, A_2 As Integer, A_3 As Integer, A_4 As Integer, A_5 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.oo_OOoOoo.OO.
			Me.oOoO._o0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.Text = A_0
			Me.oOoO._o0.().Text = A_1
			Me.O00.__0OOO. = A_4
			Me.Oo_0o0OoOoO._. = A_3
			Me.Oo.__0o_0_Oo. = A_2
			Me.oOoO._o0.().Value = A_2
			Me.Oo.__0o_0_Oo. = A_5
		End Sub

		' Token: 0x0600099F RID: 2463 RVA: 0x000430C3 File Offset: 0x000412C3
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Value < Me.Oo_0o0OoOoO._. OrElse Me.Value > Me.O00.__0OOO. Then
				MessageBox.Show(Me.Oo.__0o_0_Oo., "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x060009A0 RID: 2464 RVA: 0x000430FD File Offset: 0x000412FD
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400036F RID: 879
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000370 RID: 880
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000371 RID: 881
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x04000372 RID: 882
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000373 RID: 883
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000374 RID: 884
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000375 RID: 885
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000376 RID: 886
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000377 RID: 887
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
