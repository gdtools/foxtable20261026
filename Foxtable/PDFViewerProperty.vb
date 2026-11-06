Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x0200016A RID: 362
	Friend Class PDFViewerProperty
		Inherits ControlPropertyBase

		' Token: 0x060010D8 RID: 4312 RVA: 0x0006AAD4 File Offset: 0x00068CD4
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O00oO_00O._. = True
			Me.OO.__0oOOO_Oo. = True
			Me.O00oO_00O._. = CType(A_0.ChildControl, o_O0)
		End Sub

		' Token: 0x17000375 RID: 885
		' (get) Token: 0x060010D9 RID: 4313 RVA: 0x0006AAFC File Offset: 0x00068CFC
		' (set) Token: 0x060010DA RID: 4314 RVA: 0x0006AB04 File Offset: 0x00068D04
		<O_Oo00Oo000O0(3.0)>
		<DefaultValue(True)>
		<Description("是否显示工具栏")>
		<Category("基本")>
		<DisplayName("显示工具栏")>
		Public Property RibbonVisible As Boolean
			Get
				Return Me.O00oO_00O._.
			End Get
			Set(value As Boolean)
				Me.O00oO_00O._. = value
			End Set
		End Property

		' Token: 0x17000376 RID: 886
		' (get) Token: 0x060010DB RID: 4315 RVA: 0x0006AB0D File Offset: 0x00068D0D
		' (set) Token: 0x060010DC RID: 4316 RVA: 0x0006AB15 File Offset: 0x00068D15
		<O_Oo00Oo000O0(3.0)>
		<Description("是否显示状态栏")>
		<Category("基本")>
		<DisplayName("显示状态栏")>
		<DefaultValue(True)>
		Public Property StatusBarVisible As Boolean
			Get
				Return Me.OO.__0oOOO_Oo.
			End Get
			Set(value As Boolean)
				Me.OO.__0oOOO_Oo. = value
			End Set
		End Property

		' Token: 0x0400065F RID: 1631
		Private <<EMPTY_NAME>> As o_O0

		' Token: 0x04000660 RID: 1632
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000661 RID: 1633
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
