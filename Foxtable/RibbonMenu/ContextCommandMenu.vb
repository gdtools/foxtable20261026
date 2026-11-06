Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command

Namespace Foxtable.RibbonMenu
	' Token: 0x02000029 RID: 41
	<ComVisible(True)>
	Public Class ContextCommandMenu
		Inherits ContextCommand

		' Token: 0x0600014B RID: 331 RVA: 0x00003C54 File Offset: 0x00001E54
		Public Sub New(A_0 As C1CommandMenu)
			MyBase.New(A_0)
			Me.o_o_0oO_.o_o. = A_0
		End Sub

		' Token: 0x0600014C RID: 332 RVA: 0x00003C64 File Offset: 0x00001E64
		Public Sub New(A_0 As C1CommandLink)
			MyBase.New(A_0)
			Me.o_o_0oO_.o_o. = CType(A_0.Command, C1CommandMenu)
		End Sub

		' Token: 0x1700009C RID: 156
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x0600014E RID: 334 RVA: 0x00003C8C File Offset: 0x00001E8C
		Public ReadOnly Property Items As ContextCommandCollection
			Get
				If Me.o_o_0oO_.o_o. Is Nothing Then
					Me.o_o_0oO_.o_o. = New ContextCommandCollection(Me.o_o_0oO_.o_o..CommandLinks)
				End If
				Return Me.o_o_0oO_.o_o.
			End Get
		End Property

		' Token: 0x04000043 RID: 67
		Private <<EMPTY_NAME>> As ContextCommandCollection

		' Token: 0x04000044 RID: 68
		Private <<EMPTY_NAME>> As C1CommandMenu
	End Class
End Namespace
