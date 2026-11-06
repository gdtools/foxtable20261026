Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001BC RID: 444
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class IMFontProperty
		' Token: 0x060014BF RID: 5311 RVA: 0x0008180A File Offset: 0x0007FA0A
		Public Sub New(A_0 As CellStyle, A_1 As CellStyle)
			Me.O00.O0. = SystemColors.WindowText
			Me.OO0oo__._. = SystemColors.WindowText
			Me.o0O0OOo._ooO_O. = A_0
			Me.O_O0_o._O0o0O. = A_1
		End Sub

		' Token: 0x17000472 RID: 1138
		' (get) Token: 0x060014C0 RID: 5312 RVA: 0x00081836 File Offset: 0x0007FA36
		' (set) Token: 0x060014C1 RID: 5313 RVA: 0x00081848 File Offset: 0x0007FA48
		Public Property MyFontName As String
			Get
				Return Me.o0O0OOo._ooO_O..Font.Name
			End Get
			Set(value As String)
				Me.o0O0OOo._ooO_O. = value
			End Set
		End Property

		' Token: 0x17000473 RID: 1139
		' (get) Token: 0x060014C2 RID: 5314 RVA: 0x00081851 File Offset: 0x0007FA51
		' (set) Token: 0x060014C3 RID: 5315 RVA: 0x00081863 File Offset: 0x0007FA63
		Public Property MyFontSize As Single
			Get
				Return Me.o0O0OOo._ooO_O..Font.Size
			End Get
			Set(value As Single)
				Me.o0O0OOo._ooO_O. = value
			End Set
		End Property

		' Token: 0x17000474 RID: 1140
		' (get) Token: 0x060014C4 RID: 5316 RVA: 0x0008186C File Offset: 0x0007FA6C
		' (set) Token: 0x060014C5 RID: 5317 RVA: 0x0008187E File Offset: 0x0007FA7E
		Public Property MyFontStyle As Integer
			Get
				Return CInt(Me.o0O0OOo._ooO_O..Font.Style)
			End Get
			Set(value As Integer)
				Me.o0O0OOo._ooO_O. = value
			End Set
		End Property

		' Token: 0x17000475 RID: 1141
		' (get) Token: 0x060014C6 RID: 5318 RVA: 0x00081887 File Offset: 0x0007FA87
		' (set) Token: 0x060014C7 RID: 5319 RVA: 0x00081894 File Offset: 0x0007FA94
		Public Property MyFontColor As Color
			Get
				Return Me.o0O0OOo._ooO_O..ForeColor
			End Get
			Set(value As Color)
				Me.O00.O0. = value
			End Set
		End Property

		' Token: 0x17000476 RID: 1142
		' (get) Token: 0x060014C8 RID: 5320 RVA: 0x0008189D File Offset: 0x0007FA9D
		' (set) Token: 0x060014C9 RID: 5321 RVA: 0x000818AF File Offset: 0x0007FAAF
		Public Property budyFontName As String
			Get
				Return Me.O_O0_o._O0o0O..Font.Name
			End Get
			Set(value As String)
				Me.OO0oo__._. = value
			End Set
		End Property

		' Token: 0x17000477 RID: 1143
		' (get) Token: 0x060014CA RID: 5322 RVA: 0x000818B8 File Offset: 0x0007FAB8
		' (set) Token: 0x060014CB RID: 5323 RVA: 0x000818CA File Offset: 0x0007FACA
		Public Property budyFontSize As Single
			Get
				Return Me.O_O0_o._O0o0O..Font.Size
			End Get
			Set(value As Single)
				Me.OO0oo__._. = value
			End Set
		End Property

		' Token: 0x17000478 RID: 1144
		' (get) Token: 0x060014CC RID: 5324 RVA: 0x000818D3 File Offset: 0x0007FAD3
		' (set) Token: 0x060014CD RID: 5325 RVA: 0x000818E5 File Offset: 0x0007FAE5
		Public Property budyFontStyle As Integer
			Get
				Return CInt(Me.O_O0_o._O0o0O..Font.Style)
			End Get
			Set(value As Integer)
				Me.OO0oo__._. = value
			End Set
		End Property

		' Token: 0x17000479 RID: 1145
		' (get) Token: 0x060014CE RID: 5326 RVA: 0x000818EE File Offset: 0x0007FAEE
		' (set) Token: 0x060014CF RID: 5327 RVA: 0x000818FB File Offset: 0x0007FAFB
		Public Property budyFontColor As Color
			Get
				Return Me.O_O0_o._O0o0O..ForeColor
			End Get
			Set(value As Color)
				Me.OO0oo__._. = value
			End Set
		End Property

		' Token: 0x060014D0 RID: 5328 RVA: 0x00081904 File Offset: 0x0007FB04
		Friend Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.o0O0OOo._ooO_O., "", True) > 0 AndAlso Me.o0O0OOo._ooO_O. > 0F Then
				Dim font As Font = New Font(Me.o0O0OOo._ooO_O., Me.o0O0OOo._ooO_O., CType(Me.o0O0OOo._ooO_O., FontStyle))
				Me.o0O0OOo._ooO_O..Font = font
			End If
			Me.o0O0OOo._ooO_O..ForeColor = Me.O00.O0.
			If Operators.CompareString(Me.OO0oo__._., "", True) > 0 AndAlso Me.OO0oo__._. > 0F Then
				Dim font2 As Font = New Font(Me.OO0oo__._., Me.OO0oo__._., CType(Me.OO0oo__._., FontStyle))
				Me.O_O0_o._O0o0O..Font = font2
			End If
			Me.O_O0_o._O0o0O..ForeColor = Me.OO0oo__._.
		End Sub

		' Token: 0x0400082B RID: 2091
		Private <<EMPTY_NAME>> As CellStyle

		' Token: 0x0400082C RID: 2092
		Private <<EMPTY_NAME>> As CellStyle

		' Token: 0x0400082D RID: 2093
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400082E RID: 2094
		Private <<EMPTY_NAME>> As Single

		' Token: 0x0400082F RID: 2095
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000830 RID: 2096
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04000831 RID: 2097
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000832 RID: 2098
		Private <<EMPTY_NAME>> As Single

		' Token: 0x04000833 RID: 2099
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000834 RID: 2100
		Private <<EMPTY_NAME>> As Color
	End Class
End Namespace
