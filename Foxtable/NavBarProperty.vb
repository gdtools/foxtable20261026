Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports C1.Win.C1Command

Namespace Foxtable
	' Token: 0x02000407 RID: 1031
	Friend Class NavBarProperty
		Inherits ControlPropertyBase

		' Token: 0x060043AE RID: 17326 RVA: 0x001C2318 File Offset: 0x001C0518
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.oO_o.0_o0_. = CType(A_0.ChildControl, O_OOO)
		End Sub

		' Token: 0x17000F2A RID: 3882
		' (get) Token: 0x060043AF RID: 17327 RVA: 0x001C2334 File Offset: 0x001C0534
		' (set) Token: 0x060043B0 RID: 17328 RVA: 0x001C2342 File Offset: 0x001C0542
		<Browsable(False)>
		<OooO0(False)>
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x17000F2B RID: 3883
		' (get) Token: 0x060043B1 RID: 17329 RVA: 0x001C2344 File Offset: 0x001C0544
		' (set) Token: 0x060043B2 RID: 17330 RVA: 0x001C2356 File Offset: 0x001C0556
		<O_Oo00Oo000O0(0.0)>
		<DefaultValue("(default)")>
		<Category("外观")>
		<DisplayName("样式")>
		<TypeConverter(GetType(o00))>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.oO_o.0_o0_.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.oO_o.0_o0_. })
			End Set
		End Property

		' Token: 0x17000F2C RID: 3884
		' (get) Token: 0x060043B3 RID: 17331 RVA: 0x001C2372 File Offset: 0x001C0572
		' (set) Token: 0x060043B4 RID: 17332 RVA: 0x001C237F File Offset: 0x001C057F
		<DefaultValue("宋体,9")>
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<DisplayName("按钮字体")>
		<Category("外观")>
		Public Property ButtonFont As Font
			Get
				Return Me.oO_o.0_o0_..ButtonFont
			End Get
			Set(value As Font)
				Me.oO_o.0_o0_..ButtonFont = value
			End Set
		End Property

		' Token: 0x17000F2D RID: 3885
		' (get) Token: 0x060043B5 RID: 17333 RVA: 0x001C238D File Offset: 0x001C058D
		' (set) Token: 0x060043B6 RID: 17334 RVA: 0x001C239A File Offset: 0x001C059A
		<Category("外观")>
		<O_Oo00Oo000O0(5.0)>
		<MergableProperty(True)>
		<DefaultValue(32)>
		<DisplayName("按钮高度")>
		Public Property ButtonHeight As Integer
			Get
				Return Me.oO_o.0_o0_..ButtonHeight
			End Get
			Set(value As Integer)
				Me.oO_o.0_o0_..ButtonHeight = value
			End Set
		End Property

		' Token: 0x17000F2E RID: 3886
		' (get) Token: 0x060043B7 RID: 17335 RVA: 0x001C23A8 File Offset: 0x001C05A8
		' (set) Token: 0x060043B8 RID: 17336 RVA: 0x001C23B5 File Offset: 0x001C05B5
		<MergableProperty(True)>
		<Category("外观")>
		<DisplayName("图标大小")>
		<O_Oo00Oo000O0(6.0)>
		Public Property ButtonImageSize As Size
			Get
				Return Me.oO_o.0_o0_..ImageScalingSize
			End Get
			Set(value As Size)
				Me.oO_o.0_o0_..ImageScalingSize = value
			End Set
		End Property

		' Token: 0x17000F2F RID: 3887
		' (get) Token: 0x060043B9 RID: 17337 RVA: 0x001C23C3 File Offset: 0x001C05C3
		' (set) Token: 0x060043BA RID: 17338 RVA: 0x001C23D0 File Offset: 0x001C05D0
		<O_Oo00Oo000O0(7.0)>
		<MergableProperty(True)>
		<DefaultValue("宋体,9")>
		<DisplayName("标题字体")>
		<Category("外观")>
		Public Property HeaderFont As Font
			Get
				Return Me.oO_o.0_o0_..PanelHeaderFont
			End Get
			Set(value As Font)
				Me.oO_o.0_o0_..PanelHeaderFont = value
			End Set
		End Property

		' Token: 0x17000F30 RID: 3888
		' (get) Token: 0x060043BB RID: 17339 RVA: 0x001C23DE File Offset: 0x001C05DE
		' (set) Token: 0x060043BC RID: 17340 RVA: 0x001C23EB File Offset: 0x001C05EB
		<Category("外观")>
		<O_Oo00Oo000O0(8.0)>
		<MergableProperty(True)>
		<DefaultValue(24)>
		<DisplayName("标题高度")>
		Public Property HeaderHeight As Integer
			Get
				Return Me.oO_o.0_o0_..PanelHeaderHeight
			End Get
			Set(value As Integer)
				Me.oO_o.0_o0_..PanelHeaderHeight = value
			End Set
		End Property

		' Token: 0x17000F31 RID: 3889
		' (get) Token: 0x060043BD RID: 17341 RVA: 0x001C23F9 File Offset: 0x001C05F9
		' (set) Token: 0x060043BE RID: 17342 RVA: 0x001C2406 File Offset: 0x001C0606
		<O_Oo00Oo000O0(9.0)>
		<Category("外观")>
		<MergableProperty(True)>
		<Description("多余的按钮显示在水平栏，设为-1会显示所有按钮。")>
		<DefaultValue(5)>
		<DisplayName("显示按钮数")>
		Public Property StackButtonCount As Integer
			Get
				Return Me.oO_o.0_o0_..StackButtonCount
			End Get
			Set(value As Integer)
				Me.oO_o.0_o0_..StackButtonCount = value
			End Set
		End Property

		' Token: 0x17000F32 RID: 3890
		' (get) Token: 0x060043BF RID: 17343 RVA: 0x001C2414 File Offset: 0x001C0614
		' (set) Token: 0x060043C0 RID: 17344 RVA: 0x001C2421 File Offset: 0x001C0621
		<DisplayName("水平栏高度")>
		<DefaultValue(30)>
		<O_Oo00Oo000O0(10.0)>
		<Category("外观")>
		<MergableProperty(True)>
		<Description("如果不需要在水平栏显示内容，可设为0")>
		Public Property StripHeight As Integer
			Get
				Return Me.oO_o.0_o0_..StripHeight
			End Get
			Set(value As Integer)
				Me.oO_o.0_o0_..StripHeight = value
			End Set
		End Property

		' Token: 0x17000F33 RID: 3891
		' (get) Token: 0x060043C1 RID: 17345 RVA: 0x001C242F File Offset: 0x001C062F
		' (set) Token: 0x060043C2 RID: 17346 RVA: 0x001C2441 File Offset: 0x001C0641
		<Category("选定页面")>
		<OooO0(True)>
		<DisplayName("页面名称")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.0)>
		Public Property SelectedPageNamet As String
			Get
				Return Me.oO_o.0_o0_..SelectedPanel.Name
			End Get
			Set(value As String)
				Me.oO_o.0_o0_..SelectedPanel.Name = value
			End Set
		End Property

		' Token: 0x17000F34 RID: 3892
		' (get) Token: 0x060043C3 RID: 17347 RVA: 0x001C2454 File Offset: 0x001C0654
		' (set) Token: 0x060043C4 RID: 17348 RVA: 0x001C2466 File Offset: 0x001C0666
		<Category("选定页面")>
		<MergableProperty(True)>
		<OooO0(True)>
		<DisplayName("页面标题")>
		<O_Oo00Oo000O0(1.0)>
		Public Property SelectedHeaderText As String
			Get
				Return Me.oO_o.0_o0_..SelectedButton.PanelHeader
			End Get
			Set(value As String)
				Me.oO_o.0_o0_..SelectedButton.PanelHeader = value
			End Set
		End Property

		' Token: 0x17000F35 RID: 3893
		' (get) Token: 0x060043C5 RID: 17349 RVA: 0x001C2479 File Offset: 0x001C0679
		' (set) Token: 0x060043C6 RID: 17350 RVA: 0x001C248B File Offset: 0x001C068B
		<DisplayName("按钮标题")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<OooO0(True)>
		<Category("选定页面")>
		Public Property SelectedButtonText As String
			Get
				Return Me.oO_o.0_o0_..SelectedButton.Text
			End Get
			Set(value As String)
				Me.oO_o.0_o0_..SelectedButton.Text = value
			End Set
		End Property

		' Token: 0x17000F36 RID: 3894
		' (get) Token: 0x060043C7 RID: 17351 RVA: 0x001C249E File Offset: 0x001C069E
		' (set) Token: 0x060043C8 RID: 17352 RVA: 0x001C24B5 File Offset: 0x001C06B5
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<DisplayName("按钮图标")>
		<Category("选定页面")>
		<OooO0(True)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property SelectedButtonImage As String
			Get
				Return CType(Me.oO_o.0_o0_..SelectedPanel, oO_0).ImageFile
			End Get
			Set(value As String)
				CType(Me.oO_o.0_o0_..SelectedPanel, oO_0).ImageFile = value
			End Set
		End Property

		' Token: 0x17000F37 RID: 3895
		' (get) Token: 0x060043C9 RID: 17353 RVA: 0x001C24CD File Offset: 0x001C06CD
		' (set) Token: 0x060043CA RID: 17354 RVA: 0x001C24E4 File Offset: 0x001C06E4
		<DisplayName("按钮小图标")>
		<OooO0(True)>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Category("选定页面")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property SelectedButtonSmallImage As String
			Get
				Return CType(Me.oO_o.0_o0_..SelectedPanel, oO_0).oOo_._0__0o_0o.()
			End Get
			Set(value As String)
				CType(Me.oO_o.0_o0_..SelectedPanel, oO_0).oOo_._0__0o_0o.(value)
			End Set
		End Property

		' Token: 0x17000F38 RID: 3896
		' (get) Token: 0x060043CB RID: 17355 RVA: 0x001C24FC File Offset: 0x001C06FC
		' (set) Token: 0x060043CC RID: 17356 RVA: 0x001C2504 File Offset: 0x001C0704
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0876")>
		<O_Oo00Oo000O0(0.1)>
		<Description("选定不同页面后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.oO_o.0_o0_.
			End Get
			Set(value As EventString)
				Me.oO_o.0_o0_. = value
			End Set
		End Property

		' Token: 0x17000F39 RID: 3897
		' (get) Token: 0x060043CD RID: 17357 RVA: 0x001C2510 File Offset: 0x001C0710
		' (set) Token: 0x060043CE RID: 17358 RVA: 0x001C258C File Offset: 0x001C078C
		<Browsable(False)>
		Public Property Panels As String
			Get
				Dim text As String = Nothing
				Dim num As Integer = Me.oO_o.0_o0_..Panels.Count - 1
				For i As Integer = 0 To num
					Dim a_ As CustomNavBarPanelProperty = New CustomNavBarPanelProperty(CType(Me.oO_o.0_o0_..Panels(i), oO_0))
					If i > 0 Then
						text += vbFormFeed
					End If
					text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbTab, False).Replace(vbFormFeed, "")
				Next
				Return text
			End Get
			Set(value As String)
				Dim array As String() = value.Split(New Char() { vbFormFeed })
				Me.oO_o.0_o0_..Panels.Clear()
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim oO_ As oO_0 = MyBase.Holder.oo_.o_O.()
					Dim a_ As Object = New CustomNavBarPanelProperty(oO_)
					Me.oO_o.0_o0_..Panels.Add(oO_)
					o_O_o_oOoo__.OOOO_OO._oo.(a_, array(i), vbTab)
				Next
			End Set
		End Property

		' Token: 0x04001BA5 RID: 7077
		Private <<EMPTY_NAME>> As O_OOO

		' Token: 0x04001BA6 RID: 7078
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
