Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000019 RID: 25
	<ComVisible(True)>
	Public Class FontComboBox
		Inherits RibbonItem

		' Token: 0x060000BA RID: 186 RVA: 0x00003144 File Offset: 0x00001344
		Friend Sub New(A_0 As RibbonFontComboBox)
			MyBase.New(A_0)
			Me.o_.o0_o. = A_0
		End Sub

		' Token: 0x060000BB RID: 187 RVA: 0x00003154 File Offset: 0x00001354
		Public Sub New(A_0 As String)
			Me.o_.o0_o. = New RibbonFontComboBox()
			Me.oOo_.0o_O_O_0. = Me.o_.o0_o.
			Me.o_.o0_o..ID = A_0
		End Sub

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000BC RID: 188 RVA: 0x0000317F File Offset: 0x0000137F
		' (set) Token: 0x060000BD RID: 189 RVA: 0x0000318C File Offset: 0x0000138C
		Public Property Text As String
			Get
				Return Me.o_.o0_o..Text
			End Get
			Set(value As String)
				Me.o_.o0_o..Text = value
			End Set
		End Property

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000BE RID: 190 RVA: 0x0000319A File Offset: 0x0000139A
		' (set) Token: 0x060000BF RID: 191 RVA: 0x000031A7 File Offset: 0x000013A7
		Public Property Label As String
			Get
				Return Me.o_.o0_o..Label
			End Get
			Set(value As String)
				Me.o_.o0_o..Label = value
			End Set
		End Property

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000C0 RID: 192 RVA: 0x000031B5 File Offset: 0x000013B5
		' (set) Token: 0x060000C1 RID: 193 RVA: 0x000031C2 File Offset: 0x000013C2
		Public Property TextAreaWidth As Integer
			Get
				Return Me.o_.o0_o..TextAreaWidth
			End Get
			Set(value As Integer)
				Me.o_.o0_o..TextAreaWidth = value
			End Set
		End Property

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000C2 RID: 194 RVA: 0x000031D0 File Offset: 0x000013D0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property MenuItems As RibbonItemCollection
			Get
				If Me.o_.o0_o. Is Nothing Then
					Me.o_.o0_o. = New RibbonItemCollection(Me.o_.o0_o..MenuItems)
				End If
				Return Me.o_.o0_o.
			End Get
		End Property

		' Token: 0x04000022 RID: 34
		Friend <<EMPTY_NAME>> As RibbonFontComboBox

		' Token: 0x04000023 RID: 35
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
