Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000393 RID: 915
	<DesignerGenerated()>
	Friend Class O0___o0_
		Inherits UserControl

		' Token: 0x06003A90 RID: 14992 RVA: 0x0019667A File Offset: 0x0019487A
		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.o0o0O._o0Oo.
			Me.o0o0O._o0Oo.()
		End Sub

		' Token: 0x06003A91 RID: 14993 RVA: 0x0019669C File Offset: 0x0019489C
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

		' Token: 0x06003A92 RID: 14994 RVA: 0x001966DC File Offset: 0x001948DC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			MyBase.SuspendLayout()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.BorderStyle = BorderStyle.Fixed3D
			MyBase.Name = "o.....o0"
			MyBase.Size = New Size(146, 146)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003A93 RID: 14995 RVA: 0x0019673C File Offset: 0x0019493C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString("主表", Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x06003A94 RID: 14996 RVA: 0x001967A2 File Offset: 0x001949A2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x0400182B RID: 6187
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
