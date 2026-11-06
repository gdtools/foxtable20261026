Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000482 RID: 1154
	<OoO0___o("RibbonGroup")>
	<oO0oooo("1089")>
	Friend Class RibbonGroup
		Inherits RibbonBase

		' Token: 0x06004CEB RID: 19691 RVA: 0x0020141E File Offset: 0x001FF61E
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.o0.o00_. = True
			Me.Ooo_0_.o0. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001156 RID: 4438
		' (get) Token: 0x06004CEC RID: 19692 RVA: 0x0020143D File Offset: 0x001FF63D
		' (set) Token: 0x06004CED RID: 19693 RVA: 0x00201458 File Offset: 0x001FF658
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Text As String
			Get
				If Me.o0.o00_. Is Nothing Then
					Me.o0.o00_. = ""
				End If
				Return Me.o0.o00_.
			End Get
			Set(value As String)
				Me.o0.o00_. = value
			End Set
		End Property

		' Token: 0x17001157 RID: 4439
		' (get) Token: 0x06004CEE RID: 19694 RVA: 0x00201461 File Offset: 0x001FF661
		' (set) Token: 0x06004CEF RID: 19695 RVA: 0x00201469 File Offset: 0x001FF669
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("图标")>
		<Description("一个16*16尺寸的图标，或者对应大小的图片，该图标在分组处于收缩状态时显示。")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Category("属性")>
		Public Property Image As String
			Get
				Return Me.Ooo_0_.o0.
			End Get
			Set(value As String)
				Me.Ooo_0_.o0. = value
			End Set
		End Property

		' Token: 0x17001158 RID: 4440
		' (get) Token: 0x06004CF0 RID: 19696 RVA: 0x00201472 File Offset: 0x001FF672
		' (set) Token: 0x06004CF1 RID: 19697 RVA: 0x0020147A File Offset: 0x001FF67A
		<Category("属性")>
		<DisplayName("提示")>
		<O_Oo00Oo000O0(4.0)>
		Public Property ToolTip As String
			Get
				Return Me.OOo_.o__O_O0o_.
			End Get
			Set(value As String)
				Me.OOo_.o__O_O0o_. = value
			End Set
		End Property

		' Token: 0x17001159 RID: 4441
		' (get) Token: 0x06004CF2 RID: 19698 RVA: 0x00201483 File Offset: 0x001FF683
		' (set) Token: 0x06004CF3 RID: 19699 RVA: 0x0020148B File Offset: 0x001FF68B
		<DisplayName("可用")>
		<DefaultValue(True)>
		<Category("属性")>
		<O_Oo00Oo000O0(5.0)>
		Public Property Enabled As Boolean
			Get
				Return Me.o0.o00_.
			End Get
			Set(value As Boolean)
				Me.o0.o00_. = value
			End Set
		End Property

		' Token: 0x1700115A RID: 4442
		' (get) Token: 0x06004CF4 RID: 19700 RVA: 0x00201494 File Offset: 0x001FF694
		' (set) Token: 0x06004CF5 RID: 19701 RVA: 0x0020149C File Offset: 0x001FF69C
		<DefaultValue(True)>
		<Category("属性")>
		<O_Oo00Oo000O0(6.0)>
		<DisplayName("可见")>
		Public Property Visible As Boolean
			Get
				Return Me.Ooo_0_.o0.
			End Get
			Set(value As Boolean)
				Me.Ooo_0_.o0. = value
			End Set
		End Property

		' Token: 0x1700115B RID: 4443
		' (get) Token: 0x06004CF6 RID: 19702 RVA: 0x002014A5 File Offset: 0x001FF6A5
		' (set) Token: 0x06004CF7 RID: 19703 RVA: 0x002014AC File Offset: 0x001FF6AC
		<DisplayName("项目")>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(7.0)>
		<Category("属性")>
		Public Property Items As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x1700115C RID: 4444
		' (get) Token: 0x06004CF8 RID: 19704 RVA: 0x002014AE File Offset: 0x001FF6AE
		' (set) Token: 0x06004CF9 RID: 19705 RVA: 0x002014B6 File Offset: 0x001FF6B6
		<Category("属性")>
		<O_Oo00Oo000O0(9.0)>
		<DisplayName("显示对话按钮")>
		Public Property HasLauncherButton As Boolean
			Get
				Return Me.OOo_.o__O_O0o_.
			End Get
			Set(value As Boolean)
				Me.OOo_.o__O_O0o_. = value
			End Set
		End Property

		' Token: 0x1700115D RID: 4445
		' (get) Token: 0x06004CFA RID: 19706 RVA: 0x002014BF File Offset: 0x001FF6BF
		' (set) Token: 0x06004CFB RID: 19707 RVA: 0x002014C7 File Offset: 0x001FF6C7
		<Category("事件")>
		<O_Oo00Oo000O0(0.1)>
		<Description("单击对话按钮后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property DialogLauncherClick As EventString
			Get
				Return Me.o0.o00_.
			End Get
			Set(value As EventString)
				Me.o0.o00_. = value
			End Set
		End Property

		' Token: 0x1700115E RID: 4446
		' (get) Token: 0x06004CFC RID: 19708 RVA: 0x002014D0 File Offset: 0x001FF6D0
		' (set) Token: 0x06004CFD RID: 19709 RVA: 0x002014D8 File Offset: 0x001FF6D8
		<Description("鼠标进入的时候执行。")>
		<O_Oo00Oo000O0(4.0)>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property MouseEnter As EventString
			Get
				Return Me.Ooo_0_.o0.
			End Get
			Set(value As EventString)
				Me.Ooo_0_.o0. = value
			End Set
		End Property

		' Token: 0x1700115F RID: 4447
		' (get) Token: 0x06004CFE RID: 19710 RVA: 0x002014E1 File Offset: 0x001FF6E1
		' (set) Token: 0x06004CFF RID: 19711 RVA: 0x002014E9 File Offset: 0x001FF6E9
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(5.0)>
		<Category("事件")>
		<Description("鼠标离开的时候执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property MouseLeave As EventString
			Get
				Return Me.OOo_.o__O_O0o_.
			End Get
			Set(value As EventString)
				Me.OOo_.o__O_O0o_. = value
			End Set
		End Property

		' Token: 0x04001F99 RID: 8089
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F9A RID: 8090
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F9B RID: 8091
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F9C RID: 8092
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F9D RID: 8093
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F9E RID: 8094
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F9F RID: 8095
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001FA0 RID: 8096
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001FA1 RID: 8097
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
