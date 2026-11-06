Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports C1.Win.Map

Namespace Foxtable
	' Token: 0x02000159 RID: 345
	<ComVisible(True)>
	Public Class MarkTextShape
		Inherits CustomShape

		' Token: 0x170002F2 RID: 754
		' (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00069210 File Offset: 0x00067410
		' (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00069218 File Offset: 0x00067418
		Public Property Text As String

		' Token: 0x170002F3 RID: 755
		' (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00069221 File Offset: 0x00067421
		' (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00069229 File Offset: 0x00067429
		Public Property Margin As Integer

		' Token: 0x06000FC8 RID: 4040 RVA: 0x00069232 File Offset: 0x00067432
		Friend Sub New(A_0 As String)
			Me.Margin = 1
			Me.Text = A_0
		End Sub

		' Token: 0x06000FC9 RID: 4041 RVA: 0x00069248 File Offset: 0x00067448
		Friend Sub New(A_0 As String, A_1 As Integer)
			Me.Margin = 1
			Me.Text = A_0
			Me.Margin = A_1
		End Sub

		' Token: 0x06000FCA RID: 4042 RVA: 0x00069268 File Offset: 0x00067468
		Public Overrides Function GetDrawingBounds(g As Graphics, bounds As RectangleF, style As Style) As RectangleF
			Dim sizeF As SizeF = g.MeasureString(Me.Text, style.Font)
			bounds.Height = sizeF.Height + CSng((Me.Margin * 2))
			bounds.Width = sizeF.Width + CSng((Me.Margin * 2))
			Dim width As Single? = style.Border.Width
			If If((width IsNot Nothing), New Boolean?(width.GetValueOrDefault() > 0F), Nothing).GetValueOrDefault() AndAlso style.Border.Style IsNot Nothing Then
				bounds.Width += style.Border.Width.Value * 2F
				bounds.Height += style.Border.Width.Value * 2F
			End If
			bounds.X = bounds.X - bounds.Width / 2F + 5F
			bounds.Y = bounds.Y - bounds.Height / 2F + 5F
			Return bounds
		End Function

		' Token: 0x06000FCB RID: 4043 RVA: 0x000693A0 File Offset: 0x000675A0
		Public Overrides Sub Draw(g As Graphics, bounds As RectangleF, style As Style)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			If style.BackColor.ToArgb() <> 0 Then
				Dim brush As SolidBrush = New SolidBrush(style.BackColor)
				g.FillRectangle(brush, bounds)
			End If
			Dim brush2 As SolidBrush = New SolidBrush(style.ForeColor)
			g.DrawString(Me.Text, style.Font, brush2, bounds, stringFormat)
			Dim width As Single? = style.Border.Width
			If If((width IsNot Nothing), New Boolean?(width.GetValueOrDefault() > 0F), Nothing).GetValueOrDefault() AndAlso style.Border.Style IsNot Nothing Then
				g.DrawRectangle(New Pen(style.Border.Color) With { .Width = style.Border.Width.Value, .DashStyle = style.Border.Style.Value }, Rectangle.Round(bounds))
			End If
		End Sub

		' Token: 0x04000608 RID: 1544
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000609 RID: 1545
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
