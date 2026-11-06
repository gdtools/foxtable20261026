Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020003FE RID: 1022
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CustomNavBarPanelProperty
		' Token: 0x0600426F RID: 17007 RVA: 0x001C0FAA File Offset: 0x001BF1AA
		Friend Sub New(A_0 As oO_0)
			Me.OO_o_O_.o. = A_0
		End Sub

		' Token: 0x17000E8E RID: 3726
		' (get) Token: 0x06004270 RID: 17008 RVA: 0x001C0FB9 File Offset: 0x001BF1B9
		' (set) Token: 0x06004271 RID: 17009 RVA: 0x001C0FC6 File Offset: 0x001BF1C6
		<DefaultValue("")>
		Public Property Name As String
			Get
				Return Me.OO_o_O_.o..Name
			End Get
			Set(value As String)
				Me.OO_o_O_.o..Name = value
			End Set
		End Property

		' Token: 0x17000E8F RID: 3727
		' (get) Token: 0x06004272 RID: 17010 RVA: 0x001C0FD4 File Offset: 0x001BF1D4
		' (set) Token: 0x06004273 RID: 17011 RVA: 0x001C0FE6 File Offset: 0x001BF1E6
		<DefaultValue("")>
		Public Property HeaderText As String
			Get
				Return Me.OO_o_O_.o..Button.PanelHeader
			End Get
			Set(value As String)
				Me.OO_o_O_.o..Button.PanelHeader = value
			End Set
		End Property

		' Token: 0x17000E90 RID: 3728
		' (get) Token: 0x06004274 RID: 17012 RVA: 0x001C0FF9 File Offset: 0x001BF1F9
		' (set) Token: 0x06004275 RID: 17013 RVA: 0x001C100B File Offset: 0x001BF20B
		Public Property ButtonText As String
			Get
				Return Me.OO_o_O_.o..Button.Text
			End Get
			Set(value As String)
				Me.OO_o_O_.o..Button.Text = value
			End Set
		End Property

		' Token: 0x17000E91 RID: 3729
		' (get) Token: 0x06004276 RID: 17014 RVA: 0x001C101E File Offset: 0x001BF21E
		' (set) Token: 0x06004277 RID: 17015 RVA: 0x001C102B File Offset: 0x001BF22B
		Public Property ButtonImageFile As String
			Get
				Return Me.OO_o_O_.o..ImageFile
			End Get
			Set(value As String)
				Me.OO_o_O_.o..ImageFile = value
			End Set
		End Property

		' Token: 0x17000E92 RID: 3730
		' (get) Token: 0x06004278 RID: 17016 RVA: 0x001C1039 File Offset: 0x001BF239
		' (set) Token: 0x06004279 RID: 17017 RVA: 0x001C1046 File Offset: 0x001BF246
		Public Property ButtonSmallImageFile As String
			Get
				Return Me.OO_o_O_.o..oOo_._0__0o_0o.()
			End Get
			Set(value As String)
				Me.OO_o_O_.o..oOo_._0__0o_0o.(value)
			End Set
		End Property

		' Token: 0x04001B39 RID: 6969
		Private <<EMPTY_NAME>> As oO_0
	End Class
End Namespace
