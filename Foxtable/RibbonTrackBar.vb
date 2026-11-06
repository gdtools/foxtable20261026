Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000491 RID: 1169
	<oO0oooo("3092")>
	<OoO0___o("RibbonTrackBar")>
	Friend Class RibbonTrackBar
		Inherits RibbonItem

		' Token: 0x06004D4C RID: 19788 RVA: 0x00201864 File Offset: 0x001FFA64
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O0.o0__OOo00O. = 50
			Me.o0_o.o. = 100
			Me.oO_O_000.ooo. = 0
			Me.O.Ooo_Oo_oo. = 150
			Me.O_O0oO.0O0OO. = 25
			Me.o0O.o_ooo0_O. = 5
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001180 RID: 4480
		' (get) Token: 0x06004D4D RID: 19789 RVA: 0x002018B1 File Offset: 0x001FFAB1
		' (set) Token: 0x06004D4E RID: 19790 RVA: 0x002018B9 File Offset: 0x001FFAB9
		<DisplayName("初始值")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Value As Integer
			Get
				Return Me.O0.o0__OOo00O.
			End Get
			Set(value As Integer)
				Me.O0.o0__OOo00O. = value
			End Set
		End Property

		' Token: 0x17001181 RID: 4481
		' (get) Token: 0x06004D4F RID: 19791 RVA: 0x002018C2 File Offset: 0x001FFAC2
		' (set) Token: 0x06004D50 RID: 19792 RVA: 0x002018CA File Offset: 0x001FFACA
		<DisplayName("最小值")>
		<Category("属性")>
		<O_Oo00Oo000O0(1.2)>
		Public Property Minimum As Integer
			Get
				Return Me.oO_O_000.ooo.
			End Get
			Set(value As Integer)
				Me.oO_O_000.ooo. = value
			End Set
		End Property

		' Token: 0x17001182 RID: 4482
		' (get) Token: 0x06004D51 RID: 19793 RVA: 0x002018D3 File Offset: 0x001FFAD3
		' (set) Token: 0x06004D52 RID: 19794 RVA: 0x002018DB File Offset: 0x001FFADB
		<DisplayName("最大值")>
		<O_Oo00Oo000O0(1.3)>
		<Category("属性")>
		Public Property Maximum As Integer
			Get
				Return Me.o0_o.o.
			End Get
			Set(value As Integer)
				Me.o0_o.o. = value
			End Set
		End Property

		' Token: 0x17001183 RID: 4483
		' (get) Token: 0x06004D53 RID: 19795 RVA: 0x002018E4 File Offset: 0x001FFAE4
		' (set) Token: 0x06004D54 RID: 19796 RVA: 0x002018EC File Offset: 0x001FFAEC
		<DisplayName("刻度间隔")>
		<Description("两个刻度之间的间隔值。")>
		<O_Oo00Oo000O0(1.4)>
		<Category("属性")>
		Public Property TickFrequency As Integer
			Get
				Return Me.O_O0oO.0O0OO.
			End Get
			Set(value As Integer)
				Me.O_O0oO.0O0OO. = value
			End Set
		End Property

		' Token: 0x17001184 RID: 4484
		' (get) Token: 0x06004D55 RID: 19797 RVA: 0x002018F5 File Offset: 0x001FFAF5
		' (set) Token: 0x06004D56 RID: 19798 RVA: 0x002018FD File Offset: 0x001FFAFD
		<Category("属性")>
		<O_Oo00Oo000O0(1.5)>
		<DisplayName("步长")>
		<Description("单击加减按钮时值改变的幅度。")>
		Public Property StepFrequency As Integer
			Get
				Return Me.o0O.o_ooo0_O.
			End Get
			Set(value As Integer)
				Me.o0O.o_ooo0_O. = value
			End Set
		End Property

		' Token: 0x17001185 RID: 4485
		' (get) Token: 0x06004D57 RID: 19799 RVA: 0x00201906 File Offset: 0x001FFB06
		' (set) Token: 0x06004D58 RID: 19800 RVA: 0x0020190E File Offset: 0x001FFB0E
		<O_Oo00Oo000O0(1.6)>
		<Category("属性")>
		<DisplayName("宽度")>
		Public Property Width As Integer
			Get
				Return Me.O.Ooo_Oo_oo.
			End Get
			Set(value As Integer)
				Me.O.Ooo_Oo_oo. = value
			End Set
		End Property

		' Token: 0x17001186 RID: 4486
		' (get) Token: 0x06004D59 RID: 19801 RVA: 0x00201917 File Offset: 0x001FFB17
		' (set) Token: 0x06004D5A RID: 19802 RVA: 0x0020191F File Offset: 0x001FFB1F
		<O0O0oOO00_0OO(True)>
		<Description("当前值改变后执行。")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		Public Property ValueChanged As EventString
			Get
				Return Me.O0.o0__OOo00O.
			End Get
			Set(value As EventString)
				Me.O0.o0__OOo00O. = value
			End Set
		End Property

		' Token: 0x17001187 RID: 4487
		' (get) Token: 0x06004D5B RID: 19803 RVA: 0x00201928 File Offset: 0x001FFB28
		' (set) Token: 0x06004D5C RID: 19804 RVA: 0x0020192B File Offset: 0x001FFB2B
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17001188 RID: 4488
		' (get) Token: 0x06004D5D RID: 19805 RVA: 0x0020192D File Offset: 0x001FFB2D
		' (set) Token: 0x06004D5E RID: 19806 RVA: 0x00201930 File Offset: 0x001FFB30
		<Browsable(False)>
		Public Property SmallImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17001189 RID: 4489
		' (get) Token: 0x06004D5F RID: 19807 RVA: 0x00201934 File Offset: 0x001FFB34
		' (set) Token: 0x06004D60 RID: 19808 RVA: 0x00201942 File Offset: 0x001FFB42
		<Browsable(False)>
		Public Property AutoHideText As Boolean
			Get
				Dim result As Boolean
				Return result
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x1700118A RID: 4490
		' (get) Token: 0x06004D61 RID: 19809 RVA: 0x00201944 File Offset: 0x001FFB44
		' (set) Token: 0x06004D62 RID: 19810 RVA: 0x00201952 File Offset: 0x001FFB52
		<Browsable(False)>
		Public Property TextImageRelation As TextImageRelationEnum
			Get
				Dim result As TextImageRelationEnum
				Return result
			End Get
			Set(value As TextImageRelationEnum)
			End Set
		End Property

		' Token: 0x04001FBB RID: 8123
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001FBC RID: 8124
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001FBD RID: 8125
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001FBE RID: 8126
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001FBF RID: 8127
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001FC0 RID: 8128
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001FC1 RID: 8129
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
