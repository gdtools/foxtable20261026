Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports C1.Win.C1FlexGrid
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002EF RID: 751
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DrawCellEventArgs
		' Token: 0x06002783 RID: 10115 RVA: 0x0010B05C File Offset: 0x0010925C
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As OwnerDrawCellEventArgs, A_4 As C1FlexGrid, A_5 As Boolean)
			Me.ooo_OOO.O0O. = A_0
			Me.oOOo__O0O0.0O. = A_1
			Me.oOOo__O0O0.0O. = A_2
			Me.oOOo__O0O0.0O. = A_3
			Me.oOOo__O0O0.0O. = A_4
			Me.oOOo__O0O0.0O. = A_5
		End Sub

		' Token: 0x170008F9 RID: 2297
		' (get) Token: 0x06002784 RID: 10116 RVA: 0x0010B094 File Offset: 0x00109294
		Public ReadOnly Property MouseHover As Boolean
			Get
				Dim result As Boolean
				If Me.oOOo__O0O0.0O..MouseRow = Me.oOOo__O0O0.0O..Row AndAlso Me.oOOo__O0O0.0O..MouseCol = Me.oOOo__O0O0.0O..Col Then
					result = True
				End If
				Return result
			End Get
		End Property

		' Token: 0x170008FA RID: 2298
		' (get) Token: 0x06002785 RID: 10117 RVA: 0x0010B0D4 File Offset: 0x001092D4
		Public ReadOnly Property Table As Table
			Get
				Return Me.ooo_OOO.O0O.
			End Get
		End Property

		' Token: 0x170008FB RID: 2299
		' (get) Token: 0x06002786 RID: 10118 RVA: 0x0010B0DC File Offset: 0x001092DC
		Public ReadOnly Property Row As Row
			Get
				Return Me.oOOo__O0O0.0O.
			End Get
		End Property

		' Token: 0x170008FC RID: 2300
		' (get) Token: 0x06002787 RID: 10119 RVA: 0x0010B0E4 File Offset: 0x001092E4
		Public ReadOnly Property Col As Col
			Get
				Return Me.oOOo__O0O0.0O.
			End Get
		End Property

		' Token: 0x170008FD RID: 2301
		' (get) Token: 0x06002788 RID: 10120 RVA: 0x0010B0EC File Offset: 0x001092EC
		' (set) Token: 0x06002789 RID: 10121 RVA: 0x0010B0F9 File Offset: 0x001092F9
		Public Property Text As String
			Get
				Return Me.oOOo__O0O0.0O..Text
			End Get
			Set(value As String)
				Me.oOOo__O0O0.0O..Text = value
			End Set
		End Property

		' Token: 0x170008FE RID: 2302
		' (get) Token: 0x0600278A RID: 10122 RVA: 0x0010B107 File Offset: 0x00109307
		Public ReadOnly Property IsPrint As Boolean
			Get
				Return Me.oOOo__O0O0.0O.
			End Get
		End Property

		' Token: 0x170008FF RID: 2303
		' (get) Token: 0x0600278B RID: 10123 RVA: 0x0010B10F File Offset: 0x0010930F
		' (set) Token: 0x0600278C RID: 10124 RVA: 0x0010B11C File Offset: 0x0010931C
		Public Property Image As Image
			Get
				Return Me.oOOo__O0O0.0O..Image
			End Get
			Set(value As Image)
				Me.oOOo__O0O0.0O..Image = value
			End Set
		End Property

		' Token: 0x17000900 RID: 2304
		' (get) Token: 0x0600278D RID: 10125 RVA: 0x0010B12A File Offset: 0x0010932A
		' (set) Token: 0x0600278E RID: 10126 RVA: 0x0010B132 File Offset: 0x00109332
		Public Property Style As String
			Get
				Return Me.ooo_OOO.O0O.
			End Get
			Set(value As String)
				Me.ooo_OOO.O0O. = value
			End Set
		End Property

		' Token: 0x17000901 RID: 2305
		' (get) Token: 0x0600278F RID: 10127 RVA: 0x0010B13B File Offset: 0x0010933B
		Public ReadOnly Property Graphics As Graphics
			Get
				Return Me.oOOo__O0O0.0O..Graphics
			End Get
		End Property

		' Token: 0x17000902 RID: 2306
		' (get) Token: 0x06002790 RID: 10128 RVA: 0x0010B148 File Offset: 0x00109348
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Bounds As Rectangle
			Get
				Return Me.oOOo__O0O0.0O..Bounds
			End Get
		End Property

		' Token: 0x17000903 RID: 2307
		' (get) Token: 0x06002791 RID: 10129 RVA: 0x0010B158 File Offset: 0x00109358
		Public ReadOnly Property X As Integer
			Get
				Return Me.Bounds.X
			End Get
		End Property

		' Token: 0x17000904 RID: 2308
		' (get) Token: 0x06002792 RID: 10130 RVA: 0x0010B174 File Offset: 0x00109374
		Public ReadOnly Property Y As Integer
			Get
				Return Me.Bounds.Y
			End Get
		End Property

		' Token: 0x17000905 RID: 2309
		' (get) Token: 0x06002793 RID: 10131 RVA: 0x0010B190 File Offset: 0x00109390
		Public ReadOnly Property Width As Integer
			Get
				Return Me.Bounds.Width
			End Get
		End Property

		' Token: 0x17000906 RID: 2310
		' (get) Token: 0x06002794 RID: 10132 RVA: 0x0010B1AC File Offset: 0x001093AC
		Public ReadOnly Property Height As Integer
			Get
				Return Me.Bounds.Height
			End Get
		End Property

		' Token: 0x06002795 RID: 10133 RVA: 0x0010B1C7 File Offset: 0x001093C7
		Public Sub StartDraw()
			If Not Me.oOOo__O0O0.0O. Then
				Me.oOOo__O0O0.0O..DrawCell(3)
			End If
			Me.O0O__O._0. = True
		End Sub

		' Token: 0x06002796 RID: 10134 RVA: 0x0010B1E4 File Offset: 0x001093E4
		Public Sub EndDraw()
			If Operators.CompareString(Me.Text, "", True) > 0 Then
				Me.oOOo__O0O0.0O..Text = Me.Text
			End If
			If Not Me.oOOo__O0O0.0O. Then
				If Operators.CompareString(Me.Style, "", True) > 0 AndAlso Me.oOOo__O0O0.0O..Styles.Contains("User" + Me.Style) Then
					Me.oOOo__O0O0.0O..Style = Me.oOOo__O0O0.0O..Styles("User" + Me.Style)
				End If
				Me.oOOo__O0O0.0O..DrawCell(4)
				Me.oOOo__O0O0.0O..Handled = True
			End If
		End Sub

		' Token: 0x17000907 RID: 2311
		' (get) Token: 0x06002797 RID: 10135 RVA: 0x0010B297 File Offset: 0x00109497
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x17000908 RID: 2312
		' (get) Token: 0x06002798 RID: 10136 RVA: 0x0010B2A4 File Offset: 0x001094A4
		<oO0oooo("3740")>
		Public ReadOnly Property Chart As CellChart
			Get
				If Me.oOOo__O0O0.0O. Is Nothing Then
					Me.oOOo__O0O0.0O. = New CellChart()
				End If
				Return Me.oOOo__O0O0.0O.
			End Get
		End Property

		' Token: 0x06002799 RID: 10137 RVA: 0x0010B2C0 File Offset: 0x001094C0
		<oO0oooo("3740")>
		Public Sub DrawChart()
			Me.Text = ""
			If Me.oOOo__O0O0.0O..Values.Count < 2 OrElse Me.oOOo__O0O0.0O..Bounds.Width <= 0 OrElse Me.oOOo__O0O0.0O..Bounds.Height <= 0 OrElse Me.oOOo__O0O0.0O..Bounds.Width < Me.oOOo__O0O0.0O..Space * 2 OrElse Me.oOOo__O0O0.0O..Bounds.Height < Me.oOOo__O0O0.0O..Space * 2 Then
				Me.oOOo__O0O0.0O..DrawCell()
				Me.oOOo__O0O0.0O..SetUserData(Me.oOOo__O0O0.0O..Row, Me.oOOo__O0O0.0O..Col, Nothing)
				Return
			End If
			Me.oOOo__O0O0.0O..SetUserData(Me.oOOo__O0O0.0O..Row, Me.oOOo__O0O0.0O..Col, String.Concat(New String() { "@{", Conversions.ToString(Me.oOOo__O0O0.0O..Values.Count), ",", Conversions.ToString(Me.oOOo__O0O0.0O..Space), "}" }))
			Dim rectangle As Rectangle
			If Me.oOOo__O0O0.0O..StartingValue = -1.7976931348623157E+308 Then
				rectangle = Me.oOOo__O0O0.0O..Bounds
			Else
				rectangle = Me.Table.o.oO__OO_oo_0_.(Me.oOOo__O0O0.0O..Bounds, Me.oOOo__O0O0.0O..Row, Me.oOOo__O0O0.0O..Col)
				Dim num As Integer = Me.oOOo__O0O0.0O..Values.Count - 1
				For i As Integer = 0 To num
					Me.oOOo__O0O0.0O..Values(i) = Me.oOOo__O0O0.0O..Values(i) - Me.oOOo__O0O0.0O..StartingValue
				Next
				Me.oOOo__O0O0.0O..AddValues(New Object() { 0 })
			End If
			rectangle.Inflate(-Me.Chart.Space, -Me.Chart.Space)
			Me.oOOo__O0O0.0O..Width = rectangle.Width
			Me.oOOo__O0O0.0O..Height = rectangle.Height
			Me.oOOo__O0O0.0O..BackColor = Color.White
			Me.StartDraw()
			Me.Chart.Data = Me.Chart.Values
			Dim bitmap As Bitmap = New Bitmap(Me.oOOo__O0O0.0O..Width, Me.oOOo__O0O0.0O..Height)
			Me.Chart.DrawToBitmap(bitmap, Me.Chart.Bounds)
			Me.oOOo__O0O0.0O..Graphics.DrawImageUnscaled(bitmap, New Point(Me.oOOo__O0O0.0O..Bounds.X + Me.Chart.Space, Me.oOOo__O0O0.0O..Bounds.Y + Me.Chart.Space))
			Me.EndDraw()
			Me.oOOo__O0O0.0O..Values.Clear()
			Me.oOOo__O0O0.0O..Dispose()
		End Sub

		' Token: 0x04001063 RID: 4195
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001064 RID: 4196
		Private <<EMPTY_NAME>> As Row

		' Token: 0x04001065 RID: 4197
		Private <<EMPTY_NAME>> As Col

		' Token: 0x04001066 RID: 4198
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001067 RID: 4199
		Private <<EMPTY_NAME>> As OwnerDrawCellEventArgs

		' Token: 0x04001068 RID: 4200
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001069 RID: 4201
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400106A RID: 4202
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400106B RID: 4203
		Private <<EMPTY_NAME>> As CellChart
	End Class
End Namespace
