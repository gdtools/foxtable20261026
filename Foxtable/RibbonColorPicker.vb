Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000472 RID: 1138
	<oO0oooo("1122")>
	<OoO0___o("RibbonColorPicker")>
	Friend Class RibbonColorPicker
		Inherits RibbonSplitButton

		' Token: 0x06004C29 RID: 19497 RVA: 0x00200BB5 File Offset: 0x001FEDB5
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O_o0oO.O00o. = Color.Red
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x170010FC RID: 4348
		' (get) Token: 0x06004C2A RID: 19498 RVA: 0x00200BD1 File Offset: 0x001FEDD1
		' (set) Token: 0x06004C2B RID: 19499 RVA: 0x00200BD9 File Offset: 0x001FEDD9
		<DisplayName("颜色")>
		<O_Oo00Oo000O0(1.2)>
		<Category("属性")>
		<DefaultValue(-65536)>
		Public Property Color As Color
			Get
				Return Me.O_o0oO.O00o.
			End Get
			Set(value As Color)
				Me.O_o0oO.O00o. = value
			End Set
		End Property

		' Token: 0x170010FD RID: 4349
		' (get) Token: 0x06004C2C RID: 19500 RVA: 0x00200BE2 File Offset: 0x001FEDE2
		' (set) Token: 0x06004C2D RID: 19501 RVA: 0x00200BEA File Offset: 0x001FEDEA
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		<Category("事件")>
		<Description("选择不同颜色后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property SelectedColorChanged As EventString
			Get
				Return Me.O_o0oO.O00o.
			End Get
			Set(value As EventString)
				Me.O_o0oO.O00o. = value
			End Set
		End Property

		' Token: 0x170010FE RID: 4350
		' (get) Token: 0x06004C2E RID: 19502 RVA: 0x00200BF3 File Offset: 0x001FEDF3
		' (set) Token: 0x06004C2F RID: 19503 RVA: 0x00200BF6 File Offset: 0x001FEDF6
		<Browsable(False)>
		Public Property Items As Hashtable
			Get
				Return Nothing
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x04001F4C RID: 8012
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001F4D RID: 8013
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
