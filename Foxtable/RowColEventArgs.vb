Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000095 RID: 149
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RowColEventArgs
		' Token: 0x06000581 RID: 1409 RVA: 0x0001D42B File Offset: 0x0001B62B
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As RecordGrid)
			Me.o_O0oOoo.ooOoo. = True
			Me.oo0Ooo.o_0__0_. = A_0
			Me.oo_.o_O_OO0. = A_1
			Me.oo_.o_O_OO0. = A_2
			Me.oo_.o_O_OO0. = A_3
		End Sub

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x06000582 RID: 1410 RVA: 0x0001D457 File Offset: 0x0001B657
		Public ReadOnly Property Table As Table
			Get
				Return Me.oo0Ooo.o_0__0_.
			End Get
		End Property

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x06000583 RID: 1411 RVA: 0x0001D45F File Offset: 0x0001B65F
		Public ReadOnly Property Row As Row
			Get
				Return Me.oo_.o_O_OO0.
			End Get
		End Property

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x06000584 RID: 1412 RVA: 0x0001D467 File Offset: 0x0001B667
		Public ReadOnly Property Col As Col
			Get
				Return Me.oo_.o_O_OO0.
			End Get
		End Property

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x06000585 RID: 1413 RVA: 0x0001D46F File Offset: 0x0001B66F
		' (set) Token: 0x06000586 RID: 1414 RVA: 0x0001D477 File Offset: 0x0001B677
		Public Property Cancel As Boolean
			Get
				Return Me.oo_.o_O_OO0.
			End Get
			Set(value As Boolean)
				Me.oo_.o_O_OO0. = value
			End Set
		End Property

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x06000587 RID: 1415 RVA: 0x0001D480 File Offset: 0x0001B680
		' (set) Token: 0x06000588 RID: 1416 RVA: 0x0001D488 File Offset: 0x0001B688
		Public Property IsFocusCell As Boolean
			Get
				Return Me.oO._o_00.
			End Get
			Friend Set(value As Boolean)
				Me.oO._o_00. = value
			End Set
		End Property

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x06000589 RID: 1417 RVA: 0x0001D491 File Offset: 0x0001B691
		Public ReadOnly Property RecordGrid As RecordGrid
			Get
				Return Me.oo_.o_O_OO0.
			End Get
		End Property

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x0600058A RID: 1418 RVA: 0x0001D499 File Offset: 0x0001B699
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x0600058B RID: 1419 RVA: 0x0001D4A6 File Offset: 0x0001B6A6
		' (set) Token: 0x0600058C RID: 1420 RVA: 0x0001D4AE File Offset: 0x0001B6AE
		Public Property [Continue] As Boolean
			Get
				Return Me.o_O0oOoo.ooOoo.
			End Get
			Set(value As Boolean)
				Me.o_O0oOoo.ooOoo. = value
			End Set
		End Property

		' Token: 0x04000141 RID: 321
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04000142 RID: 322
		Private <<EMPTY_NAME>> As Row

		' Token: 0x04000143 RID: 323
		Private <<EMPTY_NAME>> As Col

		' Token: 0x04000144 RID: 324
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000145 RID: 325
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000146 RID: 326
		Private <<EMPTY_NAME>> As RecordGrid

		' Token: 0x04000147 RID: 327
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
