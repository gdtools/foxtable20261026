Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003F6 RID: 1014
	Friend Class ButtonProperty
		Inherits ControlPropertyBase

		' Token: 0x06004169 RID: 16745 RVA: 0x001BFE51 File Offset: 0x001BE051
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.OO_o0_oO.0. = CType(A_0.ChildControl, C1Button)
		End Sub

		' Token: 0x17000E0F RID: 3599
		' (get) Token: 0x0600416A RID: 16746 RVA: 0x001BFE6B File Offset: 0x001BE06B
		' (set) Token: 0x0600416B RID: 16747 RVA: 0x001BFE80 File Offset: 0x001BE080
		<Category("外观")>
		<O_Oo00Oo000O0(0.0)>
		<TypeConverter(GetType(o00))>
		<DefaultValue("(default)")>
		<DisplayName("样式")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.OO_o0_oO.0.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.OO_o0_oO.0. })
				If Operators.CompareString(value, "(none)", True) = 0 Then
					If Me.OO_o0_oO.0..FlatStyle <> FlatStyle.Flat Then
						Me.OO_o0_oO.0..FlatStyle = FlatStyle.Flat
						Return
					End If
				ElseIf Me.FlatStyle <> FlatStyle.Standard Then
					Me.OO_o0_oO.0..FlatStyle = FlatStyle.Standard
				End If
			End Set
		End Property

		' Token: 0x17000E10 RID: 3600
		' (get) Token: 0x0600416C RID: 16748 RVA: 0x001BFEE4 File Offset: 0x001BE0E4
		' (set) Token: 0x0600416D RID: 16749 RVA: 0x001BFEF1 File Offset: 0x001BE0F1
		<Category("基本")>
		<DisplayName("标题")>
		<O_Oo00Oo000O0(2.0)>
		<MergableProperty(True)>
		Public Overridable Property Text As String
			Get
				Return Me.OO_o0_oO.0..Text
			End Get
			Set(value As String)
				Me.OO_o0_oO.0..Text = value
			End Set
		End Property

		' Token: 0x17000E11 RID: 3601
		' (get) Token: 0x0600416E RID: 16750 RVA: 0x001BFEFF File Offset: 0x001BE0FF
		' (set) Token: 0x0600416F RID: 16751 RVA: 0x001BFF07 File Offset: 0x001BE107
		<Browsable(False)>
		Public Property DoubleClick As EventString
			Get
				Return MyBase.DoubleClick
			End Get
			Set(value As EventString)
				MyBase.DoubleClick = value
			End Set
		End Property

		' Token: 0x17000E12 RID: 3602
		' (get) Token: 0x06004170 RID: 16752 RVA: 0x001BFF10 File Offset: 0x001BE110
		' (set) Token: 0x06004171 RID: 16753 RVA: 0x001BFF18 File Offset: 0x001BE118
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.2)>
		<DisplayName("图标")>
		<Category("外观")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		Public Property ImageFile As String
			Get
				Return Me.OO_o0_oO.0.
			End Get
			Set(value As String)
				If Operators.CompareString(Me.OO_o0_oO.0., "", True) = 0 And Operators.CompareString(value, "", True) > 0 Then
					Me.ImageAlign = ContentAlignment.MiddleLeft
				End If
				Me.OO_o0_oO.0. = value
				Me.OO_o0_oO.0..Image = OO_00oOO.GetImage(Me.OO_o0_oO.0.)
			End Set
		End Property

		' Token: 0x17000E13 RID: 3603
		' (get) Token: 0x06004172 RID: 16754 RVA: 0x001BFF70 File Offset: 0x001BE170
		' (set) Token: 0x06004173 RID: 16755 RVA: 0x001BFF7D File Offset: 0x001BE17D
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(32)>
		<DisplayName("文本位置")>
		<O_Oo00Oo000O0(3.21)>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.OO_o0_oO.0..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.OO_o0_oO.0..TextAlign = value
			End Set
		End Property

		' Token: 0x17000E14 RID: 3604
		' (get) Token: 0x06004174 RID: 16756 RVA: 0x001BFF8B File Offset: 0x001BE18B
		' (set) Token: 0x06004175 RID: 16757 RVA: 0x001BFF98 File Offset: 0x001BE198
		<DisplayName("图标位置")>
		<Category("外观")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.3)>
		<DefaultValue(16)>
		Public Property ImageAlign As ContentAlignment
			Get
				Return Me.OO_o0_oO.0..ImageAlign
			End Get
			Set(value As ContentAlignment)
				Me.OO_o0_oO.0..ImageAlign = value
			End Set
		End Property

		' Token: 0x17000E15 RID: 3605
		' (get) Token: 0x06004176 RID: 16758 RVA: 0x001BFFA6 File Offset: 0x001BE1A6
		' (set) Token: 0x06004177 RID: 16759 RVA: 0x001BFFB3 File Offset: 0x001BE1B3
		<DefaultValue(0)>
		<DisplayName("相对位置")>
		<O_Oo00Oo000O0(3.4)>
		<MergableProperty(True)>
		<Category("外观")>
		<Description("设置文本和图标的相对位置。")>
		Public Property TextImageRelation As TextImageRelation
			Get
				Return Me.OO_o0_oO.0..TextImageRelation
			End Get
			Set(value As TextImageRelation)
				Me.OO_o0_oO.0..TextImageRelation = value
			End Set
		End Property

		' Token: 0x17000E16 RID: 3606
		' (get) Token: 0x06004178 RID: 16760 RVA: 0x001BFFC4 File Offset: 0x001BE1C4
		' (set) Token: 0x06004179 RID: 16761 RVA: 0x001BFFD2 File Offset: 0x001BE1D2
		<OooO0(False)>
		<Browsable(False)>
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x17000E17 RID: 3607
		' (get) Token: 0x0600417A RID: 16762 RVA: 0x001BFFD4 File Offset: 0x001BE1D4
		' (set) Token: 0x0600417B RID: 16763 RVA: 0x001BFFE1 File Offset: 0x001BE1E1
		<OooO0(True)>
		<Browsable(False)>
		Public Property FlatStyle As FlatStyle
			Get
				Return Me.OO_o0_oO.0..FlatStyle
			End Get
			Set(value As FlatStyle)
			End Set
		End Property

		' Token: 0x17000E18 RID: 3608
		' (get) Token: 0x0600417C RID: 16764 RVA: 0x001BFFE3 File Offset: 0x001BE1E3
		' (set) Token: 0x0600417D RID: 16765 RVA: 0x001BFFF0 File Offset: 0x001BE1F0
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<Category("外观")>
		<DisplayName("背景颜色")>
		Public Overrides Property BackColor As Color
			Get
				Return Me.OO_o0_oO.0..BackColor
			End Get
			Set(value As Color)
				Me.OO_o0_oO.0..BackColor = value
			End Set
		End Property

		' Token: 0x17000E19 RID: 3609
		' (get) Token: 0x0600417E RID: 16766 RVA: 0x001BFFFE File Offset: 0x001BE1FE
		' (set) Token: 0x0600417F RID: 16767 RVA: 0x001C000B File Offset: 0x001BE20B
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("字体颜色")>
		<Category("外观")>
		Public Overrides Property ForeColor As Color
			Get
				Return Me.OO_o0_oO.0..ForeColor
			End Get
			Set(value As Color)
				Me.OO_o0_oO.0..ForeColor = value
			End Set
		End Property

		' Token: 0x17000E1A RID: 3610
		' (get) Token: 0x06004180 RID: 16768 RVA: 0x001C0019 File Offset: 0x001BE219
		' (set) Token: 0x06004181 RID: 16769 RVA: 0x001C002B File Offset: 0x001BE22B
		<O_Oo00Oo000O0(0.2)>
		<Category("外观")>
		<MergableProperty(True)>
		<DisplayName("边框颜色")>
		<DefaultValue(0)>
		Public Property BorderColor As Color
			Get
				Return Me.OO_o0_oO.0..FlatAppearance.BorderColor
			End Get
			Set(value As Color)
				Me.OO_o0_oO.0..FlatAppearance.BorderColor = value
			End Set
		End Property

		' Token: 0x17000E1B RID: 3611
		' (get) Token: 0x06004182 RID: 16770 RVA: 0x001C003E File Offset: 0x001BE23E
		' (set) Token: 0x06004183 RID: 16771 RVA: 0x001C0050 File Offset: 0x001BE250
		<MergableProperty(True)>
		<DefaultValue(1)>
		<DisplayName("边框厚度")>
		<O_Oo00Oo000O0(0.3)>
		<Category("外观")>
		Public Property BorderSize As Integer
			Get
				Return Me.OO_o0_oO.0..FlatAppearance.BorderSize
			End Get
			Set(value As Integer)
				Me.OO_o0_oO.0..FlatAppearance.BorderSize = value
			End Set
		End Property

		' Token: 0x17000E1C RID: 3612
		' (get) Token: 0x06004184 RID: 16772 RVA: 0x001C0063 File Offset: 0x001BE263
		' (set) Token: 0x06004185 RID: 16773 RVA: 0x001C0075 File Offset: 0x001BE275
		<Category("外观")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.4)>
		<DisplayName("鼠标按下时的背景颜色")>
		Public Property MouseDownBackColor As Color
			Get
				Return Me.OO_o0_oO.0..FlatAppearance.MouseDownBackColor
			End Get
			Set(value As Color)
				Me.OO_o0_oO.0..FlatAppearance.MouseDownBackColor = value
			End Set
		End Property

		' Token: 0x17000E1D RID: 3613
		' (get) Token: 0x06004186 RID: 16774 RVA: 0x001C0088 File Offset: 0x001BE288
		' (set) Token: 0x06004187 RID: 16775 RVA: 0x001C009A File Offset: 0x001BE29A
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.5)>
		<DisplayName("鼠标经过时的背景颜色")>
		<Category("外观")>
		<DefaultValue(0)>
		Public Property MouseOverBackColor As Color
			Get
				Return Me.OO_o0_oO.0..FlatAppearance.MouseOverBackColor
			End Get
			Set(value As Color)
				Me.OO_o0_oO.0..FlatAppearance.MouseOverBackColor = value
			End Set
		End Property

		' Token: 0x04001AE3 RID: 6883
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001AE4 RID: 6884
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
