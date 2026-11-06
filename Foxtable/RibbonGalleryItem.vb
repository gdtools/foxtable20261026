Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200047A RID: 1146
	Friend Class RibbonGalleryItem
		Inherits RibbonBase

		' Token: 0x06004C80 RID: 19584 RVA: 0x00200F6A File Offset: 0x001FF16A
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O_oOO_.o0. = True
			Me.Ooo_0_.o0. = True
			Me.o0oO000O.OO. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001124 RID: 4388
		' (get) Token: 0x06004C81 RID: 19585 RVA: 0x00200F90 File Offset: 0x001FF190
		' (set) Token: 0x06004C82 RID: 19586 RVA: 0x00200F98 File Offset: 0x001FF198
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("标题")>
		<Category("属性")>
		Public Property Text As String
			Get
				Return Me.O_oOO_.o0.
			End Get
			Set(value As String)
				Me.O_oOO_.o0. = value
			End Set
		End Property

		' Token: 0x17001125 RID: 4389
		' (get) Token: 0x06004C83 RID: 19587 RVA: 0x00200FA1 File Offset: 0x001FF1A1
		' (set) Token: 0x06004C84 RID: 19588 RVA: 0x00200FA9 File Offset: 0x001FF1A9
		<O_Oo00Oo000O0(2.0)>
		<Description("一个32*32尺寸的图标，或者对应大小的图片。")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Category("属性")>
		<DisplayName("图标")>
		Public Property Image As String
			Get
				Return Me.OoO0O0o0O.oO0.
			End Get
			Set(value As String)
				Me.OoO0O0o0O.oO0. = value
			End Set
		End Property

		' Token: 0x17001126 RID: 4390
		' (get) Token: 0x06004C85 RID: 19589 RVA: 0x00200FB2 File Offset: 0x001FF1B2
		' (set) Token: 0x06004C86 RID: 19590 RVA: 0x00200FBA File Offset: 0x001FF1BA
		<DisplayName("提示")>
		<O_Oo00Oo000O0(5.0)>
		<Category("属性")>
		Public Property ToolTip As String
			Get
				Return Me.o0oO000O.OO.
			End Get
			Set(value As String)
				Me.o0oO000O.OO. = value
			End Set
		End Property

		' Token: 0x17001127 RID: 4391
		' (get) Token: 0x06004C87 RID: 19591 RVA: 0x00200FC3 File Offset: 0x001FF1C3
		' (set) Token: 0x06004C88 RID: 19592 RVA: 0x00200FCB File Offset: 0x001FF1CB
		<O_Oo00Oo000O0(6.0)>
		<DefaultValue(True)>
		<Category("属性")>
		<DisplayName("可用")>
		Public Property Enabled As Boolean
			Get
				Return Me.O_oOO_.o0.
			End Get
			Set(value As Boolean)
				Me.O_oOO_.o0. = value
			End Set
		End Property

		' Token: 0x17001128 RID: 4392
		' (get) Token: 0x06004C89 RID: 19593 RVA: 0x00200FD4 File Offset: 0x001FF1D4
		' (set) Token: 0x06004C8A RID: 19594 RVA: 0x00200FDC File Offset: 0x001FF1DC
		<Category("属性")>
		<O_Oo00Oo000O0(7.0)>
		<DefaultValue(True)>
		<DisplayName("可见")>
		Public Property Visible As Boolean
			Get
				Return Me.Ooo_0_.o0.
			End Get
			Set(value As Boolean)
				Me.Ooo_0_.o0. = value
			End Set
		End Property

		' Token: 0x04001F6E RID: 8046
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F6F RID: 8047
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F70 RID: 8048
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F71 RID: 8049
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F72 RID: 8050
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F73 RID: 8051
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
