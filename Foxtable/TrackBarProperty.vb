Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020002B2 RID: 690
	Friend Class TrackBarProperty
		Inherits ControlPropertyBase

		' Token: 0x0600249B RID: 9371 RVA: 0x000FACAF File Offset: 0x000F8EAF
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.Oo_o0O00O.o0O. = CType(A_0.ChildControl, TrackBar)
		End Sub

		' Token: 0x17000889 RID: 2185
		' (get) Token: 0x0600249C RID: 9372 RVA: 0x000FACC9 File Offset: 0x000F8EC9
		' (set) Token: 0x0600249D RID: 9373 RVA: 0x000FACD1 File Offset: 0x000F8ED1
		<DisplayName("绑定到")>
		<O_Oo00Oo000O0(2.1)>
		<Category("基本")>
		<DefaultValue("")>
		<MergableProperty(True)>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		Public Property BindingField As String
			Get
				Return Me.Oo_o0O00O.o0O.
			End Get
			Set(value As String)
				Me.Oo_o0O00O.o0O. = value
			End Set
		End Property

		' Token: 0x1700088A RID: 2186
		' (get) Token: 0x0600249E RID: 9374 RVA: 0x000FACDA File Offset: 0x000F8EDA
		' (set) Token: 0x0600249F RID: 9375 RVA: 0x000FACE7 File Offset: 0x000F8EE7
		<Category("数据")>
		<DisplayName("最大值")>
		<O_Oo00Oo000O0(2.0)>
		<MergableProperty(True)>
		Public Property Maximum As Integer
			Get
				Return Me.Oo_o0O00O.o0O..Maximum
			End Get
			Set(value As Integer)
				Me.Oo_o0O00O.o0O..Maximum = value
			End Set
		End Property

		' Token: 0x1700088B RID: 2187
		' (get) Token: 0x060024A0 RID: 9376 RVA: 0x000FACF5 File Offset: 0x000F8EF5
		' (set) Token: 0x060024A1 RID: 9377 RVA: 0x000FAD02 File Offset: 0x000F8F02
		<MergableProperty(True)>
		<DisplayName("最小值")>
		<O_Oo00Oo000O0(3.0)>
		<Category("数据")>
		Public Property Minimum As Integer
			Get
				Return Me.Oo_o0O00O.o0O..Minimum
			End Get
			Set(value As Integer)
			End Set
		End Property

		' Token: 0x1700088C RID: 2188
		' (get) Token: 0x060024A2 RID: 9378 RVA: 0x000FAD04 File Offset: 0x000F8F04
		' (set) Token: 0x060024A3 RID: 9379 RVA: 0x000FAD11 File Offset: 0x000F8F11
		<O_Oo00Oo000O0(1.0)>
		<Category("数据")>
		<DisplayName("当前值")>
		<MergableProperty(True)>
		Public Property Value As Integer
			Get
				Return Me.Oo_o0O00O.o0O..Value
			End Get
			Set(value As Integer)
				Me.Oo_o0O00O.o0O..Value = value
			End Set
		End Property

		' Token: 0x1700088D RID: 2189
		' (get) Token: 0x060024A4 RID: 9380 RVA: 0x000FAD1F File Offset: 0x000F8F1F
		' (set) Token: 0x060024A5 RID: 9381 RVA: 0x000FAD2C File Offset: 0x000F8F2C
		<DisplayName("步进(大)")>
		<O_Oo00Oo000O0(4.0)>
		<Description("按下PageUp、PageDown时，滑块移动的位置数。")>
		<MergableProperty(True)>
		<Category("数据")>
		Public Property LargeChange As Integer
			Get
				Return Me.Oo_o0O00O.o0O..LargeChange
			End Get
			Set(value As Integer)
				Me.Oo_o0O00O.o0O..LargeChange = value
			End Set
		End Property

		' Token: 0x1700088E RID: 2190
		' (get) Token: 0x060024A6 RID: 9382 RVA: 0x000FAD3A File Offset: 0x000F8F3A
		' (set) Token: 0x060024A7 RID: 9383 RVA: 0x000FAD47 File Offset: 0x000F8F47
		<Description("按下箭头键时，滑块移动的位置数。")>
		<DisplayName("步进(小)")>
		<Category("数据")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property SmallChange As Integer
			Get
				Return Me.Oo_o0O00O.o0O..SmallChange
			End Get
			Set(value As Integer)
				Me.Oo_o0O00O.o0O..SmallChange = value
			End Set
		End Property

		' Token: 0x1700088F RID: 2191
		' (get) Token: 0x060024A8 RID: 9384 RVA: 0x000FAD55 File Offset: 0x000F8F55
		' (set) Token: 0x060024A9 RID: 9385 RVA: 0x000FAD62 File Offset: 0x000F8F62
		<O_Oo00Oo000O0(3.1)>
		<Category("外观")>
		<MergableProperty(True)>
		<DisplayName("刻度间隔")>
		Public Property TickFrequency As Integer
			Get
				Return Me.Oo_o0O00O.o0O..TickFrequency
			End Get
			Set(value As Integer)
				Me.Oo_o0O00O.o0O..TickFrequency = value
			End Set
		End Property

		' Token: 0x17000890 RID: 2192
		' (get) Token: 0x060024AA RID: 9386 RVA: 0x000FAD70 File Offset: 0x000F8F70
		' (set) Token: 0x060024AB RID: 9387 RVA: 0x000FAD7D File Offset: 0x000F8F7D
		<O_Oo00Oo000O0(3.2)>
		<Category("外观")>
		<DisplayName("刻度样式")>
		<MergableProperty(True)>
		Public Property TickStyle As TickStyle
			Get
				Return Me.Oo_o0O00O.o0O..TickStyle
			End Get
			Set(value As TickStyle)
				Me.Oo_o0O00O.o0O..TickStyle = value
			End Set
		End Property

		' Token: 0x17000891 RID: 2193
		' (get) Token: 0x060024AC RID: 9388 RVA: 0x000FAD8B File Offset: 0x000F8F8B
		' (set) Token: 0x060024AD RID: 9389 RVA: 0x000FAD98 File Offset: 0x000F8F98
		<DisplayName("方向")>
		<O_Oo00Oo000O0(3.3)>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property Orientation As Orientation
			Get
				Return Me.Oo_o0O00O.o0O..Orientation
			End Get
			Set(value As Orientation)
				If Me.Oo_o0O00O.o0O..Orientation <> value Then
					If Me.Oo_o0O00O.o0O..Orientation = Orientation.Horizontal Then
						Dim width As Integer = Me.Oo_o0O00O.o0O..Parent.Width
						Me.Oo_o0O00O.o0O..Orientation = Orientation.Vertical
						Me.Oo_o0O00O.o0O..Parent.Height = width
						Return
					End If
					Dim height As Integer = Me.Oo_o0O00O.o0O..Parent.Height
					Me.Oo_o0O00O.o0O..Orientation = Orientation.Horizontal
					Me.Oo_o0O00O.o0O..Parent.Width = height
				End If
			End Set
		End Property

		' Token: 0x17000892 RID: 2194
		' (get) Token: 0x060024AE RID: 9390 RVA: 0x000FAE1D File Offset: 0x000F901D
		' (set) Token: 0x060024AF RID: 9391 RVA: 0x000FAE25 File Offset: 0x000F9025
		<O_Oo00Oo000O0(0.1)>
		<O0O0oOO00_0OO(True)>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("移动滑块后执行。")>
		Public Property Scroll As EventString
			Get
				Return Me.Oo_o0O00O.o0O.
			End Get
			Set(value As EventString)
				Me.Oo_o0O00O.o0O. = value
			End Set
		End Property

		' Token: 0x04000F06 RID: 3846
		Private <<EMPTY_NAME>> As TrackBar

		' Token: 0x04000F07 RID: 3847
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000F08 RID: 3848
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
