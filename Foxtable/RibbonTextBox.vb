Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000475 RID: 1141
	<oO0oooo("1112")>
	<OoO0___o("RibbonTextBox")>
	Friend Class RibbonTextBox
		Inherits RibbonItem

		' Token: 0x06004C40 RID: 19520 RVA: 0x00200CA4 File Offset: 0x001FEEA4
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O0oo0.o. = "标题:"
			Me.O0oo0.o. = 60
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001106 RID: 4358
		' (get) Token: 0x06004C41 RID: 19521 RVA: 0x00200CC8 File Offset: 0x001FEEC8
		' (set) Token: 0x06004C42 RID: 19522 RVA: 0x00200CE3 File Offset: 0x001FEEE3
		<DisplayName("标题")>
		<DefaultValue("标题:")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Label As String
			Get
				If Me.O0oo0.o. Is Nothing Then
					Me.O0oo0.o. = ""
				End If
				Return Me.O0oo0.o.
			End Get
			Set(value As String)
				Me.O0oo0.o. = value
			End Set
		End Property

		' Token: 0x17001107 RID: 4359
		' (get) Token: 0x06004C43 RID: 19523 RVA: 0x00200CEC File Offset: 0x001FEEEC
		' (set) Token: 0x06004C44 RID: 19524 RVA: 0x00200CF4 File Offset: 0x001FEEF4
		<O_Oo00Oo000O0(1.2)>
		<Category("属性")>
		<DisplayName("内容")>
		Public Property Text As String
			Get
				Return Me.o00oo_OOO.00.
			End Get
			Set(value As String)
				Me.o00oo_OOO.00. = value
			End Set
		End Property

		' Token: 0x17001108 RID: 4360
		' (get) Token: 0x06004C45 RID: 19525 RVA: 0x00200CFD File Offset: 0x001FEEFD
		' (set) Token: 0x06004C46 RID: 19526 RVA: 0x00200D05 File Offset: 0x001FEF05
		<O_Oo00Oo000O0(1.3)>
		<Category("属性")>
		<DisplayName("宽度")>
		Public Property TextAreaWidth As Integer
			Get
				Return Me.O0oo0.o.
			End Get
			Set(value As Integer)
				Me.O0oo0.o. = value
			End Set
		End Property

		' Token: 0x17001109 RID: 4361
		' (get) Token: 0x06004C47 RID: 19527 RVA: 0x00200D0E File Offset: 0x001FEF0E
		' (set) Token: 0x06004C48 RID: 19528 RVA: 0x00200D16 File Offset: 0x001FEF16
		<DefaultValue(0)>
		<Description("允许输入内容的最大长度")>
		<O_Oo00Oo000O0(1.4)>
		<Category("属性")>
		<DisplayName("最大长度")>
		Public Property MaxLength As Integer
			Get
				Return Me.o00oo_OOO.00.
			End Get
			Set(value As Integer)
				Me.o00oo_OOO.00. = value
			End Set
		End Property

		' Token: 0x1700110A RID: 4362
		' (get) Token: 0x06004C49 RID: 19529 RVA: 0x00200D1F File Offset: 0x001FEF1F
		' (set) Token: 0x06004C4A RID: 19530 RVA: 0x00200D27 File Offset: 0x001FEF27
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Description("取消修改后执行。")>
		<O_Oo00Oo000O0(0.1)>
		Public Property ChangeCanceled As EventString
			Get
				Return Me.O0oo0.o.
			End Get
			Set(value As EventString)
				Me.O0oo0.o. = value
			End Set
		End Property

		' Token: 0x1700110B RID: 4363
		' (get) Token: 0x06004C4B RID: 19531 RVA: 0x00200D30 File Offset: 0x001FEF30
		' (set) Token: 0x06004C4C RID: 19532 RVA: 0x00200D38 File Offset: 0x001FEF38
		<Description("提交修改后执行。")>
		<O_Oo00Oo000O0(0.2)>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property ChangeCommitted As EventString
			Get
				Return Me.o00oo_OOO.00.
			End Get
			Set(value As EventString)
				Me.o00oo_OOO.00. = value
			End Set
		End Property

		' Token: 0x1700110C RID: 4364
		' (get) Token: 0x06004C4D RID: 19533 RVA: 0x00200D41 File Offset: 0x001FEF41
		' (set) Token: 0x06004C4E RID: 19534 RVA: 0x00200D49 File Offset: 0x001FEF49
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("内容改变后执行。")>
		<O_Oo00Oo000O0(0.3)>
		<O0O0oOO00_0OO(True)>
		Public Property TextChanged As EventString
			Get
				Return Me.o0.0o_ooOO_o.
			End Get
			Set(value As EventString)
				Me.o0.0o_ooOO_o. = value
			End Set
		End Property

		' Token: 0x1700110D RID: 4365
		' (get) Token: 0x06004C4F RID: 19535 RVA: 0x00200D52 File Offset: 0x001FEF52
		' (set) Token: 0x06004C50 RID: 19536 RVA: 0x00200D5A File Offset: 0x001FEF5A
		<Description("获得输入焦点后执行。")>
		<O_Oo00Oo000O0(0.4)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property GotFocus As EventString
			Get
				Return Me.oO00.o_oOO0OO_.
			End Get
			Set(value As EventString)
				Me.oO00.o_oOO0OO_. = value
			End Set
		End Property

		' Token: 0x1700110E RID: 4366
		' (get) Token: 0x06004C51 RID: 19537 RVA: 0x00200D63 File Offset: 0x001FEF63
		' (set) Token: 0x06004C52 RID: 19538 RVA: 0x00200D6B File Offset: 0x001FEF6B
		<Description("失去输入焦点后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O_Oo00Oo000O0(0.5)>
		<O0O0oOO00_0OO(True)>
		Public Property LostFocus As EventString
			Get
				Return Me.oo00Oo.__o_0O0.
			End Get
			Set(value As EventString)
				Me.oo00Oo.__o_0O0. = value
			End Set
		End Property

		' Token: 0x1700110F RID: 4367
		' (get) Token: 0x06004C53 RID: 19539 RVA: 0x00200D74 File Offset: 0x001FEF74
		' (set) Token: 0x06004C54 RID: 19540 RVA: 0x00200D77 File Offset: 0x001FEF77
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04001F54 RID: 8020
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F55 RID: 8021
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F56 RID: 8022
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F57 RID: 8023
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F58 RID: 8024
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F59 RID: 8025
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F5A RID: 8026
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F5B RID: 8027
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F5C RID: 8028
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
