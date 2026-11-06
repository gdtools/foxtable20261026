Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x0200016B RID: 363
	Friend Class WebViewerProperty
		Inherits ControlPropertyBase

		' Token: 0x060010DD RID: 4317 RVA: 0x0006AB1E File Offset: 0x00068D1E
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.AreDevToolsEnabled = True
			Me.AreSaveAsEnabled = True
			Me.AreDefaultContextMenusEnabled = True
			Me.AreBrowserAcceleratorKeysEnabled = True
			Me.o_0o0.0OOOo. = CType(A_0.ChildControl, oo00)
		End Sub

		' Token: 0x17000377 RID: 887
		' (get) Token: 0x060010DE RID: 4318 RVA: 0x0006AB54 File Offset: 0x00068D54
		' (set) Token: 0x060010DF RID: 4319 RVA: 0x0006AB5C File Offset: 0x00068D5C
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("允许开发者模式")>
		<Category("基本")>
		<DefaultValue(True)>
		Public Property AreDevToolsEnabled As Boolean

		' Token: 0x17000378 RID: 888
		' (get) Token: 0x060010E0 RID: 4320 RVA: 0x0006AB65 File Offset: 0x00068D65
		' (set) Token: 0x060010E1 RID: 4321 RVA: 0x0006AB6D File Offset: 0x00068D6D
		<O_Oo00Oo000O0(9.0)>
		<DefaultValue(True)>
		<DisplayName("允许另存为")>
		<Category("基本")>
		Public Property AreSaveAsEnabled As Boolean

		' Token: 0x17000379 RID: 889
		' (get) Token: 0x060010E2 RID: 4322 RVA: 0x0006AB76 File Offset: 0x00068D76
		' (set) Token: 0x060010E3 RID: 4323 RVA: 0x0006AB7E File Offset: 0x00068D7E
		<O_Oo00Oo000O0(10.0)>
		<Category("基本")>
		<DisplayName("允许快捷菜单")>
		<DefaultValue(True)>
		Public Property AreDefaultContextMenusEnabled As Boolean

		' Token: 0x1700037A RID: 890
		' (get) Token: 0x060010E4 RID: 4324 RVA: 0x0006AB87 File Offset: 0x00068D87
		' (set) Token: 0x060010E5 RID: 4325 RVA: 0x0006AB8F File Offset: 0x00068D8F
		<DefaultValue(True)>
		<DisplayName("允许快捷键")>
		<O_Oo00Oo000O0(11.0)>
		<Category("基本")>
		Public Property AreBrowserAcceleratorKeysEnabled As Boolean

		' Token: 0x1700037B RID: 891
		' (get) Token: 0x060010E6 RID: 4326 RVA: 0x0006AB98 File Offset: 0x00068D98
		' (set) Token: 0x060010E7 RID: 4327 RVA: 0x0006ABA0 File Offset: 0x00068DA0
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("6207")>
		<O_Oo00Oo000O0(1.0)>
		<Category("导航")>
		<O0O0oOO00_0OO(True)>
		<Description("导航开始时执行")>
		Public Property NavigationStarting As EventString
			Get
				Return Me.oOooO.ooO_O00.
			End Get
			Set(value As EventString)
				Me.oOooO.ooO_O00. = value
			End Set
		End Property

		' Token: 0x1700037C RID: 892
		' (get) Token: 0x060010E8 RID: 4328 RVA: 0x0006ABA9 File Offset: 0x00068DA9
		' (set) Token: 0x060010E9 RID: 4329 RVA: 0x0006ABB1 File Offset: 0x00068DB1
		<oO0oooo("6213")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("导航")>
		<Description("导航结束时执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property NavigationCompleted As EventString
			Get
				Return Me.O.O_O0O_0.
			End Get
			Set(value As EventString)
				Me.O.O_O0O_0. = value
			End Set
		End Property

		' Token: 0x1700037D RID: 893
		' (get) Token: 0x060010EA RID: 4330 RVA: 0x0006ABBA File Offset: 0x00068DBA
		' (set) Token: 0x060010EB RID: 4331 RVA: 0x0006ABC2 File Offset: 0x00068DC2
		<Description("Source属性发生变化后触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(2.0)>
		<oO0oooo("6209")>
		<Category("导航")>
		<O0O0oOO00_0OO(True)>
		Public Property SourceChanged As EventString
			Get
				Return Me.oO0O_O0.0O.
			End Get
			Set(value As EventString)
				Me.oO0O_O0.0O. = value
			End Set
		End Property

		' Token: 0x1700037E RID: 894
		' (get) Token: 0x060010EC RID: 4332 RVA: 0x0006ABCB File Offset: 0x00068DCB
		' (set) Token: 0x060010ED RID: 4333 RVA: 0x0006ABD3 File Offset: 0x00068DD3
		<O_Oo00Oo000O0(2.5)>
		<Category("导航")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("6214")>
		<Description("发送单个资源请求前触发")>
		<O0O0oOO00_0OO(True)>
		Public Property WebResourceRequested As EventString
			Get
				Return Me.o00O00O._.
			End Get
			Set(value As EventString)
				Me.o00O00O._. = value
			End Set
		End Property

		' Token: 0x1700037F RID: 895
		' (get) Token: 0x060010EE RID: 4334 RVA: 0x0006ABDC File Offset: 0x00068DDC
		' (set) Token: 0x060010EF RID: 4335 RVA: 0x0006ABE4 File Offset: 0x00068DE4
		<Description("收到单个资源后执行")>
		<oO0oooo("6224")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("导航")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.6)>
		Public Property WebResourceResponseReceived As EventString
			Get
				Return Me.o0_o__O_O.00.
			End Get
			Set(value As EventString)
				Me.o0_o__O_O.00. = value
			End Set
		End Property

		' Token: 0x17000380 RID: 896
		' (get) Token: 0x060010F0 RID: 4336 RVA: 0x0006ABED File Offset: 0x00068DED
		' (set) Token: 0x060010F1 RID: 4337 RVA: 0x0006ABF5 File Offset: 0x00068DF5
		<O_Oo00Oo000O0(4.0)>
		<oO0oooo("6212")>
		<Category("导航")>
		<Description("页面 DOM 解析完成后触发")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property DOMContentLoaded As EventString
			Get
				Return Me.O0O_Oo_o.o.
			End Get
			Set(value As EventString)
				Me.O0O_Oo_o.o. = value
			End Set
		End Property

		' Token: 0x17000381 RID: 897
		' (get) Token: 0x060010F2 RID: 4338 RVA: 0x0006ABFE File Offset: 0x00068DFE
		' (set) Token: 0x060010F3 RID: 4339 RVA: 0x0006AC06 File Offset: 0x00068E06
		<Description("页面内容开始加载时触发")>
		<Category("导航")>
		<oO0oooo("6210")>
		<O_Oo00Oo000O0(3.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property ContentLoading As EventString
			Get
				Return Me.o_O0o.__.
			End Get
			Set(value As EventString)
				Me.o_O0o.__. = value
			End Set
		End Property

		' Token: 0x17000382 RID: 898
		' (get) Token: 0x060010F4 RID: 4340 RVA: 0x0006AC0F File Offset: 0x00068E0F
		' (set) Token: 0x060010F5 RID: 4341 RVA: 0x0006AC17 File Offset: 0x00068E17
		<oO0oooo("")>
		<O_Oo00Oo000O0(7.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("导航")>
		<Description("网页缩放倍数发生变化后触发")>
		Public Property ZoomFactorChanged As EventString
			Get
				Return Me.O0O00._0_O000.
			End Get
			Set(value As EventString)
				Me.O0O00._0_O000. = value
			End Set
		End Property

		' Token: 0x17000383 RID: 899
		' (get) Token: 0x060010F6 RID: 4342 RVA: 0x0006AC20 File Offset: 0x00068E20
		' (set) Token: 0x060010F7 RID: 4343 RVA: 0x0006AC28 File Offset: 0x00068E28
		<O_Oo00Oo000O0(8.0)>
		<Description("网页缩放倍数发生变化后触发")>
		<O0O0oOO00_0OO(True)>
		<Category("导航")>
		<oO0oooo("6211")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property HistoryChanged As EventString
			Get
				Return Me.Ooo000_o_o._.
			End Get
			Set(value As EventString)
				Me.Ooo000_o_o._. = value
			End Set
		End Property

		' Token: 0x17000384 RID: 900
		' (get) Token: 0x060010F8 RID: 4344 RVA: 0x0006AC31 File Offset: 0x00068E31
		' (set) Token: 0x060010F9 RID: 4345 RVA: 0x0006AC39 File Offset: 0x00068E39
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("6208")>
		<O_Oo00Oo000O0(1.1)>
		<Description("需要打开新的浏览器窗口时触发")>
		<Category("导航")>
		<O0O0oOO00_0OO(True)>
		Public Property NewWindowRequested As EventString
			Get
				Return Me.o_o00O._.
			End Get
			Set(value As EventString)
				Me.o_o00O._. = value
			End Set
		End Property

		' Token: 0x17000385 RID: 901
		' (get) Token: 0x060010FA RID: 4346 RVA: 0x0006AC42 File Offset: 0x00068E42
		' (set) Token: 0x060010FB RID: 4347 RVA: 0x0006AC4A File Offset: 0x00068E4A
		<Category("交互")>
		<oO0oooo("6225")>
		<Description("收到网页端发来的信息时触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.0)>
		<O0O0oOO00_0OO(True)>
		Public Property WebMessageReceived As EventString
			Get
				Return Me.oO.O0_o_Oo____.
			End Get
			Set(value As EventString)
				Me.oO.O0_o_Oo____. = value
			End Set
		End Property

		' Token: 0x17000386 RID: 902
		' (get) Token: 0x060010FC RID: 4348 RVA: 0x0006AC53 File Offset: 0x00068E53
		' (set) Token: 0x060010FD RID: 4349 RVA: 0x0006AC5B File Offset: 0x00068E5B
		<Description("即将显示上下文菜单时触发")>
		<oO0oooo("6397")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(1.0)>
		<Category("交互")>
		<O0O0oOO00_0OO(True)>
		Public Property ContextMenuRequested As EventString
			Get
				Return Me.o.oo0o.
			End Get
			Set(value As EventString)
				Me.o.oo0o. = value
			End Set
		End Property

		' Token: 0x17000387 RID: 903
		' (get) Token: 0x060010FE RID: 4350 RVA: 0x0006AC64 File Offset: 0x00068E64
		' (set) Token: 0x060010FF RID: 4351 RVA: 0x0006AC6C File Offset: 0x00068E6C
		<Description("状态栏文本发生变化时执行")>
		<oO0oooo("6269")>
		<O_Oo00Oo000O0(2.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("交互")>
		<O0O0oOO00_0OO(True)>
		Public Property StatusBarTextChanged As EventString
			Get
				Return Me.O__0._O.
			End Get
			Set(value As EventString)
				Me.O__0._O. = value
			End Set
		End Property

		' Token: 0x17000388 RID: 904
		' (get) Token: 0x06001100 RID: 4352 RVA: 0x0006AC75 File Offset: 0x00068E75
		' (set) Token: 0x06001101 RID: 4353 RVA: 0x0006AC7D File Offset: 0x00068E7D
		<Description("JavaScript对话框显示前执行")>
		<oO0oooo("6270")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("交互")>
		<O_Oo00Oo000O0(3.0)>
		<O0O0oOO00_0OO(True)>
		Public Property ScriptDialogOpening As EventString
			Get
				Return Me.o_.Oooo_O0o.
			End Get
			Set(value As EventString)
				Me.o_.Oooo_O0o. = value
			End Set
		End Property

		' Token: 0x17000389 RID: 905
		' (get) Token: 0x06001102 RID: 4354 RVA: 0x0006AC86 File Offset: 0x00068E86
		' (set) Token: 0x06001103 RID: 4355 RVA: 0x0006AC8E File Offset: 0x00068E8E
		<Category("下载")>
		<oO0oooo("6991")>
		<Description("开始下载文件时触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property DownloadStarting As EventString
			Get
				Return Me.OO._oOo0o0OO.
			End Get
			Set(value As EventString)
				Me.OO._oOo0o0OO. = value
			End Set
		End Property

		' Token: 0x1700038A RID: 906
		' (get) Token: 0x06001104 RID: 4356 RVA: 0x0006AC97 File Offset: 0x00068E97
		' (set) Token: 0x06001105 RID: 4357 RVA: 0x0006AC9F File Offset: 0x00068E9F
		<oO0oooo("6990")>
		<Description("文件下载状态发生改变后触发")>
		<Category("下载")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property DownloadStateChanged As EventString
			Get
				Return Me.O0_o.o_00_0oO.
			End Get
			Set(value As EventString)
				Me.O0_o.o_00_0oO. = value
			End Set
		End Property

		' Token: 0x1700038B RID: 907
		' (get) Token: 0x06001106 RID: 4358 RVA: 0x0006ACA8 File Offset: 0x00068EA8
		' (set) Token: 0x06001107 RID: 4359 RVA: 0x0006ACB0 File Offset: 0x00068EB0
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("下载进度发生变化后触发，1秒最多触发1次")>
		<O_Oo00Oo000O0(3.0)>
		<Category("下载")>
		<oO0oooo("6989")>
		Public Property DownloadProgressChanged As EventString
			Get
				Return Me.o00_oo.Oo0Oo_.
			End Get
			Set(value As EventString)
				Me.o00_oo.Oo0Oo_. = value
			End Set
		End Property

		' Token: 0x04000662 RID: 1634
		Private <<EMPTY_NAME>> As oo00

		' Token: 0x04000663 RID: 1635
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000664 RID: 1636
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000665 RID: 1637
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000666 RID: 1638
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000667 RID: 1639
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000668 RID: 1640
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000669 RID: 1641
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400066A RID: 1642
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400066B RID: 1643
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400066C RID: 1644
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400066D RID: 1645
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400066E RID: 1646
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400066F RID: 1647
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000670 RID: 1648
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000671 RID: 1649
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000672 RID: 1650
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000673 RID: 1651
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000674 RID: 1652
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000675 RID: 1653
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000676 RID: 1654
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000677 RID: 1655
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
