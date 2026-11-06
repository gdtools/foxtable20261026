Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000037 RID: 55
	Public Class StatusBar
		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x060001D0 RID: 464 RVA: 0x00004F1A File Offset: 0x0000311A
		' (set) Token: 0x060001D1 RID: 465 RVA: 0x00004F21 File Offset: 0x00003121
		Public Shared Property DefaultMessage As String
			Get
				Return StatusBar.OO0.0OOo__.
			End Get
			Set(value As String)
				If Operators.CompareString(StatusBar.Message1, StatusBar.OO0.0OOo__., True) = 0 Then
					StatusBar.Message1 = value
				End If
				StatusBar.OO0.0OOo__. = value
			End Set
		End Property

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x060001D2 RID: 466 RVA: 0x00004F41 File Offset: 0x00003141
		' (set) Token: 0x060001D3 RID: 467 RVA: 0x00004F54 File Offset: 0x00003154
		Public Shared Property Message1 As String
			Get
				Return Main.OO_O.o..OO_O_0Oo.___o.().Text
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 Then
					Main.OO_O.o..OO_O_0Oo.___o.().Text = value
				Else
					Main.OO_O.o..OO_O_0Oo.___o.().Text = StatusBar.DefaultMessage
				End If
				Main.OO_O.o..OO_O_0Oo.___o.().Enabled = Main.OO_O.o..OO_O_0Oo.___o.().Enabled
			End Set
		End Property

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x060001D4 RID: 468 RVA: 0x00004FB4 File Offset: 0x000031B4
		' (set) Token: 0x060001D5 RID: 469 RVA: 0x00004FC5 File Offset: 0x000031C5
		Public Shared Property Message2 As String
			Get
				Return Main.OO_O.o..o__0_._oOooO_o.().Text
			End Get
			Set(value As String)
				Main.OO_O.o..o__0_._oOooO_o.().Text = value
				Main.OO_O.o..o__0_._oOooO_o.().Enabled = Main.OO_O.o..o__0_._oOooO_o.().Enabled
			End Set
		End Property

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x060001D6 RID: 470 RVA: 0x00004FF5 File Offset: 0x000031F5
		' (set) Token: 0x060001D7 RID: 471 RVA: 0x00005008 File Offset: 0x00003208
		Public Shared Property Message3 As String
			Get
				Return Main.OO_O.o..oO0_oO.0o.().Text
			End Get
			Set(value As String)
				Dim c1StatusBar As C1StatusBar = Main.OO_O.o..O.OOO0_OOo.()
				If Operators.CompareString(value, "", True) > 0 Then
					Dim graphics As Graphics = c1StatusBar.CreateGraphics()
					Dim a As Double = CDbl(graphics.MeasureString(value, c1StatusBar.Font).Width)
					c1StatusBar.RightPaneWidth = CInt(Math.Round((Math.Ceiling(a) + 10.0) * CDbl(graphics.DpiX) / 96.0))
				Else
					c1StatusBar.RightPaneWidth = Math.Min(c1StatusBar.RightPaneWidth, 350)
				End If
				Main.OO_O.o..oO0_oO.0o.().Text = value
			End Set
		End Property

		' Token: 0x060001D8 RID: 472 RVA: 0x000050A5 File Offset: 0x000032A5
		Public Shared Sub Refresh()
			Application.DoEvents()
		End Sub

		' Token: 0x060001D9 RID: 473 RVA: 0x000050AC File Offset: 0x000032AC
		Public Shared Sub Reset()
			StatusBar.Message1 = ""
			StatusBar.Message2 = ""
			StatusBar.Message3 = ""
			StatusBar.ProgressBar.Visible = False
			StatusBar.ProgressBar.Value = 0
			StatusBar.ProgressBar.Minimum = 0
			StatusBar.ProgressBar.Maximum = 100
		End Sub

		' Token: 0x0400005A RID: 90
		Private Shared <<EMPTY_NAME>> As String = "就绪"

		' Token: 0x02000038 RID: 56
		Public Class ProgressBar
			' Token: 0x170000CD RID: 205
			' (get) Token: 0x060001DB RID: 475 RVA: 0x000050ED File Offset: 0x000032ED
			' (set) Token: 0x060001DC RID: 476 RVA: 0x000050FE File Offset: 0x000032FE
			Public Shared Property Visible As Boolean
				Get
					Return Main.OO_O.o..OO_O_0Oo.___o.().Visible
				End Get
				Set(value As Boolean)
					Main.OO_O.o..OO_O_0Oo.___o.().Visible = value
				End Set
			End Property

			' Token: 0x170000CE RID: 206
			' (get) Token: 0x060001DD RID: 477 RVA: 0x00005110 File Offset: 0x00003310
			' (set) Token: 0x060001DE RID: 478 RVA: 0x00005121 File Offset: 0x00003321
			Public Shared Property Value As Integer
				Get
					Return Main.OO_O.o..OO_O_0Oo.___o.().Value
				End Get
				Set(value As Integer)
					Main.OO_O.o..OO_O_0Oo.___o.().Value = Math.Min(Math.Max(value, Main.OO_O.o..OO_O_0Oo.___o.().Minimum), Main.OO_O.o..OO_O_0Oo.___o.().Maximum)
				End Set
			End Property

			' Token: 0x170000CF RID: 207
			' (get) Token: 0x060001DF RID: 479 RVA: 0x0000515B File Offset: 0x0000335B
			' (set) Token: 0x060001E0 RID: 480 RVA: 0x0000516C File Offset: 0x0000336C
			Public Shared Property Minimum As Integer
				Get
					Return Main.OO_O.o..OO_O_0Oo.___o.().Minimum
				End Get
				Set(value As Integer)
					Main.OO_O.o..OO_O_0Oo.___o.().Minimum = value
				End Set
			End Property

			' Token: 0x170000D0 RID: 208
			' (get) Token: 0x060001E1 RID: 481 RVA: 0x0000517E File Offset: 0x0000337E
			' (set) Token: 0x060001E2 RID: 482 RVA: 0x0000518F File Offset: 0x0000338F
			Public Shared Property Maximum As Integer
				Get
					Return Main.OO_O.o..OO_O_0Oo.___o.().Maximum
				End Get
				Set(value As Integer)
					Main.OO_O.o..OO_O_0Oo.___o.().Maximum = value
				End Set
			End Property
		End Class
	End Class
End Namespace
