Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000016 RID: 22
	<ComVisible(True)>
	Public Class ComboBox
		Inherits RibbonItem

		' Token: 0x0600009F RID: 159 RVA: 0x00002F2C File Offset: 0x0000112C
		Friend Sub New(A_0 As RibbonComboBox)
			MyBase.New(A_0)
			Me.oo0OOOO_._. = A_0
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x00002F3C File Offset: 0x0000113C
		Public Sub New(A_0 As String)
			Me.oo0OOOO_._. = New RibbonComboBox()
			Me.oOo_.0o_O_O_0. = Me.oo0OOOO_._.
			Me.oo0OOOO_._..ID = A_0
		End Sub

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000A1 RID: 161 RVA: 0x00002F67 File Offset: 0x00001167
		' (set) Token: 0x060000A2 RID: 162 RVA: 0x00002F74 File Offset: 0x00001174
		Public Property Text As String
			Get
				Return Me.oo0OOOO_._..Text
			End Get
			Set(value As String)
				Me.oo0OOOO_._..Text = value
			End Set
		End Property

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000A3 RID: 163 RVA: 0x00002F82 File Offset: 0x00001182
		' (set) Token: 0x060000A4 RID: 164 RVA: 0x00002F8F File Offset: 0x0000118F
		Public Property Label As String
			Get
				Return Me.oo0OOOO_._..Label
			End Get
			Set(value As String)
				Me.oo0OOOO_._..Label = value
			End Set
		End Property

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000A5 RID: 165 RVA: 0x00002F9D File Offset: 0x0000119D
		' (set) Token: 0x060000A6 RID: 166 RVA: 0x00002FAA File Offset: 0x000011AA
		Public Property TextAreaWidth As Integer
			Get
				Return Me.oo0OOOO_._..TextAreaWidth
			End Get
			Set(value As Integer)
				Me.oo0OOOO_._..TextAreaWidth = value
			End Set
		End Property

		' Token: 0x17000047 RID: 71
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000A8 RID: 168 RVA: 0x00002FC6 File Offset: 0x000011C6
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.oo0OOOO_._. Is Nothing Then
					Me.oo0OOOO_._. = New RibbonItemCollection(Me.oo0OOOO_._..Items)
				End If
				Return Me.oo0OOOO_._.
			End Get
		End Property

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000A9 RID: 169 RVA: 0x00002FEC File Offset: 0x000011EC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property MenuItems As RibbonItemCollection
			Get
				If Me.o0o.oO_. Is Nothing Then
					Me.o0o.oO_. = New RibbonItemCollection(Me.oo0OOOO_._..MenuItems)
				End If
				Return Me.o0o.oO_.
			End Get
		End Property

		' Token: 0x0400001D RID: 29
		Friend <<EMPTY_NAME>> As RibbonComboBox

		' Token: 0x0400001E RID: 30
		Private <<EMPTY_NAME>> As RibbonItemCollection

		' Token: 0x0400001F RID: 31
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
