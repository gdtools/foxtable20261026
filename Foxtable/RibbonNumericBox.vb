Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200047B RID: 1147
	<oO0oooo("2037")>
	<OoO0___o("RibbonNumericBox")>
	Friend Class RibbonNumericBox
		Inherits RibbonItem

		' Token: 0x06004C8B RID: 19595 RVA: 0x00200FE8 File Offset: 0x001FF1E8
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O.oOOO. = "数值:"
			Me.o0_.OO. = 50
			Me.o0_.OO. = 100D
			Me.OO_O0__oOo00.0. = 0D
			Me.O_.____0_O. = 1D
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001129 RID: 4393
		' (get) Token: 0x06004C8C RID: 19596 RVA: 0x0020103C File Offset: 0x001FF23C
		' (set) Token: 0x06004C8D RID: 19597 RVA: 0x00201044 File Offset: 0x001FF244
		<DisplayName("标题")>
		<DefaultValue("数值:")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Label As String
			Get
				Return Me.O.oOOO.
			End Get
			Set(value As String)
				Me.O.oOOO. = value
			End Set
		End Property

		' Token: 0x1700112A RID: 4394
		' (get) Token: 0x06004C8E RID: 19598 RVA: 0x0020104D File Offset: 0x001FF24D
		' (set) Token: 0x06004C8F RID: 19599 RVA: 0x00201055 File Offset: 0x001FF255
		<DisplayName("宽度")>
		<O_Oo00Oo000O0(1.3)>
		<Category("属性")>
		Public Property TextAreaWidth As Integer
			Get
				Return Me.o0_.OO.
			End Get
			Set(value As Integer)
				Me.o0_.OO. = value
			End Set
		End Property

		' Token: 0x1700112B RID: 4395
		' (get) Token: 0x06004C90 RID: 19600 RVA: 0x0020105E File Offset: 0x001FF25E
		' (set) Token: 0x06004C91 RID: 19601 RVA: 0x00201066 File Offset: 0x001FF266
		<O_Oo00Oo000O0(1.31)>
		<DisplayName("最小值")>
		<DefaultValue(0)>
		<Category("属性")>
		Public Property Minimum As Decimal
			Get
				Return Me.OO_O0__oOo00.0.
			End Get
			Set(value As Decimal)
				Me.OO_O0__oOo00.0. = value
			End Set
		End Property

		' Token: 0x1700112C RID: 4396
		' (get) Token: 0x06004C92 RID: 19602 RVA: 0x0020106F File Offset: 0x001FF26F
		' (set) Token: 0x06004C93 RID: 19603 RVA: 0x00201077 File Offset: 0x001FF277
		<O_Oo00Oo000O0(1.32)>
		<Category("属性")>
		<DefaultValue(100)>
		<DisplayName("最大值")>
		Public Property Maximum As Decimal
			Get
				Return Me.o0_.OO.
			End Get
			Set(value As Decimal)
				Me.o0_.OO. = value
			End Set
		End Property

		' Token: 0x1700112D RID: 4397
		' (get) Token: 0x06004C94 RID: 19604 RVA: 0x00201080 File Offset: 0x001FF280
		' (set) Token: 0x06004C95 RID: 19605 RVA: 0x00201088 File Offset: 0x001FF288
		<O_Oo00Oo000O0(1.4)>
		<Category("属性")>
		<DisplayName("初始值")>
		Public Property Value As String
			Get
				Return Me.OO_O0__oOo00.0.
			End Get
			Set(value As String)
				If Versioned.IsNumeric(value) Then
					Me.OO_O0__oOo00.0. = Conversion.Val(value).ToString()
				End If
			End Set
		End Property

		' Token: 0x1700112E RID: 4398
		' (get) Token: 0x06004C96 RID: 19606 RVA: 0x002010B1 File Offset: 0x001FF2B1
		' (set) Token: 0x06004C97 RID: 19607 RVA: 0x002010B9 File Offset: 0x001FF2B9
		<DisplayName("微调增幅")>
		<O_Oo00Oo000O0(1.5)>
		<Category("属性")>
		<DefaultValue(1)>
		Public Property Increment As Decimal
			Get
				Return Me.O_.____0_O.
			End Get
			Set(value As Decimal)
				Me.O_.____0_O. = value
			End Set
		End Property

		' Token: 0x1700112F RID: 4399
		' (get) Token: 0x06004C98 RID: 19608 RVA: 0x002010C2 File Offset: 0x001FF2C2
		' (set) Token: 0x06004C99 RID: 19609 RVA: 0x002010CA File Offset: 0x001FF2CA
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		<Description("取消修改后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property ChangeCanceled As EventString
			Get
				Return Me.O.oOOO.
			End Get
			Set(value As EventString)
				Me.O.oOOO. = value
			End Set
		End Property

		' Token: 0x17001130 RID: 4400
		' (get) Token: 0x06004C9A RID: 19610 RVA: 0x002010D3 File Offset: 0x001FF2D3
		' (set) Token: 0x06004C9B RID: 19611 RVA: 0x002010DB File Offset: 0x001FF2DB
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.2)>
		<Category("事件")>
		<Description("提交修改后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property ChangeCommitted As EventString
			Get
				Return Me.oo0o.0ooo.
			End Get
			Set(value As EventString)
				Me.oo0o.0ooo. = value
			End Set
		End Property

		' Token: 0x17001131 RID: 4401
		' (get) Token: 0x06004C9C RID: 19612 RVA: 0x002010E4 File Offset: 0x001FF2E4
		' (set) Token: 0x06004C9D RID: 19613 RVA: 0x002010EC File Offset: 0x001FF2EC
		<O_Oo00Oo000O0(0.3)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("值改变后执行。")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property ValueChanged As EventString
			Get
				Return Me.O0o.00O_0.
			End Get
			Set(value As EventString)
				Me.O0o.00O_0. = value
			End Set
		End Property

		' Token: 0x17001132 RID: 4402
		' (get) Token: 0x06004C9E RID: 19614 RVA: 0x002010F5 File Offset: 0x001FF2F5
		' (set) Token: 0x06004C9F RID: 19615 RVA: 0x002010FD File Offset: 0x001FF2FD
		<Description("获得输入焦点后执行。")>
		<O_Oo00Oo000O0(0.4)>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property GotFocus As EventString
			Get
				Return Me.O._Oo_o_O_.
			End Get
			Set(value As EventString)
				Me.O._Oo_o_O_. = value
			End Set
		End Property

		' Token: 0x17001133 RID: 4403
		' (get) Token: 0x06004CA0 RID: 19616 RVA: 0x00201106 File Offset: 0x001FF306
		' (set) Token: 0x06004CA1 RID: 19617 RVA: 0x0020110E File Offset: 0x001FF30E
		<O_Oo00Oo000O0(0.5)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("失去输入焦点后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property LostFocus As EventString
			Get
				Return Me.o_o.0_0_o.
			End Get
			Set(value As EventString)
				Me.o_o.0_0_o. = value
			End Set
		End Property

		' Token: 0x17001134 RID: 4404
		' (get) Token: 0x06004CA2 RID: 19618 RVA: 0x00201117 File Offset: 0x001FF317
		' (set) Token: 0x06004CA3 RID: 19619 RVA: 0x0020111A File Offset: 0x001FF31A
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04001F74 RID: 8052
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F75 RID: 8053
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F76 RID: 8054
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F77 RID: 8055
		Private <<EMPTY_NAME>> As Decimal

		' Token: 0x04001F78 RID: 8056
		Private <<EMPTY_NAME>> As Decimal

		' Token: 0x04001F79 RID: 8057
		Private <<EMPTY_NAME>> As Decimal

		' Token: 0x04001F7A RID: 8058
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F7B RID: 8059
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F7C RID: 8060
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F7D RID: 8061
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F7E RID: 8062
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
