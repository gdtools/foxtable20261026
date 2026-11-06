Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200039B RID: 923
	<DesignerGenerated()>
	Friend Class O_O_00
		Inherits UserControl

		' Token: 0x06003AC7 RID: 15047 RVA: 0x0019704C File Offset: 0x0019524C
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.Ooo__.ooO_0. IsNot Nothing Then
					Me.Ooo__.ooO_0..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06003AC8 RID: 15048 RVA: 0x0019708C File Offset: 0x0019528C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Ooo__.ooO_0. = New Container()
			MyBase.AutoScaleMode = AutoScaleMode.Font
		End Sub

		' Token: 0x06003AC9 RID: 15049 RVA: 0x001970A0 File Offset: 0x001952A0
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString("网页浏览器(已过时)", Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x06003ACA RID: 15050 RVA: 0x00197106 File Offset: 0x00195306
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x06003ACB RID: 15051 RVA: 0x0019710E File Offset: 0x0019530E
		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.Ooo__.ooO_0.
			Me.Ooo__.ooO_0.()
			Me.BackColor = Color.White
		End Sub

		' Token: 0x0400183B RID: 6203
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
