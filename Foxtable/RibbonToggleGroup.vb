Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200048E RID: 1166
	<OoO0___o("RibbonToggleGroup")>
	<oO0oooo("1128")>
	Friend Class RibbonToggleGroup
		Inherits RibbonItemContainer

		' Token: 0x06004D44 RID: 19780 RVA: 0x002017FD File Offset: 0x001FF9FD
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700117D RID: 4477
		' (get) Token: 0x06004D45 RID: 19781 RVA: 0x0020180E File Offset: 0x001FFA0E
		' (set) Token: 0x06004D46 RID: 19782 RVA: 0x00201816 File Offset: 0x001FFA16
		<DisplayName("可单击弹起")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(1.2)>
		<Description("是否允许通过单击分组栏某一按钮，使其弹起。")>
		<Category("属性")>
		Public Property AllowAllButtonsUp As Boolean
			Get
				Return Me.o_000O_o.oOo0.
			End Get
			Set(value As Boolean)
				Me.o_000O_o.oOo0. = value
			End Set
		End Property

		' Token: 0x1700117E RID: 4478
		' (get) Token: 0x06004D47 RID: 19783 RVA: 0x0020181F File Offset: 0x001FFA1F
		' (set) Token: 0x06004D48 RID: 19784 RVA: 0x00201827 File Offset: 0x001FFA27
		<O_Oo00Oo000O0(0.01)>
		<Description("某一个状态按钮的状态改变后执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property PressedButtonChanged As EventString
			Get
				Return Me.o_000O_o.oOo0.
			End Get
			Set(value As EventString)
				Me.o_000O_o.oOo0. = value
			End Set
		End Property

		' Token: 0x04001FB9 RID: 8121
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001FBA RID: 8122
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
