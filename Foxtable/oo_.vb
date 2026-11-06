Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000089 RID: 137
	Public Class oo_
		Inherits Panel

		' Token: 0x0600050E RID: 1294 RVA: 0x0001CC7B File Offset: 0x0001AE7B
		Public Sub New()
			MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			MyBase.SetStyle(ControlStyles.Opaque, False)
			Me.BackColor = Color.Transparent
			Me.Dock = DockStyle.Fill
		End Sub

		' Token: 0x0600050F RID: 1295 RVA: 0x0001CCA9 File Offset: 0x0001AEA9
		Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
			If MyBase.FindForm() Is Nothing Then
				MyBase.OnPaintBackground(e)
			End If
		End Sub
	End Class
End Namespace
