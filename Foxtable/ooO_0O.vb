Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports C1.Win.C1Chart
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports C1.Win.FlexViewer
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003C2 RID: 962
	Friend NotInheritable Module ooO_0O
		' Token: 0x06003D86 RID: 15750 RVA: 0x001ABEE4 File Offset: 0x001AA0E4
		Friend Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control) As Foxtable.WinForm.Control
			Dim result As Foxtable.WinForm.Control
			If TypeOf A_0 Is O0oo000oO0oo_ Then
				result = New CheckedComboBox(CType(A_0, O0oo000oO0oo_))
			ElseIf TypeOf A_0 Is OoOO0Oo_oo0oO Then
				result = New Foxtable.WinForm.ComboBox(CType(A_0, OoOO0Oo_oo0oO))
			ElseIf TypeOf A_0 Is OooO00O Then
				result = New DropDownBox(CType(A_0, OooO00O))
			ElseIf TypeOf A_0 Is ooOOO Then
				result = New NumericComboBox(CType(A_0, ooOOO))
			ElseIf TypeOf A_0 Is O_0oOoOo Then
				result = New Foxtable.WinForm.DateTimePicker(CType(A_0, O_0oOoOo))
			ElseIf TypeOf A_0 Is O0O_O0 Then
				result = New Foxtable.WinForm.TextBox(CType(A_0, O0O_O0))
			ElseIf TypeOf A_0 Is o__0OoO_ Then
				result = New TimeSpanBox(CType(A_0, o__0OoO_))
			ElseIf TypeOf A_0 Is CustomCheckedListBox Then
				result = New Foxtable.WinForm.CheckedListBox(CType(A_0, CustomCheckedListBox))
			ElseIf TypeOf A_0 Is CustomListBox Then
				result = New Foxtable.WinForm.ListBox(CType(A_0, CustomListBox))
			ElseIf TypeOf A_0 Is CustomCheckBox Then
				result = New Foxtable.WinForm.CheckBox(CType(A_0, CustomCheckBox))
			ElseIf TypeOf A_0 Is oO00O0oO0o000 Then
				result = New Foxtable.WinForm.RadioButton(CType(A_0, oO00O0oO0o000))
			ElseIf TypeOf A_0 Is CustomColorLabel Then
				result = New ColorLabel(CType(A_0, CustomColorLabel))
			ElseIf TypeOf A_0 Is C1Label Then
				result = New Foxtable.WinForm.Label(CType(A_0, OO_0o_O_O))
			ElseIf TypeOf A_0 Is LineControl Then
				result = New Line(CType(A_0, LineControl))
			ElseIf TypeOf A_0 Is C1Button Then
				result = New Foxtable.WinForm.Button(CType(A_0, C1Button))
			ElseIf TypeOf A_0 Is System.Windows.Forms.GroupBox Then
				result = New Foxtable.WinForm.GroupBox(CType(A_0, System.Windows.Forms.GroupBox))
			ElseIf TypeOf A_0 Is CustomPictureBox Then
				result = New Foxtable.WinForm.PictureBox(CType(A_0, CustomPictureBox))
			ElseIf TypeOf A_0 Is System.Windows.Forms.Panel Then
				result = New Foxtable.WinForm.Panel(CType(A_0, System.Windows.Forms.Panel))
			ElseIf TypeOf A_0 Is System.Windows.Forms.SplitContainer Then
				result = New Foxtable.WinForm.SplitContainer(CType(A_0, System.Windows.Forms.SplitContainer))
			ElseIf TypeOf A_0 Is C1DockingTab Then
				result = New Foxtable.WinForm.TabControl(CType(A_0, C1DockingTab))
			ElseIf TypeOf A_0 Is o_o0ooOooO Then
				result = New FilterTree(CType(A_0, o_o0ooOooO))
			ElseIf TypeOf A_0 Is o_0 Then
				result = New LoadTree(CType(A_0, o_0))
			ElseIf TypeOf A_0 Is oo__ Then
				result = New InlineTree(CType(A_0, oo__))
			ElseIf TypeOf A_0 Is oO_oo0Oo Then
				result = New LayersTree(CType(A_0, oO_oo0Oo))
			ElseIf TypeOf A_0 Is System.Windows.Forms.TreeView Then
				result = New Foxtable.WinForm.TreeView(CType(A_0, System.Windows.Forms.TreeView))
			ElseIf TypeOf A_0 Is o_O_O0O__ Then
				result = New Foxtable.WinForm.ProgressBar(CType(A_0, o_O_O0O__))
			ElseIf TypeOf A_0 Is OoOoo00 Then
				result = New Foxtable.WinForm.TrackBar(CType(A_0, OoOoo00))
			ElseIf TypeOf A_0 Is FileManager Then
				result = New FileManager(CType(A_0, FileManager))
			ElseIf TypeOf A_0 Is PictureViewer Then
				result = New PictureViewer(CType(A_0, PictureViewer))
			ElseIf TypeOf A_0 Is O_oOooO_O Then
				result = New Table(CType(A_0, O_oOooO_O))
			ElseIf TypeOf A_0 Is Oo_ Then
				result = New TopicBar(CType(A_0, Oo_))
			ElseIf TypeOf A_0 Is O_OOO Then
				result = New NavBar(CType(A_0, O_OOO))
			ElseIf TypeOf A_0 Is C1Chart Then
				result = New Chart(CType(A_0, C1Chart))
			ElseIf TypeOf A_0 Is o_OO_oOOO0o Then
				result = New Foxtable.WinForm.ListView(CType(A_0, o_OO_oOOO0o))
			ElseIf TypeOf A_0 Is OOO0_ Then
				result = New Foxtable.WinForm.WebBrowser(CType(A_0, OOO0_))
			ElseIf TypeOf A_0 Is WebViewer Then
				result = New WebViewer(CType(A_0, WebViewer))
			ElseIf TypeOf A_0 Is O_oo Then
				result = New Painter(CType(A_0, O_oo))
			ElseIf TypeOf A_0 Is C1FlexViewer Then
				result = New PDFViewer(CType(A_0, C1FlexViewer))
			ElseIf TypeOf A_0 Is OOo00o_0o0_ Then
				result = New BarCode(CType(A_0, OOo00o_0o0_))
			ElseIf TypeOf A_0 Is MonthCalendar Then
				result = New Calendar(CType(A_0, MonthCalendar))
			ElseIf TypeOf A_0 Is OooOo0___oO Then
				result = New RecordGrid(CType(A_0, OooOo0___oO))
			ElseIf TypeOf A_0 Is oOO Then
				result = New ColorPicker(CType(A_0, oOO))
			ElseIf TypeOf A_0 Is O00o Then
				result = New FontPicker(CType(A_0, O00o))
			ElseIf TypeOf A_0 Is O0_O_0O Then
				result = New Gauges(CType(A_0, O0_O_0O))
			ElseIf TypeOf A_0 Is GanttView Then
				result = New GanttView(CType(A_0, GanttView))
			ElseIf TypeOf A_0 Is GeoMap Then
				result = New Map(CType(A_0, GeoMap))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06003D87 RID: 15751 RVA: 0x001AC360 File Offset: 0x001AA560
		Friend Function <<EMPTY_NAME>>(A_0 As ControlTypeEnum, A_1 As String, Optional A_2 As DataCol = Nothing) As Boolean
			Dim result As Boolean
			If Operators.CompareString(A_1, "", True) = 0 OrElse A_1.IndexOf("."c) <= 0 Then
				result = False
			Else
				If A_1.StartsWith("全局变量") Then
					Dim text As String = A_1.Substring(A_1.LastIndexOf("."c) + 1)
					If Operators.CompareString(text, "", True) = 0 Then
						Return False
					End If
					If Not OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
						Return False
					End If
					Dim dataType As Type = OO_00oOO.Vars.VariableTable.Columns(text).DataType
					If A_0 <= ControlTypeEnum.TrackBar Then
						Select Case A_0
							Case ControlTypeEnum.CheckBox, ControlTypeEnum.RadioButton
								If dataType IsNot GetType(Boolean) Then
									Return False
								End If
								GoTo IL_381
							Case ControlTypeEnum.ComboBox, ControlTypeEnum.TopicBar, ControlTypeEnum.ListBox
								GoTo IL_381
							Case ControlTypeEnum.NumericComboBox
							Case ControlTypeEnum.DateTimePicker
								If dataType IsNot GetType(DateTime) Then
									Return False
								End If
								GoTo IL_381
							Case ControlTypeEnum.CheckedListBox
								GoTo IL_158
							Case Else
								Select Case A_0
									Case ControlTypeEnum.ProgressBar, ControlTypeEnum.ColorLabel
									Case ControlTypeEnum.Chart
										GoTo IL_381
									Case ControlTypeEnum.PictureViewer, ControlTypeEnum.FileManager, ControlTypeEnum.CheckedComboBox
										GoTo IL_158
									Case Else
										If A_0 <> ControlTypeEnum.TrackBar Then
											GoTo IL_381
										End If
								End Select
						End Select
					ElseIf A_0 <> ControlTypeEnum.TimeSpanBox Then
						If A_0 = ControlTypeEnum.FontPicker Then
							GoTo IL_158
						End If
						If A_0 <> ControlTypeEnum.ColorPicker Then
							GoTo IL_381
						End If
					End If
					If dataType Is GetType(String) OrElse dataType Is GetType(DateTime) OrElse dataType Is GetType(Boolean) Then
						Return False
					End If
					GoTo IL_381
					IL_158:
					If dataType IsNot GetType(String) Then
						Return False
					End If
				Else
					Dim text2 As String = A_1.Substring(0, A_1.LastIndexOf("."c))
					Dim text3 As String = A_1.Substring(A_1.LastIndexOf("."c) + 1)
					Dim dataColumn As DataColumn
					If A_2 IsNot Nothing Then
						dataColumn = A_2.BaseColumn
					Else
						If Operators.CompareString(text3, "", True) = 0 Then
							Return False
						End If
						If Not OO_00oOO.Tables.get_Contains(text2) Then
							Return False
						End If
						If Not OO_00oOO.Tables(text2).DataTable.BaseTable.Columns.Contains(text3) Then
							Return False
						End If
						dataColumn = OO_00oOO.Tables(text2).DataTable.BaseTable.Columns(text3)
					End If
					If dataColumn IsNot Nothing Then
						Dim name As String = [Enum].GetName(GetType(ControlTypeEnum), A_0)
						If A_0 <= ControlTypeEnum.TrackBar Then
							Select Case A_0
								Case ControlTypeEnum.CheckBox, ControlTypeEnum.RadioButton
									If dataColumn.DataType IsNot GetType(Boolean) Then
										MessageBox.Show(name + "控件只能绑定到逻辑列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
										Return False
									End If
									GoTo IL_381
								Case ControlTypeEnum.ComboBox, ControlTypeEnum.TopicBar, ControlTypeEnum.ListBox
									GoTo IL_381
								Case ControlTypeEnum.NumericComboBox
								Case ControlTypeEnum.DateTimePicker
									If dataColumn.DataType IsNot GetType(DateTime) Then
										MessageBox.Show(name + "控件只能绑定到日期列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
										Return False
									End If
									GoTo IL_381
								Case ControlTypeEnum.CheckedListBox
									GoTo IL_350
								Case Else
									Select Case A_0
										Case ControlTypeEnum.ProgressBar, ControlTypeEnum.ColorLabel
										Case ControlTypeEnum.Chart
											GoTo IL_381
										Case ControlTypeEnum.PictureViewer, ControlTypeEnum.FileManager, ControlTypeEnum.CheckedComboBox
											GoTo IL_350
										Case Else
											If A_0 <> ControlTypeEnum.TrackBar Then
												GoTo IL_381
											End If
									End Select
							End Select
						ElseIf A_0 <> ControlTypeEnum.TimeSpanBox Then
							If A_0 = ControlTypeEnum.FontPicker Then
								GoTo IL_350
							End If
							If A_0 <> ControlTypeEnum.ColorPicker Then
								GoTo IL_381
							End If
						End If
						If Not o_O_o_oOoo__.OO_.O.(dataColumn.DataType) Then
							MessageBox.Show(name + "控件只能绑定到数值列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return False
						End If
						GoTo IL_381
						IL_350:
						If dataColumn.DataType IsNot GetType(String) Then
							MessageBox.Show(name + "控件只能绑定到字符列或备注列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return False
						End If
					End If
				End If
				IL_381:
				result = True
			End If
			Return result
		End Function

		' Token: 0x06003D88 RID: 15752 RVA: 0x001AC6F1 File Offset: 0x001AA8F1
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow) As ooO_0O.BindindField
			Dim bindindField As ooO_0O.BindindField = New ooO_0O.BindindField()
			o_O_o_oOoo__.OOOO_OO._oo.(bindindField, Conversions.ToString(A_0("Property")), vbVerticalTab)
			Return bindindField
		End Function

		' Token: 0x06003D89 RID: 15753 RVA: 0x001AC710 File Offset: 0x001AA910
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow) As TempBindingTable
			Dim tempBindingTable As TempBindingTable = New TempBindingTable()
			o_O_o_oOoo__.OOOO_OO._oo.(tempBindingTable, Conversions.ToString(A_0("Property")), vbVerticalTab)
			Return tempBindingTable
		End Function

		' Token: 0x06003D8A RID: 15754 RVA: 0x001AC730 File Offset: 0x001AA930
		Friend Sub <<EMPTY_NAME>>(A_0 As C1TextBox, A_1 As BooleanEnum)
			Select Case A_1
				Case 0
					If A_0.DataBindings.Count = 0 Then
						A_0.[ReadOnly] = False
						Return
					End If
					If A_0.DataBindings.Count > 0 Then
						Dim bindingMemberInfo As BindingMemberInfo = A_0.DataBindings(0).BindingMemberInfo
						If TypeOf A_0.DataBindings(0).DataSource Is O_0 Then
							Dim text As String = CType(A_0.DataBindings(0).DataSource, O_0).Oo._Oo0OO.()
							If OO_00oOO.Tables.get_Contains(text) Then
								OO_00oOO.Tables(text)
								If OO_00oOO.Tables(text).Cols.Contains(bindingMemberInfo.BindingField) Then
									If Not OO_00oOO.Tables(text).AllowEdit Then
										A_0.[ReadOnly] = True
									ElseIf Not OO_00oOO.Tables(text).Cols(bindingMemberInfo.BindingField).AllowEdit Then
										A_0.[ReadOnly] = True
									ElseIf OO_00oOO.Tables(text).Current IsNot Nothing AndAlso OO_00oOO.Tables(text).Current.Locked Then
										A_0.[ReadOnly] = True
									Else
										A_0.[ReadOnly] = False
									End If
								Else
									Dim dataTable As DataTable = OO_00oOO.Tables(text).DataTable
									If Not dataTable.AllowEdit Then
										A_0.[ReadOnly] = True
									ElseIf Not dataTable.DataCols.Contains(bindingMemberInfo.BindingField) OrElse Not dataTable.DataCols(bindingMemberInfo.BindingField).AllowEdit Then
										A_0.[ReadOnly] = True
									ElseIf OO_00oOO.Tables(text).Current IsNot Nothing AndAlso OO_00oOO.Tables(text).Current.Locked Then
										A_0.[ReadOnly] = True
									Else
										A_0.[ReadOnly] = False
									End If
								End If
								bindingMemberInfo = Nothing
								Return
							End If
						End If
					End If
				Case 1
					A_0.[ReadOnly] = True
					Return
				Case 2
					A_0.[ReadOnly] = False
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06003D8B RID: 15755 RVA: 0x001AC938 File Offset: 0x001AAB38
		Friend Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection, A_1 As List(Of Foxtable.WinForm.TreeNode))
			Try
				For Each obj As Object In A_0
					Dim o_o__00Ooo As O_o__00Ooo = CType(obj, O_o__00Ooo)
					A_1.Add(New Foxtable.WinForm.TreeNode(o_o__00Ooo))
					If o_o__00Ooo.Nodes.Count > 0 Then
						ooO_0O.o_O0.O_.(o_o__00Ooo.Nodes, A_1)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x020003C3 RID: 963
		Friend Class BindindField
			' Token: 0x17000D81 RID: 3457
			' (get) Token: 0x06003D8D RID: 15757 RVA: 0x001AC9B8 File Offset: 0x001AABB8
			' (set) Token: 0x06003D8E RID: 15758 RVA: 0x001AC9C0 File Offset: 0x001AABC0
			Public Property BindingField As String
				Get
					Return Me.OOOOO_0._o0O0o.
				End Get
				Set(value As String)
					Me.OOOOO_0._o0O0o. = value
				End Set
			End Property

			' Token: 0x04001919 RID: 6425
			Private <<EMPTY_NAME>> As String
		End Class
	End Module
End Namespace
