Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports C1.C1Preview
Imports C1.Win.C1Chart
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1GanttView
Imports C1.Win.C1Gauge
Imports C1.Win.C1Input
Imports C1.Win.C1Sizer
Imports C1.Win.FlexViewer
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Web.WebView2.Core
Imports MSScriptControl
Imports O0o0.00

Namespace Foxtable.WinForm
	' Token: 0x020003B2 RID: 946
	<oO0oooo("0703")>
	<ComVisible(True)>
	Public Class Form
		' Token: 0x17000D0F RID: 3343
		' (get) Token: 0x06003BB2 RID: 15282 RVA: 0x0019A48A File Offset: 0x0019868A
		' (set) Token: 0x06003BB3 RID: 15283 RVA: 0x0019A494 File Offset: 0x00198694
		Friend Overridable Property Pane As FormPanel
			<CompilerGenerated()>
			Get
				Return Me.oO0.O_OO_OO_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FormPanel)
				Dim value2 As EventHandler = AddressOf Me.O.0o00__.
				Dim value3 As EventHandler = AddressOf Me.o_.o_oOo0O.
				Dim formPanel As FormPanel = Me.oO0.O_OO_OO_.
				If formPanel IsNot Nothing Then
					RemoveHandler formPanel.ParentChanged, value2
					RemoveHandler formPanel.SizeChanged, value3
				End If
				Me.oO0.O_OO_OO_. = value
				formPanel = Me.oO0.O_OO_OO_.
				If formPanel IsNot Nothing Then
					AddHandler formPanel.ParentChanged, value2
					AddHandler formPanel.SizeChanged, value3
				End If
			End Set
		End Property

		' Token: 0x17000D10 RID: 3344
		' (get) Token: 0x06003BB4 RID: 15284 RVA: 0x0019A4F2 File Offset: 0x001986F2
		' (set) Token: 0x06003BB5 RID: 15285 RVA: 0x0019A4FC File Offset: 0x001986FC
		Private Overridable Property Timer As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me.o_0.o0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.o0O._OOOo0.
				Dim timer As System.Windows.Forms.Timer = Me.o_0.o0.
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.o_0.o0. = value
				timer = Me.o_0.o0.
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000D11 RID: 3345
		' (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0019A53F File Offset: 0x0019873F
		' (set) Token: 0x06003BB7 RID: 15287 RVA: 0x0019A548 File Offset: 0x00198748
		Private Overridable Property sizer As C1SizerLight
			<CompilerGenerated()>
			Get
				Return Me.o_0.o0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As C1SizerLight)
				Dim c1SizerLightEventHandler As C1SizerLightEventHandler = AddressOf Me.oOOo.00O__0oO.
				Dim c1SizerLightEventHandler2 As C1SizerLightEventHandler = AddressOf Me.o0o_._0O__OoO.
				Dim c1SizerLight As C1SizerLight = Me.o_0.o0.
				If c1SizerLight IsNot Nothing Then
					c1SizerLight.ResizingControl -= c1SizerLightEventHandler
					c1SizerLight.ResizingFont -= c1SizerLightEventHandler2
				End If
				Me.o_0.o0. = value
				c1SizerLight = Me.o_0.o0.
				If c1SizerLight IsNot Nothing Then
					c1SizerLight.ResizingControl += c1SizerLightEventHandler
					c1SizerLight.ResizingFont += c1SizerLightEventHandler2
				End If
			End Set
		End Property

		' Token: 0x06003BB8 RID: 15288 RVA: 0x0019A5A8 File Offset: 0x001987A8
		Public Sub New(A_0 As DataRow, A_1 As Boolean)
			Me.O_0.O00o_00_O. = True
			Me.o_0.o0. = FormStartPosition.CenterScreen
			Me.o._oOO_o. = True
			Me.O._o_oO. = True
			Me.Oo._0O0OoOO_o0. = True
			Me.oOo.O0__0Oo0. = True
			Me.oO0.O_OO_OO_. = New PrintPageProperty()
			Me.o0_o.0_o_. = False
			Me.o_0.o0. = New Dictionary(Of Control, String)()
			Me.o_0.o0. = TabAlignment.Bottom
			Me.O_0.O00o_00_O. = New Dictionary(Of String, ToolStrip)()
			Me.OoO.0_Oo00Ooo. = Nothing
			Me.O0__OO_0.o_oo. = True
			Me.PrintAutoMoveByLine = True
			Me.PrintAutoMoveByTable = True
			Me.OoO._O_Oo00__. = "(default)"
			Me.O_o_.0o0__o0O. = A_0
			Me.oOO_0_oo.Oo0. = A_1
		End Sub

		' Token: 0x06003BB9 RID: 15289 RVA: 0x0019A64C File Offset: 0x0019884C
		Friend Shared Function <<EMPTY_NAME>>(A_0 As String) As Object
			If Form.oO0.O_OO_OO_. Is Nothing Then
				Form.oO0.O_OO_OO_. = New ScriptControlClass()
				Form.oO0.O_OO_OO_..Language = "VBScript"
				Dim text As String = O00.oO_.0o_oo_0O_.(Foxtable.My.Resources.a.O0_.o0__.(), "vb", "net")
				Form.oO0.O_OO_OO_..AddCode(text)
			End If
			Return Form.oO0.O_OO_OO_..Eval(A_0)
		End Function

		' Token: 0x06003BBA RID: 15290 RVA: 0x0019A6A4 File Offset: 0x001988A4
		Friend Sub <<EMPTY_NAME>>()
			Me.O_0.O00o_00_O. = O_O0OO.o0o.oO0.
			Me.Pane = New FormPanel()
			Me.Pane.Name = Me.Name
			AddHandler Me.Pane.ParentChanged, AddressOf Me.o_oOo_0o_.0.
			If Not Me.O_o_.0o0__o0O..IsNull("Property") Then
				Me.DockArea = 0
				o_O_o_oOoo__.OOOO_OO._oo.(Me, Conversions.ToString(Me.O_o_.0o0__o0O.("Property")), vbVerticalTab)
			End If
			Me.ooOO0__._0O. = New ControlCollection(Me, Me.Pane.Controls)
			Me.o0000o_Oo0.0_.(Me.Pane.Controls, Me.O_o_.0o0__o0O., -1)
			Me.OoO.O_.()
			If Me.oOO_0_oo.Oo0. Then
				OO_00oOO.Forms.O.o_0oOo_O00. = Me
			End If
		End Sub

		' Token: 0x06003BBB RID: 15291 RVA: 0x0019A770 File Offset: 0x00198970
		Friend Function <<EMPTY_NAME>>(A_0 As Boolean) As Assembly
			Dim text As String = Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
			Dim text2 As String = String.Concat(New String() { OO_00oOO.ProjectPath, "Bin\", o0OoOOoOOo0.oo00o.0OoO.(""), ".Form.", text, ".dll" })
			Dim result As Assembly
			If OO_00oOO.FileSys.FileExists(text2) Then
				result = Assembly.Load(File.ReadAllBytes(text2))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x17000D12 RID: 3346
		' (get) Token: 0x06003BBC RID: 15292 RVA: 0x0019A7EE File Offset: 0x001989EE
		' (set) Token: 0x06003BBD RID: 15293 RVA: 0x0019A7FB File Offset: 0x001989FB
		Friend Property PrintSettings As OoOO0ooo
			Get
				Return Me.Pane.PrintPropExtender1
			End Get
			Private Set(value As OoOO0ooo)
				Me.Pane.PrintPropExtender1 = value
			End Set
		End Property

		' Token: 0x06003BBE RID: 15294 RVA: 0x0019A80C File Offset: 0x00198A0C
		Private Sub <<EMPTY_NAME>>(A_0 As Control.ControlCollection, A_1 As DataRow, A_2 As Integer)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				For Each dataRow As DataRow In A_1.GetChildRows("Component")
					IL_23:
					num2 = 3
					Dim controlTypeEnum As ControlTypeEnum = CType(Conversions.ToInteger(dataRow("Type")), ControlTypeEnum)
					IL_38:
					num2 = 4
					Dim table As Table = Nothing
					IL_3D:
					num2 = 5
					If A_2 < 0 OrElse Conversions.ToInteger(dataRow("Page")) = A_2 Then
						IL_5A:
						num2 = 7
						Dim control As Control
						Dim control2 As Control
						Select Case controlTypeEnum
							Case ControlTypeEnum.Label
								IL_174:
								num2 = 15
								control = New OO_0o_O_O()
								IL_17E:
								num2 = 16
								CType(control, Label).AutoSize = True
								IL_18E:
								num2 = 17
								control2 = New Label(CType(control, OO_0o_O_O))
							Case ControlTypeEnum.TextBox
								IL_25A:
								num2 = 36
								control = New O0O_O0()
								IL_264:
								num2 = 37
								CType(control, O0O_O0).DataType = GetType(String)
								IL_27D:
								num2 = 38
								control2 = New TextBox(CType(control, O0O_O0))
							Case ControlTypeEnum.Button
								IL_229:
								num2 = 32
								control = New O00_O00()
								IL_233:
								num2 = 33
								CType(control, Button).ImageAlign = ContentAlignment.MiddleLeft
								IL_244:
								num2 = 34
								control2 = New Button(CType(control, C1Button))
							Case ControlTypeEnum.CheckBox
								IL_37C:
								num2 = 60
								control = New CustomCheckBox()
								IL_386:
								num2 = 61
								control2 = New CheckBox(CType(control, CustomCheckBox))
							Case ControlTypeEnum.RadioButton
								IL_39C:
								num2 = 63
								control = New oO00O0oO0o000()
								IL_3A6:
								num2 = 64
								control2 = New RadioButton(CType(control, oO00O0oO0o000))
							Case ControlTypeEnum.ComboBox
								IL_2CC:
								num2 = 44
								control = New OoOO0Oo_oo0oO()
								IL_2D6:
								num2 = 45
								control2 = New ComboBox(CType(control, OoOO0Oo_oo0oO))
							Case ControlTypeEnum.NumericComboBox
								IL_3BC:
								num2 = 66
								control = New ooOOO()
								IL_3C6:
								num2 = 67
								control2 = New NumericComboBox(CType(control, ooOOO))
							Case ControlTypeEnum.TopicBar
								IL_134:
								num2 = 9
								control = New Oo_()
								IL_13E:
								num2 = 10
								control2 = New TopicBar(CType(control, Oo_))
							Case ControlTypeEnum.DateTimePicker
								IL_3DC:
								num2 = 69
								control = New O_0oOoOo()
								IL_3E6:
								num2 = 70
								control2 = New DateTimePicker(CType(control, O_0oOoOo))
							Case ControlTypeEnum.ListBox
								IL_32C:
								num2 = 53
								control = New CustomListBox()
								IL_336:
								num2 = 54
								control2 = New ListBox(CType(control, CustomListBox))
							Case ControlTypeEnum.CheckedListBox
								IL_34C:
								num2 = 56
								control = New CustomCheckedListBox()
								IL_356:
								num2 = 57
								CType(control, CustomCheckedListBox).CheckOnClick = True
								IL_366:
								num2 = 58
								control2 = New CheckedListBox(CType(control, CustomCheckedListBox))
							Case ControlTypeEnum.GroupBox
								IL_3FC:
								num2 = 72
								control = New O0oO0o0o()
								IL_406:
								num2 = 73
								control2 = New GroupBox(CType(control, GroupBox))
							Case ControlTypeEnum.Panel
								IL_41C:
								num2 = 75
								control = New OO0o__()
								IL_426:
								num2 = 76
								control2 = New Panel(CType(control, Panel))
							Case ControlTypeEnum.SplitContainer
								IL_45D:
								num2 = 81
								control = New SplitContainer()
								IL_467:
								num2 = 82
								CType(control, SplitContainer).FixedPanel = FixedPanel.Panel1
								IL_477:
								num2 = 83
								control2 = New SplitContainer(CType(control, SplitContainer))
							Case ControlTypeEnum.PictureBox
								IL_43C:
								num2 = 78
								control = New CustomPictureBox(Me)
								IL_447:
								num2 = 79
								control2 = New PictureBox(CType(control, CustomPictureBox))
							Case ControlTypeEnum.TabControl
								IL_48D:
								num2 = 85
								control = New o_o0()
								IL_497:
								num2 = 86
								control2 = New TabControl(CType(control, C1DockingTab))
							Case ControlTypeEnum.TreeView
								IL_4AD:
								num2 = 88
								control = New O__oO_o0_o_o()
								IL_4B7:
								num2 = 89
								control2 = New TreeView(CType(control, TreeView))
							Case ControlTypeEnum.ProgressBar
								IL_54D:
								num2 = 103
								control = New o_O_O0O__()
								IL_557:
								num2 = 104
								control2 = New ProgressBar(CType(control, o_O_O0O__))
							Case ControlTypeEnum.Chart
								IL_E7A:
								num2 = 242
								control = New C1Chart()
								IL_E87:
								num2 = 243
								control2 = New Chart(CType(control, C1Chart))
								IL_E9B:
								num2 = 244
								CType(control2, Chart).Oo_0O0.oo00.()
							Case ControlTypeEnum.PictureViewer
								IL_64D:
								num2 = 127
								control = New PictureViewer()
								IL_657:
								num2 = 128
								control2 = New PictureViewer(CType(control, PictureViewer))
							Case ControlTypeEnum.FileManager
								IL_62D:
								num2 = 124
								control = New FileManager()
								IL_637:
								num2 = 125
								control2 = New FileManager(CType(control, FileManager))
							Case ControlTypeEnum.ColorLabel
								IL_209:
								num2 = 29
								control = New CustomColorLabel()
								IL_213:
								num2 = 30
								control2 = New ColorLabel(CType(control, CustomColorLabel))
							Case ControlTypeEnum.CheckedComboBox
								IL_2EC:
								num2 = 47
								control = New O0oo000oO0oo_()
								IL_2F6:
								num2 = 48
								control2 = New CheckedComboBox(CType(control, O0oo000oO0oo_))
							Case ControlTypeEnum.NavBar
								IL_154:
								num2 = 12
								control = New O_OOO()
								IL_15E:
								num2 = 13
								control2 = New NavBar(CType(control, O_OOO))
							Case ControlTypeEnum.DataList, ControlTypeEnum.QRCode1, ControlTypeEnum.FullPath
								GoTo IL_1CE7
							Case ControlTypeEnum.WebBrowser
								IL_58D:
								num2 = 109
								control = New OOO0_()
								IL_597:
								num2 = 110
								control2 = New WebBrowser(CType(control, OOO0_))
							Case ControlTypeEnum.Painter
								IL_5AD:
								num2 = 112
								control = New O_oo()
								IL_5B7:
								num2 = 113
								control2 = New Painter(CType(control, O_oo))
							Case ControlTypeEnum.Line
								IL_1E9:
								num2 = 26
								control = New LineControl()
								IL_1F3:
								num2 = 27
								control2 = New Line(CType(control, LineControl))
							Case ControlTypeEnum.BarCode
								IL_60D:
								num2 = 121
								control = New OOo00o_0o0_()
								IL_617:
								num2 = 122
								control2 = New BarCode(CType(control, OOo00o_0o0_))
							Case ControlTypeEnum.DropDownBox
								IL_30C:
								num2 = 50
								control = New OooO00O()
								IL_316:
								num2 = 51
								control2 = New DropDownBox(CType(control, OooO00O))
							Case ControlTypeEnum.Calendar
								IL_1A4:
								num2 = 19
								control = New MonthCalendar()
								IL_1AE:
								num2 = 20
								Dim monthCalendar As MonthCalendar = CType(control, MonthCalendar)
								IL_1BA:
								num2 = 21
								monthCalendar.FirstDayOfWeek = Day.Monday
								IL_1C5:
								num2 = 22
								monthCalendar.MaxSelectionCount = 1
								IL_1D0:
								monthCalendar = Nothing
								IL_1D3:
								num2 = 24
								control2 = New Calendar(CType(control, MonthCalendar))
							Case ControlTypeEnum.TrackBar
								IL_56D:
								num2 = 106
								control = New OoOoo00()
								IL_577:
								num2 = 107
								control2 = New TrackBar(CType(control, OoOoo00))
							Case ControlTypeEnum.RecordGrid
								IL_670:
								num2 = 130
								control = New OooOo0___oO()
								IL_67D:
								num2 = 131
								control2 = New RecordGrid(CType(control, OooOo0___oO))
							Case ControlTypeEnum.TimeSpanBox
								IL_293:
								num2 = 40
								control = New o__0OoO_()
								IL_29D:
								num2 = 41
								CType(control, o__0OoO_).DataType = GetType(String)
								IL_2B6:
								num2 = 42
								control2 = New TimeSpanBox(CType(control, o__0OoO_))
							Case ControlTypeEnum.ListView
								IL_F1C:
								num2 = 255
								control = New o_OO_oOOO0o()
								IL_F29:
								num2 = 256
								control2 = New ListView(CType(control, o_OO_oOOO0o))
							Case ControlTypeEnum.FilterTree
								IL_4CD:
								num2 = 91
								control = New o_o0ooOooO()
								IL_4D7:
								num2 = 92
								control2 = New FilterTree(CType(control, o_o0ooOooO))
							Case ControlTypeEnum.LoadTree
								IL_4ED:
								num2 = 94
								control = New o_0()
								IL_4F7:
								num2 = 95
								control2 = New LoadTree(CType(control, o_0))
							Case ControlTypeEnum.InlineTree
								IL_50D:
								num2 = 97
								control = New oo__()
								IL_517:
								num2 = 98
								control2 = New InlineTree(CType(control, oo__))
							Case ControlTypeEnum.LayersTree
								IL_52D:
								num2 = 100
								control = New oO_oo0Oo()
								IL_537:
								num2 = 101
								control2 = New LayersTree(CType(control, oO_oo0Oo))
							Case ControlTypeEnum.FontPicker
								IL_6BC:
								num2 = 136
								control = New O00o()
								IL_6C9:
								num2 = 137
								control2 = New FontPicker(CType(control, O00o))
							Case ControlTypeEnum.ColorPicker
								IL_696:
								num2 = 133
								control = New oOO()
								IL_6A3:
								num2 = 134
								control2 = New ColorPicker(CType(control, oOO))
							Case ControlTypeEnum.Gauges
								IL_EB2:
								num2 = 246
								control = New O0_O_0O()
								IL_EBF:
								num2 = 247
								control2 = New Gauges(CType(control, O0_O_0O))
							Case ControlTypeEnum.GanttView
								IL_ED5:
								num2 = 249
								control = New GanttView(False)
								IL_EE3:
								num2 = 250
								control2 = New GanttView(CType(control, GanttView))
							Case ControlTypeEnum.PDFViewer
								IL_5CD:
								num2 = 115
								control = New C1FlexViewer()
								IL_5D7:
								num2 = 116
								control2 = New PDFViewer(CType(control, C1FlexViewer))
							Case ControlTypeEnum.Map
								IL_EF9:
								num2 = 252
								control = New GeoMap()
								IL_F06:
								num2 = 253
								control2 = New Map(CType(control, GeoMap))
							Case ControlTypeEnum.WebViewer
								IL_5ED:
								num2 = 118
								control = New WebViewer()
								IL_5F7:
								num2 = 119
								control2 = New WebViewer(CType(control, WebViewer))
							Case Else
								If controlTypeEnum <> ControlTypeEnum.Table Then
									GoTo IL_1CE7
								End If
								IL_6E2:
								num2 = 139
								Dim tempBindingTable As TempBindingTable = ooO_0O.o_O0.O_.(dataRow)
								IL_6F1:
								num2 = 140
								Dim text As String = tempBindingTable.RelationTable
								IL_700:
								num2 = 141
								Dim isCopy As Boolean = tempBindingTable.IsCopy
								IL_70F:
								num2 = 142
								If tempBindingTable.TableType Is Nothing Then
									IL_721:
									num2 = 143
									If Not OO_00oOO.Tables.get_Contains(text) Then
										IL_738:
										num2 = 144
										Dim dataTable As DataTable = Me.O.OOo0O.()
										IL_746:
										num2 = 145
										dataTable.TableName = Me.Name + "_" + dataRow("Name").ToString()
										IL_774:
										num2 = 146
										O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable)
										IL_78B:
										num2 = 147
										OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(dataTable, Nothing, Nothing, Nothing, O_O0OO.OoO.0OO__0ooo.()))
										IL_7AA:
										num2 = 148
										OO_00oOO.DataTables(dataTable.TableName).o.0O000_.()
										IL_7C6:
										num2 = 149
										OO_00oOO.DataTables(dataTable.TableName).AddByCode = True
										IL_7E3:
										num2 = 150
										Dim a_ As O_0 = New O_0(O_O0OO.o__.O.(), dataTable)
										IL_7F7:
										num2 = 151
										Dim table2 As Table = New Table(a_)
										IL_806:
										num2 = 152
										table2.TableType = 2
										IL_814:
										num2 = 153
										control = table2.foxGrid
										IL_823:
										num2 = 154
										control2 = New Table(table2.foxGrid)
										IL_837:
										num2 = 155
										table = table2
										IL_841:
										num2 = 156
										OO_00oOO.Tables.Ooo.0OOoO_0.(table2)
									Else
										IL_858:
										num2 = 158
										If isCopy Then
											IL_865:
											num2 = 159
											If text.IndexOf(".") > 0 Then
												IL_87A:
												num2 = 160
												text = text.Substring(text.LastIndexOf(".") + 1)
											End If
											IL_897:
											num2 = 161
											Dim a_2 As O_0 = New O_0(O_O0OO.OOOo.oo_OOOO_0.().Tables(text), Me.Name + "_" + dataRow("Name").ToString())
											IL_8D6:
											num2 = 162
											Dim table3 As Table = New Table(a_2)
											IL_8E5:
											num2 = 163
											control = table3.foxGrid
											IL_8F4:
											num2 = 164
											control2 = New Table(table3.foxGrid)
											IL_908:
											num2 = 165
											table = table3
											IL_912:
											num2 = 166
											OO_00oOO.Tables.Ooo.0OOoO_0.(table3)
											IL_924:
											num2 = 167
											Dim enumerator As IEnumerator = OO_00oOO.Tables(text).foxGrid.Styles.GetEnumerator()
											While enumerator.MoveNext()
												Dim obj As Object = enumerator.Current
												Dim cellStyle As CellStyle = CType(obj, CellStyle)
												IL_957:
												num2 = 168
												If Not table3.foxGrid.Styles.Contains(cellStyle.Name) Then
													IL_977:
													num2 = 169
													table3.foxGrid.Styles.Add(cellStyle.Name, cellStyle)
												Else
													IL_99A:
													num2 = 171
													table3.foxGrid.Styles(cellStyle.Name).MergeWith(cellStyle)
												End If
												IL_9BF:
												num2 = 172
											End While
											IL_9D1:
											num2 = 173
											If TypeOf enumerator Is IDisposable Then
												TryCast(enumerator, IDisposable).Dispose()
											End If
										Else
											IL_9F4:
											num2 = 175
											table = OO_00oOO.Tables(text)
											IL_A08:
											num2 = 176
											control = OO_00oOO.Tables(text).foxGrid
											IL_A21:
											num2 = 177
											control2 = New Table(OO_00oOO.Tables(text).foxGrid)
											IL_A3F:
											num2 = 178
											If table.IsRelation Then
												IL_A51:
												num2 = 179
												Dim parent As Control = control.Parent
												While True
													IL_AA8:
													num2 = 181
													If parent Is Nothing Then
														GoTo Block_6
													End If
													IL_A62:
													num2 = 182
													If Not(TypeOf parent Is FormPanel) Then
														IL_A71:
														num2 = 184
														If TypeOf parent Is o_O0_0O0 Then
															Exit For
														End If
													End If
													IL_A99:
													num2 = 187
													parent = parent.Parent
												End While
												IL_A80:
												num2 = 185
												CType(parent, o_O0_0O0).o_o.O___0o.(control)
												Block_6:
											End If
										End If
									End If
								Else
									IL_AB7:
									num2 = 190
									Dim oleDbConnection As OleDbConnection = Nothing
									IL_AC0:
									num2 = 191
									Dim o0O As O0O = Nothing
									IL_AC9:
									num2 = 192
									Dim httpClient As HttpClient = Nothing
									IL_AD2:
									num2 = 193
									Dim a_3 As String = ""
									IL_ADF:
									num2 = 194
									text = Me.Name + "_" + dataRow("Name").ToString()
									IL_B08:
									num2 = 195
									If Operators.CompareString(tempBindingTable.Connection, "", True) > 0 Then
										IL_B23:
										num2 = 196
										If O_O0OO.O._o_.().ContainsKey(tempBindingTable.Connection) Then
											IL_B3C:
											num2 = 197
											oleDbConnection = O_O0OO.O._o_.()(tempBindingTable.Connection)
										Else
											IL_B57:
											num2 = 199
											If O_O0OO.OoO__.0oO0oo.().ContainsKey(tempBindingTable.Connection) Then
												IL_B70:
												num2 = 200
												o0O = O_O0OO.OoO__.0oO0oo.()(tempBindingTable.Connection)
											End If
										End If
									Else
										IL_B8B:
										num2 = 202
										oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
									End If
									IL_B98:
									num2 = 203
									If(oleDbConnection Is Nothing And o0O Is Nothing) OrElse Operators.CompareString(tempBindingTable.SelectString, "", True) = 0 Then
										IL_BC2:
										num2 = 204
										Dim dataTable2 As DataTable = Me.O.OOo0O.()
										IL_BD0:
										num2 = 205
										dataTable2.TableName = text
										IL_BDF:
										num2 = 206
										O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable2)
										IL_BF6:
										num2 = 207
										OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(dataTable2, Nothing, Nothing, Nothing, O_O0OO.OoO.0OO__0ooo.()))
										IL_C15:
										num2 = 208
										OO_00oOO.DataTables(text).o.0O000_.()
										IL_C2C:
										num2 = 209
										OO_00oOO.DataTables(text).AddByCode = True
										IL_C44:
										num2 = 210
										Dim a_4 As O_0 = New O_0(O_O0OO.o__.O.(), dataTable2)
										IL_C58:
										num2 = 211
										Dim table4 As Table = New Table(a_4)
										IL_C67:
										num2 = 212
										table4.TableType = 2
										IL_C75:
										num2 = 213
										control = table4.foxGrid
										IL_C84:
										num2 = 214
										control2 = New Table(table4.foxGrid)
										IL_C98:
										num2 = 215
										table = table4
										IL_CA2:
										num2 = 216
										OO_00oOO.Tables.Ooo.0OOoO_0.(table4)
									Else
										IL_CB9:
										num2 = 218
										If tempBindingTable.TableType = 1 Then
											IL_CC9:
											num2 = 219
											a_3 = "?"
										End If
										IL_CD6:
										num2 = 220
										Dim text2 As String
										If oleDbConnection IsNot Nothing Then
											IL_CE0:
											num2 = 221
											text2 = Oo00.o0_o._O_.(oleDbConnection, tempBindingTable.SelectString, False)
										Else
											IL_CFC:
											num2 = 223
											text2 = Oo00.o0_o._O_.(o0O.OO.OoO0., tempBindingTable.SelectString, False)
											IL_D18:
											num2 = 224
											httpClient = o0O.oO0_0.o.()
											IL_D27:
											num2 = 225
											httpClient.[Select] = text2
											IL_D36:
											num2 = 226
											If tempBindingTable.TableType = 1 Then
												IL_D46:
												num2 = 227
												Dim dictionary As Dictionary(Of String, String) = httpClient.FormData
												Dim key As String = "Action"
												Dim num3 As Integer = 1
												dictionary(key) = num3.ToString()
											Else
												IL_D69:
												num2 = 229
												Dim dictionary2 As Dictionary(Of String, String) = httpClient.FormData
												Dim key2 As String = "Action"
												Dim num3 As Integer = 2
												dictionary2(key2) = num3.ToString()
											End If
										End If
										IL_D8A:
										num2 = 230
										o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text2, text, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_3, True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, tempBindingTable.Connection, httpClient)
										IL_DC3:
										num2 = 231
										If Not OO_00oOO.DataTables.Contains(text) Then
											GoTo IL_1CE7
										End If
										IL_DDA:
										num2 = 233
										OO_00oOO.DataTables(text).o.0O000_.()
										IL_DF1:
										num2 = 234
										OO_00oOO.DataTables(text).AddByCode = True
										IL_E09:
										num2 = 235
										Dim table5 As Table = New Table(O_O0OO.o__.O.()(text))
										IL_E22:
										num2 = 236
										table5.TableType = tempBindingTable.TableType
										IL_E36:
										num2 = 237
										control = table5.foxGrid
										IL_E45:
										num2 = 238
										control2 = New Table(table5.foxGrid)
										IL_E59:
										num2 = 239
										table = table5
										IL_E63:
										num2 = 240
										OO_00oOO.Tables.Ooo.0OOoO_0.(table5)
									End If
								End If
						End Select
						IL_F3D:
						num2 = 260
						control.Tag = RuntimeHelpers.GetObjectValue(dataRow("key"))
						IL_F5B:
						num2 = 261
						Dim control3 As Control = control
						IL_F65:
						num2 = 262
						control3.Font = New Font(control3.Font.Name, control3.Font.Size, control3.Font.Style)
						IL_F9B:
						control3 = Nothing
						IL_F9E:
						num2 = 264
						control.ForeColor = control.ForeColor
						IL_FB2:
						num2 = 265
						A_0.Add(control)
						IL_FC0:
						num2 = 266
						If table IsNot Nothing Then
							IL_FCD:
							num2 = 267
							table.oO_o_0o._0oooo.(True)
							IL_FDB:
							num2 = 268
							Dim text3 As String = String.Concat(New String() { OO_00oOO.ProjectPath, "Bin\", o0OoOOoOOo0.oo00o.0OoO.(""), ".Table.", Conversions.ToString(dataRow("Key")), ".dll" })
							IL_102F:
							num2 = 269
							If OO_00oOO.FileSys.FileExists(text3) Then
								IL_1046:
								num2 = 270
								Dim rawAssembly As Byte() = File.ReadAllBytes(text3)
								IL_1055:
								num2 = 271
								If table.TableType IsNot Nothing OrElse table.IsCopy Then
									IL_106D:
									num2 = 272
									table.o0__OOo0._oO. = Assembly.Load(rawAssembly)
								End If
								IL_1081:
								num2 = 273
								If table.TableType IsNot Nothing Then
									IL_1090:
									num2 = 274
									table.DataTable.o_0_00_.oo0O0. = Assembly.Load(rawAssembly)
									IL_10A9:
									num2 = 275
									table.DataTable.o0O.O_0.(table.DataTable.o_0_00_.oo0O0.)
								End If
							End If
						End If
						IL_10C7:
						num2 = 276
						control2.o.__O0O. = Me
						IL_10D5:
						num2 = 277
						control2.Printable = True
						IL_10E3:
						num2 = 278
						control.Dock = DockStyle.None
						IL_10F1:
						num2 = 279
						o_O_o_oOoo__.OOOO_OO._oo.(control2, Conversions.ToString(dataRow("Property")), vbVerticalTab)
						IL_1111:
						num2 = 280
						If TypeOf control2 Is PictureViewer Then
							IL_1123:
							num2 = 281
							Dim pictureViewer As PictureViewer = CType(control2, PictureViewer)
							IL_1132:
							num2 = 282
							If pictureViewer.Remote AndAlso Operators.CompareString(pictureViewer.Host, "", True) > 0 Then
								IL_115C:
								num2 = 283
								Dim pictureViewer2 As PictureViewer = CType(control, PictureViewer)
								IL_116B:
								num2 = 284
								Dim ftpclient As FTPClient = New FTPClient()
								IL_1178:
								num2 = 285
								ftpclient.Host = pictureViewer.Host
								IL_118C:
								num2 = 286
								ftpclient.Account = pictureViewer.Account
								IL_11A0:
								num2 = 287
								ftpclient.RootDir = pictureViewer.RootDir
								IL_11B4:
								num2 = 288
								ftpclient.Password = pictureViewer.Password
								IL_11C8:
								num2 = 289
								ftpclient.UTF8 = pictureViewer.UTF8
								IL_11DC:
								num2 = 290
								ftpclient.Port = pictureViewer.Port
								IL_11F0:
								num2 = 291
								pictureViewer2.FTPclient = ftpclient
							End If
							IL_11FF:
							num2 = 292
							If Me.o_0.o0..ContainsKey(control2) Then
								IL_1217:
								num2 = 293
								Dim a_5 As String = Me.o_0.o0.(control2)
								IL_122C:
								num2 = 294
								Dim dataCol As DataCol = Oo00.ooO.ooo.(a_5)
								IL_123B:
								num2 = 295
								If dataCol IsNot Nothing Then
									IL_1245:
									num2 = 296
									dataCol.DefaultFolder = pictureViewer.FolderName
									IL_1259:
									num2 = 297
									dataCol.SourceFolder = pictureViewer.SourceFolder
									IL_126D:
									num2 = 298
									dataCol.FileFilter = pictureViewer.FileFilter
									IL_1281:
									num2 = 299
									dataCol.AutoCopyAttachFile = pictureViewer.AutoCopyAttachFile
									IL_1295:
									num2 = 300
									dataCol.AutoDeleteAttachFile = pictureViewer.AutoDeleteAttachFile
								End If
							End If
							IL_12A9:
							pictureViewer = Nothing
						End If
						IL_12AC:
						num2 = 302
						If TypeOf control2 Is FileManager Then
							IL_12BE:
							num2 = 303
							Dim fileManager As FileManager = CType(control2, FileManager)
							IL_12CD:
							num2 = 304
							If fileManager.Remote AndAlso Operators.CompareString(fileManager.Host, "", True) > 0 Then
								IL_12F7:
								num2 = 305
								Dim fileManager2 As FileManager = CType(control, FileManager)
								IL_1306:
								num2 = 306
								Dim ftpclient2 As FTPClient = New FTPClient()
								IL_1313:
								num2 = 307
								ftpclient2.Host = fileManager.Host
								IL_1327:
								num2 = 308
								ftpclient2.Account = fileManager.Account
								IL_133B:
								num2 = 309
								ftpclient2.RootDir = fileManager.RootDir
								IL_134F:
								num2 = 310
								ftpclient2.Password = fileManager.Password
								IL_1363:
								num2 = 311
								ftpclient2.UTF8 = fileManager.UTF8
								IL_1377:
								num2 = 312
								ftpclient2.Port = fileManager.Port
								IL_138B:
								num2 = 313
								fileManager2.FTPclient = ftpclient2
							End If
							IL_139A:
							num2 = 314
							If Me.o_0.o0..ContainsKey(control2) Then
								IL_13B2:
								num2 = 315
								Dim a_6 As String = Me.o_0.o0.(control2)
								IL_13C7:
								num2 = 316
								Dim dataCol2 As DataCol = Oo00.ooO.ooo.(a_6)
								IL_13D6:
								num2 = 317
								If dataCol2 IsNot Nothing Then
									IL_13E0:
									num2 = 318
									dataCol2.DefaultFolder = fileManager.FolderName
									IL_13F4:
									num2 = 319
									dataCol2.SourceFolder = fileManager.SourceFolder
									IL_1408:
									num2 = 320
									dataCol2.FileFilter = fileManager.FileFilter
									IL_141C:
									num2 = 321
									dataCol2.AutoCopyAttachFile = fileManager.AutoCopyAttachFile
									IL_1430:
									num2 = 322
									dataCol2.AutoDeleteAttachFile = fileManager.AutoDeleteAttachFile
								End If
							End If
							IL_1444:
							fileManager = Nothing
						End If
						IL_1447:
						num2 = 324
						If TypeOf control2 Is PictureBox Then
							IL_1459:
							num2 = 325
							Dim pictureBox As PictureBox = CType(control2, PictureBox)
							IL_1468:
							num2 = 326
							If pictureBox.Remote AndAlso Operators.CompareString(pictureBox.Host, "", True) > 0 Then
								IL_1492:
								num2 = 327
								Dim customPictureBox As CustomPictureBox = CType(control, CustomPictureBox)
								IL_14A1:
								num2 = 328
								Dim ftpclient3 As FTPClient = New FTPClient()
								IL_14AE:
								num2 = 329
								ftpclient3.Host = pictureBox.Host
								IL_14C2:
								num2 = 330
								ftpclient3.Account = pictureBox.Account
								IL_14D6:
								num2 = 331
								ftpclient3.Password = pictureBox.Password
								IL_14EA:
								num2 = 332
								ftpclient3.UTF8 = pictureBox.UTF8
								IL_14FE:
								num2 = 333
								ftpclient3.Port = pictureBox.Port
								IL_1512:
								num2 = 334
								customPictureBox.FTPClient = ftpclient3
							End If
							IL_1521:
							num2 = 335
							If Me.o_0.o0..ContainsKey(control2) Then
								IL_1536:
								num2 = 336
								Dim a_7 As String = Me.o_0.o0.(control2)
								IL_154B:
								num2 = 337
								Dim dataCol3 As DataCol = Oo00.ooO.ooo.(a_7)
								IL_155A:
								num2 = 338
								If dataCol3 IsNot Nothing Then
									IL_1564:
									num2 = 339
									dataCol3.DefaultFolder = pictureBox.FolderName
								End If
							End If
							IL_1578:
							pictureBox = Nothing
						End If
						IL_157B:
						num2 = 341
						Me.O.00oo_OO0O.(control, controlTypeEnum)
						IL_158B:
						num2 = 342
						If Not(TypeOf control Is CustomPictureBox) Then
							IL_159A:
							num2 = 343
							Me.Pane.ToolTip1.SetToolTip(control, control2.ToolTipText)
						End If
						IL_15B9:
						num2 = 344
						If O_O0OO.OoO.0OO__0ooo.().Relations.Count > 0 Then
							IL_15D4:
							num2 = 345
							If Operators.CompareString(Form.f, OO_00oOO.ProjectFile, True) <> 0 Then
								IL_15EF:
								num2 = 346
								Form.f = OO_00oOO.ProjectFile
								IL_15FF:
								num2 = 347
								Form.e = Form.c + "ProjectIdentify" + Form.d
								IL_161E:
								num2 = 348
								Form.a = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { Form.e, Form.e })
								IL_165D:
								num2 = 349
								If Form.a IsNot Nothing AndAlso Not Form.a.IsNull("Config") Then
									IL_1681:
									num2 = 350
									Dim text4 As String = O00.oO_.0o_oo_0O_.(Form.a("Config").ToString(), o_o_O0OO_0__.o000oOoo.0.(O_O0OO.O_O._Oo.()), O00.MD5Encrypt(O_O0OO.O_O._Oo.()))
									IL_16B6:
									num2 = 351
									Form.b = text4.Substring(0, text4.IndexOf("|"))
									IL_16D5:
									num2 = 352
									Form.a = text4.Substring(text4.IndexOf("|") + 1)
									IL_16F5:
									num2 = 353
									If Operators.CompareString(o0OoOOoOOo0.O_0_Oo_00.O.(Form.a.Substring(0, Form.a * 4), o0OoOOoOOo0.o_OOo_0.0O.(Form.b)), Form.a.Substring(Form.a * 4, 4), True) <> 0 Then
										IL_1736:
										num2 = 354
										O_O0OO.OoO.0OO__0ooo.().Relations.Clear()
									End If
								Else
									IL_174D:
									num2 = 356
									O_O0OO.OoO.0OO__0ooo.().Relations.Clear()
								End If
							End If
						End If
						IL_1762:
						num2 = 357
						If controlTypeEnum <= ControlTypeEnum.NavBar Then
							If controlTypeEnum = ControlTypeEnum.Button Then
								IL_19F6:
								num2 = 391
								CType(control, Button).UseVisualStyleBackColor = True
								GoTo IL_1CE7
							End If
							Select Case controlTypeEnum
								Case ControlTypeEnum.GroupBox, ControlTypeEnum.Panel
								Case ControlTypeEnum.SplitContainer
									IL_1816:
									num2 = 363
									Dim splitContainer As SplitContainer = CType(control, SplitContainer)
									IL_1825:
									num2 = 364
									splitContainer.SplitterDistance = CType(control2, SplitContainer).SplitterDistance2
									IL_183E:
									num2 = 365
									splitContainer.FixedPanel = CType(control2, SplitContainer).FixedPanel2
									IL_1857:
									num2 = 366
									Me.o0000o_Oo0.0_.(splitContainer.Panel1.Controls, dataRow, 1)
									IL_1872:
									num2 = 367
									Me.o0000o_Oo0.0_.(splitContainer.Panel2.Controls, dataRow, 2)
									IL_188D:
									splitContainer = Nothing
									GoTo IL_1CE7
								Case ControlTypeEnum.PictureBox
									IL_17F1:
									num2 = 361
									Me.o0000o_Oo0.0_.(CType(control, CustomPictureBox).PictureBox1.Controls, dataRow, -1)
									GoTo IL_1CE7
								Case ControlTypeEnum.TabControl
									IL_1895:
									num2 = 370
									Dim c1DockingTab As C1DockingTab = CType(control, C1DockingTab)
									IL_18A4:
									num2 = 371
									Dim num3 As Integer = c1DockingTab.TabPages.Count - 1
									For j As Integer = 0 To num3
										IL_18BF:
										num2 = 372
										Me.o0000o_Oo0.0_.(c1DockingTab.TabPages(j).Controls, dataRow, j)
										IL_18E2:
										num2 = 373
									Next
									IL_18F4:
									c1DockingTab = Nothing
									GoTo IL_1CE7
								Case Else
									If controlTypeEnum <> ControlTypeEnum.NavBar Then
										GoTo IL_1CE7
									End If
									IL_18FC:
									num2 = 376
									Dim c1NavBar As C1NavBar = CType(control, C1NavBar)
									IL_190B:
									num2 = 377
									Dim num4 As Integer = c1NavBar.Panels.Count - 1
									For k As Integer = 0 To num4
										IL_1926:
										num2 = 378
										Me.o0000o_Oo0.0_.(c1NavBar.Panels(k).Controls, dataRow, k)
										IL_1949:
										num2 = 379
									Next
									IL_195B:
									c1NavBar = Nothing
									GoTo IL_1CE7
							End Select
						ElseIf controlTypeEnum <= ControlTypeEnum.Gauges Then
							If controlTypeEnum = ControlTypeEnum.RecordGrid Then
								IL_1A0E:
								num2 = 393
								Dim oooOo0___oO As OooOo0___oO = CType(control, OooOo0___oO)
								IL_1A1D:
								num2 = 394
								oooOo0___oO.Ooo_oO._0O.()
								IL_1A2A:
								num2 = 395
								oooOo0___oO.BorderStyle = 3
								IL_1A38:
								oooOo0___oO = Nothing
								GoTo IL_1CE7
							End If
							If controlTypeEnum <> ControlTypeEnum.Gauges Then
								GoTo IL_1CE7
							End If
							IL_1A40:
							num2 = 398
							Dim c1Gauge As C1Gauge = CType(control, C1Gauge)
							IL_1A4F:
							num2 = 399
							c1Gauge.ItemClick += AddressOf Me.Oo.o__00_.
							IL_1A68:
							num2 = 400
							c1Gauge.ItemDoubleClick += AddressOf Me.o_.0_o0_O_000.
							IL_1A81:
							num2 = 401
							c1Gauge.ItemStateChanged += AddressOf Me.Oo0_OOOo.Oo.
							IL_1A9A:
							num2 = 402
							c1Gauge.ItemMouseDown += AddressOf Me.o0oo_o.OO.
							IL_1AB3:
							num2 = 403
							c1Gauge.ItemMouseUp += AddressOf Me.Oo0_OOOo.Oo.
							IL_1ACC:
							num2 = 404
							c1Gauge.ItemMouseEnter += AddressOf Me.o0oo_o.OO.
							IL_1AE5:
							num2 = 405
							c1Gauge.ItemMouseLeave += AddressOf Me.O_00.o.
							IL_1AFE:
							num2 = 406
							c1Gauge.ItemMouseMove += AddressOf Me.O_00.o.
							IL_1B17:
							c1Gauge = Nothing
							IL_1B1A:
							num2 = 408
							Dim enumerator2 As IEnumerator = CType(control, C1Gauge).Gauges.GetEnumerator()
							While enumerator2.MoveNext()
								Dim obj2 As Object = enumerator2.Current
								Dim c1GaugeBase As C1GaugeBase = CType(obj2, C1GaugeBase)
								IL_1B46:
								num2 = 409
								c1GaugeBase.PointerDragMove += AddressOf Me.o_.0_o000o.
								IL_1B5F:
								num2 = 410
								c1GaugeBase.PointerDragBegin += AddressOf Me.O.0o00__.
								IL_1B78:
								num2 = 411
								c1GaugeBase.PointerDragEnd += AddressOf Me.o_.o_oOo0O.
								IL_1B91:
								num2 = 412
								c1GaugeBase.PointerDragCancel += AddressOf Me.oO_.0_0.
								IL_1BAA:
								num2 = 413
								c1GaugeBase.ItemClick += AddressOf Me.Oo.o__00_.
								IL_1BC3:
								num2 = 414
								c1GaugeBase.ItemDoubleClick += AddressOf Me.o_.0_o0_O_000.
								IL_1BDC:
								num2 = 415
								c1GaugeBase.ItemStateChanged += AddressOf Me.Oo0_OOOo.Oo.
								IL_1BF5:
								num2 = 416
								c1GaugeBase.ItemMouseDown += AddressOf Me.o0oo_o.OO.
								IL_1C0E:
								num2 = 417
								c1GaugeBase.ItemMouseUp += AddressOf Me.Oo0_OOOo.Oo.
								IL_1C27:
								num2 = 418
								c1GaugeBase.ItemMouseEnter += AddressOf Me.o0oo_o.OO.
								IL_1C40:
								num2 = 419
								c1GaugeBase.ItemMouseLeave += AddressOf Me.O_00.o.
								IL_1C59:
								num2 = 420
								c1GaugeBase.ItemMouseMove += AddressOf Me.O_00.o.
								IL_1C72:
								num2 = 421
								c1GaugeBase.FormatLabel += AddressOf Me.O_.O__Oo.
								IL_1C8B:
								num2 = 422
								c1GaugeBase.PointerValueChanged += AddressOf Me.O_00.o.
								IL_1CA4:
								num2 = 423
							End While
							IL_1CB6:
							num2 = 424
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
							IL_1CD1:
							num2 = 425
							Me.o0000o_Oo0.0_.(control.Controls, dataRow, -1)
							GoTo IL_1CE7
						ElseIf controlTypeEnum <> ControlTypeEnum.Map Then
							If controlTypeEnum <> ControlTypeEnum.Table Then
								GoTo IL_1CE7
							End If
							IL_1963:
							num2 = 382
							Dim table6 As Table = CType(control2, Table)
							IL_1972:
							num2 = 383
							If Operators.CompareString(table6.ColumnList, "", True) > 0 Then
								IL_198D:
								num2 = 384
								table.SetColVisibleWidth(table6.ColumnList)
							End If
							IL_19A1:
							num2 = 385
							table.FocusRect = table6.FocusRect
							IL_19B5:
							num2 = 386
							If table.TableType = 2 Then
								IL_19C5:
								num2 = 387
								table.DataTable.AllowEdit = False
								GoTo IL_1CE7
							End If
							IL_19DD:
							num2 = 389
							table.AllowEdit = table6.AllowEdit
							GoTo IL_1CE7
						End If
						IL_17D6:
						num2 = 359
						Me.o0000o_Oo0.0_.(control.Controls, dataRow, -1)
					End If
					IL_1CE7:
					num2 = 427
				Next
				IL_1CFD:
				GoTo IL_23FF
				IL_1D02:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_23C0:
				GoTo IL_23F4
				IL_23C2:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_23D2:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_23C2
			End Try
			IL_23F4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_23FF:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BBF RID: 15295 RVA: 0x0019CC3C File Offset: 0x0019AE3C
		Private Function <<EMPTY_NAME>>() As DataTable
			Dim dataTable As DataTable = New DataTable()
			Dim text As String = "一二三四五六七八九十"
			Dim num As Integer = 0
			Do
				dataTable.Columns.Add("第" + Conversions.ToString(text(num)) + "列", GetType(String))
				num += 1
			Loop While num <= 9
			Dim num2 As Integer = 0
			Do
				dataTable.Rows.Add(dataTable.NewRow())
				num2 += 1
			Loop While num2 <= 9
			dataTable.AcceptChanges()
			Return dataTable
		End Function

		' Token: 0x06003BC0 RID: 15296 RVA: 0x0019CCB4 File Offset: 0x0019AEB4
		<oO0oooo("0710")>
		Public Sub Close()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.Pane Is Nothing OrElse Me.Pane.IsDisposed OrElse Me.Pane.Parent Is Nothing Then
					GoTo IL_34D
				End If
				IL_34:
				num2 = 5
				If Me.Pane.FindForm() IsNot Nothing AndAlso Me.FormStyle <> FormStyleEnum.DropDownForm Then
					GoTo IL_80
				End If
				IL_4C:
				num2 = 6
				If Me.Pane.Parent Is Nothing Then
					GoTo IL_34D
				End If
				IL_5E:
				num2 = 7
				Me.Pane.Parent.Controls.Remove(Me.Pane)
				GoTo IL_34D
				IL_80:
				num2 = 9
				Me.Pane.O00O00o_oOo.o_. = 1
				IL_8F:
				num2 = 10
				If Not Me.IsMain AndAlso Me.FormStyle <> FormStyleEnum.并列 Then
					GoTo IL_11B
				End If
				IL_A2:
				num2 = 11
				Dim formEventArgs As FormEventArgs = New FormEventArgs(Me)
				IL_AC:
				num2 = 12
				Dim a_ As String = "BeforeClose_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				IL_D0:
				num2 = 13
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formEventArgs }, False, Me.mmname, False)
				IL_F3:
				num2 = 14
				If formEventArgs.Cancel AndAlso Me.O_0.O00o_00_O. Then
					GoTo IL_34D
				End If
				IL_109:
				num2 = 17
				Me.oOO0OO0O.o0oO.()
				IL_112:
				num2 = 18
				Me.OoOO_._0.()
				IL_11B:
				num2 = 19
				If Not Me.IsMain Then
					GoTo IL_18E
				End If
				IL_126:
				num2 = 20
				If Me.Pane.FindForm() Is Main.OO_O.o. Then
					GoTo IL_153
				End If
				IL_13B:
				num2 = 21
				Me.Pane.FindForm().Close()
				GoTo IL_326
				IL_153:
				num2 = 23
				Me.Pane.Parent.Text = "主窗口"
				IL_16B:
				num2 = 24
				Me.Pane.Parent.Controls.Remove(Me.Pane)
				GoTo IL_326
				IL_18E:
				num2 = 26
				If Me.FormStyle <> FormStyleEnum.停靠 AndAlso Me.FormStyle <> FormStyleEnum.共有 Then
					GoTo IL_1DA
				End If
				IL_1A3:
				num2 = 27
				If Me.O_0.O00o_00_O. Is Nothing OrElse Me.O_0.O00o_00_O..FindForm() Is Nothing Then
					GoTo IL_1DA
				End If
				IL_1BB:
				num2 = 28
				If Not Me.O_0.O00o_00_O..AutoHiding Then
					GoTo IL_1DA
				End If
				IL_1CB:
				num2 = 29
				Me.O_0.O00o_00_O..AutoHiding = False
				IL_1DA:
				num2 = 30
				Select Case Me.FormStyle
					Case FormStyleEnum.并列
						IL_293:
						num2 = 43
						Dim parent As Control = Me.Pane.Parent
						IL_2A3:
						num2 = 44
						parent.Controls.Remove(Me.Pane)
						IL_2B8:
						num2 = 45
						parent.Parent.Controls.Remove(parent)
						IL_2CE:
						num2 = 46
						parent.Dispose()
					Case FormStyleEnum.停靠
						IL_243:
						num2 = 34
						Dim parent2 As Control = Me.Pane.Parent
						While True
							IL_287:
							num2 = 36
							If parent2 Is Nothing Then
								GoTo Block_10
							End If
							IL_255:
							num2 = 37
							If TypeOf parent2 Is o_O0_0O0 Then
								Exit For
							End If
							IL_27B:
							num2 = 40
							parent2 = parent2.Parent
						End While
						IL_261:
						num2 = 38
						CType(parent2, o_O0_0O0).o_o.O___0o.(Me.Pane)
						Block_10:
					Case FormStyleEnum.独立, FormStyleEnum.模式, FormStyleEnum.PopupForm
						IL_2DA:
						num2 = 48
						Dim form As Form = Me.Pane.FindForm()
						IL_2EA:
						num2 = 49
						If form.Visible Then
							GoTo IL_302
						End If
						IL_2F6:
						num2 = 50
						Me.O_.O__Oo.(form, Nothing)
						IL_302:
						num2 = 51
						form.Close()
						IL_30C:
						num2 = 52
						If Me.o0_o.0_o_. Then
							Exit Select
						End If
						IL_317:
						num2 = 53
						form.Controls.Clear()
					Case FormStyleEnum.共有
						IL_211:
						num2 = 32
						CType(Me.Pane.Parent.Parent, C1DockingTab).Close(CType(Me.Pane.Parent, C1DockingTabPage))
				End Select
				IL_326:
				num2 = 55
				If Me.Pane Is Nothing OrElse Me.Pane.IsDisposed Then
					GoTo IL_34D
				End If
				IL_33E:
				num2 = 57
				Me.Pane.O00O00o_oOo.o_. = 0
				IL_34D:
				GoTo IL_487
				IL_352:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_448:
				GoTo IL_47C
				IL_44A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_45A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_44A
			End Try
			IL_47C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_487:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BC1 RID: 15297 RVA: 0x0019D16C File Offset: 0x0019B36C
		Private Function <<EMPTY_NAME>>() As oo00o_
			Return New oo00o_() With { .ShowSingleTab = False, .ShowCaption = True, .Alignment = TabAlignment.Bottom, .CanCloseTabs = True, .CanAutoHide = True }
		End Function

		' Token: 0x06003BC2 RID: 15298 RVA: 0x0019D198 File Offset: 0x0019B398
		<oO0oooo("2139")>
		Public Sub OpenTo(OtherTableName As String, Optional Width As Integer = 2147483647)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Me.OooO.__. Then
					GoTo IL_A3
				End If
				IL_0D:
				num = 3
				Me.OooO.__. = True
				IL_16:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_1D:
				num = 5
				If Not Me.Opened OrElse Operators.CompareString(Me.o_o0__00._., OtherTableName, True) = 0 Then
					GoTo IL_3E
				End If
				IL_36:
				num = 6
				Me.Close()
				IL_3E:
				num = 7
				If Not OO_00oOO.Tables.get_Contains(OtherTableName) OrElse OO_00oOO.Tables(OtherTableName).TableType IsNot Nothing OrElse OO_00oOO.Tables(OtherTableName).IsCopy Then
					GoTo IL_8F
				End If
				IL_71:
				num = 8
				Dim a_ As Oo0__Oo = Main.OO_O.o..o0_o_o_0.0O.(OtherTableName)
				IL_7F:
				num = 9
				Me.ooO0O.00.(a_, Width, Integer.MaxValue)
				IL_8F:
				num = 10
				Me.OooO.__. = False
				IL_99:
				num = 11
				Me.o_o0__00._. = OtherTableName
				IL_A3:
				GoTo IL_122
				IL_A5:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_E3:
				GoTo IL_117
				IL_E5:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_F5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E5
			End Try
			IL_117:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_122:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BC3 RID: 15299 RVA: 0x0019D2E0 File Offset: 0x0019B4E0
		Public Function OpenAsync(ParamArray args As Object()) As Task
			Dim h As Form.h = Nothing
			h.a = Me
			h.a = args
			h.a = -1
			h.a = AsyncTaskMethodBuilder.Create()
			h.a.Start(Of Form.h)(h)
			Return h.a.Task
		End Function

		' Token: 0x06003BC4 RID: 15300 RVA: 0x0019D334 File Offset: 0x0019B534
		Public Sub CloseAsync()
			Dim d As Form.d = Nothing
			d.a = Me
			d.a = -1
			d.a = AsyncVoidMethodBuilder.Create()
			d.a.Start(Of Form.d)(d)
		End Sub

		' Token: 0x06003BC5 RID: 15301 RVA: 0x0019D374 File Offset: 0x0019B574
		Public Sub MoveAsync(x As Integer, y As Integer)
			Dim i As Form.i = Nothing
			i.a = Me
			i.b = x
			i.c = y
			i.a = -1
			i.a = AsyncVoidMethodBuilder.Create()
			i.a.Start(Of Form.i)(i)
		End Sub

		' Token: 0x06003BC6 RID: 15302 RVA: 0x0019D3C4 File Offset: 0x0019B5C4
		Public Sub Open(ParamArray args As Object())
			If args.Length = 0 Then
				Me.Open(Integer.MaxValue, Integer.MaxValue)
				Return
			End If
			If args.Length = 1 Then
				Me.Open(Conversions.ToInteger(args(0)), Integer.MaxValue)
				Return
			End If
			If args.Length = 2 Then
				Me.Open(Conversions.ToInteger(args(0)), Conversions.ToInteger(args(1)))
			End If
		End Sub

		' Token: 0x06003BC7 RID: 15303 RVA: 0x0019D420 File Offset: 0x0019B620
		<oO0oooo("0708")>
		Public Sub Open(Optional x As Integer = 2147483647, Optional y As Integer = 2147483647)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Me.OooO.__. Then
					GoTo IL_9F
				End If
				IL_0D:
				num = 3
				Me.OooO.__. = True
				IL_16:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_1D:
				num = 5
				If Not Me.Opened OrElse Operators.CompareString(Me.o_o0__00._., Me.TableName, True) = 0 Then
					GoTo IL_43
				End If
				IL_3B:
				num = 6
				Me.Close()
				IL_43:
				num = 7
				Dim oo0__Oo As Oo0__Oo = Main.OO_O.o..o0_o_o_0.0O.(Me.TableName)
				IL_56:
				num = 8
				If oo0__Oo IsNot Nothing OrElse OO_00oOO.MainTable Is Nothing Then
					GoTo IL_7A
				End If
				IL_62:
				num = 9
				oo0__Oo = Main.OO_O.o..o0_o_o_0.0O.(OO_00oOO.MainTable.Name)
				IL_7A:
				num = 10
				Me.ooO0O.00.(oo0__Oo, x, y)
				IL_86:
				num = 11
				Me.OooO.__. = False
				IL_90:
				num = 12
				Me.o_o0__00._. = Me.TableName
				IL_9F:
				GoTo IL_125
				IL_A4:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_E6:
				GoTo IL_11A
				IL_E8:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_F8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E8
			End Try
			IL_11A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_125:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BC8 RID: 15304 RVA: 0x0019D56C File Offset: 0x0019B76C
		Private Sub <<EMPTY_NAME>>(A_0 As Oo0__Oo, Optional A_1 As Integer = 2147483647, Optional A_2 As Integer = 2147483647)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim formStyle As FormStyleEnum = Me.FormStyle
				If formStyle > FormStyleEnum.停靠 AndAlso formStyle <> FormStyleEnum.主窗口 Then
					GoTo IL_54
				End If
				IL_11:
				num = 3
				If A_0 IsNot Nothing OrElse Operators.CompareString(Me.TableName, "", True) <= 0 Then
					GoTo IL_54
				End If
				IL_2A:
				num = 4
				MessageBox.Show("窗口[" + Me.Name + "]指定的所有者表不存在，无法打开此窗口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_E9B
				IL_54:
				num = 7
				Me.O_0.O00o_00_O. = Nothing
				IL_5D:
				num = 8
				Me.O_0.O00o_00_O. = True
				IL_66:
				num = 9
				If Me.Pane IsNot Nothing AndAlso Not Me.Pane.IsDisposed Then
					GoTo IL_87
				End If
				IL_7E:
				num = 10
				Me.o.0_o00O.()
				IL_87:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_8E:
				num = 12
				If Me.Pane.FindForm() IsNot Nothing Then
					GoTo IL_E9B
				End If
				IL_A1:
				num = 14
				If Me.FormStyle <> FormStyleEnum.DropDownForm Then
					GoTo IL_C6
				End If
				IL_AD:
				num = 15
				Me.o_oOo_0o_.0.(Me.Pane, New EventArgs())
				GoTo IL_E9B
				IL_C6:
				num = 17
				If Not Me.oOO_0_oo.Oo0. Then
					GoTo IL_DB
				End If
				IL_D1:
				num = 18
				Me.FormStyle = FormStyleEnum.模式
				IL_DB:
				num = 19
				If Me.FormStyle = FormStyleEnum.模式 Then
					GoTo IL_FA
				End If
				IL_E7:
				num = 20
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle)
				IL_FA:
				num = 21
				Me.O_o_.0o0__o0O.("Table").ToString()
				IL_113:
				num = 22
				If A_0 Is Nothing AndAlso (Me.FormStyle = FormStyleEnum.并列 OrElse Me.FormStyle = FormStyleEnum.停靠) Then
					GoTo IL_E9B
				End If
				IL_130:
				num = 24
				If Not Me.IsMain Then
					GoTo IL_30F
				End If
				IL_13E:
				num = 25
				Dim enumerator As IEnumerator(Of Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator.MoveNext()
					Dim form As Form = enumerator.Current
					IL_158:
					num = 26
					If form.IsMain AndAlso Operators.CompareString(form.TableName, Me.TableName, True) = 0 Then
						IL_179:
						num = 27
						form.Close()
					End If
					IL_183:
					num = 28
				End While
				IL_18F:
				num = 29
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_19D:
				num = 30
				Dim c1DockingTabPage As C1DockingTabPage = A_0.O_000__.o.().TabPages(0)
				IL_1B3:
				num = 31
				c1DockingTabPage.SuspendLayout()
				IL_1BD:
				num = 32
				Me.Pane.Visible = False
				IL_1CC:
				num = 33
				Me.Pane.SendToBack()
				IL_1DA:
				num = 34
				c1DockingTabPage.Controls.Add(Me.Pane)
				IL_1EF:
				num = 35
				Me.Pane.Dock = DockStyle.Fill
				IL_1FE:
				num = 36
				c1DockingTabPage.Text = Me.Text
				IL_20E:
				num = 37
				If Not OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + Me.ImageFile) Then
					GoTo IL_244
				End If
				IL_22D:
				num = 38
				c1DockingTabPage.Image = OO_00oOO.GetImage(Me.ImageFile)
				GoTo IL_24F
				IL_244:
				num = 40
				c1DockingTabPage.Image = Nothing
				IL_24F:
				num = 41
				If Not Me.Oo0Oo0000.__.() Then
					GoTo IL_2EB
				End If
				IL_25D:
				num = 42
				Me.Pane.BringToFront()
				IL_26B:
				num = 43
				Me.Pane.Visible = True
				IL_27A:
				num = 44
				For i As Integer = c1DockingTabPage.Controls.Count - 1 To 0 Step -1
					IL_28F:
					num = 45
					If c1DockingTabPage.Controls(i) IsNot Me.Pane Then
						IL_2A8:
						num = 47
						If Not(TypeOf c1DockingTabPage.Controls(i)Is o_O0_0O0) Then
							IL_2C0:
							num = 49
							c1DockingTabPage.Controls.Remove(c1DockingTabPage.Controls(i))
						End If
					End If
					IL_2DD:
					num = 50
				Next
				IL_2EB:
				num = 51
				c1DockingTabPage.ResumeLayout()
				IL_2F5:
				c1DockingTabPage = Nothing
				IL_2F8:
				num = 53
				Me.oO._0oOo.()
				IL_301:
				num = 54
				Me.Oo_O__o0o.0_.()
				GoTo IL_E5F
				IL_30F:
				num = 56
				Select Case Me.FormStyle
					Case FormStyleEnum.并列
						IL_346:
						num = 58
						If A_0.O_000__.o.().TabPages.Count <> 1 Then
							GoTo IL_3A5
						End If
						IL_35C:
						num = 59
						A_0.O_000__.o.().TextDirection = 1
						IL_36B:
						num = 60
						A_0.O_000__.o.().Alignment = Me.TabAlignment
						IL_37F:
						num = 61
						Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o00o_OO_o_._o.(), New Object() { A_0.O_000__.o.() })
						IL_3A5:
						num = 62
						Dim o0_OoOoO As O0_OoOoO = New O0_OoOoO()
						IL_3AF:
						num = 63
						o0_OoOoO.Text = Me.Text
						IL_3BF:
						num = 64
						o0_OoOoO.Controls.Add(Me.Pane)
						IL_3D4:
						num = 65
						A_0.O_000__.o.().TabPages.Add(o0_OoOoO)
						IL_3EA:
						num = 66
						If Not OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + Me.ImageFile) Then
							GoTo IL_41E
						End If
						IL_409:
						num = 67
						o0_OoOoO.Image = OO_00oOO.GetImage(Me.ImageFile)
						IL_41E:
						num = 68
						Me.Pane.Dock = DockStyle.Fill
						IL_42D:
						num = 69
						Me.o_0._O.()
						IL_436:
						num = 70
						If Not Me.Oo0Oo0000.__.() Then
							GoTo IL_E9B
						End If
						IL_444:
						num = 73
						If Me.Pane Is Nothing Then
							Exit Select
						End If
						IL_452:
						num = 74
						Me.oO._0oOo.()
						IL_45B:
						num = 75
						Me.Oo_O__o0o.0_.()
					Case FormStyleEnum.停靠
						IL_92B:
						num = 147
						Dim o_O0_0O As o_O0_0O0
						Select Case Me.DockArea
							Case 0
								IL_962:
								num = 151
								o_O0_0O = A_0.o__0_.o0OoOOO.()
								GoTo IL_990
							Case 2
								IL_952:
								num = 149
								o_O0_0O = A_0.O__O.o_oOO.()
								GoTo IL_990
							Case 3
								IL_972:
								num = 153
								o_O0_0O = A_0.O_000__.o.()
								GoTo IL_990
						End Select
						IL_982:
						num = 155
						o_O0_0O = A_0.O._o_00__.()
						IL_990:
						num = 157
						If A_1 = 2147483647 OrElse A_2 <> 2147483647 Then
							GoTo IL_9B6
						End If
						IL_9A6:
						num = 158
						o_O0_0O.OoOoo_O0o0.0O_.(A_1)
						GoTo IL_A0F
						IL_9B6:
						num = 160
						Select Case Me.DockArea
							Case 0, 2
								IL_9DD:
								num = 162
								o_O0_0O.OoOoo_O0o0.0O_.(Me.Pane.Width)
							Case 1, 3
								IL_9F7:
								num = 164
								o_O0_0O.OoOoo_O0o0.0O_.(Me.Pane.Height)
						End Select
						IL_A0F:
						num = 166
						Dim c1DockingTabPage2 As C1DockingTabPage = o_O0_0O.OO_o0_oO.0.(Me.Pane, Me.Text, Me.DockTitle, OO_00oOO.GetImage(Me.ImageFile), Nothing, False)
						IL_A3D:
						num = 167
						If Not Me.Oo0Oo0000.__.() Then
							GoTo IL_E9B
						End If
						IL_A4E:
						num = 170
						c1DockingTabPage2.TabVisible = True
						IL_A5C:
						num = 171
						c1DockingTabPage2.Parent.Visible = True
						IL_A6F:
						num = 172
						Me.oO._0oOo.()
						IL_A7B:
						num = 173
						Me.Oo_O__o0o.0_.()
					Case FormStyleEnum.独立, FormStyleEnum.模式, FormStyleEnum.PopupForm
						IL_A8C:
						num = 175
						If Me.FormStyle <> FormStyleEnum.PopupForm Then
							GoTo IL_AAA
						End If
						IL_A9B:
						num = 176
						Dim form2 As Form = New oOo_O_0O()
						GoTo IL_AB7
						IL_AAA:
						num = 178
						form2 = New O0oO_0()
						IL_AB7:
						num = 179
						AddHandler form2.FormClosed, AddressOf Me.O_.O__Oo.
						IL_AD0:
						num = 180
						AddHandler form2.FormClosing, AddressOf Me.O_.O__Oo.
						IL_AE9:
						num = 181
						AddHandler form2.Activated, AddressOf Me.o_.oo_0.
						IL_B02:
						num = 182
						AddHandler form2.Deactivate, AddressOf Me.ooo._O__oO.
						IL_B1B:
						num = 183
						form2.MinimizeBox = False
						IL_B29:
						num = 184
						form2.MaximizeBox = False
						IL_B37:
						num = 185
						form2.Text = Me.Text
						IL_B4A:
						num = 186
						form2.StartPosition = Me.StartPosition
						IL_B5D:
						num = 187
						If Me.FormStyle <> FormStyleEnum.模式 Then
							GoTo IL_BB1
						End If
						IL_B6C:
						num = 188
						If Main.OO_O.o..Disposing OrElse Main.OO_O.o..IsDisposed Then
							GoTo IL_BC4
						End If
						IL_B8A:
						num = 190
						If Not Main.OO_O.o..Visible Then
							GoTo IL_BC4
						End If
						IL_B9C:
						num = 191
						form2.TopMost = Me.TopMost
						GoTo IL_BC4
						IL_BB1:
						num = 193
						form2.TopMost = Me.TopMost
						IL_BC4:
						num = 194
						form2.ShowIcon = Me.ShowIcon
						IL_BD7:
						num = 195
						form2.ControlBox = Me.ControlBox
						IL_BEA:
						num = 196
						form2.MaximizeBox = Me.MaximizeBox
						IL_BFD:
						num = 197
						form2.MinimizeBox = Me.MinimizeBox
						IL_C10:
						num = 198
						form2.ClientSize = New Size(Me.Pane.Width, Me.Pane.Height)
						IL_C38:
						num = 199
						If Me.AllowResize Then
							GoTo IL_C54
						End If
						IL_C46:
						num = 200
						form2.FormBorderStyle = FormBorderStyle.FixedDialog
						IL_C54:
						num = 201
						If Operators.CompareString(Me.ImageFile, "", True) <= 0 Then
							GoTo IL_CB2
						End If
						IL_C6E:
						num = 202
						If Not OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + Me.ImageFile) Then
							GoTo IL_CB2
						End If
						IL_C90:
						num = 203
						form2.Icon = New Icon(O_O0OO.OOo_o.0o. + Me.ImageFile)
						IL_CB2:
						num = 204
						If A_1 = 2147483647 OrElse A_2 = 2147483647 Then
							GoTo IL_CF0
						End If
						IL_CC8:
						num = 205
						form2.StartPosition = FormStartPosition.Manual
						IL_CD6:
						num = 206
						Me.Left = A_1
						IL_CE3:
						num = 207
						Me.Top = A_2
						IL_CF0:
						num = 208
						If form2.StartPosition <> FormStartPosition.Manual Then
							GoTo IL_D1D
						End If
						IL_CFF:
						num = 209
						form2.Location = New Point(Me.Left, Me.Top)
						IL_D1D:
						num = 210
						form2.Controls.Add(Me.Pane)
						IL_D35:
						num = 211
						Me.Pane.Dock = DockStyle.Fill
						IL_D47:
						num = 212
						form2.ShowInTaskbar = False
						IL_D55:
						num = 213
						If Not Me.Oo0Oo0000.__.() Then
							GoTo IL_E9B
						End If
						IL_D66:
						num = 215
						If Not Me.AutoLayout Then
							GoTo IL_DB0
						End If
						IL_D74:
						num = 216
						Me.sizer = New C1SizerLight()
						IL_D85:
						num = 217
						Me.sizer.SetAutoResize(form2, True)
						IL_D99:
						num = 218
						Me.sizer.ResizeFonts = Me.AutoResizeFonts
						IL_DB0:
						num = 219
						If Me.FormStyle <> FormStyleEnum.PopupForm Then
							GoTo IL_DDB
						End If
						IL_DBF:
						num = 220
						form2.MaximizeBox = False
						IL_DCD:
						num = 221
						form2.MinimizeBox = False
						IL_DDB:
						num = 222
						If Me.FormStyle <> FormStyleEnum.独立 AndAlso Me.FormStyle <> FormStyleEnum.PopupForm Then
							GoTo IL_E14
						End If
						IL_DF3:
						num = 223
						form2.Owner = Main.OO_O.o.
						IL_E05:
						num = 224
						form2.Show()
						Exit Select
						IL_E14:
						num = 226
						If Not Me.oOO_0_oo.Oo0. Then
							GoTo IL_E51
						End If
						IL_E22:
						num = 227
						form2.ShowInTaskbar = True
						IL_E30:
						num = 228
						form2.ShowDialog()
						IL_E3E:
						num = 229
						OO_00oOO.Forms.O.o_0oOo_O00. = Nothing
						Exit Select
						IL_E51:
						num = 231
						form2.ShowDialog()
					Case FormStyleEnum.共有
						IL_469:
						num = 77
						Dim c1DockingTabPage3 As C1DockingTabPage = New C1DockingTabPage()
						IL_473:
						num = 78
						Dim c1DockingTab As C1DockingTab = Nothing
						IL_479:
						num = 79
						c1DockingTabPage3.Text = Me.Text
						IL_489:
						num = 80
						Main.OO_O.o..SuspendLayout()
						IL_496:
						num = 81
						Select Case Me.DockArea
							Case 0
								IL_7BD:
								num = 122
								Main.OO_O.o..O0o__0_OO.o.()
								IL_7CB:
								num = 123
								c1DockingTab = Main.OO_O.o..O0o__0_OO.o.()
								IL_7DA:
								num = 124
								Main.OO_O.o..O0o__0_OO.o.().Width = Me.Pane.Width
								IL_7F7:
								num = 125
								Main.OO_O.o..O0o__0_OO.o.()
								IL_805:
								num = 126
								c1DockingTab = Main.OO_O.o..O0o__0_OO.o.()
							Case 1
								IL_5BA:
								num = 96
								If Main.OO_O.o..oo_o0_._o. IsNot Nothing Then
									GoTo IL_678
								End If
								IL_5CC:
								num = 97
								Main.OO_O.o..oo_o0_._o. = New C1CommandDock()
								IL_5DE:
								num = 98
								Main.OO_O.o..oo_o0_._o..Dock = DockStyle.Bottom
								IL_5F1:
								num = 99
								Main.OO_O.o..oo_o0_._o..AllowFloat = False
								IL_604:
								num = 100
								Main.OO_O.o..Controls.Add(Main.OO_O.o..oo_o0_._o.)
								IL_620:
								num = 101
								Main.OO_O.o..o_o.0.(Me.O.OOo0O.())
								IL_633:
								num = 102
								Main.OO_O.o..oo_o0_._o..Controls.Add(Main.OO_O.o..Oo.O000_oO__o.())
								IL_654:
								num = 103
								Main.OO_O.o..oo_o0_._o..BringToFront()
								IL_666:
								num = 104
								Main.OO_O.o..OO_O_0Oo.___o.().BringToFront()
								IL_678:
								num = 105
								Main.OO_O.o..Oo.O000_oO__o.().Height = Me.Pane.Height + SystemInformation.HorizontalScrollBarHeight
								IL_69B:
								num = 106
								Dim oo_o0_._o. As C1CommandDock = Main.OO_O.o..oo_o0_._o.
								IL_6A9:
								num = 107
								c1DockingTab = Main.OO_O.o..Oo.O000_oO__o.()
							Case 2
								IL_4BD:
								num = 83
								If Main.OO_O.o..o_o0.o_. IsNot Nothing Then
									GoTo IL_57B
								End If
								IL_4CF:
								num = 84
								Main.OO_O.o..o_o0.o_. = New C1CommandDock()
								IL_4E1:
								num = 85
								Main.OO_O.o..o_o0.o_..Dock = DockStyle.Left
								IL_4F4:
								num = 86
								Main.OO_O.o..o_o0.o_..AllowFloat = False
								IL_507:
								num = 87
								Main.OO_O.o..Controls.Add(Main.OO_O.o..o_o0.o_.)
								IL_523:
								num = 88
								Main.OO_O.o..o_o0Oo.00.(Me.O.OOo0O.())
								IL_536:
								num = 89
								Main.OO_O.o..o_o0.o_..Controls.Add(Main.OO_O.o..o__0_._oOooO_o.())
								IL_557:
								num = 90
								Main.OO_O.o..o_o0.o_..BringToFront()
								IL_569:
								num = 91
								Main.OO_O.o..OO_O_0Oo.___o.().BringToFront()
								IL_57B:
								num = 92
								Main.OO_O.o..o__0_._oOooO_o.().Width = Me.Pane.Width
								IL_598:
								num = 93
								Dim o_o0.o_. As C1CommandDock = Main.OO_O.o..o_o0.o_.
								IL_5A6:
								num = 94
								c1DockingTab = Main.OO_O.o..o__0_._oOooO_o.()
							Case 3
								IL_6BD:
								num = 109
								If Main.OO_O.o..o_0_o.O. IsNot Nothing Then
									GoTo IL_77B
								End If
								IL_6CF:
								num = 110
								Main.OO_O.o..o_0_o.O. = New C1CommandDock()
								IL_6E1:
								num = 111
								Main.OO_O.o..o_0_o.O..Dock = DockStyle.Top
								IL_6F4:
								num = 112
								Main.OO_O.o..o_0_o.O..AllowFloat = False
								IL_707:
								num = 113
								Main.OO_O.o..Controls.Add(Main.OO_O.o..o_0_o.O.)
								IL_723:
								num = 114
								Main.OO_O.o..OOoo___.0.(Me.O.OOo0O.())
								IL_736:
								num = 115
								Main.OO_O.o..o_0_o.O..Controls.Add(Main.OO_O.o..O0o__0_OO.o.())
								IL_757:
								num = 116
								Main.OO_O.o..o_0_o.O..BringToFront()
								IL_769:
								num = 117
								Main.OO_O.o..OO_O_0Oo.___o.().BringToFront()
								IL_77B:
								num = 118
								Main.OO_O.o..O0o__0_OO.o.().Height = Me.Pane.Height + SystemInformation.HorizontalScrollBarHeight
								IL_79E:
								num = 119
								Dim o_0_o.O. As C1CommandDock = Main.OO_O.o..o_0_o.O.
								IL_7AC:
								num = 120
								c1DockingTab = Main.OO_O.o..O0o__0_OO.o.()
						End Select
						IL_814:
						num = 128
						c1DockingTabPage3.Controls.Add(Me.Pane)
						IL_82C:
						num = 129
						If Me.Pane Is Nothing Then
							GoTo IL_E9B
						End If
						IL_83D:
						num = 131
						c1DockingTabPage3.TabVisible = False
						IL_84B:
						num = 132
						c1DockingTab.TabPages.Add(c1DockingTabPage3)
						IL_860:
						num = 133
						Me.Pane.Dock = DockStyle.Fill
						IL_872:
						num = 134
						c1DockingTab.ShowCaption = Me.ShowDockCaption
						IL_885:
						num = 135
						c1DockingTab.CanCloseTabs = Me.ShowCloseButton
						IL_898:
						num = 136
						c1DockingTab.AutoHiding = Me.AutoHide
						IL_8AB:
						num = 137
						If Not Me.Oo0Oo0000.__.() Then
							GoTo IL_8E4
						End If
						IL_8B9:
						num = 138
						c1DockingTabPage3.TabVisible = True
						IL_8C7:
						num = 139
						c1DockingTab.Visible = True
						IL_8D5:
						num = 140
						c1DockingTab.SelectedTab = c1DockingTabPage3
						IL_8E4:
						num = 141
						Me.o_0._O.()
						IL_8F0:
						num = 142
						Main.OO_O.o..ResumeLayout()
						IL_900:
						num = 143
						Me.O_0.O00o_00_O. = c1DockingTab
						IL_90E:
						num = 144
						Me.oO._0oOo.()
						IL_91A:
						num = 145
						Me.Oo_O__o0o.0_.()
				End Select
				IL_E5F:
				num = 233
				If Me.FormStyle = FormStyleEnum.模式 Then
					GoTo IL_E7F
				End If
				IL_E6E:
				num = 234
				ShareLibriay.LockWindowUpdate(IntPtr.Zero)
				IL_E7F:
				num = 235
				Application.DoEvents()
				IL_E8A:
				num = 236
				Main.OO_O.o..O.ooO0. = True
				IL_E9B:
				GoTo IL_12A1
				IL_EA0:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1262:
				GoTo IL_1296
				IL_1264:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_1274:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1264
			End Try
			IL_1296:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_12A1:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BC9 RID: 15305 RVA: 0x0019E840 File Offset: 0x0019CA40
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim formEventArgs As FormEventArgs = New FormEventArgs(Me)
			Dim a_ As String = "AfterLoad_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formEventArgs }, True, Me.mmname, False)
			Return Me.Pane IsNot Nothing
		End Function

		' Token: 0x06003BCA RID: 15306 RVA: 0x0019E89C File Offset: 0x0019CA9C
		Private Sub <<EMPTY_NAME>>()
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
			Application.DoEvents()
			Dim formEventArgs As FormEventArgs = New FormEventArgs(Me)
			Dim a_ As String = "AfterShow_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formEventArgs }, True, Me.mmname, False)
		End Sub

		' Token: 0x06003BCB RID: 15307 RVA: 0x0019E900 File Offset: 0x0019CB00
		Public Sub ShowAsync(ParamArray args As Object())
			Dim a As Form.a = Nothing
			a.a = Me
			a.a = args
			a.a = -1
			a.a = AsyncVoidMethodBuilder.Create()
			a.a.Start(Of Form.a)(a)
		End Sub

		' Token: 0x06003BCC RID: 15308 RVA: 0x0019E948 File Offset: 0x0019CB48
		Public Sub Show(ParamArray args As Object())
			If args.Length = 0 Then
				Me.Show(Integer.MaxValue, Integer.MaxValue)
				Return
			End If
			If args.Length = 1 Then
				Me.Show(Conversions.ToInteger(args(0)), Integer.MaxValue)
				Return
			End If
			If args.Length = 2 Then
				Me.Show(Conversions.ToInteger(args(0)), Conversions.ToInteger(args(1)))
			End If
		End Sub

		' Token: 0x06003BCD RID: 15309 RVA: 0x0019E9A4 File Offset: 0x0019CBA4
		<oO0oooo("0709")>
		Public Sub Show(Optional x As Integer = 2147483647, Optional y As Integer = 2147483647)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.Open(x, y)
				IL_11:
				num2 = 3
				If Me.FormStyle = FormStyleEnum.模式 Then
					GoTo IL_225
				End If
				IL_1F:
				num2 = 5
				If Me.Pane Is Nothing OrElse Me.Pane.FindForm() Is Nothing OrElse Me.Pane.IsDisposed Then
					GoTo IL_225
				End If
				IL_4C:
				num2 = 7
				If Not Me.IsMain AndAlso Me.FormStyle <> FormStyleEnum.并列 Then
					GoTo IL_8A
				End If
				IL_5E:
				num2 = 8
				Dim c1DockingTabPage As C1DockingTabPage = CType(Me.Pane.Parent, C1DockingTabPage)
				IL_71:
				num2 = 9
				CType(c1DockingTabPage.Parent, C1DockingTab).SelectedTab = c1DockingTabPage
				GoTo IL_206
				IL_8A:
				num2 = 11
				Select Case Me.FormStyle
					Case FormStyleEnum.停靠
						IL_10E:
						num2 = 16
						Dim parent As Control = Me.Pane.Parent
						While True
							IL_1CE:
							num2 = 18
							If parent Is Nothing Then
								Exit For
							End If
							IL_123:
							num2 = 19
							If TypeOf parent Is C1DockingTabPage Then
								IL_12F:
								num2 = 20
								If TypeOf CType(parent, C1DockingTabPage).Parent Is C1DockingTab Then
									IL_145:
									num2 = 21
									CType(parent.Parent, C1DockingTab).SelectedTab = CType(parent, C1DockingTabPage)
								End If
							Else
								IL_162:
								num2 = 23
								If TypeOf parent Is C1NavBarPanel Then
									IL_16E:
									num2 = 24
									CType(parent.Parent, C1NavBar).SelectedButton = CType(parent, C1NavBarPanel).Button
								Else
									IL_190:
									num2 = 26
									If TypeOf parent Is C1DockingTab Then
										IL_19C:
										num2 = 27
										Dim c1DockingTab As C1DockingTab = CType(parent, C1DockingTab)
										IL_1A8:
										num2 = 28
										If c1DockingTab.AutoHiding Then
											IL_1B4:
											num2 = 29
											c1DockingTab.AutoHiding = False
										End If
										IL_1BF:
										c1DockingTab = Nothing
									End If
								End If
							End If
							IL_1C2:
							num2 = 31
							parent = parent.Parent
						End While
					Case FormStyleEnum.独立, FormStyleEnum.PopupForm
						IL_1DA:
						num2 = 34
						If Me.Pane Is Nothing OrElse Me.Pane.IsDisposed Then
							Exit Select
						End If
						IL_1F2:
						num2 = 35
						Me.Pane.FindForm().Visible = True
					Case FormStyleEnum.共有
						IL_BF:
						num2 = 13
						If Not(TypeOf Me.Pane.Parent.Parent Is C1DockingTab) Then
							Exit Select
						End If
						IL_DC:
						num2 = 14
						CType(Me.Pane.Parent.Parent, C1DockingTab).SelectedTab = CType(Me.Pane.Parent, C1DockingTabPage)
				End Select
				IL_206:
				num2 = 37
				If Not Me.Pane.CanFocus Then
					GoTo IL_225
				End If
				IL_216:
				num2 = 38
				Me.Pane.Focus()
				IL_225:
				GoTo IL_313
				IL_22A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2D4:
				GoTo IL_308
				IL_2D6:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2E6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2D6
			End Try
			IL_308:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_313:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x17000D13 RID: 3347
		' (get) Token: 0x06003BCE RID: 15310 RVA: 0x0019ECE8 File Offset: 0x0019CEE8
		' (set) Token: 0x06003BCF RID: 15311 RVA: 0x0019ED32 File Offset: 0x0019CF32
		Public Property Visible As Boolean
			Get
				Return(Me.FormStyle = FormStyleEnum.独立 OrElse Me.FormStyle = FormStyleEnum.PopupForm) AndAlso Me.Pane IsNot Nothing AndAlso Not Me.Pane.IsDisposed AndAlso Me.Pane.FindForm().Visible
			End Get
			Set(value As Boolean)
				If(Me.FormStyle = FormStyleEnum.独立 OrElse Me.FormStyle = FormStyleEnum.PopupForm) AndAlso Me.Pane IsNot Nothing AndAlso Not Me.Pane.IsDisposed Then
					Me.Pane.FindForm().Visible = value
				End If
			End Set
		End Property

		' Token: 0x06003BD0 RID: 15312 RVA: 0x0019ED6C File Offset: 0x0019CF6C
		<oO0oooo("1409")>
		Public Function ExistControl(Name As String) As Boolean
			Dim control As Control = Nothing
			If Me.Pane IsNot Nothing AndAlso Not Me.Pane.IsDisposed Then
				control = Me.o_._o000O.(Me.Pane.Controls, Name)
			End If
			Return control IsNot Nothing
		End Function

		' Token: 0x17000D14 RID: 3348
		' (get) Token: 0x06003BD1 RID: 15313 RVA: 0x0019EDA7 File Offset: 0x0019CFA7
		<oO0oooo("0706")>
		Public ReadOnly Property Controls As ControlCollection
			Get
				Return Me.ooOO0__._0O.
			End Get
		End Property

		' Token: 0x06003BD2 RID: 15314 RVA: 0x0019EDB0 File Offset: 0x0019CFB0
		Private Function <<EMPTY_NAME>>(A_0 As ControlTypeEnum, A_1 As String) As Control
			Select Case A_0
				Case ControlTypeEnum.Label
					Return New Label(New OO_0o_O_O())
				Case ControlTypeEnum.TextBox
					Return New TextBox(New O0O_O0())
				Case ControlTypeEnum.Button
					Return New Button(New C1Button() With { .FlatStyle = FlatStyle.Standard, .VisualStyle = 1, .UseVisualStyleBackColor = True })
				Case ControlTypeEnum.CheckBox
					Return New CheckBox(New CustomCheckBox())
				Case ControlTypeEnum.RadioButton
					Return New RadioButton(New oO00O0oO0o000())
				Case ControlTypeEnum.ComboBox
					Return New ComboBox(New OoOO0Oo_oo0oO() With { .O.oO. = Me })
				Case ControlTypeEnum.NumericComboBox
					Return New NumericComboBox(New ooOOO())
				Case ControlTypeEnum.TopicBar
					Return New TopicBar(New Oo_() With { .Size = New Size(221, 250), .Padding = New Padding(10) })
				Case ControlTypeEnum.DateTimePicker
					Return New DateTimePicker(New O_0oOoOo())
				Case ControlTypeEnum.ListBox
					Return New ListBox(New CustomListBox())
				Case ControlTypeEnum.CheckedListBox
					Return New CheckedListBox(New CustomCheckedListBox() With { .CheckOnClick = True })
				Case ControlTypeEnum.GroupBox
					Return New GroupBox(New GroupBox())
				Case ControlTypeEnum.Panel
					Return New Panel(New Panel())
				Case ControlTypeEnum.SplitContainer
					Return New SplitContainer(New SplitContainer())
				Case ControlTypeEnum.PictureBox
					Return New PictureBox(New CustomPictureBox(Me))
				Case ControlTypeEnum.TabControl
					Return New TabControl(New o_o0())
				Case ControlTypeEnum.TreeView
					Return New TreeView(New O__oO_o0_o_o() With { .Size = New Size(221, 250) })
				Case ControlTypeEnum.ProgressBar
					Return New ProgressBar(New o_O_O0O__())
				Case ControlTypeEnum.Chart
					Dim a_ As C1Chart = New C1Chart()
					New Chart(a_).Oo_0O0.oo00.()
					Return New Chart(a_)
				Case ControlTypeEnum.PictureViewer
					Return New PictureViewer(New PictureViewer() With { .Size = New Size(221, 250) })
				Case ControlTypeEnum.FileManager
					Return New FileManager(New FileManager() With { .Size = New Size(221, 250) })
				Case ControlTypeEnum.ColorLabel
					Return New ColorLabel(New CustomColorLabel())
				Case ControlTypeEnum.CheckedComboBox
					Return New CheckedComboBox(New O0oo000oO0oo_())
				Case ControlTypeEnum.NavBar
					Dim o_OOO As O_OOO = New O_OOO()
					o_OOO.Panels.Clear()
					Return New NavBar(o_OOO)
				Case ControlTypeEnum.WebBrowser
					Return New WebBrowser(New OOO0_())
				Case ControlTypeEnum.Painter
					Return New Painter(New O_oo())
				Case ControlTypeEnum.Line
					Return New Line(New LineControl())
				Case ControlTypeEnum.BarCode
					Return New BarCode(New OOo00o_0o0_() With { .Size = New Size(221, 40) })
				Case ControlTypeEnum.DropDownBox
					Return New DropDownBox(New OooO00O())
				Case ControlTypeEnum.Calendar
					Return New Calendar(New MonthCalendar() With { .FirstDayOfWeek = Day.Monday })
				Case ControlTypeEnum.TrackBar
					Return New TrackBar(New OoOoo00())
				Case ControlTypeEnum.RecordGrid
					Return New RecordGrid(New OooOo0___oO() With { .Size = New Size(200, 250) })
				Case ControlTypeEnum.TimeSpanBox
					Return New TimeSpanBox(New o__0OoO_())
				Case ControlTypeEnum.ListView
					Return New ListView(New o_OO_oOOO0o())
				Case ControlTypeEnum.FilterTree
					Return New FilterTree(New o_o0ooOooO() With { .Size = New Size(221, 250) })
				Case ControlTypeEnum.LoadTree
					Return New LoadTree(New o_0() With { .Size = New Size(221, 250) })
				Case ControlTypeEnum.InlineTree
					Return New InlineTree(New oo__() With { .Size = New Size(221, 250) })
				Case ControlTypeEnum.LayersTree
					Return New LayersTree(New oO_oo0Oo() With { .Size = New Size(221, 250) })
				Case ControlTypeEnum.FontPicker
					Return New FontPicker(New O00o())
				Case ControlTypeEnum.ColorPicker
					Return New ColorPicker(New oOO())
				Case ControlTypeEnum.Gauges
					Dim a_2 As O0_O_0O = New O0_O_0O()
					New Gauges(a_2)
					Return New Gauges(a_2)
				Case ControlTypeEnum.GanttView
					Dim ganttView As GanttView = New GanttView(False)
					New GanttView(ganttView)
					ganttView.LoadXml(OO_00oOO.FileSys.GetParentPath(Application.ExecutablePath) + "\ganttview.default.xml")
					Return New GanttView(ganttView)
				Case ControlTypeEnum.PDFViewer
					Return New PDFViewer(New C1FlexViewer())
				Case ControlTypeEnum.Map
					Dim a_3 As GeoMap = New GeoMap()
					New Map(a_3)
					Return New Map(a_3)
				Case ControlTypeEnum.WebViewer
					Return New WebViewer(New WebViewer())
			End Select
			Return Nothing
		End Function

		' Token: 0x06003BD3 RID: 15315 RVA: 0x0019F2B4 File Offset: 0x0019D4B4
		<oO0oooo("1409")>
		Public Function CreateControl(Name As String, Type As ControlTypeEnum) As Object
			Dim control As Control = Me.O.OOo0O.(Type, Name)
			control.BaseControl.Tag = "AddbyUserCode"
			control.Name = Name
			control.o.__O0O. = Me
			Me.oO__.o0.(control.BaseControl)
			Main.OO_O.o..o.O000oo.(New Object() { control.BaseControl })
			Return control
		End Function

		' Token: 0x06003BD4 RID: 15316 RVA: 0x0019F310 File Offset: 0x0019D510
		<oO0oooo("1919")>
		Public Function CreateTable(Name As String, TableName As String, IsCopy As Boolean) As Table
			Dim result As Table
			If Not OO_00oOO.Tables.get_Contains(TableName) Then
				result = Nothing
			Else
				Dim table2 As Table
				If IsCopy Then
					If TableName.IndexOf(".") > 0 Then
						TableName = TableName.Substring(TableName.LastIndexOf(".") + 1)
					End If
					Dim a_ As O_0 = New O_0(O_O0OO.OOOo.oo_OOOO_0.().Tables(TableName), Me.Name + "_" + Name)
					Dim table As Table = New Table(a_)
					table.foxGrid.Name = Name
					table2 = New Table(table.foxGrid)
					OO_00oOO.Tables.Ooo.0OOoO_0.(table)
				Else
					table2 = New Table(OO_00oOO.Tables(TableName).foxGrid)
					Dim baseControl As Control = table2.BaseControl
					baseControl.Name = Name
					If OO_00oOO.Tables(TableName).IsRelation Then
						Dim parent As Control = baseControl.Parent
						While parent IsNot Nothing
							If Not(TypeOf parent Is FormPanel) AndAlso TypeOf parent Is o_O0_0O0 Then
								CType(parent, o_O0_0O0).o_o.O___0o.(baseControl)
								Exit While
							End If
							parent = parent.Parent
						End While
					End If
				End If
				table2.BaseControl.Dock = DockStyle.None
				result = table2
			End If
			Return result
		End Function

		' Token: 0x06003BD5 RID: 15317 RVA: 0x0019F42C File Offset: 0x0019D62C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean, A_2 As String, A_3 As String) As Table
			Dim a_ As OleDbConnection = Nothing
			Dim text As String = Me.Name + "_" + A_0
			Dim a_2 As String = ""
			Dim httpClient As HttpClient = Nothing
			If Operators.CompareString(A_3, "", True) > 0 Then
				If O_O0OO.O._o_.().ContainsKey(A_3) Then
					a_ = O_O0OO.O._o_.()(A_3)
					A_2 = Oo00.o0_o._O_.(a_, A_2, False)
				Else
					If Not O_O0OO.OoO__.0oO0oo.().ContainsKey(A_3) Then
						Throw New Exception("没有找到数据源""" + A_3 + "!""")
					End If
					Dim o0O As O0O = O_O0OO.OoO__.0oO0oo.()(A_3)
					A_2 = Oo00.o0_o._O_.(o0O.OO.OoO0., A_2, False)
					httpClient = o0O.oO0_0.o.()
					httpClient.[Select] = A_2
					If Not A_1 Then
						httpClient.FormData("Action") = 1.ToString()
					Else
						httpClient.FormData("Action") = 2.ToString()
					End If
				End If
			Else
				a_ = O_O0OO.OoO.0OO__0ooo.()
			End If
			If Not A_1 Then
				a_2 = "?"
			End If
			o0OoOOoOOo0.OOOOO.o000.(a_, A_2, text, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_2, True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, "", httpClient)
			OO_00oOO.DataTables(text).o.0O000_.()
			Dim table As Table = New Table(O_O0OO.o__.O.()(text))
			If A_1 Then
				table.TableType = 2
				table.DataTable.AllowEdit = False
			Else
				table.TableType = 1
			End If
			OO_00oOO.Tables.Ooo.0OOoO_0.(table)
			table.foxGrid.Dock = DockStyle.None
			table.foxGrid.Name = A_0
			Return New Table(table.foxGrid)
		End Function

		' Token: 0x06003BD6 RID: 15318 RVA: 0x0019F5CB File Offset: 0x0019D7CB
		<oO0oooo("1919")>
		Public Function CreateSQLTable(Name As String, SqlText As String, ConnectionName As String) As Table
			Return Me.Oo_O00ooo.OO_.(Name, False, SqlText, ConnectionName)
		End Function

		' Token: 0x06003BD7 RID: 15319 RVA: 0x0019F5D7 File Offset: 0x0019D7D7
		<oO0oooo("1919")>
		Public Function CreateSQLQuery(Name As String, SqlText As String, ConnectionName As String) As Table
			Return Me.Oo_O00ooo.OO_.(Name, True, SqlText, ConnectionName)
		End Function

		' Token: 0x06003BD8 RID: 15320 RVA: 0x0019F5E4 File Offset: 0x0019D7E4
		<oO0oooo("1409")>
		Public Sub AddControl(Control As Control)
			Me.Pane.Controls.Add(Control.BaseControl)
			If TypeOf Control.BaseControl Is O_oOooO_O Then
				Dim o.0O_O0o_. As Table = CType(Control.BaseControl, O_oOooO_O).o.0O_O0o_.
				If o.0O_O0o_..TableType IsNot Nothing OrElse o.0O_O0o_..IsCopy Then
					o.0O_O0o_..oO_o_0o._0oooo.(True)
				End If
			End If
			Control.TopMost = True
		End Sub

		' Token: 0x06003BD9 RID: 15321 RVA: 0x0019F648 File Offset: 0x0019D848
		Friend Sub <<EMPTY_NAME>>(A_0 As Control)
			If TypeOf A_0 Is CustomPictureBox Then
				A_0 = CType(A_0, CustomPictureBox).PictureBox1
				A_0.Tag = RuntimeHelpers.GetObjectValue(A_0.Parent.Tag)
			End If
			Dim control As Control = A_0
			AddHandler control.Enter, AddressOf Me.O0_oO.0_O0.
			AddHandler control.Leave, AddressOf Me.oo_.o_oo.
			AddHandler control.Validating, AddressOf Me.OOO0.OOOoO.
			AddHandler control.KeyPress, AddressOf Me.O0O.OO0OO0.
			AddHandler control.KeyDown, AddressOf Me.o_.oo_o_00_.
			AddHandler control.KeyUp, AddressOf Me.O0O.OO0OO0.
			AddHandler control.Click, AddressOf Me.oo0.OOooo_.
			AddHandler control.MouseClick, AddressOf Me.o_oo.O_O_.
			AddHandler control.DoubleClick, AddressOf Me.o00_.__00.
			AddHandler control.MouseEnter, AddressOf Me.Oo.Oooo0o_.
			AddHandler control.MouseLeave, AddressOf Me.oo0OOo0_o.oOoo.
			AddHandler control.MouseHover, AddressOf Me.o_ooO0.o___0.
			AddHandler control.MouseMove, AddressOf Me.O_0OO._.
			AddHandler control.MouseDown, AddressOf Me.o._0_0_o_o0O.
			AddHandler control.MouseUp, AddressOf Me.O_OOo.o_0o.
			If TypeOf A_0 Is C1TextBox Then
				Dim c1TextBox As C1TextBox = CType(A_0, C1TextBox)
				c1TextBox.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
				AddHandler c1TextBox.TextChanged, AddressOf Me.oo__o.o0.
			End If
			If TypeOf A_0 Is CheckBox Then
				AddHandler CType(A_0, CheckBox).CheckedChanged, AddressOf Me.OooO_._oO_0.
			End If
			If TypeOf A_0 Is RadioButton Then
				AddHandler CType(A_0, RadioButton).CheckedChanged, AddressOf Me.OooO_._oO_0.
			End If
		End Sub

		' Token: 0x06003BDA RID: 15322 RVA: 0x0019F808 File Offset: 0x0019DA08
		<oO0oooo("1409")>
		Public Sub RemoveControl(Name As String)
			Dim control As Control = Me.o_._o000O.(Me.Pane.Controls, Name)
			If control IsNot Nothing Then
				Dim baseControl As Control = control.BaseControl
				oOO0oo_o0.O00OO_O_oO_.o.(baseControl.Parent.Controls, baseControl)
			End If
			Me.PrintSettings.Refresh()
		End Sub

		' Token: 0x06003BDB RID: 15323 RVA: 0x0019F850 File Offset: 0x0019DA50
		Public Sub ClearControl()
			For i As Integer = Me.Pane.Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = Me.Pane.Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(Me.Pane.Controls, a_)
			Next
			Me.PrintSettings.Refresh()
		End Sub

		' Token: 0x06003BDC RID: 15324 RVA: 0x0019F8A8 File Offset: 0x0019DAA8
		Friend Function <<EMPTY_NAME>>(A_0 As Control.ControlCollection, A_1 As String) As Control
			Try
				For Each obj As Object In A_0
					Dim control As Control = CType(obj, Control)
					If Operators.CompareString(control.Name, A_1, True) = 0 Then
						Dim control2 As Control = ooO_0O.o_O0.O_.(control)
						If control2 IsNot Nothing Then
							Return control2
						End If
					End If
					Dim control3 As Control = Nothing
					If control.Controls.Count > 0 AndAlso Not(TypeOf control Is PictureViewer) AndAlso Not(TypeOf control Is FileManager) Then
						control3 = Me.o_._o000O.(control.Controls, A_1)
					End If
					If control3 IsNot Nothing Then
						Return control3
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x17000D15 RID: 3349
		' (get) Token: 0x06003BDD RID: 15325 RVA: 0x0019F950 File Offset: 0x0019DB50
		Public ReadOnly Property ActiveControl As Object
			Get
				Dim result As Object
				If Me.Pane Is Nothing Then
					result = Nothing
				ElseIf Me.Pane.IsDisposed OrElse Me.Pane.Disposing Then
					result = Nothing
				Else
					result = Me.o_._o000O.(Me.Pane.Controls)
				End If
				Return result
			End Get
		End Property

		' Token: 0x06003BDE RID: 15326 RVA: 0x0019F99C File Offset: 0x0019DB9C
		Private Function <<EMPTY_NAME>>(A_0 As Control.ControlCollection) As Object
			Try
				For Each obj As Object In A_0
					Dim control As Control = CType(obj, Control)
					If control.Focused OrElse control.ContainsFocus Then
						If control.Controls.Count = 0 OrElse TypeOf control Is FileManager OrElse TypeOf control Is PictureViewer OrElse TypeOf control Is O_oOooO_O OrElse TypeOf control Is OooOo0___oO Then
							Dim obj2 As Object = ooO_0O.o_O0.O_.(control)
							If obj2 IsNot Nothing Then
								Return obj2
							End If
						ElseIf control.Controls.Count > 0 Then
							Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.o_._o000O.(control.Controls))
							If obj2 IsNot Nothing Then
								Return obj2
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x06003BDF RID: 15327 RVA: 0x0019FA64 File Offset: 0x0019DC64
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Pane.Parent Is Nothing Then
				Try
					For Each obj As Object In Application.OpenForms
						Dim form As Form = CType(obj, Form)
						If TypeOf form Is ef Then
							Dim ef As ef = CType(form, ef)
							If ef.OO.____oo. IsNot Nothing AndAlso ef.OO.____oo..Form Is Me Then
								ef.Close()
								Exit For
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim formEventArgs As FormEventArgs = New FormEventArgs(Me)
				Dim a_ As String = "AfterClose_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formEventArgs }, True, Me.mmname, False)
				Me.O_0.O00o_00_O. = Nothing
				If Me.Pane IsNot Nothing Then
					Me.Pane.ToolTip1.Dispose()
					Me.Pane.ToolTip1 = Nothing
					Me.Pane.ErrorProvider1.Dispose()
					Me.Pane.ErrorProvider1 = Nothing
					Me.Pane.PrintPropExtender1.Clear()
					oOO0oo_o0.O00OO_O_oO_.o.(Me.Pane.Controls)
				End If
				Me.PrintSettings.Clear()
				Me.PrintSettings = Nothing
				Me.Pane.Controls.Clear()
				Me.Pane.ooOo.o_. = Nothing
				Me.Pane.PrintPropExtender1 = Nothing
				Me.Pane.Dispose()
				Me.Pane = Nothing
				Me.O_0.O00o_00_O..Clear()
				If Me.Timer IsNot Nothing Then
					Me.Timer.Enabled = False
					Me.Timer.Dispose()
				End If
			End If
		End Sub

		' Token: 0x06003BE0 RID: 15328 RVA: 0x0019FC20 File Offset: 0x0019DE20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Me.o.Ooo_0_o0oo_. Then
				Me.o.Ooo_0_o0oo_. = True
				Dim control As Control = ooO.o.O_0000_O.(CType(A_0, Form).Controls)
				If control IsNot Nothing Then
					If TypeOf control Is O000O Then
						CType(control, O000O).SetReadOnlyProperty()
					End If
					If ooO_0O.o_O0.O_.(control) IsNot Nothing Then
						Me.O0_oO.0_O0.(control, New EventArgs())
					End If
					If Not(TypeOf control Is OoOO0Oo_oo0oO) Then
						Dim o0oo000oO0oo_ As O0oo000oO0oo_ = TryCast(control, O0oo000oO0oo_)
					End If
				End If
				Me.oO._0oOo.()
				Me.Oo_O__o0o.0_.()
			End If
		End Sub

		' Token: 0x06003BE1 RID: 15329 RVA: 0x0019FC94 File Offset: 0x0019DE94
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim control As Control = CType(Me.ActiveControl, Control)
				IL_15:
				num2 = 3
				If control Is Nothing Then
					GoTo IL_34
				End If
				IL_1A:
				num2 = 4
				control.Enabled = False
				IL_23:
				num2 = 5
				control.Enabled = True
				IL_2C:
				num2 = 6
				control.[Select]()
				IL_34:
				GoTo IL_9F
				IL_36:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_60:
				GoTo IL_94
				IL_62:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_72:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_62
			End Try
			IL_94:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_9F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BE2 RID: 15330 RVA: 0x0019FD58 File Offset: 0x0019DF58
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim form As Form = CType(A_0, Form)
			Dim control As Control = ooO.o.O_0000_O.(form.Controls)
			If TypeOf control Is O_0oOoOo AndAlso CType(control, C1TextBox).[ReadOnly] Then
				form.SelectNextControl(control, True, False, True, True)
			End If
			If control IsNot Nothing Then
				If TypeOf control Is C1FlexGrid Then
					Dim c1FlexGrid As C1FlexGrid = CType(control, C1FlexGrid)
					If c1FlexGrid.Editor IsNot Nothing Then
						c1FlexGrid.FinishEditing()
					End If
				ElseIf control.DataBindings.Count > 0 Then
					Me.OOO0.OOOoO.(control)
				End If
			End If
		End Sub

		' Token: 0x06003BE3 RID: 15331 RVA: 0x0019FDD8 File Offset: 0x0019DFD8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Me.o.Ooo_0_o0oo_. = False
				IL_09:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_10:
				num = 3
				Me.oOO0OO0O.o0oO.()
				IL_18:
				num = 4
				Dim form As Form = CType(A_0, Form)
				IL_21:
				num = 5
				form.Controls.Clear()
				IL_2E:
				num = 6
				If Me.Pane Is Nothing OrElse Me.Pane.IsDisposed Then
					GoTo IL_5B
				End If
				IL_45:
				num = 7
				Me.Pane.Dispose()
				IL_52:
				num = 8
				Me.Pane = Nothing
				IL_5B:
				num = 9
				If Not Main.OO_O.o..CanFocus Then
					GoTo IL_78
				End If
				IL_6A:
				num = 10
				Main.OO_O.o..Focus()
				IL_78:
				GoTo IL_F3
				IL_7A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_B4:
				GoTo IL_E8
				IL_B6:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_C6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_B6
			End Try
			IL_E8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F3:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BE4 RID: 15332 RVA: 0x0019FEF0 File Offset: 0x0019E0F0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Pane IsNot Nothing AndAlso Me.Pane.FindForm() IsNot Nothing AndAlso Not Me.Pane.IsDisposed Then
				Dim formEventArgs As FormEventArgs = New FormEventArgs(Me)
				Dim a_ As String = "TimerTick_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BE5 RID: 15333 RVA: 0x0019FF68 File Offset: 0x0019E168
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			Me.o0_o.0_o_. = False
			If Me.Pane IsNot Nothing Then
				Try
					For Each dataTable As DataTable In OO_00oOO.DataTables
						If dataTable.Name.ToLower().StartsWith(Me.Name.ToLower() + "_") AndAlso dataTable.o00o.00oO___0. Then
							MessageBox.Show("正在加载数据的过程中，暂不能关闭窗口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							A_1.Cancel = True
							Return
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Dim form As Form = Me.Pane.FindForm()
				If form IsNot Nothing Then
					If Not form.ControlBox AndAlso Control.ModifierKeys = Keys.Alt Then
						Me.o0_o.0_o_. = True
						A_1.Cancel = True
						Return
					End If
					If Me.ActiveControl IsNot Nothing Then
						Dim control As Control = CType(Me.ActiveControl, Control)
						If TypeOf control.BaseControl Is O_oOooO_O Then
							Dim o_oOooO_O As O_oOooO_O = CType(control.BaseControl, O_oOooO_O)
							If o_oOooO_O.Editor IsNot Nothing Then
								o_oOooO_O.FinishEditing()
								If o_oOooO_O.Editor IsNot Nothing Then
									A_1.Cancel = True
									Me.o0_o.0_o_. = True
									Return
								End If
							End If
						Else
							control.WriteValue()
						End If
					End If
					If form IsNot Main.OO_O.o. Then
						Dim formEventArgs As FormEventArgs = New FormEventArgs(Me)
						Dim a_ As String = "BeforeClose_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
						O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formEventArgs }, False, Me.mmname, False)
						If Me.O_0.O00o_00_O. Then
							A_1.Cancel = formEventArgs.Cancel
							Me.o0_o.0_o_. = formEventArgs.Cancel
						End If
						If Not A_1.Cancel Then
							Me.OoOO_._0.()
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06003BE6 RID: 15334 RVA: 0x001A0128 File Offset: 0x0019E328
		Friend Sub <<EMPTY_NAME>>(A_0 As Control, A_1 As ControlTypeEnum)
			If Not(TypeOf A_0 Is O_oOooO_O) Then
				If TypeOf A_0 Is CustomPictureBox Then
					A_0 = CType(A_0, CustomPictureBox).PictureBox1
					A_0.Tag = RuntimeHelpers.GetObjectValue(A_0.Parent.Tag)
				End If
				If TypeOf A_0 Is C1Chart Then
					AddHandler A_0.Click, AddressOf Me.OOo000o.0OO_O0.
					AddHandler A_0.DoubleClick, AddressOf Me.oOoo000O.0_.
					AddHandler A_0.MouseHover, AddressOf Me.O_o00_._Oo0O.
					AddHandler A_0.MouseMove, AddressOf Me.OoOO_o.00_.
					AddHandler A_0.MouseDown, AddressOf Me.oo.0O0___0.
					AddHandler A_0.MouseUp, AddressOf Me.O.OOo0O.
					CType(A_0, C1Chart).ShowTooltip += AddressOf Me.O.OOo0O.
				Else
					AddHandler A_0.Enter, AddressOf Me.O0_oO.0_O0.
					AddHandler A_0.Leave, AddressOf Me.oo_.o_oo.
					AddHandler A_0.Validating, AddressOf Me.OOO0.OOOoO.
					AddHandler A_0.KeyPress, AddressOf Me.O0O.OO0OO0.
					AddHandler A_0.KeyDown, AddressOf Me.o_.oo_o_00_.
					AddHandler A_0.KeyUp, AddressOf Me.O0O.OO0OO0.
					AddHandler A_0.Click, AddressOf Me.oo0.OOooo_.
					AddHandler A_0.MouseClick, AddressOf Me.o_oo.O_O_.
					AddHandler A_0.DoubleClick, AddressOf Me.o00_.__00.
					AddHandler A_0.MouseEnter, AddressOf Me.Oo.Oooo0o_.
					AddHandler A_0.MouseLeave, AddressOf Me.oo0OOo0_o.oOoo.
					AddHandler A_0.MouseHover, AddressOf Me.o_ooO0.o___0.
					AddHandler A_0.MouseMove, AddressOf Me.O_0OO._.
					AddHandler A_0.MouseDown, AddressOf Me.o._0_0_o_o0O.
					AddHandler A_0.MouseUp, AddressOf Me.O_OOo.o_0o.
				End If
				If TypeOf A_0 Is C1TextBox Then
					AddHandler A_0.LostFocus, AddressOf Me.o0000o_Oo0.0_.
					Dim c1TextBox As C1TextBox = CType(A_0, C1TextBox)
					Dim a_ As String = "DataFormat_" + Conversions.ToString(A_0.Tag)
					If Me.O0O.OO0OO0.(a_) Then
						c1TextBox.DisplayFormat.FormatType = 1
						c1TextBox.Formatting += AddressOf Me.Oo_O00ooo.OO_.
					End If
					a_ = "DataParse_" + Conversions.ToString(A_0.Tag)
					If Me.O0O.OO0OO0.(a_) Then
						c1TextBox.ParseInfo.FormatType = 1
						c1TextBox.ParseInfo.CustomFormat = ""
						c1TextBox.Parsing += AddressOf Me.Oo_O00ooo.OO_.
					End If
				End If
				If TypeOf A_0 Is C1Label Then
					Dim c1Label As C1Label = CType(A_0, C1Label)
					Dim a_2 As String = "DataFormat_" + Conversions.ToString(A_0.Tag)
					If Me.O0O.OO0OO0.(a_2) Then
						c1Label.FormatType = 1
						c1Label.CustomFormat = ""
						c1Label.Formatting += AddressOf Me.Oo_O00ooo.OO_.
					End If
				End If
				If TypeOf A_0 Is C1NumericEdit Then
					Dim c1NumericEdit As C1NumericEdit = CType(A_0, C1NumericEdit)
					AddHandler c1NumericEdit.TextChanged, AddressOf Me.oo__o.o0.
					c1NumericEdit.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
				ElseIf TypeOf A_0 Is O_0oOoOo Then
					Dim o_0oOoOo As O_0oOoOo = CType(A_0, O_0oOoOo)
					AddHandler o_0oOoOo.TextChanged, AddressOf Me.oo__o.o0.
					o_0oOoOo.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
				ElseIf TypeOf A_0 Is O00o Then
					CType(A_0, O00o).ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
				ElseIf TypeOf A_0 Is oOO Then
					CType(A_0, oOO).ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
				ElseIf TypeOf A_0 Is O0O_O0 Then
					If Not(TypeOf A_0 Is O__o) Then
						Dim o0O_O As O0O_O0 = CType(A_0, O0O_O0)
						AddHandler o0O_O.TextChanged, AddressOf Me.oo__o.o0.
						o0O_O.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
					End If
				ElseIf TypeOf A_0 Is CustomColorLabel Then
					AddHandler CType(A_0, CustomColorLabel).BackColorChanged, AddressOf Me.Oo_0o_oOo0oO.o.
				ElseIf TypeOf A_0 Is O_0oOoOo Then
					Dim o_0oOoOo2 As O_0oOoOo = CType(A_0, O_0oOoOo)
					AddHandler o_0oOoOo2.TextChanged, AddressOf Me.oo__o.o0.
					o_0oOoOo2.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
				ElseIf TypeOf A_0 Is OooO00O Then
					Dim oooO00O As OooO00O = CType(A_0, OooO00O)
					AddHandler oooO00O.TextChanged, AddressOf Me.oo__o.o0.
					oooO00O.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
					oooO00O.UpDownButtonClick += AddressOf Me.OOO0.OOOoO.
					oooO00O.ModalButtonClick += AddressOf Me.o0.ooo.
				ElseIf TypeOf A_0 Is OoOO0Oo_oo0oO Then
					Dim ooOO0Oo_oo0oO As OoOO0Oo_oo0oO = CType(A_0, OoOO0Oo_oo0oO)
					ooOO0Oo_oo0oO.oOOO_.o.(True)
					AddHandler ooOO0Oo_oo0oO.TextChanged, AddressOf Me.oo__o.o0.
					ooOO0Oo_oo0oO.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
					ooOO0Oo_oo0oO.O_O_OoOoOo.o0_.(AddressOf Me.o_._O__O.)
					ooOO0Oo_oo0oO.O.oO. = Me
				ElseIf TypeOf A_0 Is O0oo000oO0oo_ Then
					Dim o0oo000oO0oo_ As O0oo000oO0oo_ = CType(A_0, O0oo000oO0oo_)
					o0oo000oO0oo_.O.o00OOo_.(True)
					AddHandler o0oo000oO0oo_.TextChanged, AddressOf Me.oo__o.o0.
					o0oo000oO0oo_.ValueChanged += AddressOf Me.Oo_0o_oOo0oO.o.
					o0oo000oO0oo_.O0Oo.oOOoOoO__.(AddressOf Me.o_._O__O.)
					o0oo000oO0oo_.O__O.o_.(AddressOf Me.o0000o_Oo0.0_.)
				ElseIf TypeOf A_0 Is CustomCheckedListBox Then
					Dim customCheckedListBox As CustomCheckedListBox = CType(A_0, CustomCheckedListBox)
					customCheckedListBox.FormattingEnabled = True
					AddHandler customCheckedListBox.SelectedIndexChanged, AddressOf Me.o_._O__O.
					AddHandler customCheckedListBox.Format, AddressOf Me.o0000o_Oo0.0_.
					AddHandler customCheckedListBox.ItemCheck, AddressOf Me.o_.oo_o_00_.
				ElseIf TypeOf A_0 Is CustomListBox Then
					Dim customListBox As CustomListBox = CType(A_0, CustomListBox)
					customListBox.FormattingEnabled = True
					AddHandler customListBox.SelectedIndexChanged, AddressOf Me.o_._O__O.
					customListBox.O.00_Oo. = Me
				ElseIf TypeOf A_0 Is CustomCheckBox Then
					AddHandler CType(A_0, CheckBox).CheckedChanged, AddressOf Me.OooO_._oO_0.
				ElseIf TypeOf A_0 Is oO00O0oO0o000 Then
					AddHandler CType(A_0, oO00O0oO0o000).CheckedChanged, AddressOf Me.OooO_._oO_0.
				ElseIf TypeOf A_0 Is SplitContainer Then
					AddHandler CType(A_0, SplitContainer).SplitterMoved, AddressOf Me.o.o0oO__0__00_.
				ElseIf TypeOf A_0 Is C1DockingTab Then
					Dim c1DockingTab As C1DockingTab = CType(A_0, C1DockingTab)
					c1DockingTab.SelectedIndexChanged += AddressOf Me.o_._O__O.
					c1DockingTab.SelectedIndexChanging += AddressOf Me.o.o0oO__0__00_.
				ElseIf TypeOf A_0 Is O_OOO Then
					CType(A_0, O_OOO).SelectedPanelChanged += AddressOf Me.o_._O__O.
				ElseIf TypeOf A_0 Is TreeView Then
					Dim treeView As TreeView = CType(A_0, TreeView)
					If Not(TypeOf A_0 Is oo__) AndAlso Not(TypeOf A_0 Is oO_oo0Oo) AndAlso Not(TypeOf A_0 Is o_o0ooOooO) Then
						AddHandler treeView.AfterSelect, AddressOf Me.O_OoO_.Oo_0_o.
						AddHandler treeView.AfterLabelEdit, AddressOf Me.oooO.0o00_.
						AddHandler treeView.BeforeLabelEdit, AddressOf Me.Oo_OoO.o_.
						AddHandler treeView.AfterCheck, AddressOf Me.O.00oo_OO0O.
						AddHandler treeView.BeforeSelect, AddressOf Me.O_0.oOO.
						AddHandler treeView.AfterExpand, AddressOf Me.O__0._o.
						AddHandler treeView.AfterCollapse, AddressOf Me.oooO.0o00_.
						AddHandler treeView.BeforeExpand, AddressOf Me.Oo_OoO.o_.
						AddHandler treeView.NodeMouseClick, AddressOf Me.O_OOo.o_0o.
						AddHandler treeView.NodeMouseDoubleClick, AddressOf Me.ooO0O.00.
						AddHandler treeView.NodeMouseHover, AddressOf Me.ooO0O.00.
					End If
				ElseIf TypeOf A_0 Is o_OO_oOOO0o Then
					Dim listView As ListView = CType(A_0, ListView)
					AddHandler listView.RetrieveVirtualItem, AddressOf Me.Oo0Oo0000.__.
					AddHandler listView.CacheVirtualItems, AddressOf Me.oO0._o0__o_o_O.
					AddHandler listView.ItemActivate, AddressOf Me.O00.0_OO00oO_.
					AddHandler listView.BeforeLabelEdit, AddressOf Me.oO0._o0__o_o_O.
					AddHandler listView.AfterLabelEdit, AddressOf Me.oooO.0o00_.
					AddHandler listView.ItemSelectionChanged, AddressOf Me.O0O.OO0OO0.
					AddHandler listView.ItemCheck, AddressOf Me.o0000o_Oo0.0_.
					AddHandler listView.ItemChecked, AddressOf Me.o0000o_Oo0.0_.
					AddHandler listView.DrawSubItem, AddressOf Me.Oo_O00ooo.OO_.
					AddHandler listView.DrawColumnHeader, AddressOf Me.Oo_O00ooo.OO_.
				ElseIf TypeOf A_0 Is C1TopicBar Then
					Dim c1TopicBar As C1TopicBar = CType(A_0, C1TopicBar)
					c1TopicBar.LinkClick += AddressOf Me.OOO0.OOOoO.
					c1TopicBar.PageCollapsed += AddressOf Me.OOo0O0.0.
					c1TopicBar.PageExpanded += AddressOf Me.OOO0.OOOoO.
				ElseIf TypeOf A_0 Is MonthCalendar Then
					Dim monthCalendar As MonthCalendar = CType(A_0, MonthCalendar)
					AddHandler monthCalendar.DateChanged, AddressOf Me.oOo_0o_o_0_.O.
					AddHandler monthCalendar.DateSelected, AddressOf Me.Oo_O00ooo.OO_.
				ElseIf TypeOf A_0 Is OoOoo00 Then
					AddHandler CType(A_0, OoOoo00).Scroll, AddressOf Me.O000_0O__o._.
				ElseIf TypeOf A_0 Is Panel Then
					AddHandler CType(A_0, Panel).Scroll, AddressOf Me.oO_.0_0.
				ElseIf TypeOf A_0 Is GanttView Then
					Dim ganttView As GanttView = CType(A_0, GanttView)
					AddHandler CType(ganttView.Controls(4), ToolStrip).ItemClicked, AddressOf Me.O_.O__Oo.
					ganttView.AfterEditTask += AddressOf Me.O_OoO_.Oo_0_o.
					ganttView.BeforeEditTask += AddressOf Me.O__0._o.
					ganttView.BeforeAddTask += AddressOf Me.oooO.0o00_.
					ganttView.BeforeRemoveTask += AddressOf Me.oO0._o0__o_o_O.
					ganttView.TaskBarTooltip += AddressOf Me.o.o0oO__0__00_.
					ganttView.BeforeMoveTasks += AddressOf Me.oO0._o0__o_o_O.
					ganttView.TaskBarClick += AddressOf Me.o.o0oO__0__00_.
					ganttView.PaintDay += AddressOf Me.oO_.0_0.
					ganttView.SelectedIndexChanged += AddressOf Me.Oo.o__00_.
				ElseIf TypeOf A_0 Is GeoMap Then
					Dim geoMap As GeoMap = CType(A_0, GeoMap)
					geoMap.ZoomChanged += AddressOf Me.o_.O_00OOOo0_O.
					geoMap.CenterChanged += AddressOf Me.Oo._0O0_.
				ElseIf TypeOf A_0 Is WebViewer Then
					Dim webViewer As WebViewer = CType(A_0, WebViewer)
					webViewer.CoreWebView2InitializationCompleted += AddressOf Me.O0O0.O.
					webViewer.ZoomFactorChanged += AddressOf Me.o._oOO_o.
				End If
				If Not Form.b AndAlso OoOo0O.Oo_oOO_._Oo_o.() >= 0.98 Then
					Form.b = True
					AddressOf O_O0OO.O0_00o.o0__o..o__o.00oo0_o..Start()
				End If
			End If
		End Sub

		' Token: 0x06003BE7 RID: 15335 RVA: 0x001A0C00 File Offset: 0x0019EE00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Pane.ooOo.o_. IsNot Nothing Then
				If Me.Pane.ooOo.o_..FindForm() IsNot Nothing Then
					Me.Pane.ErrorProvider1.SetError(Me.Pane.ooOo.o_., Me.Pane.ooOo.o_.)
				End If
				Me.Pane.ooOo.o_. = Nothing
				Me.Pane.ooOo.o_. = Nothing
			End If
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "Enter_" + Conversions.ToString(control.Tag)
			If control.FindForm() IsNot Nothing Then
				Me.OOOo._. = control.Name
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
				If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlEventArgs.Cancel Then
					a_ = "Enter_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
				End If
			End If
		End Sub

		' Token: 0x06003BE8 RID: 15336 RVA: 0x001A0D2C File Offset: 0x0019EF2C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim control As Control = CType(A_0, Control)
				IL_10:
				num2 = 3
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				IL_1B:
				num2 = 4
				Dim a_ As String = "Leave_" + Conversions.ToString(control.Tag)
				IL_34:
				num2 = 5
				If control.FindForm() Is Nothing Then
					GoTo IL_302
				End If
				IL_41:
				num2 = 7
				If control.DataBindings.Count <= 0 Then
					GoTo IL_267
				End If
				IL_54:
				num2 = 8
				If Not(TypeOf control Is C1TextBox) Then
					GoTo IL_1F0
				End If
				IL_61:
				num2 = 9
				If Not CType(control, C1TextBox).UpdateValueWithCurrentText() Then
					GoTo IL_215
				End If
				IL_74:
				num2 = 10
				Dim binding As Binding = control.DataBindings(0)
				IL_85:
				num2 = 11
				Dim flag As Boolean = False
				IL_8B:
				num2 = 12
				If Not(TypeOf binding.DataSource Is O_0) Then
					GoTo IL_1DD
				End If
				IL_9F:
				num2 = 13
				Dim text As String = CType(binding.DataSource, O_0).Oo._Oo0OO.()
				IL_B5:
				num2 = 14
				If Not OO_00oOO.Tables.get_Contains(text) Then
					GoTo IL_1DD
				End If
				IL_C9:
				num2 = 15
				If Not OO_00oOO.Tables(text).IsCopy AndAlso Not OO_00oOO.Tables(text).IsRelation Then
					GoTo IL_1DD
				End If
				IL_F5:
				num2 = 16
				control.DataBindings.Remove(binding)
				IL_105:
				num2 = 17
				Dim bindingField As String = binding.BindingMemberInfo.BindingField
				IL_11A:
				num2 = 18
				Dim num3 As Integer = text.Length - text.Replace(".", "").Length
				IL_13D:
				num2 = 19
				Dim num4 As Integer = OO_00oOO.Tables(text).Position
				IL_153:
				num2 = 20
				If OO_00oOO.Tables(text).Current Is Nothing Then
					GoTo IL_194
				End If
				IL_169:
				num2 = 21
				OO_00oOO.Tables(text).Current(bindingField) = RuntimeHelpers.GetObjectValue(CType(control, C1TextBox).Value)
				IL_194:
				num2 = 22
				control.DataBindings.Add(binding)
				IL_1A4:
				num2 = 23
				flag = True
				IL_1AA:
				num2 = 24
				If num3 < 2 OrElse OO_00oOO.Tables(text).Position = num4 Then
					GoTo IL_1DD
				End If
				IL_1C7:
				num2 = 25
				OO_00oOO.Tables(text).Position = num4
				IL_1DD:
				num2 = 26
				If flag Then
					GoTo IL_215
				End If
				IL_1E4:
				num2 = 27
				Me.OOO0.OOOoO.(control)
				GoTo IL_215
				IL_1F0:
				num2 = 29
				If control.DataBindings.Count <= 0 Then
					GoTo IL_215
				End If
				IL_201:
				num2 = 30
				control.DataBindings(0).WriteValue()
				IL_215:
				num2 = 31
				If control.DataBindings(0).BindingManagerBase.Position < 0 Then
					GoTo IL_267
				End If
				IL_231:
				num2 = 32
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(control.DataBindings(0).BindingManagerBase.Current)
				IL_251:
				num2 = 33
				If objectValue Is Nothing Then
					GoTo IL_267
				End If
				IL_258:
				num2 = 34
				CType(objectValue, DataRowView).EndEdit()
				IL_267:
				num2 = 35
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
				IL_29B:
				num2 = 36
				If control.Disposing OrElse control.IsDisposed Then
					GoTo IL_302
				End If
				IL_2AE:
				num2 = 38
				If controlEventArgs.Cancel Then
					GoTo IL_302
				End If
				IL_2BA:
				num2 = 39
				a_ = "Leave_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				IL_2DE:
				num2 = 40
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
				IL_302:
				GoTo IL_3F8
				IL_307:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_3B9:
				GoTo IL_3ED
				IL_3BB:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3CB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3BB
			End Try
			IL_3ED:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3F8:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003BE9 RID: 15337 RVA: 0x001A1158 File Offset: 0x0019F358
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelEventArgs)
			Me.Pane.ooOo.o_. = Nothing
			Me.Pane.ooOo.o_. = Nothing
			Dim control As Control = CType(A_0, Control)
			If TypeOf control Is C1TextBox AndAlso Not CType(control, C1TextBox).UpdateValueWithCurrentText() Then
				A_1.Cancel = True
				Return
			End If
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "Validating_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not controlEventArgs.Cancel Then
				a_ = "Validating_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
			End If
			A_1.Cancel = controlEventArgs.Cancel
			oOO0oo_o0.O00OO_O_oO_.o.(control)
		End Sub

		' Token: 0x06003BEA RID: 15338 RVA: 0x001A1248 File Offset: 0x0019F448
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlKeyPressEventArgs As ControlKeyPressEventArgs = New ControlKeyPressEventArgs(control, Me, Conversions.ToString(A_1.KeyChar))
			Dim a_ As String = "KeyPress_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlKeyPressEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlKeyPressEventArgs.Cancel Then
				a_ = "KeyPress_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlKeyPressEventArgs }, False, Me.mmname, False)
			End If
			A_1.KeyChar = controlKeyPressEventArgs.KeyChar(0)
			A_1.Handled = controlKeyPressEventArgs.Cancel
		End Sub

		' Token: 0x06003BEB RID: 15339 RVA: 0x001A132C File Offset: 0x0019F52C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlKeyEventArgs As ControlKeyEventArgs = New ControlKeyEventArgs(control, Me, A_1.KeyData)
			controlKeyEventArgs.Cancel = A_1.Handled
			Dim a_ As String = "KeyDown_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlKeyEventArgs }, False, Me.mmname + "," + control.Name, False)
			If control.Disposing OrElse control.IsDisposed Then
				A_1.Handled = True
				Return
			End If
			If Not controlKeyEventArgs.Cancel Then
				a_ = "KeyDown_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlKeyEventArgs }, False, Me.mmname, False)
			End If
			A_1.Handled = controlKeyEventArgs.Cancel
			If A_1.Handled Then
				A_1.SuppressKeyPress = True
				Return
			End If
			If Not(TypeOf control Is o_OO_oOOO0o) AndAlso A_1.KeyCode = Keys.[Return] AndAlso Not A_1.Control AndAlso Not A_1.Alt AndAlso Not A_1.Shift Then
				If TypeOf control Is O0O_O0 Then
					If CType(control, O0O_O0).Multiline Then
						Return
					End If
				ElseIf TypeOf control Is Button Then
					Return
				End If
				A_1.Handled = True
				A_1.SuppressKeyPress = True
				SendKeys.Send("{TAB}")
			End If
		End Sub

		' Token: 0x06003BEC RID: 15340 RVA: 0x001A147C File Offset: 0x0019F67C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlKeyEventArgs As ControlKeyEventArgs = New ControlKeyEventArgs(control, Me, A_1.KeyData)
			Dim a_ As String = "KeyUp_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlKeyEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlKeyEventArgs.Cancel Then
				a_ = "KeyUp_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlKeyEventArgs }, False, Me.mmname, False)
			End If
			A_1.Handled = controlKeyEventArgs.Cancel
		End Sub

		' Token: 0x06003BED RID: 15341 RVA: 0x001A1548 File Offset: 0x0019F748
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				Dim control As Control = CType(A_0, Control)
				If Operators.CompareString(Me.OoO.0_Oo00Ooo., control.Tag.ToString(), True) <> 0 Then
					Me.OoO.0_Oo00Ooo. = control.Tag.ToString()
					Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
					Dim a_ As String = "Click_" + Conversions.ToString(control.Tag)
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
					If Not control.Disposing AndAlso Not control.IsDisposed Then
						If Not controlEventArgs.Cancel Then
							a_ = "Click_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
							O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
						End If
					End If
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Me.OoO.0_Oo00Ooo. = Nothing
			End Try
		End Sub

		' Token: 0x06003BEE RID: 15342 RVA: 0x001A1670 File Offset: 0x0019F870
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "ZoomChanged_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003BEF RID: 15343 RVA: 0x001A16D4 File Offset: 0x0019F8D4
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "CenterChanged_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003BF0 RID: 15344 RVA: 0x001A1738 File Offset: 0x0019F938
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Try
				Dim control As Control = CType(A_0, Control)
				If Operators.CompareString(Me.OoO.0_Oo00Ooo., control.Tag.ToString(), True) <> 0 Then
					Me.OoO.0_Oo00Ooo. = control.Tag.ToString()
					Dim controlMouseEventArgs As ControlMouseEventArgs = New ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, Me)
					Dim a_ As String = "MouseClick_" + Conversions.ToString(control.Tag)
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname + "," + control.Name, False)
					If Not control.Disposing AndAlso Not control.IsDisposed Then
						If Not controlMouseEventArgs.Cancel Then
							a_ = "MouseClick_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
							O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname, False)
						End If
					End If
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Me.OoO.0_Oo00Ooo. = Nothing
			End Try
		End Sub

		' Token: 0x06003BF1 RID: 15345 RVA: 0x001A1898 File Offset: 0x0019FA98
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				Dim control As Control = CType(A_0, Control)
				If Operators.CompareString(Me.OoO.0_Oo00Ooo., control.Tag.ToString(), True) <> 0 Then
					Me.OoO.0_Oo00Ooo. = control.Tag.ToString()
					Dim chartEventArgs As ChartEventArgs = New ChartEventArgs(control, Me)
					Dim a_ As String = "ChartClick_" + Conversions.ToString(control.Tag)
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { chartEventArgs }, False, Me.mmname + "," + control.Name, False)
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Me.OoO.0_Oo00Ooo. = Nothing
			End Try
		End Sub

		' Token: 0x06003BF2 RID: 15346 RVA: 0x001A1968 File Offset: 0x0019FB68
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "Click_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlEventArgs.Cancel Then
				a_ = "Click_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BF3 RID: 15347 RVA: 0x001A1A20 File Offset: 0x0019FC20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "DoubleClick_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlEventArgs.Cancel Then
				a_ = "DoubleClick_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BF4 RID: 15348 RVA: 0x001A1AD8 File Offset: 0x0019FCD8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim chartEventArgs As ChartEventArgs = New ChartEventArgs(control, Me)
			Dim a_ As String = "ChartDoubleClick_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { chartEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003BF5 RID: 15349 RVA: 0x001A1B3C File Offset: 0x0019FD3C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "MouseEnter_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not controlEventArgs.Cancel Then
				a_ = "MouseEnter_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BF6 RID: 15350 RVA: 0x001A1BE4 File Offset: 0x0019FDE4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "MouseLeave_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not controlEventArgs.Cancel Then
				a_ = "MouseLeave_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BF7 RID: 15351 RVA: 0x001A1C8C File Offset: 0x0019FE8C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "MouseHover_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not controlEventArgs.Cancel Then
				a_ = "MouseHover_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BF8 RID: 15352 RVA: 0x001A1D34 File Offset: 0x0019FF34
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim chartEventArgs As ChartEventArgs = New ChartEventArgs(control, Me)
			Dim a_ As String = "ChartMouseHover_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { chartEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003BF9 RID: 15353 RVA: 0x001A1D98 File Offset: 0x0019FF98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlMouseEventArgs As ControlMouseEventArgs = New ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, Me)
			Dim a_ As String = "MouseMove_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not control.Disposing AndAlso Not control.IsDisposed Then
				a_ = "MouseMove_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BFA RID: 15354 RVA: 0x001A1E68 File Offset: 0x001A0068
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim chartMouseEventArgs As ChartMouseEventArgs = New ChartMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, Me)
			Dim a_ As String = "ChartMouseMove_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { chartMouseEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003BFB RID: 15355 RVA: 0x001A1EE8 File Offset: 0x001A00E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim control As Control = CType(A_0, Control)
			If TypeOf control Is TreeView AndAlso Not(TypeOf control Is oo__) AndAlso Not(TypeOf control Is oO_oo0Oo) Then
				Dim treeView As TreeView = CType(control, TreeView)
				If treeView.GetNodeAt(A_1.X, A_1.Y) IsNot Nothing Then
					treeView.SelectedNode = treeView.GetNodeAt(A_1.X, A_1.Y)
				End If
			End If
			Dim controlMouseEventArgs As ControlMouseEventArgs = New ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, Me)
			Dim a_ As String = "MouseDown_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not control.Disposing AndAlso Not control.IsDisposed Then
				a_ = "MouseDown_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BFC RID: 15356 RVA: 0x001A2004 File Offset: 0x001A0204
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim chartMouseEventArgs As ChartMouseEventArgs = New ChartMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, Me)
			Dim a_ As String = "ChartMouseDown_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { chartMouseEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003BFD RID: 15357 RVA: 0x001A2084 File Offset: 0x001A0284
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlMouseEventArgs As ControlMouseEventArgs = New ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, Me)
			Dim a_ As String = "MouseUp_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname + "," + control.Name, False)
			If Not control.Disposing AndAlso Not control.IsDisposed Then
				a_ = "MouseUp_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlMouseEventArgs }, False, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003BFE RID: 15358 RVA: 0x001A2154 File Offset: 0x001A0354
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim chartMouseEventArgs As ChartMouseEventArgs = New ChartMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, Me)
			Dim a_ As String = "ChartMouseUp_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { chartMouseEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003BFF RID: 15359 RVA: 0x001A21D4 File Offset: 0x001A03D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ShowTooltipEventArgs)
			Dim chartDataSeries As ChartDataSeries = CType(A_0, ChartDataSeries)
			Dim c1Chart As C1Chart = Nothing
			Try
				For Each control As Control In Me.Controls
					If TypeOf control Is Chart Then
						Dim c1Chart2 As C1Chart = CType(control.BaseControl, C1Chart)
						If c1Chart2.ChartGroups(0) = chartDataSeries.Group OrElse c1Chart2.ChartGroups(1) = chartDataSeries.Group Then
							c1Chart = c1Chart2
							Exit For
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Control)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim chartToolTipEventArgs As ChartToolTipEventArgs = New ChartToolTipEventArgs(c1Chart, Me, A_1)
			Dim a_ As String = "ChartShowTooltip_" + Conversions.ToString(c1Chart.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { chartToolTipEventArgs }, False, Me.mmname + "," + c1Chart.Name, False)
		End Sub

		' Token: 0x06003C00 RID: 15360 RVA: 0x001A22C0 File Offset: 0x001A04C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Me.O_o_.0o0__o0O. = control
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "TextChanged_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
				If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlEventArgs.Cancel Then
					a_ = "TextChanged_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
				End If
				Me.O_o_.0o0__o0O. = Nothing
			End If
		End Sub

		' Token: 0x06003C01 RID: 15361 RVA: 0x001A2394 File Offset: 0x001A0594
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If Me.O_0.O00o_00_O. Is Nothing Then
				result = False
			Else
				A_0 = o0OoOOoOOo0.OO0._Oo0o.(A_0)
				result = (Me.O_0.O00o_00_O..[GetType]("UserCode").GetMethod(A_0) IsNot Nothing)
			End If
			Return result
		End Function

		' Token: 0x06003C02 RID: 15362 RVA: 0x001A23D0 File Offset: 0x001A05D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormatEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim formattingEventArgs As FormattingEventArgs = New FormattingEventArgs(control, Me, A_1)
			Dim a_ As String = "DataFormat_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formattingEventArgs }, True, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C03 RID: 15363 RVA: 0x001A2434 File Offset: 0x001A0634
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ParseEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim parsingEventArgs As ParsingEventArgs = New ParsingEventArgs(control, Me, A_1)
			Dim a_ As String = "DataParse_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { parsingEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C04 RID: 15364 RVA: 0x001A2498 File Offset: 0x001A0698
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ScrollEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "AfterScroll_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C05 RID: 15365 RVA: 0x001A2504 File Offset: 0x001A0704
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				If control.DataBindings.Count > 0 AndAlso control.DataBindings(0).BindingManagerBase.Count > 0 Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(control.DataBindings(0).BindingManagerBase.Current)
					If TypeOf objectValue Is DataRowView Then
						Dim row As DataRow = CType(objectValue, DataRowView).Row
						Dim bindingField As String = control.DataBindings(0).BindingMemberInfo.BindingField
						If TypeOf control Is C1TextBox Then
							Dim c1TextBox As C1TextBox = CType(control, C1TextBox)
							If Operators.CompareString(row(bindingField).ToString(), c1TextBox.Text, True) <> 0 Then
								c1TextBox.UpdateValueWithCurrentText()
								control.DataBindings(0).WriteValue()
								CType(objectValue, DataRowView).Row.EndEdit()
							End If
						End If
					End If
				End If
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "SelectedIndexChanged_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C06 RID: 15366 RVA: 0x001A2640 File Offset: 0x001A0840
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SelectedIndexChangingEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim tabPageChangingEventArgs As TabPageChangingEventArgs = New TabPageChangingEventArgs(control, Me, A_1)
			Dim a_ As String = "SelectedIndexChanging_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { tabPageChangingEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C07 RID: 15367 RVA: 0x001A26A4 File Offset: 0x001A08A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "SelectionChangeCommitted_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C08 RID: 15368 RVA: 0x001A2710 File Offset: 0x001A0910
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ListControlConvertEventArgs)
			If TypeOf A_1.ListItem Is DataRowView Then
				Dim control As Control = CType(A_0, Control)
				Dim listItemFormatEventArgs As ListItemFormatEventArgs = New ListItemFormatEventArgs(control, Me, CType(A_1.ListItem, DataRowView))
				Dim a_ As String = "ListItemFormat_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { listItemFormatEventArgs }, False, Me.mmname + "," + control.Name, False)
				If Operators.CompareString(listItemFormatEventArgs.Text, "", True) > 0 Then
					A_1.Value = listItemFormatEventArgs.Text
				End If
			End If
		End Sub

		' Token: 0x06003C09 RID: 15369 RVA: 0x001A27AC File Offset: 0x001A09AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				If control.DataBindings.Count > 0 AndAlso control.Focused Then
					control.DataBindings(0).WriteValue()
				End If
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "CheckedChanged_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
				If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlEventArgs.Cancel Then
					a_ = "CheckedChanged_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
				End If
			End If
		End Sub

		' Token: 0x06003C0A RID: 15370 RVA: 0x001A2898 File Offset: 0x001A0A98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim itemCheckEventArgs As ItemCheckEventArgs = New ItemCheckEventArgs(control, Me, A_1)
				Dim a_ As String = "ItemCheck_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { itemCheckEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C0B RID: 15371 RVA: 0x001A2904 File Offset: 0x001A0B04
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Me.O_o_.0o0__o0O. = control
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "ValueChanged_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
				If Not control.Disposing AndAlso Not control.IsDisposed AndAlso Not controlEventArgs.Cancel Then
					a_ = "ValueChanged_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname, False)
				End If
				Me.O_o_.0o0__o0O. = Nothing
			End If
		End Sub

		' Token: 0x06003C0C RID: 15372 RVA: 0x001A29D8 File Offset: 0x001A0BD8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SplitterEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "SplitterMoved_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C0D RID: 15373 RVA: 0x001A2A44 File Offset: 0x001A0C44
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NodeLabelEditEventArgs)
			CType(A_0, TreeView).LabelEdit = False
			If A_1.Label IsNot Nothing Then
				Dim control As Control = CType(A_0, Control)
				Dim treeNodeEditEventArgs As TreeNodeEditEventArgs = New TreeNodeEditEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)), A_1.Label)
				Dim a_ As String = "AfterEditNode_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeNodeEditEventArgs }, False, Me.mmname + "," + control.Name, False)
				A_1.CancelEdit = treeNodeEditEventArgs.Cancel
			End If
		End Sub

		' Token: 0x06003C0E RID: 15374 RVA: 0x001A2ADC File Offset: 0x001A0CDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NodeLabelEditEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim treeNodeEditEventArgs As TreeNodeEditEventArgs = New TreeNodeEditEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)), A_1.Label)
			Dim a_ As String = "BeforeEditNode_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeNodeEditEventArgs }, False, Me.mmname + "," + control.Name, False)
			A_1.CancelEdit = treeNodeEditEventArgs.Cancel
			If treeNodeEditEventArgs.Cancel Then
				Dim treeView As TreeView = CType(A_0, TreeView)
				treeView.SelectedNode.EndEdit(True)
				treeView.LabelEdit = False
			End If
		End Sub

		' Token: 0x06003C0F RID: 15375 RVA: 0x001A2B84 File Offset: 0x001A0D84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
				Dim a_ As String = "AfterSelectNode_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C10 RID: 15376 RVA: 0x001A2C00 File Offset: 0x001A0E00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
				Dim a_ As String = "AfterExpandNode_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C11 RID: 15377 RVA: 0x001A2C7C File Offset: 0x001A0E7C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
				Dim a_ As String = "AfterCollapseNode_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x06003C12 RID: 15378 RVA: 0x001A2CF8 File Offset: 0x001A0EF8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim o__oO_o0_o_o As O__oO_o0_o_o = CType(A_0, O__oO_o0_o_o)
				If Not((A_1.Action <> TreeViewAction.ByKeyboard AndAlso A_1.Action <> TreeViewAction.ByMouse) And Not o__oO_o0_o_o.Ooo__.ooO_0.()) Then
					Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
					Dim a_ As String = "AfterCheckNode_" + Conversions.ToString(control.Tag)
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
				End If
			End If
		End Sub

		' Token: 0x06003C13 RID: 15379 RVA: 0x001A2DA0 File Offset: 0x001A0FA0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewCancelEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim treeView As TreeView = CType(A_0, TreeView)
				Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
				Dim a_ As String = "BeforeSelectNode_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
				A_1.Cancel = treeViewEventArgs.Cancel
			End If
		End Sub

		' Token: 0x06003C14 RID: 15380 RVA: 0x001A2E2C File Offset: 0x001A102C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewCancelEventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
				Dim a_ As String = "BeforeExpandNode_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
				A_1.Cancel = treeViewEventArgs.Cancel
			End If
		End Sub

		' Token: 0x06003C15 RID: 15381 RVA: 0x001A2EB4 File Offset: 0x001A10B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeNodeMouseClickEventArgs)
			Try
				Dim treeView As TreeView = CType(A_0, TreeView)
				If treeView.HitTest(A_1.X, A_1.Y).Location = TreeViewHitTestLocations.Label OrElse treeView.HitTest(A_1.X, A_1.Y).Location = TreeViewHitTestLocations.Image Then
					Dim control As Control = CType(A_0, Control)
					If Operators.CompareString(Me.OoO.0_Oo00Ooo., control.Tag.ToString(), True) <> 0 Then
						Me.OoO.0_Oo00Ooo. = control.Tag.ToString()
						Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
						Dim a_ As String = "NodeMouseClick_" + Conversions.ToString(control.Tag)
						O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
					End If
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Me.OoO.0_Oo00Ooo. = Nothing
			End Try
		End Sub

		' Token: 0x06003C16 RID: 15382 RVA: 0x001A2FD8 File Offset: 0x001A11D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeNodeMouseClickEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim treeView As TreeView = CType(control, TreeView)
			Dim treeNode As TreeNode
			If treeView.SelectedNode IsNot Nothing Then
				treeNode = treeView.SelectedNode
			Else
				treeNode = A_1.Node
			End If
			Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(treeNode, O_o__00Ooo)))
			Dim a_ As String = "NodeMouseDoubleClick_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C17 RID: 15383 RVA: 0x001A306C File Offset: 0x001A126C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeNodeMouseHoverEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim treeViewEventArgs As TreeViewEventArgs = New TreeViewEventArgs(control, Me, New TreeNode(CType(A_1.Node, O_o__00Ooo)))
			Dim a_ As String = "NodeMouseHover_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { treeViewEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C18 RID: 15384 RVA: 0x001A30E0 File Offset: 0x001A12E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1TopicBarClickEventArgs)
			Try
				Dim control As Control = CType(A_0, Control)
				If Operators.CompareString(Me.OoO.0_Oo00Ooo., control.Tag.ToString(), True) <> 0 Then
					Me.OoO.0_Oo00Ooo. = control.Tag.ToString()
					Dim topicLinkEventArgs As TopicLinkEventArgs = New TopicLinkEventArgs(control, Me, A_1)
					Dim a_ As String = "TopicLinkClick_" + Conversions.ToString(control.Tag)
					O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { topicLinkEventArgs }, False, Me.mmname + "," + control.Name, False)
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Me.OoO.0_Oo00Ooo. = Nothing
			End Try
		End Sub

		' Token: 0x06003C19 RID: 15385 RVA: 0x001A31B0 File Offset: 0x001A13B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1TopicBarPageEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim topicPageEventArgs As TopicPageEventArgs = New TopicPageEventArgs(control, Me, A_1)
			Dim a_ As String = "TopicPageCollapsed_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { topicPageEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C1A RID: 15386 RVA: 0x001A3214 File Offset: 0x001A1414
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1TopicBarPageEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim topicPageEventArgs As TopicPageEventArgs = New TopicPageEventArgs(control, Me, A_1)
			Dim a_ As String = "TopicPageExpanded_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { topicPageEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C1B RID: 15387 RVA: 0x001A3278 File Offset: 0x001A1478
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As UpDownButtonClickEventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim upDownButtonClickEventArgs As UpDownButtonClickEventArgs = New UpDownButtonClickEventArgs(control, Me, A_1.Delta)
			Dim a_ As String = "UpDownButtonClick_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { upDownButtonClickEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C1C RID: 15388 RVA: 0x001A32E0 File Offset: 0x001A14E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
			Dim a_ As String = "ModalButtonClick_" + Conversions.ToString(control.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
		End Sub

		' Token: 0x06003C1D RID: 15389 RVA: 0x001A3344 File Offset: 0x001A1544
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DateRangeEventArgs)
			Dim monthCalendar As MonthCalendar = CType(A_0, MonthCalendar)
			monthCalendar.SelectionEnd = monthCalendar.SelectionStart
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(monthCalendar, Me)
			Dim a_ As String = "DateChanged_" + Conversions.ToString(monthCalendar.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + monthCalendar.Name, False)
		End Sub

		' Token: 0x06003C1E RID: 15390 RVA: 0x001A33B4 File Offset: 0x001A15B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DateRangeEventArgs)
			Dim monthCalendar As MonthCalendar = CType(A_0, MonthCalendar)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(monthCalendar, Me)
			Dim a_ As String = "DateSelected_" + Conversions.ToString(monthCalendar.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + monthCalendar.Name, False)
		End Sub

		' Token: 0x06003C1F RID: 15391 RVA: 0x001A3418 File Offset: 0x001A1618
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim control As Control = CType(A_0, Control)
			If control.FindForm() IsNot Nothing Then
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "Scroll_" + Conversions.ToString(control.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
			End If
		End Sub

		' Token: 0x17000D16 RID: 3350
		' (get) Token: 0x06003C20 RID: 15392 RVA: 0x001A3481 File Offset: 0x001A1681
		Public ReadOnly Property Name As String
			Get
				Return Me.O_o_.0o0__o0O.("Name").ToString()
			End Get
		End Property

		' Token: 0x06003C21 RID: 15393 RVA: 0x001A3498 File Offset: 0x001A1698
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As LabelEditEventArgs)
			If A_1.Label Is Nothing Then
				A_1.CancelEdit = True
				Return
			End If
			Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Dim listViewEditEventArgs As ListViewEditEventArgs = New ListViewEditEventArgs(o_OO_oOOO0o, Me, New ListViewRow(o_OO_oOOO0o.Items(A_1.Item)), A_1.Label)
			Dim a_ As String = "AfterEdit_" + Conversions.ToString(o_OO_oOOO0o.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { listViewEditEventArgs }, False, Me.mmname + "," + o_OO_oOOO0o.Name, False)
			If listViewEditEventArgs.Cancel Then
				A_1.CancelEdit = True
			End If
		End Sub

		' Token: 0x06003C22 RID: 15394 RVA: 0x001A3534 File Offset: 0x001A1734
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As LabelEditEventArgs)
			Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Dim listViewEditEventArgs As ListViewEditEventArgs = New ListViewEditEventArgs(o_OO_oOOO0o, Me, New ListViewRow(o_OO_oOOO0o.Items(A_1.Item)), A_1.Label)
			Dim a_ As String = "BeforeEdit_" + Conversions.ToString(o_OO_oOOO0o.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { listViewEditEventArgs }, False, Me.mmname + "," + o_OO_oOOO0o.Name, False)
			If listViewEditEventArgs.Cancel Then
				A_1.CancelEdit = True
			End If
		End Sub

		' Token: 0x06003C23 RID: 15395 RVA: 0x001A35C0 File Offset: 0x001A17C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RetrieveVirtualItemEventArgs)
			Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Me.Oo_O00ooo.OO_.(o_OO_oOOO0o, A_1.ItemIndex)
			A_1.Item = o_OO_oOOO0o.o0__o.O0.(A_1.ItemIndex).BaseItem
		End Sub

		' Token: 0x06003C24 RID: 15396 RVA: 0x001A3600 File Offset: 0x001A1800
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(o_OO_oOOO0o, Me)
			Dim a_ As String = "RowActivate_" + Conversions.ToString(o_OO_oOOO0o.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + o_OO_oOOO0o.Name, False)
		End Sub

		' Token: 0x06003C25 RID: 15397 RVA: 0x001A3664 File Offset: 0x001A1864
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ListViewItemSelectionChangedEventArgs)
			Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Dim listViewRowEventArgs As ListViewRowEventArgs = New ListViewRowEventArgs(o_OO_oOOO0o, Me, New ListViewRow(A_1.Item), A_1.ItemIndex)
			Dim a_ As String = "RowSelectionChanged_" + Conversions.ToString(o_OO_oOOO0o.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { listViewRowEventArgs }, False, Me.mmname + "," + o_OO_oOOO0o.Name, False)
		End Sub

		' Token: 0x06003C26 RID: 15398 RVA: 0x001A36D8 File Offset: 0x001A18D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			If A_1.NewValue <> A_1.CurrentValue Then
				Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
				Dim listViewRowEventArgs As ListViewRowEventArgs = New ListViewRowEventArgs(o_OO_oOOO0o, Me, New ListViewRow(o_OO_oOOO0o.Items(A_1.Index)), A_1.Index)
				Dim a_ As String = "RowChecking_" + Conversions.ToString(o_OO_oOOO0o.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { listViewRowEventArgs }, False, Me.mmname + "," + o_OO_oOOO0o.Name, False)
				If listViewRowEventArgs.Cancel Then
					A_1.NewValue = A_1.CurrentValue
				End If
			End If
		End Sub

		' Token: 0x06003C27 RID: 15399 RVA: 0x001A377C File Offset: 0x001A197C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckedEventArgs)
			Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Dim listViewRowEventArgs As ListViewRowEventArgs = New ListViewRowEventArgs(o_OO_oOOO0o, Me, New ListViewRow(A_1.Item), A_1.Item.Index)
			Dim a_ As String = "RowChecked_" + Conversions.ToString(o_OO_oOOO0o.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { listViewRowEventArgs }, False, Me.mmname + "," + o_OO_oOOO0o.Name, False)
		End Sub

		' Token: 0x06003C28 RID: 15400 RVA: 0x001A37F4 File Offset: 0x001A19F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DrawListViewSubItemEventArgs)
			Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Dim a_ As ListViewRow = New ListViewRow(A_1.Item)
			Dim a_2 As ListViewColumn = New ListViewColumn(A_1.Header)
			Dim listViewDrawCellEventArgs As ListViewDrawCellEventArgs = New ListViewDrawCellEventArgs(o_OO_oOOO0o, Me, a_, a_2, A_1)
			Dim a_3 As String = "DrawViewCell_" + Conversions.ToString(o_OO_oOOO0o.Tag)
			A_1.DrawDefault = True
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_3, New Object() { listViewDrawCellEventArgs }, False, Me.mmname + "," + o_OO_oOOO0o.Name, False)
		End Sub

		' Token: 0x06003C29 RID: 15401 RVA: 0x001A387C File Offset: 0x001A1A7C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemEventArgs As GaugeItemEventArgs = New GaugeItemEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemClick_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C2A RID: 15402 RVA: 0x001A38E4 File Offset: 0x001A1AE4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemEventArgs As GaugeItemEventArgs = New GaugeItemEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemDoubleClick_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C2B RID: 15403 RVA: 0x001A394C File Offset: 0x001A1B4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemEventArgs As GaugeItemEventArgs = New GaugeItemEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemStateChanged_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C2C RID: 15404 RVA: 0x001A39B4 File Offset: 0x001A1BB4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemMouseEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemMouseEventArgs As GaugeItemMouseEventArgs = New GaugeItemMouseEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemMouseUp_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemMouseEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C2D RID: 15405 RVA: 0x001A3A1C File Offset: 0x001A1C1C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemMouseEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemMouseEventArgs As GaugeItemMouseEventArgs = New GaugeItemMouseEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemMouseDown_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemMouseEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C2E RID: 15406 RVA: 0x001A3A84 File Offset: 0x001A1C84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemEventArgs As GaugeItemEventArgs = New GaugeItemEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemMouseEnter_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C2F RID: 15407 RVA: 0x001A3AEC File Offset: 0x001A1CEC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemEventArgs As GaugeItemEventArgs = New GaugeItemEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemMouseLeave_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C30 RID: 15408 RVA: 0x001A3B54 File Offset: 0x001A1D54
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemMouseEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugeItemMouseEventArgs As GaugeItemMouseEventArgs = New GaugeItemMouseEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeItemMouseMove_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeItemMouseEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C31 RID: 15409 RVA: 0x001A3BBC File Offset: 0x001A1DBC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PointerValueChangedEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Pointer.Owner.Owner, O0_O_0O)
			Dim gaugePointerValueChangedEventArgs As GaugePointerValueChangedEventArgs = New GaugePointerValueChangedEventArgs(o0_O_0O, Me, A_1.Pointer.Owner, o0_O_0O, A_1.Pointer)
			Dim a_ As String = "GaugePointerValueChanged_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugePointerValueChangedEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C32 RID: 15410 RVA: 0x001A3C40 File Offset: 0x001A1E40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PointerDragEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugePointerDragEventArgs As GaugePointerDragEventArgs = New GaugePointerDragEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "PointerDragMove_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugePointerDragEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C33 RID: 15411 RVA: 0x001A3CA8 File Offset: 0x001A1EA8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PointerDragEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugePointerDragEventArgs As GaugePointerDragEventArgs = New GaugePointerDragEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "PointerDragBegin_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugePointerDragEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C34 RID: 15412 RVA: 0x001A3D10 File Offset: 0x001A1F10
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormatLabelEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Decorator.Owner.Owner, O0_O_0O)
			Dim gaugeFormatLabelEventArgs As GaugeFormatLabelEventArgs = New GaugeFormatLabelEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "GaugeFormatLabel_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugeFormatLabelEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C35 RID: 15413 RVA: 0x001A3D84 File Offset: 0x001A1F84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PointerDragEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugePointerDragEventArgs As GaugePointerDragEventArgs = New GaugePointerDragEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "PointerDragEnd_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugePointerDragEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C36 RID: 15414 RVA: 0x001A3DEC File Offset: 0x001A1FEC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PointerDragEventArgs)
			Dim o0_O_0O As O0_O_0O = CType(A_1.Container, O0_O_0O)
			Dim gaugePointerDragEventArgs As GaugePointerDragEventArgs = New GaugePointerDragEventArgs(o0_O_0O, Me, A_1)
			Dim a_ As String = "PointerDragCancel_" + Conversions.ToString(o0_O_0O.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gaugePointerDragEventArgs }, False, Me.mmname + "," + o0_O_0O.Name, False)
		End Sub

		' Token: 0x06003C37 RID: 15415 RVA: 0x001A3E54 File Offset: 0x001A2054
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTaskArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim ganttTaskEventArgs As GanttTaskEventArgs = New GanttTaskEventArgs(ganttView, Me, A_1)
			Dim a_ As String = "AfterEditTask_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttTaskEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C38 RID: 15416 RVA: 0x001A3EB8 File Offset: 0x001A20B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTaskArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim ganttTaskEventArgs As GanttTaskEventArgs = New GanttTaskEventArgs(ganttView, Me, A_1)
			Dim a_ As String = "BeforeEditTask_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttTaskEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C39 RID: 15417 RVA: 0x001A3F1C File Offset: 0x001A211C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTaskArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim ganttTaskEventArgs As GanttTaskEventArgs = New GanttTaskEventArgs(ganttView, Me, A_1)
			Dim a_ As String = "BeforeAddTask_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttTaskEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C3A RID: 15418 RVA: 0x001A3F80 File Offset: 0x001A2180
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTaskArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim ganttTaskEventArgs As GanttTaskEventArgs = New GanttTaskEventArgs(ganttView, Me, A_1)
			Dim a_ As String = "BeforeRemoveTask_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttTaskEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C3B RID: 15419 RVA: 0x001A3FE4 File Offset: 0x001A21E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTasksArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim ganttTasksEventArgs As GanttTasksEventArgs = New GanttTasksEventArgs(ganttView, Me, A_1)
			Dim a_ As String = "BeforeMoveTasks_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttTasksEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C3C RID: 15420 RVA: 0x001A4048 File Offset: 0x001A2248
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TaskBarTooltipEventArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim ganttTaskBarTooltipEventArgs As GanttTaskBarTooltipEventArgs = New GanttTaskBarTooltipEventArgs(ganttView, Me, A_1)
			Dim a_ As String = "TaskBarTooltip_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttTaskBarTooltipEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C3D RID: 15421 RVA: 0x001A40AC File Offset: 0x001A22AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TaskBarClickEventArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			If(DateTime.Now - ganttView.oo0ooO000O.O.).TotalSeconds <= 0.6 Then
				Dim ganttTaskBarClickEventArgs As GanttTaskBarClickEventArgs = New GanttTaskBarClickEventArgs(ganttView, Me, A_1)
				Dim a_ As String = "TaskBarClick_" + Conversions.ToString(ganttView.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttTaskBarClickEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
			End If
		End Sub

		' Token: 0x06003C3E RID: 15422 RVA: 0x001A4134 File Offset: 0x001A2334
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PaintDayEventArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim ganttPaintDayEventArgs As GanttPaintDayEventArgs = New GanttPaintDayEventArgs(ganttView, Me, A_1)
			Dim a_ As String = "PaintDay_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { ganttPaintDayEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C3F RID: 15423 RVA: 0x001A4198 File Offset: 0x001A2398
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ganttView As GanttView = CType(A_0, GanttView)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(ganttView, Me)
			Dim a_ As String = "SelectedIndexChanged_" + Conversions.ToString(ganttView.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + ganttView.Name, False)
		End Sub

		' Token: 0x06003C40 RID: 15424 RVA: 0x001A41FC File Offset: 0x001A23FC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ToolStripItemClickedEventArgs)
			If Not A_1.ClickedItem.Name.StartsWith("ts") Then
				Dim parent As Control = Me.o_.oo_o_00_.(A_1.ClickedItem).Parent
				Dim gannttStripItemClikEventArgs As GannttStripItemClikEventArgs = New GannttStripItemClikEventArgs(parent, Me, A_1)
				Dim a_ As String = "GannttStripItemClik_" + Conversions.ToString(parent.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { gannttStripItemClikEventArgs }, False, Me.mmname + "," + parent.Name, False)
			End If
		End Sub

		' Token: 0x06003C41 RID: 15425 RVA: 0x001A4280 File Offset: 0x001A2480
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2InitializationCompletedEventArgs)
			Dim webViewer As WebViewer = CType(A_0, WebViewer)
			If webViewer.CoreWebView2 IsNot Nothing Then
				webViewer.CoreWebView2.Settings.AreDevToolsEnabled = webViewer.AreDevToolsEnabled
				webViewer.CoreWebView2.Settings.AreDefaultContextMenusEnabled = webViewer.AreDefaultContextMenusEnabled
				webViewer.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = webViewer.AreBrowserAcceleratorKeysEnabled
				webViewer.CoreWebView2.AddWebResourceRequestedFilter("*", 0)
				webViewer.CoreWebView2.Settings.AreHostObjectsAllowed = True
				webViewer.CoreWebView2.Settings.IsWebMessageEnabled = True
				webViewer.CoreWebView2.NavigationStarting += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.NavigationCompleted += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.ContentLoading += AddressOf Me.OOO0.OOOoO.
				webViewer.CoreWebView2.SourceChanged += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.DOMContentLoaded += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.ScriptDialogOpening += AddressOf Me.OO.OoO_o.
				webViewer.CoreWebView2.StatusBarTextChanged += AddressOf Me.O0_0O.__0_.
				webViewer.CoreWebView2.ContextMenuRequested += AddressOf Me.OOO0.OOOoO.
				webViewer.CoreWebView2.HistoryChanged += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.WebMessageReceived += AddressOf Me.OO.OoO_o.
				webViewer.CoreWebView2.NewWindowRequested += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.WebResourceRequested += AddressOf Me.OO.OoO_o.
				webViewer.CoreWebView2.WebResourceResponseReceived += AddressOf Me.OO.OoO_o.
				webViewer.CoreWebView2.SaveAsUIShowing += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.DownloadStarting += AddressOf Me.O0O0.O.
				webViewer.CoreWebView2.PermissionRequested += AddressOf Me.O0O0.O.
			End If
			Dim initializationCompletedEventArgs As InitializationCompletedEventArgs = New InitializationCompletedEventArgs(webViewer, Me, A_1)
			Dim a_ As String = "InitializationCompleted_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { initializationCompletedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C42 RID: 15426 RVA: 0x001A44D4 File Offset: 0x001A26D4
		Private Function <<EMPTY_NAME>>(A_0 As CoreWebView2) As WebViewer
			Try
				For Each control As Control In Me.Controls
					If TypeOf control.BaseControl Is WebViewer AndAlso CType(control.BaseControl, WebViewer).CoreWebView2 = A_0 Then
						Return CType(control.BaseControl, WebViewer)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Control)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x06003C43 RID: 15427 RVA: 0x001A454C File Offset: 0x001A274C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2NavigationStartingEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim navigationStartingEventArgs As NavigationStartingEventArgs = New NavigationStartingEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "NavigationStarting_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { navigationStartingEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C44 RID: 15428 RVA: 0x001A45B8 File Offset: 0x001A27B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2NavigationCompletedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim navigationCompletedEventArgs As NavigationCompletedEventArgs = New NavigationCompletedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "NavigationCompleted_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { navigationCompletedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C45 RID: 15429 RVA: 0x001A4624 File Offset: 0x001A2824
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2ContentLoadingEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim contentLoadingEventArgs As ContentLoadingEventArgs = New ContentLoadingEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "ContentLoading_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { contentLoadingEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C46 RID: 15430 RVA: 0x001A4690 File Offset: 0x001A2890
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2SourceChangedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim sourceChangedEventArgs As SourceChangedEventArgs = New SourceChangedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "SourceChanged_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { sourceChangedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C47 RID: 15431 RVA: 0x001A46FC File Offset: 0x001A28FC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2DOMContentLoadedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim domcontentLoadedEventArgs As DOMContentLoadedEventArgs = New DOMContentLoadedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "DOMContentLoaded_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { domcontentLoadedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C48 RID: 15432 RVA: 0x001A4768 File Offset: 0x001A2968
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2ScriptDialogOpeningEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim scriptDialogOpeningEventArgs As ScriptDialogOpeningEventArgs = New ScriptDialogOpeningEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "ScriptDialogOpening_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { scriptDialogOpeningEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C49 RID: 15433 RVA: 0x001A47D4 File Offset: 0x001A29D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2ContextMenuRequestedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim contextMenuRequestedEventArgs As ContextMenuRequestedEventArgs = New ContextMenuRequestedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "ContextMenuRequested_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { contextMenuRequestedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C4A RID: 15434 RVA: 0x001A4840 File Offset: 0x001A2A40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As Object)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(webViewer, Me)
			Dim a_2 As String = "StatusBarTextChanged_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { controlEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C4B RID: 15435 RVA: 0x001A48AC File Offset: 0x001A2AAC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2DownloadStartingEventArgs)
			Dim c As Form.c = New Form.c()
			c.a = Me
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			c.a = Me.O0O.OO0OO0.(a_)
			Dim downloadStartingEventArgs As DownloadStartingEventArgs = New DownloadStartingEventArgs(c.a, Me, A_1)
			c.a = "DownloadStarting_" + Conversions.ToString(c.a.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., c.a, New Object() { downloadStartingEventArgs }, False, Me.mmname + "," + c.a.Name, False)
			c.a = A_1.DownloadOperation
			If c.a.oo_.0oOOOoooo. IsNot Nothing Then
				c.a.oo_.0oOOOoooo.(c.a) = New TaskCompletionSource(Of Integer)()
				c.a.oo_.0oOOOoooo..SetResult(c.a)
			End If
			If Not A_1.Cancel Then
				Dim e As Form.e = New Form.e()
				e.a = c
				e.a = DateTime.MinValue
				e.a = AddressOf e.a
				e.b = AddressOf e.b
				e.a.a.OoO.oOOoo..TryAdd(e.a.a, e.a)
				e.a.a.oo_.0oOOOoooo..TryAdd(e.a.a, e.b)
				e.a.a.BytesReceivedChanged += e.a
				e.a.a.StateChanged += e.b
			End If
		End Sub

		' Token: 0x06003C4C RID: 15436 RVA: 0x001A4A4C File Offset: 0x001A2C4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim webViewer As WebViewer = CType(A_0, WebViewer)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(webViewer, Me)
			Dim a_ As String = "ZoomFactorChanged_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C4D RID: 15437 RVA: 0x001A4AB0 File Offset: 0x001A2CB0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As Object)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(webViewer, Me)
			Dim a_2 As String = "HistoryChanged_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { controlEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C4E RID: 15438 RVA: 0x001A4B1C File Offset: 0x001A2D1C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2WebMessageReceivedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim webMessageReceivedEventArgs As WebMessageReceivedEventArgs = New WebMessageReceivedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "WebMessageReceived_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { webMessageReceivedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C4F RID: 15439 RVA: 0x001A4B88 File Offset: 0x001A2D88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2NewWindowRequestedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim newWindowRequestedEventArgs As NewWindowRequestedEventArgs = New NewWindowRequestedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "NewWindowRequested_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { newWindowRequestedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C50 RID: 15440 RVA: 0x001A4BF4 File Offset: 0x001A2DF4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2WebResourceRequestedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim webResourceRequestedEventArgs As WebResourceRequestedEventArgs = New WebResourceRequestedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "WebResourceRequested_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { webResourceRequestedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C51 RID: 15441 RVA: 0x001A4C60 File Offset: 0x001A2E60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2WebResourceResponseReceivedEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			Dim webViewer As WebViewer = Me.O0O.OO0OO0.(a_)
			Dim webResourceResponseReceivedEventArgs As WebResourceResponseReceivedEventArgs = New WebResourceResponseReceivedEventArgs(webViewer, Me, A_1)
			Dim a_2 As String = "WebResourceResponseReceived_" + Conversions.ToString(webViewer.Tag)
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { webResourceResponseReceivedEventArgs }, False, Me.mmname + "," + webViewer.Name, False)
		End Sub

		' Token: 0x06003C52 RID: 15442 RVA: 0x001A4CCC File Offset: 0x001A2ECC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2SaveAsUIShowingEventArgs)
			Dim a_ As CoreWebView2 = CType(A_0, CoreWebView2)
			If Not Me.O0O.OO0OO0.(a_).AreSaveAsEnabled Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06003C53 RID: 15443 RVA: 0x001A4CF5 File Offset: 0x001A2EF5
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2PermissionRequestedEventArgs)
			If A_1.PermissionKind = 7 Then
				A_1.State = 1
				A_1.SavesInProfile = True
				A_1.Handled = True
			End If
		End Sub

		' Token: 0x06003C54 RID: 15444 RVA: 0x001A4D15 File Offset: 0x001A2F15
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DrawListViewColumnHeaderEventArgs)
			A_1.DrawDefault = True
		End Sub

		' Token: 0x06003C55 RID: 15445 RVA: 0x001A4D1E File Offset: 0x001A2F1E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DrawListViewItemEventArgs)
		End Sub

		' Token: 0x06003C56 RID: 15446 RVA: 0x001A4D20 File Offset: 0x001A2F20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CacheVirtualItemsEventArgs)
			Dim a_ As o_OO_oOOO0o = CType(A_0, o_OO_oOOO0o)
			Dim startIndex As Integer = A_1.StartIndex
			Dim endIndex As Integer = A_1.EndIndex
			For i As Integer = startIndex To endIndex
				Me.Oo_O00ooo.OO_.(a_, i)
			Next
		End Sub

		' Token: 0x06003C57 RID: 15447 RVA: 0x001A4D54 File Offset: 0x001A2F54
		Private Sub <<EMPTY_NAME>>(A_0 As o_OO_oOOO0o, A_1 As Integer)
			If Not A_0.o0__o.O0..ContainsKey(A_1) Then
				Dim ooO0__O0_O As ooO0__O0_O = New ooO0__O0_O()
				ooO0__O0_O.o0.oooO.(A_0.O_O.0Oo_o.())
				If A_0.Columns.Count > 0 Then
					Dim num As Integer = A_0.Columns.Count - 1
					For i As Integer = 1 To num
						ooO0__O0_O.SubItems.Add("").Name = A_0.Columns(i).Name
					Next
				End If
				Dim listViewRowEventArgs As ListViewRowEventArgs = New ListViewRowEventArgs(A_0, Me, New ListViewRow(ooO0__O0_O), A_1)
				Dim a_ As String = "RetrieveVirtualRow_" + Conversions.ToString(A_0.Tag)
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { listViewRowEventArgs }, False, Me.mmname + "," + A_0.Name, False)
				If Operators.CompareString(ooO0__O0_O.ImageKey, "", True) > 0 Then
					Dim num2 As Integer = A_0.SmallImageList.Images.IndexOfKey(ooO0__O0_O.ImageKey)
					If num2 >= 0 Then
						ooO0__O0_O.ImageIndex = num2
					Else
						num2 = A_0.LargeImageList.Images.IndexOfKey(ooO0__O0_O.ImageKey)
						If num2 >= 0 Then
							ooO0__O0_O.ImageIndex = num2
						End If
					End If
				End If
				If A_0.CheckBoxes AndAlso Not ooO0__O0_O.Checked Then
					ooO0__O0_O.Checked = True
					ooO0__O0_O.Checked = False
				End If
				A_0.o0__o.O0..Add(A_1, New ListViewRow(ooO0__O0_O))
			End If
		End Sub

		' Token: 0x17000D17 RID: 3351
		' (get) Token: 0x06003C58 RID: 15448 RVA: 0x001A4EBB File Offset: 0x001A30BB
		Public ReadOnly Property Panel As FormPanel
			Get
				Return Me.Pane
			End Get
		End Property

		' Token: 0x17000D18 RID: 3352
		' (get) Token: 0x06003C59 RID: 15449 RVA: 0x001A4EC4 File Offset: 0x001A30C4
		Public ReadOnly Property BaseForm As Form
			Get
				Dim result As Form
				If Me.Pane IsNot Nothing AndAlso Me.Pane.FindForm() IsNot Main.OO_O.o. Then
					result = Me.Pane.FindForm()
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000D19 RID: 3353
		' (get) Token: 0x06003C5A RID: 15450 RVA: 0x001A4EFC File Offset: 0x001A30FC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property AutoOpen As Boolean
			Get
				Return Convert.ToBoolean(RuntimeHelpers.GetObjectValue(Me.O_o_.0o0__o0O.("AutoOpen")))
			End Get
		End Property

		' Token: 0x17000D1A RID: 3354
		' (get) Token: 0x06003C5B RID: 15451 RVA: 0x001A4F18 File Offset: 0x001A3118
		Public ReadOnly Property TableName As String
			Get
				Return Me.O_o_.0o0__o0O.("Table").ToString()
			End Get
		End Property

		' Token: 0x17000D1B RID: 3355
		' (get) Token: 0x06003C5C RID: 15452 RVA: 0x001A4F2F File Offset: 0x001A312F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Category As String
			Get
				Return Me.O_o_.0o0__o0O.("pth").ToString()
			End Get
		End Property

		' Token: 0x17000D1C RID: 3356
		' (get) Token: 0x06003C5D RID: 15453 RVA: 0x001A4F46 File Offset: 0x001A3146
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property IsMain As Boolean
			Get
				Return Me.FormStyle = FormStyleEnum.主窗口
			End Get
		End Property

		' Token: 0x17000D1D RID: 3357
		' (get) Token: 0x06003C5E RID: 15454 RVA: 0x001A4F51 File Offset: 0x001A3151
		<oO0oooo("0705")>
		Public ReadOnly Property Opened As Boolean
			Get
				Return Me.Pane IsNot Nothing AndAlso Me.Pane.FindForm() IsNot Nothing
			End Get
		End Property

		' Token: 0x17000D1E RID: 3358
		' (get) Token: 0x06003C5F RID: 15455 RVA: 0x001A4F6B File Offset: 0x001A316B
		' (set) Token: 0x06003C60 RID: 15456 RVA: 0x001A4F73 File Offset: 0x001A3173
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FormStyle As FormStyleEnum
			Get
				Return Me.ooOO0__._0O.
			End Get
			Set(value As FormStyleEnum)
				Me.ooOO0__._0O. = value
			End Set
		End Property

		' Token: 0x17000D1F RID: 3359
		' (get) Token: 0x06003C61 RID: 15457 RVA: 0x001A4F7C File Offset: 0x001A317C
		' (set) Token: 0x06003C62 RID: 15458 RVA: 0x001A4F84 File Offset: 0x001A3184
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ShowIcon As Boolean
			Get
				Return Me.O0_.0O0__0OO.
			End Get
			Set(value As Boolean)
				Me.O0_.0O0__0OO. = value
			End Set
		End Property

		' Token: 0x17000D20 RID: 3360
		' (get) Token: 0x06003C63 RID: 15459 RVA: 0x001A4F8D File Offset: 0x001A318D
		' (set) Token: 0x06003C64 RID: 15460 RVA: 0x001A4F95 File Offset: 0x001A3195
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ControlBox As Boolean
			Get
				Return Me.oOo.O0__0Oo0.
			End Get
			Set(value As Boolean)
				Me.oOo.O0__0Oo0. = value
			End Set
		End Property

		' Token: 0x17000D21 RID: 3361
		' (get) Token: 0x06003C65 RID: 15461 RVA: 0x001A4F9E File Offset: 0x001A319E
		' (set) Token: 0x06003C66 RID: 15462 RVA: 0x001A4FA6 File Offset: 0x001A31A6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property MaximizeBox As Boolean
			Get
				Return Me.OOO.0__oO.
			End Get
			Set(value As Boolean)
				Me.OOO.0__oO. = value
			End Set
		End Property

		' Token: 0x17000D22 RID: 3362
		' (get) Token: 0x06003C67 RID: 15463 RVA: 0x001A4FAF File Offset: 0x001A31AF
		' (set) Token: 0x06003C68 RID: 15464 RVA: 0x001A4FB7 File Offset: 0x001A31B7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property MinimizeBox As Boolean
			Get
				Return Me.oO.oo_.
			End Get
			Set(value As Boolean)
				Me.oO.oo_. = value
			End Set
		End Property

		' Token: 0x17000D23 RID: 3363
		' (get) Token: 0x06003C69 RID: 15465 RVA: 0x001A4FC0 File Offset: 0x001A31C0
		' (set) Token: 0x06003C6A RID: 15466 RVA: 0x001A4FC8 File Offset: 0x001A31C8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property DockTitle As Boolean
			Get
				Return Me.O._0O0__0_0o_0.
			End Get
			Set(value As Boolean)
				Me.O._0O0__0_0o_0. = value
			End Set
		End Property

		' Token: 0x17000D24 RID: 3364
		' (get) Token: 0x06003C6B RID: 15467 RVA: 0x001A4FD1 File Offset: 0x001A31D1
		' (set) Token: 0x06003C6C RID: 15468 RVA: 0x001A4FDC File Offset: 0x001A31DC
		Public Property Text As String
			Get
				Return Me.o_0.o0.
			End Get
			Set(value As String)
				Me.o_0.o0. = value
				If Me.Pane IsNot Nothing AndAlso Me.Pane.FindForm() IsNot Nothing Then
					If Me.Pane.FindForm() IsNot Main.OO_O.o. Then
						Me.Pane.FindForm().Text = value
						Return
					End If
					If Me.Pane.Parent IsNot Nothing Then
						Me.Pane.Parent.Text = value
					End If
				End If
			End Set
		End Property

		' Token: 0x17000D25 RID: 3365
		' (get) Token: 0x06003C6D RID: 15469 RVA: 0x001A5047 File Offset: 0x001A3247
		' (set) Token: 0x06003C6E RID: 15470 RVA: 0x001A504F File Offset: 0x001A324F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TabAlignment As TabAlignment
			Get
				Return Me.o_0.o0.
			End Get
			Set(value As TabAlignment)
				Me.o_0.o0. = value
			End Set
		End Property

		' Token: 0x17000D26 RID: 3366
		' (get) Token: 0x06003C6F RID: 15471 RVA: 0x001A5058 File Offset: 0x001A3258
		' (set) Token: 0x06003C70 RID: 15472 RVA: 0x001A5060 File Offset: 0x001A3260
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ImageFile As String
			Get
				Return Me.Oooo_.__OO00o.
			End Get
			Set(value As String)
				Me.Oooo_.__OO00o. = value
			End Set
		End Property

		' Token: 0x17000D27 RID: 3367
		' (get) Token: 0x06003C71 RID: 15473 RVA: 0x001A5069 File Offset: 0x001A3269
		' (set) Token: 0x06003C72 RID: 15474 RVA: 0x001A5076 File Offset: 0x001A3276
		Public Property BackColor As Color
			Get
				Return Me.Pane.BackColor
			End Get
			Set(value As Color)
				Me.Pane.BackColor = value
			End Set
		End Property

		' Token: 0x17000D28 RID: 3368
		' (get) Token: 0x06003C73 RID: 15475 RVA: 0x001A5084 File Offset: 0x001A3284
		' (set) Token: 0x06003C74 RID: 15476 RVA: 0x001A5087 File Offset: 0x001A3287
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BackGroundImageFile As String
			Get
				Return Nothing
			End Get
			Set(value As String)
				Me.Pane.BackgroundImage = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x17000D29 RID: 3369
		' (get) Token: 0x06003C75 RID: 15477 RVA: 0x001A509A File Offset: 0x001A329A
		' (set) Token: 0x06003C76 RID: 15478 RVA: 0x001A50A7 File Offset: 0x001A32A7
		Public Property Image As Image
			Get
				Return Me.Pane.BackgroundImage
			End Get
			Set(value As Image)
				Me.Pane.BackgroundImage = value
			End Set
		End Property

		' Token: 0x17000D2A RID: 3370
		' (get) Token: 0x06003C77 RID: 15479 RVA: 0x001A50B5 File Offset: 0x001A32B5
		' (set) Token: 0x06003C78 RID: 15480 RVA: 0x001A50C2 File Offset: 0x001A32C2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BackgroundImageLayout As ImageLayout
			Get
				Return Me.Pane.BackgroundImageLayout
			End Get
			Set(value As ImageLayout)
				Me.Pane.BackgroundImageLayout = value
			End Set
		End Property

		' Token: 0x17000D2B RID: 3371
		' (get) Token: 0x06003C79 RID: 15481 RVA: 0x001A50D0 File Offset: 0x001A32D0
		' (set) Token: 0x06003C7A RID: 15482 RVA: 0x001A50DD File Offset: 0x001A32DD
		Public Property ImageLayout As ImageLayout
			Get
				Return Me.Pane.BackgroundImageLayout
			End Get
			Set(value As ImageLayout)
				Me.Pane.BackgroundImageLayout = value
			End Set
		End Property

		' Token: 0x17000D2C RID: 3372
		' (get) Token: 0x06003C7B RID: 15483 RVA: 0x001A50EB File Offset: 0x001A32EB
		' (set) Token: 0x06003C7C RID: 15484 RVA: 0x001A50F3 File Offset: 0x001A32F3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property StartPosition As FormStartPosition
			Get
				Return Me.o_0.o0.
			End Get
			Set(value As FormStartPosition)
				Me.o_0.o0. = value
			End Set
		End Property

		' Token: 0x17000D2D RID: 3373
		' (get) Token: 0x06003C7D RID: 15485 RVA: 0x001A50FC File Offset: 0x001A32FC
		' (set) Token: 0x06003C7E RID: 15486 RVA: 0x001A5104 File Offset: 0x001A3304
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TopMost As Boolean
			Get
				Return Me.OOo__.oo.
			End Get
			Set(value As Boolean)
				Me.OOo__.oo. = value
			End Set
		End Property

		' Token: 0x17000D2E RID: 3374
		' (get) Token: 0x06003C7F RID: 15487 RVA: 0x001A510D File Offset: 0x001A330D
		' (set) Token: 0x06003C80 RID: 15488 RVA: 0x001A5115 File Offset: 0x001A3315
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Left As Integer
			Get
				Return Me.ooOO0__._0O.
			End Get
			Set(value As Integer)
				Me.ooOO0__._0O. = value
			End Set
		End Property

		' Token: 0x17000D2F RID: 3375
		' (get) Token: 0x06003C81 RID: 15489 RVA: 0x001A511E File Offset: 0x001A331E
		' (set) Token: 0x06003C82 RID: 15490 RVA: 0x001A5126 File Offset: 0x001A3326
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Top As Integer
			Get
				Return Me.O__O_Oo__o.0.
			End Get
			Set(value As Integer)
				Me.O__O_Oo__o.0. = value
			End Set
		End Property

		' Token: 0x17000D30 RID: 3376
		' (get) Token: 0x06003C83 RID: 15491 RVA: 0x001A512F File Offset: 0x001A332F
		' (set) Token: 0x06003C84 RID: 15492 RVA: 0x001A513C File Offset: 0x001A333C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Width As Integer
			Get
				Return Me.Pane.Width
			End Get
			Set(value As Integer)
				Me.Pane.Width = value
			End Set
		End Property

		' Token: 0x17000D31 RID: 3377
		' (get) Token: 0x06003C85 RID: 15493 RVA: 0x001A514A File Offset: 0x001A334A
		' (set) Token: 0x06003C86 RID: 15494 RVA: 0x001A5157 File Offset: 0x001A3357
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Height As Integer
			Get
				Return Me.Pane.Height
			End Get
			Set(value As Integer)
				Me.Pane.Height = value
			End Set
		End Property

		' Token: 0x06003C87 RID: 15495 RVA: 0x001A5165 File Offset: 0x001A3365
		<oO0oooo("2312")>
		Public Sub SetBounds(x As Integer, y As Integer, Width As Integer, Height As Integer)
			If Me.Pane.FindForm() IsNot Main.OO_O.o. Then
				Dim form As Form = Me.Pane.FindForm()
				form.ClientSize = New Size(Width, Height)
				form.Location = New Point(x, y)
			End If
		End Sub

		' Token: 0x17000D32 RID: 3378
		' (get) Token: 0x06003C88 RID: 15496 RVA: 0x001A51A0 File Offset: 0x001A33A0
		' (set) Token: 0x06003C89 RID: 15497 RVA: 0x001A51A8 File Offset: 0x001A33A8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property DockArea As DockAreaEnum
			Get
				Return Me.ooOO0__._0O.
			End Get
			Set(value As DockAreaEnum)
				Me.ooOO0__._0O. = value
			End Set
		End Property

		' Token: 0x17000D33 RID: 3379
		' (get) Token: 0x06003C8A RID: 15498 RVA: 0x001A51B1 File Offset: 0x001A33B1
		' (set) Token: 0x06003C8B RID: 15499 RVA: 0x001A51B9 File Offset: 0x001A33B9
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AllowResize As Boolean
			Get
				Return Me.o._oOO_o.
			End Get
			Set(value As Boolean)
				Me.o._oOO_o. = value
			End Set
		End Property

		' Token: 0x17000D34 RID: 3380
		' (get) Token: 0x06003C8C RID: 15500 RVA: 0x001A51C2 File Offset: 0x001A33C2
		' (set) Token: 0x06003C8D RID: 15501 RVA: 0x001A51CA File Offset: 0x001A33CA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoLayout As Boolean
			Get
				Return Me.O.O0Oo_.
			End Get
			Set(value As Boolean)
				Me.O.O0Oo_. = value
			End Set
		End Property

		' Token: 0x17000D35 RID: 3381
		' (get) Token: 0x06003C8E RID: 15502 RVA: 0x001A51D3 File Offset: 0x001A33D3
		' (set) Token: 0x06003C8F RID: 15503 RVA: 0x001A51DB File Offset: 0x001A33DB
		Public Property AutoResizeFonts As Boolean
			Get
				Return Me.O0__OO_0.o_oo.
			End Get
			Set(value As Boolean)
				Me.O0__OO_0.o_oo. = value
			End Set
		End Property

		' Token: 0x17000D36 RID: 3382
		' (get) Token: 0x06003C90 RID: 15504 RVA: 0x001A51E4 File Offset: 0x001A33E4
		' (set) Token: 0x06003C91 RID: 15505 RVA: 0x001A51EC File Offset: 0x001A33EC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ShowDockCaption As Boolean
			Get
				Return Me.O._o_oO.
			End Get
			Set(value As Boolean)
				Me.O._o_oO. = value
			End Set
		End Property

		' Token: 0x17000D37 RID: 3383
		' (get) Token: 0x06003C92 RID: 15506 RVA: 0x001A51F5 File Offset: 0x001A33F5
		' (set) Token: 0x06003C93 RID: 15507 RVA: 0x001A51FD File Offset: 0x001A33FD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ShowCloseButton As Boolean
			Get
				Return Me.Oo._0O0OoOO_o0.
			End Get
			Set(value As Boolean)
				Me.Oo._0O0OoOO_o0. = value
			End Set
		End Property

		' Token: 0x17000D38 RID: 3384
		' (get) Token: 0x06003C94 RID: 15508 RVA: 0x001A5206 File Offset: 0x001A3406
		' (set) Token: 0x06003C95 RID: 15509 RVA: 0x001A520E File Offset: 0x001A340E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoHide As Boolean
			Get
				Return Me.o0.Ooo_oo0.
			End Get
			Set(value As Boolean)
				Me.o0.Ooo_oo0. = value
			End Set
		End Property

		' Token: 0x17000D39 RID: 3385
		' (get) Token: 0x06003C96 RID: 15510 RVA: 0x001A5218 File Offset: 0x001A3418
		' (set) Token: 0x06003C97 RID: 15511 RVA: 0x001A5240 File Offset: 0x001A3440
		Public Property TimerEnabled As Boolean
			Get
				Return Me.Timer IsNot Nothing AndAlso Me.Timer.Enabled
			End Get
			Set(value As Boolean)
				If value AndAlso Me.Timer Is Nothing Then
					Me.Timer = New System.Windows.Forms.Timer()
					If Me.TimerInterval > 0 Then
						Me.Timer.Interval = Me.TimerInterval
					Else
						Me.Timer.Interval = 1000
					End If
				End If
				If Me.Timer IsNot Nothing Then
					Me.Timer.Enabled = value
				End If
			End Set
		End Property

		' Token: 0x17000D3A RID: 3386
		' (get) Token: 0x06003C98 RID: 15512 RVA: 0x001A52A3 File Offset: 0x001A34A3
		' (set) Token: 0x06003C99 RID: 15513 RVA: 0x001A52AB File Offset: 0x001A34AB
		Public Property TimerInterval As Integer
			Get
				Return Me.O0000OO.o.
			End Get
			Set(value As Integer)
				If Me.Timer IsNot Nothing Then
					Me.Timer.Interval = value
				End If
				Me.O0000OO.o. = value
			End Set
		End Property

		' Token: 0x17000D3B RID: 3387
		' (get) Token: 0x06003C9A RID: 15514 RVA: 0x001A52C8 File Offset: 0x001A34C8
		' (set) Token: 0x06003C9B RID: 15515 RVA: 0x001A52D5 File Offset: 0x001A34D5
		Public Property AutoScroll As Boolean
			Get
				Return Me.Pane.AutoScroll
			End Get
			Set(value As Boolean)
				Me.Pane.AutoScroll = value
			End Set
		End Property

		' Token: 0x17000D3C RID: 3388
		' (get) Token: 0x06003C9C RID: 15516 RVA: 0x001A52E3 File Offset: 0x001A34E3
		' (set) Token: 0x06003C9D RID: 15517 RVA: 0x001A52F0 File Offset: 0x001A34F0
		<oO0oooo("1853")>
		Public Property ExtendSize As Size
			Get
				Return Me.Pane.AutoScrollMinSize
			End Get
			Set(value As Size)
				Me.Pane.AutoScrollMinSize = value
			End Set
		End Property

		' Token: 0x06003C9E RID: 15518 RVA: 0x001A52FE File Offset: 0x001A34FE
		<oO0oooo("1574")>
		Public Sub StopRedraw()
			ShareLibriay.LockWindowUpdate(Me.Pane.Handle)
		End Sub

		' Token: 0x06003C9F RID: 15519 RVA: 0x001A5311 File Offset: 0x001A3511
		<oO0oooo("1574")>
		Public Sub ResumeRedraw()
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
		End Sub

		' Token: 0x06003CA0 RID: 15520 RVA: 0x001A531E File Offset: 0x001A351E
		Public Sub Refresh()
			Me.Pane.Refresh()
		End Sub

		' Token: 0x17000D3D RID: 3389
		' (get) Token: 0x06003CA1 RID: 15521 RVA: 0x001A532B File Offset: 0x001A352B
		' (set) Token: 0x06003CA2 RID: 15522 RVA: 0x001A533C File Offset: 0x001A353C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property PageSetting As String
			Get
				Return o_O_o_oOoo__.OOOO_OO._oo.(Me.oO0.O_OO_OO_., False, vbTab, False)
			End Get
			Set(value As String)
				Me.Oo0oo000_._OO. = value
			End Set
		End Property

		' Token: 0x17000D3E RID: 3390
		' (get) Token: 0x06003CA3 RID: 15523 RVA: 0x001A5345 File Offset: 0x001A3545
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Page As PrintPageProperty
			Get
				If Operators.CompareString(Me.Oo0oo000_._OO., "", True) > 0 Then
					o_O_o_oOoo__.OOOO_OO._oo.(Me.oO0.O_OO_OO_., Me.Oo0oo000_._OO., vbTab)
					Me.Oo0oo000_._OO. = ""
				End If
				Return Me.oO0.O_OO_OO_.
			End Get
		End Property

		' Token: 0x06003CA4 RID: 15524 RVA: 0x001A537F File Offset: 0x001A357F
		<oO0oooo("1590")>
		Public Function GernatePrintDoc() As PrintDoc
			Return Me.GernatePrintDoc(Me.Pane)
		End Function

		' Token: 0x06003CA5 RID: 15525 RVA: 0x001A5390 File Offset: 0x001A3590
		<oO0oooo("2437")>
		Public Function GernatePrintDoc(Control As Object) As PrintDoc
			Dim result As PrintDoc
			If TypeOf Control Is GroupBox Then
				result = Me.GernatePrintDoc(CType(Control, GroupBox).BaseControl)
			ElseIf TypeOf Control Is Panel Then
				result = Me.GernatePrintDoc(CType(Control, Panel).BaseControl)
			ElseIf TypeOf Control Is TabPage Then
				result = Me.GernatePrintDoc(CType(Control, TabPage))
			ElseIf TypeOf Control Is SplitPanel Then
				result = Me.GernatePrintDoc(CType(Control, SplitPanel).BaseControl)
			ElseIf TypeOf Control Is NavPage Then
				result = Me.GernatePrintDoc(CType(Control, NavPage))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x17000D3F RID: 3391
		' (get) Token: 0x06003CA6 RID: 15526 RVA: 0x001A5422 File Offset: 0x001A3622
		' (set) Token: 0x06003CA7 RID: 15527 RVA: 0x001A542A File Offset: 0x001A362A
		Public Property PrintAutoMoveByLine As Boolean

		' Token: 0x17000D40 RID: 3392
		' (get) Token: 0x06003CA8 RID: 15528 RVA: 0x001A5433 File Offset: 0x001A3633
		' (set) Token: 0x06003CA9 RID: 15529 RVA: 0x001A543B File Offset: 0x001A363B
		Public Property PrintAutoMoveByTable As Boolean

		' Token: 0x06003CAA RID: 15530 RVA: 0x001A5444 File Offset: 0x001A3644
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GernatePrintDoc(Container As Control) As PrintDoc
			Dim num As Integer
			Dim result As PrintDoc
			Dim num19 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim printDoc As PrintDoc = New PrintDoc()
				IL_10:
				num2 = 3
				Dim dataTable As DataTable = New DataTable()
				IL_19:
				num2 = 4
				Me.Oo0oo000_._OO. = 0
				IL_22:
				num2 = 5
				printDoc.ResolvedUnit = 3
				IL_2C:
				num2 = 6
				dataTable.Columns.Add("Name", GetType(String))
				IL_4A:
				num2 = 7
				dataTable.Columns.Add("Control", GetType(Control))
				IL_68:
				num2 = 8
				dataTable.Columns.Add("Left", GetType(Double))
				IL_86:
				num2 = 9
				dataTable.Columns.Add("Top", GetType(Double))
				IL_A5:
				num2 = 10
				dataTable.Columns.Add("Width", GetType(Double))
				IL_C4:
				num2 = 11
				dataTable.Columns.Add("Height", GetType(Double))
				IL_E3:
				num2 = 12
				dataTable.Columns.Add("Right", GetType(Double))
				IL_102:
				num2 = 13
				dataTable.Columns.Add("Bottom", GetType(Double))
				IL_121:
				num2 = 14
				dataTable.Columns.Add("MinRows", GetType(Integer))
				IL_140:
				num2 = 15
				dataTable.Columns.Add("MaxRows", GetType(Integer))
				IL_15F:
				num2 = 16
				dataTable.Columns.Add("NewPage", GetType(Boolean))
				IL_17E:
				num2 = 17
				dataTable.Columns.Add("PrintRowNumber", GetType(Integer))
				IL_19D:
				num2 = 18
				dataTable.Columns.Add("PrintBorder", GetType(Boolean))
				IL_1BC:
				num2 = 19
				dataTable.Columns.Add("Index", GetType(Double))
				IL_1DB:
				num2 = 20
				printDoc.PrinterName = Me.Page.PrinterName
				IL_1F0:
				num2 = 21
				Dim c1PageSettings As C1PageSettings = printDoc.PageSetting
				IL_1FC:
				num2 = 22
				c1PageSettings.PaperKind = Me.Page.PaperKind
				IL_211:
				num2 = 23
				If Not Me.Page.Landscape Then
					GoTo IL_22C
				End If
				IL_221:
				num2 = 24
				c1PageSettings.Landscape = True
				IL_22C:
				num2 = 25
				If Me.Page.Width <= 0.0 OrElse Me.Page.Height <= 0.0 Then
					GoTo IL_28F
				End If
				IL_25B:
				num2 = 26
				c1PageSettings.Width = Me.Page.Width
				IL_275:
				num2 = 27
				c1PageSettings.Height = Me.Page.Height
				IL_28F:
				num2 = 28
				c1PageSettings.LeftMargin = Me.Page.LeftMargin
				IL_2A9:
				num2 = 29
				c1PageSettings.RightMargin = Me.Page.RightMargin
				IL_2C3:
				num2 = 30
				c1PageSettings.TopMargin = Me.Page.TopMargin
				IL_2DD:
				num2 = 31
				c1PageSettings.BottomMargin = Me.Page.BottomMargin
				IL_2F7:
				c1PageSettings = Nothing
				IL_2FA:
				num2 = 33
				Dim enumerator As IEnumerator = Container.Controls.GetEnumerator()
				Dim num4 As Integer
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim control As Control = CType(obj, Control)
					IL_31D:
					num2 = 34
					If Me.PrintSettings.CanExtend(control) Then
						IL_332:
						num2 = 35
						If Me.PrintSettings.GetPrintable(control) Then
							IL_347:
							num2 = 37
							Dim dataRow As DataRow = dataTable.NewRow()
							IL_353:
							num2 = 38
							Dim control2 As Control = ooO_0O.o_O0.O_.(control)
							IL_35F:
							num2 = 39
							control2.o.__O0O. = Me
							IL_36A:
							num2 = 40
							dataRow("Name") = control2.Name
							IL_380:
							num2 = 41
							dataRow("Control") = control2
							IL_391:
							num2 = 42
							dataRow("Left") = CDbl((CSng(control.Left) / SysInfo.ScreenDpiX)) * 25.4 + Me.Page.LeftMargin
							IL_3CA:
							num2 = 43
							dataRow("Top") = CDbl((CSng(control.Top) / SysInfo.ScreenDpiY)) * 25.4 + Me.Page.TopMargin
							IL_403:
							num2 = 44
							dataRow("Width") = CDbl((CSng(control.Width) / SysInfo.ScreenDpiX)) * 25.4
							IL_430:
							num2 = 45
							dataRow("Height") = CDbl((CSng(control.Height) / SysInfo.ScreenDpiY)) * 25.4
							IL_45D:
							num2 = 46
							dataRow("Right") = CDbl((CSng((control.Left + control.Width)) / SysInfo.ScreenDpiX)) * 25.4 + Me.Page.LeftMargin
							IL_49E:
							num2 = 47
							dataRow("Bottom") = CDbl((CSng((control.Top + control.Height)) / SysInfo.ScreenDpiY)) * 25.4 + Me.Page.TopMargin
							IL_4DF:
							num2 = 48
							dataRow("MinRows") = Me.PrintSettings.GetMinRows(control)
							IL_500:
							num2 = 49
							dataRow("NewPage") = Me.PrintSettings.GetNewPage(control)
							IL_521:
							num2 = 50
							dataRow("PrintBorder") = Me.PrintSettings.O0O.o____o00.(control)
							IL_542:
							num2 = 51
							If control2.o.__O0O. = ControlTypeEnum.Table Then
								IL_553:
								num2 = 52
								Dim num3 As Integer = CType(control, C1FlexGrid).Rows.Count - CType(control, C1FlexGrid).Rows.Fixed
								IL_57B:
								num2 = 53
								Dim maxRows As Integer = Me.PrintSettings.GetMaxRows(control)
								IL_58D:
								num2 = 54
								dataRow("MaxRows") = maxRows
								IL_5A3:
								num2 = 55
								If maxRows > 0 Then
									IL_5AB:
									num2 = 56
									num4 = CInt(Math.Round(Math.Max(CDbl(num4), Math.Ceiling(CDbl(num3) / CDbl(maxRows)))))
								End If
							End If
							IL_5CA:
							num2 = 57
							dataRow("PrintRowNumber") = Me.PrintSettings.GetPrintRowNumber(control)
							IL_5EB:
							num2 = 58
							dataTable.Rows.Add(dataRow)
						End If
					End If
					IL_5FC:
					num2 = 59
				End While
				IL_60B:
				num2 = 60
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_623:
				num2 = 61
				Dim array As DataRow() = dataTable.[Select]("", "Top,Left", DataViewRowState.CurrentRows)
				IL_63B:
				num2 = 62
				Dim num5 As Integer = array.Length - 1
				For i As Integer = 0 To num5
					IL_64B:
					num2 = 63
					array(i)("Index") = i
					IL_664:
					num2 = 64
				Next
				IL_673:
				num2 = 65
				array = dataTable.[Select]("", "index", DataViewRowState.CurrentRows)
				IL_68B:
				num2 = 66
				Dim num6 As Integer = array.Length - 1
				For j As Integer = 0 To num6
					IL_69E:
					num2 = 67
					If(TypeOf array(j)("Control")Is Table AndAlso Me.PrintAutoMoveByTable) OrElse (TypeOf array(j)("Control")Is Line AndAlso Me.PrintAutoMoveByLine) Then
						IL_6E3:
						num2 = 68
						Dim flag As Boolean = Conversions.ToBoolean(array(j)("NewPage"))
						IL_6FC:
						num2 = 69
						Dim array2 As DataRow() = dataTable.[Select](String.Concat(New String() { "[Top] >= ", array(j)("Top").ToString(), " And [Top] <= ", array(j)("Bottom").ToString(), " And [Name] <> '", array(j)("Name").ToString(), "'" }), "Index")
						IL_77D:
						num2 = 70
						If array2.Length > 0 Then
							IL_78A:
							num2 = 71
							array(j)("NewPage") = False
							IL_7A2:
							num2 = 72
							Dim num7 As Integer = array2.Length - 1
							Dim k As Integer = 0
							While k <= num7
								IL_7B5:
								num2 = 73
								If Not(TypeOf array2(k)("Control")Is Line) Then
									GoTo IL_7FE
								End If
								IL_7CE:
								num2 = 74
								If Conversions.ToDouble(array2(k)("Bottom")) <= Conversions.ToDouble(array(j)("Bottom")) Then
									IL_7FB:
									num2 = 77
									GoTo IL_7FE
								End If
								IL_868:
								num2 = 82
								k += 1
								Continue While
								IL_7FE:
								num2 = 78
								array2(k)("Index") = Conversions.ToDouble(array(j)("Index")) - 1.0 + CDbl((k + 1)) * 1E-06
								IL_843:
								num2 = 79
								If flag Then
									IL_84A:
									num2 = 80
									flag = False
									IL_850:
									num2 = 81
									array2(k)("NewPage") = True
									GoTo IL_868
								End If
								GoTo IL_868
							End While
						End If
					End If
					IL_87A:
					num2 = 83
				Next
				IL_88C:
				num2 = 84
				dataTable.AcceptChanges()
				IL_896:
				num2 = 85
				If num4 <> 0 Then
					GoTo IL_8A3
				End If
				IL_89D:
				num2 = 86
				num4 = 1
				IL_8A3:
				num2 = 87
				Dim num8 As Integer = num4
				For l As Integer = 1 To num8
					IL_8B2:
					num2 = 88
					array = dataTable.[Select]("", "index", DataViewRowState.CurrentRows)
					IL_8CA:
					num2 = 89
					Dim num9 As Integer = array.Length - 1
					For m As Integer = 0 To num9
						IL_8DD:
						num2 = 90
						If Conversions.ToBoolean(array(m)("NewPage")) Then
							IL_8F9:
							num2 = 91
							Dim num10 As Double = Conversions.ToDouble(array(m)("Top")) - printDoc.PageSetting.TopMargin.Value
							IL_928:
							num2 = 92
							Dim num11 As Integer = m
							Dim num12 As Integer = array.Length - 1
							For n As Integer = num11 To num12
								IL_939:
								num2 = 93
								array(n)("Top") = Conversions.ToDouble(array(n)("Top")) - num10
								IL_967:
								num2 = 94
								array(n)("Bottom") = Conversions.ToDouble(array(n)("Bottom")) - num10
								IL_995:
								num2 = 95
							Next
						End If
						IL_9A4:
						num2 = 96
						Dim obj2 As Object
						If m = 0 OrElse Conversions.ToBoolean(array(m)("NewPage")) Then
							IL_9C1:
							num2 = 97
							obj2 = Conversions.ToDouble(array(m)("Top"))
						Else
							IL_9E4:
							num2 = 99
							Dim num13 As Double = Conversions.ToDouble(array(m)("Top"))
							IL_9FD:
							num2 = 100
							Dim num14 As Double = Conversions.ToDouble(array(m - 1)("Top"))
							IL_A18:
							num2 = 101
							Dim num15 As Double = Conversions.ToDouble(array(m - 1)("Bottom"))
							IL_A33:
							num2 = 102
							If TypeOf array(m)("Control")Is Line Then
								IL_A4C:
								num2 = 103
								obj2 = "Prev.Bottom + " + Conversions.ToString(num13 - num15)
							Else
								IL_A67:
								num2 = 105
								If num13 < num15 Then
									IL_A70:
									num2 = 106
									obj2 = "Prev.Top + " + Conversions.ToString(num13 - num14)
								Else
									IL_A8B:
									num2 = 108
									obj2 = "Prev.Bottom + " + Conversions.ToString(num13 - num15)
								End If
							End If
						End If
						IL_AA4:
						num2 = 109
						If Conversions.ToBoolean(array(m)("NewPage")) Then
							IL_ABD:
							num2 = 110
							Dim num16 As Integer = Me.Oo0oo000_._OO. - 1
							For num17 As Integer = 0 To num16
								IL_ACF:
								num2 = 111
								Dim renderEmpty As RenderEmpty = New RenderEmpty()
								IL_AD9:
								num2 = 112
								renderEmpty.BreakAfter = 1
								IL_AE4:
								num2 = 113
								printDoc.Body.Children.Add(renderEmpty)
								IL_AFB:
								num2 = 114
							Next
							IL_B0A:
							num2 = 115
							Me.Oo0oo000_._OO. = 0
						End If
						IL_B14:
						num2 = 116
						Me.Oo0Oo0000.__.(printDoc, array(m), l, obj2.ToString(), Conversions.ToBoolean(array(m)("NewPage")), Conversions.ToBoolean(array(m)("PrintBorder")))
						IL_B55:
						num2 = 117
					Next
					IL_B67:
					num2 = 118
					dataTable.RejectChanges()
					IL_B71:
					num2 = 119
					If l < num4 Then
						IL_B7A:
						num2 = 120
						Dim renderEmpty2 As RenderEmpty = New RenderEmpty()
						IL_B84:
						num2 = 121
						renderEmpty2.BreakAfter = 1
						IL_B8F:
						num2 = 122
						printDoc.Body.Children.Add(renderEmpty2)
					End If
					IL_BA6:
					num2 = 123
				Next
				IL_BB8:
				num2 = 124
				printDoc.AutoRotate = False
				IL_BC3:
				num2 = 125
				result = printDoc
				IL_BC9:
				GoTo IL_E13
				IL_BCE:
				Dim num18 As Integer = num19 + 1
				num19 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num18)
				IL_DD4:
				GoTo IL_E08
				IL_DD6:
				num19 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_DE6:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num19 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_DD6
			End Try
			IL_E08:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E13:
			If num19 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003CAB RID: 15531 RVA: 0x001A628C File Offset: 0x001A448C
		Private Sub <<EMPTY_NAME>>(A_0 As C1PrintDocument, A_1 As DataRow, A_2 As Integer, A_3 As String, A_4 As Boolean, A_5 As Boolean)
			Dim num As Integer
			Dim num33 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim control As Control = CType(A_1("Control"), Control)
				IL_1A:
				num2 = 3
				Dim o.__O0O. As ControlTypeEnum = control.o.__O0O.
				If o.__O0O. <= ControlTypeEnum.Gauges Then
					Select Case o.__O0O.
						Case ControlTypeEnum.Label, ControlTypeEnum.TextBox, ControlTypeEnum.ComboBox, ControlTypeEnum.NumericComboBox, ControlTypeEnum.DateTimePicker, ControlTypeEnum.CheckedComboBox, ControlTypeEnum.DropDownBox, ControlTypeEnum.TimeSpanBox
							IL_E8:
							num2 = 5
							Dim renderText As RenderText = New RenderText()
							IL_F1:
							num2 = 6
							renderText.Text = control.BaseControl.Text
							IL_105:
							num2 = 7
							renderText.X = Conversions.ToDouble(A_1("Left"))
							IL_123:
							num2 = 8
							renderText.Y = A_3
							IL_133:
							num2 = 9
							renderText.Height = Conversions.ToDouble(A_1("Height"))
							IL_152:
							num2 = 10
							renderText.Width = Conversions.ToDouble(A_1("Width"))
							IL_171:
							num2 = 11
							renderText.Style.Font = control.BaseControl.Font
							IL_18B:
							num2 = 12
							renderText.Style.TextColor = control.BaseControl.ForeColor
							IL_1A5:
							num2 = 13
							If Not A_4 Then
								GoTo IL_1D7
							End If
							IL_1AC:
							num2 = 14
							Dim renderEmpty As RenderEmpty = New RenderEmpty()
							IL_1B6:
							num2 = 15
							renderEmpty.BreakAfter = 1
							IL_1C1:
							num2 = 16
							A_0.Body.Children.Add(renderEmpty)
							IL_1D7:
							num2 = 17
							Dim o.__O0O.2 As ControlTypeEnum = control.o.__O0O.
							Select Case o.__O0O.2
								Case ControlTypeEnum.Label
									IL_224:
									num2 = 19
									Dim c1Label As C1Label = CType(control.BaseControl, C1Label)
									IL_234:
									num2 = 20
									Dim textAlign As ContentAlignment = c1Label.TextAlign
									If textAlign <= ContentAlignment.MiddleCenter Then
										Select Case textAlign
											Case ContentAlignment.TopLeft
												GoTo IL_2AD
											Case ContentAlignment.TopCenter
											Case CType(3, ContentAlignment)
												GoTo IL_2CF
											Case ContentAlignment.TopRight
												GoTo IL_2BF
											Case Else
												If textAlign = ContentAlignment.MiddleLeft Then
													GoTo IL_2AD
												End If
												If textAlign <> ContentAlignment.MiddleCenter Then
													GoTo IL_2CF
												End If
										End Select
									ElseIf textAlign <= ContentAlignment.BottomLeft Then
										If textAlign = ContentAlignment.MiddleRight Then
											GoTo IL_2BF
										End If
										If textAlign <> ContentAlignment.BottomLeft Then
											GoTo IL_2CF
										End If
										GoTo IL_2AD
									ElseIf textAlign <> ContentAlignment.BottomCenter Then
										If textAlign <> ContentAlignment.BottomRight Then
											GoTo IL_2CF
										End If
										GoTo IL_2BF
									End If
									IL_29B:
									num2 = 22
									renderText.Style.TextAlignHorz = 1
									GoTo IL_2CF
									IL_2AD:
									num2 = 24
									renderText.Style.TextAlignHorz = 0
									GoTo IL_2CF
									IL_2BF:
									num2 = 26
									renderText.Style.TextAlignHorz = 2
									IL_2CF:
									num2 = 28
									Dim textAlign2 As ContentAlignment = c1Label.TextAlign
									If textAlign2 > ContentAlignment.MiddleCenter Then
										If textAlign2 <= ContentAlignment.BottomLeft Then
											If textAlign2 = ContentAlignment.MiddleRight Then
												GoTo IL_340
											End If
											If textAlign2 <> ContentAlignment.BottomLeft Then
												GoTo IL_362
											End If
										ElseIf textAlign2 <> ContentAlignment.BottomCenter AndAlso textAlign2 <> ContentAlignment.BottomRight Then
											GoTo IL_362
										End If
										IL_32E:
										num2 = 30
										renderText.Style.TextAlignVert = 2
										GoTo IL_362
									End If
									If textAlign2 <= ContentAlignment.TopRight Then
										If textAlign2 - ContentAlignment.TopLeft > 1 AndAlso textAlign2 <> ContentAlignment.TopRight Then
											GoTo IL_362
										End If
										IL_352:
										num2 = 34
										renderText.Style.TextAlignVert = 0
										GoTo IL_362
									End If
									If textAlign2 <> ContentAlignment.MiddleLeft AndAlso textAlign2 <> ContentAlignment.MiddleCenter Then
										GoTo IL_362
									End If
									IL_340:
									num2 = 32
									renderText.Style.TextAlignVert = 1
									IL_362:
									num2 = 36
									If Not A_5 Then
										GoTo IL_397
									End If
									IL_369:
									num2 = 37
									renderText.Style.Borders.All = New LineDef(0.1, c1Label.BorderColor)
									IL_397:
									c1Label = Nothing
									GoTo IL_4E9
								Case ControlTypeEnum.TextBox, ControlTypeEnum.ComboBox, ControlTypeEnum.NumericComboBox, ControlTypeEnum.DateTimePicker
								Case ControlTypeEnum.Button, ControlTypeEnum.CheckBox, ControlTypeEnum.RadioButton, ControlTypeEnum.TopicBar
									GoTo IL_4E9
								Case Else
									If o.__O0O.2 <> ControlTypeEnum.DropDownBox AndAlso o.__O0O.2 <> ControlTypeEnum.TimeSpanBox Then
										GoTo IL_4E9
									End If
							End Select
							IL_39F:
							num2 = 40
							renderText.Style.TextAlignVert = 1
							IL_3AF:
							num2 = 41
							Dim c1TextBox As C1TextBox = CType(control.BaseControl, C1TextBox)
							IL_3BF:
							num2 = 42
							If Not c1TextBox.Multiline Then
								GoTo IL_3DD
							End If
							IL_3CB:
							num2 = 43
							renderText.Style.TextAlignVert = 0
							GoTo IL_3ED
							IL_3DD:
							num2 = 45
							renderText.Style.TextAlignVert = 1
							IL_3ED:
							num2 = 46
							Select Case c1TextBox.TextAlign
								Case HorizontalAlignment.Left
									IL_420:
									num2 = 50
									renderText.Style.TextAlignHorz = 0
								Case HorizontalAlignment.Right
									IL_432:
									num2 = 52
									renderText.Style.TextAlignHorz = 2
								Case HorizontalAlignment.Center
									IL_40E:
									num2 = 48
									renderText.Style.TextAlignHorz = 1
							End Select
							IL_442:
							num2 = 54
							Select Case c1TextBox.VerticalAlign
								Case 0
									IL_463:
									num2 = 56
									renderText.Style.TextAlignVert = 0
								Case 1
									IL_475:
									num2 = 58
									renderText.Style.TextAlignVert = 1
								Case 2
									IL_487:
									num2 = 60
									renderText.Style.TextAlignVert = 2
							End Select
							IL_497:
							num2 = 62
							If Not A_5 Then
								GoTo IL_4E6
							End If
							IL_49E:
							num2 = 63
							renderText.Style.Padding.Left = 1
							IL_4B8:
							num2 = 64
							renderText.Style.Borders.All = New LineDef(0.1, c1TextBox.BorderColor)
							IL_4E6:
							c1TextBox = Nothing
							IL_4E9:
							num2 = 67
							A_0.Body.Children.Add(renderText)
							GoTo IL_215B
						Case ControlTypeEnum.Button, ControlTypeEnum.TopicBar, ControlTypeEnum.ListBox, ControlTypeEnum.CheckedListBox, ControlTypeEnum.GroupBox, ControlTypeEnum.Panel, ControlTypeEnum.SplitContainer, ControlTypeEnum.TabControl, ControlTypeEnum.TreeView, ControlTypeEnum.ProgressBar, ControlTypeEnum.FileManager, ControlTypeEnum.NavBar, ControlTypeEnum.DataList, ControlTypeEnum.WebBrowser, ControlTypeEnum.QRCode1, ControlTypeEnum.Calendar, ControlTypeEnum.TrackBar
							GoTo IL_215B
						Case ControlTypeEnum.CheckBox
							IL_BC2:
							num2 = 172
							Dim renderInputCheckBox As RenderInputCheckBox = New RenderInputCheckBox()
							IL_BCF:
							num2 = 173
							Dim checkBox As CheckBox = CType(control.BaseControl, CheckBox)
							IL_BE2:
							num2 = 174
							renderInputCheckBox.X = Conversions.ToDouble(A_1("Left"))
							IL_C04:
							num2 = 175
							renderInputCheckBox.Y = A_3
							IL_C18:
							num2 = 176
							renderInputCheckBox.Width = Conversions.ToDouble(A_1("Width"))
							IL_C3A:
							num2 = 177
							renderInputCheckBox.Height = Conversions.ToDouble(A_1("Height"))
							IL_C5C:
							num2 = 178
							renderInputCheckBox.Text = checkBox.Text
							IL_C70:
							num2 = 179
							renderInputCheckBox.Checked = checkBox.Checked
							IL_C84:
							num2 = 180
							renderInputCheckBox.CheckAlign = checkBox.CheckAlign
							IL_C98:
							num2 = 181
							renderInputCheckBox.[ReadOnly] = True
							IL_CA6:
							num2 = 182
							renderInputCheckBox.Style.Font = checkBox.Font
							IL_CBF:
							num2 = 183
							If Not A_4 Then
								GoTo IL_CFD
							End If
							IL_CC9:
							num2 = 184
							Dim renderEmpty2 As RenderEmpty = New RenderEmpty()
							IL_CD6:
							num2 = 185
							renderEmpty2.BreakAfter = 1
							IL_CE4:
							num2 = 186
							A_0.Body.Children.Add(renderEmpty2)
							IL_CFD:
							num2 = 187
							A_0.Body.Children.Add(renderInputCheckBox)
							GoTo IL_215B
						Case ControlTypeEnum.RadioButton
							IL_D1B:
							num2 = 189
							Dim renderInputRadioButton As RenderInputRadioButton = New RenderInputRadioButton()
							IL_D28:
							num2 = 190
							Dim radioButton As RadioButton = CType(control.BaseControl, RadioButton)
							IL_D3B:
							num2 = 191
							renderInputRadioButton.X = Conversions.ToDouble(A_1("Left"))
							IL_D5D:
							num2 = 192
							renderInputRadioButton.Y = A_3
							IL_D71:
							num2 = 193
							renderInputRadioButton.Width = Conversions.ToDouble(A_1("Width"))
							IL_D93:
							num2 = 194
							renderInputRadioButton.Height = Conversions.ToDouble(A_1("Height"))
							IL_DB5:
							num2 = 195
							renderInputRadioButton.Text = radioButton.Text
							IL_DC9:
							num2 = 196
							renderInputRadioButton.Checked = radioButton.Checked
							IL_DDD:
							num2 = 197
							renderInputRadioButton.CheckAlign = radioButton.CheckAlign
							IL_DF1:
							num2 = 198
							renderInputRadioButton.[ReadOnly] = True
							IL_DFF:
							num2 = 199
							renderInputRadioButton.Style.Font = radioButton.Font
							IL_E18:
							num2 = 200
							If Not A_4 Then
								GoTo IL_E56
							End If
							IL_E22:
							num2 = 201
							Dim renderEmpty3 As RenderEmpty = New RenderEmpty()
							IL_E2F:
							num2 = 202
							renderEmpty3.BreakAfter = 1
							IL_E3D:
							num2 = 203
							A_0.Body.Children.Add(renderEmpty3)
							IL_E56:
							num2 = 204
							A_0.Body.Children.Add(renderInputRadioButton)
							GoTo IL_215B
						Case ControlTypeEnum.PictureBox, ControlTypeEnum.Chart, ControlTypeEnum.PictureViewer, ControlTypeEnum.Painter
						Case ControlTypeEnum.ColorLabel
							IL_504:
							num2 = 69
							Dim renderText2 As RenderText = New RenderText()
							IL_50E:
							num2 = 70
							renderText2.Text = control.BaseControl.Text
							IL_523:
							num2 = 71
							renderText2.X = Conversions.ToDouble(A_1("Left"))
							IL_542:
							num2 = 72
							renderText2.Y = A_3
							IL_553:
							num2 = 73
							renderText2.Height = Conversions.ToDouble(A_1("Height"))
							IL_572:
							num2 = 74
							renderText2.Width = Conversions.ToDouble(A_1("Width"))
							IL_591:
							num2 = 75
							renderText2.Style.BackColor = control.BackColor
							IL_5A6:
							num2 = 76
							If Not A_4 Then
								GoTo IL_5D8
							End If
							IL_5AD:
							num2 = 77
							Dim renderEmpty4 As RenderEmpty = New RenderEmpty()
							IL_5B7:
							num2 = 78
							renderEmpty4.BreakAfter = 1
							IL_5C2:
							num2 = 79
							A_0.Body.Children.Add(renderEmpty4)
							IL_5D8:
							num2 = 80
							A_0.Body.Children.Add(renderText2)
							GoTo IL_215B
						Case ControlTypeEnum.Line
							IL_5F3:
							num2 = 82
							Dim lineControl As LineControl = CType(control.BaseControl, LineControl)
							IL_603:
							num2 = 83
							Dim lineDef As LineDef = New LineDef(CDbl((CSng(lineControl.Thickness) / SysInfo.ScreenDpiX)) * 25.4, lineControl.ForeColor, lineControl.DashStyle)
							IL_639:
							num2 = 84
							Dim num3 As Double = Conversions.ToDouble(A_1("Width"))
							IL_64E:
							num2 = 85
							Dim num4 As Double = Conversions.ToDouble(A_1("Height"))
							IL_663:
							num2 = 86
							Dim num5 As Double
							Dim num6 As Double
							Dim num7 As Double
							Dim num8 As Double
							Select Case lineControl.Direction
								Case 0
									IL_68B:
									num2 = 88
									num5 = 0.0
									IL_699:
									num2 = 89
									num6 = num4 / 2.0
									IL_6AA:
									num2 = 90
									num7 = num3
									IL_6B1:
									num2 = 91
									num8 = num6
								Case 1
									IL_6BD:
									num2 = 93
									num5 = num3 / 2.0
									IL_6CE:
									num2 = 94
									num6 = 0.0
									IL_6DC:
									num2 = 95
									num7 = num5
									IL_6E3:
									num2 = 96
									num8 = num4
								Case 2
									IL_6EC:
									num2 = 98
									num5 = 0.0
									IL_6FA:
									num2 = 99
									num6 = 0.0
									IL_708:
									num2 = 100
									num7 = 0.0 + num3
									IL_719:
									num2 = 101
									num8 = num4
								Case 3
									IL_722:
									num2 = 103
									num5 = 0.0
									IL_730:
									num2 = 104
									num6 = num4
									IL_737:
									num2 = 105
									num7 = num3
									IL_73E:
									num2 = 106
									num8 = 0.0
							End Select
							IL_74C:
							num2 = 108
							Dim renderLine As RenderLine = New RenderLine(num5, num6, num7, num8, lineDef)
							IL_774:
							num2 = 109
							renderLine.X = Conversions.ToDouble(A_1("Left"))
							IL_793:
							num2 = 110
							renderLine.Y = A_3
							IL_7A4:
							num2 = 111
							renderLine.Height = Conversions.ToDouble(A_1("Height"))
							IL_7C3:
							num2 = 112
							renderLine.Width = Conversions.ToDouble(A_1("Width"))
							IL_7E2:
							num2 = 113
							If Not A_4 Then
								GoTo IL_814
							End If
							IL_7E9:
							num2 = 114
							Dim renderEmpty5 As RenderEmpty = New RenderEmpty()
							IL_7F3:
							num2 = 115
							renderEmpty5.BreakAfter = 1
							IL_7FE:
							num2 = 116
							A_0.Body.Children.Add(renderEmpty5)
							IL_814:
							num2 = 117
							A_0.Body.Children.Add(renderLine)
							GoTo IL_215B
						Case ControlTypeEnum.BarCode
							IL_82F:
							num2 = 119
							Dim renderGraphics As RenderGraphics = New RenderGraphics()
							IL_839:
							num2 = 120
							renderGraphics.X = Conversions.ToDouble(A_1("Left"))
							IL_858:
							num2 = 121
							renderGraphics.Y = A_3
							IL_869:
							num2 = 122
							renderGraphics.Height = "Auto"
							IL_87D:
							num2 = 123
							renderGraphics.Width = "Auto"
							IL_891:
							num2 = 124
							Dim barCode As BarCode = CType(control, BarCode)
							IL_89C:
							num2 = 125
							barCode.DrawOnCanvas(renderGraphics.Graphics, 0.1F, 0.1F)
							IL_8B7:
							barCode = Nothing
							IL_8BA:
							num2 = 127
							If Not A_4 Then
								GoTo IL_8F5
							End If
							IL_8C1:
							num2 = 128
							Dim renderEmpty6 As RenderEmpty = New RenderEmpty()
							IL_8CE:
							num2 = 129
							renderEmpty6.BreakAfter = 1
							IL_8DC:
							num2 = 130
							A_0.Body.Children.Add(renderEmpty6)
							IL_8F5:
							num2 = 131
							A_0.Body.Children.Add(renderGraphics)
							GoTo IL_215B
						Case ControlTypeEnum.RecordGrid
							IL_E74:
							num2 = 206
							Dim c1FlexGrid As C1FlexGrid = CType(control.BaseControl, C1FlexGrid)
							IL_E87:
							num2 = 207
							Dim renderTable As RenderTable = New RenderTable()
							IL_E94:
							num2 = 208
							renderTable.Cols.Count = 2
							IL_EA7:
							num2 = 209
							renderTable.Width = Conversions.ToString(CDbl((CSng(c1FlexGrid.Width) / SysInfo.ScreenDpiX)) * 25.4) + "mm"
							IL_EE1:
							num2 = 210
							renderTable.CellStyle.Spacing.All = 0.7
							IL_F06:
							num2 = 211
							renderTable.Style.GridLines.All = New LineDef(Color.DarkGray)
							IL_F27:
							num2 = 212
							renderTable.Style.Font = c1FlexGrid.Font
							IL_F40:
							num2 = 213
							renderTable.SplitHorzBehavior = 1
							IL_F4E:
							num2 = 214
							renderTable.X = Conversions.ToDouble(A_1("Left"))
							IL_F70:
							num2 = 215
							renderTable.Y = A_3
							IL_F84:
							num2 = 216
							renderTable.Cols(0).Width = Conversions.ToString(CDbl((CSng(c1FlexGrid.Cols(0).WidthDisplay) / SysInfo.ScreenDpiX)) * 25.4) + "mm"
							IL_FD4:
							num2 = 217
							renderTable.Cols(1).Width = Conversions.ToString(CDbl((CSng((c1FlexGrid.Width - c1FlexGrid.Cols(0).WidthDisplay)) / SysInfo.ScreenDpiX)) * 25.4) + "mm"
							IL_102C:
							num2 = 218
							renderTable.CellStyle.TextAlignHorz = 0
							IL_103F:
							num2 = 219
							renderTable.CellStyle.TextAlignVert = 1
							IL_1052:
							num2 = 220
							Dim num9 As Integer = c1FlexGrid.Rows.Count - 1
							For i As Integer = 0 To num9
								IL_106D:
								num2 = 221
								Dim num10 As Integer
								renderTable.Cells(num10, 0).Text = c1FlexGrid.GetDataDisplay(i, 0)
								IL_1091:
								num2 = 222
								renderTable.Cells(num10, 1).Text = c1FlexGrid.GetDataDisplay(i, 1)
								IL_10B5:
								num2 = 223
								num10 += 1
								IL_10C1:
								num2 = 224
							Next
							IL_10D3:
							num2 = 225
							If Not A_4 Then
								GoTo IL_1111
							End If
							IL_10DD:
							num2 = 226
							Dim renderEmpty7 As RenderEmpty = New RenderEmpty()
							IL_10EA:
							num2 = 227
							renderEmpty7.BreakAfter = 1
							IL_10F8:
							num2 = 228
							A_0.Body.Children.Add(renderEmpty7)
							IL_1111:
							num2 = 229
							A_0.Generate()
							IL_111E:
							num2 = 230
							Dim count As Integer = A_0.Pages.Count
							IL_1131:
							num2 = 231
							A_0.Body.Children.Add(renderTable)
							IL_114A:
							num2 = 232
							A_0.Generate()
							IL_1157:
							num2 = 233
							Dim count2 As Integer = A_0.Pages.Count
							IL_116A:
							num2 = 234
							Me.Oo0oo000_._OO. = Me.Oo0oo000_._OO. + count2 - count
							GoTo IL_215B
						Case Else
							If o.__O0O. <> ControlTypeEnum.Gauges Then
								GoTo IL_215B
							End If
					End Select
				ElseIf o.__O0O. <> ControlTypeEnum.Map Then
					If o.__O0O. <> ControlTypeEnum.Table Then
						GoTo IL_215B
					End If
					IL_1187:
					num2 = 236
					Dim c1FlexGrid2 As C1FlexGrid = CType(control.BaseControl, C1FlexGrid)
					IL_119A:
					num2 = 237
					Dim renderTable2 As RenderTable = New RenderTable()
					IL_11A7:
					num2 = 238
					Dim dictionary As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)()
					IL_11B4:
					num2 = 239
					renderTable2.Style.Spacing.All = "0"
					IL_11D5:
					num2 = 240
					renderTable2.Style.GridLines.All = New LineDef(c1FlexGrid2.Styles.Normal.Border.Color)
					IL_1207:
					num2 = 241
					renderTable2.SplitHorzBehavior = 1
					IL_1215:
					num2 = 242
					renderTable2.CellStyle.Spacing.All = 0.7
					IL_123A:
					num2 = 243
					renderTable2.Width = "Auto"
					IL_1251:
					num2 = 244
					renderTable2.Style.Font = c1FlexGrid2.Font
					IL_126A:
					num2 = 245
					If Not A_4 Then
						GoTo IL_12A8
					End If
					IL_1274:
					num2 = 246
					Dim renderEmpty8 As RenderEmpty = New RenderEmpty()
					IL_1281:
					num2 = 247
					renderEmpty8.BreakAfter = 1
					IL_128F:
					num2 = 248
					A_0.Body.Children.Add(renderEmpty8)
					IL_12A8:
					num2 = 249
					renderTable2.X = Conversions.ToDouble(A_1("Left"))
					IL_12CA:
					num2 = 250
					renderTable2.Y = A_3
					IL_12DE:
					num2 = 251
					Dim num11 As Integer = c1FlexGrid2.Cols.Count - 1
					Dim num12 As Integer
					For j As Integer = 1 To num11
						IL_12FC:
						num2 = 252
						If c1FlexGrid2.Cols(j).Visible Then
							IL_131A:
							num2 = 253
							num12 += 1
							IL_1326:
							num2 = 256
							dictionary.Add(num12, j)
							IL_1337:
							num2 = 257
							Select Case c1FlexGrid2.Cols(j).StyleDisplay.TextAlign
								Case 0, 1, 2
									IL_13B7:
									num2 = 261
									renderTable2.Cols(num12).Style.TextAlignHorz = 0
								Case 3, 4, 5
									IL_1393:
									num2 = 259
									renderTable2.Cols(num12).Style.TextAlignHorz = 1
								Case 6, 7, 8
									IL_13DB:
									num2 = 263
									renderTable2.Cols(num12).Style.TextAlignHorz = 2
								Case 9, 10, 11
									IL_13FF:
									num2 = 265
									If c1FlexGrid2.Cols(j).DataType Is GetType(String) OrElse c1FlexGrid2.Cols(j).DataType Is GetType(DateTime) Then
										IL_1443:
										num2 = 266
										renderTable2.Cols(num12).Style.TextAlignHorz = 0
									Else
										IL_1464:
										num2 = 268
										renderTable2.Cols(num12).Style.TextAlignHorz = 2
									End If
							End Select
							IL_1483:
							num2 = 270
							renderTable2.Cols(num12).Width = CDbl((CSng(c1FlexGrid2.Cols(j).WidthDisplay) / SysInfo.ScreenDpiX)) * 25.4
							IL_14C6:
							num2 = 271
							renderTable2.Cols(num12).Style.TextAlignVert = 1
							IL_14E5:
							num2 = 272
							renderTable2.Cols(num12).Style.ImageAlign.AlignHorz = 1
							IL_1509:
							num2 = 273
							renderTable2.Cols(num12).Style.ImageAlign.AlignVert = 1
						End If
						IL_152D:
						num2 = 274
					Next
					IL_1542:
					num2 = 275
					renderTable2.Cols(0).Width = CDbl((CSng(c1FlexGrid2.Cols(0).WidthDisplay) / SysInfo.ScreenDpiX)) * 25.4
					IL_1583:
					num2 = 276
					renderTable2.Cols(0).Style.TextAlignHorz = 1
					IL_15A1:
					num2 = 277
					renderTable2.Cols(0).Style.TextAlignVert = 1
					IL_15BF:
					num2 = 278
					Dim num13 As Integer = c1FlexGrid2.Rows.Fixed - 1
					For k As Integer = 0 To num13
						IL_15DD:
						num2 = 279
						renderTable2.Rows(k).Height = CDbl((CSng(c1FlexGrid2.Rows(k).HeightDisplay) / SysInfo.ScreenDpiY)) * 25.4
						IL_1620:
						num2 = 280
						Dim num14 As Integer = num12
						For l As Integer = 1 To num14
							IL_1632:
							num2 = 281
							Dim num15 As Integer = dictionary(l)
							IL_1643:
							num2 = 282
							Dim mergedRange As CellRange = c1FlexGrid2.GetMergedRange(k, num15, False)
							IL_1657:
							num2 = 283
							Dim num16 As Integer = 0
							While True
								IL_1678:
								num2 = 285
								If mergedRange.c1 >= mergedRange.c2 OrElse c1FlexGrid2.Cols(mergedRange.c1).Visible Then
									Exit For
								End If
								IL_1662:
								num2 = 286
								mergedRange.c1 += 1
							End While
							IL_16A8:
							num2 = 288
							Dim c As Integer = mergedRange.c1
							Dim c2 As Integer = mergedRange.c2
							For m As Integer = c To c2
								IL_16C2:
								num2 = 289
								If Not c1FlexGrid2.Cols(m).Visible Then
									IL_16DD:
									num2 = 290
									num16 += 1
								End If
								IL_16E9:
								num2 = 291
							Next
							IL_16FB:
							num2 = 292
							mergedRange.c2 -= num16
							IL_1712:
							num2 = 293
							If mergedRange.IsSingleCell Then
								IL_1721:
								num2 = 294
								renderTable2.Cells(k, l).Text = c1FlexGrid2.GetDataDisplay(k, num15)
							Else
								IL_174C:
								num2 = 296
								If Not(num15 > mergedRange.c1 Or k > mergedRange.r1) Then
									IL_176B:
									num2 = 298
									renderTable2.Cells(k, l).Text = c1FlexGrid2.GetDataDisplay(k, num15)
									IL_1791:
									num2 = 299
									renderTable2.Cells(k, l).SpanCols = mergedRange.c2 - mergedRange.c1 + 1
									IL_17BD:
									num2 = 300
									renderTable2.Cells(k, l).SpanRows = mergedRange.r2 - mergedRange.r1 + 1
								End If
							End If
							IL_17E9:
							num2 = 301
							Dim cellRange As CellRange = c1FlexGrid2.GetCellRange(k, num15)
							IL_17FC:
							num2 = 302
							Select Case cellRange.StyleDisplay.TextAlign
								Case 0, 1, 2
									IL_186F:
									num2 = 306
									renderTable2.Cells(k, l).Style.TextAlignHorz = 0
								Case 3, 4, 5
									IL_184C:
									num2 = 304
									renderTable2.Cells(k, l).Style.TextAlignHorz = 1
								Case 6, 7, 8
									IL_1892:
									num2 = 308
									renderTable2.Cells(k, l).Style.TextAlignHorz = 2
								Case 9, 10, 11
									IL_18B5:
									num2 = 310
									renderTable2.Cells(k, l).Style.TextAlignHorz = 1
							End Select
							IL_18D6:
							num2 = 312
							renderTable2.Cells(k, l).Style.TextColor = cellRange.StyleDisplay.ForeColor
							IL_1902:
							num2 = 313
							renderTable2.Cells(k, l).Style.BackColor = cellRange.StyleDisplay.BackColor
							IL_192E:
							num2 = 314
						Next
						IL_1943:
						num2 = 315
					Next
					IL_1958:
					num2 = 316
					renderTable2.RowGroups(0, c1FlexGrid2.Rows.Fixed).Header = 3
					IL_197D:
					num2 = 317
					Dim num17 As Integer = c1FlexGrid2.Rows.Fixed
					IL_1991:
					num2 = 318
					Dim num18 As Integer = c1FlexGrid2.Rows.Count - 1
					IL_19A7:
					num2 = 319
					If A_1.IsNull("MaxRows") Then
						GoTo IL_19D2
					End If
					IL_19BA:
					num2 = 320
					Dim num19 As Integer = Conversions.ToInteger(A_1("MaxRows"))
					IL_19D2:
					num2 = 321
					If num19 <= 0 Then
						GoTo IL_1A26
					End If
					IL_19DD:
					num2 = 322
					num17 = c1FlexGrid2.Rows.Fixed + (A_2 - 1) * num19
					IL_19F8:
					num2 = 323
					num18 = Math.Min(c1FlexGrid2.Rows.Fixed + A_2 * num19 - 1, c1FlexGrid2.Rows.Count - 1)
					IL_1A26:
					num2 = 324
					Dim num20 As Integer = num17
					Dim num21 As Integer = num18
					For n As Integer = num20 To num21
						IL_1A39:
						num2 = 325
						Dim num22 As Integer = n - num17 + c1FlexGrid2.Rows.Fixed
						IL_1A53:
						num2 = 326
						renderTable2.Rows(num22).Height = CDbl((CSng(c1FlexGrid2.Rows(n).HeightDisplay) / SysInfo.ScreenDpiY)) * 25.4
						IL_1A96:
						num2 = 327
						Dim num23 As Integer
						If c1FlexGrid2.Rows(n).DataIndex >= 0 Then
							IL_1AB2:
							num2 = 328
							Dim tableCell As TableCell = renderTable2.Cells(num22, 0)
							num23 = c1FlexGrid2.Rows(n).DataIndex + 1
							tableCell.Text = num23.ToString()
						End If
						IL_1AEA:
						num2 = 329
						num23 = num12
						For num24 As Integer = 1 To num23
							IL_1AFC:
							num2 = 330
							Dim num25 As Integer = dictionary(num24)
							IL_1B0D:
							num2 = 331
							Dim mergedRange2 As CellRange = c1FlexGrid2.GetMergedRange(n, num25, False)
							IL_1B21:
							num2 = 332
							If mergedRange2.IsSingleCell OrElse mergedRange2.r1 = n Then
								IL_1B3E:
								num2 = 333
								Dim cellStyle As CellStyle = Nothing
								IL_1B47:
								num2 = 334
								Dim bitmap As Bitmap = New Bitmap(c1FlexGrid2.Cols(num25).WidthDisplay, c1FlexGrid2.Rows(n).HeightDisplay)
								IL_1B7A:
								num2 = 335
								Dim image As Image = Nothing
								IL_1B83:
								num2 = 336
								Dim image2 As Image = Nothing
								IL_1B8C:
								num2 = 337
								Dim a_ As CheckEnum = 0
								IL_1B95:
								num2 = 338
								Dim text As String = c1FlexGrid2.GetDataDisplay(n, num25, image2, a_)
								IL_1BAC:
								num2 = 339
								Dim graphics As Graphics = Graphics.FromImage(bitmap)
								IL_1BBB:
								num2 = 340
								If c1FlexGrid2.Cols(num25).DataType Is GetType(Boolean) Then
									IL_1BE0:
									num2 = 341
									image = ooO.oO0__o.0o__.(c1FlexGrid2, a_)
								End If
								IL_1BF1:
								num2 = 342
								Dim ownerDrawCellEventArgs As OwnerDrawCellEventArgs = New OwnerDrawCellEventArgs(Nothing, graphics, n, num25, Nothing, New Rectangle(0, 0, bitmap.Width, bitmap.Height), text, image2)
								IL_1C1F:
								num2 = 343
								If TypeOf control.BaseControl Is O_oOooO_O Then
									IL_1C32:
									num2 = 344
									Dim o_oOooO_O As O_oOooO_O = CType(control.BaseControl, O_oOooO_O)
									Dim a_2 As Object = c1FlexGrid2
									Dim a_3 As OwnerDrawCellEventArgs = ownerDrawCellEventArgs
									Dim a_4 As Boolean = True
									Dim a_5 As Boolean = True
									Dim flag As Boolean = False
									o_oOooO_O.OO_.00oO0Oo.(a_2, a_3, a_4, a_5, flag)
								End If
								IL_1C53:
								num2 = 345
								graphics.Dispose()
								IL_1C60:
								num2 = 346
								If ownerDrawCellEventArgs.Image IsNot Nothing Then
									IL_1C6F:
									num2 = 347
									image2 = ownerDrawCellEventArgs.Image
								End If
								IL_1C7E:
								num2 = 348
								text = ownerDrawCellEventArgs.Text
								IL_1C8D:
								num2 = 349
								If ownerDrawCellEventArgs.Style IsNot Nothing Then
									IL_1C9C:
									num2 = 350
									cellStyle = ownerDrawCellEventArgs.Style
								End If
								IL_1CAB:
								num2 = 351
								If image IsNot Nothing Then
									IL_1CB5:
									num2 = 352
									renderTable2.Cells(num22, num24).Image = image
								Else
									IL_1CD7:
									num2 = 354
									If image2 IsNot Nothing Then
										IL_1CE4:
										num2 = 355
										If Operators.CompareString(text, "", True) > 0 Then
											IL_1CFD:
											num2 = 356
											Dim renderImage As RenderImage = New RenderImage(image2)
											IL_1D0C:
											num2 = 357
											renderImage.Style.ImageAlign.AlignHorz = 0
											IL_1D24:
											num2 = 358
											renderImage.Style.ImageAlign.AlignVert = 1
											IL_1D3C:
											num2 = 359
											renderImage.Style.ImageAlign.StretchHorz = False
											IL_1D54:
											num2 = 360
											renderImage.Style.ImageAlign.StretchVert = False
											IL_1D6C:
											num2 = 361
											renderImage.Style.Spacing.Left = CDbl((2F / SysInfo.ScreenDpiX)) * 25.4
											IL_1D9E:
											num2 = 362
											renderImage.Style.Spacing.Right = CDbl((2F / SysInfo.ScreenDpiX)) * 25.4
											IL_1DD0:
											num2 = 363
											renderImage.Height = "parent.height"
											IL_1DE7:
											num2 = 364
											Dim renderArea As RenderArea = New RenderArea()
											IL_1DF4:
											num2 = 365
											Dim renderText3 As RenderText = New RenderText()
											IL_1E01:
											num2 = 366
											renderArea.Height = "parent.height"
											IL_1E18:
											num2 = 367
											renderArea.Stacking = 1
											IL_1E26:
											num2 = 368
											renderText3.Height = "parent.height"
											IL_1E3D:
											num2 = 369
											renderText3.Text = text
											IL_1E4C:
											num2 = 370
											renderArea.Children.Add(renderImage)
											IL_1E61:
											num2 = 371
											renderArea.Children.Add(renderText3)
											IL_1E76:
											num2 = 372
											renderTable2.Cells(num22, num24).RenderObject = renderArea
										Else
											IL_1E98:
											num2 = 374
											renderTable2.Cells(num22, num24).Image = image2
										End If
									Else
										IL_1EBA:
										num2 = 376
										renderTable2.Cells(num22, num24).Text = text
										IL_1ED7:
										num2 = 377
										renderTable2.Cells(num22, num24).Style.BackgroundImage = bitmap
										IL_1EF9:
										num2 = 378
										If cellStyle IsNot Nothing Then
											IL_1F03:
											num2 = 379
											renderTable2.Cells(num22, num24).Style.TextColor = cellStyle.ForeColor
											IL_1F2A:
											num2 = 380
											renderTable2.Cells(num22, num24).Style.BackColor = cellStyle.BackColor
										End If
									End If
								End If
								IL_1F51:
								num2 = 381
								If Not mergedRange2.IsSingleCell Then
									IL_1F60:
									num2 = 382
									renderTable2.Cells(num22, num24).SpanRows = mergedRange2.r2 - mergedRange2.r1 + 1
								End If
							End If
							IL_1F8C:
							num2 = 383
						Next
						IL_1FA1:
						num2 = 384
					Next
					IL_1FB6:
					num2 = 385
					Dim num26 As Integer = Conversions.ToInteger(A_1("MinRows"))
					IL_1FCE:
					num2 = 386
					If num26 <= 0 OrElse num18 - num17 + 1 >= num26 Then
						GoTo IL_20B9
					End If
					IL_1FEA:
					num2 = 387
					Dim num27 As Integer = num26 - Math.Max(0, num18 - num17 + 1)
					IL_2002:
					num2 = 388
					Dim num28 As Integer = num18 + 1
					Dim num29 As Integer = num18 + num27
					For num30 As Integer = num28 To num29
						IL_201A:
						num2 = 389
						Dim num31 As Integer = num30 - num17 + c1FlexGrid2.Rows.Fixed
						IL_2034:
						num2 = 390
						renderTable2.Rows(num31).Height = CDbl((CSng(c1FlexGrid2.Rows.DefaultSize) / SysInfo.ScreenDpiY)) * 25.4
						IL_2070:
						num2 = 391
						renderTable2.Cells(num31, 0).Text = (num30 - c1FlexGrid2.Rows.Fixed + 1).ToString()
						IL_20A4:
						num2 = 392
					Next
					IL_20B9:
					num2 = 393
					A_0.Generate()
					IL_20C6:
					num2 = 394
					Dim count3 As Integer = A_0.Pages.Count
					IL_20D9:
					num2 = 395
					A_0.Body.Children.Add(renderTable2)
					IL_20F2:
					num2 = 396
					A_0.Generate()
					IL_20FF:
					num2 = 397
					Dim count4 As Integer = A_0.Pages.Count
					IL_2112:
					num2 = 398
					Me.Oo0oo000_._OO. = Me.Oo0oo000_._OO. + count4 - count3
					IL_212A:
					num2 = 399
					If Conversions.ToBoolean(A_1("PrintRowNumber")) Then
						GoTo IL_215B
					End If
					IL_2142:
					num2 = 400
					renderTable2.Cols(0).Visible = False
					GoTo IL_215B
				End If
				IL_913:
				num2 = 133
				Dim image3 As Image = Nothing
				IL_91C:
				num2 = 134
				Dim renderImage2 As RenderImage = New RenderImage()
				IL_929:
				num2 = 135
				If control.o.__O0O. <> ControlTypeEnum.PictureBox Then
					GoTo IL_980
				End If
				IL_939:
				num2 = 136
				If CType(control, PictureBox).BorderStyle = BorderStyle.None Then
					GoTo IL_968
				End If
				IL_94C:
				num2 = 137
				renderImage2.Style.Borders.All = LineDef.[Default]
				IL_968:
				num2 = 138
				image3 = CType(control, PictureBox).Image
				GoTo IL_A5C
				IL_980:
				num2 = 140
				If control.o.__O0O. <> ControlTypeEnum.Chart Then
					GoTo IL_9A8
				End If
				IL_990:
				num2 = 141
				image3 = CType(control, Chart).GetImage()
				GoTo IL_A5C
				IL_9A8:
				num2 = 143
				If control.o.__O0O. <> ControlTypeEnum.Painter Then
					GoTo IL_9D0
				End If
				IL_9B8:
				num2 = 144
				image3 = CType(control, Painter).Image
				GoTo IL_A5C
				IL_9D0:
				num2 = 146
				If control.o.__O0O. <> ControlTypeEnum.PictureViewer Then
					GoTo IL_9FF
				End If
				IL_9E0:
				num2 = 147
				image3 = CType(control.BaseControl, PictureViewer).C1PictureBox1.Image
				GoTo IL_A5C
				IL_9FF:
				num2 = 149
				If control.o.__O0O. <> ControlTypeEnum.Gauges Then
					GoTo IL_A29
				End If
				IL_A0F:
				num2 = 150
				image3 = CType(control.BaseControl, O0_O_0O).GetImage()
				GoTo IL_A5C
				IL_A29:
				num2 = 152
				If control.o.__O0O. <> ControlTypeEnum.Map Then
					GoTo IL_A5C
				End If
				IL_A39:
				num2 = 153
				Dim geoMap As GeoMap = CType(control.BaseControl, GeoMap)
				IL_A4C:
				num2 = 154
				image3 = geoMap.GetBitmap(False)
				IL_A5C:
				num2 = 155
				IL_A65:
				num2 = 156
				renderImage2.Image = image3
				IL_A74:
				num2 = 157
				renderImage2.X = Conversions.ToDouble(A_1("Left"))
				IL_A96:
				num2 = 158
				renderImage2.Y = A_3
				IL_AAA:
				num2 = 159
				renderImage2.Style.ImageAlign.AlignHorz = 1
				IL_AC2:
				num2 = 160
				renderImage2.Style.ImageAlign.AlignVert = 1
				IL_ADA:
				num2 = 161
				renderImage2.Style.ImageAlign.StretchHorz = True
				IL_AF2:
				num2 = 162
				renderImage2.Style.ImageAlign.StretchVert = True
				IL_B0A:
				num2 = 163
				renderImage2.Style.ImageAlign.KeepAspectRatio = True
				IL_B22:
				num2 = 164
				renderImage2.Height = Conversions.ToDouble(A_1("Height"))
				IL_B44:
				num2 = 165
				renderImage2.Width = Conversions.ToDouble(A_1("Width"))
				IL_B66:
				num2 = 166
				If Not A_4 Then
					GoTo IL_BA4
				End If
				IL_B70:
				num2 = 167
				Dim renderEmpty9 As RenderEmpty = New RenderEmpty()
				IL_B7D:
				num2 = 168
				renderEmpty9.BreakAfter = 1
				IL_B8B:
				num2 = 169
				A_0.Body.Children.Add(renderEmpty9)
				IL_BA4:
				num2 = 170
				A_0.Body.Children.Add(renderImage2)
				IL_215B:
				GoTo IL_27F5
				IL_2160:
				Dim num32 As Integer = num33 + 1
				num33 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num32)
				IL_27B6:
				GoTo IL_27EA
				IL_27B8:
				num33 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_27C8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num33 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27B8
			End Try
			IL_27EA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_27F5:
			If num33 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003CAC RID: 15532 RVA: 0x001A8AB4 File Offset: 0x001A6CB4
		Public Sub [Select]()
			If Me.Pane.CanFocus Then
				Me.Pane.Focus()
			End If
		End Sub

		' Token: 0x17000D41 RID: 3393
		' (get) Token: 0x06003CAD RID: 15533 RVA: 0x001A8AD0 File Offset: 0x001A6CD0
		<oO0oooo("2112")>
		Public ReadOnly Property DropDownBox As DropDownBox
			Get
				Dim result As DropDownBox
				If Me.Pane Is Nothing OrElse Me.Pane.ooOo.o_. Is Nothing Then
					result = Nothing
				Else
					result = New DropDownBox(Me.Pane.ooOo.o_.)
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000D42 RID: 3394
		' (get) Token: 0x06003CAE RID: 15534 RVA: 0x001A8B08 File Offset: 0x001A6D08
		<oO0oooo("2704")>
		Public ReadOnly Property DropTable As Table
			Get
				Return Me.Pane.ooOo.o_.
			End Get
		End Property

		' Token: 0x17000D43 RID: 3395
		' (get) Token: 0x06003CAF RID: 15535 RVA: 0x001A8B15 File Offset: 0x001A6D15
		<oO0oooo("2704")>
		Public ReadOnly Property DropCol As Col
			Get
				Return Me.Pane.O00O00o_oOo.o_.
			End Get
		End Property

		' Token: 0x06003CB0 RID: 15536 RVA: 0x001A8B24 File Offset: 0x001A6D24
		<oO0oooo("2217")>
		Public Sub DisableXButton()
			Dim baseForm As Form = Me.BaseForm
			If baseForm IsNot Nothing Then
				ShareLibriay.RemoveXButton(CInt(baseForm.Handle))
			End If
		End Sub

		' Token: 0x17000D44 RID: 3396
		' (get) Token: 0x06003CB1 RID: 15537 RVA: 0x001A8B4C File Offset: 0x001A6D4C
		Friend ReadOnly Property mmname As String
			Get
				Return "窗口," + Me.Name
			End Get
		End Property

		' Token: 0x17000D45 RID: 3397
		' (get) Token: 0x06003CB2 RID: 15538 RVA: 0x001A8B5E File Offset: 0x001A6D5E
		<oO0oooo("2442")>
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(Me.Pane)
			End Get
		End Property

		' Token: 0x17000D46 RID: 3398
		' (get) Token: 0x06003CB3 RID: 15539 RVA: 0x001A8B6C File Offset: 0x001A6D6C
		' (set) Token: 0x06003CB4 RID: 15540 RVA: 0x001A8BD4 File Offset: 0x001A6DD4
		<oO0oooo("2500")>
		Public Property AcceptButton As String
			Get
				Dim result As String
				If Me.Pane.FindForm() IsNot Main.OO_O.o. AndAlso Me.Pane.FindForm().AcceptButton IsNot Nothing AndAlso TypeOf Me.Pane.FindForm().AcceptButton Is Button Then
					result = CType(Me.Pane.FindForm().AcceptButton, Button).Name
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.Pane.FindForm() IsNot Main.OO_O.o. Then
					Dim control As Control = Me.o_._o000O.(Me.Pane.Controls, value)
					If control IsNot Nothing AndAlso TypeOf control Is Button Then
						Me.Pane.FindForm().AcceptButton = CType(control.BaseControl, Button)
					End If
				End If
			End Set
		End Property

		' Token: 0x17000D47 RID: 3399
		' (get) Token: 0x06003CB5 RID: 15541 RVA: 0x001A8C2C File Offset: 0x001A6E2C
		' (set) Token: 0x06003CB6 RID: 15542 RVA: 0x001A8C94 File Offset: 0x001A6E94
		<oO0oooo("2501")>
		Public Property CancelButton As String
			Get
				Dim result As String
				If Me.Pane.FindForm() IsNot Main.OO_O.o. AndAlso Me.Pane.FindForm().CancelButton IsNot Nothing AndAlso TypeOf Me.Pane.FindForm().CancelButton Is Button Then
					result = CType(Me.Pane.FindForm().CancelButton, Button).Name
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.Pane.FindForm() IsNot Main.OO_O.o. Then
					Dim control As Control = Me.o_._o000O.(Me.Pane.Controls, value)
					If control IsNot Nothing AndAlso TypeOf control Is Button Then
						Me.Pane.FindForm().CancelButton = CType(control.BaseControl, Button)
					End If
				End If
			End Set
		End Property

		' Token: 0x06003CB7 RID: 15543 RVA: 0x001A8CEC File Offset: 0x001A6EEC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetTheme(theme As String, Form As Boolean)
			If Form Then
				Main.OO_O.o..Oo.oOo_o0Oo0.(theme, New Object() { Me, Me.Panel })
			End If
			Try
				For Each control As Control In Me.Controls
					If Not(TypeOf control.BaseControl Is O_oOooO_O) AndAlso Operators.CompareString(Main.OO_O.o..o0_o_o_0.0O.(control.BaseControl), "(none)", True) <> 0 Then
						control.Theme = theme
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Control)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003CB8 RID: 15544 RVA: 0x001A8D88 File Offset: 0x001A6F88
		<oO0oooo("3305")>
		Public Sub SetTheme(theme As String)
			Me.SetTheme(theme, False)
		End Sub

		' Token: 0x17000D48 RID: 3400
		' (get) Token: 0x06003CB9 RID: 15545 RVA: 0x001A8D92 File Offset: 0x001A6F92
		' (set) Token: 0x06003CBA RID: 15546 RVA: 0x001A8DA4 File Offset: 0x001A6FA4
		Public Property ShowToolTipIcon As ToolTipIcon
			Get
				Return Me.Pane.ToolTip1.ToolTipIcon
			End Get
			Set(value As ToolTipIcon)
				Me.Pane.ToolTip1.ToolTipIcon = value
			End Set
		End Property

		' Token: 0x17000D49 RID: 3401
		' (get) Token: 0x06003CBB RID: 15547 RVA: 0x001A8DB7 File Offset: 0x001A6FB7
		' (set) Token: 0x06003CBC RID: 15548 RVA: 0x001A8DC9 File Offset: 0x001A6FC9
		Public Property TootlTipTitle As String
			Get
				Return Me.Pane.ToolTip1.ToolTipTitle
			End Get
			Set(value As String)
				Me.Pane.ToolTip1.ToolTipTitle = value
			End Set
		End Property

		' Token: 0x17000D4A RID: 3402
		' (get) Token: 0x06003CBD RID: 15549 RVA: 0x001A8DDC File Offset: 0x001A6FDC
		' (set) Token: 0x06003CBE RID: 15550 RVA: 0x001A8DEE File Offset: 0x001A6FEE
		Public Property ToolTipBalloon As Boolean
			Get
				Return Me.Pane.ToolTip1.IsBalloon
			End Get
			Set(value As Boolean)
				Me.Pane.ToolTip1.IsBalloon = value
			End Set
		End Property

		' Token: 0x06003CBF RID: 15551 RVA: 0x001A8E01 File Offset: 0x001A7001
		<oO0oooo("2677")>
		Public Sub ClearErrors()
			Me.Pane.ErrorProvider1.Clear()
		End Sub

		' Token: 0x06003CC0 RID: 15552 RVA: 0x001A8E13 File Offset: 0x001A7013
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_0._O.()
			Me.Pane.ooOo.o_. = Nothing
			Me.Pane.ooOo.o_. = Nothing
		End Sub

		' Token: 0x06003CC1 RID: 15553 RVA: 0x001A8E34 File Offset: 0x001A7034
		Friend Sub <<EMPTY_NAME>>()
			If Me.Pane.FindForm() IsNot Nothing Then
				Try
					For Each control As Control In Me.o_0.o0..Keys
						CType(control, OoO_).O_o.o__.(Me.o_0.o0.(control))
					Next
				Finally
					Dim enumerator As Dictionary(Of Control, String).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.o_0.o0..Clear()
			End If
		End Sub

		' Token: 0x06003CC2 RID: 15554 RVA: 0x001A8EB4 File Offset: 0x001A70B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Pane.FindForm() IsNot Nothing Then
				Dim formEventArgs As FormEventArgs = New FormEventArgs(Me)
				Dim a_ As String = "SizeChanged_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { formEventArgs }, True, Me.mmname, False)
			End If
		End Sub

		' Token: 0x06003CC3 RID: 15555 RVA: 0x001A8F14 File Offset: 0x001A7114
		Friend Sub <<EMPTY_NAME>>()
			Me.O_0.O00o_00_O..Clear()
			Me.o_0.o0. = Nothing
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { Me.O_o_.0o0__o0O.("Key").ToString(), o0_O.oo0_.O0Oo_o. })
			If dataRow IsNot Nothing Then
				Dim a_ As String = dataRow("Config").ToString()
				Dim oo_ As OO_ = New OO_(a_, Me)
				oo_.o.__o_O.()
				Me.O_0.O00o_00_O. = oo_.o.__o_O.
				Dim list As List(Of String) = New List(Of String)()
				list.AddRange(Me.O_0.O00o_00_O..Keys)
				For i As Integer = list.Count - 1 To 0 Step -1
					Dim toolStrip As ToolStrip = Me.O_0.O00o_00_O.(list(i))
					If Not(TypeOf toolStrip Is ContextMenuStrip) Then
						Me.Pane.Controls.Add(toolStrip)
					End If
				Next
				Me.o_0.o0. = New StripCollection(Me.O_0.O00o_00_O., Me)
			End If
		End Sub

		' Token: 0x06003CC4 RID: 15556 RVA: 0x001A9021 File Offset: 0x001A7221
		Private Function <<EMPTY_NAME>>(A_0 As ToolStripItem) As ToolStrip
			While A_0.OwnerItem IsNot Nothing AndAlso Not(TypeOf A_0.OwnerItem Is ToolStripOverflowButton)
				A_0 = A_0.OwnerItem
			End While
			Dim owner As ToolStrip = A_0.Owner
			Return A_0.Owner
		End Function

		' Token: 0x06003CC5 RID: 15557 RVA: 0x001A9050 File Offset: 0x001A7250
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ToolStripItemClickedEventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If TypeOf A_1.ClickedItem Is ToolStripSplitButton Then
					GoTo IL_313
				End If
				IL_19:
				num2 = 4
				If OO_00oOO.Forms.ActiveForm Is Nothing Then
					GoTo IL_75
				End If
				IL_27:
				num2 = 5
				Dim control As Control = CType(OO_00oOO.Forms.ActiveForm.ActiveControl, Control)
				IL_3F:
				num2 = 6
				If control Is Nothing Then
					GoTo IL_75
				End If
				IL_45:
				num2 = 7
				Dim baseControl As Control = control.BaseControl
				IL_50:
				num2 = 8
				If Not(TypeOf baseControl Is C1TextBox) Then
					GoTo IL_6B
				End If
				IL_5B:
				num2 = 9
				CType(baseControl, C1TextBox).UpdateValueWithCurrentText()
				IL_6B:
				num2 = 10
				control.WriteValue()
				IL_75:
				num2 = 11
				If Me.Pane.FindForm() IsNot Main.OO_O.o. Then
					GoTo IL_F6
				End If
				IL_8A:
				num2 = 12
				If Main.OO_O.o..ActiveControl Is Nothing Then
					GoTo IL_F6
				End If
				IL_99:
				num2 = 13
				If Not(TypeOf Main.OO_O.o..ActiveControl Is C1TextBox) Then
					GoTo IL_F6
				End If
				IL_AD:
				num2 = 14
				Dim c1TextBox As C1TextBox = CType(Main.OO_O.o..ActiveControl, C1TextBox)
				IL_C1:
				num2 = 15
				c1TextBox.UpdateValueWithCurrentText()
				IL_CC:
				num2 = 16
				If c1TextBox.DataBindings.Count <= 0 Then
					GoTo IL_F3
				End If
				IL_DE:
				num2 = 17
				c1TextBox.DataBindings(0).WriteValue()
				IL_F3:
				c1TextBox = Nothing
				IL_F6:
				num2 = 19
				If Me.Pane Is Nothing OrElse Me.Pane.Disposing OrElse Me.Pane.IsDisposed OrElse Not Me.Opened OrElse Me.Pane.ActiveControl Is Nothing Then
					GoTo IL_171
				End If
				IL_130:
				num2 = 20
				Dim control2 As Control = CType(Me.ActiveControl, Control)
				IL_140:
				num2 = 21
				If control2 Is Nothing Then
					GoTo IL_171
				End If
				IL_147:
				num2 = 22
				If Not(TypeOf control2.BaseControl Is C1FlexGrid) Then
					GoTo IL_171
				End If
				IL_158:
				num2 = 23
				If Not CType(control2.BaseControl, C1FlexGrid).FinishEditing() Then
					GoTo IL_313
				End If
				IL_171:
				num2 = 25
				Dim a_ As ToolStrip = Me.o_.oo_o_00_.(A_1.ClickedItem)
				IL_181:
				num2 = 26
				Dim ownerItem As ToolStripItem = A_1.ClickedItem.OwnerItem
				IL_191:
				num2 = 27
				Dim stripItemEventArgs As StripItemEventArgs = New StripItemEventArgs(a_, A_1.ClickedItem, ownerItem, Me)
				IL_1A5:
				num2 = 28
				Dim a_2 As String = "ItemClick_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				IL_1C9:
				num2 = 29
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_2, New Object() { stripItemEventArgs }, True, Me.mmname, False)
				IL_1ED:
				num2 = 30
				If Me.Pane Is Nothing OrElse Me.Pane.Disposing OrElse Me.Pane.IsDisposed OrElse Not Me.Opened OrElse Me.Pane.ActiveControl Is Nothing Then
					GoTo IL_313
				End If
				IL_236:
				num2 = 31
				Dim control3 As Control = CType(Me.ActiveControl, Control)
				IL_246:
				num2 = 32
				If control3 Is Nothing Then
					GoTo IL_313
				End If
				IL_250:
				num2 = 33
				If Not(TypeOf control3.BaseControl Is C1TextBox) Then
					GoTo IL_313
				End If
				IL_264:
				num2 = 34
				Me.StopRedraw()
				IL_26D:
				num2 = 35
				Dim num3 As Integer = -1
				IL_273:
				num2 = 36
				Dim length As Integer = -1
				IL_279:
				num2 = 37
				If Not(TypeOf control3.BaseControl Is C1TextBox) Then
					GoTo IL_2B6
				End If
				IL_28A:
				num2 = 38
				Dim c1TextBox2 As C1TextBox = CType(control3.BaseControl, C1TextBox)
				IL_29B:
				num2 = 39
				num3 = c1TextBox2.SelectionStart
				IL_2A7:
				num2 = 40
				length = c1TextBox2.SelectionLength
				IL_2B3:
				c1TextBox2 = Nothing
				IL_2B6:
				num2 = 42
				control3.Enabled = False
				IL_2C1:
				num2 = 43
				control3.Enabled = True
				IL_2CC:
				num2 = 44
				control3.[Select]()
				IL_2D6:
				num2 = 45
				If num3 < 0 Then
					GoTo IL_300
				End If
				IL_2DE:
				num2 = 46
				Dim c1TextBox3 As C1TextBox = CType(control3.BaseControl, C1TextBox)
				IL_2EF:
				num2 = 47
				c1TextBox3.[Select](num3, length)
				IL_2FD:
				c1TextBox3 = Nothing
				IL_300:
				num2 = 49
				control3.[Select]()
				IL_30A:
				num2 = 50
				Me.ResumeRedraw()
				IL_313:
				GoTo IL_431
				IL_318:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_3F2:
				GoTo IL_426
				IL_3F4:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_404:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3F4
			End Try
			IL_426:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_431:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003CC6 RID: 15558 RVA: 0x001A94B4 File Offset: 0x001A76B4
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_._o000O.(CType(A_0, ToolStripItem))
			Dim ownerItem As ToolStripItem = CType(A_0, ToolStripItem).OwnerItem
			Dim stripItemEventArgs As StripItemEventArgs = New StripItemEventArgs(Me.o_._o000O.(CType(A_0, ToolStripItem)), CType(A_0, ToolStripItem), ownerItem, Me)
			Dim a_ As String = "ItemMouseEnter_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { stripItemEventArgs }, True, Me.mmname, False)
		End Sub

		' Token: 0x06003CC7 RID: 15559 RVA: 0x001A9534 File Offset: 0x001A7734
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_._o000O.(CType(A_0, ToolStripItem))
			Dim ownerItem As ToolStripItem = CType(A_0, ToolStripItem).OwnerItem
			Dim stripItemEventArgs As StripItemEventArgs = New StripItemEventArgs(Me.o_._o000O.(CType(A_0, ToolStripItem)), CType(A_0, ToolStripItem), ownerItem, Me)
			Dim a_ As String = "ItemMouseLeave_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { stripItemEventArgs }, True, Me.mmname, False)
		End Sub

		' Token: 0x06003CC8 RID: 15560 RVA: 0x001A95B4 File Offset: 0x001A77B4
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_._o000O.(CType(A_0, ToolStripItem))
			Dim ownerItem As ToolStripItem = CType(A_0, ToolStripItem).OwnerItem
			Dim stripItemEventArgs As StripItemEventArgs = New StripItemEventArgs(Me.o_._o000O.(CType(A_0, ToolStripItem)), CType(A_0, ToolStripItem), ownerItem, Me)
			Dim a_ As String = "ItemMouseHover_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { stripItemEventArgs }, True, Me.mmname, False)
		End Sub

		' Token: 0x06003CC9 RID: 15561 RVA: 0x001A9634 File Offset: 0x001A7834
		Private Function <<EMPTY_NAME>>(A_0 As ToolStripItem) As ToolStrip
			While A_0.Owner Is Nothing OrElse A_0.OwnerItem IsNot Nothing
				If A_0.OwnerItem Is Nothing Then
					Return Nothing
				End If
				A_0 = A_0.OwnerItem
			End While
			Return A_0.Owner
		End Function

		' Token: 0x17000D4B RID: 3403
		' (get) Token: 0x06003CCA RID: 15562 RVA: 0x001A966F File Offset: 0x001A786F
		<oO0oooo("Strips")>
		Public ReadOnly Property Strips As StripCollection
			Get
				If Me.o_0.o0. Is Nothing Then
					Me.o_0.o0. = New StripCollection(Me.O_0.O00o_00_O., Me)
				End If
				Return Me.o_0.o0.
			End Get
		End Property

		' Token: 0x06003CCB RID: 15563 RVA: 0x001A9694 File Offset: 0x001A7894
		Friend Sub <<EMPTY_NAME>>()
			Dim list As List(Of ListView) = New List(Of ListView)()
			Try
				For Each control As Control In Me.Controls
					control.BaseControl.Tag = ""
					If TypeOf control.BaseControl Is C1TopicBar Then
						Dim c1TopicBar As C1TopicBar = CType(control.BaseControl, C1TopicBar)
						c1TopicBar.Visible = True
						If c1TopicBar.Pages.Count > 0 Then
							c1TopicBar.Pages(0).PageVisible = True
						End If
					ElseIf TypeOf control.BaseControl Is ListView Then
						list.Add(CType(control.BaseControl, ListView))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Control)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Try
				For Each listView As ListView In list
					listView.Enabled = False
					listView.Parent.Controls.Remove(listView)
				Next
			Finally
				Dim enumerator2 As List(Of ListView).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Me.Pane.ActiveControl = Nothing
			Application.DoEvents()
		End Sub

		' Token: 0x06003CCC RID: 15564 RVA: 0x001A97BC File Offset: 0x001A79BC
		Friend Sub <<EMPTY_NAME>>()
			Me.StopRedraw()
			Main.OO_O.o..o0oO_O.0Oo_00.(Me.Panel.Controls)
			Try
				For Each toolStrip As ToolStrip In Me.O_0.O00o_00_O..Values
					Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { toolStrip })
				Next
			Finally
				Dim enumerator As Dictionary(Of String, ToolStrip).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each control As Control In Me.Controls
					If TypeOf control Is PictureBox Then
						CType(control, PictureBox).ImageFile = ""
					End If
					Me.o0o_._O0.(control.BaseControl)
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of Control)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003CCD RID: 15565 RVA: 0x001A9898 File Offset: 0x001A7A98
		Private Sub <<EMPTY_NAME>>(A_0 As Control)
			If Not(TypeOf A_0 Is O_oOooO_O) Then
				If TypeOf A_0 Is C1Chart Then
					RemoveHandler A_0.Click, AddressOf Me.OOo000o.0OO_O0.
					RemoveHandler A_0.DoubleClick, AddressOf Me.oOoo000O.0_.
					RemoveHandler A_0.MouseHover, AddressOf Me.O_o00_._Oo0O.
					RemoveHandler A_0.MouseMove, AddressOf Me.OoOO_o.00_.
					RemoveHandler A_0.MouseDown, AddressOf Me.oo.0O0___0.
					RemoveHandler A_0.MouseUp, AddressOf Me.O.OOo0O.
					CType(A_0, C1Chart).ShowTooltip -= AddressOf Me.O.OOo0O.
				Else
					RemoveHandler A_0.Enter, AddressOf Me.O0_oO.0_O0.
					RemoveHandler A_0.Leave, AddressOf Me.oo_.o_oo.
					RemoveHandler A_0.Validating, AddressOf Me.OOO0.OOOoO.
					RemoveHandler A_0.KeyPress, AddressOf Me.O0O.OO0OO0.
					RemoveHandler A_0.KeyDown, AddressOf Me.o_.oo_o_00_.
					RemoveHandler A_0.KeyUp, AddressOf Me.O0O.OO0OO0.
					RemoveHandler A_0.Click, AddressOf Me.oo0.OOooo_.
					RemoveHandler A_0.MouseClick, AddressOf Me.o_oo.O_O_.
					RemoveHandler A_0.DoubleClick, AddressOf Me.o00_.__00.
					RemoveHandler A_0.MouseEnter, AddressOf Me.Oo.Oooo0o_.
					RemoveHandler A_0.MouseLeave, AddressOf Me.oo0OOo0_o.oOoo.
					RemoveHandler A_0.MouseHover, AddressOf Me.o_ooO0.o___0.
					RemoveHandler A_0.MouseMove, AddressOf Me.O_0OO._.
					RemoveHandler A_0.MouseDown, AddressOf Me.o._0_0_o_o0O.
					RemoveHandler A_0.MouseUp, AddressOf Me.O_OOo.o_0o.
				End If
				If TypeOf A_0 Is C1TextBox Then
					Dim c1TextBox As C1TextBox = CType(A_0, C1TextBox)
					c1TextBox.Formatting -= AddressOf Me.Oo_O00ooo.OO_.
					c1TextBox.Parsing -= AddressOf Me.Oo_O00ooo.OO_.
				End If
				If TypeOf A_0 Is C1Label Then
					CType(A_0, C1Label).Formatting -= AddressOf Me.Oo_O00ooo.OO_.
				End If
				If TypeOf A_0 Is C1NumericEdit Then
					Dim c1NumericEdit As C1NumericEdit = CType(A_0, C1NumericEdit)
					RemoveHandler c1NumericEdit.TextChanged, AddressOf Me.oo__o.o0.
					c1NumericEdit.ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
					Return
				End If
				If TypeOf A_0 Is O_0oOoOo Then
					Dim o_0oOoOo As O_0oOoOo = CType(A_0, O_0oOoOo)
					RemoveHandler o_0oOoOo.TextChanged, AddressOf Me.oo__o.o0.
					o_0oOoOo.ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
					Return
				End If
				If TypeOf A_0 Is O00o Then
					CType(A_0, O00o).ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
					Return
				End If
				If TypeOf A_0 Is oOO Then
					CType(A_0, oOO).ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
					Return
				End If
				If TypeOf A_0 Is O0O_O0 Then
					If Not(TypeOf A_0 Is O__o) Then
						Dim o0O_O As O0O_O0 = CType(A_0, O0O_O0)
						RemoveHandler o0O_O.TextChanged, AddressOf Me.oo__o.o0.
						o0O_O.ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
						Return
					End If
				Else
					If TypeOf A_0 Is CustomColorLabel Then
						RemoveHandler CType(A_0, CustomColorLabel).BackColorChanged, AddressOf Me.Oo_0o_oOo0oO.o.
						Return
					End If
					If TypeOf A_0 Is O_0oOoOo Then
						Dim o_0oOoOo2 As O_0oOoOo = CType(A_0, O_0oOoOo)
						RemoveHandler o_0oOoOo2.TextChanged, AddressOf Me.oo__o.o0.
						o_0oOoOo2.ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
						If o_0oOoOo2.oO._0o_O__. IsNot Nothing Then
							o_0oOoOo2.DropDownForm = Nothing
							Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { o_0oOoOo2.oO._0o_O__..o.O_OO.() })
							o_0oOoOo2.oO._0o_O__..Controls.Clear()
							o_0oOoOo2.oO._0o_O__..Close()
							o_0oOoOo2.oO._0o_O__..Dispose()
							o_0oOoOo2.oO._0o_O__. = Nothing
						End If
						Return
					End If
					If TypeOf A_0 Is OooO00O Then
						Dim oooO00O As OooO00O = CType(A_0, OooO00O)
						RemoveHandler oooO00O.TextChanged, AddressOf Me.oo__o.o0.
						oooO00O.ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
						oooO00O.UpDownButtonClick -= AddressOf Me.OOO0.OOOoO.
						oooO00O.ModalButtonClick -= AddressOf Me.o0.ooo.
						Return
					End If
					If TypeOf A_0 Is OoOO0Oo_oo0oO Then
						Dim ooOO0Oo_oo0oO As OoOO0Oo_oo0oO = CType(A_0, OoOO0Oo_oo0oO)
						RemoveHandler ooOO0Oo_oo0oO.TextChanged, AddressOf Me.oo__o.o0.
						ooOO0Oo_oo0oO.ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
						ooOO0Oo_oo0oO.oOOO_.o.(AddressOf Me.o_._O__O.)
						ooOO0Oo_oo0oO.O.oO. = Nothing
						Return
					End If
					If TypeOf A_0 Is O0oo000oO0oo_ Then
						Dim o0oo000oO0oo_ As O0oo000oO0oo_ = CType(A_0, O0oo000oO0oo_)
						RemoveHandler o0oo000oO0oo_.TextChanged, AddressOf Me.oo__o.o0.
						o0oo000oO0oo_.ValueChanged -= AddressOf Me.Oo_0o_oOo0oO.o.
						o0oo000oO0oo_.o0OO0._0.(AddressOf Me.o_._O__O.)
						o0oo000oO0oo_.o0OO0._0.(AddressOf Me.o0000o_Oo0.0_.)
						Return
					End If
					If TypeOf A_0 Is CustomCheckedListBox Then
						Dim customCheckedListBox As CustomCheckedListBox = CType(A_0, CustomCheckedListBox)
						RemoveHandler customCheckedListBox.SelectedIndexChanged, AddressOf Me.o_._O__O.
						RemoveHandler customCheckedListBox.Format, AddressOf Me.o0000o_Oo0.0_.
						RemoveHandler customCheckedListBox.ItemCheck, AddressOf Me.o_.oo_o_00_.
						Return
					End If
					If TypeOf A_0 Is CustomListBox Then
						Dim customListBox As CustomListBox = CType(A_0, CustomListBox)
						RemoveHandler customListBox.SelectedIndexChanged, AddressOf Me.o_._O__O.
						customListBox.O.00_Oo. = Nothing
						Return
					End If
					If TypeOf A_0 Is CustomCheckBox Then
						RemoveHandler CType(A_0, CheckBox).CheckedChanged, AddressOf Me.OooO_._oO_0.
						Return
					End If
					If TypeOf A_0 Is oO00O0oO0o000 Then
						RemoveHandler CType(A_0, oO00O0oO0o000).CheckedChanged, AddressOf Me.OooO_._oO_0.
						Return
					End If
					If TypeOf A_0 Is SplitContainer Then
						RemoveHandler CType(A_0, SplitContainer).SplitterMoved, AddressOf Me.o.o0oO__0__00_.
						Return
					End If
					If TypeOf A_0 Is C1DockingTab Then
						Dim c1DockingTab As C1DockingTab = CType(A_0, C1DockingTab)
						c1DockingTab.SelectedIndexChanged -= AddressOf Me.o_._O__O.
						c1DockingTab.SelectedIndexChanging -= AddressOf Me.o.o0oO__0__00_.
						Return
					End If
					If TypeOf A_0 Is O_OOO Then
						CType(A_0, O_OOO).SelectedPanelChanged -= AddressOf Me.o_._O__O.
						Return
					End If
					If TypeOf A_0 Is TreeView Then
						Dim treeView As TreeView = CType(A_0, TreeView)
						RemoveHandler treeView.AfterSelect, AddressOf Me.O_OoO_.Oo_0_o.
						RemoveHandler treeView.AfterLabelEdit, AddressOf Me.oooO.0o00_.
						RemoveHandler treeView.BeforeLabelEdit, AddressOf Me.Oo_OoO.o_.
						RemoveHandler treeView.AfterCheck, AddressOf Me.O.00oo_OO0O.
						RemoveHandler treeView.BeforeSelect, AddressOf Me.O_0.oOO.
						RemoveHandler treeView.AfterExpand, AddressOf Me.O__0._o.
						RemoveHandler treeView.AfterCollapse, AddressOf Me.oooO.0o00_.
						RemoveHandler treeView.BeforeExpand, AddressOf Me.Oo_OoO.o_.
						RemoveHandler treeView.NodeMouseClick, AddressOf Me.O_OOo.o_0o.
						RemoveHandler treeView.NodeMouseDoubleClick, AddressOf Me.ooO0O.00.
						RemoveHandler treeView.NodeMouseHover, AddressOf Me.ooO0O.00.
						Return
					End If
					If TypeOf A_0 Is o_OO_oOOO0o Then
						Dim listView As ListView = CType(A_0, ListView)
						RemoveHandler listView.RetrieveVirtualItem, AddressOf Me.Oo0Oo0000.__.
						RemoveHandler listView.CacheVirtualItems, AddressOf Me.oO0._o0__o_o_O.
						RemoveHandler listView.ItemActivate, AddressOf Me.O00.0_OO00oO_.
						RemoveHandler listView.BeforeLabelEdit, AddressOf Me.oO0._o0__o_o_O.
						RemoveHandler listView.AfterLabelEdit, AddressOf Me.oooO.0o00_.
						RemoveHandler listView.ItemSelectionChanged, AddressOf Me.O0O.OO0OO0.
						RemoveHandler listView.ItemCheck, AddressOf Me.o0000o_Oo0.0_.
						RemoveHandler listView.ItemChecked, AddressOf Me.o0000o_Oo0.0_.
						RemoveHandler listView.DrawSubItem, AddressOf Me.Oo_O00ooo.OO_.
						RemoveHandler listView.DrawColumnHeader, AddressOf Me.Oo_O00ooo.OO_.
						Return
					End If
					If TypeOf A_0 Is C1TopicBar Then
						Dim c1TopicBar As C1TopicBar = CType(A_0, C1TopicBar)
						c1TopicBar.LinkClick -= AddressOf Me.OOO0.OOOoO.
						c1TopicBar.PageCollapsed -= AddressOf Me.OOo0O0.0.
						c1TopicBar.PageExpanded -= AddressOf Me.OOO0.OOOoO.
						Return
					End If
					If TypeOf A_0 Is MonthCalendar Then
						Dim monthCalendar As MonthCalendar = CType(A_0, MonthCalendar)
						RemoveHandler monthCalendar.DateChanged, AddressOf Me.oOo_0o_o_0_.O.
						RemoveHandler monthCalendar.DateSelected, AddressOf Me.Oo_O00ooo.OO_.
						Return
					End If
					If TypeOf A_0 Is OoOoo00 Then
						RemoveHandler CType(A_0, OoOoo00).Scroll, AddressOf Me.O000_0O__o._.
						Return
					End If
					If TypeOf A_0 Is Panel Then
						RemoveHandler CType(A_0, Panel).Scroll, AddressOf Me.oO_.0_0.
						Return
					End If
					If TypeOf A_0 Is O0_O_0O Then
						Dim c1Gauge As C1Gauge = CType(A_0, C1Gauge)
						c1Gauge.ItemClick -= AddressOf Me.Oo.o__00_.
						c1Gauge.ItemDoubleClick -= AddressOf Me.o_.0_o0_O_000.
						c1Gauge.ItemStateChanged -= AddressOf Me.Oo0_OOOo.Oo.
						c1Gauge.ItemMouseDown -= AddressOf Me.o0oo_o.OO.
						c1Gauge.ItemMouseUp -= AddressOf Me.Oo0_OOOo.Oo.
						c1Gauge.ItemMouseEnter -= AddressOf Me.o0oo_o.OO.
						c1Gauge.ItemMouseLeave -= AddressOf Me.O_00.o.
						c1Gauge.ItemMouseMove -= AddressOf Me.O_00.o.
						Try
							For Each obj As Object In CType(A_0, C1Gauge).Gauges
								Dim c1GaugeBase As C1GaugeBase = CType(obj, C1GaugeBase)
								c1GaugeBase.PointerDragMove -= AddressOf Me.o_.0_o000o.
								c1GaugeBase.PointerDragBegin -= AddressOf Me.O.0o00__.
								c1GaugeBase.PointerDragEnd -= AddressOf Me.o_.o_oOo0O.
								c1GaugeBase.PointerDragCancel -= AddressOf Me.oO_.0_0.
								c1GaugeBase.ItemClick -= AddressOf Me.Oo.o__00_.
								c1GaugeBase.ItemDoubleClick -= AddressOf Me.o_.0_o0_O_000.
								c1GaugeBase.ItemStateChanged -= AddressOf Me.Oo0_OOOo.Oo.
								c1GaugeBase.ItemMouseDown -= AddressOf Me.o0oo_o.OO.
								c1GaugeBase.ItemMouseUp -= AddressOf Me.Oo0_OOOo.Oo.
								c1GaugeBase.ItemMouseEnter -= AddressOf Me.o0oo_o.OO.
								c1GaugeBase.ItemMouseLeave -= AddressOf Me.O_00.o.
								c1GaugeBase.ItemMouseMove -= AddressOf Me.O_00.o.
								c1GaugeBase.FormatLabel -= AddressOf Me.O_.O__Oo.
								c1GaugeBase.PointerValueChanged -= AddressOf Me.O_00.o.
							Next
							Return
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
					If TypeOf A_0 Is GanttView Then
						Dim ganttView As GanttView = CType(A_0, GanttView)
						RemoveHandler CType(ganttView.Controls(4), ToolStrip).ItemClicked, AddressOf Me.O_.O__Oo.
						ganttView.AfterEditTask -= AddressOf Me.O_OoO_.Oo_0_o.
						ganttView.BeforeEditTask -= AddressOf Me.O__0._o.
						ganttView.BeforeRemoveTask -= AddressOf Me.oO0._o0__o_o_O.
						ganttView.BeforeRemoveTask -= AddressOf Me.oO0._o0__o_o_O.
						ganttView.TaskBarTooltip -= AddressOf Me.o.o0oO__0__00_.
						ganttView.BeforeMoveTasks -= AddressOf Me.oO0._o0__o_o_O.
						ganttView.TaskBarClick -= AddressOf Me.o.o0oO__0__00_.
						ganttView.PaintDay -= AddressOf Me.oO_.0_0.
						ganttView.SelectedIndexChanged -= AddressOf Me.Oo.o__00_.
						Return
					End If
					If TypeOf A_0 Is GeoMap Then
						Dim geoMap As GeoMap = CType(A_0, GeoMap)
						geoMap.ZoomChanged -= AddressOf Me.o_.O_00OOOo0_O.
						geoMap.CenterChanged -= AddressOf Me.Oo._0O0_.
						Return
					End If
					If TypeOf A_0 Is WebViewer Then
						Dim webViewer As WebViewer = CType(A_0, WebViewer)
						webViewer.Oo0Oo_0oo0.0.()
						webViewer.CoreWebView2InitializationCompleted -= AddressOf Me.O0O0.O.
						webViewer.ZoomFactorChanged -= AddressOf Me.o._oOO_o.
						If webViewer.CoreWebView2 IsNot Nothing Then
							webViewer.[Stop]()
							webViewer.CoreWebView2.NavigationStarting -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.NavigationCompleted -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.ContentLoading -= AddressOf Me.OOO0.OOOoO.
							webViewer.CoreWebView2.SourceChanged -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.DOMContentLoaded -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.ScriptDialogOpening -= AddressOf Me.OO.OoO_o.
							webViewer.CoreWebView2.StatusBarTextChanged -= AddressOf Me.O0_0O.__0_.
							webViewer.CoreWebView2.ContextMenuRequested -= AddressOf Me.OOO0.OOOoO.
							webViewer.CoreWebView2.HistoryChanged -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.WebMessageReceived -= AddressOf Me.OO.OoO_o.
							webViewer.CoreWebView2.NewWindowRequested -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.WebResourceRequested -= AddressOf Me.OO.OoO_o.
							webViewer.CoreWebView2.WebResourceResponseReceived -= AddressOf Me.OO.OoO_o.
							webViewer.CoreWebView2.SaveAsUIShowing -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.DownloadStarting -= AddressOf Me.O0O0.O.
							webViewer.CoreWebView2.PermissionRequested -= AddressOf Me.O0O0.O.
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06003CCE RID: 15566 RVA: 0x001AA598 File Offset: 0x001A8798
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf A_0 Is C1TextBox Then
				Me.OOO0.OOOoO.(CType(A_0, C1TextBox))
			End If
		End Sub

		' Token: 0x06003CCF RID: 15567 RVA: 0x001AA5B0 File Offset: 0x001A87B0
		Private Sub <<EMPTY_NAME>>(A_0 As Control)
			Dim control As Control = ooO_0O.o_O0.O_.(A_0)
			If control IsNot Nothing Then
				Dim o000O As O000O = TryCast(A_0, O000O)
				If o000O IsNot Nothing Then
					If Not o000O.OoO.Oo0O0o.() Then
						o000O.OoO.Oo0O0o.(True)
						control.WriteValue()
						o000O.OoO.Oo0O0o.(False)
						Return
					End If
				Else
					control.WriteValue()
				End If
			End If
		End Sub

		' Token: 0x06003CD0 RID: 15568 RVA: 0x001AA5F4 File Offset: 0x001A87F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1SizerLightEventArgs)
			Dim control As Control = A_1.Control
			If control IsNot Nothing Then
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "ResizingControl_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
				A_1.Cancel = controlEventArgs.Cancel
			End If
		End Sub

		' Token: 0x06003CD1 RID: 15569 RVA: 0x001AA670 File Offset: 0x001A8870
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1SizerLightEventArgs)
			Dim control As Control = A_1.Control
			If control IsNot Nothing Then
				Dim controlEventArgs As ControlEventArgs = New ControlEventArgs(control, Me)
				Dim a_ As String = "ResizingFont_" + Conversions.ToString(Me.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(Me.O_0.O00o_00_O., a_, New Object() { controlEventArgs }, False, Me.mmname + "," + control.Name, False)
				A_1.Cancel = controlEventArgs.Cancel
			End If
		End Sub

		' Token: 0x17000D4C RID: 3404
		' (get) Token: 0x06003CD2 RID: 15570 RVA: 0x001AA6EA File Offset: 0x001A88EA
		' (set) Token: 0x06003CD3 RID: 15571 RVA: 0x001AA6F2 File Offset: 0x001A88F2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property MenuTheme As String
			Get
				Return Me.OoO._O_Oo00__.
			End Get
			Set(value As String)
				Me.OoO._O_Oo00__. = value
			End Set
		End Property

		' Token: 0x06003CD4 RID: 15572 RVA: 0x001AA6FB File Offset: 0x001A88FB
		<CompilerGenerated()>
		Private Sub b()
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.a)
			End If
		End Sub

		' Token: 0x06003CD5 RID: 15573 RVA: 0x001AA71B File Offset: 0x001A891B
		<CompilerGenerated()>
		Private Sub a()
			Me.Close()
		End Sub

		' Token: 0x040018BC RID: 6332
		Friend <<EMPTY_NAME>> As DataRow

		' Token: 0x040018BD RID: 6333
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040018BE RID: 6334
		<CompilerGenerated()>
		<AccessedThroughProperty("Pane")>
		Private <<EMPTY_NAME>> As FormPanel

		' Token: 0x040018BF RID: 6335
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018C0 RID: 6336
		Private <<EMPTY_NAME>> As FormStyleEnum

		' Token: 0x040018C1 RID: 6337
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018C2 RID: 6338
		Private <<EMPTY_NAME>> As String

		' Token: 0x040018C3 RID: 6339
		Private <<EMPTY_NAME>> As FormStartPosition

		' Token: 0x040018C4 RID: 6340
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040018C5 RID: 6341
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040018C6 RID: 6342
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018C7 RID: 6343
		Private <<EMPTY_NAME>> As DockAreaEnum

		' Token: 0x040018C8 RID: 6344
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018C9 RID: 6345
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018CA RID: 6346
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018CB RID: 6347
		Private <<EMPTY_NAME>> As String

		' Token: 0x040018CC RID: 6348
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018CD RID: 6349
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018CE RID: 6350
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018CF RID: 6351
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018D0 RID: 6352
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018D1 RID: 6353
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018D2 RID: 6354
		Private Shared <<EMPTY_NAME>> As ScriptControl

		' Token: 0x040018D3 RID: 6355
		<AccessedThroughProperty("Timer")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Timer

		' Token: 0x040018D4 RID: 6356
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040018D5 RID: 6357
		Private <<EMPTY_NAME>> As String

		' Token: 0x040018D6 RID: 6358
		Private <<EMPTY_NAME>> As PrintPageProperty

		' Token: 0x040018D7 RID: 6359
		Private <<EMPTY_NAME>> As ControlCollection

		' Token: 0x040018D8 RID: 6360
		Private <<EMPTY_NAME>> As String

		' Token: 0x040018D9 RID: 6361
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040018DA RID: 6362
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018DB RID: 6363
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040018DC RID: 6364
		Friend <<EMPTY_NAME>> As Dictionary(Of Control, String)

		' Token: 0x040018DD RID: 6365
		Friend <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x040018DE RID: 6366
		Private <<EMPTY_NAME>> As TabAlignment

		' Token: 0x040018DF RID: 6367
		Friend <<EMPTY_NAME>> As Assembly

		' Token: 0x040018E0 RID: 6368
		Friend <<EMPTY_NAME>> As Dictionary(Of String, ToolStrip)

		' Token: 0x040018E1 RID: 6369
		Friend <<EMPTY_NAME>> As StripCollection

		' Token: 0x040018E2 RID: 6370
		Friend <<EMPTY_NAME>> As Control

		' Token: 0x040018E3 RID: 6371
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040018E4 RID: 6372
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040018E5 RID: 6373
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040018E6 RID: 6374
		<CompilerGenerated()>
		<AccessedThroughProperty("sizer")>
		Private <<EMPTY_NAME>> As C1SizerLight

		' Token: 0x040018E7 RID: 6375
		Private Shared a As String = ""

		' Token: 0x040018E8 RID: 6376
		Private Shared b As String = ""

		' Token: 0x040018E9 RID: 6377
		Private Shared a As DataRow

		' Token: 0x040018EA RID: 6378
		Private Shared c As String = "("

		' Token: 0x040018EB RID: 6379
		Private Shared d As String = ")"

		' Token: 0x040018EC RID: 6380
		Private Shared e As String

		' Token: 0x040018ED RID: 6381
		Private Shared a As Integer = 7

		' Token: 0x040018EE RID: 6382
		Private Shared f As String

		' Token: 0x040018EF RID: 6383
		Private Shared a As Boolean

		' Token: 0x040018F0 RID: 6384
		Private Shared b As Boolean = False

		' Token: 0x040018F1 RID: 6385
		Private <<EMPTY_NAME>> As String

		' Token: 0x040018F2 RID: 6386
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018F3 RID: 6387
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018F4 RID: 6388
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018F5 RID: 6389
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018F6 RID: 6390
		Private <<EMPTY_NAME>> As String

		' Token: 0x0200050B RID: 1291
		<CompilerGenerated()>
		Friend NotInheritable Class g
			' Token: 0x060054FD RID: 21757 RVA: 0x0021FD58 File Offset: 0x0021DF58
			Friend Sub a()
				If OO_00oOO.BaseMainForm IsNot Nothing Then
					Dim control As Control = OO_00oOO.BaseMainForm
					Dim method As [Delegate]
					If Me.a IsNot Nothing Then
						method = Me.a
					Else
						Dim $UNNAMED_TYPE$ As $UNNAMED_TYPE$ = AddressOf Me.b
						Dim $UNNAMED_TYPE$2 As $UNNAMED_TYPE$ = $UNNAMED_TYPE$
						Me.a = $UNNAMED_TYPE$
						method = $UNNAMED_TYPE$2
					End If
					control.Invoke(method)
				End If
			End Sub

			' Token: 0x060054FE RID: 21758 RVA: 0x0021FD9C File Offset: 0x0021DF9C
			Friend Sub b()
				If Me.a.Length = 0 Then
					Me.a.Open(Integer.MaxValue, Integer.MaxValue)
					Return
				End If
				If Me.a.Length = 2 Then
					Dim x As Integer = Conversions.ToInteger(Me.a(0))
					Dim y As Integer = Conversions.ToInteger(Me.a(1))
					Me.a.Open(x, y)
				End If
			End Sub

			' Token: 0x040021DD RID: 8669
			Public a As Object()

			' Token: 0x040021DE RID: 8670
			Public a As Form

			' Token: 0x040021DF RID: 8671
			Public a As $UNNAMED_TYPE$
		End Class

		' Token: 0x0200050E RID: 1294
		<CompilerGenerated()>
		Friend NotInheritable Class f
			' Token: 0x06005504 RID: 21764 RVA: 0x0021FFE0 File Offset: 0x0021E1E0
			Friend Sub a()
				If OO_00oOO.BaseMainForm IsNot Nothing Then
					Dim control As Control = OO_00oOO.BaseMainForm
					Dim method As [Delegate]
					If Me.a IsNot Nothing Then
						method = Me.a
					Else
						Dim $UNNAMED_TYPE$ As $UNNAMED_TYPE$ = AddressOf Me.b
						Dim $UNNAMED_TYPE$2 As $UNNAMED_TYPE$ = $UNNAMED_TYPE$
						Me.a = $UNNAMED_TYPE$
						method = $UNNAMED_TYPE$2
					End If
					control.Invoke(method)
				End If
			End Sub

			' Token: 0x06005505 RID: 21765 RVA: 0x00220024 File Offset: 0x0021E224
			Friend Sub b()
				Dim location As Point = Me.a.BaseForm.Location
				Me.a.BaseForm.Location = New Point(location.X + Me.a, location.Y + Me.b)
			End Sub

			' Token: 0x040021E9 RID: 8681
			Public a As Integer

			' Token: 0x040021EA RID: 8682
			Public b As Integer

			' Token: 0x040021EB RID: 8683
			Public a As Form

			' Token: 0x040021EC RID: 8684
			Public a As $UNNAMED_TYPE$
		End Class

		' Token: 0x02000510 RID: 1296
		<CompilerGenerated()>
		Friend NotInheritable Class b
			' Token: 0x06005509 RID: 21769 RVA: 0x00220180 File Offset: 0x0021E380
			Friend Sub a()
				If OO_00oOO.BaseMainForm IsNot Nothing Then
					Dim control As Control = OO_00oOO.BaseMainForm
					Dim method As [Delegate]
					If Me.a IsNot Nothing Then
						method = Me.a
					Else
						Dim $UNNAMED_TYPE$ As $UNNAMED_TYPE$ = AddressOf Me.b
						Dim $UNNAMED_TYPE$2 As $UNNAMED_TYPE$ = $UNNAMED_TYPE$
						Me.a = $UNNAMED_TYPE$
						method = $UNNAMED_TYPE$2
					End If
					control.Invoke(method)
				End If
			End Sub

			' Token: 0x0600550A RID: 21770 RVA: 0x002201C4 File Offset: 0x0021E3C4
			Friend Sub b()
				If Me.a.Length = 0 Then
					Me.a.Show(Integer.MaxValue, Integer.MaxValue)
					Return
				End If
				If Me.a.Length = 2 Then
					Dim x As Integer = Conversions.ToInteger(Me.a(0))
					Dim y As Integer = Conversions.ToInteger(Me.a(1))
					Me.a.Show(x, y)
				End If
			End Sub

			' Token: 0x040021F3 RID: 8691
			Public a As Object()

			' Token: 0x040021F4 RID: 8692
			Public a As Form

			' Token: 0x040021F5 RID: 8693
			Public a As $UNNAMED_TYPE$
		End Class

		' Token: 0x02000512 RID: 1298
		<CompilerGenerated()>
		Friend NotInheritable Class e
			' Token: 0x0600550E RID: 21774 RVA: 0x00220328 File Offset: 0x0021E528
			Friend Sub a(A_0 As Object, A_1 As Object)
				If(DateTime.Now - Me.a).TotalSeconds >= 1.0 Then
					Me.a = DateTime.Now
					Me.a.a = "DownloadProgressChanged_" + Conversions.ToString(Me.a.a.Tag)
					Dim downloadStateChangedEventArgs As DownloadStateChangedEventArgs = New DownloadStateChangedEventArgs(Me.a.a, Me.a.a, Me.a.a)
					O_O0OO.OoO_o.oO0o0O.(Me.a.a.O_0.O00o_00_O., Me.a.a, New Object() { downloadStateChangedEventArgs }, False, Me.a.a.mmname + "," + Me.a.a.Name, False)
				End If
			End Sub

			' Token: 0x0600550F RID: 21775 RVA: 0x00220410 File Offset: 0x0021E610
			Friend Sub b(A_0 As Object, A_1 As Object)
				If Me.a.a.State = 2 OrElse (Me.a.a.State = 1 AndAlso Not Me.a.a.CanResume) Then
					Dim eventHandler As EventHandler(Of Object) = Nothing
					If Me.a.a.OoO.oOOoo..TryRemove(Me.a.a, eventHandler) Then
						Me.a.a.BytesReceivedChanged -= Me.a
					End If
					If Me.a.a.oo_.0oOOOoooo..TryRemove(Me.a.a, eventHandler) Then
						Me.a.a.StateChanged -= Me.b
					End If
					If Me.a.a.oo_.0oOOOoooo..ContainsKey(Me.a.a) Then
						Me.a.a.oo_.0oOOOoooo.(Me.a.a).SetResult(0)
						Dim taskCompletionSource As TaskCompletionSource(Of Integer) = Nothing
						Me.a.a.oo_.0oOOOoooo..TryRemove(Me.a.a, taskCompletionSource)
					End If
				End If
				Me.a.a = "DownloadStateChanged_" + Conversions.ToString(Me.a.a.Tag)
				Dim downloadStateChangedEventArgs As DownloadStateChangedEventArgs = New DownloadStateChangedEventArgs(Me.a.a, Me.a.a, Me.a.a)
				O_O0OO.OoO_o.oO0o0O.(Me.a.a.O_0.O00o_00_O., Me.a.a, New Object() { downloadStateChangedEventArgs }, False, Me.a.a.mmname + "," + Me.a.a.Name, False)
			End Sub

			' Token: 0x040021FB RID: 8699
			Public a As DateTime

			' Token: 0x040021FC RID: 8700
			Public a As EventHandler(Of Object)

			' Token: 0x040021FD RID: 8701
			Public b As EventHandler(Of Object)

			' Token: 0x040021FE RID: 8702
			Public a As Form.c
		End Class

		' Token: 0x02000513 RID: 1299
		<CompilerGenerated()>
		Friend NotInheritable Class c
			' Token: 0x040021FF RID: 8703
			Public a As String

			' Token: 0x04002200 RID: 8704
			Public a As WebViewer

			' Token: 0x04002201 RID: 8705
			Public a As CoreWebView2DownloadOperation

			' Token: 0x04002202 RID: 8706
			Public a As Form
		End Class
	End Class
End Namespace
