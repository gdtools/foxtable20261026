Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000519 RID: 1305
	<ComVisible(True)>
	Public Class NumericComboBox
		Inherits Control
		Implements OoO_

		' Token: 0x0600556F RID: 21871 RVA: 0x00221254 File Offset: 0x0021F454
		Friend Sub New(A_0 As ooOOO)
			MyBase.New(A_0, ControlTypeEnum.NumericComboBox)
			Me.o.oO_oo_O. = A_0
		End Sub

		' Token: 0x17001478 RID: 5240
		' (get) Token: 0x06005570 RID: 21872 RVA: 0x00221265 File Offset: 0x0021F465
		' (set) Token: 0x06005571 RID: 21873 RVA: 0x00221272 File Offset: 0x0021F472
		Public Property Text As String
			Get
				Return Me.o.oO_oo_O..Text
			End Get
			Set(value As String)
				Me.o.oO_oo_O..Value = value
			End Set
		End Property

		' Token: 0x17001479 RID: 5241
		' (get) Token: 0x06005572 RID: 21874 RVA: 0x00221280 File Offset: 0x0021F480
		' (set) Token: 0x06005573 RID: 21875 RVA: 0x0022128D File Offset: 0x0021F48D
		Public Property Value As Object
			Get
				Return Me.o.oO_oo_O..Value
			End Get
			Set(value As Object)
				Me.o.oO_oo_O..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x1700147A RID: 5242
		' (get) Token: 0x06005574 RID: 21876 RVA: 0x002212A0 File Offset: 0x0021F4A0
		' (set) Token: 0x06005575 RID: 21877 RVA: 0x002212AD File Offset: 0x0021F4AD
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o.oO_oo_O..o00.Oo_OO0.()
			End Get
			Set(value As BooleanEnum)
				Me.o.oO_oo_O..o00.Oo_OO0.(value)
			End Set
		End Property

		' Token: 0x1700147B RID: 5243
		' (get) Token: 0x06005576 RID: 21878 RVA: 0x002212BB File Offset: 0x0021F4BB
		' (set) Token: 0x06005577 RID: 21879 RVA: 0x002212C4 File Offset: 0x0021F4C4
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o.oO_oo_O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.NumericComboBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o.oO_oo_O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							If binding IsNot Nothing Then
								Me.o.oO_oo_O..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x1700147C RID: 5244
		' (get) Token: 0x06005578 RID: 21880 RVA: 0x002213A0 File Offset: 0x0021F5A0
		' (set) Token: 0x06005579 RID: 21881 RVA: 0x002213AE File Offset: 0x0021F5AE
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x1700147D RID: 5245
		' (get) Token: 0x0600557A RID: 21882 RVA: 0x002213B0 File Offset: 0x0021F5B0
		' (set) Token: 0x0600557B RID: 21883 RVA: 0x002213BD File Offset: 0x0021F5BD
		<oO0oooo("1861")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o.oO_oo_O..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o.oO_oo_O..TextAlign = value
			End Set
		End Property

		' Token: 0x1700147E RID: 5246
		' (get) Token: 0x0600557C RID: 21884 RVA: 0x002213CB File Offset: 0x0021F5CB
		' (set) Token: 0x0600557D RID: 21885 RVA: 0x002213D8 File Offset: 0x0021F5D8
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o.oO_oo_O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o.oO_oo_O..BorderStyle = value
			End Set
		End Property

		' Token: 0x1700147F RID: 5247
		' (get) Token: 0x0600557E RID: 21886 RVA: 0x002213E6 File Offset: 0x0021F5E6
		' (set) Token: 0x0600557F RID: 21887 RVA: 0x002213F3 File Offset: 0x0021F5F3
		Public Property BorderColor As Color
			Get
				Return Me.o.oO_oo_O..BorderColor
			End Get
			Set(value As Color)
				Me.o.oO_oo_O..BorderColor = value
			End Set
		End Property

		' Token: 0x17001480 RID: 5248
		' (get) Token: 0x06005580 RID: 21888 RVA: 0x00221401 File Offset: 0x0021F601
		' (set) Token: 0x06005581 RID: 21889 RVA: 0x0022140E File Offset: 0x0021F60E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property PasswordChar As Char
			Get
				Return Me.o.oO_oo_O..PasswordChar
			End Get
			Set(value As Char)
				Me.o.oO_oo_O..PasswordChar = value
			End Set
		End Property

		' Token: 0x17001481 RID: 5249
		' (get) Token: 0x06005582 RID: 21890 RVA: 0x0022141C File Offset: 0x0021F61C
		' (set) Token: 0x06005583 RID: 21891 RVA: 0x00221430 File Offset: 0x0021F630
		<oO0oooo("1873")>
		Public Property FormatString As String
			Get
				Return Me.o.oO_oo_O..DisplayFormat.CustomFormat
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					value = Me.o.oO_oo_O.
				End If
				Me.o.oO_oo_O..DisplayFormat.CustomFormat = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o.oO_oo_O..DisplayFormat.FormatType = 2
					Return
				End If
				Me.o.oO_oo_O..DisplayFormat.FormatType = 0
			End Set
		End Property

		' Token: 0x17001482 RID: 5250
		' (get) Token: 0x06005584 RID: 21892 RVA: 0x00221496 File Offset: 0x0021F696
		' (set) Token: 0x06005585 RID: 21893 RVA: 0x002214A3 File Offset: 0x0021F6A3
		Public Property ShowUpDownButtons As Boolean
			Get
				Return Me.o.oO_oo_O..ShowUpDownButtons
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..ShowUpDownButtons = value
			End Set
		End Property

		' Token: 0x17001483 RID: 5251
		' (get) Token: 0x06005586 RID: 21894 RVA: 0x002214B1 File Offset: 0x0021F6B1
		' (set) Token: 0x06005587 RID: 21895 RVA: 0x002214BE File Offset: 0x0021F6BE
		Public Property ShowDropDownButton As Boolean
			Get
				Return Me.o.oO_oo_O..ShowDropDownButton
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..ShowDropDownButton = value
			End Set
		End Property

		' Token: 0x17001484 RID: 5252
		' (get) Token: 0x06005588 RID: 21896 RVA: 0x002214CC File Offset: 0x0021F6CC
		' (set) Token: 0x06005589 RID: 21897 RVA: 0x0022150A File Offset: 0x0021F70A
		Public Property Increment As Double
			Get
				Dim result As Double
				If Me.o.oO_oo_O..Increment IsNot Nothing Then
					result = CDbl(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.o.oO_oo_O..Increment)))
				Else
					result = 0.0
				End If
				Return result
			End Get
			Set(value As Double)
				Me.o.oO_oo_O..Increment = value
			End Set
		End Property

		' Token: 0x17001485 RID: 5253
		' (get) Token: 0x0600558A RID: 21898 RVA: 0x0022151D File Offset: 0x0021F71D
		' (set) Token: 0x0600558B RID: 21899 RVA: 0x0022152A File Offset: 0x0021F72A
		Public Overrides Property BackColor As Color
			Get
				Return Me.o.oO_oo_O..BackColor
			End Get
			Set(value As Color)
				Me.o.oO_oo_O..BackColor = value
			End Set
		End Property

		' Token: 0x17001486 RID: 5254
		' (get) Token: 0x0600558C RID: 21900 RVA: 0x00221538 File Offset: 0x0021F738
		' (set) Token: 0x0600558D RID: 21901 RVA: 0x00221545 File Offset: 0x0021F745
		Public Overrides Property ForeColor As Color
			Get
				Return Me.o.oO_oo_O..ForeColor
			End Get
			Set(value As Color)
				Me.o.oO_oo_O..ForeColor = value
				Me.o.oO_oo_O..NegativeForeColor = value
			End Set
		End Property

		' Token: 0x0600558E RID: 21902 RVA: 0x0022155F File Offset: 0x0021F75F
		Public Sub SelectAll()
			Me.o.oO_oo_O..SelectAll()
		End Sub

		' Token: 0x0600558F RID: 21903 RVA: 0x0022156C File Offset: 0x0021F76C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x04002208 RID: 8712
		Private <<EMPTY_NAME>> As ooOOO

		' Token: 0x04002209 RID: 8713
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
