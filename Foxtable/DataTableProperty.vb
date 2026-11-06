Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000323 RID: 803
	<OoO0___o("Table")>
	Friend Class DataTableProperty
		' Token: 0x06002C36 RID: 11318 RVA: 0x00130BF8 File Offset: 0x0012EDF8
		Public Sub New(A_0 As DataTable)
			Me.o__.0ooOOoo0o. = A_0
		End Sub

		' Token: 0x06002C37 RID: 11319 RVA: 0x00130C07 File Offset: 0x0012EE07
		Public Sub New()
		End Sub

		' Token: 0x06002C38 RID: 11320 RVA: 0x00130C10 File Offset: 0x0012EE10
		Shared Sub New()
			Dim dataRow As DataRow = O_O0OO.O0_00o.o0__o..Rows.Find("DataFiles")
			If dataRow Is Nothing Then
				DataTableProperty.o.O0_oo0O. = False
				Return
			End If
			If Operators.CompareString(dataRow("Config").ToString(), O00.CRCCheckFile(Application.ExecutablePath), True) = 0 Then
				DataTableProperty.o.O0_oo0O. = True
				Return
			End If
			DataTableProperty.o.O0_oo0O. = False
		End Sub

		' Token: 0x17000AAB RID: 2731
		' (get) Token: 0x06002C39 RID: 11321 RVA: 0x00130C71 File Offset: 0x0012EE71
		' (set) Token: 0x06002C3A RID: 11322 RVA: 0x00130C7E File Offset: 0x0012EE7E
		<Browsable(False)>
		Public Property Caption As String
			Get
				Return Me.o__.0ooOOoo0o..Caption
			End Get
			Set(value As String)
				Me.o__.0ooOOoo0o..Caption = value
			End Set
		End Property

		' Token: 0x17000AAC RID: 2732
		' (get) Token: 0x06002C3B RID: 11323 RVA: 0x00130C8C File Offset: 0x0012EE8C
		' (set) Token: 0x06002C3C RID: 11324 RVA: 0x00130C99 File Offset: 0x0012EE99
		<Browsable(False)>
		Public Property AsmCrcString As String
			Get
				Return Me.o__.0ooOOoo0o..frd_AsmCrcString
			End Get
			Set(value As String)
				Me.o__.0ooOOoo0o..frd_AsmCrcString = value
			End Set
		End Property

		' Token: 0x17000AAD RID: 2733
		' (get) Token: 0x06002C3D RID: 11325 RVA: 0x00130CA7 File Offset: 0x0012EEA7
		' (set) Token: 0x06002C3E RID: 11326 RVA: 0x00130CAF File Offset: 0x0012EEAF
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0605")>
		<Description("进入单元格，准备编辑的时候执行。")>
		<Category("A.编辑")>
		<O_Oo00Oo000O0(1.0)>
		<O0O0oOO00_0OO(True)>
		Public Property PrepareEdit As EventString
			Get
				Return Me.o_o00.oOo000.
			End Get
			Set(value As EventString)
				Me.o_o00.oOo000. = value
			End Set
		End Property

		' Token: 0x17000AAE RID: 2734
		' (get) Token: 0x06002C3F RID: 11327 RVA: 0x00130CB8 File Offset: 0x0012EEB8
		' (set) Token: 0x06002C40 RID: 11328 RVA: 0x00130CC0 File Offset: 0x0012EEC0
		<oO0oooo("0615")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("A.编辑")>
		<O0O0oOO00_0OO(True)>
		<Description("真正有了编辑单元格动作的时候执行，例如用户通过键盘输入内容，或者用鼠标单击了下拉按钮。")>
		<O_Oo00Oo000O0(2.0)>
		Public Property StartEdit As EventString
			Get
				Return Me.O.OOOOO.
			End Get
			Set(value As EventString)
				Me.O.OOOOO. = value
			End Set
		End Property

		' Token: 0x17000AAF RID: 2735
		' (get) Token: 0x06002C41 RID: 11329 RVA: 0x00130CC9 File Offset: 0x0012EEC9
		' (set) Token: 0x06002C42 RID: 11330 RVA: 0x00130CD1 File Offset: 0x0012EED1
		<Browsable(False)>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("A.编辑")>
		<Description("单元格真正进入编辑状态之前执行，此时编辑框(Editor)已经初始化，可以设置其属性。")>
		<O_Oo00Oo000O0(2.1)>
		Public Property SetupEditor As EventString
			Get
				Return Me.O.O_0oo.
			End Get
			Set(value As EventString)
				Me.O.O_0oo. = value
			End Set
		End Property

		' Token: 0x17000AB0 RID: 2736
		' (get) Token: 0x06002C43 RID: 11331 RVA: 0x00130CDA File Offset: 0x0012EEDA
		' (set) Token: 0x06002C44 RID: 11332 RVA: 0x00130CE2 File Offset: 0x0012EEE2
		<Description("结束编辑单元格前执行，通常用于验证输入的内容。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("A.编辑")>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0617")>
		<O_Oo00Oo000O0(3.0)>
		Public Property ValidateEdit As EventString
			Get
				Return Me.O_0_.O.
			End Get
			Set(value As EventString)
				Me.O_0_.O. = value
			End Set
		End Property

		' Token: 0x17000AB1 RID: 2737
		' (get) Token: 0x06002C45 RID: 11333 RVA: 0x00130CEB File Offset: 0x0012EEEB
		' (set) Token: 0x06002C46 RID: 11334 RVA: 0x00130CF3 File Offset: 0x0012EEF3
		<oO0oooo("0616")>
		<Category("A.编辑")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("结束编辑单元格后执行，通常用于执行一些特定的操作和计算。")>
		<O_Oo00Oo000O0(4.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterEdit As EventString
			Get
				Return Me.O.OOO_oo.
			End Get
			Set(value As EventString)
				Me.O.OOO_oo. = value
			End Set
		End Property

		' Token: 0x17000AB2 RID: 2738
		' (get) Token: 0x06002C47 RID: 11335 RVA: 0x00130CFC File Offset: 0x0012EEFC
		' (set) Token: 0x06002C48 RID: 11336 RVA: 0x00130D04 File Offset: 0x0012EF04
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0619")>
		<Description("编辑框中内容发生变化时执行。")>
		<Category("A.编辑")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(4.1)>
		Public Property ChangeEdit As EventString
			Get
				Return Me.o_o.O00000_OO.
			End Get
			Set(value As EventString)
				Me.o_o.O00000_OO. = value
			End Set
		End Property

		' Token: 0x17000AB3 RID: 2739
		' (get) Token: 0x06002C49 RID: 11337 RVA: 0x00130D0D File Offset: 0x0012EF0D
		' (set) Token: 0x06002C4A RID: 11338 RVA: 0x00130D15 File Offset: 0x0012EF15
		<Description("在编辑框(Editor)输入一字符键时执行。")>
		<Category("A.编辑")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0620")>
		<O_Oo00Oo000O0(4.2)>
		Public Property KeyPressEdit As EventString
			Get
				Return Me.o00_0.0OoO0.
			End Get
			Set(value As EventString)
				Me.o00_0.0OoO0. = value
			End Set
		End Property

		' Token: 0x17000AB4 RID: 2740
		' (get) Token: 0x06002C4B RID: 11339 RVA: 0x00130D1E File Offset: 0x0012EF1E
		' (set) Token: 0x06002C4C RID: 11340 RVA: 0x00130D26 File Offset: 0x0012EF26
		<oO0oooo("0622")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("在编辑状态时，按下一按键时执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("A.编辑")>
		<O_Oo00Oo000O0(4.3)>
		Public Property KeyDownEdit As EventString
			Get
				Return Me.O_.0oo.
			End Get
			Set(value As EventString)
				Me.O_.0oo. = value
			End Set
		End Property

		' Token: 0x17000AB5 RID: 2741
		' (get) Token: 0x06002C4D RID: 11341 RVA: 0x00130D2F File Offset: 0x0012EF2F
		' (set) Token: 0x06002C4E RID: 11342 RVA: 0x00130D37 File Offset: 0x0012EF37
		<oO0oooo("0623")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("在编辑状态时，松开一按键时执行。")>
		<Category("A.编辑")>
		<O_Oo00Oo000O0(4.4)>
		Public Property KeyUpEdit As EventString
			Get
				Return Me.O0O0._.
			End Get
			Set(value As EventString)
				Me.O0O0._. = value
			End Set
		End Property

		' Token: 0x17000AB6 RID: 2742
		' (get) Token: 0x06002C4F RID: 11343 RVA: 0x00130D40 File Offset: 0x0012EF40
		' (set) Token: 0x06002C50 RID: 11344 RVA: 0x00130D48 File Offset: 0x0012EF48
		<oO0oooo("0642")>
		<Category("A.编辑")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("单击单元格按钮后执行。")>
		<O_Oo00Oo000O0(4.5)>
		Public Property CellButtonClick As EventString
			Get
				Return Me.O_OoO0.0o0O.
			End Get
			Set(value As EventString)
				Me.O_OoO0.0o0O. = value
			End Set
		End Property

		' Token: 0x17000AB7 RID: 2743
		' (get) Token: 0x06002C51 RID: 11345 RVA: 0x00130D51 File Offset: 0x0012EF51
		' (set) Token: 0x06002C52 RID: 11346 RVA: 0x00130D59 File Offset: 0x0012EF59
		<oO0oooo("0624")>
		<Category("B.数据")>
		<DisplayName("DataColChanging")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("某一列的内容变化前执行，通常用于验证该列内容。")>
		<O_Oo00Oo000O0(5.0)>
		Public Property DataColChanging As EventString
			Get
				Return Me.Oo_.0oO_.
			End Get
			Set(value As EventString)
				Me.Oo_.0oO_. = value
			End Set
		End Property

		' Token: 0x17000AB8 RID: 2744
		' (get) Token: 0x06002C53 RID: 11347 RVA: 0x00130D62 File Offset: 0x0012EF62
		' (set) Token: 0x06002C54 RID: 11348 RVA: 0x00130D6A File Offset: 0x0012EF6A
		<DisplayName("DataColChanged")>
		<Category("B.数据")>
		<oO0oooo("0625")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("某一列的内容变化后执行，通常用于执行一些特定的操作和计算。")>
		<O_Oo00Oo000O0(6.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataColChanged As EventString
			Get
				Return Me.O.00_o__o.
			End Get
			Set(value As EventString)
				Me.O.00_o__o. = value
			End Set
		End Property

		' Token: 0x17000AB9 RID: 2745
		' (get) Token: 0x06002C55 RID: 11349 RVA: 0x00130D73 File Offset: 0x0012EF73
		' (set) Token: 0x06002C56 RID: 11350 RVA: 0x00130D7B File Offset: 0x0012EF7B
		<oO0oooo("0628")>
		<Category("B.数据")>
		<Description("保存某一行之前执行，通常用于对数据进行保存前的验证！。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(6.1)>
		Public Property BeforeSaveDataRow As EventString
			Get
				Return Me.OoO.0.
			End Get
			Set(value As EventString)
				Me.OoO.0. = value
			End Set
		End Property

		' Token: 0x17000ABA RID: 2746
		' (get) Token: 0x06002C57 RID: 11351 RVA: 0x00130D84 File Offset: 0x0012EF84
		' (set) Token: 0x06002C58 RID: 11352 RVA: 0x00130D8C File Offset: 0x0012EF8C
		<oO0oooo("3755")>
		<Description("保存某一行之后执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("B.数据")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(6.11)>
		Public Property AfterSaveDataRow As EventString
			Get
				Return Me.O._OooO0o0_o.
			End Get
			Set(value As EventString)
				Me.O._OooO0o0_o. = value
			End Set
		End Property

		' Token: 0x17000ABB RID: 2747
		' (get) Token: 0x06002C59 RID: 11353 RVA: 0x00130D95 File Offset: 0x0012EF95
		' (set) Token: 0x06002C5A RID: 11354 RVA: 0x00130D9D File Offset: 0x0012EF9D
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0629")>
		<O0O0oOO00_0OO(True)>
		<Description("增加行之前执行。")>
		<Category("C.增加行")>
		<O_Oo00Oo000O0(8.1)>
		Public Property BeforeAddDataRow As EventString
			Get
				Return Me.o.Oo_O0OO_0o0.
			End Get
			Set(value As EventString)
				Me.o.Oo_O0OO_0o0. = value
			End Set
		End Property

		' Token: 0x17000ABC RID: 2748
		' (get) Token: 0x06002C5B RID: 11355 RVA: 0x00130DA6 File Offset: 0x0012EFA6
		' (set) Token: 0x06002C5C RID: 11356 RVA: 0x00130DAE File Offset: 0x0012EFAE
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0630")>
		<O0O0oOO00_0OO(True)>
		<Description("增加一行时执行，此时DataRow还处于孤立状态，并未真正增加到DataTable中。")>
		<Category("C.增加行")>
		<O_Oo00Oo000O0(9.0)>
		Public Property DataRowAdding As EventString
			Get
				Return Me.O_oO_0OOo_o.0O.
			End Get
			Set(value As EventString)
				Me.O_oO_0OOo_o.0O. = value
			End Set
		End Property

		' Token: 0x17000ABD RID: 2749
		' (get) Token: 0x06002C5D RID: 11357 RVA: 0x00130DB7 File Offset: 0x0012EFB7
		' (set) Token: 0x06002C5E RID: 11358 RVA: 0x00130DBF File Offset: 0x0012EFBF
		<Description("增加一行后执行，此时DataRow已经真正增加到DataTable中。")>
		<oO0oooo("0631")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("C.增加行")>
		<O_Oo00Oo000O0(10.0)>
		Public Property DataRowAdded As EventString
			Get
				Return Me.o_._0.
			End Get
			Set(value As EventString)
				Me.o_._0. = value
			End Set
		End Property

		' Token: 0x17000ABE RID: 2750
		' (get) Token: 0x06002C5F RID: 11359 RVA: 0x00130DC8 File Offset: 0x0012EFC8
		' (set) Token: 0x06002C60 RID: 11360 RVA: 0x00130DD0 File Offset: 0x0012EFD0
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0632")>
		<Description("删除行之前执行。")>
		<Category("D.删除行")>
		<O_Oo00Oo000O0(10.1)>
		Public Property BeforeDeleteDataRow As EventString
			Get
				Return Me.O.0o0O__0.
			End Get
			Set(value As EventString)
				Me.O.0o0O__0. = value
			End Set
		End Property

		' Token: 0x17000ABF RID: 2751
		' (get) Token: 0x06002C61 RID: 11361 RVA: 0x00130DD9 File Offset: 0x0012EFD9
		' (set) Token: 0x06002C62 RID: 11362 RVA: 0x00130DE1 File Offset: 0x0012EFE1
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0633")>
		<O0O0oOO00_0OO(True)>
		<Description("删除某一行时执行。")>
		<Category("D.删除行")>
		<O_Oo00Oo000O0(11.0)>
		Public Property DataRowDeleting As EventString
			Get
				Return Me.oO.o0OO_0.
			End Get
			Set(value As EventString)
				Me.oO.o0OO_0. = value
			End Set
		End Property

		' Token: 0x17000AC0 RID: 2752
		' (get) Token: 0x06002C63 RID: 11363 RVA: 0x00130DEA File Offset: 0x0012EFEA
		' (set) Token: 0x06002C64 RID: 11364 RVA: 0x00130DF2 File Offset: 0x0012EFF2
		<oO0oooo("0634")>
		<Description("删除某一行之后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("D.删除行")>
		<O_Oo00Oo000O0(12.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataRowDeleted As EventString
			Get
				Return Me.o0ooo.O_Oo.
			End Get
			Set(value As EventString)
				Me.o0ooo.O_Oo. = value
			End Set
		End Property

		' Token: 0x17000AC1 RID: 2753
		' (get) Token: 0x06002C65 RID: 11365 RVA: 0x00130DFB File Offset: 0x0012EFFB
		' (set) Token: 0x06002C66 RID: 11366 RVA: 0x00130E03 File Offset: 0x0012F003
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0635")>
		<Description("行的锁定状态发生变化之前执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("E.锁定行")>
		<O_Oo00Oo000O0(13.0)>
		Public Property DataRowLockedChanging As EventString
			Get
				Return Me.oooO.o_o.
			End Get
			Set(value As EventString)
				Me.oooO.o_o. = value
			End Set
		End Property

		' Token: 0x17000AC2 RID: 2754
		' (get) Token: 0x06002C67 RID: 11367 RVA: 0x00130E0C File Offset: 0x0012F00C
		' (set) Token: 0x06002C68 RID: 11368 RVA: 0x00130E14 File Offset: 0x0012F014
		<Category("E.锁定行")>
		<oO0oooo("0636")>
		<O0O0oOO00_0OO(True)>
		<Description("行的锁定状态发生变化之后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(14.0)>
		Public Property DataRowLockedChanged As EventString
			Get
				Return Me.o_0o._.
			End Get
			Set(value As EventString)
				Me.o_0o._. = value
			End Set
		End Property

		' Token: 0x17000AC3 RID: 2755
		' (get) Token: 0x06002C69 RID: 11369 RVA: 0x00130E1D File Offset: 0x0012F01D
		' (set) Token: 0x06002C6A RID: 11370 RVA: 0x00130E25 File Offset: 0x0012F025
		<Description("选择不同记录后执行，也就是Current属性发生变化后执行。")>
		<Category("F.选择")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0641")>
		<O_Oo00Oo000O0(14.0)>
		<O0O0oOO00_0OO(True)>
		Public Property CurrentChanged As EventString
			Get
				Return Me.OOo.0_.
			End Get
			Set(value As EventString)
				Me.OOo.0_. = value
			End Set
		End Property

		' Token: 0x17000AC4 RID: 2756
		' (get) Token: 0x06002C6B RID: 11371 RVA: 0x00130E2E File Offset: 0x0012F02E
		' (set) Token: 0x06002C6C RID: 11372 RVA: 0x00130E36 File Offset: 0x0012F036
		<oO0oooo("0640")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("F.选择")>
		<Description("选择不同行后执行，也就是Position属性发生变化后执行")>
		<O_Oo00Oo000O0(15.0)>
		<O0O0oOO00_0OO(True)>
		Public Property PositionChanged As EventString
			Get
				Return Me.O0._0.
			End Get
			Set(value As EventString)
				Me.O0._0. = value
			End Set
		End Property

		' Token: 0x17000AC5 RID: 2757
		' (get) Token: 0x06002C6D RID: 11373 RVA: 0x00130E3F File Offset: 0x0012F03F
		' (set) Token: 0x06002C6E RID: 11374 RVA: 0x00130E47 File Offset: 0x0012F047
		<oO0oooo("0644")>
		<Category("F.选择")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("选择不同的单元格前执行，也就是表的RowSel、ColSel属性发生变化前执行。")>
		<O_Oo00Oo000O0(16.0)>
		Public Property BeforeSelChange As EventString
			Get
				Return Me.o0_.o_.
			End Get
			Set(value As EventString)
				Me.o0_.o_. = value
			End Set
		End Property

		' Token: 0x17000AC6 RID: 2758
		' (get) Token: 0x06002C6F RID: 11375 RVA: 0x00130E50 File Offset: 0x0012F050
		' (set) Token: 0x06002C70 RID: 11376 RVA: 0x00130E58 File Offset: 0x0012F058
		<Description("选择不同的单元格后执行，也就是表的RowSel、ColSel属性发生变化后执行。")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0645")>
		<Category("F.选择")>
		<O_Oo00Oo000O0(16.1)>
		Public Property AfterSelChange As EventString
			Get
				Return Me.oOoO._.
			End Get
			Set(value As EventString)
				Me.oOoO._. = value
			End Set
		End Property

		' Token: 0x17000AC7 RID: 2759
		' (get) Token: 0x06002C71 RID: 11377 RVA: 0x00130E61 File Offset: 0x0012F061
		' (set) Token: 0x06002C72 RID: 11378 RVA: 0x00130E69 File Offset: 0x0012F069
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0646")>
		<Description("选择不同的区域前执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化前执行。")>
		<Category("F.选择")>
		<O_Oo00Oo000O0(17.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeSelRangeChange As EventString
			Get
				Return Me.OO.0OoOOoO.
			End Get
			Set(value As EventString)
				Me.OO.0OoOOoO. = value
			End Set
		End Property

		' Token: 0x17000AC8 RID: 2760
		' (get) Token: 0x06002C73 RID: 11379 RVA: 0x00130E72 File Offset: 0x0012F072
		' (set) Token: 0x06002C74 RID: 11380 RVA: 0x00130E7A File Offset: 0x0012F07A
		<Description("选择不同的区域后执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化后执行。")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0647")>
		<Category("F.选择")>
		<O_Oo00Oo000O0(17.1)>
		Public Property AfterSelRangeChange As EventString
			Get
				Return Me.Ooo.oO_.
			End Get
			Set(value As EventString)
				Me.Ooo.oO_. = value
			End Set
		End Property

		' Token: 0x17000AC9 RID: 2761
		' (get) Token: 0x06002C75 RID: 11381 RVA: 0x00130E83 File Offset: 0x0012F083
		' (set) Token: 0x06002C76 RID: 11382 RVA: 0x00130E8B File Offset: 0x0012F08B
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("G.复选")>
		<Description("修改行复选框状态前执行。")>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("1639")>
		<O_Oo00Oo000O0(19.0)>
		Public Property BeforeCheckRow As EventString
			Get
				Return Me.Oo_0oOo.OooO.
			End Get
			Set(value As EventString)
				Me.Oo_0oOo.OooO. = value
			End Set
		End Property

		' Token: 0x17000ACA RID: 2762
		' (get) Token: 0x06002C77 RID: 11383 RVA: 0x00130E94 File Offset: 0x0012F094
		' (set) Token: 0x06002C78 RID: 11384 RVA: 0x00130E9C File Offset: 0x0012F09C
		<Description("修改行复选框状态后执行。")>
		<Category("G.复选")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1640")>
		<O_Oo00Oo000O0(19.1)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterCheckRow As EventString
			Get
				Return Me.O0oO0_oO._O_O.
			End Get
			Set(value As EventString)
				Me.O0oO0_oO._O_O. = value
			End Set
		End Property

		' Token: 0x17000ACB RID: 2763
		' (get) Token: 0x06002C79 RID: 11385 RVA: 0x00130EA5 File Offset: 0x0012F0A5
		' (set) Token: 0x06002C7A RID: 11386 RVA: 0x00130EAD File Offset: 0x0012F0AD
		<oO0oooo("1847")>
		<Category("H.调整")>
		<Description("移动行后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(18.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterMoveRow As EventString
			Get
				Return Me.O.OO0O0OOO.
			End Get
			Set(value As EventString)
				Me.O.OO0O0OOO. = value
			End Set
		End Property

		' Token: 0x17000ACC RID: 2764
		' (get) Token: 0x06002C7B RID: 11387 RVA: 0x00130EB6 File Offset: 0x0012F0B6
		' (set) Token: 0x06002C7C RID: 11388 RVA: 0x00130EBE File Offset: 0x0012F0BE
		<oO0oooo("2271")>
		<Description("移动行前执行。")>
		<Category("H.调整")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(17.9)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeMoveRow As EventString
			Get
				Return Me.O0_o.0Oo.
			End Get
			Set(value As EventString)
				Me.O0_o.0Oo. = value
			End Set
		End Property

		' Token: 0x17000ACD RID: 2765
		' (get) Token: 0x06002C7D RID: 11389 RVA: 0x00130EC7 File Offset: 0x0012F0C7
		' (set) Token: 0x06002C7E RID: 11390 RVA: 0x00130ECF File Offset: 0x0012F0CF
		<Category("H.调整")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Description("拖动列之前发生。")>
		<oO0oooo("0648")>
		<O_Oo00Oo000O0(19.0)>
		Public Property BeforeDragColumn As EventString
			Get
				Return Me.o_.0_0_oo0.
			End Get
			Set(value As EventString)
				Me.o_.0_0_oo0. = value
			End Set
		End Property

		' Token: 0x17000ACE RID: 2766
		' (get) Token: 0x06002C7F RID: 11391 RVA: 0x00130ED8 File Offset: 0x0012F0D8
		' (set) Token: 0x06002C80 RID: 11392 RVA: 0x00130EE0 File Offset: 0x0012F0E0
		<Category("H.调整")>
		<oO0oooo("0649")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Description("拖动列之后发生。")>
		<O_Oo00Oo000O0(20.0)>
		Public Property AfterDragColumn As EventString
			Get
				Return Me.O._O.
			End Get
			Set(value As EventString)
				Me.O._O. = value
			End Set
		End Property

		' Token: 0x17000ACF RID: 2767
		' (get) Token: 0x06002C81 RID: 11393 RVA: 0x00130EE9 File Offset: 0x0012F0E9
		' (set) Token: 0x06002C82 RID: 11394 RVA: 0x00130EF1 File Offset: 0x0012F0F1
		<Category("H.调整")>
		<Description("调整冻结区之前发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0650")>
		<O_Oo00Oo000O0(21.0)>
		Public Property BeforeFreezeColumn As EventString
			Get
				Return Me.O.___O_.
			End Get
			Set(value As EventString)
				Me.O.___O_. = value
			End Set
		End Property

		' Token: 0x17000AD0 RID: 2768
		' (get) Token: 0x06002C83 RID: 11395 RVA: 0x00130EFA File Offset: 0x0012F0FA
		' (set) Token: 0x06002C84 RID: 11396 RVA: 0x00130F02 File Offset: 0x0012F102
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0651")>
		<Category("H.调整")>
		<Description("调整冻结区之后发生。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(22.0)>
		Public Property AfterFreezeColumn As EventString
			Get
				Return Me.o.O0_OOoo_o0.
			End Get
			Set(value As EventString)
				Me.o.O0_OOoo_o0. = value
			End Set
		End Property

		' Token: 0x17000AD1 RID: 2769
		' (get) Token: 0x06002C85 RID: 11397 RVA: 0x00130F0B File Offset: 0x0012F10B
		' (set) Token: 0x06002C86 RID: 11398 RVA: 0x00130F13 File Offset: 0x0012F113
		<oO0oooo("0652")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("调整列宽之前发生。")>
		<Category("H.调整")>
		<O_Oo00Oo000O0(23.0)>
		Public Property BeforeResizeColumn As EventString
			Get
				Return Me.OOO.__0.
			End Get
			Set(value As EventString)
				Me.OOO.__0. = value
			End Set
		End Property

		' Token: 0x17000AD2 RID: 2770
		' (get) Token: 0x06002C87 RID: 11399 RVA: 0x00130F1C File Offset: 0x0012F11C
		' (set) Token: 0x06002C88 RID: 11400 RVA: 0x00130F24 File Offset: 0x0012F124
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0653")>
		<Description("调整列宽之后发生。")>
		<O0O0oOO00_0OO(True)>
		<Category("H.调整")>
		<O_Oo00Oo000O0(24.0)>
		Public Property AfterResizeColumn As EventString
			Get
				Return Me.Oo_oO__.o_oOo.
			End Get
			Set(value As EventString)
				Me.Oo_oO__.o_oOo. = value
			End Set
		End Property

		' Token: 0x17000AD3 RID: 2771
		' (get) Token: 0x06002C89 RID: 11401 RVA: 0x00130F2D File Offset: 0x0012F12D
		' (set) Token: 0x06002C8A RID: 11402 RVA: 0x00130F35 File Offset: 0x0012F135
		<Description("调整行高之前发生。")>
		<Category("H.调整")>
		<oO0oooo("0654")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(25.0)>
		Public Property BeforeResizeRow As EventString
			Get
				Return Me.o_O0O0_0O.oO.
			End Get
			Set(value As EventString)
				Me.o_O0O0_0O.oO. = value
			End Set
		End Property

		' Token: 0x17000AD4 RID: 2772
		' (get) Token: 0x06002C8B RID: 11403 RVA: 0x00130F3E File Offset: 0x0012F13E
		' (set) Token: 0x06002C8C RID: 11404 RVA: 0x00130F46 File Offset: 0x0012F146
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0655")>
		<Description("调整行高之后发生。")>
		<O0O0oOO00_0OO(True)>
		<Category("H.调整")>
		<O_Oo00Oo000O0(26.0)>
		Public Property AfterResizeRow As EventString
			Get
				Return Me.o_O._o0Oo_O0_.
			End Get
			Set(value As EventString)
				Me.o_O._o0Oo_O0_. = value
			End Set
		End Property

		' Token: 0x17000AD5 RID: 2773
		' (get) Token: 0x06002C8D RID: 11405 RVA: 0x00130F4F File Offset: 0x0012F14F
		' (set) Token: 0x06002C8E RID: 11406 RVA: 0x00130F57 File Offset: 0x0012F157
		<Category("I.绘制")>
		<oO0oooo("0656")>
		<Description("绘制某一单元格的时候执行，该事件执行非常频繁，对性能影响极大，代码必需简洁高效,不能有耗时的计算和操作。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(28.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DrawCell As EventString
			Get
				Return Me.Oo0.o0O_oO.
			End Get
			Set(value As EventString)
				Me.Oo0.o0O_oO. = value
			End Set
		End Property

		' Token: 0x17000AD6 RID: 2774
		' (get) Token: 0x06002C8F RID: 11407 RVA: 0x00130F60 File Offset: 0x0012F160
		' (set) Token: 0x06002C90 RID: 11408 RVA: 0x00130F68 File Offset: 0x0012F168
		<Category("I.绘制")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Description("绘制某一行之前执行，通常用于动态设置行高。")>
		<oO0oooo("1952")>
		<O_Oo00Oo000O0(28.1)>
		Public Property BeforeDrawRow As EventString
			Get
				Return Me.O_0oO_0.____.
			End Get
			Set(value As EventString)
				Me.O_0oO_0.____. = value
			End Set
		End Property

		' Token: 0x17000AD7 RID: 2775
		' (get) Token: 0x06002C91 RID: 11409 RVA: 0x00130F71 File Offset: 0x0012F171
		' (set) Token: 0x06002C92 RID: 11410 RVA: 0x00130F79 File Offset: 0x0012F179
		<Category("J.加载")>
		<Description("重新加载数据之前执行。")>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("2057")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(29.0)>
		Public Property BeforeLoad As EventString
			Get
				Return Me.O.00o.
			End Get
			Set(value As EventString)
				Me.O.00o. = value
			End Set
		End Property

		' Token: 0x17000AD8 RID: 2776
		' (get) Token: 0x06002C93 RID: 11411 RVA: 0x00130F82 File Offset: 0x0012F182
		' (set) Token: 0x06002C94 RID: 11412 RVA: 0x00130F8A File Offset: 0x0012F18A
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2058")>
		<O0O0oOO00_0OO(True)>
		<Category("J.加载")>
		<Description("重新加载数据之后执行。")>
		<O_Oo00Oo000O0(30.0)>
		Public Property AfterLoad As EventString
			Get
				Return Me.oo.O__.
			End Get
			Set(value As EventString)
				Me.oo.O__. = value
			End Set
		End Property

		' Token: 0x17000AD9 RID: 2777
		' (get) Token: 0x06002C95 RID: 11413 RVA: 0x00130F93 File Offset: 0x0012F193
		' (set) Token: 0x06002C96 RID: 11414 RVA: 0x00130F9B File Offset: 0x0012F19B
		<Description("筛选数据之前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("K.筛选")>
		<oO0oooo("2059")>
		<O_Oo00Oo000O0(31.0)>
		Public Property BeforeFilter As EventString
			Get
				Return Me.O.O0O__OO0.
			End Get
			Set(value As EventString)
				Me.O.O0O__OO0. = value
			End Set
		End Property

		' Token: 0x17000ADA RID: 2778
		' (get) Token: 0x06002C97 RID: 11415 RVA: 0x00130FA4 File Offset: 0x0012F1A4
		' (set) Token: 0x06002C98 RID: 11416 RVA: 0x00130FAC File Offset: 0x0012F1AC
		<Description("筛选数据之后执行。")>
		<oO0oooo("2060")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("K.筛选")>
		<O_Oo00Oo000O0(32.0)>
		Public Property AfterFilter As EventString
			Get
				Return Me.o_Oo.o000OOO00.
			End Get
			Set(value As EventString)
				Me.o_Oo.o000OOO00. = value
			End Set
		End Property

		' Token: 0x17000ADB RID: 2779
		' (get) Token: 0x06002C99 RID: 11417 RVA: 0x00130FB5 File Offset: 0x0012F1B5
		' (set) Token: 0x06002C9A RID: 11418 RVA: 0x00130FBD File Offset: 0x0012F1BD
		<oO0oooo("2061")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("数据排序之前执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("L.排序")>
		<O_Oo00Oo000O0(33.0)>
		Public Property BeforeSort As EventString
			Get
				Return Me.oO_._0.
			End Get
			Set(value As EventString)
				Me.oO_._0. = value
			End Set
		End Property

		' Token: 0x17000ADC RID: 2780
		' (get) Token: 0x06002C9B RID: 11419 RVA: 0x00130FC6 File Offset: 0x0012F1C6
		' (set) Token: 0x06002C9C RID: 11420 RVA: 0x00130FCE File Offset: 0x0012F1CE
		<Description("数据排序之后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("L.排序")>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("2062")>
		<O_Oo00Oo000O0(34.0)>
		Public Property AfterSort As EventString
			Get
				Return Me.OO._O_0.
			End Get
			Set(value As EventString)
				Me.OO._O_0. = value
			End Set
		End Property

		' Token: 0x17000ADD RID: 2781
		' (get) Token: 0x06002C9D RID: 11421 RVA: 0x00130FD7 File Offset: 0x0012F1D7
		' (set) Token: 0x06002C9E RID: 11422 RVA: 0x00130FDF File Offset: 0x0012F1DF
		<Description("双击单元格后执行。")>
		<oO0oooo("1499")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("M.鼠标与键盘")>
		<O_Oo00Oo000O0(37.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DoubleClick As EventString
			Get
				Return Me.O.00oo_0OOOO0o.
			End Get
			Set(value As EventString)
				Me.O.00oo_0OOOO0o. = value
			End Set
		End Property

		' Token: 0x17000ADE RID: 2782
		' (get) Token: 0x06002C9F RID: 11423 RVA: 0x00130FE8 File Offset: 0x0012F1E8
		' (set) Token: 0x06002CA0 RID: 11424 RVA: 0x00130FF0 File Offset: 0x0012F1F0
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2386")>
		<Category("M.鼠标与键盘")>
		<Description("单击单元格后执行。")>
		<O_Oo00Oo000O0(37.0)>
		<O0O0oOO00_0OO(True)>
		Public Property Click As EventString
			Get
				Return Me.O0o0.o.
			End Get
			Set(value As EventString)
				Me.O0o0.o. = value
			End Set
		End Property

		' Token: 0x17000ADF RID: 2783
		' (get) Token: 0x06002CA1 RID: 11425 RVA: 0x00130FF9 File Offset: 0x0012F1F9
		' (set) Token: 0x06002CA2 RID: 11426 RVA: 0x00131001 File Offset: 0x0012F201
		<oO0oooo("2678")>
		<Description("鼠标进入某个单元格的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("M.鼠标与键盘")>
		<O_Oo00Oo000O0(37.5)>
		<O0O0oOO00_0OO(True)>
		Public Property MouseEnterCell As EventString
			Get
				Return Me.o.O_O_ooo0.
			End Get
			Set(value As EventString)
				Me.o.O_O_ooo0. = value
			End Set
		End Property

		' Token: 0x17000AE0 RID: 2784
		' (get) Token: 0x06002CA3 RID: 11427 RVA: 0x0013100A File Offset: 0x0012F20A
		' (set) Token: 0x06002CA4 RID: 11428 RVA: 0x00131012 File Offset: 0x0012F212
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2679")>
		<Description("鼠标离开某个单元格的时候执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("M.鼠标与键盘")>
		<O_Oo00Oo000O0(37.5)>
		Public Property MouseLeaveCell As EventString
			Get
				Return Me.o0_O000O._.
			End Get
			Set(value As EventString)
				Me.o0_O000O._. = value
			End Set
		End Property

		' Token: 0x17000AE1 RID: 2785
		' (get) Token: 0x06002CA5 RID: 11429 RVA: 0x0013101B File Offset: 0x0012F21B
		' (set) Token: 0x06002CA6 RID: 11430 RVA: 0x00131023 File Offset: 0x0012F223
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("3750")>
		<Description("鼠标停留在某个单元格的时候执行。")>
		<Category("M.鼠标与键盘")>
		<O_Oo00Oo000O0(37.55)>
		<O0O0oOO00_0OO(True)>
		Public Property MouseHoverCell As EventString
			Get
				Return Me.o_.0o__0.
			End Get
			Set(value As EventString)
				Me.o_.0o__0. = value
			End Set
		End Property

		' Token: 0x17000AE2 RID: 2786
		' (get) Token: 0x06002CA7 RID: 11431 RVA: 0x0013102C File Offset: 0x0012F22C
		' (set) Token: 0x06002CA8 RID: 11432 RVA: 0x00131034 File Offset: 0x0012F234
		<oO0oooo("2929")>
		<Category("M.鼠标与键盘")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("双击行头时执行。")>
		<O_Oo00Oo000O0(37.6)>
		Public Property DoubleClickRowHeader As EventString
			Get
				Return Me.Oo00_0.0o.
			End Get
			Set(value As EventString)
				Me.Oo00_0.0o. = value
			End Set
		End Property

		' Token: 0x17000AE3 RID: 2787
		' (get) Token: 0x06002CA9 RID: 11433 RVA: 0x0013103D File Offset: 0x0012F23D
		' (set) Token: 0x06002CAA RID: 11434 RVA: 0x00131045 File Offset: 0x0012F245
		<oO0oooo("1642")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("压下按键时执行")>
		<O_Oo00Oo000O0(38.0)>
		<Category("M.鼠标与键盘")>
		<O0O0oOO00_0OO(True)>
		Public Property KeyDown As EventString
			Get
				Return Me.o0._o00_0_O_0O.
			End Get
			Set(value As EventString)
				Me.o0._o00_0_O_0O. = value
			End Set
		End Property

		' Token: 0x17000AE4 RID: 2788
		' (get) Token: 0x06002CAB RID: 11435 RVA: 0x0013104E File Offset: 0x0012F24E
		' (set) Token: 0x06002CAC RID: 11436 RVA: 0x00131056 File Offset: 0x0012F256
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1643")>
		<Description("松开按键执行")>
		<O_Oo00Oo000O0(39.0)>
		<Category("M.鼠标与键盘")>
		<O0O0oOO00_0OO(True)>
		Public Property KeyUp As EventString
			Get
				Return Me.OOo_O_O.0oooO0.
			End Get
			Set(value As EventString)
				Me.OOo_O_O.0oooO0. = value
			End Set
		End Property

		' Token: 0x17000AE5 RID: 2789
		' (get) Token: 0x06002CAD RID: 11437 RVA: 0x0013105F File Offset: 0x0012F25F
		' (set) Token: 0x06002CAE RID: 11438 RVA: 0x00131067 File Offset: 0x0012F267
		<Description("向图片列或文件列添加文件的时候执行。")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("N.附件")>
		<oO0oooo("2210")>
		<O_Oo00Oo000O0(35.1)>
		Public Property BeforeAttachFile As EventString
			Get
				Return Me.oO0.0OoO.
			End Get
			Set(value As EventString)
				Me.oO0.0OoO. = value
			End Set
		End Property

		' Token: 0x17000AE6 RID: 2790
		' (get) Token: 0x06002CAF RID: 11439 RVA: 0x00131070 File Offset: 0x0012F270
		' (set) Token: 0x06002CB0 RID: 11440 RVA: 0x00131078 File Offset: 0x0012F278
		<oO0oooo("2637")>
		<Category("N.附件")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("打开附件文件或者图片的时候执行")>
		<O_Oo00Oo000O0(35.2)>
		Public Property BeforeOpenFile As EventString
			Get
				Return Me.o_0_0.0.
			End Get
			Set(value As EventString)
				Me.o_0_0.0. = value
			End Set
		End Property

		' Token: 0x17000AE7 RID: 2791
		' (get) Token: 0x06002CB1 RID: 11441 RVA: 0x00131081 File Offset: 0x0012F281
		' (set) Token: 0x06002CB2 RID: 11442 RVA: 0x00131089 File Offset: 0x0012F289
		<oO0oooo("2638")>
		<Description("添加附件文件或者图片的时候执行")>
		<Category("N.附件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(35.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeAddFile As EventString
			Get
				Return Me.o_oOoo_O._00.
			End Get
			Set(value As EventString)
				Me.o_oOoo_O._00. = value
			End Set
		End Property

		' Token: 0x17000AE8 RID: 2792
		' (get) Token: 0x06002CB3 RID: 11443 RVA: 0x00131092 File Offset: 0x0012F292
		' (set) Token: 0x06002CB4 RID: 11444 RVA: 0x0013109A File Offset: 0x0012F29A
		<oO0oooo("2716")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("删除附件文件或图片的时候执行")>
		<O0O0oOO00_0OO(True)>
		<Category("N.附件")>
		<O_Oo00Oo000O0(35.3)>
		Public Property BeforeDeleteFile As EventString
			Get
				Return Me.oOo00_O.0_o0.
			End Get
			Set(value As EventString)
				Me.oOo00_O.0_o0. = value
			End Set
		End Property

		' Token: 0x17000AE9 RID: 2793
		' (get) Token: 0x06002CB5 RID: 11445 RVA: 0x001310A3 File Offset: 0x0012F2A3
		' (set) Token: 0x06002CB6 RID: 11446 RVA: 0x001310AB File Offset: 0x0012F2AB
		<oO0oooo("0661")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("加载表设置后执行，可以在此处添加代码，对表和列的属性进行设置。")>
		<Category("O.杂项")>
		<O_Oo00Oo000O0(35.0)>
		Public Property AfterLoadTableSetting As EventString
			Get
				Return Me.O_o_.o.
			End Get
			Set(value As EventString)
				Me.O_o_.o. = value
			End Set
		End Property

		' Token: 0x17000AEA RID: 2794
		' (get) Token: 0x06002CB7 RID: 11447 RVA: 0x001310B4 File Offset: 0x0012F2B4
		' (set) Token: 0x06002CB8 RID: 11448 RVA: 0x001310BC File Offset: 0x0012F2BC
		<oO0oooo("0662")>
		<Category("O.杂项")>
		<O_Oo00Oo000O0(36.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("显示快捷菜单之前执行，可以在此禁止显示快捷菜单，或更改要显示的快捷菜单。")>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeShowContextMenu As EventString
			Get
				Return Me.O0_0__Oo.O_.
			End Get
			Set(value As EventString)
				Me.O0_0__Oo.O_. = value
			End Set
		End Property

		' Token: 0x17000AEB RID: 2795
		' (get) Token: 0x06002CB9 RID: 11449 RVA: 0x001310C5 File Offset: 0x0012F2C5
		' (set) Token: 0x06002CBA RID: 11450 RVA: 0x001310CD File Offset: 0x0012F2CD
		<Category("O.杂项")>
		<oO0oooo("2357")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(40.0)>
		<Description("滚动表格后执行")>
		<O0O0oOO00_0OO(True)>
		Public Property AfterScroll As EventString
			Get
				Return Me.o_O_o.o0_.
			End Get
			Set(value As EventString)
				Me.o_O_o.o0_. = value
			End Set
		End Property

		' Token: 0x17000AEC RID: 2796
		' (get) Token: 0x06002CBB RID: 11451 RVA: 0x001310D6 File Offset: 0x0012F2D6
		' (set) Token: 0x06002CBC RID: 11452 RVA: 0x001310E3 File Offset: 0x0012F2E3
		<DefaultValue(True)>
		<DisplayName("允许拖动列")>
		<Description("是否可以利用鼠标拖动列标题来调整列位置。")>
		<Category("鼠标")>
		<O_Oo00Oo000O0(2.0)>
		Public Property AllowDragColumn As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowDragColumn
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowDragColumn = value
			End Set
		End Property

		' Token: 0x17000AED RID: 2797
		' (get) Token: 0x06002CBD RID: 11453 RVA: 0x001310F1 File Offset: 0x0012F2F1
		' (set) Token: 0x06002CBE RID: 11454 RVA: 0x001310FE File Offset: 0x0012F2FE
		<DefaultValue(True)>
		<DisplayName("允许冻结列")>
		<Description("是否可以利用鼠标拖动来调整冻结列数。")>
		<O_Oo00Oo000O0(3.0)>
		<Category("鼠标")>
		Public Property AllowFreezeColumn As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowFreezeColumn
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowFreezeColumn = value
			End Set
		End Property

		' Token: 0x17000AEE RID: 2798
		' (get) Token: 0x06002CBF RID: 11455 RVA: 0x0013110C File Offset: 0x0012F30C
		' (set) Token: 0x06002CC0 RID: 11456 RVA: 0x00131119 File Offset: 0x0012F319
		<DefaultValue(True)>
		<O_Oo00Oo000O0(4.0)>
		<Category("鼠标")>
		<DisplayName("允许调整列宽")>
		<Description("是否可以利用鼠标拖动来调整列宽。")>
		Public Property AllowResizeColumn As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowResizeColumn
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowResizeColumn = value
			End Set
		End Property

		' Token: 0x17000AEF RID: 2799
		' (get) Token: 0x06002CC1 RID: 11457 RVA: 0x00131127 File Offset: 0x0012F327
		' (set) Token: 0x06002CC2 RID: 11458 RVA: 0x00131134 File Offset: 0x0012F334
		<Description("是否可以利用鼠标拖动来调整行高。")>
		<Category("鼠标")>
		<DisplayName("允许调整行高")>
		<O_Oo00Oo000O0(5.0)>
		<DefaultValue(True)>
		Public Property AllowResizeRow As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowResizeRow
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowResizeRow = value
			End Set
		End Property

		' Token: 0x17000AF0 RID: 2800
		' (get) Token: 0x06002CC3 RID: 11459 RVA: 0x00131142 File Offset: 0x0012F342
		' (set) Token: 0x06002CC4 RID: 11460 RVA: 0x0013114F File Offset: 0x0012F34F
		<DisplayName("允许分别调整行高")>
		<Category("鼠标")>
		<DefaultValue(False)>
		<Description("用鼠标调整行高时，是否可以分别调整没每一行的高度。")>
		<O_Oo00Oo000O0(6.0)>
		Public Property AllowResizeSingleRow As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowResizeSingleRow
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowResizeSingleRow = value
			End Set
		End Property

		' Token: 0x17000AF1 RID: 2801
		' (get) Token: 0x06002CC5 RID: 11461 RVA: 0x0013115D File Offset: 0x0012F35D
		' (set) Token: 0x06002CC6 RID: 11462 RVA: 0x0013116A File Offset: 0x0012F36A
		<DefaultValue(True)>
		<O_Oo00Oo000O0(-1.0)>
		<Category("操作")>
		<DisplayName("允许编辑")>
		Public Property AllowEdit As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowEdit
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowEdit = value
			End Set
		End Property

		' Token: 0x17000AF2 RID: 2802
		' (get) Token: 0x06002CC7 RID: 11463 RVA: 0x00131178 File Offset: 0x0012F378
		' (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00131185 File Offset: 0x0012F385
		<O_Oo00Oo000O0(-0.9)>
		<DisplayName("保持编辑状态")>
		<DefaultValue(0)>
		<Category("操作")>
		Public Property PreserveEditMode As BooleanEnum
			Get
				Return Me.o__.0ooOOoo0o..PreserveEditMode2
			End Get
			Set(value As BooleanEnum)
				Me.o__.0ooOOoo0o..PreserveEditMode2 = value
			End Set
		End Property

		' Token: 0x17000AF3 RID: 2803
		' (get) Token: 0x06002CC9 RID: 11465 RVA: 0x00131193 File Offset: 0x0012F393
		' (set) Token: 0x06002CCA RID: 11466 RVA: 0x001311A0 File Offset: 0x0012F3A0
		<Category("操作")>
		<DisplayName("允许增加行")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(7.0)>
		Public Property AllowAddNew As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowAddNew
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowAddNew = value
			End Set
		End Property

		' Token: 0x17000AF4 RID: 2804
		' (get) Token: 0x06002CCB RID: 11467 RVA: 0x001311AE File Offset: 0x0012F3AE
		' (set) Token: 0x06002CCC RID: 11468 RVA: 0x001311BB File Offset: 0x0012F3BB
		<O_Oo00Oo000O0(7.1)>
		<Category("操作")>
		<Description("在最后一个单元格按回车时，是否自动增加一行")>
		<DisplayName("自动增加行")>
		<DefaultValue(False)>
		Public Property AutoAddNew As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AutoAddNew
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AutoAddNew = value
			End Set
		End Property

		' Token: 0x17000AF5 RID: 2805
		' (get) Token: 0x06002CCD RID: 11469 RVA: 0x001311C9 File Offset: 0x0012F3C9
		' (set) Token: 0x06002CCE RID: 11470 RVA: 0x001311D6 File Offset: 0x0012F3D6
		<Category("操作")>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("允许删除行")>
		<DefaultValue(True)>
		Public Property AllowDelete As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowDelete
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowDelete = value
			End Set
		End Property

		' Token: 0x17000AF6 RID: 2806
		' (get) Token: 0x06002CCF RID: 11471 RVA: 0x001311E4 File Offset: 0x0012F3E4
		' (set) Token: 0x06002CD0 RID: 11472 RVA: 0x001311F1 File Offset: 0x0012F3F1
		<O_Oo00Oo000O0(9.0)>
		<Category("操作")>
		<DisplayName("允许锁定行")>
		<DefaultValue(True)>
		Public Property AllowLockRow As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowLockRow
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowLockRow = value
			End Set
		End Property

		' Token: 0x17000AF7 RID: 2807
		' (get) Token: 0x06002CD1 RID: 11473 RVA: 0x001311FF File Offset: 0x0012F3FF
		' (set) Token: 0x06002CD2 RID: 11474 RVA: 0x0013120C File Offset: 0x0012F40C
		<Category("操作")>
		<DisplayName("允许解锁行")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(10.0)>
		Public Property AllowUnLockRow As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowUnlockRow
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowUnlockRow = value
			End Set
		End Property

		' Token: 0x17000AF8 RID: 2808
		' (get) Token: 0x06002CD3 RID: 11475 RVA: 0x0013121A File Offset: 0x0012F41A
		' (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00131227 File Offset: 0x0012F427
		<Description("设为False，将禁止用户复制粘贴表中数据，防止重要数据被非法复制。")>
		<Category("操作")>
		<DisplayName("允许复制粘贴")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(10.1)>
		Public Property AllowClipBoard As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowClipBoard
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowClipBoard = value
			End Set
		End Property

		' Token: 0x17000AF9 RID: 2809
		' (get) Token: 0x06002CD5 RID: 11477 RVA: 0x00131235 File Offset: 0x0012F435
		' (set) Token: 0x06002CD6 RID: 11478 RVA: 0x00131242 File Offset: 0x0012F442
		<Category("操作")>
		<DefaultValue(True)>
		<Description("设为False，将禁止用户初始化此表。")>
		<O_Oo00Oo000O0(10.2)>
		<DisplayName("允许初始化")>
		Public Property AllowInitialize As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowInitialize
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowInitialize = value
			End Set
		End Property

		' Token: 0x17000AFA RID: 2810
		' (get) Token: 0x06002CD7 RID: 11479 RVA: 0x00131250 File Offset: 0x0012F450
		' (set) Token: 0x06002CD8 RID: 11480 RVA: 0x0013125D File Offset: 0x0012F45D
		<Description("设为False，将禁止用户重定向此表。")>
		<O_Oo00Oo000O0(10.2)>
		<DefaultValue(True)>
		<DisplayName("允许重定向")>
		<Category("操作")>
		Public Property AllowRedirect As Boolean
			Get
				Return Me.o__.0ooOOoo0o..AllowRedirect
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowRedirect = value
			End Set
		End Property

		' Token: 0x17000AFB RID: 2811
		' (get) Token: 0x06002CD9 RID: 11481 RVA: 0x0013126B File Offset: 0x0012F46B
		' (set) Token: 0x06002CDA RID: 11482 RVA: 0x00131278 File Offset: 0x0012F478
		<DisplayName("分页后台筛选")>
		<DefaultValue(False)>
		<Description("是否允许用户直接通过菜单筛选后台数据。")>
		<Category("操作")>
		<O_Oo00Oo000O0(15.0)>
		Public Property AllowBackEndFilter As Boolean
			Get
				Return Me.o__.0ooOOoo0o..o0OOOo_.0_o_0o.
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..AllowBackEndFilter = value
			End Set
		End Property

		' Token: 0x17000AFC RID: 2812
		' (get) Token: 0x06002CDB RID: 11483 RVA: 0x00131286 File Offset: 0x0012F486
		' (set) Token: 0x06002CDC RID: 11484 RVA: 0x00131293 File Offset: 0x0012F493
		<DisplayName("删除行需要确认")>
		<O_Oo00Oo000O0(12.0)>
		<DefaultValue(True)>
		<Description("是否在删除行之前提示用户确认。")>
		<Category("操作")>
		Public Property DeleteRowPrompt As Boolean
			Get
				Return Me.o__.0ooOOoo0o..DeleteRowPrompt
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..DeleteRowPrompt = value
			End Set
		End Property

		' Token: 0x17000AFD RID: 2813
		' (get) Token: 0x06002CDD RID: 11485 RVA: 0x001312A1 File Offset: 0x0012F4A1
		' (set) Token: 0x06002CDE RID: 11486 RVA: 0x001312AE File Offset: 0x0012F4AE
		<O_Oo00Oo000O0(13.0)>
		<Category("操作")>
		<DisplayName("按回车键向下移动")>
		<DefaultValue(False)>
		Public Property EnterKeyActionDown As Boolean
			Get
				Return Me.o__.0ooOOoo0o..EnterKeyActionDown
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..EnterKeyActionDown = value
			End Set
		End Property

		' Token: 0x17000AFE RID: 2814
		' (get) Token: 0x06002CDF RID: 11487 RVA: 0x001312BC File Offset: 0x0012F4BC
		' (set) Token: 0x06002CE0 RID: 11488 RVA: 0x001312C9 File Offset: 0x0012F4C9
		<DisplayName("按Tab键向下移动")>
		<Category("操作")>
		<O_Oo00Oo000O0(14.0)>
		<DefaultValue(False)>
		Public Property TabKeyActionDown As Boolean
			Get
				Return Me.o__.0ooOOoo0o..TabKeyActionDown
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..TabKeyActionDown = value
			End Set
		End Property

		' Token: 0x17000AFF RID: 2815
		' (get) Token: 0x06002CE1 RID: 11489 RVA: 0x001312D8 File Offset: 0x0012F4D8
		' (set) Token: 0x06002CE2 RID: 11490 RVA: 0x001312E6 File Offset: 0x0012F4E6
		<Browsable(False)>
		<OooO0(True)>
		Public Property SystemVisualStyle As Boolean
			Get
				Dim result As Boolean
				Return result
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000B00 RID: 2816
		' (get) Token: 0x06002CE3 RID: 11491 RVA: 0x001312E8 File Offset: 0x0012F4E8
		' (set) Token: 0x06002CE4 RID: 11492 RVA: 0x001312F5 File Offset: 0x0012F4F5
		<DefaultValue("(default)")>
		<O_Oo00Oo000O0(-1.0)>
		<Category("杂项")>
		<DisplayName("表格样式")>
		<Browsable(False)>
		Public Property Theme As String
			Get
				Return Me.o__.0ooOOoo0o..O0__.00.
			End Get
			Set(value As String)
				Me.o__.0ooOOoo0o..O0__.00. = value
			End Set
		End Property

		' Token: 0x17000B01 RID: 2817
		' (get) Token: 0x06002CE5 RID: 11493 RVA: 0x00131303 File Offset: 0x0012F503
		' (set) Token: 0x06002CE6 RID: 11494 RVA: 0x00131310 File Offset: 0x0012F510
		<Category("杂项")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("启用多层表头")>
		Public Property MultiRowHeader As Boolean
			Get
				Return Me.o__.0ooOOoo0o..MultiRowHeader
			End Get
			Set(value As Boolean)
				Me.o__.0ooOOoo0o..MultiRowHeader = value
			End Set
		End Property

		' Token: 0x17000B02 RID: 2818
		' (get) Token: 0x06002CE7 RID: 11495 RVA: 0x0013131E File Offset: 0x0012F51E
		' (set) Token: 0x06002CE8 RID: 11496 RVA: 0x0013132B File Offset: 0x0012F52B
		<Category("杂项")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("自定义图标")>
		Public Property CustomImage As String
			Get
				Return Me.o__.0ooOOoo0o..frd_CustomImage
			End Get
			Set(value As String)
				Me.o__.0ooOOoo0o..frd_CustomImage = value
			End Set
		End Property

		' Token: 0x17000B03 RID: 2819
		' (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00131339 File Offset: 0x0012F539
		' (set) Token: 0x06002CEA RID: 11498 RVA: 0x00131346 File Offset: 0x0012F546
		<Browsable(False)>
		Public Property Developer As String
			Get
				Return Me.o__.0ooOOoo0o..Developer
			End Get
			Set(value As String)
				Me.o__.0ooOOoo0o..Developer = value
			End Set
		End Property

		' Token: 0x17000B04 RID: 2820
		' (get) Token: 0x06002CEB RID: 11499 RVA: 0x00131354 File Offset: 0x0012F554
		<Browsable(False)>
		<OooO0(True)>
		Public Shared ReadOnly Property Connected As Boolean
			Get
				Return DataTableProperty.o.O0_oo0O.
			End Get
		End Property

		' Token: 0x040011A8 RID: 4520
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x040011A9 RID: 4521
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011AA RID: 4522
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011AB RID: 4523
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011AC RID: 4524
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011AD RID: 4525
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011AE RID: 4526
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011AF RID: 4527
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B0 RID: 4528
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B1 RID: 4529
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B2 RID: 4530
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B3 RID: 4531
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B4 RID: 4532
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B5 RID: 4533
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B6 RID: 4534
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B7 RID: 4535
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B8 RID: 4536
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011B9 RID: 4537
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011BA RID: 4538
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011BB RID: 4539
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011BC RID: 4540
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011BD RID: 4541
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011BE RID: 4542
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011BF RID: 4543
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C0 RID: 4544
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C1 RID: 4545
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C2 RID: 4546
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C3 RID: 4547
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C4 RID: 4548
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C5 RID: 4549
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C6 RID: 4550
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C7 RID: 4551
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C8 RID: 4552
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011C9 RID: 4553
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011CA RID: 4554
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011CB RID: 4555
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011CC RID: 4556
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011CD RID: 4557
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011CE RID: 4558
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011CF RID: 4559
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D0 RID: 4560
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D1 RID: 4561
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D2 RID: 4562
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D3 RID: 4563
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D4 RID: 4564
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D5 RID: 4565
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D6 RID: 4566
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D7 RID: 4567
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D8 RID: 4568
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011D9 RID: 4569
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011DA RID: 4570
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011DB RID: 4571
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011DC RID: 4572
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011DD RID: 4573
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011DE RID: 4574
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011DF RID: 4575
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E0 RID: 4576
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E1 RID: 4577
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E2 RID: 4578
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E3 RID: 4579
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E4 RID: 4580
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E5 RID: 4581
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E6 RID: 4582
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E7 RID: 4583
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E8 RID: 4584
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011E9 RID: 4585
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040011EA RID: 4586
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040011EB RID: 4587
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040011EC RID: 4588
		Private <<EMPTY_NAME>> As String

		' Token: 0x040011ED RID: 4589
		Private Shared <<EMPTY_NAME>> As Boolean = True
	End Class
End Namespace
