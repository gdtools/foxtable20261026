Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports C1.Win.Map

Namespace Foxtable
	' Token: 0x02000158 RID: 344
	<ComVisible(True)>
	Public Class MarkImageShape
		Inherits CustomShape

		' Token: 0x170002F1 RID: 753
		' (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00069132 File Offset: 0x00067332
		' (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0006913A File Offset: 0x0006733A
		Public Property Image As Image

		' Token: 0x06000FC2 RID: 4034 RVA: 0x00069143 File Offset: 0x00067343
		Public Sub New(A_0 As Image)
			Me.Image = A_0
		End Sub

		' Token: 0x06000FC3 RID: 4035 RVA: 0x00069154 File Offset: 0x00067354
		Public Overrides Sub Draw(g As Graphics, bounds As RectangleF, style As Style)
			g.DrawImage(Me.Image, bounds)
			Dim width As Single? = style.Border.Width
			If If((width IsNot Nothing), New Boolean?(width.GetValueOrDefault() > 0F), Nothing).GetValueOrDefault() AndAlso style.Border.Style IsNot Nothing Then
				g.DrawRectangle(New Pen(style.Border.Color) With { .Width = style.Border.Width.Value, .DashStyle = style.Border.Style.Value }, Rectangle.Round(bounds))
			End If
		End Sub

		' Token: 0x04000607 RID: 1543
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Image
	End Class
End Namespace
