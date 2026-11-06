Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000505 RID: 1285
	<ComVisible(True)>
	Public Class CheckedComboBox
		Inherits Control
		Implements OoO_

		' Token: 0x060053BE RID: 21438 RVA: 0x0021DC40 File Offset: 0x0021BE40
		Friend Sub New(A_0 As O0oo000oO0oo_)
			MyBase.New(A_0, ControlTypeEnum.CheckedComboBox)
			Me.o0.00O. = A_0
			Me.o0.00O..InitialSelection = 1
		End Sub

		' Token: 0x170013B5 RID: 5045
		' (get) Token: 0x060053BF RID: 21439 RVA: 0x0021DC5E File Offset: 0x0021BE5E
		' (set) Token: 0x060053C0 RID: 21440 RVA: 0x0021DC6B File Offset: 0x0021BE6B
		<oO0oooo("0750")>
		Public Property Text As String
			Get
				Return Me.o0.00O..Text
			End Get
			Set(value As String)
				Me.o0.00O..Value = value
			End Set
		End Property

		' Token: 0x170013B6 RID: 5046
		' (get) Token: 0x060053C1 RID: 21441 RVA: 0x0021DC7C File Offset: 0x0021BE7C
		' (set) Token: 0x060053C2 RID: 21442 RVA: 0x0021DCB7 File Offset: 0x0021BEB7
		<oO0oooo("0751")>
		Public Property Value As Object
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o0.00O..Value)
				Dim result As Object
				If objectValue IsNot Nothing AndAlso Operators.CompareString(objectValue.ToString(), "", True) = 0 Then
					result = Nothing
				Else
					result = objectValue
				End If
				Return result
			End Get
			Set(value As Object)
				Me.o0.00O..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170013B7 RID: 5047
		' (get) Token: 0x060053C3 RID: 21443 RVA: 0x0021DCCA File Offset: 0x0021BECA
		' (set) Token: 0x060053C4 RID: 21444 RVA: 0x0021DCD7 File Offset: 0x0021BED7
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o0.00O..o_0Oo.o_.()
			End Get
			Set(value As BooleanEnum)
				Me.o0.00O..O.o00OOo_.(value)
			End Set
		End Property

		' Token: 0x170013B8 RID: 5048
		' (get) Token: 0x060053C5 RID: 21445 RVA: 0x0021DCE5 File Offset: 0x0021BEE5
		' (set) Token: 0x060053C6 RID: 21446 RVA: 0x0021DCF0 File Offset: 0x0021BEF0
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o0.00O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.CheckedComboBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o0.00O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Me.o0.00O..DataType = OO_00oOO.Vars.VariableTable.Columns(text).DataType
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							If binding IsNot Nothing Then
								Me.o0.00O..DataBindings.Add(binding)
							End If
							Me.o0.00O..DataType = MyBase.BindCol.DataCol.BaseColumn.DataType
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170013B9 RID: 5049
		' (get) Token: 0x060053C7 RID: 21447 RVA: 0x0021DE18 File Offset: 0x0021C018
		' (set) Token: 0x060053C8 RID: 21448 RVA: 0x0021DE25 File Offset: 0x0021C025
		Public Property AllowEditValue As Boolean
			Get
				Return Me.o0.00O..OOo0_o.O00__.()
			End Get
			Set(value As Boolean)
				Me.o0.00O..O00O.ooOO0.(value)
			End Set
		End Property

		' Token: 0x170013BA RID: 5050
		' (get) Token: 0x060053C9 RID: 21449 RVA: 0x0021DE33 File Offset: 0x0021C033
		' (set) Token: 0x060053CA RID: 21450 RVA: 0x0021DE40 File Offset: 0x0021C040
		Public Property DropDownWidth As Integer
			Get
				Return Me.o0.00O..o__0o0o_.OO0O_.()
			End Get
			Set(value As Integer)
				Me.o0.00O..o_.0__Oo____O.(value)
			End Set
		End Property

		' Token: 0x170013BB RID: 5051
		' (get) Token: 0x060053CB RID: 21451 RVA: 0x0021DE4E File Offset: 0x0021C04E
		' (set) Token: 0x060053CC RID: 21452 RVA: 0x0021DE5B File Offset: 0x0021C05B
		Public Property DropDownHeight As Integer
			Get
				Return Me.o0.00O..O0O.o.()
			End Get
			Set(value As Integer)
				Me.o0.00O..o.oOOO_0_.(value)
			End Set
		End Property

		' Token: 0x170013BC RID: 5052
		' (get) Token: 0x060053CD RID: 21453 RVA: 0x0021DE69 File Offset: 0x0021C069
		' (set) Token: 0x060053CE RID: 21454 RVA: 0x0021DE76 File Offset: 0x0021C076
		Public Property MaxDropDownItems As Integer
			Get
				Return Me.o0.00O..O_oOo.o0Oo.()
			End Get
			Set(value As Integer)
				Me.o0.00O..O.o00OOo_.(value)
			End Set
		End Property

		' Token: 0x170013BD RID: 5053
		' (get) Token: 0x060053CF RID: 21455 RVA: 0x0021DE84 File Offset: 0x0021C084
		' (set) Token: 0x060053D0 RID: 21456 RVA: 0x0021DF08 File Offset: 0x0021C108
		<oO0oooo("0925")>
		Public Property ComboList As String
			Get
				Dim text As String = ""
				Try
					For Each value As Object In Me.o0.00O..o_0Oo.o_.()
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
				If Me.o0.00O..O_.0.() Is Nothing Then
					Me.o0.00O..o_0Oo.o_.().Clear()
				End If
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o0.00O..o_0Oo.o_.().AddRange(value.Split(New Char() { vbLf, vbCr, "|"c }, StringSplitOptions.RemoveEmptyEntries))
				End If
			End Set
		End Property

		' Token: 0x170013BE RID: 5054
		' (get) Token: 0x060053D1 RID: 21457 RVA: 0x0021DF69 File Offset: 0x0021C169
		' (set) Token: 0x060053D2 RID: 21458 RVA: 0x0021DF76 File Offset: 0x0021C176
		<oO0oooo("0927")>
		Public Property DisplayMember As String
			Get
				Return Me.o0.00O..O0O.o.()
			End Get
			Set(value As String)
				Me.o0.00O..OoO.0oo_Oo_.(value)
			End Set
		End Property

		' Token: 0x170013BF RID: 5055
		' (get) Token: 0x060053D3 RID: 21459 RVA: 0x0021DF84 File Offset: 0x0021C184
		' (set) Token: 0x060053D4 RID: 21460 RVA: 0x0021DF94 File Offset: 0x0021C194
		<oO0oooo("0928")>
		Public Property ValueMember As String
			Get
				Return Me.o0.00O..OOooOOO.O0.()
			End Get
			Set(value As String)
				If Me.o0.00O..O_.0.() IsNot Nothing Then
					Dim dataView As DataView = CType(Me.o0.00O..O_.0.(), DataView)
					If dataView.Table.Columns.Contains(value) Then
						dataView.Sort = value
					End If
				End If
				Me.o0.00O..o0OO.O.(value)
			End Set
		End Property

		' Token: 0x170013C0 RID: 5056
		' (get) Token: 0x060053D5 RID: 21461 RVA: 0x0021DFE8 File Offset: 0x0021C1E8
		' (set) Token: 0x060053D6 RID: 21462 RVA: 0x0021E028 File Offset: 0x0021C228
		<oO0oooo("0926")>
		Public Property DataSource As String
			Get
				Dim result As String
				If Me.o0.00O..O_.0.() Is Nothing Then
					result = ""
				Else
					result = CType(Me.o0.00O..O_.0.(), DataView).Table.TableName
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value) Then
					Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(value)
					If Operators.CompareString(Me.ValueMember, "", True) = 0 OrElse Not dataTable.Columns.Contains(Me.ValueMember) Then
						Me.o0.00O..OoO.0oo_Oo_.(Nothing)
					Else
						Dim a_ As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(value), Me.DataFilter, Me.ValueMember, DataViewRowState.CurrentRows)
						Me.o0.00O..OoO.0oo_Oo_.(a_)
					End If
					Return
				End If
				Me.o0.00O..OoO.0oo_Oo_.(Nothing)
			End Set
		End Property

		' Token: 0x170013C1 RID: 5057
		' (get) Token: 0x060053D7 RID: 21463 RVA: 0x0021E0E0 File Offset: 0x0021C2E0
		' (set) Token: 0x060053D8 RID: 21464 RVA: 0x0021E115 File Offset: 0x0021C315
		Public Property DataFilter As String
			Get
				Dim result As String
				If Me.o0.00O..O_.0.() IsNot Nothing Then
					result = CType(Me.o0.00O..O_.0.(), DataView).RowFilter
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.o0.00O..O_.0.() IsNot Nothing Then
					CType(Me.o0.00O..O_.0.(), DataView).RowFilter = value
				End If
			End Set
		End Property

		' Token: 0x170013C2 RID: 5058
		' (get) Token: 0x060053D9 RID: 21465 RVA: 0x0021E13A File Offset: 0x0021C33A
		' (set) Token: 0x060053DA RID: 21466 RVA: 0x0021E147 File Offset: 0x0021C347
		<oO0oooo("0946")>
		Public Property MultiColumn As Boolean
			Get
				Return Me.o0.00O..oOO0_o._0O00.()
			End Get
			Set(value As Boolean)
				Me.o0.00O..o_.0__Oo____O.(value)
			End Set
		End Property

		' Token: 0x170013C3 RID: 5059
		' (get) Token: 0x060053DB RID: 21467 RVA: 0x0021E155 File Offset: 0x0021C355
		' (set) Token: 0x060053DC RID: 21468 RVA: 0x0021E162 File Offset: 0x0021C362
		<oO0oooo("0946")>
		Public Property ColumnWidth As Integer
			Get
				Return Me.o0.00O..O_.0.()
			End Get
			Set(value As Integer)
				If value > 0 Then
					Me.o0.00O..OOooOOO.O0.(value)
				End If
			End Set
		End Property

		' Token: 0x170013C4 RID: 5060
		' (get) Token: 0x060053DD RID: 21469 RVA: 0x0021E174 File Offset: 0x0021C374
		' (set) Token: 0x060053DE RID: 21470 RVA: 0x0021E181 File Offset: 0x0021C381
		<oO0oooo("3103")>
		Public Property CheckOnClick As Boolean
			Get
				Return Me.o0.00O..o__0o0o_.OO0O_.()
			End Get
			Set(value As Boolean)
				Me.o0.00O..Oo.00_.(value)
			End Set
		End Property

		' Token: 0x170013C5 RID: 5061
		' (get) Token: 0x060053DF RID: 21471 RVA: 0x0021E18F File Offset: 0x0021C38F
		' (set) Token: 0x060053E0 RID: 21472 RVA: 0x0021E19C File Offset: 0x0021C39C
		<oO0oooo("0945")>
		Public Property Separator As Char
			Get
				Return Me.o0.00O..o_0Oo.o_.()
			End Get
			Set(value As Char)
				If Operators.CompareString(Conversions.ToString(value), "", True) = 0 Then
					Me.o0.00O..o0OO.O.(","c)
					Return
				End If
				Me.o0.00O..o0OO.O.(value)
			End Set
		End Property

		' Token: 0x170013C6 RID: 5062
		' (get) Token: 0x060053E1 RID: 21473 RVA: 0x0021E1CC File Offset: 0x0021C3CC
		' (set) Token: 0x060053E2 RID: 21474 RVA: 0x0021E1DA File Offset: 0x0021C3DA
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x170013C7 RID: 5063
		' (get) Token: 0x060053E3 RID: 21475 RVA: 0x0021E1DC File Offset: 0x0021C3DC
		' (set) Token: 0x060053E4 RID: 21476 RVA: 0x0021E1E9 File Offset: 0x0021C3E9
		<oO0oooo("1861")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o0.00O..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o0.00O..TextAlign = value
			End Set
		End Property

		' Token: 0x170013C8 RID: 5064
		' (get) Token: 0x060053E5 RID: 21477 RVA: 0x0021E1F7 File Offset: 0x0021C3F7
		' (set) Token: 0x060053E6 RID: 21478 RVA: 0x0021E204 File Offset: 0x0021C404
		Public Property CharacterCasing As CharacterCasing
			Get
				Return Me.o0.00O..CharacterCasing
			End Get
			Set(value As CharacterCasing)
				Me.o0.00O..CharacterCasing = value
			End Set
		End Property

		' Token: 0x170013C9 RID: 5065
		' (get) Token: 0x060053E7 RID: 21479 RVA: 0x0021E212 File Offset: 0x0021C412
		' (set) Token: 0x060053E8 RID: 21480 RVA: 0x0021E21F File Offset: 0x0021C41F
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o0.00O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o0.00O..BorderStyle = value
			End Set
		End Property

		' Token: 0x170013CA RID: 5066
		' (get) Token: 0x060053E9 RID: 21481 RVA: 0x0021E22D File Offset: 0x0021C42D
		' (set) Token: 0x060053EA RID: 21482 RVA: 0x0021E23A File Offset: 0x0021C43A
		Public Property BorderColor As Color
			Get
				Return Me.o0.00O..BorderColor
			End Get
			Set(value As Color)
				Me.o0.00O..BorderColor = value
			End Set
		End Property

		' Token: 0x170013CB RID: 5067
		' (get) Token: 0x060053EB RID: 21483 RVA: 0x0021E248 File Offset: 0x0021C448
		' (set) Token: 0x060053EC RID: 21484 RVA: 0x0021E255 File Offset: 0x0021C455
		Public Overrides Property BackColor As Color
			Get
				Return Me.o0.00O..BackColor
			End Get
			Set(value As Color)
				Me.o0.00O..BackColor = value
			End Set
		End Property

		' Token: 0x170013CC RID: 5068
		' (get) Token: 0x060053ED RID: 21485 RVA: 0x0021E263 File Offset: 0x0021C463
		' (set) Token: 0x060053EE RID: 21486 RVA: 0x0021E270 File Offset: 0x0021C470
		Public Overrides Property ForeColor As Color
			Get
				Return Me.o0.00O..ForeColor
			End Get
			Set(value As Color)
				Me.o0.00O..ForeColor = value
			End Set
		End Property

		' Token: 0x170013CD RID: 5069
		' (get) Token: 0x060053EF RID: 21487 RVA: 0x0021E27E File Offset: 0x0021C47E
		' (set) Token: 0x060053F0 RID: 21488 RVA: 0x0021E28B File Offset: 0x0021C48B
		Public Property MaxLength As Integer
			Get
				Return Me.o0.00O..MaxLength
			End Get
			Set(value As Integer)
				Me.o0.00O..MaxLength = value
			End Set
		End Property

		' Token: 0x170013CE RID: 5070
		' (get) Token: 0x060053F1 RID: 21489 RVA: 0x0021E299 File Offset: 0x0021C499
		' (set) Token: 0x060053F2 RID: 21490 RVA: 0x0021E2A6 File Offset: 0x0021C4A6
		<oO0oooo("1865")>
		Public Property PasswordChar As Char
			Get
				Return Me.o0.00O..PasswordChar
			End Get
			Set(value As Char)
				Me.o0.00O..PasswordChar = value
			End Set
		End Property

		' Token: 0x170013CF RID: 5071
		' (get) Token: 0x060053F3 RID: 21491 RVA: 0x0021E2B4 File Offset: 0x0021C4B4
		' (set) Token: 0x060053F4 RID: 21492 RVA: 0x0021E2C1 File Offset: 0x0021C4C1
		<oO0oooo("1866")>
		Public Property EditMask As String
			Get
				Return Me.o0.00O..EditMask
			End Get
			Set(value As String)
				Me.o0.00O..EditMask = value
			End Set
		End Property

		' Token: 0x170013D0 RID: 5072
		' (get) Token: 0x060053F5 RID: 21493 RVA: 0x0021E2CF File Offset: 0x0021C4CF
		' (set) Token: 0x060053F6 RID: 21494 RVA: 0x0021E2DC File Offset: 0x0021C4DC
		<oO0oooo("1867")>
		Public Property FormatString As String
			Get
				Return Me.o0.00O..CustomFormat
			End Get
			Set(value As String)
				Me.o0.00O..CustomFormat = value
				Me.o0.00O..EditFormat.CustomFormat = Nothing
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o0.00O..FormatType = 2
					Return
				End If
				Me.o0.00O..FormatType = 0
			End Set
		End Property

		' Token: 0x170013D1 RID: 5073
		' (get) Token: 0x060053F7 RID: 21495 RVA: 0x0021E32E File Offset: 0x0021C52E
		' (set) Token: 0x060053F8 RID: 21496 RVA: 0x0021E33B File Offset: 0x0021C53B
		Public Property TrimStart As Boolean
			Get
				Return Me.o0.00O..TrimStart
			End Get
			Set(value As Boolean)
				Me.o0.00O..TrimStart = value
			End Set
		End Property

		' Token: 0x170013D2 RID: 5074
		' (get) Token: 0x060053F9 RID: 21497 RVA: 0x0021E349 File Offset: 0x0021C549
		' (set) Token: 0x060053FA RID: 21498 RVA: 0x0021E356 File Offset: 0x0021C556
		Public Property TrimEnd As Boolean
			Get
				Return Me.o0.00O..TrimStart
			End Get
			Set(value As Boolean)
				Me.o0.00O..TrimEnd = value
			End Set
		End Property

		' Token: 0x170013D3 RID: 5075
		' (get) Token: 0x060053FB RID: 21499 RVA: 0x0021E364 File Offset: 0x0021C564
		' (set) Token: 0x060053FC RID: 21500 RVA: 0x0021E371 File Offset: 0x0021C571
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.o0.00O..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.o0.00O..InitialSelection = value
			End Set
		End Property

		' Token: 0x170013D4 RID: 5076
		' (get) Token: 0x060053FD RID: 21501 RVA: 0x0021E37F File Offset: 0x0021C57F
		<oO0oooo("0934")>
		Public ReadOnly Property Items As CheckedListBox.ObjectCollection
			Get
				Return Me.o0.00O..o_0Oo.o_.()
			End Get
		End Property

		' Token: 0x170013D5 RID: 5077
		' (get) Token: 0x060053FE RID: 21502 RVA: 0x0021E38C File Offset: 0x0021C58C
		' (set) Token: 0x060053FF RID: 21503 RVA: 0x0021E399 File Offset: 0x0021C599
		<oO0oooo("0930")>
		Public Property SelectedIndex As Integer
			Get
				Return Me.o0.00O..o0.0.()
			End Get
			Set(value As Integer)
				Me.o0.00O..o0.O_O.(value)
			End Set
		End Property

		' Token: 0x170013D6 RID: 5078
		' (get) Token: 0x06005400 RID: 21504 RVA: 0x0021E3A7 File Offset: 0x0021C5A7
		' (set) Token: 0x06005401 RID: 21505 RVA: 0x0021E3B4 File Offset: 0x0021C5B4
		<oO0oooo("0932")>
		Public Property SelectedItem As Object
			Get
				Return Me.o0.00O..o0.0.()
			End Get
			Set(value As Object)
				Me.o0.00O..o.__.(RuntimeHelpers.GetObjectValue(value))
			End Set
		End Property

		' Token: 0x170013D7 RID: 5079
		' (get) Token: 0x06005402 RID: 21506 RVA: 0x0021E3C7 File Offset: 0x0021C5C7
		' (set) Token: 0x06005403 RID: 21507 RVA: 0x0021E3D4 File Offset: 0x0021C5D4
		<oO0oooo("0740")>
		Public Property SelectedText As String
			Get
				Return Me.o0.00O..SelectedText
			End Get
			Set(value As String)
				Me.o0.00O..SelectedText = value
			End Set
		End Property

		' Token: 0x170013D8 RID: 5080
		' (get) Token: 0x06005404 RID: 21508 RVA: 0x0021E3E2 File Offset: 0x0021C5E2
		' (set) Token: 0x06005405 RID: 21509 RVA: 0x0021E3EF File Offset: 0x0021C5EF
		<oO0oooo("0933")>
		Public Property SelectedValue As Object
			Get
				Return Me.o0.00O..o_0Oo.o_.()
			End Get
			Set(value As Object)
				Me.o0.00O..o0OO.O.(RuntimeHelpers.GetObjectValue(value))
			End Set
		End Property

		' Token: 0x170013D9 RID: 5081
		' (get) Token: 0x06005406 RID: 21510 RVA: 0x0021E402 File Offset: 0x0021C602
		' (set) Token: 0x06005407 RID: 21511 RVA: 0x0021E40F File Offset: 0x0021C60F
		Public Property SelectionStart As Integer
			Get
				Return Me.o0.00O..SelectionStart
			End Get
			Set(value As Integer)
				Me.o0.00O..SelectionStart = value
			End Set
		End Property

		' Token: 0x170013DA RID: 5082
		' (get) Token: 0x06005408 RID: 21512 RVA: 0x0021E41D File Offset: 0x0021C61D
		' (set) Token: 0x06005409 RID: 21513 RVA: 0x0021E42A File Offset: 0x0021C62A
		Public Property SelectionLength As Integer
			Get
				Return Me.o0.00O..SelectionLength
			End Get
			Set(value As Integer)
				Me.o0.00O..SelectionLength = value
			End Set
		End Property

		' Token: 0x0600540A RID: 21514 RVA: 0x0021E438 File Offset: 0x0021C638
		Public Sub SelectAll()
			Me.o0.00O..SelectAll()
		End Sub

		' Token: 0x0600540B RID: 21515 RVA: 0x0021E445 File Offset: 0x0021C645
		Public Sub Copy()
			Me.o0.00O..Copy()
		End Sub

		' Token: 0x0600540C RID: 21516 RVA: 0x0021E452 File Offset: 0x0021C652
		Public Sub Cut()
			Me.o0.00O..Cut()
		End Sub

		' Token: 0x0600540D RID: 21517 RVA: 0x0021E45F File Offset: 0x0021C65F
		Public Sub Paste()
			Me.o0.00O..Paste()
		End Sub

		' Token: 0x0600540E RID: 21518 RVA: 0x0021E46C File Offset: 0x0021C66C
		Public Sub Undo()
			Me.o0.00O..Undo()
		End Sub

		' Token: 0x0600540F RID: 21519 RVA: 0x0021E479 File Offset: 0x0021C679
		Public Sub ResetText()
			Me.o0.00O..ResetText()
		End Sub

		' Token: 0x170013DB RID: 5083
		' (get) Token: 0x06005410 RID: 21520 RVA: 0x0021E486 File Offset: 0x0021C686
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Lines As String()
			Get
				Return Me.o0.00O..Lines
			End Get
		End Property

		' Token: 0x06005411 RID: 21521 RVA: 0x0021E493 File Offset: 0x0021C693
		Public Sub OpenDropDown()
			Me.o0.00O..OpenDropDown()
		End Sub

		' Token: 0x06005412 RID: 21522 RVA: 0x0021E4A0 File Offset: 0x0021C6A0
		Public Sub CloseDropDown()
			Me.o0.00O..CloseDropDown()
		End Sub

		' Token: 0x170013DC RID: 5084
		' (get) Token: 0x06005413 RID: 21523 RVA: 0x0021E4AD File Offset: 0x0021C6AD
		Public ReadOnly Property DroppedDown As Boolean
			Get
				Return Me.o0.00O..DroppedDown
			End Get
		End Property

		' Token: 0x06005414 RID: 21524 RVA: 0x0021E4BA File Offset: 0x0021C6BA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021CB RID: 8651
		Private <<EMPTY_NAME>> As O0oo000oO0oo_
	End Class
End Namespace
