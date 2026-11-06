Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design

Namespace Foxtable
	' Token: 0x0200046E RID: 1134
	<OoO0___o("RibbonButton")>
	<oO0oooo("1102")>
	Friend Class RibbonButton
		Inherits RibbonItem

		' Token: 0x06004C01 RID: 19457 RVA: 0x00200A06 File Offset: 0x001FEC06
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x170010EA RID: 4330
		' (get) Token: 0x06004C02 RID: 19458 RVA: 0x00200A17 File Offset: 0x001FEC17
		' (set) Token: 0x06004C03 RID: 19459 RVA: 0x00200A32 File Offset: 0x001FEC32
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		<DisplayName("标题")>
		Public Property Text As String
			Get
				If Me.o0o__0.OO0O. Is Nothing Then
					Me.o0o__0.OO0O. = ""
				End If
				Return Me.o0o__0.OO0O.
			End Get
			Set(value As String)
				Me.o0o__0.OO0O. = value
			End Set
		End Property

		' Token: 0x170010EB RID: 4331
		' (get) Token: 0x06004C04 RID: 19460 RVA: 0x00200A3B File Offset: 0x001FEC3B
		' (set) Token: 0x06004C05 RID: 19461 RVA: 0x00200A43 File Offset: 0x001FEC43
		<O_Oo00Oo000O0(1.3)>
		<DefaultValue(0)>
		<DisplayName("快捷键")>
		<Category("属性")>
		<Editor(GetType(ShortcutKeysEditor), GetType(UITypeEditor))>
		Public Property ShortcutKeys As Keys
			Get
				Return Me.o0o__0.OO0O.
			End Get
			Set(value As Keys)
				Me.o0o__0.OO0O. = value
			End Set
		End Property

		' Token: 0x170010EC RID: 4332
		' (get) Token: 0x06004C06 RID: 19462 RVA: 0x00200A4C File Offset: 0x001FEC4C
		' (set) Token: 0x06004C07 RID: 19463 RVA: 0x00200A54 File Offset: 0x001FEC54
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		<Category("事件")>
		<Description("单击按钮后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property Click As EventString
			Get
				Return Me.o0o__0.OO0O.
			End Get
			Set(value As EventString)
				Me.o0o__0.OO0O. = value
			End Set
		End Property

		' Token: 0x170010ED RID: 4333
		' (get) Token: 0x06004C08 RID: 19464 RVA: 0x00200A5D File Offset: 0x001FEC5D
		' (set) Token: 0x06004C09 RID: 19465 RVA: 0x00200A65 File Offset: 0x001FEC65
		<O_Oo00Oo000O0(0.2)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Browsable(False)>
		<Category("事件")>
		<Description("双击按钮后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property DoubleClick As EventString
			Get
				Return Me.ooo._0o.
			End Get
			Set(value As EventString)
				Me.ooo._0o. = value
			End Set
		End Property

		' Token: 0x04001F3B RID: 7995
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F3C RID: 7996
		Private <<EMPTY_NAME>> As Keys

		' Token: 0x04001F3D RID: 7997
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F3E RID: 7998
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
