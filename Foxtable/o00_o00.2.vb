Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000198 RID: 408
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o00_o00
		Inherits UserControl

		' Token: 0x06001377 RID: 4983 RVA: 0x0007EBA0 File Offset: 0x0007CDA0
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.o0o0O._o0Oo. IsNot Nothing Then
					Me.o0o0O._o0Oo..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06001378 RID: 4984 RVA: 0x0007EBE0 File Offset: 0x0007CDE0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0o0O._o0Oo. = New Container()
			MyBase.AutoScaleMode = AutoScaleMode.Font
		End Sub

		' Token: 0x06001379 RID: 4985 RVA: 0x0007EBF4 File Offset: 0x0007CDF4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString("ListView", Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x0600137A RID: 4986 RVA: 0x0007EC5A File Offset: 0x0007CE5A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600137B RID: 4987 RVA: 0x0007EC62 File Offset: 0x0007CE62
		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.O.00_Oo.
			Me.o0o0O._o0Oo.()
			Me.BackColor = Color.White
		End Sub

		' Token: 0x040007AD RID: 1965
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
