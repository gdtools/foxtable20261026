Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003CF RID: 975
	<DesignerGenerated()>
	Friend Class O_oo
		Inherits UserControl

		' Token: 0x06003E5C RID: 15964 RVA: 0x001AFEF8 File Offset: 0x001AE0F8
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.o.oO00_. IsNot Nothing Then
					Me.o.oO00_..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06003E5D RID: 15965 RVA: 0x001AFF38 File Offset: 0x001AE138
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.oO00_. = New Container()
			MyBase.AutoScaleMode = AutoScaleMode.Font
		End Sub

		' Token: 0x06003E5E RID: 15966 RVA: 0x001AFF4C File Offset: 0x001AE14C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			If Me.o.oO00_. IsNot Nothing Then
				Me.BackgroundImage = Me.o.oO00_.
			Else
				Me.BackgroundImage = Nothing
			End If
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x06003E5F RID: 15967 RVA: 0x001AFF72 File Offset: 0x001AE172
		Public Function <<EMPTY_NAME>>() As Bitmap
			Return Me.o.oO00_.
		End Function

		' Token: 0x06003E60 RID: 15968 RVA: 0x001AFF7A File Offset: 0x001AE17A
		Public Sub <<EMPTY_NAME>>(A_0 As Bitmap)
			Me.o.oO00_. = A_0
		End Sub

		' Token: 0x06003E61 RID: 15969 RVA: 0x001AFF83 File Offset: 0x001AE183
		Public Sub New()
			AddHandler MyBase.SizeChanged, AddressOf Me.o.oO00_.
			Me.o.oO00_.()
			Me.DoubleBuffered = True
			Me.BackgroundImageLayout = ImageLayout.None
		End Sub

		' Token: 0x06003E62 RID: 15970 RVA: 0x001AFFB4 File Offset: 0x001AE1B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.oO00_. IsNot Nothing Then
				Dim image As Bitmap
				If MyBase.AutoScrollMinSize.IsEmpty Then
					image = New Bitmap(Math.Max(MyBase.ClientSize.Width, 1), Math.Max(1, MyBase.ClientSize.Height))
				Else
					image = New Bitmap(MyBase.AutoScrollMinSize.Width, MyBase.AutoScrollMinSize.Height)
				End If
				Dim graphics As Graphics = Graphics.FromImage(image)
				graphics.DrawImage(Me.o.oO00_., 0, 0)
				graphics.Dispose()
				Me.o.oO00_..Dispose()
				Me.o.oO00_. = image
				Me.BackgroundImage = Me.o.oO00_.
			End If
		End Sub

		' Token: 0x0400194F RID: 6479
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001950 RID: 6480
		Private <<EMPTY_NAME>> As Bitmap
	End Class
End Namespace
