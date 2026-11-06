Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000020 RID: 32
	<ComVisible(True)>
	<oO0oooo("1094")>
	Public Class Qat
		Inherits RibbonItem

		' Token: 0x0600010E RID: 270 RVA: 0x0000372F File Offset: 0x0000192F
		Friend Sub New(A_0 As RibbonQat)
			MyBase.New(A_0)
			Me.OOo.O_o. = A_0
		End Sub

		' Token: 0x1700007B RID: 123
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x06000110 RID: 272 RVA: 0x0000374D File Offset: 0x0000194D
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.OOo.O_o. Is Nothing Then
					Me.OOo.O_o. = New RibbonItemCollection(Me.OOo.O_o..Items)
				End If
				Return Me.OOo.O_o.
			End Get
		End Property

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x06000111 RID: 273 RVA: 0x00003773 File Offset: 0x00001973
		' (set) Token: 0x06000112 RID: 274 RVA: 0x00003780 File Offset: 0x00001980
		Public Property BelowRibbon As Boolean
			Get
				Return Me.OOo.O_o..BelowRibbon
			End Get
			Set(value As Boolean)
				Me.OOo.O_o..BelowRibbon = value
			End Set
		End Property

		' Token: 0x04000030 RID: 48
		Private <<EMPTY_NAME>> As RibbonQat

		' Token: 0x04000031 RID: 49
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
