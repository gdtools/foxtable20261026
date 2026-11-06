Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1GanttView
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x020000E0 RID: 224
	Public Class GanttView
		Inherits C1GanttView

		' Token: 0x06000C98 RID: 3224 RVA: 0x0005AE28 File Offset: 0x00059028
		Friend Sub New(Optional A_0 As Boolean = False)
			AddHandler MyBase.MouseDown, AddressOf Me.OO0oo.o0.
			Me.oo0ooO000O.O. = New Dictionary(Of String, String)()
			AddHandler MyBase.BarStyles.ListChanged, AddressOf Me.OO0oo.o0.
			MyBase.AfterEditTask += AddressOf Me.o._00o0_.
			MyBase.BeforeEditTask += AddressOf Me.OooOOO0O_0.0.
			MyBase.EnablePrinting = True
			Dim c1FlexGrid As C1FlexGrid = CType(MyBase.Controls(2), C1FlexGrid)
			c1FlexGrid.BeforeEdit += AddressOf Me.OooOOO0O_0.0.
			c1FlexGrid.Styles.Fixed.WordWrap = True
			c1FlexGrid.Styles.SelectedColumnHeader.WordWrap = True
			If A_0 Then
				c1FlexGrid.Styles.Normal.TextAlign = 1
				AddHandler MyBase.ToolStrip.ItemClicked, AddressOf Me.OO0oo.o0.
				AddHandler MyBase.GridContextMenu.ItemClicked, AddressOf Me.OO0oo.o0.
				AddHandler MyBase.ChartContextMenu.ItemClicked, AddressOf Me.OO0oo.o0.
				MyBase.AfterEditTask += AddressOf Me.OoOoOo.O.
			End If
			Me.Strip.Items.Remove("tsdSort")
		End Sub

		' Token: 0x06000C99 RID: 3225 RVA: 0x0005AF60 File Offset: 0x00059160
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ListChangedEventArgs)
			If A_1.ListChangedType = ListChangedType.ItemAdded Then
				Dim barStyleCollection As BarStyleCollection = CType(A_0, BarStyleCollection)
				Dim barType As BarType = barStyleCollection(A_1.NewIndex).BarType
				For i As Integer = barStyleCollection.Count - 1 To 0 Step -1
					If i <> A_1.NewIndex AndAlso barStyleCollection(i).BarType = barType Then
						barStyleCollection.RemoveAt(i)
					End If
				Next
			End If
		End Sub

		' Token: 0x06000C9A RID: 3226 RVA: 0x0005AFC1 File Offset: 0x000591C1
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ToolStripItemClickedEventArgs)
			If MyBase.FindForm() IsNot Nothing AndAlso TypeOf MyBase.FindForm()Is o\u3002\u3002\u3000\u3000\u3002 Then
				CType(MyBase.FindForm().MdiParent, o\u3000\u3002).OO_._oOo. = True
			End If
		End Sub

		' Token: 0x06000C9B RID: 3227 RVA: 0x0005AFEE File Offset: 0x000591EE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTaskArgs)
			If MyBase.FindForm() IsNot Nothing AndAlso TypeOf MyBase.FindForm()Is o\u3002\u3002\u3000\u3000\u3002 Then
				CType(MyBase.FindForm().MdiParent, o\u3000\u3002).OO_._oOo. = True
			End If
		End Sub

		' Token: 0x1700020D RID: 525
		' (set) Token: 0x06000C9C RID: 3228 RVA: 0x0005B01C File Offset: 0x0005921C
		Public WriteOnly Property CalendarDataTable As DataTable
			Set(value As DataTable)
				CType(Me, ISupportInitialize).BeginInit()
				MyBase.DataStorage.CalendarStorage.BeginInit()
				If value IsNot Nothing Then
					MyBase.DataStorage.CalendarStorage.Mappings.CalendarID.MappingName = "CalendarID"
					MyBase.DataStorage.CalendarStorage.Mappings.Data.MappingName = "Data"
					MyBase.DataStorage.CalendarStorage.Mappings.IdMapping.MappingName = "Id"
					MyBase.DataStorage.CalendarStorage.Mappings.Name.MappingName = "Name"
					MyBase.DataStorage.CalendarStorage.DataSource = value.BaseTable
				End If
				CType(Me, ISupportInitialize).EndInit()
				MyBase.DataStorage.CalendarStorage.EndInit()
			End Set
		End Property

		' Token: 0x1700020E RID: 526
		' (set) Token: 0x06000C9D RID: 3229 RVA: 0x0005B0F0 File Offset: 0x000592F0
		Public WriteOnly Property PropertyDataTable As DataTable
			Set(value As DataTable)
				CType(Me, ISupportInitialize).BeginInit()
				MyBase.DataStorage.PropertyStorage.BeginInit()
				If value IsNot Nothing Then
					MyBase.DataStorage.PropertyStorage.Key.MappingName = "Key"
					MyBase.DataStorage.PropertyStorage.Value.MappingName = "Value"
					MyBase.DataStorage.PropertyStorage.DataSource = value.BaseTable
				End If
				CType(Me, ISupportInitialize).EndInit()
				MyBase.DataStorage.PropertyStorage.EndInit()
			End Set
		End Property

		' Token: 0x1700020F RID: 527
		' (set) Token: 0x06000C9E RID: 3230 RVA: 0x0005B178 File Offset: 0x00059378
		Public WriteOnly Property ResourceDataTable As DataTable
			Set(value As DataTable)
				CType(Me, ISupportInitialize).BeginInit()
				MyBase.DataStorage.ResourceStorage.BeginInit()
				If value IsNot Nothing Then
					MyBase.DataStorage.ResourceStorage.Mappings.Cost.MappingName = "Cost"
					MyBase.DataStorage.ResourceStorage.Mappings.IdMapping.MappingName = "Id"
					MyBase.DataStorage.ResourceStorage.Mappings.Name.MappingName = "Name"
					MyBase.DataStorage.ResourceStorage.Mappings.Notes.MappingName = "Notes"
					MyBase.DataStorage.ResourceStorage.Mappings.ResourceID.MappingName = "ResourceID"
					MyBase.DataStorage.ResourceStorage.Mappings.ResourceType.MappingName = "ResourceType"
					MyBase.DataStorage.ResourceStorage.Mappings.UnitOfMeasure.MappingName = "UnitOfMeasure"
					MyBase.DataStorage.ResourceStorage.DataSource = value.BaseTable
				End If
				CType(Me, ISupportInitialize).EndInit()
				MyBase.DataStorage.ResourceStorage.EndInit()
			End Set
		End Property

		' Token: 0x17000210 RID: 528
		' (set) Token: 0x06000C9F RID: 3231 RVA: 0x0005B2A8 File Offset: 0x000594A8
		Public WriteOnly Property TaskDataTable As DataTable
			Set(value As DataTable)
				CType(Me, ISupportInitialize).BeginInit()
				MyBase.DataStorage.TasksStorage.BeginInit()
				If value IsNot Nothing Then
					MyBase.DataStorage.TasksStorage.Mappings.CalendarID.MappingName = "CalendarID"
					MyBase.DataStorage.TasksStorage.Mappings.Parts.MappingName = "Parts"
					MyBase.DataStorage.TasksStorage.Mappings.ConstraintDate.MappingName = "ConstraintDate"
					MyBase.DataStorage.TasksStorage.Mappings.ConstraintType.MappingName = "ConstraintType"
					MyBase.DataStorage.TasksStorage.Mappings.CustomFields.MappingName = "CustomFields"
					MyBase.DataStorage.TasksStorage.Mappings.Deadline.MappingName = "Deadline"
					MyBase.DataStorage.TasksStorage.Mappings.Duration.MappingName = "Duration"
					MyBase.DataStorage.TasksStorage.Mappings.DurationUnits.MappingName = "DurationUnits"
					MyBase.DataStorage.TasksStorage.Mappings.Finish.MappingName = "Finish"
					MyBase.DataStorage.TasksStorage.Mappings.HideBar.MappingName = "HideBar"
					MyBase.DataStorage.TasksStorage.Mappings.IdMapping.MappingName = "Id"
					MyBase.DataStorage.TasksStorage.Mappings.Initialized.MappingName = "Initialized"
					MyBase.DataStorage.TasksStorage.Mappings.Mode.MappingName = "Mode"
					MyBase.DataStorage.TasksStorage.Mappings.Name.MappingName = "Name"
					MyBase.DataStorage.TasksStorage.Mappings.NextID.MappingName = "NextID"
					MyBase.DataStorage.TasksStorage.Mappings.Notes.MappingName = "Notes"
					MyBase.DataStorage.TasksStorage.Mappings.OutlineParentID.MappingName = "OutlineParentID"
					MyBase.DataStorage.TasksStorage.Mappings.PercentComplete.MappingName = "PercentComplete"
					MyBase.DataStorage.TasksStorage.Mappings.Predecessors.MappingName = "Predecessors"
					MyBase.DataStorage.TasksStorage.Mappings.Resources.MappingName = "Resources"
					MyBase.DataStorage.TasksStorage.Mappings.Start.MappingName = "Start"
					MyBase.DataStorage.TasksStorage.Mappings.Summary.MappingName = "Summary"
					MyBase.DataStorage.TasksStorage.Mappings.TaskID.MappingName = "TaskID"
					MyBase.DataStorage.TasksStorage.DataSource = value.BaseTable
					Me.oo0ooO000O.O. = New DataView(value.BaseTable, "", "TaskID", DataViewRowState.CurrentRows)
				Else
					Me.oo0ooO000O.O. = Nothing
				End If
				CType(Me, ISupportInitialize).EndInit()
				MyBase.DataStorage.TasksStorage.EndInit()
			End Set
		End Property

		' Token: 0x06000CA0 RID: 3232 RVA: 0x0005B5EC File Offset: 0x000597EC
		Public Sub SaveSettings()
			Dim dayTimesKind As DayTimesKind = MyBase.DefaultWorkWeek.SundayTimes.DayTimesKind
			If dayTimesKind Is Nothing Then
				MyBase.DefaultWorkWeek.SundayTimes.DayTimesKind = 1
			Else
				MyBase.DefaultWorkWeek.SundayTimes.DayTimesKind = 0
			End If
			MyBase.DefaultWorkWeek.SundayTimes.DayTimesKind = dayTimesKind
			If MyBase.DataStorage.PropertyStorage.DataSource IsNot Nothing Then
				Dim jarray As JArray = New JArray()
				Try
					For Each barStyle As BarStyle In MyBase.BarStyles
						Dim jobject As JObject = Me.OO0oo.o0.(barStyle, New BarStyle() With { .BarType = barStyle.BarType })
						jarray.Add(jobject)
					Next
				Finally
					Dim enumerator As IEnumerator(Of BarStyle)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Dim dataTable As DataTable = CType(MyBase.DataStorage.PropertyStorage.DataSource, DataTable)
				Dim dataRow As DataRow = dataTable.Rows.Find("Extend\BarStyles")
				If jarray.Count = 0 Then
					If dataRow IsNot Nothing Then
						dataRow("Value") = DBNull.Value
					End If
				Else
					If dataRow Is Nothing Then
						dataRow = dataTable.NewRow()
						dataRow("Key") = "Extend\BarStyles"
						dataTable.Rows.Add(dataRow)
					End If
					dataRow("Value") = jarray.ToString(0).Replace(vbCrLf, "")
				End If
			End If
			Dim num As Integer = MyBase.Tasks.Count - 1
			For i As Integer = 0 To num
				Dim task As Task = MyBase.Tasks(i)
				Dim num2 As Integer = Me.oo0ooO000O.O..Find(task.ID)
				Dim num3 As Integer = -1
				If i < MyBase.Tasks.Count - 1 Then
					num3 = MyBase.Tasks(i + 1).ID
				End If
				If num2 >= 0 Then
					Dim row As DataRow = Me.oo0ooO000O.O.(num2).Row
					If Operators.ConditionalCompareObjectNotEqual(row("NextID"), num3, True) Then
						row("NextID") = num3
					End If
					If task.Inactive Then
						row("Inactive") = True
					Else
						row("Inactive") = DBNull.Value
					End If
					Dim text As String = Me.OO0oo.o0.(task)
					If Operators.CompareString(text, "", True) = 0 Then
						If Not row.IsNull("FieldStyle") Then
							row("FieldStyle") = DBNull.Value
						End If
					Else
						row("FieldStyle") = text
					End If
				End If
			Next
		End Sub

		' Token: 0x06000CA1 RID: 3233 RVA: 0x0005B888 File Offset: 0x00059A88
		Public Sub LoadSettings()
			If MyBase.DataStorage.PropertyStorage.DataSource IsNot Nothing Then
				Dim dataRow As DataRow = CType(MyBase.DataStorage.PropertyStorage.DataSource, DataTable).Rows.Find("Extend\BarStyles")
				If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Value") Then
					Me.OO0oo.o0.(dataRow("Value").ToString(), MyBase.BarStyles)
				End If
			End If
			If MyBase.DataStorage.TasksStorage.DataSource IsNot Nothing Then
				Try
					For Each obj As Object In CType(MyBase.DataStorage.TasksStorage.DataSource, DataTable).Rows
						Dim dataRow2 As DataRow = CType(obj, DataRow)
						If Not dataRow2.IsNull("BarStyle") OrElse Not dataRow2.IsNull("FieldStyle") OrElse Not dataRow2.IsNull("Inactive") Then
							Dim task As Task = MyBase.Tasks.Search(Conversions.ToInteger(dataRow2("TaskID")))
							If task IsNot Nothing Then
								If Not dataRow2.IsNull("BarStyle") Then
									Me.OO0oo.o0.(dataRow2("BarStyle").ToString(), task.BarStyles)
								End If
								If Not dataRow2.IsNull("FieldStyle") Then
									Me.OO0oo.o0.(task, dataRow2("FieldStyle").ToString())
								End If
								If Not dataRow2.IsNull("Inactive") Then
									task.Inactive = Conversions.ToBoolean(dataRow2("Inactive"))
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
			End If
		End Sub

		' Token: 0x06000CA2 RID: 3234 RVA: 0x0005BA28 File Offset: 0x00059C28
		Private Function <<EMPTY_NAME>>(A_0 As Task) As String
			Dim result As String
			If A_0.FieldStyles.Count = 0 Then
				result = ""
			Else
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.Controls(2), C1FlexGrid)
				Dim font As Font = c1FlexGrid.Styles.Normal.Font
				Dim foreColor As Color = c1FlexGrid.Styles.Normal.ForeColor
				Dim backColor As Color = c1FlexGrid.Styles.Normal.BackColor
				Dim jarray As JArray = New JArray()
				Try
					For Each fieldStyle As FieldStyle In A_0.FieldStyles
						Dim jobject As JObject = New JObject()
						jobject("Field") = fieldStyle.Field
						If fieldStyle.BackColor.ToArgb() <> backColor.ToArgb() Then
							jobject("BackColor") = fieldStyle.BackColor.ToArgb()
						End If
						If fieldStyle.ForeColor.ToArgb() <> foreColor.ToArgb() Then
							jobject("ForeColor") = fieldStyle.ForeColor.ToArgb()
						End If
						If Operators.CompareString(font.Name, fieldStyle.Font.Name, True) <> 0 OrElse font.Size <> fieldStyle.Font.Size OrElse font.Style <> fieldStyle.Font.Style Then
							If Operators.CompareString(font.Name, fieldStyle.Font.Name, True) <> 0 Then
								jobject("FontName") = fieldStyle.Font.Name
							End If
							If font.Size <> fieldStyle.Font.Size Then
								jobject("FontSize") = fieldStyle.Font.Size
							End If
							If font.Style <> fieldStyle.Font.Style Then
								jobject("FontStyle") = CInt(fieldStyle.Font.Style)
							End If
						End If
						If jobject.Count > 1 Then
							jarray.Add(jobject)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of FieldStyle)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				If jarray.Count > 0 Then
					result = jarray.ToString()
				Else
					result = ""
				End If
			End If
			Return result
		End Function

		' Token: 0x06000CA3 RID: 3235 RVA: 0x0005BC88 File Offset: 0x00059E88
		Private Sub <<EMPTY_NAME>>(A_0 As Task, A_1 As String)
			Dim jarray As JArray = JArray.Parse(A_1)
			Dim font As Font = CType(MyBase.Controls(2), C1FlexGrid).Styles.Normal.Font
			Try
				For Each jtoken As JToken In jarray
					Dim jobject As JObject = CType(jtoken, JObject)
					Dim fieldStyle As FieldStyle = New FieldStyle()
					fieldStyle.Field = CInt(jobject("Field"))
					If jobject.ContainsKey("BackColor") Then
						fieldStyle.BackColor = Color.FromArgb(CInt(jobject("BackColor")))
					End If
					If jobject.ContainsKey("ForeColor") Then
						fieldStyle.ForeColor = Color.FromArgb(CInt(jobject("ForeColor")))
					End If
					If jobject.ContainsKey("FontName") OrElse jobject.ContainsKey("FontSize") OrElse jobject.ContainsKey("FontStyle") Then
						Dim familyName As String = font.Name
						Dim emSize As Single = font.Size
						Dim style As FontStyle = font.Style
						If jobject.ContainsKey("FontName") Then
							familyName = jobject("FontName").ToString()
						End If
						If jobject.ContainsKey("FontSize") Then
							emSize = CSng(jobject("FontSize"))
						End If
						If jobject.ContainsKey("FontStyle") Then
							style = CType(CInt(jobject("FontStyle")), FontStyle)
						End If
						fieldStyle.Font = New Font(familyName, emSize, style)
					End If
					A_0.FieldStyles.Add(fieldStyle)
				Next
			Finally
				Dim enumerator As IEnumerator(Of JToken)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000CA4 RID: 3236 RVA: 0x0005BE38 File Offset: 0x0005A038
		Private Sub <<EMPTY_NAME>>(A_0 As DataRow, Optional A_1 As Task = Nothing)
			If A_1 Is Nothing Then
				A_1 = MyBase.Tasks.Search(Conversions.ToInteger(A_0("TaskID")))
			End If
			If A_1 Is Nothing OrElse A_1.BarStyles.Count = 0 Then
				A_0("BarStyle") = DBNull.Value
				Return
			End If
			Dim list As List(Of BarType) = New List(Of BarType)()
			If A_1.Summary Then
				list.Add(6)
				list.Add(4)
			ElseIf A_1.Duration = 0.0 Then
				list.Add(8)
			Else
				If A_1.Mode Is Nothing Then
					list.Add(1)
				Else
					list.Add(2)
				End If
				list.Add(3)
			End If
			If list.Count <> 0 Then
				Dim jarray As JArray = New JArray()
				Try
					For Each barType As BarType In list
						Dim barStyle As BarStyle = A_1.BarStyles.Search(barType)
						If barStyle IsNot Nothing Then
							Dim barStyle2 As BarStyle = MyBase.BarStyles.Search(barType)
							If barStyle2 Is Nothing Then
								barStyle2 = New BarStyle()
								barStyle2.BarType = barType
							End If
							Dim jobject As JObject = Me.OO0oo.o0.(barStyle, barStyle2)
							If jobject.Count > 1 Then
								jarray.Add(jobject)
							End If
						End If
					Next
				Finally
					Dim enumerator As List(Of BarType).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				If jarray.Count = 0 Then
					A_0("BarStyle") = DBNull.Value
					Return
				End If
				A_0("BarStyle") = jarray.ToString(0).Replace(vbCrLf, "")
			End If
		End Sub

		' Token: 0x06000CA5 RID: 3237 RVA: 0x0005BFB4 File Offset: 0x0005A1B4
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As BarStyleCollection)
			Dim jarray As JArray = JArray.Parse(A_0)
			Try
				For Each jtoken As JToken In jarray
					Dim jobject As JObject = CType(jtoken, JObject)
					Dim barType As BarType = CInt(jobject("BarType"))
					Dim barStyle As BarStyle = A_1.Search(barType)
					If barStyle Is Nothing Then
						If A_1 <> MyBase.BarStyles Then
							Dim barStyle2 As BarStyle = MyBase.BarStyles.Search(barType)
							If barStyle2 IsNot Nothing Then
								barStyle = CType(barStyle2.Clone(), BarStyle)
							End If
						End If
						If barStyle Is Nothing Then
							barStyle = New BarStyle()
							barStyle.BarType = barType
						End If
						A_1.Add(barStyle)
					End If
					If jobject.ContainsKey("BarHeight") Then
						barStyle.BarHeight = CInt(jobject("BarHeight"))
					End If
					If jobject.ContainsKey("BottomText1_ID") Then
						barStyle.BottomText1_ID = CInt(jobject("BottomText1_ID"))
					End If
					If jobject.ContainsKey("BottomText2_ID") Then
						barStyle.BottomText2_ID = CInt(jobject("BottomText2_ID"))
					End If
					If jobject.ContainsKey("TopText1_ID") Then
						barStyle.TopText1_ID = CInt(jobject("TopText1_ID"))
					End If
					If jobject.ContainsKey("TopText2_ID") Then
						barStyle.TopText2_ID = CInt(jobject("TopText2_ID"))
					End If
					If jobject.ContainsKey("LeftText1_ID") Then
						barStyle.LeftText1_ID = CInt(jobject("LeftText1_ID"))
					End If
					If jobject.ContainsKey("LeftText2_ID") Then
						barStyle.LeftText2_ID = CInt(jobject("LeftText2_ID"))
					End If
					If jobject.ContainsKey("RightText1_ID") Then
						barStyle.RightText1_ID = CInt(jobject("RightText1_ID"))
					End If
					If jobject.ContainsKey("RightText2_ID") Then
						barStyle.RightText2_ID = CInt(jobject("RightText2_ID"))
					End If
					If jobject.ContainsKey("AdaptiveBarHeight") Then
						barStyle.AdaptiveBarHeight = CBool(jobject("AdaptiveBarHeight"))
					End If
					If jobject.ContainsKey("BarShape") Then
						barStyle.BarShape = CInt(jobject("BarShape"))
					End If
					If jobject.ContainsKey("BarPattern") Then
						barStyle.BarPattern = CInt(jobject("BarPattern"))
					End If
					If jobject.ContainsKey("BarColor") Then
						barStyle.BarColor = Color.FromArgb(Conversions.ToInteger(jobject("BarColor").ToString()))
					End If
					If jobject.ContainsKey("EndShape") Then
						barStyle.EndShape = CInt(jobject("EndShape"))
					End If
					If jobject.ContainsKey("EndPattern") Then
						barStyle.EndPattern = CInt(jobject("BarPattern"))
					End If
					If jobject.ContainsKey("EndColor") Then
						barStyle.EndColor = Color.FromArgb(Conversions.ToInteger(jobject("BarColor").ToString()))
					End If
					If jobject.ContainsKey("StartShape") Then
						barStyle.StartShape = CInt(jobject("StartShape"))
					End If
					If jobject.ContainsKey("StartPattern") Then
						barStyle.StartPattern = CInt(jobject("BarPattern"))
					End If
					If jobject.ContainsKey("StartColor") Then
						barStyle.StartColor = Color.FromArgb(Conversions.ToInteger(jobject("StartColor").ToString()))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of JToken)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000CA6 RID: 3238 RVA: 0x0005C340 File Offset: 0x0005A540
		Private Function <<EMPTY_NAME>>(A_0 As BarStyle, A_1 As BarStyle) As JObject
			Dim jobject As JObject = New JObject()
			jobject("BarType") = A_0.BarType
			If A_0.AdaptiveBarHeight <> A_1.AdaptiveBarHeight Then
				jobject("AdaptiveBarHeight") = A_0.AdaptiveBarHeight
			End If
			If Not A_1.AdaptiveBarHeight AndAlso A_0.BarHeight <> A_1.BarHeight Then
				jobject("BarHeight") = A_0.BarHeight
			End If
			If A_0.BottomText1_ID <> A_1.BottomText1_ID Then
				jobject("BottomText1_ID") = A_0.BottomText1_ID
			End If
			If A_0.BottomText2_ID <> A_1.BottomText2_ID Then
				jobject("BottomText2_ID") = A_0.BottomText2_ID
			End If
			If A_0.TopText1_ID <> A_1.TopText1_ID Then
				jobject("TopText1_ID") = A_0.TopText1_ID
			End If
			If A_0.TopText2_ID <> A_1.TopText2_ID Then
				jobject("TopText2_ID") = A_0.TopText2_ID
			End If
			If A_0.LeftText1_ID <> A_1.LeftText1_ID Then
				jobject("LeftText1_ID") = A_0.LeftText1_ID
			End If
			If A_0.LeftText2_ID <> A_1.LeftText2_ID Then
				jobject("LeftText2_ID") = A_0.LeftText2_ID
			End If
			If A_0.RightText1_ID <> A_1.RightText1_ID Then
				jobject("RightText1_ID") = A_0.RightText1_ID
			End If
			If A_0.RightText2_ID <> A_1.RightText2_ID Then
				jobject("RightText2_ID") = A_0.RightText2_ID
			End If
			If A_0.BarShape <> A_1.BarShape Then
				jobject("BarShape") = A_0.BarShape
			End If
			If A_0.BarShape IsNot Nothing Then
				If A_0.BarPattern <> A_1.BarPattern Then
					jobject("BarPattern") = A_0.BarPattern
				End If
				If A_0.BarColor <> A_1.BarColor Then
					jobject("BarColor") = A_0.BarColor.ToArgb()
				End If
			End If
			If A_0.EndShape <> A_1.EndShape Then
				jobject("EndShape") = A_0.EndShape
			End If
			If A_0.EndShape <> 0 Then
				If A_0.EndPattern <> A_1.EndPattern Then
					jobject("EndPattern") = A_0.EndPattern
				End If
				If A_0.EndColor <> A_0.EndColor Then
					jobject("EndColor") = A_0.EndColor.ToArgb()
				End If
			End If
			If A_0.StartShape <> A_1.StartShape Then
				jobject("StartShape") = A_0.StartShape
			End If
			If A_0.StartShape <> 0 Then
				If A_0.StartPattern <> A_1.StartPattern Then
					jobject("StartPattern") = A_0.StartPattern
				End If
				If A_0.StartColor <> A_0.StartColor Then
					jobject("StartColor") = A_0.StartColor.ToArgb()
				End If
			End If
			Return jobject
		End Function

		' Token: 0x06000CA7 RID: 3239 RVA: 0x0005C660 File Offset: 0x0005A860
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTaskArgs)
			If TypeOf A_1.Task Is Task AndAlso MyBase.DataStorage.TasksStorage.DataSource IsNot Nothing Then
				Dim num As Integer = Me.oo0ooO000O.O..Find(A_1.Task.ID)
				If num >= 0 Then
					Dim row As DataRow = Me.oo0ooO000O.O.(num).Row
					Me.OO0oo.o0.(row, CType(A_1.Task, Task))
				End If
			End If
		End Sub

		' Token: 0x06000CA8 RID: 3240 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelTaskArgs)
			If A_1.Task IsNot Nothing AndAlso Not A_1.Task.Initialized Then
				A_1.Task.Mode = 0
			End If
		End Sub

		' Token: 0x06000CA9 RID: 3241 RVA: 0x0005C6F3 File Offset: 0x0005A8F3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.oo0ooO000O.O. = DateTime.Now
		End Sub

		' Token: 0x17000211 RID: 529
		' (get) Token: 0x06000CAA RID: 3242 RVA: 0x0005C700 File Offset: 0x0005A900
		Public ReadOnly Property Strip As Strip
			Get
				Return New Strip(MyBase.ToolStrip, Nothing)
			End Get
		End Property

		' Token: 0x06000CAB RID: 3243 RVA: 0x0005C710 File Offset: 0x0005A910
		Public Sub SetColumns(Properties As TaskProperty(), Captions As String(), Widths As Integer(), Visibles As Boolean())
			CType(Me, ISupportInitialize).BeginInit()
			If Properties.Length <> Captions.Length OrElse Captions.Length <> Widths.Length OrElse Widths.Length <> Visibles.Length Then
				MessageBox.Show("数组长度不一致！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
			MyBase.Columns.Clear()
			Dim num As Integer = Properties.Length - 1
			For i As Integer = 0 To num
				Dim taskPropertyColumn As TaskPropertyColumn = New TaskPropertyColumn()
				taskPropertyColumn.[Property] = Properties(i)
				taskPropertyColumn.Caption = Captions(i)
				taskPropertyColumn.Width = Widths(i)
				taskPropertyColumn.Visible = Visibles(i)
				MyBase.Columns.Add(taskPropertyColumn)
			Next
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		' Token: 0x06000CAC RID: 3244 RVA: 0x0005C7A9 File Offset: 0x0005A9A9
		Public Sub SetComboList(Name As String, ComboList As String)
			Me.oo0ooO000O.O..Add(Name, ComboList)
		End Sub

		' Token: 0x06000CAD RID: 3245 RVA: 0x0005C7B8 File Offset: 0x0005A9B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
			Dim name As String = c1FlexGrid.Cols(A_1.Col).Name
			Try
				For Each text As String In Me.oo0ooO000O.O..Keys
					If Operators.CompareString(text, name, True) = 0 Then
						c1FlexGrid.Cols(A_1.Col).ComboList = Me.oo0ooO000O.O.(text)
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06000CAE RID: 3246 RVA: 0x0005C854 File Offset: 0x0005AA54
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Throw New NotImplementedException()
		End Sub

		' Token: 0x040004DB RID: 1243
		Private <<EMPTY_NAME>> As System.Windows.Forms.Label

		' Token: 0x040004DC RID: 1244
		Friend <<EMPTY_NAME>> As DateTime

		' Token: 0x040004DD RID: 1245
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x040004DE RID: 1246
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
