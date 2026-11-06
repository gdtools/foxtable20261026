Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020001A3 RID: 419
	<ComVisible(True)>
	Public Class ListViewColumn
		' Token: 0x060013C6 RID: 5062 RVA: 0x0007FEF2 File Offset: 0x0007E0F2
		Public Sub New(A_0 As ColumnHeader)
			Me.O.oo_oO. = A_0
		End Sub

		' Token: 0x17000408 RID: 1032
		' (get) Token: 0x060013C7 RID: 5063 RVA: 0x0007FF01 File Offset: 0x0007E101
		Friend ReadOnly Property BaseColumn As ColumnHeader
			Get
				Return Me.O.oo_oO.
			End Get
		End Property

		' Token: 0x17000409 RID: 1033
		' (get) Token: 0x060013C8 RID: 5064 RVA: 0x0007FF0C File Offset: 0x0007E10C
		' (set) Token: 0x060013C9 RID: 5065 RVA: 0x0007FF5C File Offset: 0x0007E15C
		Public Property Name As String
			Get
				Dim result As String
				If Me.O.oo_oO. Is Me.O.oo_oO..ListView.Columns(0) Then
					result = CType(Me.O.oo_oO..ListView, o_OO_oOOO0o).O_O.0Oo_o.()
				Else
					result = Me.O.oo_oO..Name
				End If
				Return result
			End Get
			Set(value As String)
				If Me.O.oo_oO. Is Me.O.oo_oO..ListView.Columns(0) Then
					CType(Me.O.oo_oO..ListView, o_OO_oOOO0o).o0__o.O0.(value)
				Else
					Me.O.oo_oO..Name = value
				End If
				If Operators.CompareString(Me.O.oo_oO..Text, "", True) = 0 Then
					Me.O.oo_oO..Text = value
				End If
			End Set
		End Property

		' Token: 0x1700040A RID: 1034
		' (get) Token: 0x060013CA RID: 5066 RVA: 0x0007FFCF File Offset: 0x0007E1CF
		' (set) Token: 0x060013CB RID: 5067 RVA: 0x0007FFDC File Offset: 0x0007E1DC
		Public Property Text As String
			Get
				Return Me.O.oo_oO..Text
			End Get
			Set(value As String)
				Me.O.oo_oO..Text = value
			End Set
		End Property

		' Token: 0x1700040B RID: 1035
		' (get) Token: 0x060013CC RID: 5068 RVA: 0x0007FFEA File Offset: 0x0007E1EA
		' (set) Token: 0x060013CD RID: 5069 RVA: 0x0007FFF7 File Offset: 0x0007E1F7
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.O.oo_oO..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.O.oo_oO..TextAlign = value
			End Set
		End Property

		' Token: 0x1700040C RID: 1036
		' (get) Token: 0x060013CE RID: 5070 RVA: 0x00080005 File Offset: 0x0007E205
		' (set) Token: 0x060013CF RID: 5071 RVA: 0x00080012 File Offset: 0x0007E212
		Public Property Width As Integer
			Get
				Return Me.O.oo_oO..Width
			End Get
			Set(value As Integer)
				Me.O.oo_oO..Width = value
			End Set
		End Property

		' Token: 0x1700040D RID: 1037
		' (get) Token: 0x060013D0 RID: 5072 RVA: 0x00080020 File Offset: 0x0007E220
		' (set) Token: 0x060013D1 RID: 5073 RVA: 0x0008002D File Offset: 0x0007E22D
		Public Property Index As Integer
			Get
				Return Me.O.oo_oO..DisplayIndex
			End Get
			Set(value As Integer)
				Me.O.oo_oO..DisplayIndex = value
			End Set
		End Property

		' Token: 0x1700040E RID: 1038
		' (get) Token: 0x060013D2 RID: 5074 RVA: 0x0008003B File Offset: 0x0007E23B
		' (set) Token: 0x060013D3 RID: 5075 RVA: 0x00080048 File Offset: 0x0007E248
		Public Property Tag As Object
			Get
				Return Me.O.oo_oO..Tag
			End Get
			Set(value As Object)
				Me.O.oo_oO..Tag = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x060013D4 RID: 5076 RVA: 0x0008005B File Offset: 0x0007E25B
		Public Sub AutoResize(Optional mode As ColumnHeaderAutoResizeStyle = ColumnHeaderAutoResizeStyle.ColumnContent)
			Me.O.oo_oO..AutoResize(mode)
		End Sub

		' Token: 0x040007C5 RID: 1989
		Private <<EMPTY_NAME>> As ColumnHeader
	End Class
End Namespace
