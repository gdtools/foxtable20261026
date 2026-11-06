Imports System
Imports System.ComponentModel
Imports System.Data
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000465 RID: 1125
	Friend Class RibbonBase
		' Token: 0x06004B78 RID: 19320 RVA: 0x001FFB75 File Offset: 0x001FDD75
		Public Sub New(A_0 As DataRow)
			Me.o0o__0.OO0O. = A_0
			If Not A_0.IsNull("Name") Then
				Me.Name = Conversions.ToString(A_0("Name"))
			End If
		End Sub

		' Token: 0x170010A7 RID: 4263
		' (get) Token: 0x06004B79 RID: 19321 RVA: 0x001FFBA7 File Offset: 0x001FDDA7
		<Browsable(False)>
		Friend ReadOnly Property DataRow As DataRow
			Get
				Return Me.o0o__0.OO0O.
			End Get
		End Property

		' Token: 0x170010A8 RID: 4264
		' (get) Token: 0x06004B7A RID: 19322 RVA: 0x001FFBAF File Offset: 0x001FDDAF
		<Browsable(False)>
		Friend ReadOnly Property RibbonItemType As RibbonItemTypeEnum
			Get
				Return CType(Conversions.ToInteger(Me.DataRow("Type")), RibbonItemTypeEnum)
			End Get
		End Property

		' Token: 0x170010A9 RID: 4265
		' (get) Token: 0x06004B7B RID: 19323 RVA: 0x001FFBC6 File Offset: 0x001FDDC6
		' (set) Token: 0x06004B7C RID: 19324 RVA: 0x001FFBCE File Offset: 0x001FDDCE
		<Category("属性")>
		<OooO0(True)>
		<DisplayName("名称")>
		<O_Oo00Oo000O0(1.0)>
		Public Property Name As String
			Get
				Return Me.o0o__0.OO0O.
			End Get
			Set(value As String)
				Me.o0o__0.OO0O. = value
			End Set
		End Property

		' Token: 0x170010AA RID: 4266
		' (get) Token: 0x06004B7D RID: 19325 RVA: 0x001FFBD7 File Offset: 0x001FDDD7
		<DisplayName("类型")>
		<OooO0(True)>
		<Category("属性")>
		<O_Oo00Oo000O0(1.0)>
		Public ReadOnly Property Type As String
			Get
				Return RibbonBase.o0o__0.OO0O.(CType(Conversions.ToInteger(Me.o0o__0.OO0O.("Type")), RibbonItemTypeEnum))
			End Get
		End Property

		' Token: 0x06004B7E RID: 19326 RVA: 0x001FFBF4 File Offset: 0x001FDDF4
		Friend Shared Function <<EMPTY_NAME>>(A_0 As RibbonItemTypeEnum) As String
			Dim result As String
			Select Case A_0
				Case RibbonItemTypeEnum.ApplicationMenu
					result = "程序菜单"
				Case RibbonItemTypeEnum.QAT
					result = "快速访问栏"
				Case RibbonItemTypeEnum.ConfigBar
					result = "配置栏"
				Case RibbonItemTypeEnum.PaperList
					result = "纸张列表"
				Case RibbonItemTypeEnum.Tab
					result = "功能区"
				Case RibbonItemTypeEnum.WindowList
					result = "窗口列表"
				Case RibbonItemTypeEnum.Group
					result = "功能组"
				Case RibbonItemTypeEnum.ToggleGroup
					result = "状态分组栏"
				Case RibbonItemTypeEnum.ToolBar
					result = "工具栏"
				Case RibbonItemTypeEnum.Button
					result = "标准按钮"
				Case RibbonItemTypeEnum.CheckBox
					result = "检查框"
				Case RibbonItemTypeEnum.ColorPicker
					result = "颜色选取按钮"
				Case RibbonItemTypeEnum.ComboBox
					result = "组合框"
				Case RibbonItemTypeEnum.TextBox
					result = "文本框"
				Case RibbonItemTypeEnum.FontComboBox
					result = "字体选择框"
				Case RibbonItemTypeEnum.Label
					result = "标签"
				Case RibbonItemTypeEnum.MenuButton
					result = "菜单按钮"
				Case RibbonItemTypeEnum.Separator
					result = "分割条"
				Case RibbonItemTypeEnum.SplitButton
					result = "组合按钮"
				Case RibbonItemTypeEnum.ToggleButton
					result = "状态按钮"
				Case RibbonItemTypeEnum.TableViewList
					result = "视图列表"
				Case RibbonItemTypeEnum.GroupTableList
					result = "分组统计历史列表"
				Case RibbonItemTypeEnum.CrossTableList
					result = "交叉统计历史列表"
				Case RibbonItemTypeEnum.SubtotalModeList
					result = "汇总模式历史列表"
				Case RibbonItemTypeEnum.ExcelReportList
					result = "Excel报表列表"
				Case RibbonItemTypeEnum.CodeReportList
					result = "专业报表列表"
				Case RibbonItemTypeEnum.DatePicker
					result = "日期输入框"
				Case RibbonItemTypeEnum.NumericBox
					result = "数值输入框"
				Case RibbonItemTypeEnum.ProgressBar
					result = "进度条"
				Case RibbonItemTypeEnum.WordReportList
					result = "Word文章列表"
				Case RibbonItemTypeEnum.Gallery
					result = "Gallery"
				Case RibbonItemTypeEnum.GalleryItem
					result = "GalleryItem"
				Case RibbonItemTypeEnum.TimePicker
					result = "时间输入框"
				Case RibbonItemTypeEnum.TrackBar
					result = "滑动条"
				Case RibbonItemTypeEnum.TopToolBar
					result = "上工具栏"
				Case RibbonItemTypeEnum.BottomToolBar
					result = "下工具栏"
				Case RibbonItemTypeEnum.TopTab
					result = "功能区组"
				Case Else
					Select Case A_0
						Case RibbonItemTypeEnum.ContextMenu
							result = "快捷菜单"
						Case RibbonItemTypeEnum.ContextCommand
							result = "标准项目"
						Case RibbonItemTypeEnum.ContextCommandMenu
							result = "子菜单"
						Case Else
							result = ""
					End Select
			End Select
			Return result
		End Function

		' Token: 0x04001EFA RID: 7930
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001EFB RID: 7931
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
