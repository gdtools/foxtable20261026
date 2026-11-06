Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000517 RID: 1303
	<ComVisible(True)>
	Public Class ListBox
		Inherits Control
		Implements OoO_

		' Token: 0x06005535 RID: 21813 RVA: 0x00220B38 File Offset: 0x0021ED38
		Friend Sub New(A_0 As CustomListBox)
			MyBase.New(A_0, ControlTypeEnum.TextBox)
			Me.O.oo_oO. = A_0
		End Sub

		' Token: 0x1700145B RID: 5211
		' (get) Token: 0x06005536 RID: 21814 RVA: 0x00220B49 File Offset: 0x0021ED49
		' (set) Token: 0x06005537 RID: 21815 RVA: 0x00220B56 File Offset: 0x0021ED56
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O.oo_oO..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O.oo_oO..BorderStyle = value
			End Set
		End Property

		' Token: 0x1700145C RID: 5212
		' (get) Token: 0x06005538 RID: 21816 RVA: 0x00220B64 File Offset: 0x0021ED64
		' (set) Token: 0x06005539 RID: 21817 RVA: 0x00220B71 File Offset: 0x0021ED71
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O.oo_oO..[ReadOnly]
			End Get
			Set(value As BooleanEnum)
				Me.O.oo_oO..[ReadOnly] = value
			End Set
		End Property

		' Token: 0x1700145D RID: 5213
		' (get) Token: 0x0600553A RID: 21818 RVA: 0x00220B7F File Offset: 0x0021ED7F
		' (set) Token: 0x0600553B RID: 21819 RVA: 0x00220B88 File Offset: 0x0021ED88
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.O.oo_oO..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.ListBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.O.oo_oO..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value", value)
							If binding IsNot Nothing Then
								Me.O.oo_oO..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x1700145E RID: 5214
		' (get) Token: 0x0600553C RID: 21820 RVA: 0x00220C60 File Offset: 0x0021EE60
		' (set) Token: 0x0600553D RID: 21821 RVA: 0x00220CE4 File Offset: 0x0021EEE4
		<oO0oooo("0953")>
		Public Property ComboList As String
			Get
				Dim text As String = ""
				Try
					For Each value As Object In Me.O.oo_oO..Items
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
				Me.O.oo_oO..Items.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					Me.O.oo_oO..BeginUpdate()
					Me.O.oo_oO..Items.AddRange(value.Split(New Char() { vbLf, vbCr, "|"c }, StringSplitOptions.RemoveEmptyEntries))
					Me.O.oo_oO..EndUpdate()
				End If
			End Set
		End Property

		' Token: 0x1700145F RID: 5215
		' (get) Token: 0x0600553E RID: 21822 RVA: 0x00220D4E File Offset: 0x0021EF4E
		' (set) Token: 0x0600553F RID: 21823 RVA: 0x00220D5B File Offset: 0x0021EF5B
		<oO0oooo("0956")>
		Public Property DisplayMember As String
			Get
				Return Me.O.oo_oO..DisplayMember
			End Get
			Set(value As String)
				Me.O.oo_oO..DisplayMember = value
			End Set
		End Property

		' Token: 0x17001460 RID: 5216
		' (get) Token: 0x06005540 RID: 21824 RVA: 0x00220D69 File Offset: 0x0021EF69
		' (set) Token: 0x06005541 RID: 21825 RVA: 0x00220D76 File Offset: 0x0021EF76
		<oO0oooo("0957")>
		Public Property ValueMember As String
			Get
				Return Me.O.oo_oO..ValueMember
			End Get
			Set(value As String)
				Me.O.oo_oO..ValueMember = value
			End Set
		End Property

		' Token: 0x17001461 RID: 5217
		' (get) Token: 0x06005542 RID: 21826 RVA: 0x00220D84 File Offset: 0x0021EF84
		' (set) Token: 0x06005543 RID: 21827 RVA: 0x00220DC4 File Offset: 0x0021EFC4
		<oO0oooo("0955")>
		Public Property DataSource As String
			Get
				Dim result As String
				If Me.O.oo_oO..DataSource Is Nothing Then
					result = ""
				Else
					result = CType(Me.O.oo_oO..DataSource, DataView).Table.TableName
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value) Then
					Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(value)
					If Operators.CompareString(Me.ValueMember, "", True) = 0 OrElse Not dataTable.Columns.Contains(Me.ValueMember) Then
						Me.O.oo_oO..DataSource = Nothing
					Else
						Dim dataSource As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(value), Me.DataFilter, Me.ValueMember, DataViewRowState.CurrentRows)
						Me.O.oo_oO..DataSource = dataSource
					End If
					Return
				End If
				Me.O.oo_oO..DataSource = Nothing
			End Set
		End Property

		' Token: 0x17001462 RID: 5218
		' (get) Token: 0x06005544 RID: 21828 RVA: 0x00220E7C File Offset: 0x0021F07C
		' (set) Token: 0x06005545 RID: 21829 RVA: 0x00220EB1 File Offset: 0x0021F0B1
		Public Property DataFilter As String
			Get
				Dim result As String
				If Me.O.oo_oO..DataSource IsNot Nothing Then
					result = CType(Me.O.oo_oO..DataSource, DataView).RowFilter
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.O.oo_oO..DataSource IsNot Nothing Then
					CType(Me.O.oo_oO..DataSource, DataView).RowFilter = value
				End If
			End Set
		End Property

		' Token: 0x17001463 RID: 5219
		' (get) Token: 0x06005546 RID: 21830 RVA: 0x00220ED8 File Offset: 0x0021F0D8
		' (set) Token: 0x06005547 RID: 21831 RVA: 0x00220F0D File Offset: 0x0021F10D
		Public Property DataSort As String
			Get
				Dim result As String
				If Me.O.oo_oO..DataSource IsNot Nothing Then
					result = CType(Me.O.oo_oO..DataSource, DataView).Sort
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.O.oo_oO..DataSource IsNot Nothing Then
					CType(Me.O.oo_oO..DataSource, DataView).Sort = value
				End If
			End Set
		End Property

		' Token: 0x17001464 RID: 5220
		' (get) Token: 0x06005548 RID: 21832 RVA: 0x00220F32 File Offset: 0x0021F132
		' (set) Token: 0x06005549 RID: 21833 RVA: 0x00220F3F File Offset: 0x0021F13F
		Public Property MultiColumn As Boolean
			Get
				Return Me.O.oo_oO..MultiColumn
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..MultiColumn = value
			End Set
		End Property

		' Token: 0x17001465 RID: 5221
		' (get) Token: 0x0600554A RID: 21834 RVA: 0x00220F4D File Offset: 0x0021F14D
		' (set) Token: 0x0600554B RID: 21835 RVA: 0x00220F5A File Offset: 0x0021F15A
		Public Property ColumnWidth As Integer
			Get
				Return Me.O.oo_oO..ColumnWidth
			End Get
			Set(value As Integer)
				Me.O.oo_oO..ColumnWidth = value
			End Set
		End Property

		' Token: 0x17001466 RID: 5222
		' (get) Token: 0x0600554C RID: 21836 RVA: 0x00220F68 File Offset: 0x0021F168
		' (set) Token: 0x0600554D RID: 21837 RVA: 0x00220F75 File Offset: 0x0021F175
		Public Property ItemSpacing As Integer
			Get
				Return Me.O.oo_oO..ItemSpacing
			End Get
			Set(value As Integer)
				Me.O.oo_oO..ItemSpacing = value
			End Set
		End Property

		' Token: 0x17001467 RID: 5223
		' (get) Token: 0x0600554E RID: 21838 RVA: 0x00220F83 File Offset: 0x0021F183
		<oO0oooo("0954")>
		Public ReadOnly Property Items As ListBox.ObjectCollection
			Get
				Return Me.O.oo_oO..Items
			End Get
		End Property

		' Token: 0x17001468 RID: 5224
		' (get) Token: 0x0600554F RID: 21839 RVA: 0x00220F90 File Offset: 0x0021F190
		' (set) Token: 0x06005550 RID: 21840 RVA: 0x00220F9D File Offset: 0x0021F19D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Value As Object
			Get
				Return Me.O.oo_oO..Value
			End Get
			Set(value As Object)
				Me.O.oo_oO..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17001469 RID: 5225
		' (get) Token: 0x06005551 RID: 21841 RVA: 0x00220FB0 File Offset: 0x0021F1B0
		' (set) Token: 0x06005552 RID: 21842 RVA: 0x00220FBD File Offset: 0x0021F1BD
		<oO0oooo("0958")>
		Public Property SelectedIndex As Integer
			Get
				Return Me.O.oo_oO..SelectedIndex
			End Get
			Set(value As Integer)
				Me.O.oo_oO..SelectedIndex = value
			End Set
		End Property

		' Token: 0x1700146A RID: 5226
		' (get) Token: 0x06005553 RID: 21843 RVA: 0x00220FCC File Offset: 0x0021F1CC
		' (set) Token: 0x06005554 RID: 21844 RVA: 0x00221030 File Offset: 0x0021F230
		<oO0oooo("0959")>
		Public Property SelectedItem As Object
			Get
				Dim result As Object
				If Me.O.oo_oO..DataSource Is Nothing Then
					result = Me.Value
				ElseIf Me.O.oo_oO..SelectedIndex < 0 Then
					result = Nothing
				Else
					result = New DataRow(CType(Me.O.oo_oO..DataSource, DataView)(Me.O.oo_oO..SelectedIndex).Row)
				End If
				Return result
			End Get
			Set(value As Object)
				If value Is Nothing Then
					Me.O.oo_oO..SelectedIndex = -1
					Return
				End If
				If Me.O.oo_oO..DataSource Is Nothing Then
					Me.Value = RuntimeHelpers.GetObjectValue(value)
					Return
				End If
				Dim dataRow As DataRow = CType(value, DataRow)
				Dim selectedIndex As Integer = CType(Me.O.oo_oO..DataSource, DataView).Find(RuntimeHelpers.GetObjectValue(dataRow(Me.ValueMember)))
				Me.SelectedIndex = selectedIndex
			End Set
		End Property

		' Token: 0x1700146B RID: 5227
		' (get) Token: 0x06005555 RID: 21845 RVA: 0x0022109E File Offset: 0x0021F29E
		' (set) Token: 0x06005556 RID: 21846 RVA: 0x002210A6 File Offset: 0x0021F2A6
		<oO0oooo("0960")>
		Public Property SelectedValue As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06005557 RID: 21847 RVA: 0x002210B4 File Offset: 0x0021F2B4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x04002206 RID: 8710
		Private <<EMPTY_NAME>> As CustomListBox
	End Class
End Namespace
