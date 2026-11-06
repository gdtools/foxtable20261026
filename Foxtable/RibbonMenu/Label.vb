Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000011 RID: 17
	<ComVisible(True)>
	Public Class Label
		Inherits RibbonItem

		' Token: 0x06000080 RID: 128 RVA: 0x00002C73 File Offset: 0x00000E73
		Friend Sub New(A_0 As RibbonLabel)
			MyBase.New(A_0)
			Me.OOo.O_o. = A_0
		End Sub

		' Token: 0x06000081 RID: 129 RVA: 0x00002C83 File Offset: 0x00000E83
		Public Sub New(A_0 As String)
			Me.OOo.O_o. = New RibbonLabel()
			Me.oOo_.0o_O_O_0. = Me.OOo.O_o.
			Me.OOo.O_o..ID = A_0
		End Sub

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x06000082 RID: 130 RVA: 0x00002CAE File Offset: 0x00000EAE
		' (set) Token: 0x06000083 RID: 131 RVA: 0x00002CBB File Offset: 0x00000EBB
		Public Property Text As String
			Get
				Return Me.OOo.O_o..Text
			End Get
			Set(value As String)
				Me.OOo.O_o..Text = value
			End Set
		End Property

		' Token: 0x04000016 RID: 22
		Friend <<EMPTY_NAME>> As RibbonLabel
	End Class
End Namespace
