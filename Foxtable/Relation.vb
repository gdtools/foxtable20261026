Imports System
Imports System.Data
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002FF RID: 767
	<oO0oooo("1941")>
	<ComVisible(True)>
	Public Class Relation
		' Token: 0x06002822 RID: 10274 RVA: 0x0010D354 File Offset: 0x0010B554
		Public Sub New(A_0 As DataRelation)
			Me.o.0OoO. = CType(A_0, O0Oo)
			Me.O.OOoo_o0. = New DataCol(A_0.ParentColumns.Length - 1 + 1 - 1) {}
			Me.oo_.000o0Oo0. = New DataCol(A_0.ChildColumns.Length - 1 + 1 - 1) {}
			Dim num As Integer = Me.O.OOoo_o0..Length - 1
			For i As Integer = 0 To num
				If Operators.CompareString(A_0.ParentColumns(i).ColumnName, "_Identify", True) = 0 Then
					Me.O.OOoo_o0.(i) = New DataCol(A_0.ParentColumns(i))
				Else
					Me.O.OOoo_o0.(i) = Me.ParentTable.DataCols(A_0.ParentColumns(i).ColumnName)
				End If
				Me.oo_.000o0Oo0.(i) = Me.ChildTable.DataCols(A_0.ChildColumns(i).ColumnName)
			Next
		End Sub

		' Token: 0x17000946 RID: 2374
		' (get) Token: 0x06002823 RID: 10275 RVA: 0x0010D436 File Offset: 0x0010B636
		Public ReadOnly Property ParentTable As DataTable
			Get
				Return OO_00oOO.DataTables(Me.o.0OoO..ParentTable.TableName)
			End Get
		End Property

		' Token: 0x17000947 RID: 2375
		' (get) Token: 0x06002824 RID: 10276 RVA: 0x0010D452 File Offset: 0x0010B652
		Public ReadOnly Property ChildTable As DataTable
			Get
				Return OO_00oOO.DataTables(Me.o.0OoO..ChildTable.TableName)
			End Get
		End Property

		' Token: 0x17000948 RID: 2376
		' (get) Token: 0x06002825 RID: 10277 RVA: 0x0010D46E File Offset: 0x0010B66E
		Public ReadOnly Property ParentColumns As DataCol()
			Get
				Return Me.O.OOoo_o0.
			End Get
		End Property

		' Token: 0x17000949 RID: 2377
		' (get) Token: 0x06002826 RID: 10278 RVA: 0x0010D476 File Offset: 0x0010B676
		Public ReadOnly Property ParentColumn As DataCol
			Get
				Return Me.O.OOoo_o0.(0)
			End Get
		End Property

		' Token: 0x1700094A RID: 2378
		' (get) Token: 0x06002827 RID: 10279 RVA: 0x0010D480 File Offset: 0x0010B680
		Public ReadOnly Property ChildColumns As DataCol()
			Get
				Return Me.oo_.000o0Oo0.
			End Get
		End Property

		' Token: 0x1700094B RID: 2379
		' (get) Token: 0x06002828 RID: 10280 RVA: 0x0010D488 File Offset: 0x0010B688
		Public ReadOnly Property ChildColumn As DataCol
			Get
				Return Me.oo_.000o0Oo0.(0)
			End Get
		End Property

		' Token: 0x1700094C RID: 2380
		' (get) Token: 0x06002829 RID: 10281 RVA: 0x0010D492 File Offset: 0x0010B692
		Public ReadOnly Property Name As String
			Get
				Return Me.o.0OoO..RelationName
			End Get
		End Property

		' Token: 0x1700094D RID: 2381
		' (get) Token: 0x0600282A RID: 10282 RVA: 0x0010D49F File Offset: 0x0010B69F
		' (set) Token: 0x0600282B RID: 10283 RVA: 0x0010D4AC File Offset: 0x0010B6AC
		Public Property CascadeDelete As Boolean
			Get
				Return Me.o.0OoO..o.O0_o.()
			End Get
			Set(value As Boolean)
				Me.o.0OoO..o.O0_o.(value)
			End Set
		End Property

		' Token: 0x1700094E RID: 2382
		' (get) Token: 0x0600282C RID: 10284 RVA: 0x0010D4BA File Offset: 0x0010B6BA
		' (set) Token: 0x0600282D RID: 10285 RVA: 0x0010D4C7 File Offset: 0x0010B6C7
		Public Property CascadeUpdate As Boolean
			Get
				Return Me.o.0OoO..oo0__.0Oo0o_.()
			End Get
			Set(value As Boolean)
				Me.o.0OoO..oo0__.0Oo0o_.(value)
			End Set
		End Property

		' Token: 0x1700094F RID: 2383
		' (get) Token: 0x0600282E RID: 10286 RVA: 0x0010D4D5 File Offset: 0x0010B6D5
		' (set) Token: 0x0600282F RID: 10287 RVA: 0x0010D4E2 File Offset: 0x0010B6E2
		Public Property RelationPath As RelationPathEnum
			Get
				Return Me.o.0OoO..oo0__.0Oo0o_.()
			End Get
			Set(value As RelationPathEnum)
				Me.o.0OoO..oo0__.0Oo0o_.(value)
			End Set
		End Property

		' Token: 0x040010A8 RID: 4264
		Private <<EMPTY_NAME>> As DataCol()

		' Token: 0x040010A9 RID: 4265
		Private <<EMPTY_NAME>> As DataCol()

		' Token: 0x040010AA RID: 4266
		Private <<EMPTY_NAME>> As O0Oo
	End Class
End Namespace
