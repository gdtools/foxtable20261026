Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000473 RID: 1139
	<oO0oooo("1107")>
	<OoO0___o("RibbonSplitButton")>
	Friend Class RibbonSplitButton
		Inherits RibbonDropDownItem

		' Token: 0x06004C30 RID: 19504 RVA: 0x00200BF8 File Offset: 0x001FEDF8
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x170010FF RID: 4351
		' (get) Token: 0x06004C31 RID: 19505 RVA: 0x00200C09 File Offset: 0x001FEE09
		' (set) Token: 0x06004C32 RID: 19506 RVA: 0x00200C24 File Offset: 0x001FEE24
		<Category("属性")>
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("标题")>
		Public Property Text As String
			Get
				If Me.O._oo0__0o. Is Nothing Then
					Me.O._oo0__0o. = ""
				End If
				Return Me.O._oo0__0o.
			End Get
			Set(value As String)
				Me.O._oo0__0o. = value
			End Set
		End Property

		' Token: 0x17001100 RID: 4352
		' (get) Token: 0x06004C33 RID: 19507 RVA: 0x00200C2D File Offset: 0x001FEE2D
		' (set) Token: 0x06004C34 RID: 19508 RVA: 0x00200C35 File Offset: 0x001FEE35
		<O_Oo00Oo000O0(0.1)>
		<Description("单击按钮后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property Click As EventString
			Get
				Return Me.O._oo0__0o.
			End Get
			Set(value As EventString)
				Me.O._oo0__0o. = value
			End Set
		End Property

		' Token: 0x04001F4E RID: 8014
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F4F RID: 8015
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
