Imports System
Imports System.Drawing.Printing
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004E0 RID: 1248
	Public Class PrintSetting
		' Token: 0x06005015 RID: 20501 RVA: 0x002180F0 File Offset: 0x002162F0
		Public Sub New(A_0 As XLPrintSettings)
			Me.o0_.O_o. = A_0
		End Sub

		' Token: 0x17001207 RID: 4615
		' (get) Token: 0x06005016 RID: 20502 RVA: 0x002180FF File Offset: 0x002162FF
		' (set) Token: 0x06005017 RID: 20503 RVA: 0x0021810C File Offset: 0x0021630C
		Public Property BlackAndWhite As Boolean
			Get
				Return Me.o0_.O_o..BlackAndWhite
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..BlackAndWhite = value
			End Set
		End Property

		' Token: 0x17001208 RID: 4616
		' (get) Token: 0x06005018 RID: 20504 RVA: 0x0021811A File Offset: 0x0021631A
		' (set) Token: 0x06005019 RID: 20505 RVA: 0x00218127 File Offset: 0x00216327
		Public Property CenterHorizontal As Boolean
			Get
				Return Me.o0_.O_o..CenterHorizontal
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..CenterHorizontal = value
			End Set
		End Property

		' Token: 0x17001209 RID: 4617
		' (get) Token: 0x0600501A RID: 20506 RVA: 0x00218135 File Offset: 0x00216335
		' (set) Token: 0x0600501B RID: 20507 RVA: 0x00218142 File Offset: 0x00216342
		Public Property CenterVertical As Boolean
			Get
				Return Me.o0_.O_o..CenterVertical
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..CenterVertical = value
			End Set
		End Property

		' Token: 0x1700120A RID: 4618
		' (get) Token: 0x0600501C RID: 20508 RVA: 0x00218150 File Offset: 0x00216350
		' (set) Token: 0x0600501D RID: 20509 RVA: 0x0021815D File Offset: 0x0021635D
		Public Property PrintGridlines As Boolean
			Get
				Return Me.o0_.O_o..PrintGridlines
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..PrintGridlines = value
			End Set
		End Property

		' Token: 0x1700120B RID: 4619
		' (get) Token: 0x0600501E RID: 20510 RVA: 0x0021816B File Offset: 0x0021636B
		' (set) Token: 0x0600501F RID: 20511 RVA: 0x00218178 File Offset: 0x00216378
		Public Property PrintHeaders As Boolean
			Get
				Return Me.o0_.O_o..PrintHeaders
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..PrintHeaders = value
			End Set
		End Property

		' Token: 0x1700120C RID: 4620
		' (get) Token: 0x06005020 RID: 20512 RVA: 0x00218186 File Offset: 0x00216386
		' (set) Token: 0x06005021 RID: 20513 RVA: 0x00218193 File Offset: 0x00216393
		Public Property StartPage As Integer
			Get
				Return Me.o0_.O_o..StartPage
			End Get
			Set(value As Integer)
				Me.o0_.O_o..StartPage = value
			End Set
		End Property

		' Token: 0x1700120D RID: 4621
		' (get) Token: 0x06005022 RID: 20514 RVA: 0x002181A1 File Offset: 0x002163A1
		' (set) Token: 0x06005023 RID: 20515 RVA: 0x002181AE File Offset: 0x002163AE
		Public Property PrintPagesInRows As Boolean
			Get
				Return Me.o0_.O_o..PrintPagesInRows
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..PrintPagesInRows = value
			End Set
		End Property

		' Token: 0x1700120E RID: 4622
		' (get) Token: 0x06005024 RID: 20516 RVA: 0x002181BC File Offset: 0x002163BC
		' (set) Token: 0x06005025 RID: 20517 RVA: 0x002181C9 File Offset: 0x002163C9
		<oO0oooo("1315")>
		Public Property Header As String
			Get
				Return Me.o0_.O_o..Header
			End Get
			Set(value As String)
				Me.o0_.O_o..Header = value
			End Set
		End Property

		' Token: 0x1700120F RID: 4623
		' (get) Token: 0x06005026 RID: 20518 RVA: 0x002181D7 File Offset: 0x002163D7
		' (set) Token: 0x06005027 RID: 20519 RVA: 0x002181E4 File Offset: 0x002163E4
		<oO0oooo("1315")>
		Public Property Footer As String
			Get
				Return Me.o0_.O_o..Footer
			End Get
			Set(value As String)
				Me.o0_.O_o..Footer = value
			End Set
		End Property

		' Token: 0x17001210 RID: 4624
		' (get) Token: 0x06005028 RID: 20520 RVA: 0x002181F2 File Offset: 0x002163F2
		' (set) Token: 0x06005029 RID: 20521 RVA: 0x00218209 File Offset: 0x00216409
		Public Property MarginFooter As Double
			Get
				Return Me.o0_.O_o..MarginFooter * 25.4
			End Get
			Set(value As Double)
				Me.o0_.O_o..MarginFooter = value / 25.4
			End Set
		End Property

		' Token: 0x17001211 RID: 4625
		' (get) Token: 0x0600502A RID: 20522 RVA: 0x00218221 File Offset: 0x00216421
		' (set) Token: 0x0600502B RID: 20523 RVA: 0x00218238 File Offset: 0x00216438
		Public Property MarginHeader As Double
			Get
				Return Me.o0_.O_o..MarginHeader * 25.4
			End Get
			Set(value As Double)
				Me.o0_.O_o..MarginHeader = value / 25.4
			End Set
		End Property

		' Token: 0x17001212 RID: 4626
		' (get) Token: 0x0600502C RID: 20524 RVA: 0x00218250 File Offset: 0x00216450
		' (set) Token: 0x0600502D RID: 20525 RVA: 0x0021825D File Offset: 0x0021645D
		<oO0oooo("1312")>
		Public Property Landscape As Boolean
			Get
				Return Me.o0_.O_o..Landscape
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..Landscape = value
			End Set
		End Property

		' Token: 0x17001213 RID: 4627
		' (get) Token: 0x0600502E RID: 20526 RVA: 0x0021826B File Offset: 0x0021646B
		' (set) Token: 0x0600502F RID: 20527 RVA: 0x00218278 File Offset: 0x00216478
		<oO0oooo("1312")>
		Public Property PaperKind As Integer
			Get
				Return CInt(Me.o0_.O_o..PaperKind)
			End Get
			Set(value As Integer)
				If [Enum].IsDefined(GetType(PaperKind), value) Then
					Me.o0_.O_o..PaperKind = CType(value, PaperKind)
				End If
			End Set
		End Property

		' Token: 0x17001214 RID: 4628
		' (get) Token: 0x06005030 RID: 20528 RVA: 0x0021829D File Offset: 0x0021649D
		' (set) Token: 0x06005031 RID: 20529 RVA: 0x002182B4 File Offset: 0x002164B4
		<oO0oooo("1312")>
		Public Property MarginBottom As Double
			Get
				Return Me.o0_.O_o..MarginBottom * 25.4
			End Get
			Set(value As Double)
				Me.o0_.O_o..MarginBottom = value / 25.4
			End Set
		End Property

		' Token: 0x17001215 RID: 4629
		' (get) Token: 0x06005032 RID: 20530 RVA: 0x002182CC File Offset: 0x002164CC
		' (set) Token: 0x06005033 RID: 20531 RVA: 0x002182E3 File Offset: 0x002164E3
		<oO0oooo("1312")>
		Public Property MarginLeft As Double
			Get
				Return Me.o0_.O_o..MarginLeft * 25.4
			End Get
			Set(value As Double)
				Me.o0_.O_o..MarginLeft = value / 25.4
			End Set
		End Property

		' Token: 0x17001216 RID: 4630
		' (get) Token: 0x06005034 RID: 20532 RVA: 0x002182FB File Offset: 0x002164FB
		' (set) Token: 0x06005035 RID: 20533 RVA: 0x00218312 File Offset: 0x00216512
		<oO0oooo("1312")>
		Public Property MarginRight As Double
			Get
				Return Me.o0_.O_o..MarginRight * 25.4
			End Get
			Set(value As Double)
				Me.o0_.O_o..MarginRight = value / 25.4
			End Set
		End Property

		' Token: 0x17001217 RID: 4631
		' (get) Token: 0x06005036 RID: 20534 RVA: 0x0021832A File Offset: 0x0021652A
		' (set) Token: 0x06005037 RID: 20535 RVA: 0x00218341 File Offset: 0x00216541
		<oO0oooo("1312")>
		Public Property MarginTop As Double
			Get
				Return Me.o0_.O_o..MarginTop * 25.4
			End Get
			Set(value As Double)
				Me.o0_.O_o..MarginTop = value / 25.4
			End Set
		End Property

		' Token: 0x17001218 RID: 4632
		' (get) Token: 0x06005038 RID: 20536 RVA: 0x00218359 File Offset: 0x00216559
		' (set) Token: 0x06005039 RID: 20537 RVA: 0x00218366 File Offset: 0x00216566
		<oO0oooo("1313")>
		Public Property AutoScale As Boolean
			Get
				Return Me.o0_.O_o..AutoScale
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..AutoScale = value
			End Set
		End Property

		' Token: 0x17001219 RID: 4633
		' (get) Token: 0x0600503A RID: 20538 RVA: 0x00218374 File Offset: 0x00216574
		' (set) Token: 0x0600503B RID: 20539 RVA: 0x00218381 File Offset: 0x00216581
		<oO0oooo("1313")>
		Public Property ScalingFactor As Integer
			Get
				Return Me.o0_.O_o..ScalingFactor
			End Get
			Set(value As Integer)
				Me.o0_.O_o..ScalingFactor = value
			End Set
		End Property

		' Token: 0x1700121A RID: 4634
		' (get) Token: 0x0600503C RID: 20540 RVA: 0x0021838F File Offset: 0x0021658F
		' (set) Token: 0x0600503D RID: 20541 RVA: 0x0021839C File Offset: 0x0021659C
		<oO0oooo("1313")>
		Public Property FitPagesAcross As Integer
			Get
				Return Me.o0_.O_o..FitPagesAcross
			End Get
			Set(value As Integer)
				Me.o0_.O_o..FitPagesAcross = value
			End Set
		End Property

		' Token: 0x1700121B RID: 4635
		' (get) Token: 0x0600503E RID: 20542 RVA: 0x002183AA File Offset: 0x002165AA
		' (set) Token: 0x0600503F RID: 20543 RVA: 0x002183B7 File Offset: 0x002165B7
		<oO0oooo("1313")>
		Public Property FitPagesDown As Integer
			Get
				Return Me.o0_.O_o..FitPagesDown
			End Get
			Set(value As Integer)
				Me.o0_.O_o..FitPagesDown = value
			End Set
		End Property

		' Token: 0x04002190 RID: 8592
		Private <<EMPTY_NAME>> As XLPrintSettings
	End Class
End Namespace
