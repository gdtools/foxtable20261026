Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000504 RID: 1284
	<ComVisible(True)>
	Public Class CheckBox
		Inherits Control
		Implements OoO_

		' Token: 0x060053A4 RID: 21412 RVA: 0x0021DA0E File Offset: 0x0021BC0E
		Friend Sub New(A_0 As CustomCheckBox)
			MyBase.New(A_0, ControlTypeEnum.CheckBox)
			Me.o0.00O. = A_0
		End Sub

		' Token: 0x170013A9 RID: 5033
		' (get) Token: 0x060053A5 RID: 21413 RVA: 0x0021DA1F File Offset: 0x0021BC1F
		' (set) Token: 0x060053A6 RID: 21414 RVA: 0x0021DA28 File Offset: 0x0021BC28
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
					If ooO_0O.o_O0.O_.(ControlTypeEnum.CheckBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o0.00O..DataBindings.Add("Checked", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Checked", value)
							If binding IsNot Nothing Then
								Me.o0.00O..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170013AA RID: 5034
		' (get) Token: 0x060053A7 RID: 21415 RVA: 0x0021DAFD File Offset: 0x0021BCFD
		' (set) Token: 0x060053A8 RID: 21416 RVA: 0x0021DB0A File Offset: 0x0021BD0A
		Public Property Text As String
			Get
				Return Me.o0.00O..Text
			End Get
			Set(value As String)
				Me.o0.00O..Text = value
			End Set
		End Property

		' Token: 0x170013AB RID: 5035
		' (get) Token: 0x060053A9 RID: 21417 RVA: 0x0021DB18 File Offset: 0x0021BD18
		' (set) Token: 0x060053AA RID: 21418 RVA: 0x0021DB25 File Offset: 0x0021BD25
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o0.00O..[ReadOnly]
			End Get
			Set(value As BooleanEnum)
				Me.o0.00O..[ReadOnly] = value
			End Set
		End Property

		' Token: 0x170013AC RID: 5036
		' (get) Token: 0x060053AB RID: 21419 RVA: 0x0021DB33 File Offset: 0x0021BD33
		' (set) Token: 0x060053AC RID: 21420 RVA: 0x0021DB40 File Offset: 0x0021BD40
		<oO0oooo("1882")>
		Public Property Appearance As Appearance
			Get
				Return Me.o0.00O..Appearance
			End Get
			Set(value As Appearance)
				Me.o0.00O..Appearance = value
			End Set
		End Property

		' Token: 0x170013AD RID: 5037
		' (get) Token: 0x060053AD RID: 21421 RVA: 0x0021DB4E File Offset: 0x0021BD4E
		' (set) Token: 0x060053AE RID: 21422 RVA: 0x0021DB60 File Offset: 0x0021BD60
		<oO0oooo("0777")>
		Public Property Checked As Boolean
			Get
				Return Conversions.ToBoolean(Me.o0.00O..Checked)
			End Get
			Set(value As Boolean)
				Me.o0.00O..Checked = value
			End Set
		End Property

		' Token: 0x170013AE RID: 5038
		' (get) Token: 0x060053AF RID: 21423 RVA: 0x0021DB73 File Offset: 0x0021BD73
		' (set) Token: 0x060053B0 RID: 21424 RVA: 0x0021DB80 File Offset: 0x0021BD80
		Public Property VisualStyle As VisualStyle
			Get
				Return Me.o0.00O..VisualStyleBaseStyle
			End Get
			Set(value As VisualStyle)
				Me.o0.00O..VisualStyle = value
				Me.o0.00O..VisualStyleBaseStyle = value
			End Set
		End Property

		' Token: 0x170013AF RID: 5039
		' (get) Token: 0x060053B1 RID: 21425 RVA: 0x0021DB9A File Offset: 0x0021BD9A
		' (set) Token: 0x060053B2 RID: 21426 RVA: 0x0021DBA7 File Offset: 0x0021BDA7
		<oO0oooo("1878")>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.o0.00O..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.o0.00O..TextAlign = value
			End Set
		End Property

		' Token: 0x170013B0 RID: 5040
		' (get) Token: 0x060053B3 RID: 21427 RVA: 0x0021DBB5 File Offset: 0x0021BDB5
		' (set) Token: 0x060053B4 RID: 21428 RVA: 0x0021DBC2 File Offset: 0x0021BDC2
		<oO0oooo("1879")>
		Public Property CheckAlign As ContentAlignment
			Get
				Return Me.o0.00O..CheckAlign
			End Get
			Set(value As ContentAlignment)
				Me.o0.00O..CheckAlign = value
			End Set
		End Property

		' Token: 0x170013B1 RID: 5041
		' (get) Token: 0x060053B5 RID: 21429 RVA: 0x0021DBD0 File Offset: 0x0021BDD0
		' (set) Token: 0x060053B6 RID: 21430 RVA: 0x0021DBD3 File Offset: 0x0021BDD3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ImageFile As String
			Get
				Return Nothing
			End Get
			Set(value As String)
				Me.o0.00O..Image = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x170013B2 RID: 5042
		' (get) Token: 0x060053B7 RID: 21431 RVA: 0x0021DBE6 File Offset: 0x0021BDE6
		' (set) Token: 0x060053B8 RID: 21432 RVA: 0x0021DBF3 File Offset: 0x0021BDF3
		<oO0oooo("1880")>
		Public Property ImageAlign As ContentAlignment
			Get
				Return Me.o0.00O..ImageAlign
			End Get
			Set(value As ContentAlignment)
				Me.o0.00O..ImageAlign = value
			End Set
		End Property

		' Token: 0x170013B3 RID: 5043
		' (get) Token: 0x060053B9 RID: 21433 RVA: 0x0021DC01 File Offset: 0x0021BE01
		' (set) Token: 0x060053BA RID: 21434 RVA: 0x0021DC0E File Offset: 0x0021BE0E
		<oO0oooo("1881")>
		Public Property TextImageRelation As TextImageRelation
			Get
				Return Me.o0.00O..TextImageRelation
			End Get
			Set(value As TextImageRelation)
				Me.o0.00O..TextImageRelation = value
			End Set
		End Property

		' Token: 0x170013B4 RID: 5044
		' (get) Token: 0x060053BB RID: 21435 RVA: 0x0021DC1C File Offset: 0x0021BE1C
		' (set) Token: 0x060053BC RID: 21436 RVA: 0x0021DC29 File Offset: 0x0021BE29
		<oO0oooo("0780")>
		Public Property Image As Image
			Get
				Return Me.o0.00O..Image
			End Get
			Set(value As Image)
				Me.o0.00O..Image = value
			End Set
		End Property

		' Token: 0x060053BD RID: 21437 RVA: 0x0021DC37 File Offset: 0x0021BE37
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021CA RID: 8650
		Private <<EMPTY_NAME>> As CustomCheckBox
	End Class
End Namespace
