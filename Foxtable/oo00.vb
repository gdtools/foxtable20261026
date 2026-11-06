Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000E2 RID: 226
	<DesignerGenerated()>
	Friend Class oo00
		Inherits UserControl

		' Token: 0x06000CB0 RID: 3248 RVA: 0x0005C864 File Offset: 0x0005AA64
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.OOOo_._oO0_O. IsNot Nothing Then
					Me.OOOo_._oO0_O..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000CB1 RID: 3249 RVA: 0x0005C8A4 File Offset: 0x0005AAA4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OOOo_._oO0_O. = New Container()
			MyBase.AutoScaleMode = AutoScaleMode.Font
		End Sub

		' Token: 0x06000CB2 RID: 3250 RVA: 0x0005C8B8 File Offset: 0x0005AAB8
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString("WebViewer", Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x06000CB3 RID: 3251 RVA: 0x0005C91E File Offset: 0x0005AB1E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000CB4 RID: 3252 RVA: 0x0005C926 File Offset: 0x0005AB26
		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.OOOo_._oO0_O.
			Me.OOOo_._oO0_O.()
			Me.BackColor = Color.White
		End Sub

		' Token: 0x040004DF RID: 1247
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
