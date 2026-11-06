Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports C1.Win.C1Input

Namespace Foxtable
	' Token: 0x020002AC RID: 684
	Friend Class DropDownBoxProperty
		Inherits TextBoxProperty

		' Token: 0x06002415 RID: 9237 RVA: 0x000FA47C File Offset: 0x000F867C
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o.O_OO. = True
			Me.oO.0. = CType(A_0.ChildControl, C1DropDownControl)
			Me.oO.0..VerticalAlign = 1
		End Sub

		' Token: 0x17000848 RID: 2120
		' (get) Token: 0x06002416 RID: 9238 RVA: 0x000FA4A9 File Offset: 0x000F86A9
		' (set) Token: 0x06002417 RID: 9239 RVA: 0x000FA4B1 File Offset: 0x000F86B1
		<TypeConverter(GetType(O__000__Oo0))>
		<O_Oo00Oo000O0(2.9)>
		<MergableProperty(True)>
		<DisplayName("下拉窗口")>
		<Category("基本")>
		Public Property DropFormName As String
			Get
				Return Me.o.O_OO.
			End Get
			Set(value As String)
				Me.o.O_OO. = value
			End Set
		End Property

		' Token: 0x17000849 RID: 2121
		' (get) Token: 0x06002418 RID: 9240 RVA: 0x000FA4BA File Offset: 0x000F86BA
		' (set) Token: 0x06002419 RID: 9241 RVA: 0x000FA4C7 File Offset: 0x000F86C7
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("显示下拉按钮")>
		<Category("基本")>
		<DefaultValue(True)>
		Public Property ShowDropDownButton As Boolean
			Get
				Return Me.oO.0..ShowDropDownButton
			End Get
			Set(value As Boolean)
				Me.oO.0..ShowDropDownButton = value
			End Set
		End Property

		' Token: 0x1700084A RID: 2122
		' (get) Token: 0x0600241A RID: 9242 RVA: 0x000FA4D5 File Offset: 0x000F86D5
		' (set) Token: 0x0600241B RID: 9243 RVA: 0x000FA4E2 File Offset: 0x000F86E2
		<MergableProperty(True)>
		<Category("基本")>
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("显示微调按钮")>
		<DefaultValue(False)>
		Public Property ShowUpDownButtons As Boolean
			Get
				Return Me.oO.0..ShowUpDownButtons
			End Get
			Set(value As Boolean)
				Me.oO.0..ShowUpDownButtons = value
			End Set
		End Property

		' Token: 0x1700084B RID: 2123
		' (get) Token: 0x0600241C RID: 9244 RVA: 0x000FA4F0 File Offset: 0x000F86F0
		' (set) Token: 0x0600241D RID: 9245 RVA: 0x000FA4FD File Offset: 0x000F86FD
		<DisplayName("显示命令按钮")>
		<Category("基本")>
		<DefaultValue(False)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property ShowModalButton As Boolean
			Get
				Return Me.oO.0..ShowModalButton
			End Get
			Set(value As Boolean)
				Me.oO.0..ShowModalButton = value
			End Set
		End Property

		' Token: 0x1700084C RID: 2124
		' (get) Token: 0x0600241E RID: 9246 RVA: 0x000FA50B File Offset: 0x000F870B
		' (set) Token: 0x0600241F RID: 9247 RVA: 0x000FA513 File Offset: 0x000F8713
		<MergableProperty(True)>
		<O_Oo00Oo000O0(6.0)>
		<DefaultValue(True)>
		<Category("基本")>
		<DisplayName("允许直接输入")>
		<Description("是否允许用户直接输入内容")>
		Public Property AllowEditValue As Boolean
			Get
				Return Me.o.O_OO.
			End Get
			Set(value As Boolean)
				Me.o.O_OO. = value
			End Set
		End Property

		' Token: 0x1700084D RID: 2125
		' (get) Token: 0x06002420 RID: 9248 RVA: 0x000FA51C File Offset: 0x000F871C
		' (set) Token: 0x06002421 RID: 9249 RVA: 0x000FA524 File Offset: 0x000F8724
		<oO0oooo("2109")>
		<Description("单击向上微调按钮后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property UpDownButtonClick As EventString
			Get
				Return Me.oO.0.
			End Get
			Set(value As EventString)
				Me.oO.0. = value
			End Set
		End Property

		' Token: 0x1700084E RID: 2126
		' (get) Token: 0x06002422 RID: 9250 RVA: 0x000FA52D File Offset: 0x000F872D
		' (set) Token: 0x06002423 RID: 9251 RVA: 0x000FA535 File Offset: 0x000F8735
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2110")>
		<Description("单击命令按钮后执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.3)>
		Public Property ModalButtonClick As EventString
			Get
				Return Me.OO0__.O0oO0o_o.
			End Get
			Set(value As EventString)
				Me.OO0__.O0oO0o_o. = value
			End Set
		End Property

		' Token: 0x1700084F RID: 2127
		' (get) Token: 0x06002424 RID: 9252 RVA: 0x000FA53E File Offset: 0x000F873E
		' (set) Token: 0x06002425 RID: 9253 RVA: 0x000FA541 File Offset: 0x000F8741
		<Browsable(False)>
		<OooO0(True)>
		Public Property MultiLine As Boolean
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x04000EE7 RID: 3815
		Private <<EMPTY_NAME>> As C1DropDownControl

		' Token: 0x04000EE8 RID: 3816
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000EE9 RID: 3817
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000EEA RID: 3818
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000EEB RID: 3819
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
