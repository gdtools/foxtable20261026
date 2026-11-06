Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input

Namespace Foxtable.WinForm
	' Token: 0x02000503 RID: 1283
	<ComVisible(True)>
	Public Class Button
		Inherits Control

		' Token: 0x06005386 RID: 21382 RVA: 0x0021D85E File Offset: 0x0021BA5E
		Public Sub New(A_0 As C1Button)
			MyBase.New(A_0, ControlTypeEnum.Button)
			Me.oo._00. = A_0
		End Sub

		' Token: 0x1700139B RID: 5019
		' (get) Token: 0x06005387 RID: 21383 RVA: 0x0021D86F File Offset: 0x0021BA6F
		' (set) Token: 0x06005388 RID: 21384 RVA: 0x0021D87C File Offset: 0x0021BA7C
		Public Property Text As String
			Get
				Return Me.oo._00..Text
			End Get
			Set(value As String)
				Me.oo._00..Text = value
			End Set
		End Property

		' Token: 0x1700139C RID: 5020
		' (get) Token: 0x06005389 RID: 21385 RVA: 0x0021D88A File Offset: 0x0021BA8A
		' (set) Token: 0x0600538A RID: 21386 RVA: 0x0021D897 File Offset: 0x0021BA97
		<oO0oooo("1855")>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.oo._00..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.oo._00..TextAlign = value
			End Set
		End Property

		' Token: 0x1700139D RID: 5021
		' (get) Token: 0x0600538B RID: 21387 RVA: 0x0021D8A5 File Offset: 0x0021BAA5
		' (set) Token: 0x0600538C RID: 21388 RVA: 0x0021D8A8 File Offset: 0x0021BAA8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ImageFile As String
			Get
				Return Nothing
			End Get
			Set(value As String)
				Me.oo._00..Image = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x1700139E RID: 5022
		' (get) Token: 0x0600538D RID: 21389 RVA: 0x0021D8BB File Offset: 0x0021BABB
		' (set) Token: 0x0600538E RID: 21390 RVA: 0x0021D8C8 File Offset: 0x0021BAC8
		<oO0oooo("1856")>
		Public Property ImageAlign As ContentAlignment
			Get
				Return Me.oo._00..ImageAlign
			End Get
			Set(value As ContentAlignment)
				Me.oo._00..ImageAlign = value
			End Set
		End Property

		' Token: 0x1700139F RID: 5023
		' (get) Token: 0x0600538F RID: 21391 RVA: 0x0021D8D6 File Offset: 0x0021BAD6
		' (set) Token: 0x06005390 RID: 21392 RVA: 0x0021D8E3 File Offset: 0x0021BAE3
		<oO0oooo("1857")>
		Public Property TextImageRelation As TextImageRelation
			Get
				Return Me.oo._00..TextImageRelation
			End Get
			Set(value As TextImageRelation)
				Me.oo._00..TextImageRelation = value
			End Set
		End Property

		' Token: 0x170013A0 RID: 5024
		' (get) Token: 0x06005391 RID: 21393 RVA: 0x0021D8F1 File Offset: 0x0021BAF1
		' (set) Token: 0x06005392 RID: 21394 RVA: 0x0021D8FE File Offset: 0x0021BAFE
		<oO0oooo("0772")>
		Public Property Image As Image
			Get
				Return Me.oo._00..Image
			End Get
			Set(value As Image)
				Me.oo._00..Image = value
			End Set
		End Property

		' Token: 0x170013A1 RID: 5025
		' (get) Token: 0x06005393 RID: 21395 RVA: 0x0021D90C File Offset: 0x0021BB0C
		' (set) Token: 0x06005394 RID: 21396 RVA: 0x0021D91A File Offset: 0x0021BB1A
		<oO0oooo("1858")>
		Public Property FlatStyle As FlatStyle
			Get
				Dim result As FlatStyle
				Return result
			End Get
			Set(value As FlatStyle)
			End Set
		End Property

		' Token: 0x170013A2 RID: 5026
		' (get) Token: 0x06005395 RID: 21397 RVA: 0x0021D91C File Offset: 0x0021BB1C
		' (set) Token: 0x06005396 RID: 21398 RVA: 0x0021D92A File Offset: 0x0021BB2A
		<oO0oooo("3093")>
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x170013A3 RID: 5027
		' (get) Token: 0x06005397 RID: 21399 RVA: 0x0021D92C File Offset: 0x0021BB2C
		' (set) Token: 0x06005398 RID: 21400 RVA: 0x0021D93E File Offset: 0x0021BB3E
		Public Property BorderSize As Integer
			Get
				Return Me.oo._00..FlatAppearance.BorderSize
			End Get
			Set(value As Integer)
				Me.oo._00..FlatAppearance.BorderSize = value
			End Set
		End Property

		' Token: 0x170013A4 RID: 5028
		' (get) Token: 0x06005399 RID: 21401 RVA: 0x0021D951 File Offset: 0x0021BB51
		' (set) Token: 0x0600539A RID: 21402 RVA: 0x0021D963 File Offset: 0x0021BB63
		Public Property BorderColor As Color
			Get
				Return Me.oo._00..FlatAppearance.BorderColor
			End Get
			Set(value As Color)
				Me.oo._00..FlatAppearance.BorderColor = value
			End Set
		End Property

		' Token: 0x170013A5 RID: 5029
		' (get) Token: 0x0600539B RID: 21403 RVA: 0x0021D976 File Offset: 0x0021BB76
		' (set) Token: 0x0600539C RID: 21404 RVA: 0x0021D988 File Offset: 0x0021BB88
		Public Property MouseDownBackColor As Color
			Get
				Return Me.oo._00..FlatAppearance.MouseDownBackColor
			End Get
			Set(value As Color)
				Me.oo._00..FlatAppearance.MouseDownBackColor = value
			End Set
		End Property

		' Token: 0x170013A6 RID: 5030
		' (get) Token: 0x0600539D RID: 21405 RVA: 0x0021D99B File Offset: 0x0021BB9B
		' (set) Token: 0x0600539E RID: 21406 RVA: 0x0021D9AD File Offset: 0x0021BBAD
		<oO0oooo("2309")>
		Public Property MouseOverBackColor As Color
			Get
				Return Me.oo._00..FlatAppearance.MouseOverBackColor
			End Get
			Set(value As Color)
				Me.oo._00..FlatAppearance.MouseOverBackColor = value
			End Set
		End Property

		' Token: 0x0600539F RID: 21407 RVA: 0x0021D9C0 File Offset: 0x0021BBC0
		<oO0oooo("2309")>
		Public Sub PerformClick()
			Me.o.__O0O..o0_0OO0._O.(Me.oo._00., New EventArgs())
		End Sub

		' Token: 0x170013A7 RID: 5031
		' (get) Token: 0x060053A0 RID: 21408 RVA: 0x0021D9D8 File Offset: 0x0021BBD8
		' (set) Token: 0x060053A1 RID: 21409 RVA: 0x0021D9E5 File Offset: 0x0021BBE5
		Public Overrides Property ForeColor As Color
			Get
				Return Me.oo._00..ForeColor
			End Get
			Set(value As Color)
				Me.oo._00..ForeColor = value
			End Set
		End Property

		' Token: 0x170013A8 RID: 5032
		' (get) Token: 0x060053A2 RID: 21410 RVA: 0x0021D9F3 File Offset: 0x0021BBF3
		' (set) Token: 0x060053A3 RID: 21411 RVA: 0x0021DA00 File Offset: 0x0021BC00
		Public Overrides Property BackColor As Color
			Get
				Return Me.oo._00..BackColor
			End Get
			Set(value As Color)
				Me.oo._00..BackColor = value
			End Set
		End Property

		' Token: 0x040021C9 RID: 8649
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
