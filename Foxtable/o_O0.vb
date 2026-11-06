Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000137 RID: 311
	<DesignerGenerated()>
	Public Class o_O0
		Inherits UserControl

		' Token: 0x06000F18 RID: 3864 RVA: 0x00067B08 File Offset: 0x00065D08
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.O.0O_oo. IsNot Nothing Then
					Me.O.0O_oo..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000F19 RID: 3865 RVA: 0x00067B48 File Offset: 0x00065D48
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O.0O_oo. = New Container()
			MyBase.AutoScaleMode = AutoScaleMode.Font
		End Sub

		' Token: 0x06000F1A RID: 3866 RVA: 0x00067B5C File Offset: 0x00065D5C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString("PDFViewer", Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x06000F1B RID: 3867 RVA: 0x00067BC2 File Offset: 0x00065DC2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000F1C RID: 3868 RVA: 0x00067BCA File Offset: 0x00065DCA
		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.O.0O_oo.
			Me.O.0O_oo.()
			Me.BackColor = Color.White
		End Sub

		' Token: 0x040005D1 RID: 1489
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
