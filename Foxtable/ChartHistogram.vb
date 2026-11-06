Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Chart

Namespace Foxtable
	' Token: 0x020003A8 RID: 936
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ChartHistogram
		' Token: 0x06003B99 RID: 15257 RVA: 0x00199E0E File Offset: 0x0019800E
		Public Sub New(A_0 As ChartDataSeries)
			Me.OOO.o_oo0o0ooO. = A_0
		End Sub

		' Token: 0x17000D06 RID: 3334
		' (get) Token: 0x06003B9A RID: 15258 RVA: 0x00199E1D File Offset: 0x0019801D
		' (set) Token: 0x06003B9B RID: 15259 RVA: 0x00199E2F File Offset: 0x0019802F
		<oO0oooo("0981")>
		Public Property IntervalStart As Double
			Get
				Return Me.OOO.o_oo0o0ooO..Histogram.IntervalStart
			End Get
			Set(value As Double)
				Me.OOO.o_oo0o0ooO..Histogram.IntervalStart = value
			End Set
		End Property

		' Token: 0x17000D07 RID: 3335
		' (get) Token: 0x06003B9C RID: 15260 RVA: 0x00199E42 File Offset: 0x00198042
		' (set) Token: 0x06003B9D RID: 15261 RVA: 0x00199E54 File Offset: 0x00198054
		<oO0oooo("0981")>
		Public Property IntervalWidth As Double
			Get
				Return Me.OOO.o_oo0o0ooO..Histogram.IntervalWidth
			End Get
			Set(value As Double)
				Me.OOO.o_oo0o0ooO..Histogram.IntervalWidth = value
			End Set
		End Property

		' Token: 0x17000D08 RID: 3336
		' (get) Token: 0x06003B9E RID: 15262 RVA: 0x00199E67 File Offset: 0x00198067
		' (set) Token: 0x06003B9F RID: 15263 RVA: 0x00199E79 File Offset: 0x00198079
		<oO0oooo("0981")>
		Public Property IntervalNumber As Integer
			Get
				Return Me.OOO.o_oo0o0ooO..Histogram.IntervalNumber
			End Get
			Set(value As Integer)
				Me.OOO.o_oo0o0ooO..Histogram.IntervalNumber = value
			End Set
		End Property

		' Token: 0x17000D09 RID: 3337
		' (get) Token: 0x06003BA0 RID: 15264 RVA: 0x00199E8C File Offset: 0x0019808C
		<oO0oooo("0981")>
		Public ReadOnly Property AboveIntervalCount As Double
			Get
				Return Me.OOO.o_oo0o0ooO..Histogram.AboveIntervalCount
			End Get
		End Property

		' Token: 0x17000D0A RID: 3338
		' (get) Token: 0x06003BA1 RID: 15265 RVA: 0x00199E9E File Offset: 0x0019809E
		<oO0oooo("0981")>
		Public ReadOnly Property BelowIntervalCount As Double
			Get
				Return Me.OOO.o_oo0o0ooO..Histogram.BelowIntervalCount
			End Get
		End Property

		' Token: 0x0400186C RID: 6252
		Private <<EMPTY_NAME>> As ChartDataSeries
	End Class
End Namespace
