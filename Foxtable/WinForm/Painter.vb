Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.My

Namespace Foxtable.WinForm
	' Token: 0x0200051A RID: 1306
	<ComVisible(True)>
	<oO0oooo("1481")>
	Public Class Painter
		Inherits Control

		' Token: 0x06005590 RID: 21904 RVA: 0x00221575 File Offset: 0x0021F775
		Friend Sub New(A_0 As O_oo)
			MyBase.New(A_0, ControlTypeEnum.Painter)
			Me.o.oO_oo_O. = A_0
		End Sub

		' Token: 0x17001487 RID: 5255
		' (get) Token: 0x06005591 RID: 21905 RVA: 0x00221587 File Offset: 0x0021F787
		' (set) Token: 0x06005592 RID: 21906 RVA: 0x00221594 File Offset: 0x0021F794
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o.oO_oo_O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o.oO_oo_O..BorderStyle = value
			End Set
		End Property

		' Token: 0x17001488 RID: 5256
		' (get) Token: 0x06005593 RID: 21907 RVA: 0x002215A2 File Offset: 0x0021F7A2
		' (set) Token: 0x06005594 RID: 21908 RVA: 0x002215AF File Offset: 0x0021F7AF
		Public Property AutoScroll As Boolean
			Get
				Return Me.o.oO_oo_O..AutoScroll
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..AutoScroll = value
			End Set
		End Property

		' Token: 0x17001489 RID: 5257
		' (get) Token: 0x06005595 RID: 21909 RVA: 0x002215BD File Offset: 0x0021F7BD
		' (set) Token: 0x06005596 RID: 21910 RVA: 0x002215CA File Offset: 0x0021F7CA
		Public Property ExtendSize As Size
			Get
				Return Me.o.oO_oo_O..AutoScrollMinSize
			End Get
			Set(value As Size)
				Me.o.oO_oo_O..AutoScrollMinSize = value
			End Set
		End Property

		' Token: 0x1700148A RID: 5258
		' (get) Token: 0x06005597 RID: 21911 RVA: 0x002215D8 File Offset: 0x0021F7D8
		<oO0oooo("1482")>
		Public ReadOnly Property Graphics As Graphics
			Get
				Dim result As Graphics
				If Me.a IsNot Nothing Then
					result = Me.a
				Else
					If Me.o.oO_oo_O..o.oO00_.() Is Nothing Then
						If Me.o.oO_oo_O..AutoScrollMinSize.IsEmpty Then
							Me.o.oO_oo_O..o.oO00_.(New Bitmap(Me.o.oO_oo_O..ClientSize.Width, Me.o.oO_oo_O..ClientSize.Height))
						Else
							Me.o.oO_oo_O..o.oO00_.(New Bitmap(Me.o.oO_oo_O..AutoScrollMinSize.Width, Me.o.oO_oo_O..AutoScrollMinSize.Height))
						End If
					End If
					Me.a = Graphics.FromImage(Me.o.oO_oo_O..o.oO00_.())
					Me.a.SmoothingMode = SmoothingMode.AntiAlias
					Me.a.TextRenderingHint = TextRenderingHint.AntiAlias
					result = Me.a
				End If
				Return result
			End Get
		End Property

		' Token: 0x06005598 RID: 21912 RVA: 0x002216C2 File Offset: 0x0021F8C2
		Public Sub Repaint()
			Me.o.oO_oo_O..BackgroundImage = Nothing
			If Me.o.oO_oo_O..o.oO00_.() IsNot Nothing Then
				Me.o.oO_oo_O..BackgroundImage = Me.o.oO_oo_O..o.oO00_.()
			End If
		End Sub

		' Token: 0x06005599 RID: 21913 RVA: 0x002216F3 File Offset: 0x0021F8F3
		Public Sub Save(FileName As String)
			If Me.o.oO_oo_O..o.oO00_.() IsNot Nothing Then
				Me.o.oO_oo_O..o.oO00_.().Save(FileName, O_O0OO.OoO_00._.(FileName))
			End If
		End Sub

		' Token: 0x1700148B RID: 5259
		' (get) Token: 0x0600559A RID: 21914 RVA: 0x0022171C File Offset: 0x0021F91C
		Public ReadOnly Property Image As Image
			Get
				Dim result As Image
				If Me.o.oO_oo_O..o.oO00_.() IsNot Nothing Then
					result = Me.o.oO_oo_O..o.oO00_.()
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x0600559B RID: 21915 RVA: 0x00221747 File Offset: 0x0021F947
		Public Sub Copy()
			c.OOOOO.o.().Clipboard.SetImage(Me.Image)
		End Sub

		' Token: 0x0400220A RID: 8714
		Private <<EMPTY_NAME>> As O_oo

		' Token: 0x0400220B RID: 8715
		Private a As Graphics
	End Class
End Namespace
