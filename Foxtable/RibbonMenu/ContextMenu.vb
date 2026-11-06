Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable.RibbonMenu
	' Token: 0x02000027 RID: 39
	<ComVisible(True)>
	Public Class ContextMenu
		' Token: 0x06000131 RID: 305 RVA: 0x00003A99 File Offset: 0x00001C99
		Public Sub New(A_0 As C1ContextMenu)
			Me.o_o_0oO_.o_o. = New C1ContextMenu()
			Me.o_o_0oO_.o_o. = A_0
		End Sub

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x06000132 RID: 306 RVA: 0x00003AB3 File Offset: 0x00001CB3
		Public ReadOnly Property Name As String
			Get
				Return Me.o_o_0oO_.o_o..Name
			End Get
		End Property

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x06000133 RID: 307 RVA: 0x00003AC0 File Offset: 0x00001CC0
		Friend ReadOnly Property BaseMenu As C1ContextMenu
			Get
				Return Me.o_o_0oO_.o_o.
			End Get
		End Property

		' Token: 0x17000091 RID: 145
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x06000135 RID: 309 RVA: 0x00003AD6 File Offset: 0x00001CD6
		Public ReadOnly Property Items As ContextCommandCollection
			Get
				If Me.o_o_0oO_.o_o. Is Nothing Then
					Me.o_o_0oO_.o_o. = New ContextCommandCollection(Me.o_o_0oO_.o_o..CommandLinks)
				End If
				Return Me.o_o_0oO_.o_o.
			End Get
		End Property

		' Token: 0x06000136 RID: 310 RVA: 0x00003AFC File Offset: 0x00001CFC
		Friend Sub Show(control As System.Windows.Forms.Control, Point As Point)
			Me.o_o_0oO_.o_o..ShowContextMenu(control, Point)
		End Sub

		' Token: 0x06000137 RID: 311 RVA: 0x00003B0B File Offset: 0x00001D0B
		Public Sub Show(control As Foxtable.WinForm.Control, x As Integer, y As Integer)
			Me.o_o_0oO_.o_o..ShowContextMenu(control.BaseControl, New Point(x, y))
		End Sub

		' Token: 0x0400003F RID: 63
		Private <<EMPTY_NAME>> As C1ContextMenu

		' Token: 0x04000040 RID: 64
		Private <<EMPTY_NAME>> As ContextCommandCollection
	End Class
End Namespace
