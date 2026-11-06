Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200025F RID: 607
	<DesignerGenerated()>
	Friend Class O0O__
		Inherits UserControl

		' Token: 0x06001CD8 RID: 7384 RVA: 0x000B747C File Offset: 0x000B567C
		Public Sub New()
			Me.oo0oO_O.oooO0O.()
		End Sub

		' Token: 0x06001CD9 RID: 7385 RVA: 0x000B748C File Offset: 0x000B568C
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.oo0oO_O.oooO0O. IsNot Nothing Then
					Me.oo0oO_O.oooO0O..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06001CDA RID: 7386 RVA: 0x000B74CC File Offset: 0x000B56CC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			MyBase.SuspendLayout()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.BorderStyle = BorderStyle.Fixed3D
			MyBase.Name = "o...o.O."
			MyBase.Size = New Size(154, 203)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001CDB RID: 7387 RVA: 0x000B7529 File Offset: 0x000B5729
		Public Function <<EMPTY_NAME>>() As String
			Return Me.oo0oO_O.oooO0O.
		End Function

		' Token: 0x06001CDC RID: 7388 RVA: 0x000B7531 File Offset: 0x000B5731
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.oo0oO_O.oooO0O. = A_0
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001CDD RID: 7389 RVA: 0x000B7540 File Offset: 0x000B5740
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			Dim s As String
			If Operators.CompareString(Me.oo0oO_O.oooO0O.(), "", True) = 0 Then
				s = "记录窗口"
			Else
				s = "记录窗口(" + Me.oo0oO_O.oooO0O.() + ")"
			End If
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString(s, Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x04000C22 RID: 3106
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000C23 RID: 3107
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
