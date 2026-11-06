Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports C1.Win.C1Command

Namespace Foxtable
	' Token: 0x02000413 RID: 1043
	Friend Class TopicBarProperty
		Inherits ControlPropertyBase

		' Token: 0x0600459D RID: 17821 RVA: 0x001C3E6A File Offset: 0x001C206A
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O._oooo0__. = CType(A_0.ChildControl, Oo_)
		End Sub

		' Token: 0x1700101B RID: 4123
		' (get) Token: 0x0600459E RID: 17822 RVA: 0x001C3E84 File Offset: 0x001C2084
		' (set) Token: 0x0600459F RID: 17823 RVA: 0x001C3E92 File Offset: 0x001C2092
		<OooO0(False)>
		<Browsable(False)>
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x1700101C RID: 4124
		' (get) Token: 0x060045A0 RID: 17824 RVA: 0x001C3E94 File Offset: 0x001C2094
		' (set) Token: 0x060045A1 RID: 17825 RVA: 0x001C3EA6 File Offset: 0x001C20A6
		<O_Oo00Oo000O0(0.0)>
		<DefaultValue("(default)")>
		<TypeConverter(GetType(o00))>
		<DisplayName("样式")>
		<Category("外观")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.O._oooo0__.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.O._oooo0__. })
			End Set
		End Property

		' Token: 0x1700101D RID: 4125
		' (get) Token: 0x060045A2 RID: 17826 RVA: 0x001C3EC2 File Offset: 0x001C20C2
		' (set) Token: 0x060045A3 RID: 17827 RVA: 0x001C3ECA File Offset: 0x001C20CA
		<oO0oooo("0869")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("单击命令连接后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.0)>
		Public Property TopicLinkClick As EventString
			Get
				Return Me.o.Ooo_0__0Oo.
			End Get
			Set(value As EventString)
				Me.o.Ooo_0__0Oo. = value
			End Set
		End Property

		' Token: 0x1700101E RID: 4126
		' (get) Token: 0x060045A4 RID: 17828 RVA: 0x001C3ED3 File Offset: 0x001C20D3
		' (set) Token: 0x060045A5 RID: 17829 RVA: 0x001C3EDB File Offset: 0x001C20DB
		<oO0oooo("2133")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("展开页面后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.0)>
		Public Property TopicPageExpanded As EventString
			Get
				Return Me.O00___._OO_.
			End Get
			Set(value As EventString)
				Me.O00___._OO_. = value
			End Set
		End Property

		' Token: 0x1700101F RID: 4127
		' (get) Token: 0x060045A6 RID: 17830 RVA: 0x001C3EE4 File Offset: 0x001C20E4
		' (set) Token: 0x060045A7 RID: 17831 RVA: 0x001C3EEC File Offset: 0x001C20EC
		<oO0oooo("2134")>
		<O_Oo00Oo000O0(0.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("收缩页面后执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property TopicPageCollapsed As EventString
			Get
				Return Me.O0_.__o_.
			End Get
			Set(value As EventString)
				Me.O0_.__o_. = value
			End Set
		End Property

		' Token: 0x17001020 RID: 4128
		' (get) Token: 0x060045A8 RID: 17832 RVA: 0x001C3EF5 File Offset: 0x001C20F5
		' (set) Token: 0x060045A9 RID: 17833 RVA: 0x001C3EFD File Offset: 0x001C20FD
		<Browsable(False)>
		Public Property Setting As String
			Get
				Return Me.o.Ooo_0__0Oo.
			End Get
			Set(value As String)
				Me.o.Ooo_0__0Oo. = value
				oOO0oo_o0.O.ooooo.(Me.O._oooo0__., value)
			End Set
		End Property

		' Token: 0x04001C4E RID: 7246
		Friend <<EMPTY_NAME>> As Oo_

		' Token: 0x04001C4F RID: 7247
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C50 RID: 7248
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C51 RID: 7249
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C52 RID: 7250
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
