Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002EA RID: 746
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("0662")>
	Public Class BeforeShowContextMenuEventArgs
		' Token: 0x0600275A RID: 10074 RVA: 0x0010ADFC File Offset: 0x00108FFC
		Public Sub New(A_0 As Table, A_1 As HitTypeEnum)
			Me.O.O00. = A_0
			Me.O.O00. = A_1
		End Sub

		' Token: 0x170008DC RID: 2268
		' (get) Token: 0x0600275B RID: 10075 RVA: 0x0010AE12 File Offset: 0x00109012
		Public ReadOnly Property Table As Table
			Get
				Return Me.O.O00.
			End Get
		End Property

		' Token: 0x170008DD RID: 2269
		' (get) Token: 0x0600275C RID: 10076 RVA: 0x0010AE1A File Offset: 0x0010901A
		Public ReadOnly Property HitType As HitTypeEnum
			Get
				Return Me.O.O00.
			End Get
		End Property

		' Token: 0x170008DE RID: 2270
		' (get) Token: 0x0600275D RID: 10077 RVA: 0x0010AE22 File Offset: 0x00109022
		' (set) Token: 0x0600275E RID: 10078 RVA: 0x0010AE2A File Offset: 0x0010902A
		Public Property Cancel As Boolean
			Get
				Return Me.O.O00.
			End Get
			Set(value As Boolean)
				Me.O.O00. = value
			End Set
		End Property

		' Token: 0x170008DF RID: 2271
		' (get) Token: 0x0600275F RID: 10079 RVA: 0x0010AE33 File Offset: 0x00109033
		' (set) Token: 0x06002760 RID: 10080 RVA: 0x0010AE3B File Offset: 0x0010903B
		Public Property ContextMenu As ContextMenu
			Get
				Return Me.O.O00.
			End Get
			Set(value As ContextMenu)
				Me.O.O00. = value
			End Set
		End Property

		' Token: 0x170008E0 RID: 2272
		' (get) Token: 0x06002761 RID: 10081 RVA: 0x0010AE44 File Offset: 0x00109044
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x0400104B RID: 4171
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400104C RID: 4172
		Private <<EMPTY_NAME>> As HitTypeEnum

		' Token: 0x0400104D RID: 4173
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400104E RID: 4174
		Private <<EMPTY_NAME>> As ContextMenu
	End Class
End Namespace
