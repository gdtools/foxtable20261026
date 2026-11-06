Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.Interop
Imports C1.Win.Map
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004F5 RID: 1269
	<ComVisible(True)>
	Public Class Map
		Inherits Control

		' Token: 0x0600513A RID: 20794 RVA: 0x00219D01 File Offset: 0x00217F01
		Public Sub New(A_0 As GeoMap)
			MyBase.New(A_0, ControlTypeEnum.Map)
			Me.o.oO_oo_O. = A_0
		End Sub

		' Token: 0x17001283 RID: 4739
		' (get) Token: 0x0600513B RID: 20795 RVA: 0x00219D13 File Offset: 0x00217F13
		Public ReadOnly Property GeoMap As GeoMap
			Get
				Return Me.o.oO_oo_O.
			End Get
		End Property

		' Token: 0x17001284 RID: 4740
		' (get) Token: 0x0600513C RID: 20796 RVA: 0x00219D1C File Offset: 0x00217F1C
		' (set) Token: 0x0600513D RID: 20797 RVA: 0x00219DB0 File Offset: 0x00217FB0
		Public Property TileSource As TileSoureEnum
			Get
				Dim result As TileSoureEnum
				If Me.o.oO_oo_O..TileLayer.TileSource Is Nothing Then
					result = TileSoureEnum.None
				ElseIf TypeOf Me.o.oO_oo_O..TileLayer.TileSource Is VirtualEarthRoadSource Then
					result = TileSoureEnum.Road
				ElseIf TypeOf Me.o.oO_oo_O..TileLayer.TileSource Is VirtualEarthAerialSource Then
					result = TileSoureEnum.Aerial
				ElseIf TypeOf Me.o.oO_oo_O..TileLayer.TileSource Is VirtualEarthHybridSource Then
					result = TileSoureEnum.Hybrid
				ElseIf TypeOf Me.o.oO_oo_O..TileLayer.TileSource Is CustomTileSource Then
					result = TileSoureEnum.Custom
				Else
					result = TileSoureEnum.None
				End If
				Return result
			End Get
			Set(value As TileSoureEnum)
				Select Case value
					Case TileSoureEnum.None
						Me.o.oO_oo_O..TileLayer.TileSource = Nothing
						Return
					Case TileSoureEnum.Road
						Me.o.oO_oo_O..TileLayer.TileSource = New VirtualEarthRoadSource()
						Return
					Case TileSoureEnum.Aerial
						Me.o.oO_oo_O..TileLayer.TileSource = New VirtualEarthAerialSource()
						Return
					Case TileSoureEnum.Hybrid
						Me.o.oO_oo_O..TileLayer.TileSource = New VirtualEarthHybridSource()
						Return
					Case TileSoureEnum.Custom
						Me.o.oO_oo_O..TileLayer.TileSource = New CustomTileSource(Me.o.oO_oo_O.)
						Return
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x17001285 RID: 4741
		' (get) Token: 0x0600513E RID: 20798 RVA: 0x00219E49 File Offset: 0x00218049
		' (set) Token: 0x0600513F RID: 20799 RVA: 0x00219E61 File Offset: 0x00218061
		Public Property Zoom As Double
			Get
				Return Math.Round(Me.o.oO_oo_O..Viewport.Zoom, 6)
			End Get
			Set(value As Double)
				Me.o.oO_oo_O..Viewport.Zoom = value
			End Set
		End Property

		' Token: 0x17001286 RID: 4742
		' (get) Token: 0x06005140 RID: 20800 RVA: 0x00219E74 File Offset: 0x00218074
		' (set) Token: 0x06005141 RID: 20801 RVA: 0x00219E86 File Offset: 0x00218086
		Public Property MaxZoom As Double
			Get
				Return Me.o.oO_oo_O..Viewport.MaxZoom
			End Get
			Set(value As Double)
				Me.o.oO_oo_O..Viewport.MaxZoom = value
			End Set
		End Property

		' Token: 0x17001287 RID: 4743
		' (get) Token: 0x06005142 RID: 20802 RVA: 0x00219E99 File Offset: 0x00218099
		' (set) Token: 0x06005143 RID: 20803 RVA: 0x00219EAB File Offset: 0x002180AB
		Public Property MinZoom As Double
			Get
				Return Me.o.oO_oo_O..Viewport.MinZoom
			End Get
			Set(value As Double)
				Me.o.oO_oo_O..Viewport.MinZoom = value
			End Set
		End Property

		' Token: 0x17001288 RID: 4744
		' (get) Token: 0x06005144 RID: 20804 RVA: 0x00219EC0 File Offset: 0x002180C0
		' (set) Token: 0x06005145 RID: 20805 RVA: 0x00219EEC File Offset: 0x002180EC
		Public Property CenterX As Double
			Get
				Return Math.Round(Me.o.oO_oo_O..Viewport.Center.X, 6)
			End Get
			Set(value As Double)
				Me.o.oO_oo_O..Viewport.Center = New Point(value, Me.o.oO_oo_O..Viewport.Center.Y)
			End Set
		End Property

		' Token: 0x17001289 RID: 4745
		' (get) Token: 0x06005146 RID: 20806 RVA: 0x00219F28 File Offset: 0x00218128
		' (set) Token: 0x06005147 RID: 20807 RVA: 0x00219F54 File Offset: 0x00218154
		Public Property CenterY As Double
			Get
				Return Math.Round(Me.o.oO_oo_O..Viewport.Center.Y, 6)
			End Get
			Set(value As Double)
				Me.o.oO_oo_O..Viewport.Center = New Point(Me.o.oO_oo_O..Viewport.Center.X, value)
			End Set
		End Property

		' Token: 0x1700128A RID: 4746
		' (get) Token: 0x06005148 RID: 20808 RVA: 0x00219F90 File Offset: 0x00218190
		' (set) Token: 0x06005149 RID: 20809 RVA: 0x00219FE0 File Offset: 0x002181E0
		Public Property MinX As String
			Get
				Dim result As String
				If Double.IsNaN(Me.o.oO_oo_O..Viewport.Limits.MinLong) Then
					result = ""
				Else
					result = Me.o.oO_oo_O..Viewport.Limits.MinLong.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.o.oO_oo_O..Viewport.Limits.MinLong = Double.NaN
					Return
				End If
				Me.o.oO_oo_O..Viewport.Limits.MinLong = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x1700128B RID: 4747
		' (get) Token: 0x0600514A RID: 20810 RVA: 0x0021A044 File Offset: 0x00218244
		' (set) Token: 0x0600514B RID: 20811 RVA: 0x0021A094 File Offset: 0x00218294
		Public Property MaxX As String
			Get
				Dim result As String
				If Double.IsNaN(Me.o.oO_oo_O..Viewport.Limits.MaxLong) Then
					result = ""
				Else
					result = Me.o.oO_oo_O..Viewport.Limits.MaxLong.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.o.oO_oo_O..Viewport.Limits.MaxLong = Double.NaN
					Return
				End If
				Me.o.oO_oo_O..Viewport.Limits.MaxLong = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x1700128C RID: 4748
		' (get) Token: 0x0600514C RID: 20812 RVA: 0x0021A0F8 File Offset: 0x002182F8
		' (set) Token: 0x0600514D RID: 20813 RVA: 0x0021A148 File Offset: 0x00218348
		Public Property MinY As String
			Get
				Dim result As String
				If Double.IsNaN(Me.o.oO_oo_O..Viewport.Limits.MinLat) Then
					result = ""
				Else
					result = Me.o.oO_oo_O..Viewport.Limits.MinLat.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.o.oO_oo_O..Viewport.Limits.MinLat = Double.NaN
					Return
				End If
				Me.o.oO_oo_O..Viewport.Limits.MinLat = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x1700128D RID: 4749
		' (get) Token: 0x0600514E RID: 20814 RVA: 0x0021A1AC File Offset: 0x002183AC
		' (set) Token: 0x0600514F RID: 20815 RVA: 0x0021A1FC File Offset: 0x002183FC
		Public Property MaxY As String
			Get
				Dim result As String
				If Double.IsNaN(Me.o.oO_oo_O..Viewport.Limits.MaxLat) Then
					result = ""
				Else
					result = Me.o.oO_oo_O..Viewport.Limits.MaxLat.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 OrElse Operators.CompareString(value, "NaN", True) = 0 Then
					Me.o.oO_oo_O..Viewport.Limits.MaxLat = Double.NaN
					Return
				End If
				Me.o.oO_oo_O..Viewport.Limits.MaxLat = Conversion.Val(value)
			End Set
		End Property

		' Token: 0x1700128E RID: 4750
		' (get) Token: 0x06005150 RID: 20816 RVA: 0x0021A25F File Offset: 0x0021845F
		' (set) Token: 0x06005151 RID: 20817 RVA: 0x0021A26C File Offset: 0x0021846C
		Public Property AllowTranslating As Boolean
			Get
				Return Me.o.oO_oo_O..AllowTranslating
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..AllowTranslating = value
			End Set
		End Property

		' Token: 0x1700128F RID: 4751
		' (get) Token: 0x06005152 RID: 20818 RVA: 0x0021A27A File Offset: 0x0021847A
		' (set) Token: 0x06005153 RID: 20819 RVA: 0x0021A287 File Offset: 0x00218487
		Public Property AllowZooming As Boolean
			Get
				Return Me.o.oO_oo_O..AllowZooming
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..AllowZooming = value
			End Set
		End Property

		' Token: 0x17001290 RID: 4752
		' (get) Token: 0x06005154 RID: 20820 RVA: 0x0021A295 File Offset: 0x00218495
		' (set) Token: 0x06005155 RID: 20821 RVA: 0x0021A2A7 File Offset: 0x002184A7
		Public Property ZoomToolVisible As Boolean
			Get
				Return Me.o.oO_oo_O..ZoomTool.Visible
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..ZoomTool.Visible = value
			End Set
		End Property

		' Token: 0x17001291 RID: 4753
		' (get) Token: 0x06005156 RID: 20822 RVA: 0x0021A2BA File Offset: 0x002184BA
		' (set) Token: 0x06005157 RID: 20823 RVA: 0x0021A2CC File Offset: 0x002184CC
		Public Property PanToolVisible As Boolean
			Get
				Return Me.o.oO_oo_O..PanTool.Visible
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..PanTool.Visible = value
			End Set
		End Property

		' Token: 0x17001292 RID: 4754
		' (get) Token: 0x06005158 RID: 20824 RVA: 0x0021A2DF File Offset: 0x002184DF
		' (set) Token: 0x06005159 RID: 20825 RVA: 0x0021A2F1 File Offset: 0x002184F1
		Public Property DistanceScaleVisible As Boolean
			Get
				Return Me.o.oO_oo_O..DistanceScale.Visible
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..DistanceScale.Visible = value
			End Set
		End Property

		' Token: 0x040021B1 RID: 8625
		Private <<EMPTY_NAME>> As GeoMap
	End Class
End Namespace
