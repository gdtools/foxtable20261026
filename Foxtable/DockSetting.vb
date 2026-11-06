Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000324 RID: 804
	Friend Class DockSetting
		' Token: 0x06002CEC RID: 11500 RVA: 0x0013135B File Offset: 0x0012F55B
		Public Sub New(A_0 As DataTable)
			Me.OO_.0o_0. = A_0
		End Sub

		' Token: 0x17000B05 RID: 2821
		' (get) Token: 0x06002CED RID: 11501 RVA: 0x0013136A File Offset: 0x0012F56A
		' (set) Token: 0x06002CEE RID: 11502 RVA: 0x00131377 File Offset: 0x0012F577
		Public Property RightDockOrder As String
			Get
				Return Me.OO_.0o_0..frd_RightDockOrder
			End Get
			Set(value As String)
				Me.OO_.0o_0..frd_RightDockOrder = value
			End Set
		End Property

		' Token: 0x17000B06 RID: 2822
		' (get) Token: 0x06002CEF RID: 11503 RVA: 0x00131385 File Offset: 0x0012F585
		' (set) Token: 0x06002CF0 RID: 11504 RVA: 0x00131392 File Offset: 0x0012F592
		Public Property BottomDockOrder As String
			Get
				Return Me.OO_.0o_0..frd_BottomDockOrder
			End Get
			Set(value As String)
				Me.OO_.0o_0..frd_BottomDockOrder = value
			End Set
		End Property

		' Token: 0x17000B07 RID: 2823
		' (get) Token: 0x06002CF1 RID: 11505 RVA: 0x001313A0 File Offset: 0x0012F5A0
		' (set) Token: 0x06002CF2 RID: 11506 RVA: 0x001313AD File Offset: 0x0012F5AD
		<DefaultValue("")>
		Public Property LeftDockOrder As String
			Get
				Return Me.OO_.0o_0..frd_LeftDockOrder
			End Get
			Set(value As String)
				Me.OO_.0o_0..frd_LeftDockOrder = value
			End Set
		End Property

		' Token: 0x17000B08 RID: 2824
		' (get) Token: 0x06002CF3 RID: 11507 RVA: 0x001313BB File Offset: 0x0012F5BB
		' (set) Token: 0x06002CF4 RID: 11508 RVA: 0x001313C8 File Offset: 0x0012F5C8
		Public Property TopDockOrder As String
			Get
				Return Me.OO_.0o_0..frd_TopDockOrder
			End Get
			Set(value As String)
				Me.OO_.0o_0..frd_TopDockOrder = value
			End Set
		End Property

		' Token: 0x17000B09 RID: 2825
		' (get) Token: 0x06002CF5 RID: 11509 RVA: 0x001313D6 File Offset: 0x0012F5D6
		' (set) Token: 0x06002CF6 RID: 11510 RVA: 0x001313E3 File Offset: 0x0012F5E3
		<DefaultValue(0)>
		Public Property RightDockSize As Integer
			Get
				Return Me.OO_.0o_0..frd_RightDockSize
			End Get
			Set(value As Integer)
				Me.OO_.0o_0..frd_RightDockSize = value
			End Set
		End Property

		' Token: 0x17000B0A RID: 2826
		' (get) Token: 0x06002CF7 RID: 11511 RVA: 0x001313F1 File Offset: 0x0012F5F1
		' (set) Token: 0x06002CF8 RID: 11512 RVA: 0x001313FE File Offset: 0x0012F5FE
		<DefaultValue(0)>
		Public Property BottomDockSize As Integer
			Get
				Return Me.OO_.0o_0..frd_BottomDockSize
			End Get
			Set(value As Integer)
				Me.OO_.0o_0..frd_BottomDockSize = value
			End Set
		End Property

		' Token: 0x17000B0B RID: 2827
		' (get) Token: 0x06002CF9 RID: 11513 RVA: 0x0013140C File Offset: 0x0012F60C
		' (set) Token: 0x06002CFA RID: 11514 RVA: 0x00131419 File Offset: 0x0012F619
		<DefaultValue(0)>
		Public Property TopDockSize As Integer
			Get
				Return Me.OO_.0o_0..frd_TopDockSize
			End Get
			Set(value As Integer)
				Me.OO_.0o_0..frd_TopDockSize = value
			End Set
		End Property

		' Token: 0x17000B0C RID: 2828
		' (get) Token: 0x06002CFB RID: 11515 RVA: 0x00131427 File Offset: 0x0012F627
		' (set) Token: 0x06002CFC RID: 11516 RVA: 0x00131434 File Offset: 0x0012F634
		<DefaultValue(200)>
		Public Property LeftDockSize As Integer
			Get
				Return Me.OO_.0o_0..frd_LeftDockSize
			End Get
			Set(value As Integer)
				Me.OO_.0o_0..frd_LeftDockSize = value
			End Set
		End Property

		' Token: 0x040011EE RID: 4590
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
