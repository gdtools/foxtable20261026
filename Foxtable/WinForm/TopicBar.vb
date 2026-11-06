Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command

Namespace Foxtable.WinForm
	' Token: 0x02000525 RID: 1317
	<ComVisible(True)>
	Public Class TopicBar
		Inherits Control

		' Token: 0x060056D5 RID: 22229 RVA: 0x00223454 File Offset: 0x00221654
		Friend Sub New(A_0 As Oo_)
			MyBase.New(A_0, ControlTypeEnum.TopicBar)
			Me.o.OOoo. = A_0
		End Sub

		' Token: 0x17001522 RID: 5410
		' (get) Token: 0x060056D6 RID: 22230 RVA: 0x00223465 File Offset: 0x00221665
		' (set) Token: 0x060056D7 RID: 22231 RVA: 0x00223468 File Offset: 0x00221668
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Setting As String
			Get
				Return Nothing
			End Get
			Set(value As String)
				oOO0oo_o0.O.ooooo.(Me.o.OOoo., value)
			End Set
		End Property

		' Token: 0x17001523 RID: 5411
		' (get) Token: 0x060056D8 RID: 22232 RVA: 0x00223476 File Offset: 0x00221676
		<oO0oooo("0841")>
		Public ReadOnly Property Pages As TopicPageCollection
			Get
				If Me.a Is Nothing Then
					Me.a = New TopicPageCollection(Me.o.OOoo.)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x17001524 RID: 5412
		' (get) Token: 0x060056D9 RID: 22233 RVA: 0x00223497 File Offset: 0x00221697
		' (set) Token: 0x060056DA RID: 22234 RVA: 0x002234AA File Offset: 0x002216AA
		Public Property Animation As Boolean
			Get
				Return Me.o.OOoo..Animation <> 1
			End Get
			Set(value As Boolean)
				If value Then
					Me.o.OOoo..Animation = 0
					Return
				End If
				Me.o.OOoo..Animation = 1
			End Set
		End Property

		' Token: 0x17001525 RID: 5413
		' (get) Token: 0x060056DB RID: 22235 RVA: 0x002234C8 File Offset: 0x002216C8
		' (set) Token: 0x060056DC RID: 22236 RVA: 0x002234D6 File Offset: 0x002216D6
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x04002230 RID: 8752
		Private <<EMPTY_NAME>> As Oo_

		' Token: 0x04002231 RID: 8753
		Private a As TopicPageCollection
	End Class
End Namespace
