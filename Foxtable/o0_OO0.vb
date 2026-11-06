Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000398 RID: 920
	Friend Class o0_OO0
		Inherits Panel
		Implements O0_0_0_0_

		' Token: 0x06003AB2 RID: 15026 RVA: 0x00196A80 File Offset: 0x00194C80
		Public Sub New()
			Me.Dock = DockStyle.Fill
			Me.BackColor = Color.Transparent
			MyBase.ResizeRedraw = True
		End Sub

		' Token: 0x06003AB3 RID: 15027 RVA: 0x00196AA4 File Offset: 0x00194CA4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			MyBase.OnPaint(e)
			If CType(MyBase.Parent.Parent, o0000O).BorderStyle = BorderStyle.None Then
				Dim graphics As Graphics = e.Graphics
				Dim pen As Pen = New Pen(SystemColors.ControlDark)
				Dim rect As Rectangle = New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1)
				pen.DashStyle = DashStyle.Dash
				graphics.DrawRectangle(pen, rect)
				graphics.Dispose()
			End If
		End Sub

		' Token: 0x06003AB4 RID: 15028 RVA: 0x00196B0D File Offset: 0x00194D0D
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			MyBase.Invalidate()
		End Sub

		' Token: 0x06003AB5 RID: 15029 RVA: 0x00196B1C File Offset: 0x00194D1C
		Public Function <<EMPTY_NAME>>() As Integer Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			Return Me.o__O0_.o_.
		End Function

		' Token: 0x06003AB6 RID: 15030 RVA: 0x00196B24 File Offset: 0x00194D24
		Public Sub <<EMPTY_NAME>>(A_0 As Integer) Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			Me.o__O0_.o_. = A_0
		End Sub

		' Token: 0x06003AB7 RID: 15031 RVA: 0x00196B2D File Offset: 0x00194D2D
		Public Function <<EMPTY_NAME>>() As Integer Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			Return Me.oo0oo__0o.O.
		End Function

		' Token: 0x06003AB8 RID: 15032 RVA: 0x00196B35 File Offset: 0x00194D35
		Public Sub <<EMPTY_NAME>>(A_0 As Integer) Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			Me.oo0oo__0o.O. = A_0
		End Sub

		' Token: 0x06003AB9 RID: 15033 RVA: 0x00196B3E File Offset: 0x00194D3E
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			oOO0oo_o0.O00OO_O_oO_.o.(Me, MyBase.Controls)
		End Sub

		' Token: 0x06003ABA RID: 15034 RVA: 0x00196B4C File Offset: 0x00194D4C
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			oOO0oo_o0.O._0O0__o.(MyBase.Controls)
		End Sub

		' Token: 0x04001835 RID: 6197
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001836 RID: 6198
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
