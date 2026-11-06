Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200006B RID: 107
	Friend Partial Class oOo_O_0O
		Inherits Form

		' Token: 0x06000397 RID: 919 RVA: 0x0000C13F File Offset: 0x0000A33F
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O0o.0O.
			AddHandler MyBase.FormClosing, AddressOf Me.O0o.0O.
			MyBase.ShowInTaskbar = False
			MyBase.TopMost = True
		End Sub

		' Token: 0x06000398 RID: 920
		Private Declare Function AnimateWindow Lib "user32" (A_0 As IntPtr, A_1 As Integer, A_2 As Integer) As Boolean

		' Token: 0x06000399 RID: 921 RVA: 0x0000C17C File Offset: 0x0000A37C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Right - MyBase.Width
			Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Bottom - MyBase.Height
			MyBase.Location = New Point(x, y)
			oOo_O_0O.AnimateWindow(MyBase.Handle, 1000, 393224)
		End Sub

		' Token: 0x0600039A RID: 922 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
		End Sub

		' Token: 0x040000BD RID: 189
		Private Const <<EMPTY_NAME>> As Integer = 1

		' Token: 0x040000BE RID: 190
		Private Const <<EMPTY_NAME>> As Integer = 2

		' Token: 0x040000BF RID: 191
		Private Const <<EMPTY_NAME>> As Integer = 4

		' Token: 0x040000C0 RID: 192
		Private Const <<EMPTY_NAME>> As Integer = 8

		' Token: 0x040000C1 RID: 193
		Private Const <<EMPTY_NAME>> As Integer = 16

		' Token: 0x040000C2 RID: 194
		Private Const <<EMPTY_NAME>> As Integer = 65536

		' Token: 0x040000C3 RID: 195
		Private Const <<EMPTY_NAME>> As Integer = 131072

		' Token: 0x040000C4 RID: 196
		Private Const <<EMPTY_NAME>> As Integer = 262144

		' Token: 0x040000C5 RID: 197
		Private Const <<EMPTY_NAME>> As Integer = 524288
	End Class
End Namespace
