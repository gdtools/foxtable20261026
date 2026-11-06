Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports C1.Win.C1Chart
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000500 RID: 1280
	<ComVisible(True)>
	Public Class ChartDataArray
		' Token: 0x06005333 RID: 21299 RVA: 0x0021D00F File Offset: 0x0021B20F
		Public Sub New(A_0 As ChartDataArray)
			Me.oO0Oo._o_O_. = A_0
		End Sub

		' Token: 0x17001370 RID: 4976
		' (get) Token: 0x06005334 RID: 21300 RVA: 0x0021D01E File Offset: 0x0021B21E
		' (set) Token: 0x06005335 RID: 21301 RVA: 0x0021D02B File Offset: 0x0021B22B
		Public Property DataField As String
			Get
				Return Me.oO0Oo._o_O_..DataField
			End Get
			Set(value As String)
				Me.oO0Oo._o_O_..DataField = value
			End Set
		End Property

		' Token: 0x17001371 RID: 4977
		' (get) Token: 0x06005336 RID: 21302 RVA: 0x0021D039 File Offset: 0x0021B239
		' (set) Token: 0x06005337 RID: 21303 RVA: 0x0021D046 File Offset: 0x0021B246
		Public Property DataType As Type
			Get
				Return Me.oO0Oo._o_O_..DataType
			End Get
			Set(value As Type)
				Me.oO0Oo._o_O_..DataType = value
			End Set
		End Property

		' Token: 0x17001372 RID: 4978
		Public Default Property Item(Index As Integer) As Object
			Get
				Return Me.oO0Oo._o_O_.(Index)
			End Get
			Set(value As Object)
				If TypeOf value Is Byte Then
					value = Conversions.ToInteger(value)
				End If
				Me.oO0Oo._o_O_.(Index) = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17001373 RID: 4979
		' (get) Token: 0x0600533A RID: 21306 RVA: 0x0021D08B File Offset: 0x0021B28B
		Public ReadOnly Property Mean As Double
			Get
				Return Me.oO0Oo._o_O_..Statistics.Mean
			End Get
		End Property

		' Token: 0x17001374 RID: 4980
		' (get) Token: 0x0600533B RID: 21307 RVA: 0x0021D09D File Offset: 0x0021B29D
		Public ReadOnly Property Median As Double
			Get
				Return Me.oO0Oo._o_O_..Statistics.Median
			End Get
		End Property

		' Token: 0x17001375 RID: 4981
		' (get) Token: 0x0600533C RID: 21308 RVA: 0x0021D0AF File Offset: 0x0021B2AF
		Public ReadOnly Property StdDev As Double
			Get
				Return Me.oO0Oo._o_O_..Statistics.StdDev
			End Get
		End Property

		' Token: 0x17001376 RID: 4982
		' (get) Token: 0x0600533D RID: 21309 RVA: 0x0021D0C1 File Offset: 0x0021B2C1
		Public ReadOnly Property Variance As Double
			Get
				Return Me.oO0Oo._o_O_..Statistics.Variance
			End Get
		End Property

		' Token: 0x040021BF RID: 8639
		Private <<EMPTY_NAME>> As ChartDataArray
	End Class
End Namespace
