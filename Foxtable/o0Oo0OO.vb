Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000395 RID: 917
	<DesignerGenerated()>
	Friend Class o0Oo0OO
		Inherits UserControl

		' Token: 0x06003AA0 RID: 15008 RVA: 0x00196834 File Offset: 0x00194A34
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.O0___oo._0O00. IsNot Nothing Then
					Me.O0___oo._0O00..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06003AA1 RID: 15009 RVA: 0x00196874 File Offset: 0x00194A74
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O0___oo._0O00. = New Container()
			MyBase.AutoScaleMode = AutoScaleMode.Font
		End Sub

		' Token: 0x06003AA2 RID: 15010 RVA: 0x00196888 File Offset: 0x00194A88
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString("绘图板", Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x06003AA3 RID: 15011 RVA: 0x001968EE File Offset: 0x00194AEE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x06003AA4 RID: 15012 RVA: 0x001968F6 File Offset: 0x00194AF6
		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.o00.Oo_OO0.
			Me.o00.Oo_OO0.()
			Me.BackColor = Color.White
		End Sub

		' Token: 0x04001830 RID: 6192
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
