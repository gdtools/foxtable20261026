Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports C1.Win.Interop
Imports C1.Win.Map
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000169 RID: 361
	Friend Class MapProperty
		Inherits ControlPropertyBase

		' Token: 0x060010AD RID: 4269 RVA: 0x0006A4EA File Offset: 0x000686EA
		Friend Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O_.OOO_O_. = TileSoureEnum.None
			Me.O_.OOO_O_. = CType(A_0.ChildControl, GeoMap)
		End Sub

		' Token: 0x17000360 RID: 864
		' (get) Token: 0x060010AE RID: 4270 RVA: 0x0006A50B File Offset: 0x0006870B
		' (set) Token: 0x060010AF RID: 4271 RVA: 0x0006A514 File Offset: 0x00068714
		<O_Oo00Oo000O0(1.0)>
		<Category("地图")>
		<DisplayName("地图来源")>
		<DefaultValue(0)>
		Public Property TileSource As TileSoureEnum
			Get
				Return Me.O_.OOO_O_.
			End Get
			Set(value As TileSoureEnum)
				Me.O_.OOO_O_. = value
				Select Case value
					Case TileSoureEnum.None, TileSoureEnum.Custom
						Me.O_.OOO_O_..TileLayer.TileSource = Nothing
						Return
					Case TileSoureEnum.Road
						Me.O_.OOO_O_..TileLayer.TileSource = New VirtualEarthRoadSource()
						Return
					Case TileSoureEnum.Aerial
						Me.O_.OOO_O_..TileLayer.TileSource = New VirtualEarthAerialSource()
						Return
					Case TileSoureEnum.Hybrid
						Me.O_.OOO_O_..TileLayer.TileSource = New VirtualEarthHybridSource()
						Return
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x17000361 RID: 865
		' (get) Token: 0x060010B0 RID: 4272 RVA: 0x0006A598 File Offset: 0x00068798
		' (set) Token: 0x060010B1 RID: 4273 RVA: 0x0006A5A0 File Offset: 0x000687A0
		<Description("获取地图瓦片的时候执行")>
		<oO0oooo("")>
		<O_Oo00Oo000O0(1.0)>
		<Category("地图")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property GetMapTile As EventString
			Get
				Return Me.Oo._oooO.
			End Get
			Set(value As EventString)
				Me.Oo._oooO. = value
			End Set
		End Property

		' Token: 0x17000362 RID: 866
		' (get) Token: 0x060010B2 RID: 4274 RVA: 0x0006A5A9 File Offset: 0x000687A9
		' (set) Token: 0x060010B3 RID: 4275 RVA: 0x0006A5B1 File Offset: 0x000687B1
		<oO0oooo("")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("地图")>
		<Description("绘制自定义标记的时候执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property OwerDrawMark As EventString
			Get
				Return Me.OO__Oo_oo_._.
			End Get
			Set(value As EventString)
				Me.OO__Oo_oo_._. = value
			End Set
		End Property

		' Token: 0x17000363 RID: 867
		' (get) Token: 0x060010B4 RID: 4276 RVA: 0x0006A5BA File Offset: 0x000687BA
		' (set) Token: 0x060010B5 RID: 4277 RVA: 0x0006A5C2 File Offset: 0x000687C2
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("")>
		<O_Oo00Oo000O0(4.0)>
		<Description("获取自定义形状的绘制区域时执行")>
		<Category("地图")>
		<O0O0oOO00_0OO(True)>
		Public Property GetDrawingBounds As EventString
			Get
				Return Me.oooOOo._oOo__0.
			End Get
			Set(value As EventString)
				Me.oooOOo._oOo__0. = value
			End Set
		End Property

		' Token: 0x17000364 RID: 868
		' (get) Token: 0x060010B6 RID: 4278 RVA: 0x0006A5CB File Offset: 0x000687CB
		' (set) Token: 0x060010B7 RID: 4279 RVA: 0x0006A5D3 File Offset: 0x000687D3
		<Category("地图")>
		<Description("绘制虚拟矢量层的时候执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(3.0)>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("")>
		Public Property GetVirtualItems As EventString
			Get
				Return Me.Oo_o._O00O.
			End Get
			Set(value As EventString)
				Me.Oo_o._O00O. = value
			End Set
		End Property

		' Token: 0x17000365 RID: 869
		' (get) Token: 0x060010B8 RID: 4280 RVA: 0x0006A5DC File Offset: 0x000687DC
		' (set) Token: 0x060010B9 RID: 4281 RVA: 0x0006A5E4 File Offset: 0x000687E4
		<oO0oooo("")>
		<O_Oo00Oo000O0(5.0)>
		<Description("地图中心位置发生改变的时候执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("地图")>
		Public Property CenterChanged As EventString
			Get
				Return Me.O_oOooooo.00O.
			End Get
			Set(value As EventString)
				Me.O_oOooooo.00O. = value
			End Set
		End Property

		' Token: 0x17000366 RID: 870
		' (get) Token: 0x060010BA RID: 4282 RVA: 0x0006A5ED File Offset: 0x000687ED
		' (set) Token: 0x060010BB RID: 4283 RVA: 0x0006A5F5 File Offset: 0x000687F5
		<Description("地图中心位置发生改变的时候执行")>
		<O_Oo00Oo000O0(5.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("")>
		<Category("地图")>
		<O0O0oOO00_0OO(True)>
		Public Property ZoomChanged As EventString
			Get
				Return Me.ooOo__0o0._oO.
			End Get
			Set(value As EventString)
				Me.ooOo__0o0._oO. = value
			End Set
		End Property

		' Token: 0x17000367 RID: 871
		' (get) Token: 0x060010BC RID: 4284 RVA: 0x0006A5FE File Offset: 0x000687FE
		' (set) Token: 0x060010BD RID: 4285 RVA: 0x0006A616 File Offset: 0x00068816
		<DisplayName("缩放级别")>
		<Category("地图")>
		<O_Oo00Oo000O0(2.0)>
		Public Property Zoom As Double
			Get
				Return Math.Round(Me.O_.OOO_O_..Viewport.Zoom, 6)
			End Get
			Set(value As Double)
				Me.O_.OOO_O_..Viewport.Zoom = value
			End Set
		End Property

		' Token: 0x17000368 RID: 872
		' (get) Token: 0x060010BE RID: 4286 RVA: 0x0006A629 File Offset: 0x00068829
		' (set) Token: 0x060010BF RID: 4287 RVA: 0x0006A63B File Offset: 0x0006883B
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("最大缩放")>
		<Category("地图")>
		Public Property MaxZoom As Double
			Get
				Return Me.O_.OOO_O_..Viewport.MaxZoom
			End Get
			Set(value As Double)
				Me.O_.OOO_O_..Viewport.MaxZoom = Math.Min(value, 20.0)
			End Set
		End Property

		' Token: 0x17000369 RID: 873
		' (get) Token: 0x060010C0 RID: 4288 RVA: 0x0006A65C File Offset: 0x0006885C
		' (set) Token: 0x060010C1 RID: 4289 RVA: 0x0006A66E File Offset: 0x0006886E
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(0)>
		<Category("地图")>
		<DisplayName("最小缩放")>
		Public Property MinZoom As Double
			Get
				Return Me.O_.OOO_O_..Viewport.MinZoom
			End Get
			Set(value As Double)
				Me.O_.OOO_O_..Viewport.MinZoom = Math.Max(0.0, value)
			End Set
		End Property

		' Token: 0x1700036A RID: 874
		' (get) Token: 0x060010C2 RID: 4290 RVA: 0x0006A690 File Offset: 0x00068890
		' (set) Token: 0x060010C3 RID: 4291 RVA: 0x0006A6BC File Offset: 0x000688BC
		<DisplayName("中心经度")>
		<O_Oo00Oo000O0(5.0)>
		<Category("地图")>
		<DefaultValue(103.72)>
		Public Property CenterX As Double
			Get
				Return Math.Round(Me.O_.OOO_O_..Viewport.Center.X, 6)
			End Get
			Set(value As Double)
				Me.O_.OOO_O_..Viewport.Center = New Point(value, Me.O_.OOO_O_..Viewport.Center.Y)
			End Set
		End Property

		' Token: 0x1700036B RID: 875
		' (get) Token: 0x060010C4 RID: 4292 RVA: 0x0006A6F8 File Offset: 0x000688F8
		' (set) Token: 0x060010C5 RID: 4293 RVA: 0x0006A724 File Offset: 0x00068924
		<O_Oo00Oo000O0(6.0)>
		<DefaultValue(34.5)>
		<Category("地图")>
		<DisplayName("中心维度")>
		Public Property CenterY As Double
			Get
				Return Math.Round(Me.O_.OOO_O_..Viewport.Center.Y, 6)
			End Get
			Set(value As Double)
				Me.O_.OOO_O_..Viewport.Center = New Point(Me.O_.OOO_O_..Viewport.Center.X, value)
			End Set
		End Property

		' Token: 0x1700036C RID: 876
		' (get) Token: 0x060010C6 RID: 4294 RVA: 0x0006A760 File Offset: 0x00068960
		' (set) Token: 0x060010C7 RID: 4295 RVA: 0x0006A7B0 File Offset: 0x000689B0
		<DefaultValue("")>
		<Category("地图")>
		<DisplayName("最小经度")>
		<O_Oo00Oo000O0(7.0)>
		Public Property MinX As String
			Get
				Dim result As String
				If Double.IsNaN(Me.O_.OOO_O_..Viewport.Limits.MinLong) Then
					result = ""
				Else
					result = Me.O_.OOO_O_..Viewport.Limits.MinLong.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.O_.OOO_O_..Viewport.Limits.MinLong = Double.NaN
					Return
				End If
				Me.O_.OOO_O_..Viewport.Limits.MinLong = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x1700036D RID: 877
		' (get) Token: 0x060010C8 RID: 4296 RVA: 0x0006A814 File Offset: 0x00068A14
		' (set) Token: 0x060010C9 RID: 4297 RVA: 0x0006A864 File Offset: 0x00068A64
		<Category("地图")>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("最大经度")>
		<DefaultValue("")>
		Public Property MaxX As String
			Get
				Dim result As String
				If Double.IsNaN(Me.O_.OOO_O_..Viewport.Limits.MaxLong) Then
					result = ""
				Else
					result = Me.O_.OOO_O_..Viewport.Limits.MaxLong.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.O_.OOO_O_..Viewport.Limits.MaxLong = Double.NaN
					Return
				End If
				Me.O_.OOO_O_..Viewport.Limits.MaxLong = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x1700036E RID: 878
		' (get) Token: 0x060010CA RID: 4298 RVA: 0x0006A8C8 File Offset: 0x00068AC8
		' (set) Token: 0x060010CB RID: 4299 RVA: 0x0006A918 File Offset: 0x00068B18
		<O_Oo00Oo000O0(9.0)>
		<Category("地图")>
		<DisplayName("最小纬度")>
		<DefaultValue("")>
		Public Property MinY As String
			Get
				Dim result As String
				If Double.IsNaN(Me.O_.OOO_O_..Viewport.Limits.MinLat) Then
					result = ""
				Else
					result = Me.O_.OOO_O_..Viewport.Limits.MinLat.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.O_.OOO_O_..Viewport.Limits.MinLat = Double.NaN
					Return
				End If
				Me.O_.OOO_O_..Viewport.Limits.MinLat = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x1700036F RID: 879
		' (get) Token: 0x060010CC RID: 4300 RVA: 0x0006A97C File Offset: 0x00068B7C
		' (set) Token: 0x060010CD RID: 4301 RVA: 0x0006A9CC File Offset: 0x00068BCC
		<O_Oo00Oo000O0(10.0)>
		<DefaultValue("")>
		<DisplayName("最大纬度")>
		<Category("地图")>
		Public Property MaxY As String
			Get
				Dim result As String
				If Double.IsNaN(Me.O_.OOO_O_..Viewport.Limits.MaxLat) Then
					result = ""
				Else
					result = Me.O_.OOO_O_..Viewport.Limits.MaxLat.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.O_.OOO_O_..Viewport.Limits.MaxLat = Double.NaN
					Return
				End If
				Me.O_.OOO_O_..Viewport.Limits.MaxLat = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x17000370 RID: 880
		' (get) Token: 0x060010CE RID: 4302 RVA: 0x0006AA2F File Offset: 0x00068C2F
		' (set) Token: 0x060010CF RID: 4303 RVA: 0x0006AA3C File Offset: 0x00068C3C
		<Category("地图")>
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("允许平移")>
		<DefaultValue(True)>
		Public Property AllowTranslating As Boolean
			Get
				Return Me.O_.OOO_O_..AllowTranslating
			End Get
			Set(value As Boolean)
				Me.O_.OOO_O_..AllowTranslating = value
			End Set
		End Property

		' Token: 0x17000371 RID: 881
		' (get) Token: 0x060010D0 RID: 4304 RVA: 0x0006AA4A File Offset: 0x00068C4A
		' (set) Token: 0x060010D1 RID: 4305 RVA: 0x0006AA57 File Offset: 0x00068C57
		<DefaultValue(True)>
		<Category("地图")>
		<O_Oo00Oo000O0(12.0)>
		<DisplayName("允许缩放")>
		Public Property AllowZooming As Boolean
			Get
				Return Me.O_.OOO_O_..AllowZooming
			End Get
			Set(value As Boolean)
				Me.O_.OOO_O_..AllowZooming = value
			End Set
		End Property

		' Token: 0x17000372 RID: 882
		' (get) Token: 0x060010D2 RID: 4306 RVA: 0x0006AA65 File Offset: 0x00068C65
		' (set) Token: 0x060010D3 RID: 4307 RVA: 0x0006AA77 File Offset: 0x00068C77
		<O_Oo00Oo000O0(13.0)>
		<DisplayName("显示缩放工具")>
		<DefaultValue(True)>
		<Category("地图")>
		Public Property ZoomToolVisible As Boolean
			Get
				Return Me.O_.OOO_O_..ZoomTool.Visible
			End Get
			Set(value As Boolean)
				Me.O_.OOO_O_..ZoomTool.Visible = value
			End Set
		End Property

		' Token: 0x17000373 RID: 883
		' (get) Token: 0x060010D4 RID: 4308 RVA: 0x0006AA8A File Offset: 0x00068C8A
		' (set) Token: 0x060010D5 RID: 4309 RVA: 0x0006AA9C File Offset: 0x00068C9C
		<O_Oo00Oo000O0(14.0)>
		<DefaultValue(True)>
		<Category("地图")>
		<DisplayName("显示平移工具")>
		Public Property PanToolVisible As Boolean
			Get
				Return Me.O_.OOO_O_..PanTool.Visible
			End Get
			Set(value As Boolean)
				Me.O_.OOO_O_..PanTool.Visible = value
			End Set
		End Property

		' Token: 0x17000374 RID: 884
		' (get) Token: 0x060010D6 RID: 4310 RVA: 0x0006AAAF File Offset: 0x00068CAF
		' (set) Token: 0x060010D7 RID: 4311 RVA: 0x0006AAC1 File Offset: 0x00068CC1
		<O_Oo00Oo000O0(15.0)>
		<DefaultValue(True)>
		<DisplayName("显示比例尺")>
		<Category("地图")>
		Public Property DistanceScaleVisible As Boolean
			Get
				Return Me.O_.OOO_O_..DistanceScale.Visible
			End Get
			Set(value As Boolean)
				Me.O_.OOO_O_..DistanceScale.Visible = value
			End Set
		End Property

		' Token: 0x04000657 RID: 1623
		Private <<EMPTY_NAME>> As GeoMap

		' Token: 0x04000658 RID: 1624
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000659 RID: 1625
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400065A RID: 1626
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400065B RID: 1627
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400065C RID: 1628
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400065D RID: 1629
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400065E RID: 1630
		Private <<EMPTY_NAME>> As TileSoureEnum
	End Class
End Namespace
