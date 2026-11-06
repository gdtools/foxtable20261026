Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000390 RID: 912
	<DesignerGenerated()>
	Friend Class OO___O_
		Inherits UserControl

		' Token: 0x06003A79 RID: 14969 RVA: 0x00196462 File Offset: 0x00194662
		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.o__.OOO_0Oo.
			Me.o__.OOO_0Oo.()
		End Sub

		' Token: 0x06003A7A RID: 14970 RVA: 0x00196484 File Offset: 0x00194684
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.o__.OOO_0Oo. IsNot Nothing Then
					Me.o__.OOO_0Oo..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06003A7B RID: 14971 RVA: 0x001964C4 File Offset: 0x001946C4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			MyBase.SuspendLayout()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.BorderStyle = BorderStyle.FixedSingle
			MyBase.Name = "O......."
			MyBase.Size = New Size(148, 148)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003A7C RID: 14972 RVA: 0x00196524 File Offset: 0x00194724
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString("图表", Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x06003A7D RID: 14973 RVA: 0x0019658A File Offset: 0x0019478A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x04001825 RID: 6181
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
