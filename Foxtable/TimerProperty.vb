Imports System
Imports System.ComponentModel
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200032B RID: 811
	<TypeConverter(GetType(OoO0o0oo__Oo))>
	Friend Class TimerProperty
		' Token: 0x0600303A RID: 12346 RVA: 0x001374A8 File Offset: 0x001356A8
		Public Sub New()
			Me.oo.0oOO. = 2000
			Me.oo.0oOO. = True
			Me.O___0O.oo. = True
		End Sub

		' Token: 0x17000C9E RID: 3230
		' (get) Token: 0x0600303B RID: 12347 RVA: 0x001374C9 File Offset: 0x001356C9
		' (set) Token: 0x0600303C RID: 12348 RVA: 0x001374D1 File Offset: 0x001356D1
		<OooO0(True)>
		<Category("基本属性")>
		<DisplayName("名称")>
		<O_Oo00Oo000O0(1.0)>
		Public Property Name As String
			Get
				Return Me.oo.0oOO.
			End Get
			Set(value As String)
				Me.oo.0oOO. = value
			End Set
		End Property

		' Token: 0x17000C9F RID: 3231
		' (get) Token: 0x0600303D RID: 12349 RVA: 0x001374DA File Offset: 0x001356DA
		' (set) Token: 0x0600303E RID: 12350 RVA: 0x001374E2 File Offset: 0x001356E2
		<Description("计划执行间隔，单位为1/1000秒。")>
		<O_Oo00Oo000O0(2.0)>
		<Category("基本属性")>
		<DisplayName("间隔")>
		<DefaultValue(0)>
		Public Property Interval As Integer
			Get
				Return Me.oo.0oOO.
			End Get
			Set(value As Integer)
				If value < 1 Then
					value = 1
				End If
				Me.oo.0oOO. = value
			End Set
		End Property

		' Token: 0x17000CA0 RID: 3232
		' (get) Token: 0x0600303F RID: 12351 RVA: 0x001374F2 File Offset: 0x001356F2
		' (set) Token: 0x06003040 RID: 12352 RVA: 0x001374FA File Offset: 0x001356FA
		<DisplayName("执行")>
		<O_Oo00Oo000O0(3.0)>
		<Category("基本属性")>
		<Description("是否执行计划")>
		<DefaultValue(True)>
		Public Property Enabled As Boolean
			Get
				Return Me.oo.0oOO.
			End Get
			Set(value As Boolean)
				Me.oo.0oOO. = value
			End Set
		End Property

		' Token: 0x17000CA1 RID: 3233
		' (get) Token: 0x06003041 RID: 12353 RVA: 0x00137503 File Offset: 0x00135703
		' (set) Token: 0x06003042 RID: 12354 RVA: 0x0013750B File Offset: 0x0013570B
		<Category("基本属性")>
		<O_Oo00Oo000O0(4.0)>
		<Description("是否允许用户暂停计划的执行")>
		<DisplayName("允许暂停")>
		<DefaultValue(True)>
		Public Property CanPause As Boolean
			Get
				Return Me.O___0O.oo.
			End Get
			Set(value As Boolean)
				Me.O___0O.oo. = value
			End Set
		End Property

		' Token: 0x17000CA2 RID: 3234
		' (get) Token: 0x06003043 RID: 12355 RVA: 0x00137514 File Offset: 0x00135714
		' (set) Token: 0x06003044 RID: 12356 RVA: 0x0013751C File Offset: 0x0013571C
		<DisplayName("代码")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("基本属性")>
		<Description("定期执行的代码")>
		<O_Oo00Oo000O0(5.0)>
		Public Property Tick As EventString
			Get
				Return Me.oo.0oOO.
			End Get
			Set(value As EventString)
				Me.oo.0oOO. = value
			End Set
		End Property

		' Token: 0x04001354 RID: 4948
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001355 RID: 4949
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001356 RID: 4950
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001357 RID: 4951
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001358 RID: 4952
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
