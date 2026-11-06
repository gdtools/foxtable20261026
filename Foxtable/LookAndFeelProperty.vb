Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace Foxtable
	' Token: 0x02000326 RID: 806
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class LookAndFeelProperty
		' Token: 0x06002D1D RID: 11549 RVA: 0x00131838 File Offset: 0x0012FA38
		Public Sub New()
			Me.Oo_.OOOO_Oo_. = True
			Me.O.oO0__. = Color.SteelBlue
			Me.o_O0_._O. = Color.Red
			Me.Oo.ooo00. = Color.Orange
			Me.ooO._O_. = Color.DarkGray
			Me.O0OOo._Oo00. = Color.Salmon
			Me.oOO0.o. = Color.BurlyWood
			Me.o00O__oo00O.0O. = 0
			Me.O.o_oO0_. = SystemColors.Control
			Me.o00O__oo00O.0O. = 0
			Me.O_0O_O.0O0. = 0
			Me.OoO00_Oo0o.o. = Color.Transparent
			Me.o00_.0ooOo. = Color.Transparent
			Me.oooO__.00_. = Color.Transparent
			Me.OOo0.OO_O000O. = Color.Transparent
			Me.o.oo0o0_0. = Color.Transparent
			Me.Oo00o.0O_o0O_o. = Color.Transparent
			Me.o0o.o0O0O0OOO0. = Color.Transparent
			Me.ooO0O0__o_.o0. = Color.Transparent
			Me.OO0O._Oo. = Color.Transparent
			Me.ooO.OOOoO. = Color.Transparent
			Me.oO.oO0ooO0_00o. = Color.Transparent
			Me.Oo.oo_0_. = Color.Transparent
			Me.o0O_o00O.0o_. = Color.Transparent
			Me.Oo0o.O0o0. = Color.Transparent
			Me.O.O_00O. = Color.PaleGreen
			Me.OooO0o_._0oOoO. = SystemColors.WindowText
			Me.Oo._oO0. = Color.LightYellow
			Me.Oooo_.oOoo0o. = SystemColors.WindowText
			Me.o__0.OO. = Color.Azure
			Me.oo.0o0OOoOOoo0. = SystemColors.WindowText
			Me.O0OO0.o_. = Color.Snow
			Me.OOOOo.O_. = SystemColors.WindowText
			Me.oo0_0O0._OO. = Color.Beige
			Me.O_o_0_._oO. = SystemColors.WindowText
			Me.ooO0.O0. = Color.AliceBlue
			Me.O_o.o_. = SystemColors.WindowText
			Me.O__O0o.o0. = Color.LightGoldenrodYellow
			Me.O.o0_oooo00. = SystemColors.WindowText
			Me.o._OO0. = Color.Transparent
			Me.o000OO0._oO_o. = Color.Transparent
			Me.O_oo.0O0__O_. = Color.Transparent
			Me.Oo0.0_O. = True
			Me.O_OO_0_0o__0.o. = True
			Me.OoOo000.O_. = True
			Me.O0_Oooo_.0O_0. = True
			Me.o0_.O_0_. = Color.Transparent
			Me.O.o_O_O. = Color.Transparent
		End Sub

		' Token: 0x17000B1C RID: 2844
		' (get) Token: 0x06002D1E RID: 11550 RVA: 0x00131A3B File Offset: 0x0012FC3B
		' (set) Token: 0x06002D1F RID: 11551 RVA: 0x00131A43 File Offset: 0x0012FC43
		<Browsable(False)>
		Public Property UserStyle As String
			Get
				Return Me.O.oO0__.
			End Get
			Set(value As String)
				Me.O.oO0__. = value
			End Set
		End Property

		' Token: 0x17000B1D RID: 2845
		' (get) Token: 0x06002D20 RID: 11552 RVA: 0x00131A4C File Offset: 0x0012FC4C
		' (set) Token: 0x06002D21 RID: 11553 RVA: 0x00131A54 File Offset: 0x0012FC54
		<DisplayName("显示行号")>
		<O_Oo00Oo000O0(2.0)>
		<Description("如果显示了行号，则不显示锁定行标记。")>
		<DefaultValue(True)>
		<Category("外观")>
		Public Property ShowLineNumber As Boolean
			Get
				Return Me.Oo_.OOOO_Oo_.
			End Get
			Set(value As Boolean)
				Me.Oo_.OOOO_Oo_. = value
			End Set
		End Property

		' Token: 0x17000B1E RID: 2846
		' (get) Token: 0x06002D22 RID: 11554 RVA: 0x00131A5D File Offset: 0x0012FC5D
		' (set) Token: 0x06002D23 RID: 11555 RVA: 0x00131A65 File Offset: 0x0012FC65
		<Category("行号颜色")>
		<DefaultValue(-12156236)>
		<DisplayName("普通行")>
		<O_Oo00Oo000O0(3.0)>
		Public Property UnchangedRowHeaderForeColor As Color
			Get
				Return Me.O.oO0__.
			End Get
			Set(value As Color)
				Me.O.oO0__. = value
			End Set
		End Property

		' Token: 0x17000B1F RID: 2847
		' (get) Token: 0x06002D24 RID: 11556 RVA: 0x00131A6E File Offset: 0x0012FC6E
		' (set) Token: 0x06002D25 RID: 11557 RVA: 0x00131A76 File Offset: 0x0012FC76
		<DisplayName("新增行")>
		<DefaultValue(-65536)>
		<O_Oo00Oo000O0(4.0)>
		<Category("行号颜色")>
		Public Property AddedRowHeaderForeColor As Color
			Get
				Return Me.o_O0_._O.
			End Get
			Set(value As Color)
				Me.o_O0_._O. = value
			End Set
		End Property

		' Token: 0x17000B20 RID: 2848
		' (get) Token: 0x06002D26 RID: 11558 RVA: 0x00131A7F File Offset: 0x0012FC7F
		' (set) Token: 0x06002D27 RID: 11559 RVA: 0x00131A87 File Offset: 0x0012FC87
		<Category("行号颜色")>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("已修改行")>
		<DefaultValue(-23296)>
		Public Property ModifiedRowHeaderForeColor As Color
			Get
				Return Me.Oo.ooo00.
			End Get
			Set(value As Color)
				Me.Oo.ooo00. = value
			End Set
		End Property

		' Token: 0x17000B21 RID: 2849
		' (get) Token: 0x06002D28 RID: 11560 RVA: 0x00131A90 File Offset: 0x0012FC90
		' (set) Token: 0x06002D29 RID: 11561 RVA: 0x00131A98 File Offset: 0x0012FC98
		<Category("行号颜色")>
		<DisplayName("普通行(锁定)")>
		<DefaultValue(-5658199)>
		<O_Oo00Oo000O0(6.0)>
		Public Property LockedRowHeaderForeColor As Color
			Get
				Return Me.ooO._O_.
			End Get
			Set(value As Color)
				Me.ooO._O_. = value
			End Set
		End Property

		' Token: 0x17000B22 RID: 2850
		' (get) Token: 0x06002D2A RID: 11562 RVA: 0x00131AA1 File Offset: 0x0012FCA1
		' (set) Token: 0x06002D2B RID: 11563 RVA: 0x00131AA9 File Offset: 0x0012FCA9
		<Category("行号颜色")>
		<DisplayName("新增行(锁定)")>
		<Description("被锁定的新增行")>
		<O_Oo00Oo000O0(7.0)>
		<DefaultValue(-360334)>
		Public Property LockedAddedRowHeaderForeColor As Color
			Get
				Return Me.O0OOo._Oo00.
			End Get
			Set(value As Color)
				Me.O0OOo._Oo00. = value
			End Set
		End Property

		' Token: 0x17000B23 RID: 2851
		' (get) Token: 0x06002D2C RID: 11564 RVA: 0x00131AB2 File Offset: 0x0012FCB2
		' (set) Token: 0x06002D2D RID: 11565 RVA: 0x00131ABA File Offset: 0x0012FCBA
		<DefaultValue(-2180985)>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("已修改行(锁定)")>
		<Description("被锁定的已修改行")>
		<Category("行号颜色")>
		Public Property LockedModifiedRowHeaderForeColor As Color
			Get
				Return Me.oOO0.o.
			End Get
			Set(value As Color)
				Me.oOO0.o. = value
			End Set
		End Property

		' Token: 0x17000B24 RID: 2852
		' (get) Token: 0x06002D2E RID: 11566 RVA: 0x00131AC3 File Offset: 0x0012FCC3
		' (set) Token: 0x06002D2F RID: 11567 RVA: 0x00131ACB File Offset: 0x0012FCCB
		<O_Oo00Oo000O0(7.0)>
		<Category("网格线")>
		<DefaultValue(0)>
		<DisplayName("方向")>
		Public Property GridLineDirection As GridLineDirectionEnum
			Get
				Return Me.o00O__oo00O.0O.
			End Get
			Set(value As GridLineDirectionEnum)
				Me.o00O__oo00O.0O. = value
			End Set
		End Property

		' Token: 0x17000B25 RID: 2853
		' (get) Token: 0x06002D30 RID: 11568 RVA: 0x00131AD4 File Offset: 0x0012FCD4
		' (set) Token: 0x06002D31 RID: 11569 RVA: 0x00131ADC File Offset: 0x0012FCDC
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("类型")>
		<DefaultValue(0)>
		<Category("网格线")>
		Public Property GridStyle As GridStyleEnum
			Get
				Return Me.o00O__oo00O.0O.
			End Get
			Set(value As GridStyleEnum)
				Me.o00O__oo00O.0O. = value
			End Set
		End Property

		' Token: 0x17000B26 RID: 2854
		' (get) Token: 0x06002D32 RID: 11570 RVA: 0x00131AE5 File Offset: 0x0012FCE5
		' (set) Token: 0x06002D33 RID: 11571 RVA: 0x00131AED File Offset: 0x0012FCED
		<O_Oo00Oo000O0(9.0)>
		<DisplayName("宽度")>
		<DefaultValue(0)>
		<Category("网格线")>
		Public Property GridWidth As GridWidthEnum
			Get
				Return Me.O_0O_O.0O0.
			End Get
			Set(value As GridWidthEnum)
				Me.O_0O_O.0O0. = value
			End Set
		End Property

		' Token: 0x17000B27 RID: 2855
		' (get) Token: 0x06002D34 RID: 11572 RVA: 0x00131AF6 File Offset: 0x0012FCF6
		' (set) Token: 0x06002D35 RID: 11573 RVA: 0x00131AFE File Offset: 0x0012FCFE
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(10.0)>
		<DisplayName("颜色")>
		<Description("只有在网格类型为Flat、Dotted、Double的时候，网格线的颜色设置才有效。")>
		<DefaultValue(16777215)>
		<Category("网格线")>
		Public Property GridColor As Color
			Get
				Return Me.O.o_oO0_.
			End Get
			Set(value As Color)
				Me.O.o_oO0_. = value
			End Set
		End Property

		' Token: 0x17000B28 RID: 2856
		' (get) Token: 0x06002D36 RID: 11574 RVA: 0x00131B07 File Offset: 0x0012FD07
		' (set) Token: 0x06002D37 RID: 11575 RVA: 0x00131B0F File Offset: 0x0012FD0F
		<DisplayName("背景颜色")>
		<Category("A.数据区")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(11.0)>
		Public Property BackColor As Color
			Get
				Return Me.OoO00_Oo0o.o.
			End Get
			Set(value As Color)
				If Me.AlterRowBackColor = Me.BackColor Then
					Me.AlterRowBackColor = value
				End If
				Me.OoO00_Oo0o.o. = value
			End Set
		End Property

		' Token: 0x17000B29 RID: 2857
		' (get) Token: 0x06002D38 RID: 11576 RVA: 0x00131B32 File Offset: 0x0012FD32
		' (set) Token: 0x06002D39 RID: 11577 RVA: 0x00131B3A File Offset: 0x0012FD3A
		<DisplayName("字体颜色")>
		<Category("A.数据区")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(12.0)>
		<DefaultValue(16777215)>
		Public Property ForeColor As Color
			Get
				Return Me.o00_.0ooOo.
			End Get
			Set(value As Color)
				If Me.AlterRowForeColor = Me.ForeColor Then
					Me.AlterRowForeColor = value
				End If
				Me.o00_.0ooOo. = value
			End Set
		End Property

		' Token: 0x17000B2A RID: 2858
		' (get) Token: 0x06002D3A RID: 11578 RVA: 0x00131B5D File Offset: 0x0012FD5D
		' (set) Token: 0x06002D3B RID: 11579 RVA: 0x00131B65 File Offset: 0x0012FD65
		<DefaultValue(16777215)>
		<O_Oo00Oo000O0(11.0)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("B.选定区")>
		<DisplayName("背景颜色")>
		Public Property HighlightBackColor As Color
			Get
				Return Me.oooO__.00_.
			End Get
			Set(value As Color)
				Me.oooO__.00_. = value
			End Set
		End Property

		' Token: 0x17000B2B RID: 2859
		' (get) Token: 0x06002D3C RID: 11580 RVA: 0x00131B6E File Offset: 0x0012FD6E
		' (set) Token: 0x06002D3D RID: 11581 RVA: 0x00131B76 File Offset: 0x0012FD76
		<DefaultValue(16777215)>
		<O_Oo00Oo000O0(12.0)>
		<Category("B.选定区")>
		<DisplayName("字体颜色")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property HighlightForeColor As Color
			Get
				Return Me.OOo0.OO_O000O.
			End Get
			Set(value As Color)
				Me.OOo0.OO_O000O. = value
			End Set
		End Property

		' Token: 0x17000B2C RID: 2860
		' (get) Token: 0x06002D3E RID: 11582 RVA: 0x00131B7F File Offset: 0x0012FD7F
		' (set) Token: 0x06002D3F RID: 11583 RVA: 0x00131B87 File Offset: 0x0012FD87
		<O_Oo00Oo000O0(12.0)>
		<DisplayName("背景颜色")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("C.标题区")>
		Public Property FixedBackColor As Color
			Get
				Return Me.o.oo0o0_0.
			End Get
			Set(value As Color)
				Me.o.oo0o0_0. = value
			End Set
		End Property

		' Token: 0x17000B2D RID: 2861
		' (get) Token: 0x06002D40 RID: 11584 RVA: 0x00131B90 File Offset: 0x0012FD90
		' (set) Token: 0x06002D41 RID: 11585 RVA: 0x00131B98 File Offset: 0x0012FD98
		<DefaultValue(16777215)>
		<O_Oo00Oo000O0(12.0)>
		<Category("C.标题区")>
		<DisplayName("字体颜色")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property FixedForeColor As Color
			Get
				Return Me.Oo00o.0O_o0O_o.
			End Get
			Set(value As Color)
				Me.Oo00o.0O_o0O_o. = value
			End Set
		End Property

		' Token: 0x17000B2E RID: 2862
		' (get) Token: 0x06002D42 RID: 11586 RVA: 0x00131BA1 File Offset: 0x0012FDA1
		' (set) Token: 0x06002D43 RID: 11587 RVA: 0x00131BA9 File Offset: 0x0012FDA9
		<DisplayName("背景颜色")>
		<Category("D.选定标题区")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(12.0)>
		Public Property SelectedHeaderBackColor As Color
			Get
				Return Me.o0O_o00O.0o_.
			End Get
			Set(value As Color)
				Me.o0O_o00O.0o_. = value
			End Set
		End Property

		' Token: 0x17000B2F RID: 2863
		' (get) Token: 0x06002D44 RID: 11588 RVA: 0x00131BB2 File Offset: 0x0012FDB2
		' (set) Token: 0x06002D45 RID: 11589 RVA: 0x00131BBA File Offset: 0x0012FDBA
		<O_Oo00Oo000O0(12.0)>
		<Category("D.选定标题区")>
		<DisplayName("字体颜色")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property SelectedHeaderForeColor As Color
			Get
				Return Me.Oo0o.O0o0.
			End Get
			Set(value As Color)
				Me.Oo0o.O0o0. = value
			End Set
		End Property

		' Token: 0x17000B30 RID: 2864
		' (get) Token: 0x06002D46 RID: 11590 RVA: 0x00131BC3 File Offset: 0x0012FDC3
		' (set) Token: 0x06002D47 RID: 11591 RVA: 0x00131BCB File Offset: 0x0012FDCB
		<DefaultValue(0)>
		<O_Oo00Oo000O0(10.9)>
		<DisplayName("关闭交替显示")>
		<Category("E.交替行")>
		Public Property DisableAlterRowMode As BooleanEnum
			Get
				Return Me.O__O.ooO__.
			End Get
			Set(value As BooleanEnum)
				Me.O__O.ooO__. = value
			End Set
		End Property

		' Token: 0x17000B31 RID: 2865
		' (get) Token: 0x06002D48 RID: 11592 RVA: 0x00131BD4 File Offset: 0x0012FDD4
		' (set) Token: 0x06002D49 RID: 11593 RVA: 0x00131BDC File Offset: 0x0012FDDC
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("背景颜色")>
		<DefaultValue(16777215)>
		<Category("E.交替行")>
		Public Property AlterRowBackColor As Color
			Get
				Return Me.OO0O._Oo.
			End Get
			Set(value As Color)
				Me.OO0O._Oo. = value
			End Set
		End Property

		' Token: 0x17000B32 RID: 2866
		' (get) Token: 0x06002D4A RID: 11594 RVA: 0x00131BE5 File Offset: 0x0012FDE5
		' (set) Token: 0x06002D4B RID: 11595 RVA: 0x00131BED File Offset: 0x0012FDED
		<DisplayName("字体颜色")>
		<O_Oo00Oo000O0(12.0)>
		<Category("E.交替行")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property AlterRowForeColor As Color
			Get
				Return Me.ooO.OOOoO.
			End Get
			Set(value As Color)
				Me.ooO.OOOoO. = value
			End Set
		End Property

		' Token: 0x17000B33 RID: 2867
		' (get) Token: 0x06002D4C RID: 11596 RVA: 0x00131BF6 File Offset: 0x0012FDF6
		' (set) Token: 0x06002D4D RID: 11597 RVA: 0x00131BFE File Offset: 0x0012FDFE
		<O_Oo00Oo000O0(11.0)>
		<DefaultValue(16777215)>
		<Category("F.冻结区")>
		<DisplayName("背景颜色")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property FrozenBackColor As Color
			Get
				Return Me.o0o.o0O0O0OOO0.
			End Get
			Set(value As Color)
				Me.o0o.o0O0O0OOO0. = value
			End Set
		End Property

		' Token: 0x17000B34 RID: 2868
		' (get) Token: 0x06002D4E RID: 11598 RVA: 0x00131C07 File Offset: 0x0012FE07
		' (set) Token: 0x06002D4F RID: 11599 RVA: 0x00131C0F File Offset: 0x0012FE0F
		<O_Oo00Oo000O0(12.0)>
		<Category("F.冻结区")>
		<DisplayName("字体颜色")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property frozenForeColor As Color
			Get
				Return Me.ooO0O0__o_.o0.
			End Get
			Set(value As Color)
				Me.ooO0O0__o_.o0. = value
			End Set
		End Property

		' Token: 0x17000B35 RID: 2869
		' (get) Token: 0x06002D50 RID: 11600 RVA: 0x00131C18 File Offset: 0x0012FE18
		' (set) Token: 0x06002D51 RID: 11601 RVA: 0x00131C20 File Offset: 0x0012FE20
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("背景颜色")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("G.焦点单元格")>
		Public Property FocusBackColor As Color
			Get
				Return Me.oO.oO0ooO0_00o.
			End Get
			Set(value As Color)
				Me.oO.oO0ooO0_00o. = value
			End Set
		End Property

		' Token: 0x17000B36 RID: 2870
		' (get) Token: 0x06002D52 RID: 11602 RVA: 0x00131C29 File Offset: 0x0012FE29
		' (set) Token: 0x06002D53 RID: 11603 RVA: 0x00131C31 File Offset: 0x0012FE31
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(12.0)>
		<Category("G.焦点单元格")>
		<DisplayName("字体颜色")>
		<DefaultValue(16777215)>
		Public Property FocusForeColor As Color
			Get
				Return Me.Oo.oo_0_.
			End Get
			Set(value As Color)
				Me.Oo.oo_0_. = value
			End Set
		End Property

		' Token: 0x17000B37 RID: 2871
		' (get) Token: 0x06002D54 RID: 11604 RVA: 0x00131C3A File Offset: 0x0012FE3A
		' (set) Token: 0x06002D55 RID: 11605 RVA: 0x00131C42 File Offset: 0x0012FE42
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("H.已修改单元格")>
		<DisplayName("背景颜色")>
		<O_Oo00Oo000O0(11.0)>
		Public Property ModifiedCellBackColor As Color
			Get
				Return Me.o000OO0._oO_o.
			End Get
			Set(value As Color)
				Me.o000OO0._oO_o. = value
			End Set
		End Property

		' Token: 0x17000B38 RID: 2872
		' (get) Token: 0x06002D56 RID: 11606 RVA: 0x00131C4B File Offset: 0x0012FE4B
		' (set) Token: 0x06002D57 RID: 11607 RVA: 0x00131C53 File Offset: 0x0012FE53
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(12.0)>
		<Category("H.已修改单元格")>
		<DisplayName("字体颜色")>
		<DefaultValue(16777215)>
		Public Property ModifiedCellForeColor As Color
			Get
				Return Me.O_oo.0O0__O_.
			End Get
			Set(value As Color)
				Me.O_oo.0O0__O_. = value
			End Set
		End Property

		' Token: 0x17000B39 RID: 2873
		' (get) Token: 0x06002D58 RID: 11608 RVA: 0x00131C5C File Offset: 0x0012FE5C
		' (set) Token: 0x06002D59 RID: 11609 RVA: 0x00131C64 File Offset: 0x0012FE64
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("背景颜色")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("I.当前行")>
		<DefaultValue(16777215)>
		Public Property CurrentRowBackColor As Color
			Get
				Return Me.o0_.O_0_.
			End Get
			Set(value As Color)
				Me.o0_.O_0_. = value
			End Set
		End Property

		' Token: 0x17000B3A RID: 2874
		' (get) Token: 0x06002D5A RID: 11610 RVA: 0x00131C6D File Offset: 0x0012FE6D
		' (set) Token: 0x06002D5B RID: 11611 RVA: 0x00131C75 File Offset: 0x0012FE75
		<O_Oo00Oo000O0(12.0)>
		<DisplayName("字体颜色")>
		<DefaultValue(16777215)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("I.当前行")>
		Public Property CurrentRowForeColor As Color
			Get
				Return Me.O.o_O_O.
			End Get
			Set(value As Color)
				Me.O.o_O_O. = value
			End Set
		End Property

		' Token: 0x17000B3B RID: 2875
		' (get) Token: 0x06002D5C RID: 11612 RVA: 0x00131C7E File Offset: 0x0012FE7E
		' (set) Token: 0x06002D5D RID: 11613 RVA: 0x00131C86 File Offset: 0x0012FE86
		<O_Oo00Oo000O0(11.0)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("J.总计行")>
		<DefaultValue(-6751336)>
		<DisplayName("背景颜色")>
		Public Property GrandTotalBackColor As Color
			Get
				Return Me.O.O_00O.
			End Get
			Set(value As Color)
				Me.O.O_00O. = value
			End Set
		End Property

		' Token: 0x17000B3C RID: 2876
		' (get) Token: 0x06002D5E RID: 11614 RVA: 0x00131C8F File Offset: 0x0012FE8F
		' (set) Token: 0x06002D5F RID: 11615 RVA: 0x00131C97 File Offset: 0x0012FE97
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(12.0)>
		<DefaultValue(-16777216)>
		<Category("J.总计行")>
		<DisplayName("字体颜色")>
		Public Property GrandTotalForeColor As Color
			Get
				Return Me.OooO0o_._0oOoO.
			End Get
			Set(value As Color)
				Me.OooO0o_._0oOoO. = value
			End Set
		End Property

		' Token: 0x17000B3D RID: 2877
		' (get) Token: 0x06002D60 RID: 11616 RVA: 0x00131CA0 File Offset: 0x0012FEA0
		' (set) Token: 0x06002D61 RID: 11617 RVA: 0x00131CA8 File Offset: 0x0012FEA8
		<DisplayName("背景颜色")>
		<DefaultValue(-64)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(11.0)>
		<Category("K.小计行0")>
		Public Property Subtotal0BackColor As Color
			Get
				Return Me.Oo._oO0.
			End Get
			Set(value As Color)
				Me.Oo._oO0. = value
			End Set
		End Property

		' Token: 0x17000B3E RID: 2878
		' (get) Token: 0x06002D62 RID: 11618 RVA: 0x00131CB1 File Offset: 0x0012FEB1
		' (set) Token: 0x06002D63 RID: 11619 RVA: 0x00131CB9 File Offset: 0x0012FEB9
		<DisplayName("字体颜色")>
		<O_Oo00Oo000O0(12.0)>
		<Category("K.小计行0")>
		<DefaultValue(-16777216)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property Subtotal0ForeColor As Color
			Get
				Return Me.Oooo_.oOoo0o.
			End Get
			Set(value As Color)
				Me.Oooo_.oOoo0o. = value
			End Set
		End Property

		' Token: 0x17000B3F RID: 2879
		' (get) Token: 0x06002D64 RID: 11620 RVA: 0x00131CC2 File Offset: 0x0012FEC2
		' (set) Token: 0x06002D65 RID: 11621 RVA: 0x00131CCA File Offset: 0x0012FECA
		<O_Oo00Oo000O0(11.0)>
		<DefaultValue(-2031617)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<Category("L.小计行1")>
		<DisplayName("背景颜色")>
		Public Property Subtotal1BackColor As Color
			Get
				Return Me.o__0.OO.
			End Get
			Set(value As Color)
				Me.o__0.OO. = value
			End Set
		End Property

		' Token: 0x17000B40 RID: 2880
		' (get) Token: 0x06002D66 RID: 11622 RVA: 0x00131CD3 File Offset: 0x0012FED3
		' (set) Token: 0x06002D67 RID: 11623 RVA: 0x00131CDB File Offset: 0x0012FEDB
		<DefaultValue(-16777216)>
		<Category("L.小计行1")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(12.0)>
		<DisplayName("字体颜色")>
		Public Property Subtotal1ForeColor As Color
			Get
				Return Me.oo.0o0OOoOOoo0.
			End Get
			Set(value As Color)
				Me.oo.0o0OOoOOoo0. = value
			End Set
		End Property

		' Token: 0x17000B41 RID: 2881
		' (get) Token: 0x06002D68 RID: 11624 RVA: 0x00131CE4 File Offset: 0x0012FEE4
		' (set) Token: 0x06002D69 RID: 11625 RVA: 0x00131CEC File Offset: 0x0012FEEC
		<O_Oo00Oo000O0(11.0)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<DefaultValue(-5004601)>
		<Category("M.小计行2")>
		<DisplayName("背景颜色")>
		Public Property Subtotal2BackColor As Color
			Get
				Return Me.O0OO0.o_.
			End Get
			Set(value As Color)
				Me.O0OO0.o_. = value
			End Set
		End Property

		' Token: 0x17000B42 RID: 2882
		' (get) Token: 0x06002D6A RID: 11626 RVA: 0x00131CF5 File Offset: 0x0012FEF5
		' (set) Token: 0x06002D6B RID: 11627 RVA: 0x00131CFD File Offset: 0x0012FEFD
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<DefaultValue(-16777216)>
		<Category("M.小计行2")>
		<DisplayName("字体颜色")>
		<O_Oo00Oo000O0(12.0)>
		Public Property Subtotal2ForeColor As Color
			Get
				Return Me.OOOOo.O_.
			End Get
			Set(value As Color)
				Me.OOOOo.O_. = value
			End Set
		End Property

		' Token: 0x17000B43 RID: 2883
		' (get) Token: 0x06002D6C RID: 11628 RVA: 0x00131D06 File Offset: 0x0012FF06
		' (set) Token: 0x06002D6D RID: 11629 RVA: 0x00131D0E File Offset: 0x0012FF0E
		<DisplayName("背景颜色")>
		<O_Oo00Oo000O0(11.0)>
		<Category("N.小计行3")>
		<DefaultValue(-2517356)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property Subtotal3BackColor As Color
			Get
				Return Me.oo0_0O0._OO.
			End Get
			Set(value As Color)
				Me.oo0_0O0._OO. = value
			End Set
		End Property

		' Token: 0x17000B44 RID: 2884
		' (get) Token: 0x06002D6E RID: 11630 RVA: 0x00131D17 File Offset: 0x0012FF17
		' (set) Token: 0x06002D6F RID: 11631 RVA: 0x00131D1F File Offset: 0x0012FF1F
		<O_Oo00Oo000O0(12.0)>
		<Category("N.小计行3")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<DefaultValue(-16777216)>
		<DisplayName("字体颜色")>
		Public Property Subtotal3ForeColor As Color
			Get
				Return Me.O_o_0_._oO.
			End Get
			Set(value As Color)
				Me.O_o_0_._oO. = value
			End Set
		End Property

		' Token: 0x17000B45 RID: 2885
		' (get) Token: 0x06002D70 RID: 11632 RVA: 0x00131D28 File Offset: 0x0012FF28
		' (set) Token: 0x06002D71 RID: 11633 RVA: 0x00131D30 File Offset: 0x0012FF30
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("背景颜色")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<DefaultValue(-343920)>
		<Category("O.小计行4")>
		Public Property Subtotal4BackColor As Color
			Get
				Return Me.ooO0.O0.
			End Get
			Set(value As Color)
				Me.ooO0.O0. = value
			End Set
		End Property

		' Token: 0x17000B46 RID: 2886
		' (get) Token: 0x06002D72 RID: 11634 RVA: 0x00131D39 File Offset: 0x0012FF39
		' (set) Token: 0x06002D73 RID: 11635 RVA: 0x00131D41 File Offset: 0x0012FF41
		<DisplayName("字体颜色")>
		<Category("O.小计行4")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<DefaultValue(-16777216)>
		<O_Oo00Oo000O0(12.0)>
		Public Property Subtotal4ForeColor As Color
			Get
				Return Me.O_o.o_.
			End Get
			Set(value As Color)
				Me.O_o.o_. = value
			End Set
		End Property

		' Token: 0x17000B47 RID: 2887
		' (get) Token: 0x06002D74 RID: 11636 RVA: 0x00131D4A File Offset: 0x0012FF4A
		' (set) Token: 0x06002D75 RID: 11637 RVA: 0x00131D52 File Offset: 0x0012FF52
		<DisplayName("背景颜色")>
		<O_Oo00Oo000O0(11.0)>
		<Category("P.小计行5")>
		<DefaultValue(-3942757)>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		Public Property Subtotal5BackColor As Color
			Get
				Return Me.O__O0o.o0.
			End Get
			Set(value As Color)
				Me.O__O0o.o0. = value
			End Set
		End Property

		' Token: 0x17000B48 RID: 2888
		' (get) Token: 0x06002D76 RID: 11638 RVA: 0x00131D5B File Offset: 0x0012FF5B
		' (set) Token: 0x06002D77 RID: 11639 RVA: 0x00131D63 File Offset: 0x0012FF63
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<O_Oo00Oo000O0(12.0)>
		<DefaultValue(-16777216)>
		<Category("P.小计行5")>
		<DisplayName("字体颜色")>
		Public Property Subtotal5ForeColor As Color
			Get
				Return Me.O.o0_oooo00.
			End Get
			Set(value As Color)
				Me.O.o0_oooo00. = value
			End Set
		End Property

		' Token: 0x17000B49 RID: 2889
		' (get) Token: 0x06002D78 RID: 11640 RVA: 0x00131D6C File Offset: 0x0012FF6C
		' (set) Token: 0x06002D79 RID: 11641 RVA: 0x00131D74 File Offset: 0x0012FF74
		<DefaultValue(16777215)>
		<O_Oo00Oo000O0(11.0)>
		<Category("Q.空白区")>
		<TypeConverter(GetType(o__oOOo00oo0_))>
		<DisplayName("背景颜色")>
		Public Property EmptyBackColor As Color
			Get
				Return Me.o._OO0.
			End Get
			Set(value As Color)
				Me.o._OO0. = value
			End Set
		End Property

		' Token: 0x17000B4A RID: 2890
		' (get) Token: 0x06002D7A RID: 11642 RVA: 0x00131D7D File Offset: 0x0012FF7D
		' (set) Token: 0x06002D7B RID: 11643 RVA: 0x00131D85 File Offset: 0x0012FF85
		<DisplayName("显示锁定表标记")>
		<O_Oo00Oo000O0(12.0)>
		<DefaultValue(True)>
		<Category("外观")>
		Public Property ShowLockTableIcon As Boolean
			Get
				Return Me.Oo0.0_O.
			End Get
			Set(value As Boolean)
				Me.Oo0.0_O. = value
			End Set
		End Property

		' Token: 0x17000B4B RID: 2891
		' (get) Token: 0x06002D7C RID: 11644 RVA: 0x00131D8E File Offset: 0x0012FF8E
		' (set) Token: 0x06002D7D RID: 11645 RVA: 0x00131D96 File Offset: 0x0012FF96
		<O_Oo00Oo000O0(13.0)>
		<DefaultValue(True)>
		<DisplayName("显示锁定列标记")>
		<Category("外观")>
		Public Property ShowLockColumnIcon As Boolean
			Get
				Return Me.O_OO_0_0o__0.o.
			End Get
			Set(value As Boolean)
				Me.O_OO_0_0o__0.o. = value
			End Set
		End Property

		' Token: 0x17000B4C RID: 2892
		' (get) Token: 0x06002D7E RID: 11646 RVA: 0x00131D9F File Offset: 0x0012FF9F
		' (set) Token: 0x06002D7F RID: 11647 RVA: 0x00131DA7 File Offset: 0x0012FFA7
		<O_Oo00Oo000O0(14.0)>
		<DefaultValue(True)>
		<Category("外观")>
		<DisplayName("显示锁定行标记")>
		<Description("在不显示行号的时候，是否在行标题处显示锁定行标记。")>
		Public Property ShowLockRowIcon As Boolean
			Get
				Return Me.OoOo000.O_.
			End Get
			Set(value As Boolean)
				Me.OoOo000.O_. = value
			End Set
		End Property

		' Token: 0x17000B4D RID: 2893
		' (get) Token: 0x06002D80 RID: 11648 RVA: 0x00131DB0 File Offset: 0x0012FFB0
		' (set) Token: 0x06002D81 RID: 11649 RVA: 0x00131DB8 File Offset: 0x0012FFB8
		<DisplayName("显示排序标记")>
		<O_Oo00Oo000O0(13.0)>
		<Category("外观")>
		<DefaultValue(True)>
		Public Property ShowSortIcon As Boolean
			Get
				Return Me.O0_Oooo_.0O_0.
			End Get
			Set(value As Boolean)
				Me.O0_Oooo_.0O_0. = value
			End Set
		End Property

		' Token: 0x040011FD RID: 4605
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040011FE RID: 4606
		Private <<EMPTY_NAME>> As Color

		' Token: 0x040011FF RID: 4607
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001200 RID: 4608
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001201 RID: 4609
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001202 RID: 4610
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001203 RID: 4611
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001204 RID: 4612
		Private <<EMPTY_NAME>> As GridLineDirectionEnum

		' Token: 0x04001205 RID: 4613
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001206 RID: 4614
		Private <<EMPTY_NAME>> As GridStyleEnum

		' Token: 0x04001207 RID: 4615
		Private <<EMPTY_NAME>> As GridWidthEnum

		' Token: 0x04001208 RID: 4616
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001209 RID: 4617
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400120A RID: 4618
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400120B RID: 4619
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400120C RID: 4620
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400120D RID: 4621
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400120E RID: 4622
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400120F RID: 4623
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001210 RID: 4624
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001211 RID: 4625
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001212 RID: 4626
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001213 RID: 4627
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001214 RID: 4628
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001215 RID: 4629
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001216 RID: 4630
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001217 RID: 4631
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001218 RID: 4632
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001219 RID: 4633
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400121A RID: 4634
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400121B RID: 4635
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400121C RID: 4636
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400121D RID: 4637
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400121E RID: 4638
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400121F RID: 4639
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001220 RID: 4640
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001221 RID: 4641
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001222 RID: 4642
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001223 RID: 4643
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001224 RID: 4644
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001225 RID: 4645
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001226 RID: 4646
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001227 RID: 4647
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001228 RID: 4648
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001229 RID: 4649
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400122A RID: 4650
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400122B RID: 4651
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400122C RID: 4652
		Private <<EMPTY_NAME>> As Color

		' Token: 0x0400122D RID: 4653
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400122E RID: 4654
		Private <<EMPTY_NAME>> As BooleanEnum
	End Class
End Namespace
