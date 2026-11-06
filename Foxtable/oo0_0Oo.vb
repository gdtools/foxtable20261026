Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000396 RID: 918
	Friend Class oo0_0Oo
		Inherits Panel
		Implements O0_0_0_0_

		' Token: 0x06003AA5 RID: 15013 RVA: 0x00196921 File Offset: 0x00194B21
		Public Sub New()
			AddHandler MyBase.MouseMove, AddressOf Me.oO0O0.o.
			AddHandler MyBase.MouseUp, AddressOf Me.O0___oo._0O00.
			MyBase.ResizeRedraw = True
		End Sub

		' Token: 0x06003AA6 RID: 15014 RVA: 0x00196954 File Offset: 0x00194B54
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			MyBase.OnPaint(e)
			If MyBase.BorderStyle = BorderStyle.None Then
				Dim graphics As Graphics = e.Graphics
				Dim pen As Pen = New Pen(SystemColors.ControlDark)
				Dim rect As Rectangle = New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1)
				pen.DashStyle = DashStyle.Dash
				graphics.DrawRectangle(pen, rect)
				graphics.Dispose()
			End If
		End Sub

		' Token: 0x06003AA7 RID: 15015 RVA: 0x001969AE File Offset: 0x00194BAE
		Public Function <<EMPTY_NAME>>() As Integer Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			Return Me.O0___oo._0O00.
		End Function

		' Token: 0x06003AA8 RID: 15016 RVA: 0x001969B6 File Offset: 0x00194BB6
		Public Sub <<EMPTY_NAME>>(A_0 As Integer) Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			Me.O0___oo._0O00. = A_0
		End Sub

		' Token: 0x06003AA9 RID: 15017 RVA: 0x001969BF File Offset: 0x00194BBF
		Public Function <<EMPTY_NAME>>() As Integer Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			Return Me.oO_._o.
		End Function

		' Token: 0x06003AAA RID: 15018 RVA: 0x001969C7 File Offset: 0x00194BC7
		Public Sub <<EMPTY_NAME>>(A_0 As Integer) Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			Me.oO_._o. = A_0
		End Sub

		' Token: 0x06003AAB RID: 15019 RVA: 0x001969D0 File Offset: 0x00194BD0
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			oOO0oo_o0.O00OO_O_oO_.o.(Me, MyBase.Controls)
		End Sub

		' Token: 0x06003AAC RID: 15020 RVA: 0x001969DE File Offset: 0x00194BDE
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			oOO0oo_o0.O._0O0__o.(MyBase.Controls)
		End Sub

		' Token: 0x06003AAD RID: 15021 RVA: 0x001969EB File Offset: 0x00194BEB
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If A_1.Button = MouseButtons.Left Then
				Me.Refresh()
			End If
		End Sub

		' Token: 0x06003AAE RID: 15022 RVA: 0x00196A00 File Offset: 0x00194C00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.Refresh()
		End Sub

		' Token: 0x04001831 RID: 6193
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001832 RID: 6194
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
