Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000018 RID: 24
	<ComVisible(True)>
	Public Class ColorPicker
		Inherits RibbonItem

		' Token: 0x060000B4 RID: 180 RVA: 0x000030D3 File Offset: 0x000012D3
		Friend Sub New(A_0 As RibbonColorPicker)
			MyBase.New(A_0)
			Me.oOoOoOoO._o0. = A_0
		End Sub

		' Token: 0x060000B5 RID: 181 RVA: 0x000030E3 File Offset: 0x000012E3
		Public Sub New(A_0 As String)
			Me.oOoOoOoO._o0. = New RibbonColorPicker()
			Me.oOo_.0o_O_O_0. = Me.oOoOoOoO._o0.
			Me.oOoOoOoO._o0..ID = A_0
		End Sub

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000B6 RID: 182 RVA: 0x0000310E File Offset: 0x0000130E
		' (set) Token: 0x060000B7 RID: 183 RVA: 0x0000311B File Offset: 0x0000131B
		Public Property Text As String
			Get
				Return Me.oOoOoOoO._o0..Text
			End Get
			Set(value As String)
				Me.oOoOoOoO._o0..Text = value
			End Set
		End Property

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000B8 RID: 184 RVA: 0x00003129 File Offset: 0x00001329
		' (set) Token: 0x060000B9 RID: 185 RVA: 0x00003136 File Offset: 0x00001336
		Public Property Color As Color
			Get
				Return Me.oOoOoOoO._o0..Color
			End Get
			Set(value As Color)
				Me.oOoOoOoO._o0..Color = value
			End Set
		End Property

		' Token: 0x04000021 RID: 33
		Friend <<EMPTY_NAME>> As RibbonColorPicker
	End Class
End Namespace
