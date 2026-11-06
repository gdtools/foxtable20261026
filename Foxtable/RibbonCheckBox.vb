Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000470 RID: 1136
	<OoO0___o("RibbonCheckBox")>
	<oO0oooo("1118")>
	Friend Class RibbonCheckBox
		Inherits RibbonButton

		' Token: 0x06004C1F RID: 19487 RVA: 0x00200B48 File Offset: 0x001FED48
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x170010F8 RID: 4344
		' (get) Token: 0x06004C20 RID: 19488 RVA: 0x00200B59 File Offset: 0x001FED59
		' (set) Token: 0x06004C21 RID: 19489 RVA: 0x00200B61 File Offset: 0x001FED61
		<DisplayName("选中")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(1.2)>
		<Category("属性")>
		Public Property Checked As Boolean
			Get
				Return Me.o0o__0.OO0O.
			End Get
			Set(value As Boolean)
				Me.o0o__0.OO0O. = value
			End Set
		End Property

		' Token: 0x170010F9 RID: 4345
		' (get) Token: 0x06004C22 RID: 19490 RVA: 0x00200B6A File Offset: 0x001FED6A
		' (set) Token: 0x06004C23 RID: 19491 RVA: 0x00200B72 File Offset: 0x001FED72
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(1.1)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Description("选中状态改变后执行。")>
		Public Property CheckedChanged As EventString
			Get
				Return Me.o0o__0.OO0O.
			End Get
			Set(value As EventString)
				Me.o0o__0.OO0O. = value
			End Set
		End Property

		' Token: 0x170010FA RID: 4346
		' (get) Token: 0x06004C24 RID: 19492 RVA: 0x00200B7B File Offset: 0x001FED7B
		' (set) Token: 0x06004C25 RID: 19493 RVA: 0x00200B7E File Offset: 0x001FED7E
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04001F49 RID: 8009
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F4A RID: 8010
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
