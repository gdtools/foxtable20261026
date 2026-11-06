Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports C1.Win.C1Chart

Namespace Foxtable.WinForm
	' Token: 0x020004FF RID: 1279
	<ComVisible(True)>
	Public Class ChartAxis
		' Token: 0x060052F8 RID: 21240 RVA: 0x0021CC27 File Offset: 0x0021AE27
		Public Sub New(A_0 As Axis)
			Me.oOOO_.__oO0O. = A_0
		End Sub

		' Token: 0x17001354 RID: 4948
		' (get) Token: 0x060052F9 RID: 21241 RVA: 0x0021CC36 File Offset: 0x0021AE36
		' (set) Token: 0x060052FA RID: 21242 RVA: 0x0021CC43 File Offset: 0x0021AE43
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoMax As Boolean
			Get
				Return Me.oOOO_.__oO0O..AutoMax
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..AutoMax = value
			End Set
		End Property

		' Token: 0x17001355 RID: 4949
		' (get) Token: 0x060052FB RID: 21243 RVA: 0x0021CC51 File Offset: 0x0021AE51
		' (set) Token: 0x060052FC RID: 21244 RVA: 0x0021CC5E File Offset: 0x0021AE5E
		<oO0oooo("1016")>
		Public Property Max As Double
			Get
				Return Me.oOOO_.__oO0O..Max
			End Get
			Set(value As Double)
				Me.AutoMax = False
				Me.oOOO_.__oO0O..Max = value
			End Set
		End Property

		' Token: 0x17001356 RID: 4950
		' (get) Token: 0x060052FD RID: 21245 RVA: 0x0021CC73 File Offset: 0x0021AE73
		' (set) Token: 0x060052FE RID: 21246 RVA: 0x0021CC85 File Offset: 0x0021AE85
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property MaxDate As DateTime
			Get
				Return DateTime.FromOADate(Me.oOOO_.__oO0O..Max)
			End Get
			Set(value As DateTime)
				Me.AutoMax = False
				Me.oOOO_.__oO0O..Max = value.ToOADate()
			End Set
		End Property

		' Token: 0x17001357 RID: 4951
		' (get) Token: 0x060052FF RID: 21247 RVA: 0x0021CCA0 File Offset: 0x0021AEA0
		' (set) Token: 0x06005300 RID: 21248 RVA: 0x0021CCAD File Offset: 0x0021AEAD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoMin As Boolean
			Get
				Return Me.oOOO_.__oO0O..AutoMin
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..AutoMin = value
			End Set
		End Property

		' Token: 0x17001358 RID: 4952
		' (get) Token: 0x06005301 RID: 21249 RVA: 0x0021CCBB File Offset: 0x0021AEBB
		' (set) Token: 0x06005302 RID: 21250 RVA: 0x0021CCC8 File Offset: 0x0021AEC8
		<oO0oooo("1016")>
		Public Property Min As Double
			Get
				Return Me.oOOO_.__oO0O..Min
			End Get
			Set(value As Double)
				Me.AutoMin = False
				Me.oOOO_.__oO0O..Min = value
			End Set
		End Property

		' Token: 0x17001359 RID: 4953
		' (get) Token: 0x06005303 RID: 21251 RVA: 0x0021CCDD File Offset: 0x0021AEDD
		' (set) Token: 0x06005304 RID: 21252 RVA: 0x0021CCEF File Offset: 0x0021AEEF
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property MinDate As DateTime
			Get
				Return DateTime.FromOADate(Me.oOOO_.__oO0O..Min)
			End Get
			Set(value As DateTime)
				Me.AutoMin = False
				Me.oOOO_.__oO0O..Min = value.ToOADate()
			End Set
		End Property

		' Token: 0x1700135A RID: 4954
		' (get) Token: 0x06005305 RID: 21253 RVA: 0x0021CD0A File Offset: 0x0021AF0A
		' (set) Token: 0x06005306 RID: 21254 RVA: 0x0021CD17 File Offset: 0x0021AF17
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoOrigin As Boolean
			Get
				Return Me.oOOO_.__oO0O..AutoOrigin
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..AutoOrigin = value
			End Set
		End Property

		' Token: 0x1700135B RID: 4955
		' (get) Token: 0x06005307 RID: 21255 RVA: 0x0021CD25 File Offset: 0x0021AF25
		' (set) Token: 0x06005308 RID: 21256 RVA: 0x0021CD32 File Offset: 0x0021AF32
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Origin As Double
			Get
				Return Me.oOOO_.__oO0O..Origin
			End Get
			Set(value As Double)
				Me.oOOO_.__oO0O..Origin = value
			End Set
		End Property

		' Token: 0x1700135C RID: 4956
		' (get) Token: 0x06005309 RID: 21257 RVA: 0x0021CD40 File Offset: 0x0021AF40
		' (set) Token: 0x0600530A RID: 21258 RVA: 0x0021CD4D File Offset: 0x0021AF4D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoMajor As Boolean
			Get
				Return Me.oOOO_.__oO0O..AutoMajor
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..AutoMajor = value
			End Set
		End Property

		' Token: 0x1700135D RID: 4957
		' (get) Token: 0x0600530B RID: 21259 RVA: 0x0021CD5B File Offset: 0x0021AF5B
		' (set) Token: 0x0600530C RID: 21260 RVA: 0x0021CD68 File Offset: 0x0021AF68
		<oO0oooo("1018")>
		Public Property Major As Double
			Get
				Return Me.oOOO_.__oO0O..UnitMajor
			End Get
			Set(value As Double)
				Me.oOOO_.__oO0O..UnitMajor = value
			End Set
		End Property

		' Token: 0x1700135E RID: 4958
		' (get) Token: 0x0600530D RID: 21261 RVA: 0x0021CD76 File Offset: 0x0021AF76
		' (set) Token: 0x0600530E RID: 21262 RVA: 0x0021CD86 File Offset: 0x0021AF86
		Public Property MajorTick As Boolean
			Get
				Return Me.oOOO_.__oO0O..TickMajor > 0
			End Get
			Set(value As Boolean)
				If value Then
					Me.oOOO_.__oO0O..TickMajor = 2
					Return
				End If
				Me.oOOO_.__oO0O..TickMajor = 0
			End Set
		End Property

		' Token: 0x1700135F RID: 4959
		' (get) Token: 0x0600530F RID: 21263 RVA: 0x0021CDA4 File Offset: 0x0021AFA4
		' (set) Token: 0x06005310 RID: 21264 RVA: 0x0021CDB6 File Offset: 0x0021AFB6
		Public Property GridMajorVisible As Boolean
			Get
				Return Me.oOOO_.__oO0O..GridMajor.Visible
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..GridMajor.Visible = value
			End Set
		End Property

		' Token: 0x17001360 RID: 4960
		' (get) Token: 0x06005311 RID: 21265 RVA: 0x0021CDC9 File Offset: 0x0021AFC9
		' (set) Token: 0x06005312 RID: 21266 RVA: 0x0021CDDB File Offset: 0x0021AFDB
		<oO0oooo("6003")>
		Public Property GridMajorColor As Color
			Get
				Return Me.oOOO_.__oO0O..GridMajor.Color
			End Get
			Set(value As Color)
				Me.oOOO_.__oO0O..GridMajor.Color = value
			End Set
		End Property

		' Token: 0x17001361 RID: 4961
		' (get) Token: 0x06005313 RID: 21267 RVA: 0x0021CDEE File Offset: 0x0021AFEE
		' (set) Token: 0x06005314 RID: 21268 RVA: 0x0021CDFB File Offset: 0x0021AFFB
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoMinor As Boolean
			Get
				Return Me.oOOO_.__oO0O..AutoMinor
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..AutoMinor = value
			End Set
		End Property

		' Token: 0x17001362 RID: 4962
		' (get) Token: 0x06005315 RID: 21269 RVA: 0x0021CE09 File Offset: 0x0021B009
		' (set) Token: 0x06005316 RID: 21270 RVA: 0x0021CE16 File Offset: 0x0021B016
		Public Property Minor As Double
			Get
				Return Me.oOOO_.__oO0O..UnitMinor
			End Get
			Set(value As Double)
				Me.oOOO_.__oO0O..UnitMinor = value
			End Set
		End Property

		' Token: 0x17001363 RID: 4963
		' (get) Token: 0x06005317 RID: 21271 RVA: 0x0021CE24 File Offset: 0x0021B024
		' (set) Token: 0x06005318 RID: 21272 RVA: 0x0021CE34 File Offset: 0x0021B034
		Public Property MinorTick As Boolean
			Get
				Return Me.oOOO_.__oO0O..TickMinor > 0
			End Get
			Set(value As Boolean)
				If value Then
					Me.oOOO_.__oO0O..TickMinor = 2
					Return
				End If
				Me.oOOO_.__oO0O..TickMinor = 0
			End Set
		End Property

		' Token: 0x17001364 RID: 4964
		' (get) Token: 0x06005319 RID: 21273 RVA: 0x0021CE52 File Offset: 0x0021B052
		' (set) Token: 0x0600531A RID: 21274 RVA: 0x0021CE64 File Offset: 0x0021B064
		Public Property GridMinorVisible As Boolean
			Get
				Return Me.oOOO_.__oO0O..GridMinor.Visible
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..GridMinor.Visible = value
			End Set
		End Property

		' Token: 0x17001365 RID: 4965
		' (get) Token: 0x0600531B RID: 21275 RVA: 0x0021CE77 File Offset: 0x0021B077
		' (set) Token: 0x0600531C RID: 21276 RVA: 0x0021CE89 File Offset: 0x0021B089
		Public Property GridMinorColor As Color
			Get
				Return Me.oOOO_.__oO0O..GridMinor.Color
			End Get
			Set(value As Color)
				Me.oOOO_.__oO0O..GridMinor.Color = value
			End Set
		End Property

		' Token: 0x17001366 RID: 4966
		' (get) Token: 0x0600531D RID: 21277 RVA: 0x0021CE9C File Offset: 0x0021B09C
		' (set) Token: 0x0600531E RID: 21278 RVA: 0x0021CEA9 File Offset: 0x0021B0A9
		<oO0oooo("1025")>
		Public Property Reversed As Boolean
			Get
				Return Me.oOOO_.__oO0O..Reversed
			End Get
			Set(value As Boolean)
				Me.oOOO_.__oO0O..Reversed = value
			End Set
		End Property

		' Token: 0x17001367 RID: 4967
		' (get) Token: 0x0600531F RID: 21279 RVA: 0x0021CEB7 File Offset: 0x0021B0B7
		' (set) Token: 0x06005320 RID: 21280 RVA: 0x0021CEC4 File Offset: 0x0021B0C4
		<oO0oooo("1024")>
		Public Property Compass As CompassEnum
			Get
				Return Me.oOOO_.__oO0O..Compass
			End Get
			Set(value As CompassEnum)
				Me.oOOO_.__oO0O..Compass = value
			End Set
		End Property

		' Token: 0x17001368 RID: 4968
		' (get) Token: 0x06005321 RID: 21281 RVA: 0x0021CED2 File Offset: 0x0021B0D2
		' (set) Token: 0x06005322 RID: 21282 RVA: 0x0021CEE2 File Offset: 0x0021B0E2
		<oO0oooo("1029")>
		Public Property AnnoWithLabels As Boolean
			Get
				Return Me.oOOO_.__oO0O..AnnoMethod = 1
			End Get
			Set(value As Boolean)
				If value Then
					Me.oOOO_.__oO0O..AnnoMethod = 1
					Return
				End If
				Me.oOOO_.__oO0O..AnnoMethod = 0
			End Set
		End Property

		' Token: 0x17001369 RID: 4969
		' (get) Token: 0x06005323 RID: 21283 RVA: 0x0021CF00 File Offset: 0x0021B100
		' (set) Token: 0x06005324 RID: 21284 RVA: 0x0021CF0D File Offset: 0x0021B10D
		<oO0oooo("1030")>
		Public Property AnnoRotation As Integer
			Get
				Return Me.oOOO_.__oO0O..AnnotationRotation
			End Get
			Set(value As Integer)
				Me.oOOO_.__oO0O..AnnotationRotation = value
			End Set
		End Property

		' Token: 0x1700136A RID: 4970
		' (get) Token: 0x06005325 RID: 21285 RVA: 0x0021CF1B File Offset: 0x0021B11B
		' (set) Token: 0x06005326 RID: 21286 RVA: 0x0021CF28 File Offset: 0x0021B128
		<oO0oooo("1031")>
		Public Property AnnoFormatString As String
			Get
				Return Me.oOOO_.__oO0O..AnnoFormatString
			End Get
			Set(value As String)
				Me.oOOO_.__oO0O..AnnoFormatString = value
			End Set
		End Property

		' Token: 0x06005327 RID: 21287 RVA: 0x0021CF36 File Offset: 0x0021B136
		<oO0oooo("1032")>
		Public Sub SetValueLabel(Value As Object, Label As String)
			Me.oOOO_.__oO0O..ValueLabels.Add(RuntimeHelpers.GetObjectValue(Value), Label)
		End Sub

		' Token: 0x06005328 RID: 21288 RVA: 0x0021CF50 File Offset: 0x0021B150
		Public Sub ClearValueLabel()
			Me.oOOO_.__oO0O..ValueLabels.Clear()
		End Sub

		' Token: 0x1700136B RID: 4971
		' (get) Token: 0x06005329 RID: 21289 RVA: 0x0021CF62 File Offset: 0x0021B162
		' (set) Token: 0x0600532A RID: 21290 RVA: 0x0021CF6F File Offset: 0x0021B16F
		<oO0oooo("6006")>
		Public Property Aligment As StringAlignment
			Get
				Return Me.oOOO_.__oO0O..Alignment
			End Get
			Set(value As StringAlignment)
				Me.oOOO_.__oO0O..Alignment = value
			End Set
		End Property

		' Token: 0x1700136C RID: 4972
		' (get) Token: 0x0600532B RID: 21291 RVA: 0x0021CF7D File Offset: 0x0021B17D
		' (set) Token: 0x0600532C RID: 21292 RVA: 0x0021CF8A File Offset: 0x0021B18A
		Public Property Text As String
			Get
				Return Me.oOOO_.__oO0O..Text
			End Get
			Set(value As String)
				Me.oOOO_.__oO0O..Text = value
			End Set
		End Property

		' Token: 0x1700136D RID: 4973
		' (get) Token: 0x0600532D RID: 21293 RVA: 0x0021CF98 File Offset: 0x0021B198
		' (set) Token: 0x0600532E RID: 21294 RVA: 0x0021CFA5 File Offset: 0x0021B1A5
		Public Property Font As Font
			Get
				Return Me.oOOO_.__oO0O..Font
			End Get
			Set(value As Font)
				Me.oOOO_.__oO0O..Font = value
			End Set
		End Property

		' Token: 0x1700136E RID: 4974
		' (get) Token: 0x0600532F RID: 21295 RVA: 0x0021CFB4 File Offset: 0x0021B1B4
		' (set) Token: 0x06005330 RID: 21296 RVA: 0x0021CFD6 File Offset: 0x0021B1D6
		Public Property DateType As Boolean
			Get
				Return Me.oOOO_.__oO0O..AnnoFormat = 7
			End Get
			Set(value As Boolean)
				If value Then
					Me.oOOO_.__oO0O..AnnoFormat = 7
					Return
				End If
				Me.oOOO_.__oO0O..AnnoFormat = 0
			End Set
		End Property

		' Token: 0x1700136F RID: 4975
		' (get) Token: 0x06005331 RID: 21297 RVA: 0x0021CFF4 File Offset: 0x0021B1F4
		' (set) Token: 0x06005332 RID: 21298 RVA: 0x0021D001 File Offset: 0x0021B201
		Public Property ForeColor As Color
			Get
				Return Me.oOOO_.__oO0O..ForeColor
			End Get
			Set(value As Color)
				Me.oOOO_.__oO0O..ForeColor = value
			End Set
		End Property

		' Token: 0x040021BE RID: 8638
		Private <<EMPTY_NAME>> As Axis
	End Class
End Namespace
