Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000509 RID: 1289
	<ComVisible(True)>
	Public Class DateTimePicker
		Inherits Control
		Implements OoO_

		' Token: 0x060054A4 RID: 21668 RVA: 0x0021F5AA File Offset: 0x0021D7AA
		Friend Sub New(A_0 As O_0oOoOo)
			MyBase.New(A_0, ControlTypeEnum.DateTimePicker)
			Me.o.__O0O. = A_0
		End Sub

		' Token: 0x1700141F RID: 5151
		' (get) Token: 0x060054A5 RID: 21669 RVA: 0x0021F5BB File Offset: 0x0021D7BB
		' (set) Token: 0x060054A6 RID: 21670 RVA: 0x0021F5C8 File Offset: 0x0021D7C8
		Public Property Text As String
			Get
				Return Me.o.__O0O..Text
			End Get
			Set(value As String)
				Me.o.__O0O..Value = value
			End Set
		End Property

		' Token: 0x17001420 RID: 5152
		' (get) Token: 0x060054A7 RID: 21671 RVA: 0x0021F5D6 File Offset: 0x0021D7D6
		' (set) Token: 0x060054A8 RID: 21672 RVA: 0x0021F5E4 File Offset: 0x0021D7E4
		Public Property Value As Object
			Get
				Return Me.o.__O0O..Value
			End Get
			Set(value As Object)
				If value Is Nothing Then
					Me.o.__O0O..Value = Nothing
					Return
				End If
				If Operators.CompareString(value.ToString(), "0:00:00", True) = 0 Then
					Me.o.__O0O..Value = Nothing
					Return
				End If
				Me.o.__O0O..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17001421 RID: 5153
		' (get) Token: 0x060054A9 RID: 21673 RVA: 0x0021F632 File Offset: 0x0021D832
		' (set) Token: 0x060054AA RID: 21674 RVA: 0x0021F63F File Offset: 0x0021D83F
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o.__O0O..O0O.O0.()
			End Get
			Set(value As BooleanEnum)
				Me.o.__O0O..oO._0o_O__.(value)
			End Set
		End Property

		' Token: 0x17001422 RID: 5154
		' (get) Token: 0x060054AB RID: 21675 RVA: 0x0021F64D File Offset: 0x0021D84D
		' (set) Token: 0x060054AC RID: 21676 RVA: 0x0021F658 File Offset: 0x0021D858
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o.__O0O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.DateTimePicker, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o.__O0O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							If binding IsNot Nothing Then
								Me.o.__O0O..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17001423 RID: 5155
		' (get) Token: 0x060054AD RID: 21677 RVA: 0x0021F734 File Offset: 0x0021D934
		' (set) Token: 0x060054AE RID: 21678 RVA: 0x0021F742 File Offset: 0x0021D942
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x17001424 RID: 5156
		' (get) Token: 0x060054AF RID: 21679 RVA: 0x0021F744 File Offset: 0x0021D944
		' (set) Token: 0x060054B0 RID: 21680 RVA: 0x0021F751 File Offset: 0x0021D951
		<oO0oooo("2033")>
		Public Property DateTimeFormat As DateTimeFormatEnum
			Get
				Return Me.o.__O0O..O0O.O0.()
			End Get
			Set(value As DateTimeFormatEnum)
				Me.o.__O0O..O0O.O0.(value)
			End Set
		End Property

		' Token: 0x17001425 RID: 5157
		' (get) Token: 0x060054B1 RID: 21681 RVA: 0x0021F75F File Offset: 0x0021D95F
		' (set) Token: 0x060054B2 RID: 21682 RVA: 0x0021F76C File Offset: 0x0021D96C
		<oO0oooo("1861")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o.__O0O..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o.__O0O..TextAlign = value
			End Set
		End Property

		' Token: 0x17001426 RID: 5158
		' (get) Token: 0x060054B3 RID: 21683 RVA: 0x0021F77A File Offset: 0x0021D97A
		' (set) Token: 0x060054B4 RID: 21684 RVA: 0x0021F787 File Offset: 0x0021D987
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o.__O0O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o.__O0O..BorderStyle = value
			End Set
		End Property

		' Token: 0x17001427 RID: 5159
		' (get) Token: 0x060054B5 RID: 21685 RVA: 0x0021F795 File Offset: 0x0021D995
		' (set) Token: 0x060054B6 RID: 21686 RVA: 0x0021F7A2 File Offset: 0x0021D9A2
		Public Property BorderColor As Color
			Get
				Return Me.o.__O0O..BorderColor
			End Get
			Set(value As Color)
				Me.o.__O0O..BorderColor = value
			End Set
		End Property

		' Token: 0x17001428 RID: 5160
		' (get) Token: 0x060054B7 RID: 21687 RVA: 0x0021F7B0 File Offset: 0x0021D9B0
		' (set) Token: 0x060054B8 RID: 21688 RVA: 0x0021F7BD File Offset: 0x0021D9BD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property PasswordChar As Char
			Get
				Return Me.o.__O0O..PasswordChar
			End Get
			Set(value As Char)
				Me.o.__O0O..PasswordChar = value
			End Set
		End Property

		' Token: 0x17001429 RID: 5161
		' (get) Token: 0x060054B9 RID: 21689 RVA: 0x0021F7CB File Offset: 0x0021D9CB
		' (set) Token: 0x060054BA RID: 21690 RVA: 0x0021F7D8 File Offset: 0x0021D9D8
		Public Property ShowWeekNumbers As Boolean
			Get
				Return Me.o.__O0O..O0O.O0.()
			End Get
			Set(value As Boolean)
				Me.o.__O0O..oo0_O_Ooo._.(value)
			End Set
		End Property

		' Token: 0x1700142A RID: 5162
		' (get) Token: 0x060054BB RID: 21691 RVA: 0x0021F7E6 File Offset: 0x0021D9E6
		' (set) Token: 0x060054BC RID: 21692 RVA: 0x0021F7F3 File Offset: 0x0021D9F3
		Public Property ShowDropDownButton As Boolean
			Get
				Return Me.o.__O0O..ShowDropDownButton
			End Get
			Set(value As Boolean)
				Me.o.__O0O..ShowDropDownButton = value
			End Set
		End Property

		' Token: 0x1700142B RID: 5163
		' (get) Token: 0x060054BD RID: 21693 RVA: 0x0021F801 File Offset: 0x0021DA01
		' (set) Token: 0x060054BE RID: 21694 RVA: 0x0021F80E File Offset: 0x0021DA0E
		Public Property CalendarDimensions As Size
			Get
				Return Me.o.__O0O..O.o0O_.()
			End Get
			Set(value As Size)
				Me.o.__O0O..O0O.O0.(value)
			End Set
		End Property

		' Token: 0x1700142C RID: 5164
		' (get) Token: 0x060054BF RID: 21695 RVA: 0x0021F81C File Offset: 0x0021DA1C
		' (set) Token: 0x060054C0 RID: 21696 RVA: 0x0021F829 File Offset: 0x0021DA29
		Public Overrides Property BackColor As Color
			Get
				Return Me.o.__O0O..BackColor
			End Get
			Set(value As Color)
				Me.o.__O0O..BackColor = value
			End Set
		End Property

		' Token: 0x1700142D RID: 5165
		' (get) Token: 0x060054C1 RID: 21697 RVA: 0x0021F837 File Offset: 0x0021DA37
		' (set) Token: 0x060054C2 RID: 21698 RVA: 0x0021F844 File Offset: 0x0021DA44
		Public Overrides Property ForeColor As Color
			Get
				Return Me.o.__O0O..ForeColor
			End Get
			Set(value As Color)
				Me.o.__O0O..ForeColor = value
			End Set
		End Property

		' Token: 0x060054C3 RID: 21699 RVA: 0x0021F852 File Offset: 0x0021DA52
		Public Sub SelectAll()
			Me.o.__O0O..SelectAll()
		End Sub

		' Token: 0x060054C4 RID: 21700 RVA: 0x0021F85F File Offset: 0x0021DA5F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021CF RID: 8655
		Private <<EMPTY_NAME>> As O_0oOoOo
	End Class
End Namespace
