Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000452 RID: 1106
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000
		Inherits Form

		' Token: 0x060049C5 RID: 18885 RVA: 0x001F19A0 File Offset: 0x001EFBA0
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo0._. IsNot Nothing Then
					Me.Oo0._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060049C6 RID: 18886 RVA: 0x001F19E0 File Offset: 0x001EFBE0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Oo0._.(New C1Button())
			Me.Oo0._.(New Label())
			MyBase.SuspendLayout()
			Me.Ooo_oo._o.().DialogResult = DialogResult.Cancel
			Me.Ooo_oo._o.().Location = New Point(102, 65)
			Me.Ooo_oo._o.().Name = "Button1"
			Me.Ooo_oo._o.().Size = New Size(75, 23)
			Me.Ooo_oo._o.().TabIndex = 0
			Me.Ooo_oo._o.().Text = "取消"
			Me.Ooo_oo._o.().UseVisualStyleBackColor = True
			Me.Oo0._.().Location = New Point(12, 28)
			Me.Oo0._.().Name = "Label1"
			Me.Oo0._.().Size = New Size(264, 21)
			Me.Oo0._.().TabIndex = 1
			Me.Oo0._.().Text = "打印准备中..."
			Me.Oo0._.().TextAlign = ContentAlignment.MiddleCenter
			MyBase.AcceptButton = Me.Ooo_oo._o.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.Ooo_oo._o.()
			MyBase.ClientSize = New Size(288, 109)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.Oo0._.())
			MyBase.Controls.Add(Me.Ooo_oo._o.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.0....O"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "打印进程"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060049C7 RID: 18887 RVA: 0x001F1B8F File Offset: 0x001EFD8F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo0._.
		End Function

		' Token: 0x060049C8 RID: 18888 RVA: 0x001F1B98 File Offset: 0x001EFD98
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Ooo_oo._o.
			Dim oo0._. As C1Button = Me.Oo0._.
			If oo0._. IsNot Nothing Then
				RemoveHandler oo0._..Click, value
			End If
			Me.Oo0._. = A_0
			oo0._. = Me.Oo0._.
			If oo0._. IsNot Nothing Then
				AddHandler oo0._..Click, value
			End If
		End Sub

		' Token: 0x060049C9 RID: 18889 RVA: 0x001F1BDB File Offset: 0x001EFDDB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo0._.
		End Function

		' Token: 0x060049CA RID: 18890 RVA: 0x001F1BE3 File Offset: 0x001EFDE3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo0._. = A_0
		End Sub

		' Token: 0x060049CB RID: 18891 RVA: 0x001F1BEC File Offset: 0x001EFDEC
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.Ooo_oo._o.
			Me.Oo0._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060049CC RID: 18892 RVA: 0x001F1C21 File Offset: 0x001EFE21
		Public Overloads Function <<EMPTY_NAME>>() As Boolean
			Return Me.Oo0._.
		End Function

		' Token: 0x060049CD RID: 18893 RVA: 0x001F1C29 File Offset: 0x001EFE29
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.Oo0._. = A_0
		End Sub

		' Token: 0x060049CE RID: 18894 RVA: 0x001F1C32 File Offset: 0x001EFE32
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.Oo0._.().Text = A_0
		End Sub

		' Token: 0x060049CF RID: 18895 RVA: 0x001F1C40 File Offset: 0x001EFE40
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Ooo_oo._o.().Enabled = False
			Me.Oo._ooo.(True)
		End Sub

		' Token: 0x060049D0 RID: 18896 RVA: 0x001F1C55 File Offset: 0x001EFE55
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001E3A RID: 7738
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001E3B RID: 7739
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001E3C RID: 7740
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001E3D RID: 7741
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
