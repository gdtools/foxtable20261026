Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000399 RID: 921
	<DesignerGenerated()>
	Friend Class oOo__OO_
		Inherits UserControl

		' Token: 0x06003ABB RID: 15035 RVA: 0x00196B59 File Offset: 0x00194D59
		Public Sub New()
			Me.ooO.Oo000_.()
		End Sub

		' Token: 0x06003ABC RID: 15036 RVA: 0x00196B68 File Offset: 0x00194D68
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.ooO.Oo000_. IsNot Nothing Then
					Me.ooO.Oo000_..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06003ABD RID: 15037 RVA: 0x00196BA8 File Offset: 0x00194DA8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			MyBase.SuspendLayout()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.BorderStyle = BorderStyle.Fixed3D
			MyBase.Name = "o..OO..o"
			MyBase.Size = New Size(197, 145)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003ABE RID: 15038 RVA: 0x00196C05 File Offset: 0x00194E05
		Public Function <<EMPTY_NAME>>() As String
			Return Me.ooO.Oo000_.
		End Function

		' Token: 0x06003ABF RID: 15039 RVA: 0x00196C0D File Offset: 0x00194E0D
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.ooO.Oo000_. = A_0
			MyBase.Invalidate()
		End Sub

		' Token: 0x06003AC0 RID: 15040 RVA: 0x00196C1C File Offset: 0x00194E1C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim stringFormat As StringFormat = New StringFormat()
			Dim s As String
			If Operators.CompareString(Me.ooO.Oo000_.(), "", True) = 0 Then
				s = "表"
			Else
				s = "表(" + Me.ooO.Oo000_.() + ")"
			End If
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString(s, Me.Font, Brushes.Black, CSng((MyBase.ClientSize.Width / 2)), CSng((MyBase.ClientSize.Height / 2)), stringFormat)
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x04001837 RID: 6199
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001838 RID: 6200
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
