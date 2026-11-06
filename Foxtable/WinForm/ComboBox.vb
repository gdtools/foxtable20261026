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
	' Token: 0x02000508 RID: 1288
	<ComVisible(True)>
	Public Class ComboBox
		Inherits Control
		Implements OoO_

		' Token: 0x0600544C RID: 21580 RVA: 0x0021EC63 File Offset: 0x0021CE63
		Friend Sub New(A_0 As OoOO0Oo_oo0oO)
			MyBase.New(A_0, ControlTypeEnum.ComboBox)
			Me.o_Oo._O_00000_. = A_0
		End Sub

		' Token: 0x170013F7 RID: 5111
		' (get) Token: 0x0600544D RID: 21581 RVA: 0x0021EC74 File Offset: 0x0021CE74
		' (set) Token: 0x0600544E RID: 21582 RVA: 0x0021EC81 File Offset: 0x0021CE81
		<oO0oooo("0750")>
		Public Property Text As String
			Get
				Return Me.o_Oo._O_00000_..Text
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..Value = value
			End Set
		End Property

		' Token: 0x170013F8 RID: 5112
		' (get) Token: 0x0600544F RID: 21583 RVA: 0x0021EC90 File Offset: 0x0021CE90
		' (set) Token: 0x06005450 RID: 21584 RVA: 0x0021ECCB File Offset: 0x0021CECB
		<oO0oooo("0751")>
		Public Property Value As Object
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o_Oo._O_00000_..Value)
				Dim result As Object
				If objectValue IsNot Nothing AndAlso Operators.CompareString(objectValue.ToString(), "", True) = 0 Then
					result = Nothing
				Else
					result = objectValue
				End If
				Return result
			End Get
			Set(value As Object)
				Me.o_Oo._O_00000_..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170013F9 RID: 5113
		' (get) Token: 0x06005451 RID: 21585 RVA: 0x0021ECDE File Offset: 0x0021CEDE
		' (set) Token: 0x06005452 RID: 21586 RVA: 0x0021ECEB File Offset: 0x0021CEEB
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o_Oo._O_00000_..O__oo_OO.O_.()
			End Get
			Set(value As BooleanEnum)
				Me.o_Oo._O_00000_..o__0_OooO0._.(value)
			End Set
		End Property

		' Token: 0x170013FA RID: 5114
		' (get) Token: 0x06005453 RID: 21587 RVA: 0x0021ECF9 File Offset: 0x0021CEF9
		' (set) Token: 0x06005454 RID: 21588 RVA: 0x0021ED04 File Offset: 0x0021CF04
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.ComboBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o_Oo._O_00000_..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Me.o_Oo._O_00000_..DataType = OO_00oOO.Vars.VariableTable.Columns(text).DataType
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							If binding IsNot Nothing Then
								Me.o_Oo._O_00000_..DataBindings.Add(binding)
								If Me.o_Oo._O_00000_..DataBindings.Count > 0 Then
									Dim num As Integer = value.LastIndexOf("."c)
									Dim a_ As String = value.Substring(0, num)
									Dim name As String = value.Substring(num + 1)
									Me.o_Oo._O_00000_..DataType = OO_00oOO.Tables(a_).DataTable.BaseTable.Columns(name).DataType
								End If
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170013FB RID: 5115
		' (get) Token: 0x06005455 RID: 21589 RVA: 0x0021EE6C File Offset: 0x0021D06C
		' (set) Token: 0x06005456 RID: 21590 RVA: 0x0021EE79 File Offset: 0x0021D079
		<oO0oooo("1861")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o_Oo._O_00000_..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o_Oo._O_00000_..TextAlign = value
			End Set
		End Property

		' Token: 0x170013FC RID: 5116
		' (get) Token: 0x06005457 RID: 21591 RVA: 0x0021EE87 File Offset: 0x0021D087
		' (set) Token: 0x06005458 RID: 21592 RVA: 0x0021EE94 File Offset: 0x0021D094
		Public Property CharacterCasing As CharacterCasing
			Get
				Return Me.o_Oo._O_00000_..CharacterCasing
			End Get
			Set(value As CharacterCasing)
				Me.o_Oo._O_00000_..CharacterCasing = value
			End Set
		End Property

		' Token: 0x170013FD RID: 5117
		' (get) Token: 0x06005459 RID: 21593 RVA: 0x0021EEA4 File Offset: 0x0021D0A4
		' (set) Token: 0x0600545A RID: 21594 RVA: 0x0021EEB2 File Offset: 0x0021D0B2
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x170013FE RID: 5118
		' (get) Token: 0x0600545B RID: 21595 RVA: 0x0021EEB4 File Offset: 0x0021D0B4
		' (set) Token: 0x0600545C RID: 21596 RVA: 0x0021EEC1 File Offset: 0x0021D0C1
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o_Oo._O_00000_..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o_Oo._O_00000_..BorderStyle = value
			End Set
		End Property

		' Token: 0x170013FF RID: 5119
		' (get) Token: 0x0600545D RID: 21597 RVA: 0x0021EECF File Offset: 0x0021D0CF
		' (set) Token: 0x0600545E RID: 21598 RVA: 0x0021EEDC File Offset: 0x0021D0DC
		Public Property BorderColor As Color
			Get
				Return Me.o_Oo._O_00000_..BorderColor
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..BorderColor = value
			End Set
		End Property

		' Token: 0x17001400 RID: 5120
		' (get) Token: 0x0600545F RID: 21599 RVA: 0x0021EEEA File Offset: 0x0021D0EA
		' (set) Token: 0x06005460 RID: 21600 RVA: 0x0021EEF7 File Offset: 0x0021D0F7
		Public Property MaxLength As Integer
			Get
				Return Me.o_Oo._O_00000_..MaxLength
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..MaxLength = value
			End Set
		End Property

		' Token: 0x17001401 RID: 5121
		' (get) Token: 0x06005461 RID: 21601 RVA: 0x0021EF05 File Offset: 0x0021D105
		' (set) Token: 0x06005462 RID: 21602 RVA: 0x0021EF12 File Offset: 0x0021D112
		<oO0oooo("1865")>
		Public Property PasswordChar As Char
			Get
				Return Me.o_Oo._O_00000_..PasswordChar
			End Get
			Set(value As Char)
				Me.o_Oo._O_00000_..PasswordChar = value
			End Set
		End Property

		' Token: 0x17001402 RID: 5122
		' (get) Token: 0x06005463 RID: 21603 RVA: 0x0021EF20 File Offset: 0x0021D120
		' (set) Token: 0x06005464 RID: 21604 RVA: 0x0021EF2D File Offset: 0x0021D12D
		Public Overrides Property BackColor As Color
			Get
				Return Me.o_Oo._O_00000_..BackColor
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..BackColor = value
			End Set
		End Property

		' Token: 0x17001403 RID: 5123
		' (get) Token: 0x06005465 RID: 21605 RVA: 0x0021EF3B File Offset: 0x0021D13B
		' (set) Token: 0x06005466 RID: 21606 RVA: 0x0021EF48 File Offset: 0x0021D148
		Public Overrides Property ForeColor As Color
			Get
				Return Me.o_Oo._O_00000_..ForeColor
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..ForeColor = value
			End Set
		End Property

		' Token: 0x17001404 RID: 5124
		' (get) Token: 0x06005467 RID: 21607 RVA: 0x0021EF56 File Offset: 0x0021D156
		' (set) Token: 0x06005468 RID: 21608 RVA: 0x0021EF63 File Offset: 0x0021D163
		<oO0oooo("1866")>
		Public Property EditMask As String
			Get
				Return Me.o_Oo._O_00000_..EditMask
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..EditMask = value
			End Set
		End Property

		' Token: 0x17001405 RID: 5125
		' (get) Token: 0x06005469 RID: 21609 RVA: 0x0021EF71 File Offset: 0x0021D171
		' (set) Token: 0x0600546A RID: 21610 RVA: 0x0021EF84 File Offset: 0x0021D184
		<oO0oooo("1867")>
		Public Property FormatString As String
			Get
				Return Me.o_Oo._O_00000_..DisplayFormat.CustomFormat
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..DisplayFormat.CustomFormat = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o_Oo._O_00000_..DisplayFormat.FormatType = 2
					Return
				End If
				Me.o_Oo._O_00000_..DisplayFormat.FormatType = 0
			End Set
		End Property

		' Token: 0x17001406 RID: 5126
		' (get) Token: 0x0600546B RID: 21611 RVA: 0x0021EFD4 File Offset: 0x0021D1D4
		' (set) Token: 0x0600546C RID: 21612 RVA: 0x0021EFE1 File Offset: 0x0021D1E1
		Public Property TrimStart As Boolean
			Get
				Return Me.o_Oo._O_00000_..TrimStart
			End Get
			Set(value As Boolean)
				Me.o_Oo._O_00000_..TrimStart = value
			End Set
		End Property

		' Token: 0x17001407 RID: 5127
		' (get) Token: 0x0600546D RID: 21613 RVA: 0x0021EFEF File Offset: 0x0021D1EF
		' (set) Token: 0x0600546E RID: 21614 RVA: 0x0021EFFC File Offset: 0x0021D1FC
		Public Property TrimEnd As Boolean
			Get
				Return Me.o_Oo._O_00000_..TrimStart
			End Get
			Set(value As Boolean)
				Me.o_Oo._O_00000_..TrimEnd = value
			End Set
		End Property

		' Token: 0x17001408 RID: 5128
		' (get) Token: 0x0600546F RID: 21615 RVA: 0x0021F00A File Offset: 0x0021D20A
		' (set) Token: 0x06005470 RID: 21616 RVA: 0x0021F017 File Offset: 0x0021D217
		Public Property AllowEditValue As Boolean
			Get
				Return Me.o_Oo._O_00000_..oo0.ooo.()
			End Get
			Set(value As Boolean)
				Me.o_Oo._O_00000_..o.Oo0.(value)
			End Set
		End Property

		' Token: 0x17001409 RID: 5129
		' (get) Token: 0x06005471 RID: 21617 RVA: 0x0021F025 File Offset: 0x0021D225
		' (set) Token: 0x06005472 RID: 21618 RVA: 0x0021F035 File Offset: 0x0021D235
		<oO0oooo("0943")>
		Public Property AutoComplete As Boolean
			Get
				Return Me.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.SuggestAppend
			End Get
			Set(value As Boolean)
				If value Then
					Me.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.SuggestAppend
					Return
				End If
				Me.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.None
			End Set
		End Property

		' Token: 0x1700140A RID: 5130
		' (get) Token: 0x06005473 RID: 21619 RVA: 0x0021F053 File Offset: 0x0021D253
		' (set) Token: 0x06005474 RID: 21620 RVA: 0x0021F060 File Offset: 0x0021D260
		Public Property DropDownWidth As Integer
			Get
				Return Me.o_Oo._O_00000_..O.oOo.()
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..O_.oO_O0.(value)
			End Set
		End Property

		' Token: 0x1700140B RID: 5131
		' (get) Token: 0x06005475 RID: 21621 RVA: 0x0021F06E File Offset: 0x0021D26E
		' (set) Token: 0x06005476 RID: 21622 RVA: 0x0021F07B File Offset: 0x0021D27B
		Public Property DropDownHeight As Integer
			Get
				Return Me.o_Oo._O_00000_..O_o0o0_Oo.0.()
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..o.Oo0.(value)
			End Set
		End Property

		' Token: 0x1700140C RID: 5132
		' (get) Token: 0x06005477 RID: 21623 RVA: 0x0021F089 File Offset: 0x0021D289
		' (set) Token: 0x06005478 RID: 21624 RVA: 0x0021F096 File Offset: 0x0021D296
		Public Property MaxDropDownItems As Integer
			Get
				Return Me.o_Oo._O_00000_..o0Oo_.o_.()
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..o__0_OooO0._.(value)
			End Set
		End Property

		' Token: 0x1700140D RID: 5133
		' (get) Token: 0x06005479 RID: 21625 RVA: 0x0021F0A4 File Offset: 0x0021D2A4
		' (set) Token: 0x0600547A RID: 21626 RVA: 0x0021F128 File Offset: 0x0021D328
		<oO0oooo("0925")>
		Public Property ComboList As String
			Get
				Dim text As String = ""
				Try
					For Each value As Object In Me.o_Oo._O_00000_..O_o0o0_Oo.0.()
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
				Me.o_Oo._O_00000_..O_o0o0_Oo.0.().Clear()
				Me.o_Oo._O_00000_..o_0.__. = False
				If Operators.CompareString(value, "", True) > 0 Then
					Dim array As String() = value.Split(New Char() { vbLf, vbCr, "|"c }, StringSplitOptions.RemoveEmptyEntries)
					Me.o_Oo._O_00000_..O_o0o0_Oo.0.().AddRange(array)
					If Me.AutoComplete AndAlso Me.AllowEditValue Then
						Me.o_Oo._O_00000_..AutoCompleteSource = AutoCompleteSource.CustomSource
						Me.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.SuggestAppend
						Me.o_Oo._O_00000_..AutoCompleteCustomSource.Clear()
						Me.o_Oo._O_00000_..AutoCompleteCustomSource.AddRange(array)
					End If
				End If
			End Set
		End Property

		' Token: 0x1700140E RID: 5134
		' (get) Token: 0x0600547B RID: 21627 RVA: 0x0021F1D4 File Offset: 0x0021D3D4
		' (set) Token: 0x0600547C RID: 21628 RVA: 0x0021F1E1 File Offset: 0x0021D3E1
		<oO0oooo("0927")>
		Public Property DisplayMember As String
			Get
				Return Me.o_Oo._O_00000_..O_o0o0_Oo.0.()
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..o_O0.OO0o0O0o.(value)
			End Set
		End Property

		' Token: 0x1700140F RID: 5135
		' (get) Token: 0x0600547D RID: 21629 RVA: 0x0021F1EF File Offset: 0x0021D3EF
		' (set) Token: 0x0600547E RID: 21630 RVA: 0x0021F1FC File Offset: 0x0021D3FC
		<oO0oooo("0928")>
		Public Property ValueMember As String
			Get
				Return Me.o_Oo._O_00000_..Ooo_O__.0o.()
			End Get
			Set(value As String)
				If Me.o_Oo._O_00000_..OO0._0O.() IsNot Nothing Then
					Dim dataView As DataView = CType(Me.o_Oo._O_00000_..OO0._0O.(), DataView)
					If dataView.Table.Columns.Contains(value) Then
						dataView.Sort = value
					End If
				End If
				Me.o_Oo._O_00000_..O.__.(value)
			End Set
		End Property

		' Token: 0x17001410 RID: 5136
		' (get) Token: 0x0600547F RID: 21631 RVA: 0x0021F250 File Offset: 0x0021D450
		' (set) Token: 0x06005480 RID: 21632 RVA: 0x0021F290 File Offset: 0x0021D490
		<oO0oooo("0926")>
		Public Property DataSource As String
			Get
				Dim result As String
				If Me.o_Oo._O_00000_..OO0._0O.() IsNot Nothing Then
					result = CType(Me.o_Oo._O_00000_..OO0._0O.(), DataView).Table.TableName
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..o_0.__. = False
				If Operators.CompareString(value, "", True) > 0 AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value) Then
					Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(value)
					If Operators.CompareString(Me.ValueMember, "", True) = 0 OrElse Not dataTable.Columns.Contains(Me.ValueMember) Then
						Me.o_Oo._O_00000_..o_O0.OO0o0O0o.(Nothing)
					Else
						Dim a_ As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(value), Me.DataFilter, Me.ValueMember, DataViewRowState.CurrentRows)
						Me.o_Oo._O_00000_..o_O0.OO0o0O0o.(a_)
						If Me.AutoComplete AndAlso Me.AllowEditValue Then
							Me.o_Oo._O_00000_..AutoCompleteSource = AutoCompleteSource.CustomSource
							Me.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.SuggestAppend
							Me.o_Oo._O_00000_..o_0.__. = True
						End If
					End If
					Return
				End If
				Me.o_Oo._O_00000_..o_O0.OO0o0O0o.(Nothing)
			End Set
		End Property

		' Token: 0x17001411 RID: 5137
		' (get) Token: 0x06005481 RID: 21633 RVA: 0x0021F38C File Offset: 0x0021D58C
		' (set) Token: 0x06005482 RID: 21634 RVA: 0x0021F3C1 File Offset: 0x0021D5C1
		Public Property DataFilter As String
			Get
				Dim result As String
				If Me.o_Oo._O_00000_..OO0._0O.() IsNot Nothing Then
					result = CType(Me.o_Oo._O_00000_..OO0._0O.(), DataView).RowFilter
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.o_Oo._O_00000_..OO0._0O.() IsNot Nothing Then
					CType(Me.o_Oo._O_00000_..OO0._0O.(), DataView).RowFilter = value
				End If
			End Set
		End Property

		' Token: 0x17001412 RID: 5138
		' (get) Token: 0x06005483 RID: 21635 RVA: 0x0021F3E6 File Offset: 0x0021D5E6
		' (set) Token: 0x06005484 RID: 21636 RVA: 0x0021F3F5 File Offset: 0x0021D5F5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property DataSort As String
			Get
				Me.o_Oo._O_00000_..OO0._0O.()
				Return Nothing
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..OO0._0O.()
			End Set
		End Property

		' Token: 0x17001413 RID: 5139
		' (get) Token: 0x06005485 RID: 21637 RVA: 0x0021F403 File Offset: 0x0021D603
		' (set) Token: 0x06005486 RID: 21638 RVA: 0x0021F410 File Offset: 0x0021D610
		<oO0oooo("0946")>
		Public Property MultiColumn As Boolean
			Get
				Return Me.o_Oo._O_00000_..o0Oo_.o_.()
			End Get
			Set(value As Boolean)
				Me.o_Oo._O_00000_..O_.oOO00.(value)
			End Set
		End Property

		' Token: 0x17001414 RID: 5140
		' (get) Token: 0x06005487 RID: 21639 RVA: 0x0021F41E File Offset: 0x0021D61E
		' (set) Token: 0x06005488 RID: 21640 RVA: 0x0021F42B File Offset: 0x0021D62B
		<oO0oooo("0946")>
		Public Property ColumnWidth As Integer
			Get
				Return Me.o_Oo._O_00000_..o.ooO.()
			End Get
			Set(value As Integer)
				If value > 0 Then
					Me.o_Oo._O_00000_..o_O0.OO0o0O0o.(value)
				End If
			End Set
		End Property

		' Token: 0x17001415 RID: 5141
		' (get) Token: 0x06005489 RID: 21641 RVA: 0x0021F43D File Offset: 0x0021D63D
		' (set) Token: 0x0600548A RID: 21642 RVA: 0x0021F44A File Offset: 0x0021D64A
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.o_Oo._O_00000_..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.o_Oo._O_00000_..InitialSelection = value
			End Set
		End Property

		' Token: 0x17001416 RID: 5142
		' (get) Token: 0x0600548B RID: 21643 RVA: 0x0021F458 File Offset: 0x0021D658
		<oO0oooo("0934")>
		Public ReadOnly Property Items As ListBox.ObjectCollection
			Get
				Return Me.o_Oo._O_00000_..O_o0o0_Oo.0.()
			End Get
		End Property

		' Token: 0x17001417 RID: 5143
		' (get) Token: 0x0600548C RID: 21644 RVA: 0x0021F465 File Offset: 0x0021D665
		' (set) Token: 0x0600548D RID: 21645 RVA: 0x0021F472 File Offset: 0x0021D672
		<oO0oooo("0930")>
		Public Property SelectedIndex As Integer
			Get
				Return Me.o_Oo._O_00000_..Ooo_O__.0o.()
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..O_.oOO00.(value)
			End Set
		End Property

		' Token: 0x17001418 RID: 5144
		' (get) Token: 0x0600548E RID: 21646 RVA: 0x0021F480 File Offset: 0x0021D680
		' (set) Token: 0x0600548F RID: 21647 RVA: 0x0021F48D File Offset: 0x0021D68D
		<oO0oooo("0932")>
		Public Property SelectedItem As Object
			Get
				Return Me.o_Oo._O_00000_..Ooo_O__.0o.()
			End Get
			Set(value As Object)
				Me.o_Oo._O_00000_..o.OOoOo_00O.(RuntimeHelpers.GetObjectValue(value))
			End Set
		End Property

		' Token: 0x17001419 RID: 5145
		' (get) Token: 0x06005490 RID: 21648 RVA: 0x0021F4A0 File Offset: 0x0021D6A0
		' (set) Token: 0x06005491 RID: 21649 RVA: 0x0021F4AD File Offset: 0x0021D6AD
		<oO0oooo("0933")>
		Public Property SelectedValue As Object
			Get
				Return Me.o_Oo._O_00000_..O__oo_OO.O_.()
			End Get
			Set(value As Object)
				Me.o_Oo._O_00000_..o__0_OooO0._.(RuntimeHelpers.GetObjectValue(value))
			End Set
		End Property

		' Token: 0x1700141A RID: 5146
		' (get) Token: 0x06005492 RID: 21650 RVA: 0x0021F4C0 File Offset: 0x0021D6C0
		' (set) Token: 0x06005493 RID: 21651 RVA: 0x0021F4CD File Offset: 0x0021D6CD
		<oO0oooo("0740")>
		Public Property SelectedText As String
			Get
				Return Me.o_Oo._O_00000_..SelectedText
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..SelectedText = value
			End Set
		End Property

		' Token: 0x1700141B RID: 5147
		' (get) Token: 0x06005494 RID: 21652 RVA: 0x0021F4DB File Offset: 0x0021D6DB
		' (set) Token: 0x06005495 RID: 21653 RVA: 0x0021F4E8 File Offset: 0x0021D6E8
		Public Property SelectionStart As Integer
			Get
				Return Me.o_Oo._O_00000_..SelectionStart
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..SelectionStart = value
			End Set
		End Property

		' Token: 0x1700141C RID: 5148
		' (get) Token: 0x06005496 RID: 21654 RVA: 0x0021F4F6 File Offset: 0x0021D6F6
		' (set) Token: 0x06005497 RID: 21655 RVA: 0x0021F503 File Offset: 0x0021D703
		Public Property SelectionLength As Integer
			Get
				Return Me.o_Oo._O_00000_..SelectionLength
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..SelectionLength = value
			End Set
		End Property

		' Token: 0x06005498 RID: 21656 RVA: 0x0021F511 File Offset: 0x0021D711
		Public Sub SelectAll()
			Me.o_Oo._O_00000_..SelectAll()
		End Sub

		' Token: 0x06005499 RID: 21657 RVA: 0x0021F51E File Offset: 0x0021D71E
		Public Sub Copy()
			Me.o_Oo._O_00000_..Copy()
		End Sub

		' Token: 0x0600549A RID: 21658 RVA: 0x0021F52B File Offset: 0x0021D72B
		Public Sub Cut()
			Me.o_Oo._O_00000_..Cut()
		End Sub

		' Token: 0x0600549B RID: 21659 RVA: 0x0021F538 File Offset: 0x0021D738
		Public Sub Paste()
			Me.o_Oo._O_00000_..Paste()
		End Sub

		' Token: 0x0600549C RID: 21660 RVA: 0x0021F545 File Offset: 0x0021D745
		Public Sub Undo()
			Me.o_Oo._O_00000_..Undo()
		End Sub

		' Token: 0x0600549D RID: 21661 RVA: 0x0021F552 File Offset: 0x0021D752
		Public Sub ResetText()
			Me.o_Oo._O_00000_..ResetText()
		End Sub

		' Token: 0x0600549E RID: 21662 RVA: 0x0021F55F File Offset: 0x0021D75F
		Public Sub OpenDropDown()
			Me.o_Oo._O_00000_..OpenDropDown()
		End Sub

		' Token: 0x1700141D RID: 5149
		' (get) Token: 0x0600549F RID: 21663 RVA: 0x0021F56C File Offset: 0x0021D76C
		Public ReadOnly Property DroppedDown As Boolean
			Get
				Return Me.o_Oo._O_00000_..DroppedDown
			End Get
		End Property

		' Token: 0x060054A0 RID: 21664 RVA: 0x0021F579 File Offset: 0x0021D779
		Public Sub CloseDropDown()
			Me.o_Oo._O_00000_..CloseDropDown()
		End Sub

		' Token: 0x060054A1 RID: 21665 RVA: 0x0021F586 File Offset: 0x0021D786
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x1700141E RID: 5150
		' (get) Token: 0x060054A2 RID: 21666 RVA: 0x0021F58F File Offset: 0x0021D78F
		' (set) Token: 0x060054A3 RID: 21667 RVA: 0x0021F59C File Offset: 0x0021D79C
		Public Property ItemSpacing As Integer
			Get
				Return Me.o_Oo._O_00000_..oo_OO_oo.oO_.()
			End Get
			Set(value As Integer)
				Me.o_Oo._O_00000_..O_o0O.O_O.(value)
			End Set
		End Property

		' Token: 0x040021CE RID: 8654
		Private <<EMPTY_NAME>> As OoOO0Oo_oo0oO
	End Class
End Namespace
