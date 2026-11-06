Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000416 RID: 1046
	Friend Class TreeViewProperty
		Inherits ControlPropertyBase

		' Token: 0x060045B6 RID: 17846 RVA: 0x001C3F77 File Offset: 0x001C2177
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.oOo0O_o_.oO_o. = CType(A_0.ChildControl, TreeView)
		End Sub

		' Token: 0x17001026 RID: 4134
		' (get) Token: 0x060045B7 RID: 17847 RVA: 0x001C3F91 File Offset: 0x001C2191
		' (set) Token: 0x060045B8 RID: 17848 RVA: 0x001C3F9C File Offset: 0x001C219C
		<O_Oo00Oo000O0(3.7)>
		<Category("外观")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<DisplayName("节点高度")>
		<Description("设置节点高度，设为0表示使用默认高度。")>
		Public Property ItemHeight As Integer
			Get
				Return Me.oOo0O_o_.oO_o.
			End Get
			Set(value As Integer)
				Me.oOo0O_o_.oO_o. = value
				If value > 0 Then
					Me.oOo0O_o_.oO_o..ItemHeight = value
					Return
				End If
				Me.oOo0O_o_.oO_o..ItemHeight = CInt(Math.Ceiling(CDbl(Me.oOo0O_o_.oO_o..Font.Size) * 1.5))
			End Set
		End Property

		' Token: 0x17001027 RID: 4135
		' (get) Token: 0x060045B9 RID: 17849 RVA: 0x001C3FED File Offset: 0x001C21ED
		' (set) Token: 0x060045BA RID: 17850 RVA: 0x001C3FFA File Offset: 0x001C21FA
		<DisplayName("显示复选框")>
		<O_Oo00Oo000O0(3.2)>
		<DefaultValue(False)>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property CheckBoxes As Boolean
			Get
				Return Me.oOo0O_o_.oO_o..CheckBoxes
			End Get
			Set(value As Boolean)
				Me.oOo0O_o_.oO_o..CheckBoxes = value
				If value Then
					Me.ItemHeight = Math.Max(16, Me.ItemHeight)
				End If
			End Set
		End Property

		' Token: 0x17001028 RID: 4136
		' (get) Token: 0x060045BB RID: 17851 RVA: 0x001C401E File Offset: 0x001C221E
		' (set) Token: 0x060045BC RID: 17852 RVA: 0x001C402B File Offset: 0x001C222B
		<DefaultValue(True)>
		<O_Oo00Oo000O0(3.3)>
		<Category("外观")>
		<MergableProperty(True)>
		<DisplayName("显示加减号")>
		Public Property ShowPlusMinus As Boolean
			Get
				Return Me.oOo0O_o_.oO_o..ShowPlusMinus
			End Get
			Set(value As Boolean)
				Me.oOo0O_o_.oO_o..ShowPlusMinus = value
			End Set
		End Property

		' Token: 0x17001029 RID: 4137
		' (get) Token: 0x060045BD RID: 17853 RVA: 0x001C4039 File Offset: 0x001C2239
		' (set) Token: 0x060045BE RID: 17854 RVA: 0x001C4046 File Offset: 0x001C2246
		<DefaultValue(True)>
		<O_Oo00Oo000O0(3.4)>
		<DisplayName("显示节点连线")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property ShowLines As Boolean
			Get
				Return Me.oOo0O_o_.oO_o..ShowLines
			End Get
			Set(value As Boolean)
				Me.oOo0O_o_.oO_o..ShowLines = value
			End Set
		End Property

		' Token: 0x1700102A RID: 4138
		' (get) Token: 0x060045BF RID: 17855 RVA: 0x001C4054 File Offset: 0x001C2254
		' (set) Token: 0x060045C0 RID: 17856 RVA: 0x001C405C File Offset: 0x001C225C
		<Category("外观")>
		<O_Oo00Oo000O0(3.5)>
		<MergableProperty(True)>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<DisplayName("节点图标")>
		Public Property ImageFile As String
			Get
				Return Me.oOo0O_o_.oO_o.
			End Get
			Set(value As String)
				If Operators.CompareString(Me.oOo0O_o_.oO_o..SelectedImageKey, Me.oOo0O_o_.oO_o..ImageKey, True) = 0 AndAlso Operators.CompareString(Me.o_OoO00.O0O___., "", True) = 0 Then
					Me.oOo0O_o_.oO_o..SelectedImageKey = ""
				End If
				Me.oOo0O_o_.oO_o..ImageKey = ""
				If Operators.CompareString(Me.oOo0O_o_.oO_o., value, True) <> 0 AndAlso Operators.CompareString(Me.oOo0O_o_.oO_o., "", True) > 0 AndAlso Not oOO0oo_o0.o.O0o000_.(Me.oOo0O_o_.oO_o., Me.oOo0O_o_.oO_o..Nodes, Me.oOo0O_o_.oO_o.) Then
					Me.oOo0O_o_.oO_o..ImageList.Images.RemoveByKey(Me.ImageFile)
				End If
				Me.oOo0O_o_.oO_o. = value
				Me.SetImageKey()
			End Set
		End Property

		' Token: 0x1700102B RID: 4139
		' (get) Token: 0x060045C1 RID: 17857 RVA: 0x001C4123 File Offset: 0x001C2323
		' (set) Token: 0x060045C2 RID: 17858 RVA: 0x001C412C File Offset: 0x001C232C
		<DisplayName("选定图标")>
		<Category("外观")>
		<O_Oo00Oo000O0(3.6)>
		<Description("在选定节点处显示的图像。")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<MergableProperty(True)>
		Public Property SelectedImageFile As String
			Get
				Return Me.o_OoO00.O0O___.
			End Get
			Set(value As String)
				If Operators.CompareString(Me.oOo0O_o_.oO_o..ImageKey, Me.oOo0O_o_.oO_o..SelectedImageKey, True) = 0 AndAlso Operators.CompareString(Me.oOo0O_o_.oO_o., "", True) = 0 Then
					Me.oOo0O_o_.oO_o..ImageKey = ""
				End If
				Me.oOo0O_o_.oO_o..SelectedImageKey = ""
				If Operators.CompareString(Me.o_OoO00.O0O___., value, True) <> 0 AndAlso Operators.CompareString(Me.o_OoO00.O0O___., "", True) > 0 AndAlso Not oOO0oo_o0.o.O0o000_.(Me.oOo0O_o_.oO_o., Me.oOo0O_o_.oO_o..Nodes, Me.o_OoO00.O0O___.) Then
					Me.oOo0O_o_.oO_o..ImageList.Images.RemoveByKey(Me.SelectedImageFile)
				End If
				Me.o_OoO00.O0O___. = value
				Me.SetImageKey()
			End Set
		End Property

		' Token: 0x060045C3 RID: 17859 RVA: 0x001C41F4 File Offset: 0x001C23F4
		Private Sub SetImageKey()
			If Operators.CompareString(Me.ImageFile, "", True) > 0 OrElse Operators.CompareString(Me.SelectedImageFile, "", True) > 0 Then
				Dim imageList As ImageList
				If Me.oOo0O_o_.oO_o..ImageList Is Nothing Then
					imageList = New ImageList()
					Me.oOo0O_o_.oO_o..ImageList = imageList
				Else
					imageList = Me.oOo0O_o_.oO_o..ImageList
				End If
				If Operators.CompareString(Me.ImageFile, "", True) > 0 AndAlso Not imageList.Images.Keys.Contains(Me.ImageFile) Then
					Dim image As Image = OO_00oOO.GetImage(Me.ImageFile)
					If image IsNot Nothing Then
						imageList.Images.Add(Me.ImageFile, image)
					End If
				End If
				If Operators.CompareString(Me.SelectedImageFile, "", True) > 0 AndAlso Not imageList.Images.Keys.Contains(Me.SelectedImageFile) Then
					Dim image2 As Image = OO_00oOO.GetImage(Me.SelectedImageFile)
					If image2 IsNot Nothing Then
						imageList.Images.Add(Me.SelectedImageFile, image2)
					End If
				End If
				If Operators.CompareString(Me.ImageFile, "", True) > 0 Then
					Me.oOo0O_o_.oO_o..ImageKey = Me.ImageFile
				ElseIf Operators.CompareString(Me.SelectedImageFile, "", True) > 0 Then
					Me.oOo0O_o_.oO_o..ImageKey = Me.SelectedImageFile
				Else
					Me.oOo0O_o_.oO_o..ImageKey = String.Empty
				End If
				If Operators.CompareString(Me.SelectedImageFile, "", True) > 0 Then
					Me.oOo0O_o_.oO_o..SelectedImageKey = Me.SelectedImageFile
				ElseIf Operators.CompareString(Me.ImageFile, "", True) > 0 Then
					Me.oOo0O_o_.oO_o..SelectedImageKey = Me.ImageFile
				Else
					Me.oOo0O_o_.oO_o..SelectedImageKey = String.Empty
				End If
				If Me.oOo0O_o_.oO_o..ImageList IsNot Nothing AndAlso Me.oOo0O_o_.oO_o..ImageList.Images.Count = 0 Then
					Me.oOo0O_o_.oO_o..ImageList = Nothing
				End If
			Else
				Me.oOo0O_o_.oO_o..ImageKey = String.Empty
				Me.oOo0O_o_.oO_o..SelectedImageKey = String.Empty
				If Me.oOo0O_o_.oO_o..ImageList IsNot Nothing AndAlso Me.oOo0O_o_.oO_o..ImageList.Images.Count = 0 Then
					Me.oOo0O_o_.oO_o..ImageList = Nothing
					Return
				End If
			End If
		End Sub

		' Token: 0x1700102C RID: 4140
		' (get) Token: 0x060045C4 RID: 17860 RVA: 0x001C4435 File Offset: 0x001C2635
		' (set) Token: 0x060045C5 RID: 17861 RVA: 0x001C4447 File Offset: 0x001C2647
		<OooO0(True)>
		<DisplayName("节点名称")>
		<MergableProperty(False)>
		<Category("选定节点")>
		<O_Oo00Oo000O0(1.0)>
		Public Property NodeName As String
			Get
				Return Me.oOo0O_o_.oO_o..SelectedNode.Name
			End Get
			Set(value As String)
				Me.oOo0O_o_.oO_o..SelectedNode.Name = value
			End Set
		End Property

		' Token: 0x1700102D RID: 4141
		' (get) Token: 0x060045C6 RID: 17862 RVA: 0x001C445C File Offset: 0x001C265C
		' (set) Token: 0x060045C7 RID: 17863 RVA: 0x001C448C File Offset: 0x001C268C
		<MergableProperty(False)>
		<OooO0(True)>
		<DisplayName("节点文本")>
		<Category("选定节点")>
		<O_Oo00Oo000O0(1.8)>
		Public Property NodeText As String
			Get
				Dim result As String
				If Me.oOo0O_o_.oO_o..SelectedNode Is Nothing Then
					result = Nothing
				Else
					result = Me.oOo0O_o_.oO_o..SelectedNode.Text
				End If
				Return result
			End Get
			Set(value As String)
				If Me.oOo0O_o_.oO_o..SelectedNode IsNot Nothing Then
					Me.oOo0O_o_.oO_o..SelectedNode.Text = value
				End If
			End Set
		End Property

		' Token: 0x1700102E RID: 4142
		' (get) Token: 0x060045C8 RID: 17864 RVA: 0x001C44AC File Offset: 0x001C26AC
		' (set) Token: 0x060045C9 RID: 17865 RVA: 0x001C44BE File Offset: 0x001C26BE
		<Category("选定节点")>
		<OooO0(True)>
		<DisplayName("选中节点")>
		<MergableProperty(False)>
		<Browsable(False)>
		<O_Oo00Oo000O0(1.9)>
		Public Property NodeChecked As Boolean
			Get
				Return Me.oOo0O_o_.oO_o..SelectedNode.Checked
			End Get
			Set(value As Boolean)
				Me.oOo0O_o_.oO_o..SelectedNode.Checked = value
			End Set
		End Property

		' Token: 0x1700102F RID: 4143
		' (get) Token: 0x060045CA RID: 17866 RVA: 0x001C44D1 File Offset: 0x001C26D1
		' (set) Token: 0x060045CB RID: 17867 RVA: 0x001C44E3 File Offset: 0x001C26E3
		<OooO0(True)>
		<MergableProperty(False)>
		<DisplayName("节点提示")>
		<Category("选定节点")>
		<O_Oo00Oo000O0(2.0)>
		Public Property NodeTooltip As String
			Get
				Return Me.oOo0O_o_.oO_o..SelectedNode.ToolTipText
			End Get
			Set(value As String)
				Me.oOo0O_o_.oO_o..SelectedNode.ToolTipText = value
			End Set
		End Property

		' Token: 0x17001030 RID: 4144
		' (get) Token: 0x060045CC RID: 17868 RVA: 0x001C44F6 File Offset: 0x001C26F6
		' (set) Token: 0x060045CD RID: 17869 RVA: 0x001C450D File Offset: 0x001C270D
		<MergableProperty(False)>
		<OooO0(True)>
		<DisplayName("节点图标")>
		<Category("选定节点")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(3.0)>
		Public Property NodeImageFile As String
			Get
				Return CType(Me.oOo0O_o_.oO_o..SelectedNode, O_o__00Ooo).ImageFile
			End Get
			Set(value As String)
				CType(Me.oOo0O_o_.oO_o..SelectedNode, O_o__00Ooo).ImageFile = value
			End Set
		End Property

		' Token: 0x17001031 RID: 4145
		' (get) Token: 0x060045CE RID: 17870 RVA: 0x001C4525 File Offset: 0x001C2725
		' (set) Token: 0x060045CF RID: 17871 RVA: 0x001C453C File Offset: 0x001C273C
		<MergableProperty(False)>
		<DisplayName("选定图标")>
		<Category("选定节点")>
		<Description("节点处于选中状态时在该节点中显示的图像")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<OooO0(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property NodeSelectedImageFile As String
			Get
				Return CType(Me.oOo0O_o_.oO_o..SelectedNode, O_o__00Ooo).o0Ooo_O0oo.O__.()
			End Get
			Set(value As String)
				CType(Me.oOo0O_o_.oO_o..SelectedNode, O_o__00Ooo).O.OOO_.(value)
			End Set
		End Property

		' Token: 0x17001032 RID: 4146
		' (get) Token: 0x060045D0 RID: 17872 RVA: 0x001C4554 File Offset: 0x001C2754
		' (set) Token: 0x060045D1 RID: 17873 RVA: 0x001C4566 File Offset: 0x001C2766
		<MergableProperty(False)>
		<OooO0(True)>
		<Category("选定节点")>
		<DisplayName("背景颜色")>
		<O_Oo00Oo000O0(6.0)>
		Public Property NodeBackColor As Color
			Get
				Return Me.oOo0O_o_.oO_o..SelectedNode.BackColor
			End Get
			Set(value As Color)
				Me.oOo0O_o_.oO_o..SelectedNode.BackColor = value
			End Set
		End Property

		' Token: 0x17001033 RID: 4147
		' (get) Token: 0x060045D2 RID: 17874 RVA: 0x001C4579 File Offset: 0x001C2779
		' (set) Token: 0x060045D3 RID: 17875 RVA: 0x001C458B File Offset: 0x001C278B
		<MergableProperty(False)>
		<OooO0(True)>
		<DisplayName("字体颜色")>
		<Category("选定节点")>
		<O_Oo00Oo000O0(7.0)>
		Public Property NodeForeColor As Color
			Get
				Return Me.oOo0O_o_.oO_o..SelectedNode.ForeColor
			End Get
			Set(value As Color)
				Me.oOo0O_o_.oO_o..SelectedNode.ForeColor = value
			End Set
		End Property

		' Token: 0x17001034 RID: 4148
		' (get) Token: 0x060045D4 RID: 17876 RVA: 0x001C459E File Offset: 0x001C279E
		' (set) Token: 0x060045D5 RID: 17877 RVA: 0x001C45A6 File Offset: 0x001C27A6
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0918")>
		<Category("事件")>
		<Description("选定节点后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property AfterSelectNode As EventString
			Get
				Return Me.OO.o0o0OO.
			End Get
			Set(value As EventString)
				Me.OO.o0o0OO. = value
			End Set
		End Property

		' Token: 0x17001035 RID: 4149
		' (get) Token: 0x060045D6 RID: 17878 RVA: 0x001C45AF File Offset: 0x001C27AF
		' (set) Token: 0x060045D7 RID: 17879 RVA: 0x001C45B7 File Offset: 0x001C27B7
		<oO0oooo("0919")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("选定节点前执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property BeforeSelectNode As EventString
			Get
				Return Me.O_o0.o0oO0o_.
			End Get
			Set(value As EventString)
				Me.O_o0.o0oO0o_. = value
			End Set
		End Property

		' Token: 0x17001036 RID: 4150
		' (get) Token: 0x060045D8 RID: 17880 RVA: 0x001C45C0 File Offset: 0x001C27C0
		' (set) Token: 0x060045D9 RID: 17881 RVA: 0x001C45C8 File Offset: 0x001C27C8
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1310")>
		<Category("事件")>
		<Description("展开节点后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.3)>
		Public Property AfterExpandNode As EventString
			Get
				Return Me.o__o00o.0o.
			End Get
			Set(value As EventString)
				Me.o__o00o.0o. = value
			End Set
		End Property

		' Token: 0x17001037 RID: 4151
		' (get) Token: 0x060045DA RID: 17882 RVA: 0x001C45D1 File Offset: 0x001C27D1
		' (set) Token: 0x060045DB RID: 17883 RVA: 0x001C45D9 File Offset: 0x001C27D9
		<Description("收缩节点后执行")>
		<oO0oooo("1310")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.31)>
		Public Property AfterCollapseNode As EventString
			Get
				Return Me.O.o_000_0.
			End Get
			Set(value As EventString)
				Me.O.o_000_0. = value
			End Set
		End Property

		' Token: 0x17001038 RID: 4152
		' (get) Token: 0x060045DC RID: 17884 RVA: 0x001C45E2 File Offset: 0x001C27E2
		' (set) Token: 0x060045DD RID: 17885 RVA: 0x001C45EA File Offset: 0x001C27EA
		<Description("展开节前执行")>
		<oO0oooo("1311")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.4)>
		Public Property BeforeExpandNode As EventString
			Get
				Return Me.o_o_0.o0.
			End Get
			Set(value As EventString)
				Me.o_o_0.o0. = value
			End Set
		End Property

		' Token: 0x17001039 RID: 4153
		' (get) Token: 0x060045DE RID: 17886 RVA: 0x001C45F3 File Offset: 0x001C27F3
		' (set) Token: 0x060045DF RID: 17887 RVA: 0x001C45FB File Offset: 0x001C27FB
		<oO0oooo("1947")>
		<Category("事件")>
		<Description("改变节点复选框状态后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.41)>
		Public Property AfterCheckNode As EventString
			Get
				Return Me.Oo.OO0o.
			End Get
			Set(value As EventString)
				Me.Oo.OO0o. = value
			End Set
		End Property

		' Token: 0x1700103A RID: 4154
		' (get) Token: 0x060045E0 RID: 17888 RVA: 0x001C4604 File Offset: 0x001C2804
		' (set) Token: 0x060045E1 RID: 17889 RVA: 0x001C460C File Offset: 0x001C280C
		<oO0oooo("0885")>
		<Category("事件")>
		<Description("单击节点后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.5)>
		Public Property NodeMouseClick As EventString
			Get
				Return Me.oOo0O_o_.oO_o.
			End Get
			Set(value As EventString)
				Me.oOo0O_o_.oO_o. = value
			End Set
		End Property

		' Token: 0x1700103B RID: 4155
		' (get) Token: 0x060045E2 RID: 17890 RVA: 0x001C4615 File Offset: 0x001C2815
		' (set) Token: 0x060045E3 RID: 17891 RVA: 0x001C461D File Offset: 0x001C281D
		<oO0oooo("2396")>
		<Category("事件")>
		<Description("编辑节点标题后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.5)>
		Public Property AfterEditNode As EventString
			Get
				Return Me.o0Oo_o.__o__.
			End Get
			Set(value As EventString)
				Me.o0Oo_o.__o__. = value
			End Set
		End Property

		' Token: 0x1700103C RID: 4156
		' (get) Token: 0x060045E4 RID: 17892 RVA: 0x001C4626 File Offset: 0x001C2826
		' (set) Token: 0x060045E5 RID: 17893 RVA: 0x001C462E File Offset: 0x001C282E
		<oO0oooo("2404")>
		<Category("事件")>
		<Description("编辑节点标题前执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.5)>
		Public Property BeforeEditNode As EventString
			Get
				Return Me.o._OoOO0O_.
			End Get
			Set(value As EventString)
				Me.o._OoOO0O_. = value
			End Set
		End Property

		' Token: 0x1700103D RID: 4157
		' (get) Token: 0x060045E6 RID: 17894 RVA: 0x001C4637 File Offset: 0x001C2837
		' (set) Token: 0x060045E7 RID: 17895 RVA: 0x001C463F File Offset: 0x001C283F
		<oO0oooo("0886")>
		<Category("事件")>
		<Description("双击节点后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.6)>
		Public Property NodeMouseDoubleClick As EventString
			Get
				Return Me.o_OoO00.O0O___.
			End Get
			Set(value As EventString)
				Me.o_OoO00.O0O___. = value
			End Set
		End Property

		' Token: 0x1700103E RID: 4158
		' (get) Token: 0x060045E8 RID: 17896 RVA: 0x001C4648 File Offset: 0x001C2848
		' (set) Token: 0x060045E9 RID: 17897 RVA: 0x001C4650 File Offset: 0x001C2850
		<oO0oooo("0920")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("鼠标停留在某一节点后执行")>
		<O_Oo00Oo000O0(0.7)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property NodeMouseHover As EventString
			Get
				Return Me.o_0_.o000.
			End Get
			Set(value As EventString)
				Me.o_0_.o000. = value
			End Set
		End Property

		' Token: 0x1700103F RID: 4159
		' (get) Token: 0x060045EA RID: 17898 RVA: 0x001C465C File Offset: 0x001C285C
		' (set) Token: 0x060045EB RID: 17899 RVA: 0x001C4680 File Offset: 0x001C2880
		<Browsable(False)>
		Public Property NodesSettingString As String
			Get
				Dim result As String = Nothing
				oOO0oo_o0.O__o0o0O0O_.0.(Me.oOo0O_o_.oO_o..Nodes, result)
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) <> 0 Then
					Dim array As String() = value.Split(New Char() { vbFormFeed })
					Dim nodes As TreeNodeCollection = Me.oOo0O_o_.oO_o..Nodes
					Dim o_o__00Ooo As O_o__00Ooo = Nothing
					For Each text As String In array
						If Operators.CompareString(text, "Inner", True) = 0 Then
							nodes = o_o__00Ooo.Nodes
						ElseIf Operators.CompareString(text, "Outer", True) = 0 Then
							If nodes(0).Parent.Parent Is Nothing Then
								nodes = Me.oOo0O_o_.oO_o..Nodes
							Else
								nodes = nodes(0).Parent.Parent.Nodes
							End If
						Else
							o_o__00Ooo = New O_o__00Ooo()
							nodes.Add(o_o__00Ooo)
							o_O_o_oOoo__.OOOO_OO._oo.(New CustomTreeNodeProperty(o_o__00Ooo), text, vbTab)
						End If
					Next
				End If
			End Set
		End Property

		' Token: 0x04001C58 RID: 7256
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x04001C59 RID: 7257
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C5A RID: 7258
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C5B RID: 7259
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C5C RID: 7260
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C5D RID: 7261
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C5E RID: 7262
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C5F RID: 7263
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C60 RID: 7264
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C61 RID: 7265
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C62 RID: 7266
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C63 RID: 7267
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C64 RID: 7268
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C65 RID: 7269
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C66 RID: 7270
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
