Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200047C RID: 1148
	<oO0oooo("2039")>
	<OoO0___o("RibbonProgressBar")>
	Friend Class RibbonProgressBar
		Inherits RibbonItem

		' Token: 0x06004CA4 RID: 19620 RVA: 0x0020111C File Offset: 0x001FF31C
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O.O_OO000_O0_0. = 80
			Me.o_.ooo. = 12
			Me.o0oOo_.o0. = 100
			Me.OOO_.0. = 0
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001135 RID: 4405
		' (get) Token: 0x06004CA5 RID: 19621 RVA: 0x0020114C File Offset: 0x001FF34C
		' (set) Token: 0x06004CA6 RID: 19622 RVA: 0x00201154 File Offset: 0x001FF354
		<DisplayName("宽度")>
		<O_Oo00Oo000O0(1.3)>
		<Category("属性")>
		Public Property Width As Integer
			Get
				Return Me.O.O_OO000_O0_0.
			End Get
			Set(value As Integer)
				Me.O.O_OO000_O0_0. = value
			End Set
		End Property

		' Token: 0x17001136 RID: 4406
		' (get) Token: 0x06004CA7 RID: 19623 RVA: 0x0020115D File Offset: 0x001FF35D
		' (set) Token: 0x06004CA8 RID: 19624 RVA: 0x00201165 File Offset: 0x001FF365
		<DefaultValue(12)>
		<Category("属性")>
		<DisplayName("高度")>
		<O_Oo00Oo000O0(1.301)>
		Public Property Height As Integer
			Get
				Return Me.o_.ooo.
			End Get
			Set(value As Integer)
				value = Math.Min(24, Math.Max(5, value))
				Me.o_.ooo. = value
			End Set
		End Property

		' Token: 0x17001137 RID: 4407
		' (get) Token: 0x06004CA9 RID: 19625 RVA: 0x0020117E File Offset: 0x001FF37E
		' (set) Token: 0x06004CAA RID: 19626 RVA: 0x00201186 File Offset: 0x001FF386
		<DisplayName("最小值")>
		<Category("属性")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(1.31)>
		Public Property Minimum As Integer
			Get
				Return Me.OOO_.0.
			End Get
			Set(value As Integer)
				Me.OOO_.0. = value
			End Set
		End Property

		' Token: 0x17001138 RID: 4408
		' (get) Token: 0x06004CAB RID: 19627 RVA: 0x0020118F File Offset: 0x001FF38F
		' (set) Token: 0x06004CAC RID: 19628 RVA: 0x00201197 File Offset: 0x001FF397
		<DefaultValue(100)>
		<Category("属性")>
		<DisplayName("最大值")>
		<O_Oo00Oo000O0(1.32)>
		Public Property Maximum As Integer
			Get
				Return Me.o0oOo_.o0.
			End Get
			Set(value As Integer)
				Me.o0oOo_.o0. = value
			End Set
		End Property

		' Token: 0x17001139 RID: 4409
		' (get) Token: 0x06004CAD RID: 19629 RVA: 0x002011A0 File Offset: 0x001FF3A0
		' (set) Token: 0x06004CAE RID: 19630 RVA: 0x002011A8 File Offset: 0x001FF3A8
		<Category("属性")>
		<DisplayName("初始值")>
		<O_Oo00Oo000O0(1.4)>
		<DefaultValue(0)>
		Public Property Value As Integer
			Get
				Return Me.oOo0_O._0Oo.
			End Get
			Set(value As Integer)
				Me.oOo0_O._0Oo. = value
			End Set
		End Property

		' Token: 0x1700113A RID: 4410
		' (get) Token: 0x06004CAF RID: 19631 RVA: 0x002011B1 File Offset: 0x001FF3B1
		' (set) Token: 0x06004CB0 RID: 19632 RVA: 0x002011B9 File Offset: 0x001FF3B9
		<Description("当前值改变后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.3)>
		<O0O0oOO00_0OO(True)>
		<Category("事件")>
		Public Property ValueChanged As EventString
			Get
				Return Me.O.O_OO000_O0_0.
			End Get
			Set(value As EventString)
				Me.O.O_OO000_O0_0. = value
			End Set
		End Property

		' Token: 0x1700113B RID: 4411
		' (get) Token: 0x06004CB1 RID: 19633 RVA: 0x002011C2 File Offset: 0x001FF3C2
		' (set) Token: 0x06004CB2 RID: 19634 RVA: 0x002011C5 File Offset: 0x001FF3C5
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x1700113C RID: 4412
		' (get) Token: 0x06004CB3 RID: 19635 RVA: 0x002011C7 File Offset: 0x001FF3C7
		' (set) Token: 0x06004CB4 RID: 19636 RVA: 0x002011CA File Offset: 0x001FF3CA
		<Browsable(False)>
		Public Property SmallImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x1700113D RID: 4413
		' (get) Token: 0x06004CB5 RID: 19637 RVA: 0x002011CC File Offset: 0x001FF3CC
		' (set) Token: 0x06004CB6 RID: 19638 RVA: 0x002011DA File Offset: 0x001FF3DA
		<Browsable(False)>
		Public Property AutoHideText As Boolean
			Get
				Dim result As Boolean
				Return result
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x1700113E RID: 4414
		' (get) Token: 0x06004CB7 RID: 19639 RVA: 0x002011DC File Offset: 0x001FF3DC
		' (set) Token: 0x06004CB8 RID: 19640 RVA: 0x002011EA File Offset: 0x001FF3EA
		<Browsable(False)>
		Public Property TextImageRelation As TextImageRelationEnum
			Get
				Dim result As TextImageRelationEnum
				Return result
			End Get
			Set(value As TextImageRelationEnum)
			End Set
		End Property

		' Token: 0x04001F7F RID: 8063
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F80 RID: 8064
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F81 RID: 8065
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F82 RID: 8066
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F83 RID: 8067
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F84 RID: 8068
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
