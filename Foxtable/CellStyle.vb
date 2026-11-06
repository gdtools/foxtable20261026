Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1FlexGrid

Namespace Foxtable
	' Token: 0x0200031E RID: 798
	<oO0oooo("0656")>
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CellStyle
		' Token: 0x06002B3E RID: 11070 RVA: 0x0012ED32 File Offset: 0x0012CF32
		Public Sub New(A_0 As DataTable, A_1 As String)
			Me.oOO.oO_____OO_. = A_0
			Me.oOO.oO_____OO_. = A_1
		End Sub

		' Token: 0x17000A36 RID: 2614
		' (get) Token: 0x06002B3F RID: 11071 RVA: 0x0012ED48 File Offset: 0x0012CF48
		' (set) Token: 0x06002B40 RID: 11072 RVA: 0x0012EDB4 File Offset: 0x0012CFB4
		Public Property BackColor As Color
			Get
				Dim backColor As Color
				If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
					backColor = OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).BackColor
				End If
				Return backColor
			End Get
			Set(value As Color)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOO.oO_____OO_. AndAlso table.foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
							table.foxGrid.Styles(Me.oOO.oO_____OO_.).BackColor = value
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000A37 RID: 2615
		' (get) Token: 0x06002B41 RID: 11073 RVA: 0x0012EE3C File Offset: 0x0012D03C
		' (set) Token: 0x06002B42 RID: 11074 RVA: 0x0012EEA8 File Offset: 0x0012D0A8
		Public Property ForeColor As Color
			Get
				Dim foreColor As Color
				If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
					foreColor = OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).ForeColor
				End If
				Return foreColor
			End Get
			Set(value As Color)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOO.oO_____OO_. AndAlso table.foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
							table.foxGrid.Styles(Me.oOO.oO_____OO_.).ForeColor = value
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000A38 RID: 2616
		' (get) Token: 0x06002B43 RID: 11075 RVA: 0x0012EF30 File Offset: 0x0012D130
		' (set) Token: 0x06002B44 RID: 11076 RVA: 0x0012EFA0 File Offset: 0x0012D1A0
		Public Property BorderColor As Color
			Get
				Dim color As Color
				If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
					color = OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).Border.Color
				End If
				Return color
			End Get
			Set(value As Color)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOO.oO_____OO_. AndAlso table.foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
							table.foxGrid.Styles(Me.oOO.oO_____OO_.).Border.Color = value
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000A39 RID: 2617
		' (get) Token: 0x06002B45 RID: 11077 RVA: 0x0012F02C File Offset: 0x0012D22C
		' (set) Token: 0x06002B46 RID: 11078 RVA: 0x0012F09C File Offset: 0x0012D29C
		Public Property FontBold As Boolean
			Get
				Dim bold As Boolean
				If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
					bold = OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).Font.Bold
				End If
				Return bold
			End Get
			Set(value As Boolean)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOO.oO_____OO_. AndAlso table.foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
							Dim cellStyle As CellStyle = table.foxGrid.Styles(Me.oOO.oO_____OO_.)
							If value Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Or FontStyle.Bold)
							ElseIf(cellStyle.Font.Style And FontStyle.Bold) = FontStyle.Bold Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Xor FontStyle.Bold)
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000A3A RID: 2618
		' (get) Token: 0x06002B47 RID: 11079 RVA: 0x0012F17C File Offset: 0x0012D37C
		' (set) Token: 0x06002B48 RID: 11080 RVA: 0x0012F1EC File Offset: 0x0012D3EC
		Public Property FontItalic As Boolean
			Get
				Dim italic As Boolean
				If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
					italic = OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).Font.Italic
				End If
				Return italic
			End Get
			Set(value As Boolean)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOO.oO_____OO_. AndAlso table.foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
							Dim cellStyle As CellStyle = table.foxGrid.Styles(Me.oOO.oO_____OO_.)
							If value Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Or FontStyle.Italic)
							ElseIf(cellStyle.Font.Style And FontStyle.Italic) = FontStyle.Italic Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Xor FontStyle.Italic)
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000A3B RID: 2619
		' (get) Token: 0x06002B49 RID: 11081 RVA: 0x0012F2CC File Offset: 0x0012D4CC
		' (set) Token: 0x06002B4A RID: 11082 RVA: 0x0012F33C File Offset: 0x0012D53C
		Public Property FontUnderline As Boolean
			Get
				Dim underline As Boolean
				If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
					underline = OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).Font.Underline
				End If
				Return underline
			End Get
			Set(value As Boolean)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOO.oO_____OO_. AndAlso table.foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
							Dim cellStyle As CellStyle = table.foxGrid.Styles(Me.oOO.oO_____OO_.)
							If value Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Or FontStyle.Underline)
							ElseIf(cellStyle.Font.Style And FontStyle.Underline) = FontStyle.Underline Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Xor FontStyle.Underline)
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000A3C RID: 2620
		' (get) Token: 0x06002B4B RID: 11083 RVA: 0x0012F41C File Offset: 0x0012D61C
		' (set) Token: 0x06002B4C RID: 11084 RVA: 0x0012F48C File Offset: 0x0012D68C
		Public Property FontStrikeout As Boolean
			Get
				Dim strikeout As Boolean
				If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
					strikeout = OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).Font.Strikeout
				End If
				Return strikeout
			End Get
			Set(value As Boolean)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOO.oO_____OO_. AndAlso table.foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
							Dim cellStyle As CellStyle = table.foxGrid.Styles(Me.oOO.oO_____OO_.)
							If value Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Or FontStyle.Strikeout)
							ElseIf(cellStyle.Font.Style And FontStyle.Strikeout) = FontStyle.Strikeout Then
								cellStyle.Font = New Font(cellStyle.Font, cellStyle.Font.Style Xor FontStyle.Strikeout)
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x06002B4D RID: 11085 RVA: 0x0012F56C File Offset: 0x0012D76C
		Public Sub Clear()
			If OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles.Contains(Me.oOO.oO_____OO_.) Then
				OO_00oOO.Tables(Me.oOO.oO_____OO_..Name).foxGrid.Styles(Me.oOO.oO_____OO_.).Clear()
			End If
		End Sub

		' Token: 0x0400118C RID: 4492
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400118D RID: 4493
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
