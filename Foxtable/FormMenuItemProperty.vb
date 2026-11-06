Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200017D RID: 381
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FormMenuItemProperty
		' Token: 0x060011C8 RID: 4552 RVA: 0x0006E553 File Offset: 0x0006C753
		Public Sub New()
			Me.oO0_o.o. = StripItemTypeEnum.MenuItem
			Me.oO0_o.o. = TextPositionEnum.Right
			Me.ooo_o__OO_.o. = ToolStripItemAlignment.Left
			Me.ooO0.__0_0_. = True
			Me.oO0o00.00_. = True
		End Sub

		' Token: 0x170003B5 RID: 949
		' (get) Token: 0x060011C9 RID: 4553 RVA: 0x0006E57E File Offset: 0x0006C77E
		' (set) Token: 0x060011CA RID: 4554 RVA: 0x0006E586 File Offset: 0x0006C786
		<Browsable(False)>
		Public Property Type As StripItemTypeEnum
			Get
				Return Me.oO0_o.o.
			End Get
			Set(value As StripItemTypeEnum)
				Me.oO0_o.o. = value
			End Set
		End Property

		' Token: 0x170003B6 RID: 950
		' (get) Token: 0x060011CB RID: 4555 RVA: 0x0006E58F File Offset: 0x0006C78F
		' (set) Token: 0x060011CC RID: 4556 RVA: 0x0006E597 File Offset: 0x0006C797
		<O_Oo00Oo000O0(0.0)>
		<Category("属性")>
		<OooO0(True)>
		<DisplayName("类型")>
		Public Property Type2 As StripItemTypeEnum2
			Get
				Return CType(Me.oO0_o.o., StripItemTypeEnum2)
			End Get
			Set(value As StripItemTypeEnum2)
				Me.oO0_o.o. = CType(value, StripItemTypeEnum)
			End Set
		End Property

		' Token: 0x170003B7 RID: 951
		' (get) Token: 0x060011CD RID: 4557 RVA: 0x0006E5A0 File Offset: 0x0006C7A0
		' (set) Token: 0x060011CE RID: 4558 RVA: 0x0006E5A8 File Offset: 0x0006C7A8
		<DisplayName("名称")>
		<Category("属性")>
		<O_Oo00Oo000O0(1.0)>
		Public Property Name As String
			Get
				Return Me.oO0_o.o.
			End Get
			Set(value As String)
				Me.oO0_o.o. = value
			End Set
		End Property

		' Token: 0x170003B8 RID: 952
		' (get) Token: 0x060011CF RID: 4559 RVA: 0x0006E5B1 File Offset: 0x0006C7B1
		' (set) Token: 0x060011D0 RID: 4560 RVA: 0x0006E5B9 File Offset: 0x0006C7B9
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("标题")>
		<Category("属性")>
		Public Property Text As String
			Get
				Return Me.ooO._Oo_OOoO.
			End Get
			Set(value As String)
				Me.ooO._Oo_OOoO. = value
			End Set
		End Property

		' Token: 0x170003B9 RID: 953
		' (get) Token: 0x060011D1 RID: 4561 RVA: 0x0006E5C2 File Offset: 0x0006C7C2
		' (set) Token: 0x060011D2 RID: 4562 RVA: 0x0006E5CA File Offset: 0x0006C7CA
		<Category("属性")>
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("提示")>
		Public Property ToolTipText As String
			Get
				Return Me.oo0.o0_0_.
			End Get
			Set(value As String)
				Me.oo0.o0_0_. = value
			End Set
		End Property

		' Token: 0x170003BA RID: 954
		' (get) Token: 0x060011D3 RID: 4563 RVA: 0x0006E5D3 File Offset: 0x0006C7D3
		' (set) Token: 0x060011D4 RID: 4564 RVA: 0x0006E5DB File Offset: 0x0006C7DB
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Category("属性")>
		<DisplayName("图标")>
		<O_Oo00Oo000O0(3.0)>
		Public Property ImageFile As String
			Get
				Return Me.OO0._o_0_o_OO.
			End Get
			Set(value As String)
				Me.OO0._o_0_o_OO. = value
			End Set
		End Property

		' Token: 0x170003BB RID: 955
		' (get) Token: 0x060011D5 RID: 4565 RVA: 0x0006E5E4 File Offset: 0x0006C7E4
		' (set) Token: 0x060011D6 RID: 4566 RVA: 0x0006E5EC File Offset: 0x0006C7EC
		<DisplayName("勾选")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(4.0)>
		<Category("属性")>
		Public Property Checked As Boolean
			Get
				Return Me.O._0O0__o.
			End Get
			Set(value As Boolean)
				Me.O._0O0__o. = value
			End Set
		End Property

		' Token: 0x170003BC RID: 956
		' (get) Token: 0x060011D7 RID: 4567 RVA: 0x0006E5F5 File Offset: 0x0006C7F5
		' (set) Token: 0x060011D8 RID: 4568 RVA: 0x0006E5FD File Offset: 0x0006C7FD
		<DisplayName("快捷键")>
		<Category("属性")>
		<O_Oo00Oo000O0(4.1)>
		<DefaultValue(False)>
		Public Property ShortcutKeys As Keys
			Get
				Return Me.oO0_o.o.
			End Get
			Set(value As Keys)
				Me.oO0_o.o. = value
			End Set
		End Property

		' Token: 0x170003BD RID: 957
		' (get) Token: 0x060011D9 RID: 4569 RVA: 0x0006E606 File Offset: 0x0006C806
		' (set) Token: 0x060011DA RID: 4570 RVA: 0x0006E60E File Offset: 0x0006C80E
		<Category("属性")>
		<O_Oo00Oo000O0(6.0)>
		<DisplayName("显示标题")>
		<DefaultValue(False)>
		Public Property DisplayText As Boolean
			Get
				Return Me.OO0._o_0_o_OO.
			End Get
			Set(value As Boolean)
				Me.OO0._o_0_o_OO. = value
			End Set
		End Property

		' Token: 0x170003BE RID: 958
		' (get) Token: 0x060011DB RID: 4571 RVA: 0x0006E617 File Offset: 0x0006C817
		' (set) Token: 0x060011DC RID: 4572 RVA: 0x0006E61F File Offset: 0x0006C81F
		<DisplayName("标题位置")>
		<O_Oo00Oo000O0(7.0)>
		<DefaultValue(0)>
		<Category("属性")>
		Public Property TextPosition As TextPositionEnum
			Get
				Return Me.oO0_o.o.
			End Get
			Set(value As TextPositionEnum)
				Me.oO0_o.o. = value
			End Set
		End Property

		' Token: 0x170003BF RID: 959
		' (get) Token: 0x060011DD RID: 4573 RVA: 0x0006E628 File Offset: 0x0006C828
		' (set) Token: 0x060011DE RID: 4574 RVA: 0x0006E630 File Offset: 0x0006C830
		<DefaultValue(False)>
		<DisplayName("列表项目")>
		<Category("属性")>
		<O_Oo00Oo000O0(8.0)>
		Public Property ComboList As String
			Get
				Return Me.o.0Oo_0__oO_O_.
			End Get
			Set(value As String)
				Me.o.0Oo_0__oO_O_. = value
			End Set
		End Property

		' Token: 0x170003C0 RID: 960
		' (get) Token: 0x060011DF RID: 4575 RVA: 0x0006E639 File Offset: 0x0006C839
		' (set) Token: 0x060011E0 RID: 4576 RVA: 0x0006E641 File Offset: 0x0006C841
		<DisplayName("位置")>
		<DefaultValue(False)>
		<Category("属性")>
		<O_Oo00Oo000O0(9.0)>
		Public Property Alignment As ToolStripItemAlignment
			Get
				Return Me.ooo_o__OO_.o.
			End Get
			Set(value As ToolStripItemAlignment)
				Me.ooo_o__OO_.o. = value
			End Set
		End Property

		' Token: 0x170003C1 RID: 961
		' (get) Token: 0x060011E1 RID: 4577 RVA: 0x0006E64A File Offset: 0x0006C84A
		' (set) Token: 0x060011E2 RID: 4578 RVA: 0x0006E652 File Offset: 0x0006C852
		<Category("属性")>
		<DisplayName("可见")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(10.0)>
		Public Property Visible As Boolean
			Get
				Return Me.oO0o00.00_.
			End Get
			Set(value As Boolean)
				Me.oO0o00.00_. = value
			End Set
		End Property

		' Token: 0x170003C2 RID: 962
		' (get) Token: 0x060011E3 RID: 4579 RVA: 0x0006E65B File Offset: 0x0006C85B
		' (set) Token: 0x060011E4 RID: 4580 RVA: 0x0006E663 File Offset: 0x0006C863
		<DisplayName("可用")>
		<O_Oo00Oo000O0(11.0)>
		<DefaultValue(True)>
		<Category("属性")>
		Public Property Enabeld As Boolean
			Get
				Return Me.ooO0.__0_0_.
			End Get
			Set(value As Boolean)
				Me.ooO0.__0_0_. = value
			End Set
		End Property

		' Token: 0x040006CD RID: 1741
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006CE RID: 1742
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006CF RID: 1743
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006D0 RID: 1744
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006D1 RID: 1745
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006D2 RID: 1746
		Private <<EMPTY_NAME>> As StripItemTypeEnum

		' Token: 0x040006D3 RID: 1747
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006D4 RID: 1748
		Private <<EMPTY_NAME>> As TextPositionEnum

		' Token: 0x040006D5 RID: 1749
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006D6 RID: 1750
		Private <<EMPTY_NAME>> As ToolStripItemAlignment

		' Token: 0x040006D7 RID: 1751
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006D8 RID: 1752
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006D9 RID: 1753
		Private <<EMPTY_NAME>> As Keys

		' Token: 0x040006DA RID: 1754
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
