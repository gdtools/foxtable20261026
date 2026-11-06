Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200048D RID: 1165
	<OoO0___o("RibbonToggleButton")>
	<oO0oooo("1110")>
	Friend Class RibbonToggleButton
		Inherits RibbonButton

		' Token: 0x06004D3D RID: 19773 RVA: 0x002017B2 File Offset: 0x001FF9B2
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O_._0____0OO_0. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700117A RID: 4474
		' (get) Token: 0x06004D3E RID: 19774 RVA: 0x002017CA File Offset: 0x001FF9CA
		' (set) Token: 0x06004D3F RID: 19775 RVA: 0x002017D2 File Offset: 0x001FF9D2
		<O_Oo00Oo000O0(1.2)>
		<DisplayName("按下")>
		<Description("ToggleButton有两个状态，分别是按下和按起，此属性决定按钮是否处于按下状态。")>
		<DefaultValue(False)>
		<Category("属性")>
		Public Property Pressed As Boolean
			Get
				Return Me.o_000O_o.oOo0.
			End Get
			Set(value As Boolean)
				Me.o_000O_o.oOo0. = value
			End Set
		End Property

		' Token: 0x1700117B RID: 4475
		' (get) Token: 0x06004D40 RID: 19776 RVA: 0x002017DB File Offset: 0x001FF9DB
		' (set) Token: 0x06004D41 RID: 19777 RVA: 0x002017E3 File Offset: 0x001FF9E3
		<Description("分组名相同的状态按钮，在同一时候只能有一个被按下，也就是说，按下其中一个按钮，之前被按下的按钮将自动弹起")>
		<DisplayName("所属分组名")>
		<O_Oo00Oo000O0(1.202)>
		<Category("属性")>
		Public Property GroupName As String
			Get
				Return Me.o_000O_o.oOo0.
			End Get
			Set(value As String)
				Me.o_000O_o.oOo0. = value
			End Set
		End Property

		' Token: 0x1700117C RID: 4476
		' (get) Token: 0x06004D42 RID: 19778 RVA: 0x002017EC File Offset: 0x001FF9EC
		' (set) Token: 0x06004D43 RID: 19779 RVA: 0x002017F4 File Offset: 0x001FF9F4
		<Description("按钮状态(按下或按起)改变后执行。")>
		<O_Oo00Oo000O0(1.1)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property PressedChanged As EventString
			Get
				Return Me.o_000O_o.oOo0.
			End Get
			Set(value As EventString)
				Me.o_000O_o.oOo0. = value
			End Set
		End Property

		' Token: 0x04001FB5 RID: 8117
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001FB6 RID: 8118
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001FB7 RID: 8119
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001FB8 RID: 8120
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
