Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input

Namespace Foxtable
	' Token: 0x02000404 RID: 1028
	Friend Class LabelProperty
		Inherits ControlPropertyBase

		' Token: 0x06004375 RID: 17269 RVA: 0x001C1EE1 File Offset: 0x001C00E1
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O0oo_0_.__0__. = CType(A_0.ChildControl, C1Label)
		End Sub

		' Token: 0x17000F0F RID: 3855
		' (get) Token: 0x06004376 RID: 17270 RVA: 0x001C1EFB File Offset: 0x001C00FB
		' (set) Token: 0x06004377 RID: 17271 RVA: 0x001C1F08 File Offset: 0x001C0108
		<Editor(GetType(O0_00_oo0oO_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(2.0)>
		<Category("基本")>
		<MergableProperty(True)>
		<DisplayName("文本")>
		Public Overridable Property Text As String
			Get
				Return Me.O0oo_0_.__0__..Text
			End Get
			Set(value As String)
				Me.O0oo_0_.__0__..Value = value
			End Set
		End Property

		' Token: 0x17000F10 RID: 3856
		' (get) Token: 0x06004378 RID: 17272 RVA: 0x001C1F16 File Offset: 0x001C0116
		' (set) Token: 0x06004379 RID: 17273 RVA: 0x001C1F1E File Offset: 0x001C011E
		<O_Oo00Oo000O0(10.0)>
		<Category("基本")>
		<MergableProperty(True)>
		<DisplayName("格式符号")>
		Public Property FormatString As String
			Get
				Return Me.OOOOo.oo0oO.
			End Get
			Set(value As String)
				Me.OOOOo.oo0oO. = value
			End Set
		End Property

		' Token: 0x17000F11 RID: 3857
		' (get) Token: 0x0600437A RID: 17274 RVA: 0x001C1F27 File Offset: 0x001C0127
		' (set) Token: 0x0600437B RID: 17275 RVA: 0x001C1F2F File Offset: 0x001C012F
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<DefaultValue("")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		Public Property BindingField As String
			Get
				Return Me.O0Ooo0o.0O.
			End Get
			Set(value As String)
				Me.O0Ooo0o.0O. = value
			End Set
		End Property

		' Token: 0x17000F12 RID: 3858
		' (get) Token: 0x0600437C RID: 17276 RVA: 0x001C1F38 File Offset: 0x001C0138
		' (set) Token: 0x0600437D RID: 17277 RVA: 0x001C1F4A File Offset: 0x001C014A
		<DisplayName("样式")>
		<TypeConverter(GetType(o00))>
		<O_Oo00Oo000O0(0.0)>
		<Category("外观")>
		<DefaultValue("(none)")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.O0oo_0_.__0__.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.O0oo_0_.__0__. })
			End Set
		End Property

		' Token: 0x17000F13 RID: 3859
		' (get) Token: 0x0600437E RID: 17278 RVA: 0x001C1F66 File Offset: 0x001C0166
		' (set) Token: 0x0600437F RID: 17279 RVA: 0x001C1F73 File Offset: 0x001C0173
		<DefaultValue(True)>
		<DisplayName("自动大小")>
		<Category("位置")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.1)>
		Public Property AutoSize As Boolean
			Get
				Return Me.O0oo_0_.__0__..AutoSize
			End Get
			Set(value As Boolean)
				Me.O0oo_0_.__0__..AutoSize = value
			End Set
		End Property

		' Token: 0x17000F14 RID: 3860
		' (get) Token: 0x06004380 RID: 17280 RVA: 0x001C1F81 File Offset: 0x001C0181
		' (set) Token: 0x06004381 RID: 17281 RVA: 0x001C1F8E File Offset: 0x001C018E
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.1)>
		<Category("外观")>
		<DefaultValue(0)>
		<DisplayName("边框样式")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O0oo_0_.__0__..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O0oo_0_.__0__..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000F15 RID: 3861
		' (get) Token: 0x06004382 RID: 17282 RVA: 0x001C1F9C File Offset: 0x001C019C
		' (set) Token: 0x06004383 RID: 17283 RVA: 0x001C1FA9 File Offset: 0x001C01A9
		<O_Oo00Oo000O0(3.11)>
		<MergableProperty(True)>
		<DefaultValue(-10197916)>
		<DisplayName("边框颜色")>
		<Category("外观")>
		Public Property BorderColor As Color
			Get
				Return Me.O0oo_0_.__0__..BorderColor
			End Get
			Set(value As Color)
				Me.O0oo_0_.__0__..BorderColor = value
				If Me.O0oo_0_.__0__..BorderStyle <> BorderStyle.FixedSingle Then
					Me.O0oo_0_.__0__..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x17000F16 RID: 3862
		' (get) Token: 0x06004384 RID: 17284 RVA: 0x001C1FD1 File Offset: 0x001C01D1
		' (set) Token: 0x06004385 RID: 17285 RVA: 0x001C1FDE File Offset: 0x001C01DE
		<MergableProperty(True)>
		<Category("外观")>
		<DefaultValue(1)>
		<O_Oo00Oo000O0(0.1)>
		<DisplayName("文本位置")>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.O0oo_0_.__0__..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.O0oo_0_.__0__..TextAlign = value
			End Set
		End Property

		' Token: 0x04001B96 RID: 7062
		Private <<EMPTY_NAME>> As C1Label

		' Token: 0x04001B97 RID: 7063
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B98 RID: 7064
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
