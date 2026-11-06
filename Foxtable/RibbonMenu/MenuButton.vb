Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000015 RID: 21
	<ComVisible(True)>
	Public Class MenuButton
		Inherits RibbonItem

		' Token: 0x06000097 RID: 151 RVA: 0x00002E87 File Offset: 0x00001087
		Friend Sub New(A_0 As RibbonMenu)
			MyBase.New(A_0)
			Me.OOo.O_o. = A_0
		End Sub

		' Token: 0x06000098 RID: 152 RVA: 0x00002E97 File Offset: 0x00001097
		Public Sub New(A_0 As String)
			Me.OOo.O_o. = New RibbonMenu()
			Me.oOo_.0o_O_O_0. = Me.OOo.O_o.
			Me.OOo.O_o..ID = A_0
		End Sub

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x06000099 RID: 153 RVA: 0x00002EC2 File Offset: 0x000010C2
		' (set) Token: 0x0600009A RID: 154 RVA: 0x00002ECF File Offset: 0x000010CF
		Public Property Text As String
			Get
				Return Me.OOo.O_o..Text
			End Get
			Set(value As String)
				Me.OOo.O_o..Text = value
			End Set
		End Property

		' Token: 0x17000041 RID: 65
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x0600009C RID: 156 RVA: 0x00002EEB File Offset: 0x000010EB
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.OOo.O_o. Is Nothing Then
					Me.OOo.O_o. = New RibbonItemCollection(Me.OOo.O_o..Items)
				End If
				Return Me.OOo.O_o.
			End Get
		End Property

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x0600009D RID: 157 RVA: 0x00002F11 File Offset: 0x00001111
		' (set) Token: 0x0600009E RID: 158 RVA: 0x00002F1E File Offset: 0x0000111E
		Public Property ArrowVisible As Boolean
			Get
				Return Me.OOo.O_o..ArrowVisible
			End Get
			Set(value As Boolean)
				Me.OOo.O_o..ArrowVisible = value
			End Set
		End Property

		' Token: 0x0400001B RID: 27
		Friend <<EMPTY_NAME>> As RibbonMenu

		' Token: 0x0400001C RID: 28
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
