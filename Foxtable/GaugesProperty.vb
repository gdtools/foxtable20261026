Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports C1.Win.C1Gauge

Namespace Foxtable
	' Token: 0x02000168 RID: 360
	Friend Class GaugesProperty
		Inherits ControlPropertyBase

		' Token: 0x06001087 RID: 4231 RVA: 0x0006A318 File Offset: 0x00068518
		Friend Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o_0__oo.oo_. = CType(A_0.ChildControl, O0_O_0O)
		End Sub

		' Token: 0x1700034C RID: 844
		' (get) Token: 0x06001088 RID: 4232 RVA: 0x0006A332 File Offset: 0x00068532
		<Editor(GetType(o__OO), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(12.0)>
		<MergableProperty(True)>
		<OooO0(True)>
		<Category("基本")>
		Public ReadOnly Property Gauges As GaugeCollection
			Get
				Return Me.o_0__oo.oo_..Gauges
			End Get
		End Property

		' Token: 0x1700034D RID: 845
		' (get) Token: 0x06001089 RID: 4233 RVA: 0x0006A33F File Offset: 0x0006853F
		<Category("杂项")>
		<O_Oo00Oo000O0(-19.0)>
		<MergableProperty(True)>
		<Editor(GetType(oo_OOOOooO), GetType(UITypeEditor))>
		<OooO0(True)>
		Public ReadOnly Property FaceShapes As ShapeCollection
			Get
				Return Me.o_0__oo.oo_..FaceShapes
			End Get
		End Property

		' Token: 0x1700034E RID: 846
		' (get) Token: 0x0600108A RID: 4234 RVA: 0x0006A34C File Offset: 0x0006854C
		<Editor(GetType(oo_OOOOooO), GetType(UITypeEditor))>
		<OooO0(True)>
		<Category("杂项")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(-20.0)>
		Public ReadOnly Property CoverShapes As ShapeCollection
			Get
				Return Me.o_0__oo.oo_..CoverShapes
			End Get
		End Property

		' Token: 0x1700034F RID: 847
		' (get) Token: 0x0600108B RID: 4235 RVA: 0x0006A359 File Offset: 0x00068559
		' (set) Token: 0x0600108C RID: 4236 RVA: 0x0006A361 File Offset: 0x00068561
		<O_Oo00Oo000O0(0.5)>
		<Category("Gauge事件")>
		<oO0oooo("3920")>
		<DisplayName("ItemClick")>
		<Description("单击某个组件时触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property GaugeItemClick As EventString
			Get
				Return Me.O_oO.o.
			End Get
			Set(value As EventString)
				Me.O_oO.o. = value
			End Set
		End Property

		' Token: 0x17000350 RID: 848
		' (get) Token: 0x0600108D RID: 4237 RVA: 0x0006A36A File Offset: 0x0006856A
		' (set) Token: 0x0600108E RID: 4238 RVA: 0x0006A372 File Offset: 0x00068572
		<DisplayName("ItemDoubleClick")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("Gauge事件")>
		<O_Oo00Oo000O0(0.6)>
		<oO0oooo("3920")>
		<Description("双击某个组件时触发")>
		<O0O0oOO00_0OO(True)>
		Public Property GaugeItemDoubleClick As EventString
			Get
				Return Me.OOoOO_0O._ooO.
			End Get
			Set(value As EventString)
				Me.OOoOO_0O._ooO. = value
			End Set
		End Property

		' Token: 0x17000351 RID: 849
		' (get) Token: 0x0600108F RID: 4239 RVA: 0x0006A37B File Offset: 0x0006857B
		' (set) Token: 0x06001090 RID: 4240 RVA: 0x0006A383 File Offset: 0x00068583
		<oO0oooo("3920")>
		<Description("当鼠标悬停在某个组件并按下鼠标时触发")>
		<O0O0oOO00_0OO(True)>
		<DisplayName("ItemMouseDown")>
		<O_Oo00Oo000O0(0.7)>
		<Category("Gauge事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property GaugeItemMouseDown As EventString
			Get
				Return Me.oOoo0oO.oooO__.
			End Get
			Set(value As EventString)
				Me.oOoo0oO.oooO__. = value
			End Set
		End Property

		' Token: 0x17000352 RID: 850
		' (get) Token: 0x06001091 RID: 4241 RVA: 0x0006A38C File Offset: 0x0006858C
		' (set) Token: 0x06001092 RID: 4242 RVA: 0x0006A394 File Offset: 0x00068594
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("3920")>
		<Description("当鼠标悬停在某个组件并松开鼠标时触发")>
		<O_Oo00Oo000O0(0.8)>
		<DisplayName("ItemMouseUp")>
		<O0O0oOO00_0OO(True)>
		<Category("Gauge事件")>
		Public Property GaugeItemMouseUp As EventString
			Get
				Return Me.O_o0o_o.OOo.
			End Get
			Set(value As EventString)
				Me.O_o0o_o.OOo. = value
			End Set
		End Property

		' Token: 0x17000353 RID: 851
		' (get) Token: 0x06001093 RID: 4243 RVA: 0x0006A39D File Offset: 0x0006859D
		' (set) Token: 0x06001094 RID: 4244 RVA: 0x0006A3A5 File Offset: 0x000685A5
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("Gauge事件")>
		<DisplayName("ItemMouseEnter")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.9)>
		<Description("当鼠标进入某个组件时触发")>
		<oO0oooo("3920")>
		Public Property GaugeItemMouseEnter As EventString
			Get
				Return Me.OoO.OOO_OO00_o.
			End Get
			Set(value As EventString)
				Me.OoO.OOO_OO00_o. = value
			End Set
		End Property

		' Token: 0x17000354 RID: 852
		' (get) Token: 0x06001095 RID: 4245 RVA: 0x0006A3AE File Offset: 0x000685AE
		' (set) Token: 0x06001096 RID: 4246 RVA: 0x0006A3B6 File Offset: 0x000685B6
		<oO0oooo("3920")>
		<DisplayName("ItemMouseLeave")>
		<Description("当鼠标离开某个组件时触发")>
		<O0O0oOO00_0OO(True)>
		<Category("Gauge事件")>
		<O_Oo00Oo000O0(1.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property GaugeItemMouseLeave As EventString
			Get
				Return Me.O.__O0o__o.
			End Get
			Set(value As EventString)
				Me.O.__O0o__o. = value
			End Set
		End Property

		' Token: 0x17000355 RID: 853
		' (get) Token: 0x06001097 RID: 4247 RVA: 0x0006A3BF File Offset: 0x000685BF
		' (set) Token: 0x06001098 RID: 4248 RVA: 0x0006A3C7 File Offset: 0x000685C7
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("3920")>
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("ItemMouseMove")>
		<Description("当鼠标经过某个组件时触发")>
		<Category("Gauge事件")>
		<O0O0oOO00_0OO(True)>
		Public Property GaugeItemMouseMove As EventString
			Get
				Return Me.oo.OO0OOoO.
			End Get
			Set(value As EventString)
				Me.oo.OO0OOoO. = value
			End Set
		End Property

		' Token: 0x17000356 RID: 854
		' (get) Token: 0x06001099 RID: 4249 RVA: 0x0006A3D0 File Offset: 0x000685D0
		' (set) Token: 0x0600109A RID: 4250 RVA: 0x0006A3D8 File Offset: 0x000685D8
		<DisplayName("ItemStateChanged")>
		<oO0oooo("3920")>
		<O_Oo00Oo000O0(1.2)>
		<Description("当某个组件的状态改变时触发")>
		<Category("Gauge事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property GaugeItemStateChanged As EventString
			Get
				Return Me.oo_.o0_.
			End Get
			Set(value As EventString)
				Me.oo_.o0_. = value
			End Set
		End Property

		' Token: 0x17000357 RID: 855
		' (get) Token: 0x0600109B RID: 4251 RVA: 0x0006A3E1 File Offset: 0x000685E1
		' (set) Token: 0x0600109C RID: 4252 RVA: 0x0006A3E9 File Offset: 0x000685E9
		<Category("Gauge事件")>
		<O_Oo00Oo000O0(1.3)>
		<DisplayName("FormatLabel")>
		<oO0oooo("3929")>
		<Description("格式化标签时触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property GaugeFormatLabel As EventString
			Get
				Return Me.oO_oo_.00o_o.
			End Get
			Set(value As EventString)
				Me.oO_oo_.00o_o. = value
			End Set
		End Property

		' Token: 0x17000358 RID: 856
		' (get) Token: 0x0600109D RID: 4253 RVA: 0x0006A3F2 File Offset: 0x000685F2
		' (set) Token: 0x0600109E RID: 4254 RVA: 0x0006A3FA File Offset: 0x000685FA
		<oO0oooo("3934")>
		<Category("Gauge事件")>
		<DisplayName("PointerValueChanged")>
		<O_Oo00Oo000O0(1.4)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("指针值发生变化后触发")>
		<O0O0oOO00_0OO(True)>
		Public Property GaugePointerValueChanged As EventString
			Get
				Return Me.OO0o.OOO_oo0_.
			End Get
			Set(value As EventString)
				Me.OO0o.OOO_oo0_. = value
			End Set
		End Property

		' Token: 0x17000359 RID: 857
		' (get) Token: 0x0600109F RID: 4255 RVA: 0x0006A403 File Offset: 0x00068603
		' (set) Token: 0x060010A0 RID: 4256 RVA: 0x0006A40B File Offset: 0x0006860B
		<oO0oooo("3920")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("开始拖拽某个指针时触发")>
		<Category("Gauge事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property PointerDragBegin As EventString
			Get
				Return Me.o0OoO_000_._o.
			End Get
			Set(value As EventString)
				Me.o0OoO_000_._o. = value
			End Set
		End Property

		' Token: 0x1700035A RID: 858
		' (get) Token: 0x060010A1 RID: 4257 RVA: 0x0006A414 File Offset: 0x00068614
		' (set) Token: 0x060010A2 RID: 4258 RVA: 0x0006A41C File Offset: 0x0006861C
		<oO0oooo("3920")>
		<O_Oo00Oo000O0(0.3)>
		<Description("结束拖拽某个指针时触发")>
		<O0O0oOO00_0OO(True)>
		<Category("Gauge事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property PointerDragEnd As EventString
			Get
				Return Me.OO0o0O.0oooO.
			End Get
			Set(value As EventString)
				Me.OO0o0O.0oooO. = value
			End Set
		End Property

		' Token: 0x1700035B RID: 859
		' (get) Token: 0x060010A3 RID: 4259 RVA: 0x0006A425 File Offset: 0x00068625
		' (set) Token: 0x060010A4 RID: 4260 RVA: 0x0006A42D File Offset: 0x0006862D
		<O0O0oOO00_0OO(True)>
		<Category("Gauge事件")>
		<Description("按ESC键取消拖拽某个指针后触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("3920")>
		<O_Oo00Oo000O0(0.4)>
		Public Property PointerDragCancel As EventString
			Get
				Return Me.oOOO_.O0o.
			End Get
			Set(value As EventString)
				Me.oOOO_.O0o. = value
			End Set
		End Property

		' Token: 0x1700035C RID: 860
		' (get) Token: 0x060010A5 RID: 4261 RVA: 0x0006A436 File Offset: 0x00068636
		' (set) Token: 0x060010A6 RID: 4262 RVA: 0x0006A43E File Offset: 0x0006863E
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("在拖拽某个指针的过程中触发")>
		<oO0oooo("3920")>
		<Category("Gauge事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property PointerDragMove As EventString
			Get
				Return Me.oo_0oo_O.OO0o.
			End Get
			Set(value As EventString)
				Me.oo_0oo_O.OO0o. = value
			End Set
		End Property

		' Token: 0x1700035D RID: 861
		' (get) Token: 0x060010A7 RID: 4263 RVA: 0x0006A447 File Offset: 0x00068647
		' (set) Token: 0x060010A8 RID: 4264 RVA: 0x0006A44F File Offset: 0x0006864F
		<O_Oo00Oo000O0(3.0)>
		<Category("外观")>
		<MergableProperty(False)>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<DisplayName("背景图片")>
		Public Property BackGroundImageFile As String
			Get
				Return Me.O_oO.o.
			End Get
			Set(value As String)
				Me.O_oO.o. = value
				Me.o_0__oo.oo_..BackgroundImage = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x1700035E RID: 862
		' (get) Token: 0x060010A9 RID: 4265 RVA: 0x0006A469 File Offset: 0x00068669
		' (set) Token: 0x060010AA RID: 4266 RVA: 0x0006A476 File Offset: 0x00068676
		<MergableProperty(False)>
		<DefaultValue(1)>
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("背景布局")>
		<Category("外观")>
		Public Property BackgroundImageLayout As ImageLayout
			Get
				Return Me.o_0__oo.oo_..BackgroundImageLayout
			End Get
			Set(value As ImageLayout)
				Me.o_0__oo.oo_..BackgroundImageLayout = value
			End Set
		End Property

		' Token: 0x1700035F RID: 863
		' (get) Token: 0x060010AB RID: 4267 RVA: 0x0006A484 File Offset: 0x00068684
		' (set) Token: 0x060010AC RID: 4268 RVA: 0x0006A4C4 File Offset: 0x000686C4
		<Browsable(False)>
		Public Property Settings As String
			Get
				Dim tempFileName As String = Path.GetTempFileName()
				Me.o_0__oo.oo_..Save(tempFileName, Encoding.UTF8)
				Dim result As String = OO_00oOO.FileSys.ReadAllText(tempFileName, Encoding.UTF8)
				OO_00oOO.FileSys.DeleteFile(tempFileName)
				Return result
			End Get
			Set(value As String)
				Dim xmlDocument As XmlDocument = New XmlDocument()
				xmlDocument.LoadXml(value)
				Me.o_0__oo.oo_..Load(xmlDocument)
			End Set
		End Property

		' Token: 0x04000647 RID: 1607
		Private <<EMPTY_NAME>> As O0_O_0O

		' Token: 0x04000648 RID: 1608
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000649 RID: 1609
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400064A RID: 1610
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400064B RID: 1611
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400064C RID: 1612
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400064D RID: 1613
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400064E RID: 1614
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400064F RID: 1615
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000650 RID: 1616
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000651 RID: 1617
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000652 RID: 1618
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000653 RID: 1619
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000654 RID: 1620
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000655 RID: 1621
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000656 RID: 1622
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
