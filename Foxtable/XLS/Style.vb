Imports System
Imports System.Drawing
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004EA RID: 1258
	Public Class Style
		' Token: 0x0600509F RID: 20639 RVA: 0x00218C44 File Offset: 0x00216E44
		Friend Sub New(A_0 As XLStyle)
			Me.Ooo_O__.0. = A_0
		End Sub

		' Token: 0x1700123C RID: 4668
		' (get) Token: 0x060050A0 RID: 20640 RVA: 0x00218C53 File Offset: 0x00216E53
		' (set) Token: 0x060050A1 RID: 20641 RVA: 0x00218C60 File Offset: 0x00216E60
		<oO0oooo("1161")>
		Public Property AlignHorz As AlignHorzEnum
			Get
				Return Me.Ooo_O__.0..AlignHorz
			End Get
			Set(value As AlignHorzEnum)
				Me.Ooo_O__.0..AlignHorz = value
			End Set
		End Property

		' Token: 0x1700123D RID: 4669
		' (get) Token: 0x060050A2 RID: 20642 RVA: 0x00218C6E File Offset: 0x00216E6E
		' (set) Token: 0x060050A3 RID: 20643 RVA: 0x00218C7B File Offset: 0x00216E7B
		<oO0oooo("1161")>
		Public Property AlignVert As AlignVertEnum
			Get
				Return Me.Ooo_O__.0..AlignVert
			End Get
			Set(value As AlignVertEnum)
				Me.Ooo_O__.0..AlignVert = value
			End Set
		End Property

		' Token: 0x1700123E RID: 4670
		' (get) Token: 0x060050A4 RID: 20644 RVA: 0x00218C89 File Offset: 0x00216E89
		' (set) Token: 0x060050A5 RID: 20645 RVA: 0x00218C96 File Offset: 0x00216E96
		Public Property BackColor As Color
			Get
				Return Me.Ooo_O__.0..BackColor
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..BackColor = value
			End Set
		End Property

		' Token: 0x1700123F RID: 4671
		' (get) Token: 0x060050A6 RID: 20646 RVA: 0x00218CA4 File Offset: 0x00216EA4
		' (set) Token: 0x060050A7 RID: 20647 RVA: 0x00218CB1 File Offset: 0x00216EB1
		<oO0oooo("1163")>
		Public Property BorderBottom As LineStyleEnum
			Get
				Return Me.Ooo_O__.0..BorderBottom
			End Get
			Set(value As LineStyleEnum)
				Me.Ooo_O__.0..BorderBottom = CByte(value)
			End Set
		End Property

		' Token: 0x17001240 RID: 4672
		' (get) Token: 0x060050A8 RID: 20648 RVA: 0x00218CC0 File Offset: 0x00216EC0
		' (set) Token: 0x060050A9 RID: 20649 RVA: 0x00218CCD File Offset: 0x00216ECD
		<oO0oooo("1163")>
		Public Property BorderColorBottom As Color
			Get
				Return Me.Ooo_O__.0..BorderColorBottom
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..BorderColorBottom = value
			End Set
		End Property

		' Token: 0x17001241 RID: 4673
		' (get) Token: 0x060050AA RID: 20650 RVA: 0x00218CDB File Offset: 0x00216EDB
		' (set) Token: 0x060050AB RID: 20651 RVA: 0x00218CE8 File Offset: 0x00216EE8
		<oO0oooo("1163")>
		Public Property BorderLeft As LineStyleEnum
			Get
				Return Me.Ooo_O__.0..BorderLeft
			End Get
			Set(value As LineStyleEnum)
				Me.Ooo_O__.0..BorderLeft = CByte(value)
			End Set
		End Property

		' Token: 0x17001242 RID: 4674
		' (get) Token: 0x060050AC RID: 20652 RVA: 0x00218CF7 File Offset: 0x00216EF7
		' (set) Token: 0x060050AD RID: 20653 RVA: 0x00218D04 File Offset: 0x00216F04
		<oO0oooo("1163")>
		Public Property BorderColorLeft As Color
			Get
				Return Me.Ooo_O__.0..BorderColorLeft
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..BorderColorLeft = value
			End Set
		End Property

		' Token: 0x17001243 RID: 4675
		' (get) Token: 0x060050AE RID: 20654 RVA: 0x00218D12 File Offset: 0x00216F12
		' (set) Token: 0x060050AF RID: 20655 RVA: 0x00218D1F File Offset: 0x00216F1F
		<oO0oooo("1163")>
		Public Property BorderTop As LineStyleEnum
			Get
				Return Me.Ooo_O__.0..BorderTop
			End Get
			Set(value As LineStyleEnum)
				Me.Ooo_O__.0..BorderTop = CByte(value)
			End Set
		End Property

		' Token: 0x17001244 RID: 4676
		' (get) Token: 0x060050B0 RID: 20656 RVA: 0x00218D2E File Offset: 0x00216F2E
		' (set) Token: 0x060050B1 RID: 20657 RVA: 0x00218D3B File Offset: 0x00216F3B
		<oO0oooo("1163")>
		Public Property BorderColorTop As Color
			Get
				Return Me.Ooo_O__.0..BorderColorTop
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..BorderColorTop = value
			End Set
		End Property

		' Token: 0x17001245 RID: 4677
		' (get) Token: 0x060050B2 RID: 20658 RVA: 0x00218D49 File Offset: 0x00216F49
		' (set) Token: 0x060050B3 RID: 20659 RVA: 0x00218D56 File Offset: 0x00216F56
		<oO0oooo("1163")>
		Public Property BorderRight As LineStyleEnum
			Get
				Return Me.Ooo_O__.0..BorderRight
			End Get
			Set(value As LineStyleEnum)
				Me.Ooo_O__.0..BorderRight = CByte(value)
			End Set
		End Property

		' Token: 0x17001246 RID: 4678
		' (get) Token: 0x060050B4 RID: 20660 RVA: 0x00218D65 File Offset: 0x00216F65
		' (set) Token: 0x060050B5 RID: 20661 RVA: 0x00218D72 File Offset: 0x00216F72
		<oO0oooo("1163")>
		Public Property BorderColorRight As Color
			Get
				Return Me.Ooo_O__.0..BorderColorRight
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..BorderColorRight = value
			End Set
		End Property

		' Token: 0x17001247 RID: 4679
		' (get) Token: 0x060050B6 RID: 20662 RVA: 0x00218D80 File Offset: 0x00216F80
		' (set) Token: 0x060050B7 RID: 20663 RVA: 0x00218D8D File Offset: 0x00216F8D
		<oO0oooo("1164")>
		Public Property Diagonal As DiagonalEnum
			Get
				Return Me.Ooo_O__.0..Diagonal
			End Get
			Set(value As DiagonalEnum)
				Me.Ooo_O__.0..Diagonal = CByte(value)
			End Set
		End Property

		' Token: 0x17001248 RID: 4680
		' (get) Token: 0x060050B8 RID: 20664 RVA: 0x00218D9C File Offset: 0x00216F9C
		' (set) Token: 0x060050B9 RID: 20665 RVA: 0x00218DA9 File Offset: 0x00216FA9
		<oO0oooo("1164")>
		Public Property DiagonalColor As Color
			Get
				Return Me.Ooo_O__.0..DiagonalColor
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..DiagonalColor = value
			End Set
		End Property

		' Token: 0x17001249 RID: 4681
		' (get) Token: 0x060050BA RID: 20666 RVA: 0x00218DB7 File Offset: 0x00216FB7
		' (set) Token: 0x060050BB RID: 20667 RVA: 0x00218DC4 File Offset: 0x00216FC4
		<oO0oooo("1164")>
		Public Property DiagonalStyle As LineStyleEnum
			Get
				Return Me.Ooo_O__.0..DiagonalStyle
			End Get
			Set(value As LineStyleEnum)
				Me.Ooo_O__.0..DiagonalStyle = CByte(value)
			End Set
		End Property

		' Token: 0x1700124A RID: 4682
		' (get) Token: 0x060050BC RID: 20668 RVA: 0x00218DD4 File Offset: 0x00216FD4
		' (set) Token: 0x060050BD RID: 20669 RVA: 0x00218E0E File Offset: 0x0021700E
		Public Property Font As Font
			Get
				Dim result As Font
				If Me.Ooo_O__.0..Font IsNot Nothing Then
					result = Me.Ooo_O__.0..Font
				Else
					result = New Font("宋体", 12F, FontStyle.Regular)
				End If
				Return result
			End Get
			Set(value As Font)
				Me.Ooo_O__.0..Font = value
			End Set
		End Property

		' Token: 0x1700124B RID: 4683
		' (get) Token: 0x060050BE RID: 20670 RVA: 0x00218E1C File Offset: 0x0021701C
		' (set) Token: 0x060050BF RID: 20671 RVA: 0x00218E29 File Offset: 0x00217029
		Public Property FontName As String
			Get
				Return Me.Font.Name
			End Get
			Set(value As String)
				Me.Font = New Font(value, Me.Font.Size, Me.Font.Style)
			End Set
		End Property

		' Token: 0x1700124C RID: 4684
		' (get) Token: 0x060050C0 RID: 20672 RVA: 0x00218E4D File Offset: 0x0021704D
		' (set) Token: 0x060050C1 RID: 20673 RVA: 0x00218E5A File Offset: 0x0021705A
		Public Property FontSize As Single
			Get
				Return Me.Font.Size
			End Get
			Set(value As Single)
				Me.Font = New Font(Me.Font.Name, value, Me.Font.Style)
			End Set
		End Property

		' Token: 0x1700124D RID: 4685
		' (get) Token: 0x060050C2 RID: 20674 RVA: 0x00218E7E File Offset: 0x0021707E
		' (set) Token: 0x060050C3 RID: 20675 RVA: 0x00218E8C File Offset: 0x0021708C
		Public Property FontBold As Boolean
			Get
				Return Me.Font.Bold
			End Get
			Set(value As Boolean)
				If value Then
					Me.Font = New Font(Me.Font, Me.Font.Style Or FontStyle.Bold)
					Return
				End If
				Me.Font = New Font(Me.Font, Me.Font.Style Xor FontStyle.Bold)
			End Set
		End Property

		' Token: 0x1700124E RID: 4686
		' (get) Token: 0x060050C4 RID: 20676 RVA: 0x00218ED9 File Offset: 0x002170D9
		' (set) Token: 0x060050C5 RID: 20677 RVA: 0x00218EE8 File Offset: 0x002170E8
		Public Property FontItalic As Boolean
			Get
				Return Me.Font.Italic
			End Get
			Set(value As Boolean)
				If value Then
					Me.Font = New Font(Me.Font, Me.Font.Style Or FontStyle.Italic)
					Return
				End If
				Me.Font = New Font(Me.Font, Me.Font.Style Xor FontStyle.Italic)
			End Set
		End Property

		' Token: 0x1700124F RID: 4687
		' (get) Token: 0x060050C6 RID: 20678 RVA: 0x00218F35 File Offset: 0x00217135
		' (set) Token: 0x060050C7 RID: 20679 RVA: 0x00218F44 File Offset: 0x00217144
		Public Property FontStrikeout As Boolean
			Get
				Return Me.Font.Strikeout
			End Get
			Set(value As Boolean)
				If value Then
					Me.Font = New Font(Me.Font, Me.Font.Style Or FontStyle.Strikeout)
					Return
				End If
				Me.Font = New Font(Me.Font, Me.Font.Style Xor FontStyle.Strikeout)
			End Set
		End Property

		' Token: 0x17001250 RID: 4688
		' (get) Token: 0x060050C8 RID: 20680 RVA: 0x00218F91 File Offset: 0x00217191
		' (set) Token: 0x060050C9 RID: 20681 RVA: 0x00218FA0 File Offset: 0x002171A0
		Public Property FontUnderline As Boolean
			Get
				Return Me.Font.Underline
			End Get
			Set(value As Boolean)
				If value Then
					Me.Font = New Font(Me.Font, Me.Font.Style Or FontStyle.Underline)
					Return
				End If
				Me.Font = New Font(Me.Font, Me.Font.Style Xor FontStyle.Underline)
			End Set
		End Property

		' Token: 0x17001251 RID: 4689
		' (get) Token: 0x060050CA RID: 20682 RVA: 0x00218FED File Offset: 0x002171ED
		' (set) Token: 0x060050CB RID: 20683 RVA: 0x00218FFA File Offset: 0x002171FA
		Public Property ForeColor As Color
			Get
				Return Me.Ooo_O__.0..ForeColor
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..ForeColor = value
			End Set
		End Property

		' Token: 0x17001252 RID: 4690
		' (get) Token: 0x060050CC RID: 20684 RVA: 0x00219008 File Offset: 0x00217208
		' (set) Token: 0x060050CD RID: 20685 RVA: 0x0021901A File Offset: 0x0021721A
		Public Property Format As String
			Get
				Return XLStyle.FormatXLToDotNet(Me.Ooo_O__.0..Format)
			End Get
			Set(value As String)
				Me.Ooo_O__.0..Format = XLStyle.FormatDotNetToXL(value)
			End Set
		End Property

		' Token: 0x17001253 RID: 4691
		' (get) Token: 0x060050CE RID: 20686 RVA: 0x0021902D File Offset: 0x0021722D
		' (set) Token: 0x060050CF RID: 20687 RVA: 0x0021903A File Offset: 0x0021723A
		Public Property Locked As Boolean
			Get
				Return Me.Ooo_O__.0..Locked
			End Get
			Set(value As Boolean)
				Me.Ooo_O__.0..Locked = True
			End Set
		End Property

		' Token: 0x17001254 RID: 4692
		' (get) Token: 0x060050D0 RID: 20688 RVA: 0x00219048 File Offset: 0x00217248
		' (set) Token: 0x060050D1 RID: 20689 RVA: 0x00219055 File Offset: 0x00217255
		Public Property Rotation As Integer
			Get
				Return Me.Ooo_O__.0..Rotation
			End Get
			Set(value As Integer)
				Me.Ooo_O__.0..Rotation = value
			End Set
		End Property

		' Token: 0x17001255 RID: 4693
		' (get) Token: 0x060050D2 RID: 20690 RVA: 0x00219063 File Offset: 0x00217263
		' (set) Token: 0x060050D3 RID: 20691 RVA: 0x00219070 File Offset: 0x00217270
		Public Property WordWrap As Boolean
			Get
				Return Me.Ooo_O__.0..WordWrap
			End Get
			Set(value As Boolean)
				Me.Ooo_O__.0..WordWrap = True
			End Set
		End Property

		' Token: 0x040021A7 RID: 8615
		Friend <<EMPTY_NAME>> As XLStyle
	End Class
End Namespace
