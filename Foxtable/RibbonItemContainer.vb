Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200046D RID: 1133
	Friend Class RibbonItemContainer
		Inherits RibbonBase

		' Token: 0x06004BF4 RID: 19444 RVA: 0x00200991 File Offset: 0x001FEB91
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.oo_00OOO_o.0O. = True
			Me.O_0o_O.o0_O. = True
		End Sub

		' Token: 0x170010E4 RID: 4324
		' (get) Token: 0x06004BF5 RID: 19445 RVA: 0x002009A8 File Offset: 0x001FEBA8
		' (set) Token: 0x06004BF6 RID: 19446 RVA: 0x002009B0 File Offset: 0x001FEBB0
		<Category("属性")>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("提示")>
		Public Property ToolTip As String
			Get
				Return Me.oo_00OOO_o.0O.
			End Get
			Set(value As String)
				Me.oo_00OOO_o.0O. = value
			End Set
		End Property

		' Token: 0x170010E5 RID: 4325
		' (get) Token: 0x06004BF7 RID: 19447 RVA: 0x002009B9 File Offset: 0x001FEBB9
		' (set) Token: 0x06004BF8 RID: 19448 RVA: 0x002009C1 File Offset: 0x001FEBC1
		<DefaultValue(True)>
		<DisplayName("可用")>
		<O_Oo00Oo000O0(3.0)>
		<Category("属性")>
		Public Property Enabled As Boolean
			Get
				Return Me.oo_00OOO_o.0O.
			End Get
			Set(value As Boolean)
				Me.oo_00OOO_o.0O. = value
			End Set
		End Property

		' Token: 0x170010E6 RID: 4326
		' (get) Token: 0x06004BF9 RID: 19449 RVA: 0x002009CA File Offset: 0x001FEBCA
		' (set) Token: 0x06004BFA RID: 19450 RVA: 0x002009D2 File Offset: 0x001FEBD2
		<DisplayName("可见")>
		<Category("属性")>
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(True)>
		Public Property Visible As Boolean
			Get
				Return Me.O_0o_O.o0_O.
			End Get
			Set(value As Boolean)
				Me.O_0o_O.o0_O. = value
			End Set
		End Property

		' Token: 0x170010E7 RID: 4327
		' (get) Token: 0x06004BFB RID: 19451 RVA: 0x002009DB File Offset: 0x001FEBDB
		' (set) Token: 0x06004BFC RID: 19452 RVA: 0x002009E2 File Offset: 0x001FEBE2
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("项目")>
		<Category("属性")>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		Public Property Items As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x170010E8 RID: 4328
		' (get) Token: 0x06004BFD RID: 19453 RVA: 0x002009E4 File Offset: 0x001FEBE4
		' (set) Token: 0x06004BFE RID: 19454 RVA: 0x002009EC File Offset: 0x001FEBEC
		<O_Oo00Oo000O0(1.0)>
		<Category("事件")>
		<Description("鼠标进入的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property MouseEnter As EventString
			Get
				Return Me.oo_00OOO_o.0O.
			End Get
			Set(value As EventString)
				Me.oo_00OOO_o.0O. = value
			End Set
		End Property

		' Token: 0x170010E9 RID: 4329
		' (get) Token: 0x06004BFF RID: 19455 RVA: 0x002009F5 File Offset: 0x001FEBF5
		' (set) Token: 0x06004C00 RID: 19456 RVA: 0x002009FD File Offset: 0x001FEBFD
		<Category("事件")>
		<O_Oo00Oo000O0(2.0)>
		<Description("鼠标离开的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property MouseLeave As EventString
			Get
				Return Me.O_0o_O.o0_O.
			End Get
			Set(value As EventString)
				Me.O_0o_O.o0_O. = value
			End Set
		End Property

		' Token: 0x04001F36 RID: 7990
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F37 RID: 7991
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F38 RID: 7992
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F39 RID: 7993
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F3A RID: 7994
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
