Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000506 RID: 1286
	<ComVisible(True)>
	Public Class CheckedListBox
		Inherits Control
		Implements OoO_

		' Token: 0x06005415 RID: 21525 RVA: 0x0021E4C3 File Offset: 0x0021C6C3
		Friend Sub New(A_0 As CustomCheckedListBox)
			MyBase.New(A_0, ControlTypeEnum.CheckedListBox)
			Me.O00O.0OOO00. = A_0
		End Sub

		' Token: 0x170013DD RID: 5085
		' (get) Token: 0x06005416 RID: 21526 RVA: 0x0021E4D5 File Offset: 0x0021C6D5
		' (set) Token: 0x06005417 RID: 21527 RVA: 0x0021E4E2 File Offset: 0x0021C6E2
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O00O.0OOO00..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O00O.0OOO00..BorderStyle = value
			End Set
		End Property

		' Token: 0x170013DE RID: 5086
		' (get) Token: 0x06005418 RID: 21528 RVA: 0x0021E4F0 File Offset: 0x0021C6F0
		' (set) Token: 0x06005419 RID: 21529 RVA: 0x0021E4FD File Offset: 0x0021C6FD
		Public Overridable Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O00O.0OOO00..[ReadOnly]
			End Get
			Set(value As BooleanEnum)
				Me.O00O.0OOO00..[ReadOnly] = value
			End Set
		End Property

		' Token: 0x170013DF RID: 5087
		' (get) Token: 0x0600541A RID: 21530 RVA: 0x0021E50B File Offset: 0x0021C70B
		' (set) Token: 0x0600541B RID: 21531 RVA: 0x0021E514 File Offset: 0x0021C714
		<oO0oooo("1860")>
		Public Overridable Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.O00O.0OOO00..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.CheckedListBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.O00O.0OOO00..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value", value)
							If binding IsNot Nothing Then
								Me.O00O.0OOO00..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170013E0 RID: 5088
		' (get) Token: 0x0600541C RID: 21532 RVA: 0x0021E5EC File Offset: 0x0021C7EC
		' (set) Token: 0x0600541D RID: 21533 RVA: 0x0021E670 File Offset: 0x0021C870
		<oO0oooo("0953")>
		Public Property ComboList As String
			Get
				Dim text As String = ""
				Try
					For Each value As Object In Me.O00O.0OOO00..Items
						Dim str As String = Conversions.ToString(value)
						If Operators.CompareString(text, "", True) > 0 Then
							text += "|"
						End If
						text += str
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return text
			End Get
			Set(value As String)
				If Me.O00O.0OOO00..DataSource Is Nothing Then
					Me.O00O.0OOO00..Items.Clear()
				End If
				If Operators.CompareString(value, "", True) > 0 Then
					Me.O00O.0OOO00..BeginUpdate()
					Me.O00O.0OOO00..Items.AddRange(value.Split(New Char() { vbLf, vbCr, "|"c }, StringSplitOptions.RemoveEmptyEntries))
					Me.O00O.0OOO00..EndUpdate()
				End If
			End Set
		End Property

		' Token: 0x170013E1 RID: 5089
		' (get) Token: 0x0600541E RID: 21534 RVA: 0x0021E6E7 File Offset: 0x0021C8E7
		' (set) Token: 0x0600541F RID: 21535 RVA: 0x0021E6F4 File Offset: 0x0021C8F4
		<oO0oooo("0956")>
		Public Property DisplayMember As String
			Get
				Return Me.O00O.0OOO00..DisplayMember
			End Get
			Set(value As String)
				Me.O00O.0OOO00..DisplayMember = value
			End Set
		End Property

		' Token: 0x170013E2 RID: 5090
		' (get) Token: 0x06005420 RID: 21536 RVA: 0x0021E702 File Offset: 0x0021C902
		' (set) Token: 0x06005421 RID: 21537 RVA: 0x0021E70F File Offset: 0x0021C90F
		<oO0oooo("0957")>
		Public Property ValueMember As String
			Get
				Return Me.O00O.0OOO00..ValueMember
			End Get
			Set(value As String)
				Me.O00O.0OOO00..ValueMember = value
			End Set
		End Property

		' Token: 0x170013E3 RID: 5091
		' (get) Token: 0x06005422 RID: 21538 RVA: 0x0021E720 File Offset: 0x0021C920
		' (set) Token: 0x06005423 RID: 21539 RVA: 0x0021E760 File Offset: 0x0021C960
		<oO0oooo("0955")>
		Public Property DataSource As String
			Get
				Dim result As String
				If Me.O00O.0OOO00..DataSource Is Nothing Then
					result = ""
				Else
					result = CType(Me.O00O.0OOO00..DataSource, DataView).Table.TableName
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value) Then
					Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(value)
					If Operators.CompareString(Me.ValueMember, "", True) = 0 OrElse Not dataTable.Columns.Contains(Me.ValueMember) Then
						Me.O00O.0OOO00..DataSource = Nothing
					Else
						Dim dataSource As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(value), Me.DataFilter, "", DataViewRowState.CurrentRows)
						Dim displayMember As String = Me.DisplayMember
						Me.O00O.0OOO00..DataSource = dataSource
						Me.O00O.0OOO00..DisplayMember = displayMember
					End If
					Return
				End If
				Me.O00O.0OOO00..DataSource = Nothing
			End Set
		End Property

		' Token: 0x170013E4 RID: 5092
		' (get) Token: 0x06005424 RID: 21540 RVA: 0x0021E82C File Offset: 0x0021CA2C
		' (set) Token: 0x06005425 RID: 21541 RVA: 0x0021E861 File Offset: 0x0021CA61
		Public Property DataFilter As String
			Get
				Dim result As String
				If Me.O00O.0OOO00..DataSource IsNot Nothing Then
					result = CType(Me.O00O.0OOO00..DataSource, DataView).RowFilter
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.O00O.0OOO00..DataSource IsNot Nothing Then
					CType(Me.O00O.0OOO00..DataSource, DataView).RowFilter = value
				End If
			End Set
		End Property

		' Token: 0x170013E5 RID: 5093
		' (get) Token: 0x06005426 RID: 21542 RVA: 0x0021E888 File Offset: 0x0021CA88
		' (set) Token: 0x06005427 RID: 21543 RVA: 0x0021E8BD File Offset: 0x0021CABD
		Public Property DataSort As String
			Get
				Dim result As String
				If Me.O00O.0OOO00..DataSource IsNot Nothing Then
					result = CType(Me.O00O.0OOO00..DataSource, DataView).Sort
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.O00O.0OOO00..DataSource IsNot Nothing Then
					CType(Me.O00O.0OOO00..DataSource, DataView).Sort = value
				End If
			End Set
		End Property

		' Token: 0x170013E6 RID: 5094
		' (get) Token: 0x06005428 RID: 21544 RVA: 0x0021E8E2 File Offset: 0x0021CAE2
		' (set) Token: 0x06005429 RID: 21545 RVA: 0x0021E8EF File Offset: 0x0021CAEF
		Public Property MultiColumn As Boolean
			Get
				Return Me.O00O.0OOO00..MultiColumn
			End Get
			Set(value As Boolean)
				Me.O00O.0OOO00..MultiColumn = value
			End Set
		End Property

		' Token: 0x170013E7 RID: 5095
		' (get) Token: 0x0600542A RID: 21546 RVA: 0x0021E8FD File Offset: 0x0021CAFD
		' (set) Token: 0x0600542B RID: 21547 RVA: 0x0021E90A File Offset: 0x0021CB0A
		Public Property ColumnWidth As Integer
			Get
				Return Me.O00O.0OOO00..ColumnWidth
			End Get
			Set(value As Integer)
				Me.O00O.0OOO00..ColumnWidth = value
			End Set
		End Property

		' Token: 0x170013E8 RID: 5096
		' (get) Token: 0x0600542C RID: 21548 RVA: 0x0021E918 File Offset: 0x0021CB18
		' (set) Token: 0x0600542D RID: 21549 RVA: 0x0021E925 File Offset: 0x0021CB25
		<oO0oooo("3103")>
		Public Property CheckOnClick As Boolean
			Get
				Return Me.O00O.0OOO00..CheckOnClick
			End Get
			Set(value As Boolean)
				Me.O00O.0OOO00..CheckOnClick = value
			End Set
		End Property

		' Token: 0x170013E9 RID: 5097
		' (get) Token: 0x0600542E RID: 21550 RVA: 0x0021E933 File Offset: 0x0021CB33
		' (set) Token: 0x0600542F RID: 21551 RVA: 0x0021E940 File Offset: 0x0021CB40
		Public Property Separator As String
			Get
				Return Me.O00O.0OOO00..Separator
			End Get
			Set(value As String)
				If value IsNot Nothing AndAlso value.Length = 1 Then
					Me.O00O.0OOO00..Separator = value
				End If
			End Set
		End Property

		' Token: 0x170013EA RID: 5098
		' (get) Token: 0x06005430 RID: 21552 RVA: 0x0021E95A File Offset: 0x0021CB5A
		' (set) Token: 0x06005431 RID: 21553 RVA: 0x0021E967 File Offset: 0x0021CB67
		<oO0oooo("0949")>
		Public Property Value As String
			Get
				Return Me.O00O.0OOO00..Value
			End Get
			Set(value As String)
				Me.O00O.0OOO00..Value = value
			End Set
		End Property

		' Token: 0x170013EB RID: 5099
		' (get) Token: 0x06005432 RID: 21554 RVA: 0x0021E975 File Offset: 0x0021CB75
		<oO0oooo("0954")>
		Public ReadOnly Property Items As CheckedListBox.ObjectCollection
			Get
				Return Me.O00O.0OOO00..Items
			End Get
		End Property

		' Token: 0x170013EC RID: 5100
		' (get) Token: 0x06005433 RID: 21555 RVA: 0x0021E982 File Offset: 0x0021CB82
		Public ReadOnly Property CheckedItems As CheckedListBox.CheckedItemCollection
			Get
				Return Me.O00O.0OOO00..CheckedItems
			End Get
		End Property

		' Token: 0x170013ED RID: 5101
		' (get) Token: 0x06005434 RID: 21556 RVA: 0x0021E98F File Offset: 0x0021CB8F
		<oO0oooo("0950")>
		Public ReadOnly Property CheckedIndices As CheckedListBox.CheckedIndexCollection
			Get
				Return Me.O00O.0OOO00..CheckedIndices
			End Get
		End Property

		' Token: 0x170013EE RID: 5102
		' (get) Token: 0x06005435 RID: 21557 RVA: 0x0021E99C File Offset: 0x0021CB9C
		' (set) Token: 0x06005436 RID: 21558 RVA: 0x0021E9A9 File Offset: 0x0021CBA9
		<oO0oooo("0958")>
		Public Property SelectedIndex As Integer
			Get
				Return Me.O00O.0OOO00..SelectedIndex
			End Get
			Set(value As Integer)
				Me.O00O.0OOO00..SelectedIndex = value
			End Set
		End Property

		' Token: 0x170013EF RID: 5103
		' (get) Token: 0x06005437 RID: 21559 RVA: 0x0021E9B8 File Offset: 0x0021CBB8
		' (set) Token: 0x06005438 RID: 21560 RVA: 0x0021EA20 File Offset: 0x0021CC20
		<oO0oooo("0959")>
		Public Property SelectedItem As Object
			Get
				Dim result As Object
				If Me.O00O.0OOO00..DataSource Is Nothing Then
					result = Me.O00O.0OOO00..SelectedItem
				ElseIf Me.O00O.0OOO00..SelectedIndex < 0 Then
					result = Nothing
				Else
					result = New DataRow(CType(Me.O00O.0OOO00..DataSource, DataView)(Me.O00O.0OOO00..SelectedIndex).Row)
				End If
				Return result
			End Get
			Set(value As Object)
				If value Is Nothing Then
					Me.O00O.0OOO00..SelectedIndex = -1
					Return
				End If
				If Me.O00O.0OOO00..DataSource Is Nothing Then
					Me.O00O.0OOO00..SelectedItem = RuntimeHelpers.GetObjectValue(value)
					Return
				End If
				Dim dataRow As DataRow = CType(value, DataRow)
				Dim num As Integer = CType(Me.O00O.0OOO00..DataSource, DataView).Find(RuntimeHelpers.GetObjectValue(dataRow(Me.ValueMember)))
				If num >= 0 Then
					Me.SelectedIndex = num
				End If
			End Set
		End Property

		' Token: 0x170013F0 RID: 5104
		' (get) Token: 0x06005439 RID: 21561 RVA: 0x0021EA97 File Offset: 0x0021CC97
		' (set) Token: 0x0600543A RID: 21562 RVA: 0x0021EAA4 File Offset: 0x0021CCA4
		<oO0oooo("0960")>
		Public Property SelectedValue As Object
			Get
				Return Me.O00O.0OOO00..SelectedValue2
			End Get
			Set(value As Object)
				Me.O00O.0OOO00..SelectedValue2 = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x0600543B RID: 21563 RVA: 0x0021EAB7 File Offset: 0x0021CCB7
		<oO0oooo("0951")>
		Public Sub SetItemChecked(Index As Integer, Checked As Boolean)
			Me.O00O.0OOO00..SetItemChecked(Index, Checked)
		End Sub

		' Token: 0x0600543C RID: 21564 RVA: 0x0021EAC6 File Offset: 0x0021CCC6
		<oO0oooo("0952")>
		Public Function GetItemChecked(Index As Integer) As Boolean
			Return Me.O00O.0OOO00..GetItemChecked(Index)
		End Function

		' Token: 0x0600543D RID: 21565 RVA: 0x0021EAD4 File Offset: 0x0021CCD4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021CC RID: 8652
		Private <<EMPTY_NAME>> As CustomCheckedListBox
	End Class
End Namespace
