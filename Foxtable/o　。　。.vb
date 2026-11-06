Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200018F RID: 399
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class o\u3000\u3002\u3000\u3002\u3000
		Inherits Form

		' Token: 0x0600125D RID: 4701 RVA: 0x0006FEBC File Offset: 0x0006E0BC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o00oO__o_.O__. IsNot Nothing Then
					Me.o00oO__o_.O__..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600125E RID: 4702 RVA: 0x0006FEFC File Offset: 0x0006E0FC
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			MyBase.SuspendLayout()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(261, 98)
			MyBase.ControlBox = False
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Name = "Forms"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "文件传输状态"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600125F RID: 4703
		Private Declare Function AnimateWindow Lib "user32" (A_0 As IntPtr, A_1 As Integer, A_2 As Integer) As Boolean

		' Token: 0x06001260 RID: 4704 RVA: 0x0006FF78 File Offset: 0x0006E178
		Friend Sub <<EMPTY_NAME>>(A_0 As Control)
			MyBase.SuspendLayout()
			A_0.Width = MyBase.ClientSize.Width
			A_0.Height = 96
			A_0.Top = MyBase.Controls.Count * 96
			A_0.Left = 0
			MyBase.Controls.Add(A_0)
			If MyBase.Controls.Count > 1 Then
				MyBase.Height += 96
				MyBase.Top -= 96
			End If
			MyBase.ResumeLayout()
		End Sub

		' Token: 0x06001261 RID: 4705 RVA: 0x00070000 File Offset: 0x0006E200
		Friend Overloads Sub <<EMPTY_NAME>>(A_0 As Control)
			Dim top As Integer = A_0.Top
			MyBase.Controls.Remove(A_0)
			If MyBase.Controls.Count > 0 Then
				MyBase.SuspendLayout()
				Try
					For Each obj As Object In MyBase.Controls
						Dim control As Control = CType(obj, Control)
						If control.Top > top Then
							control.Top -= 96
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				MyBase.Height -= 96
				MyBase.Top += 96
				MyBase.ResumeLayout()
				Return
			End If
			MyBase.Close()
			Me.o00oO__o_.O__..ooOooo.oO. = Nothing
		End Sub

		' Token: 0x06001262 RID: 4706 RVA: 0x000700CC File Offset: 0x0006E2CC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Right - MyBase.Width
			Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Bottom - MyBase.Height
			MyBase.Location = New Point(x, y)
			o\u3000\u3002\u3000\u3002\u3000.AnimateWindow(MyBase.Handle, 300, 393224)
		End Sub

		' Token: 0x06001263 RID: 4707 RVA: 0x00070130 File Offset: 0x0006E330
		Public Sub New(A_0 As IMClient)
			AddHandler MyBase.Load, AddressOf Me.oOOOO.O.
			Me.oOOOO.O.()
			Me.o00oO__o_.O__. = A_0
			MyBase.TopMost = True
		End Sub

		' Token: 0x0400073E RID: 1854
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400073F RID: 1855
		Private Const <<EMPTY_NAME>> As Integer = 1

		' Token: 0x04000740 RID: 1856
		Private Const <<EMPTY_NAME>> As Integer = 2

		' Token: 0x04000741 RID: 1857
		Private Const <<EMPTY_NAME>> As Integer = 4

		' Token: 0x04000742 RID: 1858
		Private Const <<EMPTY_NAME>> As Integer = 8

		' Token: 0x04000743 RID: 1859
		Private Const <<EMPTY_NAME>> As Integer = 16

		' Token: 0x04000744 RID: 1860
		Private Const <<EMPTY_NAME>> As Integer = 65536

		' Token: 0x04000745 RID: 1861
		Private Const <<EMPTY_NAME>> As Integer = 131072

		' Token: 0x04000746 RID: 1862
		Private Const <<EMPTY_NAME>> As Integer = 262144

		' Token: 0x04000747 RID: 1863
		Private Const <<EMPTY_NAME>> As Integer = 524288

		' Token: 0x04000748 RID: 1864
		Private <<EMPTY_NAME>> As IMClient
	End Class
End Namespace
